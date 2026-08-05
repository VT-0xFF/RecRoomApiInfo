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
using RecRoom.Logging.Attributes;
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
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87AEC0", VA = "0x18087C6C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F7CC30", Offset = "0x6F7B430", VA = "0x186F7CC30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87D9C0", Offset = "0x87C1C0", VA = "0x18087D9C0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x87DA00", Offset = "0x87C200", VA = "0x18087DA00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : MKCMLEJGADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F75AB0", Offset = "0x6F742B0", VA = "0x186F75AB0", Slot = "4")]
		public override void JGBCFAKMKJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87AEC0", VA = "0x18087C6C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MPEKIJEOIGF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BDF0", Offset = "0x6F7A5F0", VA = "0x186F7BDF0")]
	public MPEKIJEOIGF(string JNNDBFGKHHD, Exception OKPGFIEKFIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class OLKMFFNIKBJ : JBKFOMDLCHJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct EGMINFDGBLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<HNKJBJIHEKD>> <>t__builder;

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
		private TaskAwaiter<HCBEMHFAHOC<HNKJBJIHEKD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6F67FF0", Offset = "0x6F667F0", VA = "0x186F67FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F68230", Offset = "0x6F66A30", VA = "0x186F68230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct BCNMAEHPODL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<CCBKILLIDJI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<CCBKILLIDJI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F62860", Offset = "0x6F61060", VA = "0x186F62860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6F62A70", Offset = "0x6F61270", VA = "0x186F62A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	[UnityEngine.Scripting.Preserve]
	public OLKMFFNIKBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D5E0", Offset = "0x6F7BDE0", VA = "0x186F7D5E0", Slot = "4")]
	[AsyncStateMachine(typeof(EGMINFDGBLA))]
	public Task<IReadOnlyList<HNKJBJIHEKD>> ONIIPBCLFIM(long DIMOGDCMBFM, long KJMNNDODHCP, [Optional] CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D4D0", Offset = "0x6F7BCD0", VA = "0x186F7D4D0", Slot = "5")]
	[AsyncStateMachine(typeof(BCNMAEHPODL))]
	public Task<IReadOnlyList<CCBKILLIDJI>> DOJAJMGLMHI(IReadOnlyList<int> CGGPKCDCEIA, [Optional] CancellationToken MPLGBOFHPLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HCBILDDEOJN : IEquatable<HCBILDDEOJN>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int EIMMGFLJDHE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	CCBKILLIDJI NCPBHLHBGEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime KGLAKIHAMKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	COGBIDCIEPE? DGLMILFGMCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	MGMLPCEDDPE? DLOJPFEFPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	AJDCLNNIJGN KDKOLJHNILF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<DGFDNIJCPMA> HJKBNIFJLCE();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum AJDCLNNIJGN
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JBKFOMDLCHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<HNKJBJIHEKD>> ONIIPBCLFIM(long DIMOGDCMBFM, long KJMNNDODHCP, [Optional] CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<CCBKILLIDJI>> DOJAJMGLMHI(IReadOnlyList<int> CGGPKCDCEIA, [Optional] CancellationToken MPLGBOFHPLM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class FEJGLEBLKDD
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class JNNKLAGBMGO : HCBILDDEOJN, IEquatable<HCBILDDEOJN>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct ENPAGPABADO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<DGFDNIJCPMA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public JNNKLAGBMGO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private JFDEDNEDKBI <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<FLKIEPIEFEG> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<DGFDNIJCPMA> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6F69260", Offset = "0x6F67A60", VA = "0x186F69260", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6F69700", Offset = "0x6F67F00", VA = "0x186F69700", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly HNKJBJIHEKD HAFLHBJODHD;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int EIMMGFLJDHE
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x85FD10", Offset = "0x85E510", VA = "0x18085FD10", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public CCBKILLIDJI NCPBHLHBGEL
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8510A0", VA = "0x1808528A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime DCKEHFJHKEG
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x5B05A70", Offset = "0x5B04270", VA = "0x185B05A70", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public COGBIDCIEPE? DGLMILFGMCA
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1C13D00", Offset = "0x1C12500", VA = "0x181C13D00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public MGMLPCEDDPE? DLOJPFEFPEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5B05B50", Offset = "0x5B04350", VA = "0x185B05B50", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public AJDCLNNIJGN KDKOLJHNILF
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8C3EC0", Offset = "0x8C26C0", VA = "0x1808C3EC0", Slot = "10")]
			get
			{
				return default(AJDCLNNIJGN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6F718D0", Offset = "0x6F700D0", VA = "0x186F718D0", Slot = "9")]
		[AsyncStateMachine(typeof(ENPAGPABADO))]
		public Task<DGFDNIJCPMA> HJKBNIFJLCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6F71A10", Offset = "0x6F70210", VA = "0x186F71A10")]
		public JNNKLAGBMGO(int AEJFNKCGKJL, CCBKILLIDJI GKPLKHNIAAM, HNKJBJIHEKD HAFLHBJODHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6F717C0", Offset = "0x6F6FFC0", VA = "0x186F717C0", Slot = "11")]
		public bool Equals(HCBILDDEOJN OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6F71720", Offset = "0x6F6FF20", VA = "0x186F71720", Slot = "0")]
		public override bool Equals(object MEAFIMADMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6F719D0", Offset = "0x6F701D0", VA = "0x186F719D0")]
		private bool NHAJPMJLCKB(JNNKLAGBMGO OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6F71850", Offset = "0x6F70050", VA = "0x186F71850", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class KAMPFFDNOIJ : HCBILDDEOJN, IEquatable<HCBILDDEOJN>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct DFKFCDNLHDB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<DGFDNIJCPMA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public KAMPFFDNOIJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<DGFDNIJCPMA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6F663A0", Offset = "0x6F64BA0", VA = "0x186F663A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6F665D0", Offset = "0x6F64DD0", VA = "0x186F665D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly NCKGPLMHNNB NGNNMIEGNHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly COGBIDCIEPE NFAOODAHDOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly MGMLPCEDDPE JHDKCODGOEA;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int EIMMGFLJDHE
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6F725D0", Offset = "0x6F70DD0", VA = "0x186F725D0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public CCBKILLIDJI NCPBHLHBGEL
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6F729D0", Offset = "0x6F711D0", VA = "0x186F729D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime DCKEHFJHKEG
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6F728D0", Offset = "0x6F710D0", VA = "0x186F728D0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public COGBIDCIEPE? DGLMILFGMCA
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6F72980", Offset = "0x6F71180", VA = "0x186F72980", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public MGMLPCEDDPE? DLOJPFEFPEE
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6F72A60", Offset = "0x6F71260", VA = "0x186F72A60", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public AJDCLNNIJGN KDKOLJHNILF
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8CA1D0", Offset = "0x8C89D0", VA = "0x1808CA1D0", Slot = "10")]
			get
			{
				return default(AJDCLNNIJGN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x10DD5D0", Offset = "0x10DBDD0", VA = "0x1810DD5D0")]
		public KAMPFFDNOIJ(NCKGPLMHNNB NHABHPPMDON, COGBIDCIEPE LMDAHADOCMG, MGMLPCEDDPE AFEBLMEGKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6F727E0", Offset = "0x6F70FE0", VA = "0x186F727E0", Slot = "9")]
		[AsyncStateMachine(typeof(DFKFCDNLHDB))]
		public Task<DGFDNIJCPMA> HJKBNIFJLCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6F72610", Offset = "0x6F70E10", VA = "0x186F72610", Slot = "11")]
		public bool Equals(HCBILDDEOJN OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6F726B0", Offset = "0x6F70EB0", VA = "0x186F726B0", Slot = "0")]
		public override bool Equals(object MEAFIMADMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6F72920", Offset = "0x6F71120", VA = "0x186F72920")]
		private bool NHAJPMJLCKB(KAMPFFDNOIJ OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6F72760", Offset = "0x6F70F60", VA = "0x186F72760", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class OGPPILHBAGM : HCBILDDEOJN, IEquatable<HCBILDDEOJN>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct CIFHBDIJGDN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<DGFDNIJCPMA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<DGFDNIJCPMA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6F642A0", Offset = "0x6F62AA0", VA = "0x186F642A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6F644E0", Offset = "0x6F62CE0", VA = "0x186F644E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CCBKILLIDJI AEKIDCIFIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly COGBIDCIEPE NFAOODAHDOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly MGMLPCEDDPE JHDKCODGOEA;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int EIMMGFLJDHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6F7CFA0", Offset = "0x6F7B7A0", VA = "0x186F7CFA0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public CCBKILLIDJI NCPBHLHBGEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851900", VA = "0x180853100", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime DCKEHFJHKEG
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852AA0", VA = "0x1808542A0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public COGBIDCIEPE? DGLMILFGMCA
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6F7D430", Offset = "0x6F7BC30", VA = "0x186F7D430", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public MGMLPCEDDPE? DLOJPFEFPEE
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6F7D480", Offset = "0x6F7BC80", VA = "0x186F7D480", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public AJDCLNNIJGN KDKOLJHNILF
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852AA0", VA = "0x1808542A0", Slot = "10")]
			get
			{
				return default(AJDCLNNIJGN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x10DD5D0", Offset = "0x10DBDD0", VA = "0x1810DD5D0")]
		public OGPPILHBAGM(CCBKILLIDJI GKPLKHNIAAM, COGBIDCIEPE LMDAHADOCMG, MGMLPCEDDPE AFEBLMEGKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D280", Offset = "0x6F7BA80", VA = "0x186F7D280", Slot = "9")]
		[AsyncStateMachine(typeof(CIFHBDIJGDN))]
		public Task<DGFDNIJCPMA> HJKBNIFJLCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D0E0", Offset = "0x6F7B8E0", VA = "0x186F7D0E0", Slot = "11")]
		public bool Equals(HCBILDDEOJN OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6F7CFC0", Offset = "0x6F7B7C0", VA = "0x186F7CFC0", Slot = "0")]
		public override bool Equals(object MEAFIMADMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D1F0", Offset = "0x6F7B9F0", VA = "0x186F7D1F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D350", Offset = "0x6F7BB50", VA = "0x186F7D350")]
		private bool NHAJPMJLCKB(OGPPILHBAGM OKGBBGMIACH)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct JJDJOJDEFBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<HCBILDDEOJN>> <>t__builder;

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
		public FEJGLEBLKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<HNKJBJIHEKD> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<HNKJBJIHEKD>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, CCBKILLIDJI account, HNKJBJIHEKD roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6F707D0", Offset = "0x6F6EFD0", VA = "0x186F707D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6F715B0", Offset = "0x6F6FDB0", VA = "0x186F715B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct KIFENGKCAKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, CCBKILLIDJI account, HNKJBJIHEKD roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<HNKJBJIHEKD> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public FEJGLEBLKDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<CCBKILLIDJI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6F748B0", Offset = "0x6F730B0", VA = "0x186F748B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6F75290", Offset = "0x6F73A90", VA = "0x186F75290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly GNGNHODIFED FLDFAFKKDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly JBKFOMDLCHJ LMGKHFMLMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly APCMDALIFAP CDKBBCDFGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly LKJHFGDNFFP<(long, long), IReadOnlyList<HNKJBJIHEKD>> PPIGNHBAKHP;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6F69B70", Offset = "0x6F68370", VA = "0x186F69B70")]
	[UnityEngine.Scripting.Preserve]
	public FEJGLEBLKDD([OMAPKKAGFIL(null)] JBKFOMDLCHJ JCGADIJBGCL, [OMAPKKAGFIL(null)] APCMDALIFAP GCIHBOGNOCG, [OMAPKKAGFIL(null)] GNGNHODIFED BADCNKLHNGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6F69A20", Offset = "0x6F68220", VA = "0x186F69A20")]
	[AsyncStateMachine(typeof(JJDJOJDEFBB))]
	public Task<IList<HCBILDDEOJN>> PMIGKKKHMEG(long DIMOGDCMBFM, long MMMJFAODPOA, bool LBHNFPLLPPA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6F69770", Offset = "0x6F67F70", VA = "0x186F69770")]
	private bool DAACIBEADMJ(DateTime? KNOJCNGFFGF, long DIMOGDCMBFM, long MMMJFAODPOA, [Out] NCKGPLMHNNB HEEEABJCCCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6F69910", Offset = "0x6F68110", VA = "0x186F69910")]
	[AsyncStateMachine(typeof(KIFENGKCAKA))]
	private Task<IReadOnlyList<(int, CCBKILLIDJI, HNKJBJIHEKD)>> JIICFBNLNGF(IReadOnlyList<HNKJBJIHEKD> OEELLFIALDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface APCMDALIFAP
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<NCKGPLMHNNB> FIPANKDGOFE;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BGOHNIEEPOG(long DIMOGDCMBFM, long MMMJFAODPOA, JBBKCFOEFFA HLJMJFBMCDD, HCEEFOPOCMM LKIPKDFOIKO);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AMEPMODJGEG(long DIMOGDCMBFM, long MMMJFAODPOA, [Out] NCKGPLMHNNB HEEEABJCCCA);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HNIMFMKAJPB(long DIMOGDCMBFM, long MMMJFAODPOA, HCEEFOPOCMM LKIPKDFOIKO, [Out] NCKGPLMHNNB HEEEABJCCCA);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IHHNIIDNNKG(long DIMOGDCMBFM, long MMMJFAODPOA);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface GAGJCKDHAGD : DLOEDDKPHPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool DKMCCHAMJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task NIIJPKMNAEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ODPNHFDHCHP(Task LEDCCMOCHJB, string NAFEJNMBGDG);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface EMPCKPBJDBG : DLOEDDKPHPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DGFDNIJCPMA> JFAEBIMIGEM(NCKGPLMHNNB HEEEABJCCCA);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LCOGCHLMALM(CancellationToken MPLGBOFHPLM);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface DKMKDMJDKAD : DLOEDDKPHPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	AGBLOFNHMNJ CGDMKGIJFNC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IMDJDHEEMJK();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FNLBOAJMEAK();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface DLOEDDKPHPI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface KJHGHIOALEA
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan POPLOMEELGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan EILAOPAHMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan FFOMFNFAGFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan MFJMGLGDJLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool HIEMGKLEMPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool DHJHHPNONME
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool PDNJFNGKLAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int HBEFNCBJLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool GMPLDANEBAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool JLAHKDIJKKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool FABNOODIDDM
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum EMDPEFDABNM
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum EFBCINIABEJ
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
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct BIDJCBPPELH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long LBHHCOPBEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long KJMNNDODHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly EMDPEFDABNM NCMHJNKFAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception NFPCHIICMPD;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6F62B30", Offset = "0x6F61330", VA = "0x186F62B30")]
	public BIDJCBPPELH(long LBHHCOPBEOO, long KJMNNDODHCP, EMDPEFDABNM NCMHJNKFAGH, [CanBeNull] Exception NFPCHIICMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6F62AE0", Offset = "0x6F612E0", VA = "0x186F62AE0")]
	public static BIDJCBPPELH AIJAFPFEFCM(MDBDBMHCDOA DJKOBHKEIHL, EMDPEFDABNM NCMHJNKFAGH, [Optional] Exception NFPCHIICMPD)
	{
		return default(BIDJCBPPELH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public delegate void OMLCDPLNPMG(BIDJCBPPELH NMJHAGKCPPO);
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface MDIOJHKPIFM : DLOEDDKPHPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action FBNNGEHPFJP;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event OMLCDPLNPMG DAKEBEBHJID;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event OMLCDPLNPMG JINMNOEEMPB;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event OMLCDPLNPMG LLPKHLEBIFH;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<EFBCINIABEJ, bool> FDJJFJNOJEM;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GJOPDEMKKAE();

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IGKNNADFBCJ(BIDJCBPPELH NMJHAGKCPPO);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CBIKINJHPHE(BIDJCBPPELH NMJHAGKCPPO);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GCEEECEEPGL(BIDJCBPPELH NMJHAGKCPPO);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void APBMNJALIEG(EFBCINIABEJ LJJJHDHDDOO, bool NPCJOOKKGED);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface CDPDCOBHLKK : DLOEDDKPHPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NMANLOAKGED();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CNOADOMBMCE();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface FFDBLCGPPMM : DLOEDDKPHPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	TaskStatus GBIGLBPMJGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task IADAOMLEGLE(MDBDBMHCDOA OLIIPNAKLLA, PHMFOBHEKIK LHBIIPLLKKE, CancellationToken LJPECIOGMKH);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class JPPJBCFDDGC
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6F72580", Offset = "0x6F70D80", VA = "0x186F72580")]
	public static bool MLOIKDCIPFP(this FFDBLCGPPMM MCGBLNMHNKO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public delegate Task HPIMEFGKLNK(CancellationToken EOCJCEFCOOA, int IDCPOPPPDDB, JLMLCKPCLMI ONEPKIAFHHL);
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface GPMIBIFCKBJ : DLOEDDKPHPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CELLIGGGPOC(HPIMEFGKLNK JABMPBLAEKI);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface PNHFEHLPHMO : JFDEDNEDKBI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	CancellationToken HDNPIHLFMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	INCIOHANCNE HDLDKNAIPCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	ILFDHJAHNHI HIAEFCJGPMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	DEBFMJKLBDN DJEMJGOJCKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	MFEINKDLEHJ KFKHEOKCKBP
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	INNHEOLIKBM MDBMBBPHIBI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NBAHHDNKILP GCINGEDLGMH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	OMKEILKNJFC OHKEMMFEOLB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	BOAMHEKDIOK DNKBABKCKEM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	GAGJCKDHAGD GDMOGGJEDBM
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	EMPCKPBJDBG DNFGAGHGFEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	MDIOJHKPIFM AEFEHKNIGLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	CDPDCOBHLKK FIIGPOBAGDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	FFDBLCGPPMM KPMOHDGEAPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	GPMIBIFCKBJ CMHDFDJFCNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	DHPDBLFEFKM BNNHJAOKOAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	KIJJEBJPOIH OJKPJCDHHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	LNJOHEOEPEC AFNPDMELIEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	CCOBBDFLOFB CJLEAOJJGCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	OELPCMIPAIF CCBDHCDOJDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	GNGDMGCCAPD GKFMPEHDLNL
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	GDNPJMDDBLG OKFDHBKKLPB
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	FGAHPIAHGMI CPPADNKEGPA
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	HMHGPPDLHFG KAMMGKKGEJM
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	GNDHGGJAABG ODOJHIPFPFN
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	DKMKDMJDKAD IBOABCLKAIG
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	KJHGHIOALEA DDNLDNHMOKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	GGIIPLFNMOA DGIEGKOIAJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	APCMDALIFAP AEHDIMKFCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	KKNNHLMFANP EIGIGOMEGDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	GDBDKOPOCLO IELHIFNAECG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	FJDMGDBCEIP LGPBJMPPCFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void HMEDGBMBGNA(PHMFOBHEKIK HGAMIEAIIIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface DHPDBLFEFKM : DLOEDDKPHPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ILGKIPAKNNM PBLNBBGFGAP(Guid KPMGFINBLBG);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MFKDEBIIBOM(Guid KPMGFINBLBG);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ILAGFIPHBII(Guid KPMGFINBLBG, Task FPNFJMOCKDJ);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GBCDJOMOKCI(Guid KPMGFINBLBG, DGFDNIJCPMA FHJGDBNGPJP);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(DGFDNIJCPMA, Task)> BDAIDICDCAJ(Guid KPMGFINBLBG);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface IENMFFFGEPA : DLOEDDKPHPI, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface KIJJEBJPOIH : DLOEDDKPHPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NMIDACFLKHF(JHHNPEBPLNM JNNDBFGKHHD);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DCAJFCLMDMN(JHHNPEBPLNM JNNDBFGKHHD);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<KPFIKNDEFFO> HEDPEEEGPBI(CancellationToken JHPDMDBBGOI);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface LNJOHEOEPEC : DLOEDDKPHPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ILGKIPAKNNM GIOEHONMECA(JHHNPEBPLNM MJJIPHKHOEB);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GLALEPFIHIM(Guid KPMGFINBLBG, Task FPNFJMOCKDJ);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface CCOBBDFLOFB : DLOEDDKPHPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DGFDNIJCPMA> CJLEAOJJGCB(JHHNPEBPLNM PIHNIIFANNM);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface OELPCMIPAIF : DLOEDDKPHPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JBBIANFGILF> HEIELJDJGCB(OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, MDBDBMHCDOA OLIIPNAKLLA, CancellationToken MPLGBOFHPLM);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface GDNPJMDDBLG : DLOEDDKPHPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DGFDNIJCPMA DJPMKICBDLN(LCMANADAOPN KNKLAKPFAOI);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CEOGFJOOFNG(string BECGFNBELMK);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface GNGDMGCCAPD : DLOEDDKPHPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JHHNPEBPLNM> ELIGHDCDHPD(JHHNPEBPLNM GPCNCGBOPJG, NOCKKKPBJAK EECJCJLHLIP, CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<JHHNPEBPLNM> NEJJKEMHNPK(CancellationToken MPLGBOFHPLM, NOCKKKPBJAK EECJCJLHLIP);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AOOKNBGCDKI GCAGPDDCIGD(LDOGEOGHOLH JLCNMJIDAOM, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AOOKNBGCDKI BLGCCGBNIDG(LDOGEOGHOLH JLCNMJIDAOM, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface FGAHPIAHGMI : DLOEDDKPHPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DGFDNIJCPMA MBKKPDMNLNB(LCMANADAOPN KNKLAKPFAOI, KPFIKNDEFFO OFNDKLGKJDP);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DGFDNIJCPMA IKOPFOCCMFH(LCMANADAOPN NACPIIAAOMP);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface HMHGPPDLHFG
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEIGOIECKLJ(LOEOIDGPKKK GPHHOLMHNPG);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PKJNLOKJFLA(LOEOIDGPKKK GPHHOLMHNPG);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FDIIAFKDEHO(LOEOIDGPKKK GPHHOLMHNPG);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KFKIMHEEPAI(LOEOIDGPKKK GPHHOLMHNPG);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class LOEOIDGPKKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly MDBDBMHCDOA GIOPCPEPAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> LFGJJFNMFKM;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public OADONCMLPJG<string> JBFLLCIBMLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8510A0", VA = "0x1808528A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x852870", Offset = "0x851070", VA = "0x180852870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x8519E0", VA = "0x1808531E0")]
	public LOEOIDGPKKK(MDBDBMHCDOA AKLKCJCNCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6F75950", Offset = "0x6F74150", VA = "0x186F75950")]
	public LOEOIDGPKKK AGIBFGMAADE(string NDDCLPHCEEO, string JMDCGOKJIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6F75A20", Offset = "0x6F74220", VA = "0x186F75A20")]
	public bool OCMIHLIDOHH([Out] IEnumerable<KeyValuePair<string, string>> NIPKJPFADEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x61D8FC0", Offset = "0x61D77C0", VA = "0x1861D8FC0")]
	public LOEOIDGPKKK GEKBMFJGKNP(OADONCMLPJG<string> GFNLGFOFJFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface GGIIPLFNMOA
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool EEEIGPEEAFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	string LDKGNECMADH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool NADHJCEMKHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PCALHEPDJHK();

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PJOHEDNALLN GCDKLDMNACH(long LMGCMDBJBOB);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AJPKAMNMEFA<KEOGFOOKLEH, JPOIDFBEIEP> DOAMOMEBKAF(long LMGCMDBJBOB);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AJPKAMNMEFA<KEOGFOOKLEH, CKJAAMAMPKA> LLDBHOMHADC(long LMGCMDBJBOB);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AJPKAMNMEFA<long, LPCEBBBOKPM> JEGEKEHEPKM();

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LLOELFEMBJO(long LMGCMDBJBOB, [Out] bool HGNGLHCBFFF);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> OGAAMPKGOLH(byte[] BIOFMAGLAJN, byte[] PNMECAEFMNK, CancellationToken MPLGBOFHPLM);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface JFDEDNEDKBI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool MLOIKDCIPFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool HIFLENFBBBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	PHMFOBHEKIK FAFJDJJEHAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action FBNNGEHPFJP;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event OMLCDPLNPMG DAKEBEBHJID;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event OMLCDPLNPMG JINMNOEEMPB;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event OMLCDPLNPMG LLPKHLEBIFH;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<EFBCINIABEJ, bool> FDJJFJNOJEM;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CNOADOMBMCE();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	JNAKBMBBKNN IPPANBBAFNL();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	PKDPFMCHDKO PCCMMKDEEOK();

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<DGFDNIJCPMA> JFAEBIMIGEM(NCKGPLMHNNB NHABHPPMDON);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task LCOGCHLMALM(CancellationToken MPLGBOFHPLM);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface INNHEOLIKBM
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool GCIKIJGEKFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	string JHGHKCPEHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DBDIIBPKNCD(Scene LAFLPMGONPA);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task PHCDEBFPBHD(NPKNNMIHNCN BBOLLCFICFM, CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task PCAJFBOFBEI();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task GCOMEFGGEKD();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface MFEINKDLEHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	FFAMIDMIBLK HFPCNNCNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool OIACCGFHMIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool KAHJDKKOLIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool HOEHOFPBHCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool FDPEGABPHFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	int FEKAAEMNJIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool GNEHDOJFEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool CFABDLCABFE
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	byte CCBEMFADLFE
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	byte HDJCHEKNDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool ONLEHMBACCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool BBEKCOFABED
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool OBPAOPCHOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	float GEEFLPFBKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> DIIMJFOIJPN;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	INCIOHANCNE AADCMKCAFBF(INCIOHANCNE OOEKFBLDDAA);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ONJFDIEDDHE(INCIOHANCNE PGHIDIKDPNB);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GLAMKPDKFLB();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task KGDIMLFIDJK(OADONCMLPJG<string>.HILOONJJDHL ABOFEKKDBHO, CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JIMGGHFIBLD(float BLKMGGOFGAD);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KIIPMDCKFJI(string ODFKELNLEML);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<FFCFLPKEGBI> EBCMNOKFAHK();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable OIAJKMFPAFJ(object CNBJCJOALNK, FFCFLPKEGBI DAKLDBBBMLH);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<AIDMEJBIGGB> CCJICCPNMHM();

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	JPOIDFBEIEP KKIMAJADFNF(IEnumerable<CLPMHIGOAIJ> ILCIEJIEOFI);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IFPMMEJAEDD(int DMNHBMODOKL);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task AKMOLJFPAFH();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void NMMDKFHFNMM();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool IOIPMPKKEHO();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task PBEAGIGBPOC(CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task LACAHCCAMNJ(CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<IHBHHHHIAHA> FIDPNGBAADE(DateTime LMOBKEPKEIO, CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> AJFLMAHKFEO(CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void PMAMGPFDAMB(string JNNDBFGKHHD = "", float HIEBMCLPBGB = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "25")]
	EJPPCDFMGAB KLLOFGGAGIB(LEBMOIGALED NNEJNOJGJGB, INAMFDDJCJB MEGACNKHFJL, CKJAAMAMPKA GFOADFAGJGL, IEnumerable<PersistenceView> LALNNECKACD, KLAHAGABJNO AAPBDGLHGOD);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void AEBOLMJONND(CKJAAMAMPKA GFOADFAGJGL);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void KPHCIFOLCHL(CLPMHIGOAIJ OOCANEMEHMO, [In] EJPPCDFMGAB NNIAKJBMFAH);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task FACDGKCFEAF(CKJAAMAMPKA DFEILOOLDPK, bool FGOIIGNLDGH, CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task AEJKGCJDEBG(CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void OJLDDPGHNHF(long DIMOGDCMBFM, long KJMNNDODHCP, FLKIEPIEFEG ECCIBCDNFPF, HNKJBJIHEKD AECCPEOLNJH, JBBKCFOEFFA HLJMJFBMCDD, KAIMFMKFBCK? BJEDAIHNLGI, JJNDGMFMLEH? ADMCGJGIPAE);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void IBMFBPFMKOM(long DIMOGDCMBFM, long KJMNNDODHCP, JJNDGMFMLEH? ADMCGJGIPAE);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void FBAAICKHAFL(PersistenceView KKGCEMLHADC);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool AEMKNGANMEC(PersistenceView HLFKKKOLNPG);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool HAAOIFNGIBJ(CLPMHIGOAIJ OOCANEMEHMO, CCFJLIPPODM EIBPJCOMOGE, [Out] NCKGFONBDGH GKFJAOOBFHD);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task HFFCFMGDHEM(CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void OEAPKJGADNL();

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable CPIOLAOHFLO();

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void DEBECCJJEFM(CKJAAMAMPKA DFEILOOLDPK, CCFJLIPPODM EIBPJCOMOGE);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<bool> NPDEGNDKDHH(ILFDHJAHNHI FAELELHBKKO, CancellationToken MPLGBOFHPLM, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void BGMHHIMGKKI(CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<BMBMOGELPMJ> NMLJKFHNHOC(LDMDHGPFODD GPCNCGBOPJG);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<FLKIEPIEFEG> NHHODJJHGPD(long DIMOGDCMBFM, bool JNLHLHAGLFN, CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<HNKJBJIHEKD> JMOCIDDFIPO(long DIMOGDCMBFM, long KJMNNDODHCP, long JFKPBGIIONL, CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<HNKJBJIHEKD> GJDCKPJJPAM(long DIMOGDCMBFM, long KJMNNDODHCP, CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<LLEPICGCMEA> BDPBPEFFPNE(string CNCIKMOKNCG, CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<LLEPICGCMEA> HNMGCCENHPL(string CNCIKMOKNCG, long DIMOGDCMBFM, long KJMNNDODHCP, string EEPCKBDHEGC, KDDDDHELEIK.OFPJCAGGINJ FCMADEBOIJK, KDDDDHELEIK.OFPJCAGGINJ PNMECAEFMNK, int HDFLMOLOCCD);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool BDHFIKJJOAD();

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "49")]
	bool NHIHEPMPGEA();

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool NJKHCJBMMIG(IEnumerable<NCKGFONBDGH> ILNNAGMPKHP);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void CIIHKADMBEP(List<GameObject> KBBEEPPCANP);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "52")]
	float NLKDJIJBIAJ();

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "53")]
	Task<Scene> JLCDFILIOPA(string OAAJEIOFMBJ, LoadSceneMode DDIGHDALBPK, bool DNHNFCFHHHN, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void MGKMNEHAJBD();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void GBOPJINFEFP(bool CKPMODOEIJG);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void LMHCPPFHFMG();

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void NDNAIOFGFGE();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void DGIBHJOJINE(MDBDBMHCDOA ODGJFBJGOFN);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Task PAAGKABCCEN(OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "69")]
	Task LPFJPJMDCEB(OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "70")]
	Task HCIFMEBEAIF(OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "71")]
	Task BBBIOGBGOGA(OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "72")]
	IDisposable HIDMPOPILCG();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "73")]
	IGNOJPABBPI CIBDIHKLIAG();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task AMLJJEGBCNF(CancellationToken MPLGBOFHPLM);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface IGNOJPABBPI
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task GEKGICPHEIJ(CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HLCBANIENAE(CancellationToken MPLGBOFHPLM);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct EJPPCDFMGAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> ELBCDHDGBBL;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum IHBHHHHIAHA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct LEBMOIGALED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string CECLABBIDNN;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface FFAMIDMIBLK
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	MDBDBMHCDOA BDKFDNIDKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	FLKIEPIEFEG NMFKMAELONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	HCDOMJKEJGM NDLEIHLCCDI
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool CFDDJCLAHPD
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool KLEGFNFNEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	int HGKOKFJLFPG
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action NAOMOMFBMJP;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> HKMIFPBLENP;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EFEIDHHNCJE();

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.HMGBEKBDAJP> FMLAHBCEJDN(long LMGCMDBJBOB, [Optional] CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<OEFODOPOJHO> NPHFMEHGOJN();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task DLLENOGMCHP();

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(MDBDBMHCDOA, PHMFOBHEKIK) IMFLFNEHEHE();

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "15")]
	PEJDDGDCLFF MBJPMOIKNLI();

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void ECKAKIBDOCH(long LMGCMDBJBOB);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface GNDHGGJAABG
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BJIBDPOKENM([Out] IEnumerable<int> MMJGMIMIELL);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LLMCDDNILFE(NKPKPHIMNEI EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KLBDEBKMANE(NKPKPHIMNEI EOCJCEFCOOA);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface BKPEKJBMGIP
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string PGHKILOGFDP(DGFDNIJCPMA OMMIFMPIFCF);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface ABNHEGMNLPH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ICOAKFCEEGG(LLOFDCKBGNA.PHLOHJMEDAC MALFIDMAHOP);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GCDCOOGHCJC(LLOFDCKBGNA.PHLOHJMEDAC MALFIDMAHOP);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface NBAHHDNKILP : ABNHEGMNLPH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DGFDNIJCPMA AAHGJHLKCBO(LCMANADAOPN NACPIIAAOMP);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface OMKEILKNJFC : ABNHEGMNLPH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DGFDNIJCPMA DJPMKICBDLN(LCMANADAOPN GFABMNOLKLL);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface PJOHEDNALLN
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CIKECDEKJAI<NPKNNMIHNCN, EGADAFAJMEN>> ECFCFNJAJPC(string EEPCKBDHEGC, long LMGCMDBJBOB, long? DIMOGDCMBFM, long? KJMNNDODHCP, KGKIJLNHCBD.GNBOAEIMAME KANAHIPJEKP, CancellationToken MPLGBOFHPLM);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface AJPKAMNMEFA<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CIKECDEKJAI<MOGOEHIGGGP<TData>, EGADAFAJMEN>> KJCHEJEPAGN(TGetDataArg BGLHKLFFJEP, CancellationToken MPLGBOFHPLM);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class EHPKEGPHHAK : PNHFEHLPHMO, JFDEDNEDKBI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct OGMIPAJCCGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder<DGFDNIJCPMA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public EHPKEGPHHAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public NCKGPLMHNNB autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<DGFDNIJCPMA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x6F7CCB0", Offset = "0x6F7B4B0", VA = "0x186F7CCB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x6F7CF30", Offset = "0x6F7B730", VA = "0x186F7CF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct BMPFNLMDBGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public EHPKEGPHHAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x6F64010", Offset = "0x6F62810", VA = "0x186F64010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x6F64240", Offset = "0x6F62A40", VA = "0x186F64240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class NDJELHOCNHH : IEnumerable<DLOEDDKPHPI>, IEnumerable, IEnumerator<DLOEDDKPHPI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private DLOEDDKPHPI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public EHPKEGPHHAK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		private DLOEDDKPHPI System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x89FD00", Offset = "0x89E500", VA = "0x18089FD00")]
		[DebuggerHidden]
		public NDJELHOCNHH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6F7BE60", Offset = "0x6F7A660", VA = "0x186F7BE60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C2C0", Offset = "0x6F7AAC0", VA = "0x186F7C2C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C210", Offset = "0x6F7AA10", VA = "0x186F7C210", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DLOEDDKPHPI> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C210", Offset = "0x6F7AA10", VA = "0x186F7C210", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource PDODAFANCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly INCIOHANCNE PGHIDIKDPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool LOOMHHLOKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private IOJCCAEBDFA ONNLNELFHAA;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public ILFDHJAHNHI HIAEFCJGPMA
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8569D0", Offset = "0x8551D0", VA = "0x1808569D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855180", VA = "0x180856980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public DEBFMJKLBDN DJEMJGOJCKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x856300", Offset = "0x854B00", VA = "0x180856300", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8562F0", Offset = "0x854AF0", VA = "0x1808562F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public MFEINKDLEHJ KFKHEOKCKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x856340", Offset = "0x854B40", VA = "0x180856340", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x856330", Offset = "0x854B30", VA = "0x180856330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public INNHEOLIKBM MDBMBBPHIBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x856320", Offset = "0x854B20", VA = "0x180856320", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x856310", Offset = "0x854B10", VA = "0x180856310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public NBAHHDNKILP GCINGEDLGMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x856A90", Offset = "0x855290", VA = "0x180856A90", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x856B60", Offset = "0x855360", VA = "0x180856B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public OMKEILKNJFC OHKEMMFEOLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x856BA0", Offset = "0x8553A0", VA = "0x180856BA0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x856BD0", Offset = "0x8553D0", VA = "0x180856BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public BOAMHEKDIOK DNKBABKCKEM
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x85FD30", Offset = "0x85E530", VA = "0x18085FD30", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x85FD60", Offset = "0x85E560", VA = "0x18085FD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public GAGJCKDHAGD GDMOGGJEDBM
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x85FE60", Offset = "0x85E660", VA = "0x18085FE60", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x85FE80", Offset = "0x85E680", VA = "0x18085FE80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public EMPCKPBJDBG DNFGAGHGFEP
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x85FE70", Offset = "0x85E670", VA = "0x18085FE70", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x85FEB0", Offset = "0x85E6B0", VA = "0x18085FEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public MDIOJHKPIFM AEFEHKNIGLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9C0350", Offset = "0x9BEB50", VA = "0x1809C0350", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9EE3B0", Offset = "0x9ECBB0", VA = "0x1809EE3B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public CDPDCOBHLKK FIIGPOBAGDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x85FDF0", Offset = "0x85E5F0", VA = "0x18085FDF0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x85FD70", Offset = "0x85E570", VA = "0x18085FD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public FFDBLCGPPMM KPMOHDGEAPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9E66A0", Offset = "0x9E4EA0", VA = "0x1809E66A0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9C5320", Offset = "0x9C3B20", VA = "0x1809C5320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public GPMIBIFCKBJ CMHDFDJFCNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x85DEA0", Offset = "0x85C6A0", VA = "0x18085DEA0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x85DEE0", Offset = "0x85C6E0", VA = "0x18085DEE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public DHPDBLFEFKM BNNHJAOKOAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xB8BBA0", Offset = "0xB8A3A0", VA = "0x180B8BBA0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xB93B60", Offset = "0xB92360", VA = "0x180B93B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public IENMFFFGEPA MPEIAOIBKNK
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x947DD0", Offset = "0x9465D0", VA = "0x180947DD0", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x93DBD0", Offset = "0x93C3D0", VA = "0x18093DBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public KIJJEBJPOIH OJKPJCDHHDP
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x9475A0", Offset = "0x945DA0", VA = "0x1809475A0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x948B10", Offset = "0x947310", VA = "0x180948B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public LNJOHEOEPEC AFNPDMELIEH
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8BD870", Offset = "0x8BC070", VA = "0x1808BD870", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xB93BA0", Offset = "0xB923A0", VA = "0x180B93BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public CCOBBDFLOFB CJLEAOJJGCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8BF2F0", Offset = "0x8BDAF0", VA = "0x1808BF2F0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA22490", Offset = "0xA20C90", VA = "0x180A22490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public OELPCMIPAIF CCBDHCDOJDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x85DED0", Offset = "0x85C6D0", VA = "0x18085DED0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x85DE80", Offset = "0x85C680", VA = "0x18085DE80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public GNGDMGCCAPD GKFMPEHDLNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4F0", Offset = "0x8B9CF0", VA = "0x1808BB4F0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9C48D0", Offset = "0x9C30D0", VA = "0x1809C48D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public GDNPJMDDBLG OKFDHBKKLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA47F20", Offset = "0xA46720", VA = "0x180A47F20", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA47F40", Offset = "0xA46740", VA = "0x180A47F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public FGAHPIAHGMI CPPADNKEGPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8BF310", Offset = "0x8BDB10", VA = "0x1808BF310", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xB93B80", Offset = "0xB92380", VA = "0x180B93B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public HMHGPPDLHFG KAMMGKKGEJM
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8BF320", Offset = "0x8BDB20", VA = "0x1808BF320", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9C38F0", Offset = "0x9C20F0", VA = "0x1809C38F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public GNDHGGJAABG ODOJHIPFPFN
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8BF270", Offset = "0x8BDA70", VA = "0x1808BF270", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xB93B40", Offset = "0xB92340", VA = "0x180B93B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public DKMKDMJDKAD IBOABCLKAIG
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF280", Offset = "0x8BDA80", VA = "0x1808BF280", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xB93D80", Offset = "0xB92580", VA = "0x180B93D80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public KJHGHIOALEA DDNLDNHMOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8BF150", Offset = "0x8BD950", VA = "0x1808BF150", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xB93D60", Offset = "0xB92560", VA = "0x180B93D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public GGIIPLFNMOA DGIEGKOIAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8BF120", Offset = "0x8BD920", VA = "0x1808BF120", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xB93CA0", Offset = "0xB924A0", VA = "0x180B93CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public APCMDALIFAP AEHDIMKFCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8BF080", Offset = "0x8BD880", VA = "0x1808BF080", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public KKNNHLMFANP EIGIGOMEGDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA5F960", Offset = "0xA5E160", VA = "0x180A5F960", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public GDBDKOPOCLO IELHIFNAECG
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8BF300", Offset = "0x8BDB00", VA = "0x1808BF300", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public FJDMGDBCEIP LGPBJMPPCFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xAFA9E0", Offset = "0xAF91E0", VA = "0x180AFA9E0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public PHMFOBHEKIK FAFJDJJEHAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xAFA800", Offset = "0xAF9000", VA = "0x180AFA800", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xB93D00", Offset = "0xB92500", VA = "0x180B93D00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private bool JJIDNNFHAGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x6F68300", Offset = "0x6F66B00", VA = "0x186F68300", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private bool EGMBFMJJEEH
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6F687A0", Offset = "0x6F66FA0", VA = "0x186F687A0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private CancellationToken CDLFAJFFLDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6F68AB0", Offset = "0x6F672B0", VA = "0x186F68AB0", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private INCIOHANCNE PHNEENJICEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action DEGINDIDOFO
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6F68990", Offset = "0x6F67190", VA = "0x186F68990", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6F68360", Offset = "0x6F66B60", VA = "0x186F68360", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event OMLCDPLNPMG PAEFGIELMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6F68740", Offset = "0x6F66F40", VA = "0x186F68740", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6F683C0", Offset = "0x6F66BC0", VA = "0x186F683C0", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event OMLCDPLNPMG MMMKBBOBLEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6F68A50", Offset = "0x6F67250", VA = "0x186F68A50", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6F68930", Offset = "0x6F67130", VA = "0x186F68930", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event OMLCDPLNPMG MGGNEDHPMKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6F68820", Offset = "0x6F67020", VA = "0x186F68820", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6F68AD0", Offset = "0x6F672D0", VA = "0x186F68AD0", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<EFBCINIABEJ, bool> FOJIJOCBLFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6F689F0", Offset = "0x6F671F0", VA = "0x186F689F0", Slot = "45")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x6F682A0", Offset = "0x6F66AA0", VA = "0x186F682A0", Slot = "46")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0xB93D00", Offset = "0xB92500", VA = "0x180B93D00", Slot = "36")]
	public void HMEDGBMBGNA(PHMFOBHEKIK HGAMIEAIIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6F68E00", Offset = "0x6F67600", VA = "0x186F68E00")]
	[UnityEngine.Scripting.Preserve]
	internal EHPKEGPHHAK([OMAPKKAGFIL(null)] INCIOHANCNE PGHIDIKDPNB, [OMAPKKAGFIL(null)] ILFDHJAHNHI FAELELHBKKO, [OMAPKKAGFIL(null)] DEBFMJKLBDN HPIKMIOHGPC, [OMAPKKAGFIL(null)] MFEINKDLEHJ EKMGPIDNBAL, [OMAPKKAGFIL(null)] INNHEOLIKBM DAHOAFOCMNK, [OMAPKKAGFIL(null)] NBAHHDNKILP PLDFHJDBLCM, [OMAPKKAGFIL(null)] OMKEILKNJFC NPKMKLLOPKG, [OMAPKKAGFIL(null)] BOAMHEKDIOK CJHEFFFCIJN, [OMAPKKAGFIL(null)] GAGJCKDHAGD JIMBHKPDLLH, [OMAPKKAGFIL(null)] EMPCKPBJDBG HEFAOBKNDGK, [OMAPKKAGFIL(null)] MDIOJHKPIFM KMFINGCDELI, [OMAPKKAGFIL(null)] CDPDCOBHLKK ABLOKNIMFCK, [OMAPKKAGFIL(null)] FFDBLCGPPMM MCGBLNMHNKO, [OMAPKKAGFIL(null)] GPMIBIFCKBJ LPINBJBANHC, [OMAPKKAGFIL(null)] DHPDBLFEFKM PODDALKBECI, [OMAPKKAGFIL(null)] IENMFFFGEPA ANNFANPCCIH, [OMAPKKAGFIL(null)] KIJJEBJPOIH OFBHFEIOFPN, [OMAPKKAGFIL(null)] LNJOHEOEPEC DCEOPNHDHAB, [OMAPKKAGFIL(null)] CCOBBDFLOFB FOEFGCMONND, [OMAPKKAGFIL(null)] OELPCMIPAIF KAGKBNNDDPK, [OMAPKKAGFIL(null)] GDNPJMDDBLG HGNPBLNJDEJ, [OMAPKKAGFIL(null)] GNGDMGCCAPD ELAJIBPEDAA, [OMAPKKAGFIL(null)] FGAHPIAHGMI DLEEJBBLHGJ, [OMAPKKAGFIL(null)] HMHGPPDLHFG BNLFELFFHMM, [OMAPKKAGFIL(null)] GNDHGGJAABG DKKIFNFPLNE, [OMAPKKAGFIL(null)] KJHGHIOALEA AACIHKHGIHG, [OMAPKKAGFIL(null)] GGIIPLFNMOA JKPACCCFGCC, [OMAPKKAGFIL(null)] APCMDALIFAP BPDMMEBNEKC, [OMAPKKAGFIL(null)] KKNNHLMFANP CGMJLNEOJIF, [OMAPKKAGFIL(null)] GDBDKOPOCLO CLJOHLGPPOL, [OMAPKKAGFIL(null)] FJDMGDBCEIP LPFOAEHCDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6F68880", Offset = "0x6F67080", VA = "0x186F68880")]
	private void HMCGAKKBHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6F684B0", Offset = "0x6F66CB0", VA = "0x186F684B0", Slot = "55")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6F68B30", Offset = "0x6F67330", VA = "0x186F68B30", Slot = "49")]
	private void NGLEEHGBBMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6F68D70", Offset = "0x6F67570", VA = "0x186F68D70", Slot = "50")]
	private JNAKBMBBKNN PLIFKLHBOAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6F68420", Offset = "0x6F66C20", VA = "0x186F68420", Slot = "51")]
	private PKDPFMCHDKO DHFCJIBMGNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6F68BE0", Offset = "0x6F673E0", VA = "0x186F68BE0", Slot = "52")]
	[AsyncStateMachine(typeof(OGMIPAJCCGC))]
	private Task<DGFDNIJCPMA> OMCJIEMPOBJ(NCKGPLMHNNB HEEEABJCCCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6F68650", Offset = "0x6F66E50", VA = "0x186F68650", Slot = "53")]
	[AsyncStateMachine(typeof(BMPFNLMDBGN))]
	private Task EOCPFACOFDC(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6F68CF0", Offset = "0x6F674F0", VA = "0x186F68CF0")]
	[IteratorStateMachine(typeof(NDJELHOCNHH))]
	private IEnumerable<DLOEDDKPHPI> OPAOOEAGKHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6F68B80", Offset = "0x6F67380", VA = "0x186F68B80")]
	[CompilerGenerated]
	private void OBLNOKPPDCN(DLOEDDKPHPI INPAFGCEBHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class DNGDLAEGGBH : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0xEF3CF0", Offset = "0xEF24F0", VA = "0x180EF3CF0")]
	public DNGDLAEGGBH(string JNNDBFGKHHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal class AOJJOPMOLMK : MGNJKKAIFOI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct LGLFBGJDEPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AOJJOPMOLMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x6F755A0", Offset = "0x6F73DA0", VA = "0x186F755A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x6F758E0", Offset = "0x6F740E0", VA = "0x186F758E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MFEINKDLEHJ EKMGPIDNBAL;

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x85F050", Offset = "0x85D850", VA = "0x18085F050")]
	public AOJJOPMOLMK(PNHFEHLPHMO KBCJMHHCDBC, MFEINKDLEHJ EKMGPIDNBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F62690", Offset = "0x6F60E90", VA = "0x186F62690", Slot = "4")]
	[AsyncStateMachine(typeof(LGLFBGJDEPF))]
	public Task<bool> AOCJNLDMAFJ(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6F62780", Offset = "0x6F60F80", VA = "0x186F62780")]
	[CompilerGenerated]
	private object MECLHOMABPI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class MFCEKMANMAH : MGNJKKAIFOI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct BLCJBLBLCNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public MFCEKMANMAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private float <timeoutTime>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6F63890", Offset = "0x6F62090", VA = "0x186F63890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6F63FA0", Offset = "0x6F627A0", VA = "0x186F63FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly MFEINKDLEHJ EKMGPIDNBAL;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private FFAMIDMIBLK HFPCNNCNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x6F75EA0", Offset = "0x6F746A0", VA = "0x186F75EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x85F050", Offset = "0x85D850", VA = "0x18085F050")]
	public MFCEKMANMAH(PNHFEHLPHMO KBCJMHHCDBC, MFEINKDLEHJ EKMGPIDNBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6F75C90", Offset = "0x6F74490", VA = "0x186F75C90", Slot = "4")]
	[AsyncStateMachine(typeof(BLCJBLBLCNE))]
	public Task<bool> AOCJNLDMAFJ(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x6F75DC0", Offset = "0x6F745C0", VA = "0x186F75DC0")]
	[CompilerGenerated]
	private object HMOGEIBOAKM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal class NFPBGEHJCEI : MGNJKKAIFOI
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class LFGODBHHOHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public NFPBGEHJCEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public OEFODOPOJHO result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public MDBDBMHCDOA newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public LFGODBHHOHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6F754B0", Offset = "0x6F73CB0", VA = "0x186F754B0")]
		internal object KGCKGCEKMLC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6F75440", Offset = "0x6F73C40", VA = "0x186F75440")]
		internal object JEIPIGHBHKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F753A0", Offset = "0x6F73BA0", VA = "0x186F753A0")]
		internal object BDPLBKDHOHD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct DHHJGIFDFEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public NFPBGEHJCEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private LFGODBHHOHE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<OEFODOPOJHO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6F66640", Offset = "0x6F64E40", VA = "0x186F66640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6F66F70", Offset = "0x6F65770", VA = "0x186F66F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly MFEINKDLEHJ EKMGPIDNBAL;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private FFAMIDMIBLK HFPCNNCNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C430", Offset = "0x6F7AC30", VA = "0x186F7C430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x85F050", Offset = "0x85D850", VA = "0x18085F050")]
	public NFPBGEHJCEI(PNHFEHLPHMO KBCJMHHCDBC, MFEINKDLEHJ EKMGPIDNBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C310", Offset = "0x6F7AB10", VA = "0x186F7C310", Slot = "4")]
	[AsyncStateMachine(typeof(DHHJGIFDFEB))]
	public Task<bool> AOCJNLDMAFJ(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal interface MGNJKKAIFOI
{
	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> AOCJNLDMAFJ(CancellationToken MPLGBOFHPLM);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal struct NNPIKJEPMJD
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class MOLOBLHIFJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public PNHFEHLPHMO manager;

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public MOLOBLHIFJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6F7BDA0", Offset = "0x6F7A5A0", VA = "0x186F7BDA0")]
		internal Task CNLPALNBLCN(CancellationToken cancellationToken, int roomTotalVersion, JLMLCKPCLMI localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct JFEGJJBMFAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public NNPIKJEPMJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private NCKGPLMHNNB <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<IHBHHHHIAHA> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter<DGFDNIJCPMA> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6F6FFD0", Offset = "0x6F6E7D0", VA = "0x186F6FFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6F70560", Offset = "0x6F6ED60", VA = "0x186F70560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct FMDGDOABFEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public NNPIKJEPMJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A340", Offset = "0x6F68B40", VA = "0x186F6A340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A660", Offset = "0x6F68E60", VA = "0x186F6A660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly CancellationToken MPLGBOFHPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly PNHFEHLPHMO GOHDOKCJOFP;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private ILFDHJAHNHI HIAEFCJGPMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6F7CB10", Offset = "0x6F7B310", VA = "0x186F7CB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	private MFEINKDLEHJ KFKHEOKCKBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C600", Offset = "0x6F7AE00", VA = "0x186F7C600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private FFAMIDMIBLK HFPCNNCNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C9E0", Offset = "0x6F7B1E0", VA = "0x186F7C9E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private EMPCKPBJDBG DNFGAGHGFEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C650", Offset = "0x6F7AE50", VA = "0x186F7C650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x1FC6840", Offset = "0x1FC5040", VA = "0x181FC6840")]
	public NNPIKJEPMJD(CancellationToken MPLGBOFHPLM, PNHFEHLPHMO GOHDOKCJOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6F7CA60", Offset = "0x6F7B260", VA = "0x186F7CA60")]
	public static HPIMEFGKLNK NMBOGGHINHI(PNHFEHLPHMO GOHDOKCJOFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C4F0", Offset = "0x6F7ACF0", VA = "0x186F7C4F0")]
	[AsyncStateMachine(typeof(JFEGJJBMFAE))]
	public Task<bool> AGALHLJOLPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C6A0", Offset = "0x6F7AEA0", VA = "0x186F7C6A0")]
	private bool LEBPNAIGEJO([Out] NCKGPLMHNNB HEEEABJCCCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6F7CB60", Offset = "0x6F7B360", VA = "0x186F7CB60")]
	[AsyncStateMachine(typeof(FMDGDOABFEA))]
	private Task PJHENJEAODH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C8B0", Offset = "0x6F7B0B0", VA = "0x186F7C8B0")]
	private Task<IHBHHHHIAHA> LOKGNICGELD(NCKGPLMHNNB NINHNJFGIBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct ILGKIPAKNNM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly DHPDBLFEFKM PODDALKBECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly Guid KPMGFINBLBG;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private Task<(DGFDNIJCPMA, Task)> BFILLPLPPPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x6F6F620", Offset = "0x6F6DE20", VA = "0x186F6F620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x42211C0", Offset = "0x421F9C0", VA = "0x1842211C0")]
	public ILGKIPAKNNM(DHPDBLFEFKM PODDALKBECI, Guid KPMGFINBLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F7C0", Offset = "0x6F6DFC0", VA = "0x186F6F7C0")]
	public TaskAwaiter<(DGFDNIJCPMA, Task)> HGMNODJPCNM()
	{
		return default(TaskAwaiter<(DGFDNIJCPMA, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F6F0", Offset = "0x6F6DEF0", VA = "0x186F6F6F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal struct DEPMLGHEKII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly TaskCompletionSource<(DGFDNIJCPMA, Task)> IKADGLBBPCG;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Task<(DGFDNIJCPMA, Task)> BFILLPLPPPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x6F65FC0", Offset = "0x6F647C0", VA = "0x186F65FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6F66210", Offset = "0x6F64A10", VA = "0x186F66210")]
	public DEPMLGHEKII(TimeSpan CENAAPAKFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6F66000", Offset = "0x6F64800", VA = "0x186F66000")]
	public void EIHJHKEEANH(Task FPNFJMOCKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6F660A0", Offset = "0x6F648A0", VA = "0x186F660A0")]
	public void GEKAFKBGJMB(DGFDNIJCPMA OMMIFMPIFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F661C0", Offset = "0x6F649C0", VA = "0x186F661C0")]
	public void PNEGMOMJHEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6F66130", Offset = "0x6F64930", VA = "0x186F66130")]
	internal void NAFBHAEBLJH(string JNNDBFGKHHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class KDHELKKLFGD
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class GBHEPCMOOEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public HNKJBJIHEKD subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public GBHEPCMOOEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A6C0", Offset = "0x6F68EC0", VA = "0x186F6A6C0")]
		internal bool NOGFNJFMPBP(HCDOMJKEJGM s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6F72F30", Offset = "0x6F71730", VA = "0x186F72F30")]
	public static JBBIANFGILF JGIIBNEOBDO(long LBHHCOPBEOO, long KJMNNDODHCP, string CNCIKMOKNCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F72C40", Offset = "0x6F71440", VA = "0x186F72C40")]
	public static JBBIANFGILF JGIIBNEOBDO(long LBHHCOPBEOO, long KJMNNDODHCP, KEOGFOOKLEH BIOFMAGLAJN, long JFKPBGIIONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F72FC0", Offset = "0x6F717C0", VA = "0x186F72FC0")]
	public static JBBIANFGILF JGIIBNEOBDO(BMBMOGELPMJ BODDICEIOJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F72D00", Offset = "0x6F71500", VA = "0x186F72D00")]
	public static JBBIANFGILF JGIIBNEOBDO(FLKIEPIEFEG FEBBHMHHOKC, HNKJBJIHEKD IHANMGECDBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F73150", Offset = "0x6F71950", VA = "0x186F73150")]
	public static JBBIANFGILF OPOMKMNENAA(this JBBIANFGILF MIJPDJDOIDB, FLKIEPIEFEG FMHAEEHBLLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6F72AB0", Offset = "0x6F712B0", VA = "0x186F72AB0")]
	public static JBBIANFGILF BMNHHDGIDMH(this JBBIANFGILF MIJPDJDOIDB, HNKJBJIHEKD LGPIILHNADA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[RecRoom.NoEngine.Common.Preserve]
internal class DBDPEFCLHMH : GAGJCKDHAGD, DLOEDDKPHPI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct AFBOKGKNFLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public DBDPEFCLHMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6F60770", Offset = "0x6F5EF70", VA = "0x186F60770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x6F60E00", Offset = "0x6F5F600", VA = "0x186F60E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly NKPKPHIMNEI EIEOONHFCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private string PKKHOAKPOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Task GBJLHNPCAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool DKMCCHAMJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x6F64550", Offset = "0x6F62D50", VA = "0x186F64550", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Task NIIJPKMNAEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x6F646A0", Offset = "0x6F62EA0", VA = "0x186F646A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x858FC0", Offset = "0x8577C0", VA = "0x180858FC0", Slot = "7")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6F64730", Offset = "0x6F62F30", VA = "0x186F64730", Slot = "6")]
	public void ODPNHFDHCHP(Task LEDCCMOCHJB, string NAFEJNMBGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6F64580", Offset = "0x6F62D80", VA = "0x186F64580")]
	[AsyncStateMachine(typeof(AFBOKGKNFLA))]
	private Task HKBNFPKOHBA(Task DJMMIEKABGF, string NAFEJNMBGDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6F64890", Offset = "0x6F63090", VA = "0x186F64890")]
	public DBDPEFCLHMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class AJNJHKPNKKB : DKMKDMJDKAD, DLOEDDKPHPI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool DJPKCKCDCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private AGBLOFNHMNJ KBLFDMHIFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private ILFDHJAHNHI FAELELHBKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private KJHGHIOALEA AACIHKHGIHG;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public AGBLOFNHMNJ CGDMKGIJFNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6F621F0", Offset = "0x6F609F0", VA = "0x186F621F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6F622A0", Offset = "0x6F60AA0", VA = "0x186F622A0", Slot = "7")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6F624E0", Offset = "0x6F60CE0", VA = "0x186F624E0", Slot = "5")]
	public void IMDJDHEEMJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6F62260", Offset = "0x6F60A60", VA = "0x186F62260", Slot = "6")]
	public void FNLBOAJMEAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6F62420", Offset = "0x6F60C20", VA = "0x186F62420")]
	private Task HPEAEHOOAHL(FMJIADNAIKM LMDEKGEENAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6F62260", Offset = "0x6F60A60", VA = "0x186F62260", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	public AJNJHKPNKKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class HCEDEAKELNJ : KJHGHIOALEA
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	private class ILFHBMGGKEC<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly PMIHDANGMFM KHLLEDBKIEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly string NDDCLPHCEEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly T LIAHLPBCKNO;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public T JNHPIMBJPMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x8A6510", Offset = "0x8A4D10", VA = "0x1808A6510")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x9AD960", Offset = "0x9AC160", VA = "0x1809AD960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3EC5C80", Offset = "0x3EC4480", VA = "0x183EC5C80")]
		public ILFHBMGGKEC(PMIHDANGMFM KHLLEDBKIEB, string NDDCLPHCEEO, T LIAHLPBCKNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3EC5690", Offset = "0x3EC3E90", VA = "0x183EC5690")]
		private void LFMLDIGACBB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly PMIHDANGMFM KHLLEDBKIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly ILFHBMGGKEC<TimeSpan> FGJMIKIHGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly ILFHBMGGKEC<TimeSpan> HGEICKNLABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly ILFHBMGGKEC<TimeSpan> BIIKAHONGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly ILFHBMGGKEC<TimeSpan> ICOLNEIEPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly ILFHBMGGKEC<bool> EBEKBOKEHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly ILFHBMGGKEC<bool> KMBDHDFPDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly ILFHBMGGKEC<bool> JJGLHGBBLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly ILFHBMGGKEC<int> OKAOJGFPOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly ILFHBMGGKEC<bool> BBPOCBHELBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly ILFHBMGGKEC<bool> BMNDDOFGHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly ILFHBMGGKEC<bool> DHPCOBKJGID;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public TimeSpan POPLOMEELGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A970", Offset = "0x6F69170", VA = "0x186F6A970", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public TimeSpan EILAOPAHMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A7F0", Offset = "0x6F68FF0", VA = "0x186F6A7F0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public TimeSpan FFOMFNFAGFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A6F0", Offset = "0x6F68EF0", VA = "0x186F6A6F0", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public TimeSpan MFJMGLGDJLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A930", Offset = "0x6F69130", VA = "0x186F6A930", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool HIEMGKLEMPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A8B0", Offset = "0x6F690B0", VA = "0x186F6A8B0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool DHJHHPNONME
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A730", Offset = "0x6F68F30", VA = "0x186F6A730", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool PDNJFNGKLAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A770", Offset = "0x6F68F70", VA = "0x186F6A770", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public int HBEFNCBJLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A7B0", Offset = "0x6F68FB0", VA = "0x186F6A7B0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool GMPLDANEBAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A8F0", Offset = "0x6F690F0", VA = "0x186F6A8F0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool JLAHKDIJKKN
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A830", Offset = "0x6F69030", VA = "0x186F6A830", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool FABNOODIDDM
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A870", Offset = "0x6F69070", VA = "0x186F6A870", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x6F6A9B0", Offset = "0x6F691B0", VA = "0x186F6A9B0")]
	[UnityEngine.Scripting.Preserve]
	public HCEDEAKELNJ([OMAPKKAGFIL(null)] PMIHDANGMFM KHLLEDBKIEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[UnityEngine.Scripting.Preserve]
internal class JPHAMNDCIBF : MDIOJHKPIFM, DLOEDDKPHPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class DOKPADCGDHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public BIDJCBPPELH roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public DOKPADCGDHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6F67E90", Offset = "0x6F66690", VA = "0x186F67E90")]
		internal object MGNNDFMFPAN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action FBNNGEHPFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6F721B0", Offset = "0x6F709B0", VA = "0x186F721B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6F71D70", Offset = "0x6F70570", VA = "0x186F71D70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event OMLCDPLNPMG DAKEBEBHJID
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6F72110", Offset = "0x6F70910", VA = "0x186F72110", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x6F723A0", Offset = "0x6F70BA0", VA = "0x186F723A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event OMLCDPLNPMG JINMNOEEMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x6F72250", Offset = "0x6F70A50", VA = "0x186F72250", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6F72040", Offset = "0x6F70840", VA = "0x186F72040", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event OMLCDPLNPMG LLPKHLEBIFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6F724E0", Offset = "0x6F70CE0", VA = "0x186F724E0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6F72440", Offset = "0x6F70C40", VA = "0x186F72440", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<EFBCINIABEJ, bool> FDJJFJNOJEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x6F722F0", Offset = "0x6F70AF0", VA = "0x186F722F0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x6F71A70", Offset = "0x6F70270", VA = "0x186F71A70", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "19")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6F71E40", Offset = "0x6F70640", VA = "0x186F71E40", Slot = "14")]
	public void GJOPDEMKKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6F720E0", Offset = "0x6F708E0", VA = "0x186F720E0", Slot = "15")]
	public void IGKNNADFBCJ(BIDJCBPPELH NMJHAGKCPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6F71D40", Offset = "0x6F70540", VA = "0x186F71D40", Slot = "16")]
	public void CBIKINJHPHE(BIDJCBPPELH NMJHAGKCPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6F71E10", Offset = "0x6F70610", VA = "0x186F71E10", Slot = "17")]
	public void GCEEECEEPGL(BIDJCBPPELH NMJHAGKCPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6F71B20", Offset = "0x6F70320", VA = "0x186F71B20", Slot = "18")]
	public void APBMNJALIEG(EFBCINIABEJ LJJJHDHDDOO, bool NPCJOOKKGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6F71B70", Offset = "0x6F70370", VA = "0x186F71B70")]
	private void APPOJKGPLJE(OMLCDPLNPMG DAKLDBBBMLH, BIDJCBPPELH NMJHAGKCPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	public JPHAMNDCIBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[UnityEngine.Scripting.Preserve]
internal class BJHOANGGNIE : CDPDCOBHLKK, DLOEDDKPHPI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct DJAFMLHHAIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public BJHOANGGNIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x6F66FE0", Offset = "0x6F657E0", VA = "0x186F66FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6F674C0", Offset = "0x6F65CC0", VA = "0x186F674C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct KHAGLLPCFMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public BJHOANGGNIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6F741F0", Offset = "0x6F729F0", VA = "0x186F741F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6F74850", Offset = "0x6F73050", VA = "0x186F74850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class NJMPMBBCKFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public NJMPMBBCKFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C480", Offset = "0x6F7AC80", VA = "0x186F7C480")]
		internal object KGFIEECBOMC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct JCAAOPLFHHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public BJHOANGGNIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private NJMPMBBCKFM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6F6F810", Offset = "0x6F6E010", VA = "0x186F6F810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6F6FF60", Offset = "0x6F6E760", VA = "0x186F6FF60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class HMOFCOEHDFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public HMOFCOEHDFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x6F6AF20", Offset = "0x6F69720", VA = "0x186F6AF20")]
		internal object EPEAECGOECB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private MFEINKDLEHJ EKMGPIDNBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private MGNJKKAIFOI[] CLJBIGHCNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private CancellationTokenSource NPCICLIMLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private int KCKAFLCODKL;

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x6F62F40", Offset = "0x6F61740", VA = "0x186F62F40", Slot = "6")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x6F62E30", Offset = "0x6F61630", VA = "0x186F62E30", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6F62E40", Offset = "0x6F61640", VA = "0x186F62E40", Slot = "8")]
	public void GINDKEMMJIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6F62C30", Offset = "0x6F61430", VA = "0x186F62C30", Slot = "5")]
	public void CNOADOMBMCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x6F633E0", Offset = "0x6F61BE0", VA = "0x186F633E0", Slot = "4")]
	[AsyncStateMachine(typeof(DJAFMLHHAIH))]
	public Task NMANLOAKGED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x6F630C0", Offset = "0x6F618C0", VA = "0x186F630C0")]
	private void KKFDGNOJHKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6F62FC0", Offset = "0x6F617C0", VA = "0x186F62FC0")]
	[AsyncStateMachine(typeof(KHAGLLPCFMC))]
	private Task JLBHAMLFEMO(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6F634B0", Offset = "0x6F61CB0", VA = "0x186F634B0")]
	[AsyncStateMachine(typeof(JCAAOPLFHHJ))]
	private Task<bool> NOPPOHGFLDN(int DHNLEFJCEAH, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6F62B50", Offset = "0x6F61350", VA = "0x186F62B50")]
	private void AKHCHGOIHLF(int DHNLEFJCEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x6F635F0", Offset = "0x6F61DF0", VA = "0x186F635F0")]
	private void OCLKHLIGBBD(int DHNLEFJCEAH, bool NPCJOOKKGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x6F62D00", Offset = "0x6F61500", VA = "0x186F62D00")]
	private void DFEHLIFKLBM(int DHNLEFJCEAH, Exception PBAHBFAICPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6F636D0", Offset = "0x6F61ED0", VA = "0x186F636D0")]
	private void PCIOICDEOFK(CancellationToken MPLGBOFHPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	public BJHOANGGNIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[RecRoom.NoEngine.Common.Preserve]
internal class HNKBGIBBNMO : FFDBLCGPPMM, DLOEDDKPHPI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct PAMJGNFNGGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public PHMFOBHEKIK customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D700", Offset = "0x6F7BF00", VA = "0x186F7D700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E060", Offset = "0x6F7C860", VA = "0x186F7E060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct PPDHDIPGLCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public PHMFOBHEKIK customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private OADONCMLPJG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private PHCOOIGGHEB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private NOCKKKPBJAK <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private LOEOIDGPKKK <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E0C0", Offset = "0x6F7C8C0", VA = "0x186F7E0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6F7EC80", Offset = "0x6F7D480", VA = "0x186F7EC80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class HMMKPOEOPLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public Matchmaking.DCIEOPEHEPA result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public DMFAPLFEJDL errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public HMMKPOEOPLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6F6AE70", Offset = "0x6F69670", VA = "0x186F6AE70")]
		internal object PKDFCEACPLO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class FEGHAJBNLCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public Task<JBBIANFGILF> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public FEGHAJBNLCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851900", VA = "0x180853100")]
		internal Task<JBBIANFGILF> AKALEOPAHNP(OADONCMLPJG<string>.HILOONJJDHL _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct MIJPPMOPNBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public PHMFOBHEKIK customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public NOCKKKPBJAK joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private FEGHAJBNLCO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private NPFIODHPLCC <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private PHCOOIGGHEB <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private OADONCMLPJG<string>.HILOONJJDHL <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private NKKKGGINLEP <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private Task<Matchmaking.HMGBEKBDAJP> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private AFIHICIEAEF <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private int <i>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private TaskAwaiter<Matchmaking.HMGBEKBDAJP> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private TaskAwaiter<JBBIANFGILF> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x6F76460", Offset = "0x6F74C60", VA = "0x186F76460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6F7BD40", Offset = "0x6F7A540", VA = "0x186F7BD40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct IBIPMOKBHJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private OADONCMLPJG<string>.HILOONJJDHL <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6F6EB70", Offset = "0x6F6D370", VA = "0x186F6EB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6F6F5C0", Offset = "0x6F6DDC0", VA = "0x186F6F5C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct FGMMFNHNJMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private INCIOHANCNE <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6F69CA0", Offset = "0x6F684A0", VA = "0x186F69CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A110", Offset = "0x6F68910", VA = "0x186F6A110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct MFEKPCKEMPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public AsyncTaskMethodBuilder<Matchmaking.HMGBEKBDAJP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private TaskAwaiter<Matchmaking.HMGBEKBDAJP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6F75EF0", Offset = "0x6F746F0", VA = "0x186F75EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6F763F0", Offset = "0x6F74BF0", VA = "0x186F763F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct AIPAICBEHPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public Matchmaking.HMGBEKBDAJP serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public NOCKKKPBJAK joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private TaskAwaiter<HBOFKAEDAPN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6F60E60", Offset = "0x6F5F660", VA = "0x186F60E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6F61560", Offset = "0x6F5FD60", VA = "0x186F61560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class JIPNGCHCFCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public JIPNGCHCFCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6F705D0", Offset = "0x6F6EDD0", VA = "0x186F705D0")]
		internal object FBGOHMOBGCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6F706D0", Offset = "0x6F6EED0", VA = "0x186F706D0")]
		internal string JMIFFCAIAEJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct AJNGDMHBPON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private JIPNGCHCFCC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6F615C0", Offset = "0x6F5FDC0", VA = "0x186F615C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6F62190", Offset = "0x6F60990", VA = "0x186F62190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct DNDPFDJLFMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public NOCKKKPBJAK joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public JBBIANFGILF initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public MDBDBMHCDOA targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public NPFIODHPLCC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private OADONCMLPJG<string>.HILOONJJDHL <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x6F67520", Offset = "0x6F65D20", VA = "0x186F67520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6F67E30", Offset = "0x6F66630", VA = "0x186F67E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct DBMGOGHGNOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private OADONCMLPJG<string>.HILOONJJDHL <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private PHCOOIGGHEB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private CancellationTokenSource <timeoutTcs>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private CancellationToken <timeoutToken>5__7;

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x6F64920", Offset = "0x6F63120", VA = "0x186F64920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x6F65F60", Offset = "0x6F64760", VA = "0x186F65F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct AADFJFIEGJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public JLMLCKPCLMI localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private TaskAwaiter<DGFDNIJCPMA> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FFA0", Offset = "0x6F5E7A0", VA = "0x186F5FFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6F60710", Offset = "0x6F5EF10", VA = "0x186F60710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class FHGLJJDLGGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public FHGLJJDLGGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A170", Offset = "0x6F68970", VA = "0x186F6A170")]
		internal object POCCAOMGPEE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class LBFPKNNPLFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public LBFPKNNPLFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6F75300", Offset = "0x6F73B00", VA = "0x186F75300")]
		internal void CJEJNJFHLPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class EEIDPHAINCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public EEIDPHAINCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6F67F70", Offset = "0x6F66770", VA = "0x186F67F70")]
		internal object BABICLDPMHL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class JNDJBOEIGAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public JNDJBOEIGAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x6F71620", Offset = "0x6F6FE20", VA = "0x186F71620")]
		internal string GLPGPBNMNBF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly CDLNJDLNIPA OLOCEDJDFLB;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly CDLNJDLNIPA BPCOIOKDKDB;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly CDLNJDLNIPA PCIAMJMIABF;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly string ANKCHOGOAEB;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly string DLKDLGEKOIC;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly string MOBNGBHJBCF;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly Guid AMGNMGCFFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private BOAMHEKDIOK CJHEFFFCIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private DEBFMJKLBDN HPIKMIOHGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private ILFDHJAHNHI FAELELHBKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private MFEINKDLEHJ EKMGPIDNBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private CDPDCOBHLKK ABLOKNIMFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private GAGJCKDHAGD JIMBHKPDLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private MDIOJHKPIFM KMFINGCDELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private GDBDKOPOCLO CLJOHLGPPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private KKNNHLMFANP CGMJLNEOJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private IDisposable KPBJBKAIJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly NKPKPHIMNEI HLFHFFLLGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private AFIHICIEAEF JILPJAIBHOM;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public TaskStatus GBIGLBPMJGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8BF200", Offset = "0x8BDA00", VA = "0x1808BF200", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xB59670", Offset = "0xB57E70", VA = "0x180B59670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private FFAMIDMIBLK HFPCNNCNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E780", Offset = "0x6F6CF80", VA = "0x186F6E780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x6F6D180", Offset = "0x6F6B980", VA = "0x186F6D180", Slot = "6")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6F6C0D0", Offset = "0x6F6A8D0", VA = "0x186F6C0D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6F6D790", Offset = "0x6F6BF90", VA = "0x186F6D790", Slot = "5")]
	[AsyncStateMachine(typeof(PAMJGNFNGGE))]
	public Task IADAOMLEGLE(MDBDBMHCDOA OLIIPNAKLLA, PHMFOBHEKIK LHBIIPLLKKE, CancellationToken LJPECIOGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6F6DD90", Offset = "0x6F6C590", VA = "0x186F6DD90")]
	[AsyncStateMachine(typeof(PPDHDIPGLCM))]
	private Task LEIGIBIHDKJ(MDBDBMHCDOA OLIIPNAKLLA, PHMFOBHEKIK LHBIIPLLKKE, CancellationToken LJPECIOGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6F6B5D0", Offset = "0x6F69DD0", VA = "0x186F6B5D0")]
	private static void AMEBNCCMPCK(GDBDKOPOCLO CLJOHLGPPOL, MDBDBMHCDOA OLIIPNAKLLA, Exception PBAHBFAICPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6F6C180", Offset = "0x6F6A980", VA = "0x186F6C180")]
	private static void FFBKAJLPPED(LOEOIDGPKKK IOLDPMPDDLA, Exception PBAHBFAICPK, [Optional] List<int> ODNIHHABMCH, int KCKAFLCODKL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E160", Offset = "0x6F6C960", VA = "0x186F6E160")]
	[AsyncStateMachine(typeof(MIJPPMOPNBH))]
	private Task MENFDAOMFIP(OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, MDBDBMHCDOA OLIIPNAKLLA, PHMFOBHEKIK LHBIIPLLKKE, NOCKKKPBJAK OPJMEADJLCF, CancellationToken LJPECIOGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6F6D640", Offset = "0x6F6BE40", VA = "0x186F6D640")]
	private void HNFCABGDADF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6F6D050", Offset = "0x6F6B850", VA = "0x186F6D050")]
	[AsyncStateMachine(typeof(IBIPMOKBHJA))]
	private Task HELENOIFGLE(OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E450", Offset = "0x6F6CC50", VA = "0x186F6E450")]
	private void NADLKFOEBAO(MDBDBMHCDOA OLIIPNAKLLA, CancellationToken LJPECIOGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6F6BC60", Offset = "0x6F6A460", VA = "0x186F6BC60")]
	private void DBGMGHDNGAL(MDBDBMHCDOA OLIIPNAKLLA, NOCKKKPBJAK OPJMEADJLCF, OperationCanceledException JEGEBALABNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6F6D8D0", Offset = "0x6F6C0D0", VA = "0x186F6D8D0")]
	private void IGGJNBCFCEJ(MDBDBMHCDOA OLIIPNAKLLA, NOCKKKPBJAK OPJMEADJLCF, Exception PBAHBFAICPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6F6AF90", Offset = "0x6F69790", VA = "0x186F6AF90")]
	private void ADECOJLLCEG(MDBDBMHCDOA OLIIPNAKLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6F6C120", Offset = "0x6F6A920", VA = "0x186F6C120")]
	private static BIDJCBPPELH EJFDIJEFKFP(MDBDBMHCDOA OLIIPNAKLLA)
	{
		return default(BIDJCBPPELH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6F6BB90", Offset = "0x6F6A390", VA = "0x186F6BB90")]
	[AsyncStateMachine(typeof(FGMMFNHNJMB))]
	private Task BOELEJIFBLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6F6CBE0", Offset = "0x6F6B3E0", VA = "0x186F6CBE0")]
	[AsyncStateMachine(typeof(MFEKPCKEMPF))]
	private Task<Matchmaking.HMGBEKBDAJP> FMLAHBCEJDN(MDBDBMHCDOA OLIIPNAKLLA, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6F6DBF0", Offset = "0x6F6C3F0", VA = "0x186F6DBF0")]
	private static HBOFKAEDAPN KOHBOIIBIEM(Matchmaking.HMGBEKBDAJP KOCMLIJCBLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6F6B1A0", Offset = "0x6F699A0", VA = "0x186F6B1A0")]
	[AsyncStateMachine(typeof(AIPAICBEHPG))]
	private Task AHFJIDFMPEB(Matchmaking.HMGBEKBDAJP KOCMLIJCBLI, NOCKKKPBJAK OPJMEADJLCF, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken CGFBIGKMGCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6F6BF90", Offset = "0x6F6A790", VA = "0x186F6BF90")]
	[AsyncStateMachine(typeof(AJNGDMHBPON))]
	private Task DPPIJODPFLB(MDBDBMHCDOA OLIIPNAKLLA, CancellationTokenSource CFNNLMNCHIM, Task HNNFPDNLJHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6F6B990", Offset = "0x6F6A190", VA = "0x186F6B990")]
	[AsyncStateMachine(typeof(DNDPFDJLFMB))]
	private Task BADNIKJAECB(JBBIANFGILF KLNKIGMCCKO, NPFIODHPLCC CMNBDIJCHGE, MDBDBMHCDOA PFCJBPLHMBO, NOCKKKPBJAK CKEHJAPJCLE, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken EOCFNKLBEMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6F6DEE0", Offset = "0x6F6C6E0", VA = "0x186F6DEE0")]
	private NOCKKKPBJAK LJJDGOMDDAL(NOCKKKPBJAK CKEHJAPJCLE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6F6CDA0", Offset = "0x6F6B5A0", VA = "0x186F6CDA0")]
	[AsyncStateMachine(typeof(DBMGOGHGNOP))]
	private Task GDMGNLIGCBB(OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E320", Offset = "0x6F6CB20", VA = "0x186F6E320")]
	[AsyncStateMachine(typeof(AADFJFIEGJI))]
	private Task MLKHHDHLNGB(CancellationToken MPLGBOFHPLM, int IDCPOPPPDDB, JLMLCKPCLMI ONEPKIAFHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x6F6CED0", Offset = "0x6F6B6D0", VA = "0x186F6CED0")]
	private static void GLEGLCIMJNP(MDBDBMHCDOA OLIIPNAKLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x6F6B2F0", Offset = "0x6F69AF0", VA = "0x186F6B2F0")]
	private void AHJEPGBAJCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E0D0", Offset = "0x6F6C8D0", VA = "0x186F6E0D0")]
	private void MABJEEAHJII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6F6BB00", Offset = "0x6F6A300", VA = "0x186F6BB00")]
	private void BGHPDLKEPFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6F6DD00", Offset = "0x6F6C500", VA = "0x186F6DD00")]
	private void KPDCFKDOCLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x6F6DB00", Offset = "0x6F6C300", VA = "0x186F6DB00")]
	private static void JGCOPKNAEMG(MDBDBMHCDOA OLIIPNAKLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x6F6B4C0", Offset = "0x6F69CC0", VA = "0x186F6B4C0")]
	private static CancellationTokenRegistration AMDJGGIGCJE(MDBDBMHCDOA OLIIPNAKLLA, CancellationToken CGFBIGKMGCL)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6F6BE90", Offset = "0x6F6A690", VA = "0x186F6BE90")]
	private static void DNGCDFGGFFA(MDBDBMHCDOA OLIIPNAKLLA, Exception PBAHBFAICPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x6F6CA30", Offset = "0x6F6B230", VA = "0x186F6CA30")]
	private void FGFPEFHEFOM(MDBDBMHCDOA OLIIPNAKLLA, Task HNNFPDNLJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E2C0", Offset = "0x6F6CAC0", VA = "0x186F6E2C0")]
	private static void MGFMJHPPHBP(Func<string> ALLEHOLILJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E9F0", Offset = "0x6F6D1F0", VA = "0x186F6E9F0")]
	public HNKBGIBBNMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6F6CD40", Offset = "0x6F6B540", VA = "0x186F6CD40")]
	[CompilerGenerated]
	internal static (int, int?) GAHNEKBKMAO(DMFAPLFEJDL LBJMNCMBNEA)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[RecRoom.NoEngine.Common.Preserve]
internal class KECDANANLKO : GPMIBIFCKBJ, DLOEDDKPHPI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct AKGJJNNFNKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public KECDANANLKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public JLMLCKPCLMI localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x6F80ED0", Offset = "0x6F7F6D0", VA = "0x186F80ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x6F81290", Offset = "0x6F7FA90", VA = "0x186F81290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class KDPMFNPCPDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public KECDANANLKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public JLMLCKPCLMI localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public KDPMFNPCPDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x6F92E60", Offset = "0x6F91660", VA = "0x186F92E60")]
		internal List<Task> ODJDFFMEEMO(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct EEGEPLPDDFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public HPIMEFGKLNK taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public JLMLCKPCLMI localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F88B70", Offset = "0x6F87370", VA = "0x186F88B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6F88F00", Offset = "0x6F87700", VA = "0x186F88F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct GJIILEKIGAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public KECDANANLKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x6F8B690", Offset = "0x6F89E90", VA = "0x186F8B690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x6F8B950", Offset = "0x6F8A150", VA = "0x186F8B950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private readonly HashSet<HPIMEFGKLNK> MBNKNAPCPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private DEBFMJKLBDN HPIKMIOHGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private FFCFLPKEGBI CFHFJJJEMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private LJJNFBNGNFA KNOBALPGCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private IDisposable KPBJBKAIJHH;

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6F73DC0", Offset = "0x6F725C0", VA = "0x186F73DC0", Slot = "5")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6F73BF0", Offset = "0x6F723F0", VA = "0x186F73BF0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6F738A0", Offset = "0x6F720A0", VA = "0x186F738A0", Slot = "4")]
	public bool CELLIGGGPOC(HPIMEFGKLNK JABMPBLAEKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6F73240", Offset = "0x6F71A40", VA = "0x186F73240")]
	private void ACCECIBKIGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6F73900", Offset = "0x6F72100", VA = "0x186F73900")]
	private void CHBANEPGHPG(BCCLEKKJGLB FCMADEBOIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6F73CD0", Offset = "0x6F724D0", VA = "0x186F73CD0")]
	[AsyncStateMachine(typeof(AKGJJNNFNKA))]
	private Task HBFKOLGGOJG(int IDCPOPPPDDB, JLMLCKPCLMI ONEPKIAFHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6F73370", Offset = "0x6F71B70", VA = "0x186F73370")]
	private Func<CancellationToken, List<Task>> BAMLLDAFAFC(int IDCPOPPPDDB, JLMLCKPCLMI ONEPKIAFHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x6F73440", Offset = "0x6F71C40", VA = "0x186F73440")]
	private List<Task> CCPFNHBACIN(int IDCPOPPPDDB, JLMLCKPCLMI ONEPKIAFHHL, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6F74040", Offset = "0x6F72840", VA = "0x186F74040")]
	[AsyncStateMachine(typeof(EEGEPLPDDFO))]
	private Task KDAIKBEEJFH(HPIMEFGKLNK LDEAEONJEHG, CancellationToken EOCJCEFCOOA, int IDCPOPPPDDB, JLMLCKPCLMI ONEPKIAFHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6F73B20", Offset = "0x6F72320", VA = "0x186F73B20")]
	[AsyncStateMachine(typeof(GJIILEKIGAI))]
	private Task COHAHPNBDIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x6F73C50", Offset = "0x6F72450", VA = "0x186F73C50")]
	private void GINDKEMMJIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6F74160", Offset = "0x6F72960", VA = "0x186F74160")]
	public KECDANANLKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[UnityEngine.Scripting.Preserve]
internal sealed class PDEGFADDMDE : DHPDBLFEFKM, DLOEDDKPHPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class IIMLFIPAJMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public IIMLFIPAJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EF10", Offset = "0x6F8D710", VA = "0x186F8EF10")]
		internal object ECLJNPHBCAN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class LLIKMOKHPJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public LLIKMOKHPJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x6F954F0", Offset = "0x6F93CF0", VA = "0x186F954F0")]
		internal object NFCNCKIPENF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class IPPOKHMHDLE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public IPPOKHMHDLE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class GGMPHEJNDAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public GGMPHEJNDAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x6F8B630", Offset = "0x6F89E30", VA = "0x186F8B630")]
		internal object MGGACGDPKNJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class LMGAKJBNMHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public LMGAKJBNMHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x6F95A50", Offset = "0x6F94250", VA = "0x186F95A50")]
		internal object IADJNBGAGIC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private readonly Dictionary<Guid, DEPMLGHEKII> PODDALKBECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private readonly TimeSpan PGJKIPCMONL;

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "9")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6F9D260", Offset = "0x6F9BA60", VA = "0x186F9D260", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6F9DBC0", Offset = "0x6F9C3C0", VA = "0x186F9DBC0", Slot = "4")]
	public ILGKIPAKNNM PBLNBBGFGAP(Guid KPMGFINBLBG)
	{
		return default(ILGKIPAKNNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6F9D9B0", Offset = "0x6F9C1B0", VA = "0x186F9D9B0", Slot = "5")]
	public bool MFKDEBIIBOM(Guid KPMGFINBLBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F9D680", Offset = "0x6F9BE80", VA = "0x186F9D680", Slot = "6")]
	public bool ILAGFIPHBII(Guid KPMGFINBLBG, Task FPNFJMOCKDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x6F9D270", Offset = "0x6F9BA70", VA = "0x186F9D270", Slot = "7")]
	public bool GBCDJOMOKCI(Guid KPMGFINBLBG, DGFDNIJCPMA OMMIFMPIFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F9D1F0", Offset = "0x6F9B9F0", VA = "0x186F9D1F0", Slot = "8")]
	public Task<(DGFDNIJCPMA, Task)> BDAIDICDCAJ(Guid KPMGFINBLBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6F9D450", Offset = "0x6F9BC50", VA = "0x186F9D450")]
	private void GLNFLBKPBCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6F9DDE0", Offset = "0x6F9C5E0", VA = "0x186F9DDE0")]
	public PDEGFADDMDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[RecRoom.NoEngine.Common.Preserve]
internal class CDPDJJBIBDC : IENMFFFGEPA, DLOEDDKPHPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private class OAIBMIFPOGM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private readonly MDBDBMHCDOA ODGJFBJGOFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private readonly CancellationTokenSource NPCICLIMLAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public readonly CancellationToken JDBBABFONDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private bool LGIHFPFHNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private bool MAFFMBBADNE;

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x6F9BAF0", Offset = "0x6F9A2F0", VA = "0x186F9BAF0")]
		public OAIBMIFPOGM(MDBDBMHCDOA ODGJFBJGOFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x6F9B9A0", Offset = "0x6F9A1A0", VA = "0x186F9B9A0")]
		public void GINDKEMMJIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x6F9B970", Offset = "0x6F9A170", VA = "0x186F9B970", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class COHBDHFHIBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public FMJIADNAIKM disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public COHBDHFHIBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6F878A0", Offset = "0x6F860A0", VA = "0x186F878A0")]
		internal object GJJABDHLAJI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct AGCLEHHNEKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public FMJIADNAIKM disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public CDPDJJBIBDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x6F801D0", Offset = "0x6F7E9D0", VA = "0x186F801D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x6F80580", Offset = "0x6F7ED80", VA = "0x186F80580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class PEKOJDNGLPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public PEKOJDNGLPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x6F9DEA0", Offset = "0x6F9C6A0", VA = "0x186F9DEA0")]
		internal object CLCIPPKEGGC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct MPHDHEIMLNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public CDPDJJBIBDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private PHCOOIGGHEB <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x6F997E0", Offset = "0x6F97FE0", VA = "0x186F997E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x9EB410", Offset = "0x9E9C10", VA = "0x1809EB410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class NPFMOOJMNCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public MDBDBMHCDOA newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public NPFMOOJMNCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x6F9B850", Offset = "0x6F9A050", VA = "0x186F9B850")]
		internal object AEMEAGGLKLI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x6F9B930", Offset = "0x6F9A130", VA = "0x186F9B930")]
		internal object JKBLBAFFGFG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x6F9B8F0", Offset = "0x6F9A0F0", VA = "0x186F9B8F0")]
		internal object EDEGOPIEENF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class DDANANHINOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public DDANANHINOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x6F87930", Offset = "0x6F86130", VA = "0x186F87930")]
		internal void KDBBFJLAOAA()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private struct EJJFDEDKAOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public MDBDBMHCDOA newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public CDPDJJBIBDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public PHMFOBHEKIK customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private NPFMOOJMNCA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x6F89590", Offset = "0x6F87D90", VA = "0x186F89590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x6F8A510", Offset = "0x6F88D10", VA = "0x186F8A510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly ONHBODPEMNP.AOMBGGKOFKP CNCKDHMKNAH;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly MEIHHKOBOJC ICIADONHJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private DEBFMJKLBDN HPIKMIOHGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private CDPDCOBHLKK ABLOKNIMFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private MFEINKDLEHJ EKMGPIDNBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private KJHGHIOALEA AACIHKHGIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private FFDBLCGPPMM MCGBLNMHNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private MDBDBMHCDOA FMOGMGAOFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private OAIBMIFPOGM PJOAGEEEDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private bool OOMHAADDHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private Task NJOFDKJFGCB;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private FFAMIDMIBLK HFPCNNCNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x6F857A0", Offset = "0x6F83FA0", VA = "0x186F857A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool PJEOOLOCMOL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x91F1C0", Offset = "0x91D9C0", VA = "0x18091F1C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x6F85600", Offset = "0x6F83E00", VA = "0x186F85600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6F84FD0", Offset = "0x6F837D0", VA = "0x186F84FD0", Slot = "4")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6F84C10", Offset = "0x6F83410", VA = "0x186F84C10", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6F85270", Offset = "0x6F83A70", VA = "0x186F85270")]
	[AsyncStateMachine(typeof(AGCLEHHNEKG))]
	private Task JKMLDKGMEKK(FMJIADNAIKM LCBIAINGNCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6F85610", Offset = "0x6F83E10", VA = "0x186F85610")]
	private void NAOMOMFBMJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F84A80", Offset = "0x6F83280", VA = "0x186F84A80")]
	private void BGEFNKEMCOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D80", Offset = "0x6F83580", VA = "0x186F84D80")]
	private void GAIFFCCGEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F85A80", Offset = "0x6F84280", VA = "0x186F85A80")]
	private bool PLFGDIKCEGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x6F84F00", Offset = "0x6F83700", VA = "0x186F84F00")]
	[AsyncStateMachine(typeof(MPHDHEIMLNK))]
	private void HKMIFPBLENP(int JGJFKDCDFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x6F857F0", Offset = "0x6F83FF0", VA = "0x186F857F0")]
	private void OPMKJEKGEHI([Out] IDisposable EFBBALGDKJK, [Out] IDisposable GJCJECOCBAG, [Out] IDisposable HNAJEPEILMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x6F85360", Offset = "0x6F83B60", VA = "0x186F85360")]
	private bool JKPKFJAKOGI(MDBDBMHCDOA ODGJFBJGOFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x6F855B0", Offset = "0x6F83DB0", VA = "0x186F855B0")]
	private void LNJAOOJBLKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x6F85480", Offset = "0x6F83C80", VA = "0x186F85480")]
	[AsyncStateMachine(typeof(EJJFDEDKAOF))]
	private Task LEIGIBIHDKJ(MDBDBMHCDOA ODGJFBJGOFN, PHMFOBHEKIK LHBIIPLLKKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6F85ED0", Offset = "0x6F846D0", VA = "0x186F85ED0")]
	public CDPDJJBIBDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[UnityEngine.Scripting.Preserve]
internal sealed class JFGEPJACMMB : KIJJEBJPOIH, DLOEDDKPHPI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private struct GCCCCOACEJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public AsyncTaskMethodBuilder<KPFIKNDEFFO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public JFGEPJACMMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private TaskAwaiter<KPFIKNDEFFO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6F8B330", Offset = "0x6F89B30", VA = "0x186F8B330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x6F8B5C0", Offset = "0x6F89DC0", VA = "0x186F8B5C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class ABFBAKOBLAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public JHHNPEBPLNM message;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public ABFBAKOBLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F850", Offset = "0x6F7E050", VA = "0x186F7F850")]
		internal object MNFGDIAHDKF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class OCGFNJLLBMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public JHHNPEBPLNM messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public OCGFNJLLBMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6F9BD40", Offset = "0x6F9A540", VA = "0x186F9BD40")]
		internal object EMPANHJNGMC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class IOAFBONFKLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public IOAFBONFKLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x6F90730", Offset = "0x6F8EF30", VA = "0x186F90730")]
		internal object GOCMPLOAOPM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct HODPIFDFBHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public JFGEPJACMMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private TaskAwaiter<LDOGEOGHOLH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6F8CDA0", Offset = "0x6F8B5A0", VA = "0x186F8CDA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x6F8D660", Offset = "0x6F8BE60", VA = "0x186F8D660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class BIDEHHENBGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public JHHNPEBPLNM operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public BIDEHHENBGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x6F825F0", Offset = "0x6F80DF0", VA = "0x186F825F0")]
		internal object DMNCBDOEKOH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct INMJIFBIJNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public JHHNPEBPLNM operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public JFGEPJACMMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private NOCKKKPBJAK <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x6F8FB60", Offset = "0x6F8E360", VA = "0x186F8FB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x6F906D0", Offset = "0x6F8EED0", VA = "0x186F906D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct NKBHNJGDMBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public AsyncTaskMethodBuilder<LDOGEOGHOLH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public JFGEPJACMMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private PGGDLKOGOBJ.GFAHLAKMHKM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private NOCKKKPBJAK <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x6F9AD50", Offset = "0x6F99550", VA = "0x186F9AD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x6F9B270", Offset = "0x6F99A70", VA = "0x186F9B270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class FFBOBOHEFDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public LDOGEOGHOLH operation;

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public FFBOBOHEFDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x6F8A690", Offset = "0x6F88E90", VA = "0x186F8A690")]
		internal object IBNJJFJMLJO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private struct JBIGGDBBPGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public LDOGEOGHOLH operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public JFGEPJACMMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private OADONCMLPJG<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x6F90790", Offset = "0x6F8EF90", VA = "0x186F90790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x6F90DC0", Offset = "0x6F8F5C0", VA = "0x186F90DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class CEOJHGOJIKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public CEOJHGOJIKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x6F85F40", Offset = "0x6F84740", VA = "0x186F85F40")]
		internal object NINEIBJNIPO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class CFPMDHOMAAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public CFPMDHOMAAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x6F85FA0", Offset = "0x6F847A0", VA = "0x186F85FA0")]
		internal object DNJMBAILEBD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private GAGJCKDHAGD JIMBHKPDLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private LNJOHEOEPEC DCEOPNHDHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private GNGDMGCCAPD ELAJIBPEDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private ILFDHJAHNHI FAELELHBKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private TaskCompletionSource<KPFIKNDEFFO> HNPFGBJOFHC;

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x6F916B0", Offset = "0x6F8FEB0", VA = "0x186F916B0", Slot = "7")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x6F915A0", Offset = "0x6F8FDA0", VA = "0x186F915A0", Slot = "6")]
	[AsyncStateMachine(typeof(GCCCCOACEJO))]
	public Task<KPFIKNDEFFO> HEDPEEEGPBI(CancellationToken JHPDMDBBGOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6F91C20", Offset = "0x6F90420", VA = "0x186F91C20", Slot = "4")]
	public void NMIDACFLKHF(JHHNPEBPLNM JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x6F90E20", Offset = "0x6F8F620", VA = "0x186F90E20", Slot = "5")]
	public void DCAJFCLMDMN(JHHNPEBPLNM AHIOCFBKFEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6F920C0", Offset = "0x6F908C0", VA = "0x186F920C0")]
	[AsyncStateMachine(typeof(HODPIFDFBHL))]
	private Task PONCBMFOEOL(JHHNPEBPLNM GPCNCGBOPJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F91FB0", Offset = "0x6F907B0", VA = "0x186F91FB0")]
	[AsyncStateMachine(typeof(INMJIFBIJNC))]
	private Task PBPEGIONGGK(JHHNPEBPLNM LLGJLDCBANK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6F91AD0", Offset = "0x6F902D0", VA = "0x186F91AD0")]
	[AsyncStateMachine(typeof(NKBHNJGDMBB))]
	private Task<LDOGEOGHOLH> NJFAFCEHLDL(JHHNPEBPLNM GPCNCGBOPJG, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6F91180", Offset = "0x6F8F980", VA = "0x186F91180")]
	private NOCKKKPBJAK DIFFLJGINPN(JHHNPEBPLNM PIHNIIFANNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F917A0", Offset = "0x6F8FFA0", VA = "0x186F917A0")]
	[AsyncStateMachine(typeof(JBIGGDBBPGA))]
	private Task KPBAJBJEEKL(LDOGEOGHOLH PADMFCNKGOL, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x6F918C0", Offset = "0x6F900C0", VA = "0x186F918C0")]
	private LDOGEOGHOLH MLCOFAJHONO(JHHNPEBPLNM GPCNCGBOPJG, NOCKKKPBJAK EECJCJLHLIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x2BCA5A0", Offset = "0x2BC8DA0", VA = "0x182BCA5A0")]
	private T FPAIGDJBKKJ<T>(T JMDCGOKJIDA) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F91210", Offset = "0x6F8FA10", VA = "0x186F91210")]
	private LDOGEOGHOLH GEPBOINCFBB(JHHNPEBPLNM GPCNCGBOPJG, NOCKKKPBJAK EECJCJLHLIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	public JFGEPJACMMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[UnityEngine.Scripting.Preserve]
internal sealed class MCPBIHOJABL : LNJOHEOEPEC, DLOEDDKPHPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class OIIBAKCIDJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public OIIBAKCIDJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x6F9C670", Offset = "0x6F9AE70", VA = "0x186F9C670")]
		internal object BPJIFMJFNAG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class MIMPMDOFDGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public MIMPMDOFDGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x6F99110", Offset = "0x6F97910", VA = "0x186F99110")]
		internal object MLMAKMIDCHG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private ILFDHJAHNHI FAELELHBKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private FGAHPIAHGMI DLEEJBBLHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private KIJJEBJPOIH OFBHFEIOFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private DHPDBLFEFKM PODDALKBECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private GNDHGGJAABG DKKIFNFPLNE;

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6F97BD0", Offset = "0x6F963D0", VA = "0x186F97BD0", Slot = "6")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6F96D50", Offset = "0x6F95550", VA = "0x186F96D50", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x6F97590", Offset = "0x6F95D90", VA = "0x186F97590", Slot = "4")]
	public ILGKIPAKNNM GIOEHONMECA(JHHNPEBPLNM MJJIPHKHOEB)
	{
		return default(ILGKIPAKNNM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x6F979C0", Offset = "0x6F961C0", VA = "0x186F979C0", Slot = "5")]
	public void GLALEPFIHIM(Guid KPMGFINBLBG, Task FPNFJMOCKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6F98210", Offset = "0x6F96A10", VA = "0x186F98210")]
	private void NFMAFIEKMLN(byte IEEHAPDEHNL, int OHGHBMACDMM, object AENCOFPLNBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x6F96510", Offset = "0x6F94D10", VA = "0x186F96510")]
	private void BIMAPAGNABO(NDIHCAFDEOE BGEDEFLEFII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x6F97080", Offset = "0x6F95880", VA = "0x186F97080")]
	private void FOJGMPCGJHJ(NDIHCAFDEOE BGEDEFLEFII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x6F97D40", Offset = "0x6F96540", VA = "0x186F97D40")]
	private void MCMMFKDFMPA(NDIHCAFDEOE BGEDEFLEFII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x6F982E0", Offset = "0x6F96AE0", VA = "0x186F982E0")]
	private DGFDNIJCPMA PKLJABLJELL(JHHNPEBPLNM PIHNIIFANNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x6F97380", Offset = "0x6F95B80", VA = "0x186F97380")]
	private void GAKFFOGHFBP(JHHNPEBPLNM LLGJLDCBANK, DGFDNIJCPMA OMMIFMPIFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x6F96AA0", Offset = "0x6F952A0", VA = "0x186F96AA0")]
	private bool CCNCLFFLLID(JHHNPEBPLNM LLGJLDCBANK, DGFDNIJCPMA OMMIFMPIFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x6F96E00", Offset = "0x6F95600", VA = "0x186F96E00")]
	private bool EGMNIDLJKCE(JHHNPEBPLNM ANENNFMGIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x6F97F80", Offset = "0x6F96780", VA = "0x186F97F80")]
	private bool MKEGGCIIGHD(byte IEEHAPDEHNL, ExitGames.Client.Photon.Hashtable BGEDEFLEFII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	public MCPBIHOJABL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[UnityEngine.Scripting.Preserve]
internal sealed class EBGLDLIIJJP : CCOBBDFLOFB, DLOEDDKPHPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class HIALKOCPJDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public KPFIKNDEFFO operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public EBGLDLIIJJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public JHHNPEBPLNM roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public HIALKOCPJDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x6F8CD30", Offset = "0x6F8B530", VA = "0x186F8CD30")]
		internal object NNCHBJALIEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x6F8CC00", Offset = "0x6F8B400", VA = "0x186F8CC00")]
		internal object AIBKKMKGKNA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct CHLDPGIABKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public AsyncTaskMethodBuilder<DGFDNIJCPMA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public EBGLDLIIJJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public JHHNPEBPLNM roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private TaskAwaiter<DGFDNIJCPMA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x6F87130", Offset = "0x6F85930", VA = "0x186F87130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x6F877C0", Offset = "0x6F85FC0", VA = "0x186F877C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class CHLLPLHOFNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public KPFIKNDEFFO operationType;

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public CHLLPLHOFNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x6F87830", Offset = "0x6F86030", VA = "0x186F87830")]
		internal object PINIKCKBLMN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class KBPCGEPADNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public KBPCGEPADNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x6F92D80", Offset = "0x6F91580", VA = "0x186F92D80")]
		internal object BNDOMKNNCBN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x6F92DF0", Offset = "0x6F915F0", VA = "0x186F92DF0")]
		internal object DOJIPMJKKMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x6F92D10", Offset = "0x6F91510", VA = "0x186F92D10")]
		internal object AHDPAEKOIDP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct ACAIJAOKMJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public AsyncTaskMethodBuilder<DGFDNIJCPMA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public EBGLDLIIJJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private KBPCGEPADNC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private ILGKIPAKNNM <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private DGFDNIJCPMA <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private TaskAwaiter<(DGFDNIJCPMA validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F8B0", Offset = "0x6F7E0B0", VA = "0x186F7F8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x6F80160", Offset = "0x6F7E960", VA = "0x186F80160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private ILFDHJAHNHI FAELELHBKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private FGAHPIAHGMI DLEEJBBLHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private LNJOHEOEPEC DCEOPNHDHAB;

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x6F888D0", Offset = "0x6F870D0", VA = "0x186F888D0", Slot = "5")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x6F88670", Offset = "0x6F86E70", VA = "0x186F88670", Slot = "4")]
	[AsyncStateMachine(typeof(CHLDPGIABKC))]
	private Task<DGFDNIJCPMA> ADIBGCJIAIH(JHHNPEBPLNM PIHNIIFANNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x6F88980", Offset = "0x6F87180", VA = "0x186F88980")]
	private bool LFAJICGJEBM(KPFIKNDEFFO LJJJHDHDDOO, [Out] DGFDNIJCPMA ADPMAHMCGNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x6F88790", Offset = "0x6F86F90", VA = "0x186F88790")]
	[AsyncStateMachine(typeof(ACAIJAOKMJD))]
	private Task<DGFDNIJCPMA> CEEGAKPAPOH(JHHNPEBPLNM GPCNCGBOPJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	public EBGLDLIIJJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class AKDLKDBIAEL : OELPCMIPAIF, DLOEDDKPHPI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private struct BNNONHLMBDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public AsyncTaskMethodBuilder<JBBIANFGILF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public AKDLKDBIAEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private TaskAwaiter<FLKIEPIEFEG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private TaskAwaiter<JBBIANFGILF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x6F82DD0", Offset = "0x6F815D0", VA = "0x186F82DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x6F833A0", Offset = "0x6F81BA0", VA = "0x186F833A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class MLMGGBGFFBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public MLMGGBGFFBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x6F996F0", Offset = "0x6F97EF0", VA = "0x186F996F0")]
		internal object HDNNMHHLIDF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct FGEGEKODOGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public AsyncTaskMethodBuilder<FLKIEPIEFEG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public AKDLKDBIAEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private MLMGGBGFFBO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private TaskAwaiter<FLKIEPIEFEG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x6F8A710", Offset = "0x6F88F10", VA = "0x186F8A710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x6F8AD00", Offset = "0x6F89500", VA = "0x186F8AD00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct HAHKDFNBKKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public AsyncTaskMethodBuilder<JBBIANFGILF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public AKDLKDBIAEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public FLKIEPIEFEG roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private TaskAwaiter<(KEOGFOOKLEH superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x6F8B9B0", Offset = "0x6F8A1B0", VA = "0x186F8B9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x6F8BE10", Offset = "0x6F8A610", VA = "0x186F8BE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class AGKHFKGBNBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public AGKHFKGBNBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x92C050", Offset = "0x92A850", VA = "0x18092C050")]
		internal bool OGJDGOKBMBE(HCDOMJKEJGM sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct HFMMKMFIOKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public AsyncTaskMethodBuilder<(KEOGFOOKLEH superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public FLKIEPIEFEG roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public AKDLKDBIAEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private TaskAwaiter<(KEOGFOOKLEH superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x6F8C4F0", Offset = "0x6F8ACF0", VA = "0x186F8C4F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x6F8CB90", Offset = "0x6F8B390", VA = "0x186F8CB90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class OLIEEAFBADB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public OLIEEAFBADB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x6F9C740", Offset = "0x6F9AF40", VA = "0x186F9C740")]
		internal object LPOINOEPNNB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct CBPACJKAOOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public AsyncTaskMethodBuilder<(KEOGFOOKLEH superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public HCDOMJKEJGM subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public AKDLKDBIAEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public MDBDBMHCDOA dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private OLIEEAFBADB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private TaskAwaiter<HNKJBJIHEKD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x6F842E0", Offset = "0x6F82AE0", VA = "0x186F842E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x6F84A10", Offset = "0x6F83210", VA = "0x186F84A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private static readonly (KEOGFOOKLEH superRoomData, long subRoomDataSaveId) OLKFKEJHBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private MFEINKDLEHJ EKMGPIDNBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private FJDMGDBCEIP LPFOAEHCDII;

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x6F80A90", Offset = "0x6F7F290", VA = "0x186F80A90", Slot = "5")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x6F80930", Offset = "0x6F7F130", VA = "0x186F80930", Slot = "4")]
	[AsyncStateMachine(typeof(BNNONHLMBDJ))]
	public Task<JBBIANFGILF> HEIELJDJGCB(OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, MDBDBMHCDOA OLIIPNAKLLA, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x6F80660", Offset = "0x6F7EE60", VA = "0x186F80660")]
	[AsyncStateMachine(typeof(FGEGEKODOGO))]
	private Task<FLKIEPIEFEG> CLMLMLFBNGB(MDBDBMHCDOA OLIIPNAKLLA, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x6F807C0", Offset = "0x6F7EFC0", VA = "0x186F807C0")]
	[AsyncStateMachine(typeof(HAHKDFNBKKJ))]
	private Task<JBBIANFGILF> CNGOKCGJIMP(MDBDBMHCDOA OLIIPNAKLLA, FLKIEPIEFEG MGNEMJNJPBC, long MMMJFAODPOA, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x6F80C90", Offset = "0x6F7F490", VA = "0x186F80C90")]
	[AsyncStateMachine(typeof(HFMMKMFIOKF))]
	private Task<(KEOGFOOKLEH, long)> KJBLKACJONI(MDBDBMHCDOA OLIIPNAKLLA, FLKIEPIEFEG MGNEMJNJPBC, long MMMJFAODPOA, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x6F80B20", Offset = "0x6F7F320", VA = "0x186F80B20")]
	[AsyncStateMachine(typeof(CBPACJKAOOO))]
	private Task<(KEOGFOOKLEH, long)> JJCPGCALCHB(MDBDBMHCDOA GJPPIGHDBDI, HCDOMJKEJGM FMOALFGMFNJ, long MMMJFAODPOA, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	public AKDLKDBIAEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[UnityEngine.Scripting.Preserve]
internal sealed class PBLPMMAAJPA : GNGDMGCCAPD, DLOEDDKPHPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class CABABMGDIDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public CABABMGDIDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x6F84280", Offset = "0x6F82A80", VA = "0x186F84280")]
		internal object HIMLPFHCLBN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct DMJEDLKGDEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public AsyncTaskMethodBuilder<JHHNPEBPLNM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public PBLPMMAAJPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public NOCKKKPBJAK pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x6F87FF0", Offset = "0x6F867F0", VA = "0x186F87FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x6F88600", Offset = "0x6F86E00", VA = "0x186F88600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct HANMNAEFEGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public AsyncTaskMethodBuilder<JHHNPEBPLNM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public PBLPMMAAJPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public NOCKKKPBJAK pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private TaskAwaiter<GLCNHMNLOKL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x6F8BE80", Offset = "0x6F8A680", VA = "0x186F8BE80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x6F8C480", Offset = "0x6F8AC80", VA = "0x186F8C480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private sealed class OKJPIDHGIGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public OKJPIDHGIGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x6F9C6E0", Offset = "0x6F9AEE0", VA = "0x186F9C6E0")]
		internal object EBNNLEOIGBC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct CGALDJOHNGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public AsyncTaskMethodBuilder<JHHNPEBPLNM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public PBLPMMAAJPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public NOCKKKPBJAK pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private NLAOPAEBMHG <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private FIPBDBKIEEE <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private TaskAwaiter<GLCNHMNLOKL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x6F86000", Offset = "0x6F84800", VA = "0x186F86000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x6F86BF0", Offset = "0x6F853F0", VA = "0x186F86BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private ILFDHJAHNHI FAELELHBKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private DKMKDMJDKAD BIOBKNDENDB;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	private AGBLOFNHMNJ CGDMKGIJFNC
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x6F9C850", Offset = "0x6F9B050", VA = "0x186F9C850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x6F9CEB0", Offset = "0x6F9B6B0", VA = "0x186F9CEB0", Slot = "8")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x6F9CB40", Offset = "0x6F9B340", VA = "0x186F9CB40", Slot = "4")]
	[AsyncStateMachine(typeof(DMJEDLKGDEI))]
	public Task<JHHNPEBPLNM> ELIGHDCDHPD(JHHNPEBPLNM GPCNCGBOPJG, NOCKKKPBJAK EECJCJLHLIP, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x6F9CF40", Offset = "0x6F9B740", VA = "0x186F9CF40", Slot = "5")]
	[AsyncStateMachine(typeof(HANMNAEFEGC))]
	public Task<JHHNPEBPLNM> NEJJKEMHNPK(CancellationToken MPLGBOFHPLM, NOCKKKPBJAK EECJCJLHLIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x6F9CCA0", Offset = "0x6F9B4A0", VA = "0x186F9CCA0", Slot = "6")]
	public AOOKNBGCDKI GCAGPDDCIGD(LDOGEOGHOLH JLCNMJIDAOM, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x6F9C910", Offset = "0x6F9B110", VA = "0x186F9C910", Slot = "7")]
	public AOOKNBGCDKI BLGCCGBNIDG(LDOGEOGHOLH JLCNMJIDAOM, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x6F9D090", Offset = "0x6F9B890", VA = "0x186F9D090")]
	[AsyncStateMachine(typeof(CGALDJOHNGG))]
	private Task<JHHNPEBPLNM> PBPMPIHGEDG(JHHNPEBPLNM GPCNCGBOPJG, NOCKKKPBJAK EECJCJLHLIP, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x31DBEA0", Offset = "0x31DA6A0", VA = "0x1831DBEA0")]
	private static byte[] GOABJGJKCCI(JHHNPEBPLNM JNNDBFGKHHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	public PBLPMMAAJPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[UnityEngine.Scripting.Preserve]
internal sealed class EFHPJLNDOMI : FGAHPIAHGMI, DLOEDDKPHPI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private NBAHHDNKILP PLDFHJDBLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private ILFDHJAHNHI FAELELHBKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	private GAGJCKDHAGD JIMBHKPDLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private GDNPJMDDBLG HGNPBLNJDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private MFEINKDLEHJ EKMGPIDNBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private FFDBLCGPPMM MCGBLNMHNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private GPMIBIFCKBJ LPINBJBANHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private KJHGHIOALEA AACIHKHGIHG;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private FFAMIDMIBLK HFPCNNCNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x6F89540", Offset = "0x6F87D40", VA = "0x186F89540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private static DGFDNIJCPMA AFLLLJEHLHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x6F879D0", Offset = "0x6F861D0", VA = "0x186F879D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x6F88F60", Offset = "0x6F87760", VA = "0x186F88F60", Slot = "6")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x6F893D0", Offset = "0x6F87BD0", VA = "0x186F893D0", Slot = "4")]
	public DGFDNIJCPMA MBKKPDMNLNB(LCMANADAOPN KNKLAKPFAOI, KPFIKNDEFFO OFNDKLGKJDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x6F890D0", Offset = "0x6F878D0", VA = "0x186F890D0", Slot = "5")]
	public DGFDNIJCPMA IKOPFOCCMFH(LCMANADAOPN NACPIIAAOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x6F87A30", Offset = "0x6F86230", VA = "0x186F87A30")]
	private static DGFDNIJCPMA LGFAHEEJNOP(IOJDCLBFPMF NPGFMGMHJJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	public EFHPJLNDOMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class MMECDHDBMIH : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x6F997A0", Offset = "0x6F97FA0", VA = "0x186F997A0")]
	public MMECDHDBMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x64136C0", Offset = "0x6411EC0", VA = "0x1864136C0")]
	public MMECDHDBMIH(string JNNDBFGKHHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[UnityEngine.Scripting.Preserve]
internal sealed class KNEPLNMCHOB : EMPCKPBJDBG, DLOEDDKPHPI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct MGJOLEKJICM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public AsyncTaskMethodBuilder<DGFDNIJCPMA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public KNEPLNMCHOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public NCKGPLMHNNB autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private OADONCMLPJG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private OADONCMLPJG<string>.HILOONJJDHL <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private OCGMAIALJEA <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private TaskAwaiter<DGFDNIJCPMA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x6F98520", Offset = "0x6F96D20", VA = "0x186F98520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x6F990A0", Offset = "0x6F978A0", VA = "0x186F990A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct KKDEDEIKJBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public KNEPLNMCHOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x6F92EA0", Offset = "0x6F916A0", VA = "0x186F92EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x6F935F0", Offset = "0x6F91DF0", VA = "0x186F935F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct NOMHJOPBDOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public KNEPLNMCHOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x6F9B2E0", Offset = "0x6F99AE0", VA = "0x186F9B2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x6F9B7F0", Offset = "0x6F99FF0", VA = "0x186F9B7F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct LKDKPEPCDNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public KNEPLNMCHOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x6F94D40", Offset = "0x6F93540", VA = "0x186F94D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x6F95490", Offset = "0x6F93C90", VA = "0x186F95490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct LJEOLNGJFDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public KNEPLNMCHOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x6F94880", Offset = "0x6F93080", VA = "0x186F94880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x6F94A20", Offset = "0x6F93220", VA = "0x186F94A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct BKPHKDFGKEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public KNEPLNMCHOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x6F82650", Offset = "0x6F80E50", VA = "0x186F82650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x6F82D70", Offset = "0x6F81570", VA = "0x186F82D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct CGNINGFKIPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public KNEPLNMCHOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x6F86C60", Offset = "0x6F85460", VA = "0x186F86C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x6F870D0", Offset = "0x6F858D0", VA = "0x186F870D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct JKHPIJOHMOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public KNEPLNMCHOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public HCEEFOPOCMM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private OADONCMLPJG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x6F921D0", Offset = "0x6F909D0", VA = "0x186F921D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x6F92730", Offset = "0x6F90F30", VA = "0x186F92730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private ILFDHJAHNHI FAELELHBKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private MFEINKDLEHJ EKMGPIDNBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private GNGDMGCCAPD ELAJIBPEDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private GAGJCKDHAGD JIMBHKPDLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private GPMIBIFCKBJ LPINBJBANHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private CancellationTokenSource GLAECGNFBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private Task HBOAIMOJKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private TaskCompletionSource<int> CHKFKKHGIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private int JMGPACPBHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private int ABBDGPKNACJ;

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x6F93C10", Offset = "0x6F92410", VA = "0x186F93C10", Slot = "6")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0xA738F0", Offset = "0xA720F0", VA = "0x180A738F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x6F93FE0", Offset = "0x6F927E0", VA = "0x186F93FE0")]
	private void KENOGMLIIJC(float EODHKDJNLAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x6F93EB0", Offset = "0x6F926B0", VA = "0x186F93EB0", Slot = "4")]
	[AsyncStateMachine(typeof(MGJOLEKJICM))]
	public Task<DGFDNIJCPMA> JFAEBIMIGEM(NCKGPLMHNNB HEEEABJCCCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x6F940C0", Offset = "0x6F928C0", VA = "0x186F940C0", Slot = "5")]
	[AsyncStateMachine(typeof(KKDEDEIKJBL))]
	public Task LCOGCHLMALM([Optional] CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0xA738F0", Offset = "0xA720F0", VA = "0x180A738F0")]
	public void CNPJEKFBNHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x6F938B0", Offset = "0x6F920B0", VA = "0x186F938B0")]
	private OCGMAIALJEA DKEKHADIABB(NCKGPLMHNNB HEEEABJCCCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x6F93DC0", Offset = "0x6F925C0", VA = "0x186F93DC0")]
	[AsyncStateMachine(typeof(NOMHJOPBDOP))]
	private Task IDFCJDCFLLA(CancellationToken LJPECIOGMKH, int IDCPOPPPDDB, JLMLCKPCLMI ONEPKIAFHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x6F93A20", Offset = "0x6F92220", VA = "0x186F93A20")]
	[AsyncStateMachine(typeof(LKDKPEPCDNM))]
	private Task EAMHJPAFKAH(CancellationToken LJPECIOGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x6F942C0", Offset = "0x6F92AC0", VA = "0x186F942C0")]
	[AsyncStateMachine(typeof(LJEOLNGJFDF))]
	private Task LLONGBMBIFH([Optional] CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x6F93B20", Offset = "0x6F92320", VA = "0x186F93B20")]
	[AsyncStateMachine(typeof(BKPHKDFGKEN))]
	private Task FEGEFKCOLBK(CancellationToken LJPECIOGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x6F943B0", Offset = "0x6F92BB0", VA = "0x186F943B0")]
	[AsyncStateMachine(typeof(CGNINGFKIPB))]
	private Task NOBGFDFOJPB(CancellationToken LHIBLAEHAHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x6F944B0", Offset = "0x6F92CB0", VA = "0x186F944B0")]
	private Task PIAALHKKFCK(HCEEFOPOCMM LKIPKDFOIKO, CancellationToken LJPECIOGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x6F941B0", Offset = "0x6F929B0", VA = "0x186F941B0")]
	[AsyncStateMachine(typeof(JKHPIJOHMOC))]
	private Task LEDAEHMICIM(HCEEFOPOCMM LKIPKDFOIKO, CancellationToken LJPECIOGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x6F93650", Offset = "0x6F91E50", VA = "0x186F93650")]
	private bool DJPMKICBDLN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	public KNEPLNMCHOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[UnityEngine.Scripting.Preserve]
internal class KBJCNLMGEBN : GDNPJMDDBLG, DLOEDDKPHPI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private struct FMNELMMCLGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public KBJCNLMGEBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private OADONCMLPJG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x6F8AD70", Offset = "0x6F89570", VA = "0x186F8AD70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x6F8B2D0", Offset = "0x6F89AD0", VA = "0x186F8B2D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private OMKEILKNJFC NPKMKLLOPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	private FGAHPIAHGMI DLEEJBBLHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private GNGDMGCCAPD ELAJIBPEDAA;

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x6F92940", Offset = "0x6F91140", VA = "0x186F92940", Slot = "6")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x6F928F0", Offset = "0x6F910F0", VA = "0x186F928F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x6F92790", Offset = "0x6F90F90", VA = "0x186F92790", Slot = "5")]
	[AsyncStateMachine(typeof(FMNELMMCLGK))]
	public Task CEOGFJOOFNG(string BECGFNBELMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x6F92890", Offset = "0x6F91090", VA = "0x186F92890", Slot = "4")]
	public DGFDNIJCPMA DJPMKICBDLN(LCMANADAOPN KNKLAKPFAOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x6F92C20", Offset = "0x6F91420", VA = "0x186F92C20")]
	private JKIDNJAJEEP MAPPHJOCDOK(string BECGFNBELMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	public KBJCNLMGEBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public static class OHKFAKLBMEA
{
	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x6F9BDA0", Offset = "0x6F9A5A0", VA = "0x186F9BDA0")]
	public static void CMAHDMNADIP(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x6F9BFE0", Offset = "0x6F9A7E0", VA = "0x186F9BFE0")]
	internal static void FIJMHCAIMNB(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x6F9C590", Offset = "0x6F9AD90", VA = "0x186F9C590")]
	internal static void MGOKHOADIFP(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x6F9C140", Offset = "0x6F9A940", VA = "0x186F9C140")]
	internal static void LBCHCNDODIN(INCIOHANCNE PGHIDIKDPNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal class IJCKLOFHIFP : GPMENIDAHFH<JHHNPEBPLNM>
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class IKECNMIPAJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public JHHNPEBPLNM message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public IKECNMIPAJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x6F8F800", Offset = "0x6F8E000", VA = "0x186F8F800")]
		internal object BJKIKAPFGMG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly IJCKLOFHIFP MJFJCBEEADM;

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x6F8F560", Offset = "0x6F8DD60", VA = "0x186F8F560")]
	public ExitGames.Client.Photon.Hashtable OPCGAJMHMBL(JHHNPEBPLNM JNNDBFGKHHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x6F8F5F0", Offset = "0x6F8DDF0", VA = "0x186F8F5F0", Slot = "5")]
	protected override void PDCANANKNJH(JHHNPEBPLNM JNNDBFGKHHD, IDictionary<object, object> LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EF70", Offset = "0x6F8D770", VA = "0x186F8EF70", Slot = "6")]
	public override JHHNPEBPLNM DGBBAPGEGII(IDictionary<object, object> LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x6F8F1A0", Offset = "0x6F8D9A0", VA = "0x186F8F1A0")]
	private static void MGFMJHPPHBP(string MFIDPDMAIND, JHHNPEBPLNM JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x6F8F7C0", Offset = "0x6F8DFC0", VA = "0x186F8F7C0")]
	public IJCKLOFHIFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x6F8F2B0", Offset = "0x6F8DAB0", VA = "0x186F8F2B0")]
	[CompilerGenerated]
	internal static string NJPGLJCLIKP(JBBIANFGILF MIJPDJDOIDB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public static class DEPHGOGNEHH
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public static DGFDNIJCPMA AFLLLJEHLHL
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x6F879D0", Offset = "0x6F861D0", VA = "0x186F879D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x6F87EF0", Offset = "0x6F866F0", VA = "0x186F87EF0")]
	public static bool MMMIIKFLHMB(this DGFDNIJCPMA OMMIFMPIFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x6F87A30", Offset = "0x6F86230", VA = "0x186F87A30")]
	public static DGFDNIJCPMA LGFAHEEJNOP(IOJDCLBFPMF MNCJHJGEMJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x6F87A90", Offset = "0x6F86290", VA = "0x186F87A90")]
	public static DGFDNIJCPMA LKFNKJCJHNP(IEnumerable<DGFDNIJCPMA> HLKJLHJANAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F87C90", Offset = "0x6F86490", VA = "0x186F87C90")]
	public static string MJBMDIPJMML(this DGFDNIJCPMA ADPMAHMCGNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public abstract class LLOFDCKBGNA : ABNHEGMNLPH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public delegate DGFDNIJCPMA PHLOHJMEDAC([NotNull] LCMANADAOPN FJJHEJLNNIM);

	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private sealed class HLIHCIEBPPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public LCMANADAOPN photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public HLIHCIEBPPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x6638C70", Offset = "0x6637470", VA = "0x186638C70")]
		internal DGFDNIJCPMA GMNCIGHMOFL(PHLOHJMEDAC v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private bool LOOMHHLOKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	protected readonly HashSet<PHLOHJMEDAC> DCCNPGLMPDA;

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x6F95600", Offset = "0x6F93E00", VA = "0x186F95600", Slot = "4")]
	public void ICOAKFCEEGG(PHLOHJMEDAC MALFIDMAHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x6F955A0", Offset = "0x6F93DA0", VA = "0x186F955A0", Slot = "5")]
	public void GCDCOOGHCJC(PHLOHJMEDAC MALFIDMAHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x6F95550", Offset = "0x6F93D50", VA = "0x186F95550", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x6F95660", Offset = "0x6F93E60", VA = "0x186F95660")]
	protected DGFDNIJCPMA KPBLPCLNAJN(LCMANADAOPN NACPIIAAOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F95900", Offset = "0x6F94100", VA = "0x186F95900")]
	protected LLOFDCKBGNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class ICGKEGKACAG : LLOFDCKBGNA, NBAHHDNKILP, ABNHEGMNLPH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private sealed class OBNKKPFDFHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public DGFDNIJCPMA result;

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public OBNKKPFDFHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x6F9BBA0", Offset = "0x6F9A3A0", VA = "0x186F9BBA0")]
		internal object NOLMMJAHICD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x6F8A680", Offset = "0x6F88E80", VA = "0x186F8A680")]
	[UnityEngine.Scripting.Preserve]
	public ICGKEGKACAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D6C0", Offset = "0x6F8BEC0", VA = "0x186F8D6C0", Slot = "8")]
	public DGFDNIJCPMA AAHGJHLKCBO(LCMANADAOPN NACPIIAAOMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class FEEGGDIGHPP : LLOFDCKBGNA, OMKEILKNJFC, ABNHEGMNLPH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private sealed class PBHCDHBJPCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public DGFDNIJCPMA result;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public PBHCDHBJPCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x6F9C7F0", Offset = "0x6F9AFF0", VA = "0x186F9C7F0")]
		internal object FFAPHNLCABO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F8A680", Offset = "0x6F88E80", VA = "0x186F8A680")]
	[UnityEngine.Scripting.Preserve]
	public FEEGGDIGHPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F8A570", Offset = "0x6F88D70", VA = "0x186F8A570", Slot = "8")]
	public DGFDNIJCPMA DJPMKICBDLN(LCMANADAOPN GFABMNOLKLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal static class MCIALNAKIJI
{
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private sealed class PLCJONIAFOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public OADONCMLPJG<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public PLCJONIAFOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x6F9DF10", Offset = "0x6F9C710", VA = "0x186F9DF10")]
		internal object NMHFIGPLJJC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x6F962B0", Offset = "0x6F94AB0", VA = "0x186F962B0")]
	public static OADONCMLPJG<string> ADOMOAHOKMN(CDLNJDLNIPA KBNCOADBJAI, [Optional] string NELDGGFCGBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x6F96450", Offset = "0x6F94C50", VA = "0x186F96450")]
	public static void PAINIEOMMIF(OADONCMLPJG<string> GFNLGFOFJFM, CDLNJDLNIPA KBNCOADBJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x6F96390", Offset = "0x6F94B90", VA = "0x186F96390")]
	public static string BEINGEOEJIE(JHHNPEBPLNM PIHNIIFANNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal static class OCAJHOCDPLC
{
	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6F9BC00", Offset = "0x6F9A400", VA = "0x186F9BC00")]
	public static void IOKJHAALHMO(this ILFDHJAHNHI FAELELHBKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x6F9BD30", Offset = "0x6F9A530", VA = "0x186F9BD30")]
	public static void ONKCLFPAGNJ(this ILFDHJAHNHI FAELELHBKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x6F9BC10", Offset = "0x6F9A410", VA = "0x186F9BC10")]
	private static void OGCAIFHMACF(this ILFDHJAHNHI FAELELHBKKO, bool PPIBKPHJPDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public class MJCLPMIECAL : LHBACLGNGEP, IIGABFJMEDH, NCHALEHKFGO, GCDIDGMHHIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000317")]
	private readonly IIGABFJMEDH KNBEMFOOBEO;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public LCMANADAOPN BNIDNLLDGDI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x6F99180", Offset = "0x6F97980", VA = "0x186F99180", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public int NLIMGMDJKMB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x6F99420", Offset = "0x6F97C20", VA = "0x186F99420", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public int KEIOJNKNJMA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x6F996A0", Offset = "0x6F97EA0", VA = "0x186F996A0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool KFNLGFNJAKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x86D5A0", Offset = "0x86BDA0", VA = "0x18086D5A0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public int FHAMDDJKDHM
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x8C3EC0", Offset = "0x8C26C0", VA = "0x1808C3EC0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event GBFIPMEOIEO.IIICGAPIKPN FDGMLHJPMCC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event EMPLKCIGFHB FAAGLMBMKBP
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x6F99380", Offset = "0x6F97B80", VA = "0x186F99380", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x6F991D0", Offset = "0x6F979D0", VA = "0x186F991D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> ALIFLIBGFBI
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<LCMANADAOPN> FCAFMIJALDC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action JPCOBLHHKLB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x6F99600", Offset = "0x6F97E00", VA = "0x186F99600", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x6F992E0", Offset = "0x6F97AE0", VA = "0x186F992E0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0xCAAAD0", Offset = "0xCA92D0", VA = "0x180CAAAD0")]
	public MJCLPMIECAL(IIGABFJMEDH KNBEMFOOBEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x6F99470", Offset = "0x6F97C70", VA = "0x186F99470", Slot = "8")]
	public bool LLGBFLNNPKP(byte IEEHAPDEHNL, ExitGames.Client.Photon.Hashtable HLPJEBAFCEI, KGBEHAIDAFK HNCFNOCLOFC, SendOptions PNIFNNMGDFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x6F99520", Offset = "0x6F97D20", VA = "0x186F99520", Slot = "16")]
	public LCMANADAOPN MCNNANDHEGF(int LKMOKKELGIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "19")]
	public void CCHHCCMEFDH(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "20")]
	public void NCLNJAFLICJ(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "21")]
	public void IFLIFIEEPEH(object EOCJCEFCOOA, bool HNBFKCCDJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x6F99270", Offset = "0x6F97A70", VA = "0x186F99270", Slot = "22")]
	public IDisposable JAMBAJOBMOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x8999F0", VA = "0x18089B1F0", Slot = "23")]
	private bool MOFFPJGMBLD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "24")]
	public void BGDDHBNJMCK(StringBuilder EBMHMAKKCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x6F992C0", Offset = "0x6F97AC0", VA = "0x186F992C0", Slot = "25")]
	public bool JPOBOCAEGBK(bool DCHKPIILKAF, [Out] string GGEHLADLJHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x978400", Offset = "0x976C00", VA = "0x180978400", Slot = "28")]
	public void LJEEHGIHICP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal struct NDIHCAFDEOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000319")]
	private readonly IDictionary<object, object> BGEDEFLEFII;

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x926780", Offset = "0x924F80", VA = "0x180926780")]
	public NDIHCAFDEOE(IDictionary<object, object> BGEDEFLEFII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x6F9AAB0", Offset = "0x6F992B0", VA = "0x186F9AAB0")]
	public bool LEOKLOLLEBG([Out] JHHNPEBPLNM JNNDBFGKHHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x6F9ACA0", Offset = "0x6F994A0", VA = "0x186F9ACA0")]
	public Guid NFINFGAHIFN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F9AB60", Offset = "0x6F99360", VA = "0x186F9AB60")]
	public DGFDNIJCPMA MHDDMELJGMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F9A9C0", Offset = "0x6F991C0", VA = "0x186F9A9C0")]
	public static ExitGames.Client.Photon.Hashtable JGIIBNEOBDO(JHHNPEBPLNM JNNDBFGKHHD, DGFDNIJCPMA OMMIFMPIFCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal static class AIGNFIKLEED
{
	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F805E0", Offset = "0x6F7EDE0", VA = "0x186F805E0")]
	public static bool OHHEIKNGFFN(this MDBDBMHCDOA AKLKCJCNCJP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal struct LJJNFBNGNFA : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct KNKBDKPEAAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public LJJNFBNGNFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x6F94640", Offset = "0x6F92E40", VA = "0x186F94640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x6F94820", Offset = "0x6F93020", VA = "0x186F94820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	private readonly CancellationTokenSource NPCICLIMLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	private bool LOOMHHLOKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	private Task LEDCCMOCHJB;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool OONANGMADII
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x6F94A80", Offset = "0x6F93280", VA = "0x186F94A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x6F94C10", Offset = "0x6F93410", VA = "0x186F94C10")]
	public LJJNFBNGNFA(CancellationToken MPLGBOFHPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x6F94B00", Offset = "0x6F93300", VA = "0x186F94B00")]
	[AsyncStateMachine(typeof(KNKBDKPEAAF))]
	public Task GKDNMPIMODG(Func<CancellationToken, List<Task>> FCCDOIIADHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x6F94AB0", Offset = "0x6F932B0", VA = "0x186F94AB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public readonly struct PFLNKKCOAHI<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct MBFHGOOPFGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public AsyncTaskMethodBuilder<CIKECDEKJAI<MOGOEHIGGGP<TData>, EGADAFAJMEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public PFLNKKCOAHI<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private TaskAwaiter<CIKECDEKJAI<MOGOEHIGGGP<TData>, EGADAFAJMEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x4469360", Offset = "0x4467B60", VA = "0x184469360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x3806840", Offset = "0x3805040", VA = "0x183806840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	private readonly AJPKAMNMEFA<TGetDataArg, TData> NMBACBFNMGF;

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x926780", Offset = "0x924F80", VA = "0x180926780")]
	internal PFLNKKCOAHI(AJPKAMNMEFA<TGetDataArg, TData> HDLOJHGAFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x4761380", Offset = "0x475FB80", VA = "0x184761380")]
	[AsyncStateMachine(typeof(PFLNKKCOAHI<, >.MBFHGOOPFGO))]
	public Task<CIKECDEKJAI<MOGOEHIGGGP<TData>, EGADAFAJMEN>> HEJLCMFPFKH(TGetDataArg BGLHKLFFJEP, string GCBBANDJGBO, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public static class CLFHENNBCPM
{
	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x259D370", Offset = "0x259BB70", VA = "0x18259D370")]
	public static PFLNKKCOAHI<TGetDataArg, TData> FJAAFKPDAIA<TGetDataArg, TData>(AJPKAMNMEFA<TGetDataArg, TData> HDLOJHGAFKF)
	{
		return default(PFLNKKCOAHI<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public struct DMFAPLFEJDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public readonly int IDKDFLHMDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public readonly int? JFHBOLOLMPM;

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x4221770", Offset = "0x421FF70", VA = "0x184221770")]
	public DMFAPLFEJDL(int DMNHBMODOKL, [Optional] int? GCKKBDHCMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F87F10", Offset = "0x6F86710", VA = "0x186F87F10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public interface GELBFHCOJFD<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OINJEINMHLK();

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GELBFHCOJFD<T> CLBDCAFDKCH(string MCMGPBCLOFD);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GELBFHCOJFD<T> KDEBJKOOMCC(JDBCODNMCIB<T> LCPNIJPJAFM);

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GELBFHCOJFD<T> NLHHLJDJCBO(int LBJMNCMBNEA);

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GELBFHCOJFD<T> IJKKFEMOKBM(int LBJMNCMBNEA, AEDEDFOFFNI<T> NOBJBDLNLFJ);
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public interface GDBDKOPOCLO
{
	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GELBFHCOJFD<T> PNCFFJHHHNH<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LMAFCMMDBNJ EJIBLCEFOHJ(Exception PBAHBFAICPK);

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DMFAPLFEJDL LKHKMCHILPP(Exception PBAHBFAICPK);
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public delegate string JDBCODNMCIB<in T>(T PBAHBFAICPK) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public delegate int AEDEDFOFFNI<in T>(T PBAHBFAICPK) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000E3")]
internal class IHBKKNBOOHI : GDBDKOPOCLO
{
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	private delegate string IBHPDOJEFBA(Exception PBAHBFAICPK);

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private delegate int KGDFGPEJPLO(Exception PBAHBFAICPK);

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private class CFDPBBOJKIG<T> : GELBFHCOJFD<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[CompilerGenerated]
		private sealed class MPPKJNJLOMC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x600041C")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
			public MPPKJNJLOMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851900", VA = "0x180853100")]
			internal string LAMJBFGBOOA(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		[CompilerGenerated]
		private sealed class GFLEGAPCNMG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			public JDBCODNMCIB<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
			public GFLEGAPCNMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x3CB3C60", Offset = "0x3CB2460", VA = "0x183CB3C60")]
			internal string OCKDINJPOBB(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		[CompilerGenerated]
		private sealed class CBBBBKGMMHJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public AEDEDFOFFNI<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
			public CBBBBKGMMHJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x3CB3C60", Offset = "0x3CB2460", VA = "0x183CB3C60")]
			internal int AHKCBDHMIOL(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private readonly IHBKKNBOOHI CLJOHLGPPOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private readonly Type IMEKHFCCHIC;

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x5105EA0", Offset = "0x51046A0", VA = "0x185105EA0")]
		internal CFDPBBOJKIG(IHBKKNBOOHI CLJOHLGPPOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x5105E70", Offset = "0x5104670", VA = "0x185105E70", Slot = "4")]
		public void OINJEINMHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x5105AC0", Offset = "0x51042C0", VA = "0x185105AC0", Slot = "5")]
		public GELBFHCOJFD<T> CLBDCAFDKCH(string MCMGPBCLOFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x5105D10", Offset = "0x5104510", VA = "0x185105D10", Slot = "6")]
		public GELBFHCOJFD<T> KDEBJKOOMCC(JDBCODNMCIB<T> LCPNIJPJAFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x5105E30", Offset = "0x5104630", VA = "0x185105E30", Slot = "7")]
		public GELBFHCOJFD<T> NLHHLJDJCBO(int LBJMNCMBNEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x5105BE0", Offset = "0x51043E0", VA = "0x185105BE0", Slot = "8")]
		public GELBFHCOJFD<T> IJKKFEMOKBM(int LBJMNCMBNEA, AEDEDFOFFNI<T> NOBJBDLNLFJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	private class KOEBFDPLEJD<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		private bool FFOHEMPBHFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private readonly List<Type> NGEAFLHHKLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private readonly Dictionary<Type, TVal> OAHIBPPNLJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private readonly Dictionary<Type, int> IDPHGIDLAFM;

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public IReadOnlyList<Type> KMDBOACGJPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x41B8520", Offset = "0x41B6D20", VA = "0x1841B8520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x41B8A40", Offset = "0x41B7240", VA = "0x1841B8A40")]
		public KOEBFDPLEJD(Dictionary<Type, int> IDPHGIDLAFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x41B8870", Offset = "0x41B7070", VA = "0x1841B8870")]
		public void PBLNBBGFGAP(Type NDDCLPHCEEO, TVal GPBAFILNEOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x41B8480", Offset = "0x41B6C80", VA = "0x1841B8480")]
		public bool BPELFEMFLPO(Type IMEKHFCCHIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x41B84D0", Offset = "0x41B6CD0", VA = "0x1841B84D0")]
		public bool ODHBLCILLBD(TVal JMDCGOKJIDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x3804220", Offset = "0x3802A20", VA = "0x183804220")]
		public TVal JMJOGDIBBHK(Type NCMHJNKFAGH)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x41B8680", Offset = "0x41B6E80", VA = "0x1841B8680")]
		[CompilerGenerated]
		private int OLMIAFCMCLO(Type ICMIAHJCIFL, Type DCOLGEOFAJF)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private sealed class LPDINAJEIDJ : IEnumerable<DMFAPLFEJDL>, IEnumerable, IEnumerator<DMFAPLFEJDL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private DMFAPLFEJDL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public IHBKKNBOOHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private IEnumerator<DMFAPLFEJDL> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		private DMFAPLFEJDL System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0x385AEF0", Offset = "0x38596F0", VA = "0x18385AEF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(DMFAPLFEJDL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0x6F96110", Offset = "0x6F94910", VA = "0x186F96110", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x89FD00", Offset = "0x89E500", VA = "0x18089FD00")]
		[DebuggerHidden]
		public LPDINAJEIDJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x6F96160", Offset = "0x6F94960", VA = "0x186F96160", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x6F95B50", Offset = "0x6F94350", VA = "0x186F95B50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x6F95AB0", Offset = "0x6F942B0", VA = "0x186F95AB0")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x6F95B00", Offset = "0x6F94300", VA = "0x186F95B00")]
		private void KNPOGHPBEEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x6F960C0", Offset = "0x6F948C0", VA = "0x186F960C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x6F96000", Offset = "0x6F94800", VA = "0x186F96000", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DMFAPLFEJDL> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x6F96000", Offset = "0x6F94800", VA = "0x186F96000", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private static readonly DMFAPLFEJDL APAMOKNFMBP;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private static readonly Dictionary<Type, int> PGDMJOGFKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private readonly HashSet<Type> FJJOEDGBJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private readonly KOEBFDPLEJD<int> AHFAEBADILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private readonly KOEBFDPLEJD<KGDFGPEJPLO> NOHDKOFPDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private readonly KOEBFDPLEJD<IBHPDOJEFBA> LDONPMDMNCJ;

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DEB0", Offset = "0x6F8C6B0", VA = "0x186F8DEB0")]
	[GDGALFJPCGE(JMIPDAHBNNG.GameOnly)]
	private static void ECBJKBNABGH(INCIOHANCNE LDLMDJOAIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EBD0", Offset = "0x6F8D3D0", VA = "0x186F8EBD0")]
	[RecRoom.NoEngine.Common.Preserve]
	public IHBKKNBOOHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x2B5FF50", Offset = "0x2B5E750", VA = "0x182B5FF50", Slot = "4")]
	public GELBFHCOJFD<T> PNCFFJHHHNH<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DF20", Offset = "0x6F8C720", VA = "0x186F8DF20", Slot = "5")]
	public LMAFCMMDBNJ EJIBLCEFOHJ(Exception PBAHBFAICPK)
	{
		return default(LMAFCMMDBNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E820", Offset = "0x6F8D020", VA = "0x186F8E820", Slot = "6")]
	public DMFAPLFEJDL LKHKMCHILPP(Exception? PBAHBFAICPK)
	{
		return default(DMFAPLFEJDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E780", Offset = "0x6F8CF80", VA = "0x186F8E780", Slot = "7")]
	[IteratorStateMachine(typeof(LPDINAJEIDJ))]
	public IEnumerable<DMFAPLFEJDL> KBJJLCOLOEN(Exception PBAHBFAICPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E630", Offset = "0x6F8CE30", VA = "0x186F8E630", Slot = "8")]
	public string JOIGGINBEEN(Exception? PBAHBFAICPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D7D0", Offset = "0x6F8BFD0", VA = "0x186F8D7D0")]
	private string CNHALHKGOCF(AggregateException LOEKHCMHBEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DFB0", Offset = "0x6F8C7B0", VA = "0x186F8DFB0")]
	private void IHEDAKLCGNP(Type IMEKHFCCHIC, int LBJMNCMBNEA, KGDFGPEJPLO? OFELHHJPODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DC60", Offset = "0x6F8C460", VA = "0x186F8DC60")]
	private void DMILLEEEOCG(Type IMEKHFCCHIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E360", Offset = "0x6F8CB60", VA = "0x186F8E360")]
	private void ILLEOJDGNAJ(Type IMEKHFCCHIC, IBHPDOJEFBA OEGEKJOGIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DAE0", Offset = "0x6F8C2E0", VA = "0x186F8DAE0")]
	private static int DALIPMEINOJ(Type IMEKHFCCHIC, Dictionary<Type, int> IDPHGIDLAFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x2B83C80", Offset = "0x2B82480", VA = "0x182B83C80")]
	private static bool AKKNKPDDGNK<TVal>(KOEBFDPLEJD<TVal> MNHECFLLMJH, Type IMEKHFCCHIC, [Out] TVal JMDCGOKJIDA) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EA20", Offset = "0x6F8D220", VA = "0x186F8EA20")]
	[CompilerGenerated]
	internal static int OICKKDMJBOP(Type GMOCFLKKALG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public struct LMAFCMMDBNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public readonly DMFAPLFEJDL CAEPJNKNMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public readonly string JCDCACKMBMN;

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x6F95A30", Offset = "0x6F94230", VA = "0x186F95A30")]
	public LMAFCMMDBNJ(string KMIMCLPDKGD, DMFAPLFEJDL LBJMNCMBNEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x6F95990", Offset = "0x6F94190", VA = "0x186F95990")]
	public string HGKGFJHHKFM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class BOAMHEKDIOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private readonly ACFAMDNJIMF HOFJLGDPOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private string IHALHOEJCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private long? JKAIGOMEDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private long? GDGAGLKACJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private long? MMKGMIIENIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private string FCNEGMPAAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private BAEGFPFJEKP DDIJAKOKPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private long? CDPILCBBCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private bool IBOMEKKHAFM;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public string ALLCOBLMNJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public long HOBGBCGFHFI
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x6F841E0", Offset = "0x6F829E0", VA = "0x186F841E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public long JGPHNMFFODD
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x6F84140", Offset = "0x6F82940", VA = "0x186F84140")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public long KKBFFPMLMEA
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x6F83B30", Offset = "0x6F82330", VA = "0x186F83B30")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public string AAIIPJLPFIF
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x6F841A0", Offset = "0x6F829A0", VA = "0x186F841A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public BAEGFPFJEKP JHHDEGHBEOG
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0xA61CC0", Offset = "0xA604C0", VA = "0x180A61CC0")]
		get
		{
			return default(BAEGFPFJEKP);
		}
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x6F83410", Offset = "0x6F81C10", VA = "0x186F83410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public long DJJKHHEPNFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x6F83750", Offset = "0x6F81F50", VA = "0x186F83750")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x6F84240", Offset = "0x6F82A40", VA = "0x186F84240")]
	[UnityEngine.Scripting.Preserve]
	public BOAMHEKDIOK([OMAPKKAGFIL(null)] ACFAMDNJIMF HOFJLGDPOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x6F83500", Offset = "0x6F81D00", VA = "0x186F83500")]
	private void DADNIIDGHDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x6F83CB0", Offset = "0x6F824B0", VA = "0x186F83CB0")]
	public void HNFDEIEALJH(long DIMOGDCMBFM, long MMMJFAODPOA, [Optional] long? LMGCMDBJBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x6F83B90", Offset = "0x6F82390", VA = "0x186F83B90")]
	public void GANGAAPLNMJ(long LMGCMDBJBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x6F83C30", Offset = "0x6F82430", VA = "0x186F83C30")]
	public void HEMIGHIOIDD(string KNBLDALGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x6F837B0", Offset = "0x6F81FB0", VA = "0x186F837B0")]
	public void EMEODMKFKLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
internal class AOOKNBGCDKI : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct INNEMEINFPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public AsyncTaskMethodBuilder<JHHNPEBPLNM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public JHHNPEBPLNM roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public AOOKNBGCDKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private TaskAwaiter<AGBLOFNHMNJ.CBEFFACDNLD<JHHNPEBPLNM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x6FAA7B0", Offset = "0x6FA8FB0", VA = "0x186FAA7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x6FAABB0", Offset = "0x6FA93B0", VA = "0x186FAABB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct HEMCMJGMBBI<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class BMODCBKEGML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public JHHNPEBPLNM roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public BMODCBKEGML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EF10", Offset = "0x6F9D710", VA = "0x186F9EF10")]
		internal JHHNPEBPLNM JLHKBOHBBEM(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct HGDBNNCOFFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public AsyncTaskMethodBuilder<AGBLOFNHMNJ.CBEFFACDNLD<JHHNPEBPLNM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public JHHNPEBPLNM roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public AOOKNBGCDKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private NLAOPAEBMHG <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private TaskAwaiter<AGBLOFNHMNJ.CBEFFACDNLD<JHHNPEBPLNM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x6FA8810", Offset = "0x6FA7010", VA = "0x186FA8810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x6FA8E20", Offset = "0x6FA7620", VA = "0x186FA8E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct AODMDECPDFP<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public AOOKNBGCDKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x3C8A5F0", Offset = "0x3C88DF0", VA = "0x183C8A5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x356F050", Offset = "0x356D850", VA = "0x18356F050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct CBECGODNOOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public AOOKNBGCDKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EFF0", Offset = "0x6F9D7F0", VA = "0x186F9EFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x6F9F1B0", Offset = "0x6F9D9B0", VA = "0x186F9F1B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class CPDJCELNHOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public CPDJCELNHOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x6FA1A00", Offset = "0x6FA0200", VA = "0x186FA1A00")]
		internal object PKEABFDGAOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x6FA1940", Offset = "0x6FA0140", VA = "0x186FA1940")]
		internal bool EECPBKJBDOH(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class BBGEFFFEFOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public BBGEFFFEFOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EEB0", Offset = "0x6F9D6B0", VA = "0x186F9EEB0")]
		internal object OKIMCFHPLMP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class GHHOMEAANDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public GHHOMEAANDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x6FA65A0", Offset = "0x6FA4DA0", VA = "0x186FA65A0")]
		internal object NAHJOGDNKBJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class PCPBAOOGHNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public PCPBAOOGHNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x6FB4C70", Offset = "0x6FB3470", VA = "0x186FB4C70")]
		internal object FEDIIEINHFM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class KPHLNIHJFCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public AOOKNBGCDKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public KPHLNIHJFCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB710", Offset = "0x6FA9F10", VA = "0x186FAB710")]
		internal object BJKIKAPFGMG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private static readonly Guid BEKJIAKMEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public readonly LDOGEOGHOLH PCEFFCPFNFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private readonly AGBLOFNHMNJ IMDHKLFLDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private readonly NCHALEHKFGO FAELELHBKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private readonly GCDIDGMHHIJ AKOFEJNHKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private bool AEJLHEPPBCK;

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x6F823C0", Offset = "0x6F80BC0", VA = "0x186F823C0")]
	public AOOKNBGCDKI(LDOGEOGHOLH PADMFCNKGOL, AGBLOFNHMNJ IMDHKLFLDMB, NCHALEHKFGO FAELELHBKKO, GCDIDGMHHIJ AKOFEJNHKBC, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x6F81500", Offset = "0x6F7FD00", VA = "0x186F81500", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x6F81500", Offset = "0x6F7FD00", VA = "0x186F81500")]
	public void AJOKGMMPOJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x6F81BC0", Offset = "0x6F803C0", VA = "0x186F81BC0")]
	public void JCEFFGDJBNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x6F81C80", Offset = "0x6F80480", VA = "0x186F81C80")]
	public void MAOAFACFAFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x6F816A0", Offset = "0x6F7FEA0", VA = "0x186F816A0")]
	[AsyncStateMachine(typeof(INNEMEINFPB))]
	internal Task<JHHNPEBPLNM> HCJJGKLKHFP(OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, JHHNPEBPLNM PIHNIIFANNM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x31DBEA0", Offset = "0x31DA6A0", VA = "0x1831DBEA0")]
	private static byte[] FIKACFFPBMG<T>(T JNNDBFGKHHD) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x31DBD50", Offset = "0x31DA550", VA = "0x1831DBD50")]
	private static T DNGMAFHHGNP<T>(MessageParser<T> KPNGFFCGGHG, byte[] JNNDBFGKHHD, T NKOKHDBOMFH) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x6F82210", Offset = "0x6F80A10", VA = "0x186F82210")]
	[AsyncStateMachine(typeof(HGDBNNCOFFP))]
	private Task<AGBLOFNHMNJ.CBEFFACDNLD<JHHNPEBPLNM>> PEFHAMFAMDM(JHHNPEBPLNM PIHNIIFANNM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x31DBFA0", Offset = "0x31DA7A0", VA = "0x1831DBFA0")]
	[AsyncStateMachine(typeof(AODMDECPDFP<>))]
	internal Task<T> OLKFELFFMLH<T>(CancellationToken LJPECIOGMKH, Func<CancellationToken, Task<T>> KFEIMOJODHF, int EFINHJDBJEF = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x6F81FD0", Offset = "0x6F807D0", VA = "0x186F81FD0")]
	[AsyncStateMachine(typeof(CBECGODNOOF))]
	internal Task OLKFELFFMLH(CancellationToken LJPECIOGMKH, Func<CancellationToken, Task> KFEIMOJODHF, int EFINHJDBJEF = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x6F81620", Offset = "0x6F7FE20", VA = "0x186F81620")]
	public IOFNMIAGIID GGKOPJBIDKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x6F81480", Offset = "0x6F7FC80", VA = "0x186F81480")]
	public PCJKPFOHLAA AGADJBPJNGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x6F81910", Offset = "0x6F80110", VA = "0x186F81910")]
	public OPPOPKDPFEJ IKFHFHLENCI([Optional] CDLNJDLNIPA? KBNCOADBJAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x6F81A60", Offset = "0x6F80260", VA = "0x186F81A60")]
	public void IMLNJALHMII(Func<Guid, bool> BMMICOLDKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x6F82100", Offset = "0x6F80900", VA = "0x186F82100")]
	public void PCHMJOPDGHI(Func<Guid, bool> CJBGLKIMAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x6F81E50", Offset = "0x6F80650", VA = "0x186F81E50")]
	public Guid OCDKPEAMHIM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x6F81800", Offset = "0x6F80000", VA = "0x186F81800")]
	public void HJOMCJIKAEL(Guid LJBACHIBEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x6F81340", Offset = "0x6F7FB40", VA = "0x186F81340")]
	public void ABMKFOJDGKE(JHHNPEBPLNM JBBIODKBMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x6F81D40", Offset = "0x6F80540", VA = "0x186F81D40")]
	public void MGFMJHPPHBP(string FNOGOHPEEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x31DBEB0", Offset = "0x31DA6B0", VA = "0x1831DBEB0")]
	private T FPAIGDJBKKJ<T>(T JMDCGOKJIDA) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x6F812F0", Offset = "0x6F7FAF0", VA = "0x186F812F0")]
	public void ABCHJAIGKJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x31DBAA0", Offset = "0x31DA2A0", VA = "0x1831DBAA0")]
	[CompilerGenerated]
	internal static string BNJEKJEILEI<T>(byte[] DDNKCFIIBGP, int KBFGFPLLOGD, HEMCMJGMBBI<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
internal sealed class HCHMJJACOEA : LDOGEOGHOLH
{
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class KNLIJFAPCJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public KNLIJFAPCJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB6A0", Offset = "0x6FA9EA0", VA = "0x186FAB6A0")]
		internal object GJADKLJHKOE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private struct GKDPGBPONGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public HCHMJJACOEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private PEJDDGDCLFF <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private PCJKPFOHLAA <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x6FA6610", Offset = "0x6FA4E10", VA = "0x186FA6610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x6FA6EE0", Offset = "0x6FA56E0", VA = "0x186FA6EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct NAMIDAAADBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public HCHMJJACOEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private bool <omIsEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private bool <omShouldBeEnabled>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private TaskAwaiter<FLKIEPIEFEG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private TaskAwaiter<byte> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x6FB0130", Offset = "0x6FAE930", VA = "0x186FB0130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x6FB08E0", Offset = "0x6FAF0E0", VA = "0x186FB08E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private struct MBGDJCBHEPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public HCHMJJACOEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private TaskAwaiter<HNKJBJIHEKD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x6FAE020", Offset = "0x6FAC820", VA = "0x186FAE020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x6FAE330", Offset = "0x6FACB30", VA = "0x186FAE330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private sealed class NCJIGLGCJMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public PEJDDGDCLFF presence;

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public NCJIGLGCJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x6FB0A40", Offset = "0x6FAF240", VA = "0x186FB0A40")]
		internal object IFJABCIFOFP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	private static readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	private static readonly CDLNJDLNIPA KBKNHCEIBOM;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	private static readonly CDLNJDLNIPA HGNMKAKPHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000386")]
	private readonly JBBIANFGILF KLNKIGMCCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000387")]
	private readonly MDBDBMHCDOA EJBBNMBAICD;

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x6FA8680", Offset = "0x6FA6E80", VA = "0x186FA8680")]
	public HCHMJJACOEA(JBBIANFGILF KLNKIGMCCKO, MDBDBMHCDOA EJBBNMBAICD, Guid KPMGFINBLBG, PNHFEHLPHMO KBCJMHHCDBC, NOCKKKPBJAK HEBPMOPIKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x6FA8280", Offset = "0x6FA6A80", VA = "0x186FA8280", Slot = "7")]
	[AsyncStateMachine(typeof(GKDPGBPONGJ))]
	protected override Task JHJGIGBBDDE(AOOKNBGCDKI HOBEPAEHHJL, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x6FA8180", Offset = "0x6FA6980", VA = "0x186FA8180")]
	[AsyncStateMachine(typeof(NAMIDAAADBH))]
	private Task GBOPJINFEFP(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x6FA8070", Offset = "0x6FA6870", VA = "0x186FA8070")]
	[AsyncStateMachine(typeof(MBGDJCBHEPM))]
	private Task<byte> DGOHIDEKAID(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x6FA83C0", Offset = "0x6FA6BC0", VA = "0x186FA83C0")]
	private PEJDDGDCLFF MBJPMOIKNLI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
internal class OCGMAIALJEA : LDOGEOGHOLH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private struct DGLEIKLNILD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public OCGMAIALJEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private TaskAwaiter<BMBMOGELPMJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x6FA1DD0", Offset = "0x6FA05D0", VA = "0x186FA1DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x6FA2750", Offset = "0x6FA0F50", VA = "0x186FA2750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	private readonly int LICNBNKOLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	private readonly NCKGPLMHNNB NHABHPPMDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public readonly long GKKIJACBHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public readonly long PAFDFFODJEJ;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public BMBMOGELPMJ OJOBEJNECJD
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x85FE70", Offset = "0x85E670", VA = "0x18085FE70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x85FEB0", Offset = "0x85E6B0", VA = "0x18085FEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0CA0", Offset = "0x6FAF4A0", VA = "0x186FB0CA0")]
	public OCGMAIALJEA(Guid KPMGFINBLBG, PNHFEHLPHMO KBCJMHHCDBC, NOCKKKPBJAK HEBPMOPIKJB, int LICNBNKOLEM, NCKGPLMHNNB NHABHPPMDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0B80", Offset = "0x6FAF380", VA = "0x186FB0B80", Slot = "7")]
	[AsyncStateMachine(typeof(DGLEIKLNILD))]
	protected override Task JHJGIGBBDDE(AOOKNBGCDKI HOBEPAEHHJL, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal abstract class HPMIHEBMPKI : LDOGEOGHOLH
{
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private sealed class DCDAHHDPJDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public HPMIHEBMPKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public IGNOJPABBPI playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public DCDAHHDPJDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x6FA1AF0", Offset = "0x6FA02F0", VA = "0x186FA1AF0")]
		internal Task IFGJHLKGBCL(OADONCMLPJG<string>.HILOONJJDHL postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x6FA1A60", Offset = "0x6FA0260", VA = "0x186FA1A60")]
		internal object HCNFOGOCMEJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private struct MFCKACCHCKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public HPMIHEBMPKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private DCDAHHDPJDE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x6FAE3A0", Offset = "0x6FACBA0", VA = "0x186FAE3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x6FAEB60", Offset = "0x6FAD360", VA = "0x186FAEB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private struct MMFOBIBKFNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public IGNOJPABBPI playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public HPMIHEBMPKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x6FAFB40", Offset = "0x6FAE340", VA = "0x186FAFB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x6FB00D0", Offset = "0x6FAE8D0", VA = "0x186FB00D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x6FA9110", Offset = "0x6FA7910", VA = "0x186FA9110")]
	public HPMIHEBMPKI(Guid KPMGFINBLBG, PNHFEHLPHMO KBCJMHHCDBC, NOCKKKPBJAK HEBPMOPIKJB, string JHNINBLPPLN, EFBCINIABEJ LJJJHDHDDOO, bool BGLMCDKAHBI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x6FA8E90", Offset = "0x6FA7690", VA = "0x186FA8E90", Slot = "7")]
	[AsyncStateMachine(typeof(MFCKACCHCKK))]
	protected override Task JHJGIGBBDDE(AOOKNBGCDKI HOBEPAEHHJL, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task POFDJKAPCLA(AOOKNBGCDKI HOBEPAEHHJL, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x6FA8FD0", Offset = "0x6FA77D0", VA = "0x186FA8FD0")]
	[AsyncStateMachine(typeof(MMFOBIBKFNK))]
	private Task PFMLNKKNOPL(IDisposable DIDIAIAKNAB, IGNOJPABBPI HFOMBEAGHGK, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
internal class DDDDOLJAOHE : LDOGEOGHOLH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private struct GNPJMDDHFGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public DDDDOLJAOHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private TaskAwaiter<JBBKCFOEFFA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x6FA73C0", Offset = "0x6FA5BC0", VA = "0x186FA73C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x6FA7930", Offset = "0x6FA6130", VA = "0x186FA7930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	private readonly HCEEFOPOCMM LKIPKDFOIKO;

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x6FA1D30", Offset = "0x6FA0530", VA = "0x186FA1D30")]
	public DDDDOLJAOHE(Guid KPMGFINBLBG, PNHFEHLPHMO KBCJMHHCDBC, NOCKKKPBJAK HEBPMOPIKJB, HCEEFOPOCMM LKIPKDFOIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x6FA1B30", Offset = "0x6FA0330", VA = "0x186FA1B30", Slot = "6")]
	protected override string BJAGFHJFAKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x6FA1C10", Offset = "0x6FA0410", VA = "0x186FA1C10", Slot = "7")]
	[AsyncStateMachine(typeof(GNPJMDDHFGE))]
	protected override Task JHJGIGBBDDE(AOOKNBGCDKI HOBEPAEHHJL, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
internal abstract class LDOGEOGHOLH : AICOLMPJDDO
{
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	public delegate Task HCBHHAMMKNH(OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private sealed class PAODNFLLCBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public OADONCMLPJG<string>.HILOONJJDHL operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public LDOGEOGHOLH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public PAODNFLLCBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x6FB2290", Offset = "0x6FB0A90", VA = "0x186FB2290")]
		internal Task FPBNMKNLEFP(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class LOPMMGFHAFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public PAODNFLLCBK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public LOPMMGFHAFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x6FADF60", Offset = "0x6FAC760", VA = "0x186FADF60")]
		internal object APPOCGBDAJO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct CFNFIENGDPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public LDOGEOGHOLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public Func<LDOGEOGHOLH, OADONCMLPJG<string>.HILOONJJDHL, AOOKNBGCDKI> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private PAODNFLLCBK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private AOOKNBGCDKI <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x6F9F9E0", Offset = "0x6F9E1E0", VA = "0x186F9F9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x6FA0AE0", Offset = "0x6F9F2E0", VA = "0x186FA0AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct DLAJNJNLAHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x6FA27B0", Offset = "0x6FA0FB0", VA = "0x186FA27B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x6FA3240", Offset = "0x6FA1A40", VA = "0x186FA3240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct LFPACHJBKCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public LDOGEOGHOLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x6FADBA0", Offset = "0x6FAC3A0", VA = "0x186FADBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x6FADF00", Offset = "0x6FAC700", VA = "0x186FADF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public readonly Guid BCGKIOLOHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public readonly ByteString GKEIIDKFDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public readonly NOCKKKPBJAK LOICDGCIEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	protected readonly string FLBAFFCOAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	private readonly PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	private readonly bool BGLMCDKAHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	private readonly Queue<HCBHHAMMKNH> BDIHHCCEHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private readonly NKKKGGINLEP NKGDDIPPMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	private readonly EFBCINIABEJ LJJJHDHDDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private bool OHAODFIPPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public BAEGFPFJEKP BKNLBEKNLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public BAEGFPFJEKP GBFDEOMKNOD;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public PNHFEHLPHMO NOOCLICDJJM
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x856960", Offset = "0x855160", VA = "0x180856960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public MFEINKDLEHJ KFKHEOKCKBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD240", Offset = "0x6FABA40", VA = "0x186FAD240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public INNHEOLIKBM MDBMBBPHIBI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD0E0", Offset = "0x6FAB8E0", VA = "0x186FAD0E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public FFAMIDMIBLK HFPCNNCNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD680", Offset = "0x6FABE80", VA = "0x186FAD680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event KPJCHGMHNOH ODCPIOEPMDN
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x6FACF80", Offset = "0x6FAB780", VA = "0x186FACF80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x6FACF60", Offset = "0x6FAB760", VA = "0x186FACF60", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD840", Offset = "0x6FAC040", VA = "0x186FAD840")]
	protected LDOGEOGHOLH(Guid KPMGFINBLBG, PNHFEHLPHMO KBCJMHHCDBC, NOCKKKPBJAK HEBPMOPIKJB, string JHNINBLPPLN, EFBCINIABEJ LJJJHDHDDOO, bool BGLMCDKAHBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x6FACFA0", Offset = "0x6FAB7A0", VA = "0x186FACFA0", Slot = "6")]
	protected virtual string BJAGFHJFAKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD3C0", Offset = "0x6FABBC0", VA = "0x186FAD3C0")]
	public void JPMIMBKPEIM(HCBHHAMMKNH LDEAEONJEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD700", Offset = "0x6FABF00", VA = "0x186FAD700")]
	protected void PABDMJKMPLE(float MPPCPDMLBPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x6FACE10", Offset = "0x6FAB610", VA = "0x186FACE10")]
	[AsyncStateMachine(typeof(CFNFIENGDPN))]
	public Task AGALHLJOLPH(CancellationToken MPLGBOFHPLM, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, [Optional] Func<LDOGEOGHOLH, OADONCMLPJG<string>.HILOONJJDHL, AOOKNBGCDKI> ECLLCEGPBIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD290", Offset = "0x6FABA90", VA = "0x186FAD290")]
	[AsyncStateMachine(typeof(DLAJNJNLAHH))]
	private static Task GOMBJKCFMGA(Func<CancellationToken, Task> HBLGMBBHCGK, Func<CancellationToken, Task> MOPPHNLDCLD, CancellationToken LJPECIOGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD510", Offset = "0x6FABD10", VA = "0x186FAD510")]
	private void MKFHGECMKHH(bool NPCJOOKKGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD130", Offset = "0x6FAB930", VA = "0x186FAD130")]
	private void EPEAKBDMGAD(AOOKNBGCDKI HOBEPAEHHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task JHJGIGBBDDE(AOOKNBGCDKI HOBEPAEHHJL, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD720", Offset = "0x6FABF20", VA = "0x186FAD720")]
	[AsyncStateMachine(typeof(LFPACHJBKCH))]
	private Task PDGFBOGPEFA(OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x6FACFE0", Offset = "0x6FAB7E0", VA = "0x186FACFE0")]
	public JHHNPEBPLNM BOKPFNOKGEP(NLAOPAEBMHG GOCKGMEMPGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD420", Offset = "0x6FABC20", VA = "0x186FAD420")]
	[CompilerGenerated]
	private Task LFABIFBOKFH(CancellationToken DOGPFNGIKMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD060", Offset = "0x6FAB860", VA = "0x186FAD060")]
	[CompilerGenerated]
	private object CIGONIBMJDK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
internal sealed class OJHFPGDNLEK : HPMIHEBMPKI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct CEPPGEFKNEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public OJHFPGDNLEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private BIDJCBPPELH <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private PCJKPFOHLAA <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x6F9F210", Offset = "0x6F9DA10", VA = "0x186F9F210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x6F9F980", Offset = "0x6F9E180", VA = "0x186F9F980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	private readonly JBBIANFGILF GDGGKBKMAFL;

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0F20", Offset = "0x6FAF720", VA = "0x186FB0F20")]
	public OJHFPGDNLEK(Guid KPMGFINBLBG, PNHFEHLPHMO KBCJMHHCDBC, JBBIANFGILF GDGGKBKMAFL, NOCKKKPBJAK HEBPMOPIKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0DD0", Offset = "0x6FAF5D0", VA = "0x186FB0DD0", Slot = "8")]
	[AsyncStateMachine(typeof(CEPPGEFKNEK))]
	protected override Task POFDJKAPCLA(AOOKNBGCDKI HOBEPAEHHJL, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
internal class JKIDNJAJEEP : LDOGEOGHOLH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private struct KHKCAIAFPMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public JKIDNJAJEEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		private TaskAwaiter<JBBKCFOEFFA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB290", Offset = "0x6FA9A90", VA = "0x186FAB290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB640", Offset = "0x6FA9E40", VA = "0x186FAB640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	private readonly string FCDJJHECOOP;

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB1E0", Offset = "0x6FA99E0", VA = "0x186FAB1E0")]
	public JKIDNJAJEEP(Guid KPMGFINBLBG, PNHFEHLPHMO KBCJMHHCDBC, NOCKKKPBJAK HEBPMOPIKJB, string FCDJJHECOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB0D0", Offset = "0x6FA98D0", VA = "0x186FAB0D0", Slot = "7")]
	[AsyncStateMachine(typeof(KHKCAIAFPMC))]
	protected override Task JHJGIGBBDDE(AOOKNBGCDKI HOBEPAEHHJL, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
internal class PCLJEAAOENH : HPMIHEBMPKI
{
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private sealed class CLPKMFFCLKJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000118")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000415")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			public AsyncTaskMethodBuilder<JHHNPEBPLNM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			public CLPKMFFCLKJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			private TaskAwaiter<JBBKCFOEFFA> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			private TaskAwaiter<JHHNPEBPLNM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0x6FB6790", Offset = "0x6FB4F90", VA = "0x186FB6790", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x6FB6C50", Offset = "0x6FB5450", VA = "0x186FB6C50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public PCLJEAAOENH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public OPPOPKDPFEJ serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public LEBMOIGALED roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public IOFNMIAGIID uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public JJNDGMFMLEH roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public CLPKMFFCLKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x6FA0E40", Offset = "0x6F9F640", VA = "0x186FA0E40")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<JHHNPEBPLNM> PCBAIDMELCF(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct FKBAGLHKNBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public PCLJEAAOENH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private CLPKMFFCLKJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private BIDJCBPPELH <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private PCJKPFOHLAA <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private JHHNPEBPLNM <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x6FA55E0", Offset = "0x6FA3DE0", VA = "0x186FA55E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x6FA6540", Offset = "0x6FA4D40", VA = "0x186FA6540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	private static readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	private static readonly CDLNJDLNIPA KBKNHCEIBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	private readonly int HDFLMOLOCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	[CanBeNull]
	private readonly KAIMFMKFBCK BJEDAIHNLGI;

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4BC0", Offset = "0x6FB33C0", VA = "0x186FB4BC0")]
	public PCLJEAAOENH(Guid KPMGFINBLBG, PNHFEHLPHMO KBCJMHHCDBC, int HDFLMOLOCCD, KAIMFMKFBCK BJEDAIHNLGI, NOCKKKPBJAK HEBPMOPIKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x6FB49D0", Offset = "0x6FB31D0", VA = "0x186FB49D0", Slot = "8")]
	[AsyncStateMachine(typeof(FKBAGLHKNBF))]
	protected override Task POFDJKAPCLA(AOOKNBGCDKI HOBEPAEHHJL, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x6FB48D0", Offset = "0x6FB30D0", VA = "0x186FB48D0")]
	private void MGJCDPIEIGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4700", Offset = "0x6FB2F00", VA = "0x186FB4700")]
	private void BJOHILFKCOL(OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, BIDJCBPPELH NMJHAGKCPPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal abstract class ONKMEGIFDPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public readonly LDOGEOGHOLH PCEFFCPFNFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public readonly AOOKNBGCDKI BMIIBEBGCLJ;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public MFEINKDLEHJ KFKHEOKCKBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x6FB2130", Offset = "0x6FB0930", VA = "0x186FB2130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public FFAMIDMIBLK HFPCNNCNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x6FB21A0", Offset = "0x6FB09A0", VA = "0x186FB21A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2230", Offset = "0x6FB0A30", VA = "0x186FB2230")]
	protected ONKMEGIFDPF(AOOKNBGCDKI HOBEPAEHHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2180", Offset = "0x6FB0980", VA = "0x186FB2180")]
	protected void MGFMJHPPHBP(string FNOGOHPEEJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal struct IDOKGAKHACO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public Dictionary<Guid, List<CNEDOEIINNH>> KOHNICGLMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public Dictionary<Guid, List<CNEDOEIINNH>> BMCMDODEBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public Dictionary<Guid, List<CNEDOEIINNH>> FDEADOOLGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public List<Guid> OINPNKLHCDN;

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x6FA9160", Offset = "0x6FA7960", VA = "0x186FA9160")]
	public static IDOKGAKHACO JMJOGDIBBHK(MFEINKDLEHJ EKMGPIDNBAL, BAEGFPFJEKP MPMDJOHBDMD, BCCLEKKJGLB ODJOOIPMNML)
	{
		return default(IDOKGAKHACO);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011D")]
internal struct AOHLCIPIPLB
{
	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x8999F0", VA = "0x18089B1F0")]
	public static AOHLCIPIPLB JGIIBNEOBDO()
	{
		return default(AOHLCIPIPLB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal struct JHNAMKCFCAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public readonly FLKIEPIEFEG ECCIBCDNFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public readonly HCDOMJKEJGM BPKLHPPCKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public readonly string EEPCKBDHEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public readonly KEOGFOOKLEH BIOFMAGLAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public readonly KEOGFOOKLEH PNMECAEFMNK;

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x6FAAEA0", Offset = "0x6FA96A0", VA = "0x186FAAEA0")]
	public JHNAMKCFCAD(FLKIEPIEFEG ECCIBCDNFPF, HCDOMJKEJGM BPKLHPPCKJK, string EEPCKBDHEGC, KEOGFOOKLEH BIOFMAGLAJN, KEOGFOOKLEH PNMECAEFMNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal struct JIEDHIIBLJD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	private readonly AOOKNBGCDKI HOBEPAEHHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	private readonly Guid LJBACHIBEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	private bool NPCJOOKKGED;

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB020", Offset = "0x6FA9820", VA = "0x186FAB020")]
	public static JIEDHIIBLJD OCDKPEAMHIM(AOOKNBGCDKI HOBEPAEHHJL)
	{
		return default(JIEDHIIBLJD);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x98D390", Offset = "0x98BB90", VA = "0x18098D390")]
	public void OKNOMJKMFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x6FAAF20", Offset = "0x6FA9720", VA = "0x186FAAF20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB080", Offset = "0x6FA9880", VA = "0x186FAB080")]
	private JIEDHIIBLJD(AOOKNBGCDKI HOBEPAEHHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x6FAAF20", Offset = "0x6FA9720", VA = "0x186FAAF20")]
	private void HJOMCJIKAEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x6FAAF80", Offset = "0x6FA9780", VA = "0x186FAAF80")]
	private Func<Guid, bool> MFCLINCFMIK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal class PCJKPFOHLAA : ONKMEGIFDPF, AICOLMPJDDO
{
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	public delegate Task<BAEGFPFJEKP> NBINIKGBAMA(BCCLEKKJGLB LINJEFIAFHO, FCPMHIPDGPA MNPMLLCCIJK, NKKKGGINLEP CMNBDIJCHGE, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private struct PAPDCCDMGAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public JBBIANFGILF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		private JIEDHIIBLJD <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x6FB23C0", Offset = "0x6FB0BC0", VA = "0x186FB23C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x6FB2B30", Offset = "0x6FB1330", VA = "0x186FB2B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct GKKABENGFIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public AsyncTaskMethodBuilder<JHHNPEBPLNM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public JBBIANFGILF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private OADONCMLPJG<string>.HILOONJJDHL <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x6FA6F40", Offset = "0x6FA5740", VA = "0x186FA6F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x6FA7350", Offset = "0x6FA5B50", VA = "0x186FA7350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct EAPIFEMKFDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public JBBIANFGILF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private OADONCMLPJG<string>.HILOONJJDHL <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x6FA32A0", Offset = "0x6FA1AA0", VA = "0x186FA32A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x6FA3730", Offset = "0x6FA1F30", VA = "0x186FA3730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private sealed class PDLADLBEBGO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000126")]
		private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public AsyncTaskMethodBuilder<JHNAMKCFCAD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public PDLADLBEBGO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			private JHNAMKCFCAD <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			private TaskAwaiter<BAEGFPFJEKP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			private TaskAwaiter<JHNAMKCFCAD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x6FB5240", Offset = "0x6FB3A40", VA = "0x186FB5240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0x6FB59D0", Offset = "0x6FB41D0", VA = "0x186FB59D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000127")]
		private struct <<LoadRoomLocal>b__3>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			public AsyncTaskMethodBuilder<BCCLEKKJGLB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			public PDLADLBEBGO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			private BCCLEKKJGLB <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			private TaskAwaiter<BAEGFPFJEKP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			private TaskAwaiter<BCCLEKKJGLB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000516")]
			[Cpp2IlInjected.Address(RVA = "0x6FB5A40", Offset = "0x6FB4240", VA = "0x186FB5A40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0x6FB6090", Offset = "0x6FB4890", VA = "0x186FB6090", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public JBBIANFGILF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public NKKKGGINLEP preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public NKKKGGINLEP downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public JHNAMKCFCAD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public NKKKGGINLEP postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public BCCLEKKJGLB phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public KGKIJLNHCBD.GNBOAEIMAME <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public PDLADLBEBGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x6FB4F60", Offset = "0x6FB3760", VA = "0x186FB4F60")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<JHNAMKCFCAD> ICICOMFHDMM(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x6FB4CE0", Offset = "0x6FB34E0", VA = "0x186FB4CE0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<BCCLEKKJGLB> BPBCMKLLFEP(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x6FB50A0", Offset = "0x6FB38A0", VA = "0x186FB50A0")]
		internal void NGPFLDECLHP(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x6FB50E0", Offset = "0x6FB38E0", VA = "0x186FB50E0")]
		internal Task PDLBOJJIBFL(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x6FB4E00", Offset = "0x6FB3600", VA = "0x186FB4E00")]
		internal Task CPCNLLIDNJO(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct EOENEDAMKMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public JBBIANFGILF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private PDLADLBEBGO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private TaskAwaiter<JHNAMKCFCAD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private TaskAwaiter<BCCLEKKJGLB> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4830", Offset = "0x6FA3030", VA = "0x186FA4830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x6FA5580", Offset = "0x6FA3D80", VA = "0x186FA5580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct MGBEPLHGAGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public BCCLEKKJGLB phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public NKKKGGINLEP postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private TaskAwaiter<BAEGFPFJEKP> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private FCPMHIPDGPA <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x6FAEBC0", Offset = "0x6FAD3C0", VA = "0x186FAEBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x6FAFAE0", Offset = "0x6FAE2E0", VA = "0x186FAFAE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct LCKAIKKOOLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC500", Offset = "0x6FAAD00", VA = "0x186FAC500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x6FACDB0", Offset = "0x6FAB5B0", VA = "0x186FACDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct CNOINGELDGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public NKKKGGINLEP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		private OADONCMLPJG<string>.HILOONJJDHL <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private TaskAwaiter<BAEGFPFJEKP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x6FA0F60", Offset = "0x6F9F760", VA = "0x186FA0F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x6FA18E0", Offset = "0x6FA00E0", VA = "0x186FA18E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct ILMIABPMMBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public AsyncTaskMethodBuilder<BAEGFPFJEKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public NKKKGGINLEP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		private OADONCMLPJG<string>.HILOONJJDHL <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private TaskAwaiter<BAEGFPFJEKP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x6FA9770", Offset = "0x6FA7F70", VA = "0x186FA9770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x6FAA740", Offset = "0x6FA8F40", VA = "0x186FAA740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct OMKDNEKFPJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public AsyncTaskMethodBuilder<BAEGFPFJEKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public NKKKGGINLEP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public FCPMHIPDGPA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private OADONCMLPJG<string>.HILOONJJDHL <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private TaskAwaiter<BAEGFPFJEKP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x6FB0FD0", Offset = "0x6FAF7D0", VA = "0x186FB0FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x6FB20C0", Offset = "0x6FB08C0", VA = "0x186FB20C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct CHGKHEDHNMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public AsyncTaskMethodBuilder<BAEGFPFJEKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public BAEGFPFJEKP operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public NKKKGGINLEP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public BCCLEKKJGLB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private TaskAwaiter<BAEGFPFJEKP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x6FA0B40", Offset = "0x6F9F340", VA = "0x186FA0B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x6FA0DD0", Offset = "0x6F9F5D0", VA = "0x186FA0DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private sealed class ELLBFHIMDKF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000131")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004BD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004BE")]
			public AsyncTaskMethodBuilder<BAEGFPFJEKP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004BF")]
			public ELLBFHIMDKF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004C0")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C1")]
			private PHCOOIGGHEB <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004C2")]
			private TaskAwaiter<BAEGFPFJEKP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600052E")]
			[Cpp2IlInjected.Address(RVA = "0x6FB6100", Offset = "0x6FB4900", VA = "0x186FB6100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0x6FB6720", Offset = "0x6FB4F20", VA = "0x186FB6720", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public NKKKGGINLEP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public NBINIKGBAMA masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public FCPMHIPDGPA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public BAEGFPFJEKP originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public ELLBFHIMDKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4710", Offset = "0x6FA2F10", VA = "0x186FA4710")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<BAEGFPFJEKP> MAJBALJKKPP(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private struct APINIADFKHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public AsyncTaskMethodBuilder<BAEGFPFJEKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public NKKKGGINLEP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public NBINIKGBAMA masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public FCPMHIPDGPA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		private TaskAwaiter<BAEGFPFJEKP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x6F9E940", Offset = "0x6F9D140", VA = "0x186F9E940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EE40", Offset = "0x6F9D640", VA = "0x186F9EE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct GOJAOLOIPLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public NKKKGGINLEP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private BAEGFPFJEKP <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private IEnumerator<BAEGFPFJEKP> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private TaskAwaiter<BAEGFPFJEKP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x6FA7990", Offset = "0x6FA6190", VA = "0x186FA7990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x6FA7EC0", Offset = "0x6FA66C0", VA = "0x186FA7EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct JCOPCMMMMCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x6FAAC20", Offset = "0x6FA9420", VA = "0x186FAAC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x6FAAE40", Offset = "0x6FA9640", VA = "0x186FAAE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct LDPIIDMHAKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD9A0", Offset = "0x6FAC1A0", VA = "0x186FAD9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x6FADB40", Offset = "0x6FAC340", VA = "0x186FADB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct EDGELNDMKKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public BCCLEKKJGLB phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public NKKKGGINLEP postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private TaskAwaiter<BAEGFPFJEKP> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private FCPMHIPDGPA <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x6FA3790", Offset = "0x6FA1F90", VA = "0x186FA3790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x6FA46B0", Offset = "0x6FA2EB0", VA = "0x186FA46B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct LCHHMPMBJOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public AsyncTaskMethodBuilder<BAEGFPFJEKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public NKKKGGINLEP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		private TaskAwaiter<BAEGFPFJEKP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB960", Offset = "0x6FAA160", VA = "0x186FAB960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC490", Offset = "0x6FAAC90", VA = "0x186FAC490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	private readonly NKPKPHIMNEI KGJFAMAJCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private readonly NKPKPHIMNEI EMGIEIOJPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private readonly BOAMHEKDIOK CJHEFFFCIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private readonly GNKDLDAAEML ANANAPJIBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	private readonly KKMJLGFKMCG HCBLCMEMNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	private readonly NPFIODHPLCC BPNELNCMPID;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private PNHFEHLPHMO NOOCLICDJJM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x6FB2BD0", Offset = "0x6FB13D0", VA = "0x186FB2BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event KPJCHGMHNOH ODCPIOEPMDN
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x6FB2BB0", Offset = "0x6FB13B0", VA = "0x186FB2BB0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x6FB2B90", Offset = "0x6FB1390", VA = "0x186FB2B90", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4460", Offset = "0x6FB2C60", VA = "0x186FB4460")]
	public PCJKPFOHLAA(AOOKNBGCDKI HOBEPAEHHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3800", Offset = "0x6FB2000", VA = "0x186FB3800")]
	[AsyncStateMachine(typeof(PAPDCCDMGAP))]
	public Task MCBFGPEMKEP(JBBIANFGILF GPCNCGBOPJG, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4070", Offset = "0x6FB2870", VA = "0x186FB4070")]
	[AsyncStateMachine(typeof(GKKABENGFIE))]
	private Task<JHHNPEBPLNM> OKDGMCKAGJM(JBBIANFGILF GPCNCGBOPJG, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3950", Offset = "0x6FB2150", VA = "0x186FB3950")]
	[AsyncStateMachine(typeof(EAPIFEMKFDL))]
	private Task MKAHEDDPJAI(JBBIANFGILF GPCNCGBOPJG, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x6FB30D0", Offset = "0x6FB18D0", VA = "0x186FB30D0")]
	[AsyncStateMachine(typeof(EOENEDAMKMI))]
	private Task GEBJKNHIMMH(JBBIANFGILF GPCNCGBOPJG, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MJJIEGHIIHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3540", Offset = "0x6FB1D40", VA = "0x186FB3540")]
	[AsyncStateMachine(typeof(MGBEPLHGAGA))]
	private Task KDKEILCMNCL(BCCLEKKJGLB GGIEODBFCMI, NKKKGGINLEP DHKIHDFOOAK, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken CKBNFNEGPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x6FB41D0", Offset = "0x6FB29D0", VA = "0x186FB41D0")]
	[AsyncStateMachine(typeof(LCKAIKKOOLC))]
	private Task PAAGKABCCEN(OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3E10", Offset = "0x6FB2610", VA = "0x186FB3E10")]
	[AsyncStateMachine(typeof(CNOINGELDGB))]
	private Task NLNJAPLAEPE(BCCLEKKJGLB LINJEFIAFHO, NKKKGGINLEP CMNBDIJCHGE, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3690", Offset = "0x6FB1E90", VA = "0x186FB3690")]
	[AsyncStateMachine(typeof(ILMIABPMMBI))]
	private Task<BAEGFPFJEKP> KODHAJDJLMP(BCCLEKKJGLB LINJEFIAFHO, FCPMHIPDGPA DPNAFHBKAFN, NKKKGGINLEP CMNBDIJCHGE, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x6FB42E0", Offset = "0x6FB2AE0", VA = "0x186FB42E0")]
	[AsyncStateMachine(typeof(OMKDNEKFPJM))]
	private Task<BAEGFPFJEKP> PDBHOJNDJEJ(BCCLEKKJGLB LINJEFIAFHO, FCPMHIPDGPA DPNAFHBKAFN, NKKKGGINLEP CMNBDIJCHGE, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3250", Offset = "0x6FB1A50", VA = "0x186FB3250")]
	[AsyncStateMachine(typeof(CHGKHEDHNMF))]
	private Task<BAEGFPFJEKP> JENLMPOBLMB(BAEGFPFJEKP MPMDJOHBDMD, BCCLEKKJGLB ODJOOIPMNML, NKKKGGINLEP CMNBDIJCHGE, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM, bool AMEECLKOLCO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3F60", Offset = "0x6FB2760", VA = "0x186FB3F60")]
	private bool NNBCAPFCHHL(BCCLEKKJGLB GGIEODBFCMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2F40", Offset = "0x6FB1740", VA = "0x186FB2F40")]
	[AsyncStateMachine(typeof(APINIADFKHM))]
	protected Task<BAEGFPFJEKP> GBKANPHFDEI(BCCLEKKJGLB LINJEFIAFHO, FCPMHIPDGPA DPNAFHBKAFN, NKKKGGINLEP CMNBDIJCHGE, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM, NBINIKGBAMA ODKHEHKDCDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x6FB33D0", Offset = "0x6FB1BD0", VA = "0x186FB33D0")]
	[AsyncStateMachine(typeof(GOJAOLOIPLE))]
	private Task JJLNAOANHOJ(BCCLEKKJGLB LINJEFIAFHO, NKKKGGINLEP CMNBDIJCHGE, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2C00", Offset = "0x6FB1400", VA = "0x186FB2C00")]
	private void BLELCDJIOFC(BAEGFPFJEKP DGDNFAGKJJD, NKKKGGINLEP CMNBDIJCHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2EE0", Offset = "0x6FB16E0", VA = "0x186FB2EE0")]
	private void EMBFDJBDFFA(BAEGFPFJEKP KKHDHGEJOPN, [Out] BAEGFPFJEKP FFPMGCEAJOD, [Out] BAEGFPFJEKP KBNILNCJOBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3210", Offset = "0x6FB1A10", VA = "0x186FB3210")]
	private Task<JHNAMKCFCAD> IBAFCNNGGBJ(JBBIANFGILF GPCNCGBOPJG, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3AB0", Offset = "0x6FB22B0", VA = "0x186FB3AB0")]
	private Task<BCCLEKKJGLB> NAEJOCDJHNH(JHNAMKCFCAD LINJEFIAFHO, KGKIJLNHCBD.GNBOAEIMAME KANAHIPJEKP, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2D40", Offset = "0x6FB1540", VA = "0x186FB2D40")]
	[AsyncStateMachine(typeof(JCOPCMMMMCB))]
	private Task DMFOCICFLCE(BCCLEKKJGLB LINJEFIAFHO, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM, bool DJDDDKCEKHP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2C50", Offset = "0x6FB1450", VA = "0x186FB2C50")]
	[AsyncStateMachine(typeof(LDPIIDMHAKH))]
	private Task DDPHFAPHNMD(BCCLEKKJGLB LINJEFIAFHO, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2E90", Offset = "0x6FB1690", VA = "0x186FB2E90")]
	private Task EFGNAADJLFA(BCCLEKKJGLB LINJEFIAFHO, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3A90", Offset = "0x6FB2290", VA = "0x186FB3A90")]
	private Task MKIEPGKEMCG(BCCLEKKJGLB LINJEFIAFHO, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2EC0", Offset = "0x6FB16C0", VA = "0x186FB2EC0")]
	private Task EJGFDNPNEIN(BCCLEKKJGLB LINJEFIAFHO, FCPMHIPDGPA DPNAFHBKAFN, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2F20", Offset = "0x6FB1720", VA = "0x186FB2F20")]
	private Task FALJJJKGMCC(BCCLEKKJGLB LINJEFIAFHO, FCPMHIPDGPA DPNAFHBKAFN, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x6FB37F0", Offset = "0x6FB1FF0", VA = "0x186FB37F0")]
	private static Task LNLKHCIOHAD(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3DF0", Offset = "0x6FB25F0", VA = "0x186FB3DF0")]
	private Task NKNNIBAMIAA(BCCLEKKJGLB LINJEFIAFHO, FCPMHIPDGPA DPNAFHBKAFN, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3520", Offset = "0x6FB1D20", VA = "0x186FB3520")]
	private Task KAKLPMDHELE(BCCLEKKJGLB LINJEFIAFHO, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3DA0", Offset = "0x6FB25A0", VA = "0x186FB3DA0")]
	private void NFEJECHCLPP(JBBIANFGILF GPCNCGBOPJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4050", Offset = "0x6FB2850", VA = "0x186FB4050")]
	public void OAGKDLDDPPP(long LMGCMDBJBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
	private static void BMGKEDPPOFE(FLKIEPIEFEG ECCIBCDNFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3AF0", Offset = "0x6FB22F0", VA = "0x186FB3AF0")]
	[AsyncStateMachine(typeof(EDGELNDMKKJ))]
	private Task NDLPLKBKJDH(BCCLEKKJGLB GGIEODBFCMI, NKKKGGINLEP DHKIHDFOOAK, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken CKBNFNEGPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3C40", Offset = "0x6FB2440", VA = "0x186FB3C40")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(LCHHMPMBJOH))]
	private Task<BAEGFPFJEKP> NDPOMNCNAKP(BCCLEKKJGLB LINJEFIAFHO, FCPMHIPDGPA DPNAFHBKAFN, NKKKGGINLEP CMNBDIJCHGE, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct JAGPKEDOPNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private BCCLEKKJGLB LINJEFIAFHO;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private MFEINKDLEHJ KFKHEOKCKBP
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4C80", Offset = "0x6FC3480", VA = "0x186FC4C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x6FC4BA0", Offset = "0x6FC33A0", VA = "0x186FC4BA0")]
	public static Task AGALHLJOLPH(PNHFEHLPHMO KBCJMHHCDBC, BCCLEKKJGLB LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x6FC4980", Offset = "0x6FC3180", VA = "0x186FC4980")]
	private void AGALHLJOLPH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct MBPCJJOAHBO
{
	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x6FCAA50", Offset = "0x6FC9250", VA = "0x186FCAA50")]
	public static Task AGALHLJOLPH(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct CBBPBLNIDIA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private struct GIPJHKIPBFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private OADONCMLPJG<string>.HILOONJJDHL <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1A20", Offset = "0x6FC0220", VA = "0x186FC1A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1F40", Offset = "0x6FC0740", VA = "0x186FC1F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC600", Offset = "0x6FBAE00", VA = "0x186FBC600")]
	[AsyncStateMachine(typeof(GIPJHKIPBFO))]
	public static Task AGALHLJOLPH(AOOKNBGCDKI HOBEPAEHHJL, BCCLEKKJGLB LINJEFIAFHO, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013C")]
internal struct LMGNCPJGAIF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct ADBNHDLAKGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public FCPMHIPDGPA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private BAEGFPFJEKP <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private PNHFEHLPHMO <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private MFEINKDLEHJ <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private PHCOOIGGHEB <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private List<(PersistenceView, CLPMHIGOAIJ)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private CLPMHIGOAIJ <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x6FB7030", Offset = "0x6FB5830", VA = "0x186FB7030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x6FB7CB0", Offset = "0x6FB64B0", VA = "0x186FB7CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x6FCA700", Offset = "0x6FC8F00", VA = "0x186FCA700")]
	[AsyncStateMachine(typeof(ADBNHDLAKGC))]
	public static Task AGALHLJOLPH(AOOKNBGCDKI HOBEPAEHHJL, BCCLEKKJGLB LINJEFIAFHO, FCPMHIPDGPA DPNAFHBKAFN, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x6FCA850", Offset = "0x6FC9050", VA = "0x186FCA850")]
	private static void GEMIADKFHHE(PersistenceView HLFKKKOLNPG, CLPMHIGOAIJ OOCANEMEHMO, BCCLEKKJGLB LINJEFIAFHO, BAEGFPFJEKP MPMDJOHBDMD, bool FGOIIGNLDGH)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013F")]
internal struct PPKGCGCBCMF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct HNFIOAGKEFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public PNHFEHLPHMO roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3CC0", Offset = "0x6FC24C0", VA = "0x186FC3CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4100", Offset = "0x6FC2900", VA = "0x186FC4100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x6FD03D0", Offset = "0x6FCEBD0", VA = "0x186FD03D0")]
	[AsyncStateMachine(typeof(HNFIOAGKEFC))]
	public static Task AGALHLJOLPH(PNHFEHLPHMO KBCJMHHCDBC, BCCLEKKJGLB LINJEFIAFHO, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
internal struct OJAPCCOPINI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct DGAJLLPODJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public PNHFEHLPHMO roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC9F0", Offset = "0x6FBB1F0", VA = "0x186FBC9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x6FBCC00", Offset = "0x6FBB400", VA = "0x186FBCC00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private sealed class KANDKPKGKPJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000144")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400052B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400052C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400052D")]
			public OADONCMLPJG<string>.HILOONJJDHL timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400052E")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400052F")]
			public KANDKPKGKPJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000558")]
			[Cpp2IlInjected.Address(RVA = "0x6FD0A00", Offset = "0x6FCF200", VA = "0x186FD0A00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000559")]
			[Cpp2IlInjected.Address(RVA = "0x6FD0D90", Offset = "0x6FCF590", VA = "0x186FD0D90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public KANDKPKGKPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7380", Offset = "0x6FC5B80", VA = "0x186FC7380")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task FPICMPNLPMI(OADONCMLPJG<string>.HILOONJJDHL timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct KDAKAOIHDFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public OJAPCCOPINI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7940", Offset = "0x6FC6140", VA = "0x186FC7940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x6FC8300", Offset = "0x6FC6B00", VA = "0x186FC8300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private sealed class EGIGMNCPODP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public CCFJLIPPODM version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public EGIGMNCPODP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD980", Offset = "0x6FBC180", VA = "0x186FBD980")]
		internal object KOEBPLFHGOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x6FBDA60", Offset = "0x6FBC260", VA = "0x186FBDA60")]
		internal object PEHOIBPMDNF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	private BCCLEKKJGLB LINJEFIAFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	private AOOKNBGCDKI HOBEPAEHHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	private bool DJDDDKCEKHP;

	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private static readonly ByteString JOKAAPOMGEN;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private MFEINKDLEHJ KFKHEOKCKBP
	{
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x6FCCB20", Offset = "0x6FCB320", VA = "0x186FCCB20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private FFAMIDMIBLK HFPCNNCNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x6FCCBB0", Offset = "0x6FCB3B0", VA = "0x186FCCBB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC1F0", Offset = "0x6FCA9F0", VA = "0x186FCC1F0")]
	[AsyncStateMachine(typeof(DGAJLLPODJF))]
	public static Task AGALHLJOLPH(PNHFEHLPHMO KBCJMHHCDBC, BCCLEKKJGLB LINJEFIAFHO, AOOKNBGCDKI HOBEPAEHHJL, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM, bool DJDDDKCEKHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC340", Offset = "0x6FCAB40", VA = "0x186FCC340")]
	[AsyncStateMachine(typeof(KDAKAOIHDFD))]
	private Task AGALHLJOLPH(OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC480", Offset = "0x6FCAC80", VA = "0x186FCC480")]
	private void CIAIEKFFHPK([NotNull] CKJAAMAMPKA DFEILOOLDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x6FCCB70", Offset = "0x6FCB370", VA = "0x186FCCB70")]
	private bool FGJHAIOGJNE(CCFJLIPPODM DMDAEILPBHA, CKJAAMAMPKA DFEILOOLDPK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
internal struct FBKJKJHEJFH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct JKKPIJJOEKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public AsyncTaskMethodBuilder<BCCLEKKJGLB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public FBKJKJHEJFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public KGKIJLNHCBD.GNBOAEIMAME downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private OADONCMLPJG<string>.HILOONJJDHL <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private TaskAwaiter<(CIKECDEKJAI<NPKNNMIHNCN, EGADAFAJMEN>, CIKECDEKJAI<MOGOEHIGGGP<CKJAAMAMPKA>, EGADAFAJMEN>, CIKECDEKJAI<MOGOEHIGGGP<JPOIDFBEIEP>, EGADAFAJMEN>, CIKECDEKJAI<MOGOEHIGGGP<LPCEBBBOKPM>, EGADAFAJMEN>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x6FC66C0", Offset = "0x6FC4EC0", VA = "0x186FC66C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7170", Offset = "0x6FC5970", VA = "0x186FC7170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct BOMNLAHGAHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public AsyncTaskMethodBuilder<CIKECDEKJAI<NPKNNMIHNCN, EGADAFAJMEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public OADONCMLPJG<string>.HILOONJJDHL downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public FBKJKJHEJFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public KGKIJLNHCBD.GNBOAEIMAME downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private TaskAwaiter<CIKECDEKJAI<NPKNNMIHNCN, EGADAFAJMEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x6FBBF80", Offset = "0x6FBA780", VA = "0x186FBBF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC590", Offset = "0x6FBAD90", VA = "0x186FBC590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	private PFLNKKCOAHI<KEOGFOOKLEH, JPOIDFBEIEP> LKIOEIPJIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	private PFLNKKCOAHI<KEOGFOOKLEH, CKJAAMAMPKA> HBGBDBMCOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	private PFLNKKCOAHI<long, LPCEBBBOKPM> HEFLBPJEPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	private PJOHEDNALLN EOGAHJIINJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	private FLKIEPIEFEG ECCIBCDNFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	private HCDOMJKEJGM BPKLHPPCKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	private string EEPCKBDHEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	private KEOGFOOKLEH BIOFMAGLAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	private KEOGFOOKLEH PNMECAEFMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	private long LMGCMDBJBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	private OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM;

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x6FBEC20", Offset = "0x6FBD420", VA = "0x186FBEC20")]
	public static Task<BCCLEKKJGLB> GNJKDOJCBBG(PNHFEHLPHMO KBCJMHHCDBC, [In] JHNAMKCFCAD LINJEFIAFHO, KGKIJLNHCBD.GNBOAEIMAME KANAHIPJEKP, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE8D0", Offset = "0x6FBD0D0", VA = "0x186FBE8D0")]
	[AsyncStateMachine(typeof(JKKPIJJOEKK))]
	private Task<BCCLEKKJGLB> AGALHLJOLPH(KGKIJLNHCBD.GNBOAEIMAME KANAHIPJEKP, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x6FBEA60", Offset = "0x6FBD260", VA = "0x186FBEA60")]
	[AsyncStateMachine(typeof(BOMNLAHGAHA))]
	private Task<CIKECDEKJAI<NPKNNMIHNCN, EGADAFAJMEN>> FPCKHFICPDG(string EEPCKBDHEGC, long LMGCMDBJBOB, long? DIMOGDCMBFM, long? KJMNNDODHCP, KGKIJLNHCBD.GNBOAEIMAME KANAHIPJEKP, OADONCMLPJG<string>.HILOONJJDHL MFPMAOGMDIK, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
internal struct ONKDMLGACJD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private struct FLKGCOMGNOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public AsyncTaskMethodBuilder<JHNAMKCFCAD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public ONKDMLGACJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private OADONCMLPJG<string>.HILOONJJDHL <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private TaskAwaiter<JHNAMKCFCAD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0AB0", Offset = "0x6FBF2B0", VA = "0x186FC0AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0EB0", Offset = "0x6FBF6B0", VA = "0x186FC0EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct KBBJHMOIPMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public AsyncTaskMethodBuilder<JHNAMKCFCAD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public ONKDMLGACJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private TaskAwaiter<JHNAMKCFCAD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x6FC74A0", Offset = "0x6FC5CA0", VA = "0x186FC74A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC78D0", Offset = "0x6FC60D0", VA = "0x186FC78D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class MNONHLPGAJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public MNONHLPGAJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x92C050", Offset = "0x92A850", VA = "0x18092C050")]
		internal bool IEIJLBPGCJB(HCDOMJKEJGM sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct BNEHBJOEMEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public AsyncTaskMethodBuilder<JHNAMKCFCAD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public KEOGFOOKLEH superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public MFEINKDLEHJ callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private MNONHLPGAJH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public GGIIPLFNMOA roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private FLKIEPIEFEG <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private HCDOMJKEJGM <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private KEOGFOOKLEH <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private KEOGFOOKLEH <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private TaskAwaiter<FLKIEPIEFEG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private TaskAwaiter<LLEPICGCMEA> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private TaskAwaiter<HNKJBJIHEKD> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x6FBADE0", Offset = "0x6FB95E0", VA = "0x186FBADE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x6FBBF10", Offset = "0x6FBA710", VA = "0x186FBBF10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000560")]
	private MFEINKDLEHJ EKMGPIDNBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000561")]
	private BOAMHEKDIOK CJHEFFFCIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000562")]
	private GGIIPLFNMOA JKPACCCFGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000563")]
	private OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000564")]
	private long DIMOGDCMBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	private long MMMJFAODPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	private long JFKPBGIIONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	private string CNCIKMOKNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private KEOGFOOKLEH DPKLJFBJENK;

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x6FCCFB0", Offset = "0x6FCB7B0", VA = "0x186FCCFB0")]
	public static Task<JHNAMKCFCAD> GNJKDOJCBBG(PNHFEHLPHMO KBCJMHHCDBC, JBBIANFGILF GPCNCGBOPJG, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x6FCCE30", Offset = "0x6FCB630", VA = "0x186FCCE30")]
	[AsyncStateMachine(typeof(FLKGCOMGNOD))]
	private Task<JHNAMKCFCAD> AGALHLJOLPH(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD230", Offset = "0x6FCBA30", VA = "0x186FCD230")]
	[AsyncStateMachine(typeof(KBBJHMOIPMM))]
	private Task<JHNAMKCFCAD> IBAFCNNGGBJ(OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD390", Offset = "0x6FCBB90", VA = "0x186FCD390")]
	[AsyncStateMachine(typeof(BNEHBJOEMEG))]
	private static Task<JHNAMKCFCAD> IBAFCNNGGBJ(MFEINKDLEHJ EKMGPIDNBAL, GGIIPLFNMOA JKPACCCFGCC, long DIMOGDCMBFM, long MMMJFAODPOA, long JFKPBGIIONL, string CNCIKMOKNCG, KEOGFOOKLEH DPKLJFBJENK, CancellationToken MPLGBOFHPLM, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x6FCCF80", Offset = "0x6FCB780", VA = "0x186FCCF80")]
	private void DHHHMFJMENJ(FLKIEPIEFEG ECCIBCDNFPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
internal struct DGNIKAGOCHB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct EPGDBNGOGIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public DGNIKAGOCHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x6FBDBA0", Offset = "0x6FBC3A0", VA = "0x186FBDBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x6FBE130", Offset = "0x6FBC930", VA = "0x186FBE130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400058B")]
	private MFEINKDLEHJ EKMGPIDNBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400058C")]
	private BCCLEKKJGLB LINJEFIAFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400058D")]
	private OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400058E")]
	private float GGEDFCNOKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400058F")]
	private float KHPFKLEDAHL;

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x6FBD0E0", Offset = "0x6FBB8E0", VA = "0x186FBD0E0")]
	public static Task MFIHCKJGFLF(PNHFEHLPHMO KBCJMHHCDBC, BCCLEKKJGLB LINJEFIAFHO, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x6FBCC60", Offset = "0x6FBB460", VA = "0x186FBCC60")]
	[AsyncStateMachine(typeof(EPGDBNGOGIB))]
	public Task AGALHLJOLPH(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x6FBCFA0", Offset = "0x6FBB7A0", VA = "0x186FBCFA0")]
	private static void HHAFDHIEILI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x6FBCD80", Offset = "0x6FBB580", VA = "0x186FBCD80")]
	private void DPGOPDPAMPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x6FBCEE0", Offset = "0x6FBB6E0", VA = "0x186FBCEE0")]
	private static float HCCEFAGLBHC(MFEINKDLEHJ EKMGPIDNBAL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x6FBD280", Offset = "0x6FBBA80", VA = "0x186FBD280")]
	private static float OPDDPJJIELM()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000152")]
internal struct JCHJMDOAEGK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct LEBHPOLOGOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private LDOGEOGHOLH <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private PNHFEHLPHMO <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private FJCBFJLOJNB.HEMGOLNMIEJ <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x6FC9E80", Offset = "0x6FC8680", VA = "0x186FC9E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA6A0", Offset = "0x6FC8EA0", VA = "0x186FCA6A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct BHOOGBGPDJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x6FBAA90", Offset = "0x6FB9290", VA = "0x186FBAA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x6FBAD80", Offset = "0x6FB9580", VA = "0x186FBAD80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x6FC5530", Offset = "0x6FC3D30", VA = "0x186FC5530")]
	[AsyncStateMachine(typeof(LEBHPOLOGOP))]
	public static Task AGALHLJOLPH(AOOKNBGCDKI HOBEPAEHHJL, BCCLEKKJGLB LINJEFIAFHO, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x6FC5670", Offset = "0x6FC3E70", VA = "0x186FC5670")]
	private static Task<JHHNPEBPLNM> EIJPLEGLDCB(AOOKNBGCDKI HOBEPAEHHJL, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x6FC56E0", Offset = "0x6FC3EE0", VA = "0x186FC56E0")]
	[AsyncStateMachine(typeof(BHOOGBGPDJC))]
	private static Task IDOIIPCLOJP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
internal struct PNOHLCBINMM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct ODLOGBCMIKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public PNOHLCBINMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x6FCB1D0", Offset = "0x6FC99D0", VA = "0x186FCB1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x6FCB880", Offset = "0x6FCA080", VA = "0x186FCB880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private sealed class PIGPMDMLNGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public PIGPMDMLNGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x6FCFC30", Offset = "0x6FCE430", VA = "0x186FCFC30")]
		internal object LHOFPOCAMBD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct GEMDJEOOABA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public PNOHLCBINMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1420", Offset = "0x6FBFC20", VA = "0x186FC1420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1880", Offset = "0x6FC0080", VA = "0x186FC1880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005AA")]
	private bool JHLNKBPNCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005AB")]
	private OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005AC")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005AD")]
	private CancellationToken MPLGBOFHPLM;

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x6FD0360", Offset = "0x6FCEB60", VA = "0x186FD0360")]
	public static Task GDDFCAEIIAE(PNHFEHLPHMO KBCJMHHCDBC, bool JHLNKBPNCBO, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken CGFBIGKMGCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x6FD0140", Offset = "0x6FCE940", VA = "0x186FD0140")]
	[AsyncStateMachine(typeof(ODLOGBCMIKM))]
	private Task AGALHLJOLPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x6FD0230", Offset = "0x6FCEA30", VA = "0x186FD0230")]
	[AsyncStateMachine(typeof(GEMDJEOOABA))]
	private Task AMHLAJGDKIO(bool DNHNFCFHHHN, string OAAJEIOFMBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x8999F0", VA = "0x18089B1F0")]
	private bool JLKDJOGOKEC(bool JHLNKBPNCBO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct KLKDPMKGLFM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private struct KNCEOJKJOJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public KLKDPMKGLFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x6FC9850", Offset = "0x6FC8050", VA = "0x186FC9850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x6FC9DC0", Offset = "0x6FC85C0", VA = "0x186FC9DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private sealed class KOKHFIEHLAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public KOKHFIEHLAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x6FC9E30", Offset = "0x6FC8630", VA = "0x186FC9E30")]
		internal object LHOFPOCAMBD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private struct GANKJKJHKCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public KLKDPMKGLFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0F20", Offset = "0x6FBF720", VA = "0x186FC0F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x6FC13B0", Offset = "0x6FBFBB0", VA = "0x186FC13B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005BD")]
	private ABKBLDBOPKP JOMJHKECGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005BE")]
	private OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005BF")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C0")]
	private bool JBAPLLMCMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005C1")]
	private BCCLEKKJGLB LINJEFIAFHO;

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x6FC89B0", Offset = "0x6FC71B0", VA = "0x186FC89B0")]
	public static Task<Scene> ANJIDPMKHGM(PNHFEHLPHMO KBCJMHHCDBC, ABKBLDBOPKP LOKLKHKLFPL, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x6FC8740", Offset = "0x6FC6F40", VA = "0x186FC8740")]
	[AsyncStateMachine(typeof(KNCEOJKJOJN))]
	private Task<Scene> AGALHLJOLPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x6FC8A30", Offset = "0x6FC7230", VA = "0x186FC8A30")]
	private bool EIMIEILCPAJ(BCCLEKKJGLB LINJEFIAFHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x6FC8A60", Offset = "0x6FC7260", VA = "0x186FC8A60")]
	private void MGKMNEHAJBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x6FC8860", Offset = "0x6FC7060", VA = "0x186FC8860")]
	[AsyncStateMachine(typeof(GANKJKJHKCG))]
	private Task<Scene> AMHLAJGDKIO(string OAAJEIOFMBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
internal struct KKMJLGFKMCG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct AGBDPBGOIGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public AsyncTaskMethodBuilder<BAEGFPFJEKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public KKMJLGFKMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public BAEGFPFJEKP nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public BCCLEKKJGLB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		private OADONCMLPJG<string>.HILOONJJDHL <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		private TaskAwaiter<BAEGFPFJEKP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8380", Offset = "0x6FB6B80", VA = "0x186FB8380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8E60", Offset = "0x6FB7660", VA = "0x186FB8E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private struct JJLDAMPBLBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public AsyncTaskMethodBuilder<BAEGFPFJEKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public KKMJLGFKMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public BAEGFPFJEKP state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6370", Offset = "0x6FC4B70", VA = "0x186FC6370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6650", Offset = "0x6FC4E50", VA = "0x186FC6650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	private readonly AOOKNBGCDKI HOBEPAEHHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private readonly BOAMHEKDIOK CJHEFFFCIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	private readonly GNKDLDAAEML ANANAPJIBKL;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private LDOGEOGHOLH PCEFFCPFNFE
	{
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x56E8AE0", Offset = "0x56E72E0", VA = "0x1856E8AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x6FC86E0", Offset = "0x6FC6EE0", VA = "0x186FC86E0")]
	public KKMJLGFKMCG(AOOKNBGCDKI HOBEPAEHHJL, BOAMHEKDIOK CJHEFFFCIJN, GNKDLDAAEML ANANAPJIBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x6FC8400", Offset = "0x6FC6C00", VA = "0x186FC8400")]
	[AsyncStateMachine(typeof(AGBDPBGOIGG))]
	public Task<BAEGFPFJEKP> MHDBOPPLJDH(BAEGFPFJEKP NCONGBKANCG, BCCLEKKJGLB ODJOOIPMNML, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM, bool AMEECLKOLCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x6FC8580", Offset = "0x6FC6D80", VA = "0x186FC8580")]
	[AsyncStateMachine(typeof(JJLDAMPBLBI))]
	private Task<BAEGFPFJEKP> OODKHDCPLHI(OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, BAEGFPFJEKP DMDDBNBIFMI, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x6FC83B0", Offset = "0x6FC6BB0", VA = "0x186FC83B0")]
	private bool HNONDFFMHPC(BAEGFPFJEKP CFAGNNMBLHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x6FC83E0", Offset = "0x6FC6BE0", VA = "0x186FC83E0")]
	private void MGFMJHPPHBP(string ALLEHOLILJB)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000160")]
internal struct GFPNDEOOMCO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private struct ADCGBNLIECO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public LDOGEOGHOLH operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public FCPMHIPDGPA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		private PHCOOIGGHEB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		private List<(PersistenceView, CLPMHIGOAIJ)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private (PersistenceView, CLPMHIGOAIJ) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x6FB7D10", Offset = "0x6FB6510", VA = "0x186FB7D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8320", Offset = "0x6FB6B20", VA = "0x186FB8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x6FC18E0", Offset = "0x6FC00E0", VA = "0x186FC18E0")]
	[AsyncStateMachine(typeof(ADCGBNLIECO))]
	public static Task AGALHLJOLPH(LDOGEOGHOLH PADMFCNKGOL, BCCLEKKJGLB LINJEFIAFHO, FCPMHIPDGPA DPNAFHBKAFN, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000162")]
internal struct NALHALLENCC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private struct HJEPEJGPDKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public LDOGEOGHOLH operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public FCPMHIPDGPA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		private CCFJLIPPODM <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private PHCOOIGGHEB <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		private List<(PersistenceView, CLPMHIGOAIJ)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private CLPMHIGOAIJ <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3410", Offset = "0x6FC1C10", VA = "0x186FC3410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3C60", Offset = "0x6FC2460", VA = "0x186FC3C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x6FCAB30", Offset = "0x6FC9330", VA = "0x186FCAB30")]
	[AsyncStateMachine(typeof(HJEPEJGPDKJ))]
	public static Task AGALHLJOLPH(LDOGEOGHOLH PADMFCNKGOL, BCCLEKKJGLB LINJEFIAFHO, FCPMHIPDGPA DPNAFHBKAFN, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
internal struct FJCBFJLOJNB
{
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	public struct HEMGOLNMIEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public List<NCKGFONBDGH> MFIKIEPKPBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public List<CLPMHIGOAIJ> LEHPADKOLLE;

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0xAB1600", Offset = "0xAAFE00", VA = "0x180AB1600")]
		public HEMGOLNMIEJ(List<NCKGFONBDGH> MFIKIEPKPBB, List<CLPMHIGOAIJ> LEHPADKOLLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private sealed class JCFIKPFBJCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public IEnumerable<NCKGFONBDGH> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public JCFIKPFBJCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x6FC54B0", Offset = "0x6FC3CB0", VA = "0x186FC54B0")]
		internal object FABOFDNJIKP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005FD")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005FE")]
	private BCCLEKKJGLB LINJEFIAFHO;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private MFEINKDLEHJ KFKHEOKCKBP
	{
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0890", Offset = "0x6FBF090", VA = "0x186FC0890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0280", Offset = "0x6FBEA80", VA = "0x186FC0280")]
	public static HEMGOLNMIEJ AGALHLJOLPH(PNHFEHLPHMO KBCJMHHCDBC, BCCLEKKJGLB LINJEFIAFHO)
	{
		return default(HEMGOLNMIEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0020", Offset = "0x6FBE820", VA = "0x186FC0020")]
	private HEMGOLNMIEJ AGALHLJOLPH()
	{
		return default(HEMGOLNMIEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x6FC02E0", Offset = "0x6FBEAE0", VA = "0x186FC02E0")]
	private HEMGOLNMIEJ DKENKAFIPMM(CKJAAMAMPKA DFEILOOLDPK, CCFJLIPPODM EIBPJCOMOGE)
	{
		return default(HEMGOLNMIEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x6FC08E0", Offset = "0x6FBF0E0", VA = "0x186FC08E0")]
	private bool IGJJFFNHFLE(IEnumerable<NCKGFONBDGH> MFIKIEPKPBB)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000167")]
internal struct KMBMIGAEPGA
{
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private sealed class PDHPCFLCMPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public FJCBFJLOJNB.HEMGOLNMIEJ instantiations;

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public PDHPCFLCMPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x6FCF560", Offset = "0x6FCDD60", VA = "0x186FCF560")]
		internal object FPICMPNLPMI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class ELBCCNMKKBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public ELBCCNMKKBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x6FBDB10", Offset = "0x6FBC310", VA = "0x186FBDB10")]
		internal object FPBNMKNLEFP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x6FC8AD0", Offset = "0x6FC72D0", VA = "0x186FC8AD0")]
	public static void AGALHLJOLPH(LDOGEOGHOLH PADMFCNKGOL, BCCLEKKJGLB LINJEFIAFHO, FJCBFJLOJNB.HEMGOLNMIEJ IBLABOGDCFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
internal class GNKDLDAAEML
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private struct KNABJDKMEDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public GNKDLDAAEML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public BAEGFPFJEKP operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public BCCLEKKJGLB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x6FC9080", Offset = "0x6FC7880", VA = "0x186FC9080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x6FC97F0", Offset = "0x6FC7FF0", VA = "0x186FC97F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private sealed class AMGCDOIIEAJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016D")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000613")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000614")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000615")]
			public AMGCDOIIEAJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000616")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000617")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0x6FD06E0", Offset = "0x6FCEEE0", VA = "0x186FD06E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x6FD09A0", Offset = "0x6FCF1A0", VA = "0x186FD09A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public GNKDLDAAEML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public OADONCMLPJG<string>.HILOONJJDHL handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public AMGCDOIIEAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9CB0", Offset = "0x6FB84B0", VA = "0x186FB9CB0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task FEKPJGFOHFF(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private struct OIJOGIOFDEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public GNKDLDAAEML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		private AMGCDOIIEAJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x6FCBC60", Offset = "0x6FCA460", VA = "0x186FCBC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x6FCC190", Offset = "0x6FCA990", VA = "0x186FCC190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct OPOGGMJIFMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public GNKDLDAAEML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		private Dictionary<Guid, List<CNEDOEIINNH>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x6FCD530", Offset = "0x6FCBD30", VA = "0x186FCD530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x6FCDAE0", Offset = "0x6FCC2E0", VA = "0x186FCDAE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct ALIHIMJOPAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public GNKDLDAAEML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		private Dictionary<Guid, List<CNEDOEIINNH>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x6FB95D0", Offset = "0x6FB7DD0", VA = "0x186FB95D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9C50", Offset = "0x6FB8450", VA = "0x186FB9C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class EFKJHOCODEL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000172")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000637")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000638")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000639")]
			public CNEDOEIINNH handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400063A")]
			public EFKJHOCODEL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400063B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(RVA = "0x6FD04E0", Offset = "0x6FCECE0", VA = "0x186FD04E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0x6FD0680", Offset = "0x6FCEE80", VA = "0x186FD0680", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public NONNNPKNJHH runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public List<CNEDOEIINNH> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public EFKJHOCODEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD6B0", Offset = "0x6FBBEB0", VA = "0x186FBD6B0")]
		internal object BGJBLCDJLMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD7A0", Offset = "0x6FBBFA0", VA = "0x186FBD7A0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task HFPKJOMEJMM(CNEDOEIINNH handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD890", Offset = "0x6FBC090", VA = "0x186FBD890")]
		internal object KKBCGMPLPNJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private struct FGBECPLAAGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public NONNNPKNJHH runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public List<CNEDOEIINNH> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		private EFKJHOCODEL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x6FBFAF0", Offset = "0x6FBE2F0", VA = "0x186FBFAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x6FBFFC0", Offset = "0x6FBE7C0", VA = "0x186FBFFC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private struct PIAJBODKKPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public GNKDLDAAEML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x6FCF610", Offset = "0x6FCDE10", VA = "0x186FCF610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x6FCFBD0", Offset = "0x6FCE3D0", VA = "0x186FCFBD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private sealed class CCCLIGPGNNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public CCCLIGPGNNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC740", Offset = "0x6FBAF40", VA = "0x186FBC740")]
		internal object DHJLJGCPIMJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private struct NMEHDBMMELB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public GNKDLDAAEML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x6FCAC70", Offset = "0x6FC9470", VA = "0x186FCAC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x6FCB130", Offset = "0x6FC9930", VA = "0x186FCB130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private sealed class CHMHLODPEBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public CHMHLODPEBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC7B0", Offset = "0x6FBAFB0", VA = "0x186FBC7B0")]
		internal object BFPLKMAPGLD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct JBAKKAMGEEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public GNKDLDAAEML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4CD0", Offset = "0x6FC34D0", VA = "0x186FC4CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5310", Offset = "0x6FC3B10", VA = "0x186FC5310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class BEHMABACEEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public BEHMABACEEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x6FBAA20", Offset = "0x6FB9220", VA = "0x186FBAA20")]
		internal object MGGOLOICADP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000605")]
	private readonly AOOKNBGCDKI HOBEPAEHHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000606")]
	private IDOKGAKHACO ANANAPJIBKL;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private LDOGEOGHOLH PCEFFCPFNFE
	{
		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x917CA0", Offset = "0x9164A0", VA = "0x180917CA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x8519E0", VA = "0x1808531E0")]
	public GNKDLDAAEML(AOOKNBGCDKI HOBEPAEHHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x6FC22B0", Offset = "0x6FC0AB0", VA = "0x186FC22B0")]
	[AsyncStateMachine(typeof(KNABJDKMEDN))]
	public Task AGALHLJOLPH(BAEGFPFJEKP MPMDJOHBDMD, BCCLEKKJGLB ODJOOIPMNML, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x6FC27D0", Offset = "0x6FC0FD0", VA = "0x186FC27D0")]
	[AsyncStateMachine(typeof(OIJOGIOFDEP))]
	private Task HAKONPBCCBH(BCCLEKKJGLB LINJEFIAFHO, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2E50", Offset = "0x6FC1650", VA = "0x186FC2E50")]
	[AsyncStateMachine(typeof(OPOGGMJIFMG))]
	private Task MJACBELPHDC(BCCLEKKJGLB LINJEFIAFHO, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2F90", Offset = "0x6FC1790", VA = "0x186FC2F90")]
	[AsyncStateMachine(typeof(ALIHIMJOPAI))]
	private Task NIDDOAFCPBL(BCCLEKKJGLB LINJEFIAFHO, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2A30", Offset = "0x6FC1230", VA = "0x186FC2A30")]
	[AsyncStateMachine(typeof(FGBECPLAAGL))]
	private Task KHPOFECAIJA(Guid BLDBPNFIAPG, List<CNEDOEIINNH> FCGOCDPHAPF, NONNNPKNJHH GNKFHIIIPHB, BCCLEKKJGLB LINJEFIAFHO, CancellationToken EOCJCEFCOOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2400", Offset = "0x6FC0C00", VA = "0x186FC2400")]
	[AsyncStateMachine(typeof(PIAJBODKKPG))]
	private Task AOGKIGGKNAO(BCCLEKKJGLB LINJEFIAFHO, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2170", Offset = "0x6FC0970", VA = "0x186FC2170")]
	[AsyncStateMachine(typeof(NMEHDBMMELB))]
	private Task AEMCLNCLDAB(Guid KCMKEFIHCLF, BCCLEKKJGLB LINJEFIAFHO, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2D10", Offset = "0x6FC1510", VA = "0x186FC2D10")]
	[AsyncStateMachine(typeof(JBAKKAMGEEF))]
	private Task MHBNJPAJGBL(Guid KCMKEFIHCLF, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2910", Offset = "0x6FC1110", VA = "0x186FC2910")]
	private void JDGHIGBGGMI(Guid KCMKEFIHCLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2720", Offset = "0x6FC0F20", VA = "0x186FC2720")]
	private void CEELOAFAJNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2B80", Offset = "0x6FC1380", VA = "0x186FC2B80")]
	public Guid LELOEOEJPCG(BAEGFPFJEKP DGDNFAGKJJD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2540", Offset = "0x6FC0D40", VA = "0x186FC2540")]
	[CompilerGenerated]
	private object CDHMCIHGEJO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
internal struct GLMCEPIGLJP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private struct FBKGGJFADBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public GLMCEPIGLJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private IEnumerator<AIDMEJBIGGB> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x6FBE190", Offset = "0x6FBC990", VA = "0x186FBE190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x6FBE870", Offset = "0x6FBD070", VA = "0x186FBE870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000663")]
	private MFEINKDLEHJ EKMGPIDNBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000664")]
	private OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000665")]
	private CancellationToken MPLGBOFHPLM;

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2100", Offset = "0x6FC0900", VA = "0x186FC2100")]
	public static Task GKDNMPIMODG(MFEINKDLEHJ EKMGPIDNBAL, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken CGFBIGKMGCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2010", Offset = "0x6FC0810", VA = "0x186FC2010")]
	[AsyncStateMachine(typeof(FBKGGJFADBF))]
	private Task AGALHLJOLPH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
public readonly struct JJNDGMFMLEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066C")]
	public readonly bool DKJALNHCOGO;

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x216D990", Offset = "0x216C190", VA = "0x18216D990")]
	public JJNDGMFMLEH(bool PHGCMJDPPHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
public readonly struct JBBKCFOEFFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066D")]
	public readonly CKJAAMAMPKA? LJIMKCPNMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	public readonly HCPPCCJPAPN NBDIAENDHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400066F")]
	public readonly string? CECLABBIDNN;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public IReadOnlyCollection<string> GGAGFAHHLKI
	{
		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5390", Offset = "0x6FC3B90", VA = "0x186FC5390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public IReadOnlyDictionary<long, int> PCMMCOJMKMN
	{
		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5370", Offset = "0x6FC3B70", VA = "0x186FC5370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x6FC53B0", Offset = "0x6FC3BB0", VA = "0x186FC53B0")]
	public JBBKCFOEFFA(CKJAAMAMPKA? FCMADEBOIJK, HCPPCCJPAPN HPDOCHJIFMF, string? EEPCKBDHEGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
internal class OPPOPKDPFEJ : ONKMEGIFDPF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct FBMJKKMBOJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public AsyncTaskMethodBuilder<JBBKCFOEFFA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public OPPOPKDPFEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public INAMFDDJCJB serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public LEBMOIGALED roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private PHCOOIGGHEB <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x6FBEF90", Offset = "0x6FBD790", VA = "0x186FBEF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF600", Offset = "0x6FBDE00", VA = "0x186FBF600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private sealed class JENHGHCEACK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public INAMFDDJCJB serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public OPPOPKDPFEJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public JENHGHCEACK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6070", Offset = "0x6FC4870", VA = "0x186FC6070")]
		internal Task NHHHCEINCAB(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6290", Offset = "0x6FC4A90", VA = "0x186FC6290")]
		internal Task OJDLDHGBGNK(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class GLMAGKFFIFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public JENHGHCEACK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public GLMAGKFFIFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1FA0", Offset = "0x6FC07A0", VA = "0x186FC1FA0")]
		internal object AFIAAGDGOFD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class OBPNJGNEAOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public JENHGHCEACK CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public OBPNJGNEAOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x6FCB190", Offset = "0x6FC9990", VA = "0x186FCB190")]
		internal Task MLKMDGFAKKB(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private struct JDPCHIPGNGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public INAMFDDJCJB serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public OPPOPKDPFEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		private GLMAGKFFIFN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x6FC57A0", Offset = "0x6FC3FA0", VA = "0x186FC57A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6010", Offset = "0x6FC4810", VA = "0x186FC6010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000670")]
	private readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.Token(Token = "0x4000671")]
	private static readonly TimeSpan NILDDDBDBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000672")]
	private readonly BOKGGMAHILG HBAOPAHIPOP;

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x6FCEC50", Offset = "0x6FCD450", VA = "0x186FCEC50")]
	public OPPOPKDPFEJ(AOOKNBGCDKI HOBEPAEHHJL, BOKGGMAHILG HBAOPAHIPOP, CDLNJDLNIPA KBNCOADBJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0x6FCEA80", Offset = "0x6FCD280", VA = "0x186FCEA80")]
	[AsyncStateMachine(typeof(FBMJKKMBOJL))]
	public Task<JBBKCFOEFFA> OPCGAJMHMBL(long MMMJFAODPOA, LEBMOIGALED NNEJNOJGJGB, INAMFDDJCJB MEGACNKHFJL, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x6FCE6F0", Offset = "0x6FCCEF0", VA = "0x186FCE6F0")]
	[AsyncStateMachine(typeof(JDPCHIPGNGA))]
	private Task KLFGEGFIBON(INAMFDDJCJB MEGACNKHFJL, IEnumerable<PersistenceView> LALNNECKACD, StringBuilder ENGOKPLGAKB, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x6FCE140", Offset = "0x6FCC940", VA = "0x186FCE140")]
	private JBBKCFOEFFA EOMFACDBNNG(long MMMJFAODPOA, LEBMOIGALED NNEJNOJGJGB, INAMFDDJCJB MEGACNKHFJL, IEnumerable<PersistenceView> LALNNECKACD, StringBuilder ENGOKPLGAKB)
	{
		return default(JBBKCFOEFFA);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x6FCDB40", Offset = "0x6FCC340", VA = "0x186FCDB40")]
	private CKJAAMAMPKA ECOIKMGEIHP(long MMMJFAODPOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x6FCE830", Offset = "0x6FCD030", VA = "0x186FCE830")]
	private void ODDPCKBJAJI(CKJAAMAMPKA GFOADFAGJGL, StringBuilder ENGOKPLGAKB, IEnumerable<PersistenceView> LALNNECKACD, [In] EJPPCDFMGAB NNIAKJBMFAH, KLAHAGABJNO AAPBDGLHGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x6FCDCA0", Offset = "0x6FCC4A0", VA = "0x186FCDCA0")]
	private void EGPAJCOIJFI(CKJAAMAMPKA GFOADFAGJGL, StringBuilder ENGOKPLGAKB, PersistenceView HLFKKKOLNPG, KLAHAGABJNO AAPBDGLHGOD, [In] EJPPCDFMGAB NNIAKJBMFAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
internal class IOFNMIAGIID : ONKMEGIFDPF
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	private sealed class KHMIPGCIMFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public KDDDDHELEIK.OFPJCAGGINJ roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public KHMIPGCIMFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x6FC8360", Offset = "0x6FC6B60", VA = "0x186FC8360")]
		internal object AMOIJKOGANI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private struct PBBBFBGEEKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public AsyncTaskMethodBuilder<(KDDDDHELEIK.OFPJCAGGINJ roomDataUpload, KDDDDHELEIK.OFPJCAGGINJ subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		public JBBKCFOEFFA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public IOFNMIAGIID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private KHMIPGCIMFH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		private TaskAwaiter<KDDDDHELEIK.OFPJCAGGINJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x6FCECA0", Offset = "0x6FCD4A0", VA = "0x186FCECA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x6FCF4F0", Offset = "0x6FCDCF0", VA = "0x186FCF4F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private struct AGJLPMKGJKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public AsyncTaskMethodBuilder<BMBMOGELPMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public IOFNMIAGIID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public JBBKCFOEFFA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public KAIMFMKFBCK roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		private TaskAwaiter<(KDDDDHELEIK.OFPJCAGGINJ roomDataUpload, KDDDDHELEIK.OFPJCAGGINJ subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		private TaskAwaiter<BMBMOGELPMJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8ED0", Offset = "0x6FB76D0", VA = "0x186FB8ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9560", Offset = "0x6FB7D60", VA = "0x186FB9560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private struct FFMNMKIKIKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public AsyncTaskMethodBuilder<LLEPICGCMEA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public IOFNMIAGIID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public JBBKCFOEFFA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		private TaskAwaiter<(KDDDDHELEIK.OFPJCAGGINJ roomDataUpload, KDDDDHELEIK.OFPJCAGGINJ subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		private TaskAwaiter<LLEPICGCMEA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF670", Offset = "0x6FBDE70", VA = "0x186FBF670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x6FBFA80", Offset = "0x6FBE280", VA = "0x186FBFA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private sealed class ICOOGILOKNL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200018C")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006BE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006BF")]
			public AsyncTaskMethodBuilder<JHHNPEBPLNM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006C0")]
			public ICOOGILOKNL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006C1")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006C2")]
			private JHHNPEBPLNM <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006C3")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006C4")]
			private TaskAwaiter<LLEPICGCMEA> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006C5")]
			private TaskAwaiter<BMBMOGELPMJ> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006C6")]
			private TaskAwaiter<JHHNPEBPLNM> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0x6FD0DF0", Offset = "0x6FCF5F0", VA = "0x186FD0DF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0x6FD1D70", Offset = "0x6FD0570", VA = "0x186FD1D70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public IOFNMIAGIID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public JBBKCFOEFFA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public KAIMFMKFBCK roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public JJNDGMFMLEH roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public ICOOGILOKNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4160", Offset = "0x6FC2960", VA = "0x186FC4160")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<JHHNPEBPLNM> LCAMHNHONHA(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private struct OGAHBMDEBIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		public AsyncTaskMethodBuilder<JHHNPEBPLNM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		public IOFNMIAGIID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		public JBBKCFOEFFA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public KAIMFMKFBCK roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public JJNDGMFMLEH roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x6FCB8E0", Offset = "0x6FCA0E0", VA = "0x186FCB8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x6FCBBF0", Offset = "0x6FCA3F0", VA = "0x186FCBBF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000695")]
	private static readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.Token(Token = "0x4000696")]
	private static readonly CDLNJDLNIPA KBKNHCEIBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private readonly OELPCMIPAIF KAGKBNNDDPK;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	private PNHFEHLPHMO NOOCLICDJJM
	{
		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x6FB2BD0", Offset = "0x6FB13D0", VA = "0x186FB2BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x6FC48F0", Offset = "0x6FC30F0", VA = "0x186FC48F0")]
	public IOFNMIAGIID(AOOKNBGCDKI HOBEPAEHHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x6FC4290", Offset = "0x6FC2A90", VA = "0x186FC4290")]
	[AsyncStateMachine(typeof(PBBBFBGEEKC))]
	private Task<(KDDDDHELEIK.OFPJCAGGINJ, KDDDDHELEIK.OFPJCAGGINJ)> FLGKJCLCBHA(JBBKCFOEFFA HLJMJFBMCDD, long DIMOGDCMBFM, long KJMNNDODHCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x6FC46E0", Offset = "0x6FC2EE0", VA = "0x186FC46E0")]
	[AsyncStateMachine(typeof(AGJLPMKGJKE))]
	public Task<BMBMOGELPMJ> KILMPIGDEFN(int HDFLMOLOCCD, [CanBeNull] KAIMFMKFBCK BJEDAIHNLGI, JBBKCFOEFFA HLJMJFBMCDD, long DIMOGDCMBFM, long KJMNNDODHCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x6FC43D0", Offset = "0x6FC2BD0", VA = "0x186FC43D0")]
	[AsyncStateMachine(typeof(FFMNMKIKIKD))]
	private Task<LLEPICGCMEA> IBEFOMBMBBH(string CNCIKMOKNCG, int HDFLMOLOCCD, JBBKCFOEFFA HLJMJFBMCDD, long DIMOGDCMBFM, long KJMNNDODHCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x6FC4540", Offset = "0x6FC2D40", VA = "0x186FC4540")]
	[AsyncStateMachine(typeof(OGAHBMDEBIG))]
	public Task<JHHNPEBPLNM> JNHHAFNJDLP(int HDFLMOLOCCD, KAIMFMKFBCK? BJEDAIHNLGI, JBBKCFOEFFA HLJMJFBMCDD, long DIMOGDCMBFM, long KJMNNDODHCP, JJNDGMFMLEH ADMCGJGIPAE, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
public abstract class JKOFPHHMCIB<T> where T : JKOFPHHMCIB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D3")]
	internal readonly PNHFEHLPHMO HFPIOMLCALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D4")]
	private int? DKHDGICDBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D5")]
	protected readonly Guid BCGKIOLOHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D6")]
	protected readonly KPFIKNDEFFO IPFOHGNPEKN;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	protected T FBLEFNNFHEC
	{
		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x40A4720", Offset = "0x40A2F20", VA = "0x1840A4720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x40A4AC0", Offset = "0x40A32C0", VA = "0x1840A4AC0")]
	internal JKOFPHHMCIB(PNHFEHLPHMO NKLGIGDEHPG, KPFIKNDEFFO OFNDKLGKJDP, [Optional] Guid? KPMGFINBLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x40A49E0", Offset = "0x40A31E0", VA = "0x1840A49E0")]
	private JHHNPEBPLNM PENLDJAENCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "4")]
	protected virtual void PEKBGBCPAFB(JHHNPEBPLNM JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x40A4780", Offset = "0x40A2F80", VA = "0x1840A4780")]
	public T KJEEAGABNJN(LCMANADAOPN GFABMNOLKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x40A4810", Offset = "0x40A3010", VA = "0x1840A4810")]
	public T KLGMHMFMGJM(int GNKJGCJCNCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x40A48B0", Offset = "0x40A30B0", VA = "0x1840A48B0", Slot = "5")]
	public virtual Task<DGFDNIJCPMA> NLMPIJBFLPJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
public class JNAKBMBBKNN : JKOFPHHMCIB<JNAKBMBBKNN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006D7")]
	private JBBIANFGILF MIJPDJDOIDB;

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x6FC72B0", Offset = "0x6FC5AB0", VA = "0x186FC72B0")]
	internal JNAKBMBBKNN(PNHFEHLPHMO NKLGIGDEHPG, KPFIKNDEFFO OFNDKLGKJDP, [Optional] Guid? KPMGFINBLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x64EB4E0", Offset = "0x64E9CE0", VA = "0x1864EB4E0")]
	public JNAKBMBBKNN DKFDBKAIPAL(JBBIANFGILF MIJPDJDOIDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x6FC71E0", Offset = "0x6FC59E0", VA = "0x186FC71E0", Slot = "4")]
	protected override void PEKBGBCPAFB(JHHNPEBPLNM JNNDBFGKHHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public class PKDPFMCHDKO : JKOFPHHMCIB<PKDPFMCHDKO>
{
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	internal enum NEGBDBAAHJL
	{
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private struct EDFKPOAPOML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		public AsyncTaskMethodBuilder<DGFDNIJCPMA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public PKDPFMCHDKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		private TaskAwaiter<DGFDNIJCPMA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD2A0", Offset = "0x6FBBAA0", VA = "0x186FBD2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD640", Offset = "0x6FBBE40", VA = "0x186FBD640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	private NEGBDBAAHJL OJMGIAOGCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	private string JKHIABFAKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	private KAIMFMKFBCK MIJPDJDOIDB;

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x6FCFFD0", Offset = "0x6FCE7D0", VA = "0x186FCFFD0")]
	internal PKDPFMCHDKO(PNHFEHLPHMO NKLGIGDEHPG, KPFIKNDEFFO OFNDKLGKJDP, [Optional] Guid? KPMGFINBLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x6FCFD00", Offset = "0x6FCE500", VA = "0x186FCFD00")]
	public PKDPFMCHDKO CJJIFNBEFLM(string OLBMKMHMAID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x6FCFCB0", Offset = "0x6FCE4B0", VA = "0x186FCFCB0")]
	public PKDPFMCHDKO ANIMIMMOMJN(bool IFNMMJBNOOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x6FCFCD0", Offset = "0x6FCE4D0", VA = "0x186FCFCD0")]
	public PKDPFMCHDKO CGDKPENHAOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x6FCFE60", Offset = "0x6FCE660", VA = "0x186FCFE60", Slot = "4")]
	protected override void PEKBGBCPAFB(JHHNPEBPLNM JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x6FCFD70", Offset = "0x6FCE570", VA = "0x186FCFD70", Slot = "5")]
	[AsyncStateMachine(typeof(EDFKPOAPOML))]
	public override Task<DGFDNIJCPMA> NLMPIJBFLPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x6FCFD30", Offset = "0x6FCE530", VA = "0x186FCFD30")]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task<DGFDNIJCPMA> NIGHHPCGLLN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
internal static class COCNFEPHPJE
{
	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC820", Offset = "0x6FBB020", VA = "0x186FBC820")]
	public static void EMKJDLKKJMJ(this PEJDDGDCLFF OPGANEAFOBB, MDBDBMHCDOA EJBBNMBAICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC970", Offset = "0x6FBB170", VA = "0x186FBC970")]
	public static void GLEGLCIMJNP(this MDBDBMHCDOA AKLKCJCNCJP, [Optional] string JNNDBFGKHHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
public static class ONAHBABICHB
{
	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x6FCCD90", Offset = "0x6FCB590", VA = "0x186FCCD90")]
	public static KEOGFOOKLEH OCOHMLNJCMB(this MJHHKFADFIN KIKMALBGNCI)
	{
		return default(KEOGFOOKLEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x6FCCCE0", Offset = "0x6FCB4E0", VA = "0x186FCCCE0")]
	public static MJHHKFADFIN HOEGBACGNOI(this KEOGFOOKLEH EKCHGKAGDHK)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x2000195")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000196")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006E7")]
			public IOJDCLBFPMF ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006E8")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006E9")]
			public IOJDCLBFPMF HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006EA")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006EB")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006EC")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		private static IOJDCLBFPMF[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		private Dictionary<IOJDCLBFPMF, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x6FD2450", Offset = "0x6FD0C50", VA = "0x186FD2450")]
		public bool LDOIADAMLNM(IOJDCLBFPMF MNCJHJGEMJG, [Out] ResultConfig AACIHKHGIHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x6FD2310", Offset = "0x6FD0B10", VA = "0x186FD2310")]
		public ResultConfig INOGKEJOMCC(IOJDCLBFPMF NPGFMGMHJJL, [Optional] HashSet<IOJDCLBFPMF> PJIJOJLNADK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x6FD2A20", Offset = "0x6FD1220", VA = "0x186FD2A20", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x6FD24C0", Offset = "0x6FD0CC0", VA = "0x186FD24C0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x8BEAE0", Offset = "0x8BD2E0", VA = "0x1808BEAE0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
public static class HHBANNGACOC
{
	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x6FC30D0", Offset = "0x6FC18D0", VA = "0x186FC30D0")]
	[GDGALFJPCGE(JMIPDAHBNNG.GameOnly)]
	private static void CEJDNEABNOB(INCIOHANCNE LDLMDJOAIBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
public interface NCKGPLMHNNB : IEquatable<NCKGPLMHNNB>
{
	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	DateTime CDOJLDGOHIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IGLJKNPEBFK();

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FLEPJADKKGI(long DIMOGDCMBFM, long MMMJFAODPOA, [Out] JBBKCFOEFFA HLJMJFBMCDD);
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
internal class BAIIAJAOGAH : APCMDALIFAP
{
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private sealed class MKGEJBEALMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		public HCEEFOPOCMM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public MKGEJBEALMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x6FD56F0", Offset = "0x6FD3EF0", VA = "0x186FD56F0")]
		internal object HILAFDMLMPO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006F2")]
	private readonly PDMHIOFNOPB GDDDILGMPMI;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<NCKGPLMHNNB> FIPANKDGOFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9F10", Offset = "0x6FB8710", VA = "0x186FB9F10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x6FBA970", Offset = "0x6FB9170", VA = "0x186FBA970", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x8519E0", VA = "0x1808531E0")]
	[UnityEngine.Scripting.Preserve]
	public BAIIAJAOGAH([OMAPKKAGFIL(null)] PDMHIOFNOPB GDDDILGMPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9FC0", Offset = "0x6FB87C0", VA = "0x186FB9FC0", Slot = "6")]
	public bool BGOHNIEEPOG(long DIMOGDCMBFM, long MMMJFAODPOA, JBBKCFOEFFA HLJMJFBMCDD, HCEEFOPOCMM LKIPKDFOIKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x1C29A90", Offset = "0x1C28290", VA = "0x181C29A90")]
	private void DCPMOMGGEIJ(NCKGPLMHNNB NHABHPPMDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9DA0", Offset = "0x6FB85A0", VA = "0x186FB9DA0", Slot = "7")]
	public bool AMEPMODJGEG(long DIMOGDCMBFM, long MMMJFAODPOA, [Out] NCKGPLMHNNB HEEEABJCCCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x6FBA7A0", Offset = "0x6FB8FA0", VA = "0x186FBA7A0", Slot = "8")]
	public bool HNIMFMKAJPB(long DIMOGDCMBFM, long MMMJFAODPOA, HCEEFOPOCMM LKIPKDFOIKO, [Out] NCKGPLMHNNB HEEEABJCCCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x6FBA300", Offset = "0x6FB8B00", VA = "0x186FBA300")]
	private void BKBJFGHMADN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x6FBA850", Offset = "0x6FB9050", VA = "0x186FBA850", Slot = "9")]
	public void IHHNIIDNNKG(long DIMOGDCMBFM, long MMMJFAODPOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
internal abstract class FNABHGGPMDG : PDMHIOFNOPB
{
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	protected enum LMIIJCPEHGG : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[CompilerGenerated]
	private sealed class MLCFCHICDHB : IEnumerable<NCKGPLMHNNB>, IEnumerable, IEnumerator<NCKGPLMHNNB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		private NCKGPLMHNNB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		public FNABHGGPMDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		private HCEEFOPOCMM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		public HCEEFOPOCMM <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		private NCKGPLMHNNB System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000665")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000667")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x89FD00", Offset = "0x89E500", VA = "0x18089FD00")]
		[DebuggerHidden]
		public MLCFCHICDHB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5760", Offset = "0x6FD3F60", VA = "0x186FD5760", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5A40", Offset = "0x6FD4240", VA = "0x186FD5A40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5990", Offset = "0x6FD4190", VA = "0x186FD5990", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NCKGPLMHNNB> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5990", Offset = "0x6FD4190", VA = "0x186FD5990", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	[CompilerGenerated]
	private sealed class CAJEAPOJAJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public HCEEFOPOCMM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public CAJEAPOJAJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3D80", Offset = "0x6FD2580", VA = "0x186FD3D80")]
		internal object HHPEHHGJNNP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	[CompilerGenerated]
	private sealed class BIMDNNLPEAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public FNABHGGPMDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public BIMDNNLPEAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x6FD2DC0", Offset = "0x6FD15C0", VA = "0x186FD2DC0")]
		internal void KAJFMGNMAGC(BODEGEDJFLM.KNDNPIAAOJO ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006F8")]
	private readonly object KMHKNAKFPLJ;

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	protected string JALMHGGOKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x6FD4410", Offset = "0x6FD2C10", VA = "0x186FD4410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public abstract NJNINEFDHOO LDONDENFFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x6FD4830", Offset = "0x6FD3030", VA = "0x186FD4830")]
	protected FNABHGGPMDG([CanBeNull] string JGDBHEDCOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3E90", Offset = "0x6FD2690", VA = "0x186FD3E90", Slot = "5")]
	public bool GABAFEMFKLM(long DIMOGDCMBFM, long MMMJFAODPOA, HCEEFOPOCMM LKIPKDFOIKO, [Out] NCKGPLMHNNB NHABHPPMDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x6FD47A0", Offset = "0x6FD2FA0", VA = "0x186FD47A0", Slot = "6")]
	[IteratorStateMachine(typeof(MLCFCHICDHB))]
	public IEnumerable<NCKGPLMHNNB> OIPJIEMLAMM(HCEEFOPOCMM LKIPKDFOIKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void CPEAEKPGHDH(Stream BNJJDODGDJC, long DIMOGDCMBFM, long MMMJFAODPOA, JBBKCFOEFFA HLJMJFBMCDD);

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool BHEHJCNOINI(Stream MMOLAPACPMC, long DIMOGDCMBFM, long MMMJFAODPOA, IOPFFLOBCBM GLPDMIFJKNA, [Out] JBBKCFOEFFA HLJMJFBMCDD);

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x6FD4420", Offset = "0x6FD2C20", VA = "0x186FD4420", Slot = "7")]
	public NCKGPLMHNNB NINJAPGBAPF(long DIMOGDCMBFM, long MMMJFAODPOA, JBBKCFOEFFA HLJMJFBMCDD, HCEEFOPOCMM LKIPKDFOIKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo FMPENCBMNAB(long DIMOGDCMBFM, long MMMJFAODPOA, HCEEFOPOCMM LKIPKDFOIKO, LMIIJCPEHGG GFALHOIMFPG);

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo JNOIECBPKHC(HCEEFOPOCMM LKIPKDFOIKO, LMIIJCPEHGG GFALHOIMFPG);

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3E20", Offset = "0x6FD2620", VA = "0x186FD3E20")]
	protected void FMFBLIKAKBD(BODEGEDJFLM.KNDNPIAAOJO KNBEEMJODEI, string ALLEHOLILJB, FileInfo NMFNNOJLCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x6FD4080", Offset = "0x6FD2880", VA = "0x186FD4080")]
	internal bool GGALNMKFMLH(FileInfo LHALDDCEPNI, long DIMOGDCMBFM, long MMMJFAODPOA, [Out] JBBKCFOEFFA HLJMJFBMCDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
	private void DOBDIENEIOJ(Exception NKAKJFGNGPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
internal class LCJFCBFJIIL : FNABHGGPMDG
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public override NJNINEFDHOO LDONDENFFCN
	{
		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0xCAE4C0", Offset = "0xCACCC0", VA = "0x180CAE4C0", Slot = "8")]
		get
		{
			return default(NJNINEFDHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x6FD56B0", Offset = "0x6FD3EB0", VA = "0x186FD56B0")]
	public LCJFCBFJIIL([Optional] string JGDBHEDCOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x6FD5530", Offset = "0x6FD3D30", VA = "0x186FD5530")]
	private void IJOLNNCNOCK(HCEEFOPOCMM LKIPKDFOIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x6FD51B0", Offset = "0x6FD39B0", VA = "0x186FD51B0", Slot = "9")]
	internal override void CPEAEKPGHDH(Stream BNJJDODGDJC, long DIMOGDCMBFM, long MMMJFAODPOA, JBBKCFOEFFA HLJMJFBMCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x6FD4BD0", Offset = "0x6FD33D0", VA = "0x186FD4BD0", Slot = "10")]
	internal override bool BHEHJCNOINI(Stream MMOLAPACPMC, long DIMOGDCMBFM, long MMMJFAODPOA, IOPFFLOBCBM GLPDMIFJKNA, [Out] JBBKCFOEFFA HLJMJFBMCDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x6FD5440", Offset = "0x6FD3C40", VA = "0x186FD5440", Slot = "11")]
	protected override FileInfo FMPENCBMNAB(long DIMOGDCMBFM, long MMMJFAODPOA, HCEEFOPOCMM LKIPKDFOIKO, LMIIJCPEHGG GFALHOIMFPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x6FD55B0", Offset = "0x6FD3DB0", VA = "0x186FD55B0", Slot = "12")]
	protected override DirectoryInfo JNOIECBPKHC(HCEEFOPOCMM LKIPKDFOIKO, LMIIJCPEHGG GFALHOIMFPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal sealed class PDDMKIGFEOI : FNABHGGPMDG
{
	[Cpp2IlInjected.Token(Token = "0x4000708")]
	private static readonly byte[] NDDCLPHCEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000709")]
	private readonly byte[] ACPBGFGNPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400070A")]
	private readonly byte[] MINLNEFMHEG;

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public override NJNINEFDHOO LDONDENFFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x5D820B0", Offset = "0x5D808B0", VA = "0x185D820B0", Slot = "8")]
		get
		{
			return default(NJNINEFDHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x6FD6E40", Offset = "0x6FD5640", VA = "0x186FD6E40")]
	public PDDMKIGFEOI([Optional] string JGDBHEDCOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x6FD67F0", Offset = "0x6FD4FF0", VA = "0x186FD67F0", Slot = "9")]
	internal override void CPEAEKPGHDH(Stream BNJJDODGDJC, long DIMOGDCMBFM, long MMMJFAODPOA, JBBKCFOEFFA HLJMJFBMCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x6FD6020", Offset = "0x6FD4820", VA = "0x186FD6020", Slot = "10")]
	internal override bool BHEHJCNOINI(Stream MMOLAPACPMC, long DIMOGDCMBFM, long MMMJFAODPOA, IOPFFLOBCBM GLPDMIFJKNA, [Out] JBBKCFOEFFA HLJMJFBMCDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x6FD6AB0", Offset = "0x6FD52B0", VA = "0x186FD6AB0")]
	private void FFFHPGPEGLO(byte[] DDNKCFIIBGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x6FD6B70", Offset = "0x6FD5370", VA = "0x186FD6B70", Slot = "11")]
	protected override FileInfo FMPENCBMNAB(long DIMOGDCMBFM, long MMMJFAODPOA, HCEEFOPOCMM LKIPKDFOIKO, LMIIJCPEHGG GFALHOIMFPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x6FD6CA0", Offset = "0x6FD54A0", VA = "0x186FD6CA0", Slot = "12")]
	protected override DirectoryInfo JNOIECBPKHC(HCEEFOPOCMM LKIPKDFOIKO, LMIIJCPEHGG GFALHOIMFPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
public enum NJNINEFDHOO : byte
{
	[Cpp2IlInjected.Token(Token = "0x400070C")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x400070D")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x400070E")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001A5")]
internal class BJGOPAHGMNK : PDMHIOFNOPB
{
	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[CompilerGenerated]
	private sealed class NOKHNFDAFNO : IEnumerable<NCKGPLMHNNB>, IEnumerable, IEnumerator<NCKGPLMHNNB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		private NCKGPLMHNNB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public BJGOPAHGMNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		private HCEEFOPOCMM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		public HCEEFOPOCMM <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		private NJNINEFDHOO[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		private IEnumerator<NCKGPLMHNNB> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		private NCKGPLMHNNB System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600068C")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600068E")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x89FD00", Offset = "0x89E500", VA = "0x18089FD00")]
		[DebuggerHidden]
		public NOKHNFDAFNO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5F90", Offset = "0x6FD4790", VA = "0x186FD5F90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5AE0", Offset = "0x6FD42E0", VA = "0x186FD5AE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5A90", Offset = "0x6FD4290", VA = "0x186FD5A90")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5F40", Offset = "0x6FD4740", VA = "0x186FD5F40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5E90", Offset = "0x6FD4690", VA = "0x186FD5E90", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NCKGPLMHNNB> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5E90", Offset = "0x6FD4690", VA = "0x186FD5E90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400070F")]
	private readonly NJNINEFDHOO[] LDBFPDFCCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000710")]
	private readonly Dictionary<NJNINEFDHOO, PDMHIOFNOPB> KMMCJNEPACA;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public NJNINEFDHOO LDONDENFFCN
	{
		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3820", Offset = "0x6FD2020", VA = "0x186FD3820", Slot = "4")]
		get
		{
			return default(NJNINEFDHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3A30", Offset = "0x6FD2230", VA = "0x186FD3A30")]
	[UnityEngine.Scripting.Preserve]
	public BJGOPAHGMNK(params PDMHIOFNOPB[] FAIKPHELKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x6FD36D0", Offset = "0x6FD1ED0", VA = "0x186FD36D0", Slot = "5")]
	public bool GABAFEMFKLM(long DIMOGDCMBFM, long MMMJFAODPOA, HCEEFOPOCMM LKIPKDFOIKO, [Out] NCKGPLMHNNB NHABHPPMDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x6FD34B0", Offset = "0x6FD1CB0", VA = "0x186FD34B0")]
	private void DFFFBBMOJKB(int KJLNIBNFALP, long DIMOGDCMBFM, long MMMJFAODPOA, HCEEFOPOCMM LKIPKDFOIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x6FD39A0", Offset = "0x6FD21A0", VA = "0x186FD39A0", Slot = "6")]
	[IteratorStateMachine(typeof(NOKHNFDAFNO))]
	public IEnumerable<NCKGPLMHNNB> OIPJIEMLAMM(HCEEFOPOCMM LKIPKDFOIKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3850", Offset = "0x6FD2050", VA = "0x186FD3850", Slot = "7")]
	public NCKGPLMHNNB NINJAPGBAPF(long DIMOGDCMBFM, long MMMJFAODPOA, JBBKCFOEFFA HLJMJFBMCDD, HCEEFOPOCMM LKIPKDFOIKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
internal static class IIIFNHKDNCH
{
	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x6FD48B0", Offset = "0x6FD30B0", VA = "0x186FD48B0")]
	internal static byte[] HBPMLDJOMEN(byte[] DDNKCFIIBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x6FD4970", Offset = "0x6FD3170", VA = "0x186FD4970")]
	public static void JBIAPOEPLLI(Stream EDOGOHPOPNO, byte[] HNENGEFLMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0x6FD49F0", Offset = "0x6FD31F0", VA = "0x186FD49F0")]
	public static bool NOCKNFNDHKD(Stream EDOGOHPOPNO, long DMNDKKPPFFL, IOPFFLOBCBM KBOLGJGNIGE, [Out] byte[] ANCDIFNJCND)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
internal sealed class BJBFNGEEGKK : NCKGPLMHNNB, IEquatable<NCKGPLMHNNB>, IEquatable<BJBFNGEEGKK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400071E")]
	private readonly FNABHGGPMDG EKGGLPDLAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400071F")]
	public readonly FileInfo MNCEOGOIGEH;

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public NJNINEFDHOO LDONDENFFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x699F390", Offset = "0x699DB90", VA = "0x18699F390", Slot = "9")]
		get
		{
			return default(NJNINEFDHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public DateTime CDOJLDGOHIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x6FD30D0", Offset = "0x6FD18D0", VA = "0x186FD30D0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x6FD33A0", Offset = "0x6FD1BA0", VA = "0x186FD33A0")]
	public BJBFNGEEGKK(FNABHGGPMDG OJKACGONHKN, FileInfo LHALDDCEPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x6FD32F0", Offset = "0x6FD1AF0", VA = "0x186FD32F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3230", Offset = "0x6FD1A30", VA = "0x186FD3230", Slot = "5")]
	public void IGLJKNPEBFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3160", Offset = "0x6FD1960", VA = "0x186FD3160", Slot = "6")]
	public bool FLEPJADKKGI(long DIMOGDCMBFM, long MMMJFAODPOA, [Out] JBBKCFOEFFA HLJMJFBMCDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2FF0", Offset = "0x6FD17F0", VA = "0x186FD2FF0", Slot = "7")]
	public bool Equals(NCKGPLMHNNB OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2F30", Offset = "0x6FD1730", VA = "0x186FD2F30", Slot = "8")]
	public bool Equals(BJBFNGEEGKK OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2E40", Offset = "0x6FD1640", VA = "0x186FD2E40", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x6FD31A0", Offset = "0x6FD19A0", VA = "0x186FD31A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AA")]
public delegate void IOPFFLOBCBM(BODEGEDJFLM.KNDNPIAAOJO KLOBGAANGMC, string JNNDBFGKHHD);
[Cpp2IlInjected.Token(Token = "0x20001AB")]
internal interface PDMHIOFNOPB
{
	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	NJNINEFDHOO LDONDENFFCN
	{
		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GABAFEMFKLM(long DIMOGDCMBFM, long MMMJFAODPOA, HCEEFOPOCMM LKIPKDFOIKO, [Out] NCKGPLMHNNB NHABHPPMDON);

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<NCKGPLMHNNB> OIPJIEMLAMM(HCEEFOPOCMM LKIPKDFOIKO);

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NCKGPLMHNNB NINJAPGBAPF(long DIMOGDCMBFM, long MMMJFAODPOA, JBBKCFOEFFA HLJMJFBMCDD, HCEEFOPOCMM LKIPKDFOIKO);
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
