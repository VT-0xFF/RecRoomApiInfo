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
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87B0C0", VA = "0x18087C6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F7BE40", Offset = "0x6F7A840", VA = "0x186F7BE40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87D9C0", Offset = "0x87C3C0", VA = "0x18087D9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87DA00", Offset = "0x87C400", VA = "0x18087DA00")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F74CC0", Offset = "0x6F736C0", VA = "0x186F74CC0", Slot = "4")]
		public override void JGBCFAKMKJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87B0C0", VA = "0x18087C6C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MPEKIJEOIGF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B070", Offset = "0x6F79A70", VA = "0x186F7B070")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F67AD0", Offset = "0x6F664D0", VA = "0x186F67AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F67D10", Offset = "0x6F66710", VA = "0x186F67D10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F62960", Offset = "0x6F61360", VA = "0x186F62960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6F62B70", Offset = "0x6F61570", VA = "0x186F62B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	[UnityEngine.Scripting.Preserve]
	public OLKMFFNIKBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C7F0", Offset = "0x6F7B1F0", VA = "0x186F7C7F0", Slot = "4")]
	[AsyncStateMachine(typeof(EGMINFDGBLA))]
	public Task<IReadOnlyList<HNKJBJIHEKD>> ONIIPBCLFIM(long DIMOGDCMBFM, long KJMNNDODHCP, [Optional] CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C6E0", Offset = "0x6F7B0E0", VA = "0x186F7C6E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F68D40", Offset = "0x6F67740", VA = "0x186F68D40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6F691E0", Offset = "0x6F67BE0", VA = "0x186F691E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x85FD10", Offset = "0x85E710", VA = "0x18085FD10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8512A0", VA = "0x1808528A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x5B05B70", Offset = "0x5B04570", VA = "0x185B05B70", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public COGBIDCIEPE? DGLMILFGMCA
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1C13D00", Offset = "0x1C12700", VA = "0x181C13D00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public MGMLPCEDDPE? DLOJPFEFPEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5B05C50", Offset = "0x5B04650", VA = "0x185B05C50", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public AJDCLNNIJGN KDKOLJHNILF
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8C3EC0", Offset = "0x8C28C0", VA = "0x1808C3EC0", Slot = "10")]
			get
			{
				return default(AJDCLNNIJGN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6F71670", Offset = "0x6F70070", VA = "0x186F71670", Slot = "9")]
		[AsyncStateMachine(typeof(ENPAGPABADO))]
		public Task<DGFDNIJCPMA> HJKBNIFJLCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6F717B0", Offset = "0x6F701B0", VA = "0x186F717B0")]
		public JNNKLAGBMGO(int AEJFNKCGKJL, CCBKILLIDJI GKPLKHNIAAM, HNKJBJIHEKD HAFLHBJODHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6F71560", Offset = "0x6F6FF60", VA = "0x186F71560", Slot = "11")]
		public bool Equals(HCBILDDEOJN OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6F714C0", Offset = "0x6F6FEC0", VA = "0x186F714C0", Slot = "0")]
		public override bool Equals(object MEAFIMADMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6F71770", Offset = "0x6F70170", VA = "0x186F71770")]
		private bool NHAJPMJLCKB(JNNKLAGBMGO OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6F715F0", Offset = "0x6F6FFF0", VA = "0x186F715F0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F66440", Offset = "0x6F64E40", VA = "0x186F66440", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6F66670", Offset = "0x6F65070", VA = "0x186F66670", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F72370", Offset = "0x6F70D70", VA = "0x186F72370", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public CCBKILLIDJI NCPBHLHBGEL
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6F72770", Offset = "0x6F71170", VA = "0x186F72770", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime DCKEHFJHKEG
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6F72670", Offset = "0x6F71070", VA = "0x186F72670", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public COGBIDCIEPE? DGLMILFGMCA
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6F72720", Offset = "0x6F71120", VA = "0x186F72720", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public MGMLPCEDDPE? DLOJPFEFPEE
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6F72800", Offset = "0x6F71200", VA = "0x186F72800", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public AJDCLNNIJGN KDKOLJHNILF
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8CA1D0", Offset = "0x8C8BD0", VA = "0x1808CA1D0", Slot = "10")]
			get
			{
				return default(AJDCLNNIJGN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x10DD5D0", Offset = "0x10DBFD0", VA = "0x1810DD5D0")]
		public KAMPFFDNOIJ(NCKGPLMHNNB NHABHPPMDON, COGBIDCIEPE LMDAHADOCMG, MGMLPCEDDPE AFEBLMEGKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6F72580", Offset = "0x6F70F80", VA = "0x186F72580", Slot = "9")]
		[AsyncStateMachine(typeof(DFKFCDNLHDB))]
		public Task<DGFDNIJCPMA> HJKBNIFJLCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6F723B0", Offset = "0x6F70DB0", VA = "0x186F723B0", Slot = "11")]
		public bool Equals(HCBILDDEOJN OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6F72450", Offset = "0x6F70E50", VA = "0x186F72450", Slot = "0")]
		public override bool Equals(object MEAFIMADMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6F726C0", Offset = "0x6F710C0", VA = "0x186F726C0")]
		private bool NHAJPMJLCKB(KAMPFFDNOIJ OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6F72500", Offset = "0x6F70F00", VA = "0x186F72500", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F642D0", Offset = "0x6F62CD0", VA = "0x186F642D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6F64510", Offset = "0x6F62F10", VA = "0x186F64510", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F7C1B0", Offset = "0x6F7ABB0", VA = "0x186F7C1B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime DCKEHFJHKEG
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852CA0", VA = "0x1808542A0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public COGBIDCIEPE? DGLMILFGMCA
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6F7C640", Offset = "0x6F7B040", VA = "0x186F7C640", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public MGMLPCEDDPE? DLOJPFEFPEE
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6F7C690", Offset = "0x6F7B090", VA = "0x186F7C690", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public AJDCLNNIJGN KDKOLJHNILF
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852CA0", VA = "0x1808542A0", Slot = "10")]
			get
			{
				return default(AJDCLNNIJGN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x10DD5D0", Offset = "0x10DBFD0", VA = "0x1810DD5D0")]
		public OGPPILHBAGM(CCBKILLIDJI GKPLKHNIAAM, COGBIDCIEPE LMDAHADOCMG, MGMLPCEDDPE AFEBLMEGKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C490", Offset = "0x6F7AE90", VA = "0x186F7C490", Slot = "9")]
		[AsyncStateMachine(typeof(CIFHBDIJGDN))]
		public Task<DGFDNIJCPMA> HJKBNIFJLCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C2F0", Offset = "0x6F7ACF0", VA = "0x186F7C2F0", Slot = "11")]
		public bool Equals(HCBILDDEOJN OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C1D0", Offset = "0x6F7ABD0", VA = "0x186F7C1D0", Slot = "0")]
		public override bool Equals(object MEAFIMADMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C400", Offset = "0x6F7AE00", VA = "0x186F7C400", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C560", Offset = "0x6F7AF60", VA = "0x186F7C560")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F6FF20", Offset = "0x6F6E920", VA = "0x186F6FF20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6F70D60", Offset = "0x6F6F760", VA = "0x186F70D60", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F72FE0", Offset = "0x6F719E0", VA = "0x186F72FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6F739C0", Offset = "0x6F723C0", VA = "0x186F739C0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x6F69650", Offset = "0x6F68050", VA = "0x186F69650")]
	[UnityEngine.Scripting.Preserve]
	public FEJGLEBLKDD([OMAPKKAGFIL(null)] JBKFOMDLCHJ JCGADIJBGCL, [OMAPKKAGFIL(null)] APCMDALIFAP GCIHBOGNOCG, [OMAPKKAGFIL(null)] GNGNHODIFED BADCNKLHNGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6F69500", Offset = "0x6F67F00", VA = "0x186F69500")]
	[AsyncStateMachine(typeof(JJDJOJDEFBB))]
	public Task<IList<HCBILDDEOJN>> PMIGKKKHMEG(long DIMOGDCMBFM, long MMMJFAODPOA, bool LBHNFPLLPPA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6F69250", Offset = "0x6F67C50", VA = "0x186F69250")]
	private bool DAACIBEADMJ(DateTime? KNOJCNGFFGF, long DIMOGDCMBFM, long MMMJFAODPOA, [Out] NCKGPLMHNNB HEEEABJCCCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6F693F0", Offset = "0x6F67DF0", VA = "0x186F693F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6F62C30", Offset = "0x6F61630", VA = "0x186F62C30")]
	public BIDJCBPPELH(long LBHHCOPBEOO, long KJMNNDODHCP, EMDPEFDABNM NCMHJNKFAGH, [CanBeNull] Exception NFPCHIICMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6F62BE0", Offset = "0x6F615E0", VA = "0x186F62BE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6F72320", Offset = "0x6F70D20", VA = "0x186F72320")]
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
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8512A0", VA = "0x1808528A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x852870", Offset = "0x851270", VA = "0x180852870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x851BE0", VA = "0x1808531E0")]
	public LOEOIDGPKKK(MDBDBMHCDOA AKLKCJCNCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6F74B60", Offset = "0x6F73560", VA = "0x186F74B60")]
	public LOEOIDGPKKK AGIBFGMAADE(string NDDCLPHCEEO, string JMDCGOKJIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6F74C30", Offset = "0x6F73630", VA = "0x186F74C30")]
	public bool OCMIHLIDOHH([Out] IEnumerable<KeyValuePair<string, string>> NIPKJPFADEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x61D90C0", Offset = "0x61D7AC0", VA = "0x1861D90C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F7BEC0", Offset = "0x6F7A8C0", VA = "0x186F7BEC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C140", Offset = "0x6F7AB40", VA = "0x186F7C140", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F64040", Offset = "0x6F62A40", VA = "0x186F64040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x6F64270", Offset = "0x6F62C70", VA = "0x186F64270", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x89FD00", Offset = "0x89E700", VA = "0x18089FD00")]
		[DebuggerHidden]
		public NDJELHOCNHH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B0E0", Offset = "0x6F79AE0", VA = "0x186F7B0E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B540", Offset = "0x6F79F40", VA = "0x186F7B540", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B490", Offset = "0x6F79E90", VA = "0x186F7B490", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DLOEDDKPHPI> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B490", Offset = "0x6F79E90", VA = "0x186F7B490", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8569D0", Offset = "0x8553D0", VA = "0x1808569D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public DEBFMJKLBDN DJEMJGOJCKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x856300", Offset = "0x854D00", VA = "0x180856300", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8562F0", Offset = "0x854CF0", VA = "0x1808562F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public MFEINKDLEHJ KFKHEOKCKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x856340", Offset = "0x854D40", VA = "0x180856340", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x856330", Offset = "0x854D30", VA = "0x180856330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public INNHEOLIKBM MDBMBBPHIBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x856320", Offset = "0x854D20", VA = "0x180856320", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x856310", Offset = "0x854D10", VA = "0x180856310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public NBAHHDNKILP GCINGEDLGMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x856A90", Offset = "0x855490", VA = "0x180856A90", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x856B60", Offset = "0x855560", VA = "0x180856B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public OMKEILKNJFC OHKEMMFEOLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x856BA0", Offset = "0x8555A0", VA = "0x180856BA0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x856BD0", Offset = "0x8555D0", VA = "0x180856BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public BOAMHEKDIOK DNKBABKCKEM
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x85FD30", Offset = "0x85E730", VA = "0x18085FD30", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x85FD60", Offset = "0x85E760", VA = "0x18085FD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public GAGJCKDHAGD GDMOGGJEDBM
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x85FE60", Offset = "0x85E860", VA = "0x18085FE60", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x85FE80", Offset = "0x85E880", VA = "0x18085FE80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public EMPCKPBJDBG DNFGAGHGFEP
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x85FE70", Offset = "0x85E870", VA = "0x18085FE70", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x85FEB0", Offset = "0x85E8B0", VA = "0x18085FEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public MDIOJHKPIFM AEFEHKNIGLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9C0350", Offset = "0x9BED50", VA = "0x1809C0350", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9EE3B0", Offset = "0x9ECDB0", VA = "0x1809EE3B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public CDPDCOBHLKK FIIGPOBAGDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x85FDF0", Offset = "0x85E7F0", VA = "0x18085FDF0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x85FD70", Offset = "0x85E770", VA = "0x18085FD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public FFDBLCGPPMM KPMOHDGEAPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9E66A0", Offset = "0x9E50A0", VA = "0x1809E66A0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9C5320", Offset = "0x9C3D20", VA = "0x1809C5320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public GPMIBIFCKBJ CMHDFDJFCNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x85DEA0", Offset = "0x85C8A0", VA = "0x18085DEA0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x85DEE0", Offset = "0x85C8E0", VA = "0x18085DEE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public DHPDBLFEFKM BNNHJAOKOAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xB8BBA0", Offset = "0xB8A5A0", VA = "0x180B8BBA0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xB93B60", Offset = "0xB92560", VA = "0x180B93B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public IENMFFFGEPA MPEIAOIBKNK
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x947DD0", Offset = "0x9467D0", VA = "0x180947DD0", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x93DBD0", Offset = "0x93C5D0", VA = "0x18093DBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public KIJJEBJPOIH OJKPJCDHHDP
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x9475A0", Offset = "0x945FA0", VA = "0x1809475A0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x948B10", Offset = "0x947510", VA = "0x180948B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public LNJOHEOEPEC AFNPDMELIEH
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8BD870", Offset = "0x8BC270", VA = "0x1808BD870", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xB93BA0", Offset = "0xB925A0", VA = "0x180B93BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public CCOBBDFLOFB CJLEAOJJGCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8BF2F0", Offset = "0x8BDCF0", VA = "0x1808BF2F0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA22490", Offset = "0xA20E90", VA = "0x180A22490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public OELPCMIPAIF CCBDHCDOJDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x85DED0", Offset = "0x85C8D0", VA = "0x18085DED0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x85DE80", Offset = "0x85C880", VA = "0x18085DE80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public GNGDMGCCAPD GKFMPEHDLNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4F0", Offset = "0x8B9EF0", VA = "0x1808BB4F0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9C48D0", Offset = "0x9C32D0", VA = "0x1809C48D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public GDNPJMDDBLG OKFDHBKKLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA47F20", Offset = "0xA46920", VA = "0x180A47F20", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA47F40", Offset = "0xA46940", VA = "0x180A47F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public FGAHPIAHGMI CPPADNKEGPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8BF310", Offset = "0x8BDD10", VA = "0x1808BF310", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xB93B80", Offset = "0xB92580", VA = "0x180B93B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public HMHGPPDLHFG KAMMGKKGEJM
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8BF320", Offset = "0x8BDD20", VA = "0x1808BF320", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9C38F0", Offset = "0x9C22F0", VA = "0x1809C38F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public GNDHGGJAABG ODOJHIPFPFN
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8BF270", Offset = "0x8BDC70", VA = "0x1808BF270", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xB93B40", Offset = "0xB92540", VA = "0x180B93B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public DKMKDMJDKAD IBOABCLKAIG
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF280", Offset = "0x8BDC80", VA = "0x1808BF280", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xB93D80", Offset = "0xB92780", VA = "0x180B93D80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public KJHGHIOALEA DDNLDNHMOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8BF150", Offset = "0x8BDB50", VA = "0x1808BF150", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xB93D60", Offset = "0xB92760", VA = "0x180B93D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public GGIIPLFNMOA DGIEGKOIAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8BF120", Offset = "0x8BDB20", VA = "0x1808BF120", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xB93CA0", Offset = "0xB926A0", VA = "0x180B93CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public APCMDALIFAP AEHDIMKFCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8BF080", Offset = "0x8BDA80", VA = "0x1808BF080", Slot = "32")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5F960", Offset = "0xA5E360", VA = "0x180A5F960", Slot = "33")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BF300", Offset = "0x8BDD00", VA = "0x1808BF300", Slot = "34")]
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
		[Cpp2IlInjected.Address(RVA = "0xAFA9E0", Offset = "0xAF93E0", VA = "0x180AFA9E0", Slot = "35")]
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
		[Cpp2IlInjected.Address(RVA = "0xAFA800", Offset = "0xAF9200", VA = "0x180AFA800", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xB93D00", Offset = "0xB92700", VA = "0x180B93D00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private bool JJIDNNFHAGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x6F67DE0", Offset = "0x6F667E0", VA = "0x186F67DE0", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private bool EGMBFMJJEEH
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6F68280", Offset = "0x6F66C80", VA = "0x186F68280", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private CancellationToken CDLFAJFFLDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6F68590", Offset = "0x6F66F90", VA = "0x186F68590", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private INCIOHANCNE PHNEENJICEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action DEGINDIDOFO
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6F68470", Offset = "0x6F66E70", VA = "0x186F68470", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6F67E40", Offset = "0x6F66840", VA = "0x186F67E40", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event OMLCDPLNPMG PAEFGIELMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6F68220", Offset = "0x6F66C20", VA = "0x186F68220", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6F67EA0", Offset = "0x6F668A0", VA = "0x186F67EA0", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event OMLCDPLNPMG MMMKBBOBLEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6F68530", Offset = "0x6F66F30", VA = "0x186F68530", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6F68410", Offset = "0x6F66E10", VA = "0x186F68410", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event OMLCDPLNPMG MGGNEDHPMKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6F68300", Offset = "0x6F66D00", VA = "0x186F68300", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6F685B0", Offset = "0x6F66FB0", VA = "0x186F685B0", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<EFBCINIABEJ, bool> FOJIJOCBLFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6F684D0", Offset = "0x6F66ED0", VA = "0x186F684D0", Slot = "45")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x6F67D80", Offset = "0x6F66780", VA = "0x186F67D80", Slot = "46")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0xB93D00", Offset = "0xB92700", VA = "0x180B93D00", Slot = "36")]
	public void HMEDGBMBGNA(PHMFOBHEKIK HGAMIEAIIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6F688E0", Offset = "0x6F672E0", VA = "0x186F688E0")]
	[UnityEngine.Scripting.Preserve]
	internal EHPKEGPHHAK([OMAPKKAGFIL(null)] INCIOHANCNE PGHIDIKDPNB, [OMAPKKAGFIL(null)] ILFDHJAHNHI FAELELHBKKO, [OMAPKKAGFIL(null)] DEBFMJKLBDN HPIKMIOHGPC, [OMAPKKAGFIL(null)] MFEINKDLEHJ EKMGPIDNBAL, [OMAPKKAGFIL(null)] INNHEOLIKBM DAHOAFOCMNK, [OMAPKKAGFIL(null)] NBAHHDNKILP PLDFHJDBLCM, [OMAPKKAGFIL(null)] OMKEILKNJFC NPKMKLLOPKG, [OMAPKKAGFIL(null)] BOAMHEKDIOK CJHEFFFCIJN, [OMAPKKAGFIL(null)] GAGJCKDHAGD JIMBHKPDLLH, [OMAPKKAGFIL(null)] EMPCKPBJDBG HEFAOBKNDGK, [OMAPKKAGFIL(null)] MDIOJHKPIFM KMFINGCDELI, [OMAPKKAGFIL(null)] CDPDCOBHLKK ABLOKNIMFCK, [OMAPKKAGFIL(null)] FFDBLCGPPMM MCGBLNMHNKO, [OMAPKKAGFIL(null)] GPMIBIFCKBJ LPINBJBANHC, [OMAPKKAGFIL(null)] DHPDBLFEFKM PODDALKBECI, [OMAPKKAGFIL(null)] IENMFFFGEPA ANNFANPCCIH, [OMAPKKAGFIL(null)] KIJJEBJPOIH OFBHFEIOFPN, [OMAPKKAGFIL(null)] LNJOHEOEPEC DCEOPNHDHAB, [OMAPKKAGFIL(null)] CCOBBDFLOFB FOEFGCMONND, [OMAPKKAGFIL(null)] OELPCMIPAIF KAGKBNNDDPK, [OMAPKKAGFIL(null)] GDNPJMDDBLG HGNPBLNJDEJ, [OMAPKKAGFIL(null)] GNGDMGCCAPD ELAJIBPEDAA, [OMAPKKAGFIL(null)] FGAHPIAHGMI DLEEJBBLHGJ, [OMAPKKAGFIL(null)] HMHGPPDLHFG BNLFELFFHMM, [OMAPKKAGFIL(null)] GNDHGGJAABG DKKIFNFPLNE, [OMAPKKAGFIL(null)] KJHGHIOALEA AACIHKHGIHG, [OMAPKKAGFIL(null)] GGIIPLFNMOA JKPACCCFGCC, [OMAPKKAGFIL(null)] APCMDALIFAP BPDMMEBNEKC, [OMAPKKAGFIL(null)] KKNNHLMFANP CGMJLNEOJIF, [OMAPKKAGFIL(null)] GDBDKOPOCLO CLJOHLGPPOL, [OMAPKKAGFIL(null)] FJDMGDBCEIP LPFOAEHCDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6F68360", Offset = "0x6F66D60", VA = "0x186F68360")]
	private void HMCGAKKBHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6F67F90", Offset = "0x6F66990", VA = "0x186F67F90", Slot = "55")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6F68610", Offset = "0x6F67010", VA = "0x186F68610", Slot = "49")]
	private void NGLEEHGBBMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6F68850", Offset = "0x6F67250", VA = "0x186F68850", Slot = "50")]
	private JNAKBMBBKNN PLIFKLHBOAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6F67F00", Offset = "0x6F66900", VA = "0x186F67F00", Slot = "51")]
	private PKDPFMCHDKO DHFCJIBMGNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6F686C0", Offset = "0x6F670C0", VA = "0x186F686C0", Slot = "52")]
	[AsyncStateMachine(typeof(OGMIPAJCCGC))]
	private Task<DGFDNIJCPMA> OMCJIEMPOBJ(NCKGPLMHNNB HEEEABJCCCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6F68130", Offset = "0x6F66B30", VA = "0x186F68130", Slot = "53")]
	[AsyncStateMachine(typeof(BMPFNLMDBGN))]
	private Task EOCPFACOFDC(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6F687D0", Offset = "0x6F671D0", VA = "0x186F687D0")]
	[IteratorStateMachine(typeof(NDJELHOCNHH))]
	private IEnumerable<DLOEDDKPHPI> OPAOOEAGKHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6F68660", Offset = "0x6F67060", VA = "0x186F68660")]
	[CompilerGenerated]
	private void OBLNOKPPDCN(DLOEDDKPHPI INPAFGCEBHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class DNGDLAEGGBH : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0xEF3CF0", Offset = "0xEF26F0", VA = "0x180EF3CF0")]
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

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x6F747B0", Offset = "0x6F731B0", VA = "0x186F747B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x6F74AF0", Offset = "0x6F734F0", VA = "0x186F74AF0", Slot = "5")]
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

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool LANMAFPDELN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x899BF0", VA = "0x18089B1F0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x85F050", Offset = "0x85DA50", VA = "0x18085F050")]
	public AOJJOPMOLMK(PNHFEHLPHMO KBCJMHHCDBC, MFEINKDLEHJ EKMGPIDNBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6F62790", Offset = "0x6F61190", VA = "0x186F62790", Slot = "4")]
	[AsyncStateMachine(typeof(LGLFBGJDEPF))]
	public Task<bool> AOCJNLDMAFJ(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6F62880", Offset = "0x6F61280", VA = "0x186F62880")]
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

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6F638C0", Offset = "0x6F622C0", VA = "0x186F638C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6F63FD0", Offset = "0x6F629D0", VA = "0x186F63FD0", Slot = "5")]
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

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private FFAMIDMIBLK HFPCNNCNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x6F750B0", Offset = "0x6F73AB0", VA = "0x186F750B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool LANMAFPDELN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x86D5A0", Offset = "0x86BFA0", VA = "0x18086D5A0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x85F050", Offset = "0x85DA50", VA = "0x18085F050")]
	public MFCEKMANMAH(PNHFEHLPHMO KBCJMHHCDBC, MFEINKDLEHJ EKMGPIDNBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x6F74EA0", Offset = "0x6F738A0", VA = "0x186F74EA0", Slot = "4")]
	[AsyncStateMachine(typeof(BLCJBLBLCNE))]
	public Task<bool> AOCJNLDMAFJ(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F74FD0", Offset = "0x6F739D0", VA = "0x186F74FD0")]
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

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public LFGODBHHOHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6F746C0", Offset = "0x6F730C0", VA = "0x186F746C0")]
		internal object KGCKGCEKMLC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6F74650", Offset = "0x6F73050", VA = "0x186F74650")]
		internal object JEIPIGHBHKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6F745B0", Offset = "0x6F72FB0", VA = "0x186F745B0")]
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

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6F666E0", Offset = "0x6F650E0", VA = "0x186F666E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6F67010", Offset = "0x6F65A10", VA = "0x186F67010", Slot = "5")]
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

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	private FFAMIDMIBLK HFPCNNCNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B6B0", Offset = "0x6F7A0B0", VA = "0x186F7B6B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool LANMAFPDELN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x86D5A0", Offset = "0x86BFA0", VA = "0x18086D5A0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x85F050", Offset = "0x85DA50", VA = "0x18085F050")]
	public NFPBGEHJCEI(PNHFEHLPHMO KBCJMHHCDBC, MFEINKDLEHJ EKMGPIDNBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B590", Offset = "0x6F79F90", VA = "0x186F7B590", Slot = "4")]
	[AsyncStateMachine(typeof(DHHJGIFDFEB))]
	public Task<bool> AOCJNLDMAFJ(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal interface MGNJKKAIFOI
{
	[Cpp2IlInjected.Token(Token = "0x17000090")]
	bool LANMAFPDELN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
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

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public MOLOBLHIFJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B020", Offset = "0x6F79A20", VA = "0x186F7B020")]
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

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6F6F720", Offset = "0x6F6E120", VA = "0x186F6F720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6F6FCB0", Offset = "0x6F6E6B0", VA = "0x186F6FCB0", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x6F69C50", Offset = "0x6F68650", VA = "0x186F69C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x6F69F70", Offset = "0x6F68970", VA = "0x186F69F70", Slot = "5")]
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

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private ILFDHJAHNHI HIAEFCJGPMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6F7BD20", Offset = "0x6F7A720", VA = "0x186F7BD20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private MFEINKDLEHJ KFKHEOKCKBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B810", Offset = "0x6F7A210", VA = "0x186F7B810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private FFAMIDMIBLK HFPCNNCNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6F7BBF0", Offset = "0x6F7A5F0", VA = "0x186F7BBF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private EMPCKPBJDBG DNFGAGHGFEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B860", Offset = "0x6F7A260", VA = "0x186F7B860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x1FC6840", Offset = "0x1FC5240", VA = "0x181FC6840")]
	public NNPIKJEPMJD(CancellationToken MPLGBOFHPLM, PNHFEHLPHMO GOHDOKCJOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BC70", Offset = "0x6F7A670", VA = "0x186F7BC70")]
	public static HPIMEFGKLNK NMBOGGHINHI(PNHFEHLPHMO GOHDOKCJOFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B700", Offset = "0x6F7A100", VA = "0x186F7B700")]
	[AsyncStateMachine(typeof(JFEGJJBMFAE))]
	public Task<bool> AGALHLJOLPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B8B0", Offset = "0x6F7A2B0", VA = "0x186F7B8B0")]
	private bool LEBPNAIGEJO([Out] NCKGPLMHNNB HEEEABJCCCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BD70", Offset = "0x6F7A770", VA = "0x186F7BD70")]
	[AsyncStateMachine(typeof(FMDGDOABFEA))]
	private Task PJHENJEAODH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BAC0", Offset = "0x6F7A4C0", VA = "0x186F7BAC0")]
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

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private Task<(DGFDNIJCPMA, Task)> BFILLPLPPPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6F6F530", Offset = "0x6F6DF30", VA = "0x186F6F530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x42212C0", Offset = "0x421FCC0", VA = "0x1842212C0")]
	public ILGKIPAKNNM(DHPDBLFEFKM PODDALKBECI, Guid KPMGFINBLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F6D0", Offset = "0x6F6E0D0", VA = "0x186F6F6D0")]
	public TaskAwaiter<(DGFDNIJCPMA, Task)> HGMNODJPCNM()
	{
		return default(TaskAwaiter<(DGFDNIJCPMA, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F600", Offset = "0x6F6E000", VA = "0x186F6F600", Slot = "4")]
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

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public Task<(DGFDNIJCPMA, Task)> BFILLPLPPPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6F66060", Offset = "0x6F64A60", VA = "0x186F66060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6F662B0", Offset = "0x6F64CB0", VA = "0x186F662B0")]
	public DEPMLGHEKII(TimeSpan CENAAPAKFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x6F660A0", Offset = "0x6F64AA0", VA = "0x186F660A0")]
	public void EIHJHKEEANH(Task FPNFJMOCKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F66140", Offset = "0x6F64B40", VA = "0x186F66140")]
	public void GEKAFKBGJMB(DGFDNIJCPMA OMMIFMPIFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6F66260", Offset = "0x6F64C60", VA = "0x186F66260")]
	public void PNEGMOMJHEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6F661D0", Offset = "0x6F64BD0", VA = "0x186F661D0")]
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

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public GBHEPCMOOEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x6F69FD0", Offset = "0x6F689D0", VA = "0x186F69FD0")]
		internal bool NOGFNJFMPBP(HCDOMJKEJGM s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F72CD0", Offset = "0x6F716D0", VA = "0x186F72CD0")]
	public static JBBIANFGILF JGIIBNEOBDO(long LBHHCOPBEOO, long KJMNNDODHCP, string CNCIKMOKNCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6F729E0", Offset = "0x6F713E0", VA = "0x186F729E0")]
	public static JBBIANFGILF JGIIBNEOBDO(long LBHHCOPBEOO, long KJMNNDODHCP, KEOGFOOKLEH BIOFMAGLAJN, long JFKPBGIIONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6F72D60", Offset = "0x6F71760", VA = "0x186F72D60")]
	public static JBBIANFGILF JGIIBNEOBDO(BMBMOGELPMJ BODDICEIOJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6F72AA0", Offset = "0x6F714A0", VA = "0x186F72AA0")]
	public static JBBIANFGILF JGIIBNEOBDO(FLKIEPIEFEG FEBBHMHHOKC, HNKJBJIHEKD IHANMGECDBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6F72EF0", Offset = "0x6F718F0", VA = "0x186F72EF0")]
	public static JBBIANFGILF OPOMKMNENAA(this JBBIANFGILF MIJPDJDOIDB, FLKIEPIEFEG FMHAEEHBLLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F72850", Offset = "0x6F71250", VA = "0x186F72850")]
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

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x6F60870", Offset = "0x6F5F270", VA = "0x186F60870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x6F60F00", Offset = "0x6F5F900", VA = "0x186F60F00", Slot = "5")]
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

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool DKMCCHAMJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6F645F0", Offset = "0x6F62FF0", VA = "0x186F645F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public Task NIIJPKMNAEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6F64740", Offset = "0x6F63140", VA = "0x186F64740", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x858FC0", Offset = "0x8579C0", VA = "0x180858FC0", Slot = "7")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F647D0", Offset = "0x6F631D0", VA = "0x186F647D0", Slot = "6")]
	public void ODPNHFDHCHP(Task LEDCCMOCHJB, string NAFEJNMBGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6F64620", Offset = "0x6F63020", VA = "0x186F64620")]
	[AsyncStateMachine(typeof(AFBOKGKNFLA))]
	private Task HKBNFPKOHBA(Task DJMMIEKABGF, string NAFEJNMBGDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6F64930", Offset = "0x6F63330", VA = "0x186F64930")]
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

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public AGBLOFNHMNJ CGDMKGIJFNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x6F622F0", Offset = "0x6F60CF0", VA = "0x186F622F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6F623A0", Offset = "0x6F60DA0", VA = "0x186F623A0", Slot = "7")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6F625E0", Offset = "0x6F60FE0", VA = "0x186F625E0", Slot = "5")]
	public void IMDJDHEEMJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6F62360", Offset = "0x6F60D60", VA = "0x186F62360", Slot = "6")]
	public void FNLBOAJMEAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6F62520", Offset = "0x6F60F20", VA = "0x186F62520")]
	private Task HPEAEHOOAHL(FMJIADNAIKM LMDEKGEENAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6F62360", Offset = "0x6F60D60", VA = "0x186F62360", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
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

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public T JNHPIMBJPMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x8A6510", Offset = "0x8A4F10", VA = "0x1808A6510")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x9AD960", Offset = "0x9AC360", VA = "0x1809AD960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3EC5D80", Offset = "0x3EC4780", VA = "0x183EC5D80")]
		public ILFHBMGGKEC(PMIHDANGMFM KHLLEDBKIEB, string NDDCLPHCEEO, T LIAHLPBCKNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3EC5790", Offset = "0x3EC4190", VA = "0x183EC5790")]
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

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public TimeSpan POPLOMEELGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A280", Offset = "0x6F68C80", VA = "0x186F6A280", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public TimeSpan EILAOPAHMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A100", Offset = "0x6F68B00", VA = "0x186F6A100", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public TimeSpan FFOMFNFAGFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A000", Offset = "0x6F68A00", VA = "0x186F6A000", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public TimeSpan MFJMGLGDJLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A240", Offset = "0x6F68C40", VA = "0x186F6A240", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool HIEMGKLEMPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A1C0", Offset = "0x6F68BC0", VA = "0x186F6A1C0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool DHJHHPNONME
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A040", Offset = "0x6F68A40", VA = "0x186F6A040", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool PDNJFNGKLAE
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A080", Offset = "0x6F68A80", VA = "0x186F6A080", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public int HBEFNCBJLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A0C0", Offset = "0x6F68AC0", VA = "0x186F6A0C0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool GMPLDANEBAP
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A200", Offset = "0x6F68C00", VA = "0x186F6A200", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool JLAHKDIJKKN
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A140", Offset = "0x6F68B40", VA = "0x186F6A140", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool FABNOODIDDM
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A180", Offset = "0x6F68B80", VA = "0x186F6A180", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6F6A2C0", Offset = "0x6F68CC0", VA = "0x186F6A2C0")]
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

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public DOKPADCGDHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x6F679F0", Offset = "0x6F663F0", VA = "0x186F679F0")]
		internal object MGNNDFMFPAN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action FBNNGEHPFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x6F71F50", Offset = "0x6F70950", VA = "0x186F71F50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6F71B10", Offset = "0x6F70510", VA = "0x186F71B10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event OMLCDPLNPMG DAKEBEBHJID
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6F71EB0", Offset = "0x6F708B0", VA = "0x186F71EB0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6F72140", Offset = "0x6F70B40", VA = "0x186F72140", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event OMLCDPLNPMG JINMNOEEMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x6F71FF0", Offset = "0x6F709F0", VA = "0x186F71FF0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x6F71DE0", Offset = "0x6F707E0", VA = "0x186F71DE0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event OMLCDPLNPMG LLPKHLEBIFH
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6F72280", Offset = "0x6F70C80", VA = "0x186F72280", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x6F721E0", Offset = "0x6F70BE0", VA = "0x186F721E0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<EFBCINIABEJ, bool> FDJJFJNOJEM
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x6F72090", Offset = "0x6F70A90", VA = "0x186F72090", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x6F71810", Offset = "0x6F70210", VA = "0x186F71810", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "19")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6F71BE0", Offset = "0x6F705E0", VA = "0x186F71BE0", Slot = "14")]
	public void GJOPDEMKKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6F71E80", Offset = "0x6F70880", VA = "0x186F71E80", Slot = "15")]
	public void IGKNNADFBCJ(BIDJCBPPELH NMJHAGKCPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6F71AE0", Offset = "0x6F704E0", VA = "0x186F71AE0", Slot = "16")]
	public void CBIKINJHPHE(BIDJCBPPELH NMJHAGKCPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6F71BB0", Offset = "0x6F705B0", VA = "0x186F71BB0", Slot = "17")]
	public void GCEEECEEPGL(BIDJCBPPELH NMJHAGKCPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6F718C0", Offset = "0x6F702C0", VA = "0x186F718C0", Slot = "18")]
	public void APBMNJALIEG(EFBCINIABEJ LJJJHDHDDOO, bool NPCJOOKKGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6F71910", Offset = "0x6F70310", VA = "0x186F71910")]
	private void APPOJKGPLJE(OMLCDPLNPMG DAKLDBBBMLH, BIDJCBPPELH NMJHAGKCPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
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
	private struct JMPLINJCNHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public BJHOANGGNIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6F70DD0", Offset = "0x6F6F7D0", VA = "0x186F70DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6F71460", Offset = "0x6F6FE60", VA = "0x186F71460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct LCGBBEGOPFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public BJHOANGGNIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private bool <success>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private Task<bool> <fallbackTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private TaskAwaiter<bool> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6F73A30", Offset = "0x6F72430", VA = "0x186F73A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6F74550", Offset = "0x6F72F50", VA = "0x186F74550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class CODMFBLEIFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public CODMFBLEIFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x6F64580", Offset = "0x6F62F80", VA = "0x186F64580")]
		internal object KGFIEECBOMC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct HNHNCEDAGNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public BJHOANGGNIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private CODMFBLEIFN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A830", Offset = "0x6F69230", VA = "0x186F6A830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x6F6AF80", Offset = "0x6F69980", VA = "0x186F6AF80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class MKDGPNEJIIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public MKDGPNEJIIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x6F7AFB0", Offset = "0x6F799B0", VA = "0x186F7AFB0")]
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
	private CancellationTokenSource KHDGIAPDGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private CancellationTokenSource GJBOCGIMIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private Task IMLFEPEGHGH;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool LELHMFOMGFI
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x6F62D30", Offset = "0x6F61730", VA = "0x186F62D30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x6F63090", Offset = "0x6F61A90", VA = "0x186F63090", Slot = "6")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6F62F60", Offset = "0x6F61960", VA = "0x186F62F60", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6F62F70", Offset = "0x6F61970", VA = "0x186F62F70", Slot = "8")]
	public void GINDKEMMJIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6F62D60", Offset = "0x6F61760", VA = "0x186F62D60", Slot = "5")]
	public void CNOADOMBMCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x6F63540", Offset = "0x6F61F40", VA = "0x186F63540", Slot = "4")]
	[AsyncStateMachine(typeof(JMPLINJCNHJ))]
	public Task NMANLOAKGED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x6F63110", Offset = "0x6F61B10", VA = "0x186F63110")]
	[AsyncStateMachine(typeof(LCGBBEGOPFO))]
	private Task JLBHAMLFEMO(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6F63220", Offset = "0x6F61C20", VA = "0x186F63220")]
	private void KKFDGNOJHKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6F63610", Offset = "0x6F62010", VA = "0x186F63610")]
	[AsyncStateMachine(typeof(HNHNCEDAGNK))]
	private Task<bool> NOPPOHGFLDN(int DHNLEFJCEAH, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x6F62C50", Offset = "0x6F61650", VA = "0x186F62C50")]
	private void AKHCHGOIHLF(int DHNLEFJCEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x6F63750", Offset = "0x6F62150", VA = "0x186F63750")]
	private void OCLKHLIGBBD(int DHNLEFJCEAH, bool NPCJOOKKGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x6F62E30", Offset = "0x6F61830", VA = "0x186F62E30")]
	private void DFEHLIFKLBM(int DHNLEFJCEAH, Exception PBAHBFAICPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
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
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public PHMFOBHEKIK customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C910", Offset = "0x6F7B310", VA = "0x186F7C910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D270", Offset = "0x6F7BC70", VA = "0x186F7D270", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public PHMFOBHEKIK customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private OADONCMLPJG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private PHCOOIGGHEB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private NOCKKKPBJAK <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private LOEOIDGPKKK <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D2D0", Offset = "0x6F7BCD0", VA = "0x186F7D2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6F7DE90", Offset = "0x6F7C890", VA = "0x186F7DE90", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public Matchmaking.DCIEOPEHEPA result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public DMFAPLFEJDL errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public HMMKPOEOPLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6F6A780", Offset = "0x6F69180", VA = "0x186F6A780")]
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
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public Task<JBBIANFGILF> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public FEGHAJBNLCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100")]
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
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public PHMFOBHEKIK customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public NOCKKKPBJAK joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private FEGHAJBNLCO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private NPFIODHPLCC <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private PHCOOIGGHEB <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private OADONCMLPJG<string>.HILOONJJDHL <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private NKKKGGINLEP <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private Task<Matchmaking.HMGBEKBDAJP> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private AFIHICIEAEF <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private int <i>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private TaskAwaiter<Matchmaking.HMGBEKBDAJP> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private TaskAwaiter<JBBIANFGILF> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6F75670", Offset = "0x6F74070", VA = "0x186F75670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6F7AF50", Offset = "0x6F79950", VA = "0x186F7AF50", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private OADONCMLPJG<string>.HILOONJJDHL <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6F6EA80", Offset = "0x6F6D480", VA = "0x186F6EA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6F6F4D0", Offset = "0x6F6DED0", VA = "0x186F6F4D0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private INCIOHANCNE <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6F69780", Offset = "0x6F68180", VA = "0x186F69780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6F69BF0", Offset = "0x6F685F0", VA = "0x186F69BF0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public AsyncTaskMethodBuilder<Matchmaking.HMGBEKBDAJP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private TaskAwaiter<Matchmaking.HMGBEKBDAJP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6F75100", Offset = "0x6F73B00", VA = "0x186F75100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6F75600", Offset = "0x6F74000", VA = "0x186F75600", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public Matchmaking.HMGBEKBDAJP serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public NOCKKKPBJAK joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private TaskAwaiter<HBOFKAEDAPN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6F60F60", Offset = "0x6F5F960", VA = "0x186F60F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6F61660", Offset = "0x6F60060", VA = "0x186F61660", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public JIPNGCHCFCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x6F6FD20", Offset = "0x6F6E720", VA = "0x186F6FD20")]
		internal object FBGOHMOBGCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6F6FE20", Offset = "0x6F6E820", VA = "0x186F6FE20")]
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
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private JIPNGCHCFCC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x6F616C0", Offset = "0x6F600C0", VA = "0x186F616C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x6F62290", Offset = "0x6F60C90", VA = "0x186F62290", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public NOCKKKPBJAK joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public JBBIANFGILF initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public MDBDBMHCDOA targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public NPFIODHPLCC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private OADONCMLPJG<string>.HILOONJJDHL <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x6F67080", Offset = "0x6F65A80", VA = "0x186F67080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6F67990", Offset = "0x6F66390", VA = "0x186F67990", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private OADONCMLPJG<string>.HILOONJJDHL <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private PHCOOIGGHEB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private CancellationTokenSource <timeoutTcs>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private CancellationToken <timeoutToken>5__7;

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x6F649C0", Offset = "0x6F633C0", VA = "0x186F649C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6F66000", Offset = "0x6F64A00", VA = "0x186F66000", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public JLMLCKPCLMI localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private TaskAwaiter<DGFDNIJCPMA> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x6F600A0", Offset = "0x6F5EAA0", VA = "0x186F600A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6F60810", Offset = "0x6F5F210", VA = "0x186F60810", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public FHGLJJDLGGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6F88DB0", Offset = "0x6F877B0", VA = "0x186F88DB0")]
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
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public LBFPKNNPLFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x6F93C30", Offset = "0x6F92630", VA = "0x186F93C30")]
		internal void CJEJNJFHLPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class EEIDPHAINCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public EEIDPHAINCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x6F86F20", Offset = "0x6F85920", VA = "0x186F86F20")]
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
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public JNDJBOEIGAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x6F909A0", Offset = "0x6F8F3A0", VA = "0x186F909A0")]
		internal string GLPGPBNMNBF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static readonly CDLNJDLNIPA OLOCEDJDFLB;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly CDLNJDLNIPA BPCOIOKDKDB;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly CDLNJDLNIPA PCIAMJMIABF;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static readonly string ANKCHOGOAEB;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static readonly string DLKDLGEKOIC;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static readonly string MOBNGBHJBCF;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static readonly Guid AMGNMGCFFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private BOAMHEKDIOK CJHEFFFCIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private DEBFMJKLBDN HPIKMIOHGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private ILFDHJAHNHI FAELELHBKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private MFEINKDLEHJ EKMGPIDNBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private CDPDCOBHLKK ABLOKNIMFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private GAGJCKDHAGD JIMBHKPDLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private MDIOJHKPIFM KMFINGCDELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private GDBDKOPOCLO CLJOHLGPPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private KKNNHLMFANP CGMJLNEOJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IDisposable KPBJBKAIJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly NKPKPHIMNEI HLFHFFLLGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private AFIHICIEAEF JILPJAIBHOM;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public TaskStatus GBIGLBPMJGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8BF200", Offset = "0x8BDC00", VA = "0x1808BF200", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xB59670", Offset = "0xB58070", VA = "0x180B59670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private FFAMIDMIBLK HFPCNNCNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E690", Offset = "0x6F6D090", VA = "0x186F6E690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6F6D250", Offset = "0x6F6BC50", VA = "0x186F6D250", Slot = "6")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6F6C1A0", Offset = "0x6F6ABA0", VA = "0x186F6C1A0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6F6D6A0", Offset = "0x6F6C0A0", VA = "0x186F6D6A0", Slot = "5")]
	[AsyncStateMachine(typeof(PAMJGNFNGGE))]
	public Task IADAOMLEGLE(MDBDBMHCDOA OLIIPNAKLLA, PHMFOBHEKIK LHBIIPLLKKE, CancellationToken LJPECIOGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6F6DCA0", Offset = "0x6F6C6A0", VA = "0x186F6DCA0")]
	[AsyncStateMachine(typeof(PPDHDIPGLCM))]
	private Task LEIGIBIHDKJ(MDBDBMHCDOA OLIIPNAKLLA, PHMFOBHEKIK LHBIIPLLKKE, CancellationToken LJPECIOGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6F6B6A0", Offset = "0x6F6A0A0", VA = "0x186F6B6A0")]
	private static void AMEBNCCMPCK(GDBDKOPOCLO CLJOHLGPPOL, MDBDBMHCDOA OLIIPNAKLLA, Exception PBAHBFAICPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6F6C250", Offset = "0x6F6AC50", VA = "0x186F6C250")]
	private static void FFBKAJLPPED(LOEOIDGPKKK IOLDPMPDDLA, Exception PBAHBFAICPK, [Optional] List<int> ODNIHHABMCH, int KCKAFLCODKL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E070", Offset = "0x6F6CA70", VA = "0x186F6E070")]
	[AsyncStateMachine(typeof(MIJPPMOPNBH))]
	private Task MENFDAOMFIP(OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, MDBDBMHCDOA OLIIPNAKLLA, PHMFOBHEKIK LHBIIPLLKKE, NOCKKKPBJAK OPJMEADJLCF, CancellationToken LJPECIOGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6F6D550", Offset = "0x6F6BF50", VA = "0x186F6D550")]
	private void HNFCABGDADF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6F6D120", Offset = "0x6F6BB20", VA = "0x186F6D120")]
	[AsyncStateMachine(typeof(IBIPMOKBHJA))]
	private Task HELENOIFGLE(OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E360", Offset = "0x6F6CD60", VA = "0x186F6E360")]
	private void NADLKFOEBAO(MDBDBMHCDOA OLIIPNAKLLA, CancellationToken LJPECIOGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6F6BD30", Offset = "0x6F6A730", VA = "0x186F6BD30")]
	private void DBGMGHDNGAL(MDBDBMHCDOA OLIIPNAKLLA, NOCKKKPBJAK OPJMEADJLCF, OperationCanceledException JEGEBALABNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6F6D7E0", Offset = "0x6F6C1E0", VA = "0x186F6D7E0")]
	private void IGGJNBCFCEJ(MDBDBMHCDOA OLIIPNAKLLA, NOCKKKPBJAK OPJMEADJLCF, Exception PBAHBFAICPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6F6AFF0", Offset = "0x6F699F0", VA = "0x186F6AFF0")]
	private void ADECOJLLCEG(MDBDBMHCDOA OLIIPNAKLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6F6C1F0", Offset = "0x6F6ABF0", VA = "0x186F6C1F0")]
	private static BIDJCBPPELH EJFDIJEFKFP(MDBDBMHCDOA OLIIPNAKLLA)
	{
		return default(BIDJCBPPELH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6F6BC60", Offset = "0x6F6A660", VA = "0x186F6BC60")]
	[AsyncStateMachine(typeof(FGMMFNHNJMB))]
	private Task BOELEJIFBLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6F6CCB0", Offset = "0x6F6B6B0", VA = "0x186F6CCB0")]
	[AsyncStateMachine(typeof(MFEKPCKEMPF))]
	private Task<Matchmaking.HMGBEKBDAJP> FMLAHBCEJDN(MDBDBMHCDOA OLIIPNAKLLA, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6F6DB00", Offset = "0x6F6C500", VA = "0x186F6DB00")]
	private static HBOFKAEDAPN KOHBOIIBIEM(Matchmaking.HMGBEKBDAJP KOCMLIJCBLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6F6B200", Offset = "0x6F69C00", VA = "0x186F6B200")]
	[AsyncStateMachine(typeof(AIPAICBEHPG))]
	private Task AHFJIDFMPEB(Matchmaking.HMGBEKBDAJP KOCMLIJCBLI, NOCKKKPBJAK OPJMEADJLCF, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken CGFBIGKMGCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x6F6C060", Offset = "0x6F6AA60", VA = "0x186F6C060")]
	[AsyncStateMachine(typeof(AJNGDMHBPON))]
	private Task DPPIJODPFLB(MDBDBMHCDOA OLIIPNAKLLA, CancellationTokenSource CFNNLMNCHIM, Task HNNFPDNLJHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x6F6BA60", Offset = "0x6F6A460", VA = "0x186F6BA60")]
	[AsyncStateMachine(typeof(DNDPFDJLFMB))]
	private Task BADNIKJAECB(JBBIANFGILF KLNKIGMCCKO, NPFIODHPLCC CMNBDIJCHGE, MDBDBMHCDOA PFCJBPLHMBO, NOCKKKPBJAK CKEHJAPJCLE, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken EOCFNKLBEMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x6F6DDF0", Offset = "0x6F6C7F0", VA = "0x186F6DDF0")]
	private NOCKKKPBJAK LJJDGOMDDAL(NOCKKKPBJAK CKEHJAPJCLE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x6F6CE70", Offset = "0x6F6B870", VA = "0x186F6CE70")]
	[AsyncStateMachine(typeof(DBMGOGHGNOP))]
	private Task GDMGNLIGCBB(OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E230", Offset = "0x6F6CC30", VA = "0x186F6E230")]
	[AsyncStateMachine(typeof(AADFJFIEGJI))]
	private Task MLKHHDHLNGB(CancellationToken MPLGBOFHPLM, int IDCPOPPPDDB, JLMLCKPCLMI ONEPKIAFHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6F6CFA0", Offset = "0x6F6B9A0", VA = "0x186F6CFA0")]
	private static void GLEGLCIMJNP(MDBDBMHCDOA OLIIPNAKLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x6F6B350", Offset = "0x6F69D50", VA = "0x186F6B350")]
	private void AHJEPGBAJCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x6F6DFE0", Offset = "0x6F6C9E0", VA = "0x186F6DFE0")]
	private void MABJEEAHJII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6F6BBD0", Offset = "0x6F6A5D0", VA = "0x186F6BBD0")]
	private void BGHPDLKEPFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x6F6DC10", Offset = "0x6F6C610", VA = "0x186F6DC10")]
	private void KPDCFKDOCLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x6F6DA10", Offset = "0x6F6C410", VA = "0x186F6DA10")]
	private static void JGCOPKNAEMG(MDBDBMHCDOA OLIIPNAKLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6F6B590", Offset = "0x6F69F90", VA = "0x186F6B590")]
	private static CancellationTokenRegistration AMDJGGIGCJE(MDBDBMHCDOA OLIIPNAKLLA, CancellationToken CGFBIGKMGCL)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6F6BF60", Offset = "0x6F6A960", VA = "0x186F6BF60")]
	private static void DNGCDFGGFFA(MDBDBMHCDOA OLIIPNAKLLA, Exception PBAHBFAICPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6F6CB00", Offset = "0x6F6B500", VA = "0x186F6CB00")]
	private void FGFPEFHEFOM(MDBDBMHCDOA OLIIPNAKLLA, Task HNNFPDNLJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E1D0", Offset = "0x6F6CBD0", VA = "0x186F6E1D0")]
	private static void MGFMJHPPHBP(Func<string> ALLEHOLILJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E900", Offset = "0x6F6D300", VA = "0x186F6E900")]
	public HNKBGIBBNMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x6F6CE10", Offset = "0x6F6B810", VA = "0x186F6CE10")]
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
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public KECDANANLKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public JLMLCKPCLMI localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F800E0", Offset = "0x6F7EAE0", VA = "0x186F800E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6F80550", Offset = "0x6F7EF50", VA = "0x186F80550", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public KECDANANLKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public JLMLCKPCLMI localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public KDPMFNPCPDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x6F91170", Offset = "0x6F8FB70", VA = "0x186F91170")]
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
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public HPIMEFGKLNK taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public JLMLCKPCLMI localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F86B30", Offset = "0x6F85530", VA = "0x186F86B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x6F86EC0", Offset = "0x6F858C0", VA = "0x186F86EC0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public KECDANANLKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x6F898A0", Offset = "0x6F882A0", VA = "0x186F898A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x6F89B60", Offset = "0x6F88560", VA = "0x186F89B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private readonly HashSet<HPIMEFGKLNK> MBNKNAPCPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private DEBFMJKLBDN HPIKMIOHGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private FFCFLPKEGBI CFHFJJJEMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private LJJNFBNGNFA KNOBALPGCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private IDisposable KPBJBKAIJHH;

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6F91DA0", Offset = "0x6F907A0", VA = "0x186F91DA0", Slot = "5")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6F91B80", Offset = "0x6F90580", VA = "0x186F91B80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6F91830", Offset = "0x6F90230", VA = "0x186F91830", Slot = "4")]
	public bool CELLIGGGPOC(HPIMEFGKLNK JABMPBLAEKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x6F911B0", Offset = "0x6F8FBB0", VA = "0x186F911B0")]
	private void ACCECIBKIGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6F91890", Offset = "0x6F90290", VA = "0x186F91890")]
	private void CHBANEPGHPG(BCCLEKKJGLB FCMADEBOIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6F91CB0", Offset = "0x6F906B0", VA = "0x186F91CB0")]
	[AsyncStateMachine(typeof(AKGJJNNFNKA))]
	private Task HBFKOLGGOJG(int IDCPOPPPDDB, JLMLCKPCLMI ONEPKIAFHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x6F91280", Offset = "0x6F8FC80", VA = "0x186F91280")]
	private Func<CancellationToken, List<Task>> BAMLLDAFAFC(int IDCPOPPPDDB, JLMLCKPCLMI ONEPKIAFHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6F91350", Offset = "0x6F8FD50", VA = "0x186F91350")]
	private List<Task> CCPFNHBACIN(int IDCPOPPPDDB, JLMLCKPCLMI ONEPKIAFHHL, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6F920A0", Offset = "0x6F90AA0", VA = "0x186F920A0")]
	[AsyncStateMachine(typeof(EEGEPLPDDFO))]
	private Task KDAIKBEEJFH(HPIMEFGKLNK LDEAEONJEHG, CancellationToken EOCJCEFCOOA, int IDCPOPPPDDB, JLMLCKPCLMI ONEPKIAFHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x6F91AB0", Offset = "0x6F904B0", VA = "0x186F91AB0")]
	[AsyncStateMachine(typeof(GJIILEKIGAI))]
	private Task COHAHPNBDIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6F91C00", Offset = "0x6F90600", VA = "0x186F91C00")]
	private void GINDKEMMJIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6F921C0", Offset = "0x6F90BC0", VA = "0x186F921C0")]
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
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public IIMLFIPAJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x6F8D120", Offset = "0x6F8BB20", VA = "0x186F8D120")]
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
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public LLIKMOKHPJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x6F94940", Offset = "0x6F93340", VA = "0x186F94940")]
		internal object NFCNCKIPENF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class IPPOKHMHDLE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public IPPOKHMHDLE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class GGMPHEJNDAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public GGMPHEJNDAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x6F89840", Offset = "0x6F88240", VA = "0x186F89840")]
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
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public LMGAKJBNMHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x6F94EA0", Offset = "0x6F938A0", VA = "0x186F94EA0")]
		internal object IADJNBGAGIC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private readonly Dictionary<Guid, DEPMLGHEKII> PODDALKBECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private readonly TimeSpan PGJKIPCMONL;

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "9")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x6F9C460", Offset = "0x6F9AE60", VA = "0x186F9C460", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F9CDC0", Offset = "0x6F9B7C0", VA = "0x186F9CDC0", Slot = "4")]
	public ILGKIPAKNNM PBLNBBGFGAP(Guid KPMGFINBLBG)
	{
		return default(ILGKIPAKNNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6F9CBB0", Offset = "0x6F9B5B0", VA = "0x186F9CBB0", Slot = "5")]
	public bool MFKDEBIIBOM(Guid KPMGFINBLBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6F9C880", Offset = "0x6F9B280", VA = "0x186F9C880", Slot = "6")]
	public bool ILAGFIPHBII(Guid KPMGFINBLBG, Task FPNFJMOCKDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6F9C470", Offset = "0x6F9AE70", VA = "0x186F9C470", Slot = "7")]
	public bool GBCDJOMOKCI(Guid KPMGFINBLBG, DGFDNIJCPMA OMMIFMPIFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6F9C3F0", Offset = "0x6F9ADF0", VA = "0x186F9C3F0", Slot = "8")]
	public Task<(DGFDNIJCPMA, Task)> BDAIDICDCAJ(Guid KPMGFINBLBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6F9C650", Offset = "0x6F9B050", VA = "0x186F9C650")]
	private void GLNFLBKPBCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6F9CFE0", Offset = "0x6F9B9E0", VA = "0x186F9CFE0")]
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
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private readonly MDBDBMHCDOA ODGJFBJGOFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private readonly CancellationTokenSource NPCICLIMLAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public readonly CancellationToken JDBBABFONDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private bool LGIHFPFHNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private bool MAFFMBBADNE;

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6F9AF40", Offset = "0x6F99940", VA = "0x186F9AF40")]
		public OAIBMIFPOGM(MDBDBMHCDOA ODGJFBJGOFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x6F9ADF0", Offset = "0x6F997F0", VA = "0x186F9ADF0")]
		public void GINDKEMMJIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x6F9ADC0", Offset = "0x6F997C0", VA = "0x186F9ADC0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class COHBDHFHIBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public FMJIADNAIKM disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public COHBDHFHIBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x6F85860", Offset = "0x6F84260", VA = "0x186F85860")]
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
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public FMJIADNAIKM disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public CDPDJJBIBDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F3E0", Offset = "0x6F7DDE0", VA = "0x186F7F3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F790", Offset = "0x6F7E190", VA = "0x186F7F790", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public PEKOJDNGLPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x6F9D0A0", Offset = "0x6F9BAA0", VA = "0x186F9D0A0")]
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
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public CDPDJJBIBDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private PHCOOIGGHEB <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x6F98C30", Offset = "0x6F97630", VA = "0x186F98C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x9EB410", Offset = "0x9E9E10", VA = "0x1809EB410", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public MDBDBMHCDOA newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public NPFMOOJMNCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x6F9ACA0", Offset = "0x6F996A0", VA = "0x186F9ACA0")]
		internal object AEMEAGGLKLI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x6F9AD80", Offset = "0x6F99780", VA = "0x186F9AD80")]
		internal object JKBLBAFFGFG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x6F9AD40", Offset = "0x6F99740", VA = "0x186F9AD40")]
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
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public DDANANHINOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x6F858F0", Offset = "0x6F842F0", VA = "0x186F858F0")]
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
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public MDBDBMHCDOA newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public CDPDJJBIBDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public PHMFOBHEKIK customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private NPFMOOJMNCA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x6F875D0", Offset = "0x6F85FD0", VA = "0x186F875D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x6F88550", Offset = "0x6F86F50", VA = "0x186F88550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly ONHBODPEMNP.AOMBGGKOFKP CNCKDHMKNAH;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private static readonly MEIHHKOBOJC ICIADONHJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private DEBFMJKLBDN HPIKMIOHGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private CDPDCOBHLKK ABLOKNIMFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private MFEINKDLEHJ EKMGPIDNBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private KJHGHIOALEA AACIHKHGIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private FFDBLCGPPMM MCGBLNMHNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private MDBDBMHCDOA FMOGMGAOFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private OAIBMIFPOGM PJOAGEEEDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private bool OOMHAADDHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private Task NJOFDKJFGCB;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	private FFAMIDMIBLK HFPCNNCNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x6F83760", Offset = "0x6F82160", VA = "0x186F83760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool PJEOOLOCMOL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x91F1C0", Offset = "0x91DBC0", VA = "0x18091F1C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x6F835C0", Offset = "0x6F81FC0", VA = "0x186F835C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F82F90", Offset = "0x6F81990", VA = "0x186F82F90", Slot = "4")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F82BD0", Offset = "0x6F815D0", VA = "0x186F82BD0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F83230", Offset = "0x6F81C30", VA = "0x186F83230")]
	[AsyncStateMachine(typeof(AGCLEHHNEKG))]
	private Task JKMLDKGMEKK(FMJIADNAIKM LCBIAINGNCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x6F835D0", Offset = "0x6F81FD0", VA = "0x186F835D0")]
	private void NAOMOMFBMJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x6F82A40", Offset = "0x6F81440", VA = "0x186F82A40")]
	private void BGEFNKEMCOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x6F82D40", Offset = "0x6F81740", VA = "0x186F82D40")]
	private void GAIFFCCGEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x6F83A40", Offset = "0x6F82440", VA = "0x186F83A40")]
	private bool PLFGDIKCEGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x6F82EC0", Offset = "0x6F818C0", VA = "0x186F82EC0")]
	[AsyncStateMachine(typeof(MPHDHEIMLNK))]
	private void HKMIFPBLENP(int JGJFKDCDFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6F837B0", Offset = "0x6F821B0", VA = "0x186F837B0")]
	private void OPMKJEKGEHI([Out] IDisposable EFBBALGDKJK, [Out] IDisposable GJCJECOCBAG, [Out] IDisposable HNAJEPEILMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6F83320", Offset = "0x6F81D20", VA = "0x186F83320")]
	private bool JKPKFJAKOGI(MDBDBMHCDOA ODGJFBJGOFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6F83570", Offset = "0x6F81F70", VA = "0x186F83570")]
	private void LNJAOOJBLKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x6F83440", Offset = "0x6F81E40", VA = "0x186F83440")]
	[AsyncStateMachine(typeof(EJJFDEDKAOF))]
	private Task LEIGIBIHDKJ(MDBDBMHCDOA ODGJFBJGOFN, PHMFOBHEKIK LHBIIPLLKKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x6F83E90", Offset = "0x6F82890", VA = "0x186F83E90")]
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
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public AsyncTaskMethodBuilder<KPFIKNDEFFO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public JFGEPJACMMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private TaskAwaiter<KPFIKNDEFFO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F89540", Offset = "0x6F87F40", VA = "0x186F89540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6F897D0", Offset = "0x6F881D0", VA = "0x186F897D0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public JHHNPEBPLNM message;

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public ABFBAKOBLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x6F7EA60", Offset = "0x6F7D460", VA = "0x186F7EA60")]
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
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public JHHNPEBPLNM messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public OCGFNJLLBMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x6F9B190", Offset = "0x6F99B90", VA = "0x186F9B190")]
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
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public IOAFBONFKLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x6F8E940", Offset = "0x6F8D340", VA = "0x186F8E940")]
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
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public JFGEPJACMMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private TaskAwaiter<LDOGEOGHOLH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x6F8AFB0", Offset = "0x6F899B0", VA = "0x186F8AFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x6F8B870", Offset = "0x6F8A270", VA = "0x186F8B870", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public JHHNPEBPLNM operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public BIDEHHENBGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x6F805B0", Offset = "0x6F7EFB0", VA = "0x186F805B0")]
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
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public JHHNPEBPLNM operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public JFGEPJACMMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private NOCKKKPBJAK <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x6F8DD70", Offset = "0x6F8C770", VA = "0x186F8DD70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x6F8E8E0", Offset = "0x6F8D2E0", VA = "0x186F8E8E0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public AsyncTaskMethodBuilder<LDOGEOGHOLH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public JFGEPJACMMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private PGGDLKOGOBJ.GFAHLAKMHKM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private NOCKKKPBJAK <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x6F9A1A0", Offset = "0x6F98BA0", VA = "0x186F9A1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x6F9A6C0", Offset = "0x6F990C0", VA = "0x186F9A6C0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public LDOGEOGHOLH operation;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public FFBOBOHEFDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x6F886D0", Offset = "0x6F870D0", VA = "0x186F886D0")]
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
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public LDOGEOGHOLH operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public JFGEPJACMMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private OADONCMLPJG<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x6F8E9A0", Offset = "0x6F8D3A0", VA = "0x186F8E9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EFD0", Offset = "0x6F8D9D0", VA = "0x186F8EFD0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public CEOJHGOJIKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x6F83F00", Offset = "0x6F82900", VA = "0x186F83F00")]
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
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public CFPMDHOMAAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x6F83F60", Offset = "0x6F82960", VA = "0x186F83F60")]
		internal object DNJMBAILEBD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private GAGJCKDHAGD JIMBHKPDLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private LNJOHEOEPEC DCEOPNHDHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	private GNGDMGCCAPD ELAJIBPEDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private ILFDHJAHNHI FAELELHBKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private TaskCompletionSource<KPFIKNDEFFO> HNPFGBJOFHC;

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x6F8F8C0", Offset = "0x6F8E2C0", VA = "0x186F8F8C0", Slot = "7")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F8F7B0", Offset = "0x6F8E1B0", VA = "0x186F8F7B0", Slot = "6")]
	[AsyncStateMachine(typeof(GCCCCOACEJO))]
	public Task<KPFIKNDEFFO> HEDPEEEGPBI(CancellationToken JHPDMDBBGOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6F8FE30", Offset = "0x6F8E830", VA = "0x186F8FE30", Slot = "4")]
	public void NMIDACFLKHF(JHHNPEBPLNM JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6F8F030", Offset = "0x6F8DA30", VA = "0x186F8F030", Slot = "5")]
	public void DCAJFCLMDMN(JHHNPEBPLNM AHIOCFBKFEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F902D0", Offset = "0x6F8ECD0", VA = "0x186F902D0")]
	[AsyncStateMachine(typeof(HODPIFDFBHL))]
	private Task PONCBMFOEOL(JHHNPEBPLNM GPCNCGBOPJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x6F901C0", Offset = "0x6F8EBC0", VA = "0x186F901C0")]
	[AsyncStateMachine(typeof(INMJIFBIJNC))]
	private Task PBPEGIONGGK(JHHNPEBPLNM LLGJLDCBANK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x6F8FCE0", Offset = "0x6F8E6E0", VA = "0x186F8FCE0")]
	[AsyncStateMachine(typeof(NKBHNJGDMBB))]
	private Task<LDOGEOGHOLH> NJFAFCEHLDL(JHHNPEBPLNM GPCNCGBOPJG, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F8F390", Offset = "0x6F8DD90", VA = "0x186F8F390")]
	private NOCKKKPBJAK DIFFLJGINPN(JHHNPEBPLNM PIHNIIFANNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F8F9B0", Offset = "0x6F8E3B0", VA = "0x186F8F9B0")]
	[AsyncStateMachine(typeof(JBIGGDBBPGA))]
	private Task KPBAJBJEEKL(LDOGEOGHOLH PADMFCNKGOL, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F8FAD0", Offset = "0x6F8E4D0", VA = "0x186F8FAD0")]
	private LDOGEOGHOLH MLCOFAJHONO(JHHNPEBPLNM GPCNCGBOPJG, NOCKKKPBJAK EECJCJLHLIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x2BCA6A0", Offset = "0x2BC90A0", VA = "0x182BCA6A0")]
	private T FPAIGDJBKKJ<T>(T JMDCGOKJIDA) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x6F8F420", Offset = "0x6F8DE20", VA = "0x186F8F420")]
	private LDOGEOGHOLH GEPBOINCFBB(JHHNPEBPLNM GPCNCGBOPJG, NOCKKKPBJAK EECJCJLHLIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
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
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public OIIBAKCIDJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x6F9BAC0", Offset = "0x6F9A4C0", VA = "0x186F9BAC0")]
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
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public MIMPMDOFDGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x6F98560", Offset = "0x6F96F60", VA = "0x186F98560")]
		internal object MLMAKMIDCHG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private ILFDHJAHNHI FAELELHBKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private FGAHPIAHGMI DLEEJBBLHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private KIJJEBJPOIH OFBHFEIOFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private DHPDBLFEFKM PODDALKBECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private GNDHGGJAABG DKKIFNFPLNE;

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6F97020", Offset = "0x6F95A20", VA = "0x186F97020", Slot = "6")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x6F961A0", Offset = "0x6F94BA0", VA = "0x186F961A0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x6F969E0", Offset = "0x6F953E0", VA = "0x186F969E0", Slot = "4")]
	public ILGKIPAKNNM GIOEHONMECA(JHHNPEBPLNM MJJIPHKHOEB)
	{
		return default(ILGKIPAKNNM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x6F96E10", Offset = "0x6F95810", VA = "0x186F96E10", Slot = "5")]
	public void GLALEPFIHIM(Guid KPMGFINBLBG, Task FPNFJMOCKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x6F97660", Offset = "0x6F96060", VA = "0x186F97660")]
	private void NFMAFIEKMLN(byte IEEHAPDEHNL, int OHGHBMACDMM, object AENCOFPLNBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x6F95960", Offset = "0x6F94360", VA = "0x186F95960")]
	private void BIMAPAGNABO(NDIHCAFDEOE BGEDEFLEFII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x6F964D0", Offset = "0x6F94ED0", VA = "0x186F964D0")]
	private void FOJGMPCGJHJ(NDIHCAFDEOE BGEDEFLEFII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x6F97190", Offset = "0x6F95B90", VA = "0x186F97190")]
	private void MCMMFKDFMPA(NDIHCAFDEOE BGEDEFLEFII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x6F97730", Offset = "0x6F96130", VA = "0x186F97730")]
	private DGFDNIJCPMA PKLJABLJELL(JHHNPEBPLNM PIHNIIFANNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x6F967D0", Offset = "0x6F951D0", VA = "0x186F967D0")]
	private void GAKFFOGHFBP(JHHNPEBPLNM LLGJLDCBANK, DGFDNIJCPMA OMMIFMPIFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x6F95EF0", Offset = "0x6F948F0", VA = "0x186F95EF0")]
	private bool CCNCLFFLLID(JHHNPEBPLNM LLGJLDCBANK, DGFDNIJCPMA OMMIFMPIFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x6F96250", Offset = "0x6F94C50", VA = "0x186F96250")]
	private bool EGMNIDLJKCE(JHHNPEBPLNM ANENNFMGIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x6F973D0", Offset = "0x6F95DD0", VA = "0x186F973D0")]
	private bool MKEGGCIIGHD(byte IEEHAPDEHNL, ExitGames.Client.Photon.Hashtable BGEDEFLEFII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
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
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public KPFIKNDEFFO operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public EBGLDLIIJJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public JHHNPEBPLNM roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public HIALKOCPJDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x6F8AF40", Offset = "0x6F89940", VA = "0x186F8AF40")]
		internal object NNCHBJALIEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x6F8AE10", Offset = "0x6F89810", VA = "0x186F8AE10")]
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
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public AsyncTaskMethodBuilder<DGFDNIJCPMA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public EBGLDLIIJJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public JHHNPEBPLNM roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private TaskAwaiter<DGFDNIJCPMA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x6F850F0", Offset = "0x6F83AF0", VA = "0x186F850F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x6F85780", Offset = "0x6F84180", VA = "0x186F85780", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public KPFIKNDEFFO operationType;

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public CHLLPLHOFNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x6F857F0", Offset = "0x6F841F0", VA = "0x186F857F0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public KBPCGEPADNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x6F91090", Offset = "0x6F8FA90", VA = "0x186F91090")]
		internal object BNDOMKNNCBN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x6F91100", Offset = "0x6F8FB00", VA = "0x186F91100")]
		internal object DOJIPMJKKMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x6F91020", Offset = "0x6F8FA20", VA = "0x186F91020")]
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
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public AsyncTaskMethodBuilder<DGFDNIJCPMA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public EBGLDLIIJJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private KBPCGEPADNC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private ILGKIPAKNNM <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private DGFDNIJCPMA <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private TaskAwaiter<(DGFDNIJCPMA validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x6F7EAC0", Offset = "0x6F7D4C0", VA = "0x186F7EAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F370", Offset = "0x6F7DD70", VA = "0x186F7F370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private ILFDHJAHNHI FAELELHBKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private FGAHPIAHGMI DLEEJBBLHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private LNJOHEOEPEC DCEOPNHDHAB;

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x6F86890", Offset = "0x6F85290", VA = "0x186F86890", Slot = "5")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x6F86630", Offset = "0x6F85030", VA = "0x186F86630", Slot = "4")]
	[AsyncStateMachine(typeof(CHLDPGIABKC))]
	private Task<DGFDNIJCPMA> ADIBGCJIAIH(JHHNPEBPLNM PIHNIIFANNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x6F86940", Offset = "0x6F85340", VA = "0x186F86940")]
	private bool LFAJICGJEBM(KPFIKNDEFFO LJJJHDHDDOO, [Out] DGFDNIJCPMA ADPMAHMCGNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x6F86750", Offset = "0x6F85150", VA = "0x186F86750")]
	[AsyncStateMachine(typeof(ACAIJAOKMJD))]
	private Task<DGFDNIJCPMA> CEEGAKPAPOH(JHHNPEBPLNM GPCNCGBOPJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
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
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public AsyncTaskMethodBuilder<JBBIANFGILF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public AKDLKDBIAEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<FLKIEPIEFEG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private TaskAwaiter<JBBIANFGILF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x6F80D90", Offset = "0x6F7F790", VA = "0x186F80D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x6F81360", Offset = "0x6F7FD60", VA = "0x186F81360", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public MLMGGBGFFBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x6F98B40", Offset = "0x6F97540", VA = "0x186F98B40")]
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
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public AsyncTaskMethodBuilder<FLKIEPIEFEG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public AKDLKDBIAEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private MLMGGBGFFBO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private TaskAwaiter<FLKIEPIEFEG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x6F88750", Offset = "0x6F87150", VA = "0x186F88750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x6F88D40", Offset = "0x6F87740", VA = "0x186F88D40", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public AsyncTaskMethodBuilder<JBBIANFGILF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public AKDLKDBIAEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public FLKIEPIEFEG roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private TaskAwaiter<(KEOGFOOKLEH superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x6F89BC0", Offset = "0x6F885C0", VA = "0x186F89BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x6F8A020", Offset = "0x6F88A20", VA = "0x186F8A020", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public AGKHFKGBNBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x92C050", Offset = "0x92AA50", VA = "0x18092C050")]
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
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public AsyncTaskMethodBuilder<(KEOGFOOKLEH superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public FLKIEPIEFEG roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public AKDLKDBIAEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private TaskAwaiter<(KEOGFOOKLEH superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x6F8A700", Offset = "0x6F89100", VA = "0x186F8A700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x6F8ADA0", Offset = "0x6F897A0", VA = "0x186F8ADA0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public OLIEEAFBADB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x6F9BB90", Offset = "0x6F9A590", VA = "0x186F9BB90")]
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
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public AsyncTaskMethodBuilder<(KEOGFOOKLEH superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public HCDOMJKEJGM subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public AKDLKDBIAEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public MDBDBMHCDOA dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private OLIEEAFBADB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private TaskAwaiter<HNKJBJIHEKD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x6F822A0", Offset = "0x6F80CA0", VA = "0x186F822A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x6F829D0", Offset = "0x6F813D0", VA = "0x186F829D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private static readonly (KEOGFOOKLEH superRoomData, long subRoomDataSaveId) OLKFKEJHBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private MFEINKDLEHJ EKMGPIDNBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	private FJDMGDBCEIP LPFOAEHCDII;

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x6F7FCA0", Offset = "0x6F7E6A0", VA = "0x186F7FCA0", Slot = "5")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x6F7FB40", Offset = "0x6F7E540", VA = "0x186F7FB40", Slot = "4")]
	[AsyncStateMachine(typeof(BNNONHLMBDJ))]
	public Task<JBBIANFGILF> HEIELJDJGCB(OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, MDBDBMHCDOA OLIIPNAKLLA, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F870", Offset = "0x6F7E270", VA = "0x186F7F870")]
	[AsyncStateMachine(typeof(FGEGEKODOGO))]
	private Task<FLKIEPIEFEG> CLMLMLFBNGB(MDBDBMHCDOA OLIIPNAKLLA, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F9D0", Offset = "0x6F7E3D0", VA = "0x186F7F9D0")]
	[AsyncStateMachine(typeof(HAHKDFNBKKJ))]
	private Task<JBBIANFGILF> CNGOKCGJIMP(MDBDBMHCDOA OLIIPNAKLLA, FLKIEPIEFEG MGNEMJNJPBC, long MMMJFAODPOA, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x6F7FEA0", Offset = "0x6F7E8A0", VA = "0x186F7FEA0")]
	[AsyncStateMachine(typeof(HFMMKMFIOKF))]
	private Task<(KEOGFOOKLEH, long)> KJBLKACJONI(MDBDBMHCDOA OLIIPNAKLLA, FLKIEPIEFEG MGNEMJNJPBC, long MMMJFAODPOA, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x6F7FD30", Offset = "0x6F7E730", VA = "0x186F7FD30")]
	[AsyncStateMachine(typeof(CBPACJKAOOO))]
	private Task<(KEOGFOOKLEH, long)> JJCPGCALCHB(MDBDBMHCDOA GJPPIGHDBDI, HCDOMJKEJGM FMOALFGMFNJ, long MMMJFAODPOA, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
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
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public CABABMGDIDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x6F82240", Offset = "0x6F80C40", VA = "0x186F82240")]
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
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public AsyncTaskMethodBuilder<JHHNPEBPLNM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public PBLPMMAAJPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public NOCKKKPBJAK pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x6F85FB0", Offset = "0x6F849B0", VA = "0x186F85FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x6F865C0", Offset = "0x6F84FC0", VA = "0x186F865C0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public AsyncTaskMethodBuilder<JHHNPEBPLNM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public PBLPMMAAJPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public NOCKKKPBJAK pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private TaskAwaiter<GLCNHMNLOKL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x6F8A090", Offset = "0x6F88A90", VA = "0x186F8A090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x6F8A690", Offset = "0x6F89090", VA = "0x186F8A690", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public OKJPIDHGIGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x6F9BB30", Offset = "0x6F9A530", VA = "0x186F9BB30")]
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
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public AsyncTaskMethodBuilder<JHHNPEBPLNM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public PBLPMMAAJPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public NOCKKKPBJAK pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private NLAOPAEBMHG <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private FIPBDBKIEEE <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private TaskAwaiter<GLCNHMNLOKL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x6F83FC0", Offset = "0x6F829C0", VA = "0x186F83FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x6F84BB0", Offset = "0x6F835B0", VA = "0x186F84BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private ILFDHJAHNHI FAELELHBKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private DKMKDMJDKAD BIOBKNDENDB;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	private AGBLOFNHMNJ CGDMKGIJFNC
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x6F9BCA0", Offset = "0x6F9A6A0", VA = "0x186F9BCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x6F9C0B0", Offset = "0x6F9AAB0", VA = "0x186F9C0B0", Slot = "8")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x6F9BEA0", Offset = "0x6F9A8A0", VA = "0x186F9BEA0", Slot = "4")]
	[AsyncStateMachine(typeof(DMJEDLKGDEI))]
	public Task<JHHNPEBPLNM> ELIGHDCDHPD(JHHNPEBPLNM GPCNCGBOPJG, NOCKKKPBJAK EECJCJLHLIP, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x6F9C140", Offset = "0x6F9AB40", VA = "0x186F9C140", Slot = "5")]
	[AsyncStateMachine(typeof(HANMNAEFEGC))]
	public Task<JHHNPEBPLNM> NEJJKEMHNPK(CancellationToken MPLGBOFHPLM, NOCKKKPBJAK EECJCJLHLIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x6F9C000", Offset = "0x6F9AA00", VA = "0x186F9C000", Slot = "6")]
	public AOOKNBGCDKI GCAGPDDCIGD(LDOGEOGHOLH JLCNMJIDAOM, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x6F9BD60", Offset = "0x6F9A760", VA = "0x186F9BD60", Slot = "7")]
	public AOOKNBGCDKI BLGCCGBNIDG(LDOGEOGHOLH JLCNMJIDAOM, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x6F9C290", Offset = "0x6F9AC90", VA = "0x186F9C290")]
	[AsyncStateMachine(typeof(CGALDJOHNGG))]
	private Task<JHHNPEBPLNM> PBPMPIHGEDG(JHHNPEBPLNM GPCNCGBOPJG, NOCKKKPBJAK EECJCJLHLIP, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x31DBFA0", Offset = "0x31DA9A0", VA = "0x1831DBFA0")]
	private static byte[] GOABJGJKCCI(JHHNPEBPLNM JNNDBFGKHHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public PBLPMMAAJPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[UnityEngine.Scripting.Preserve]
internal sealed class EFHPJLNDOMI : FGAHPIAHGMI, DLOEDDKPHPI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private NBAHHDNKILP PLDFHJDBLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private ILFDHJAHNHI FAELELHBKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private GAGJCKDHAGD JIMBHKPDLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private GDNPJMDDBLG HGNPBLNJDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private MFEINKDLEHJ EKMGPIDNBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private FFDBLCGPPMM MCGBLNMHNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private GPMIBIFCKBJ LPINBJBANHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private KJHGHIOALEA AACIHKHGIHG;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	private FFAMIDMIBLK HFPCNNCNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x6F87580", Offset = "0x6F85F80", VA = "0x186F87580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private static DGFDNIJCPMA AFLLLJEHLHL
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x6F85990", Offset = "0x6F84390", VA = "0x186F85990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x6F86FA0", Offset = "0x6F859A0", VA = "0x186F86FA0", Slot = "6")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x6F87410", Offset = "0x6F85E10", VA = "0x186F87410", Slot = "4")]
	public DGFDNIJCPMA MBKKPDMNLNB(LCMANADAOPN KNKLAKPFAOI, KPFIKNDEFFO OFNDKLGKJDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x6F87110", Offset = "0x6F85B10", VA = "0x186F87110", Slot = "5")]
	public DGFDNIJCPMA IKOPFOCCMFH(LCMANADAOPN NACPIIAAOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x6F859F0", Offset = "0x6F843F0", VA = "0x186F859F0")]
	private static DGFDNIJCPMA LGFAHEEJNOP(IOJDCLBFPMF NPGFMGMHJJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public EFHPJLNDOMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class MMECDHDBMIH : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x6F98BF0", Offset = "0x6F975F0", VA = "0x186F98BF0")]
	public MMECDHDBMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x64137C0", Offset = "0x64121C0", VA = "0x1864137C0")]
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
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public AsyncTaskMethodBuilder<DGFDNIJCPMA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public KNEPLNMCHOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public NCKGPLMHNNB autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private OADONCMLPJG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private OADONCMLPJG<string>.HILOONJJDHL <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private OCGMAIALJEA <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private TaskAwaiter<DGFDNIJCPMA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x6F97970", Offset = "0x6F96370", VA = "0x186F97970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x6F984F0", Offset = "0x6F96EF0", VA = "0x186F984F0", Slot = "5")]
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
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x6F92250", Offset = "0x6F90C50", VA = "0x186F92250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x6F929A0", Offset = "0x6F913A0", VA = "0x186F929A0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public KNEPLNMCHOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x6F9A730", Offset = "0x6F99130", VA = "0x186F9A730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x6F9AC40", Offset = "0x6F99640", VA = "0x186F9AC40", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public KNEPLNMCHOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x6F94190", Offset = "0x6F92B90", VA = "0x186F94190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x6F948E0", Offset = "0x6F932E0", VA = "0x186F948E0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public KNEPLNMCHOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x6F93CD0", Offset = "0x6F926D0", VA = "0x186F93CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x6F93E70", Offset = "0x6F92870", VA = "0x186F93E70", Slot = "5")]
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
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x6F80610", Offset = "0x6F7F010", VA = "0x186F80610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x6F80D30", Offset = "0x6F7F730", VA = "0x186F80D30", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public KNEPLNMCHOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x6F84C20", Offset = "0x6F83620", VA = "0x186F84C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x6F85090", Offset = "0x6F83A90", VA = "0x186F85090", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public KNEPLNMCHOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public HCEEFOPOCMM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private OADONCMLPJG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x6F903E0", Offset = "0x6F8EDE0", VA = "0x186F903E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x6F90940", Offset = "0x6F8F340", VA = "0x186F90940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private ILFDHJAHNHI FAELELHBKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private MFEINKDLEHJ EKMGPIDNBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private GNGDMGCCAPD ELAJIBPEDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private GAGJCKDHAGD JIMBHKPDLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private GPMIBIFCKBJ LPINBJBANHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private CancellationTokenSource GLAECGNFBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private Task HBOAIMOJKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private TaskCompletionSource<int> CHKFKKHGIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private int JMGPACPBHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	private int ABBDGPKNACJ;

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x6F92FC0", Offset = "0x6F919C0", VA = "0x186F92FC0", Slot = "6")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0xA738F0", Offset = "0xA722F0", VA = "0x180A738F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x6F93390", Offset = "0x6F91D90", VA = "0x186F93390")]
	private void KENOGMLIIJC(float EODHKDJNLAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x6F93260", Offset = "0x6F91C60", VA = "0x186F93260", Slot = "4")]
	[AsyncStateMachine(typeof(MGJOLEKJICM))]
	public Task<DGFDNIJCPMA> JFAEBIMIGEM(NCKGPLMHNNB HEEEABJCCCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x6F93470", Offset = "0x6F91E70", VA = "0x186F93470", Slot = "5")]
	[AsyncStateMachine(typeof(KKDEDEIKJBL))]
	public Task LCOGCHLMALM([Optional] CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0xA738F0", Offset = "0xA722F0", VA = "0x180A738F0")]
	public void CNPJEKFBNHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x6F92C60", Offset = "0x6F91660", VA = "0x186F92C60")]
	private OCGMAIALJEA DKEKHADIABB(NCKGPLMHNNB HEEEABJCCCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x6F93170", Offset = "0x6F91B70", VA = "0x186F93170")]
	[AsyncStateMachine(typeof(NOMHJOPBDOP))]
	private Task IDFCJDCFLLA(CancellationToken LJPECIOGMKH, int IDCPOPPPDDB, JLMLCKPCLMI ONEPKIAFHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x6F92DD0", Offset = "0x6F917D0", VA = "0x186F92DD0")]
	[AsyncStateMachine(typeof(LKDKPEPCDNM))]
	private Task EAMHJPAFKAH(CancellationToken LJPECIOGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x6F93670", Offset = "0x6F92070", VA = "0x186F93670")]
	[AsyncStateMachine(typeof(LJEOLNGJFDF))]
	private Task LLONGBMBIFH([Optional] CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x6F92ED0", Offset = "0x6F918D0", VA = "0x186F92ED0")]
	[AsyncStateMachine(typeof(BKPHKDFGKEN))]
	private Task FEGEFKCOLBK(CancellationToken LJPECIOGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x6F93760", Offset = "0x6F92160", VA = "0x186F93760")]
	[AsyncStateMachine(typeof(CGNINGFKIPB))]
	private Task NOBGFDFOJPB(CancellationToken LHIBLAEHAHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x6F93860", Offset = "0x6F92260", VA = "0x186F93860")]
	private Task PIAALHKKFCK(HCEEFOPOCMM LKIPKDFOIKO, CancellationToken LJPECIOGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x6F93560", Offset = "0x6F91F60", VA = "0x186F93560")]
	[AsyncStateMachine(typeof(JKHPIJOHMOC))]
	private Task LEDAEHMICIM(HCEEFOPOCMM LKIPKDFOIKO, CancellationToken LJPECIOGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x6F92A00", Offset = "0x6F91400", VA = "0x186F92A00")]
	private bool DJPMKICBDLN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
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
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public KBJCNLMGEBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private OADONCMLPJG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x6F88F80", Offset = "0x6F87980", VA = "0x186F88F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x6F894E0", Offset = "0x6F87EE0", VA = "0x186F894E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	private OMKEILKNJFC NPKMKLLOPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	private FGAHPIAHGMI DLEEJBBLHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	private GNGDMGCCAPD ELAJIBPEDAA;

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x6F90C50", Offset = "0x6F8F650", VA = "0x186F90C50", Slot = "6")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x6F90C00", Offset = "0x6F8F600", VA = "0x186F90C00", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x6F90AA0", Offset = "0x6F8F4A0", VA = "0x186F90AA0", Slot = "5")]
	[AsyncStateMachine(typeof(FMNELMMCLGK))]
	public Task CEOGFJOOFNG(string BECGFNBELMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x6F90BA0", Offset = "0x6F8F5A0", VA = "0x186F90BA0", Slot = "4")]
	public DGFDNIJCPMA DJPMKICBDLN(LCMANADAOPN KNKLAKPFAOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x6F90F30", Offset = "0x6F8F930", VA = "0x186F90F30")]
	private JKIDNJAJEEP MAPPHJOCDOK(string BECGFNBELMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public KBJCNLMGEBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public static class OHKFAKLBMEA
{
	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x6F9B1F0", Offset = "0x6F99BF0", VA = "0x186F9B1F0")]
	public static void CMAHDMNADIP(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x6F9B430", Offset = "0x6F99E30", VA = "0x186F9B430")]
	internal static void FIJMHCAIMNB(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x6F9B9E0", Offset = "0x6F9A3E0", VA = "0x186F9B9E0")]
	internal static void MGOKHOADIFP(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x6F9B590", Offset = "0x6F99F90", VA = "0x186F9B590")]
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
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public JHHNPEBPLNM message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public IKECNMIPAJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x6F8DA10", Offset = "0x6F8C410", VA = "0x186F8DA10")]
		internal object BJKIKAPFGMG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly IJCKLOFHIFP MJFJCBEEADM;

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D770", Offset = "0x6F8C170", VA = "0x186F8D770")]
	public ExitGames.Client.Photon.Hashtable OPCGAJMHMBL(JHHNPEBPLNM JNNDBFGKHHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D800", Offset = "0x6F8C200", VA = "0x186F8D800", Slot = "5")]
	protected override void PDCANANKNJH(JHHNPEBPLNM JNNDBFGKHHD, IDictionary<object, object> LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D180", Offset = "0x6F8BB80", VA = "0x186F8D180", Slot = "6")]
	public override JHHNPEBPLNM DGBBAPGEGII(IDictionary<object, object> LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D3B0", Offset = "0x6F8BDB0", VA = "0x186F8D3B0")]
	private static void MGFMJHPPHBP(string MFIDPDMAIND, JHHNPEBPLNM JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D9D0", Offset = "0x6F8C3D0", VA = "0x186F8D9D0")]
	public IJCKLOFHIFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D4C0", Offset = "0x6F8BEC0", VA = "0x186F8D4C0")]
	[CompilerGenerated]
	internal static string NJPGLJCLIKP(JBBIANFGILF MIJPDJDOIDB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public static class DEPHGOGNEHH
{
	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public static DGFDNIJCPMA AFLLLJEHLHL
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x6F85990", Offset = "0x6F84390", VA = "0x186F85990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F85EB0", Offset = "0x6F848B0", VA = "0x186F85EB0")]
	public static bool MMMIIKFLHMB(this DGFDNIJCPMA OMMIFMPIFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x6F859F0", Offset = "0x6F843F0", VA = "0x186F859F0")]
	public static DGFDNIJCPMA LGFAHEEJNOP(IOJDCLBFPMF MNCJHJGEMJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F85A50", Offset = "0x6F84450", VA = "0x186F85A50")]
	public static DGFDNIJCPMA LKFNKJCJHNP(IEnumerable<DGFDNIJCPMA> HLKJLHJANAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x6F85C50", Offset = "0x6F84650", VA = "0x186F85C50")]
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
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public LCMANADAOPN photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public HLIHCIEBPPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x6638D70", Offset = "0x6637770", VA = "0x186638D70")]
		internal DGFDNIJCPMA GMNCIGHMOFL(PHLOHJMEDAC v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000314")]
	private bool LOOMHHLOKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	protected readonly HashSet<PHLOHJMEDAC> DCCNPGLMPDA;

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F94A50", Offset = "0x6F93450", VA = "0x186F94A50", Slot = "4")]
	public void ICOAKFCEEGG(PHLOHJMEDAC MALFIDMAHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x6F949F0", Offset = "0x6F933F0", VA = "0x186F949F0", Slot = "5")]
	public void GCDCOOGHCJC(PHLOHJMEDAC MALFIDMAHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F949A0", Offset = "0x6F933A0", VA = "0x186F949A0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F94AB0", Offset = "0x6F934B0", VA = "0x186F94AB0")]
	protected DGFDNIJCPMA KPBLPCLNAJN(LCMANADAOPN NACPIIAAOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x6F94D50", Offset = "0x6F93750", VA = "0x186F94D50")]
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
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public DGFDNIJCPMA result;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public OBNKKPFDFHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x6F9AFF0", Offset = "0x6F999F0", VA = "0x186F9AFF0")]
		internal object NOLMMJAHICD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F886C0", Offset = "0x6F870C0", VA = "0x186F886C0")]
	[UnityEngine.Scripting.Preserve]
	public ICGKEGKACAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F8B8D0", Offset = "0x6F8A2D0", VA = "0x186F8B8D0", Slot = "8")]
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
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public DGFDNIJCPMA result;

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public PBHCDHBJPCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F9BC40", Offset = "0x6F9A640", VA = "0x186F9BC40")]
		internal object FFAPHNLCABO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x6F886C0", Offset = "0x6F870C0", VA = "0x186F886C0")]
	[UnityEngine.Scripting.Preserve]
	public FEEGGDIGHPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x6F885B0", Offset = "0x6F86FB0", VA = "0x186F885B0", Slot = "8")]
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
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public OADONCMLPJG<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public PLCJONIAFOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x6F9D110", Offset = "0x6F9BB10", VA = "0x186F9D110")]
		internal object NMHFIGPLJJC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x6F95700", Offset = "0x6F94100", VA = "0x186F95700")]
	public static OADONCMLPJG<string> ADOMOAHOKMN(CDLNJDLNIPA KBNCOADBJAI, [Optional] string NELDGGFCGBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6F958A0", Offset = "0x6F942A0", VA = "0x186F958A0")]
	public static void PAINIEOMMIF(OADONCMLPJG<string> GFNLGFOFJFM, CDLNJDLNIPA KBNCOADBJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x6F957E0", Offset = "0x6F941E0", VA = "0x186F957E0")]
	public static string BEINGEOEJIE(JHHNPEBPLNM PIHNIIFANNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal static class OCAJHOCDPLC
{
	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x6F9B050", Offset = "0x6F99A50", VA = "0x186F9B050")]
	public static void IOKJHAALHMO(this ILFDHJAHNHI FAELELHBKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x6F9B180", Offset = "0x6F99B80", VA = "0x186F9B180")]
	public static void ONKCLFPAGNJ(this ILFDHJAHNHI FAELELHBKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x6F9B060", Offset = "0x6F99A60", VA = "0x186F9B060")]
	private static void OGCAIFHMACF(this ILFDHJAHNHI FAELELHBKKO, bool PPIBKPHJPDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public class MJCLPMIECAL : LHBACLGNGEP, IIGABFJMEDH, NCHALEHKFGO, GCDIDGMHHIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	private readonly IIGABFJMEDH KNBEMFOOBEO;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public LCMANADAOPN BNIDNLLDGDI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x6F985D0", Offset = "0x6F96FD0", VA = "0x186F985D0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int NLIMGMDJKMB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x6F98870", Offset = "0x6F97270", VA = "0x186F98870", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public int KEIOJNKNJMA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x6F98AF0", Offset = "0x6F974F0", VA = "0x186F98AF0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool KFNLGFNJAKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x86D5A0", Offset = "0x86BFA0", VA = "0x18086D5A0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public int FHAMDDJKDHM
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x8C3EC0", Offset = "0x8C28C0", VA = "0x1808C3EC0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event GBFIPMEOIEO.IIICGAPIKPN FDGMLHJPMCC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event EMPLKCIGFHB FAAGLMBMKBP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x6F987D0", Offset = "0x6F971D0", VA = "0x186F987D0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x6F98620", Offset = "0x6F97020", VA = "0x186F98620", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> ALIFLIBGFBI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<LCMANADAOPN> FCAFMIJALDC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action JPCOBLHHKLB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x6F98A50", Offset = "0x6F97450", VA = "0x186F98A50", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x6F98730", Offset = "0x6F97130", VA = "0x186F98730", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0xCAAAD0", Offset = "0xCA94D0", VA = "0x180CAAAD0")]
	public MJCLPMIECAL(IIGABFJMEDH KNBEMFOOBEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x6F988C0", Offset = "0x6F972C0", VA = "0x186F988C0", Slot = "8")]
	public bool LLGBFLNNPKP(byte IEEHAPDEHNL, ExitGames.Client.Photon.Hashtable HLPJEBAFCEI, KGBEHAIDAFK HNCFNOCLOFC, SendOptions PNIFNNMGDFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x6F98970", Offset = "0x6F97370", VA = "0x186F98970", Slot = "16")]
	public LCMANADAOPN MCNNANDHEGF(int LKMOKKELGIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "19")]
	public void CCHHCCMEFDH(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "20")]
	public void NCLNJAFLICJ(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "21")]
	public void IFLIFIEEPEH(object EOCJCEFCOOA, bool HNBFKCCDJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F986C0", Offset = "0x6F970C0", VA = "0x186F986C0", Slot = "22")]
	public IDisposable JAMBAJOBMOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x899BF0", VA = "0x18089B1F0", Slot = "23")]
	private bool MOFFPJGMBLD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "24")]
	public void BGDDHBNJMCK(StringBuilder EBMHMAKKCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F98710", Offset = "0x6F97110", VA = "0x186F98710", Slot = "25")]
	public bool JPOBOCAEGBK(bool DCHKPIILKAF, [Out] string GGEHLADLJHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x978400", Offset = "0x976E00", VA = "0x180978400", Slot = "28")]
	public void LJEEHGIHICP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal struct NDIHCAFDEOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	private readonly IDictionary<object, object> BGEDEFLEFII;

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x926780", Offset = "0x925180", VA = "0x180926780")]
	public NDIHCAFDEOE(IDictionary<object, object> BGEDEFLEFII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F99F00", Offset = "0x6F98900", VA = "0x186F99F00")]
	public bool LEOKLOLLEBG([Out] JHHNPEBPLNM JNNDBFGKHHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F9A0F0", Offset = "0x6F98AF0", VA = "0x186F9A0F0")]
	public Guid NFINFGAHIFN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x6F99FB0", Offset = "0x6F989B0", VA = "0x186F99FB0")]
	public DGFDNIJCPMA MHDDMELJGMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x6F99E10", Offset = "0x6F98810", VA = "0x186F99E10")]
	public static ExitGames.Client.Photon.Hashtable JGIIBNEOBDO(JHHNPEBPLNM JNNDBFGKHHD, DGFDNIJCPMA OMMIFMPIFCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal static class AIGNFIKLEED
{
	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F7F0", Offset = "0x6F7E1F0", VA = "0x186F7F7F0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public LJJNFBNGNFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x6F939F0", Offset = "0x6F923F0", VA = "0x186F939F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x6F93BD0", Offset = "0x6F925D0", VA = "0x186F93BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	private readonly CancellationTokenSource NPCICLIMLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000321")]
	private bool LOOMHHLOKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	private Task LEDCCMOCHJB;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool OONANGMADII
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x6F93ED0", Offset = "0x6F928D0", VA = "0x186F93ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F94060", Offset = "0x6F92A60", VA = "0x186F94060")]
	public LJJNFBNGNFA(CancellationToken MPLGBOFHPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x6F93F50", Offset = "0x6F92950", VA = "0x186F93F50")]
	[AsyncStateMachine(typeof(KNKBDKPEAAF))]
	public Task GKDNMPIMODG(Func<CancellationToken, List<Task>> FCCDOIIADHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x6F93F00", Offset = "0x6F92900", VA = "0x186F93F00", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public AsyncTaskMethodBuilder<CIKECDEKJAI<MOGOEHIGGGP<TData>, EGADAFAJMEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public PFLNKKCOAHI<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private TaskAwaiter<CIKECDEKJAI<MOGOEHIGGGP<TData>, EGADAFAJMEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x4469460", Offset = "0x4467E60", VA = "0x184469460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x3806940", Offset = "0x3805340", VA = "0x183806940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private readonly AJPKAMNMEFA<TGetDataArg, TData> NMBACBFNMGF;

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x926780", Offset = "0x925180", VA = "0x180926780")]
	internal PFLNKKCOAHI(AJPKAMNMEFA<TGetDataArg, TData> HDLOJHGAFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x4761480", Offset = "0x475FE80", VA = "0x184761480")]
	[AsyncStateMachine(typeof(PFLNKKCOAHI<, >.MBFHGOOPFGO))]
	public Task<CIKECDEKJAI<MOGOEHIGGGP<TData>, EGADAFAJMEN>> HEJLCMFPFKH(TGetDataArg BGLHKLFFJEP, string GCBBANDJGBO, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public static class CLFHENNBCPM
{
	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x259D370", Offset = "0x259BD70", VA = "0x18259D370")]
	public static PFLNKKCOAHI<TGetDataArg, TData> FJAAFKPDAIA<TGetDataArg, TData>(AJPKAMNMEFA<TGetDataArg, TData> HDLOJHGAFKF)
	{
		return default(PFLNKKCOAHI<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public struct DMFAPLFEJDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public readonly int IDKDFLHMDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public readonly int? JFHBOLOLMPM;

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x4221870", Offset = "0x4220270", VA = "0x184221870")]
	public DMFAPLFEJDL(int DMNHBMODOKL, [Optional] int? GCKKBDHCMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x6F85ED0", Offset = "0x6F848D0", VA = "0x186F85ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public interface GELBFHCOJFD<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OINJEINMHLK();

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GELBFHCOJFD<T> CLBDCAFDKCH(string MCMGPBCLOFD);

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GELBFHCOJFD<T> KDEBJKOOMCC(JDBCODNMCIB<T> LCPNIJPJAFM);

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GELBFHCOJFD<T> NLHHLJDJCBO(int LBJMNCMBNEA);

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GELBFHCOJFD<T> IJKKFEMOKBM(int LBJMNCMBNEA, AEDEDFOFFNI<T> NOBJBDLNLFJ);
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public interface GDBDKOPOCLO
{
	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GELBFHCOJFD<T> PNCFFJHHHNH<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LMAFCMMDBNJ EJIBLCEFOHJ(Exception PBAHBFAICPK);

	[Cpp2IlInjected.Token(Token = "0x6000402")]
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
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
			public MPPKJNJLOMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100")]
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
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			public JDBCODNMCIB<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
			public GFLEGAPCNMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x3CB3D60", Offset = "0x3CB2760", VA = "0x183CB3D60")]
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
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			public AEDEDFOFFNI<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
			public CBBBBKGMMHJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x3CB3D60", Offset = "0x3CB2760", VA = "0x183CB3D60")]
			internal int AHKCBDHMIOL(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private readonly IHBKKNBOOHI CLJOHLGPPOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private readonly Type IMEKHFCCHIC;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x5105FA0", Offset = "0x51049A0", VA = "0x185105FA0")]
		internal CFDPBBOJKIG(IHBKKNBOOHI CLJOHLGPPOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x5105F70", Offset = "0x5104970", VA = "0x185105F70", Slot = "4")]
		public void OINJEINMHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x5105BC0", Offset = "0x51045C0", VA = "0x185105BC0", Slot = "5")]
		public GELBFHCOJFD<T> CLBDCAFDKCH(string MCMGPBCLOFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x5105E10", Offset = "0x5104810", VA = "0x185105E10", Slot = "6")]
		public GELBFHCOJFD<T> KDEBJKOOMCC(JDBCODNMCIB<T> LCPNIJPJAFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x5105F30", Offset = "0x5104930", VA = "0x185105F30", Slot = "7")]
		public GELBFHCOJFD<T> NLHHLJDJCBO(int LBJMNCMBNEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x5105CE0", Offset = "0x51046E0", VA = "0x185105CE0", Slot = "8")]
		public GELBFHCOJFD<T> IJKKFEMOKBM(int LBJMNCMBNEA, AEDEDFOFFNI<T> NOBJBDLNLFJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	private class KOEBFDPLEJD<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private bool FFOHEMPBHFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private readonly List<Type> NGEAFLHHKLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private readonly Dictionary<Type, TVal> OAHIBPPNLJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private readonly Dictionary<Type, int> IDPHGIDLAFM;

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public IReadOnlyList<Type> KMDBOACGJPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x41B8620", Offset = "0x41B7020", VA = "0x1841B8620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x41B8B40", Offset = "0x41B7540", VA = "0x1841B8B40")]
		public KOEBFDPLEJD(Dictionary<Type, int> IDPHGIDLAFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x41B8970", Offset = "0x41B7370", VA = "0x1841B8970")]
		public void PBLNBBGFGAP(Type NDDCLPHCEEO, TVal GPBAFILNEOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x41B8580", Offset = "0x41B6F80", VA = "0x1841B8580")]
		public bool BPELFEMFLPO(Type IMEKHFCCHIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x41B85D0", Offset = "0x41B6FD0", VA = "0x1841B85D0")]
		public bool ODHBLCILLBD(TVal JMDCGOKJIDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x3804320", Offset = "0x3802D20", VA = "0x183804320")]
		public TVal JMJOGDIBBHK(Type NCMHJNKFAGH)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x41B8780", Offset = "0x41B7180", VA = "0x1841B8780")]
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
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private DMFAPLFEJDL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public IHBKKNBOOHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private IEnumerator<DMFAPLFEJDL> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		private DMFAPLFEJDL System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0x385AFF0", Offset = "0x38599F0", VA = "0x18385AFF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(DMFAPLFEJDL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x6F95560", Offset = "0x6F93F60", VA = "0x186F95560", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x89FD00", Offset = "0x89E700", VA = "0x18089FD00")]
		[DebuggerHidden]
		public LPDINAJEIDJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x6F955B0", Offset = "0x6F93FB0", VA = "0x186F955B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x6F94FA0", Offset = "0x6F939A0", VA = "0x186F94FA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x6F94F00", Offset = "0x6F93900", VA = "0x186F94F00")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x6F94F50", Offset = "0x6F93950", VA = "0x186F94F50")]
		private void KNPOGHPBEEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x6F95510", Offset = "0x6F93F10", VA = "0x186F95510", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x6F95450", Offset = "0x6F93E50", VA = "0x186F95450", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DMFAPLFEJDL> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x6F95450", Offset = "0x6F93E50", VA = "0x186F95450", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private static readonly DMFAPLFEJDL APAMOKNFMBP;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private static readonly Dictionary<Type, int> PGDMJOGFKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private readonly HashSet<Type> FJJOEDGBJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private readonly KOEBFDPLEJD<int> AHFAEBADILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private readonly KOEBFDPLEJD<KGDFGPEJPLO> NOHDKOFPDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private readonly KOEBFDPLEJD<IBHPDOJEFBA> LDONPMDMNCJ;

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C0C0", Offset = "0x6F8AAC0", VA = "0x186F8C0C0")]
	[GDGALFJPCGE(JMIPDAHBNNG.GameOnly)]
	private static void ECBJKBNABGH(INCIOHANCNE LDLMDJOAIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x6F8CDE0", Offset = "0x6F8B7E0", VA = "0x186F8CDE0")]
	[RecRoom.NoEngine.Common.Preserve]
	public IHBKKNBOOHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x2B5FCD0", Offset = "0x2B5E6D0", VA = "0x182B5FCD0", Slot = "4")]
	public GELBFHCOJFD<T> PNCFFJHHHNH<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C130", Offset = "0x6F8AB30", VA = "0x186F8C130", Slot = "5")]
	public LMAFCMMDBNJ EJIBLCEFOHJ(Exception PBAHBFAICPK)
	{
		return default(LMAFCMMDBNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x6F8CA30", Offset = "0x6F8B430", VA = "0x186F8CA30", Slot = "6")]
	public DMFAPLFEJDL LKHKMCHILPP(Exception? PBAHBFAICPK)
	{
		return default(DMFAPLFEJDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C990", Offset = "0x6F8B390", VA = "0x186F8C990", Slot = "7")]
	[IteratorStateMachine(typeof(LPDINAJEIDJ))]
	public IEnumerable<DMFAPLFEJDL> KBJJLCOLOEN(Exception PBAHBFAICPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C840", Offset = "0x6F8B240", VA = "0x186F8C840", Slot = "8")]
	public string JOIGGINBEEN(Exception? PBAHBFAICPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x6F8B9E0", Offset = "0x6F8A3E0", VA = "0x186F8B9E0")]
	private string CNHALHKGOCF(AggregateException LOEKHCMHBEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C1C0", Offset = "0x6F8ABC0", VA = "0x186F8C1C0")]
	private void IHEDAKLCGNP(Type IMEKHFCCHIC, int LBJMNCMBNEA, KGDFGPEJPLO? OFELHHJPODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x6F8BE70", Offset = "0x6F8A870", VA = "0x186F8BE70")]
	private void DMILLEEEOCG(Type IMEKHFCCHIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C570", Offset = "0x6F8AF70", VA = "0x186F8C570")]
	private void ILLEOJDGNAJ(Type IMEKHFCCHIC, IBHPDOJEFBA OEGEKJOGIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x6F8BCF0", Offset = "0x6F8A6F0", VA = "0x186F8BCF0")]
	private static int DALIPMEINOJ(Type IMEKHFCCHIC, Dictionary<Type, int> IDPHGIDLAFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x2B83A00", Offset = "0x2B82400", VA = "0x182B83A00")]
	private static bool AKKNKPDDGNK<TVal>(KOEBFDPLEJD<TVal> MNHECFLLMJH, Type IMEKHFCCHIC, [Out] TVal JMDCGOKJIDA) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x6F8CC30", Offset = "0x6F8B630", VA = "0x186F8CC30")]
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
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public readonly DMFAPLFEJDL CAEPJNKNMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public readonly string JCDCACKMBMN;

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x6F94E80", Offset = "0x6F93880", VA = "0x186F94E80")]
	public LMAFCMMDBNJ(string KMIMCLPDKGD, DMFAPLFEJDL LBJMNCMBNEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x6F94DE0", Offset = "0x6F937E0", VA = "0x186F94DE0")]
	public string HGKGFJHHKFM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class BOAMHEKDIOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private readonly ACFAMDNJIMF HOFJLGDPOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private string IHALHOEJCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private long? JKAIGOMEDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private long? GDGAGLKACJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private long? MMKGMIIENIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private string FCNEGMPAAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private BAEGFPFJEKP DDIJAKOKPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private long? CDPILCBBCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private bool IBOMEKKHAFM;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public string ALLCOBLMNJC
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public long HOBGBCGFHFI
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x6F821A0", Offset = "0x6F80BA0", VA = "0x186F821A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public long JGPHNMFFODD
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x6F82100", Offset = "0x6F80B00", VA = "0x186F82100")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public long KKBFFPMLMEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x6F81AF0", Offset = "0x6F804F0", VA = "0x186F81AF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public string AAIIPJLPFIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x6F82160", Offset = "0x6F80B60", VA = "0x186F82160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public BAEGFPFJEKP JHHDEGHBEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0xA61CC0", Offset = "0xA606C0", VA = "0x180A61CC0")]
		get
		{
			return default(BAEGFPFJEKP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x6F813D0", Offset = "0x6F7FDD0", VA = "0x186F813D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public long DJJKHHEPNFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x6F81710", Offset = "0x6F80110", VA = "0x186F81710")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x6F82200", Offset = "0x6F80C00", VA = "0x186F82200")]
	[UnityEngine.Scripting.Preserve]
	public BOAMHEKDIOK([OMAPKKAGFIL(null)] ACFAMDNJIMF HOFJLGDPOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x6F814C0", Offset = "0x6F7FEC0", VA = "0x186F814C0")]
	private void DADNIIDGHDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x6F81C70", Offset = "0x6F80670", VA = "0x186F81C70")]
	public void HNFDEIEALJH(long DIMOGDCMBFM, long MMMJFAODPOA, [Optional] long? LMGCMDBJBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x6F81B50", Offset = "0x6F80550", VA = "0x186F81B50")]
	public void GANGAAPLNMJ(long LMGCMDBJBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x6F81BF0", Offset = "0x6F805F0", VA = "0x186F81BF0")]
	public void HEMIGHIOIDD(string KNBLDALGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x6F81770", Offset = "0x6F80170", VA = "0x186F81770")]
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
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public AsyncTaskMethodBuilder<JHHNPEBPLNM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public JHHNPEBPLNM roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public AOOKNBGCDKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private TaskAwaiter<AGBLOFNHMNJ.CBEFFACDNLD<JHHNPEBPLNM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x6FAAE50", Offset = "0x6FA9850", VA = "0x186FAAE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB380", Offset = "0x6FA9D80", VA = "0x186FAB380", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class BMODCBKEGML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public JHHNPEBPLNM roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public BMODCBKEGML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x6F9F3A0", Offset = "0x6F9DDA0", VA = "0x186F9F3A0")]
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
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public AsyncTaskMethodBuilder<AGBLOFNHMNJ.CBEFFACDNLD<JHHNPEBPLNM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public JHHNPEBPLNM roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public AOOKNBGCDKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private NLAOPAEBMHG <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private TaskAwaiter<AGBLOFNHMNJ.CBEFFACDNLD<JHHNPEBPLNM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x6FA8CE0", Offset = "0x6FA76E0", VA = "0x186FA8CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x6FA92F0", Offset = "0x6FA7CF0", VA = "0x186FA92F0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public AOOKNBGCDKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x3C8A6F0", Offset = "0x3C890F0", VA = "0x183C8A6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x356F150", Offset = "0x356DB50", VA = "0x18356F150", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public AOOKNBGCDKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x6F9F480", Offset = "0x6F9DE80", VA = "0x186F9F480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x6F9F640", Offset = "0x6F9E040", VA = "0x186F9F640", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public CPDJCELNHOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x6FA1F50", Offset = "0x6FA0950", VA = "0x186FA1F50")]
		internal object PKEABFDGAOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x6FA1E90", Offset = "0x6FA0890", VA = "0x186FA1E90")]
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
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public BBGEFFFEFOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x6F9F340", Offset = "0x6F9DD40", VA = "0x186F9F340")]
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
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public GHHOMEAANDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x6FA6A60", Offset = "0x6FA5460", VA = "0x186FA6A60")]
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
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public PCPBAOOGHNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x6FB4D40", Offset = "0x6FB3740", VA = "0x186FB4D40")]
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
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public AOOKNBGCDKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public KPHLNIHJFCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC1F0", Offset = "0x6FAABF0", VA = "0x186FAC1F0")]
		internal object BJKIKAPFGMG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private static readonly Guid BEKJIAKMEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public readonly LDOGEOGHOLH PCEFFCPFNFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private readonly AGBLOFNHMNJ IMDHKLFLDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	private readonly NCHALEHKFGO FAELELHBKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private readonly GCDIDGMHHIJ AKOFEJNHKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private bool AEJLHEPPBCK;

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EBA0", Offset = "0x6F9D5A0", VA = "0x186F9EBA0")]
	public AOOKNBGCDKI(LDOGEOGHOLH PADMFCNKGOL, AGBLOFNHMNJ IMDHKLFLDMB, NCHALEHKFGO FAELELHBKKO, GCDIDGMHHIJ AKOFEJNHKBC, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x6F9DDF0", Offset = "0x6F9C7F0", VA = "0x186F9DDF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x6F9DCD0", Offset = "0x6F9C6D0", VA = "0x186F9DCD0")]
	public void AJOKGMMPOJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E3A0", Offset = "0x6F9CDA0", VA = "0x186F9E3A0")]
	public void JCEFFGDJBNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E460", Offset = "0x6F9CE60", VA = "0x186F9E460")]
	public void MAOAFACFAFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x6F9DE80", Offset = "0x6F9C880", VA = "0x186F9DE80")]
	[AsyncStateMachine(typeof(INNEMEINFPB))]
	internal Task<JHHNPEBPLNM> HCJJGKLKHFP(OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, JHHNPEBPLNM PIHNIIFANNM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x31DBFA0", Offset = "0x31DA9A0", VA = "0x1831DBFA0")]
	private static byte[] FIKACFFPBMG<T>(T JNNDBFGKHHD) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x31DBE50", Offset = "0x31DA850", VA = "0x1831DBE50")]
	private static T DNGMAFHHGNP<T>(MessageParser<T> KPNGFFCGGHG, byte[] JNNDBFGKHHD, T NKOKHDBOMFH) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E9F0", Offset = "0x6F9D3F0", VA = "0x186F9E9F0")]
	[AsyncStateMachine(typeof(HGDBNNCOFFP))]
	private Task<AGBLOFNHMNJ.CBEFFACDNLD<JHHNPEBPLNM>> PEFHAMFAMDM(JHHNPEBPLNM PIHNIIFANNM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x31DC0A0", Offset = "0x31DAAA0", VA = "0x1831DC0A0")]
	[AsyncStateMachine(typeof(AODMDECPDFP<>))]
	internal Task<T> OLKFELFFMLH<T>(CancellationToken LJPECIOGMKH, Func<CancellationToken, Task<T>> KFEIMOJODHF, int EFINHJDBJEF = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E7B0", Offset = "0x6F9D1B0", VA = "0x186F9E7B0")]
	[AsyncStateMachine(typeof(CBECGODNOOF))]
	internal Task OLKFELFFMLH(CancellationToken LJPECIOGMKH, Func<CancellationToken, Task> KFEIMOJODHF, int EFINHJDBJEF = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x6F9DE00", Offset = "0x6F9C800", VA = "0x186F9DE00")]
	public IOFNMIAGIID GGKOPJBIDKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x6F9DC50", Offset = "0x6F9C650", VA = "0x186F9DC50")]
	public PCJKPFOHLAA AGADJBPJNGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E0F0", Offset = "0x6F9CAF0", VA = "0x186F9E0F0")]
	public OPPOPKDPFEJ IKFHFHLENCI([Optional] CDLNJDLNIPA? KBNCOADBJAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E240", Offset = "0x6F9CC40", VA = "0x186F9E240")]
	public void IMLNJALHMII(Func<Guid, bool> BMMICOLDKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E8E0", Offset = "0x6F9D2E0", VA = "0x186F9E8E0")]
	public void PCHMJOPDGHI(Func<Guid, bool> CJBGLKIMAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E630", Offset = "0x6F9D030", VA = "0x186F9E630")]
	public Guid OCDKPEAMHIM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x6F9DFE0", Offset = "0x6F9C9E0", VA = "0x186F9DFE0")]
	public void HJOMCJIKAEL(Guid LJBACHIBEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x6F9DB10", Offset = "0x6F9C510", VA = "0x186F9DB10")]
	public void ABMKFOJDGKE(JHHNPEBPLNM JBBIODKBMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E520", Offset = "0x6F9CF20", VA = "0x186F9E520")]
	public void MGFMJHPPHBP(string FNOGOHPEEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x31DBFB0", Offset = "0x31DA9B0", VA = "0x1831DBFB0")]
	private T FPAIGDJBKKJ<T>(T JMDCGOKJIDA) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x6F9DAC0", Offset = "0x6F9C4C0", VA = "0x186F9DAC0")]
	public void ABCHJAIGKJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x31DBBA0", Offset = "0x31DA5A0", VA = "0x1831DBBA0")]
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
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public KNLIJFAPCJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC180", Offset = "0x6FAAB80", VA = "0x186FAC180")]
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
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public HCHMJJACOEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private PEJDDGDCLFF <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private PCJKPFOHLAA <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x6FA6AD0", Offset = "0x6FA54D0", VA = "0x186FA6AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x6FA73A0", Offset = "0x6FA5DA0", VA = "0x186FA73A0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public HCHMJJACOEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private bool <omIsEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private bool <omShouldBeEnabled>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private TaskAwaiter<FLKIEPIEFEG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private TaskAwaiter<byte> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x6FB0100", Offset = "0x6FAEB00", VA = "0x186FB0100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x6FB08B0", Offset = "0x6FAF2B0", VA = "0x186FB08B0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public HCHMJJACOEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private TaskAwaiter<HNKJBJIHEKD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x6FAE080", Offset = "0x6FACA80", VA = "0x186FAE080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x6FAE390", Offset = "0x6FACD90", VA = "0x186FAE390", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public PEJDDGDCLFF presence;

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public NCJIGLGCJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x6FB0A10", Offset = "0x6FAF410", VA = "0x186FB0A10")]
		internal object IFJABCIFOFP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	private static readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	private static readonly CDLNJDLNIPA KBKNHCEIBOM;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	private static readonly CDLNJDLNIPA HGNMKAKPHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400038C")]
	private readonly JBBIANFGILF KLNKIGMCCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400038D")]
	private readonly MDBDBMHCDOA EJBBNMBAICD;

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x6FA8B50", Offset = "0x6FA7550", VA = "0x186FA8B50")]
	public HCHMJJACOEA(JBBIANFGILF KLNKIGMCCKO, MDBDBMHCDOA EJBBNMBAICD, Guid KPMGFINBLBG, PNHFEHLPHMO KBCJMHHCDBC, NOCKKKPBJAK HEBPMOPIKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x6FA8750", Offset = "0x6FA7150", VA = "0x186FA8750", Slot = "7")]
	[AsyncStateMachine(typeof(GKDPGBPONGJ))]
	protected override Task JHJGIGBBDDE(AOOKNBGCDKI HOBEPAEHHJL, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x6FA8650", Offset = "0x6FA7050", VA = "0x186FA8650")]
	[AsyncStateMachine(typeof(NAMIDAAADBH))]
	private Task GBOPJINFEFP(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x6FA8540", Offset = "0x6FA6F40", VA = "0x186FA8540")]
	[AsyncStateMachine(typeof(MBGDJCBHEPM))]
	private Task<byte> DGOHIDEKAID(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x6FA8890", Offset = "0x6FA7290", VA = "0x186FA8890")]
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
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public OCGMAIALJEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private TaskAwaiter<BMBMOGELPMJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x6FA2320", Offset = "0x6FA0D20", VA = "0x186FA2320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x6FA2CA0", Offset = "0x6FA16A0", VA = "0x186FA2CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	private readonly int LICNBNKOLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	private readonly NCKGPLMHNNB NHABHPPMDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public readonly long GKKIJACBHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public readonly long PAFDFFODJEJ;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public BMBMOGELPMJ OJOBEJNECJD
	{
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x85FE70", Offset = "0x85E870", VA = "0x18085FE70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x85FEB0", Offset = "0x85E8B0", VA = "0x18085FEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0C70", Offset = "0x6FAF670", VA = "0x186FB0C70")]
	public OCGMAIALJEA(Guid KPMGFINBLBG, PNHFEHLPHMO KBCJMHHCDBC, NOCKKKPBJAK HEBPMOPIKJB, int LICNBNKOLEM, NCKGPLMHNNB NHABHPPMDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0B50", Offset = "0x6FAF550", VA = "0x186FB0B50", Slot = "7")]
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
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public HPMIHEBMPKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public IGNOJPABBPI playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public DCDAHHDPJDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x6FA2040", Offset = "0x6FA0A40", VA = "0x186FA2040")]
		internal Task IFGJHLKGBCL(OADONCMLPJG<string>.HILOONJJDHL postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x6FA1FB0", Offset = "0x6FA09B0", VA = "0x186FA1FB0")]
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
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public HPMIHEBMPKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private DCDAHHDPJDE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x6FAE400", Offset = "0x6FACE00", VA = "0x186FAE400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x6FAEBC0", Offset = "0x6FAD5C0", VA = "0x186FAEBC0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public IGNOJPABBPI playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public HPMIHEBMPKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x6FAFB10", Offset = "0x6FAE510", VA = "0x186FAFB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x6FB00A0", Offset = "0x6FAEAA0", VA = "0x186FB00A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x6FA95E0", Offset = "0x6FA7FE0", VA = "0x186FA95E0")]
	public HPMIHEBMPKI(Guid KPMGFINBLBG, PNHFEHLPHMO KBCJMHHCDBC, NOCKKKPBJAK HEBPMOPIKJB, string JHNINBLPPLN, EFBCINIABEJ LJJJHDHDDOO, bool BGLMCDKAHBI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x6FA9360", Offset = "0x6FA7D60", VA = "0x186FA9360", Slot = "7")]
	[AsyncStateMachine(typeof(MFCKACCHCKK))]
	protected override Task JHJGIGBBDDE(AOOKNBGCDKI HOBEPAEHHJL, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task POFDJKAPCLA(AOOKNBGCDKI HOBEPAEHHJL, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x6FA94A0", Offset = "0x6FA7EA0", VA = "0x186FA94A0")]
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
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public DDDDOLJAOHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private TaskAwaiter<JBBKCFOEFFA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x6FA7890", Offset = "0x6FA6290", VA = "0x186FA7890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x6FA7E00", Offset = "0x6FA6800", VA = "0x186FA7E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	private readonly HCEEFOPOCMM LKIPKDFOIKO;

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x6FA2280", Offset = "0x6FA0C80", VA = "0x186FA2280")]
	public DDDDOLJAOHE(Guid KPMGFINBLBG, PNHFEHLPHMO KBCJMHHCDBC, NOCKKKPBJAK HEBPMOPIKJB, HCEEFOPOCMM LKIPKDFOIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x6FA2080", Offset = "0x6FA0A80", VA = "0x186FA2080", Slot = "6")]
	protected override string BJAGFHJFAKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x6FA2160", Offset = "0x6FA0B60", VA = "0x186FA2160", Slot = "7")]
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
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public OADONCMLPJG<string>.HILOONJJDHL operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public LDOGEOGHOLH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public PAODNFLLCBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x6FB2360", Offset = "0x6FB0D60", VA = "0x186FB2360")]
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
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public PAODNFLLCBK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public LOPMMGFHAFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x6FADFC0", Offset = "0x6FAC9C0", VA = "0x186FADFC0")]
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
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public LDOGEOGHOLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public Func<LDOGEOGHOLH, OADONCMLPJG<string>.HILOONJJDHL, AOOKNBGCDKI> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private PAODNFLLCBK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private AOOKNBGCDKI <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x6F9FE70", Offset = "0x6F9E870", VA = "0x186F9FE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x6FA1030", Offset = "0x6F9FA30", VA = "0x186FA1030", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x6FA2D00", Offset = "0x6FA1700", VA = "0x186FA2D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x6FA3790", Offset = "0x6FA2190", VA = "0x186FA3790", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public LDOGEOGHOLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x6FADC00", Offset = "0x6FAC600", VA = "0x186FADC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x6FADF60", Offset = "0x6FAC960", VA = "0x186FADF60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public readonly Guid BCGKIOLOHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public readonly ByteString GKEIIDKFDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public readonly NOCKKKPBJAK LOICDGCIEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	protected readonly string FLBAFFCOAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private readonly PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private readonly bool BGLMCDKAHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private readonly Queue<HCBHHAMMKNH> BDIHHCCEHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	private readonly NKKKGGINLEP NKGDDIPPMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	private readonly EFBCINIABEJ LJJJHDHDDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	private bool OHAODFIPPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public BAEGFPFJEKP BKNLBEKNLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public BAEGFPFJEKP GBFDEOMKNOD;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public PNHFEHLPHMO NOOCLICDJJM
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x856960", Offset = "0x855360", VA = "0x180856960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public MFEINKDLEHJ KFKHEOKCKBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD2A0", Offset = "0x6FABCA0", VA = "0x186FAD2A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public INNHEOLIKBM MDBMBBPHIBI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD020", Offset = "0x6FABA20", VA = "0x186FAD020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public FFAMIDMIBLK HFPCNNCNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD6E0", Offset = "0x6FAC0E0", VA = "0x186FAD6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event KPJCHGMHNOH ODCPIOEPMDN
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x6FACEC0", Offset = "0x6FAB8C0", VA = "0x186FACEC0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x6FACEA0", Offset = "0x6FAB8A0", VA = "0x186FACEA0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD8A0", Offset = "0x6FAC2A0", VA = "0x186FAD8A0")]
	protected LDOGEOGHOLH(Guid KPMGFINBLBG, PNHFEHLPHMO KBCJMHHCDBC, NOCKKKPBJAK HEBPMOPIKJB, string JHNINBLPPLN, EFBCINIABEJ LJJJHDHDDOO, bool BGLMCDKAHBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x6FACEE0", Offset = "0x6FAB8E0", VA = "0x186FACEE0", Slot = "6")]
	protected virtual string BJAGFHJFAKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD420", Offset = "0x6FABE20", VA = "0x186FAD420")]
	public void JPMIMBKPEIM(HCBHHAMMKNH LDEAEONJEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD760", Offset = "0x6FAC160", VA = "0x186FAD760")]
	protected void PABDMJKMPLE(float MPPCPDMLBPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x6FACD50", Offset = "0x6FAB750", VA = "0x186FACD50")]
	[AsyncStateMachine(typeof(CFNFIENGDPN))]
	public Task AGALHLJOLPH(CancellationToken MPLGBOFHPLM, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, [Optional] Func<LDOGEOGHOLH, OADONCMLPJG<string>.HILOONJJDHL, AOOKNBGCDKI> ECLLCEGPBIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD2F0", Offset = "0x6FABCF0", VA = "0x186FAD2F0")]
	[AsyncStateMachine(typeof(DLAJNJNLAHH))]
	private static Task GOMBJKCFMGA(Func<CancellationToken, Task> HBLGMBBHCGK, Func<CancellationToken, Task> MOPPHNLDCLD, CancellationToken LJPECIOGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD570", Offset = "0x6FABF70", VA = "0x186FAD570")]
	private void MKFHGECMKHH(bool NPCJOOKKGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD070", Offset = "0x6FABA70", VA = "0x186FAD070")]
	private void EPEAKBDMGAD(AOOKNBGCDKI HOBEPAEHHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task JHJGIGBBDDE(AOOKNBGCDKI HOBEPAEHHJL, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD780", Offset = "0x6FAC180", VA = "0x186FAD780")]
	[AsyncStateMachine(typeof(LFPACHJBKCH))]
	private Task PDGFBOGPEFA(OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x6FACF20", Offset = "0x6FAB920", VA = "0x186FACF20")]
	public JHHNPEBPLNM BOKPFNOKGEP(NLAOPAEBMHG GOCKGMEMPGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD480", Offset = "0x6FABE80", VA = "0x186FAD480")]
	[CompilerGenerated]
	private Task LFABIFBOKFH(CancellationToken DOGPFNGIKMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x6FACFA0", Offset = "0x6FAB9A0", VA = "0x186FACFA0")]
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
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public OJHFPGDNLEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private BIDJCBPPELH <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private PCJKPFOHLAA <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F9F6A0", Offset = "0x6F9E0A0", VA = "0x186F9F6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x6F9FE10", Offset = "0x6F9E810", VA = "0x186F9FE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	private readonly JBBIANFGILF GDGGKBKMAFL;

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0EF0", Offset = "0x6FAF8F0", VA = "0x186FB0EF0")]
	public OJHFPGDNLEK(Guid KPMGFINBLBG, PNHFEHLPHMO KBCJMHHCDBC, JBBIANFGILF GDGGKBKMAFL, NOCKKKPBJAK HEBPMOPIKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0DA0", Offset = "0x6FAF7A0", VA = "0x186FB0DA0", Slot = "8")]
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
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public JKIDNJAJEEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private TaskAwaiter<JBBKCFOEFFA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x6FABD70", Offset = "0x6FAA770", VA = "0x186FABD70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC120", Offset = "0x6FAAB20", VA = "0x186FAC120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	private readonly string FCDJJHECOOP;

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x6FABCC0", Offset = "0x6FAA6C0", VA = "0x186FABCC0")]
	public JKIDNJAJEEP(Guid KPMGFINBLBG, PNHFEHLPHMO KBCJMHHCDBC, NOCKKKPBJAK HEBPMOPIKJB, string FCDJJHECOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x6FABBB0", Offset = "0x6FAA5B0", VA = "0x186FABBB0", Slot = "7")]
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
			[Cpp2IlInjected.Token(Token = "0x400041B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400041C")]
			public AsyncTaskMethodBuilder<JHHNPEBPLNM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400041D")]
			public CLPKMFFCLKJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400041E")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400041F")]
			private TaskAwaiter<JBBKCFOEFFA> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000420")]
			private TaskAwaiter<JHHNPEBPLNM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0x6FB6810", Offset = "0x6FB5210", VA = "0x186FB6810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0x6FB6CD0", Offset = "0x6FB56D0", VA = "0x186FB6CD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public PCLJEAAOENH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public OPPOPKDPFEJ serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public LEBMOIGALED roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public IOFNMIAGIID uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public JJNDGMFMLEH roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public CLPKMFFCLKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x6FA1390", Offset = "0x6F9FD90", VA = "0x186FA1390")]
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
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public PCLJEAAOENH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private CLPKMFFCLKJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private BIDJCBPPELH <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private PCJKPFOHLAA <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private JHHNPEBPLNM <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x6FA5AA0", Offset = "0x6FA44A0", VA = "0x186FA5AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x6FA6A00", Offset = "0x6FA5400", VA = "0x186FA6A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	private static readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	private static readonly CDLNJDLNIPA KBKNHCEIBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private readonly int HDFLMOLOCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	[CanBeNull]
	private readonly KAIMFMKFBCK BJEDAIHNLGI;

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4C90", Offset = "0x6FB3690", VA = "0x186FB4C90")]
	public PCLJEAAOENH(Guid KPMGFINBLBG, PNHFEHLPHMO KBCJMHHCDBC, int HDFLMOLOCCD, KAIMFMKFBCK BJEDAIHNLGI, NOCKKKPBJAK HEBPMOPIKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4AA0", Offset = "0x6FB34A0", VA = "0x186FB4AA0", Slot = "8")]
	[AsyncStateMachine(typeof(FKBAGLHKNBF))]
	protected override Task POFDJKAPCLA(AOOKNBGCDKI HOBEPAEHHJL, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x6FB49A0", Offset = "0x6FB33A0", VA = "0x186FB49A0")]
	private void MGJCDPIEIGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x6FB47D0", Offset = "0x6FB31D0", VA = "0x186FB47D0")]
	private void BJOHILFKCOL(OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, BIDJCBPPELH NMJHAGKCPPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal abstract class ONKMEGIFDPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public readonly LDOGEOGHOLH PCEFFCPFNFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public readonly AOOKNBGCDKI BMIIBEBGCLJ;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public MFEINKDLEHJ KFKHEOKCKBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x6FB2100", Offset = "0x6FB0B00", VA = "0x186FB2100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public FFAMIDMIBLK HFPCNNCNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x6FB2270", Offset = "0x6FB0C70", VA = "0x186FB2270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2300", Offset = "0x6FB0D00", VA = "0x186FB2300")]
	protected ONKMEGIFDPF(AOOKNBGCDKI HOBEPAEHHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2150", Offset = "0x6FB0B50", VA = "0x186FB2150")]
	protected void MGFMJHPPHBP(string FNOGOHPEEJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal struct IDOKGAKHACO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public Dictionary<Guid, List<CNEDOEIINNH>> KOHNICGLMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public Dictionary<Guid, List<CNEDOEIINNH>> BMCMDODEBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public Dictionary<Guid, List<CNEDOEIINNH>> FDEADOOLGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public List<Guid> OINPNKLHCDN;

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x6FA9630", Offset = "0x6FA8030", VA = "0x186FA9630")]
	public static IDOKGAKHACO JMJOGDIBBHK(MFEINKDLEHJ EKMGPIDNBAL, BAEGFPFJEKP MPMDJOHBDMD, BCCLEKKJGLB ODJOOIPMNML)
	{
		return default(IDOKGAKHACO);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011D")]
internal struct AOHLCIPIPLB
{
	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x899BF0", VA = "0x18089B1F0")]
	public static AOHLCIPIPLB JGIIBNEOBDO()
	{
		return default(AOHLCIPIPLB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal struct JHNAMKCFCAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public readonly FLKIEPIEFEG ECCIBCDNFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public readonly HCDOMJKEJGM BPKLHPPCKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public readonly string EEPCKBDHEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public readonly KEOGFOOKLEH BIOFMAGLAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public readonly KEOGFOOKLEH PNMECAEFMNK;

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB670", Offset = "0x6FAA070", VA = "0x186FAB670")]
	public JHNAMKCFCAD(FLKIEPIEFEG ECCIBCDNFPF, HCDOMJKEJGM BPKLHPPCKJK, string EEPCKBDHEGC, KEOGFOOKLEH BIOFMAGLAJN, KEOGFOOKLEH PNMECAEFMNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal struct JIEDHIIBLJD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private readonly AOOKNBGCDKI HOBEPAEHHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	private readonly Guid LJBACHIBEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	private bool NPCJOOKKGED;

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB9E0", Offset = "0x6FAA3E0", VA = "0x186FAB9E0")]
	public static JIEDHIIBLJD OCDKPEAMHIM(AOOKNBGCDKI HOBEPAEHHJL)
	{
		return default(JIEDHIIBLJD);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x98D390", Offset = "0x98BD90", VA = "0x18098D390")]
	public void OKNOMJKMFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB6F0", Offset = "0x6FAA0F0", VA = "0x186FAB6F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x6FABA10", Offset = "0x6FAA410", VA = "0x186FABA10")]
	private JIEDHIIBLJD(AOOKNBGCDKI HOBEPAEHHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB700", Offset = "0x6FAA100", VA = "0x186FAB700")]
	private void HJOMCJIKAEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB940", Offset = "0x6FAA340", VA = "0x186FAB940")]
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
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public JBBIANFGILF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		private JIEDHIIBLJD <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x6FB2490", Offset = "0x6FB0E90", VA = "0x186FB2490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x6FB2C00", Offset = "0x6FB1600", VA = "0x186FB2C00", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public AsyncTaskMethodBuilder<JHHNPEBPLNM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public JBBIANFGILF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private OADONCMLPJG<string>.HILOONJJDHL <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x6FA7400", Offset = "0x6FA5E00", VA = "0x186FA7400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x6FA7820", Offset = "0x6FA6220", VA = "0x186FA7820", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public JBBIANFGILF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private OADONCMLPJG<string>.HILOONJJDHL <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x6FA37F0", Offset = "0x6FA21F0", VA = "0x186FA37F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x6FA3C80", Offset = "0x6FA2680", VA = "0x186FA3C80", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			public AsyncTaskMethodBuilder<JHNAMKCFCAD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			public PDLADLBEBGO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			private JHNAMKCFCAD <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			private TaskAwaiter<BAEGFPFJEKP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			private TaskAwaiter<JHNAMKCFCAD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x6FB5310", Offset = "0x6FB3D10", VA = "0x186FB5310", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x6FB5A70", Offset = "0x6FB4470", VA = "0x186FB5A70", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			public AsyncTaskMethodBuilder<BCCLEKKJGLB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			public PDLADLBEBGO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000470")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000471")]
			private BCCLEKKJGLB <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000472")]
			private TaskAwaiter<BAEGFPFJEKP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000473")]
			private TaskAwaiter<BCCLEKKJGLB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0x6FB5AE0", Offset = "0x6FB44E0", VA = "0x186FB5AE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051B")]
			[Cpp2IlInjected.Address(RVA = "0x6FB6110", Offset = "0x6FB4B10", VA = "0x186FB6110", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public JBBIANFGILF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public NKKKGGINLEP preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public NKKKGGINLEP downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public JHNAMKCFCAD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public NKKKGGINLEP postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public BCCLEKKJGLB phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public KGKIJLNHCBD.GNBOAEIMAME <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public PDLADLBEBGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x6FB5030", Offset = "0x6FB3A30", VA = "0x186FB5030")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<JHNAMKCFCAD> ICICOMFHDMM(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x6FB4DB0", Offset = "0x6FB37B0", VA = "0x186FB4DB0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<BCCLEKKJGLB> BPBCMKLLFEP(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x6FB5170", Offset = "0x6FB3B70", VA = "0x186FB5170")]
		internal void NGPFLDECLHP(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x6FB51B0", Offset = "0x6FB3BB0", VA = "0x186FB51B0")]
		internal Task PDLBOJJIBFL(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x6FB4ED0", Offset = "0x6FB38D0", VA = "0x186FB4ED0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public JBBIANFGILF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private PDLADLBEBGO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private TaskAwaiter<JHNAMKCFCAD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private TaskAwaiter<BCCLEKKJGLB> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4CF0", Offset = "0x6FA36F0", VA = "0x186FA4CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x6FA5A40", Offset = "0x6FA4440", VA = "0x186FA5A40", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public BCCLEKKJGLB phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public NKKKGGINLEP postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private TaskAwaiter<BAEGFPFJEKP> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private FCPMHIPDGPA <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x6FAEC20", Offset = "0x6FAD620", VA = "0x186FAEC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x6FAFAB0", Offset = "0x6FAE4B0", VA = "0x186FAFAB0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC440", Offset = "0x6FAAE40", VA = "0x186FAC440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x6FACCF0", Offset = "0x6FAB6F0", VA = "0x186FACCF0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public NKKKGGINLEP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private OADONCMLPJG<string>.HILOONJJDHL <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private TaskAwaiter<BAEGFPFJEKP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x6FA14B0", Offset = "0x6F9FEB0", VA = "0x186FA14B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x6FA1E30", Offset = "0x6FA0830", VA = "0x186FA1E30", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public AsyncTaskMethodBuilder<BAEGFPFJEKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public NKKKGGINLEP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private OADONCMLPJG<string>.HILOONJJDHL <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private TaskAwaiter<BAEGFPFJEKP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x6FA9C40", Offset = "0x6FA8640", VA = "0x186FA9C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x6FAADE0", Offset = "0x6FA97E0", VA = "0x186FAADE0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public AsyncTaskMethodBuilder<BAEGFPFJEKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public NKKKGGINLEP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public FCPMHIPDGPA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private OADONCMLPJG<string>.HILOONJJDHL <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private TaskAwaiter<BAEGFPFJEKP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x6FB0FA0", Offset = "0x6FAF9A0", VA = "0x186FB0FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x6FB2090", Offset = "0x6FB0A90", VA = "0x186FB2090", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public AsyncTaskMethodBuilder<BAEGFPFJEKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public BAEGFPFJEKP operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public NKKKGGINLEP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public BCCLEKKJGLB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private TaskAwaiter<BAEGFPFJEKP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x6FA1090", Offset = "0x6F9FA90", VA = "0x186FA1090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x6FA1320", Offset = "0x6F9FD20", VA = "0x186FA1320", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40004C3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004C4")]
			public AsyncTaskMethodBuilder<BAEGFPFJEKP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004C5")]
			public ELLBFHIMDKF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004C6")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C7")]
			private PHCOOIGGHEB <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004C8")]
			private TaskAwaiter<BAEGFPFJEKP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x6FB6180", Offset = "0x6FB4B80", VA = "0x186FB6180", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000533")]
			[Cpp2IlInjected.Address(RVA = "0x6FB67A0", Offset = "0x6FB51A0", VA = "0x186FB67A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public NKKKGGINLEP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public NBINIKGBAMA masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public FCPMHIPDGPA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public BAEGFPFJEKP originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public ELLBFHIMDKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4BD0", Offset = "0x6FA35D0", VA = "0x186FA4BD0")]
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
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public AsyncTaskMethodBuilder<BAEGFPFJEKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public NKKKGGINLEP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public NBINIKGBAMA masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public FCPMHIPDGPA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private TaskAwaiter<BAEGFPFJEKP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EDD0", Offset = "0x6F9D7D0", VA = "0x186F9EDD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x6F9F2D0", Offset = "0x6F9DCD0", VA = "0x186F9F2D0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public NKKKGGINLEP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private BAEGFPFJEKP <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private IEnumerator<BAEGFPFJEKP> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private TaskAwaiter<BAEGFPFJEKP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x6FA7E60", Offset = "0x6FA6860", VA = "0x186FA7E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x6FA8390", Offset = "0x6FA6D90", VA = "0x186FA8390", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB3F0", Offset = "0x6FA9DF0", VA = "0x186FAB3F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB610", Offset = "0x6FAA010", VA = "0x186FAB610", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x6FADA00", Offset = "0x6FAC400", VA = "0x186FADA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x6FADBA0", Offset = "0x6FAC5A0", VA = "0x186FADBA0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public BCCLEKKJGLB phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public NKKKGGINLEP postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private TaskAwaiter<BAEGFPFJEKP> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private FCPMHIPDGPA <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x6FA3CE0", Offset = "0x6FA26E0", VA = "0x186FA3CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4B70", Offset = "0x6FA3570", VA = "0x186FA4B70", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public AsyncTaskMethodBuilder<BAEGFPFJEKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public NKKKGGINLEP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private TaskAwaiter<BAEGFPFJEKP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC8960", Offset = "0x6FC7360", VA = "0x186FC8960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x6FC93C0", Offset = "0x6FC7DC0", VA = "0x186FC93C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private readonly NKPKPHIMNEI KGJFAMAJCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	private readonly NKPKPHIMNEI EMGIEIOJPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000440")]
	private readonly BOAMHEKDIOK CJHEFFFCIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000441")]
	private readonly GNKDLDAAEML ANANAPJIBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000442")]
	private readonly KKMJLGFKMCG HCBLCMEMNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private readonly NPFIODHPLCC BPNELNCMPID;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private PNHFEHLPHMO NOOCLICDJJM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x6FB2CA0", Offset = "0x6FB16A0", VA = "0x186FB2CA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event KPJCHGMHNOH ODCPIOEPMDN
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x6FB2C80", Offset = "0x6FB1680", VA = "0x186FB2C80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x6FB2C60", Offset = "0x6FB1660", VA = "0x186FB2C60", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4530", Offset = "0x6FB2F30", VA = "0x186FB4530")]
	public PCJKPFOHLAA(AOOKNBGCDKI HOBEPAEHHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x6FB38D0", Offset = "0x6FB22D0", VA = "0x186FB38D0")]
	[AsyncStateMachine(typeof(PAPDCCDMGAP))]
	public Task MCBFGPEMKEP(JBBIANFGILF GPCNCGBOPJG, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4140", Offset = "0x6FB2B40", VA = "0x186FB4140")]
	[AsyncStateMachine(typeof(GKKABENGFIE))]
	private Task<JHHNPEBPLNM> OKDGMCKAGJM(JBBIANFGILF GPCNCGBOPJG, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3A20", Offset = "0x6FB2420", VA = "0x186FB3A20")]
	[AsyncStateMachine(typeof(EAPIFEMKFDL))]
	private Task MKAHEDDPJAI(JBBIANFGILF GPCNCGBOPJG, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x6FB31A0", Offset = "0x6FB1BA0", VA = "0x186FB31A0")]
	[AsyncStateMachine(typeof(EOENEDAMKMI))]
	private Task GEBJKNHIMMH(JBBIANFGILF GPCNCGBOPJG, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MJJIEGHIIHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3610", Offset = "0x6FB2010", VA = "0x186FB3610")]
	[AsyncStateMachine(typeof(MGBEPLHGAGA))]
	private Task KDKEILCMNCL(BCCLEKKJGLB GGIEODBFCMI, NKKKGGINLEP DHKIHDFOOAK, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken CKBNFNEGPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x6FB42A0", Offset = "0x6FB2CA0", VA = "0x186FB42A0")]
	[AsyncStateMachine(typeof(LCKAIKKOOLC))]
	private Task PAAGKABCCEN(OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3EE0", Offset = "0x6FB28E0", VA = "0x186FB3EE0")]
	[AsyncStateMachine(typeof(CNOINGELDGB))]
	private Task NLNJAPLAEPE(BCCLEKKJGLB LINJEFIAFHO, NKKKGGINLEP CMNBDIJCHGE, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3760", Offset = "0x6FB2160", VA = "0x186FB3760")]
	[AsyncStateMachine(typeof(ILMIABPMMBI))]
	private Task<BAEGFPFJEKP> KODHAJDJLMP(BCCLEKKJGLB LINJEFIAFHO, FCPMHIPDGPA DPNAFHBKAFN, NKKKGGINLEP CMNBDIJCHGE, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x6FB43B0", Offset = "0x6FB2DB0", VA = "0x186FB43B0")]
	[AsyncStateMachine(typeof(OMKDNEKFPJM))]
	private Task<BAEGFPFJEKP> PDBHOJNDJEJ(BCCLEKKJGLB LINJEFIAFHO, FCPMHIPDGPA DPNAFHBKAFN, NKKKGGINLEP CMNBDIJCHGE, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3320", Offset = "0x6FB1D20", VA = "0x186FB3320")]
	[AsyncStateMachine(typeof(CHGKHEDHNMF))]
	private Task<BAEGFPFJEKP> JENLMPOBLMB(BAEGFPFJEKP MPMDJOHBDMD, BCCLEKKJGLB ODJOOIPMNML, NKKKGGINLEP CMNBDIJCHGE, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM, bool AMEECLKOLCO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4030", Offset = "0x6FB2A30", VA = "0x186FB4030")]
	private bool NNBCAPFCHHL(BCCLEKKJGLB GGIEODBFCMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3010", Offset = "0x6FB1A10", VA = "0x186FB3010")]
	[AsyncStateMachine(typeof(APINIADFKHM))]
	protected Task<BAEGFPFJEKP> GBKANPHFDEI(BCCLEKKJGLB LINJEFIAFHO, FCPMHIPDGPA DPNAFHBKAFN, NKKKGGINLEP CMNBDIJCHGE, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM, NBINIKGBAMA ODKHEHKDCDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x6FB34A0", Offset = "0x6FB1EA0", VA = "0x186FB34A0")]
	[AsyncStateMachine(typeof(GOJAOLOIPLE))]
	private Task JJLNAOANHOJ(BCCLEKKJGLB LINJEFIAFHO, NKKKGGINLEP CMNBDIJCHGE, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2CD0", Offset = "0x6FB16D0", VA = "0x186FB2CD0")]
	private void BLELCDJIOFC(BAEGFPFJEKP DGDNFAGKJJD, NKKKGGINLEP CMNBDIJCHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2FB0", Offset = "0x6FB19B0", VA = "0x186FB2FB0")]
	private void EMBFDJBDFFA(BAEGFPFJEKP KKHDHGEJOPN, [Out] BAEGFPFJEKP FFPMGCEAJOD, [Out] BAEGFPFJEKP KBNILNCJOBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x6FB32E0", Offset = "0x6FB1CE0", VA = "0x186FB32E0")]
	private Task<JHNAMKCFCAD> IBAFCNNGGBJ(JBBIANFGILF GPCNCGBOPJG, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3B80", Offset = "0x6FB2580", VA = "0x186FB3B80")]
	private Task<BCCLEKKJGLB> NAEJOCDJHNH(JHNAMKCFCAD LINJEFIAFHO, KGKIJLNHCBD.GNBOAEIMAME KANAHIPJEKP, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2E10", Offset = "0x6FB1810", VA = "0x186FB2E10")]
	[AsyncStateMachine(typeof(JCOPCMMMMCB))]
	private Task DMFOCICFLCE(BCCLEKKJGLB LINJEFIAFHO, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM, bool DJDDDKCEKHP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2D20", Offset = "0x6FB1720", VA = "0x186FB2D20")]
	[AsyncStateMachine(typeof(LDPIIDMHAKH))]
	private Task DDPHFAPHNMD(BCCLEKKJGLB LINJEFIAFHO, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2F60", Offset = "0x6FB1960", VA = "0x186FB2F60")]
	private Task EFGNAADJLFA(BCCLEKKJGLB LINJEFIAFHO, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3B60", Offset = "0x6FB2560", VA = "0x186FB3B60")]
	private Task MKIEPGKEMCG(BCCLEKKJGLB LINJEFIAFHO, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2F90", Offset = "0x6FB1990", VA = "0x186FB2F90")]
	private Task EJGFDNPNEIN(BCCLEKKJGLB LINJEFIAFHO, FCPMHIPDGPA DPNAFHBKAFN, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2FF0", Offset = "0x6FB19F0", VA = "0x186FB2FF0")]
	private Task FALJJJKGMCC(BCCLEKKJGLB LINJEFIAFHO, FCPMHIPDGPA DPNAFHBKAFN, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x6FB38C0", Offset = "0x6FB22C0", VA = "0x186FB38C0")]
	private static Task LNLKHCIOHAD(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3EC0", Offset = "0x6FB28C0", VA = "0x186FB3EC0")]
	private Task NKNNIBAMIAA(BCCLEKKJGLB LINJEFIAFHO, FCPMHIPDGPA DPNAFHBKAFN, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x6FB35F0", Offset = "0x6FB1FF0", VA = "0x186FB35F0")]
	private Task KAKLPMDHELE(BCCLEKKJGLB LINJEFIAFHO, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3E70", Offset = "0x6FB2870", VA = "0x186FB3E70")]
	private void NFEJECHCLPP(JBBIANFGILF GPCNCGBOPJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4120", Offset = "0x6FB2B20", VA = "0x186FB4120")]
	public void OAGKDLDDPPP(long LMGCMDBJBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
	private static void BMGKEDPPOFE(FLKIEPIEFEG ECCIBCDNFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3BC0", Offset = "0x6FB25C0", VA = "0x186FB3BC0")]
	[AsyncStateMachine(typeof(EDGELNDMKKJ))]
	private Task NDLPLKBKJDH(BCCLEKKJGLB GGIEODBFCMI, NKKKGGINLEP DHKIHDFOOAK, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken CKBNFNEGPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3D10", Offset = "0x6FB2710", VA = "0x186FB3D10")]
	[AsyncStateMachine(typeof(LCHHMPMBJOH))]
	[CompilerGenerated]
	private Task<BAEGFPFJEKP> NDPOMNCNAKP(BCCLEKKJGLB LINJEFIAFHO, FCPMHIPDGPA DPNAFHBKAFN, NKKKGGINLEP CMNBDIJCHGE, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct JAGPKEDOPNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	private BCCLEKKJGLB LINJEFIAFHO;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private MFEINKDLEHJ KFKHEOKCKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3760", Offset = "0x6FC2160", VA = "0x186FC3760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x6FC3680", Offset = "0x6FC2080", VA = "0x186FC3680")]
	public static Task AGALHLJOLPH(PNHFEHLPHMO KBCJMHHCDBC, BCCLEKKJGLB LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x6FC3460", Offset = "0x6FC1E60", VA = "0x186FC3460")]
	private void AGALHLJOLPH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct MBPCJJOAHBO
{
	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x6FCA000", Offset = "0x6FC8A00", VA = "0x186FCA000")]
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
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private OADONCMLPJG<string>.HILOONJJDHL <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0840", Offset = "0x6FBF240", VA = "0x186FC0840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0D60", Offset = "0x6FBF760", VA = "0x186FC0D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x6FBBA00", Offset = "0x6FBA400", VA = "0x186FBBA00")]
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
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public FCPMHIPDGPA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private BAEGFPFJEKP <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private PNHFEHLPHMO <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private MFEINKDLEHJ <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private PHCOOIGGHEB <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		private List<(PersistenceView, CLPMHIGOAIJ)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private CLPMHIGOAIJ <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x6FB70B0", Offset = "0x6FB5AB0", VA = "0x186FB70B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x6FB7D30", Offset = "0x6FB6730", VA = "0x186FB7D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x6FC9CB0", Offset = "0x6FC86B0", VA = "0x186FC9CB0")]
	[AsyncStateMachine(typeof(ADBNHDLAKGC))]
	public static Task AGALHLJOLPH(AOOKNBGCDKI HOBEPAEHHJL, BCCLEKKJGLB LINJEFIAFHO, FCPMHIPDGPA DPNAFHBKAFN, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x6FC9E00", Offset = "0x6FC8800", VA = "0x186FC9E00")]
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
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public PNHFEHLPHMO roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x6FC27A0", Offset = "0x6FC11A0", VA = "0x186FC27A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x6FC2BE0", Offset = "0x6FC15E0", VA = "0x186FC2BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF7F0", Offset = "0x6FCE1F0", VA = "0x186FCF7F0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public PNHFEHLPHMO roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x6FBBC20", Offset = "0x6FBA620", VA = "0x186FBBC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x6FBBE30", Offset = "0x6FBA830", VA = "0x186FBBE30", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			public OADONCMLPJG<string>.HILOONJJDHL timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000534")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000535")]
			public KANDKPKGKPJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000536")]
			private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000537")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0x6FCFE20", Offset = "0x6FCE820", VA = "0x186FCFE20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0x6FD01B0", Offset = "0x6FCEBB0", VA = "0x186FD01B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public KANDKPKGKPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5E60", Offset = "0x6FC4860", VA = "0x186FC5E60")]
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
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public OJAPCCOPINI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6420", Offset = "0x6FC4E20", VA = "0x186FC6420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6DE0", Offset = "0x6FC57E0", VA = "0x186FC6DE0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public CCFJLIPPODM version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public EGIGMNCPODP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC7A0", Offset = "0x6FBB1A0", VA = "0x186FBC7A0")]
		internal object KOEBPLFHGOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC880", Offset = "0x6FBB280", VA = "0x186FBC880")]
		internal object PEHOIBPMDNF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	private BCCLEKKJGLB LINJEFIAFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private AOOKNBGCDKI HOBEPAEHHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private bool DJDDDKCEKHP;

	[Cpp2IlInjected.Token(Token = "0x4000526")]
	private static readonly ByteString JOKAAPOMGEN;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private MFEINKDLEHJ KFKHEOKCKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x6FCC0D0", Offset = "0x6FCAAD0", VA = "0x186FCC0D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	private FFAMIDMIBLK HFPCNNCNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x6FCC160", Offset = "0x6FCAB60", VA = "0x186FCC160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x6FCB7A0", Offset = "0x6FCA1A0", VA = "0x186FCB7A0")]
	[AsyncStateMachine(typeof(DGAJLLPODJF))]
	public static Task AGALHLJOLPH(PNHFEHLPHMO KBCJMHHCDBC, BCCLEKKJGLB LINJEFIAFHO, AOOKNBGCDKI HOBEPAEHHJL, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM, bool DJDDDKCEKHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x6FCB8F0", Offset = "0x6FCA2F0", VA = "0x186FCB8F0")]
	[AsyncStateMachine(typeof(KDAKAOIHDFD))]
	private Task AGALHLJOLPH(OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x6FCBA30", Offset = "0x6FCA430", VA = "0x186FCBA30")]
	private void CIAIEKFFHPK([NotNull] CKJAAMAMPKA DFEILOOLDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC120", Offset = "0x6FCAB20", VA = "0x186FCC120")]
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
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public AsyncTaskMethodBuilder<BCCLEKKJGLB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public FBKJKJHEJFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public KGKIJLNHCBD.GNBOAEIMAME downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private OADONCMLPJG<string>.HILOONJJDHL <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		private TaskAwaiter<(CIKECDEKJAI<NPKNNMIHNCN, EGADAFAJMEN>, CIKECDEKJAI<MOGOEHIGGGP<CKJAAMAMPKA>, EGADAFAJMEN>, CIKECDEKJAI<MOGOEHIGGGP<JPOIDFBEIEP>, EGADAFAJMEN>, CIKECDEKJAI<MOGOEHIGGGP<LPCEBBBOKPM>, EGADAFAJMEN>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x6FC51A0", Offset = "0x6FC3BA0", VA = "0x186FC51A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5C50", Offset = "0x6FC4650", VA = "0x186FC5C50", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public AsyncTaskMethodBuilder<CIKECDEKJAI<NPKNNMIHNCN, EGADAFAJMEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public OADONCMLPJG<string>.HILOONJJDHL downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public FBKJKJHEJFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public KGKIJLNHCBD.GNBOAEIMAME downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private TaskAwaiter<CIKECDEKJAI<NPKNNMIHNCN, EGADAFAJMEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x6FBB380", Offset = "0x6FB9D80", VA = "0x186FBB380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x6FBB990", Offset = "0x6FBA390", VA = "0x186FBB990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	private PFLNKKCOAHI<KEOGFOOKLEH, JPOIDFBEIEP> LKIOEIPJIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	private PFLNKKCOAHI<KEOGFOOKLEH, CKJAAMAMPKA> HBGBDBMCOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	private PFLNKKCOAHI<long, LPCEBBBOKPM> HEFLBPJEPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	private PJOHEDNALLN EOGAHJIINJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	private FLKIEPIEFEG ECCIBCDNFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	private HCDOMJKEJGM BPKLHPPCKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	private string EEPCKBDHEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	private KEOGFOOKLEH BIOFMAGLAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	private KEOGFOOKLEH PNMECAEFMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	private long LMGCMDBJBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	private OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM;

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x6FBDA40", Offset = "0x6FBC440", VA = "0x186FBDA40")]
	public static Task<BCCLEKKJGLB> GNJKDOJCBBG(PNHFEHLPHMO KBCJMHHCDBC, [In] JHNAMKCFCAD LINJEFIAFHO, KGKIJLNHCBD.GNBOAEIMAME KANAHIPJEKP, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x6FBD6F0", Offset = "0x6FBC0F0", VA = "0x186FBD6F0")]
	[AsyncStateMachine(typeof(JKKPIJJOEKK))]
	private Task<BCCLEKKJGLB> AGALHLJOLPH(KGKIJLNHCBD.GNBOAEIMAME KANAHIPJEKP, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x6FBD880", Offset = "0x6FBC280", VA = "0x186FBD880")]
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
		private OADONCMLPJG<string>.HILOONJJDHL <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private TaskAwaiter<JHNAMKCFCAD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF8D0", Offset = "0x6FBE2D0", VA = "0x186FBF8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x6FBFCD0", Offset = "0x6FBE6D0", VA = "0x186FBFCD0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public AsyncTaskMethodBuilder<JHNAMKCFCAD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public ONKDMLGACJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private TaskAwaiter<JHNAMKCFCAD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5F80", Offset = "0x6FC4980", VA = "0x186FC5F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x6FC63B0", Offset = "0x6FC4DB0", VA = "0x186FC63B0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public MNONHLPGAJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x92C050", Offset = "0x92AA50", VA = "0x18092C050")]
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
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public AsyncTaskMethodBuilder<JHNAMKCFCAD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public KEOGFOOKLEH superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public MFEINKDLEHJ callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private MNONHLPGAJH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public GGIIPLFNMOA roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private FLKIEPIEFEG <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private HCDOMJKEJGM <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private KEOGFOOKLEH <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private KEOGFOOKLEH <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private TaskAwaiter<FLKIEPIEFEG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private TaskAwaiter<LLEPICGCMEA> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private TaskAwaiter<HNKJBJIHEKD> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x6FBA1E0", Offset = "0x6FB8BE0", VA = "0x186FBA1E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x6FBB310", Offset = "0x6FB9D10", VA = "0x186FBB310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	private MFEINKDLEHJ EKMGPIDNBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	private BOAMHEKDIOK CJHEFFFCIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private GGIIPLFNMOA JKPACCCFGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private long DIMOGDCMBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	private long MMMJFAODPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private long JFKPBGIIONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private string CNCIKMOKNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private KEOGFOOKLEH DPKLJFBJENK;

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC410", Offset = "0x6FCAE10", VA = "0x186FCC410")]
	public static Task<JHNAMKCFCAD> GNJKDOJCBBG(PNHFEHLPHMO KBCJMHHCDBC, JBBIANFGILF GPCNCGBOPJG, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC290", Offset = "0x6FCAC90", VA = "0x186FCC290")]
	[AsyncStateMachine(typeof(FLKGCOMGNOD))]
	private Task<JHNAMKCFCAD> AGALHLJOLPH(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC650", Offset = "0x6FCB050", VA = "0x186FCC650")]
	[AsyncStateMachine(typeof(KBBJHMOIPMM))]
	private Task<JHNAMKCFCAD> IBAFCNNGGBJ(OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC7B0", Offset = "0x6FCB1B0", VA = "0x186FCC7B0")]
	[AsyncStateMachine(typeof(BNEHBJOEMEG))]
	private static Task<JHNAMKCFCAD> IBAFCNNGGBJ(MFEINKDLEHJ EKMGPIDNBAL, GGIIPLFNMOA JKPACCCFGCC, long DIMOGDCMBFM, long MMMJFAODPOA, long JFKPBGIIONL, string CNCIKMOKNCG, KEOGFOOKLEH DPKLJFBJENK, CancellationToken MPLGBOFHPLM, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC3E0", Offset = "0x6FCADE0", VA = "0x186FCC3E0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public DGNIKAGOCHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC9C0", Offset = "0x6FBB3C0", VA = "0x186FBC9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x6FBCF50", Offset = "0x6FBB950", VA = "0x186FBCF50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	private MFEINKDLEHJ EKMGPIDNBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000592")]
	private BCCLEKKJGLB LINJEFIAFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000593")]
	private OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000594")]
	private float GGEDFCNOKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000595")]
	private float KHPFKLEDAHL;

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC310", Offset = "0x6FBAD10", VA = "0x186FBC310")]
	public static Task MFIHCKJGFLF(PNHFEHLPHMO KBCJMHHCDBC, BCCLEKKJGLB LINJEFIAFHO, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x6FBBE90", Offset = "0x6FBA890", VA = "0x186FBBE90")]
	[AsyncStateMachine(typeof(EPGDBNGOGIB))]
	public Task AGALHLJOLPH(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC1D0", Offset = "0x6FBABD0", VA = "0x186FBC1D0")]
	private static void HHAFDHIEILI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x6FBBFB0", Offset = "0x6FBA9B0", VA = "0x186FBBFB0")]
	private void DPGOPDPAMPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC110", Offset = "0x6FBAB10", VA = "0x186FBC110")]
	private static float HCCEFAGLBHC(MFEINKDLEHJ EKMGPIDNBAL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC4B0", Offset = "0x6FBAEB0", VA = "0x186FBC4B0")]
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
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private LDOGEOGHOLH <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private PNHFEHLPHMO <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private FJCBFJLOJNB.HEMGOLNMIEJ <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x6FC9430", Offset = "0x6FC7E30", VA = "0x186FC9430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x6FC9C50", Offset = "0x6FC8650", VA = "0x186FC9C50", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9E90", Offset = "0x6FB8890", VA = "0x186FB9E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x6FBA180", Offset = "0x6FB8B80", VA = "0x186FBA180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x6FC4010", Offset = "0x6FC2A10", VA = "0x186FC4010")]
	[AsyncStateMachine(typeof(LEBHPOLOGOP))]
	public static Task AGALHLJOLPH(AOOKNBGCDKI HOBEPAEHHJL, BCCLEKKJGLB LINJEFIAFHO, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x6FC4150", Offset = "0x6FC2B50", VA = "0x186FC4150")]
	private static Task<JHHNPEBPLNM> EIJPLEGLDCB(AOOKNBGCDKI HOBEPAEHHJL, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x6FC41C0", Offset = "0x6FC2BC0", VA = "0x186FC41C0")]
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
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public PNOHLCBINMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA780", Offset = "0x6FC9180", VA = "0x186FCA780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x6FCAE30", Offset = "0x6FC9830", VA = "0x186FCAE30", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public PIGPMDMLNGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x6FCF050", Offset = "0x6FCDA50", VA = "0x186FCF050")]
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
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public PNOHLCBINMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0240", Offset = "0x6FBEC40", VA = "0x186FC0240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x6FC06A0", Offset = "0x6FBF0A0", VA = "0x186FC06A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005B0")]
	private bool JHLNKBPNCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005B1")]
	private OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B2")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005B3")]
	private CancellationToken MPLGBOFHPLM;

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF780", Offset = "0x6FCE180", VA = "0x186FCF780")]
	public static Task GDDFCAEIIAE(PNHFEHLPHMO KBCJMHHCDBC, bool JHLNKBPNCBO, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken CGFBIGKMGCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF560", Offset = "0x6FCDF60", VA = "0x186FCF560")]
	[AsyncStateMachine(typeof(ODLOGBCMIKM))]
	private Task AGALHLJOLPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF650", Offset = "0x6FCE050", VA = "0x186FCF650")]
	[AsyncStateMachine(typeof(GEMDJEOOABA))]
	private Task AMHLAJGDKIO(bool DNHNFCFHHHN, string OAAJEIOFMBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x899BF0", VA = "0x18089B1F0")]
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
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public KLKDPMKGLFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x6FC8330", Offset = "0x6FC6D30", VA = "0x186FC8330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x6FC88A0", Offset = "0x6FC72A0", VA = "0x186FC88A0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public KOKHFIEHLAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC8910", Offset = "0x6FC7310", VA = "0x186FC8910")]
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
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public KLKDPMKGLFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x6FBFD40", Offset = "0x6FBE740", VA = "0x186FBFD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC01D0", Offset = "0x6FBEBD0", VA = "0x186FC01D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C3")]
	private ABKBLDBOPKP JOMJHKECGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C4")]
	private OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C5")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	private bool JBAPLLMCMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private BCCLEKKJGLB LINJEFIAFHO;

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7490", Offset = "0x6FC5E90", VA = "0x186FC7490")]
	public static Task<Scene> ANJIDPMKHGM(PNHFEHLPHMO KBCJMHHCDBC, ABKBLDBOPKP LOKLKHKLFPL, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7220", Offset = "0x6FC5C20", VA = "0x186FC7220")]
	[AsyncStateMachine(typeof(KNCEOJKJOJN))]
	private Task<Scene> AGALHLJOLPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7510", Offset = "0x6FC5F10", VA = "0x186FC7510")]
	private bool EIMIEILCPAJ(BCCLEKKJGLB LINJEFIAFHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7540", Offset = "0x6FC5F40", VA = "0x186FC7540")]
	private void MGKMNEHAJBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7340", Offset = "0x6FC5D40", VA = "0x186FC7340")]
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
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public AsyncTaskMethodBuilder<BAEGFPFJEKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public KKMJLGFKMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public BAEGFPFJEKP nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public BCCLEKKJGLB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private OADONCMLPJG<string>.HILOONJJDHL <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private TaskAwaiter<BAEGFPFJEKP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8400", Offset = "0x6FB6E00", VA = "0x186FB8400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8EE0", Offset = "0x6FB78E0", VA = "0x186FB8EE0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public AsyncTaskMethodBuilder<BAEGFPFJEKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public KKMJLGFKMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public BAEGFPFJEKP state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4E50", Offset = "0x6FC3850", VA = "0x186FC4E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5130", Offset = "0x6FC3B30", VA = "0x186FC5130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D4")]
	private readonly AOOKNBGCDKI HOBEPAEHHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	private readonly BOAMHEKDIOK CJHEFFFCIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D6")]
	private readonly GNKDLDAAEML ANANAPJIBKL;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	private LDOGEOGHOLH PCEFFCPFNFE
	{
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x56E8BE0", Offset = "0x56E75E0", VA = "0x1856E8BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x6FC71C0", Offset = "0x6FC5BC0", VA = "0x186FC71C0")]
	public KKMJLGFKMCG(AOOKNBGCDKI HOBEPAEHHJL, BOAMHEKDIOK CJHEFFFCIJN, GNKDLDAAEML ANANAPJIBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x6FC6EE0", Offset = "0x6FC58E0", VA = "0x186FC6EE0")]
	[AsyncStateMachine(typeof(AGBDPBGOIGG))]
	public Task<BAEGFPFJEKP> MHDBOPPLJDH(BAEGFPFJEKP NCONGBKANCG, BCCLEKKJGLB ODJOOIPMNML, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM, bool AMEECLKOLCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7060", Offset = "0x6FC5A60", VA = "0x186FC7060")]
	[AsyncStateMachine(typeof(JJLDAMPBLBI))]
	private Task<BAEGFPFJEKP> OODKHDCPLHI(OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, BAEGFPFJEKP DMDDBNBIFMI, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x6FC6E90", Offset = "0x6FC5890", VA = "0x186FC6E90")]
	private bool HNONDFFMHPC(BAEGFPFJEKP CFAGNNMBLHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x6FC6EC0", Offset = "0x6FC58C0", VA = "0x186FC6EC0")]
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
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public LDOGEOGHOLH operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public FCPMHIPDGPA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		private PHCOOIGGHEB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		private List<(PersistenceView, CLPMHIGOAIJ)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		private (PersistenceView, CLPMHIGOAIJ) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x6FB7D90", Offset = "0x6FB6790", VA = "0x186FB7D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x6FB83A0", Offset = "0x6FB6DA0", VA = "0x186FB83A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0700", Offset = "0x6FBF100", VA = "0x186FC0700")]
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
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public LDOGEOGHOLH operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public FCPMHIPDGPA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private CCFJLIPPODM <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private PHCOOIGGHEB <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private List<(PersistenceView, CLPMHIGOAIJ)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		private CLPMHIGOAIJ <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1EF0", Offset = "0x6FC08F0", VA = "0x186FC1EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x6FC2740", Offset = "0x6FC1140", VA = "0x186FC2740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x6FCA0E0", Offset = "0x6FC8AE0", VA = "0x186FCA0E0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public List<NCKGFONBDGH> MFIKIEPKPBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public List<CLPMHIGOAIJ> LEHPADKOLLE;

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0xAB1600", Offset = "0xAB0000", VA = "0x180AB1600")]
		public HEMGOLNMIEJ(List<NCKGFONBDGH> MFIKIEPKPBB, List<CLPMHIGOAIJ> LEHPADKOLLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private sealed class JCFIKPFBJCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public IEnumerable<NCKGFONBDGH> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public JCFIKPFBJCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3F90", Offset = "0x6FC2990", VA = "0x186FC3F90")]
		internal object FABOFDNJIKP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000603")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000604")]
	private BCCLEKKJGLB LINJEFIAFHO;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	private MFEINKDLEHJ KFKHEOKCKBP
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF6B0", Offset = "0x6FBE0B0", VA = "0x186FBF6B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x6FBF0A0", Offset = "0x6FBDAA0", VA = "0x186FBF0A0")]
	public static HEMGOLNMIEJ AGALHLJOLPH(PNHFEHLPHMO KBCJMHHCDBC, BCCLEKKJGLB LINJEFIAFHO)
	{
		return default(HEMGOLNMIEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x6FBEE40", Offset = "0x6FBD840", VA = "0x186FBEE40")]
	private HEMGOLNMIEJ AGALHLJOLPH()
	{
		return default(HEMGOLNMIEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x6FBF100", Offset = "0x6FBDB00", VA = "0x186FBF100")]
	private HEMGOLNMIEJ DKENKAFIPMM(CKJAAMAMPKA DFEILOOLDPK, CCFJLIPPODM EIBPJCOMOGE)
	{
		return default(HEMGOLNMIEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x6FBF700", Offset = "0x6FBE100", VA = "0x186FBF700")]
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
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public FJCBFJLOJNB.HEMGOLNMIEJ instantiations;

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public PDHPCFLCMPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x6FCE980", Offset = "0x6FCD380", VA = "0x186FCE980")]
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
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public ELBCCNMKKBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC930", Offset = "0x6FBB330", VA = "0x186FBC930")]
		internal object FPBNMKNLEFP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x6FC75B0", Offset = "0x6FC5FB0", VA = "0x186FC75B0")]
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
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public GNKDLDAAEML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public BAEGFPFJEKP operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public BCCLEKKJGLB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7B60", Offset = "0x6FC6560", VA = "0x186FC7B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x6FC82D0", Offset = "0x6FC6CD0", VA = "0x186FC82D0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000619")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400061A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400061B")]
			public AMGCDOIIEAJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400061C")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400061D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x6FCFB00", Offset = "0x6FCE500", VA = "0x186FCFB00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x6FCFDC0", Offset = "0x6FCE7C0", VA = "0x186FCFDC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public GNKDLDAAEML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public OADONCMLPJG<string>.HILOONJJDHL handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public AMGCDOIIEAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9D30", Offset = "0x6FB8730", VA = "0x186FB9D30")]
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
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public GNKDLDAAEML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		private AMGCDOIIEAJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x6FCB210", Offset = "0x6FC9C10", VA = "0x186FCB210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x6FCB740", Offset = "0x6FCA140", VA = "0x186FCB740", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public GNKDLDAAEML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		private Dictionary<Guid, List<CNEDOEIINNH>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x6FCC950", Offset = "0x6FCB350", VA = "0x186FCC950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x6FCCF00", Offset = "0x6FCB900", VA = "0x186FCCF00", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public GNKDLDAAEML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		private Dictionary<Guid, List<CNEDOEIINNH>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9650", Offset = "0x6FB8050", VA = "0x186FB9650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9CD0", Offset = "0x6FB86D0", VA = "0x186FB9CD0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400063D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400063E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400063F")]
			public CNEDOEIINNH handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000640")]
			public EFKJHOCODEL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000641")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005DA")]
			[Cpp2IlInjected.Address(RVA = "0x6FCF900", Offset = "0x6FCE300", VA = "0x186FCF900", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DB")]
			[Cpp2IlInjected.Address(RVA = "0x6FCFAA0", Offset = "0x6FCE4A0", VA = "0x186FCFAA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public NONNNPKNJHH runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public List<CNEDOEIINNH> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public EFKJHOCODEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC4D0", Offset = "0x6FBAED0", VA = "0x186FBC4D0")]
		internal object BGJBLCDJLMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC5C0", Offset = "0x6FBAFC0", VA = "0x186FBC5C0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task HFPKJOMEJMM(CNEDOEIINNH handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC6B0", Offset = "0x6FBB0B0", VA = "0x186FBC6B0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public NONNNPKNJHH runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public List<CNEDOEIINNH> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private EFKJHOCODEL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x6FBE910", Offset = "0x6FBD310", VA = "0x186FBE910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x6FBEDE0", Offset = "0x6FBD7E0", VA = "0x186FBEDE0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		public GNKDLDAAEML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x6FCEA30", Offset = "0x6FCD430", VA = "0x186FCEA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x6FCEFF0", Offset = "0x6FCD9F0", VA = "0x186FCEFF0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public CCCLIGPGNNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x6FBBB40", Offset = "0x6FBA540", VA = "0x186FBBB40")]
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
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public GNKDLDAAEML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA220", Offset = "0x6FC8C20", VA = "0x186FCA220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA6E0", Offset = "0x6FC90E0", VA = "0x186FCA6E0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public CHMHLODPEBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x6FBBBB0", Offset = "0x6FBA5B0", VA = "0x186FBBBB0")]
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
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public GNKDLDAAEML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x6FC37B0", Offset = "0x6FC21B0", VA = "0x186FC37B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3DF0", Offset = "0x6FC27F0", VA = "0x186FC3DF0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public BEHMABACEEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9E20", Offset = "0x6FB8820", VA = "0x186FB9E20")]
		internal object MGGOLOICADP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400060B")]
	private readonly AOOKNBGCDKI HOBEPAEHHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400060C")]
	private IDOKGAKHACO ANANAPJIBKL;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	private LDOGEOGHOLH PCEFFCPFNFE
	{
		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x917CA0", Offset = "0x9166A0", VA = "0x180917CA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x851BE0", VA = "0x1808531E0")]
	public GNKDLDAAEML(AOOKNBGCDKI HOBEPAEHHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x6FC10D0", Offset = "0x6FBFAD0", VA = "0x186FC10D0")]
	[AsyncStateMachine(typeof(KNABJDKMEDN))]
	public Task AGALHLJOLPH(BAEGFPFJEKP MPMDJOHBDMD, BCCLEKKJGLB ODJOOIPMNML, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x6FC15F0", Offset = "0x6FBFFF0", VA = "0x186FC15F0")]
	[AsyncStateMachine(typeof(OIJOGIOFDEP))]
	private Task HAKONPBCCBH(BCCLEKKJGLB LINJEFIAFHO, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1C70", Offset = "0x6FC0670", VA = "0x186FC1C70")]
	[AsyncStateMachine(typeof(OPOGGMJIFMG))]
	private Task MJACBELPHDC(BCCLEKKJGLB LINJEFIAFHO, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1DB0", Offset = "0x6FC07B0", VA = "0x186FC1DB0")]
	[AsyncStateMachine(typeof(ALIHIMJOPAI))]
	private Task NIDDOAFCPBL(BCCLEKKJGLB LINJEFIAFHO, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1850", Offset = "0x6FC0250", VA = "0x186FC1850")]
	[AsyncStateMachine(typeof(FGBECPLAAGL))]
	private Task KHPOFECAIJA(Guid BLDBPNFIAPG, List<CNEDOEIINNH> FCGOCDPHAPF, NONNNPKNJHH GNKFHIIIPHB, BCCLEKKJGLB LINJEFIAFHO, CancellationToken EOCJCEFCOOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1220", Offset = "0x6FBFC20", VA = "0x186FC1220")]
	[AsyncStateMachine(typeof(PIAJBODKKPG))]
	private Task AOGKIGGKNAO(BCCLEKKJGLB LINJEFIAFHO, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0F90", Offset = "0x6FBF990", VA = "0x186FC0F90")]
	[AsyncStateMachine(typeof(NMEHDBMMELB))]
	private Task AEMCLNCLDAB(Guid KCMKEFIHCLF, BCCLEKKJGLB LINJEFIAFHO, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1B30", Offset = "0x6FC0530", VA = "0x186FC1B30")]
	[AsyncStateMachine(typeof(JBAKKAMGEEF))]
	private Task MHBNJPAJGBL(Guid KCMKEFIHCLF, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1730", Offset = "0x6FC0130", VA = "0x186FC1730")]
	private void JDGHIGBGGMI(Guid KCMKEFIHCLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1540", Offset = "0x6FBFF40", VA = "0x186FC1540")]
	private void CEELOAFAJNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x6FC19A0", Offset = "0x6FC03A0", VA = "0x186FC19A0")]
	public Guid LELOEOEJPCG(BAEGFPFJEKP DGDNFAGKJJD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1360", Offset = "0x6FBFD60", VA = "0x186FC1360")]
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
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public GLMCEPIGLJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		private IEnumerator<AIDMEJBIGGB> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x6FBCFB0", Offset = "0x6FBB9B0", VA = "0x186FBCFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD690", Offset = "0x6FBC090", VA = "0x186FBD690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000669")]
	private MFEINKDLEHJ EKMGPIDNBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400066A")]
	private OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400066B")]
	private CancellationToken MPLGBOFHPLM;

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0F20", Offset = "0x6FBF920", VA = "0x186FC0F20")]
	public static Task GKDNMPIMODG(MFEINKDLEHJ EKMGPIDNBAL, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken CGFBIGKMGCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0E30", Offset = "0x6FBF830", VA = "0x186FC0E30")]
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
	[Cpp2IlInjected.Token(Token = "0x4000672")]
	public readonly bool DKJALNHCOGO;

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x216D990", Offset = "0x216C390", VA = "0x18216D990")]
	public JJNDGMFMLEH(bool PHGCMJDPPHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
public readonly struct JBBKCFOEFFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000673")]
	public readonly CKJAAMAMPKA? LJIMKCPNMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	public readonly HCPPCCJPAPN NBDIAENDHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000675")]
	public readonly string? CECLABBIDNN;

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public IReadOnlyCollection<string> GGAGFAHHLKI
	{
		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3E70", Offset = "0x6FC2870", VA = "0x186FC3E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public IReadOnlyDictionary<long, int> PCMMCOJMKMN
	{
		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3E50", Offset = "0x6FC2850", VA = "0x186FC3E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x6FC3E90", Offset = "0x6FC2890", VA = "0x186FC3E90")]
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
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public AsyncTaskMethodBuilder<JBBKCFOEFFA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public OPPOPKDPFEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public INAMFDDJCJB serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public LEBMOIGALED roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private PHCOOIGGHEB <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x6FBDDB0", Offset = "0x6FBC7B0", VA = "0x186FBDDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x6FBE420", Offset = "0x6FBCE20", VA = "0x186FBE420", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public INAMFDDJCJB serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public OPPOPKDPFEJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public JENHGHCEACK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4B50", Offset = "0x6FC3550", VA = "0x186FC4B50")]
		internal Task NHHHCEINCAB(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4D70", Offset = "0x6FC3770", VA = "0x186FC4D70")]
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
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public JENHGHCEACK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public GLMAGKFFIFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0DC0", Offset = "0x6FBF7C0", VA = "0x186FC0DC0")]
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
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public JENHGHCEACK CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public OBPNJGNEAOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA740", Offset = "0x6FC9140", VA = "0x186FCA740")]
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
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public INAMFDDJCJB serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public OPPOPKDPFEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		private GLMAGKFFIFN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4280", Offset = "0x6FC2C80", VA = "0x186FC4280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4AF0", Offset = "0x6FC34F0", VA = "0x186FC4AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000676")]
	private readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.Token(Token = "0x4000677")]
	private static readonly TimeSpan NILDDDBDBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000678")]
	private readonly BOKGGMAHILG HBAOPAHIPOP;

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x6FCE070", Offset = "0x6FCCA70", VA = "0x186FCE070")]
	public OPPOPKDPFEJ(AOOKNBGCDKI HOBEPAEHHJL, BOKGGMAHILG HBAOPAHIPOP, CDLNJDLNIPA KBNCOADBJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x6FCDEA0", Offset = "0x6FCC8A0", VA = "0x186FCDEA0")]
	[AsyncStateMachine(typeof(FBMJKKMBOJL))]
	public Task<JBBKCFOEFFA> OPCGAJMHMBL(long MMMJFAODPOA, LEBMOIGALED NNEJNOJGJGB, INAMFDDJCJB MEGACNKHFJL, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x6FCDB10", Offset = "0x6FCC510", VA = "0x186FCDB10")]
	[AsyncStateMachine(typeof(JDPCHIPGNGA))]
	private Task KLFGEGFIBON(INAMFDDJCJB MEGACNKHFJL, IEnumerable<PersistenceView> LALNNECKACD, StringBuilder ENGOKPLGAKB, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD560", Offset = "0x6FCBF60", VA = "0x186FCD560")]
	private JBBKCFOEFFA EOMFACDBNNG(long MMMJFAODPOA, LEBMOIGALED NNEJNOJGJGB, INAMFDDJCJB MEGACNKHFJL, IEnumerable<PersistenceView> LALNNECKACD, StringBuilder ENGOKPLGAKB)
	{
		return default(JBBKCFOEFFA);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x6FCCF60", Offset = "0x6FCB960", VA = "0x186FCCF60")]
	private CKJAAMAMPKA ECOIKMGEIHP(long MMMJFAODPOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x6FCDC50", Offset = "0x6FCC650", VA = "0x186FCDC50")]
	private void ODDPCKBJAJI(CKJAAMAMPKA GFOADFAGJGL, StringBuilder ENGOKPLGAKB, IEnumerable<PersistenceView> LALNNECKACD, [In] EJPPCDFMGAB NNIAKJBMFAH, KLAHAGABJNO AAPBDGLHGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD0C0", Offset = "0x6FCBAC0", VA = "0x186FCD0C0")]
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
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public KDDDDHELEIK.OFPJCAGGINJ roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public KHMIPGCIMFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6E40", Offset = "0x6FC5840", VA = "0x186FC6E40")]
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
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public AsyncTaskMethodBuilder<(KDDDDHELEIK.OFPJCAGGINJ roomDataUpload, KDDDDHELEIK.OFPJCAGGINJ subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public JBBKCFOEFFA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public IOFNMIAGIID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		private KHMIPGCIMFH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		private TaskAwaiter<KDDDDHELEIK.OFPJCAGGINJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x6FCE0C0", Offset = "0x6FCCAC0", VA = "0x186FCE0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x6FCE910", Offset = "0x6FCD310", VA = "0x186FCE910", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public AsyncTaskMethodBuilder<BMBMOGELPMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public IOFNMIAGIID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public JBBKCFOEFFA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public KAIMFMKFBCK roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		private TaskAwaiter<(KDDDDHELEIK.OFPJCAGGINJ roomDataUpload, KDDDDHELEIK.OFPJCAGGINJ subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		private TaskAwaiter<BMBMOGELPMJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8F50", Offset = "0x6FB7950", VA = "0x186FB8F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x6FB95E0", Offset = "0x6FB7FE0", VA = "0x186FB95E0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public AsyncTaskMethodBuilder<LLEPICGCMEA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public IOFNMIAGIID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public JBBKCFOEFFA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private TaskAwaiter<(KDDDDHELEIK.OFPJCAGGINJ roomDataUpload, KDDDDHELEIK.OFPJCAGGINJ subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		private TaskAwaiter<LLEPICGCMEA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x6FBE490", Offset = "0x6FBCE90", VA = "0x186FBE490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x6FBE8A0", Offset = "0x6FBD2A0", VA = "0x186FBE8A0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40006C4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006C5")]
			public AsyncTaskMethodBuilder<JHHNPEBPLNM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006C6")]
			public ICOOGILOKNL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006C7")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006C8")]
			private JHHNPEBPLNM <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006C9")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006CA")]
			private TaskAwaiter<LLEPICGCMEA> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006CB")]
			private TaskAwaiter<BMBMOGELPMJ> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006CC")]
			private TaskAwaiter<JHHNPEBPLNM> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x600061F")]
			[Cpp2IlInjected.Address(RVA = "0x6FD0210", Offset = "0x6FCEC10", VA = "0x186FD0210", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0x6FD1190", Offset = "0x6FCFB90", VA = "0x186FD1190", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public IOFNMIAGIID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public JBBKCFOEFFA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		public KAIMFMKFBCK roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		public JJNDGMFMLEH roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public ICOOGILOKNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC2C40", Offset = "0x6FC1640", VA = "0x186FC2C40")]
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
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public AsyncTaskMethodBuilder<JHHNPEBPLNM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public IOFNMIAGIID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public JBBKCFOEFFA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		public KAIMFMKFBCK roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		public JJNDGMFMLEH roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x6FCAE90", Offset = "0x6FC9890", VA = "0x186FCAE90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x6FCB1A0", Offset = "0x6FC9BA0", VA = "0x186FCB1A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400069B")]
	private static readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.Token(Token = "0x400069C")]
	private static readonly CDLNJDLNIPA KBKNHCEIBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400069D")]
	private readonly OELPCMIPAIF KAGKBNNDDPK;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	private PNHFEHLPHMO NOOCLICDJJM
	{
		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x6FB2CA0", Offset = "0x6FB16A0", VA = "0x186FB2CA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x6FC33D0", Offset = "0x6FC1DD0", VA = "0x186FC33D0")]
	public IOFNMIAGIID(AOOKNBGCDKI HOBEPAEHHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2D70", Offset = "0x6FC1770", VA = "0x186FC2D70")]
	[AsyncStateMachine(typeof(PBBBFBGEEKC))]
	private Task<(KDDDDHELEIK.OFPJCAGGINJ, KDDDDHELEIK.OFPJCAGGINJ)> FLGKJCLCBHA(JBBKCFOEFFA HLJMJFBMCDD, long DIMOGDCMBFM, long KJMNNDODHCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x6FC31C0", Offset = "0x6FC1BC0", VA = "0x186FC31C0")]
	[AsyncStateMachine(typeof(AGJLPMKGJKE))]
	public Task<BMBMOGELPMJ> KILMPIGDEFN(int HDFLMOLOCCD, [CanBeNull] KAIMFMKFBCK BJEDAIHNLGI, JBBKCFOEFFA HLJMJFBMCDD, long DIMOGDCMBFM, long KJMNNDODHCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2EB0", Offset = "0x6FC18B0", VA = "0x186FC2EB0")]
	[AsyncStateMachine(typeof(FFMNMKIKIKD))]
	private Task<LLEPICGCMEA> IBEFOMBMBBH(string CNCIKMOKNCG, int HDFLMOLOCCD, JBBKCFOEFFA HLJMJFBMCDD, long DIMOGDCMBFM, long KJMNNDODHCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x6FC3020", Offset = "0x6FC1A20", VA = "0x186FC3020")]
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
	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	internal readonly PNHFEHLPHMO HFPIOMLCALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	private int? DKHDGICDBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	protected readonly Guid BCGKIOLOHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	protected readonly KPFIKNDEFFO IPFOHGNPEKN;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	protected T FBLEFNNFHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x40A4820", Offset = "0x40A3220", VA = "0x1840A4820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x40A4BC0", Offset = "0x40A35C0", VA = "0x1840A4BC0")]
	internal JKOFPHHMCIB(PNHFEHLPHMO NKLGIGDEHPG, KPFIKNDEFFO OFNDKLGKJDP, [Optional] Guid? KPMGFINBLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x40A4AE0", Offset = "0x40A34E0", VA = "0x1840A4AE0")]
	private JHHNPEBPLNM PENLDJAENCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "4")]
	protected virtual void PEKBGBCPAFB(JHHNPEBPLNM JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x40A4880", Offset = "0x40A3280", VA = "0x1840A4880")]
	public T KJEEAGABNJN(LCMANADAOPN GFABMNOLKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x40A4910", Offset = "0x40A3310", VA = "0x1840A4910")]
	public T KLGMHMFMGJM(int GNKJGCJCNCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x40A49B0", Offset = "0x40A33B0", VA = "0x1840A49B0", Slot = "5")]
	public virtual Task<DGFDNIJCPMA> NLMPIJBFLPJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
public class JNAKBMBBKNN : JKOFPHHMCIB<JNAKBMBBKNN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	private JBBIANFGILF MIJPDJDOIDB;

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x6FC5D90", Offset = "0x6FC4790", VA = "0x186FC5D90")]
	internal JNAKBMBBKNN(PNHFEHLPHMO NKLGIGDEHPG, KPFIKNDEFFO OFNDKLGKJDP, [Optional] Guid? KPMGFINBLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x64EB5E0", Offset = "0x64E9FE0", VA = "0x1864EB5E0")]
	public JNAKBMBBKNN DKFDBKAIPAL(JBBIANFGILF MIJPDJDOIDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x6FC5CC0", Offset = "0x6FC46C0", VA = "0x186FC5CC0", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private struct EDFKPOAPOML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public AsyncTaskMethodBuilder<DGFDNIJCPMA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		public PKDPFMCHDKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		private TaskAwaiter<DGFDNIJCPMA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x6FD34F0", Offset = "0x6FD1EF0", VA = "0x186FD34F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3870", Offset = "0x6FD2270", VA = "0x186FD3870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006DE")]
	private NEGBDBAAHJL OJMGIAOGCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006DF")]
	private string JKHIABFAKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006E0")]
	private KAIMFMKFBCK MIJPDJDOIDB;

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF3F0", Offset = "0x6FCDDF0", VA = "0x186FCF3F0")]
	internal PKDPFMCHDKO(PNHFEHLPHMO NKLGIGDEHPG, KPFIKNDEFFO OFNDKLGKJDP, [Optional] Guid? KPMGFINBLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF120", Offset = "0x6FCDB20", VA = "0x186FCF120")]
	public PKDPFMCHDKO CJJIFNBEFLM(string OLBMKMHMAID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF0D0", Offset = "0x6FCDAD0", VA = "0x186FCF0D0")]
	public PKDPFMCHDKO ANIMIMMOMJN(bool IFNMMJBNOOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF0F0", Offset = "0x6FCDAF0", VA = "0x186FCF0F0")]
	public PKDPFMCHDKO CGDKPENHAOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF280", Offset = "0x6FCDC80", VA = "0x186FCF280", Slot = "4")]
	protected override void PEKBGBCPAFB(JHHNPEBPLNM JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF190", Offset = "0x6FCDB90", VA = "0x186FCF190", Slot = "5")]
	[AsyncStateMachine(typeof(EDFKPOAPOML))]
	public override Task<DGFDNIJCPMA> NLMPIJBFLPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF150", Offset = "0x6FCDB50", VA = "0x186FCF150")]
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
	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3320", Offset = "0x6FD1D20", VA = "0x186FD3320")]
	public static void EMKJDLKKJMJ(this PEJDDGDCLFF OPGANEAFOBB, MDBDBMHCDOA EJBBNMBAICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3470", Offset = "0x6FD1E70", VA = "0x186FD3470")]
	public static void GLEGLCIMJNP(this MDBDBMHCDOA AKLKCJCNCJP, [Optional] string JNNDBFGKHHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
public static class ONAHBABICHB
{
	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x6FD5ED0", Offset = "0x6FD48D0", VA = "0x186FD5ED0")]
	public static KEOGFOOKLEH OCOHMLNJCMB(this MJHHKFADFIN KIKMALBGNCI)
	{
		return default(KEOGFOOKLEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x6FD5E20", Offset = "0x6FD4820", VA = "0x186FD5E20")]
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
			[Cpp2IlInjected.Token(Token = "0x40006ED")]
			public IOJDCLBFPMF ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006EE")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006EF")]
			public IOJDCLBFPMF HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006F0")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006F1")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006F2")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		private static IOJDCLBFPMF[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		private Dictionary<IOJDCLBFPMF, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x6FD7250", Offset = "0x6FD5C50", VA = "0x186FD7250")]
		public bool LDOIADAMLNM(IOJDCLBFPMF MNCJHJGEMJG, [Out] ResultConfig AACIHKHGIHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x6FD7110", Offset = "0x6FD5B10", VA = "0x186FD7110")]
		public ResultConfig INOGKEJOMCC(IOJDCLBFPMF NPGFMGMHJJL, [Optional] HashSet<IOJDCLBFPMF> PJIJOJLNADK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x6FD7890", Offset = "0x6FD6290", VA = "0x186FD7890", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x6FD72C0", Offset = "0x6FD5CC0", VA = "0x186FD72C0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x8BEAE0", Offset = "0x8BD4E0", VA = "0x1808BEAE0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
public static class HHBANNGACOC
{
	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x6FD4370", Offset = "0x6FD2D70", VA = "0x186FD4370")]
	[GDGALFJPCGE(JMIPDAHBNNG.GameOnly)]
	private static void CEJDNEABNOB(INCIOHANCNE LDLMDJOAIBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
public interface NCKGPLMHNNB : IEquatable<NCKGPLMHNNB>
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	DateTime CDOJLDGOHIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IGLJKNPEBFK();

	[Cpp2IlInjected.Token(Token = "0x600064A")]
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
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		public HCEEFOPOCMM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public MKGEJBEALMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x6FD55C0", Offset = "0x6FD3FC0", VA = "0x186FD55C0")]
		internal object HILAFDMLMPO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006F8")]
	private readonly PDMHIOFNOPB GDDDILGMPMI;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<NCKGPLMHNNB> FIPANKDGOFE
	{
		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x6FD1890", Offset = "0x6FD0290", VA = "0x186FD1890", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x6FD2210", Offset = "0x6FD0C10", VA = "0x186FD2210", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x851BE0", VA = "0x1808531E0")]
	[UnityEngine.Scripting.Preserve]
	public BAIIAJAOGAH([OMAPKKAGFIL(null)] PDMHIOFNOPB GDDDILGMPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x6FD1940", Offset = "0x6FD0340", VA = "0x186FD1940", Slot = "6")]
	public bool BGOHNIEEPOG(long DIMOGDCMBFM, long MMMJFAODPOA, JBBKCFOEFFA HLJMJFBMCDD, HCEEFOPOCMM LKIPKDFOIKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x1C29A90", Offset = "0x1C28490", VA = "0x181C29A90")]
	private void DCPMOMGGEIJ(NCKGPLMHNNB NHABHPPMDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x6FD1720", Offset = "0x6FD0120", VA = "0x186FD1720", Slot = "7")]
	public bool AMEPMODJGEG(long DIMOGDCMBFM, long MMMJFAODPOA, [Out] NCKGPLMHNNB HEEEABJCCCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2040", Offset = "0x6FD0A40", VA = "0x186FD2040", Slot = "8")]
	public bool HNIMFMKAJPB(long DIMOGDCMBFM, long MMMJFAODPOA, HCEEFOPOCMM LKIPKDFOIKO, [Out] NCKGPLMHNNB HEEEABJCCCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x6FD1C20", Offset = "0x6FD0620", VA = "0x186FD1C20")]
	private void BKBJFGHMADN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x6FD20F0", Offset = "0x6FD0AF0", VA = "0x186FD20F0", Slot = "9")]
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
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[CompilerGenerated]
	private sealed class MLCFCHICDHB : IEnumerable<NCKGPLMHNNB>, IEnumerable, IEnumerator<NCKGPLMHNNB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		private NCKGPLMHNNB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public FNABHGGPMDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		private HCEEFOPOCMM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public HCEEFOPOCMM <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		private NCKGPLMHNNB System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000669")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600066B")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x89FD00", Offset = "0x89E700", VA = "0x18089FD00")]
		[DebuggerHidden]
		public MLCFCHICDHB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5630", Offset = "0x6FD4030", VA = "0x186FD5630", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5910", Offset = "0x6FD4310", VA = "0x186FD5910", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5860", Offset = "0x6FD4260", VA = "0x186FD5860", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NCKGPLMHNNB> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5860", Offset = "0x6FD4260", VA = "0x186FD5860", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		public HCEEFOPOCMM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public CAJEAPOJAJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3280", Offset = "0x6FD1C80", VA = "0x186FD3280")]
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
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		public FNABHGGPMDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public BIMDNNLPEAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x6FD22C0", Offset = "0x6FD0CC0", VA = "0x186FD22C0")]
		internal void KAJFMGNMAGC(BODEGEDJFLM.KNDNPIAAOJO ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006FE")]
	private readonly object KMHKNAKFPLJ;

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	protected string JALMHGGOKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3ED0", Offset = "0x6FD28D0", VA = "0x186FD3ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public abstract NJNINEFDHOO LDONDENFFCN
	{
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x6FD42F0", Offset = "0x6FD2CF0", VA = "0x186FD42F0")]
	protected FNABHGGPMDG([CanBeNull] string JGDBHEDCOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3950", Offset = "0x6FD2350", VA = "0x186FD3950", Slot = "5")]
	public bool GABAFEMFKLM(long DIMOGDCMBFM, long MMMJFAODPOA, HCEEFOPOCMM LKIPKDFOIKO, [Out] NCKGPLMHNNB NHABHPPMDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x6FD4260", Offset = "0x6FD2C60", VA = "0x186FD4260", Slot = "6")]
	[IteratorStateMachine(typeof(MLCFCHICDHB))]
	public IEnumerable<NCKGPLMHNNB> OIPJIEMLAMM(HCEEFOPOCMM LKIPKDFOIKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void CPEAEKPGHDH(Stream BNJJDODGDJC, long DIMOGDCMBFM, long MMMJFAODPOA, JBBKCFOEFFA HLJMJFBMCDD);

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool BHEHJCNOINI(Stream MMOLAPACPMC, long DIMOGDCMBFM, long MMMJFAODPOA, IOPFFLOBCBM GLPDMIFJKNA, [Out] JBBKCFOEFFA HLJMJFBMCDD);

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3EE0", Offset = "0x6FD28E0", VA = "0x186FD3EE0", Slot = "7")]
	public NCKGPLMHNNB NINJAPGBAPF(long DIMOGDCMBFM, long MMMJFAODPOA, JBBKCFOEFFA HLJMJFBMCDD, HCEEFOPOCMM LKIPKDFOIKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo FMPENCBMNAB(long DIMOGDCMBFM, long MMMJFAODPOA, HCEEFOPOCMM LKIPKDFOIKO, LMIIJCPEHGG GFALHOIMFPG);

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo JNOIECBPKHC(HCEEFOPOCMM LKIPKDFOIKO, LMIIJCPEHGG GFALHOIMFPG);

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x6FD38E0", Offset = "0x6FD22E0", VA = "0x186FD38E0")]
	protected void FMFBLIKAKBD(BODEGEDJFLM.KNDNPIAAOJO KNBEEMJODEI, string ALLEHOLILJB, FileInfo NMFNNOJLCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3B40", Offset = "0x6FD2540", VA = "0x186FD3B40")]
	internal bool GGALNMKFMLH(FileInfo LHALDDCEPNI, long DIMOGDCMBFM, long MMMJFAODPOA, [Out] JBBKCFOEFFA HLJMJFBMCDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
	private void DOBDIENEIOJ(Exception NKAKJFGNGPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
internal class LCJFCBFJIIL : FNABHGGPMDG
{
	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public override NJNINEFDHOO LDONDENFFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0xCAE4C0", Offset = "0xCACEC0", VA = "0x180CAE4C0", Slot = "8")]
		get
		{
			return default(NJNINEFDHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x6FD5580", Offset = "0x6FD3F80", VA = "0x186FD5580")]
	public LCJFCBFJIIL([Optional] string JGDBHEDCOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x6FD5400", Offset = "0x6FD3E00", VA = "0x186FD5400")]
	private void IJOLNNCNOCK(HCEEFOPOCMM LKIPKDFOIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x6FD5080", Offset = "0x6FD3A80", VA = "0x186FD5080", Slot = "9")]
	internal override void CPEAEKPGHDH(Stream BNJJDODGDJC, long DIMOGDCMBFM, long MMMJFAODPOA, JBBKCFOEFFA HLJMJFBMCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x6FD4AA0", Offset = "0x6FD34A0", VA = "0x186FD4AA0", Slot = "10")]
	internal override bool BHEHJCNOINI(Stream MMOLAPACPMC, long DIMOGDCMBFM, long MMMJFAODPOA, IOPFFLOBCBM GLPDMIFJKNA, [Out] JBBKCFOEFFA HLJMJFBMCDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x6FD5310", Offset = "0x6FD3D10", VA = "0x186FD5310", Slot = "11")]
	protected override FileInfo FMPENCBMNAB(long DIMOGDCMBFM, long MMMJFAODPOA, HCEEFOPOCMM LKIPKDFOIKO, LMIIJCPEHGG GFALHOIMFPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x6FD5480", Offset = "0x6FD3E80", VA = "0x186FD5480", Slot = "12")]
	protected override DirectoryInfo JNOIECBPKHC(HCEEFOPOCMM LKIPKDFOIKO, LMIIJCPEHGG GFALHOIMFPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal sealed class PDDMKIGFEOI : FNABHGGPMDG
{
	[Cpp2IlInjected.Token(Token = "0x400070E")]
	private static readonly byte[] NDDCLPHCEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400070F")]
	private readonly byte[] ACPBGFGNPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000710")]
	private readonly byte[] MINLNEFMHEG;

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public override NJNINEFDHOO LDONDENFFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x5D821B0", Offset = "0x5D80BB0", VA = "0x185D821B0", Slot = "8")]
		get
		{
			return default(NJNINEFDHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x6FD6D90", Offset = "0x6FD5790", VA = "0x186FD6D90")]
	public PDDMKIGFEOI([Optional] string JGDBHEDCOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x6FD6740", Offset = "0x6FD5140", VA = "0x186FD6740", Slot = "9")]
	internal override void CPEAEKPGHDH(Stream BNJJDODGDJC, long DIMOGDCMBFM, long MMMJFAODPOA, JBBKCFOEFFA HLJMJFBMCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x6FD5F70", Offset = "0x6FD4970", VA = "0x186FD5F70", Slot = "10")]
	internal override bool BHEHJCNOINI(Stream MMOLAPACPMC, long DIMOGDCMBFM, long MMMJFAODPOA, IOPFFLOBCBM GLPDMIFJKNA, [Out] JBBKCFOEFFA HLJMJFBMCDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x6FD6A00", Offset = "0x6FD5400", VA = "0x186FD6A00")]
	private void FFFHPGPEGLO(byte[] DDNKCFIIBGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0x6FD6AC0", Offset = "0x6FD54C0", VA = "0x186FD6AC0", Slot = "11")]
	protected override FileInfo FMPENCBMNAB(long DIMOGDCMBFM, long MMMJFAODPOA, HCEEFOPOCMM LKIPKDFOIKO, LMIIJCPEHGG GFALHOIMFPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x6FD6BF0", Offset = "0x6FD55F0", VA = "0x186FD6BF0", Slot = "12")]
	protected override DirectoryInfo JNOIECBPKHC(HCEEFOPOCMM LKIPKDFOIKO, LMIIJCPEHGG GFALHOIMFPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
public enum NJNINEFDHOO : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000712")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x4000713")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x4000714")]
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
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		private NCKGPLMHNNB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		public BJGOPAHGMNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		private HCEEFOPOCMM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		public HCEEFOPOCMM <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		private NJNINEFDHOO[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		private IEnumerator<NCKGPLMHNNB> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		private NCKGPLMHNNB System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000690")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x89FD00", Offset = "0x89E700", VA = "0x18089FD00")]
		[DebuggerHidden]
		public NOKHNFDAFNO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5D90", Offset = "0x6FD4790", VA = "0x186FD5D90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x6FD59B0", Offset = "0x6FD43B0", VA = "0x186FD59B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5960", Offset = "0x6FD4360", VA = "0x186FD5960")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5D40", Offset = "0x6FD4740", VA = "0x186FD5D40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5C90", Offset = "0x6FD4690", VA = "0x186FD5C90", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NCKGPLMHNNB> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5C90", Offset = "0x6FD4690", VA = "0x186FD5C90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000715")]
	private readonly NJNINEFDHOO[] LDBFPDFCCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000716")]
	private readonly Dictionary<NJNINEFDHOO, PDMHIOFNOPB> KMMCJNEPACA;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public NJNINEFDHOO LDONDENFFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x6FD2D20", Offset = "0x6FD1720", VA = "0x186FD2D20", Slot = "4")]
		get
		{
			return default(NJNINEFDHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2F30", Offset = "0x6FD1930", VA = "0x186FD2F30")]
	[UnityEngine.Scripting.Preserve]
	public BJGOPAHGMNK(params PDMHIOFNOPB[] FAIKPHELKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2BD0", Offset = "0x6FD15D0", VA = "0x186FD2BD0", Slot = "5")]
	public bool GABAFEMFKLM(long DIMOGDCMBFM, long MMMJFAODPOA, HCEEFOPOCMM LKIPKDFOIKO, [Out] NCKGPLMHNNB NHABHPPMDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x6FD29B0", Offset = "0x6FD13B0", VA = "0x186FD29B0")]
	private void DFFFBBMOJKB(int KJLNIBNFALP, long DIMOGDCMBFM, long MMMJFAODPOA, HCEEFOPOCMM LKIPKDFOIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2EA0", Offset = "0x6FD18A0", VA = "0x186FD2EA0", Slot = "6")]
	[IteratorStateMachine(typeof(NOKHNFDAFNO))]
	public IEnumerable<NCKGPLMHNNB> OIPJIEMLAMM(HCEEFOPOCMM LKIPKDFOIKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2D50", Offset = "0x6FD1750", VA = "0x186FD2D50", Slot = "7")]
	public NCKGPLMHNNB NINJAPGBAPF(long DIMOGDCMBFM, long MMMJFAODPOA, JBBKCFOEFFA HLJMJFBMCDD, HCEEFOPOCMM LKIPKDFOIKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
internal static class IIIFNHKDNCH
{
	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x6FD4780", Offset = "0x6FD3180", VA = "0x186FD4780")]
	internal static byte[] HBPMLDJOMEN(byte[] DDNKCFIIBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x6FD4840", Offset = "0x6FD3240", VA = "0x186FD4840")]
	public static void JBIAPOEPLLI(Stream EDOGOHPOPNO, byte[] HNENGEFLMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x6FD48C0", Offset = "0x6FD32C0", VA = "0x186FD48C0")]
	public static bool NOCKNFNDHKD(Stream EDOGOHPOPNO, long DMNDKKPPFFL, IOPFFLOBCBM KBOLGJGNIGE, [Out] byte[] ANCDIFNJCND)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
internal sealed class BJBFNGEEGKK : NCKGPLMHNNB, IEquatable<NCKGPLMHNNB>, IEquatable<BJBFNGEEGKK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000724")]
	private readonly FNABHGGPMDG EKGGLPDLAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000725")]
	public readonly FileInfo MNCEOGOIGEH;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public NJNINEFDHOO LDONDENFFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x699F490", Offset = "0x699DE90", VA = "0x18699F490", Slot = "9")]
		get
		{
			return default(NJNINEFDHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public DateTime CDOJLDGOHIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x6FD25D0", Offset = "0x6FD0FD0", VA = "0x186FD25D0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x6FD28A0", Offset = "0x6FD12A0", VA = "0x186FD28A0")]
	public BJBFNGEEGKK(FNABHGGPMDG OJKACGONHKN, FileInfo LHALDDCEPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x6FD27F0", Offset = "0x6FD11F0", VA = "0x186FD27F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2730", Offset = "0x6FD1130", VA = "0x186FD2730", Slot = "5")]
	public void IGLJKNPEBFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2660", Offset = "0x6FD1060", VA = "0x186FD2660", Slot = "6")]
	public bool FLEPJADKKGI(long DIMOGDCMBFM, long MMMJFAODPOA, [Out] JBBKCFOEFFA HLJMJFBMCDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x6FD24F0", Offset = "0x6FD0EF0", VA = "0x186FD24F0", Slot = "7")]
	public bool Equals(NCKGPLMHNNB OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2430", Offset = "0x6FD0E30", VA = "0x186FD2430", Slot = "8")]
	public bool Equals(BJBFNGEEGKK OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2340", Offset = "0x6FD0D40", VA = "0x186FD2340", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x6FD26A0", Offset = "0x6FD10A0", VA = "0x186FD26A0", Slot = "2")]
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
	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	NJNINEFDHOO LDONDENFFCN
	{
		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GABAFEMFKLM(long DIMOGDCMBFM, long MMMJFAODPOA, HCEEFOPOCMM LKIPKDFOIKO, [Out] NCKGPLMHNNB NHABHPPMDON);

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<NCKGPLMHNNB> OIPJIEMLAMM(HCEEFOPOCMM LKIPKDFOIKO);

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
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
