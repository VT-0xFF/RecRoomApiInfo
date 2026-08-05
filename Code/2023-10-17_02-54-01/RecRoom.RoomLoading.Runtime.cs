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
		[Cpp2IlInjected.Address(RVA = "0x78CB70", Offset = "0x78B370", VA = "0x18078CB70")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x625C510", Offset = "0x625AD10", VA = "0x18625C510")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78D440", Offset = "0x78BC40", VA = "0x18078D440")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x78D480", Offset = "0x78BC80", VA = "0x18078D480")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BBJCAIBBAAG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6245D00", Offset = "0x6244500", VA = "0x186245D00")]
	public BBJCAIBBAAG(string BKGEBGGPBLH, Exception MKHOFBPNAEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class FGHNEAGOBEE : KHEGFLHGIMC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct FIMBMEHGOEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<MLEOJECBJGH>> <>t__builder;

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
		private TaskAwaiter<GPBCECGBNEN<MLEOJECBJGH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x624A9D0", Offset = "0x62491D0", VA = "0x18624A9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x624AC10", Offset = "0x6249410", VA = "0x18624AC10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct DLHNDBDLKEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<HNHCHBECMGB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<HNHCHBECMGB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6247E80", Offset = "0x6246680", VA = "0x186247E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6248090", Offset = "0x6246890", VA = "0x186248090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	[UnityEngine.Scripting.Preserve]
	public FGHNEAGOBEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x624A7A0", Offset = "0x6248FA0", VA = "0x18624A7A0", Slot = "4")]
	[AsyncStateMachine(typeof(FIMBMEHGOEG))]
	public Task<IReadOnlyList<MLEOJECBJGH>> BLHOJGHACCP(long NBNJFKJOFIF, long HEOAHEPJHCF, [Optional] CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x624A8C0", Offset = "0x62490C0", VA = "0x18624A8C0", Slot = "5")]
	[AsyncStateMachine(typeof(DLHNDBDLKEH))]
	public Task<IReadOnlyList<HNHCHBECMGB>> DFNLPDAMBDE(IReadOnlyList<int> NKPELIGKBLO, [Optional] CancellationToken EHCFBFBFEDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BCHKNNLLDJH : IEquatable<BCHKNNLLDJH>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int BJFPALPJMPG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	HNHCHBECMGB HEJAHAKFMGB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime MMKLKNALPPB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	HBOILNIPHBB? MGGNFANAHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	DMMPDBNPJOL? DCBOCOMFBNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	FKBELPADBGF OCJPJOODOCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<ANOEFAFFECF> OCLCGNJKJHN();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum FKBELPADBGF
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KHEGFLHGIMC
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<MLEOJECBJGH>> BLHOJGHACCP(long NBNJFKJOFIF, long HEOAHEPJHCF, [Optional] CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<HNHCHBECMGB>> DFNLPDAMBDE(IReadOnlyList<int> NKPELIGKBLO, [Optional] CancellationToken EHCFBFBFEDH);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ANKHPCEMLDJ
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class DFMHJPMMEPJ : BCHKNNLLDJH, IEquatable<BCHKNNLLDJH>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct BKKKEIBFBHK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<ANOEFAFFECF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public DFMHJPMMEPJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private MFKHKKIKBKD <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<MEGCEJKCLCC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<ANOEFAFFECF> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6246020", Offset = "0x6244820", VA = "0x186246020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x62464C0", Offset = "0x6244CC0", VA = "0x1862464C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly MLEOJECBJGH LEJEFIEIJIN;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int BJFPALPJMPG
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x768D90", Offset = "0x767590", VA = "0x180768D90", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public HNHCHBECMGB HEJAHAKFMGB
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x766110", Offset = "0x764910", VA = "0x180766110", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime MAMIPALIOOD
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8D4600", Offset = "0x8D2E00", VA = "0x1808D4600", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HBOILNIPHBB? MGGNFANAHGE
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x17A8C50", Offset = "0x17A7450", VA = "0x1817A8C50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public DMMPDBNPJOL? DCBOCOMFBNK
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x1F5DB90", Offset = "0x1F5C390", VA = "0x181F5DB90", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public FKBELPADBGF OCJPJOODOCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7E1100", Offset = "0x7DF900", VA = "0x1807E1100", Slot = "10")]
			get
			{
				return default(FKBELPADBGF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6247D20", Offset = "0x6246520", VA = "0x186247D20", Slot = "9")]
		[AsyncStateMachine(typeof(BKKKEIBFBHK))]
		public Task<ANOEFAFFECF> OCLCGNJKJHN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6247E20", Offset = "0x6246620", VA = "0x186247E20")]
		public DFMHJPMMEPJ(int PEJOEFHOKPM, HNHCHBECMGB BMLLMKKHLAF, MLEOJECBJGH LEJEFIEIJIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6247BD0", Offset = "0x62463D0", VA = "0x186247BD0", Slot = "11")]
		public bool Equals(BCHKNNLLDJH IFHFGCDLDEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6247B30", Offset = "0x6246330", VA = "0x186247B30", Slot = "0")]
		public override bool Equals(object CBBCDNDPNHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6247CE0", Offset = "0x62464E0", VA = "0x186247CE0")]
		private bool NIHEHAANBOE(DFMHJPMMEPJ IFHFGCDLDEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6247C60", Offset = "0x6246460", VA = "0x186247C60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class GEAMFIHJHLB : BCHKNNLLDJH, IEquatable<BCHKNNLLDJH>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct OAOGKJCFHON : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<ANOEFAFFECF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public GEAMFIHJHLB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<ANOEFAFFECF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x625C590", Offset = "0x625AD90", VA = "0x18625C590", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x625C7C0", Offset = "0x625AFC0", VA = "0x18625C7C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly OBLPPCHKGBB PKDPNCFLBNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HBOILNIPHBB KNMAMPEDAAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly DMMPDBNPJOL BHIFAEOCMHD;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int BJFPALPJMPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x624DF30", Offset = "0x624C730", VA = "0x18624DF30", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public HNHCHBECMGB HEJAHAKFMGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x624DA90", Offset = "0x624C290", VA = "0x18624DA90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime MAMIPALIOOD
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x624DC70", Offset = "0x624C470", VA = "0x18624DC70", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public HBOILNIPHBB? MGGNFANAHGE
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x624DEE0", Offset = "0x624C6E0", VA = "0x18624DEE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public DMMPDBNPJOL? DCBOCOMFBNK
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x624DD40", Offset = "0x624C540", VA = "0x18624DD40", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public FKBELPADBGF OCJPJOODOCB
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7D0D80", Offset = "0x7CF580", VA = "0x1807D0D80", Slot = "10")]
			get
			{
				return default(FKBELPADBGF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xD34480", Offset = "0xD32C80", VA = "0x180D34480")]
		public GEAMFIHJHLB(OBLPPCHKGBB CHBGJFKEEJF, HBOILNIPHBB LKCPHJIGJFC, DMMPDBNPJOL OKJNIFAFIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x624DDF0", Offset = "0x624C5F0", VA = "0x18624DDF0", Slot = "9")]
		[AsyncStateMachine(typeof(OAOGKJCFHON))]
		public Task<ANOEFAFFECF> OCLCGNJKJHN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x624DBD0", Offset = "0x624C3D0", VA = "0x18624DBD0", Slot = "11")]
		public bool Equals(BCHKNNLLDJH IFHFGCDLDEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x624DB20", Offset = "0x624C320", VA = "0x18624DB20", Slot = "0")]
		public override bool Equals(object CBBCDNDPNHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x624DD90", Offset = "0x624C590", VA = "0x18624DD90")]
		private bool NIHEHAANBOE(GEAMFIHJHLB IFHFGCDLDEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x624DCC0", Offset = "0x624C4C0", VA = "0x18624DCC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class PKHLMDKAGNG : BCHKNNLLDJH, IEquatable<BCHKNNLLDJH>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct BCPPOHNPLMK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<ANOEFAFFECF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<ANOEFAFFECF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6245D70", Offset = "0x6244570", VA = "0x186245D70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6245FB0", Offset = "0x62447B0", VA = "0x186245FB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly HNHCHBECMGB KNNADFMKAIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly HBOILNIPHBB KNMAMPEDAAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly DMMPDBNPJOL BHIFAEOCMHD;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int BJFPALPJMPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x62626E0", Offset = "0x6260EE0", VA = "0x1862626E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public HNHCHBECMGB HEJAHAKFMGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime MAMIPALIOOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x764500", Offset = "0x762D00", VA = "0x180764500", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public HBOILNIPHBB? MGGNFANAHGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6262690", Offset = "0x6260E90", VA = "0x186262690", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public DMMPDBNPJOL? DCBOCOMFBNK
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6262440", Offset = "0x6260C40", VA = "0x186262440", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public FKBELPADBGF OCJPJOODOCB
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x764500", Offset = "0x762D00", VA = "0x180764500", Slot = "10")]
			get
			{
				return default(FKBELPADBGF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xD34480", Offset = "0xD32C80", VA = "0x180D34480")]
		public PKHLMDKAGNG(HNHCHBECMGB BMLLMKKHLAF, HBOILNIPHBB LKCPHJIGJFC, DMMPDBNPJOL OKJNIFAFIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x62625C0", Offset = "0x6260DC0", VA = "0x1862625C0", Slot = "9")]
		[AsyncStateMachine(typeof(BCPPOHNPLMK))]
		public Task<ANOEFAFFECF> OCLCGNJKJHN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6262320", Offset = "0x6260B20", VA = "0x186262320", Slot = "11")]
		public bool Equals(BCHKNNLLDJH IFHFGCDLDEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x62622A0", Offset = "0x6260AA0", VA = "0x1862622A0", Slot = "0")]
		public override bool Equals(object CBBCDNDPNHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6262390", Offset = "0x6260B90", VA = "0x186262390", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6262490", Offset = "0x6260C90", VA = "0x186262490")]
		private bool NIHEHAANBOE(PKHLMDKAGNG IFHFGCDLDEA)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct PPODMFLEMBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<BCHKNNLLDJH>> <>t__builder;

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
		public ANKHPCEMLDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<MLEOJECBJGH> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<MLEOJECBJGH>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, HNHCHBECMGB account, MLEOJECBJGH roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6262760", Offset = "0x6260F60", VA = "0x186262760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6263540", Offset = "0x6261D40", VA = "0x186263540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct IGHHKBGCNBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, HNHCHBECMGB account, MLEOJECBJGH roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<MLEOJECBJGH> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public ANKHPCEMLDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<HNHCHBECMGB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x624F5F0", Offset = "0x624DDF0", VA = "0x18624F5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6250030", Offset = "0x624E830", VA = "0x186250030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly FLCJKBHBBGP ELFNODDDJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly KHEGFLHGIMC MJLAHMCGHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly NLICGHANJFP AEABFNMABIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly ANNKFHDNJKL<(long, long), IReadOnlyList<MLEOJECBJGH>> BBGDGOPAHHK;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6245BD0", Offset = "0x62443D0", VA = "0x186245BD0")]
	[UnityEngine.Scripting.Preserve]
	public ANKHPCEMLDJ([KEKICHOEFEB(null)] KHEGFLHGIMC KAFLAHIOKFF, [KEKICHOEFEB(null)] NLICGHANJFP GLIKKDAIIKM, [KEKICHOEFEB(null)] FLCJKBHBBGP HGEANONGIPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6245A80", Offset = "0x6244280", VA = "0x186245A80")]
	[AsyncStateMachine(typeof(PPODMFLEMBA))]
	public Task<IList<BCHKNNLLDJH>> PJKLLMIHNEK(long NBNJFKJOFIF, long OMOMGBJOLII, bool HOHGCFMLDPP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x62457D0", Offset = "0x6243FD0", VA = "0x1862457D0")]
	private bool HHFHANDCOLD(DateTime? GLJDOHKPIJM, long NBNJFKJOFIF, long OMOMGBJOLII, [Out] OBLPPCHKGBB JLIKKAGDNAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6245970", Offset = "0x6244170", VA = "0x186245970")]
	[AsyncStateMachine(typeof(IGHHKBGCNBO))]
	private Task<IReadOnlyList<(int, HNHCHBECMGB, MLEOJECBJGH)>> NLPMIJIMKGB(IReadOnlyList<MLEOJECBJGH> KAMPPNKEGJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface NLICGHANJFP
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<OBLPPCHKGBB> PEHEEDKPLFI;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GINDFGBNLHP(long NBNJFKJOFIF, long OMOMGBJOLII, KKLDNOOFJJJ BDCAKKAGLOE, GGAEDDPGPFL FCJBDNMKKLN);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DNHANGOICHI(long NBNJFKJOFIF, long OMOMGBJOLII, [Out] OBLPPCHKGBB JLIKKAGDNAN);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IBCLJNHOKKF(long NBNJFKJOFIF, long OMOMGBJOLII, GGAEDDPGPFL FCJBDNMKKLN, [Out] OBLPPCHKGBB JLIKKAGDNAN);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KFALHBFDMEO(long NBNJFKJOFIF, long OMOMGBJOLII);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface PMOEIHKACBO : DMCCOCJCFNK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool DMNEOHNKDME
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task GJKAPMKOJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FFGBBGNBMFJ(Task AKGEHPDFIAE, string IOGLHMCCCPL);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface IDEOMGMIEJK : DMCCOCJCFNK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ANOEFAFFECF> KEALACGNDGO(OBLPPCHKGBB JLIKKAGDNAN);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NLEJMNIPDLK(CancellationToken EHCFBFBFEDH);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface NHOAIGNOOHK : DMCCOCJCFNK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	FBKGNJKHOII FJBLAJAEKML
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MBKJAFDGNGF();

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BJIHJCODOAG();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface DMCCOCJCFNK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GLJEDCMMNGN(HKHECNIPIOJ LOJMHJJKLIJ);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface JPCCDPCHOFD
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan KAKNNOAMMMD
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan PLEBKBDOJJO
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan KBKLKEBEKIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan NBBJKIHOKJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool FHAJLJJINMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool ADGFOBBMEBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool CFOFBKNGFJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int POLDOFGFCHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool KPLOCLMJJKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum MPFEDOHPEPI
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum IOBHDNMDIFB
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
public struct DEDIDPIECAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long ADKNLFICAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long HEOAHEPJHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly MPFEDOHPEPI GFGNPBCFEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception LOHFDJEPMBD;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6247AC0", Offset = "0x62462C0", VA = "0x186247AC0")]
	public DEDIDPIECAL(long ADKNLFICAMB, long HEOAHEPJHCF, MPFEDOHPEPI GFGNPBCFEMC, [CanBeNull] Exception LOHFDJEPMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6247A70", Offset = "0x6246270", VA = "0x186247A70")]
	public static DEDIDPIECAL GEJJKAGDKLH(FAPHDJICDBI FKILDDJFBMH, MPFEDOHPEPI GFGNPBCFEMC, [Optional] Exception LOHFDJEPMBD)
	{
		return default(DEDIDPIECAL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public delegate void NFOALEJPCOM(DEDIDPIECAL DOLBAIIOHMI);
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal interface PFHBEMNNDIC : DMCCOCJCFNK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action JADGPKGJLBG;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event NFOALEJPCOM EMNIKOOIMGN;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event NFOALEJPCOM GPEJAFMANOJ;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event NFOALEJPCOM IOFNLAFGIBF;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<IOBHDNMDIFB, bool> NGEAOOMNHBB;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NMMNJPECCOF();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void AJOOPIEIHFE(DEDIDPIECAL DOLBAIIOHMI);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JHLHACKNDHD(DEDIDPIECAL DOLBAIIOHMI);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void IDNKNOAPDHG(DEDIDPIECAL DOLBAIIOHMI);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AOPODNJGMAL(IOBHDNMDIFB AMKPPIJBFNG, bool MJOMMNNHKHB);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface HKDPKLIFIKK : DMCCOCJCFNK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ANHCBANIHOE();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PCJHDMPIGGD();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface AJGGJOEDFAM : DMCCOCJCFNK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	TaskStatus DMFNDAKJOAG
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CPGMNMIPNMJ(FAPHDJICDBI CAPMGFOKDKN, AKCDAENEHEC PIAMKFGNOIH, CancellationToken DINCIKDPHMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal static class HIFLJOEMJGE
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x624F1F0", Offset = "0x624D9F0", VA = "0x18624F1F0")]
	public static bool FECCGECJKEI(this AJGGJOEDFAM MGDHDGAHABJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public delegate Task IBMNOJHFFNF(EGEMJBICGKC KAGMDCLCJHI, CancellationToken KIAKEGJPMAL);
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface GPGGGCMILBN : DMCCOCJCFNK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PPFOAPLBGFO(IBMNOJHFFNF GDFIGPGPEFI);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface HKHECNIPIOJ : MFKHKKIKBKD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	CancellationToken FGODELEOMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	LLKIHBKOOLA PFCFLKDONAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	EMCLNBMIAFK FDJBNEIPECE
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	HEEPHCNKAAB KPFELNOLEME
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	NHDKLDFMNOK JAIBLGKGHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	ADMCHBMLFLK ODFAHIOEKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	FILLDCCIKAF FCIMGCIKHPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	DHBGMDMHDLN LMCAPLLGCNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	JGMGPMLOKAC EBBMFLBCAEI
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	PMOEIHKACBO FFDLODMMOGH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	IDEOMGMIEJK MKAMLPJPHCG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	PFHBEMNNDIC DKOBHODIDDC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	HKDPKLIFIKK PENOFKLKBNB
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	AJGGJOEDFAM INOGIKPEAPP
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	GPGGGCMILBN LHONJJOKIIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	OLFBMLBGCAP IDOCKAHODIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	EILOFBEIBKF AMJNPNLPAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	PABNMGIMAJM GDBGNDFDBGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	IKCOGABLLKF JFOGJFEGDLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	ALBKEKEEMGG FIHLENCOKCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	GJEGGLJCIKF HCKJLFFKBJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	NACFABKEACP LLEJJJBLAHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	MNHBODFFBLI KOAEIBGBHGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	KCAGEKHHKPM OLAHHCCHNNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	HEBNOFFIONN EJDPHHCFGLH
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	NHOAIGNOOHK NNCNEKKLODG
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	JPCCDPCHOFD LIJNMPABDDM
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	HACCBOPPNMD CACBBBIGNNA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	NLICGHANJFP NAILPHGIJPF
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	CPKEAHBNHDJ NDDEPJPIMGD
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	PBJDCDGMCIN LNJNAECLMKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void IHICOJAGEOA(AKCDAENEHEC OICAIDHKNJK);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface OLFBMLBGCAP : DMCCOCJCFNK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KDGDHFBEFOP BONJGFNEKBE(Guid BACFDICONIG);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PJFBCFIPABD(Guid BACFDICONIG);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FDBNEELDOFI(Guid BACFDICONIG, Task FJNDBCBLLJI);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GPJPLDGJKBA(Guid BACFDICONIG, ANOEFAFFECF GMLIOHDNDEG);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(ANOEFAFFECF, Task)> HFAGLILCHLO(Guid BACFDICONIG);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface OMMFIKHIIFB : DMCCOCJCFNK, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface EILOFBEIBKF : DMCCOCJCFNK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LDJCHAPMBDC(GEAEOIJPPME BKGEBGGPBLH);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HLFCDIDJLFH(GEAEOIJPPME BKGEBGGPBLH);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<JNPLDNDBBJJ> BNDKHEIBEGD(CancellationToken EGFKINNLJCB);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface PABNMGIMAJM : DMCCOCJCFNK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KDGDHFBEFOP KGADHKNGLMK(GEAEOIJPPME LHCIAHEJGAA);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OPIGAJJPFHA(Guid BACFDICONIG, Task FJNDBCBLLJI);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface IKCOGABLLKF : DMCCOCJCFNK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ANOEFAFFECF> JFOGJFEGDLC(GEAEOIJPPME COLIIFENAOI);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface ALBKEKEEMGG : DMCCOCJCFNK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MNHIEHBCOOD> NKNPFAIOBDK(ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, FAPHDJICDBI CAPMGFOKDKN, CancellationToken EHCFBFBFEDH);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface NACFABKEACP : DMCCOCJCFNK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ANOEFAFFECF EEMHBLAIDME(JLNLBCDKCMG KGHDFCJAHGF);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JAILGAFHGPH(string EPIKKECCKMG);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface GJEGGLJCIKF : DMCCOCJCFNK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GEAEOIJPPME> FGGBLMOJOAM(GEAEOIJPPME LJEEHJLDFLC, EBEIOKMCHFG LLNAJFDAEHL, CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<GEAEOIJPPME> KEIDICNHCKO(CancellationToken EHCFBFBFEDH, EBEIOKMCHFG LLNAJFDAEHL);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MNLGPGKPHPA MFGEEHJCLEC(OFOHOILEKAB BNDODLKMLLH, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MNLGPGKPHPA APANCFGMMGP(OFOHOILEKAB BNDODLKMLLH, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface MNHBODFFBLI : DMCCOCJCFNK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ANOEFAFFECF MBMNFCJJKMP(JLNLBCDKCMG KGHDFCJAHGF, JNPLDNDBBJJ LILDKJDGMDE);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ANOEFAFFECF EICJHNDJCOP(JLNLBCDKCMG MLBPFKHFGPG);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface KCAGEKHHKPM
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HCMOCOPLLFK(AGJKIBCHDBK OIHLPHLCGCN);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HOLKCGGCEEG(AGJKIBCHDBK OIHLPHLCGCN);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JHMIMFBHHLP(AGJKIBCHDBK OIHLPHLCGCN);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BDFLEAFDPPL(AGJKIBCHDBK OIHLPHLCGCN);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class AGJKIBCHDBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly FAPHDJICDBI GKJNGJIPBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> GOHJAEFKDAG;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public ANHHFLMKBPC<string> KKIOHFOMCOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x766110", Offset = "0x764910", VA = "0x180766110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7662F0", Offset = "0x764AF0", VA = "0x1807662F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x768BD0", Offset = "0x7673D0", VA = "0x180768BD0")]
	public AGJKIBCHDBK(FAPHDJICDBI GGBGEOFOBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6244EB0", Offset = "0x62436B0", VA = "0x186244EB0")]
	public AGJKIBCHDBK NCGKPJAAIJL(string OHPCNPKOLBJ, string FKKGMPDEPMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6244E20", Offset = "0x6243620", VA = "0x186244E20")]
	public bool JEKNFCLLOFK([Out] IEnumerable<KeyValuePair<string, string>> OCIFMFNEKAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5693870", Offset = "0x5692070", VA = "0x185693870")]
	public AGJKIBCHDBK IHMIDOCCMFK(ANHHFLMKBPC<string> AOGFPKDBLJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface HACCBOPPNMD
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool HNCGOJCLAAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	string HKBPMOOFOGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DAFFIDOHOFH();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AFIMCMFMGGM JJODBGBKOFE(long NCDPLLGFCLI);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EFHMHJOOELJ<FINMELMELDP, FFPNNGOGOKI> BABGFBDKALP(long NCDPLLGFCLI);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EFHMHJOOELJ<FINMELMELDP, OGBHGJIPJCE> NOICBJCLPEE(long NCDPLLGFCLI);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EFHMHJOOELJ<long, KCHEFKPEJHC> LIJAICCDFCL();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> AABIHGKIEGF(byte[] LAPMLCJGBLE, byte[] PEFHOJDFIMF, CancellationToken EHCFBFBFEDH);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface MFKHKKIKBKD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool FECCGECJKEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool CLILNHLCPBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	AKCDAENEHEC IGDABFDOAAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action JADGPKGJLBG;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event NFOALEJPCOM EMNIKOOIMGN;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event NFOALEJPCOM GPEJAFMANOJ;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event NFOALEJPCOM IOFNLAFGIBF;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<IOBHDNMDIFB, bool> NGEAOOMNHBB;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PCJHDMPIGGD();

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	CDICBECJBCH NNGIABKJHBK();

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	OMMFCHHELNE GOLIOKPOJPE();

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<ANOEFAFFECF> KEALACGNDGO(OBLPPCHKGBB CHBGJFKEEJF);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task NLEJMNIPDLK(CancellationToken EHCFBFBFEDH);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface ADMCHBMLFLK
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool CAFMJPFGNBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string GJJJKBLMEOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EMILDKDGCGO(Scene AKBBHENFCCB);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task DPPPGLOHCOC(KLCGJIIIAKO NEBFBONLCCK, CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task MHJKMIPAIND();
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface NHDKLDFMNOK
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	GEGICDFBGIP GAOPKHMLGDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool LNDEDINIBCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool NDOLEHFMICG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool DPMNECDKMDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool CNJFMDCFCGA
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool EPHCHBCKDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool PKHCPGLHJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float COICNJCLCJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> FDEFIDLGDDN;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LLKIHBKOOLA MIKPOMCHFGN(LLKIHBKOOLA LKGGHPMDMAA);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DHAHHHJLPHE(LLKIHBKOOLA OKPDFALIJHE);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BLGEAEAGNKG();

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task FALJLOHOODM(ANHHFLMKBPC<string>.AJPBBELKCKG COEFJALJMOP, CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PNBHKGHDBMC(float HCHEOAHOBMM);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DCLBIIGDGJD(string CNOGBCGHKGJ);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<IIPGDPEJJMH> FHEFDPJELNH();

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable LOPIDEFMPNB(object FJNGJOFLBMD, IIPGDPEJJMH CMIOFACLLHD);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FFPNNGOGOKI HJNCKMMKPLB(IEnumerable<KAGLGJLPIBC> ADPACPMPOKE);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PFPKDCIOAKH(int ICNFOOHBEIB);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task KDMCGFPKPEK();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JNMCOLPFNGN();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool HJCIOKCLFEA();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task JBEADALDFDD(CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task GNGOHBNJGFH(CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task<PMMLMPOKANG> GPGHFDMFICE(DateTime HNLGFNLPFDJ, CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<bool> CPKAFKAJJFA(CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void BHCLIJJGIAL(string HMKCFDPKKDM = "", float JPFLHJGBBEB = 3f);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "22")]
	KMPCKLFLAEJ MNOIDEPABPE(JKDLBDKJGBI GNAMFMBEGAN, CJJNPMBFNCP JPMJJLLKIJF, OGBHGJIPJCE JMJMKBNLIKI, IEnumerable<PersistenceView> NPHNDFFHJOB, EHMMPJGANPO DPBIIOIDPKH);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void MDFKIEMDBED(OGBHGJIPJCE JMJMKBNLIKI);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void EGEGAAAKCEK(KAGLGJLPIBC CDHDPJPOJHJ, [In] KMPCKLFLAEJ LLMGHJGNIAD);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task PDNLGNMIFJM(OGBHGJIPJCE LNKNDFPNDAJ, bool ICGHDDKNBOK, CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task BPOJGADLOMD(CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void NCALBNANJHC(long NBNJFKJOFIF, long HEOAHEPJHCF, MEGCEJKCLCC BAPHNKFCMLP, MLEOJECBJGH LPNAFHBIEOK, KKLDNOOFJJJ BDCAKKAGLOE, POCCJPPMGCN? BPFMCEBCONM, IMAENCKMEPE? INMHOHJIBMI);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void AIJBOLFJEKF(long NBNJFKJOFIF, long HEOAHEPJHCF, IMAENCKMEPE? INMHOHJIBMI);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void KCCFHKPCGIG(PersistenceView KLMDDNIEHMO);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool CJJOOJBKFKN(PersistenceView CLOKEPECCEF);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool BEKICKOPNJH(KAGLGJLPIBC CDHDPJPOJHJ, EDLKHAAMHBP HKCLCOJCCHA, [Out] FDIKHEBPHEA AHFLNFPMAHB);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task BNFDPEKDGAD(CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void APKILKBIJDI();

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "34")]
	IDisposable PNKHGFNBPMD();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void GIPJANBMJKF(OGBHGJIPJCE LNKNDFPNDAJ, EDLKHAAMHBP HKCLCOJCCHA);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<bool> GFMDMBDLLEF(EMCLNBMIAFK JIAGCNOOLAE, CancellationToken EHCFBFBFEDH, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void ECDMMECKMPF(CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<GCMHHKBFFMI> MCIOFNEGLHH(BKDMLKPJAKO LJEEHJLDFLC);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<MEGCEJKCLCC> ICAIFIODCAK(long NBNJFKJOFIF, bool JFLAILABEEC, CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<MLEOJECBJGH> CBBJJLKGFFG(long NBNJFKJOFIF, long HEOAHEPJHCF, long MHNINMPGKNJ, CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<DLGOOIKOPLC> LCCBMFFBCBB(string KPKBCEDPOCD, CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<DLGOOIKOPLC> HPLJCILGNAP(string KPKBCEDPOCD, long NBNJFKJOFIF, long HEOAHEPJHCF, string CMPPDGOADDE, NDEJCBMFAJE.LEFJIJPLCAC KAGMDCLCJHI, NDEJCBMFAJE.LEFJIJPLCAC PEFHOJDFIMF, int NINOCLLNPBI);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "44")]
	bool GENOLMLBJKE();

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool MMLAIOHBPLA();

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool IFMEGEJFJFD(IEnumerable<FDIKHEBPHEA> NJDCHMKNBOF);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "47")]
	void JJJFMGBPGMG(List<GameObject> EMGHNFOEHGF);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "48")]
	float JMPEEIDEKCH();

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task<Scene> ONCIPIGKPBE(string JACEFLIJGKH, LoadSceneMode KJMJGFGFBFC, bool POPOELKFFIE, ANHHFLMKBPC<string>.AJPBBELKCKG AOGFPKDBLJK);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "50")]
	void CBOKHAFIBPH();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void MIJIMJFCLFI(bool PLMDMDMKAAB);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void CPBEPGNOPLO(FAPHDJICDBI BNAABMJLIMF);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "58")]
	Task GIAMNOICLOF(ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "59")]
	Task ONOODPBMELM(ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "60")]
	Task ICKLGEAGGGC(ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "61")]
	IDisposable HBMFLIIBEMP();

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "62")]
	EICHMJCIJHN AINOHBIIJCO();

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Task CKLJLDJJEII(CancellationToken EHCFBFBFEDH);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface EICHMJCIJHN
{
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task FOCIIDEABGO(CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JOAMFMHEMPK(CancellationToken EHCFBFBFEDH);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct KMPCKLFLAEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> IKJIMKOHNAK;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public enum PMMLMPOKANG : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct JKDLBDKJGBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string OAMNCKJIOOO;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface GEGICDFBGIP
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	FAPHDJICDBI IPDBFADPDCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	MEGCEJKCLCC LIMNFFDICJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	ILPOHKEMFGB CFDFLMEFKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool AOFIIOOCHHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool FENCBNLLHJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	int HBDFHMKLCAL
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action NMPIDMLOEBE;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> EECPONEDCHG;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LKCCMJDFMOE();

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.DHLDAEGKICN> MMBGFKOAOBD(long NCDPLLGFCLI, [Optional] CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<KFGMBBDBHME> HOGLKHFPKHK();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task DJFNDKPDMOC();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(FAPHDJICDBI, AKCDAENEHEC) GCEGGJNKJGN();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "15")]
	JDBGDEDGBHG OOOGCCIAALA();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void COHBMOEEABA(long NCDPLLGFCLI);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface HEBNOFFIONN
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HCCOGFBHHMM([Out] IEnumerable<int> DNNHFGFLBBF);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MFAFMLDKDBP(JCNOBKCLCPM KIAKEGJPMAL);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CAANIJILCEF(JCNOBKCLCPM KIAKEGJPMAL);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface AFEFMNIOIFN
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string PAGOPGNELPB(ANOEFAFFECF FPCACMBMLBI);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface HMPLIHCDKKG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LCGJEICIBOL(FONMOIKDFND.ACMBLKGLLCC IIPDIEGMHMO);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AGAONIEGMFM(FONMOIKDFND.ACMBLKGLLCC IIPDIEGMHMO);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface FILLDCCIKAF : HMPLIHCDKKG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ANOEFAFFECF DLLDPKHGGFK(JLNLBCDKCMG MLBPFKHFGPG);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface DHBGMDMHDLN : HMPLIHCDKKG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ANOEFAFFECF EEMHBLAIDME(JLNLBCDKCMG AKFGFNBMNIF);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface AFIMCMFMGGM
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EOPMGLNDIOA<KLCGJIIIAKO, BJFJCNKKJDP>> KEDDPCJJGGO(string CMPPDGOADDE, long NCDPLLGFCLI, HNJEFBAMJIH.BOLKGIAFBOP MIBBCGFIAOO, CancellationToken EHCFBFBFEDH);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface EFHMHJOOELJ<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EOPMGLNDIOA<byte[], BJFJCNKKJDP>> FAMDEIADKIB(TGetDataArg OIFDKAEILPK, CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EOPMGLNDIOA<OEBIDEOHOKD<TData>, BJFJCNKKJDP> BOHAIFACBBA(byte[] AELCABDCBDD);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class MHDPMOCOCIH : HKHECNIPIOJ, MFKHKKIKBKD, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct GOFHDHOPNBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public AsyncTaskMethodBuilder<ANOEFAFFECF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public MHDPMOCOCIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public OBLPPCHKGBB autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter<ANOEFAFFECF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x624E800", Offset = "0x624D000", VA = "0x18624E800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x624EA80", Offset = "0x624D280", VA = "0x18624EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct FKCIMBIHLDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public MHDPMOCOCIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x624AC80", Offset = "0x6249480", VA = "0x18624AC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x624AEB0", Offset = "0x62496B0", VA = "0x18624AEB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class FMMLPNAHPMH : IEnumerable<DMCCOCJCFNK>, IEnumerable, IEnumerator<DMCCOCJCFNK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private DMCCOCJCFNK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public MHDPMOCOCIH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		private DMCCOCJCFNK System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x86AE20", Offset = "0x869620", VA = "0x18086AE20")]
		[DebuggerHidden]
		public FMMLPNAHPMH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x624B650", Offset = "0x6249E50", VA = "0x18624B650", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x624BAB0", Offset = "0x624A2B0", VA = "0x18624BAB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x624BA00", Offset = "0x624A200", VA = "0x18624BA00", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DMCCOCJCFNK> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x624BA00", Offset = "0x624A200", VA = "0x18624BA00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource NKGJBKAENHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly LLKIHBKOOLA OKPDFALIJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool KIMEMKKPGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private OLNHGPCGOAF DJJBLFOAAEA;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public EMCLNBMIAFK FDJBNEIPECE
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x768D80", Offset = "0x767580", VA = "0x180768D80", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x768E00", Offset = "0x767600", VA = "0x180768E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public HEEPHCNKAAB KPFELNOLEME
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x761C50", Offset = "0x760450", VA = "0x180761C50", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x761BD0", Offset = "0x7603D0", VA = "0x180761BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public NHDKLDFMNOK JAIBLGKGHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x761BF0", Offset = "0x7603F0", VA = "0x180761BF0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x761C10", Offset = "0x760410", VA = "0x180761C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public ADMCHBMLFLK ODFAHIOEKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x761C00", Offset = "0x760400", VA = "0x180761C00", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x761BE0", Offset = "0x7603E0", VA = "0x180761BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public FILLDCCIKAF FCIMGCIKHPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x761C30", Offset = "0x760430", VA = "0x180761C30", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x761C60", Offset = "0x760460", VA = "0x180761C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public DHBGMDMHDLN LMCAPLLGCNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x761C20", Offset = "0x760420", VA = "0x180761C20", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x761C40", Offset = "0x760440", VA = "0x180761C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public JGMGPMLOKAC EBBMFLBCAEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x768CA0", Offset = "0x7674A0", VA = "0x180768CA0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x768CD0", Offset = "0x7674D0", VA = "0x180768CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public PMOEIHKACBO FFDLODMMOGH
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x768D30", Offset = "0x767530", VA = "0x180768D30", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x768C90", Offset = "0x767490", VA = "0x180768C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public IDEOMGMIEJK MKAMLPJPHCG
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x768CB0", Offset = "0x7674B0", VA = "0x180768CB0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x768DB0", Offset = "0x7675B0", VA = "0x180768DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public PFHBEMNNDIC DKOBHODIDDC
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8120A0", Offset = "0x8108A0", VA = "0x1808120A0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x812180", Offset = "0x810980", VA = "0x180812180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public HKDPKLIFIKK PENOFKLKBNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x768E20", Offset = "0x767620", VA = "0x180768E20", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x768DE0", Offset = "0x7675E0", VA = "0x180768DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public AJGGJOEDFAM INOGIKPEAPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8A33B0", Offset = "0x8A1BB0", VA = "0x1808A33B0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8A3700", Offset = "0x8A1F00", VA = "0x1808A3700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public GPGGGCMILBN LHONJJOKIIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x768200", Offset = "0x766A00", VA = "0x180768200", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7681E0", Offset = "0x7669E0", VA = "0x1807681E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public OLFBMLBGCAP IDOCKAHODIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8B6300", Offset = "0x8B4B00", VA = "0x1808B6300", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8B6550", Offset = "0x8B4D50", VA = "0x1808B6550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public OMMFIKHIIFB CMCKOMLFAOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x83D270", Offset = "0x83BA70", VA = "0x18083D270", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8B6610", Offset = "0x8B4E10", VA = "0x1808B6610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public EILOFBEIBKF AMJNPNLPAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8B6350", Offset = "0x8B4B50", VA = "0x1808B6350", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8B65B0", Offset = "0x8B4DB0", VA = "0x1808B65B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public PABNMGIMAJM GDBGNDFDBGM
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x818210", Offset = "0x816A10", VA = "0x180818210", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8B6630", Offset = "0x8B4E30", VA = "0x1808B6630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public IKCOGABLLKF JFOGJFEGDLC
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8B6360", Offset = "0x8B4B60", VA = "0x1808B6360", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8B65D0", Offset = "0x8B4DD0", VA = "0x1808B65D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public ALBKEKEEMGG FIHLENCOKCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x768290", Offset = "0x766A90", VA = "0x180768290", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x768270", Offset = "0x766A70", VA = "0x180768270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public GJEGGLJCIKF HCKJLFFKBJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7DDAD0", Offset = "0x7DC2D0", VA = "0x1807DDAD0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7DDAE0", Offset = "0x7DC2E0", VA = "0x1807DDAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public NACFABKEACP LLEJJJBLAHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8B6380", Offset = "0x8B4B80", VA = "0x1808B6380", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8B6650", Offset = "0x8B4E50", VA = "0x1808B6650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public MNHBODFFBLI KOAEIBGBHGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8B6370", Offset = "0x8B4B70", VA = "0x1808B6370", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B4DF0", VA = "0x1808B65F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public KCAGEKHHKPM OLAHHCCHNNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8B6340", Offset = "0x8B4B40", VA = "0x1808B6340", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8B6590", Offset = "0x8B4D90", VA = "0x1808B6590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public HEBNOFFIONN EJDPHHCFGLH
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8B6490", Offset = "0x8B4C90", VA = "0x1808B6490", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8B6870", Offset = "0x8B5070", VA = "0x1808B6870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public NHOAIGNOOHK NNCNEKKLODG
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8B6470", Offset = "0x8B4C70", VA = "0x1808B6470", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8B6830", Offset = "0x8B5030", VA = "0x1808B6830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public JPCCDPCHOFD LIJNMPABDDM
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8B6420", Offset = "0x8B4C20", VA = "0x1808B6420", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8B6790", Offset = "0x8B4F90", VA = "0x1808B6790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public HACCBOPPNMD CACBBBIGNNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8B63E0", Offset = "0x8B4BE0", VA = "0x1808B63E0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8B6710", Offset = "0x8B4F10", VA = "0x1808B6710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public NLICGHANJFP NAILPHGIJPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8B6480", Offset = "0x8B4C80", VA = "0x1808B6480", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public CPKEAHBNHDJ NDDEPJPIMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8B6310", Offset = "0x8B4B10", VA = "0x1808B6310", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public PBJDCDGMCIN LNJNAECLMKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8B6450", Offset = "0x8B4C50", VA = "0x1808B6450", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public AKCDAENEHEC IGDABFDOAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8B63F0", Offset = "0x8B4BF0", VA = "0x1808B63F0", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8B6730", Offset = "0x8B4F30", VA = "0x1808B6730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	private bool KIHNHKKJIJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6258890", Offset = "0x6257090", VA = "0x186258890", Slot = "46")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private bool LHPBGAOGNNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6258810", Offset = "0x6257010", VA = "0x186258810", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private CancellationToken JGHPEBMCEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x62590C0", Offset = "0x62578C0", VA = "0x1862590C0", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	private LLKIHBKOOLA GLMEOANEHCO
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action JJBHLIPKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x62587B0", Offset = "0x6256FB0", VA = "0x1862587B0", Slot = "36")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x62591A0", Offset = "0x62579A0", VA = "0x1862591A0", Slot = "37")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event NFOALEJPCOM JEKAFHJFALH
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6259140", Offset = "0x6257940", VA = "0x186259140", Slot = "38")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6259060", Offset = "0x6257860", VA = "0x186259060", Slot = "39")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event NFOALEJPCOM DCMEDNLHNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6258BE0", Offset = "0x62573E0", VA = "0x186258BE0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6258CF0", Offset = "0x62574F0", VA = "0x186258CF0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event NFOALEJPCOM AFKFNJKPBGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6258D50", Offset = "0x6257550", VA = "0x186258D50", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6258B80", Offset = "0x6257380", VA = "0x186258B80", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<IOBHDNMDIFB, bool> EKFHJBHKENN
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x62590E0", Offset = "0x62578E0", VA = "0x1862590E0", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6258E40", Offset = "0x6257640", VA = "0x186258E40", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x8B6730", Offset = "0x8B4F30", VA = "0x1808B6730", Slot = "35")]
	public void IHICOJAGEOA(AKCDAENEHEC OICAIDHKNJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6259200", Offset = "0x6257A00", VA = "0x186259200")]
	[UnityEngine.Scripting.Preserve]
	internal MHDPMOCOCIH([KEKICHOEFEB(null)] LLKIHBKOOLA OKPDFALIJHE, [KEKICHOEFEB(null)] EMCLNBMIAFK JIAGCNOOLAE, [KEKICHOEFEB(null)] HEEPHCNKAAB NAFGPPDGGAP, [KEKICHOEFEB(null)] NHDKLDFMNOK HGOFPLJJILB, [KEKICHOEFEB(null)] ADMCHBMLFLK LCJFLDIGMEC, [KEKICHOEFEB(null)] FILLDCCIKAF BCOJFHNKCHE, [KEKICHOEFEB(null)] DHBGMDMHDLN AOCAGONDCAI, [KEKICHOEFEB(null)] JGMGPMLOKAC CDMGHLCAIIK, [KEKICHOEFEB(null)] PMOEIHKACBO BDJBBEPJBGF, [KEKICHOEFEB(null)] IDEOMGMIEJK GIOPHEGOFJO, [KEKICHOEFEB(null)] PFHBEMNNDIC CGFCBDPFKDC, [KEKICHOEFEB(null)] HKDPKLIFIKK JGKDMAIJPDJ, [KEKICHOEFEB(null)] AJGGJOEDFAM MGDHDGAHABJ, [KEKICHOEFEB(null)] GPGGGCMILBN MEIBLKIIFAK, [KEKICHOEFEB(null)] OLFBMLBGCAP DNNFAIHNCJP, [KEKICHOEFEB(null)] OMMFIKHIIFB LBGEBDNMIEL, [KEKICHOEFEB(null)] EILOFBEIBKF FHDMABIEMGK, [KEKICHOEFEB(null)] PABNMGIMAJM LEFKIFEFKPC, [KEKICHOEFEB(null)] IKCOGABLLKF MIHBGGAEGDP, [KEKICHOEFEB(null)] ALBKEKEEMGG AOMHJKJMKKC, [KEKICHOEFEB(null)] NACFABKEACP BJLGPNNNLLO, [KEKICHOEFEB(null)] GJEGGLJCIKF IIIAFBIONCI, [KEKICHOEFEB(null)] MNHBODFFBLI CPFGJIIMOIH, [KEKICHOEFEB(null)] KCAGEKHHKPM LGKKNBKLOBK, [KEKICHOEFEB(null)] HEBNOFFIONN ENNHBACDBLM, [KEKICHOEFEB(null)] JPCCDPCHOFD IKANDDIAENK, [KEKICHOEFEB(null)] HACCBOPPNMD AOAMFFCECNF, [KEKICHOEFEB(null)] NLICGHANJFP JFAIGMBPLPH, [KEKICHOEFEB(null)] CPKEAHBNHDJ DDFAFLADAPN, [KEKICHOEFEB(null)] PBJDCDGMCIN JLIIBGFDIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6258C40", Offset = "0x6257440", VA = "0x186258C40")]
	private void GLJEDCMMNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x62589E0", Offset = "0x62571E0", VA = "0x1862589E0", Slot = "54")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6258FB0", Offset = "0x62577B0", VA = "0x186258FB0", Slot = "48")]
	private void NLMGIJJLNFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6258EA0", Offset = "0x62576A0", VA = "0x186258EA0", Slot = "49")]
	private CDICBECJBCH NDNBHKCHFIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6258DB0", Offset = "0x62575B0", VA = "0x186258DB0", Slot = "50")]
	private OMMFCHHELNE IMDINPBJEHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x62586A0", Offset = "0x6256EA0", VA = "0x1862586A0", Slot = "51")]
	[AsyncStateMachine(typeof(GOFHDHOPNBF))]
	private Task<ANOEFAFFECF> ABCGLBMIDGP(OBLPPCHKGBB JLIKKAGDNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x62588F0", Offset = "0x62570F0", VA = "0x1862588F0", Slot = "52")]
	[AsyncStateMachine(typeof(FKCIMBIHLDL))]
	private Task DJFNKGDBFJI(CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6258F30", Offset = "0x6257730", VA = "0x186258F30")]
	[IteratorStateMachine(typeof(FMMLPNAHPMH))]
	private IEnumerable<DMCCOCJCFNK> NIJNKFBAEAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6259000", Offset = "0x6257800", VA = "0x186259000")]
	[CompilerGenerated]
	private void OEIOICOCMOH(DMCCOCJCFNK FMGHNFLOPOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class FOCFIICMBBB : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0xC1C660", Offset = "0xC1AE60", VA = "0x180C1C660")]
	public FOCFIICMBBB(string BKGEBGGPBLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal class FDGPKONBNKD : HEDKDAIFHEA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct IBNDLIJHPBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public FDGPKONBNKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x624F240", Offset = "0x624DA40", VA = "0x18624F240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x624F580", Offset = "0x624DD80", VA = "0x18624F580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly HKHECNIPIOJ LOJMHJJKLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly NHDKLDFMNOK HGOFPLJJILB;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x7619F0", Offset = "0x7601F0", VA = "0x1807619F0")]
	public FDGPKONBNKD(HKHECNIPIOJ LOJMHJJKLIJ, NHDKLDFMNOK HGOFPLJJILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x624A5D0", Offset = "0x6248DD0", VA = "0x18624A5D0", Slot = "4")]
	[AsyncStateMachine(typeof(IBNDLIJHPBJ))]
	public Task<bool> ADCLDCDFIBH(CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x624A6C0", Offset = "0x6248EC0", VA = "0x18624A6C0")]
	[CompilerGenerated]
	private object KHDGFLMPGEJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal class LDEDJIFLKNG : HEDKDAIFHEA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct CGMPDECAKDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public LDEDJIFLKNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private float <timeoutTime>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x6246BB0", Offset = "0x62453B0", VA = "0x186246BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x62472C0", Offset = "0x6245AC0", VA = "0x1862472C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly HKHECNIPIOJ LOJMHJJKLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly NHDKLDFMNOK HGOFPLJJILB;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	private GEGICDFBGIP GAOPKHMLGDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6257DE0", Offset = "0x62565E0", VA = "0x186257DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7619F0", Offset = "0x7601F0", VA = "0x1807619F0")]
	public LDEDJIFLKNG(HKHECNIPIOJ LOJMHJJKLIJ, NHDKLDFMNOK HGOFPLJJILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6257BD0", Offset = "0x62563D0", VA = "0x186257BD0", Slot = "4")]
	[AsyncStateMachine(typeof(CGMPDECAKDF))]
	public Task<bool> ADCLDCDFIBH(CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6257D00", Offset = "0x6256500", VA = "0x186257D00")]
	[CompilerGenerated]
	private object EJOFBKOIKJL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal class MFBMJGBNLHC : HEDKDAIFHEA
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class EAKHAJBJNAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public MFBMJGBNLHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public KFGMBBDBHME result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public FAPHDJICDBI newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public EAKHAJBJNAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6248E80", Offset = "0x6247680", VA = "0x186248E80")]
		internal object FGIOLLCEIIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6248F70", Offset = "0x6247770", VA = "0x186248F70")]
		internal object LKECDKDAKIE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6248DE0", Offset = "0x62475E0", VA = "0x186248DE0")]
		internal object CJFJAAKMKFO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct KOPFIEAMGIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public MFBMJGBNLHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private EAKHAJBJNAJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private TaskAwaiter<KFGMBBDBHME> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6257230", Offset = "0x6255A30", VA = "0x186257230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6257B60", Offset = "0x6256360", VA = "0x186257B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly HKHECNIPIOJ LOJMHJJKLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly NHDKLDFMNOK HGOFPLJJILB;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	private GEGICDFBGIP GAOPKHMLGDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x62580A0", Offset = "0x62568A0", VA = "0x1862580A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x7619F0", Offset = "0x7601F0", VA = "0x1807619F0")]
	public MFBMJGBNLHC(HKHECNIPIOJ LOJMHJJKLIJ, NHDKLDFMNOK HGOFPLJJILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6257F80", Offset = "0x6256780", VA = "0x186257F80", Slot = "4")]
	[AsyncStateMachine(typeof(KOPFIEAMGIM))]
	public Task<bool> ADCLDCDFIBH(CancellationToken EHCFBFBFEDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal interface HEDKDAIFHEA
{
	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> ADCLDCDFIBH(CancellationToken EHCFBFBFEDH);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal struct DECDLIPMMNA
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class DFHOBLJHDCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public HKHECNIPIOJ manager;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public DFHOBLJHDCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6247AE0", Offset = "0x62462E0", VA = "0x186247AE0")]
		internal Task JDEFOHMJKLN(EGEMJBICGKC data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct BKPEGEPFLPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public DECDLIPMMNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private OBLPPCHKGBB <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<PMMLMPOKANG> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<ANOEFAFFECF> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6246530", Offset = "0x6244D30", VA = "0x186246530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6246AC0", Offset = "0x62452C0", VA = "0x186246AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct JDPHMHOJFDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public DECDLIPMMNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x62500A0", Offset = "0x624E8A0", VA = "0x1862500A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x62503C0", Offset = "0x624EBC0", VA = "0x1862503C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly CancellationToken EHCFBFBFEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly HKHECNIPIOJ PNFHHOFJABN;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private EMCLNBMIAFK FDJBNEIPECE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x62479D0", Offset = "0x62461D0", VA = "0x1862479D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	private NHDKLDFMNOK JAIBLGKGHED
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6247A20", Offset = "0x6246220", VA = "0x186247A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private GEGICDFBGIP GAOPKHMLGDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6247510", Offset = "0x6245D10", VA = "0x186247510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private IDEOMGMIEJK MKAMLPJPHCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6247870", Offset = "0x6246070", VA = "0x186247870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x1C2FDB0", Offset = "0x1C2E5B0", VA = "0x181C2FDB0")]
	public DECDLIPMMNA(CancellationToken EHCFBFBFEDH, HKHECNIPIOJ PNFHHOFJABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6247460", Offset = "0x6245C60", VA = "0x186247460")]
	public static IBMNOJHFFNF FOLOIAIPPPL(HKHECNIPIOJ PNFHHOFJABN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x62478C0", Offset = "0x62460C0", VA = "0x1862478C0")]
	[AsyncStateMachine(typeof(BKPEGEPFLPO))]
	public Task<bool> MFGPHFHEOBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6247660", Offset = "0x6245E60", VA = "0x186247660")]
	private bool JIAFLCFKBJN([Out] OBLPPCHKGBB JLIKKAGDNAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6247590", Offset = "0x6245D90", VA = "0x186247590")]
	[AsyncStateMachine(typeof(JDPHMHOJFDJ))]
	private Task JGNBIKIEPIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6247330", Offset = "0x6245B30", VA = "0x186247330")]
	private Task<PMMLMPOKANG> FOBAGBPKPOF(OBLPPCHKGBB OJFNHEHPBMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal struct KDGDHFBEFOP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly OLFBMLBGCAP DNNFAIHNCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Guid BACFDICONIG;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private Task<(ANOEFAFFECF, Task)> MFGAFCHJCBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6251270", Offset = "0x624FA70", VA = "0x186251270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x38FED60", Offset = "0x38FD560", VA = "0x1838FED60")]
	public KDGDHFBEFOP(OLFBMLBGCAP DNNFAIHNCJP, Guid BACFDICONIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6251150", Offset = "0x624F950", VA = "0x186251150")]
	public TaskAwaiter<(ANOEFAFFECF, Task)> CNPPKHCHJBE()
	{
		return default(TaskAwaiter<(ANOEFAFFECF, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x62511A0", Offset = "0x624F9A0", VA = "0x1862511A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct KEGOLPLPEEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly TaskCompletionSource<(ANOEFAFFECF, Task)> HGJPFFJEECO;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public Task<(ANOEFAFFECF, Task)> MFGAFCHJCBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6251340", Offset = "0x624FB40", VA = "0x186251340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6251590", Offset = "0x624FD90", VA = "0x186251590")]
	public KEGOLPLPEEA(TimeSpan EHHDIDGCGLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6251380", Offset = "0x624FB80", VA = "0x186251380")]
	public void JGKKNJCOEPO(Task FJNDBCBLLJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6251420", Offset = "0x624FC20", VA = "0x186251420")]
	public void NLJDELCMOBH(ANOEFAFFECF FPCACMBMLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6251540", Offset = "0x624FD40", VA = "0x186251540")]
	public void PNODNCEHPOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x62514B0", Offset = "0x624FCB0", VA = "0x1862514B0")]
	internal void PBMJANAHNAE(string BKGEBGGPBLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class DODEKPFJAGG
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class LKINDIPOJCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public MLEOJECBJGH subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public LKINDIPOJCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6257EE0", Offset = "0x62566E0", VA = "0x186257EE0")]
		internal bool LLBBPIPIFKI(ILPOHKEMFGB s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x62489F0", Offset = "0x62471F0", VA = "0x1862489F0")]
	public static MNHIEHBCOOD KLKFANDJKFE(long ADKNLFICAMB, long HEOAHEPJHCF, string KPKBCEDPOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6248CB0", Offset = "0x62474B0", VA = "0x186248CB0")]
	public static MNHIEHBCOOD KLKFANDJKFE(long ADKNLFICAMB, long HEOAHEPJHCF, FINMELMELDP LAPMLCJGBLE, long MHNINMPGKNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6248860", Offset = "0x6247060", VA = "0x186248860")]
	public static MNHIEHBCOOD KLKFANDJKFE(GCMHHKBFFMI JBLIJKFKMOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6248A80", Offset = "0x6247280", VA = "0x186248A80")]
	public static MNHIEHBCOOD KLKFANDJKFE(MEGCEJKCLCC HKBGHDIBJOC, MLEOJECBJGH DFKNAGFNDIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x62485E0", Offset = "0x6246DE0", VA = "0x1862485E0")]
	public static MNHIEHBCOOD AECCCPCGDCL(this MNHIEHBCOOD KAAIDPFBBBH, MEGCEJKCLCC HBEPAKDNHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x62486D0", Offset = "0x6246ED0", VA = "0x1862486D0")]
	public static MNHIEHBCOOD AIIKMHJPOEG(this MNHIEHBCOOD KAAIDPFBBBH, MLEOJECBJGH DLOGFIKFAJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[UnityEngine.Scripting.Preserve]
internal class EEDKAMGMLPH : PMOEIHKACBO, DMCCOCJCFNK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct FKMHJCNIBFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public EEDKAMGMLPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x624AF10", Offset = "0x6249710", VA = "0x18624AF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x624B5F0", Offset = "0x6249DF0", VA = "0x18624B5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly JCNOBKCLCPM IJIHBAKKEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private string LJHJIECNELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Task AHPHCAMMJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private HKHECNIPIOJ LOJMHJJKLIJ;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool DMNEOHNKDME
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x6248FE0", Offset = "0x62477E0", VA = "0x186248FE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public Task GJKAPMKOJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x6249170", Offset = "0x6247970", VA = "0x186249170", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x766120", Offset = "0x764920", VA = "0x180766120", Slot = "7")]
	public void GLJEDCMMNGN(HKHECNIPIOJ LOJMHJJKLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6249010", Offset = "0x6247810", VA = "0x186249010", Slot = "6")]
	public void FFGBBGNBMFJ(Task AKGEHPDFIAE, string IOGLHMCCCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6249200", Offset = "0x6247A00", VA = "0x186249200")]
	[AsyncStateMachine(typeof(FKMHJCNIBFD))]
	private Task JFOCOCBPHHH(Task PIABKKJODGF, string IOGLHMCCCPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6249320", Offset = "0x6247B20", VA = "0x186249320")]
	public EEDKAMGMLPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal class OKBHENPBNFG : NHOAIGNOOHK, DMCCOCJCFNK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool DOEOGKEGCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private FBKGNJKHOII OKBIDEMFDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private EMCLNBMIAFK JIAGCNOOLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private JPCCDPCHOFD IKANDDIAENK;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public FBKGNJKHOII FJBLAJAEKML
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x625D1E0", Offset = "0x625B9E0", VA = "0x18625D1E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x625D250", Offset = "0x625BA50", VA = "0x18625D250", Slot = "7")]
	public void GLJEDCMMNGN(HKHECNIPIOJ LOJMHJJKLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x625D490", Offset = "0x625BC90", VA = "0x18625D490", Slot = "5")]
	public void MBKJAFDGNGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x625D1A0", Offset = "0x625B9A0", VA = "0x18625D1A0", Slot = "6")]
	public void BJIHJCODOAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x625D3D0", Offset = "0x625BBD0", VA = "0x18625D3D0")]
	private Task JCJMAOJPGNJ(LADONBJPHPE EANKMFHELBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x625D1A0", Offset = "0x625B9A0", VA = "0x18625D1A0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public OKBHENPBNFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class AJOLKNALOEI : JPCCDPCHOFD
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private class HLOMJICNAEG<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly NLEFLBLOMOJ LLCDADFGEDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly string OHPCNPKOLBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly T LOJDAJFIDPG;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public T PENMJFOMGMH
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x7B39F0", Offset = "0x7B21F0", VA = "0x1807B39F0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x89BFC0", Offset = "0x89A7C0", VA = "0x18089BFC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x35A0D60", Offset = "0x359F560", VA = "0x1835A0D60")]
		public HLOMJICNAEG(NLEFLBLOMOJ LLCDADFGEDL, string OHPCNPKOLBJ, T LOJDAJFIDPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x35A0A00", Offset = "0x359F200", VA = "0x1835A0A00")]
		private void NMHDPJNOLPO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly NLEFLBLOMOJ LLCDADFGEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly HLOMJICNAEG<TimeSpan> NJCENFINJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly HLOMJICNAEG<TimeSpan> NFBFPHACECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly HLOMJICNAEG<TimeSpan> LJHGOPCJDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly HLOMJICNAEG<TimeSpan> EOIDEJOFEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly HLOMJICNAEG<bool> NCJKPEBONJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly HLOMJICNAEG<bool> FJDOAKMOPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly HLOMJICNAEG<bool> DNNDNOANDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly HLOMJICNAEG<int> GHFJDFIKAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly HLOMJICNAEG<bool> JCJACMHLNCJ;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public TimeSpan KAKNNOAMMMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x6245100", Offset = "0x6243900", VA = "0x186245100", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public TimeSpan PLEBKBDOJJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x6245140", Offset = "0x6243940", VA = "0x186245140", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public TimeSpan KBKLKEBEKIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6245040", Offset = "0x6243840", VA = "0x186245040", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public TimeSpan NBBJKIHOKJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x6245000", Offset = "0x6243800", VA = "0x186245000", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool FHAJLJJINMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6245180", Offset = "0x6243980", VA = "0x186245180", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool ADGFOBBMEBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x62450C0", Offset = "0x62438C0", VA = "0x1862450C0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public bool CFOFBKNGFJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x6244F80", Offset = "0x6243780", VA = "0x186244F80", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public int POLDOFGFCHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6244FC0", Offset = "0x62437C0", VA = "0x186244FC0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool KPLOCLMJJKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6245080", Offset = "0x6243880", VA = "0x186245080", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x62451C0", Offset = "0x62439C0", VA = "0x1862451C0")]
	[UnityEngine.Scripting.Preserve]
	public AJOLKNALOEI([KEKICHOEFEB(null)] NLEFLBLOMOJ LLCDADFGEDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[UnityEngine.Scripting.Preserve]
internal class NOHBDFMAFIH : PFHBEMNNDIC, DMCCOCJCFNK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class OMBJHGDBNCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public DEDIDPIECAL roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public OMBJHGDBNCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x625D640", Offset = "0x625BE40", VA = "0x18625D640")]
		internal object OIBPNIIOKKH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action JADGPKGJLBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x625C1B0", Offset = "0x625A9B0", VA = "0x18625C1B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x625C470", Offset = "0x625AC70", VA = "0x18625C470", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event NFOALEJPCOM EMNIKOOIMGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x625B9C0", Offset = "0x625A1C0", VA = "0x18625B9C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x625BE10", Offset = "0x625A610", VA = "0x18625BE10", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event NFOALEJPCOM GPEJAFMANOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x625BF50", Offset = "0x625A750", VA = "0x18625BF50", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x625BEB0", Offset = "0x625A6B0", VA = "0x18625BEB0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event NFOALEJPCOM IOFNLAFGIBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x625BAE0", Offset = "0x625A2E0", VA = "0x18625BAE0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x625BD70", Offset = "0x625A570", VA = "0x18625BD70", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<IOBHDNMDIFB, bool> NGEAOOMNHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x625BFF0", Offset = "0x625A7F0", VA = "0x18625BFF0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x625C100", Offset = "0x625A900", VA = "0x18625C100", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "19")]
	public void GLJEDCMMNGN(HKHECNIPIOJ LOJMHJJKLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x625C250", Offset = "0x625AA50", VA = "0x18625C250", Slot = "14")]
	public void NMMNJPECCOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x625BA60", Offset = "0x625A260", VA = "0x18625BA60", Slot = "15")]
	public void AJOOPIEIHFE(DEDIDPIECAL DOLBAIIOHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x625C0D0", Offset = "0x625A8D0", VA = "0x18625C0D0", Slot = "16")]
	public void JHLHACKNDHD(DEDIDPIECAL DOLBAIIOHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x625C0A0", Offset = "0x625A8A0", VA = "0x18625C0A0", Slot = "17")]
	public void IDNKNOAPDHG(DEDIDPIECAL DOLBAIIOHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x625BA90", Offset = "0x625A290", VA = "0x18625BA90", Slot = "18")]
	public void AOPODNJGMAL(IOBHDNMDIFB AMKPPIJBFNG, bool MJOMMNNHKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x625BB80", Offset = "0x625A380", VA = "0x18625BB80")]
	private void BHJKEIPKKOJ(NFOALEJPCOM CMIOFACLLHD, DEDIDPIECAL DOLBAIIOHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public NOHBDFMAFIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[UnityEngine.Scripting.Preserve]
internal class JPDCEDECMPM : HKDPKLIFIKK, DMCCOCJCFNK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct MHCIGHFEAHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public JPDCEDECMPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x62580F0", Offset = "0x62568F0", VA = "0x1862580F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x6258640", Offset = "0x6256E40", VA = "0x186258640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct HDGICNBONLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public JPDCEDECMPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x624EAF0", Offset = "0x624D2F0", VA = "0x18624EAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x624F190", Offset = "0x624D990", VA = "0x18624F190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class DOLPOCGPLBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public DOLPOCGPLBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x6248D70", Offset = "0x6247570", VA = "0x186248D70")]
		internal object NAHKPCMOLGN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct ENJELILCOGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public JPDCEDECMPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private DOLPOCGPLBJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6249DD0", Offset = "0x62485D0", VA = "0x186249DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x624A560", Offset = "0x6248D60", VA = "0x18624A560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class MEEJFINOIAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public MEEJFINOIAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x6257F10", Offset = "0x6256710", VA = "0x186257F10")]
		internal object GHLMEDJBJKC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private HKHECNIPIOJ LOJMHJJKLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private NHDKLDFMNOK HGOFPLJJILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private HEDKDAIFHEA[] KDAGELBJHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private CancellationTokenSource PDCJAGPLKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private int MFIMEDPAGPI;

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6250760", Offset = "0x624EF60", VA = "0x186250760", Slot = "6")]
	public void GLJEDCMMNGN(HKHECNIPIOJ LOJMHJJKLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6250620", Offset = "0x624EE20", VA = "0x186250620", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6250FB0", Offset = "0x624F7B0", VA = "0x186250FB0", Slot = "8")]
	public void PJCBOPOMMKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6250ED0", Offset = "0x624F6D0", VA = "0x186250ED0", Slot = "5")]
	public void PCJHDMPIGGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6250420", Offset = "0x624EC20", VA = "0x186250420", Slot = "4")]
	[AsyncStateMachine(typeof(MHCIGHFEAHM))]
	public Task ANHCBANIHOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6250BC0", Offset = "0x624F3C0", VA = "0x186250BC0")]
	private void LPEGNKHIDGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6250AD0", Offset = "0x624F2D0", VA = "0x186250AD0")]
	[AsyncStateMachine(typeof(HDGICNBONLP))]
	private Task LKFJFLEHFGF(CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6250630", Offset = "0x624EE30", VA = "0x186250630")]
	[AsyncStateMachine(typeof(ENJELILCOGF))]
	private Task<bool> GHNLDDOGNND(int LFEFGCGCIAG, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x62507E0", Offset = "0x624EFE0", VA = "0x1862507E0")]
	private void HGPOFKKPAEE(int LFEFGCGCIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x62508C0", Offset = "0x624F0C0", VA = "0x1862508C0")]
	private void JHFGFGCMPNF(int LFEFGCGCIAG, bool MJOMMNNHKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x62509A0", Offset = "0x624F1A0", VA = "0x1862509A0")]
	private void KLCGKLIDOBO(int LFEFGCGCIAG, Exception KPCACGLGOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x62504F0", Offset = "0x624ECF0", VA = "0x1862504F0")]
	private void BFPPCPNCLHP(CancellationToken EHCFBFBFEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public JPDCEDECMPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.NoEngine.Common.Preserve]
internal class PABIDAKLGLP : AJGGJOEDFAM, DMCCOCJCFNK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private struct ELJAPAFGCOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public FAPHDJICDBI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public PABIDAKLGLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public AKCDAENEHEC customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x62493B0", Offset = "0x6247BB0", VA = "0x1862493B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x6249D70", Offset = "0x6248570", VA = "0x186249D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct NAPNMPEOGED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public PABIDAKLGLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public FAPHDJICDBI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public AKCDAENEHEC customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private ANHHFLMKBPC<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private EBEIOKMCHFG <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private AGJKIBCHDBK <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x625A2D0", Offset = "0x6258AD0", VA = "0x18625A2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x625AED0", Offset = "0x62596D0", VA = "0x18625AED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class LGLJGLELLLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public Matchmaking.PDJGDDGMOFI result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public KMDEMOGEPEE errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public LGLJGLELLLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x6257E30", Offset = "0x6256630", VA = "0x186257E30")]
		internal object KDLIJGNBONF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class MIFJOPOGPGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public Task<MNHIEHBCOOD> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public MIFJOPOGPGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
		internal Task<MNHIEHBCOOD> OMDBOKDOMEA(ANHHFLMKBPC<string>.AJPBBELKCKG _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct KINMJHFFAOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public PABIDAKLGLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public FAPHDJICDBI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public AKCDAENEHEC customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public EBEIOKMCHFG joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private MIFJOPOGPGM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private FINJGDFJPJF <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private CABPPMPBKEH <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private Task<Matchmaking.DHLDAEGKICN> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private OIOLPIKBIHI <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private TaskAwaiter<Matchmaking.DHLDAEGKICN> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private CancellationToken <photonJoinedToken>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private Task <roomLoadTask>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private TaskAwaiter<MNHIEHBCOOD> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x6251720", Offset = "0x624FF20", VA = "0x186251720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6256510", Offset = "0x6254D10", VA = "0x186256510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct KNPBFDLLCOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public PABIDAKLGLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x6256740", Offset = "0x6254F40", VA = "0x186256740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x62571D0", Offset = "0x62559D0", VA = "0x1862571D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct DOCKKGGPOGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public PABIDAKLGLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private LLKIHBKOOLA <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x6248100", Offset = "0x6246900", VA = "0x186248100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x6248580", Offset = "0x6246D80", VA = "0x186248580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct NNKKNAAELBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public AsyncTaskMethodBuilder<Matchmaking.DHLDAEGKICN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public FAPHDJICDBI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public PABIDAKLGLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private TaskAwaiter<Matchmaking.DHLDAEGKICN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x625B470", Offset = "0x6259C70", VA = "0x18625B470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x625B950", Offset = "0x625A150", VA = "0x18625B950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct GOALECGPEKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public Matchmaking.DHLDAEGKICN serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public PABIDAKLGLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public EBEIOKMCHFG joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter<ENGKFENENDE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x624E070", Offset = "0x624C870", VA = "0x18624E070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x624E7A0", Offset = "0x624CFA0", VA = "0x18624E7A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class ALBMCEIGHLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public FAPHDJICDBI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public ALBMCEIGHLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x62456D0", Offset = "0x6243ED0", VA = "0x1862456D0")]
		internal object KFFHJPBLFEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x62455D0", Offset = "0x6243DD0", VA = "0x1862455D0")]
		internal string CDPCGALMNBN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct MIIHPIPIGJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public FAPHDJICDBI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public PABIDAKLGLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private ALBMCEIGHLF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6259640", Offset = "0x6257E40", VA = "0x186259640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x625A270", Offset = "0x6258A70", VA = "0x18625A270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct ODIMGNFPNAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public PABIDAKLGLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public EBEIOKMCHFG joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public MNHIEHBCOOD initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public FAPHDJICDBI targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public FINJGDFJPJF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x625C830", Offset = "0x625B030", VA = "0x18625C830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x625D140", Offset = "0x625B940", VA = "0x18625D140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct GBLCDHAEPPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public PABIDAKLGLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private CancellationTokenSource <timeoutTcs>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private CancellationToken <timeoutToken>5__7;

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x624C390", Offset = "0x624AB90", VA = "0x18624C390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x624DA30", Offset = "0x624C230", VA = "0x18624DA30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct GBDJNAFOGDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public EGEMJBICGKC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public PABIDAKLGLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private TaskAwaiter<ANOEFAFFECF> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x624BB00", Offset = "0x624A300", VA = "0x18624BB00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x624C330", Offset = "0x624AB30", VA = "0x18624C330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class KJMADEHAPAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public FAPHDJICDBI targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public KJMADEHAPAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6256570", Offset = "0x6254D70", VA = "0x186256570")]
		internal object APCPGPDJANG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class PKBCMGJJMJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public PKBCMGJJMJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6262200", Offset = "0x6260A00", VA = "0x186262200")]
		internal void ENHENKBEPHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class BLHONOOEIFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public FAPHDJICDBI targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public BLHONOOEIFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6246B30", Offset = "0x6245330", VA = "0x186246B30")]
		internal object KOEHCKCHDGI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class GKPEGGOMCEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public FAPHDJICDBI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public GKPEGGOMCEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x624DF70", Offset = "0x624C770", VA = "0x18624DF70")]
		internal string KDHJBPOLALG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly DGJIKJLGCCH PGAIEPGCLGI;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly DGJIKJLGCCH FFIDNOEBPOJ;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly DGJIKJLGCCH MPNIHBCNBMM;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly string GBMBEKGJPGB;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly string IHBHJKIMFBC;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly string LKECFDEJLJE;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static readonly Guid BGIMABAIGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private JGMGPMLOKAC CDMGHLCAIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private HEEPHCNKAAB NAFGPPDGGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private EMCLNBMIAFK JIAGCNOOLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private HKHECNIPIOJ LOJMHJJKLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private NHDKLDFMNOK HGOFPLJJILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private HKDPKLIFIKK JGKDMAIJPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private PMOEIHKACBO BDJBBEPJBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private PFHBEMNNDIC CGFCBDPFKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private PBJDCDGMCIN JLIIBGFDIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private CPKEAHBNHDJ DDFAFLADAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private IDisposable GOEEOHLCAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly JCNOBKCLCPM NMEDCEANLNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly JCNOBKCLCPM DLELOOKHAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private OIOLPIKBIHI PHLDPNBKLLG;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public TaskStatus DMFNDAKJOAG
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x955E60", Offset = "0x954660", VA = "0x180955E60", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x99EA70", Offset = "0x99D270", VA = "0x18099EA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private GEGICDFBGIP GAOPKHMLGDB
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x6260100", Offset = "0x625E900", VA = "0x186260100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x625F760", Offset = "0x625DF60", VA = "0x18625F760", Slot = "6")]
	public void GLJEDCMMNGN(HKHECNIPIOJ LOJMHJJKLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x625E370", Offset = "0x625CB70", VA = "0x18625E370", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x625DF80", Offset = "0x625C780", VA = "0x18625DF80", Slot = "5")]
	[AsyncStateMachine(typeof(ELJAPAFGCOH))]
	public Task CPGMNMIPNMJ(FAPHDJICDBI CAPMGFOKDKN, AKCDAENEHEC PIAMKFGNOIH, CancellationToken DINCIKDPHMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x625DC80", Offset = "0x625C480", VA = "0x18625DC80")]
	[AsyncStateMachine(typeof(NAPNMPEOGED))]
	private Task BPEKKHGJEPI(FAPHDJICDBI CAPMGFOKDKN, AKCDAENEHEC PIAMKFGNOIH, CancellationToken DINCIKDPHMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x6260BA0", Offset = "0x625F3A0", VA = "0x186260BA0")]
	private static void PPPBNFFNKHP(PBJDCDGMCIN JLIIBGFDIKP, FAPHDJICDBI CAPMGFOKDKN, Exception KPCACGLGOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x625E3C0", Offset = "0x625CBC0", VA = "0x18625E3C0")]
	private static void EEBDMPDILAN(AGJKIBCHDBK DHBDOOAGBKD, Exception KPCACGLGOPI, [Optional] List<int> CNGNFJDDJAI, int MFIMEDPAGPI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x625E1B0", Offset = "0x625C9B0", VA = "0x18625E1B0")]
	[AsyncStateMachine(typeof(KINMJHFFAOL))]
	private Task DMEDHJMPFAF(ANHHFLMKBPC<string>.AJPBBELKCKG AOGFPKDBLJK, FAPHDJICDBI CAPMGFOKDKN, AKCDAENEHEC PIAMKFGNOIH, EBEIOKMCHFG AFMEIIOIMPN, CancellationToken DINCIKDPHMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x625FFB0", Offset = "0x625E7B0", VA = "0x18625FFB0")]
	private void JCLFDMJKCDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x625DB50", Offset = "0x625C350", VA = "0x18625DB50")]
	[AsyncStateMachine(typeof(KNPBFDLLCOO))]
	private Task BLDAKCKGBDA(ANHHFLMKBPC<string>.AJPBBELKCKG AOGFPKDBLJK, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x625F420", Offset = "0x625DC20", VA = "0x18625F420")]
	private void GHADHGKPEOB(FAPHDJICDBI CAPMGFOKDKN, CancellationToken DINCIKDPHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x62606B0", Offset = "0x625EEB0", VA = "0x1862606B0")]
	private void OMFHHDAKCLF(FAPHDJICDBI CAPMGFOKDKN, EBEIOKMCHFG AFMEIIOIMPN, OperationCanceledException ANINDAAJDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x625FD80", Offset = "0x625E580", VA = "0x18625FD80")]
	private void IKAKJNEIINB(FAPHDJICDBI CAPMGFOKDKN, EBEIOKMCHFG AFMEIIOIMPN, Exception KPCACGLGOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x62602E0", Offset = "0x625EAE0", VA = "0x1862602E0")]
	private void LIPMDGEAOAA(FAPHDJICDBI CAPMGFOKDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x625E310", Offset = "0x625CB10", VA = "0x18625E310")]
	private static DEDIDPIECAL DNGGKDIGLFP(FAPHDJICDBI CAPMGFOKDKN)
	{
		return default(DEDIDPIECAL);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x625FCB0", Offset = "0x625E4B0", VA = "0x18625FCB0")]
	[AsyncStateMachine(typeof(DOCKKGGPOGI))]
	private Task IBEHBBCCCGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6260510", Offset = "0x625ED10", VA = "0x186260510")]
	[AsyncStateMachine(typeof(NNKKNAAELBO))]
	private Task<Matchmaking.DHLDAEGKICN> MMBGFKOAOBD(FAPHDJICDBI CAPMGFOKDKN, ANHHFLMKBPC<string>.AJPBBELKCKG AOGFPKDBLJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x625D720", Offset = "0x625BF20", VA = "0x18625D720")]
	private static ENGKFENENDE AEOOHBIMFLC(Matchmaking.DHLDAEGKICN ONLMDKENADC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x625F270", Offset = "0x625DA70", VA = "0x18625F270")]
	[AsyncStateMachine(typeof(GOALECGPEKL))]
	private Task GCKJPDOANHP(Matchmaking.DHLDAEGKICN ONLMDKENADC, EBEIOKMCHFG AFMEIIOIMPN, ANHHFLMKBPC<string>.AJPBBELKCKG AOGFPKDBLJK, CancellationToken CFOIEPEIFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x62608E0", Offset = "0x625F0E0", VA = "0x1862608E0")]
	[AsyncStateMachine(typeof(MIIHPIPIGJF))]
	private Task OPECBPHBLAO(FAPHDJICDBI CAPMGFOKDKN, CancellationTokenSource IEGPDFEDPBB, Task OJIIKIGIIDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6260A30", Offset = "0x625F230", VA = "0x186260A30")]
	[AsyncStateMachine(typeof(ODIMGNFPNAA))]
	private Task PJOMNFJJCFH(MNHIEHBCOOD NHKOJPMKFOA, FINJGDFJPJF PFAJALCKHDJ, FAPHDJICDBI BKLIDCPKLEM, EBEIOKMCHFG CHHJODKMIHD, ANHHFLMKBPC<string>.AJPBBELKCKG AOGFPKDBLJK, CancellationToken IOJNADPOCIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x625D830", Offset = "0x625C030", VA = "0x18625D830")]
	private EBEIOKMCHFG AFPODBFPMBK(EBEIOKMCHFG CHHJODKMIHD, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x625EDF0", Offset = "0x625D5F0", VA = "0x18625EDF0")]
	[AsyncStateMachine(typeof(GBLCDHAEPPD))]
	private Task EPMEFMHFNHF(ANHHFLMKBPC<string>.AJPBBELKCKG AOGFPKDBLJK, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x625DA30", Offset = "0x625C230", VA = "0x18625DA30")]
	[AsyncStateMachine(typeof(GBDJNAFOGDO))]
	private Task BGPJEEDKFPH(EGEMJBICGKC AELCABDCBDD, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x625F0F0", Offset = "0x625D8F0", VA = "0x18625F0F0")]
	private static void FPJGFEEBKGD(FAPHDJICDBI CAPMGFOKDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x625EF20", Offset = "0x625D720", VA = "0x18625EF20")]
	private void EPPECHFIDLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x625EC50", Offset = "0x625D450", VA = "0x18625EC50")]
	private void EFFLFKAIHDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x625FC20", Offset = "0x625E420", VA = "0x18625FC20")]
	private void GPMFDNKCDIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6260150", Offset = "0x625E950", VA = "0x186260150")]
	private void KMGMNJDFHHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x625E0C0", Offset = "0x625C8C0", VA = "0x18625E0C0")]
	private static void DFDMNBIOPNI(FAPHDJICDBI CAPMGFOKDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x625ECE0", Offset = "0x625D4E0", VA = "0x18625ECE0")]
	private static CancellationTokenRegistration EOBKGICKILN(FAPHDJICDBI CAPMGFOKDKN, CancellationToken CFOIEPEIFHO)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x62601E0", Offset = "0x625E9E0", VA = "0x1862601E0")]
	private static void LAJOMCODFJA(FAPHDJICDBI CAPMGFOKDKN, Exception KPCACGLGOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x625DDD0", Offset = "0x625C5D0", VA = "0x18625DDD0")]
	private void CAKLFFLIIHN(FAPHDJICDBI CAPMGFOKDKN, Task OJIIKIGIIDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6260650", Offset = "0x625EE50", VA = "0x186260650")]
	private static void NOCJPHOMELN(Func<string> JODJCGEJGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6261180", Offset = "0x625F980", VA = "0x186261180")]
	public PABIDAKLGLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x625F3C0", Offset = "0x625DBC0", VA = "0x18625F3C0")]
	[CompilerGenerated]
	internal static (int, int?) GEAOCHOAMCB(KMDEMOGEPEE DFJHGAEKCEE)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[UnityEngine.Scripting.Preserve]
internal class PAKCHOJPDHL : GPGGGCMILBN, DMCCOCJCFNK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct NLMONANJNBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public PAKCHOJPDHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public EGEMJBICGKC roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x625AF30", Offset = "0x6259730", VA = "0x18625AF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x625B410", Offset = "0x6259C10", VA = "0x18625B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private sealed class FJILOJHKEHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public PAKCHOJPDHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public EGEMJBICGKC roomData;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public FJILOJHKEHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x626B410", Offset = "0x6269C10", VA = "0x18626B410")]
		internal List<Task> JLJBAADJNEO(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct CIDIGEOINPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public IBMNOJHFFNF taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public EGEMJBICGKC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6268680", Offset = "0x6266E80", VA = "0x186268680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6268A50", Offset = "0x6267250", VA = "0x186268A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct AGDACCDCOJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public PAKCHOJPDHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6264140", Offset = "0x6262940", VA = "0x186264140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6264400", Offset = "0x6262C00", VA = "0x186264400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly HashSet<IBMNOJHFFNF> ACGIFINEFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private HEEPHCNKAAB NAFGPPDGGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private HKHECNIPIOJ LOJMHJJKLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private IIPGDPEJJMH EKOLMLNGLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private PMCAAEOCKIK ABMDCKJOPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private IDisposable GOEEOHLCAJF;

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x6261720", Offset = "0x625FF20", VA = "0x186261720", Slot = "5")]
	public void GLJEDCMMNGN(HKHECNIPIOJ LOJMHJJKLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x6261250", Offset = "0x625FA50", VA = "0x186261250", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x6261FF0", Offset = "0x62607F0", VA = "0x186261FF0", Slot = "4")]
	public bool PPFOAPLBGFO(IBMNOJHFFNF GDFIGPGPEFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x6261EB0", Offset = "0x62606B0", VA = "0x186261EB0")]
	private void PLMKEMKGIMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x6261B60", Offset = "0x6260360", VA = "0x186261B60")]
	private void OMIHEDMFGGB(EGEMJBICGKC KAGMDCLCJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x62619A0", Offset = "0x62601A0", VA = "0x1862619A0")]
	[AsyncStateMachine(typeof(NLMONANJNBL))]
	private Task HHCHGOMAOFA(EGEMJBICGKC KAGMDCLCJHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x6261A90", Offset = "0x6260290", VA = "0x186261A90")]
	private Func<CancellationToken, List<Task>> MOBEHHJOODF(EGEMJBICGKC KAGMDCLCJHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x62612B0", Offset = "0x625FAB0", VA = "0x1862612B0")]
	private List<Task> GJLCEFOFBNC(EGEMJBICGKC KAGMDCLCJHI, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x6262050", Offset = "0x6260850", VA = "0x186262050")]
	[AsyncStateMachine(typeof(CIDIGEOINPC))]
	private Task PPNMHLFMJEC(IBMNOJHFFNF EMFGPDGANAF, EGEMJBICGKC AELCABDCBDD, CancellationToken KIAKEGJPMAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6261D60", Offset = "0x6260560", VA = "0x186261D60")]
	[AsyncStateMachine(typeof(AGDACCDCOJG))]
	private Task ONGBFBHMJEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6261E30", Offset = "0x6260630", VA = "0x186261E30")]
	private void PJCBOPOMMKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6262170", Offset = "0x6260970", VA = "0x186262170")]
	public PAKCHOJPDHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[UnityEngine.Scripting.Preserve]
internal sealed class OINGEOPMIEG : OLFBMLBGCAP, DMCCOCJCFNK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class OAAIFKJFJLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public OAAIFKJFJLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x627CAF0", Offset = "0x627B2F0", VA = "0x18627CAF0")]
		internal object FKBICEIICLI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class PHJGKJKLHDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public PHJGKJKLHDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x62823C0", Offset = "0x6280BC0", VA = "0x1862823C0")]
		internal object BIDLADJLEKB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class NAPEGMDFFAM
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public NAPEGMDFFAM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class FNDNCBAMCGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public FNDNCBAMCGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x626B440", Offset = "0x6269C40", VA = "0x18626B440")]
		internal object HIFOBNBPEMF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class JFJHAPHPIOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public JFJHAPHPIOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6270CD0", Offset = "0x626F4D0", VA = "0x186270CD0")]
		internal object EANCHADPOIH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private readonly Dictionary<Guid, KEGOLPLPEEA> DNNFAIHNCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private readonly TimeSpan ANEMDABBBNO;

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "9")]
	public void GLJEDCMMNGN(HKHECNIPIOJ LOJMHJJKLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x627FB30", Offset = "0x627E330", VA = "0x18627FB30", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x627F900", Offset = "0x627E100", VA = "0x18627F900", Slot = "4")]
	public KDGDHFBEFOP BONJGFNEKBE(Guid BACFDICONIG)
	{
		return default(KDGDHFBEFOP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6280340", Offset = "0x627EB40", VA = "0x186280340", Slot = "5")]
	public bool PJFBCFIPABD(Guid BACFDICONIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x627FB40", Offset = "0x627E340", VA = "0x18627FB40", Slot = "6")]
	public bool FDBNEELDOFI(Guid BACFDICONIG, Task FJNDBCBLLJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x62800D0", Offset = "0x627E8D0", VA = "0x1862800D0", Slot = "7")]
	public bool GPJPLDGJKBA(Guid BACFDICONIG, ANOEFAFFECF FPCACMBMLBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x62802D0", Offset = "0x627EAD0", VA = "0x1862802D0", Slot = "8")]
	public Task<(ANOEFAFFECF, Task)> HFAGLILCHLO(Guid BACFDICONIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x627FE90", Offset = "0x627E690", VA = "0x18627FE90")]
	private void GGOPJEANBNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x6280570", Offset = "0x627ED70", VA = "0x186280570")]
	public OINGEOPMIEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[UnityEngine.Scripting.Preserve]
internal class OBMKHLOJJDK : OMMFIKHIIFB, DMCCOCJCFNK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private class LJCPEGNMIPL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private readonly FAPHDJICDBI BNAABMJLIMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private readonly CancellationTokenSource PDCJAGPLKHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public readonly CancellationToken IAKAFKKJDJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private bool FMJKPGNBNOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private bool CBPCANBMLCP;

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x6274880", Offset = "0x6273080", VA = "0x186274880")]
		public LJCPEGNMIPL(FAPHDJICDBI BNAABMJLIMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x6274730", Offset = "0x6272F30", VA = "0x186274730")]
		public void PJCBOPOMMKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x6274700", Offset = "0x6272F00", VA = "0x186274700", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class JAKDKKNLJDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public LADONBJPHPE disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public JAKDKKNLJDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x6270C40", Offset = "0x626F440", VA = "0x186270C40")]
		internal object LHNKEPECFAG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private struct OPOJNMGGCFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public LADONBJPHPE disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public OBMKHLOJJDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x6281930", Offset = "0x6280130", VA = "0x186281930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x6281D60", Offset = "0x6280560", VA = "0x186281D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class ADONJCCBKJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public ADONJCCBKJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x6264030", Offset = "0x6262830", VA = "0x186264030")]
		internal object APKNHMIOOKD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct IOEEDKHGMCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public OBMKHLOJJDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x626F170", Offset = "0x626D970", VA = "0x18626F170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x840DA0", Offset = "0x83F5A0", VA = "0x180840DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class IECGLGGCIDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public FAPHDJICDBI newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public IECGLGGCIDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x626EBB0", Offset = "0x626D3B0", VA = "0x18626EBB0")]
		internal object EBFONCNJMKP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x626EB70", Offset = "0x626D370", VA = "0x18626EB70")]
		internal object BJDMJGMBHCL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x626EB30", Offset = "0x626D330", VA = "0x18626EB30")]
		internal object BBBEDBJHLAH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class AEEDDDPHNOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public AEEDDDPHNOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x62640A0", Offset = "0x62628A0", VA = "0x1862640A0")]
		internal void GAPKJOBHMBE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private struct BGMNCLIACHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public FAPHDJICDBI newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public OBMKHLOJJDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public AKCDAENEHEC customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private IECGLGGCIDA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x6266500", Offset = "0x6264D00", VA = "0x186266500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x6267510", Offset = "0x6265D10", VA = "0x186267510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private static readonly EGAAFGAINAD.MNJGOKFLMBE GBMCMBPPLAP;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private static readonly ABLOGMIMFGM PCLEMPMGNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private HEEPHCNKAAB NAFGPPDGGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private HKHECNIPIOJ LOJMHJJKLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private HKDPKLIFIKK JGKDMAIJPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private NHDKLDFMNOK HGOFPLJJILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private JPCCDPCHOFD IKANDDIAENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private AJGGJOEDFAM MGDHDGAHABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private long MFDHMCMLGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private LJCPEGNMIPL OIAHKEODICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private bool BJCCNPEJPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private Task PJFGKFLFMHP;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private GEGICDFBGIP GAOPKHMLGDB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x627D760", Offset = "0x627BF60", VA = "0x18627D760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool FNDPPCPCJOB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0xA3DC70", Offset = "0xA3C470", VA = "0x180A3DC70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x627D550", Offset = "0x627BD50", VA = "0x18627D550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x627D2B0", Offset = "0x627BAB0", VA = "0x18627D2B0", Slot = "4")]
	public void GLJEDCMMNGN(HKHECNIPIOJ LOJMHJJKLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x627CE80", Offset = "0x627B680", VA = "0x18627CE80", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x627CC60", Offset = "0x627B460", VA = "0x18627CC60")]
	[AsyncStateMachine(typeof(OPOJNMGGCFH))]
	private Task BNAJMMNFEEP(LADONBJPHPE CJJNALPCMIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x627DA40", Offset = "0x627C240", VA = "0x18627DA40")]
	private void NMPIDMLOEBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x627D110", Offset = "0x627B910", VA = "0x18627D110")]
	private void FBIANLBBJKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x627D560", Offset = "0x627BD60", VA = "0x18627D560")]
	private void HFJKIKJHDFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x627D6F0", Offset = "0x627BEF0", VA = "0x18627D6F0")]
	private bool HHGEFOAHJMB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x627D040", Offset = "0x627B840", VA = "0x18627D040")]
	[AsyncStateMachine(typeof(IOEEDKHGMCI))]
	private void EECPONEDCHG(int DMAJKGMCJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x627D7B0", Offset = "0x627BFB0", VA = "0x18627D7B0")]
	private void MMHLIOHNNGC([Out] IDisposable DCDDKKGCLJF, [Out] IDisposable MOKAJCIOJPE, [Out] IDisposable AJOLMAPKPLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x627CB50", Offset = "0x627B350", VA = "0x18627CB50")]
	private bool AFCCCMLFBIM(FAPHDJICDBI BNAABMJLIMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x627CFF0", Offset = "0x627B7F0", VA = "0x18627CFF0")]
	private void ECEGELIAIIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x627CD50", Offset = "0x627B550", VA = "0x18627CD50")]
	[AsyncStateMachine(typeof(BGMNCLIACHN))]
	private Task BPEKKHGJEPI(FAPHDJICDBI BNAABMJLIMF, AKCDAENEHEC PIAMKFGNOIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x627DFD0", Offset = "0x627C7D0", VA = "0x18627DFD0")]
	public OBMKHLOJJDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[UnityEngine.Scripting.Preserve]
internal sealed class HIJJNKLHADC : EILOFBEIBKF, DMCCOCJCFNK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct GAMJEGNCHJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public AsyncTaskMethodBuilder<JNPLDNDBBJJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public HIJJNKLHADC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private TaskAwaiter<JNPLDNDBBJJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x626B960", Offset = "0x626A160", VA = "0x18626B960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x626BBB0", Offset = "0x626A3B0", VA = "0x18626BBB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class DLKNGBBLAIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public GEAEOIJPPME message;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public DLKNGBBLAIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x626AF90", Offset = "0x6269790", VA = "0x18626AF90")]
		internal object DENDLJHJCPC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class OKDGAENNHFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public GEAEOIJPPME messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public OKDGAENNHFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x6280BA0", Offset = "0x627F3A0", VA = "0x186280BA0")]
		internal object DMJGIIODFMP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class EFILDPGODCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public GEAEOIJPPME request;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public EFILDPGODCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x626B060", Offset = "0x6269860", VA = "0x18626B060")]
		internal object DHOPCHGKCGA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct CNKOLMPHJFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public GEAEOIJPPME request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public HIJJNKLHADC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private TaskAwaiter<OFOHOILEKAB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x6268AB0", Offset = "0x62672B0", VA = "0x186268AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x62693C0", Offset = "0x6267BC0", VA = "0x1862693C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class IOGIDJEIBAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public GEAEOIJPPME operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public IOGIDJEIBAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x6270360", Offset = "0x626EB60", VA = "0x186270360")]
		internal object NFDCCHIJJLC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct DFHKMLCGAAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public GEAEOIJPPME operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public HIJJNKLHADC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private EBEIOKMCHFG <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private TaskAwaiter<GEAEOIJPPME> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x6269420", Offset = "0x6267C20", VA = "0x186269420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x6269FD0", Offset = "0x62687D0", VA = "0x186269FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct GKHCCJABHIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public AsyncTaskMethodBuilder<OFOHOILEKAB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public HIJJNKLHADC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public GEAEOIJPPME request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private IEFCONNFBHB.ENAFKNBCDDF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private EBEIOKMCHFG <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private TaskAwaiter<GEAEOIJPPME> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x626BDE0", Offset = "0x626A5E0", VA = "0x18626BDE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x626C300", Offset = "0x626AB00", VA = "0x18626C300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class AKFNOJOAKPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public OFOHOILEKAB operation;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public AKFNOJOAKPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x6265190", Offset = "0x6263990", VA = "0x186265190")]
		internal object OPOKIFJHGBH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private struct GOOHJOPLPNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public OFOHOILEKAB operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public HIJJNKLHADC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private ANHHFLMKBPC<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x626CB20", Offset = "0x626B320", VA = "0x18626CB20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x626D1A0", Offset = "0x626B9A0", VA = "0x18626D1A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class BJPFIHMFEKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public GEAEOIJPPME request;

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public BJPFIHMFEKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6267F50", Offset = "0x6266750", VA = "0x186267F50")]
		internal object KHIPNBDNLCC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class PFPIHOLJKGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public GEAEOIJPPME request;

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public PFPIHOLJKGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x6282360", Offset = "0x6280B60", VA = "0x186282360")]
		internal object MIPBIMFNNLA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private HKHECNIPIOJ LOJMHJJKLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private PMOEIHKACBO BDJBBEPJBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private PABNMGIMAJM LEFKIFEFKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private GJEGGLJCIKF IIIAFBIONCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private EMCLNBMIAFK JIAGCNOOLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private TaskCompletionSource<JNPLDNDBBJJ> LLNNFGNLGFK;

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x626D960", Offset = "0x626C160", VA = "0x18626D960", Slot = "7")]
	public void GLJEDCMMNGN(HKHECNIPIOJ LOJMHJJKLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x626D7C0", Offset = "0x626BFC0", VA = "0x18626D7C0", Slot = "6")]
	[AsyncStateMachine(typeof(GAMJEGNCHJG))]
	public Task<JNPLDNDBBJJ> BNDKHEIBEGD(CancellationToken EGFKINNLJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x626E250", Offset = "0x626CA50", VA = "0x18626E250", Slot = "4")]
	public void LDJCHAPMBDC(GEAEOIJPPME BKGEBGGPBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x626DA50", Offset = "0x626C250", VA = "0x18626DA50", Slot = "5")]
	public void HLFCDIDJLFH(GEAEOIJPPME EDBKMMIOBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x626E710", Offset = "0x626CF10", VA = "0x18626E710")]
	[AsyncStateMachine(typeof(CNKOLMPHJFD))]
	private Task OKENEOAHAFD(GEAEOIJPPME LJEEHJLDFLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x626DDC0", Offset = "0x626C5C0", VA = "0x18626DDC0")]
	[AsyncStateMachine(typeof(DFHKMLCGAAK))]
	private Task IFKFAALENKP(GEAEOIJPPME JEFDCBJLPFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x626DED0", Offset = "0x626C6D0", VA = "0x18626DED0")]
	[AsyncStateMachine(typeof(GKHCCJABHIA))]
	private Task<OFOHOILEKAB> JONEJHMOKEM(GEAEOIJPPME LJEEHJLDFLC, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x626D8D0", Offset = "0x626C0D0", VA = "0x18626D8D0")]
	private EBEIOKMCHFG FELKLKAJKID(GEAEOIJPPME COLIIFENAOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x626E5F0", Offset = "0x626CDF0", VA = "0x18626E5F0")]
	[AsyncStateMachine(typeof(GOOHJOPLPNL))]
	private Task MOEBLMMMLMI(OFOHOILEKAB NFBNNCDBMIA, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x626E020", Offset = "0x626C820", VA = "0x18626E020")]
	private OFOHOILEKAB KCAMMEPPMJH(GEAEOIJPPME LJEEHJLDFLC, EBEIOKMCHFG LLNAJFDAEHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2383010", Offset = "0x2381810", VA = "0x182383010")]
	private T KFEPBIENCDD<T>(T FKKGMPDEPMA) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x626D420", Offset = "0x626BC20", VA = "0x18626D420")]
	private OFOHOILEKAB AAFMIJDLLBC(GEAEOIJPPME LJEEHJLDFLC, EBEIOKMCHFG LLNAJFDAEHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public HIJJNKLHADC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[UnityEngine.Scripting.Preserve]
internal sealed class MOLPAMOFLAE : PABNMGIMAJM, DMCCOCJCFNK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class BJAHBPKEAKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public BJAHBPKEAKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x6267EE0", Offset = "0x62666E0", VA = "0x186267EE0")]
		internal object BKIJMCCCCNA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class HNKAOAEECBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public HNKAOAEECBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x626E920", Offset = "0x626D120", VA = "0x18626E920")]
		internal object IENJAEGDLKK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private EMCLNBMIAFK JIAGCNOOLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private MNHBODFFBLI CPFGJIIMOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private EILOFBEIBKF FHDMABIEMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private OLFBMLBGCAP DNNFAIHNCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private HEBNOFFIONN ENNHBACDBLM;

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x62772D0", Offset = "0x6275AD0", VA = "0x1862772D0", Slot = "6")]
	public void GLJEDCMMNGN(HKHECNIPIOJ LOJMHJJKLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x6276C00", Offset = "0x6275400", VA = "0x186276C00", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x62776C0", Offset = "0x6275EC0", VA = "0x1862776C0", Slot = "4")]
	public KDGDHFBEFOP KGADHKNGLMK(GEAEOIJPPME LHCIAHEJGAA)
	{
		return default(KDGDHFBEFOP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6278600", Offset = "0x6276E00", VA = "0x186278600", Slot = "5")]
	public void OPIGAJJPFHA(Guid BACFDICONIG, Task FJNDBCBLLJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6276EE0", Offset = "0x62756E0", VA = "0x186276EE0")]
	private void GCMPBNKPHLD(byte DFBOOPBNIGI, int NOEJIEGJBEK, object OCMCNHPAAMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x6278030", Offset = "0x6276830", VA = "0x186278030")]
	private void ONCGPBOIMNH(NHBOIMDDLCH HOCFILEOKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6276FB0", Offset = "0x62757B0", VA = "0x186276FB0")]
	private void GHEHFFDNOFF(NHBOIMDDLCH HOCFILEOKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6276710", Offset = "0x6274F10", VA = "0x186276710")]
	private void BDAEPJHEHAP(NHBOIMDDLCH HOCFILEOKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6277DD0", Offset = "0x62765D0", VA = "0x186277DD0")]
	private ANOEFAFFECF MLPDICOLAGL(GEAEOIJPPME COLIIFENAOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6276CB0", Offset = "0x62754B0", VA = "0x186276CB0")]
	private void FNAIGJINCJO(GEAEOIJPPME JEFDCBJLPFG, ANOEFAFFECF FPCACMBMLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6277B10", Offset = "0x6276310", VA = "0x186277B10")]
	private bool MLNHFGPFPLM(GEAEOIJPPME JEFDCBJLPFG, ANOEFAFFECF FPCACMBMLBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6277440", Offset = "0x6275C40", VA = "0x186277440")]
	private bool HAEEPIGLJBN(GEAEOIJPPME BGMHEBEFNCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x6276960", Offset = "0x6275160", VA = "0x186276960")]
	private bool DBPBLPIPBDN(byte DFBOOPBNIGI, ExitGames.Client.Photon.Hashtable HOCFILEOKMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public MOLPAMOFLAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[UnityEngine.Scripting.Preserve]
internal sealed class INNOEPKILOC : IKCOGABLLKF, DMCCOCJCFNK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class IAGNKFPCBFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public JNPLDNDBBJJ operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public INNOEPKILOC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public GEAEOIJPPME roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public IAGNKFPCBFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x626E990", Offset = "0x626D190", VA = "0x18626E990")]
		internal object FJJAHALAJKB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x626EA00", Offset = "0x626D200", VA = "0x18626EA00")]
		internal object NEFNCGCPKLB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private struct AKIMIHHMKHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public AsyncTaskMethodBuilder<ANOEFAFFECF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public INNOEPKILOC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public GEAEOIJPPME roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private TaskAwaiter<ANOEFAFFECF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x6265210", Offset = "0x6263A10", VA = "0x186265210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x62658F0", Offset = "0x62640F0", VA = "0x1862658F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class GJDJPCKNMHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public JNPLDNDBBJJ operationType;

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public GJDJPCKNMHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x626BD70", Offset = "0x626A570", VA = "0x18626BD70")]
		internal object NJNBIGGBBPO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class GCIHDHAKENN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public GEAEOIJPPME request;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public GCIHDHAKENN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x626BD00", Offset = "0x626A500", VA = "0x18626BD00")]
		internal object MPINLOJDBEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x626BC90", Offset = "0x626A490", VA = "0x18626BC90")]
		internal object HHODGMMMIFM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x626BC20", Offset = "0x626A420", VA = "0x18626BC20")]
		internal object GJBMOCCEDAH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct BHNDJJBHJGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public AsyncTaskMethodBuilder<ANOEFAFFECF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public GEAEOIJPPME request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public INNOEPKILOC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private GCIHDHAKENN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private KDGDHFBEFOP <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private ANOEFAFFECF <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private TaskAwaiter<(ANOEFAFFECF validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x6267570", Offset = "0x6265D70", VA = "0x186267570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x6267E70", Offset = "0x6266670", VA = "0x186267E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private EMCLNBMIAFK JIAGCNOOLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private MNHBODFFBLI CPFGJIIMOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private PABNMGIMAJM LEFKIFEFKPC;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x626EE60", Offset = "0x626D660", VA = "0x18626EE60", Slot = "5")]
	public void GLJEDCMMNGN(HKHECNIPIOJ LOJMHJJKLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x626EF10", Offset = "0x626D710", VA = "0x18626EF10", Slot = "4")]
	[AsyncStateMachine(typeof(AKIMIHHMKHA))]
	private Task<ANOEFAFFECF> IJGFGGCFNMG(GEAEOIJPPME COLIIFENAOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x626EC50", Offset = "0x626D450", VA = "0x18626EC50")]
	private bool GJKIKDFHCKF(JNPLDNDBBJJ AMKPPIJBFNG, [Out] ANOEFAFFECF KMHAEDONIKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x626F030", Offset = "0x626D830", VA = "0x18626F030")]
	[AsyncStateMachine(typeof(BHNDJJBHJGC))]
	private Task<ANOEFAFFECF> LPJINMIFCAO(GEAEOIJPPME LJEEHJLDFLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public INNOEPKILOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class ALNBNOFHIPF : ALBKEKEEMGG, DMCCOCJCFNK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct ONCPNMCIHMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public AsyncTaskMethodBuilder<MNHIEHBCOOD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public FAPHDJICDBI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public ALNBNOFHIPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private TaskAwaiter<MEGCEJKCLCC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x6280C60", Offset = "0x627F460", VA = "0x186280C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x6281110", Offset = "0x627F910", VA = "0x186281110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class CBFDJPBHKHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public CBFDJPBHKHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x6268570", Offset = "0x6266D70", VA = "0x186268570")]
		internal object NKCHKIMDDCP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct NKMDPDCIPHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public AsyncTaskMethodBuilder<MEGCEJKCLCC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public ALNBNOFHIPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public FAPHDJICDBI targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private CBFDJPBHKHC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private TaskAwaiter<MEGCEJKCLCC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x627B490", Offset = "0x6279C90", VA = "0x18627B490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x627BA80", Offset = "0x627A280", VA = "0x18627BA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class HKBEPJMKDIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public HKBEPJMKDIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x1306F30", Offset = "0x1305730", VA = "0x181306F30")]
		internal bool FHPBGPCAKLK(ILPOHKEMFGB sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private NHDKLDFMNOK HGOFPLJJILB;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private static readonly (FINMELMELDP superRoomData, long subRoomDataSaveId) CGNAADBDNBD;

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x6265AC0", Offset = "0x62642C0", VA = "0x186265AC0", Slot = "5")]
	public void GLJEDCMMNGN(HKHECNIPIOJ LOJMHJJKLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x6265FB0", Offset = "0x62647B0", VA = "0x186265FB0", Slot = "4")]
	[AsyncStateMachine(typeof(ONCPNMCIHMG))]
	public Task<MNHIEHBCOOD> NKNPFAIOBDK(ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, FAPHDJICDBI CAPMGFOKDKN, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x6265960", Offset = "0x6264160", VA = "0x186265960")]
	[AsyncStateMachine(typeof(NKMDPDCIPHE))]
	private Task<MEGCEJKCLCC> DAHCNOGNDOC(FAPHDJICDBI CAPMGFOKDKN, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x6265E70", Offset = "0x6264670", VA = "0x186265E70")]
	private MNHIEHBCOOD LDOAOBJEKAP(FAPHDJICDBI CAPMGFOKDKN, MEGCEJKCLCC FMODJNJIODP, long OMOMGBJOLII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x6265B30", Offset = "0x6264330", VA = "0x186265B30")]
	private (FINMELMELDP, long) KCHIIODKBOM(FAPHDJICDBI CAPMGFOKDKN, MEGCEJKCLCC FMODJNJIODP, long OMOMGBJOLII)
	{
		return default((FINMELMELDP, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public ALNBNOFHIPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[UnityEngine.Scripting.Preserve]
internal sealed class JNINBJNLNJB : GJEGGLJCIKF, DMCCOCJCFNK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class CCEDMODKICG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public GEAEOIJPPME request;

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public CCEDMODKICG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x6268620", Offset = "0x6266E20", VA = "0x186268620")]
		internal object BFGONPFMPPC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct AIDCPJDNEJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public AsyncTaskMethodBuilder<GEAEOIJPPME> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public GEAEOIJPPME request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public JNINBJNLNJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public EBEIOKMCHFG pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private TaskAwaiter<GEAEOIJPPME> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x6264460", Offset = "0x6262C60", VA = "0x186264460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x6264AA0", Offset = "0x62632A0", VA = "0x186264AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct PJMDIIDIFEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public AsyncTaskMethodBuilder<GEAEOIJPPME> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public JNINBJNLNJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public EBEIOKMCHFG pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private TaskAwaiter<CKGFMOEPEDA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x6282420", Offset = "0x6280C20", VA = "0x186282420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x6282A50", Offset = "0x6281250", VA = "0x186282A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class LNHPNDCAONC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public GEAEOIJPPME request;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public LNHPNDCAONC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x6274FB0", Offset = "0x62737B0", VA = "0x186274FB0")]
		internal object EMNPKPNDFBK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct OGFHBOBEKFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public AsyncTaskMethodBuilder<GEAEOIJPPME> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public GEAEOIJPPME request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public JNINBJNLNJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public EBEIOKMCHFG pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private KHFDFFIDAJM <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private IKJNFLEGBEL <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private TaskAwaiter<CKGFMOEPEDA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x627E040", Offset = "0x627C840", VA = "0x18627E040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x627EC60", Offset = "0x627D460", VA = "0x18627EC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private EMCLNBMIAFK JIAGCNOOLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private NHOAIGNOOHK CALLOFHIPKB;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private FBKGNJKHOII FJBLAJAEKML
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x6272A70", Offset = "0x6271270", VA = "0x186272A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x6272B30", Offset = "0x6271330", VA = "0x186272B30", Slot = "8")]
	public void GLJEDCMMNGN(HKHECNIPIOJ LOJMHJJKLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x6272910", Offset = "0x6271110", VA = "0x186272910", Slot = "4")]
	[AsyncStateMachine(typeof(AIDCPJDNEJD))]
	public Task<GEAEOIJPPME> FGGBLMOJOAM(GEAEOIJPPME LJEEHJLDFLC, EBEIOKMCHFG LLNAJFDAEHL, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x6272BC0", Offset = "0x62713C0", VA = "0x186272BC0", Slot = "5")]
	[AsyncStateMachine(typeof(PJMDIIDIFEM))]
	public Task<GEAEOIJPPME> KEIDICNHCKO(CancellationToken EHCFBFBFEDH, EBEIOKMCHFG LLNAJFDAEHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x6272D00", Offset = "0x6271500", VA = "0x186272D00", Slot = "6")]
	public MNLGPGKPHPA MFGEEHJCLEC(OFOHOILEKAB BNDODLKMLLH, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x6272580", Offset = "0x6270D80", VA = "0x186272580", Slot = "7")]
	public MNLGPGKPHPA APANCFGMMGP(OFOHOILEKAB BNDODLKMLLH, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x62727B0", Offset = "0x6270FB0", VA = "0x1862727B0")]
	[AsyncStateMachine(typeof(OGFHBOBEKFK))]
	private Task<GEAEOIJPPME> EELNCPNIHBF(GEAEOIJPPME LJEEHJLDFLC, EBEIOKMCHFG LLNAJFDAEHL, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x2455D90", Offset = "0x2454590", VA = "0x182455D90")]
	private static byte[] GCEGOPGOLID(GEAEOIJPPME BKGEBGGPBLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public JNINBJNLNJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[UnityEngine.Scripting.Preserve]
internal sealed class JPJPOJNJPEO : MNHBODFFBLI, DMCCOCJCFNK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private FILLDCCIKAF BCOJFHNKCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private EMCLNBMIAFK JIAGCNOOLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private PMOEIHKACBO BDJBBEPJBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private NACFABKEACP BJLGPNNNLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private NHDKLDFMNOK HGOFPLJJILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private AJGGJOEDFAM MGDHDGAHABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private GPGGGCMILBN MEIBLKIIFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private JPCCDPCHOFD IKANDDIAENK;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private GEGICDFBGIP GAOPKHMLGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x6273410", Offset = "0x6271C10", VA = "0x186273410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private static ANOEFAFFECF OPEJMADNALA
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x62733B0", Offset = "0x6271BB0", VA = "0x1862733B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x6273240", Offset = "0x6271A40", VA = "0x186273240", Slot = "6")]
	public void GLJEDCMMNGN(HKHECNIPIOJ LOJMHJJKLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x6273460", Offset = "0x6271C60", VA = "0x186273460", Slot = "4")]
	public ANOEFAFFECF MBMNFCJJKMP(JLNLBCDKCMG KGHDFCJAHGF, JNPLDNDBBJJ LILDKJDGMDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x6272F70", Offset = "0x6271770", VA = "0x186272F70", Slot = "5")]
	public ANOEFAFFECF EICJHNDJCOP(JLNLBCDKCMG MLBPFKHFGPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x6272F10", Offset = "0x6271710", VA = "0x186272F10")]
	private static ANOEFAFFECF BJFEKFMMKDE(HCNKAAALKFM OGMICOLLEPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public JPJPOJNJPEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public class NDAGAEJMFNI : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x6278F40", Offset = "0x6277740", VA = "0x186278F40")]
	public NDAGAEJMFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x58D0D00", Offset = "0x58CF500", VA = "0x1858D0D00")]
	public NDAGAEJMFNI(string BKGEBGGPBLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[UnityEngine.Scripting.Preserve]
internal sealed class NPBAGKNEHKM : IDEOMGMIEJK, DMCCOCJCFNK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct OHEDALMHLHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public AsyncTaskMethodBuilder<ANOEFAFFECF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public NPBAGKNEHKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public OBLPPCHKGBB autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private ANHHFLMKBPC<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private MOIOBFIDCML <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private TaskAwaiter<ANOEFAFFECF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x627ECD0", Offset = "0x627D4D0", VA = "0x18627ECD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x627F890", Offset = "0x627E090", VA = "0x18627F890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct GNLKCNJCNMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public NPBAGKNEHKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x626C370", Offset = "0x626AB70", VA = "0x18626C370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x626CAC0", Offset = "0x626B2C0", VA = "0x18626CAC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct OJMEOJGAEAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public NPBAGKNEHKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x6280630", Offset = "0x627EE30", VA = "0x186280630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x6280B40", Offset = "0x627F340", VA = "0x186280B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct ONKLKHBOAKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public NPBAGKNEHKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x6281180", Offset = "0x627F980", VA = "0x186281180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x62818D0", Offset = "0x62800D0", VA = "0x1862818D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct BEJFFDLOGBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public NPBAGKNEHKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x6266300", Offset = "0x6264B00", VA = "0x186266300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x62664A0", Offset = "0x6264CA0", VA = "0x1862664A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct DJJJCEFOJJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public NPBAGKNEHKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x626A810", Offset = "0x6269010", VA = "0x18626A810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x626AF30", Offset = "0x6269730", VA = "0x18626AF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct NFKBNINLLCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public NPBAGKNEHKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x6278F80", Offset = "0x6277780", VA = "0x186278F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x62793F0", Offset = "0x6277BF0", VA = "0x1862793F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct LLKJGNCIBOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public NPBAGKNEHKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public GGAEDDPGPFL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private ANHHFLMKBPC<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x6274930", Offset = "0x6273130", VA = "0x186274930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x6274E70", Offset = "0x6273670", VA = "0x186274E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private EMCLNBMIAFK JIAGCNOOLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private HKHECNIPIOJ LOJMHJJKLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private NHDKLDFMNOK HGOFPLJJILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private GJEGGLJCIKF IIIAFBIONCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private PMOEIHKACBO BDJBBEPJBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private GPGGGCMILBN MEIBLKIIFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private CancellationTokenSource DEHMMIPIBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private Task ONEKMJEOKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private TaskCompletionSource<int> NLICEAGFJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private int EPAKKFFAHID;

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x627BED0", Offset = "0x627A6D0", VA = "0x18627BED0", Slot = "6")]
	public void GLJEDCMMNGN(HKHECNIPIOJ LOJMHJJKLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x1B0A140", Offset = "0x1B08940", VA = "0x181B0A140", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x627BAF0", Offset = "0x627A2F0", VA = "0x18627BAF0")]
	private void DHJBDAEHBPO(float KODDENMJLLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x627C170", Offset = "0x627A970", VA = "0x18627C170", Slot = "4")]
	[AsyncStateMachine(typeof(OHEDALMHLHE))]
	public Task<ANOEFAFFECF> KEALACGNDGO(OBLPPCHKGBB JLIKKAGDNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x627C830", Offset = "0x627B030", VA = "0x18627C830", Slot = "5")]
	[AsyncStateMachine(typeof(GNLKCNJCNMP))]
	public Task NLEJMNIPDLK([Optional] CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x1B0A140", Offset = "0x1B08940", VA = "0x181B0A140")]
	public void HDBADMMEDCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x627C920", Offset = "0x627B120", VA = "0x18627C920")]
	private MOIOBFIDCML OPDKNAIIJPM(OBLPPCHKGBB JLIKKAGDNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x627BBD0", Offset = "0x627A3D0", VA = "0x18627BBD0")]
	[AsyncStateMachine(typeof(OJMEOJGAEAC))]
	private Task EBHPCBJGDJG(EGEMJBICGKC EANKMFHELBA, CancellationToken DINCIKDPHMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x627C730", Offset = "0x627AF30", VA = "0x18627C730")]
	[AsyncStateMachine(typeof(ONKLKHBOAKA))]
	private Task MMNAIDAMDHF(CancellationToken DINCIKDPHMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x627C080", Offset = "0x627A880", VA = "0x18627C080")]
	[AsyncStateMachine(typeof(BEJFFDLOGBO))]
	private Task HNOINLJMACE([Optional] CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x627C530", Offset = "0x627AD30", VA = "0x18627C530")]
	[AsyncStateMachine(typeof(DJJJCEFOJJC))]
	private Task MEBJEJIPJAM(CancellationToken DINCIKDPHMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x627BDD0", Offset = "0x627A5D0", VA = "0x18627BDD0")]
	[AsyncStateMachine(typeof(NFKBNINLLCH))]
	private Task FHPOAHIKLHO(CancellationToken NKDCCCLCJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x627C2A0", Offset = "0x627AAA0", VA = "0x18627C2A0")]
	private Task LLPHPNCPNBB(GGAEDDPGPFL FCJBDNMKKLN, CancellationToken DINCIKDPHMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x627C620", Offset = "0x627AE20", VA = "0x18627C620")]
	[AsyncStateMachine(typeof(LLKJGNCIBOI))]
	private Task MLKGHNCJIPM(GGAEDDPGPFL FCJBDNMKKLN, CancellationToken DINCIKDPHMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x627BCC0", Offset = "0x627A4C0", VA = "0x18627BCC0")]
	private bool EEMHBLAIDME()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public NPBAGKNEHKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[UnityEngine.Scripting.Preserve]
internal class DGKJINFHIOA : NACFABKEACP, DMCCOCJCFNK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct BMIKDCJNMON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public DGKJINFHIOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private ANHHFLMKBPC<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x6267FB0", Offset = "0x62667B0", VA = "0x186267FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x6268510", Offset = "0x6266D10", VA = "0x186268510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	private DHBGMDMHDLN AOCAGONDCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private HKHECNIPIOJ LOJMHJJKLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	private MNHBODFFBLI CPFGJIIMOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	private GJEGGLJCIKF IIIAFBIONCI;

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x626A0E0", Offset = "0x62688E0", VA = "0x18626A0E0", Slot = "6")]
	public void GLJEDCMMNGN(HKHECNIPIOJ LOJMHJJKLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x626A030", Offset = "0x6268830", VA = "0x18626A030", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x626A3C0", Offset = "0x6268BC0", VA = "0x18626A3C0", Slot = "5")]
	[AsyncStateMachine(typeof(BMIKDCJNMON))]
	public Task JAILGAFHGPH(string EPIKKECCKMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x626A080", Offset = "0x6268880", VA = "0x18626A080", Slot = "4")]
	public ANOEFAFFECF EEMHBLAIDME(JLNLBCDKCMG KGHDFCJAHGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x626A4C0", Offset = "0x6268CC0", VA = "0x18626A4C0")]
	private PBADJECEKAD JKHGNIDHBGO(string EPIKKECCKMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public DGKJINFHIOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public static class KLNJGAOACAC
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x6273630", Offset = "0x6271E30", VA = "0x186273630")]
	public static void AKMMHPDJDNJ(LLKIHBKOOLA OKPDFALIJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x6273910", Offset = "0x6272110", VA = "0x186273910")]
	internal static void EMNKMENPBDK(LLKIHBKOOLA OKPDFALIJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x6273830", Offset = "0x6272030", VA = "0x186273830")]
	internal static void EHPBKAIDHCA(LLKIHBKOOLA OKPDFALIJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x6273A30", Offset = "0x6272230", VA = "0x186273A30")]
	internal static void NHHDBEGHMDK(LLKIHBKOOLA OKPDFALIJHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal class IPMKAHNBHGJ : KLEFHCBNGLI<GEAEOIJPPME>
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class FHAHENLHFEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public GEAEOIJPPME message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public FHAHENLHFEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x626B0C0", Offset = "0x62698C0", VA = "0x18626B0C0")]
		internal object OKKJEJOJFGK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly IPMKAHNBHGJ FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x62703C0", Offset = "0x626EBC0", VA = "0x1862703C0")]
	public ExitGames.Client.Photon.Hashtable BBOAPHOFBBK(GEAEOIJPPME BKGEBGGPBLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x6270450", Offset = "0x626EC50", VA = "0x186270450", Slot = "5")]
	protected override void IFCIJIMDJFP(GEAEOIJPPME BKGEBGGPBLH, IDictionary<object, object> AELCABDCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x6270930", Offset = "0x626F130", VA = "0x186270930", Slot = "6")]
	public override GEAEOIJPPME PFKIHJFLILM(IDictionary<object, object> AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x6270820", Offset = "0x626F020", VA = "0x186270820")]
	private static void NOCJPHOMELN(string GJIOGBCNNCC, GEAEOIJPPME BKGEBGGPBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x6270C00", Offset = "0x626F400", VA = "0x186270C00")]
	public IPMKAHNBHGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x6270580", Offset = "0x626ED80", VA = "0x186270580")]
	[CompilerGenerated]
	internal static string NIDEHDKPMJL(MNHIEHBCOOD KAAIDPFBBBH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public static class NBGAJOACDKA
{
	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public static ANOEFAFFECF OPEJMADNALA
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x62733B0", Offset = "0x6271BB0", VA = "0x1862733B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x6278AC0", Offset = "0x62772C0", VA = "0x186278AC0")]
	public static bool DCCCFIHEHGK(this ANOEFAFFECF FPCACMBMLBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x6272F10", Offset = "0x6271710", VA = "0x186272F10")]
	public static ANOEFAFFECF BJFEKFMMKDE(HCNKAAALKFM CJJOHGNOIDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x6278AE0", Offset = "0x62772E0", VA = "0x186278AE0")]
	public static ANOEFAFFECF EMGHEPEFLHN(IEnumerable<ANOEFAFFECF> HEIEKDLMDHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x6278CE0", Offset = "0x62774E0", VA = "0x186278CE0")]
	public static string LOBILCFJION(this ANOEFAFFECF KMHAEDONIKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public abstract class FONMOIKDFND : HMPLIHCDKKG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public delegate ANOEFAFFECF ACMBLKGLLCC([NotNull] JLNLBCDKCMG PLFPMGEHJLF);

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class KABICJEBHNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public JLNLBCDKCMG photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public KABICJEBHNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x5AC1B00", Offset = "0x5AC0300", VA = "0x185AC1B00")]
		internal ANOEFAFFECF AJBJBGJOGKD(ACMBLKGLLCC v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	private bool KIMEMKKPGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	protected readonly HashSet<ACMBLKGLLCC> EFBMKKMLLKL;

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x626B7F0", Offset = "0x6269FF0", VA = "0x18626B7F0", Slot = "4")]
	public void LCGJEICIBOL(ACMBLKGLLCC IIPDIEGMHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x626B4A0", Offset = "0x6269CA0", VA = "0x18626B4A0", Slot = "5")]
	public void AGAONIEGMFM(ACMBLKGLLCC IIPDIEGMHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x626B7A0", Offset = "0x6269FA0", VA = "0x18626B7A0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x626B500", Offset = "0x6269D00", VA = "0x18626B500")]
	protected ANOEFAFFECF AHCOEBILGLO(JLNLBCDKCMG MLBPFKHFGPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x626B850", Offset = "0x626A050", VA = "0x18626B850")]
	protected FONMOIKDFND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public class BCHAOIGIPFN : FONMOIKDFND, FILLDCCIKAF, HMPLIHCDKKG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class NAOGJGBDBKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public ANOEFAFFECF result;

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public NAOGJGBDBKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x6278A60", Offset = "0x6277260", VA = "0x186278A60")]
		internal object COFNDDJJMOA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x62662F0", Offset = "0x6264AF0", VA = "0x1862662F0")]
	[UnityEngine.Scripting.Preserve]
	public BCHAOIGIPFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x62661E0", Offset = "0x62649E0", VA = "0x1862661E0", Slot = "8")]
	public ANOEFAFFECF DLLDPKHGGFK(JLNLBCDKCMG MLBPFKHFGPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public class HKCGHBIHAKI : FONMOIKDFND, DHBGMDMHDLN, HMPLIHCDKKG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private sealed class OLEGNDLLHLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public ANOEFAFFECF result;

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public OLEGNDLLHLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x6280C00", Offset = "0x627F400", VA = "0x186280C00")]
		internal object EPOEMCKCCJG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x62662F0", Offset = "0x6264AF0", VA = "0x1862662F0")]
	[UnityEngine.Scripting.Preserve]
	public HKCGHBIHAKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x626E810", Offset = "0x626D010", VA = "0x18626E810", Slot = "8")]
	public ANOEFAFFECF EEMHBLAIDME(JLNLBCDKCMG AKFGFNBMNIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal static class DIKNKMPEMKF
{
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private sealed class GADIPDNDIFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public ANHHFLMKBPC<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public GADIPDNDIFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x626B8E0", Offset = "0x626A0E0", VA = "0x18626B8E0")]
		internal object CBDAFNOOOJH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x626A5B0", Offset = "0x6268DB0", VA = "0x18626A5B0")]
	public static ANHHFLMKBPC<string> CMJLNAMMKBE(DGJIKJLGCCH KFIEDGIKACP, [Optional] string NPMLMGEOEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x626A750", Offset = "0x6268F50", VA = "0x18626A750")]
	public static void MDLLCCPGIHP(ANHHFLMKBPC<string> AOGFPKDBLJK, DGJIKJLGCCH KFIEDGIKACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x626A690", Offset = "0x6268E90", VA = "0x18626A690")]
	public static string DDKAJEBDEFO(GEAEOIJPPME COLIIFENAOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal static class MDGEBGDJIBA
{
	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x6275010", Offset = "0x6273810", VA = "0x186275010")]
	public static void DOKLNJINHKO(this EMCLNBMIAFK JIAGCNOOLAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x6275020", Offset = "0x6273820", VA = "0x186275020")]
	public static void NOPOPNPBJDC(this EMCLNBMIAFK JIAGCNOOLAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x6275030", Offset = "0x6273830", VA = "0x186275030")]
	private static void PMJBKHKNBLF(this EMCLNBMIAFK JIAGCNOOLAE, bool FEIJBIAHICO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class NJACMIPGMPL : OECDCEILJFN, CGBMONMGACN, FFJNDGBCJKJ, KIPAGPGKHMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private readonly CGBMONMGACN KPCIFMAIKCB;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public JLNLBCDKCMG BPCDKOHENOB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x6279D00", Offset = "0x6278500", VA = "0x186279D00", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int FFGLFFIIPPE
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x6279830", Offset = "0x6278030", VA = "0x186279830", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public int EHGDIPGJGLB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x62797E0", Offset = "0x6277FE0", VA = "0x1862797E0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool NIAEKLOMKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x77D0F0", Offset = "0x77B8F0", VA = "0x18077D0F0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public int HKAMFIAMFBK
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x7E1100", Offset = "0x7DF900", VA = "0x1807E1100", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event NCNPIPEEFLG.BBGODEDCGEL BALDJAENMIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event MOCIEJGKFFB HIJOCHCOMMC
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x6279880", Offset = "0x6278080", VA = "0x186279880", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x6279AC0", Offset = "0x62782C0", VA = "0x186279AC0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> FICLFLDINIH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<JLNLBCDKCMG> CPJNHBENIEG
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action CKPKCEGOIHI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x6279B60", Offset = "0x6278360", VA = "0x186279B60", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x6279A20", Offset = "0x6278220", VA = "0x186279A20", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0xBFAED0", Offset = "0xBF96D0", VA = "0x180BFAED0")]
	public NJACMIPGMPL(CGBMONMGACN KPCIFMAIKCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x6279970", Offset = "0x6278170", VA = "0x186279970", Slot = "8")]
	public bool IJEDOMOCHEH(byte DFBOOPBNIGI, ExitGames.Client.Photon.Hashtable BBDAIOEBCKN, ACADAJIBIJM OONIKFINHEG, SendOptions GBEFIOLAGPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x6279C20", Offset = "0x6278420", VA = "0x186279C20", Slot = "16")]
	public JLNLBCDKCMG OILMLGEMGCE(int MHCLCCCFPCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "19")]
	public void MGMAPGDJJJC(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "20")]
	public void HLGFKJEEIPJ(object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "21")]
	public void MHNAAFJKBNJ(object KIAKEGJPMAL, bool FMGPAPMCAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6279920", Offset = "0x6278120", VA = "0x186279920", Slot = "22")]
	public IDisposable IIBDMBHPIEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "23")]
	private bool LILMIMICBAM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "24")]
	public void CKMJOOFKAPL(StringBuilder ICLBMBEPLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x6279C00", Offset = "0x6278400", VA = "0x186279C00", Slot = "25")]
	public bool NBFECOLKNEG(bool FDFNKHKIJFI, [Out] string HLPKEEDLIBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0xACED80", Offset = "0xACD580", VA = "0x180ACED80", Slot = "28")]
	public void LBAJJKABAMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal struct NHBOIMDDLCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private readonly IDictionary<object, object> HOCFILEOKMJ;

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x7ECAD0", Offset = "0x7EB2D0", VA = "0x1807ECAD0")]
	public NHBOIMDDLCH(IDictionary<object, object> HOCFILEOKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6279500", Offset = "0x6277D00", VA = "0x186279500")]
	public bool JDEGOAIOONA([Out] GEAEOIJPPME BKGEBGGPBLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x6279450", Offset = "0x6277C50", VA = "0x186279450")]
	public Guid BLKJPOJIPPC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x62796A0", Offset = "0x6277EA0", VA = "0x1862796A0")]
	public ANOEFAFFECF PFMBEJFCMLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x62795B0", Offset = "0x6277DB0", VA = "0x1862795B0")]
	public static ExitGames.Client.Photon.Hashtable KLKFANDJKFE(GEAEOIJPPME BKGEBGGPBLH, ANOEFAFFECF FPCACMBMLBI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal static class MOCCJOGLAJJ
{
	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x6276690", Offset = "0x6274E90", VA = "0x186276690")]
	public static bool EBIDAKFDOKI(this FAPHDJICDBI GGBGEOFOBAL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal struct PMCAAEOCKIK : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct MPCNDPOCCIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public PMCAAEOCKIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x6278820", Offset = "0x6277020", VA = "0x186278820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x6278A00", Offset = "0x6277200", VA = "0x186278A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private readonly CancellationTokenSource PDCJAGPLKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private bool KIMEMKKPGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	private Task AKGEHPDFIAE;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool ODGHFELEPIL
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x6282C90", Offset = "0x6281490", VA = "0x186282C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x6282CC0", Offset = "0x62814C0", VA = "0x186282CC0")]
	public PMCAAEOCKIK(CancellationToken EHCFBFBFEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x6282B30", Offset = "0x6281330", VA = "0x186282B30")]
	[AsyncStateMachine(typeof(MPCNDPOCCIL))]
	public Task AKDCIGLBLJO(Func<CancellationToken, List<Task>> DHBKMEAHDIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x6282C40", Offset = "0x6281440", VA = "0x186282C40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public readonly struct CNKODECFGAB<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct LIAMOHDHPJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<OEBIDEOHOKD<TData>, BJFJCNKKJDP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public CNKODECFGAB<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private TaskAwaiter<EOPMGLNDIOA<byte[], BJFJCNKKJDP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x3920CE0", Offset = "0x391F4E0", VA = "0x183920CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x39226E0", Offset = "0x3920EE0", VA = "0x1839226E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private readonly EFHMHJOOELJ<TGetDataArg, TData> DDBMMBAAAPM;

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x7ECAD0", Offset = "0x7EB2D0", VA = "0x1807ECAD0")]
	internal CNKODECFGAB(EFHMHJOOELJ<TGetDataArg, TData> JOGDKLBFLFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x4B7A580", Offset = "0x4B78D80", VA = "0x184B7A580")]
	[AsyncStateMachine(typeof(CNKODECFGAB<, >.LIAMOHDHPJH))]
	public Task<EOPMGLNDIOA<OEBIDEOHOKD<TData>, BJFJCNKKJDP>> DEHFAFCMAPI(TGetDataArg OIFDKAEILPK, string DNEGHEMNDMK, ANHHFLMKBPC<string>.AJPBBELKCKG AOGFPKDBLJK, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public static class LAHEKGNOBBI
{
	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x22930B0", Offset = "0x22918B0", VA = "0x1822930B0")]
	public static CNKODECFGAB<TGetDataArg, TData> KKMBICLNKPK<TGetDataArg, TData>(EFHMHJOOELJ<TGetDataArg, TData> JOGDKLBFLFJ)
	{
		return default(CNKODECFGAB<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public struct KMDEMOGEPEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public readonly int LHEDMGNEBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public readonly int? GGLPCBMOMOC;

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x38FF060", Offset = "0x38FD860", VA = "0x1838FF060")]
	public KMDEMOGEPEE(int ICNFOOHBEIB, [Optional] int? BEDNOFNOFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x6273E80", Offset = "0x6272680", VA = "0x186273E80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public interface IAMEPBEFKHJ<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLPNCKBNBME();

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IAMEPBEFKHJ<T> HJAGHHDKEOA(string MMKDCJKIOML);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IAMEPBEFKHJ<T> ANMLAIKOGIP(CJAAKHEMLON<T> DCGIMNFOCLL);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IAMEPBEFKHJ<T> HPLGNCJDILE(int DFJHGAEKCEE);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IAMEPBEFKHJ<T> CJPCJJIDIPB(int DFJHGAEKCEE, IBJMHHEBLKP<T> LJCNLLCCBKI);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public interface PBJDCDGMCIN
{
	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IAMEPBEFKHJ<T> CKACLEAKPFF<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JFOPKODJDKB ELCIEGBELDK(Exception KPCACGLGOPI);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KMDEMOGEPEE LCAELLDFJKI(Exception KPCACGLGOPI);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public delegate string CJAAKHEMLON<in T>(T KPCACGLGOPI) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public delegate int IBJMHHEBLKP<in T>(T KPCACGLGOPI) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class NJOACMFJLBA : PBJDCDGMCIN
{
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	private delegate string IEKEAFMLAGK(Exception KPCACGLGOPI);

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private delegate int GDOCIJCPJGL(Exception KPCACGLGOPI);

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	private class MCBHOOEMPKK<T> : IAMEPBEFKHJ<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private sealed class OKJALIMNDNA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public OKJALIMNDNA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FF")]
			[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
			internal string FIJCLOLBJJN(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private sealed class KKPEJKLNKIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			public CJAAKHEMLON<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public KKPEJKLNKIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0x38807F0", Offset = "0x387EFF0", VA = "0x1838807F0")]
			internal string JAAFCMHCBCA(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private sealed class CCKFHILNJDE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030F")]
			public IBJMHHEBLKP<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public CCKFHILNJDE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x38807F0", Offset = "0x387EFF0", VA = "0x1838807F0")]
			internal int EGEMIEJLGBM(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private readonly NJOACMFJLBA JLIIBGFDIKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private readonly Type AIBDCPCEKDB;

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6940", Offset = "0x3AE5140", VA = "0x183AE6940")]
		internal MCBHOOEMPKK(NJOACMFJLBA JLIIBGFDIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x3AE67C0", Offset = "0x3AE4FC0", VA = "0x183AE67C0", Slot = "4")]
		public void FLPNCKBNBME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x3AE67F0", Offset = "0x3AE4FF0", VA = "0x183AE67F0", Slot = "5")]
		public IAMEPBEFKHJ<T> HJAGHHDKEOA(string MMKDCJKIOML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6590", Offset = "0x3AE4D90", VA = "0x183AE6590", Slot = "6")]
		public IAMEPBEFKHJ<T> ANMLAIKOGIP(CJAAKHEMLON<T> DCGIMNFOCLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6900", Offset = "0x3AE5100", VA = "0x183AE6900", Slot = "7")]
		public IAMEPBEFKHJ<T> HPLGNCJDILE(int DFJHGAEKCEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x3AE66A0", Offset = "0x3AE4EA0", VA = "0x183AE66A0", Slot = "8")]
		public IAMEPBEFKHJ<T> CJPCJJIDIPB(int DFJHGAEKCEE, IBJMHHEBLKP<T> LJCNLLCCBKI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private class IFMAJJDBBHB<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private bool GCDDECGECAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private readonly List<Type> AKEOAAFJDJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private readonly Dictionary<Type, TVal> GPOABIDGCEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private readonly Dictionary<Type, int> CAPDICJFIFH;

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public IReadOnlyList<Type> LCGNGIGMNJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x3638660", Offset = "0x3636E60", VA = "0x183638660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x3638760", Offset = "0x3636F60", VA = "0x183638760")]
		public IFMAJJDBBHB(Dictionary<Type, int> CAPDICJFIFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x3638420", Offset = "0x3636C20", VA = "0x183638420")]
		public void BONJGFNEKBE(Type OHPCNPKOLBJ, TVal LLMHDPLKODA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x3638720", Offset = "0x3636F20", VA = "0x183638720")]
		public bool NGHMGJNKBFK(Type AIBDCPCEKDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x36383E0", Offset = "0x3636BE0", VA = "0x1836383E0")]
		public bool AOPIADDJKDP(TVal FKKGMPDEPMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x3638560", Offset = "0x3636D60", VA = "0x183638560")]
		public TVal FBPOFKNEBFB(Type GFGNPBCFEMC)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x36382A0", Offset = "0x3636AA0", VA = "0x1836382A0")]
		[CompilerGenerated]
		private int AJHCKFFPDNP(Type IGGDMJGEALC, Type GMCHAHKMHCO)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class JFMJJHOELPH : IEnumerable<KMDEMOGEPEE>, IEnumerable, IEnumerator<KMDEMOGEPEE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private KMDEMOGEPEE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public NJOACMFJLBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private IEnumerator<KMDEMOGEPEE> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		private KMDEMOGEPEE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x3073930", Offset = "0x3072130", VA = "0x183073930", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KMDEMOGEPEE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0x6271390", Offset = "0x626FB90", VA = "0x186271390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x86AE20", Offset = "0x869620", VA = "0x18086AE20")]
		[DebuggerHidden]
		public JFMJJHOELPH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x62713E0", Offset = "0x626FBE0", VA = "0x1862713E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x6270D30", Offset = "0x626F530", VA = "0x186270D30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x6271230", Offset = "0x626FA30", VA = "0x186271230")]
		private void NINDIEOCHCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x62711E0", Offset = "0x626F9E0", VA = "0x1862711E0")]
		private void NIGDNOCCEEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x6271340", Offset = "0x626FB40", VA = "0x186271340", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x6271280", Offset = "0x626FA80", VA = "0x186271280", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KMDEMOGEPEE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x6271280", Offset = "0x626FA80", VA = "0x186271280", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	private static readonly KMDEMOGEPEE IKJJNIKOFGC;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	private static readonly Dictionary<Type, int> MJODAIMMHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	private readonly HashSet<Type> FBJPNLEDIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	private readonly IFMAJJDBBHB<int> EEBLNMOKBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	private readonly IFMAJJDBBHB<GDOCIJCPJGL> KCJPPNJCHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	private readonly IFMAJJDBBHB<IEKEAFMLAGK> BFGDGHHKMEN;

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x627B010", Offset = "0x6279810", VA = "0x18627B010")]
	[NJKKEFDLCAD(AFMDLPKJFNK.GameOnly)]
	private static void PFJBINLDPOI(LLKIHBKOOLA OBCMACCCGNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x627B150", Offset = "0x6279950", VA = "0x18627B150")]
	[RecRoom.NoEngine.Common.Preserve]
	public NJOACMFJLBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x2221D70", Offset = "0x2220570", VA = "0x182221D70", Slot = "4")]
	public IAMEPBEFKHJ<T> CKACLEAKPFF<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x627A1B0", Offset = "0x62789B0", VA = "0x18627A1B0", Slot = "5")]
	public JFOPKODJDKB ELCIEGBELDK(Exception KPCACGLGOPI)
	{
		return default(JFOPKODJDKB);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x627A840", Offset = "0x6279040", VA = "0x18627A840", Slot = "6")]
	public KMDEMOGEPEE LCAELLDFJKI(Exception? KPCACGLGOPI)
	{
		return default(KMDEMOGEPEE);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x627ABC0", Offset = "0x62793C0", VA = "0x18627ABC0", Slot = "7")]
	[IteratorStateMachine(typeof(JFMJJHOELPH))]
	public IEnumerable<KMDEMOGEPEE> NBOGIMBNODE(Exception KPCACGLGOPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x627A060", Offset = "0x6278860", VA = "0x18627A060", Slot = "8")]
	public string EKCLPBFAFMD(Exception? KPCACGLGOPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x6279D50", Offset = "0x6278550", VA = "0x186279D50")]
	private string CCLBFGGLCEB(AggregateException MFAMOJKNMCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x627AC60", Offset = "0x6279460", VA = "0x18627AC60")]
	private void ONAFDIDCMHC(Type AIBDCPCEKDB, int DFJHGAEKCEE, GDOCIJCPJGL? DDEKNFMGHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x627A240", Offset = "0x6278A40", VA = "0x18627A240")]
	private void GJLFLKNGGGA(Type AIBDCPCEKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x627A490", Offset = "0x6278C90", VA = "0x18627A490")]
	private void GMDBGMIEEDC(Type AIBDCPCEKDB, IEKEAFMLAGK FFNBLHEHKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x627AA40", Offset = "0x6279240", VA = "0x18627AA40")]
	private static int MFPMNJMFFAP(Type AIBDCPCEKDB, Dictionary<Type, int> CAPDICJFIFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x24B4EA0", Offset = "0x24B36A0", VA = "0x1824B4EA0")]
	private static bool BDKHJHOGBNA<TVal>(IFMAJJDBBHB<TVal> OLDAAMHBNMC, Type AIBDCPCEKDB, [Out] TVal FKKGMPDEPMA) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x627A760", Offset = "0x6278F60", VA = "0x18627A760")]
	[CompilerGenerated]
	internal static int JPBFHLKEBIO(Type FAMAHMENHEP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public struct JFOPKODJDKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public readonly KMDEMOGEPEE NAKGEFNCFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public readonly string DBBHANLFFHI;

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x62715D0", Offset = "0x626FDD0", VA = "0x1862715D0")]
	public JFOPKODJDKB(string DLICNMKDAFF, KMDEMOGEPEE DFJHGAEKCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x6271530", Offset = "0x626FD30", VA = "0x186271530")]
	public string DPODJMMAJMF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public class JGMGPMLOKAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000321")]
	private readonly POMIFCOBDBE IDJJOACPBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	private string KCLHCIMIKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	private long? LCNECBPCJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	private long? HKDLPPKPIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private long? MFIJBFJOBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	private string KCLMBJMLGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private LGDGGBMJANA NBLMPHNDGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private long? HLKJOPPLFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	private bool LBJFCPOOGPD;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public string CDLDAFIOLOP
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public long HGJHMEAKOOL
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x6271920", Offset = "0x6270120", VA = "0x186271920")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public long PFKKCGILGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x6271F30", Offset = "0x6270730", VA = "0x186271F30")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public long GAAPPOLJLAH
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x62715F0", Offset = "0x626FDF0", VA = "0x1862715F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public string OBCPEGHNPFM
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x6271B70", Offset = "0x6270370", VA = "0x186271B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public LGDGGBMJANA ACCHGFHOJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xEB7870", Offset = "0xEB6070", VA = "0x180EB7870")]
		get
		{
			return default(LGDGGBMJANA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x6271A80", Offset = "0x6270280", VA = "0x186271A80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public long PBKAHLEJIDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x6271A20", Offset = "0x6270220", VA = "0x186271A20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x6272420", Offset = "0x6270C20", VA = "0x186272420")]
	[UnityEngine.Scripting.Preserve]
	public JGMGPMLOKAC([KEKICHOEFEB(null)] POMIFCOBDBE IDJJOACPBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x62716D0", Offset = "0x626FED0", VA = "0x1862716D0")]
	private void CAFLOMMGABN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x6271F90", Offset = "0x6270790", VA = "0x186271F90")]
	public void PADCFLNKBMI(long NBNJFKJOFIF, long OMOMGBJOLII, [Optional] long? NCDPLLGFCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x6271980", Offset = "0x6270180", VA = "0x186271980")]
	public void GOINBNBFJIH(long NCDPLLGFCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x6271650", Offset = "0x626FE50", VA = "0x186271650")]
	public void BOAMLLPNIJB(string JOKPEKJELJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x6271BB0", Offset = "0x62703B0", VA = "0x186271BB0")]
	public void LJJIFDHHOHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal class MNLGPGKPHPA : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private struct PFLAGMKCNHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public AsyncTaskMethodBuilder<GEAEOIJPPME> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public GEAEOIJPPME roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public MNLGPGKPHPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private TaskAwaiter<FBKGNJKHOII.PFAPGKMBPFP<GEAEOIJPPME>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x6281DC0", Offset = "0x62805C0", VA = "0x186281DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x62822F0", Offset = "0x6280AF0", VA = "0x1862822F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct KAOBPGDBFID<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private sealed class LMPEDNEACJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public GEAEOIJPPME roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public LMPEDNEACJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x6274ED0", Offset = "0x62736D0", VA = "0x186274ED0")]
		internal GEAEOIJPPME JLCAIFBECJC(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private struct AJIMODIPBJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public AsyncTaskMethodBuilder<FBKGNJKHOII.PFAPGKMBPFP<GEAEOIJPPME>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public GEAEOIJPPME roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public MNLGPGKPHPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private KHFDFFIDAJM <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private TaskAwaiter<FBKGNJKHOII.PFAPGKMBPFP<GEAEOIJPPME>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x6264B10", Offset = "0x6263310", VA = "0x186264B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x6265120", Offset = "0x6263920", VA = "0x186265120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct EBEMLIHIDCG<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public MNLGPGKPHPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x30304D0", Offset = "0x302ECD0", VA = "0x1830304D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x3030BF0", Offset = "0x302F3F0", VA = "0x183030BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct HHONMGFDGPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public MNLGPGKPHPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x626D200", Offset = "0x626BA00", VA = "0x18626D200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x626D3C0", Offset = "0x626BBC0", VA = "0x18626D3C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class JKDBGIGGCDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public JKDBGIGGCDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x6272520", Offset = "0x6270D20", VA = "0x186272520")]
		internal object FOCMCFLOPKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x6272460", Offset = "0x6270C60", VA = "0x186272460")]
		internal bool FHNPIAJHLKP(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class KGMFEKNOIDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public KGMFEKNOIDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x62735D0", Offset = "0x6271DD0", VA = "0x1862735D0")]
		internal object MCOFPEKFLJF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class PKNEDOEHJBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public PKNEDOEHJBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x6282AC0", Offset = "0x62812C0", VA = "0x186282AC0")]
		internal object BCACLKOPPKA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private sealed class EEBHJLJHBIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public EEBHJLJHBIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x626AFF0", Offset = "0x62697F0", VA = "0x18626AFF0")]
		internal object PCDANFIFMCO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class MLLHEGIFMGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public MNLGPGKPHPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public MLLHEGIFMGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x6275150", Offset = "0x6273950", VA = "0x186275150")]
		internal object OKKJEJOJFGK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private static readonly Guid OCFKBHEFACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public readonly OFOHOILEKAB EFDHOHIMFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private readonly FBKGNJKHOII ILILBEPGEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private readonly FFJNDGBCJKJ JIAGCNOOLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private readonly KIPAGPGKHMM IECPPKHCAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private bool ECECBECEJIP;

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x6276460", Offset = "0x6274C60", VA = "0x186276460")]
	public MNLGPGKPHPA(OFOHOILEKAB NFBNNCDBMIA, FBKGNJKHOII ILILBEPGEBL, FFJNDGBCJKJ JIAGCNOOLAE, KIPAGPGKHMM IECPPKHCAME, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x62757D0", Offset = "0x6273FD0", VA = "0x1862757D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x62757D0", Offset = "0x6273FD0", VA = "0x1862757D0")]
	public void OCIJFNGLLCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x6275E20", Offset = "0x6274620", VA = "0x186275E20")]
	public void LPJBIEAKNMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x6275BE0", Offset = "0x62743E0", VA = "0x186275BE0")]
	public void KAIGHCACAEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x62754E0", Offset = "0x6273CE0", VA = "0x1862754E0")]
	[AsyncStateMachine(typeof(PFLAGMKCNHJ))]
	internal Task<GEAEOIJPPME> BOOOIJFKAMA(ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, GEAEOIJPPME COLIIFENAOI, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x2455D90", Offset = "0x2454590", VA = "0x182455D90")]
	private static byte[] BFPDAPBCACM<T>(T BKGEBGGPBLH) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x2456050", Offset = "0x2454850", VA = "0x182456050")]
	private static T CNIFPGPPHDE<T>(MessageParser<T> LLCMOJKHPNE, byte[] BKGEBGGPBLH, T LHEMNDHOIFD) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x6275AA0", Offset = "0x62742A0", VA = "0x186275AA0")]
	[AsyncStateMachine(typeof(AJIMODIPBJL))]
	private Task<FBKGNJKHOII.PFAPGKMBPFP<GEAEOIJPPME>> JPHLBFALEPC(GEAEOIJPPME COLIIFENAOI, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x2456290", Offset = "0x2454A90", VA = "0x182456290")]
	[AsyncStateMachine(typeof(EBEMLIHIDCG<>))]
	internal Task<T> NOJIOKGPPOJ<T>(CancellationToken DINCIKDPHMJ, Func<CancellationToken, Task<T>> EEELBBAHMFO, int MDIJGMMCBCL = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x6275FF0", Offset = "0x62747F0", VA = "0x186275FF0")]
	[AsyncStateMachine(typeof(HHONMGFDGPM))]
	internal Task NOJIOKGPPOJ(CancellationToken DINCIKDPHMJ, Func<CancellationToken, Task> EEELBBAHMFO, int MDIJGMMCBCL = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x6275640", Offset = "0x6273E40", VA = "0x186275640")]
	public JIAEDHHFNMM CIPEJECOAOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x6276370", Offset = "0x6274B70", VA = "0x186276370")]
	public BNOAPJLBPCE ODPNNIBNGPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x6275390", Offset = "0x6273B90", VA = "0x186275390")]
	public BCBBNCKGLHE BOFMPBJBHKO([Optional] DGJIKJLGCCH? KFIEDGIKACP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x6275940", Offset = "0x6274140", VA = "0x186275940")]
	public void JIEMNFAHNBB(Func<Guid, bool> MGODCEDNNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x62756C0", Offset = "0x6273EC0", VA = "0x1862756C0")]
	public void DACACJKKHNB(Func<Guid, bool> AMNCPLIOFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x6275CA0", Offset = "0x62744A0", VA = "0x186275CA0")]
	public Guid KLMIKIPNEFP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x6276120", Offset = "0x6274920", VA = "0x186276120")]
	public void OBEAPFJPCMN(Guid CFBLOLMMIID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x6276230", Offset = "0x6274A30", VA = "0x186276230")]
	public void OCDCMCLMGCG(GEAEOIJPPME JCDKDPJHACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x6275EE0", Offset = "0x62746E0", VA = "0x186275EE0")]
	public void NOCJPHOMELN(string MFMLIAAPKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x24561A0", Offset = "0x24549A0", VA = "0x1824561A0")]
	private T KFEPBIENCDD<T>(T FKKGMPDEPMA) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x62758F0", Offset = "0x62740F0", VA = "0x1862758F0")]
	public void ENFAMNPIBCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x2455DA0", Offset = "0x24545A0", VA = "0x182455DA0")]
	[CompilerGenerated]
	internal static string CKAALIEAKFK<T>(byte[] MHCEKABKGED, int IFKKCMGLINO, KAOBPGDBFID<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
internal sealed class LAINFOEINKK : OFOHOILEKAB
{
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class AMHAGEHKPJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public AMHAGEHKPJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x6284E20", Offset = "0x6283620", VA = "0x186284E20")]
		internal object EHIAOAJMCDN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private struct NJKDIDDDOJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public LAINFOEINKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public MNLGPGKPHPA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private JDBGDEDGBHG <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private BNOAPJLBPCE <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x6295010", Offset = "0x6293810", VA = "0x186295010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x6295790", Offset = "0x6293F90", VA = "0x186295790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct HICKFNBLLEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public LAINFOEINKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private bool <omIsEnabled>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private TaskAwaiter<MEGCEJKCLCC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private TaskAwaiter<byte> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x628C900", Offset = "0x628B100", VA = "0x18628C900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x628CE80", Offset = "0x628B680", VA = "0x18628CE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private struct FHBDBBAHFPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public LAINFOEINKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private TaskAwaiter<MLEOJECBJGH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x6289A90", Offset = "0x6288290", VA = "0x186289A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x6289DB0", Offset = "0x62885B0", VA = "0x186289DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private sealed class JOHNPJINBPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public JDBGDEDGBHG presence;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public JOHNPJINBPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x62909E0", Offset = "0x628F1E0", VA = "0x1862909E0")]
		internal object DAKLFNIKCAP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private static readonly DGJIKJLGCCH JHPMPPNJLMB;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	private static readonly DGJIKJLGCCH LODPDBADFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private readonly MNHIEHBCOOD NHKOJPMKFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private readonly FAPHDJICDBI JNJOPOLCPAA;

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x6274570", Offset = "0x6272D70", VA = "0x186274570")]
	public LAINFOEINKK(MNHIEHBCOOD NHKOJPMKFOA, FAPHDJICDBI JNJOPOLCPAA, Guid BACFDICONIG, HKHECNIPIOJ LOJMHJJKLIJ, EBEIOKMCHFG BCDJEFOHHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x6274070", Offset = "0x6272870", VA = "0x186274070", Slot = "7")]
	[AsyncStateMachine(typeof(NJKDIDDDOJC))]
	protected override Task IFMPBLEGHIK(MNLGPGKPHPA MFJBAPDNGMP, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x62741B0", Offset = "0x62729B0", VA = "0x1862741B0")]
	[AsyncStateMachine(typeof(HICKFNBLLEL))]
	private Task MIJIMJFCLFI(CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x6273F60", Offset = "0x6272760", VA = "0x186273F60")]
	[AsyncStateMachine(typeof(FHBDBBAHFPG))]
	private Task<byte> AKGHCNPAONP(CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x62742B0", Offset = "0x6272AB0", VA = "0x1862742B0")]
	private JDBGDEDGBHG OOOGCCIAALA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal class MOIOBFIDCML : OFOHOILEKAB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private struct MGBDIKMJPGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public MOIOBFIDCML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public MNLGPGKPHPA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private TaskAwaiter<GCMHHKBFFMI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x6291EA0", Offset = "0x62906A0", VA = "0x186291EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x6292870", Offset = "0x6291070", VA = "0x186292870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000378")]
	private readonly int NFEHEOJCAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000379")]
	private readonly OBLPPCHKGBB CHBGJFKEEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public readonly long GLLOKICLPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public readonly long DCMHGCHDGCM;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public GCMHHKBFFMI AMGCENPOOFL
	{
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x768CB0", Offset = "0x7674B0", VA = "0x180768CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x768DB0", Offset = "0x7675B0", VA = "0x180768DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x62929F0", Offset = "0x62911F0", VA = "0x1862929F0")]
	public MOIOBFIDCML(Guid BACFDICONIG, HKHECNIPIOJ LOJMHJJKLIJ, EBEIOKMCHFG BCDJEFOHHFM, int NFEHEOJCAJC, OBLPPCHKGBB CHBGJFKEEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x62928D0", Offset = "0x62910D0", VA = "0x1862928D0", Slot = "7")]
	[AsyncStateMachine(typeof(MGBDIKMJPGE))]
	protected override Task IFMPBLEGHIK(MNLGPGKPHPA MFJBAPDNGMP, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
internal abstract class GOMIEOGHKBH : OFOHOILEKAB
{
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private sealed class CCDNNJDOALA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public GOMIEOGHKBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public EICHMJCIJHN playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public CCDNNJDOALA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x6287D50", Offset = "0x6286550", VA = "0x186287D50")]
		internal Task NEMCAKECEEB(ANHHFLMKBPC<string>.AJPBBELKCKG postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x6287CC0", Offset = "0x62864C0", VA = "0x186287CC0")]
		internal object AFCPAHNFLNL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private struct AIHHFOIMHNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public GOMIEOGHKBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public MNLGPGKPHPA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private CCDNNJDOALA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x6283BF0", Offset = "0x62823F0", VA = "0x186283BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x62843B0", Offset = "0x6282BB0", VA = "0x1862843B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private struct GBNHMJDBCBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public EICHMJCIJHN playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public GOMIEOGHKBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x6289E20", Offset = "0x6288620", VA = "0x186289E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x628A3B0", Offset = "0x6288BB0", VA = "0x18628A3B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x628B080", Offset = "0x6289880", VA = "0x18628B080")]
	public GOMIEOGHKBH(Guid BACFDICONIG, HKHECNIPIOJ LOJMHJJKLIJ, EBEIOKMCHFG BCDJEFOHHFM, string FOPLEABIEMA, IOBHDNMDIFB AMKPPIJBFNG, bool PDPBJLIEBDC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x628AF40", Offset = "0x6289740", VA = "0x18628AF40", Slot = "7")]
	[AsyncStateMachine(typeof(AIHHFOIMHNH))]
	protected override Task IFMPBLEGHIK(MNLGPGKPHPA MFJBAPDNGMP, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task NKLJCIECPNG(MNLGPGKPHPA MFJBAPDNGMP, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x628AE00", Offset = "0x6289600", VA = "0x18628AE00")]
	[AsyncStateMachine(typeof(GBNHMJDBCBF))]
	private Task BGKNMLKMDHA(IDisposable NFHBFFMHMDH, EICHMJCIJHN BLGGDCMKJAC, ANHHFLMKBPC<string>.AJPBBELKCKG AOGFPKDBLJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal class PIIGMFLMMOO : OFOHOILEKAB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private struct DKNCHLAEBJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public PIIGMFLMMOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public MNLGPGKPHPA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private TaskAwaiter<KKLDNOOFJJJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x6288BC0", Offset = "0x62873C0", VA = "0x186288BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x6289130", Offset = "0x6287930", VA = "0x186289130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000399")]
	private readonly GGAEDDPGPFL FCJBDNMKKLN;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x629A000", Offset = "0x6298800", VA = "0x18629A000")]
	public PIIGMFLMMOO(Guid BACFDICONIG, HKHECNIPIOJ LOJMHJJKLIJ, EBEIOKMCHFG BCDJEFOHHFM, GGAEDDPGPFL FCJBDNMKKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x6299F20", Offset = "0x6298720", VA = "0x186299F20", Slot = "6")]
	protected override string MACGCBHHJGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x6299E00", Offset = "0x6298600", VA = "0x186299E00", Slot = "7")]
	[AsyncStateMachine(typeof(DKNCHLAEBJC))]
	protected override Task IFMPBLEGHIK(MNLGPGKPHPA MFJBAPDNGMP, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal abstract class OFOHOILEKAB : BMHPEAOJIIJ
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public delegate Task EMFIOAEBCGE(ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private sealed class BFBAEILEOBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public OFOHOILEKAB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public BFBAEILEOBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x6285FE0", Offset = "0x62847E0", VA = "0x186285FE0")]
		internal Task JEIOBJLNIPH(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class NINCDHOCLNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public BFBAEILEOBK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public NINCDHOCLNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x6294F50", Offset = "0x6293750", VA = "0x186294F50")]
		internal object OFPNJFHNHAC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x6294E90", Offset = "0x6293690", VA = "0x186294E90")]
		internal object MPCDHCIAAPG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private struct IALHIHJJFOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public OFOHOILEKAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public Func<OFOHOILEKAB, ANHHFLMKBPC<string>.AJPBBELKCKG, MNLGPGKPHPA> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private BFBAEILEOBK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private MNLGPGKPHPA <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private TaskAwaiter<GEAEOIJPPME> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x628D250", Offset = "0x628BA50", VA = "0x18628D250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x628E350", Offset = "0x628CB50", VA = "0x18628E350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct ADALGIHINBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public OFOHOILEKAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x6283830", Offset = "0x6282030", VA = "0x186283830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x6283B90", Offset = "0x6282390", VA = "0x186283B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public readonly Guid DEPMDGOGFMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public readonly ByteString CPNNMMKPKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public readonly EBEIOKMCHFG BEENPMHLMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	protected readonly string PICCGHFAMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	private readonly HKHECNIPIOJ LOJMHJJKLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	private readonly bool PDPBJLIEBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	private readonly Queue<EMFIOAEBCGE> FDIBCMJLDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	private readonly CABPPMPBKEH KMICKKAPALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	private readonly IOBHDNMDIFB AMKPPIJBFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	private bool ABFMDHPGNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public LGDGGBMJANA BJDEJGPJIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public LGDGGBMJANA CBMCMLHJHLL;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public HKHECNIPIOJ JEJCGJLHKPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x7660F0", Offset = "0x7648F0", VA = "0x1807660F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public NHDKLDFMNOK JAIBLGKGHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x6298C10", Offset = "0x6297410", VA = "0x186298C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public ADMCHBMLFLK ODFAHIOEKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x62987E0", Offset = "0x6296FE0", VA = "0x1862987E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public GEGICDFBGIP GAOPKHMLGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x6298960", Offset = "0x6297160", VA = "0x186298960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event BBPBFMKJKPP MHNMLCHLJDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x6298BF0", Offset = "0x62973F0", VA = "0x186298BF0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x6298940", Offset = "0x6297140", VA = "0x186298940", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x6298C60", Offset = "0x6297460", VA = "0x186298C60")]
	protected OFOHOILEKAB(Guid BACFDICONIG, HKHECNIPIOJ LOJMHJJKLIJ, EBEIOKMCHFG BCDJEFOHHFM, string FOPLEABIEMA, IOBHDNMDIFB AMKPPIJBFNG, bool PDPBJLIEBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x62989E0", Offset = "0x62971E0", VA = "0x1862989E0", Slot = "6")]
	protected virtual string MACGCBHHJGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x6298570", Offset = "0x6296D70", VA = "0x186298570")]
	public void CPHIDCENDMA(EMFIOAEBCGE EMFGPDGANAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6298920", Offset = "0x6297120", VA = "0x186298920")]
	protected void FEDBHCMFIDF(float EJOBIJGJEMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x6298A20", Offset = "0x6297220", VA = "0x186298A20")]
	[AsyncStateMachine(typeof(IALHIHJJFOA))]
	public Task MFGPHFHEOBL(CancellationToken EHCFBFBFEDH, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, [Optional] Func<OFOHOILEKAB, ANHHFLMKBPC<string>.AJPBBELKCKG, MNLGPGKPHPA> BOHIMEPHNPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x6298420", Offset = "0x6296C20", VA = "0x186298420")]
	private void BKIODFEJBIM(bool MJOMMNNHKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x62986F0", Offset = "0x6296EF0", VA = "0x1862986F0")]
	private void DLDMDMPILNH(MNLGPGKPHPA MFJBAPDNGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task IFMPBLEGHIK(MNLGPGKPHPA MFJBAPDNGMP, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x62985D0", Offset = "0x6296DD0", VA = "0x1862985D0")]
	[AsyncStateMachine(typeof(ADALGIHINBH))]
	private Task DKLHAKJEJFL(ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x6298B70", Offset = "0x6297370", VA = "0x186298B70")]
	public GEAEOIJPPME NOCKMCMNJGN(KHFDFFIDAJM AOMOBGDHDDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x6298830", Offset = "0x6297030", VA = "0x186298830")]
	[CompilerGenerated]
	private Task FBGJBCLDAAE(CancellationToken INGJCJMKCCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
internal sealed class JKBHBPLOGDC : GOMIEOGHKBH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct NPPKBFOJOBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public JKBHBPLOGDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public MNLGPGKPHPA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private DEDIDPIECAL <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private BNOAPJLBPCE <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x62971A0", Offset = "0x62959A0", VA = "0x1862971A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x6297910", Offset = "0x6296110", VA = "0x186297910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	private readonly MNHIEHBCOOD HDICAGMCIMP;

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x628F740", Offset = "0x628DF40", VA = "0x18628F740")]
	public JKBHBPLOGDC(Guid BACFDICONIG, HKHECNIPIOJ LOJMHJJKLIJ, MNHIEHBCOOD HDICAGMCIMP, EBEIOKMCHFG BCDJEFOHHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x628F5F0", Offset = "0x628DDF0", VA = "0x18628F5F0", Slot = "8")]
	[AsyncStateMachine(typeof(NPPKBFOJOBO))]
	protected override Task NKLJCIECPNG(MNLGPGKPHPA MFJBAPDNGMP, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal class PBADJECEKAD : OFOHOILEKAB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct KBNDLIMDKCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public PBADJECEKAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public MNLGPGKPHPA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private TaskAwaiter<KKLDNOOFJJJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x6290B20", Offset = "0x628F320", VA = "0x186290B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x6290ED0", Offset = "0x628F6D0", VA = "0x186290ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	private readonly string PDDMEDNHCPM;

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x6299D50", Offset = "0x6298550", VA = "0x186299D50")]
	public PBADJECEKAD(Guid BACFDICONIG, HKHECNIPIOJ LOJMHJJKLIJ, EBEIOKMCHFG BCDJEFOHHFM, string PDDMEDNHCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x6299C40", Offset = "0x6298440", VA = "0x186299C40", Slot = "7")]
	[AsyncStateMachine(typeof(KBNDLIMDKCH))]
	protected override Task IFMPBLEGHIK(MNLGPGKPHPA MFJBAPDNGMP, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
internal class NKNINAACGNK : GOMIEOGHKBH
{
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private sealed class IDJLJFBJHJF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000112")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			public AsyncTaskMethodBuilder<GEAEOIJPPME> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			public IDJLJFBJHJF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			private TaskAwaiter<KKLDNOOFJJJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			private TaskAwaiter<GEAEOIJPPME> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x629CDD0", Offset = "0x629B5D0", VA = "0x18629CDD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x629D290", Offset = "0x629BA90", VA = "0x18629D290", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public NKNINAACGNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public BCBBNCKGLHE serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public JKDLBDKJGBI roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public JIAEDHHFNMM uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public IMAENCKMEPE roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public IDJLJFBJHJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x628E3B0", Offset = "0x628CBB0", VA = "0x18628E3B0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<GEAEOIJPPME> AHOOFHMDJJE(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct MPMMBLAECIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public NKNINAACGNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public MNLGPGKPHPA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private IDJLJFBJHJF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private DEDIDPIECAL <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private BNOAPJLBPCE <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private TaskAwaiter<GEAEOIJPPME> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x6292B20", Offset = "0x6291320", VA = "0x186292B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x62939C0", Offset = "0x62921C0", VA = "0x1862939C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private static readonly DGJIKJLGCCH JHPMPPNJLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private readonly int NINOCLLNPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	[CanBeNull]
	private readonly POCCJPPMGCN BPFMCEBCONM;

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x6295CB0", Offset = "0x62944B0", VA = "0x186295CB0")]
	public NKNINAACGNK(Guid BACFDICONIG, HKHECNIPIOJ LOJMHJJKLIJ, int NINOCLLNPBI, POCCJPPMGCN BPFMCEBCONM, EBEIOKMCHFG BCDJEFOHHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x6295AC0", Offset = "0x62942C0", VA = "0x186295AC0", Slot = "8")]
	[AsyncStateMachine(typeof(MPMMBLAECIO))]
	protected override Task NKLJCIECPNG(MNLGPGKPHPA MFJBAPDNGMP, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x62957F0", Offset = "0x6293FF0", VA = "0x1862957F0")]
	private void BFJHNDDJCKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x62958F0", Offset = "0x62940F0", VA = "0x1862958F0")]
	private void LJPGBMJPAJF(ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, DEDIDPIECAL DOLBAIIOHMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
internal abstract class NCMKMJBCHEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public readonly OFOHOILEKAB EFDHOHIMFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public readonly MNLGPGKPHPA ODALGFFIDFM;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public NHDKLDFMNOK JAIBLGKGHED
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x62940E0", Offset = "0x62928E0", VA = "0x1862940E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public GEGICDFBGIP GAOPKHMLGDB
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x6294030", Offset = "0x6292830", VA = "0x186294030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x6294130", Offset = "0x6292930", VA = "0x186294130")]
	protected NCMKMJBCHEP(MNLGPGKPHPA MFJBAPDNGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x62940C0", Offset = "0x62928C0", VA = "0x1862940C0")]
	protected void NOCJPHOMELN(string MFMLIAAPKFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal struct NCBKNJAFGEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public Dictionary<Guid, List<BOKNLEENGCP>> JCELPHBLNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public Dictionary<Guid, List<BOKNLEENGCP>> MBNGEINNHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public Dictionary<Guid, List<BOKNLEENGCP>> OFADPJLFLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public List<Guid> AIEKADEOMLG;

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x6293A20", Offset = "0x6292220", VA = "0x186293A20")]
	public static NCBKNJAFGEG FBPOFKNEBFB(NHDKLDFMNOK HGOFPLJJILB, LGDGGBMJANA HFCMEPJOLMI, EGEMJBICGKC OFJFMFJFDNP)
	{
		return default(NCBKNJAFGEG);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal struct MPPJGIEIDMD
{
	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370")]
	public static MPPJGIEIDMD KLKFANDJKFE()
	{
		return default(MPPJGIEIDMD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
internal struct DEBDMKGPELG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public readonly MEGCEJKCLCC BAPHNKFCMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public readonly ILPOHKEMFGB OFAEDIOONDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public readonly string CMPPDGOADDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public readonly FINMELMELDP LAPMLCJGBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public readonly FINMELMELDP PEFHOJDFIMF;

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x62884E0", Offset = "0x6286CE0", VA = "0x1862884E0")]
	public DEBDMKGPELG(MEGCEJKCLCC BAPHNKFCMLP, ILPOHKEMFGB OFAEDIOONDI, string CMPPDGOADDE, FINMELMELDP LAPMLCJGBLE, FINMELMELDP PEFHOJDFIMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
internal struct LNDJFIBKGGN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	private readonly MNLGPGKPHPA MFJBAPDNGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	private readonly Guid CFBLOLMMIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	private bool MJOMMNNHKHB;

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x6291DF0", Offset = "0x62905F0", VA = "0x186291DF0")]
	public static LNDJFIBKGGN KLMIKIPNEFP(MNLGPGKPHPA MFJBAPDNGMP)
	{
		return default(LNDJFIBKGGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x7D0F40", Offset = "0x7CF740", VA = "0x1807D0F40")]
	public void AFENDHMMCHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x6291CF0", Offset = "0x62904F0", VA = "0x186291CF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x6291E50", Offset = "0x6290650", VA = "0x186291E50")]
	private LNDJFIBKGGN(MNLGPGKPHPA MFJBAPDNGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x6291CF0", Offset = "0x62904F0", VA = "0x186291CF0")]
	private void OBEAPFJPCMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x6291D50", Offset = "0x6290550", VA = "0x186291D50")]
	private Func<Guid, bool> IHFIJKDIAOK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal class BNOAPJLBPCE : NCMKMJBCHEP, BMHPEAOJIIJ
{
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	public delegate Task<LGDGGBMJANA> JHKDOLNECHL(EGEMJBICGKC AELCABDCBDD, LIGDDNKKMOF JPILPLAOGFG, CABPPMPBKEH PFAJALCKHDJ, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct IENOGDIGCDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public BNOAPJLBPCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public MNHIEHBCOOD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private LNDJFIBKGGN <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private TaskAwaiter<GEAEOIJPPME> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x628E4D0", Offset = "0x628CCD0", VA = "0x18628E4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x628EBD0", Offset = "0x628D3D0", VA = "0x18628EBD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private struct HGLOBNAKOBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public AsyncTaskMethodBuilder<GEAEOIJPPME> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public BNOAPJLBPCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public MNHIEHBCOOD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private TaskAwaiter<GEAEOIJPPME> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x628C480", Offset = "0x628AC80", VA = "0x18628C480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x628C890", Offset = "0x628B090", VA = "0x18628C890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private struct OBBNOLPIEOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public BNOAPJLBPCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public MNHIEHBCOOD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x6297970", Offset = "0x6296170", VA = "0x186297970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x6297E00", Offset = "0x6296600", VA = "0x186297E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private sealed class DLFFMJMKDDM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000120")]
		private struct <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			public AsyncTaskMethodBuilder<DEBDMKGPELG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public DLFFMJMKDDM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			private DEBDMKGPELG <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000430")]
			private TaskAwaiter<LGDGGBMJANA> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000431")]
			private TaskAwaiter<DEBDMKGPELG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004EF")]
			[Cpp2IlInjected.Address(RVA = "0x629B440", Offset = "0x6299C40", VA = "0x18629B440", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F0")]
			[Cpp2IlInjected.Address(RVA = "0x629BBD0", Offset = "0x629A3D0", VA = "0x18629BBD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000121")]
		private struct <<LoadRoomLocal>b__4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public AsyncTaskMethodBuilder<EGEMJBICGKC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			public DLFFMJMKDDM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			private EGEMJBICGKC <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			private TaskAwaiter<LGDGGBMJANA> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000438")]
			private TaskAwaiter<EGEMJBICGKC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004F1")]
			[Cpp2IlInjected.Address(RVA = "0x629BC40", Offset = "0x629A440", VA = "0x18629BC40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F2")]
			[Cpp2IlInjected.Address(RVA = "0x629C290", Offset = "0x629AA90", VA = "0x18629C290", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000122")]
		private struct <<LoadRoomLocal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public DLFFMJMKDDM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			private TaskAwaiter<LGDGGBMJANA> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			private LIGDDNKKMOF <timedYielder>5__2;

			[Cpp2IlInjected.Token(Token = "0x60004F3")]
			[Cpp2IlInjected.Address(RVA = "0x629A0A0", Offset = "0x62988A0", VA = "0x18629A0A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F4")]
			[Cpp2IlInjected.Address(RVA = "0x629B3E0", Offset = "0x6299BE0", VA = "0x18629B3E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public BNOAPJLBPCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public MNHIEHBCOOD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public CABPPMPBKEH preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public CABPPMPBKEH downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public DEBDMKGPELG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public CABPPMPBKEH postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public EGEMJBICGKC phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public HNJEFBAMJIH.BOLKGIAFBOP <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public DLFFMJMKDDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x62893F0", Offset = "0x6287BF0", VA = "0x1862893F0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<DEBDMKGPELG> JPDHGAPGDDD(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x6289290", Offset = "0x6287A90", VA = "0x186289290")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<EGEMJBICGKC> GGBMFGKDOAN(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x62893B0", Offset = "0x6287BB0", VA = "0x1862893B0")]
		internal void HMEPBPOKBLO(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x6289190", Offset = "0x6287990", VA = "0x186289190")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task FNCNIIKOKDI(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct OJNLEIKCMBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public BNOAPJLBPCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public MNHIEHBCOOD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		private DLFFMJMKDDM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private TaskAwaiter<DEBDMKGPELG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private TaskAwaiter<EGEMJBICGKC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x6298EE0", Offset = "0x62976E0", VA = "0x186298EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x6299BE0", Offset = "0x62983E0", VA = "0x186299BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct IJABLCJOEKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public BNOAPJLBPCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x628EC30", Offset = "0x628D430", VA = "0x18628EC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x628F370", Offset = "0x628DB70", VA = "0x18628F370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct LEBOLFBCLJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public BNOAPJLBPCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public EGEMJBICGKC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public CABPPMPBKEH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private TaskAwaiter<LGDGGBMJANA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x6291330", Offset = "0x628FB30", VA = "0x186291330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x6291C90", Offset = "0x6290490", VA = "0x186291C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct JKODKLIFOOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public AsyncTaskMethodBuilder<LGDGGBMJANA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public BNOAPJLBPCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public EGEMJBICGKC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public CABPPMPBKEH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private TaskAwaiter<LGDGGBMJANA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x628F7F0", Offset = "0x628DFF0", VA = "0x18628F7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x6290970", Offset = "0x628F170", VA = "0x186290970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct NNPNHEICCME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public AsyncTaskMethodBuilder<LGDGGBMJANA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public BNOAPJLBPCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public EGEMJBICGKC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public CABPPMPBKEH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public LIGDDNKKMOF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private TaskAwaiter<LGDGGBMJANA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x6295D60", Offset = "0x6294560", VA = "0x186295D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x6297130", Offset = "0x6295930", VA = "0x186297130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct ENGMDFPPMOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public AsyncTaskMethodBuilder<LGDGGBMJANA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public BNOAPJLBPCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public LGDGGBMJANA operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public CABPPMPBKEH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public EGEMJBICGKC deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private TaskAwaiter<LGDGGBMJANA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x6289790", Offset = "0x6287F90", VA = "0x186289790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x6289A20", Offset = "0x6288220", VA = "0x186289A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private sealed class JDOJJABHKBI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012B")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000485")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			public AsyncTaskMethodBuilder<LGDGGBMJANA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			public JDOJJABHKBI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			private IDisposable <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			private TaskAwaiter<LGDGGBMJANA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000509")]
			[Cpp2IlInjected.Address(RVA = "0x629C300", Offset = "0x629AB00", VA = "0x18629C300", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600050A")]
			[Cpp2IlInjected.Address(RVA = "0x629C970", Offset = "0x629B170", VA = "0x18629C970", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public BNOAPJLBPCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public EGEMJBICGKC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public CABPPMPBKEH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public JHKDOLNECHL masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public LIGDDNKKMOF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public LGDGGBMJANA originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public JDOJJABHKBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x628F3D0", Offset = "0x628DBD0", VA = "0x18628F3D0")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<LGDGGBMJANA> BOKNIELNEMJ(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct BCPEOJIJBOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public AsyncTaskMethodBuilder<LGDGGBMJANA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public BNOAPJLBPCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public EGEMJBICGKC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public CABPPMPBKEH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public JHKDOLNECHL masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public LIGDDNKKMOF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private TaskAwaiter<LGDGGBMJANA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x6284E90", Offset = "0x6283690", VA = "0x186284E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x62853D0", Offset = "0x6283BD0", VA = "0x1862853D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct HALNLDJIAGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public BNOAPJLBPCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public EGEMJBICGKC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public CABPPMPBKEH progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private LGDGGBMJANA <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		private IEnumerator<LGDGGBMJANA> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private TaskAwaiter<LGDGGBMJANA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x628B0D0", Offset = "0x62898D0", VA = "0x18628B0D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x628B600", Offset = "0x6289E00", VA = "0x18628B600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct HOLANGDLAJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public BNOAPJLBPCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public EGEMJBICGKC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x628CEE0", Offset = "0x628B6E0", VA = "0x18628CEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x628D1F0", Offset = "0x628B9F0", VA = "0x18628D1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct CCDPGKHHLMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public BNOAPJLBPCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public EGEMJBICGKC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x6287D90", Offset = "0x6286590", VA = "0x186287D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x6287FE0", Offset = "0x62867E0", VA = "0x186287FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	private readonly JCNOBKCLCPM CFICDLCKBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	private readonly JCNOBKCLCPM PEIFHOMEOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private readonly JGMGPMLOKAC CDMGHLCAIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	private readonly FLCIDGAEMMI DMAMFFFANDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	private readonly MFENFHFPNME NLNOCCLHDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	private readonly FINJGDFJPJF NFABCHGHLMM;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private HKHECNIPIOJ JEJCGJLHKPD
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x6286F20", Offset = "0x6285720", VA = "0x186286F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event BBPBFMKJKPP MHNMLCHLJDK
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x62874A0", Offset = "0x6285CA0", VA = "0x1862874A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x6286A50", Offset = "0x6285250", VA = "0x186286A50", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x6287A10", Offset = "0x6286210", VA = "0x186287A10")]
	public BNOAPJLBPCE(MNLGPGKPHPA MFJBAPDNGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x6287350", Offset = "0x6285B50", VA = "0x186287350")]
	[AsyncStateMachine(typeof(IENOGDIGCDB))]
	public Task NMLNOGHOFDA(MNHIEHBCOOD LJEEHJLDFLC, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x6286290", Offset = "0x6284A90", VA = "0x186286290")]
	[AsyncStateMachine(typeof(HGLOBNAKOBP))]
	private Task<GEAEOIJPPME> DELOGINMDDO(MNHIEHBCOOD LJEEHJLDFLC, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x6286C70", Offset = "0x6285470", VA = "0x186286C70")]
	[AsyncStateMachine(typeof(OBBNOLPIEOK))]
	private Task GMPNODDPOOA(MNHIEHBCOOD LJEEHJLDFLC, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x62866A0", Offset = "0x6284EA0", VA = "0x1862866A0")]
	[AsyncStateMachine(typeof(OJNLEIKCMBK))]
	private Task EIALONJGJHE(MNHIEHBCOOD LJEEHJLDFLC, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken MLIAGJELKFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x6286A70", Offset = "0x6285270", VA = "0x186286A70")]
	[AsyncStateMachine(typeof(IJABLCJOEKB))]
	private Task GIAMNOICLOF(ANHHFLMKBPC<string>.AJPBBELKCKG AOGFPKDBLJK, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x62867E0", Offset = "0x6284FE0", VA = "0x1862867E0")]
	[AsyncStateMachine(typeof(LEBOLFBCLJM))]
	private Task EMLFPELEJCG(EGEMJBICGKC AELCABDCBDD, CABPPMPBKEH PFAJALCKHDJ, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x6286540", Offset = "0x6284D40", VA = "0x186286540")]
	[AsyncStateMachine(typeof(JKODKLIFOOI))]
	private Task<LGDGGBMJANA> EAHDBMCFGAC(EGEMJBICGKC AELCABDCBDD, LIGDDNKKMOF AOBJJLNIJJM, CABPPMPBKEH PFAJALCKHDJ, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x6287840", Offset = "0x6286040", VA = "0x186287840")]
	[AsyncStateMachine(typeof(NNPNHEICCME))]
	private Task<LGDGGBMJANA> PIHGJEGLBGK(EGEMJBICGKC AELCABDCBDD, LIGDDNKKMOF AOBJJLNIJJM, CABPPMPBKEH PFAJALCKHDJ, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x6286110", Offset = "0x6284910", VA = "0x186286110")]
	[AsyncStateMachine(typeof(ENGMDFPPMOO))]
	private Task<LGDGGBMJANA> CENLGPKGADH(LGDGGBMJANA HFCMEPJOLMI, EGEMJBICGKC OFJFMFJFDNP, CABPPMPBKEH PFAJALCKHDJ, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH, bool JLPHAJFODLH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x6287260", Offset = "0x6285A60", VA = "0x186287260")]
	private bool NKOCMJJDIPE(EGEMJBICGKC JIIEDECMOLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x6287640", Offset = "0x6285E40", VA = "0x186287640")]
	[AsyncStateMachine(typeof(BCPEOJIJBOA))]
	protected Task<LGDGGBMJANA> OGHHFEBBBFH(EGEMJBICGKC AELCABDCBDD, LIGDDNKKMOF AOBJJLNIJJM, CABPPMPBKEH PFAJALCKHDJ, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH, JHKDOLNECHL CCJKDJMKFDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x62863F0", Offset = "0x6284BF0", VA = "0x1862863F0")]
	[AsyncStateMachine(typeof(HALNLDJIAGJ))]
	private Task EAGBDOCDHMN(EGEMJBICGKC AELCABDCBDD, CABPPMPBKEH PFAJALCKHDJ, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x62879C0", Offset = "0x62861C0", VA = "0x1862879C0")]
	private void PJOMGBEDBCB(LGDGGBMJANA IECAPDPKLLG, CABPPMPBKEH PFAJALCKHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x62874C0", Offset = "0x6285CC0", VA = "0x1862874C0")]
	private void ODFIOOIPOAO(LGDGGBMJANA IMKIDBEGMHF, [Out] LGDGGBMJANA GEDLEFCNCCB, [Out] LGDGGBMJANA NGHKNPGNNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x6286930", Offset = "0x6285130", VA = "0x186286930")]
	private Task<DEBDMKGPELG> FOHEKJLGHLE(MNHIEHBCOOD LJEEHJLDFLC, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x62870D0", Offset = "0x62858D0", VA = "0x1862870D0")]
	private Task<EGEMJBICGKC> NGIJIAJCGIM(DEBDMKGPELG AELCABDCBDD, HNJEFBAMJIH.BOLKGIAFBOP MIBBCGFIAOO, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x6286DB0", Offset = "0x62855B0", VA = "0x186286DB0")]
	[AsyncStateMachine(typeof(HOLANGDLAJO))]
	private Task IALCBIFBGNM(EGEMJBICGKC AELCABDCBDD, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH, bool EKLNGAIGAJD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x6286B80", Offset = "0x6285380", VA = "0x186286B80")]
	[AsyncStateMachine(typeof(CCDPGKHHLMC))]
	private Task GJGKKKJKMJO(EGEMJBICGKC AELCABDCBDD, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x6286F70", Offset = "0x6285770", VA = "0x186286F70")]
	private Task MKKPPBJIKGP(EGEMJBICGKC AELCABDCBDD, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x6286F50", Offset = "0x6285750", VA = "0x186286F50")]
	private Task MDNHLDIDNCC(EGEMJBICGKC AELCABDCBDD, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x6286F00", Offset = "0x6285700", VA = "0x186286F00")]
	private Task JHKBEDFCOBD(EGEMJBICGKC AELCABDCBDD, LIGDDNKKMOF AOBJJLNIJJM, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x6287110", Offset = "0x6285910", VA = "0x186287110")]
	private Task NHLFNHFFGPC(EGEMJBICGKC AELCABDCBDD, LIGDDNKKMOF AOBJJLNIJJM, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x6286970", Offset = "0x6285170", VA = "0x186286970")]
	private static Task GCLPPLPBOFF(CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x6287820", Offset = "0x6286020", VA = "0x186287820")]
	private Task OLCDBEHEOHG(EGEMJBICGKC AELCABDCBDD, LIGDDNKKMOF AOBJJLNIJJM, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x6287500", Offset = "0x6285D00", VA = "0x186287500")]
	private Task OEHLKNGHEBM(EGEMJBICGKC AELCABDCBDD, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x62877D0", Offset = "0x6285FD0", VA = "0x1862877D0")]
	private void OJDDIPKKJAD(MNHIEHBCOOD LJEEHJLDFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x62870B0", Offset = "0x62858B0", VA = "0x1862870B0")]
	public void NEDNGNCGGJE(long NCDPLLGFCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	private static void FJPIDCHLOMA(MEGCEJKCLCC BAPHNKFCMLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
internal struct HGCJPJPHMOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	private HKHECNIPIOJ LOJMHJJKLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	private EGEMJBICGKC AELCABDCBDD;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private NHDKLDFMNOK JAIBLGKGHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x628C430", Offset = "0x628AC30", VA = "0x18628C430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x628C350", Offset = "0x628AB50", VA = "0x18628C350")]
	public static Task MFGPHFHEOBL(HKHECNIPIOJ LOJMHJJKLIJ, EGEMJBICGKC AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x628C150", Offset = "0x628A950", VA = "0x18628C150")]
	private void MFGPHFHEOBL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000131")]
internal struct NAKDGFPJBBM
{
	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x6286970", Offset = "0x6285170", VA = "0x186286970")]
	public static Task MFGPHFHEOBL(CancellationToken EHCFBFBFEDH)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal struct BEKNICKMMDK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct OCDELJKNFDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public MNLGPGKPHPA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public EGEMJBICGKC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x6297E60", Offset = "0x6296660", VA = "0x186297E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x62983C0", Offset = "0x6296BC0", VA = "0x1862983C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x6285EA0", Offset = "0x62846A0", VA = "0x186285EA0")]
	[AsyncStateMachine(typeof(OCDELJKNFDF))]
	public static Task MFGPHFHEOBL(MNLGPGKPHPA MFJBAPDNGMP, EGEMJBICGKC AELCABDCBDD, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000134")]
internal struct GNLKLFDPFBD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct NGAAPLLJENP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public MNLGPGKPHPA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public EGEMJBICGKC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public LIGDDNKKMOF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private LGDGGBMJANA <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private HKHECNIPIOJ <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private NHDKLDFMNOK <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private IDisposable <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private List<(PersistenceView, KAGLGJLPIBC)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private KAGLGJLPIBC <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x6294190", Offset = "0x6292990", VA = "0x186294190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x6294E30", Offset = "0x6293630", VA = "0x186294E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x628ACB0", Offset = "0x62894B0", VA = "0x18628ACB0")]
	[AsyncStateMachine(typeof(NGAAPLLJENP))]
	public static Task MFGPHFHEOBL(MNLGPGKPHPA MFJBAPDNGMP, EGEMJBICGKC AELCABDCBDD, LIGDDNKKMOF AOBJJLNIJJM, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x628AAB0", Offset = "0x62892B0", VA = "0x18628AAB0")]
	private static void GDOGFIOMJEK(PersistenceView CLOKEPECCEF, KAGLGJLPIBC CDHDPJPOJHJ, EGEMJBICGKC AELCABDCBDD, LGDGGBMJANA HFCMEPJOLMI, bool ICGHDDKNBOK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000137")]
internal struct DLNNKPICGBE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private struct CHACPNDANFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public HKHECNIPIOJ roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public EGEMJBICGKC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x6288040", Offset = "0x6286840", VA = "0x186288040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x6288480", Offset = "0x6286C80", VA = "0x186288480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x6289530", Offset = "0x6287D30", VA = "0x186289530")]
	[AsyncStateMachine(typeof(CHACPNDANFC))]
	public static Task MFGPHFHEOBL(HKHECNIPIOJ LOJMHJJKLIJ, EGEMJBICGKC AELCABDCBDD, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct HFLMLCLIHFH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private struct KIJMODLNOLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public HKHECNIPIOJ roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public EGEMJBICGKC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public MNLGPGKPHPA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x6290F30", Offset = "0x628F730", VA = "0x186290F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x6291140", Offset = "0x628F940", VA = "0x186291140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private sealed class OHHGHAEAMNI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200013C")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004E1")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004E2")]
			public ANHHFLMKBPC<string>.AJPBBELKCKG timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004E3")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004E4")]
			public OHHGHAEAMNI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004E5")]
			private ANHHFLMKBPC<string>.AJPBBELKCKG <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004E6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0x629C9E0", Offset = "0x629B1E0", VA = "0x18629C9E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000530")]
			[Cpp2IlInjected.Address(RVA = "0x629CD70", Offset = "0x629B570", VA = "0x18629CD70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public OHHGHAEAMNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x6298DC0", Offset = "0x62975C0", VA = "0x186298DC0")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task GICNMFOLPAO(ANHHFLMKBPC<string>.AJPBBELKCKG timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct ALCOLPFIPGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public HFLMLCLIHFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private TaskAwaiter<GEAEOIJPPME> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x6284410", Offset = "0x6282C10", VA = "0x186284410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x6284DC0", Offset = "0x62835C0", VA = "0x186284DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private sealed class LDPJGELNEME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public EDLKHAAMHBP version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public LDPJGELNEME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x62911A0", Offset = "0x628F9A0", VA = "0x1862911A0")]
		internal object KJEJNMBEJBF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x6291280", Offset = "0x628FA80", VA = "0x186291280")]
		internal object NJFBMHBKENE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private HKHECNIPIOJ LOJMHJJKLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	private EGEMJBICGKC AELCABDCBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	private MNLGPGKPHPA MFJBAPDNGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	private bool EKLNGAIGAJD;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	private static readonly ByteString CAJEOFKHDCO;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private NHDKLDFMNOK JAIBLGKGHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x628B9D0", Offset = "0x628A1D0", VA = "0x18628B9D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private GEGICDFBGIP GAOPKHMLGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x628B6A0", Offset = "0x6289EA0", VA = "0x18628B6A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x628B880", Offset = "0x628A080", VA = "0x18628B880")]
	[AsyncStateMachine(typeof(KIJMODLNOLM))]
	public static Task MFGPHFHEOBL(HKHECNIPIOJ LOJMHJJKLIJ, EGEMJBICGKC AELCABDCBDD, MNLGPGKPHPA MFJBAPDNGMP, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH, bool EKLNGAIGAJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x628B740", Offset = "0x6289F40", VA = "0x18628B740")]
	[AsyncStateMachine(typeof(ALCOLPFIPGD))]
	private Task MFGPHFHEOBL(ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x628BA20", Offset = "0x628A220", VA = "0x18628BA20")]
	private void PENNEALJHAD([NotNull] OGBHGJIPJCE LNKNDFPNDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x628B660", Offset = "0x6289E60", VA = "0x18628B660")]
	private bool AIKNNBMOAAG(EDLKHAAMHBP IFOEKNINMPE, OGBHGJIPJCE LNKNDFPNDAJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
internal struct GKNFJDFMCPK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct BEDIGMEBCNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public AsyncTaskMethodBuilder<EGEMJBICGKC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public GKNFJDFMCPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public HNJEFBAMJIH.BOLKGIAFBOP downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private TaskAwaiter<(EOPMGLNDIOA<KLCGJIIIAKO, BJFJCNKKJDP>, EOPMGLNDIOA<OEBIDEOHOKD<OGBHGJIPJCE>, BJFJCNKKJDP>, EOPMGLNDIOA<OEBIDEOHOKD<FFPNNGOGOKI>, BJFJCNKKJDP>, EOPMGLNDIOA<OEBIDEOHOKD<KCHEFKPEJHC>, BJFJCNKKJDP>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x6285440", Offset = "0x6283C40", VA = "0x186285440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x6285E30", Offset = "0x6284630", VA = "0x186285E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct DFKLCLHMPNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<KLCGJIIIAKO, BJFJCNKKJDP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public GKNFJDFMCPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public HNJEFBAMJIH.BOLKGIAFBOP downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private TaskAwaiter<EOPMGLNDIOA<KLCGJIIIAKO, BJFJCNKKJDP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x6288560", Offset = "0x6286D60", VA = "0x186288560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x6288B50", Offset = "0x6287350", VA = "0x186288B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	private CNKODECFGAB<FINMELMELDP, FFPNNGOGOKI> GGFICPINGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private CNKODECFGAB<FINMELMELDP, OGBHGJIPJCE> OAONMEBJDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private CNKODECFGAB<long, KCHEFKPEJHC> GMKDOJCPJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	private AFIMCMFMGGM HMBBOAPHAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private MEGCEJKCLCC BAPHNKFCMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private ILPOHKEMFGB OFAEDIOONDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private string CMPPDGOADDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private FINMELMELDP LAPMLCJGBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private FINMELMELDP PEFHOJDFIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private long NCDPLLGFCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	private ANHHFLMKBPC<string>.AJPBBELKCKG AOGFPKDBLJK;

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x628A5C0", Offset = "0x6288DC0", VA = "0x18628A5C0")]
	public static Task<EGEMJBICGKC> KPGOCEKCHKG(HKHECNIPIOJ LOJMHJJKLIJ, [In] DEBDMKGPELG AELCABDCBDD, HNJEFBAMJIH.BOLKGIAFBOP MIBBCGFIAOO, ANHHFLMKBPC<string>.AJPBBELKCKG AOGFPKDBLJK, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x628A930", Offset = "0x6289130", VA = "0x18628A930")]
	[AsyncStateMachine(typeof(BEDIGMEBCNE))]
	private Task<EGEMJBICGKC> MFGPHFHEOBL(HNJEFBAMJIH.BOLKGIAFBOP MIBBCGFIAOO, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x628A410", Offset = "0x6288C10", VA = "0x18628A410")]
	[AsyncStateMachine(typeof(DFKLCLHMPNA))]
	private Task<EOPMGLNDIOA<KLCGJIIIAKO, BJFJCNKKJDP>> AONNEILNKHN(string CMPPDGOADDE, long NCDPLLGFCLI, HNJEFBAMJIH.BOLKGIAFBOP MIBBCGFIAOO, ANHHFLMKBPC<string>.AJPBBELKCKG JJINBGGDDDA, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
internal struct BBOLOCGCPBK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct GJGKIOFBEIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public AsyncTaskMethodBuilder<DEBDMKGPELG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public BBOLOCGCPBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private TaskAwaiter<DEBDMKGPELG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x62AB4A0", Offset = "0x62A9CA0", VA = "0x1862AB4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x62AB8A0", Offset = "0x62AA0A0", VA = "0x1862AB8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private struct OHKOGBBNJFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public AsyncTaskMethodBuilder<DEBDMKGPELG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public BBOLOCGCPBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private TaskAwaiter<DEBDMKGPELG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x62B4760", Offset = "0x62B2F60", VA = "0x1862B4760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x62B4B60", Offset = "0x62B3360", VA = "0x1862B4B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private sealed class JLAIABHJKJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public JLAIABHJKJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x1306F30", Offset = "0x1305730", VA = "0x181306F30")]
		internal bool NPDEEBDAACF(ILPOHKEMFGB sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct ENBNMCOKEKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public AsyncTaskMethodBuilder<DEBDMKGPELG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public FINMELMELDP superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public NHDKLDFMNOK callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		private JLAIABHJKJH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private MEGCEJKCLCC <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private ILPOHKEMFGB <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private FINMELMELDP <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private FINMELMELDP <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private TaskAwaiter<MEGCEJKCLCC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private TaskAwaiter<DLGOOIKOPLC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private TaskAwaiter<MLEOJECBJGH> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x62A5AD0", Offset = "0x62A42D0", VA = "0x1862A5AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x62A6B70", Offset = "0x62A5370", VA = "0x1862A6B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	private NHDKLDFMNOK HGOFPLJJILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	private JGMGPMLOKAC CDMGHLCAIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	private ANHHFLMKBPC<string>.AJPBBELKCKG AOGFPKDBLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	private long NBNJFKJOFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	private long OMOMGBJOLII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	private long MHNINMPGKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private string KPKBCEDPOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	private FINMELMELDP OGJCACJKHAB;

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x629F770", Offset = "0x629DF70", VA = "0x18629F770")]
	public static Task<DEBDMKGPELG> KPGOCEKCHKG(HKHECNIPIOJ LOJMHJJKLIJ, MNHIEHBCOOD LJEEHJLDFLC, ANHHFLMKBPC<string>.AJPBBELKCKG AOGFPKDBLJK, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x629F9F0", Offset = "0x629E1F0", VA = "0x18629F9F0")]
	[AsyncStateMachine(typeof(GJGKIOFBEIH))]
	private Task<DEBDMKGPELG> MFGPHFHEOBL(CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x629F480", Offset = "0x629DC80", VA = "0x18629F480")]
	[AsyncStateMachine(typeof(OHKOGBBNJFA))]
	private Task<DEBDMKGPELG> FOHEKJLGHLE(ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x629F5E0", Offset = "0x629DDE0", VA = "0x18629F5E0")]
	[AsyncStateMachine(typeof(ENBNMCOKEKN))]
	private static Task<DEBDMKGPELG> FOHEKJLGHLE(NHDKLDFMNOK HGOFPLJJILB, long NBNJFKJOFIF, long OMOMGBJOLII, long MHNINMPGKNJ, string KPKBCEDPOCD, FINMELMELDP OGJCACJKHAB, CancellationToken EHCFBFBFEDH, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x629F450", Offset = "0x629DC50", VA = "0x18629F450")]
	private void EHGLFGJECIN(MEGCEJKCLCC BAPHNKFCMLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
internal struct JFFBCOEKAJE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct LODPNIOOCFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public JFFBCOEKAJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x62B1C60", Offset = "0x62B0460", VA = "0x1862B1C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x62B21F0", Offset = "0x62B09F0", VA = "0x1862B21F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private NHDKLDFMNOK HGOFPLJJILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private EGEMJBICGKC AELCABDCBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private ANHHFLMKBPC<string>.AJPBBELKCKG AOGFPKDBLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private float IHJLAGNPNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	private float JOHFHIAHOEC;

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x62AE640", Offset = "0x62ACE40", VA = "0x1862AE640")]
	public static Task AFGBFKAHBGJ(HKHECNIPIOJ LOJMHJJKLIJ, EGEMJBICGKC AELCABDCBDD, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x62AEB60", Offset = "0x62AD360", VA = "0x1862AEB60")]
	[AsyncStateMachine(typeof(LODPNIOOCFN))]
	public Task MFGPHFHEOBL(CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x62AE8C0", Offset = "0x62AD0C0", VA = "0x1862AE8C0")]
	private static void GJBMJMKBOLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x62AEA00", Offset = "0x62AD200", VA = "0x1862AEA00")]
	private void GJJDIAHFLAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x62AE800", Offset = "0x62AD000", VA = "0x1862AE800")]
	private static float FFLPCLOKBFM(NHDKLDFMNOK HGOFPLJJILB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x62AE7E0", Offset = "0x62ACFE0", VA = "0x1862AE7E0")]
	private static float FDJICDHHGBL()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014A")]
internal struct ENDECIAJDGA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private struct DGIKDOCABDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public MNLGPGKPHPA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public EGEMJBICGKC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private OFOHOILEKAB <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private HKHECNIPIOJ <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private EBBAOCAOMFB.JEMHICDOMOH <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private TaskAwaiter<GEAEOIJPPME> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x62A3080", Offset = "0x62A1880", VA = "0x1862A3080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x62A3A70", Offset = "0x62A2270", VA = "0x1862A3A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct IJEFCAEHDJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x62ADB10", Offset = "0x62AC310", VA = "0x1862ADB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x62ADE40", Offset = "0x62AC640", VA = "0x1862ADE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x62A6D00", Offset = "0x62A5500", VA = "0x1862A6D00")]
	[AsyncStateMachine(typeof(DGIKDOCABDH))]
	public static Task MFGPHFHEOBL(MNLGPGKPHPA MFJBAPDNGMP, EGEMJBICGKC AELCABDCBDD, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x62A6C90", Offset = "0x62A5490", VA = "0x1862A6C90")]
	private static Task<GEAEOIJPPME> FPCJGINOLOE(MNLGPGKPHPA MFJBAPDNGMP, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x62A6BE0", Offset = "0x62A53E0", VA = "0x1862A6BE0")]
	[AsyncStateMachine(typeof(IJEFCAEHDJD))]
	private static Task CKFBGICNHKH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
internal struct FLBHJKHNFAL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct NJGAJMIFBOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public FLBHJKHNFAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x62B3880", Offset = "0x62B2080", VA = "0x1862B3880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x62B3F30", Offset = "0x62B2730", VA = "0x1862B3F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private sealed class KJEBIGKPMFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public KJEBIGKPMFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x62B0250", Offset = "0x62AEA50", VA = "0x1862B0250")]
		internal object NABNACOINEL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct DIGOJNNGDIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public FLBHJKHNFAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private BLFBDJGMPNJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x62A3AD0", Offset = "0x62A22D0", VA = "0x1862A3AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x62A40E0", Offset = "0x62A28E0", VA = "0x1862A40E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400055B")]
	private bool FNGHEOJCEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400055C")]
	private ANHHFLMKBPC<string>.AJPBBELKCKG AOGFPKDBLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400055D")]
	private HKHECNIPIOJ LOJMHJJKLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400055E")]
	private CancellationToken EHCFBFBFEDH;

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x62A9F20", Offset = "0x62A8720", VA = "0x1862A9F20")]
	public static Task DPBAEIPGHOE(HKHECNIPIOJ LOJMHJJKLIJ, bool FNGHEOJCEKK, ANHHFLMKBPC<string>.AJPBBELKCKG AOGFPKDBLJK, CancellationToken CFOIEPEIFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x62A9F90", Offset = "0x62A8790", VA = "0x1862A9F90")]
	[AsyncStateMachine(typeof(NJGAJMIFBOO))]
	private Task MFGPHFHEOBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x62A9DF0", Offset = "0x62A85F0", VA = "0x1862A9DF0")]
	[AsyncStateMachine(typeof(DIGOJNNGDIJ))]
	private Task ADIJCFKENIB(bool POPOELKFFIE, string JACEFLIJGKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370")]
	private bool IJKIBOJDIOJ(bool FNGHEOJCEKK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal struct KHCJENOKFEP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct DDOIEPHCCBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public KHCJENOKFEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x62A2350", Offset = "0x62A0B50", VA = "0x1862A2350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x62A28C0", Offset = "0x62A10C0", VA = "0x1862A28C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private sealed class HMDMDHONLMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public HMDMDHONLMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x62ABA50", Offset = "0x62AA250", VA = "0x1862ABA50")]
		internal object NABNACOINEL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct FFLFHEGFPKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public KHCJENOKFEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		private BLFBDJGMPNJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x62A82C0", Offset = "0x62A6AC0", VA = "0x1862A82C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x62A88A0", Offset = "0x62A70A0", VA = "0x1862A88A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	private CLPKLIOEOAD AOJMNKNPGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000570")]
	private ANHHFLMKBPC<string>.AJPBBELKCKG AOGFPKDBLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000571")]
	private HKHECNIPIOJ LOJMHJJKLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	private bool IDNOPFPMPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000573")]
	private EGEMJBICGKC AELCABDCBDD;

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x62AFB70", Offset = "0x62AE370", VA = "0x1862AFB70")]
	public static Task<Scene> FOLPOIPIHMB(HKHECNIPIOJ LOJMHJJKLIJ, CLPKLIOEOAD NCEENBECFAP, ANHHFLMKBPC<string>.AJPBBELKCKG AOGFPKDBLJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x62AFBF0", Offset = "0x62AE3F0", VA = "0x1862AFBF0")]
	[AsyncStateMachine(typeof(DDOIEPHCCBJ))]
	private Task<Scene> MFGPHFHEOBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x62AFAD0", Offset = "0x62AE2D0", VA = "0x1862AFAD0")]
	private bool AIJAFIGKNBI(EGEMJBICGKC AELCABDCBDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x62AFB00", Offset = "0x62AE300", VA = "0x1862AFB00")]
	private void CBOKHAFIBPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x62AF980", Offset = "0x62AE180", VA = "0x1862AF980")]
	[AsyncStateMachine(typeof(FFLFHEGFPKG))]
	private Task<Scene> ADIJCFKENIB(string JACEFLIJGKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
internal struct MFENFHFPNME
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct LDBBDMAGADG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public AsyncTaskMethodBuilder<LGDGGBMJANA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public MFENFHFPNME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public LGDGGBMJANA nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public EGEMJBICGKC deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private TaskAwaiter<LGDGGBMJANA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x62B0410", Offset = "0x62AEC10", VA = "0x1862B0410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x62B0EF0", Offset = "0x62AF6F0", VA = "0x1862B0EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct FAAICBGCHKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public AsyncTaskMethodBuilder<LGDGGBMJANA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public MFENFHFPNME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public LGDGGBMJANA state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private TaskAwaiter<GEAEOIJPPME> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x62A78E0", Offset = "0x62A60E0", VA = "0x1862A78E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x62A7BC0", Offset = "0x62A63C0", VA = "0x1862A7BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000581")]
	private readonly MNLGPGKPHPA MFJBAPDNGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000582")]
	private readonly JGMGPMLOKAC CDMGHLCAIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000583")]
	private readonly FLCIDGAEMMI DMAMFFFANDI;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private OFOHOILEKAB EFDHOHIMFKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x4B8DC60", Offset = "0x4B8C460", VA = "0x184B8DC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x62B3560", Offset = "0x62B1D60", VA = "0x1862B3560")]
	public MFENFHFPNME(MNLGPGKPHPA MFJBAPDNGMP, JGMGPMLOKAC CDMGHLCAIIK, FLCIDGAEMMI DMAMFFFANDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x62B3390", Offset = "0x62B1B90", VA = "0x1862B3390")]
	[AsyncStateMachine(typeof(LDBBDMAGADG))]
	public Task<LGDGGBMJANA> HKKLLNFBBMI(LGDGGBMJANA LGACKEHBHGD, EGEMJBICGKC OFJFMFJFDNP, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH, bool JLPHAJFODLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x62B3230", Offset = "0x62B1A30", VA = "0x1862B3230")]
	[AsyncStateMachine(typeof(FAAICBGCHKN))]
	private Task<LGDGGBMJANA> BHMANCKJCJM(ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, LGDGGBMJANA CDOGIGHJFKJ, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x62B3510", Offset = "0x62B1D10", VA = "0x1862B3510")]
	private bool MMOBCLKCPIB(LGDGGBMJANA OCBPPKHKHEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x62B3540", Offset = "0x62B1D40", VA = "0x1862B3540")]
	private void NOCJPHOMELN(string JODJCGEJGGG)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000158")]
internal struct GJKKHGMMCLA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct NOGNFBBIKOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public OFOHOILEKAB operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public EGEMJBICGKC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public LIGDDNKKMOF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private List<(PersistenceView, KAGLGJLPIBC)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private (PersistenceView, KAGLGJLPIBC) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x62B40C0", Offset = "0x62B28C0", VA = "0x1862B40C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x62B4700", Offset = "0x62B2F00", VA = "0x1862B4700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x62AB910", Offset = "0x62AA110", VA = "0x1862AB910")]
	[AsyncStateMachine(typeof(NOGNFBBIKOL))]
	public static Task MFGPHFHEOBL(OFOHOILEKAB NFBNNCDBMIA, EGEMJBICGKC AELCABDCBDD, LIGDDNKKMOF AOBJJLNIJJM, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct IMHGAPEBOMH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct DCINFKPHDFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public OFOHOILEKAB operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public EGEMJBICGKC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public LIGDDNKKMOF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private EDLKHAAMHBP <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private List<(PersistenceView, KAGLGJLPIBC)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		private KAGLGJLPIBC <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x62A1A20", Offset = "0x62A0220", VA = "0x1862A1A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x62A2280", Offset = "0x62A0A80", VA = "0x1862A2280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x62AE1C0", Offset = "0x62AC9C0", VA = "0x1862AE1C0")]
	[AsyncStateMachine(typeof(DCINFKPHDFM))]
	public static Task MFGPHFHEOBL(OFOHOILEKAB NFBNNCDBMIA, EGEMJBICGKC AELCABDCBDD, LIGDDNKKMOF AOBJJLNIJJM, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal struct EBBAOCAOMFB
{
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	public struct JEMHICDOMOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public List<FDIKHEBPHEA> JAFDIMMLPNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public List<KAGLGJLPIBC> OFELIKBJPCC;

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x7F3540", Offset = "0x7F1D40", VA = "0x1807F3540")]
		public JEMHICDOMOH(List<FDIKHEBPHEA> JAFDIMMLPNK, List<KAGLGJLPIBC> OFELIKBJPCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private sealed class MNKHPMJEFEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public IEnumerable<FDIKHEBPHEA> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public MNKHPMJEFEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x62B3630", Offset = "0x62B1E30", VA = "0x1862B3630")]
		internal object MPCFIABAHHE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005B0")]
	private HKHECNIPIOJ LOJMHJJKLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005B1")]
	private EGEMJBICGKC AELCABDCBDD;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private NHDKLDFMNOK JAIBLGKGHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x62A5740", Offset = "0x62A3F40", VA = "0x1862A5740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x62A56E0", Offset = "0x62A3EE0", VA = "0x1862A56E0")]
	public static JEMHICDOMOH MFGPHFHEOBL(HKHECNIPIOJ LOJMHJJKLIJ, EGEMJBICGKC AELCABDCBDD)
	{
		return default(JEMHICDOMOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x62A5480", Offset = "0x62A3C80", VA = "0x1862A5480")]
	private JEMHICDOMOH MFGPHFHEOBL()
	{
		return default(JEMHICDOMOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x62A4D00", Offset = "0x62A3500", VA = "0x1862A4D00")]
	private JEMHICDOMOH FHOOCJECOMD(OGBHGJIPJCE LNKNDFPNDAJ, EDLKHAAMHBP HKCLCOJCCHA)
	{
		return default(JEMHICDOMOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x62A52B0", Offset = "0x62A3AB0", VA = "0x1862A52B0")]
	private bool IHALCLOLJAE(IEnumerable<FDIKHEBPHEA> JAFDIMMLPNK)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015F")]
internal struct APJNBDPMCBB
{
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class BFBGFLJPCAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public EBBAOCAOMFB.JEMHICDOMOH instantiations;

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public BFBGFLJPCAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x62A0C30", Offset = "0x629F430", VA = "0x1862A0C30")]
		internal object GICNMFOLPAO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private sealed class FJNEEOFBMCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public FJNEEOFBMCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x62A9D60", Offset = "0x62A8560", VA = "0x1862A9D60")]
		internal object JEIOBJLNIPH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x629EEA0", Offset = "0x629D6A0", VA = "0x18629EEA0")]
	public static void MFGPHFHEOBL(OFOHOILEKAB NFBNNCDBMIA, EGEMJBICGKC AELCABDCBDD, EBBAOCAOMFB.JEMHICDOMOH JOLCFFGIGML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
internal class FLCIDGAEMMI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private struct LILEJFPHCAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public FLCIDGAEMMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public LGDGGBMJANA operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public EGEMJBICGKC deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x62B1490", Offset = "0x62AFC90", VA = "0x1862B1490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x62B1C00", Offset = "0x62B0400", VA = "0x1862B1C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class PABPFPGKNAA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000165")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005C7")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005C8")]
			public PABPFPGKNAA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005C9")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005CA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0x62B5950", Offset = "0x62B4150", VA = "0x1862B5950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A2")]
			[Cpp2IlInjected.Address(RVA = "0x62B5C10", Offset = "0x62B4410", VA = "0x1862B5C10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public FLCIDGAEMMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public EGEMJBICGKC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public PABPFPGKNAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x62B5660", Offset = "0x62B3E60", VA = "0x1862B5660")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task IJBCCNMJDFM(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private struct OLNNFJJLBIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public FLCIDGAEMMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public EGEMJBICGKC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		private PABPFPGKNAA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x62B4C40", Offset = "0x62B3440", VA = "0x1862B4C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x62B5170", Offset = "0x62B3970", VA = "0x1862B5170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private struct JOLPDCKHPGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public FLCIDGAEMMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public EGEMJBICGKC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		private Dictionary<Guid, List<BOKNLEENGCP>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x62AF370", Offset = "0x62ADB70", VA = "0x1862AF370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x62AF920", Offset = "0x62AE120", VA = "0x1862AF920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct MAEOOKFLMBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public FLCIDGAEMMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public EGEMJBICGKC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private Dictionary<Guid, List<BOKNLEENGCP>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x62B22F0", Offset = "0x62B0AF0", VA = "0x1862B22F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x62B2970", Offset = "0x62B1170", VA = "0x1862B2970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class IPIEDGFFAPH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016A")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005EA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005EB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005EC")]
			public BOKNLEENGCP handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005ED")]
			public IPIEDGFFAPH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005EE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x62B5750", Offset = "0x62B3F50", VA = "0x1862B5750", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x62B58F0", Offset = "0x62B40F0", VA = "0x1862B58F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public LGEJCKKFAJI runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public List<BOKNLEENGCP> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public EGEMJBICGKC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public IPIEDGFFAPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x62AE550", Offset = "0x62ACD50", VA = "0x1862AE550")]
		internal object KGHDMLDMPJD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x62AE460", Offset = "0x62ACC60", VA = "0x1862AE460")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task GIPMENELGIG(BOKNLEENGCP handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x62AE370", Offset = "0x62ACB70", VA = "0x1862AE370")]
		internal object FIIOEBDIDKH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private struct LFLNDOHJMMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public LGEJCKKFAJI runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public List<BOKNLEENGCP> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public EGEMJBICGKC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		private IPIEDGFFAPH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x62B0F60", Offset = "0x62AF760", VA = "0x1862B0F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x62B1430", Offset = "0x62AFC30", VA = "0x1862B1430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct ABDBGABPKBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public FLCIDGAEMMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public EGEMJBICGKC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x629D700", Offset = "0x629BF00", VA = "0x18629D700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x629DCB0", Offset = "0x629C4B0", VA = "0x18629DCB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class IOIEAEMJDBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public IOIEAEMJDBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x62AE300", Offset = "0x62ACB00", VA = "0x1862AE300")]
		internal object DJGKPHKMBCI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private struct APGAAOFCBGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public FLCIDGAEMMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public EGEMJBICGKC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x629E930", Offset = "0x629D130", VA = "0x18629E930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x629EE40", Offset = "0x629D640", VA = "0x18629EE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private sealed class DGALHHMPBOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public DGALHHMPBOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x62A2930", Offset = "0x62A1130", VA = "0x1862A2930")]
		internal object EKPGNCPDJMF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct DGFIPKLLLAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public FLCIDGAEMMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		private TaskAwaiter<GEAEOIJPPME> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x62A29A0", Offset = "0x62A11A0", VA = "0x1862A29A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x62A3020", Offset = "0x62A1820", VA = "0x1862A3020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class OJGBEEALKFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public OJGBEEALKFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x62B4BD0", Offset = "0x62B33D0", VA = "0x1862B4BD0")]
		internal object AOEFFHPPEOC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B8")]
	private readonly MNLGPGKPHPA MFJBAPDNGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005B9")]
	private NCBKNJAFGEG DMAMFFFANDI;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private OFOHOILEKAB EFDHOHIMFKG
	{
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x19FC7C0", Offset = "0x19FAFC0", VA = "0x1819FC7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x768BD0", Offset = "0x7673D0", VA = "0x180768BD0")]
	public FLCIDGAEMMI(MNLGPGKPHPA MFJBAPDNGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x62AAE90", Offset = "0x62A9690", VA = "0x1862AAE90")]
	[AsyncStateMachine(typeof(LILEJFPHCAM))]
	public Task MFGPHFHEOBL(LGDGGBMJANA HFCMEPJOLMI, EGEMJBICGKC OFJFMFJFDNP, ANHHFLMKBPC<string>.AJPBBELKCKG AOGFPKDBLJK, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x62AA1C0", Offset = "0x62A89C0", VA = "0x1862AA1C0")]
	[AsyncStateMachine(typeof(OLNNFJJLBIO))]
	private Task AFJLEHALHMH(EGEMJBICGKC AELCABDCBDD, ANHHFLMKBPC<string>.AJPBBELKCKG AOGFPKDBLJK, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x62AA440", Offset = "0x62A8C40", VA = "0x1862AA440")]
	[AsyncStateMachine(typeof(JOLPDCKHPGF))]
	private Task BABDABICBFI(EGEMJBICGKC AELCABDCBDD, ANHHFLMKBPC<string>.AJPBBELKCKG AOGFPKDBLJK, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x62AA080", Offset = "0x62A8880", VA = "0x1862AA080")]
	[AsyncStateMachine(typeof(MAEOOKFLMBN))]
	private Task ACMPLLJDBGF(EGEMJBICGKC AELCABDCBDD, ANHHFLMKBPC<string>.AJPBBELKCKG AOGFPKDBLJK, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x62AAAE0", Offset = "0x62A92E0", VA = "0x1862AAAE0")]
	[AsyncStateMachine(typeof(LFLNDOHJMMF))]
	private Task FOMPJHEPMOE(Guid BLNKDDDPKLN, List<BOKNLEENGCP> EGNFJGLHPFJ, LGEJCKKFAJI JOLOPFNOKMF, EGEMJBICGKC AELCABDCBDD, CancellationToken KIAKEGJPMAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x62AAC30", Offset = "0x62A9430", VA = "0x1862AAC30")]
	[AsyncStateMachine(typeof(ABDBGABPKBJ))]
	private Task JNCINMCDAPF(EGEMJBICGKC AELCABDCBDD, ANHHFLMKBPC<string>.AJPBBELKCKG AOGFPKDBLJK, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x62AA760", Offset = "0x62A8F60", VA = "0x1862AA760")]
	[AsyncStateMachine(typeof(APGAAOFCBGI))]
	private Task EHIAOHNNAEJ(Guid FFHGPHCIIHI, EGEMJBICGKC AELCABDCBDD, ANHHFLMKBPC<string>.AJPBBELKCKG AOGFPKDBLJK, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x62AA300", Offset = "0x62A8B00", VA = "0x1862AA300")]
	[AsyncStateMachine(typeof(DGFIPKLLLAD))]
	private Task APEIBLDHFPJ(Guid FFHGPHCIIHI, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x62AAD70", Offset = "0x62A9570", VA = "0x1862AAD70")]
	private void KKILEBPANME(Guid FFHGPHCIIHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x62AAA30", Offset = "0x62A9230", VA = "0x1862AAA30")]
	private void FHKGEPGBHNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x62AA8A0", Offset = "0x62A90A0", VA = "0x1862AA8A0")]
	public Guid ELBGGEHKJDM(LGDGGBMJANA IECAPDPKLLG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x62AA580", Offset = "0x62A8D80", VA = "0x1862AA580")]
	[CompilerGenerated]
	private object DDECBDHILKI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
public readonly struct IMAENCKMEPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000616")]
	public readonly bool GNAHALKCMHD;

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0xB25330", Offset = "0xB23B30", VA = "0x180B25330")]
	public IMAENCKMEPE(bool MHNNDMNOICH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
public readonly struct KKLDNOOFJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000617")]
	public readonly OGBHGJIPJCE? FFEGMMADEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000618")]
	public readonly FEEMIECDKBL FBGEGDJGOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000619")]
	public readonly string? OAMNCKJIOOO;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public IReadOnlyCollection<string> EKEHEBAHIBG
	{
		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x62B02F0", Offset = "0x62AEAF0", VA = "0x1862B02F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public IReadOnlyDictionary<long, int> DEGDHCJMHLC
	{
		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x62B02D0", Offset = "0x62AEAD0", VA = "0x1862B02D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x62B0310", Offset = "0x62AEB10", VA = "0x1862B0310")]
	public KKLDNOOFJJJ(OGBHGJIPJCE? KAGMDCLCJHI, FEEMIECDKBL NIHMHJOIMMH, string? CMPPDGOADDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
internal class BCBBNCKGLHE : NCMKMJBCHEP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private struct BPDCKPLIDPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public AsyncTaskMethodBuilder<KKLDNOOFJJJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public BCBBNCKGLHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public CJJNPMBFNCP serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public JKDLBDKJGBI roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x62A0CE0", Offset = "0x629F4E0", VA = "0x1862A0CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x62A1380", Offset = "0x629FB80", VA = "0x1862A1380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private sealed class EJDGAPFHHHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public CJJNPMBFNCP serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public BCBBNCKGLHE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public EJDGAPFHHHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x62A58B0", Offset = "0x62A40B0", VA = "0x1862A58B0")]
		internal Task OIGFKIMPMFL(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x62A57D0", Offset = "0x62A3FD0", VA = "0x1862A57D0")]
		internal Task KHMGOKJDDAB(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private sealed class MGMHBIDHBEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public EJDGAPFHHHH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public MGMHBIDHBEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x62B35C0", Offset = "0x62B1DC0", VA = "0x1862B35C0")]
		internal object NNIKHGCILJC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class EFDJNDEAFGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public EJDGAPFHHHH CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public EFDJNDEAFGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x62A5790", Offset = "0x62A3F90", VA = "0x1862A5790")]
		internal Task DPKCFPGMLDN(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private struct IGGKNJIMPDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public CJJNPMBFNCP serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public BCBBNCKGLHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private MGMHBIDHBEA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x62ACEC0", Offset = "0x62AB6C0", VA = "0x1862ACEC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x62AD780", Offset = "0x62ABF80", VA = "0x1862AD780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400061A")]
	private readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x400061B")]
	private static readonly TimeSpan CDLODMFJLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400061C")]
	private readonly BJIJAONMOGM JKOOCOPMHBL;

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x62A0BE0", Offset = "0x629F3E0", VA = "0x1862A0BE0")]
	public BCBBNCKGLHE(MNLGPGKPHPA MFJBAPDNGMP, BJIJAONMOGM JKOOCOPMHBL, DGJIKJLGCCH KFIEDGIKACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x629FB40", Offset = "0x629E340", VA = "0x18629FB40")]
	[AsyncStateMachine(typeof(BPDCKPLIDPK))]
	public Task<KKLDNOOFJJJ> BBOAPHOFBBK(long OMOMGBJOLII, JKDLBDKJGBI GNAMFMBEGAN, CJJNPMBFNCP JPMJJLLKIJF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x62A0140", Offset = "0x629E940", VA = "0x1862A0140")]
	[AsyncStateMachine(typeof(IGGKNJIMPDD))]
	private Task ENIEOGHGIBB(CJJNPMBFNCP JPMJJLLKIJF, IEnumerable<PersistenceView> NPHNDFFHJOB, StringBuilder DKFELGGMLNL, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x629FCA0", Offset = "0x629E4A0", VA = "0x18629FCA0")]
	private KKLDNOOFJJJ BEHBMJFAFLG(long OMOMGBJOLII, JKDLBDKJGBI GNAMFMBEGAN, CJJNPMBFNCP JPMJJLLKIJF, IEnumerable<PersistenceView> NPHNDFFHJOB, StringBuilder DKFELGGMLNL)
	{
		return default(KKLDNOOFJJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x62A0290", Offset = "0x629EA90", VA = "0x1862A0290")]
	private OGBHGJIPJCE FOODMLLLBEH(long OMOMGBJOLII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x62A0450", Offset = "0x629EC50", VA = "0x1862A0450")]
	private void HDOPBALPNMF(OGBHGJIPJCE JMJMKBNLIKI, StringBuilder DKFELGGMLNL, IEnumerable<PersistenceView> NPHNDFFHJOB, [In] KMPCKLFLAEJ LLMGHJGNIAD, EHMMPJGANPO DPBIIOIDPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x62A06A0", Offset = "0x629EEA0", VA = "0x1862A06A0")]
	private void KJFGAMFGDPI(OGBHGJIPJCE JMJMKBNLIKI, StringBuilder DKFELGGMLNL, PersistenceView CLOKEPECCEF, EHMMPJGANPO DPBIIOIDPKH, [In] KMPCKLFLAEJ LLMGHJGNIAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
internal class JIAEDHHFNMM : NCMKMJBCHEP
{
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private sealed class FIPCMEKMJBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public NDEJCBMFAJE.LEFJIJPLCAC roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public FIPCMEKMJBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x62A9D10", Offset = "0x62A8510", VA = "0x1862A9D10")]
		internal object HBECGMIJBCL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private struct HPDGJEKPGJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public AsyncTaskMethodBuilder<(NDEJCBMFAJE.LEFJIJPLCAC roomDataUpload, NDEJCBMFAJE.LEFJIJPLCAC subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public KKLDNOOFJJJ roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public JIAEDHHFNMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		private FIPCMEKMJBM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private TaskAwaiter<NDEJCBMFAJE.LEFJIJPLCAC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x62ABAA0", Offset = "0x62AA2A0", VA = "0x1862ABAA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x62AC2E0", Offset = "0x62AAAE0", VA = "0x1862AC2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private struct FFJAKDJFCAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		public AsyncTaskMethodBuilder<GCMHHKBFFMI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public JIAEDHHFNMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public KKLDNOOFJJJ roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public POCCJPPMGCN roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		private TaskAwaiter<(NDEJCBMFAJE.LEFJIJPLCAC roomDataUpload, NDEJCBMFAJE.LEFJIJPLCAC subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		private TaskAwaiter<GCMHHKBFFMI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x62A7C30", Offset = "0x62A6430", VA = "0x1862A7C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x62A8250", Offset = "0x62A6A50", VA = "0x1862A8250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct CCNHJCJCPAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public AsyncTaskMethodBuilder<DLGOOIKOPLC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public JIAEDHHFNMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public KKLDNOOFJJJ roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		private TaskAwaiter<(NDEJCBMFAJE.LEFJIJPLCAC roomDataUpload, NDEJCBMFAJE.LEFJIJPLCAC subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private TaskAwaiter<DLGOOIKOPLC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x62A13F0", Offset = "0x629FBF0", VA = "0x1862A13F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x62A1810", Offset = "0x62A0010", VA = "0x1862A1810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private sealed class NJMCFDIEBOA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000182")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000668")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000669")]
			public AsyncTaskMethodBuilder<GEAEOIJPPME> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400066A")]
			public NJMCFDIEBOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400066B")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400066C")]
			private GEAEOIJPPME <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400066D")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400066E")]
			private TaskAwaiter<DLGOOIKOPLC> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400066F")]
			private TaskAwaiter<GCMHHKBFFMI> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000670")]
			private TaskAwaiter<GEAEOIJPPME> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(RVA = "0x62B5C70", Offset = "0x62B4470", VA = "0x1862B5C70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x62B6C70", Offset = "0x62B5470", VA = "0x1862B6C70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public JIAEDHHFNMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public KKLDNOOFJJJ roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public POCCJPPMGCN roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public IMAENCKMEPE roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public NJMCFDIEBOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x62B3F90", Offset = "0x62B2790", VA = "0x1862B3F90")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<GEAEOIJPPME> BDGJNMBGKNJ(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private struct IAJPNMJKJKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public AsyncTaskMethodBuilder<GEAEOIJPPME> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public JIAEDHHFNMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public KKLDNOOFJJJ roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public POCCJPPMGCN roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public IMAENCKMEPE roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private TaskAwaiter<GEAEOIJPPME> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x62AC9F0", Offset = "0x62AB1F0", VA = "0x1862AC9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x62ACD00", Offset = "0x62AB500", VA = "0x1862ACD00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400063F")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x4000640")]
	private static readonly DGJIKJLGCCH JHPMPPNJLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000641")]
	private readonly ALBKEKEEMGG AOMHJKJMKKC;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private HKHECNIPIOJ JEJCGJLHKPD
	{
		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x6286F20", Offset = "0x6285720", VA = "0x186286F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0x62AF2E0", Offset = "0x62ADAE0", VA = "0x1862AF2E0")]
	public JIAEDHHFNMM(MNLGPGKPHPA MFJBAPDNGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x62AEDF0", Offset = "0x62AD5F0", VA = "0x1862AEDF0")]
	[AsyncStateMachine(typeof(HPDGJEKPGJO))]
	private Task<(NDEJCBMFAJE.LEFJIJPLCAC, NDEJCBMFAJE.LEFJIJPLCAC)> KLIGJCGPIIE(KKLDNOOFJJJ BDCAKKAGLOE, long NBNJFKJOFIF, long HEOAHEPJHCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0x62AEF30", Offset = "0x62AD730", VA = "0x1862AEF30")]
	[AsyncStateMachine(typeof(FFJAKDJFCAH))]
	public Task<GCMHHKBFFMI> PGIKIKBIAFH(int NINOCLLNPBI, [CanBeNull] POCCJPPMGCN BPFMCEBCONM, KKLDNOOFJJJ BDCAKKAGLOE, long NBNJFKJOFIF, long HEOAHEPJHCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x62AEC80", Offset = "0x62AD480", VA = "0x1862AEC80")]
	[AsyncStateMachine(typeof(CCNHJCJCPAJ))]
	private Task<DLGOOIKOPLC> HFLMCEEDCGJ(string KPKBCEDPOCD, int NINOCLLNPBI, KKLDNOOFJJJ BDCAKKAGLOE, long NBNJFKJOFIF, long HEOAHEPJHCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x62AF0A0", Offset = "0x62AD8A0", VA = "0x1862AF0A0")]
	[AsyncStateMachine(typeof(IAJPNMJKJKH))]
	public Task<GEAEOIJPPME> PPMFAJEALEO(int NINOCLLNPBI, POCCJPPMGCN? BPFMCEBCONM, KKLDNOOFJJJ BDCAKKAGLOE, long NBNJFKJOFIF, long HEOAHEPJHCF, IMAENCKMEPE INMHOHJIBMI, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
public abstract class LOABHNFGAAM<T> where T : LOABHNFGAAM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400067D")]
	internal readonly HKHECNIPIOJ HINAMPFGCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400067E")]
	private int? EEAJPCMPCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400067F")]
	protected readonly Guid DEPMDGOGFMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000680")]
	protected readonly JNPLDNDBBJJ JIHBMEGOKEE;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	protected T CPEFCBDJHED
	{
		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x3928B90", Offset = "0x3927390", VA = "0x183928B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x3928E00", Offset = "0x3927600", VA = "0x183928E00")]
	internal LOABHNFGAAM(HKHECNIPIOJ OHLNCHINAEP, JNPLDNDBBJJ LILDKJDGMDE, [Optional] Guid? BACFDICONIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x3928A20", Offset = "0x3927220", VA = "0x183928A20")]
	private GEAEOIJPPME FNBEJAIMCBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "4")]
	protected virtual void PIFIOGMICBE(GEAEOIJPPME BKGEBGGPBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x3928BF0", Offset = "0x39273F0", VA = "0x183928BF0")]
	public T MCDNMCHGFDC(JLNLBCDKCMG AKFGFNBMNIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x3928B00", Offset = "0x3927300", VA = "0x183928B00")]
	public T GAFGONHJDGJ(int DELFHHHKBPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x3928CE0", Offset = "0x39274E0", VA = "0x183928CE0", Slot = "5")]
	public virtual Task<ANOEFAFFECF> OKOONEAGENL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public class CDICBECJBCH : LOABHNFGAAM<CDICBECJBCH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000681")]
	private MNHIEHBCOOD KAAIDPFBBBH;

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x62A1950", Offset = "0x62A0150", VA = "0x1862A1950")]
	internal CDICBECJBCH(HKHECNIPIOJ OHLNCHINAEP, JNPLDNDBBJJ LILDKJDGMDE, [Optional] Guid? BACFDICONIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x598DA10", Offset = "0x598C210", VA = "0x18598DA10")]
	public CDICBECJBCH LCCKMKICDAE(MNHIEHBCOOD KAAIDPFBBBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x62A1880", Offset = "0x62A0080", VA = "0x1862A1880", Slot = "4")]
	protected override void PIFIOGMICBE(GEAEOIJPPME BKGEBGGPBLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
public class OMMFCHHELNE : LOABHNFGAAM<OMMFCHHELNE>
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	internal enum BCFGNCFAEPH
	{
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private struct FHGEIBLMJMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public AsyncTaskMethodBuilder<ANOEFAFFECF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public OMMFCHHELNE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private TaskAwaiter<ANOEFAFFECF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x62A8910", Offset = "0x62A7110", VA = "0x1862A8910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x62A8CC0", Offset = "0x62A74C0", VA = "0x1862A8CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000682")]
	private BCFGNCFAEPH OGHHOBAOCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000683")]
	private string NJDDFJKLBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	private POCCJPPMGCN KAAIDPFBBBH;

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x62B54F0", Offset = "0x62B3CF0", VA = "0x1862B54F0")]
	internal OMMFCHHELNE(HKHECNIPIOJ OHLNCHINAEP, JNPLDNDBBJJ LILDKJDGMDE, [Optional] Guid? BACFDICONIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x62B5200", Offset = "0x62B3A00", VA = "0x1862B5200")]
	public OMMFCHHELNE FKLGJCICGBC(string DBFBABABMHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x62B5270", Offset = "0x62B3A70", VA = "0x1862B5270")]
	public OMMFCHHELNE KICGHDEIPFG(bool GMOGIFOKKFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x62B51D0", Offset = "0x62B39D0", VA = "0x1862B51D0")]
	public OMMFCHHELNE ANOGDENPAJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x62B5380", Offset = "0x62B3B80", VA = "0x1862B5380", Slot = "4")]
	protected override void PIFIOGMICBE(GEAEOIJPPME BKGEBGGPBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x62B5290", Offset = "0x62B3A90", VA = "0x1862B5290", Slot = "5")]
	[AsyncStateMachine(typeof(FHGEIBLMJMN))]
	public override Task<ANOEFAFFECF> OKOONEAGENL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x62B5230", Offset = "0x62B3A30", VA = "0x1862B5230")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<ANOEFAFFECF> JKFNJDLDAFO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000189")]
internal static class NGEKNOJJKBF
{
	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x62B36B0", Offset = "0x62B1EB0", VA = "0x1862B36B0")]
	public static void BOEGNNDLOPG(this JDBGDEDGBHG AENGMOPIGON, FAPHDJICDBI JNJOPOLCPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x62B3800", Offset = "0x62B2000", VA = "0x1862B3800")]
	public static void FPJGFEEBKGD(this FAPHDJICDBI GGBGEOFOBAL, [Optional] string BKGEBGGPBLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018A")]
public static class IFCAPBAFOPG
{
	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x62ACE20", Offset = "0x62AB620", VA = "0x1862ACE20")]
	public static FINMELMELDP IBAIJAICEHM(this ILLMGCGJCMJ GMCDBPEJHDM)
	{
		return default(FINMELMELDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x62ACD70", Offset = "0x62AB570", VA = "0x1862ACD70")]
	public static ILLMGCGJCMJ EIAAFKGMLIE(this FINMELMELDP AJEOCPOELHA)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200018C")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000691")]
			public HCNKAAALKFM ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000692")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000693")]
			public HCNKAAALKFM HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000694")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000695")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000696")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400068E")]
		private static HCNKAAALKFM[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		private Dictionary<HCNKAAALKFM, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x62B7370", Offset = "0x62B5B70", VA = "0x1862B7370")]
		public bool CMJNDEGCAKL(HCNKAAALKFM CJJOHGNOIDO, [Out] ResultConfig IKANDDIAENK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x62B73E0", Offset = "0x62B5BE0", VA = "0x1862B73E0")]
		public ResultConfig LKDILLMPLAG(HCNKAAALKFM OGMICOLLEPG, [Optional] HashSet<HCNKAAALKFM> LPDPCFJBMPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x62B7A80", Offset = "0x62B6280", VA = "0x1862B7A80", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x62B7520", Offset = "0x62B5D20", VA = "0x1862B7520", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x848550", Offset = "0x846D50", VA = "0x180848550")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
public static class KHMDFCNHMNG
{
	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x62AFD10", Offset = "0x62AE510", VA = "0x1862AFD10")]
	[NJKKEFDLCAD(AFMDLPKJFNK.GameOnly)]
	private static void OGKGNDNNKLL(LLKIHBKOOLA OBCMACCCGNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
public interface OBLPPCHKGBB : IEquatable<OBLPPCHKGBB>
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	DateTime JLEGLEMDPOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MKPCFFIEEDD();

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OHACLILMEPP(long NBNJFKJOFIF, long OMOMGBJOLII, [Out] KKLDNOOFJJJ BDCAKKAGLOE);
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
internal class DKENGHMBHJK : NLICGHANJFP
{
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[CompilerGenerated]
	private sealed class DCNNAKLICCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public GGAEDDPGPFL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public DCNNAKLICCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x62A22E0", Offset = "0x62A0AE0", VA = "0x1862A22E0")]
		internal object MOPFCHDBMDE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400069C")]
	private readonly BEPGAMFOABD CEGMJNOIDIG;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<OBLPPCHKGBB> PEHEEDKPLFI
	{
		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x62A49C0", Offset = "0x62A31C0", VA = "0x1862A49C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x62A4C50", Offset = "0x62A3450", VA = "0x1862A4C50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x768BD0", Offset = "0x7673D0", VA = "0x180768BD0")]
	[UnityEngine.Scripting.Preserve]
	public DKENGHMBHJK([KEKICHOEFEB(null)] BEPGAMFOABD CEGMJNOIDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x62A42B0", Offset = "0x62A2AB0", VA = "0x1862A42B0", Slot = "6")]
	public bool GINDFGBNLHP(long NBNJFKJOFIF, long OMOMGBJOLII, KKLDNOOFJJJ BDCAKKAGLOE, GGAEDDPGPFL FCJBDNMKKLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x17DE350", Offset = "0x17DCB50", VA = "0x1817DE350")]
	private void MPOEOIBDOIE(OBLPPCHKGBB CHBGJFKEEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x62A4140", Offset = "0x62A2940", VA = "0x1862A4140", Slot = "7")]
	public bool DNHANGOICHI(long NBNJFKJOFIF, long OMOMGBJOLII, [Out] OBLPPCHKGBB JLIKKAGDNAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x62A4A70", Offset = "0x62A3270", VA = "0x1862A4A70", Slot = "8")]
	public bool IBCLJNHOKKF(long NBNJFKJOFIF, long OMOMGBJOLII, GGAEDDPGPFL FCJBDNMKKLN, [Out] OBLPPCHKGBB JLIKKAGDNAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x62A4590", Offset = "0x62A2D90", VA = "0x1862A4590")]
	private void HBHKHPJCEHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x62A4B20", Offset = "0x62A3320", VA = "0x1862A4B20", Slot = "9")]
	public void KFALHBFDMEO(long NBNJFKJOFIF, long OMOMGBJOLII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
internal abstract class EOLAENKBHPK : BEPGAMFOABD
{
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	protected enum CHNEJHNPGFI : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x2000195")]
	[CompilerGenerated]
	private sealed class IGMKBPBLPNG : IEnumerable<OBLPPCHKGBB>, IEnumerable, IEnumerator<OBLPPCHKGBB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		private OBLPPCHKGBB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public EOLAENKBHPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		private GGAEDDPGPFL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public GGAEDDPGPFL <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		private OBLPPCHKGBB System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x86AE20", Offset = "0x869620", VA = "0x18086AE20")]
		[DebuggerHidden]
		public IGMKBPBLPNG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x62AD7E0", Offset = "0x62ABFE0", VA = "0x1862AD7E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x62ADAC0", Offset = "0x62AC2C0", VA = "0x1862ADAC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x62ADA10", Offset = "0x62AC210", VA = "0x1862ADA10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OBLPPCHKGBB> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x62ADA10", Offset = "0x62AC210", VA = "0x1862ADA10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private sealed class LOEOJDMIOPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public GGAEDDPGPFL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public LOEOJDMIOPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x62B2250", Offset = "0x62B0A50", VA = "0x1862B2250")]
		internal object CHKNDKJEKDM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private sealed class KILPDPCCDBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public EOLAENKBHPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public KILPDPCCDBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x62B01D0", Offset = "0x62AE9D0", VA = "0x1862B01D0")]
		internal void CPNHAECFEIN(JDPONNOICEO.MFJPFOBPDJE ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006A2")]
	protected readonly string OFHLKBGEDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006A3")]
	private readonly object GDPHECEDAKA;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public abstract CALEBLEHEDM LJMGCKFKFJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x62A7840", Offset = "0x62A6040", VA = "0x1862A7840")]
	protected EOLAENKBHPK([CanBeNull] string KBJMAKDICKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x62A7230", Offset = "0x62A5A30", VA = "0x1862A7230", Slot = "5")]
	public bool JADCIBNEFGI(long NBNJFKJOFIF, long OMOMGBJOLII, GGAEDDPGPFL FCJBDNMKKLN, [Out] OBLPPCHKGBB CHBGJFKEEJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x62A7420", Offset = "0x62A5C20", VA = "0x1862A7420", Slot = "6")]
	[IteratorStateMachine(typeof(IGMKBPBLPNG))]
	public IEnumerable<OBLPPCHKGBB> MJKACCHMMKK(GGAEDDPGPFL FCJBDNMKKLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void DPFBBEKGAJG(Stream ONIJPHHNEIE, long NBNJFKJOFIF, long OMOMGBJOLII, KKLDNOOFJJJ BDCAKKAGLOE);

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool FNCDLAEHJLP(Stream HNALHBFAEPD, long NBNJFKJOFIF, long OMOMGBJOLII, GEAIPIOGFGF ICAGKHLHOBM, [Out] KKLDNOOFJJJ BDCAKKAGLOE);

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x62A6EB0", Offset = "0x62A56B0", VA = "0x1862A6EB0", Slot = "7")]
	public OBLPPCHKGBB CJKCNOFLBIJ(long NBNJFKJOFIF, long OMOMGBJOLII, KKLDNOOFJJJ BDCAKKAGLOE, GGAEDDPGPFL FCJBDNMKKLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo NAOLCBMDILP(long NBNJFKJOFIF, long OMOMGBJOLII, GGAEDDPGPFL FCJBDNMKKLN, CHNEJHNPGFI NDHAJCGJKJK);

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo HMEIPLMPDEA(GGAEDDPGPFL FCJBDNMKKLN, CHNEJHNPGFI NDHAJCGJKJK);

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x62A6E40", Offset = "0x62A5640", VA = "0x1862A6E40")]
	protected void BDECMJDGEMK(JDPONNOICEO.MFJPFOBPDJE FKOIEGLDCDN, string JODJCGEJGGG, FileInfo FPHGCPFNIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x62A74B0", Offset = "0x62A5CB0", VA = "0x1862A74B0")]
	internal bool MJOCDPMPLEH(FileInfo LLHFFJIJGOK, long NBNJFKJOFIF, long OMOMGBJOLII, [Out] KKLDNOOFJJJ BDCAKKAGLOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	private void DCMBAEHBBEO(Exception LNOFJJLDMOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
internal class AEHDONPHEAP : EOLAENKBHPK
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public override CALEBLEHEDM LJMGCKFKFJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0xA4B4C0", Offset = "0xA49CC0", VA = "0x180A4B4C0", Slot = "8")]
		get
		{
			return default(CALEBLEHEDM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x629E870", Offset = "0x629D070", VA = "0x18629E870")]
	public AEHDONPHEAP([Optional] string KBJMAKDICKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x629E700", Offset = "0x629CF00", VA = "0x18629E700")]
	private void JPGGOJMJKJI(GGAEDDPGPFL FCJBDNMKKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x629DD10", Offset = "0x629C510", VA = "0x18629DD10", Slot = "9")]
	internal override void DPFBBEKGAJG(Stream ONIJPHHNEIE, long NBNJFKJOFIF, long OMOMGBJOLII, KKLDNOOFJJJ BDCAKKAGLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0x629DFA0", Offset = "0x629C7A0", VA = "0x18629DFA0", Slot = "10")]
	internal override bool FNCDLAEHJLP(Stream HNALHBFAEPD, long NBNJFKJOFIF, long OMOMGBJOLII, GEAIPIOGFGF ICAGKHLHOBM, [Out] KKLDNOOFJJJ BDCAKKAGLOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x629E780", Offset = "0x629CF80", VA = "0x18629E780", Slot = "11")]
	protected override FileInfo NAOLCBMDILP(long NBNJFKJOFIF, long OMOMGBJOLII, GGAEDDPGPFL FCJBDNMKKLN, CHNEJHNPGFI NDHAJCGJKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x629E5F0", Offset = "0x629CDF0", VA = "0x18629E5F0", Slot = "12")]
	protected override DirectoryInfo HMEIPLMPDEA(GGAEDDPGPFL FCJBDNMKKLN, CHNEJHNPGFI NDHAJCGJKJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
internal sealed class FINIAMCEDBK : EOLAENKBHPK
{
	[Cpp2IlInjected.Token(Token = "0x40006B3")]
	private static readonly byte[] OHPCNPKOLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006B4")]
	private readonly byte[] GADFGELGAHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006B5")]
	private readonly byte[] PFJILNIOICD;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public override CALEBLEHEDM LJMGCKFKFJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x52AFDF0", Offset = "0x52AE5F0", VA = "0x1852AFDF0", Slot = "8")]
		get
		{
			return default(CALEBLEHEDM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x62A9BB0", Offset = "0x62A83B0", VA = "0x1862A9BB0")]
	public FINIAMCEDBK([Optional] string KBJMAKDICKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x62A8D30", Offset = "0x62A7530", VA = "0x1862A8D30", Slot = "9")]
	internal override void DPFBBEKGAJG(Stream ONIJPHHNEIE, long NBNJFKJOFIF, long OMOMGBJOLII, KKLDNOOFJJJ BDCAKKAGLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x62A8FF0", Offset = "0x62A77F0", VA = "0x1862A8FF0", Slot = "10")]
	internal override bool FNCDLAEHJLP(Stream HNALHBFAEPD, long NBNJFKJOFIF, long OMOMGBJOLII, GEAIPIOGFGF ICAGKHLHOBM, [Out] KKLDNOOFJJJ BDCAKKAGLOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x62A9930", Offset = "0x62A8130", VA = "0x1862A9930")]
	private void JAIJHCHCHCL(byte[] MHCEKABKGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x62A99F0", Offset = "0x62A81F0", VA = "0x1862A99F0", Slot = "11")]
	protected override FileInfo NAOLCBMDILP(long NBNJFKJOFIF, long OMOMGBJOLII, GGAEDDPGPFL FCJBDNMKKLN, CHNEJHNPGFI NDHAJCGJKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x62A9820", Offset = "0x62A8020", VA = "0x1862A9820", Slot = "12")]
	protected override DirectoryInfo HMEIPLMPDEA(GGAEDDPGPFL FCJBDNMKKLN, CHNEJHNPGFI NDHAJCGJKJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
public enum CALEBLEHEDM : byte
{
	[Cpp2IlInjected.Token(Token = "0x40006B7")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40006B8")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40006B9")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
internal class MCKHMCCDBIH : BEPGAMFOABD
{
	[Cpp2IlInjected.Token(Token = "0x200019D")]
	[CompilerGenerated]
	private sealed class FOGPJFMICFO : IEnumerable<OBLPPCHKGBB>, IEnumerable, IEnumerator<OBLPPCHKGBB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		private OBLPPCHKGBB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public MCKHMCCDBIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		private GGAEDDPGPFL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public GGAEDDPGPFL <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		private CALEBLEHEDM[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		private IEnumerator<OBLPPCHKGBB> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		private OBLPPCHKGBB System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x86AE20", Offset = "0x869620", VA = "0x18086AE20")]
		[DebuggerHidden]
		public FOGPJFMICFO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x62AB410", Offset = "0x62A9C10", VA = "0x1862AB410", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x62AAFE0", Offset = "0x62A97E0", VA = "0x1862AAFE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x62AB2C0", Offset = "0x62A9AC0", VA = "0x1862AB2C0")]
		private void NINDIEOCHCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x62AB3C0", Offset = "0x62A9BC0", VA = "0x1862AB3C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x62AB310", Offset = "0x62A9B10", VA = "0x1862AB310", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OBLPPCHKGBB> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x62AB310", Offset = "0x62A9B10", VA = "0x1862AB310", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006BA")]
	private readonly CALEBLEHEDM[] MNDBNMOPLMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006BB")]
	private readonly Dictionary<CALEBLEHEDM, BEPGAMFOABD> ONLLEKKDKDM;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public CALEBLEHEDM LJMGCKFKFJA
	{
		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x62B2E20", Offset = "0x62B1620", VA = "0x1862B2E20", Slot = "4")]
		get
		{
			return default(CALEBLEHEDM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x62B2EE0", Offset = "0x62B16E0", VA = "0x1862B2EE0")]
	[UnityEngine.Scripting.Preserve]
	public MCKHMCCDBIH(params BEPGAMFOABD[] DJNJBAJBJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x62B2CD0", Offset = "0x62B14D0", VA = "0x1862B2CD0", Slot = "5")]
	public bool JADCIBNEFGI(long NBNJFKJOFIF, long OMOMGBJOLII, GGAEDDPGPFL FCJBDNMKKLN, [Out] OBLPPCHKGBB CHBGJFKEEJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x62B29D0", Offset = "0x62B11D0", VA = "0x1862B29D0")]
	private void BACELCHOADD(int HNNOMGPFOPF, long NBNJFKJOFIF, long OMOMGBJOLII, GGAEDDPGPFL FCJBDNMKKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x62B2E50", Offset = "0x62B1650", VA = "0x1862B2E50", Slot = "6")]
	[IteratorStateMachine(typeof(FOGPJFMICFO))]
	public IEnumerable<OBLPPCHKGBB> MJKACCHMMKK(GGAEDDPGPFL FCJBDNMKKLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x62B2BF0", Offset = "0x62B13F0", VA = "0x1862B2BF0", Slot = "7")]
	public OBLPPCHKGBB CJKCNOFLBIJ(long NBNJFKJOFIF, long OMOMGBJOLII, KKLDNOOFJJJ BDCAKKAGLOE, GGAEDDPGPFL FCJBDNMKKLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
internal static class IJHOLICEKDC
{
	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x62ADF20", Offset = "0x62AC720", VA = "0x1862ADF20")]
	internal static byte[] LDMJIKLOPMN(byte[] MHCEKABKGED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x62ADEA0", Offset = "0x62AC6A0", VA = "0x1862ADEA0")]
	public static void FNFGBOLFPPE(Stream NFDLBBEFMPJ, byte[] PNMBFHKBBHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x62ADFE0", Offset = "0x62AC7E0", VA = "0x1862ADFE0")]
	public static bool NLLBFMBPKDL(Stream NFDLBBEFMPJ, long MKHNGCMEBKP, GEAIPIOGFGF COAHNBJPABN, [Out] byte[] ADJDNKKCEGN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
internal sealed class IAGJFHLEKHH : OBLPPCHKGBB, IEquatable<OBLPPCHKGBB>, IEquatable<IAGJFHLEKHH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	private readonly EOLAENKBHPK BACGHKBCCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	public readonly FileInfo DANENEIPPDB;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public CALEBLEHEDM LJMGCKFKFJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x62AC670", Offset = "0x62AAE70", VA = "0x1862AC670", Slot = "9")]
		get
		{
			return default(CALEBLEHEDM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public DateTime JLEGLEMDPOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x62AC7A0", Offset = "0x62AAFA0", VA = "0x1862AC7A0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x62AC8E0", Offset = "0x62AB0E0", VA = "0x1862AC8E0")]
	public IAGJFHLEKHH(EOLAENKBHPK JPMGECHKINO, FileInfo LLHFFJIJGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x62AC830", Offset = "0x62AB030", VA = "0x1862AC830", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x62AC6A0", Offset = "0x62AAEA0", VA = "0x1862AC6A0", Slot = "5")]
	public void MKPCFFIEEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x62AC760", Offset = "0x62AAF60", VA = "0x1862AC760", Slot = "6")]
	public bool OHACLILMEPP(long NBNJFKJOFIF, long OMOMGBJOLII, [Out] KKLDNOOFJJJ BDCAKKAGLOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x62AC500", Offset = "0x62AAD00", VA = "0x1862AC500", Slot = "7")]
	public bool Equals(OBLPPCHKGBB IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x62AC350", Offset = "0x62AAB50", VA = "0x1862AC350", Slot = "8")]
	public bool Equals(IAGJFHLEKHH IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x62AC410", Offset = "0x62AAC10", VA = "0x1862AC410", Slot = "0")]
	public override bool Equals(object CBBCDNDPNHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x62AC5E0", Offset = "0x62AADE0", VA = "0x1862AC5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
public delegate void GEAIPIOGFGF(JDPONNOICEO.MFJPFOBPDJE ADBJDBHAJKM, string BKGEBGGPBLH);
[Cpp2IlInjected.Token(Token = "0x20001A1")]
internal interface BEPGAMFOABD
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	CALEBLEHEDM LJMGCKFKFJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JADCIBNEFGI(long NBNJFKJOFIF, long OMOMGBJOLII, GGAEDDPGPFL FCJBDNMKKLN, [Out] OBLPPCHKGBB CHBGJFKEEJF);

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<OBLPPCHKGBB> MJKACCHMMKK(GGAEDDPGPFL FCJBDNMKKLN);

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OBLPPCHKGBB CJKCNOFLBIJ(long NBNJFKJOFIF, long OMOMGBJOLII, KKLDNOOFJJJ BDCAKKAGLOE, GGAEDDPGPFL FCJBDNMKKLN);
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
