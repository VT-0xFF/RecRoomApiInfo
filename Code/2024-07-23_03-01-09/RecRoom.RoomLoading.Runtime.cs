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
		[Cpp2IlInjected.Address(RVA = "0x87C5D0", Offset = "0x87B7D0", VA = "0x18087C5D0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F9C230", Offset = "0x6F9B430", VA = "0x186F9C230")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87D8D0", Offset = "0x87CAD0", VA = "0x18087D8D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87D910", Offset = "0x87CB10", VA = "0x18087D910")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F94A80", Offset = "0x6F93C80", VA = "0x186F94A80", Slot = "4")]
		public override void JGBCFAKMKJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x87C5D0", Offset = "0x87B7D0", VA = "0x18087C5D0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MPEKIJEOIGF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F9A970", Offset = "0x6F99B70", VA = "0x186F9A970")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F85010", Offset = "0x6F84210", VA = "0x186F85010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F85250", Offset = "0x6F84450", VA = "0x186F85250", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F801D0", Offset = "0x6F7F3D0", VA = "0x186F801D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6F803E0", Offset = "0x6F7F5E0", VA = "0x186F803E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	[UnityEngine.Scripting.Preserve]
	public OLKMFFNIKBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F9C8F0", Offset = "0x6F9BAF0", VA = "0x186F9C8F0", Slot = "4")]
	[AsyncStateMachine(typeof(EGMINFDGBLA))]
	public Task<IReadOnlyList<HNKJBJIHEKD>> ONIIPBCLFIM(long DIMOGDCMBFM, long KJMNNDODHCP, [Optional] CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6F9C7E0", Offset = "0x6F9B9E0", VA = "0x186F9C7E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F86290", Offset = "0x6F85490", VA = "0x186F86290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6F86730", Offset = "0x6F85930", VA = "0x186F86730", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x85FD10", Offset = "0x85EF10", VA = "0x18085FD10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x851AA0", VA = "0x1808528A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x5B1DB60", Offset = "0x5B1CD60", VA = "0x185B1DB60", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public COGBIDCIEPE? DGLMILFGMCA
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1C1DC30", Offset = "0x1C1CE30", VA = "0x181C1DC30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public MGMLPCEDDPE? DLOJPFEFPEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5B1DC40", Offset = "0x5B1CE40", VA = "0x185B1DC40", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public AJDCLNNIJGN KDKOLJHNILF
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8C3D00", Offset = "0x8C2F00", VA = "0x1808C3D00", Slot = "10")]
			get
			{
				return default(AJDCLNNIJGN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6F900B0", Offset = "0x6F8F2B0", VA = "0x186F900B0", Slot = "9")]
		[AsyncStateMachine(typeof(ENPAGPABADO))]
		public Task<DGFDNIJCPMA> HJKBNIFJLCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6F901F0", Offset = "0x6F8F3F0", VA = "0x186F901F0")]
		public JNNKLAGBMGO(int AEJFNKCGKJL, CCBKILLIDJI GKPLKHNIAAM, HNKJBJIHEKD HAFLHBJODHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6F8FFA0", Offset = "0x6F8F1A0", VA = "0x186F8FFA0", Slot = "11")]
		public bool Equals(HCBILDDEOJN OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6F8FF00", Offset = "0x6F8F100", VA = "0x186F8FF00", Slot = "0")]
		public override bool Equals(object MEAFIMADMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6F901B0", Offset = "0x6F8F3B0", VA = "0x186F901B0")]
		private bool NHAJPMJLCKB(JNNKLAGBMGO OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6F90030", Offset = "0x6F8F230", VA = "0x186F90030", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F83D10", Offset = "0x6F82F10", VA = "0x186F83D10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6F83F40", Offset = "0x6F83140", VA = "0x186F83F40", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F90DB0", Offset = "0x6F8FFB0", VA = "0x186F90DB0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public CCBKILLIDJI NCPBHLHBGEL
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6F911B0", Offset = "0x6F903B0", VA = "0x186F911B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime DCKEHFJHKEG
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6F910B0", Offset = "0x6F902B0", VA = "0x186F910B0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public COGBIDCIEPE? DGLMILFGMCA
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6F91160", Offset = "0x6F90360", VA = "0x186F91160", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public MGMLPCEDDPE? DLOJPFEFPEE
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6F91240", Offset = "0x6F90440", VA = "0x186F91240", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public AJDCLNNIJGN KDKOLJHNILF
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8CA010", Offset = "0x8C9210", VA = "0x1808CA010", Slot = "10")]
			get
			{
				return default(AJDCLNNIJGN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x10E0130", Offset = "0x10DF330", VA = "0x1810E0130")]
		public KAMPFFDNOIJ(NCKGPLMHNNB NHABHPPMDON, COGBIDCIEPE LMDAHADOCMG, MGMLPCEDDPE AFEBLMEGKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6F90FC0", Offset = "0x6F901C0", VA = "0x186F90FC0", Slot = "9")]
		[AsyncStateMachine(typeof(DFKFCDNLHDB))]
		public Task<DGFDNIJCPMA> HJKBNIFJLCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6F90DF0", Offset = "0x6F8FFF0", VA = "0x186F90DF0", Slot = "11")]
		public bool Equals(HCBILDDEOJN OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6F90E90", Offset = "0x6F90090", VA = "0x186F90E90", Slot = "0")]
		public override bool Equals(object MEAFIMADMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6F91100", Offset = "0x6F90300", VA = "0x186F91100")]
		private bool NHAJPMJLCKB(KAMPFFDNOIJ OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6F90F40", Offset = "0x6F90140", VA = "0x186F90F40", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F81C10", Offset = "0x6F80E10", VA = "0x186F81C10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6F81E50", Offset = "0x6F81050", VA = "0x186F81E50", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F9C2B0", Offset = "0x6F9B4B0", VA = "0x186F9C2B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x852300", VA = "0x180853100", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime DCKEHFJHKEG
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x8534A0", VA = "0x1808542A0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public COGBIDCIEPE? DGLMILFGMCA
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6F9C740", Offset = "0x6F9B940", VA = "0x186F9C740", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public MGMLPCEDDPE? DLOJPFEFPEE
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6F9C790", Offset = "0x6F9B990", VA = "0x186F9C790", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public AJDCLNNIJGN KDKOLJHNILF
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x8534A0", VA = "0x1808542A0", Slot = "10")]
			get
			{
				return default(AJDCLNNIJGN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x10E0130", Offset = "0x10DF330", VA = "0x1810E0130")]
		public OGPPILHBAGM(CCBKILLIDJI GKPLKHNIAAM, COGBIDCIEPE LMDAHADOCMG, MGMLPCEDDPE AFEBLMEGKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6F9C590", Offset = "0x6F9B790", VA = "0x186F9C590", Slot = "9")]
		[AsyncStateMachine(typeof(CIFHBDIJGDN))]
		public Task<DGFDNIJCPMA> HJKBNIFJLCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6F9C3F0", Offset = "0x6F9B5F0", VA = "0x186F9C3F0", Slot = "11")]
		public bool Equals(HCBILDDEOJN OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6F9C2D0", Offset = "0x6F9B4D0", VA = "0x186F9C2D0", Slot = "0")]
		public override bool Equals(object MEAFIMADMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6F9C500", Offset = "0x6F9B700", VA = "0x186F9C500", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6F9C660", Offset = "0x6F9B860", VA = "0x186F9C660")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F8EFD0", Offset = "0x6F8E1D0", VA = "0x186F8EFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6F8FE10", Offset = "0x6F8F010", VA = "0x186F8FE10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F92D00", Offset = "0x6F91F00", VA = "0x186F92D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6F936E0", Offset = "0x6F928E0", VA = "0x186F936E0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x6F86BA0", Offset = "0x6F85DA0", VA = "0x186F86BA0")]
	[UnityEngine.Scripting.Preserve]
	public FEJGLEBLKDD([OMAPKKAGFIL(null)] JBKFOMDLCHJ JCGADIJBGCL, [OMAPKKAGFIL(null)] APCMDALIFAP GCIHBOGNOCG, [OMAPKKAGFIL(null)] GNGNHODIFED BADCNKLHNGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6F86A50", Offset = "0x6F85C50", VA = "0x186F86A50")]
	[AsyncStateMachine(typeof(JJDJOJDEFBB))]
	public Task<IList<HCBILDDEOJN>> PMIGKKKHMEG(long DIMOGDCMBFM, long MMMJFAODPOA, bool LBHNFPLLPPA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6F867A0", Offset = "0x6F859A0", VA = "0x186F867A0")]
	private bool DAACIBEADMJ(DateTime? KNOJCNGFFGF, long DIMOGDCMBFM, long MMMJFAODPOA, [Out] NCKGPLMHNNB HEEEABJCCCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6F86940", Offset = "0x6F85B40", VA = "0x186F86940")]
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

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6F80730", Offset = "0x6F7F930", VA = "0x186F80730")]
	public BIDJCBPPELH(long LBHHCOPBEOO, long KJMNNDODHCP, EMDPEFDABNM NCMHJNKFAGH, [CanBeNull] Exception NFPCHIICMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6F806E0", Offset = "0x6F7F8E0", VA = "0x186F806E0")]
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

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GJOPDEMKKAE();

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IGKNNADFBCJ(BIDJCBPPELH NMJHAGKCPPO);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CBIKINJHPHE(BIDJCBPPELH NMJHAGKCPPO);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GCEEECEEPGL(BIDJCBPPELH NMJHAGKCPPO);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void APBMNJALIEG(EFBCINIABEJ LJJJHDHDDOO, bool NPCJOOKKGED);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface CDPDCOBHLKK : DLOEDDKPHPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NMANLOAKGED();

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CNOADOMBMCE();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface FFDBLCGPPMM : DLOEDDKPHPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TaskStatus GBIGLBPMJGD
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task IADAOMLEGLE(MDBDBMHCDOA OLIIPNAKLLA, PHMFOBHEKIK LHBIIPLLKKE, CancellationToken LJPECIOGMKH);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class JPPJBCFDDGC
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6F90D60", Offset = "0x6F8FF60", VA = "0x186F90D60")]
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
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CELLIGGGPOC(HPIMEFGKLNK JABMPBLAEKI);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface PNHFEHLPHMO : JFDEDNEDKBI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CancellationToken HDNPIHLFMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	INCIOHANCNE HDLDKNAIPCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	ILFDHJAHNHI HIAEFCJGPMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	DEBFMJKLBDN DJEMJGOJCKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	MFEINKDLEHJ KFKHEOKCKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	INNHEOLIKBM MDBMBBPHIBI
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NBAHHDNKILP GCINGEDLGMH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	OMKEILKNJFC OHKEMMFEOLB
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	BOAMHEKDIOK DNKBABKCKEM
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	GAGJCKDHAGD GDMOGGJEDBM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	EMPCKPBJDBG DNFGAGHGFEP
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	MDIOJHKPIFM AEFEHKNIGLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	CDPDCOBHLKK FIIGPOBAGDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	FFDBLCGPPMM KPMOHDGEAPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	GPMIBIFCKBJ CMHDFDJFCNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	DHPDBLFEFKM BNNHJAOKOAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	KIJJEBJPOIH OJKPJCDHHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	LNJOHEOEPEC AFNPDMELIEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CCOBBDFLOFB CJLEAOJJGCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	OELPCMIPAIF CCBDHCDOJDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	GNGDMGCCAPD GKFMPEHDLNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	GDNPJMDDBLG OKFDHBKKLPB
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	FGAHPIAHGMI CPPADNKEGPA
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	HMHGPPDLHFG KAMMGKKGEJM
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	GNDHGGJAABG ODOJHIPFPFN
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	DKMKDMJDKAD IBOABCLKAIG
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	KJHGHIOALEA DDNLDNHMOKO
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	GGIIPLFNMOA DGIEGKOIAJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	APCMDALIFAP AEHDIMKFCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	KKNNHLMFANP EIGIGOMEGDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	GDBDKOPOCLO IELHIFNAECG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	FJDMGDBCEIP LGPBJMPPCFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	HMBECBJGGMK POBNKOIHALJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "33")]
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
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x851AA0", VA = "0x1808528A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x852870", Offset = "0x851A70", VA = "0x180852870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x8523E0", VA = "0x1808531E0")]
	public LOEOIDGPKKK(MDBDBMHCDOA AKLKCJCNCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6F94920", Offset = "0x6F93B20", VA = "0x186F94920")]
	public LOEOIDGPKKK AGIBFGMAADE(string NDDCLPHCEEO, string JMDCGOKJIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6F949F0", Offset = "0x6F93BF0", VA = "0x186F949F0")]
	public bool OCMIHLIDOHH([Out] IEnumerable<KeyValuePair<string, string>> NIPKJPFADEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x61F54A0", Offset = "0x61F46A0", VA = "0x1861F54A0")]
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
	private struct LAJGJJKPPHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public AsyncTaskMethodBuilder<DGFDNIJCPMA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public EHPKEGPHHAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public NCKGPLMHNNB autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<DGFDNIJCPMA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x6F93750", Offset = "0x6F92950", VA = "0x186F93750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x6F939D0", Offset = "0x6F92BD0", VA = "0x186F939D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct BHKLIJPOLJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public EHPKEGPHHAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x6F80450", Offset = "0x6F7F650", VA = "0x186F80450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x6F80680", Offset = "0x6F7F880", VA = "0x186F80680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class HNFJPMHDLFC : IEnumerable<DLOEDDKPHPI>, IEnumerable, IEnumerator<DLOEDDKPHPI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private DLOEDDKPHPI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public EHPKEGPHHAK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		private DLOEDDKPHPI System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x89FB40", Offset = "0x89ED40", VA = "0x18089FB40")]
		[DebuggerHidden]
		public HNFJPMHDLFC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6F89030", Offset = "0x6F88230", VA = "0x186F89030", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6F89490", Offset = "0x6F88690", VA = "0x186F89490", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6F893E0", Offset = "0x6F885E0", VA = "0x186F893E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DLOEDDKPHPI> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6F893E0", Offset = "0x6F885E0", VA = "0x186F893E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8569D0", Offset = "0x855BD0", VA = "0x1808569D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855B80", VA = "0x180856980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public DEBFMJKLBDN DJEMJGOJCKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x856300", Offset = "0x855500", VA = "0x180856300", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8562F0", Offset = "0x8554F0", VA = "0x1808562F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public MFEINKDLEHJ KFKHEOKCKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x856340", Offset = "0x855540", VA = "0x180856340", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x856330", Offset = "0x855530", VA = "0x180856330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public INNHEOLIKBM MDBMBBPHIBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x856320", Offset = "0x855520", VA = "0x180856320", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x856310", Offset = "0x855510", VA = "0x180856310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public NBAHHDNKILP GCINGEDLGMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x856A90", Offset = "0x855C90", VA = "0x180856A90", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x856B60", Offset = "0x855D60", VA = "0x180856B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public OMKEILKNJFC OHKEMMFEOLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x856BA0", Offset = "0x855DA0", VA = "0x180856BA0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x856BD0", Offset = "0x855DD0", VA = "0x180856BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public BOAMHEKDIOK DNKBABKCKEM
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x85FD30", Offset = "0x85EF30", VA = "0x18085FD30", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x85FD60", Offset = "0x85EF60", VA = "0x18085FD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public GAGJCKDHAGD GDMOGGJEDBM
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x85FE60", Offset = "0x85F060", VA = "0x18085FE60", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x85FE80", Offset = "0x85F080", VA = "0x18085FE80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public EMPCKPBJDBG DNFGAGHGFEP
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x85FE70", Offset = "0x85F070", VA = "0x18085FE70", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x85FEB0", Offset = "0x85F0B0", VA = "0x18085FEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public MDIOJHKPIFM AEFEHKNIGLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9C1100", Offset = "0x9C0300", VA = "0x1809C1100", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9EF160", Offset = "0x9EE360", VA = "0x1809EF160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public CDPDCOBHLKK FIIGPOBAGDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x85FDF0", Offset = "0x85EFF0", VA = "0x18085FDF0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x85FD70", Offset = "0x85EF70", VA = "0x18085FD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public FFDBLCGPPMM KPMOHDGEAPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9E7450", Offset = "0x9E6650", VA = "0x1809E7450", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9C60D0", Offset = "0x9C52D0", VA = "0x1809C60D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public GPMIBIFCKBJ CMHDFDJFCNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x85DEA0", Offset = "0x85D0A0", VA = "0x18085DEA0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x85DEE0", Offset = "0x85D0E0", VA = "0x18085DEE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public DHPDBLFEFKM BNNHJAOKOAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xB8CE20", Offset = "0xB8C020", VA = "0x180B8CE20", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xB94DF0", Offset = "0xB93FF0", VA = "0x180B94DF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public IENMFFFGEPA MPEIAOIBKNK
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x948B80", Offset = "0x947D80", VA = "0x180948B80", Slot = "57")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x93E980", Offset = "0x93DB80", VA = "0x18093E980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public KIJJEBJPOIH OJKPJCDHHDP
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x948350", Offset = "0x947550", VA = "0x180948350", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9498C0", Offset = "0x948AC0", VA = "0x1809498C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public LNJOHEOEPEC AFNPDMELIEH
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8BD6B0", Offset = "0x8BC8B0", VA = "0x1808BD6B0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xB94E30", Offset = "0xB94030", VA = "0x180B94E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public CCOBBDFLOFB CJLEAOJJGCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8BF130", Offset = "0x8BE330", VA = "0x1808BF130", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA23320", Offset = "0xA22520", VA = "0x180A23320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public OELPCMIPAIF CCBDHCDOJDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x85DED0", Offset = "0x85D0D0", VA = "0x18085DED0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x85DE80", Offset = "0x85D080", VA = "0x18085DE80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public GNGDMGCCAPD GKFMPEHDLNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8BB330", Offset = "0x8BA530", VA = "0x1808BB330", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9C5680", Offset = "0x9C4880", VA = "0x1809C5680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public GDNPJMDDBLG OKFDHBKKLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA48E50", Offset = "0xA48050", VA = "0x180A48E50", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA48E70", Offset = "0xA48070", VA = "0x180A48E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public FGAHPIAHGMI CPPADNKEGPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8BF150", Offset = "0x8BE350", VA = "0x1808BF150", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xB94E10", Offset = "0xB94010", VA = "0x180B94E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public HMHGPPDLHFG KAMMGKKGEJM
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8BF160", Offset = "0x8BE360", VA = "0x1808BF160", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9C46A0", Offset = "0x9C38A0", VA = "0x1809C46A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public GNDHGGJAABG ODOJHIPFPFN
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0B0", Offset = "0x8BE2B0", VA = "0x1808BF0B0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xB94DD0", Offset = "0xB93FD0", VA = "0x180B94DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public DKMKDMJDKAD IBOABCLKAIG
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF0C0", Offset = "0x8BE2C0", VA = "0x1808BF0C0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xB95010", Offset = "0xB94210", VA = "0x180B95010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public KJHGHIOALEA DDNLDNHMOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF90", Offset = "0x8BE190", VA = "0x1808BEF90", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xB94FD0", Offset = "0xB941D0", VA = "0x180B94FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public GGIIPLFNMOA DGIEGKOIAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8BEF60", Offset = "0x8BE160", VA = "0x1808BEF60", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xB94F10", Offset = "0xB94110", VA = "0x180B94F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public APCMDALIFAP AEHDIMKFCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8BEEC0", Offset = "0x8BE0C0", VA = "0x1808BEEC0", Slot = "32")]
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
		[Cpp2IlInjected.Address(RVA = "0xB94D60", Offset = "0xB93F60", VA = "0x180B94D60", Slot = "33")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BF140", Offset = "0x8BE340", VA = "0x1808BF140", Slot = "34")]
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
		[Cpp2IlInjected.Address(RVA = "0xA60A40", Offset = "0xA5FC40", VA = "0x180A60A40", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public HMBECBJGGMK POBNKOIHALJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xAFB8B0", Offset = "0xAFAAB0", VA = "0x180AFB8B0", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public PHMFOBHEKIK FAFJDJJEHAF
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xAF9C90", Offset = "0xAF8E90", VA = "0x180AF9C90", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xB94E50", Offset = "0xB94050", VA = "0x180B94E50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private bool JJIDNNFHAGE
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6F85320", Offset = "0x6F84520", VA = "0x186F85320", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private bool EGMBFMJJEEH
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x6F857C0", Offset = "0x6F849C0", VA = "0x186F857C0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private CancellationToken CDLFAJFFLDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F85B30", Offset = "0x6F84D30", VA = "0x186F85B30", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private INCIOHANCNE PHNEENJICEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action DEGINDIDOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6F859B0", Offset = "0x6F84BB0", VA = "0x186F859B0", Slot = "38")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6F85380", Offset = "0x6F84580", VA = "0x186F85380", Slot = "39")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event OMLCDPLNPMG PAEFGIELMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6F85760", Offset = "0x6F84960", VA = "0x186F85760", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6F853E0", Offset = "0x6F845E0", VA = "0x186F853E0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event OMLCDPLNPMG MMMKBBOBLEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6F85A70", Offset = "0x6F84C70", VA = "0x186F85A70", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6F85950", Offset = "0x6F84B50", VA = "0x186F85950", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event OMLCDPLNPMG MGGNEDHPMKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6F85840", Offset = "0x6F84A40", VA = "0x186F85840", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6F85B50", Offset = "0x6F84D50", VA = "0x186F85B50", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<EFBCINIABEJ, bool> FOJIJOCBLFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x6F85A10", Offset = "0x6F84C10", VA = "0x186F85A10", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x6F852C0", Offset = "0x6F844C0", VA = "0x186F852C0", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0xB94E50", Offset = "0xB94050", VA = "0x180B94E50", Slot = "37")]
	public void HMEDGBMBGNA(PHMFOBHEKIK HGAMIEAIIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6F85E20", Offset = "0x6F85020", VA = "0x186F85E20")]
	[UnityEngine.Scripting.Preserve]
	internal EHPKEGPHHAK([OMAPKKAGFIL(null)] INCIOHANCNE PGHIDIKDPNB, [OMAPKKAGFIL(null)] ILFDHJAHNHI FAELELHBKKO, [OMAPKKAGFIL(null)] DEBFMJKLBDN HPIKMIOHGPC, [OMAPKKAGFIL(null)] MFEINKDLEHJ EKMGPIDNBAL, [OMAPKKAGFIL(null)] INNHEOLIKBM DAHOAFOCMNK, [OMAPKKAGFIL(null)] NBAHHDNKILP PLDFHJDBLCM, [OMAPKKAGFIL(null)] OMKEILKNJFC NPKMKLLOPKG, [OMAPKKAGFIL(null)] BOAMHEKDIOK CJHEFFFCIJN, [OMAPKKAGFIL(null)] GAGJCKDHAGD JIMBHKPDLLH, [OMAPKKAGFIL(null)] EMPCKPBJDBG HEFAOBKNDGK, [OMAPKKAGFIL(null)] MDIOJHKPIFM KMFINGCDELI, [OMAPKKAGFIL(null)] CDPDCOBHLKK ABLOKNIMFCK, [OMAPKKAGFIL(null)] FFDBLCGPPMM MCGBLNMHNKO, [OMAPKKAGFIL(null)] GPMIBIFCKBJ LPINBJBANHC, [OMAPKKAGFIL(null)] DHPDBLFEFKM PODDALKBECI, [OMAPKKAGFIL(null)] IENMFFFGEPA ANNFANPCCIH, [OMAPKKAGFIL(null)] KIJJEBJPOIH OFBHFEIOFPN, [OMAPKKAGFIL(null)] LNJOHEOEPEC DCEOPNHDHAB, [OMAPKKAGFIL(null)] CCOBBDFLOFB FOEFGCMONND, [OMAPKKAGFIL(null)] OELPCMIPAIF KAGKBNNDDPK, [OMAPKKAGFIL(null)] GDNPJMDDBLG HGNPBLNJDEJ, [OMAPKKAGFIL(null)] GNGDMGCCAPD ELAJIBPEDAA, [OMAPKKAGFIL(null)] FGAHPIAHGMI DLEEJBBLHGJ, [OMAPKKAGFIL(null)] HMHGPPDLHFG BNLFELFFHMM, [OMAPKKAGFIL(null)] GNDHGGJAABG DKKIFNFPLNE, [OMAPKKAGFIL(null)] KJHGHIOALEA AACIHKHGIHG, [OMAPKKAGFIL(null)] GGIIPLFNMOA JKPACCCFGCC, [OMAPKKAGFIL(null)] APCMDALIFAP BPDMMEBNEKC, [OMAPKKAGFIL(null)] KKNNHLMFANP CGMJLNEOJIF, [OMAPKKAGFIL(null)] GDBDKOPOCLO CLJOHLGPPOL, [OMAPKKAGFIL(null)] FJDMGDBCEIP LPFOAEHCDII, [OMAPKKAGFIL(null)] HMBECBJGGMK AIEAPICLDBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6F858A0", Offset = "0x6F84AA0", VA = "0x186F858A0")]
	private void HMCGAKKBHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6F854D0", Offset = "0x6F846D0", VA = "0x186F854D0", Slot = "56")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6F85BB0", Offset = "0x6F84DB0", VA = "0x186F85BB0", Slot = "50")]
	private void NGLEEHGBBMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6F85D90", Offset = "0x6F84F90", VA = "0x186F85D90", Slot = "51")]
	private JNAKBMBBKNN PLIFKLHBOAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6F85440", Offset = "0x6F84640", VA = "0x186F85440", Slot = "52")]
	private PKDPFMCHDKO DHFCJIBMGNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6F85C00", Offset = "0x6F84E00", VA = "0x186F85C00", Slot = "53")]
	[AsyncStateMachine(typeof(LAJGJJKPPHH))]
	private Task<DGFDNIJCPMA> OMCJIEMPOBJ(NCKGPLMHNNB HEEEABJCCCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6F85670", Offset = "0x6F84870", VA = "0x186F85670", Slot = "54")]
	[AsyncStateMachine(typeof(BHKLIJPOLJK))]
	private Task EOCPFACOFDC(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6F85D10", Offset = "0x6F84F10", VA = "0x186F85D10")]
	[IteratorStateMachine(typeof(HNFJPMHDLFC))]
	private IEnumerable<DLOEDDKPHPI> OPAOOEAGKHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6F85AD0", Offset = "0x6F84CD0", VA = "0x186F85AD0")]
	[CompilerGenerated]
	private void JDBGIOPHKGE(DLOEDDKPHPI INPAFGCEBHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class DNGDLAEGGBH : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0xEF5750", Offset = "0xEF4950", VA = "0x180EF5750")]
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
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AOJJOPMOLMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x6F93E10", Offset = "0x6F93010", VA = "0x186F93E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x6F94150", Offset = "0x6F93350", VA = "0x186F94150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MFEINKDLEHJ EKMGPIDNBAL;

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x85F050", Offset = "0x85E250", VA = "0x18085F050")]
	public AOJJOPMOLMK(PNHFEHLPHMO KBCJMHHCDBC, MFEINKDLEHJ EKMGPIDNBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6F80000", Offset = "0x6F7F200", VA = "0x186F80000", Slot = "4")]
	[AsyncStateMachine(typeof(LGLFBGJDEPF))]
	public Task<bool> AOCJNLDMAFJ(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6F800F0", Offset = "0x6F7F2F0", VA = "0x186F800F0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public MFCEKMANMAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private float <timeoutTime>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6F81490", Offset = "0x6F80690", VA = "0x186F81490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6F81BA0", Offset = "0x6F80DA0", VA = "0x186F81BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly MFEINKDLEHJ EKMGPIDNBAL;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private FFAMIDMIBLK HFPCNNCNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x6F94EB0", Offset = "0x6F940B0", VA = "0x186F94EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x85F050", Offset = "0x85E250", VA = "0x18085F050")]
	public MFCEKMANMAH(PNHFEHLPHMO KBCJMHHCDBC, MFEINKDLEHJ EKMGPIDNBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x6F94CA0", Offset = "0x6F93EA0", VA = "0x186F94CA0", Slot = "4")]
	[AsyncStateMachine(typeof(BLCJBLBLCNE))]
	public Task<bool> AOCJNLDMAFJ(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x6F94DD0", Offset = "0x6F93FD0", VA = "0x186F94DD0")]
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
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public NFPBGEHJCEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public OEFODOPOJHO result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public MDBDBMHCDOA newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public LFGODBHHOHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6F93D20", Offset = "0x6F92F20", VA = "0x186F93D20")]
		internal object KGCKGCEKMLC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F93CB0", Offset = "0x6F92EB0", VA = "0x186F93CB0")]
		internal object JEIPIGHBHKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6F93C10", Offset = "0x6F92E10", VA = "0x186F93C10")]
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
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public NFPBGEHJCEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private LFGODBHHOHE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<OEFODOPOJHO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6F83FB0", Offset = "0x6F831B0", VA = "0x186F83FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6F848E0", Offset = "0x6F83AE0", VA = "0x186F848E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly MFEINKDLEHJ EKMGPIDNBAL;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private FFAMIDMIBLK HFPCNNCNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6F9B070", Offset = "0x6F9A270", VA = "0x186F9B070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x85F050", Offset = "0x85E250", VA = "0x18085F050")]
	public NFPBGEHJCEI(PNHFEHLPHMO KBCJMHHCDBC, MFEINKDLEHJ EKMGPIDNBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x6F9AF50", Offset = "0x6F9A150", VA = "0x186F9AF50", Slot = "4")]
	[AsyncStateMachine(typeof(DHHJGIFDFEB))]
	public Task<bool> AOCJNLDMAFJ(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal interface MGNJKKAIFOI
{
	[Cpp2IlInjected.Token(Token = "0x60001C9")]
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
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public PNHFEHLPHMO manager;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public MOLOBLHIFJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6F9A920", Offset = "0x6F99B20", VA = "0x186F9A920")]
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
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public NNPIKJEPMJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private NCKGPLMHNNB <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter<IHBHHHHIAHA> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter<DGFDNIJCPMA> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6F8E9D0", Offset = "0x6F8DBD0", VA = "0x186F8E9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EF60", Offset = "0x6F8E160", VA = "0x186F8EF60", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public NNPIKJEPMJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6F86CD0", Offset = "0x6F85ED0", VA = "0x186F86CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6F86FF0", Offset = "0x6F861F0", VA = "0x186F86FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly CancellationToken MPLGBOFHPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly PNHFEHLPHMO GOHDOKCJOFP;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	private ILFDHJAHNHI HIAEFCJGPMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6F9B750", Offset = "0x6F9A950", VA = "0x186F9B750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private MFEINKDLEHJ KFKHEOKCKBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x6F9B240", Offset = "0x6F9A440", VA = "0x186F9B240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private FFAMIDMIBLK HFPCNNCNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6F9B620", Offset = "0x6F9A820", VA = "0x186F9B620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private EMPCKPBJDBG DNFGAGHGFEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6F9B290", Offset = "0x6F9A490", VA = "0x186F9B290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x1FD1800", Offset = "0x1FD0A00", VA = "0x181FD1800")]
	public NNPIKJEPMJD(CancellationToken MPLGBOFHPLM, PNHFEHLPHMO GOHDOKCJOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6F9B6A0", Offset = "0x6F9A8A0", VA = "0x186F9B6A0")]
	public static HPIMEFGKLNK NMBOGGHINHI(PNHFEHLPHMO GOHDOKCJOFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6F9B130", Offset = "0x6F9A330", VA = "0x186F9B130")]
	[AsyncStateMachine(typeof(JFEGJJBMFAE))]
	public Task<bool> AGALHLJOLPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6F9B2E0", Offset = "0x6F9A4E0", VA = "0x186F9B2E0")]
	private bool LEBPNAIGEJO([Out] NCKGPLMHNNB HEEEABJCCCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6F9B7A0", Offset = "0x6F9A9A0", VA = "0x186F9B7A0")]
	[AsyncStateMachine(typeof(FMDGDOABFEA))]
	private Task PJHENJEAODH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6F9B4F0", Offset = "0x6F9A6F0", VA = "0x186F9B4F0")]
	private Task<IHBHHHHIAHA> LOKGNICGELD(NCKGPLMHNNB NINHNJFGIBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct ILGKIPAKNNM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly DHPDBLFEFKM PODDALKBECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Guid KPMGFINBLBG;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Task<(DGFDNIJCPMA, Task)> BFILLPLPPPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x6F8DB50", Offset = "0x6F8CD50", VA = "0x186F8DB50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x42356D0", Offset = "0x42348D0", VA = "0x1842356D0")]
	public ILGKIPAKNNM(DHPDBLFEFKM PODDALKBECI, Guid KPMGFINBLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DCF0", Offset = "0x6F8CEF0", VA = "0x186F8DCF0")]
	public TaskAwaiter<(DGFDNIJCPMA, Task)> HGMNODJPCNM()
	{
		return default(TaskAwaiter<(DGFDNIJCPMA, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DC20", Offset = "0x6F8CE20", VA = "0x186F8DC20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal struct DEPMLGHEKII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly TaskCompletionSource<(DGFDNIJCPMA, Task)> IKADGLBBPCG;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Task<(DGFDNIJCPMA, Task)> BFILLPLPPPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6F83930", Offset = "0x6F82B30", VA = "0x186F83930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6F83B80", Offset = "0x6F82D80", VA = "0x186F83B80")]
	public DEPMLGHEKII(TimeSpan CENAAPAKFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6F83970", Offset = "0x6F82B70", VA = "0x186F83970")]
	public void EIHJHKEEANH(Task FPNFJMOCKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F83A10", Offset = "0x6F82C10", VA = "0x186F83A10")]
	public void GEKAFKBGJMB(DGFDNIJCPMA OMMIFMPIFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6F83B30", Offset = "0x6F82D30", VA = "0x186F83B30")]
	public void PNEGMOMJHEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x6F83AA0", Offset = "0x6F82CA0", VA = "0x186F83AA0")]
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
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public HNKJBJIHEKD subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public GBHEPCMOOEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x6F87100", Offset = "0x6F86300", VA = "0x186F87100")]
		internal bool NOGFNJFMPBP(HCDOMJKEJGM s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F92330", Offset = "0x6F91530", VA = "0x186F92330")]
	public static JBBIANFGILF JGIIBNEOBDO(long LBHHCOPBEOO, long KJMNNDODHCP, string CNCIKMOKNCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F92040", Offset = "0x6F91240", VA = "0x186F92040")]
	public static JBBIANFGILF JGIIBNEOBDO(long LBHHCOPBEOO, long KJMNNDODHCP, KEOGFOOKLEH BIOFMAGLAJN, long JFKPBGIIONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F923C0", Offset = "0x6F915C0", VA = "0x186F923C0")]
	public static JBBIANFGILF JGIIBNEOBDO(BMBMOGELPMJ BODDICEIOJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F92100", Offset = "0x6F91300", VA = "0x186F92100")]
	public static JBBIANFGILF JGIIBNEOBDO(FLKIEPIEFEG FEBBHMHHOKC, HNKJBJIHEKD IHANMGECDBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6F92550", Offset = "0x6F91750", VA = "0x186F92550")]
	public static JBBIANFGILF OPOMKMNENAA(this JBBIANFGILF MIJPDJDOIDB, FLKIEPIEFEG FMHAEEHBLLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6F91EB0", Offset = "0x6F910B0", VA = "0x186F91EB0")]
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
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public DBDPEFCLHMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x6F7ECA0", Offset = "0x6F7DEA0", VA = "0x186F7ECA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F330", Offset = "0x6F7E530", VA = "0x186F7F330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly NKPKPHIMNEI EIEOONHFCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private string PKKHOAKPOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Task GBJLHNPCAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool DKMCCHAMJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x6F81EC0", Offset = "0x6F810C0", VA = "0x186F81EC0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public Task NIIJPKMNAEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6F82010", Offset = "0x6F81210", VA = "0x186F82010", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x858FC0", Offset = "0x8581C0", VA = "0x180858FC0", Slot = "7")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6F820A0", Offset = "0x6F812A0", VA = "0x186F820A0", Slot = "6")]
	public void ODPNHFDHCHP(Task LEDCCMOCHJB, string NAFEJNMBGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6F81EF0", Offset = "0x6F810F0", VA = "0x186F81EF0")]
	[AsyncStateMachine(typeof(AFBOKGKNFLA))]
	private Task HKBNFPKOHBA(Task DJMMIEKABGF, string NAFEJNMBGDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6F82200", Offset = "0x6F81400", VA = "0x186F82200")]
	public DBDPEFCLHMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class AJNJHKPNKKB : DKMKDMJDKAD, DLOEDDKPHPI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool DJPKCKCDCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private AGBLOFNHMNJ KBLFDMHIFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private ILFDHJAHNHI FAELELHBKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private KJHGHIOALEA AACIHKHGIHG;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public AGBLOFNHMNJ CGDMKGIJFNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x6F7FB60", Offset = "0x6F7ED60", VA = "0x186F7FB60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6F7FC10", Offset = "0x6F7EE10", VA = "0x186F7FC10", Slot = "7")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6F7FE50", Offset = "0x6F7F050", VA = "0x186F7FE50", Slot = "5")]
	public void IMDJDHEEMJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6F7FBD0", Offset = "0x6F7EDD0", VA = "0x186F7FBD0", Slot = "6")]
	public void FNLBOAJMEAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6F7FD90", Offset = "0x6F7EF90", VA = "0x186F7FD90")]
	private Task HPEAEHOOAHL(FMJIADNAIKM LMDEKGEENAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6F7FBD0", Offset = "0x6F7EDD0", VA = "0x186F7FBD0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A6350", Offset = "0x8A5550", VA = "0x1808A6350")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x9AE710", Offset = "0x9AD910", VA = "0x1809AE710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3EDB560", Offset = "0x3EDA760", VA = "0x183EDB560")]
		public ILFHBMGGKEC(PMIHDANGMFM KHLLEDBKIEB, string NDDCLPHCEEO, T LIAHLPBCKNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3EDAF70", Offset = "0x3EDA170", VA = "0x183EDAF70")]
		private void LFMLDIGACBB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly PMIHDANGMFM KHLLEDBKIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly ILFHBMGGKEC<TimeSpan> FGJMIKIHGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly ILFHBMGGKEC<TimeSpan> HGEICKNLABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly ILFHBMGGKEC<TimeSpan> BIIKAHONGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly ILFHBMGGKEC<TimeSpan> ICOLNEIEPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly ILFHBMGGKEC<bool> EBEKBOKEHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly ILFHBMGGKEC<bool> KMBDHDFPDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly ILFHBMGGKEC<bool> JJGLHGBBLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly ILFHBMGGKEC<int> OKAOJGFPOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly ILFHBMGGKEC<bool> BBPOCBHELBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly ILFHBMGGKEC<bool> BMNDDOFGHJK;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public TimeSpan POPLOMEELGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x6F88910", Offset = "0x6F87B10", VA = "0x186F88910", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public TimeSpan EILAOPAHMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x6F887D0", Offset = "0x6F879D0", VA = "0x186F887D0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public TimeSpan FFOMFNFAGFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x6F886D0", Offset = "0x6F878D0", VA = "0x186F886D0", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public TimeSpan MFJMGLGDJLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x6F888D0", Offset = "0x6F87AD0", VA = "0x186F888D0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool HIEMGKLEMPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x6F88850", Offset = "0x6F87A50", VA = "0x186F88850", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool DHJHHPNONME
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x6F88710", Offset = "0x6F87910", VA = "0x186F88710", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool PDNJFNGKLAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x6F88750", Offset = "0x6F87950", VA = "0x186F88750", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int HBEFNCBJLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6F88790", Offset = "0x6F87990", VA = "0x186F88790", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool GMPLDANEBAP
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6F88890", Offset = "0x6F87A90", VA = "0x186F88890", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool JLAHKDIJKKN
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6F88810", Offset = "0x6F87A10", VA = "0x186F88810", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x6F88950", Offset = "0x6F87B50", VA = "0x186F88950")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public DOKPADCGDHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6F84E90", Offset = "0x6F84090", VA = "0x186F84E90")]
		internal object MGNNDFMFPAN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action FBNNGEHPFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6F90990", Offset = "0x6F8FB90", VA = "0x186F90990", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6F90550", Offset = "0x6F8F750", VA = "0x186F90550", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event OMLCDPLNPMG DAKEBEBHJID
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6F908F0", Offset = "0x6F8FAF0", VA = "0x186F908F0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x6F90B80", Offset = "0x6F8FD80", VA = "0x186F90B80", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event OMLCDPLNPMG JINMNOEEMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x6F90A30", Offset = "0x6F8FC30", VA = "0x186F90A30", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6F90820", Offset = "0x6F8FA20", VA = "0x186F90820", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event OMLCDPLNPMG LLPKHLEBIFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6F90CC0", Offset = "0x6F8FEC0", VA = "0x186F90CC0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6F90C20", Offset = "0x6F8FE20", VA = "0x186F90C20", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<EFBCINIABEJ, bool> FDJJFJNOJEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x6F90AD0", Offset = "0x6F8FCD0", VA = "0x186F90AD0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x6F90250", Offset = "0x6F8F450", VA = "0x186F90250", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "19")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6F90620", Offset = "0x6F8F820", VA = "0x186F90620", Slot = "14")]
	public void GJOPDEMKKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6F908C0", Offset = "0x6F8FAC0", VA = "0x186F908C0", Slot = "15")]
	public void IGKNNADFBCJ(BIDJCBPPELH NMJHAGKCPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6F90520", Offset = "0x6F8F720", VA = "0x186F90520", Slot = "16")]
	public void CBIKINJHPHE(BIDJCBPPELH NMJHAGKCPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6F905F0", Offset = "0x6F8F7F0", VA = "0x186F905F0", Slot = "17")]
	public void GCEEECEEPGL(BIDJCBPPELH NMJHAGKCPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6F90300", Offset = "0x6F8F500", VA = "0x186F90300", Slot = "18")]
	public void APBMNJALIEG(EFBCINIABEJ LJJJHDHDDOO, bool NPCJOOKKGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6F90350", Offset = "0x6F8F550", VA = "0x186F90350")]
	private void APPOJKGPLJE(OMLCDPLNPMG DAKLDBBBMLH, BIDJCBPPELH NMJHAGKCPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F84950", Offset = "0x6F83B50", VA = "0x186F84950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6F84E30", Offset = "0x6F84030", VA = "0x186F84E30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F92640", Offset = "0x6F91840", VA = "0x186F92640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6F92CA0", Offset = "0x6F91EA0", VA = "0x186F92CA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public NJMPMBBCKFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6F9B0C0", Offset = "0x6F9A2C0", VA = "0x186F9B0C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F8DD40", Offset = "0x6F8CF40", VA = "0x186F8DD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6F8E490", Offset = "0x6F8D690", VA = "0x186F8E490", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public HMOFCOEHDFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x6F88FC0", Offset = "0x6F881C0", VA = "0x186F88FC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6F80B40", Offset = "0x6F7FD40", VA = "0x186F80B40", Slot = "6")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x6F80A30", Offset = "0x6F7FC30", VA = "0x186F80A30", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6F80A40", Offset = "0x6F7FC40", VA = "0x186F80A40", Slot = "8")]
	public void GINDKEMMJIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6F80830", Offset = "0x6F7FA30", VA = "0x186F80830", Slot = "5")]
	public void CNOADOMBMCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x6F80FE0", Offset = "0x6F801E0", VA = "0x186F80FE0", Slot = "4")]
	[AsyncStateMachine(typeof(DJAFMLHHAIH))]
	public Task NMANLOAKGED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x6F80CC0", Offset = "0x6F7FEC0", VA = "0x186F80CC0")]
	private void KKFDGNOJHKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6F80BC0", Offset = "0x6F7FDC0", VA = "0x186F80BC0")]
	[AsyncStateMachine(typeof(KHAGLLPCFMC))]
	private Task JLBHAMLFEMO(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6F810B0", Offset = "0x6F802B0", VA = "0x186F810B0")]
	[AsyncStateMachine(typeof(JCAAOPLFHHJ))]
	private Task<bool> NOPPOHGFLDN(int DHNLEFJCEAH, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6F80750", Offset = "0x6F7F950", VA = "0x186F80750")]
	private void AKHCHGOIHLF(int DHNLEFJCEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x6F811F0", Offset = "0x6F803F0", VA = "0x186F811F0")]
	private void OCLKHLIGBBD(int DHNLEFJCEAH, bool NPCJOOKKGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x6F80900", Offset = "0x6F7FB00", VA = "0x186F80900")]
	private void DFEHLIFKLBM(int DHNLEFJCEAH, Exception PBAHBFAICPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6F812D0", Offset = "0x6F804D0", VA = "0x186F812D0")]
	private void PCIOICDEOFK(CancellationToken MPLGBOFHPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
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
	private struct NOOACFLDDDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public PHMFOBHEKIK customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6F9B870", Offset = "0x6F9AA70", VA = "0x186F9B870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x6F9C1D0", Offset = "0x6F9B3D0", VA = "0x186F9C1D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct KDCPIDPLAFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public PHMFOBHEKIK customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private OADONCMLPJG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private PHCOOIGGHEB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private NOCKKKPBJAK <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private LOEOIDGPKKK <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6F91290", Offset = "0x6F90490", VA = "0x186F91290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6F91E50", Offset = "0x6F91050", VA = "0x186F91E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class GADJAGPBFDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public Matchmaking.DCIEOPEHEPA result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public DMFAPLFEJDL errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public GADJAGPBFDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6F87050", Offset = "0x6F86250", VA = "0x186F87050")]
		internal object PKDFCEACPLO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class GNNOAFOOGHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public Task<JBBIANFGILF> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public GNNOAFOOGHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x852300", VA = "0x180853100")]
		internal Task<JBBIANFGILF> AKALEOPAHNP(OADONCMLPJG<string>.HILOONJJDHL _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct MKHMPOAOELL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public PHMFOBHEKIK customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public NOCKKKPBJAK joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private GNNOAFOOGHA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private NPFIODHPLCC <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private PHCOOIGGHEB <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private OADONCMLPJG<string>.HILOONJJDHL <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private NKKKGGINLEP <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private Task<Matchmaking.HMGBEKBDAJP> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private AFIHICIEAEF <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private int <i>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private TaskAwaiter<Matchmaking.HMGBEKBDAJP> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private TaskAwaiter<JBBIANFGILF> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x6F94F00", Offset = "0x6F94100", VA = "0x186F94F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6F9A8C0", Offset = "0x6F99AC0", VA = "0x186F9A8C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct IEDHJJKJMPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private OADONCMLPJG<string>.HILOONJJDHL <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6F8D0A0", Offset = "0x6F8C2A0", VA = "0x186F8D0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6F8DAF0", Offset = "0x6F8CCF0", VA = "0x186F8DAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct JDBFAHLHNLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private INCIOHANCNE <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6F8E500", Offset = "0x6F8D700", VA = "0x186F8E500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6F8E970", Offset = "0x6F8DB70", VA = "0x186F8E970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct NDBPHEHEGMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public AsyncTaskMethodBuilder<Matchmaking.HMGBEKBDAJP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private TaskAwaiter<Matchmaking.HMGBEKBDAJP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6F9A9E0", Offset = "0x6F99BE0", VA = "0x186F9A9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6F9AEE0", Offset = "0x6F9A0E0", VA = "0x186F9AEE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct LKCGAEMBFDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public Matchmaking.HMGBEKBDAJP serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public NOCKKKPBJAK joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private TaskAwaiter<HBOFKAEDAPN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6F941C0", Offset = "0x6F933C0", VA = "0x186F941C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6F948C0", Offset = "0x6F93AC0", VA = "0x186F948C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class HMCIGOOICPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public HMCIGOOICPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6F88DC0", Offset = "0x6F87FC0", VA = "0x186F88DC0")]
		internal object FBGOHMOBGCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6F88EC0", Offset = "0x6F880C0", VA = "0x186F88EC0")]
		internal string JMIFFCAIAEJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct GLILFGLCOIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private HMCIGOOICPP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6F87130", Offset = "0x6F86330", VA = "0x186F87130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6F87D00", Offset = "0x6F86F00", VA = "0x186F87D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct GPKLHOCAINO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public NOCKKKPBJAK joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public JBBIANFGILF initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public MDBDBMHCDOA targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public NPFIODHPLCC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private OADONCMLPJG<string>.HILOONJJDHL <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x6F87D60", Offset = "0x6F86F60", VA = "0x186F87D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6F88670", Offset = "0x6F87870", VA = "0x186F88670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct DCPOAGEAJHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private OADONCMLPJG<string>.HILOONJJDHL <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private PHCOOIGGHEB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private CancellationTokenSource <timeoutTcs>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private CancellationToken <timeoutToken>5__7;

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x6F82290", Offset = "0x6F81490", VA = "0x186F82290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x6F838D0", Offset = "0x6F82AD0", VA = "0x186F838D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct AFDLLGFFHOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public JLMLCKPCLMI localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public HNKBGIBBNMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private TaskAwaiter<DGFDNIJCPMA> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F390", Offset = "0x6F7E590", VA = "0x186F7F390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6F7FB00", Offset = "0x6F7ED00", VA = "0x186F7FB00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class LBFPKNNPLFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public LBFPKNNPLFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6F93A40", Offset = "0x6F92C40", VA = "0x186F93A40")]
		internal object POCCAOMGPEE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class EEIDPHAINCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public EEIDPHAINCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6F84F70", Offset = "0x6F84170", VA = "0x186F84F70")]
		internal void CJEJNJFHLPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class JNDJBOEIGAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public JNDJBOEIGAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6F8FE80", Offset = "0x6F8F080", VA = "0x186F8FE80")]
		internal object BABICLDPMHL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class IBIFIEFIIIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public IBIFIEFIIIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x6F8CFA0", Offset = "0x6F8C1A0", VA = "0x186F8CFA0")]
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

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private HMBECBJGGMK AIEAPICLDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly NKPKPHIMNEI HLFHFFLLGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private AFIHICIEAEF JILPJAIBHOM;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public TaskStatus GBIGLBPMJGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x879C50", Offset = "0x878E50", VA = "0x180879C50", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xACA390", Offset = "0xAC9590", VA = "0x180ACA390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private FFAMIDMIBLK HFPCNNCNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x6F8CBB0", Offset = "0x6F8BDB0", VA = "0x186F8CBB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x6F8B6E0", Offset = "0x6F8A8E0", VA = "0x186F8B6E0", Slot = "6")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6F8A690", Offset = "0x6F89890", VA = "0x186F8A690", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6F8BB60", Offset = "0x6F8AD60", VA = "0x186F8BB60", Slot = "5")]
	[AsyncStateMachine(typeof(NOOACFLDDDK))]
	public Task IADAOMLEGLE(MDBDBMHCDOA OLIIPNAKLLA, PHMFOBHEKIK LHBIIPLLKKE, CancellationToken LJPECIOGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C160", Offset = "0x6F8B360", VA = "0x186F8C160")]
	[AsyncStateMachine(typeof(KDCPIDPLAFM))]
	private Task LEIGIBIHDKJ(MDBDBMHCDOA OLIIPNAKLLA, PHMFOBHEKIK LHBIIPLLKKE, CancellationToken LJPECIOGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6F89B90", Offset = "0x6F88D90", VA = "0x186F89B90")]
	private static void AMEBNCCMPCK(GDBDKOPOCLO CLJOHLGPPOL, MDBDBMHCDOA OLIIPNAKLLA, Exception PBAHBFAICPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6F8A740", Offset = "0x6F89940", VA = "0x186F8A740")]
	private static void FFBKAJLPPED(LOEOIDGPKKK IOLDPMPDDLA, Exception PBAHBFAICPK, [Optional] List<int> ODNIHHABMCH, int KCKAFLCODKL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C530", Offset = "0x6F8B730", VA = "0x186F8C530")]
	[AsyncStateMachine(typeof(MKHMPOAOELL))]
	private Task MENFDAOMFIP(OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, MDBDBMHCDOA OLIIPNAKLLA, PHMFOBHEKIK LHBIIPLLKKE, NOCKKKPBJAK OPJMEADJLCF, CancellationToken LJPECIOGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6F8BA10", Offset = "0x6F8AC10", VA = "0x186F8BA10")]
	private void HNFCABGDADF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6F8B5B0", Offset = "0x6F8A7B0", VA = "0x186F8B5B0")]
	[AsyncStateMachine(typeof(IEDHJJKJMPG))]
	private Task HELENOIFGLE(OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C820", Offset = "0x6F8BA20", VA = "0x186F8C820")]
	private void NADLKFOEBAO(MDBDBMHCDOA OLIIPNAKLLA, CancellationToken LJPECIOGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6F8A220", Offset = "0x6F89420", VA = "0x186F8A220")]
	private void DBGMGHDNGAL(MDBDBMHCDOA OLIIPNAKLLA, NOCKKKPBJAK OPJMEADJLCF, OperationCanceledException JEGEBALABNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6F8BCA0", Offset = "0x6F8AEA0", VA = "0x186F8BCA0")]
	private void IGGJNBCFCEJ(MDBDBMHCDOA OLIIPNAKLLA, NOCKKKPBJAK OPJMEADJLCF, Exception PBAHBFAICPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6F894E0", Offset = "0x6F886E0", VA = "0x186F894E0")]
	private void ADECOJLLCEG(MDBDBMHCDOA OLIIPNAKLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6F8A6E0", Offset = "0x6F898E0", VA = "0x186F8A6E0")]
	private static BIDJCBPPELH EJFDIJEFKFP(MDBDBMHCDOA OLIIPNAKLLA)
	{
		return default(BIDJCBPPELH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6F8A150", Offset = "0x6F89350", VA = "0x186F8A150")]
	[AsyncStateMachine(typeof(JDBFAHLHNLM))]
	private Task BOELEJIFBLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6F8B1A0", Offset = "0x6F8A3A0", VA = "0x186F8B1A0")]
	[AsyncStateMachine(typeof(NDBPHEHEGMB))]
	private Task<Matchmaking.HMGBEKBDAJP> FMLAHBCEJDN(MDBDBMHCDOA OLIIPNAKLLA, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6F8BFC0", Offset = "0x6F8B1C0", VA = "0x186F8BFC0")]
	private static HBOFKAEDAPN KOHBOIIBIEM(Matchmaking.HMGBEKBDAJP KOCMLIJCBLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6F896F0", Offset = "0x6F888F0", VA = "0x186F896F0")]
	[AsyncStateMachine(typeof(LKCGAEMBFDJ))]
	private Task AHFJIDFMPEB(Matchmaking.HMGBEKBDAJP KOCMLIJCBLI, NOCKKKPBJAK OPJMEADJLCF, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken CGFBIGKMGCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6F8A550", Offset = "0x6F89750", VA = "0x186F8A550")]
	[AsyncStateMachine(typeof(GLILFGLCOIM))]
	private Task DPPIJODPFLB(MDBDBMHCDOA OLIIPNAKLLA, CancellationTokenSource CFNNLMNCHIM, Task HNNFPDNLJHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6F89F50", Offset = "0x6F89150", VA = "0x186F89F50")]
	[AsyncStateMachine(typeof(GPKLHOCAINO))]
	private Task BADNIKJAECB(JBBIANFGILF KLNKIGMCCKO, NPFIODHPLCC CMNBDIJCHGE, MDBDBMHCDOA PFCJBPLHMBO, NOCKKKPBJAK CKEHJAPJCLE, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken EOCFNKLBEMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C2B0", Offset = "0x6F8B4B0", VA = "0x186F8C2B0")]
	private NOCKKKPBJAK LJJDGOMDDAL(NOCKKKPBJAK CKEHJAPJCLE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6F8B300", Offset = "0x6F8A500", VA = "0x186F8B300")]
	[AsyncStateMachine(typeof(DCPOAGEAJHJ))]
	private Task GDMGNLIGCBB(OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C6F0", Offset = "0x6F8B8F0", VA = "0x186F8C6F0")]
	[AsyncStateMachine(typeof(AFDLLGFFHOK))]
	private Task MLKHHDHLNGB(CancellationToken MPLGBOFHPLM, int IDCPOPPPDDB, JLMLCKPCLMI ONEPKIAFHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x6F8B430", Offset = "0x6F8A630", VA = "0x186F8B430")]
	private static void GLEGLCIMJNP(MDBDBMHCDOA OLIIPNAKLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x6F89840", Offset = "0x6F88A40", VA = "0x186F89840")]
	private void AHJEPGBAJCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C4A0", Offset = "0x6F8B6A0", VA = "0x186F8C4A0")]
	private void MABJEEAHJII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6F8A0C0", Offset = "0x6F892C0", VA = "0x186F8A0C0")]
	private void BGHPDLKEPFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C0D0", Offset = "0x6F8B2D0", VA = "0x186F8C0D0")]
	private void KPDCFKDOCLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x6F8BED0", Offset = "0x6F8B0D0", VA = "0x186F8BED0")]
	private static void JGCOPKNAEMG(MDBDBMHCDOA OLIIPNAKLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x6F89A80", Offset = "0x6F88C80", VA = "0x186F89A80")]
	private static CancellationTokenRegistration AMDJGGIGCJE(MDBDBMHCDOA OLIIPNAKLLA, CancellationToken CGFBIGKMGCL)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6F8A450", Offset = "0x6F89650", VA = "0x186F8A450")]
	private static void DNGCDFGGFFA(MDBDBMHCDOA OLIIPNAKLLA, Exception PBAHBFAICPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x6F8AFF0", Offset = "0x6F8A1F0", VA = "0x186F8AFF0")]
	private void FGFPEFHEFOM(MDBDBMHCDOA OLIIPNAKLLA, Task HNNFPDNLJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C690", Offset = "0x6F8B890", VA = "0x186F8C690")]
	private static void MGFMJHPPHBP(Func<string> ALLEHOLILJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6F8CE20", Offset = "0x6F8C020", VA = "0x186F8CE20")]
	public HNKBGIBBNMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6F8CB50", Offset = "0x6F8BD50", VA = "0x186F8CB50")]
	[CompilerGenerated]
	internal static (int, int?) NEOALKGAELO(DMFAPLFEJDL LBJMNCMBNEA)
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
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public KECDANANLKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public JLMLCKPCLMI localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EC00", Offset = "0x6F9DE00", VA = "0x186F9EC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x6F9F070", Offset = "0x6F9E270", VA = "0x186F9F070", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public KECDANANLKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public JLMLCKPCLMI localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public KDPMFNPCPDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x6FB0C40", Offset = "0x6FAFE40", VA = "0x186FB0C40")]
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
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public HPIMEFGKLNK taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public JLMLCKPCLMI localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6FA6950", Offset = "0x6FA5B50", VA = "0x186FA6950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6FA6CE0", Offset = "0x6FA5EE0", VA = "0x186FA6CE0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public KECDANANLKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x6FA9470", Offset = "0x6FA8670", VA = "0x186FA9470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x6FA9730", Offset = "0x6FA8930", VA = "0x186FA9730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private readonly HashSet<HPIMEFGKLNK> MBNKNAPCPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private DEBFMJKLBDN HPIKMIOHGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private FFCFLPKEGBI CFHFJJJEMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private LJJNFBNGNFA KNOBALPGCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private IDisposable KPBJBKAIJHH;

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1870", Offset = "0x6FB0A70", VA = "0x186FB1870", Slot = "5")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1650", Offset = "0x6FB0850", VA = "0x186FB1650", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1300", Offset = "0x6FB0500", VA = "0x186FB1300", Slot = "4")]
	public bool CELLIGGGPOC(HPIMEFGKLNK JABMPBLAEKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0C80", Offset = "0x6FAFE80", VA = "0x186FB0C80")]
	private void ACCECIBKIGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1360", Offset = "0x6FB0560", VA = "0x186FB1360")]
	private void CHBANEPGHPG(BCCLEKKJGLB FCMADEBOIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1780", Offset = "0x6FB0980", VA = "0x186FB1780")]
	[AsyncStateMachine(typeof(AKGJJNNFNKA))]
	private Task HBFKOLGGOJG(int IDCPOPPPDDB, JLMLCKPCLMI ONEPKIAFHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0D50", Offset = "0x6FAFF50", VA = "0x186FB0D50")]
	private Func<CancellationToken, List<Task>> BAMLLDAFAFC(int IDCPOPPPDDB, JLMLCKPCLMI ONEPKIAFHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0E20", Offset = "0x6FB0020", VA = "0x186FB0E20")]
	private List<Task> CCPFNHBACIN(int IDCPOPPPDDB, JLMLCKPCLMI ONEPKIAFHHL, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1B70", Offset = "0x6FB0D70", VA = "0x186FB1B70")]
	[AsyncStateMachine(typeof(EEGEPLPDDFO))]
	private Task KDAIKBEEJFH(HPIMEFGKLNK LDEAEONJEHG, CancellationToken EOCJCEFCOOA, int IDCPOPPPDDB, JLMLCKPCLMI ONEPKIAFHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1580", Offset = "0x6FB0780", VA = "0x186FB1580")]
	[AsyncStateMachine(typeof(GJIILEKIGAI))]
	private Task COHAHPNBDIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x6FB16D0", Offset = "0x6FB08D0", VA = "0x186FB16D0")]
	private void GINDKEMMJIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1C90", Offset = "0x6FB0E90", VA = "0x186FB1C90")]
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
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public IIMLFIPAJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x6FACCF0", Offset = "0x6FABEF0", VA = "0x186FACCF0")]
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
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public LLIKMOKHPJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x6FB4370", Offset = "0x6FB3570", VA = "0x186FB4370")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public IPPOKHMHDLE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class GGMPHEJNDAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public GGMPHEJNDAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x6FA9410", Offset = "0x6FA8610", VA = "0x186FA9410")]
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
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public LMGAKJBNMHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x6FB48D0", Offset = "0x6FB3AD0", VA = "0x186FB48D0")]
		internal object IADJNBGAGIC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private readonly Dictionary<Guid, DEPMLGHEKII> PODDALKBECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private readonly TimeSpan PGJKIPCMONL;

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "9")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC0E0", Offset = "0x6FBB2E0", VA = "0x186FBC0E0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6FBCA40", Offset = "0x6FBBC40", VA = "0x186FBCA40", Slot = "4")]
	public ILGKIPAKNNM PBLNBBGFGAP(Guid KPMGFINBLBG)
	{
		return default(ILGKIPAKNNM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC830", Offset = "0x6FBBA30", VA = "0x186FBC830", Slot = "5")]
	public bool MFKDEBIIBOM(Guid KPMGFINBLBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC500", Offset = "0x6FBB700", VA = "0x186FBC500", Slot = "6")]
	public bool ILAGFIPHBII(Guid KPMGFINBLBG, Task FPNFJMOCKDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC0F0", Offset = "0x6FBB2F0", VA = "0x186FBC0F0", Slot = "7")]
	public bool GBCDJOMOKCI(Guid KPMGFINBLBG, DGFDNIJCPMA OMMIFMPIFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC070", Offset = "0x6FBB270", VA = "0x186FBC070", Slot = "8")]
	public Task<(DGFDNIJCPMA, Task)> BDAIDICDCAJ(Guid KPMGFINBLBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC2D0", Offset = "0x6FBB4D0", VA = "0x186FBC2D0")]
	private void GLNFLBKPBCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6FBCC60", Offset = "0x6FBBE60", VA = "0x186FBCC60")]
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
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private readonly MDBDBMHCDOA ODGJFBJGOFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private readonly CancellationTokenSource NPCICLIMLAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public readonly CancellationToken JDBBABFONDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private bool LGIHFPFHNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private bool MAFFMBBADNE;

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x6FBA970", Offset = "0x6FB9B70", VA = "0x186FBA970")]
		public OAIBMIFPOGM(MDBDBMHCDOA ODGJFBJGOFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x6FBA820", Offset = "0x6FB9A20", VA = "0x186FBA820")]
		public void GINDKEMMJIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x6FBA7F0", Offset = "0x6FB99F0", VA = "0x186FBA7F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class COHBDHFHIBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public FMJIADNAIKM disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public COHBDHFHIBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6FA5680", Offset = "0x6FA4880", VA = "0x186FA5680")]
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
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public FMJIADNAIKM disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public CDPDJJBIBDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x6F9DF00", Offset = "0x6F9D100", VA = "0x186F9DF00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x6F9E2B0", Offset = "0x6F9D4B0", VA = "0x186F9E2B0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public PEKOJDNGLPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x6FBCD20", Offset = "0x6FBBF20", VA = "0x186FBCD20")]
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
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public CDPDJJBIBDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private PHCOOIGGHEB <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8660", Offset = "0x6FB7860", VA = "0x186FB8660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x9EC1C0", Offset = "0x9EB3C0", VA = "0x1809EC1C0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public MDBDBMHCDOA newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public NPFMOOJMNCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x6FBA6D0", Offset = "0x6FB98D0", VA = "0x186FBA6D0")]
		internal object AEMEAGGLKLI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x6FBA7B0", Offset = "0x6FB99B0", VA = "0x186FBA7B0")]
		internal object JKBLBAFFGFG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x6FBA770", Offset = "0x6FB9970", VA = "0x186FBA770")]
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
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public DDANANHINOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x6FA5710", Offset = "0x6FA4910", VA = "0x186FA5710")]
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
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public MDBDBMHCDOA newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public CDPDJJBIBDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public PHMFOBHEKIK customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private NPFMOOJMNCA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x6FA7370", Offset = "0x6FA6570", VA = "0x186FA7370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x6FA82F0", Offset = "0x6FA74F0", VA = "0x186FA82F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly ONHBODPEMNP.AOMBGGKOFKP CNCKDHMKNAH;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly MEIHHKOBOJC ICIADONHJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private DEBFMJKLBDN HPIKMIOHGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private CDPDCOBHLKK ABLOKNIMFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private MFEINKDLEHJ EKMGPIDNBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private KJHGHIOALEA AACIHKHGIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private FFDBLCGPPMM MCGBLNMHNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private MDBDBMHCDOA FMOGMGAOFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private OAIBMIFPOGM PJOAGEEEDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private bool OOMHAADDHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private Task NJOFDKJFGCB;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private FFAMIDMIBLK HFPCNNCNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x6FA3580", Offset = "0x6FA2780", VA = "0x186FA3580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool PJEOOLOCMOL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x91FF70", Offset = "0x91F170", VA = "0x18091FF70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x6FA33E0", Offset = "0x6FA25E0", VA = "0x186FA33E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6FA2DB0", Offset = "0x6FA1FB0", VA = "0x186FA2DB0", Slot = "4")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6FA29F0", Offset = "0x6FA1BF0", VA = "0x186FA29F0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6FA3050", Offset = "0x6FA2250", VA = "0x186FA3050")]
	[AsyncStateMachine(typeof(AGCLEHHNEKG))]
	private Task JKMLDKGMEKK(FMJIADNAIKM LCBIAINGNCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6FA33F0", Offset = "0x6FA25F0", VA = "0x186FA33F0")]
	private void NAOMOMFBMJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6FA2860", Offset = "0x6FA1A60", VA = "0x186FA2860")]
	private void BGEFNKEMCOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6FA2B60", Offset = "0x6FA1D60", VA = "0x186FA2B60")]
	private void GAIFFCCGEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6FA3860", Offset = "0x6FA2A60", VA = "0x186FA3860")]
	private bool PLFGDIKCEGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x6FA2CE0", Offset = "0x6FA1EE0", VA = "0x186FA2CE0")]
	[AsyncStateMachine(typeof(MPHDHEIMLNK))]
	private void HKMIFPBLENP(int JGJFKDCDFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x6FA35D0", Offset = "0x6FA27D0", VA = "0x186FA35D0")]
	private void OPMKJEKGEHI([Out] IDisposable EFBBALGDKJK, [Out] IDisposable GJCJECOCBAG, [Out] IDisposable HNAJEPEILMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x6FA3140", Offset = "0x6FA2340", VA = "0x186FA3140")]
	private bool JKPKFJAKOGI(MDBDBMHCDOA ODGJFBJGOFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x6FA3390", Offset = "0x6FA2590", VA = "0x186FA3390")]
	private void LNJAOOJBLKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x6FA3260", Offset = "0x6FA2460", VA = "0x186FA3260")]
	[AsyncStateMachine(typeof(EJJFDEDKAOF))]
	private Task LEIGIBIHDKJ(MDBDBMHCDOA ODGJFBJGOFN, PHMFOBHEKIK LHBIIPLLKKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6FA3CB0", Offset = "0x6FA2EB0", VA = "0x186FA3CB0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public AsyncTaskMethodBuilder<KPFIKNDEFFO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public JFGEPJACMMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private TaskAwaiter<KPFIKNDEFFO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6FA9110", Offset = "0x6FA8310", VA = "0x186FA9110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x6FA93A0", Offset = "0x6FA85A0", VA = "0x186FA93A0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public JHHNPEBPLNM message;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public ABFBAKOBLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F9D580", Offset = "0x6F9C780", VA = "0x186F9D580")]
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
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public JHHNPEBPLNM messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public OCGFNJLLBMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6FBABC0", Offset = "0x6FB9DC0", VA = "0x186FBABC0")]
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
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public IOAFBONFKLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x6FAE510", Offset = "0x6FAD710", VA = "0x186FAE510")]
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
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public JFGEPJACMMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private TaskAwaiter<LDOGEOGHOLH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6FAAB80", Offset = "0x6FA9D80", VA = "0x186FAAB80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB440", Offset = "0x6FAA640", VA = "0x186FAB440", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public JHHNPEBPLNM operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public BIDEHHENBGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x6FA03D0", Offset = "0x6F9F5D0", VA = "0x186FA03D0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public JHHNPEBPLNM operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public JFGEPJACMMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private NOCKKKPBJAK <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD940", Offset = "0x6FACB40", VA = "0x186FAD940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x6FAE4B0", Offset = "0x6FAD6B0", VA = "0x186FAE4B0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<LDOGEOGHOLH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public JFGEPJACMMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private PGGDLKOGOBJ.GFAHLAKMHKM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private NOCKKKPBJAK <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9BD0", Offset = "0x6FB8DD0", VA = "0x186FB9BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x6FBA0F0", Offset = "0x6FB92F0", VA = "0x186FBA0F0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public LDOGEOGHOLH operation;

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public FFBOBOHEFDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x6FA8470", Offset = "0x6FA7670", VA = "0x186FA8470")]
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
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public LDOGEOGHOLH operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public JFGEPJACMMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private OADONCMLPJG<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x6FAE570", Offset = "0x6FAD770", VA = "0x186FAE570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x6FAEBA0", Offset = "0x6FADDA0", VA = "0x186FAEBA0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public CEOJHGOJIKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x6FA3D20", Offset = "0x6FA2F20", VA = "0x186FA3D20")]
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
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public CFPMDHOMAAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x6FA3D80", Offset = "0x6FA2F80", VA = "0x186FA3D80")]
		internal object DNJMBAILEBD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private GAGJCKDHAGD JIMBHKPDLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private LNJOHEOEPEC DCEOPNHDHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private GNGDMGCCAPD ELAJIBPEDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private ILFDHJAHNHI FAELELHBKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private TaskCompletionSource<KPFIKNDEFFO> HNPFGBJOFHC;

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF490", Offset = "0x6FAE690", VA = "0x186FAF490", Slot = "7")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF380", Offset = "0x6FAE580", VA = "0x186FAF380", Slot = "6")]
	[AsyncStateMachine(typeof(GCCCCOACEJO))]
	public Task<KPFIKNDEFFO> HEDPEEEGPBI(CancellationToken JHPDMDBBGOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6FAFA00", Offset = "0x6FAEC00", VA = "0x186FAFA00", Slot = "4")]
	public void NMIDACFLKHF(JHHNPEBPLNM JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x6FAEC00", Offset = "0x6FADE00", VA = "0x186FAEC00", Slot = "5")]
	public void DCAJFCLMDMN(JHHNPEBPLNM AHIOCFBKFEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6FAFEA0", Offset = "0x6FAF0A0", VA = "0x186FAFEA0")]
	[AsyncStateMachine(typeof(HODPIFDFBHL))]
	private Task PONCBMFOEOL(JHHNPEBPLNM GPCNCGBOPJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6FAFD90", Offset = "0x6FAEF90", VA = "0x186FAFD90")]
	[AsyncStateMachine(typeof(INMJIFBIJNC))]
	private Task PBPEGIONGGK(JHHNPEBPLNM LLGJLDCBANK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF8B0", Offset = "0x6FAEAB0", VA = "0x186FAF8B0")]
	[AsyncStateMachine(typeof(NKBHNJGDMBB))]
	private Task<LDOGEOGHOLH> NJFAFCEHLDL(JHHNPEBPLNM GPCNCGBOPJG, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6FAEF60", Offset = "0x6FAE160", VA = "0x186FAEF60")]
	private NOCKKKPBJAK DIFFLJGINPN(JHHNPEBPLNM PIHNIIFANNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF580", Offset = "0x6FAE780", VA = "0x186FAF580")]
	[AsyncStateMachine(typeof(JBIGGDBBPGA))]
	private Task KPBAJBJEEKL(LDOGEOGHOLH PADMFCNKGOL, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF6A0", Offset = "0x6FAE8A0", VA = "0x186FAF6A0")]
	private LDOGEOGHOLH MLCOFAJHONO(JHHNPEBPLNM GPCNCGBOPJG, NOCKKKPBJAK EECJCJLHLIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x2BD90B0", Offset = "0x2BD82B0", VA = "0x182BD90B0")]
	private T FPAIGDJBKKJ<T>(T JMDCGOKJIDA) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6FAEFF0", Offset = "0x6FAE1F0", VA = "0x186FAEFF0")]
	private LDOGEOGHOLH GEPBOINCFBB(JHHNPEBPLNM GPCNCGBOPJG, NOCKKKPBJAK EECJCJLHLIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
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
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public OIIBAKCIDJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x6FBB4F0", Offset = "0x6FBA6F0", VA = "0x186FBB4F0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public MIMPMDOFDGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x6FB7F90", Offset = "0x6FB7190", VA = "0x186FB7F90")]
		internal object MLMAKMIDCHG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private ILFDHJAHNHI FAELELHBKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private FGAHPIAHGMI DLEEJBBLHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private KIJJEBJPOIH OFBHFEIOFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private DHPDBLFEFKM PODDALKBECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private GNDHGGJAABG DKKIFNFPLNE;

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6FB6A50", Offset = "0x6FB5C50", VA = "0x186FB6A50", Slot = "6")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5BD0", Offset = "0x6FB4DD0", VA = "0x186FB5BD0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x6FB6410", Offset = "0x6FB5610", VA = "0x186FB6410", Slot = "4")]
	public ILGKIPAKNNM GIOEHONMECA(JHHNPEBPLNM MJJIPHKHOEB)
	{
		return default(ILGKIPAKNNM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x6FB6840", Offset = "0x6FB5A40", VA = "0x186FB6840", Slot = "5")]
	public void GLALEPFIHIM(Guid KPMGFINBLBG, Task FPNFJMOCKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6FB7090", Offset = "0x6FB6290", VA = "0x186FB7090")]
	private void NFMAFIEKMLN(byte IEEHAPDEHNL, int OHGHBMACDMM, object AENCOFPLNBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5390", Offset = "0x6FB4590", VA = "0x186FB5390")]
	private void BIMAPAGNABO(NDIHCAFDEOE BGEDEFLEFII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5F00", Offset = "0x6FB5100", VA = "0x186FB5F00")]
	private void FOJGMPCGJHJ(NDIHCAFDEOE BGEDEFLEFII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x6FB6BC0", Offset = "0x6FB5DC0", VA = "0x186FB6BC0")]
	private void MCMMFKDFMPA(NDIHCAFDEOE BGEDEFLEFII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x6FB7160", Offset = "0x6FB6360", VA = "0x186FB7160")]
	private DGFDNIJCPMA PKLJABLJELL(JHHNPEBPLNM PIHNIIFANNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x6FB6200", Offset = "0x6FB5400", VA = "0x186FB6200")]
	private void GAKFFOGHFBP(JHHNPEBPLNM LLGJLDCBANK, DGFDNIJCPMA OMMIFMPIFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5920", Offset = "0x6FB4B20", VA = "0x186FB5920")]
	private bool CCNCLFFLLID(JHHNPEBPLNM LLGJLDCBANK, DGFDNIJCPMA OMMIFMPIFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5C80", Offset = "0x6FB4E80", VA = "0x186FB5C80")]
	private bool EGMNIDLJKCE(JHHNPEBPLNM ANENNFMGIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x6FB6E00", Offset = "0x6FB6000", VA = "0x186FB6E00")]
	private bool MKEGGCIIGHD(byte IEEHAPDEHNL, ExitGames.Client.Photon.Hashtable BGEDEFLEFII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
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
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public KPFIKNDEFFO operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public EBGLDLIIJJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public JHHNPEBPLNM roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public HIALKOCPJDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x6FAAB10", Offset = "0x6FA9D10", VA = "0x186FAAB10")]
		internal object NNCHBJALIEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x6FAA9E0", Offset = "0x6FA9BE0", VA = "0x186FAA9E0")]
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
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public AsyncTaskMethodBuilder<DGFDNIJCPMA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public EBGLDLIIJJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public JHHNPEBPLNM roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private TaskAwaiter<DGFDNIJCPMA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4F10", Offset = "0x6FA4110", VA = "0x186FA4F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x6FA55A0", Offset = "0x6FA47A0", VA = "0x186FA55A0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public KPFIKNDEFFO operationType;

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public CHLLPLHOFNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x6FA5610", Offset = "0x6FA4810", VA = "0x186FA5610")]
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
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public KBPCGEPADNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x6FB0B60", Offset = "0x6FAFD60", VA = "0x186FB0B60")]
		internal object BNDOMKNNCBN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x6FB0BD0", Offset = "0x6FAFDD0", VA = "0x186FB0BD0")]
		internal object DOJIPMJKKMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x6FB0AF0", Offset = "0x6FAFCF0", VA = "0x186FB0AF0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public AsyncTaskMethodBuilder<DGFDNIJCPMA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public EBGLDLIIJJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private KBPCGEPADNC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private ILGKIPAKNNM <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private DGFDNIJCPMA <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private TaskAwaiter<(DGFDNIJCPMA validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x6F9D5E0", Offset = "0x6F9C7E0", VA = "0x186F9D5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x6F9DE90", Offset = "0x6F9D090", VA = "0x186F9DE90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private ILFDHJAHNHI FAELELHBKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private FGAHPIAHGMI DLEEJBBLHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private LNJOHEOEPEC DCEOPNHDHAB;

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x6FA66B0", Offset = "0x6FA58B0", VA = "0x186FA66B0", Slot = "5")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x6FA6450", Offset = "0x6FA5650", VA = "0x186FA6450", Slot = "4")]
	[AsyncStateMachine(typeof(CHLDPGIABKC))]
	private Task<DGFDNIJCPMA> ADIBGCJIAIH(JHHNPEBPLNM PIHNIIFANNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x6FA6760", Offset = "0x6FA5960", VA = "0x186FA6760")]
	private bool LFAJICGJEBM(KPFIKNDEFFO LJJJHDHDDOO, [Out] DGFDNIJCPMA ADPMAHMCGNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x6FA6570", Offset = "0x6FA5770", VA = "0x186FA6570")]
	[AsyncStateMachine(typeof(ACAIJAOKMJD))]
	private Task<DGFDNIJCPMA> CEEGAKPAPOH(JHHNPEBPLNM GPCNCGBOPJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
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
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public AsyncTaskMethodBuilder<JBBIANFGILF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AKDLKDBIAEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private TaskAwaiter<FLKIEPIEFEG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private TaskAwaiter<JBBIANFGILF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x6FA0BB0", Offset = "0x6F9FDB0", VA = "0x186FA0BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x6FA1180", Offset = "0x6FA0380", VA = "0x186FA1180", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public MLMGGBGFFBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8570", Offset = "0x6FB7770", VA = "0x186FB8570")]
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
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public AsyncTaskMethodBuilder<FLKIEPIEFEG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public AKDLKDBIAEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private MLMGGBGFFBO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private TaskAwaiter<FLKIEPIEFEG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x6FA84F0", Offset = "0x6FA76F0", VA = "0x186FA84F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x6FA8AE0", Offset = "0x6FA7CE0", VA = "0x186FA8AE0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public AsyncTaskMethodBuilder<JBBIANFGILF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public AKDLKDBIAEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public FLKIEPIEFEG roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private TaskAwaiter<(KEOGFOOKLEH superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x6FA9790", Offset = "0x6FA8990", VA = "0x186FA9790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x6FA9BF0", Offset = "0x6FA8DF0", VA = "0x186FA9BF0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public AGKHFKGBNBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x92CE00", Offset = "0x92C000", VA = "0x18092CE00")]
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
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public AsyncTaskMethodBuilder<(KEOGFOOKLEH superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public FLKIEPIEFEG roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public AKDLKDBIAEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public MDBDBMHCDOA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private TaskAwaiter<(KEOGFOOKLEH superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x6FAA2D0", Offset = "0x6FA94D0", VA = "0x186FAA2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x6FAA970", Offset = "0x6FA9B70", VA = "0x186FAA970", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public OLIEEAFBADB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x6FBB5C0", Offset = "0x6FBA7C0", VA = "0x186FBB5C0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public AsyncTaskMethodBuilder<(KEOGFOOKLEH superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public HCDOMJKEJGM subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public AKDLKDBIAEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public MDBDBMHCDOA dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private OLIEEAFBADB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<HNKJBJIHEKD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x6FA20C0", Offset = "0x6FA12C0", VA = "0x186FA20C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x6FA27F0", Offset = "0x6FA19F0", VA = "0x186FA27F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static readonly (KEOGFOOKLEH superRoomData, long subRoomDataSaveId) OLKFKEJHBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private MFEINKDLEHJ EKMGPIDNBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private FJDMGDBCEIP LPFOAEHCDII;

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E7C0", Offset = "0x6F9D9C0", VA = "0x186F9E7C0", Slot = "5")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E660", Offset = "0x6F9D860", VA = "0x186F9E660", Slot = "4")]
	[AsyncStateMachine(typeof(BNNONHLMBDJ))]
	public Task<JBBIANFGILF> HEIELJDJGCB(OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, MDBDBMHCDOA OLIIPNAKLLA, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E390", Offset = "0x6F9D590", VA = "0x186F9E390")]
	[AsyncStateMachine(typeof(FGEGEKODOGO))]
	private Task<FLKIEPIEFEG> CLMLMLFBNGB(MDBDBMHCDOA OLIIPNAKLLA, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E4F0", Offset = "0x6F9D6F0", VA = "0x186F9E4F0")]
	[AsyncStateMachine(typeof(HAHKDFNBKKJ))]
	private Task<JBBIANFGILF> CNGOKCGJIMP(MDBDBMHCDOA OLIIPNAKLLA, FLKIEPIEFEG MGNEMJNJPBC, long MMMJFAODPOA, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E9C0", Offset = "0x6F9DBC0", VA = "0x186F9E9C0")]
	[AsyncStateMachine(typeof(HFMMKMFIOKF))]
	private Task<(KEOGFOOKLEH, long)> KJBLKACJONI(MDBDBMHCDOA OLIIPNAKLLA, FLKIEPIEFEG MGNEMJNJPBC, long MMMJFAODPOA, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E850", Offset = "0x6F9DA50", VA = "0x186F9E850")]
	[AsyncStateMachine(typeof(CBPACJKAOOO))]
	private Task<(KEOGFOOKLEH, long)> JJCPGCALCHB(MDBDBMHCDOA GJPPIGHDBDI, HCDOMJKEJGM FMOALFGMFNJ, long MMMJFAODPOA, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
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
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public CABABMGDIDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x6FA2060", Offset = "0x6FA1260", VA = "0x186FA2060")]
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
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public AsyncTaskMethodBuilder<JHHNPEBPLNM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public PBLPMMAAJPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public NOCKKKPBJAK pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x6FA5DD0", Offset = "0x6FA4FD0", VA = "0x186FA5DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x6FA63E0", Offset = "0x6FA55E0", VA = "0x186FA63E0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public AsyncTaskMethodBuilder<JHHNPEBPLNM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public PBLPMMAAJPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public NOCKKKPBJAK pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private TaskAwaiter<GLCNHMNLOKL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x6FA9C60", Offset = "0x6FA8E60", VA = "0x186FA9C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x6FAA260", Offset = "0x6FA9460", VA = "0x186FAA260", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public OKJPIDHGIGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x6FBB560", Offset = "0x6FBA760", VA = "0x186FBB560")]
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
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public AsyncTaskMethodBuilder<JHHNPEBPLNM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public JHHNPEBPLNM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public PBLPMMAAJPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public NOCKKKPBJAK pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private NLAOPAEBMHG <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private FIPBDBKIEEE <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private TaskAwaiter<GLCNHMNLOKL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x6FA3DE0", Offset = "0x6FA2FE0", VA = "0x186FA3DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x6FA49D0", Offset = "0x6FA3BD0", VA = "0x186FA49D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private ILFDHJAHNHI FAELELHBKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private DKMKDMJDKAD BIOBKNDENDB;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	private AGBLOFNHMNJ CGDMKGIJFNC
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x6FBB6D0", Offset = "0x6FBA8D0", VA = "0x186FBB6D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x6FBBD30", Offset = "0x6FBAF30", VA = "0x186FBBD30", Slot = "8")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x6FBB9C0", Offset = "0x6FBABC0", VA = "0x186FBB9C0", Slot = "4")]
	[AsyncStateMachine(typeof(DMJEDLKGDEI))]
	public Task<JHHNPEBPLNM> ELIGHDCDHPD(JHHNPEBPLNM GPCNCGBOPJG, NOCKKKPBJAK EECJCJLHLIP, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x6FBBDC0", Offset = "0x6FBAFC0", VA = "0x186FBBDC0", Slot = "5")]
	[AsyncStateMachine(typeof(HANMNAEFEGC))]
	public Task<JHHNPEBPLNM> NEJJKEMHNPK(CancellationToken MPLGBOFHPLM, NOCKKKPBJAK EECJCJLHLIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x6FBBB20", Offset = "0x6FBAD20", VA = "0x186FBBB20", Slot = "6")]
	public AOOKNBGCDKI GCAGPDDCIGD(LDOGEOGHOLH JLCNMJIDAOM, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x6FBB790", Offset = "0x6FBA990", VA = "0x186FBB790", Slot = "7")]
	public AOOKNBGCDKI BLGCCGBNIDG(LDOGEOGHOLH JLCNMJIDAOM, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x6FBBF10", Offset = "0x6FBB110", VA = "0x186FBBF10")]
	[AsyncStateMachine(typeof(CGALDJOHNGG))]
	private Task<JHHNPEBPLNM> PBPMPIHGEDG(JHHNPEBPLNM GPCNCGBOPJG, NOCKKKPBJAK EECJCJLHLIP, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x31EBB30", Offset = "0x31EAD30", VA = "0x1831EBB30")]
	private static byte[] GOABJGJKCCI(JHHNPEBPLNM JNNDBFGKHHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	public PBLPMMAAJPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[UnityEngine.Scripting.Preserve]
internal sealed class EFHPJLNDOMI : FGAHPIAHGMI, DLOEDDKPHPI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private NBAHHDNKILP PLDFHJDBLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	private ILFDHJAHNHI FAELELHBKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private GAGJCKDHAGD JIMBHKPDLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private GDNPJMDDBLG HGNPBLNJDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private MFEINKDLEHJ EKMGPIDNBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private FFDBLCGPPMM MCGBLNMHNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private GPMIBIFCKBJ LPINBJBANHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private KJHGHIOALEA AACIHKHGIHG;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private FFAMIDMIBLK HFPCNNCNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x6FA7320", Offset = "0x6FA6520", VA = "0x186FA7320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private static DGFDNIJCPMA AFLLLJEHLHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x6FA57B0", Offset = "0x6FA49B0", VA = "0x186FA57B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x6FA6D40", Offset = "0x6FA5F40", VA = "0x186FA6D40", Slot = "6")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x6FA71B0", Offset = "0x6FA63B0", VA = "0x186FA71B0", Slot = "4")]
	public DGFDNIJCPMA MBKKPDMNLNB(LCMANADAOPN KNKLAKPFAOI, KPFIKNDEFFO OFNDKLGKJDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x6FA6EB0", Offset = "0x6FA60B0", VA = "0x186FA6EB0", Slot = "5")]
	public DGFDNIJCPMA IKOPFOCCMFH(LCMANADAOPN NACPIIAAOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x6FA5810", Offset = "0x6FA4A10", VA = "0x186FA5810")]
	private static DGFDNIJCPMA LGFAHEEJNOP(IOJDCLBFPMF NPGFMGMHJJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	public EFHPJLNDOMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class MMECDHDBMIH : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8620", Offset = "0x6FB7820", VA = "0x186FB8620")]
	public MMECDHDBMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x642FC50", Offset = "0x642EE50", VA = "0x18642FC50")]
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
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public AsyncTaskMethodBuilder<DGFDNIJCPMA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public KNEPLNMCHOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public NCKGPLMHNNB autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private OADONCMLPJG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private OADONCMLPJG<string>.HILOONJJDHL <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private OCGMAIALJEA <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private TaskAwaiter<DGFDNIJCPMA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x6FB73A0", Offset = "0x6FB65A0", VA = "0x186FB73A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x6FB7F20", Offset = "0x6FB7120", VA = "0x186FB7F20", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public KNEPLNMCHOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x6FB1D20", Offset = "0x6FB0F20", VA = "0x186FB1D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x6FB2470", Offset = "0x6FB1670", VA = "0x186FB2470", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public KNEPLNMCHOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x6FBA160", Offset = "0x6FB9360", VA = "0x186FBA160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x6FBA670", Offset = "0x6FB9870", VA = "0x186FBA670", Slot = "5")]
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

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x6FB3BC0", Offset = "0x6FB2DC0", VA = "0x186FB3BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x6FB4310", Offset = "0x6FB3510", VA = "0x186FB4310", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public KNEPLNMCHOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x6FB3700", Offset = "0x6FB2900", VA = "0x186FB3700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x6FB38A0", Offset = "0x6FB2AA0", VA = "0x186FB38A0", Slot = "5")]
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
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x6FA0430", Offset = "0x6F9F630", VA = "0x186FA0430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x6FA0B50", Offset = "0x6F9FD50", VA = "0x186FA0B50", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public KNEPLNMCHOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4A40", Offset = "0x6FA3C40", VA = "0x186FA4A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4EB0", Offset = "0x6FA40B0", VA = "0x186FA4EB0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public KNEPLNMCHOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public HCEEFOPOCMM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private OADONCMLPJG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x6FAFFB0", Offset = "0x6FAF1B0", VA = "0x186FAFFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x6FB0510", Offset = "0x6FAF710", VA = "0x186FB0510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private ILFDHJAHNHI FAELELHBKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private MFEINKDLEHJ EKMGPIDNBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private GNGDMGCCAPD ELAJIBPEDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private GAGJCKDHAGD JIMBHKPDLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private GPMIBIFCKBJ LPINBJBANHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private CancellationTokenSource GLAECGNFBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private Task HBOAIMOJKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private TaskCompletionSource<int> CHKFKKHGIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private int JMGPACPBHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private int ABBDGPKNACJ;

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2A90", Offset = "0x6FB1C90", VA = "0x186FB2A90", Slot = "6")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0xA748D0", Offset = "0xA73AD0", VA = "0x180A748D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2E60", Offset = "0x6FB2060", VA = "0x186FB2E60")]
	private void KENOGMLIIJC(float EODHKDJNLAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2D30", Offset = "0x6FB1F30", VA = "0x186FB2D30", Slot = "4")]
	[AsyncStateMachine(typeof(MGJOLEKJICM))]
	public Task<DGFDNIJCPMA> JFAEBIMIGEM(NCKGPLMHNNB HEEEABJCCCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2F40", Offset = "0x6FB2140", VA = "0x186FB2F40", Slot = "5")]
	[AsyncStateMachine(typeof(KKDEDEIKJBL))]
	public Task LCOGCHLMALM([Optional] CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0xA748D0", Offset = "0xA73AD0", VA = "0x180A748D0")]
	public void CNPJEKFBNHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2730", Offset = "0x6FB1930", VA = "0x186FB2730")]
	private OCGMAIALJEA DKEKHADIABB(NCKGPLMHNNB HEEEABJCCCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2C40", Offset = "0x6FB1E40", VA = "0x186FB2C40")]
	[AsyncStateMachine(typeof(NOMHJOPBDOP))]
	private Task IDFCJDCFLLA(CancellationToken LJPECIOGMKH, int IDCPOPPPDDB, JLMLCKPCLMI ONEPKIAFHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x6FB28A0", Offset = "0x6FB1AA0", VA = "0x186FB28A0")]
	[AsyncStateMachine(typeof(LKDKPEPCDNM))]
	private Task EAMHJPAFKAH(CancellationToken LJPECIOGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3140", Offset = "0x6FB2340", VA = "0x186FB3140")]
	[AsyncStateMachine(typeof(LJEOLNGJFDF))]
	private Task LLONGBMBIFH([Optional] CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x6FB29A0", Offset = "0x6FB1BA0", VA = "0x186FB29A0")]
	[AsyncStateMachine(typeof(BKPHKDFGKEN))]
	private Task FEGEFKCOLBK(CancellationToken LJPECIOGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3230", Offset = "0x6FB2430", VA = "0x186FB3230")]
	[AsyncStateMachine(typeof(CGNINGFKIPB))]
	private Task NOBGFDFOJPB(CancellationToken LHIBLAEHAHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3330", Offset = "0x6FB2530", VA = "0x186FB3330")]
	private Task PIAALHKKFCK(HCEEFOPOCMM LKIPKDFOIKO, CancellationToken LJPECIOGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3030", Offset = "0x6FB2230", VA = "0x186FB3030")]
	[AsyncStateMachine(typeof(JKHPIJOHMOC))]
	private Task LEDAEHMICIM(HCEEFOPOCMM LKIPKDFOIKO, CancellationToken LJPECIOGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x6FB24D0", Offset = "0x6FB16D0", VA = "0x186FB24D0")]
	private bool DJPMKICBDLN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
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
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public KBJCNLMGEBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private OADONCMLPJG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x6FA8B50", Offset = "0x6FA7D50", VA = "0x186FA8B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x6FA90B0", Offset = "0x6FA82B0", VA = "0x186FA90B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private OMKEILKNJFC NPKMKLLOPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private FGAHPIAHGMI DLEEJBBLHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private GNGDMGCCAPD ELAJIBPEDAA;

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0720", Offset = "0x6FAF920", VA = "0x186FB0720", Slot = "6")]
	public void HMCGAKKBHMB(PNHFEHLPHMO KBCJMHHCDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x6FB06D0", Offset = "0x6FAF8D0", VA = "0x186FB06D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0570", Offset = "0x6FAF770", VA = "0x186FB0570", Slot = "5")]
	[AsyncStateMachine(typeof(FMNELMMCLGK))]
	public Task CEOGFJOOFNG(string BECGFNBELMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0670", Offset = "0x6FAF870", VA = "0x186FB0670", Slot = "4")]
	public DGFDNIJCPMA DJPMKICBDLN(LCMANADAOPN KNKLAKPFAOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0A00", Offset = "0x6FAFC00", VA = "0x186FB0A00")]
	private JKIDNJAJEEP MAPPHJOCDOK(string BECGFNBELMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	public KBJCNLMGEBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public static class OHKFAKLBMEA
{
	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x6FBAC20", Offset = "0x6FB9E20", VA = "0x186FBAC20")]
	public static void CMAHDMNADIP(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x6FBAE60", Offset = "0x6FBA060", VA = "0x186FBAE60")]
	internal static void FIJMHCAIMNB(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x6FBB410", Offset = "0x6FBA610", VA = "0x186FBB410")]
	internal static void MGOKHOADIFP(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x6FBAFC0", Offset = "0x6FBA1C0", VA = "0x186FBAFC0")]
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
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public JHHNPEBPLNM message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public IKECNMIPAJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD5E0", Offset = "0x6FAC7E0", VA = "0x186FAD5E0")]
		internal object BJKIKAPFGMG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly IJCKLOFHIFP MJFJCBEEADM;

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD340", Offset = "0x6FAC540", VA = "0x186FAD340")]
	public ExitGames.Client.Photon.Hashtable OPCGAJMHMBL(JHHNPEBPLNM JNNDBFGKHHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD3D0", Offset = "0x6FAC5D0", VA = "0x186FAD3D0", Slot = "5")]
	protected override void PDCANANKNJH(JHHNPEBPLNM JNNDBFGKHHD, IDictionary<object, object> LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x6FACD50", Offset = "0x6FABF50", VA = "0x186FACD50", Slot = "6")]
	public override JHHNPEBPLNM DGBBAPGEGII(IDictionary<object, object> LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x6FACF80", Offset = "0x6FAC180", VA = "0x186FACF80")]
	private static void MGFMJHPPHBP(string MFIDPDMAIND, JHHNPEBPLNM JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD5A0", Offset = "0x6FAC7A0", VA = "0x186FAD5A0")]
	public IJCKLOFHIFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD090", Offset = "0x6FAC290", VA = "0x186FAD090")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FA57B0", Offset = "0x6FA49B0", VA = "0x186FA57B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x6FA5CD0", Offset = "0x6FA4ED0", VA = "0x186FA5CD0")]
	public static bool MMMIIKFLHMB(this DGFDNIJCPMA OMMIFMPIFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x6FA5810", Offset = "0x6FA4A10", VA = "0x186FA5810")]
	public static DGFDNIJCPMA LGFAHEEJNOP(IOJDCLBFPMF MNCJHJGEMJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x6FA5870", Offset = "0x6FA4A70", VA = "0x186FA5870")]
	public static DGFDNIJCPMA LKFNKJCJHNP(IEnumerable<DGFDNIJCPMA> HLKJLHJANAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x6FA5A70", Offset = "0x6FA4C70", VA = "0x186FA5A70")]
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
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public LCMANADAOPN photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public HLIHCIEBPPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x6653500", Offset = "0x6652700", VA = "0x186653500")]
		internal DGFDNIJCPMA GMNCIGHMOFL(PHLOHJMEDAC v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private bool LOOMHHLOKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	protected readonly HashSet<PHLOHJMEDAC> DCCNPGLMPDA;

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4480", Offset = "0x6FB3680", VA = "0x186FB4480", Slot = "4")]
	public void ICOAKFCEEGG(PHLOHJMEDAC MALFIDMAHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4420", Offset = "0x6FB3620", VA = "0x186FB4420", Slot = "5")]
	public void GCDCOOGHCJC(PHLOHJMEDAC MALFIDMAHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x6FB43D0", Offset = "0x6FB35D0", VA = "0x186FB43D0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x6FB44E0", Offset = "0x6FB36E0", VA = "0x186FB44E0")]
	protected DGFDNIJCPMA KPBLPCLNAJN(LCMANADAOPN NACPIIAAOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4780", Offset = "0x6FB3980", VA = "0x186FB4780")]
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
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public DGFDNIJCPMA result;

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public OBNKKPFDFHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x6FBAA20", Offset = "0x6FB9C20", VA = "0x186FBAA20")]
		internal object NOLMMJAHICD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x6FA8460", Offset = "0x6FA7660", VA = "0x186FA8460")]
	[UnityEngine.Scripting.Preserve]
	public ICGKEGKACAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB4A0", Offset = "0x6FAA6A0", VA = "0x186FAB4A0", Slot = "8")]
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
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public DGFDNIJCPMA result;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public PBHCDHBJPCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x6FBB670", Offset = "0x6FBA870", VA = "0x186FBB670")]
		internal object FFAPHNLCABO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x6FA8460", Offset = "0x6FA7660", VA = "0x186FA8460")]
	[UnityEngine.Scripting.Preserve]
	public FEEGGDIGHPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6FA8350", Offset = "0x6FA7550", VA = "0x186FA8350", Slot = "8")]
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
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public OADONCMLPJG<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public PLCJONIAFOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x6FBCD90", Offset = "0x6FBBF90", VA = "0x186FBCD90")]
		internal object NMHFIGPLJJC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5130", Offset = "0x6FB4330", VA = "0x186FB5130")]
	public static OADONCMLPJG<string> ADOMOAHOKMN(CDLNJDLNIPA KBNCOADBJAI, [Optional] string NELDGGFCGBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x6FB52D0", Offset = "0x6FB44D0", VA = "0x186FB52D0")]
	public static void PAINIEOMMIF(OADONCMLPJG<string> GFNLGFOFJFM, CDLNJDLNIPA KBNCOADBJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5210", Offset = "0x6FB4410", VA = "0x186FB5210")]
	public static string BEINGEOEJIE(JHHNPEBPLNM PIHNIIFANNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal static class OCAJHOCDPLC
{
	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6FBAA80", Offset = "0x6FB9C80", VA = "0x186FBAA80")]
	public static void IOKJHAALHMO(this ILFDHJAHNHI FAELELHBKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x6FBABB0", Offset = "0x6FB9DB0", VA = "0x186FBABB0")]
	public static void ONKCLFPAGNJ(this ILFDHJAHNHI FAELELHBKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x6FBAA90", Offset = "0x6FB9C90", VA = "0x186FBAA90")]
	private static void OGCAIFHMACF(this ILFDHJAHNHI FAELELHBKKO, bool PPIBKPHJPDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public class MJCLPMIECAL : LHBACLGNGEP, IIGABFJMEDH, NCHALEHKFGO, GCDIDGMHHIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	private readonly IIGABFJMEDH KNBEMFOOBEO;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public LCMANADAOPN BNIDNLLDGDI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8000", Offset = "0x6FB7200", VA = "0x186FB8000", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public int NLIMGMDJKMB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x6FB82A0", Offset = "0x6FB74A0", VA = "0x186FB82A0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public int KEIOJNKNJMA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8520", Offset = "0x6FB7720", VA = "0x186FB8520", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool KFNLGFNJAKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x86D520", Offset = "0x86C720", VA = "0x18086D520", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public int FHAMDDJKDHM
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x8C3D00", Offset = "0x8C2F00", VA = "0x1808C3D00", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event GBFIPMEOIEO.IIICGAPIKPN FDGMLHJPMCC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event EMPLKCIGFHB FAAGLMBMKBP
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8200", Offset = "0x6FB7400", VA = "0x186FB8200", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8050", Offset = "0x6FB7250", VA = "0x186FB8050", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> ALIFLIBGFBI
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<LCMANADAOPN> FCAFMIJALDC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action JPCOBLHHKLB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8480", Offset = "0x6FB7680", VA = "0x186FB8480", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8160", Offset = "0x6FB7360", VA = "0x186FB8160", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0xA4C280", Offset = "0xA4B480", VA = "0x180A4C280")]
	public MJCLPMIECAL(IIGABFJMEDH KNBEMFOOBEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x6FB82F0", Offset = "0x6FB74F0", VA = "0x186FB82F0", Slot = "8")]
	public bool LLGBFLNNPKP(byte IEEHAPDEHNL, ExitGames.Client.Photon.Hashtable HLPJEBAFCEI, KGBEHAIDAFK HNCFNOCLOFC, SendOptions PNIFNNMGDFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x6FB83A0", Offset = "0x6FB75A0", VA = "0x186FB83A0", Slot = "16")]
	public LCMANADAOPN MCNNANDHEGF(int LKMOKKELGIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "19")]
	public void CCHHCCMEFDH(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "20")]
	public void NCLNJAFLICJ(object EOCJCEFCOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "21")]
	public void IFLIFIEEPEH(object EOCJCEFCOOA, bool HNBFKCCDJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x6FB80F0", Offset = "0x6FB72F0", VA = "0x186FB80F0", Slot = "22")]
	public IDisposable JAMBAJOBMOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "23")]
	private bool MOFFPJGMBLD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "24")]
	public void BGDDHBNJMCK(StringBuilder EBMHMAKKCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8140", Offset = "0x6FB7340", VA = "0x186FB8140", Slot = "25")]
	public bool JPOBOCAEGBK(bool DCHKPIILKAF, [Out] string GGEHLADLJHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x9791B0", Offset = "0x9783B0", VA = "0x1809791B0", Slot = "28")]
	public void LJEEHGIHICP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal struct NDIHCAFDEOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	private readonly IDictionary<object, object> BGEDEFLEFII;

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x927530", Offset = "0x926730", VA = "0x180927530")]
	public NDIHCAFDEOE(IDictionary<object, object> BGEDEFLEFII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9930", Offset = "0x6FB8B30", VA = "0x186FB9930")]
	public bool LEOKLOLLEBG([Out] JHHNPEBPLNM JNNDBFGKHHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9B20", Offset = "0x6FB8D20", VA = "0x186FB9B20")]
	public Guid NFINFGAHIFN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x6FB99E0", Offset = "0x6FB8BE0", VA = "0x186FB99E0")]
	public DGFDNIJCPMA MHDDMELJGMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9840", Offset = "0x6FB8A40", VA = "0x186FB9840")]
	public static ExitGames.Client.Photon.Hashtable JGIIBNEOBDO(JHHNPEBPLNM JNNDBFGKHHD, DGFDNIJCPMA OMMIFMPIFCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal static class AIGNFIKLEED
{
	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E310", Offset = "0x6F9D510", VA = "0x186F9E310")]
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
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public LJJNFBNGNFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x6FB34C0", Offset = "0x6FB26C0", VA = "0x186FB34C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x6FB36A0", Offset = "0x6FB28A0", VA = "0x186FB36A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	private readonly CancellationTokenSource NPCICLIMLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	private bool LOOMHHLOKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	private Task LEDCCMOCHJB;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool OONANGMADII
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x6FB3900", Offset = "0x6FB2B00", VA = "0x186FB3900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3A90", Offset = "0x6FB2C90", VA = "0x186FB3A90")]
	public LJJNFBNGNFA(CancellationToken MPLGBOFHPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3980", Offset = "0x6FB2B80", VA = "0x186FB3980")]
	[AsyncStateMachine(typeof(KNKBDKPEAAF))]
	public Task GKDNMPIMODG(Func<CancellationToken, List<Task>> FCCDOIIADHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3930", Offset = "0x6FB2B30", VA = "0x186FB3930", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public AsyncTaskMethodBuilder<CIKECDEKJAI<MOGOEHIGGGP<TData>, EGADAFAJMEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public PFLNKKCOAHI<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private TaskAwaiter<CIKECDEKJAI<MOGOEHIGGGP<TData>, EGADAFAJMEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x447EB10", Offset = "0x447DD10", VA = "0x18447EB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x381B610", Offset = "0x381A810", VA = "0x18381B610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	private readonly AJPKAMNMEFA<TGetDataArg, TData> NMBACBFNMGF;

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x927530", Offset = "0x926730", VA = "0x180927530")]
	internal PFLNKKCOAHI(AJPKAMNMEFA<TGetDataArg, TData> HDLOJHGAFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x47778B0", Offset = "0x4776AB0", VA = "0x1847778B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x25AC0C0", Offset = "0x25AB2C0", VA = "0x1825AC0C0")]
	public static PFLNKKCOAHI<TGetDataArg, TData> FJAAFKPDAIA<TGetDataArg, TData>(AJPKAMNMEFA<TGetDataArg, TData> HDLOJHGAFKF)
	{
		return default(PFLNKKCOAHI<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public struct DMFAPLFEJDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public readonly int IDKDFLHMDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public readonly int? JFHBOLOLMPM;

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x42359A0", Offset = "0x4234BA0", VA = "0x1842359A0")]
	public DMFAPLFEJDL(int DMNHBMODOKL, [Optional] int? GCKKBDHCMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x6FA5CF0", Offset = "0x6FA4EF0", VA = "0x186FA5CF0", Slot = "3")]
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
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x600041C")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
			public MPPKJNJLOMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x852300", VA = "0x180853100")]
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
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public JDBCODNMCIB<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
			public GFLEGAPCNMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x3CC7D60", Offset = "0x3CC6F60", VA = "0x183CC7D60")]
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
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public AEDEDFOFFNI<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
			public CBBBBKGMMHJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x3CC7D60", Offset = "0x3CC6F60", VA = "0x183CC7D60")]
			internal int AHKCBDHMIOL(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private readonly IHBKKNBOOHI CLJOHLGPPOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private readonly Type IMEKHFCCHIC;

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x510A360", Offset = "0x5109560", VA = "0x18510A360")]
		internal CFDPBBOJKIG(IHBKKNBOOHI CLJOHLGPPOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x510A330", Offset = "0x5109530", VA = "0x18510A330", Slot = "4")]
		public void OINJEINMHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x5109F80", Offset = "0x5109180", VA = "0x185109F80", Slot = "5")]
		public GELBFHCOJFD<T> CLBDCAFDKCH(string MCMGPBCLOFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x510A1D0", Offset = "0x51093D0", VA = "0x18510A1D0", Slot = "6")]
		public GELBFHCOJFD<T> KDEBJKOOMCC(JDBCODNMCIB<T> LCPNIJPJAFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x510A2F0", Offset = "0x51094F0", VA = "0x18510A2F0", Slot = "7")]
		public GELBFHCOJFD<T> NLHHLJDJCBO(int LBJMNCMBNEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x510A0A0", Offset = "0x51092A0", VA = "0x18510A0A0", Slot = "8")]
		public GELBFHCOJFD<T> IJKKFEMOKBM(int LBJMNCMBNEA, AEDEDFOFFNI<T> NOBJBDLNLFJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	private class KOEBFDPLEJD<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private bool FFOHEMPBHFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private readonly List<Type> NGEAFLHHKLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private readonly Dictionary<Type, TVal> OAHIBPPNLJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private readonly Dictionary<Type, int> IDPHGIDLAFM;

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public IReadOnlyList<Type> KMDBOACGJPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x41CDDA0", Offset = "0x41CCFA0", VA = "0x1841CDDA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x41CE2C0", Offset = "0x41CD4C0", VA = "0x1841CE2C0")]
		public KOEBFDPLEJD(Dictionary<Type, int> IDPHGIDLAFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x41CE0F0", Offset = "0x41CD2F0", VA = "0x1841CE0F0")]
		public void PBLNBBGFGAP(Type NDDCLPHCEEO, TVal GPBAFILNEOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x41CDD00", Offset = "0x41CCF00", VA = "0x1841CDD00")]
		public bool BPELFEMFLPO(Type IMEKHFCCHIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x41CDD50", Offset = "0x41CCF50", VA = "0x1841CDD50")]
		public bool ODHBLCILLBD(TVal JMDCGOKJIDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x3818FF0", Offset = "0x38181F0", VA = "0x183818FF0")]
		public TVal JMJOGDIBBHK(Type NCMHJNKFAGH)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x41CDF00", Offset = "0x41CD100", VA = "0x1841CDF00")]
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
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private DMFAPLFEJDL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public IHBKKNBOOHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private IEnumerator<DMFAPLFEJDL> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		private DMFAPLFEJDL System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0x38725D0", Offset = "0x38717D0", VA = "0x1838725D0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6FB4F90", Offset = "0x6FB4190", VA = "0x186FB4F90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x89FB40", Offset = "0x89ED40", VA = "0x18089FB40")]
		[DebuggerHidden]
		public LPDINAJEIDJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x6FB4FE0", Offset = "0x6FB41E0", VA = "0x186FB4FE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x6FB49D0", Offset = "0x6FB3BD0", VA = "0x186FB49D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x6FB4930", Offset = "0x6FB3B30", VA = "0x186FB4930")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x6FB4980", Offset = "0x6FB3B80", VA = "0x186FB4980")]
		private void KNPOGHPBEEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x6FB4F40", Offset = "0x6FB4140", VA = "0x186FB4F40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x6FB4E80", Offset = "0x6FB4080", VA = "0x186FB4E80", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DMFAPLFEJDL> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x6FB4E80", Offset = "0x6FB4080", VA = "0x186FB4E80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private static readonly DMFAPLFEJDL APAMOKNFMBP;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private static readonly Dictionary<Type, int> PGDMJOGFKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private readonly HashSet<Type> FJJOEDGBJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private readonly KOEBFDPLEJD<int> AHFAEBADILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private readonly KOEBFDPLEJD<KGDFGPEJPLO> NOHDKOFPDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private readonly KOEBFDPLEJD<IBHPDOJEFBA> LDONPMDMNCJ;

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x6FABC90", Offset = "0x6FAAE90", VA = "0x186FABC90")]
	[GDGALFJPCGE(JMIPDAHBNNG.GameOnly)]
	private static void ECBJKBNABGH(INCIOHANCNE LDLMDJOAIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x6FAC9B0", Offset = "0x6FABBB0", VA = "0x186FAC9B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public IHBKKNBOOHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E440", Offset = "0x2B6D640", VA = "0x182B6E440", Slot = "4")]
	public GELBFHCOJFD<T> PNCFFJHHHNH<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x6FABD00", Offset = "0x6FAAF00", VA = "0x186FABD00", Slot = "5")]
	public LMAFCMMDBNJ EJIBLCEFOHJ(Exception PBAHBFAICPK)
	{
		return default(LMAFCMMDBNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x6FAC600", Offset = "0x6FAB800", VA = "0x186FAC600", Slot = "6")]
	public DMFAPLFEJDL LKHKMCHILPP(Exception? PBAHBFAICPK)
	{
		return default(DMFAPLFEJDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x6FAC560", Offset = "0x6FAB760", VA = "0x186FAC560", Slot = "7")]
	[IteratorStateMachine(typeof(LPDINAJEIDJ))]
	public IEnumerable<DMFAPLFEJDL> KBJJLCOLOEN(Exception PBAHBFAICPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x6FAC410", Offset = "0x6FAB610", VA = "0x186FAC410", Slot = "8")]
	public string JOIGGINBEEN(Exception? PBAHBFAICPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB5B0", Offset = "0x6FAA7B0", VA = "0x186FAB5B0")]
	private string CNHALHKGOCF(AggregateException LOEKHCMHBEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x6FABD90", Offset = "0x6FAAF90", VA = "0x186FABD90")]
	private void IHEDAKLCGNP(Type IMEKHFCCHIC, int LBJMNCMBNEA, KGDFGPEJPLO? OFELHHJPODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x6FABA40", Offset = "0x6FAAC40", VA = "0x186FABA40")]
	private void DMILLEEEOCG(Type IMEKHFCCHIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x6FAC140", Offset = "0x6FAB340", VA = "0x186FAC140")]
	private void ILLEOJDGNAJ(Type IMEKHFCCHIC, IBHPDOJEFBA OEGEKJOGIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB8C0", Offset = "0x6FAAAC0", VA = "0x186FAB8C0")]
	private static int DALIPMEINOJ(Type IMEKHFCCHIC, Dictionary<Type, int> IDPHGIDLAFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x2B92170", Offset = "0x2B91370", VA = "0x182B92170")]
	private static bool AKKNKPDDGNK<TVal>(KOEBFDPLEJD<TVal> MNHECFLLMJH, Type IMEKHFCCHIC, [Out] TVal JMDCGOKJIDA) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x6FAC800", Offset = "0x6FABA00", VA = "0x186FAC800")]
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
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public readonly DMFAPLFEJDL CAEPJNKNMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public readonly string JCDCACKMBMN;

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x6FB48B0", Offset = "0x6FB3AB0", VA = "0x186FB48B0")]
	public LMAFCMMDBNJ(string KMIMCLPDKGD, DMFAPLFEJDL LBJMNCMBNEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4810", Offset = "0x6FB3A10", VA = "0x186FB4810")]
	public string HGKGFJHHKFM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class BOAMHEKDIOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private readonly ACFAMDNJIMF HOFJLGDPOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private string IHALHOEJCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private long? JKAIGOMEDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private long? GDGAGLKACJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private long? MMKGMIIENIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private string FCNEGMPAAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private BAEGFPFJEKP DDIJAKOKPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private long? CDPILCBBCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private bool IBOMEKKHAFM;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public string ALLCOBLMNJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public long HOBGBCGFHFI
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x6FA1FC0", Offset = "0x6FA11C0", VA = "0x186FA1FC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public long JGPHNMFFODD
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x6FA1F20", Offset = "0x6FA1120", VA = "0x186FA1F20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public long KKBFFPMLMEA
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x6FA1910", Offset = "0x6FA0B10", VA = "0x186FA1910")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public string AAIIPJLPFIF
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x6FA1F80", Offset = "0x6FA1180", VA = "0x186FA1F80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public BAEGFPFJEKP JHHDEGHBEOG
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0xA62DA0", Offset = "0xA61FA0", VA = "0x180A62DA0")]
		get
		{
			return default(BAEGFPFJEKP);
		}
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x6FA11F0", Offset = "0x6FA03F0", VA = "0x186FA11F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public long DJJKHHEPNFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x6FA1530", Offset = "0x6FA0730", VA = "0x186FA1530")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x6FA2020", Offset = "0x6FA1220", VA = "0x186FA2020")]
	[UnityEngine.Scripting.Preserve]
	public BOAMHEKDIOK([OMAPKKAGFIL(null)] ACFAMDNJIMF HOFJLGDPOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x6FA12E0", Offset = "0x6FA04E0", VA = "0x186FA12E0")]
	private void DADNIIDGHDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x6FA1A90", Offset = "0x6FA0C90", VA = "0x186FA1A90")]
	public void HNFDEIEALJH(long DIMOGDCMBFM, long MMMJFAODPOA, [Optional] long? LMGCMDBJBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x6FA1970", Offset = "0x6FA0B70", VA = "0x186FA1970")]
	public void GANGAAPLNMJ(long LMGCMDBJBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x6FA1A10", Offset = "0x6FA0C10", VA = "0x186FA1A10")]
	public void HEMIGHIOIDD(string KNBLDALGCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x6FA1590", Offset = "0x6FA0790", VA = "0x186FA1590")]
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
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public AsyncTaskMethodBuilder<JHHNPEBPLNM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public JHHNPEBPLNM roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public AOOKNBGCDKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private TaskAwaiter<AGBLOFNHMNJ.CBEFFACDNLD<JHHNPEBPLNM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x6FC9630", Offset = "0x6FC8830", VA = "0x186FC9630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x6FC9A30", Offset = "0x6FC8C30", VA = "0x186FC9A30", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class BMODCBKEGML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public JHHNPEBPLNM roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public BMODCBKEGML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x6FBDD90", Offset = "0x6FBCF90", VA = "0x186FBDD90")]
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
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public AsyncTaskMethodBuilder<AGBLOFNHMNJ.CBEFFACDNLD<JHHNPEBPLNM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public JHHNPEBPLNM roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public AOOKNBGCDKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private NLAOPAEBMHG <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private TaskAwaiter<AGBLOFNHMNJ.CBEFFACDNLD<JHHNPEBPLNM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7690", Offset = "0x6FC6890", VA = "0x186FC7690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7CA0", Offset = "0x6FC6EA0", VA = "0x186FC7CA0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public AOOKNBGCDKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x3C9D430", Offset = "0x3C9C630", VA = "0x183C9D430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x357EAF0", Offset = "0x357DCF0", VA = "0x18357EAF0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public AOOKNBGCDKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x6FBDE70", Offset = "0x6FBD070", VA = "0x186FBDE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x6FBE030", Offset = "0x6FBD230", VA = "0x186FBE030", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public CPDJCELNHOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0880", Offset = "0x6FBFA80", VA = "0x186FC0880")]
		internal object PKEABFDGAOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC07C0", Offset = "0x6FBF9C0", VA = "0x186FC07C0")]
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
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public BBGEFFFEFOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x6FBDD30", Offset = "0x6FBCF30", VA = "0x186FBDD30")]
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
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public GHHOMEAANDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5420", Offset = "0x6FC4620", VA = "0x186FC5420")]
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
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public PCPBAOOGHNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3AF0", Offset = "0x6FD2CF0", VA = "0x186FD3AF0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public AOOKNBGCDKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public KPHLNIHJFCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA590", Offset = "0x6FC9790", VA = "0x186FCA590")]
		internal object BJKIKAPFGMG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private static readonly Guid BEKJIAKMEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public readonly LDOGEOGHOLH PCEFFCPFNFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private readonly AGBLOFNHMNJ IMDHKLFLDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private readonly NCHALEHKFGO FAELELHBKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private readonly GCDIDGMHHIJ AKOFEJNHKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private bool AEJLHEPPBCK;

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x6FA01A0", Offset = "0x6F9F3A0", VA = "0x186FA01A0")]
	public AOOKNBGCDKI(LDOGEOGHOLH PADMFCNKGOL, AGBLOFNHMNJ IMDHKLFLDMB, NCHALEHKFGO FAELELHBKKO, GCDIDGMHHIJ AKOFEJNHKBC, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x6F9F2E0", Offset = "0x6F9E4E0", VA = "0x186F9F2E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x6F9F2E0", Offset = "0x6F9E4E0", VA = "0x186F9F2E0")]
	public void AJOKGMMPOJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x6F9F9A0", Offset = "0x6F9EBA0", VA = "0x186F9F9A0")]
	public void JCEFFGDJBNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x6F9FA60", Offset = "0x6F9EC60", VA = "0x186F9FA60")]
	public void MAOAFACFAFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x6F9F480", Offset = "0x6F9E680", VA = "0x186F9F480")]
	[AsyncStateMachine(typeof(INNEMEINFPB))]
	internal Task<JHHNPEBPLNM> HCJJGKLKHFP(OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, JHHNPEBPLNM PIHNIIFANNM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x31EBB30", Offset = "0x31EAD30", VA = "0x1831EBB30")]
	private static byte[] FIKACFFPBMG<T>(T JNNDBFGKHHD) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x31EB9E0", Offset = "0x31EABE0", VA = "0x1831EB9E0")]
	private static T DNGMAFHHGNP<T>(MessageParser<T> KPNGFFCGGHG, byte[] JNNDBFGKHHD, T NKOKHDBOMFH) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x6F9FFF0", Offset = "0x6F9F1F0", VA = "0x186F9FFF0")]
	[AsyncStateMachine(typeof(HGDBNNCOFFP))]
	private Task<AGBLOFNHMNJ.CBEFFACDNLD<JHHNPEBPLNM>> PEFHAMFAMDM(JHHNPEBPLNM PIHNIIFANNM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x31EBC30", Offset = "0x31EAE30", VA = "0x1831EBC30")]
	[AsyncStateMachine(typeof(AODMDECPDFP<>))]
	internal Task<T> OLKFELFFMLH<T>(CancellationToken LJPECIOGMKH, Func<CancellationToken, Task<T>> KFEIMOJODHF, int EFINHJDBJEF = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x6F9FDB0", Offset = "0x6F9EFB0", VA = "0x186F9FDB0")]
	[AsyncStateMachine(typeof(CBECGODNOOF))]
	internal Task OLKFELFFMLH(CancellationToken LJPECIOGMKH, Func<CancellationToken, Task> KFEIMOJODHF, int EFINHJDBJEF = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x6F9F400", Offset = "0x6F9E600", VA = "0x186F9F400")]
	public IOFNMIAGIID GGKOPJBIDKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x6F9F260", Offset = "0x6F9E460", VA = "0x186F9F260")]
	public PCJKPFOHLAA AGADJBPJNGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x6F9F6F0", Offset = "0x6F9E8F0", VA = "0x186F9F6F0")]
	public OPPOPKDPFEJ IKFHFHLENCI([Optional] CDLNJDLNIPA? KBNCOADBJAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x6F9F840", Offset = "0x6F9EA40", VA = "0x186F9F840")]
	public void IMLNJALHMII(Func<Guid, bool> BMMICOLDKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x6F9FEE0", Offset = "0x6F9F0E0", VA = "0x186F9FEE0")]
	public void PCHMJOPDGHI(Func<Guid, bool> CJBGLKIMAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x6F9FC30", Offset = "0x6F9EE30", VA = "0x186F9FC30")]
	public Guid OCDKPEAMHIM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x6F9F5E0", Offset = "0x6F9E7E0", VA = "0x186F9F5E0")]
	public void HJOMCJIKAEL(Guid LJBACHIBEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x6F9F120", Offset = "0x6F9E320", VA = "0x186F9F120")]
	public void ABMKFOJDGKE(JHHNPEBPLNM JBBIODKBMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x6F9FB20", Offset = "0x6F9ED20", VA = "0x186F9FB20")]
	public void MGFMJHPPHBP(string FNOGOHPEEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x31EBB40", Offset = "0x31EAD40", VA = "0x1831EBB40")]
	private T FPAIGDJBKKJ<T>(T JMDCGOKJIDA) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x6F9F0D0", Offset = "0x6F9E2D0", VA = "0x186F9F0D0")]
	public void ABCHJAIGKJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x31EB730", Offset = "0x31EA930", VA = "0x1831EB730")]
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
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public KNLIJFAPCJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA520", Offset = "0x6FC9720", VA = "0x186FCA520")]
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
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public HCHMJJACOEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private PEJDDGDCLFF <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private PCJKPFOHLAA <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5490", Offset = "0x6FC4690", VA = "0x186FC5490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5D60", Offset = "0x6FC4F60", VA = "0x186FC5D60", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public HCHMJJACOEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private bool <omIsEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private bool <omShouldBeEnabled>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private TaskAwaiter<FLKIEPIEFEG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private TaskAwaiter<byte> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x6FCEFB0", Offset = "0x6FCE1B0", VA = "0x186FCEFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x6FCF760", Offset = "0x6FCE960", VA = "0x186FCF760", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public HCHMJJACOEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private TaskAwaiter<HNKJBJIHEKD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x6FCCEA0", Offset = "0x6FCC0A0", VA = "0x186FCCEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x6FCD1B0", Offset = "0x6FCC3B0", VA = "0x186FCD1B0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public PEJDDGDCLFF presence;

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public NCJIGLGCJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x6FCF8C0", Offset = "0x6FCEAC0", VA = "0x186FCF8C0")]
		internal object IFJABCIFOFP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	private static readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	private static readonly CDLNJDLNIPA KBKNHCEIBOM;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	private static readonly CDLNJDLNIPA HGNMKAKPHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000387")]
	private readonly JBBIANFGILF KLNKIGMCCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000388")]
	private readonly MDBDBMHCDOA EJBBNMBAICD;

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7500", Offset = "0x6FC6700", VA = "0x186FC7500")]
	public HCHMJJACOEA(JBBIANFGILF KLNKIGMCCKO, MDBDBMHCDOA EJBBNMBAICD, Guid KPMGFINBLBG, PNHFEHLPHMO KBCJMHHCDBC, NOCKKKPBJAK HEBPMOPIKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7100", Offset = "0x6FC6300", VA = "0x186FC7100", Slot = "7")]
	[AsyncStateMachine(typeof(GKDPGBPONGJ))]
	protected override Task JHJGIGBBDDE(AOOKNBGCDKI HOBEPAEHHJL, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7000", Offset = "0x6FC6200", VA = "0x186FC7000")]
	[AsyncStateMachine(typeof(NAMIDAAADBH))]
	private Task GBOPJINFEFP(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x6FC6EF0", Offset = "0x6FC60F0", VA = "0x186FC6EF0")]
	[AsyncStateMachine(typeof(MBGDJCBHEPM))]
	private Task<byte> DGOHIDEKAID(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7240", Offset = "0x6FC6440", VA = "0x186FC7240")]
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
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public OCGMAIALJEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private TaskAwaiter<BMBMOGELPMJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0C50", Offset = "0x6FBFE50", VA = "0x186FC0C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x6FC15D0", Offset = "0x6FC07D0", VA = "0x186FC15D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	private readonly int LICNBNKOLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	private readonly NCKGPLMHNNB NHABHPPMDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public readonly long GKKIJACBHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public readonly long PAFDFFODJEJ;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public BMBMOGELPMJ OJOBEJNECJD
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x85FE70", Offset = "0x85F070", VA = "0x18085FE70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x85FEB0", Offset = "0x85F0B0", VA = "0x18085FEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x6FCFB20", Offset = "0x6FCED20", VA = "0x186FCFB20")]
	public OCGMAIALJEA(Guid KPMGFINBLBG, PNHFEHLPHMO KBCJMHHCDBC, NOCKKKPBJAK HEBPMOPIKJB, int LICNBNKOLEM, NCKGPLMHNNB NHABHPPMDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x6FCFA00", Offset = "0x6FCEC00", VA = "0x186FCFA00", Slot = "7")]
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
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public HPMIHEBMPKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public IGNOJPABBPI playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public DCDAHHDPJDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0970", Offset = "0x6FBFB70", VA = "0x186FC0970")]
		internal Task IFGJHLKGBCL(OADONCMLPJG<string>.HILOONJJDHL postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x6FC08E0", Offset = "0x6FBFAE0", VA = "0x186FC08E0")]
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
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public HPMIHEBMPKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private DCDAHHDPJDE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x6FCD220", Offset = "0x6FCC420", VA = "0x186FCD220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x6FCD9E0", Offset = "0x6FCCBE0", VA = "0x186FCD9E0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public IGNOJPABBPI playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public HPMIHEBMPKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x6FCE9C0", Offset = "0x6FCDBC0", VA = "0x186FCE9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x6FCEF50", Offset = "0x6FCE150", VA = "0x186FCEF50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7F90", Offset = "0x6FC7190", VA = "0x186FC7F90")]
	public HPMIHEBMPKI(Guid KPMGFINBLBG, PNHFEHLPHMO KBCJMHHCDBC, NOCKKKPBJAK HEBPMOPIKJB, string JHNINBLPPLN, EFBCINIABEJ LJJJHDHDDOO, bool BGLMCDKAHBI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7D10", Offset = "0x6FC6F10", VA = "0x186FC7D10", Slot = "7")]
	[AsyncStateMachine(typeof(MFCKACCHCKK))]
	protected override Task JHJGIGBBDDE(AOOKNBGCDKI HOBEPAEHHJL, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task POFDJKAPCLA(AOOKNBGCDKI HOBEPAEHHJL, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7E50", Offset = "0x6FC7050", VA = "0x186FC7E50")]
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
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public DDDDOLJAOHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private TaskAwaiter<JBBKCFOEFFA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6240", Offset = "0x6FC5440", VA = "0x186FC6240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x6FC67B0", Offset = "0x6FC59B0", VA = "0x186FC67B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private readonly HCEEFOPOCMM LKIPKDFOIKO;

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0BB0", Offset = "0x6FBFDB0", VA = "0x186FC0BB0")]
	public DDDDOLJAOHE(Guid KPMGFINBLBG, PNHFEHLPHMO KBCJMHHCDBC, NOCKKKPBJAK HEBPMOPIKJB, HCEEFOPOCMM LKIPKDFOIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x6FC09B0", Offset = "0x6FBFBB0", VA = "0x186FC09B0", Slot = "6")]
	protected override string BJAGFHJFAKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0A90", Offset = "0x6FBFC90", VA = "0x186FC0A90", Slot = "7")]
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
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public OADONCMLPJG<string>.HILOONJJDHL operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public LDOGEOGHOLH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public PAODNFLLCBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x6FD1110", Offset = "0x6FD0310", VA = "0x186FD1110")]
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
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public PAODNFLLCBK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public LOPMMGFHAFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x6FCCDE0", Offset = "0x6FCBFE0", VA = "0x186FCCDE0")]
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
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public LDOGEOGHOLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public Func<LDOGEOGHOLH, OADONCMLPJG<string>.HILOONJJDHL, AOOKNBGCDKI> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private PAODNFLLCBK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private AOOKNBGCDKI <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x6FBE860", Offset = "0x6FBDA60", VA = "0x186FBE860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF960", Offset = "0x6FBEB60", VA = "0x186FBF960", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1630", Offset = "0x6FC0830", VA = "0x186FC1630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x6FC20C0", Offset = "0x6FC12C0", VA = "0x186FC20C0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public LDOGEOGHOLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x6FCCA20", Offset = "0x6FCBC20", VA = "0x186FCCA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x6FCCD80", Offset = "0x6FCBF80", VA = "0x186FCCD80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public readonly Guid BCGKIOLOHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public readonly ByteString GKEIIDKFDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public readonly NOCKKKPBJAK LOICDGCIEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	protected readonly string FLBAFFCOAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	private readonly PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	private readonly bool BGLMCDKAHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private readonly Queue<HCBHHAMMKNH> BDIHHCCEHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	private readonly NKKKGGINLEP NKGDDIPPMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private readonly EFBCINIABEJ LJJJHDHDDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private bool OHAODFIPPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public BAEGFPFJEKP BKNLBEKNLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public BAEGFPFJEKP GBFDEOMKNOD;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public PNHFEHLPHMO NOOCLICDJJM
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x856960", Offset = "0x855B60", VA = "0x180856960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public MFEINKDLEHJ KFKHEOKCKBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x6FCC0C0", Offset = "0x6FCB2C0", VA = "0x186FCC0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public INNHEOLIKBM MDBMBBPHIBI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x6FCBF60", Offset = "0x6FCB160", VA = "0x186FCBF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public FFAMIDMIBLK HFPCNNCNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x6FCC500", Offset = "0x6FCB700", VA = "0x186FCC500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event KPJCHGMHNOH ODCPIOEPMDN
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x6FCBE00", Offset = "0x6FCB000", VA = "0x186FCBE00", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x6FCBDE0", Offset = "0x6FCAFE0", VA = "0x186FCBDE0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC6C0", Offset = "0x6FCB8C0", VA = "0x186FCC6C0")]
	protected LDOGEOGHOLH(Guid KPMGFINBLBG, PNHFEHLPHMO KBCJMHHCDBC, NOCKKKPBJAK HEBPMOPIKJB, string JHNINBLPPLN, EFBCINIABEJ LJJJHDHDDOO, bool BGLMCDKAHBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x6FCBE20", Offset = "0x6FCB020", VA = "0x186FCBE20", Slot = "6")]
	protected virtual string BJAGFHJFAKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC240", Offset = "0x6FCB440", VA = "0x186FCC240")]
	public void JPMIMBKPEIM(HCBHHAMMKNH LDEAEONJEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC580", Offset = "0x6FCB780", VA = "0x186FCC580")]
	protected void PABDMJKMPLE(float MPPCPDMLBPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x6FCBC90", Offset = "0x6FCAE90", VA = "0x186FCBC90")]
	[AsyncStateMachine(typeof(CFNFIENGDPN))]
	public Task AGALHLJOLPH(CancellationToken MPLGBOFHPLM, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, [Optional] Func<LDOGEOGHOLH, OADONCMLPJG<string>.HILOONJJDHL, AOOKNBGCDKI> ECLLCEGPBIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC110", Offset = "0x6FCB310", VA = "0x186FCC110")]
	[AsyncStateMachine(typeof(DLAJNJNLAHH))]
	private static Task GOMBJKCFMGA(Func<CancellationToken, Task> HBLGMBBHCGK, Func<CancellationToken, Task> MOPPHNLDCLD, CancellationToken LJPECIOGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC390", Offset = "0x6FCB590", VA = "0x186FCC390")]
	private void MKFHGECMKHH(bool NPCJOOKKGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x6FCBFB0", Offset = "0x6FCB1B0", VA = "0x186FCBFB0")]
	private void EPEAKBDMGAD(AOOKNBGCDKI HOBEPAEHHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task JHJGIGBBDDE(AOOKNBGCDKI HOBEPAEHHJL, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC5A0", Offset = "0x6FCB7A0", VA = "0x186FCC5A0")]
	[AsyncStateMachine(typeof(LFPACHJBKCH))]
	private Task PDGFBOGPEFA(OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x6FCBE60", Offset = "0x6FCB060", VA = "0x186FCBE60")]
	public JHHNPEBPLNM BOKPFNOKGEP(NLAOPAEBMHG GOCKGMEMPGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC2A0", Offset = "0x6FCB4A0", VA = "0x186FCC2A0")]
	[CompilerGenerated]
	private Task LFABIFBOKFH(CancellationToken DOGPFNGIKMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x6FCBEE0", Offset = "0x6FCB0E0", VA = "0x186FCBEE0")]
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
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public OJHFPGDNLEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private BIDJCBPPELH <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private PCJKPFOHLAA <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x6FBE090", Offset = "0x6FBD290", VA = "0x186FBE090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x6FBE800", Offset = "0x6FBDA00", VA = "0x186FBE800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	private readonly JBBIANFGILF GDGGKBKMAFL;

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x6FCFDA0", Offset = "0x6FCEFA0", VA = "0x186FCFDA0")]
	public OJHFPGDNLEK(Guid KPMGFINBLBG, PNHFEHLPHMO KBCJMHHCDBC, JBBIANFGILF GDGGKBKMAFL, NOCKKKPBJAK HEBPMOPIKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x6FCFC50", Offset = "0x6FCEE50", VA = "0x186FCFC50", Slot = "8")]
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
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public JKIDNJAJEEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private TaskAwaiter<JBBKCFOEFFA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA110", Offset = "0x6FC9310", VA = "0x186FCA110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA4C0", Offset = "0x6FC96C0", VA = "0x186FCA4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	private readonly string FCDJJHECOOP;

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x6FCA060", Offset = "0x6FC9260", VA = "0x186FCA060")]
	public JKIDNJAJEEP(Guid KPMGFINBLBG, PNHFEHLPHMO KBCJMHHCDBC, NOCKKKPBJAK HEBPMOPIKJB, string FCDJJHECOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x6FC9F50", Offset = "0x6FC9150", VA = "0x186FC9F50", Slot = "7")]
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
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			public AsyncTaskMethodBuilder<JHHNPEBPLNM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			public CLPKMFFCLKJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			private TaskAwaiter<JBBKCFOEFFA> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400041B")]
			private TaskAwaiter<JHHNPEBPLNM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0x6FD5610", Offset = "0x6FD4810", VA = "0x186FD5610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x6FD5AD0", Offset = "0x6FD4CD0", VA = "0x186FD5AD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public PCLJEAAOENH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public OPPOPKDPFEJ serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public LEBMOIGALED roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public IOFNMIAGIID uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public JJNDGMFMLEH roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public CLPKMFFCLKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x6FBFCC0", Offset = "0x6FBEEC0", VA = "0x186FBFCC0")]
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
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public PCLJEAAOENH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private CLPKMFFCLKJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private BIDJCBPPELH <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private PCJKPFOHLAA <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private JHHNPEBPLNM <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4460", Offset = "0x6FC3660", VA = "0x186FC4460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x6FC53C0", Offset = "0x6FC45C0", VA = "0x186FC53C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	private static readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	private static readonly CDLNJDLNIPA KBKNHCEIBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private readonly int HDFLMOLOCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	[CanBeNull]
	private readonly KAIMFMKFBCK BJEDAIHNLGI;

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3A40", Offset = "0x6FD2C40", VA = "0x186FD3A40")]
	public PCLJEAAOENH(Guid KPMGFINBLBG, PNHFEHLPHMO KBCJMHHCDBC, int HDFLMOLOCCD, KAIMFMKFBCK BJEDAIHNLGI, NOCKKKPBJAK HEBPMOPIKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3850", Offset = "0x6FD2A50", VA = "0x186FD3850", Slot = "8")]
	[AsyncStateMachine(typeof(FKBAGLHKNBF))]
	protected override Task POFDJKAPCLA(AOOKNBGCDKI HOBEPAEHHJL, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3750", Offset = "0x6FD2950", VA = "0x186FD3750")]
	private void MGJCDPIEIGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3580", Offset = "0x6FD2780", VA = "0x186FD3580")]
	private void BJOHILFKCOL(OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, BIDJCBPPELH NMJHAGKCPPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal abstract class ONKMEGIFDPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public readonly LDOGEOGHOLH PCEFFCPFNFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public readonly AOOKNBGCDKI BMIIBEBGCLJ;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public MFEINKDLEHJ KFKHEOKCKBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x6FD0FB0", Offset = "0x6FD01B0", VA = "0x186FD0FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public FFAMIDMIBLK HFPCNNCNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x6FD1020", Offset = "0x6FD0220", VA = "0x186FD1020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x6FD10B0", Offset = "0x6FD02B0", VA = "0x186FD10B0")]
	protected ONKMEGIFDPF(AOOKNBGCDKI HOBEPAEHHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x6FD1000", Offset = "0x6FD0200", VA = "0x186FD1000")]
	protected void MGFMJHPPHBP(string FNOGOHPEEJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal struct IDOKGAKHACO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public Dictionary<Guid, List<CNEDOEIINNH>> KOHNICGLMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public Dictionary<Guid, List<CNEDOEIINNH>> BMCMDODEBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public Dictionary<Guid, List<CNEDOEIINNH>> FDEADOOLGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public List<Guid> OINPNKLHCDN;

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7FE0", Offset = "0x6FC71E0", VA = "0x186FC7FE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030")]
	public static AOHLCIPIPLB JGIIBNEOBDO()
	{
		return default(AOHLCIPIPLB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal struct JHNAMKCFCAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public readonly FLKIEPIEFEG ECCIBCDNFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public readonly HCDOMJKEJGM BPKLHPPCKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public readonly string EEPCKBDHEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public readonly KEOGFOOKLEH BIOFMAGLAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public readonly KEOGFOOKLEH PNMECAEFMNK;

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x6FC9D20", Offset = "0x6FC8F20", VA = "0x186FC9D20")]
	public JHNAMKCFCAD(FLKIEPIEFEG ECCIBCDNFPF, HCDOMJKEJGM BPKLHPPCKJK, string EEPCKBDHEGC, KEOGFOOKLEH BIOFMAGLAJN, KEOGFOOKLEH PNMECAEFMNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal struct JIEDHIIBLJD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	private readonly AOOKNBGCDKI HOBEPAEHHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	private readonly Guid LJBACHIBEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	private bool NPCJOOKKGED;

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x6FC9EA0", Offset = "0x6FC90A0", VA = "0x186FC9EA0")]
	public static JIEDHIIBLJD OCDKPEAMHIM(AOOKNBGCDKI HOBEPAEHHJL)
	{
		return default(JIEDHIIBLJD);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x98E140", Offset = "0x98D340", VA = "0x18098E140")]
	public void OKNOMJKMFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x6FC9DA0", Offset = "0x6FC8FA0", VA = "0x186FC9DA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x6FC9F00", Offset = "0x6FC9100", VA = "0x186FC9F00")]
	private JIEDHIIBLJD(AOOKNBGCDKI HOBEPAEHHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x6FC9DA0", Offset = "0x6FC8FA0", VA = "0x186FC9DA0")]
	private void HJOMCJIKAEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x6FC9E00", Offset = "0x6FC9000", VA = "0x186FC9E00")]
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
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public JBBIANFGILF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private JIEDHIIBLJD <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x6FD1240", Offset = "0x6FD0440", VA = "0x186FD1240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x6FD19B0", Offset = "0x6FD0BB0", VA = "0x186FD19B0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public AsyncTaskMethodBuilder<JHHNPEBPLNM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public JBBIANFGILF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private OADONCMLPJG<string>.HILOONJJDHL <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5DC0", Offset = "0x6FC4FC0", VA = "0x186FC5DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x6FC61D0", Offset = "0x6FC53D0", VA = "0x186FC61D0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public JBBIANFGILF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private OADONCMLPJG<string>.HILOONJJDHL <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC2120", Offset = "0x6FC1320", VA = "0x186FC2120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x6FC25B0", Offset = "0x6FC17B0", VA = "0x186FC25B0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public AsyncTaskMethodBuilder<JHNAMKCFCAD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			public PDLADLBEBGO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			private JHNAMKCFCAD <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			private TaskAwaiter<BAEGFPFJEKP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			private TaskAwaiter<JHNAMKCFCAD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x6FD40C0", Offset = "0x6FD32C0", VA = "0x186FD40C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0x6FD4850", Offset = "0x6FD3A50", VA = "0x186FD4850", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			public AsyncTaskMethodBuilder<BCCLEKKJGLB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			public PDLADLBEBGO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			private BCCLEKKJGLB <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			private TaskAwaiter<BAEGFPFJEKP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			private TaskAwaiter<BCCLEKKJGLB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000516")]
			[Cpp2IlInjected.Address(RVA = "0x6FD48C0", Offset = "0x6FD3AC0", VA = "0x186FD48C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0x6FD4F10", Offset = "0x6FD4110", VA = "0x186FD4F10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public JBBIANFGILF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public NKKKGGINLEP preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public NKKKGGINLEP downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public JHNAMKCFCAD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public NKKKGGINLEP postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public BCCLEKKJGLB phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public KGKIJLNHCBD.GNBOAEIMAME <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public PDLADLBEBGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3DE0", Offset = "0x6FD2FE0", VA = "0x186FD3DE0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<JHNAMKCFCAD> ICICOMFHDMM(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3B60", Offset = "0x6FD2D60", VA = "0x186FD3B60")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<BCCLEKKJGLB> BPBCMKLLFEP(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3F20", Offset = "0x6FD3120", VA = "0x186FD3F20")]
		internal void NGPFLDECLHP(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3F60", Offset = "0x6FD3160", VA = "0x186FD3F60")]
		internal Task PDLBOJJIBFL(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3C80", Offset = "0x6FD2E80", VA = "0x186FD3C80")]
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
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public JBBIANFGILF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private PDLADLBEBGO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private TaskAwaiter<JHNAMKCFCAD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private TaskAwaiter<BCCLEKKJGLB> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC36B0", Offset = "0x6FC28B0", VA = "0x186FC36B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4400", Offset = "0x6FC3600", VA = "0x186FC4400", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public BCCLEKKJGLB phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public NKKKGGINLEP postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private TaskAwaiter<BAEGFPFJEKP> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private FCPMHIPDGPA <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x6FCDA40", Offset = "0x6FCCC40", VA = "0x186FCDA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x6FCE960", Offset = "0x6FCDB60", VA = "0x186FCE960", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x6FCB380", Offset = "0x6FCA580", VA = "0x186FCB380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x6FCBC30", Offset = "0x6FCAE30", VA = "0x186FCBC30", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public NKKKGGINLEP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private OADONCMLPJG<string>.HILOONJJDHL <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		private TaskAwaiter<BAEGFPFJEKP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x6FBFDE0", Offset = "0x6FBEFE0", VA = "0x186FBFDE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0760", Offset = "0x6FBF960", VA = "0x186FC0760", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public AsyncTaskMethodBuilder<BAEGFPFJEKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public NKKKGGINLEP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private OADONCMLPJG<string>.HILOONJJDHL <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private TaskAwaiter<BAEGFPFJEKP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x6FC85F0", Offset = "0x6FC77F0", VA = "0x186FC85F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x6FC95C0", Offset = "0x6FC87C0", VA = "0x186FC95C0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public AsyncTaskMethodBuilder<BAEGFPFJEKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public NKKKGGINLEP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public FCPMHIPDGPA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private OADONCMLPJG<string>.HILOONJJDHL <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private TaskAwaiter<BAEGFPFJEKP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x6FCFE50", Offset = "0x6FCF050", VA = "0x186FCFE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x6FD0F40", Offset = "0x6FD0140", VA = "0x186FD0F40", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public AsyncTaskMethodBuilder<BAEGFPFJEKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public BAEGFPFJEKP operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public NKKKGGINLEP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public BCCLEKKJGLB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private TaskAwaiter<BAEGFPFJEKP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF9C0", Offset = "0x6FBEBC0", VA = "0x186FBF9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x6FBFC50", Offset = "0x6FBEE50", VA = "0x186FBFC50", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40004BE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004BF")]
			public AsyncTaskMethodBuilder<BAEGFPFJEKP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004C0")]
			public ELLBFHIMDKF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004C1")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C2")]
			private PHCOOIGGHEB <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004C3")]
			private TaskAwaiter<BAEGFPFJEKP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600052E")]
			[Cpp2IlInjected.Address(RVA = "0x6FD4F80", Offset = "0x6FD4180", VA = "0x186FD4F80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0x6FD55A0", Offset = "0x6FD47A0", VA = "0x186FD55A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public NKKKGGINLEP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public NBINIKGBAMA masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public FCPMHIPDGPA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public BAEGFPFJEKP originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public ELLBFHIMDKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3590", Offset = "0x6FC2790", VA = "0x186FC3590")]
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
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public AsyncTaskMethodBuilder<BAEGFPFJEKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public NKKKGGINLEP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public NBINIKGBAMA masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public FCPMHIPDGPA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private TaskAwaiter<BAEGFPFJEKP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD7C0", Offset = "0x6FBC9C0", VA = "0x186FBD7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x6FBDCC0", Offset = "0x6FBCEC0", VA = "0x186FBDCC0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public NKKKGGINLEP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private BAEGFPFJEKP <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private IEnumerator<BAEGFPFJEKP> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private TaskAwaiter<BAEGFPFJEKP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6810", Offset = "0x6FC5A10", VA = "0x186FC6810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6D40", Offset = "0x6FC5F40", VA = "0x186FC6D40", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x6FC9AA0", Offset = "0x6FC8CA0", VA = "0x186FC9AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x6FC9CC0", Offset = "0x6FC8EC0", VA = "0x186FC9CC0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x6FCC820", Offset = "0x6FCBA20", VA = "0x186FCC820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x6FCC9C0", Offset = "0x6FCBBC0", VA = "0x186FCC9C0", Slot = "5")]
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
		public BCCLEKKJGLB phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public NKKKGGINLEP postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private TaskAwaiter<BAEGFPFJEKP> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private FCPMHIPDGPA <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x6FC2610", Offset = "0x6FC1810", VA = "0x186FC2610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3530", Offset = "0x6FC2730", VA = "0x186FC3530", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public AsyncTaskMethodBuilder<BAEGFPFJEKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public PCJKPFOHLAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public NKKKGGINLEP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		private TaskAwaiter<BAEGFPFJEKP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA7E0", Offset = "0x6FC99E0", VA = "0x186FCA7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x6FCB310", Offset = "0x6FCA510", VA = "0x186FCB310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private readonly NKPKPHIMNEI KGJFAMAJCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private readonly NKPKPHIMNEI EMGIEIOJPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private readonly BOAMHEKDIOK CJHEFFFCIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	private readonly GNKDLDAAEML ANANAPJIBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	private readonly KKMJLGFKMCG HCBLCMEMNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private readonly NPFIODHPLCC BPNELNCMPID;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private PNHFEHLPHMO NOOCLICDJJM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x6FD1A50", Offset = "0x6FD0C50", VA = "0x186FD1A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event KPJCHGMHNOH ODCPIOEPMDN
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x6FD1A30", Offset = "0x6FD0C30", VA = "0x186FD1A30", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x6FD1A10", Offset = "0x6FD0C10", VA = "0x186FD1A10", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x6FD32E0", Offset = "0x6FD24E0", VA = "0x186FD32E0")]
	public PCJKPFOHLAA(AOOKNBGCDKI HOBEPAEHHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2680", Offset = "0x6FD1880", VA = "0x186FD2680")]
	[AsyncStateMachine(typeof(PAPDCCDMGAP))]
	public Task MCBFGPEMKEP(JBBIANFGILF GPCNCGBOPJG, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2EF0", Offset = "0x6FD20F0", VA = "0x186FD2EF0")]
	[AsyncStateMachine(typeof(GKKABENGFIE))]
	private Task<JHHNPEBPLNM> OKDGMCKAGJM(JBBIANFGILF GPCNCGBOPJG, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x6FD27D0", Offset = "0x6FD19D0", VA = "0x186FD27D0")]
	[AsyncStateMachine(typeof(EAPIFEMKFDL))]
	private Task MKAHEDDPJAI(JBBIANFGILF GPCNCGBOPJG, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x6FD1F50", Offset = "0x6FD1150", VA = "0x186FD1F50")]
	[AsyncStateMachine(typeof(EOENEDAMKMI))]
	private Task GEBJKNHIMMH(JBBIANFGILF GPCNCGBOPJG, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MJJIEGHIIHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x6FD23C0", Offset = "0x6FD15C0", VA = "0x186FD23C0")]
	[AsyncStateMachine(typeof(MGBEPLHGAGA))]
	private Task KDKEILCMNCL(BCCLEKKJGLB GGIEODBFCMI, NKKKGGINLEP DHKIHDFOOAK, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken CKBNFNEGPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3050", Offset = "0x6FD2250", VA = "0x186FD3050")]
	[AsyncStateMachine(typeof(LCKAIKKOOLC))]
	private Task PAAGKABCCEN(OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2C90", Offset = "0x6FD1E90", VA = "0x186FD2C90")]
	[AsyncStateMachine(typeof(CNOINGELDGB))]
	private Task NLNJAPLAEPE(BCCLEKKJGLB LINJEFIAFHO, NKKKGGINLEP CMNBDIJCHGE, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2510", Offset = "0x6FD1710", VA = "0x186FD2510")]
	[AsyncStateMachine(typeof(ILMIABPMMBI))]
	private Task<BAEGFPFJEKP> KODHAJDJLMP(BCCLEKKJGLB LINJEFIAFHO, FCPMHIPDGPA DPNAFHBKAFN, NKKKGGINLEP CMNBDIJCHGE, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3160", Offset = "0x6FD2360", VA = "0x186FD3160")]
	[AsyncStateMachine(typeof(OMKDNEKFPJM))]
	private Task<BAEGFPFJEKP> PDBHOJNDJEJ(BCCLEKKJGLB LINJEFIAFHO, FCPMHIPDGPA DPNAFHBKAFN, NKKKGGINLEP CMNBDIJCHGE, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x6FD20D0", Offset = "0x6FD12D0", VA = "0x186FD20D0")]
	[AsyncStateMachine(typeof(CHGKHEDHNMF))]
	private Task<BAEGFPFJEKP> JENLMPOBLMB(BAEGFPFJEKP MPMDJOHBDMD, BCCLEKKJGLB ODJOOIPMNML, NKKKGGINLEP CMNBDIJCHGE, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM, bool AMEECLKOLCO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2DE0", Offset = "0x6FD1FE0", VA = "0x186FD2DE0")]
	private bool NNBCAPFCHHL(BCCLEKKJGLB GGIEODBFCMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x6FD1DC0", Offset = "0x6FD0FC0", VA = "0x186FD1DC0")]
	[AsyncStateMachine(typeof(APINIADFKHM))]
	protected Task<BAEGFPFJEKP> GBKANPHFDEI(BCCLEKKJGLB LINJEFIAFHO, FCPMHIPDGPA DPNAFHBKAFN, NKKKGGINLEP CMNBDIJCHGE, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM, NBINIKGBAMA ODKHEHKDCDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2250", Offset = "0x6FD1450", VA = "0x186FD2250")]
	[AsyncStateMachine(typeof(GOJAOLOIPLE))]
	private Task JJLNAOANHOJ(BCCLEKKJGLB LINJEFIAFHO, NKKKGGINLEP CMNBDIJCHGE, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x6FD1A80", Offset = "0x6FD0C80", VA = "0x186FD1A80")]
	private void BLELCDJIOFC(BAEGFPFJEKP DGDNFAGKJJD, NKKKGGINLEP CMNBDIJCHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x6FD1D60", Offset = "0x6FD0F60", VA = "0x186FD1D60")]
	private void EMBFDJBDFFA(BAEGFPFJEKP KKHDHGEJOPN, [Out] BAEGFPFJEKP FFPMGCEAJOD, [Out] BAEGFPFJEKP KBNILNCJOBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2090", Offset = "0x6FD1290", VA = "0x186FD2090")]
	private Task<JHNAMKCFCAD> IBAFCNNGGBJ(JBBIANFGILF GPCNCGBOPJG, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2930", Offset = "0x6FD1B30", VA = "0x186FD2930")]
	private Task<BCCLEKKJGLB> NAEJOCDJHNH(JHNAMKCFCAD LINJEFIAFHO, KGKIJLNHCBD.GNBOAEIMAME KANAHIPJEKP, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x6FD1BC0", Offset = "0x6FD0DC0", VA = "0x186FD1BC0")]
	[AsyncStateMachine(typeof(JCOPCMMMMCB))]
	private Task DMFOCICFLCE(BCCLEKKJGLB LINJEFIAFHO, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM, bool DJDDDKCEKHP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x6FD1AD0", Offset = "0x6FD0CD0", VA = "0x186FD1AD0")]
	[AsyncStateMachine(typeof(LDPIIDMHAKH))]
	private Task DDPHFAPHNMD(BCCLEKKJGLB LINJEFIAFHO, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x6FD1D10", Offset = "0x6FD0F10", VA = "0x186FD1D10")]
	private Task EFGNAADJLFA(BCCLEKKJGLB LINJEFIAFHO, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2910", Offset = "0x6FD1B10", VA = "0x186FD2910")]
	private Task MKIEPGKEMCG(BCCLEKKJGLB LINJEFIAFHO, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x6FD1D40", Offset = "0x6FD0F40", VA = "0x186FD1D40")]
	private Task EJGFDNPNEIN(BCCLEKKJGLB LINJEFIAFHO, FCPMHIPDGPA DPNAFHBKAFN, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x6FD1DA0", Offset = "0x6FD0FA0", VA = "0x186FD1DA0")]
	private Task FALJJJKGMCC(BCCLEKKJGLB LINJEFIAFHO, FCPMHIPDGPA DPNAFHBKAFN, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2670", Offset = "0x6FD1870", VA = "0x186FD2670")]
	private static Task LNLKHCIOHAD(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2C70", Offset = "0x6FD1E70", VA = "0x186FD2C70")]
	private Task NKNNIBAMIAA(BCCLEKKJGLB LINJEFIAFHO, FCPMHIPDGPA DPNAFHBKAFN, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x6FD23A0", Offset = "0x6FD15A0", VA = "0x186FD23A0")]
	private Task KAKLPMDHELE(BCCLEKKJGLB LINJEFIAFHO, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2C20", Offset = "0x6FD1E20", VA = "0x186FD2C20")]
	private void NFEJECHCLPP(JBBIANFGILF GPCNCGBOPJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2ED0", Offset = "0x6FD20D0", VA = "0x186FD2ED0")]
	public void OAGKDLDDPPP(long LMGCMDBJBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
	private static void BMGKEDPPOFE(FLKIEPIEFEG ECCIBCDNFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2970", Offset = "0x6FD1B70", VA = "0x186FD2970")]
	[AsyncStateMachine(typeof(EDGELNDMKKJ))]
	private Task NDLPLKBKJDH(BCCLEKKJGLB GGIEODBFCMI, NKKKGGINLEP DHKIHDFOOAK, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken CKBNFNEGPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2AC0", Offset = "0x6FD1CC0", VA = "0x186FD2AC0")]
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
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private BCCLEKKJGLB LINJEFIAFHO;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private MFEINKDLEHJ KFKHEOKCKBP
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x6FE2F10", Offset = "0x6FE2110", VA = "0x186FE2F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x6FE2E30", Offset = "0x6FE2030", VA = "0x186FE2E30")]
	public static Task AGALHLJOLPH(PNHFEHLPHMO KBCJMHHCDBC, BCCLEKKJGLB LINJEFIAFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x6FE2C10", Offset = "0x6FE1E10", VA = "0x186FE2C10")]
	private void AGALHLJOLPH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct MBPCJJOAHBO
{
	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8CE0", Offset = "0x6FE7EE0", VA = "0x186FE8CE0")]
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
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private OADONCMLPJG<string>.HILOONJJDHL <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x6FDFFF0", Offset = "0x6FDF1F0", VA = "0x186FDFFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x6FE0510", Offset = "0x6FDF710", VA = "0x186FE0510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x6FDA800", Offset = "0x6FD9A00", VA = "0x186FDA800")]
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
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public FCPMHIPDGPA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private BAEGFPFJEKP <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private PNHFEHLPHMO <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private MFEINKDLEHJ <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private PHCOOIGGHEB <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private List<(PersistenceView, CLPMHIGOAIJ)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private CLPMHIGOAIJ <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5EB0", Offset = "0x6FD50B0", VA = "0x186FD5EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x6FD6B30", Offset = "0x6FD5D30", VA = "0x186FD6B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8990", Offset = "0x6FE7B90", VA = "0x186FE8990")]
	[AsyncStateMachine(typeof(ADBNHDLAKGC))]
	public static Task AGALHLJOLPH(AOOKNBGCDKI HOBEPAEHHJL, BCCLEKKJGLB LINJEFIAFHO, FCPMHIPDGPA DPNAFHBKAFN, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8AE0", Offset = "0x6FE7CE0", VA = "0x186FE8AE0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public PNHFEHLPHMO roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x6FE1F50", Offset = "0x6FE1150", VA = "0x186FE1F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x6FE2390", Offset = "0x6FE1590", VA = "0x186FE2390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE660", Offset = "0x6FED860", VA = "0x186FEE660")]
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
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public PNHFEHLPHMO roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x6FDABF0", Offset = "0x6FD9DF0", VA = "0x186FDABF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x6FDAE00", Offset = "0x6FDA000", VA = "0x186FDAE00", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400052C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400052D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400052E")]
			public OADONCMLPJG<string>.HILOONJJDHL timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400052F")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			public KANDKPKGKPJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000558")]
			[Cpp2IlInjected.Address(RVA = "0x6FEEC90", Offset = "0x6FEDE90", VA = "0x186FEEC90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000559")]
			[Cpp2IlInjected.Address(RVA = "0x6FEF020", Offset = "0x6FEE220", VA = "0x186FEF020", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public KANDKPKGKPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x6FE5610", Offset = "0x6FE4810", VA = "0x186FE5610")]
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
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public OJAPCCOPINI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x6FE5BD0", Offset = "0x6FE4DD0", VA = "0x186FE5BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6590", Offset = "0x6FE5790", VA = "0x186FE6590", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public CCFJLIPPODM version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public EGIGMNCPODP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x6FDBB80", Offset = "0x6FDAD80", VA = "0x186FDBB80")]
		internal object KOEBPLFHGOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x6FDBC60", Offset = "0x6FDAE60", VA = "0x186FDBC60")]
		internal object PEHOIBPMDNF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	private BCCLEKKJGLB LINJEFIAFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	private AOOKNBGCDKI HOBEPAEHHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private bool DJDDDKCEKHP;

	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private static readonly ByteString JOKAAPOMGEN;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private MFEINKDLEHJ KFKHEOKCKBP
	{
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x6FEADB0", Offset = "0x6FE9FB0", VA = "0x186FEADB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private FFAMIDMIBLK HFPCNNCNGPE
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x6FEAE40", Offset = "0x6FEA040", VA = "0x186FEAE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA480", Offset = "0x6FE9680", VA = "0x186FEA480")]
	[AsyncStateMachine(typeof(DGAJLLPODJF))]
	public static Task AGALHLJOLPH(PNHFEHLPHMO KBCJMHHCDBC, BCCLEKKJGLB LINJEFIAFHO, AOOKNBGCDKI HOBEPAEHHJL, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM, bool DJDDDKCEKHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA5D0", Offset = "0x6FE97D0", VA = "0x186FEA5D0")]
	[AsyncStateMachine(typeof(KDAKAOIHDFD))]
	private Task AGALHLJOLPH(OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA710", Offset = "0x6FE9910", VA = "0x186FEA710")]
	private void CIAIEKFFHPK([NotNull] CKJAAMAMPKA DFEILOOLDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x6FEAE00", Offset = "0x6FEA000", VA = "0x186FEAE00")]
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
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public AsyncTaskMethodBuilder<BCCLEKKJGLB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public FBKJKJHEJFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public KGKIJLNHCBD.GNBOAEIMAME downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private OADONCMLPJG<string>.HILOONJJDHL <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private TaskAwaiter<(CIKECDEKJAI<NPKNNMIHNCN, EGADAFAJMEN>, CIKECDEKJAI<MOGOEHIGGGP<CKJAAMAMPKA>, EGADAFAJMEN>, CIKECDEKJAI<MOGOEHIGGGP<JPOIDFBEIEP>, EGADAFAJMEN>, CIKECDEKJAI<MOGOEHIGGGP<LPCEBBBOKPM>, EGADAFAJMEN>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x6FE4950", Offset = "0x6FE3B50", VA = "0x186FE4950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x6FE5400", Offset = "0x6FE4600", VA = "0x186FE5400", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public AsyncTaskMethodBuilder<CIKECDEKJAI<NPKNNMIHNCN, EGADAFAJMEN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public OADONCMLPJG<string>.HILOONJJDHL downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public FBKJKJHEJFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public KGKIJLNHCBD.GNBOAEIMAME downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private TaskAwaiter<CIKECDEKJAI<NPKNNMIHNCN, EGADAFAJMEN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x6FDA180", Offset = "0x6FD9380", VA = "0x186FDA180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x6FDA790", Offset = "0x6FD9990", VA = "0x186FDA790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	private PFLNKKCOAHI<KEOGFOOKLEH, JPOIDFBEIEP> LKIOEIPJIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	private PFLNKKCOAHI<KEOGFOOKLEH, CKJAAMAMPKA> HBGBDBMCOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	private PFLNKKCOAHI<long, LPCEBBBOKPM> HEFLBPJEPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	private PJOHEDNALLN EOGAHJIINJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	private FLKIEPIEFEG ECCIBCDNFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	private HCDOMJKEJGM BPKLHPPCKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	private string EEPCKBDHEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	private KEOGFOOKLEH BIOFMAGLAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	private KEOGFOOKLEH PNMECAEFMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	private long LMGCMDBJBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	private OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM;

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x6FDCE20", Offset = "0x6FDC020", VA = "0x186FDCE20")]
	public static Task<BCCLEKKJGLB> GNJKDOJCBBG(PNHFEHLPHMO KBCJMHHCDBC, [In] JHNAMKCFCAD LINJEFIAFHO, KGKIJLNHCBD.GNBOAEIMAME KANAHIPJEKP, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x6FDCAD0", Offset = "0x6FDBCD0", VA = "0x186FDCAD0")]
	[AsyncStateMachine(typeof(JKKPIJJOEKK))]
	private Task<BCCLEKKJGLB> AGALHLJOLPH(KGKIJLNHCBD.GNBOAEIMAME KANAHIPJEKP, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x6FDCC60", Offset = "0x6FDBE60", VA = "0x186FDCC60")]
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
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public AsyncTaskMethodBuilder<JHNAMKCFCAD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public ONKDMLGACJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private OADONCMLPJG<string>.HILOONJJDHL <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private TaskAwaiter<JHNAMKCFCAD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x6FDF080", Offset = "0x6FDE280", VA = "0x186FDF080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x6FDF480", Offset = "0x6FDE680", VA = "0x186FDF480", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public AsyncTaskMethodBuilder<JHNAMKCFCAD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public ONKDMLGACJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private TaskAwaiter<JHNAMKCFCAD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x6FE5730", Offset = "0x6FE4930", VA = "0x186FE5730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x6FE5B60", Offset = "0x6FE4D60", VA = "0x186FE5B60", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public MNONHLPGAJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x92CE00", Offset = "0x92C000", VA = "0x18092CE00")]
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
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public AsyncTaskMethodBuilder<JHNAMKCFCAD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public KEOGFOOKLEH superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public MFEINKDLEHJ callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		private MNONHLPGAJH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public GGIIPLFNMOA roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private FLKIEPIEFEG <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private HCDOMJKEJGM <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private KEOGFOOKLEH <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private KEOGFOOKLEH <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private TaskAwaiter<FLKIEPIEFEG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private TaskAwaiter<LLEPICGCMEA> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private TaskAwaiter<HNKJBJIHEKD> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8FE0", Offset = "0x6FD81E0", VA = "0x186FD8FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x6FDA110", Offset = "0x6FD9310", VA = "0x186FDA110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000561")]
	private MFEINKDLEHJ EKMGPIDNBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000562")]
	private BOAMHEKDIOK CJHEFFFCIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000563")]
	private GGIIPLFNMOA JKPACCCFGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000564")]
	private OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	private long DIMOGDCMBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	private long MMMJFAODPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	private long JFKPBGIIONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private string CNCIKMOKNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private KEOGFOOKLEH DPKLJFBJENK;

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB240", Offset = "0x6FEA440", VA = "0x186FEB240")]
	public static Task<JHNAMKCFCAD> GNJKDOJCBBG(PNHFEHLPHMO KBCJMHHCDBC, JBBIANFGILF GPCNCGBOPJG, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB0C0", Offset = "0x6FEA2C0", VA = "0x186FEB0C0")]
	[AsyncStateMachine(typeof(FLKGCOMGNOD))]
	private Task<JHNAMKCFCAD> AGALHLJOLPH(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB4C0", Offset = "0x6FEA6C0", VA = "0x186FEB4C0")]
	[AsyncStateMachine(typeof(KBBJHMOIPMM))]
	private Task<JHNAMKCFCAD> IBAFCNNGGBJ(OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB620", Offset = "0x6FEA820", VA = "0x186FEB620")]
	[AsyncStateMachine(typeof(BNEHBJOEMEG))]
	private static Task<JHNAMKCFCAD> IBAFCNNGGBJ(MFEINKDLEHJ EKMGPIDNBAL, GGIIPLFNMOA JKPACCCFGCC, long DIMOGDCMBFM, long MMMJFAODPOA, long JFKPBGIIONL, string CNCIKMOKNCG, KEOGFOOKLEH DPKLJFBJENK, CancellationToken MPLGBOFHPLM, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB210", Offset = "0x6FEA410", VA = "0x186FEB210")]
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
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public DGNIKAGOCHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x6FDBDA0", Offset = "0x6FDAFA0", VA = "0x186FDBDA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x6FDC330", Offset = "0x6FDB530", VA = "0x186FDC330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400058C")]
	private MFEINKDLEHJ EKMGPIDNBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400058D")]
	private BCCLEKKJGLB LINJEFIAFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400058E")]
	private OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400058F")]
	private float GGEDFCNOKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000590")]
	private float KHPFKLEDAHL;

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x6FDB2E0", Offset = "0x6FDA4E0", VA = "0x186FDB2E0")]
	public static Task MFIHCKJGFLF(PNHFEHLPHMO KBCJMHHCDBC, BCCLEKKJGLB LINJEFIAFHO, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x6FDAE60", Offset = "0x6FDA060", VA = "0x186FDAE60")]
	[AsyncStateMachine(typeof(EPGDBNGOGIB))]
	public Task AGALHLJOLPH(CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x6FDB1A0", Offset = "0x6FDA3A0", VA = "0x186FDB1A0")]
	private static void HHAFDHIEILI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x6FDAF80", Offset = "0x6FDA180", VA = "0x186FDAF80")]
	private void DPGOPDPAMPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x6FDB0E0", Offset = "0x6FDA2E0", VA = "0x186FDB0E0")]
	private static float HCCEFAGLBHC(MFEINKDLEHJ EKMGPIDNBAL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x6FDB480", Offset = "0x6FDA680", VA = "0x186FDB480")]
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
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public AOOKNBGCDKI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private LDOGEOGHOLH <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private PNHFEHLPHMO <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private FJCBFJLOJNB.HEMGOLNMIEJ <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8110", Offset = "0x6FE7310", VA = "0x186FE8110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8930", Offset = "0x6FE7B30", VA = "0x186FE8930", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8C90", Offset = "0x6FD7E90", VA = "0x186FD8C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8F80", Offset = "0x6FD8180", VA = "0x186FD8F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x6FE37C0", Offset = "0x6FE29C0", VA = "0x186FE37C0")]
	[AsyncStateMachine(typeof(LEBHPOLOGOP))]
	public static Task AGALHLJOLPH(AOOKNBGCDKI HOBEPAEHHJL, BCCLEKKJGLB LINJEFIAFHO, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x6FE3900", Offset = "0x6FE2B00", VA = "0x186FE3900")]
	private static Task<JHHNPEBPLNM> EIJPLEGLDCB(AOOKNBGCDKI HOBEPAEHHJL, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x6FE3970", Offset = "0x6FE2B70", VA = "0x186FE3970")]
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
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public PNOHLCBINMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x6FE9460", Offset = "0x6FE8660", VA = "0x186FE9460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x6FE9B10", Offset = "0x6FE8D10", VA = "0x186FE9B10", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public PIGPMDMLNGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x6FEDEC0", Offset = "0x6FED0C0", VA = "0x186FEDEC0")]
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
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public PNOHLCBINMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x6FDF9F0", Offset = "0x6FDEBF0", VA = "0x186FDF9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x6FDFE50", Offset = "0x6FDF050", VA = "0x186FDFE50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005AB")]
	private bool JHLNKBPNCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005AC")]
	private OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005AD")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005AE")]
	private CancellationToken MPLGBOFHPLM;

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE5F0", Offset = "0x6FED7F0", VA = "0x186FEE5F0")]
	public static Task GDDFCAEIIAE(PNHFEHLPHMO KBCJMHHCDBC, bool JHLNKBPNCBO, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken CGFBIGKMGCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE3D0", Offset = "0x6FED5D0", VA = "0x186FEE3D0")]
	[AsyncStateMachine(typeof(ODLOGBCMIKM))]
	private Task AGALHLJOLPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE4C0", Offset = "0x6FED6C0", VA = "0x186FEE4C0")]
	[AsyncStateMachine(typeof(GEMDJEOOABA))]
	private Task AMHLAJGDKIO(bool DNHNFCFHHHN, string OAAJEIOFMBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030")]
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
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public KLKDPMKGLFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x6FE7AE0", Offset = "0x6FE6CE0", VA = "0x186FE7AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8050", Offset = "0x6FE7250", VA = "0x186FE8050", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public KOKHFIEHLAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x6FE80C0", Offset = "0x6FE72C0", VA = "0x186FE80C0")]
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
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public KLKDPMKGLFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x6FDF4F0", Offset = "0x6FDE6F0", VA = "0x186FDF4F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x6FDF980", Offset = "0x6FDEB80", VA = "0x186FDF980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005BE")]
	private ABKBLDBOPKP JOMJHKECGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005BF")]
	private OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C0")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C1")]
	private bool JBAPLLMCMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005C2")]
	private BCCLEKKJGLB LINJEFIAFHO;

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6C40", Offset = "0x6FE5E40", VA = "0x186FE6C40")]
	public static Task<Scene> ANJIDPMKHGM(PNHFEHLPHMO KBCJMHHCDBC, ABKBLDBOPKP LOKLKHKLFPL, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x6FE69D0", Offset = "0x6FE5BD0", VA = "0x186FE69D0")]
	[AsyncStateMachine(typeof(KNCEOJKJOJN))]
	private Task<Scene> AGALHLJOLPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6CC0", Offset = "0x6FE5EC0", VA = "0x186FE6CC0")]
	private bool EIMIEILCPAJ(BCCLEKKJGLB LINJEFIAFHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6CF0", Offset = "0x6FE5EF0", VA = "0x186FE6CF0")]
	private void MGKMNEHAJBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6AF0", Offset = "0x6FE5CF0", VA = "0x186FE6AF0")]
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
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public AsyncTaskMethodBuilder<BAEGFPFJEKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public KKMJLGFKMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public BAEGFPFJEKP nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public BCCLEKKJGLB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		private OADONCMLPJG<string>.HILOONJJDHL <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		private TaskAwaiter<BAEGFPFJEKP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x6FD7200", Offset = "0x6FD6400", VA = "0x186FD7200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x6FD7CE0", Offset = "0x6FD6EE0", VA = "0x186FD7CE0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public AsyncTaskMethodBuilder<BAEGFPFJEKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public KKMJLGFKMCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public BAEGFPFJEKP state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x6FE4600", Offset = "0x6FE3800", VA = "0x186FE4600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x6FE48E0", Offset = "0x6FE3AE0", VA = "0x186FE48E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private readonly AOOKNBGCDKI HOBEPAEHHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	private readonly BOAMHEKDIOK CJHEFFFCIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	private readonly GNKDLDAAEML ANANAPJIBKL;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private LDOGEOGHOLH PCEFFCPFNFE
	{
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x5701720", Offset = "0x5700920", VA = "0x185701720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6970", Offset = "0x6FE5B70", VA = "0x186FE6970")]
	public KKMJLGFKMCG(AOOKNBGCDKI HOBEPAEHHJL, BOAMHEKDIOK CJHEFFFCIJN, GNKDLDAAEML ANANAPJIBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6690", Offset = "0x6FE5890", VA = "0x186FE6690")]
	[AsyncStateMachine(typeof(AGBDPBGOIGG))]
	public Task<BAEGFPFJEKP> MHDBOPPLJDH(BAEGFPFJEKP NCONGBKANCG, BCCLEKKJGLB ODJOOIPMNML, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM, bool AMEECLKOLCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6810", Offset = "0x6FE5A10", VA = "0x186FE6810")]
	[AsyncStateMachine(typeof(JJLDAMPBLBI))]
	private Task<BAEGFPFJEKP> OODKHDCPLHI(OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, BAEGFPFJEKP DMDDBNBIFMI, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6640", Offset = "0x6FE5840", VA = "0x186FE6640")]
	private bool HNONDFFMHPC(BAEGFPFJEKP CFAGNNMBLHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6670", Offset = "0x6FE5870", VA = "0x186FE6670")]
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
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public LDOGEOGHOLH operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public FCPMHIPDGPA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		private PHCOOIGGHEB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private List<(PersistenceView, CLPMHIGOAIJ)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private (PersistenceView, CLPMHIGOAIJ) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x6FD6B90", Offset = "0x6FD5D90", VA = "0x186FD6B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x6FD71A0", Offset = "0x6FD63A0", VA = "0x186FD71A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x6FDFEB0", Offset = "0x6FDF0B0", VA = "0x186FDFEB0")]
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
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public LDOGEOGHOLH operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public FCPMHIPDGPA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private CCFJLIPPODM <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private PHCOOIGGHEB <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private List<(PersistenceView, CLPMHIGOAIJ)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private CLPMHIGOAIJ <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x6FE16A0", Offset = "0x6FE08A0", VA = "0x186FE16A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x6FE1EF0", Offset = "0x6FE10F0", VA = "0x186FE1EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8DC0", Offset = "0x6FE7FC0", VA = "0x186FE8DC0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public List<NCKGFONBDGH> MFIKIEPKPBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public List<CLPMHIGOAIJ> LEHPADKOLLE;

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0xAB26B0", Offset = "0xAB18B0", VA = "0x180AB26B0")]
		public HEMGOLNMIEJ(List<NCKGFONBDGH> MFIKIEPKPBB, List<CLPMHIGOAIJ> LEHPADKOLLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private sealed class JCFIKPFBJCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public IEnumerable<NCKGFONBDGH> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public JCFIKPFBJCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x6FE3740", Offset = "0x6FE2940", VA = "0x186FE3740")]
		internal object FABOFDNJIKP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005FE")]
	private PNHFEHLPHMO KBCJMHHCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005FF")]
	private BCCLEKKJGLB LINJEFIAFHO;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private MFEINKDLEHJ KFKHEOKCKBP
	{
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x6FDEE60", Offset = "0x6FDE060", VA = "0x186FDEE60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x6FDE850", Offset = "0x6FDDA50", VA = "0x186FDE850")]
	public static HEMGOLNMIEJ AGALHLJOLPH(PNHFEHLPHMO KBCJMHHCDBC, BCCLEKKJGLB LINJEFIAFHO)
	{
		return default(HEMGOLNMIEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x6FDE5F0", Offset = "0x6FDD7F0", VA = "0x186FDE5F0")]
	private HEMGOLNMIEJ AGALHLJOLPH()
	{
		return default(HEMGOLNMIEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x6FDE8B0", Offset = "0x6FDDAB0", VA = "0x186FDE8B0")]
	private HEMGOLNMIEJ DKENKAFIPMM(CKJAAMAMPKA DFEILOOLDPK, CCFJLIPPODM EIBPJCOMOGE)
	{
		return default(HEMGOLNMIEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x6FDEEB0", Offset = "0x6FDE0B0", VA = "0x186FDEEB0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public FJCBFJLOJNB.HEMGOLNMIEJ instantiations;

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public PDHPCFLCMPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x6FED7F0", Offset = "0x6FEC9F0", VA = "0x186FED7F0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public ELBCCNMKKBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x6FDBD10", Offset = "0x6FDAF10", VA = "0x186FDBD10")]
		internal object FPBNMKNLEFP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6D60", Offset = "0x6FE5F60", VA = "0x186FE6D60")]
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
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public GNKDLDAAEML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public BAEGFPFJEKP operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public BCCLEKKJGLB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x6FE7310", Offset = "0x6FE6510", VA = "0x186FE7310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x6FE7A80", Offset = "0x6FE6C80", VA = "0x186FE7A80", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000614")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000615")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000616")]
			public AMGCDOIIEAJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000617")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000618")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0x6FEE970", Offset = "0x6FEDB70", VA = "0x186FEE970", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x6FEEC30", Offset = "0x6FEDE30", VA = "0x186FEEC30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public GNKDLDAAEML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public OADONCMLPJG<string>.HILOONJJDHL handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public AMGCDOIIEAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8B30", Offset = "0x6FD7D30", VA = "0x186FD8B30")]
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
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public GNKDLDAAEML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		private AMGCDOIIEAJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x6FE9EF0", Offset = "0x6FE90F0", VA = "0x186FE9EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x6FEA420", Offset = "0x6FE9620", VA = "0x186FEA420", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public GNKDLDAAEML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		private Dictionary<Guid, List<CNEDOEIINNH>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x6FEB7C0", Offset = "0x6FEA9C0", VA = "0x186FEB7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x6FEBD70", Offset = "0x6FEAF70", VA = "0x186FEBD70", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public GNKDLDAAEML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		private Dictionary<Guid, List<CNEDOEIINNH>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8450", Offset = "0x6FD7650", VA = "0x186FD8450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8AD0", Offset = "0x6FD7CD0", VA = "0x186FD8AD0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000638")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000639")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400063A")]
			public CNEDOEIINNH handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400063B")]
			public EFKJHOCODEL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400063C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(RVA = "0x6FEE770", Offset = "0x6FED970", VA = "0x186FEE770", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0x6FEE910", Offset = "0x6FEDB10", VA = "0x186FEE910", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public NONNNPKNJHH runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public List<CNEDOEIINNH> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public EFKJHOCODEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x6FDB8B0", Offset = "0x6FDAAB0", VA = "0x186FDB8B0")]
		internal object BGJBLCDJLMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x6FDB9A0", Offset = "0x6FDABA0", VA = "0x186FDB9A0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task HFPKJOMEJMM(CNEDOEIINNH handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x6FDBA90", Offset = "0x6FDAC90", VA = "0x186FDBA90")]
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
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public NONNNPKNJHH runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public List<CNEDOEIINNH> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		private EFKJHOCODEL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x6FDE0C0", Offset = "0x6FDD2C0", VA = "0x186FDE0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x6FDE590", Offset = "0x6FDD790", VA = "0x186FDE590", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public GNKDLDAAEML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public OADONCMLPJG<string>.HILOONJJDHL timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x6FED8A0", Offset = "0x6FECAA0", VA = "0x186FED8A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x6FEDE60", Offset = "0x6FED060", VA = "0x186FEDE60", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public CCCLIGPGNNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x6FDA940", Offset = "0x6FD9B40", VA = "0x186FDA940")]
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
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public GNKDLDAAEML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public BCCLEKKJGLB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8F00", Offset = "0x6FE8100", VA = "0x186FE8F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x6FE93C0", Offset = "0x6FE85C0", VA = "0x186FE93C0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public CHMHLODPEBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x6FDA9B0", Offset = "0x6FD9BB0", VA = "0x186FDA9B0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public GNKDLDAAEML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x6FE2F60", Offset = "0x6FE2160", VA = "0x186FE2F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x6FE35A0", Offset = "0x6FE27A0", VA = "0x186FE35A0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public BEHMABACEEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8C20", Offset = "0x6FD7E20", VA = "0x186FD8C20")]
		internal object MGGOLOICADP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000606")]
	private readonly AOOKNBGCDKI HOBEPAEHHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000607")]
	private IDOKGAKHACO ANANAPJIBKL;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private LDOGEOGHOLH PCEFFCPFNFE
	{
		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x918080", Offset = "0x917280", VA = "0x180918080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x8523E0", VA = "0x1808531E0")]
	public GNKDLDAAEML(AOOKNBGCDKI HOBEPAEHHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x6FE0880", Offset = "0x6FDFA80", VA = "0x186FE0880")]
	[AsyncStateMachine(typeof(KNABJDKMEDN))]
	public Task AGALHLJOLPH(BAEGFPFJEKP MPMDJOHBDMD, BCCLEKKJGLB ODJOOIPMNML, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x6FE0DA0", Offset = "0x6FDFFA0", VA = "0x186FE0DA0")]
	[AsyncStateMachine(typeof(OIJOGIOFDEP))]
	private Task HAKONPBCCBH(BCCLEKKJGLB LINJEFIAFHO, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x6FE1420", Offset = "0x6FE0620", VA = "0x186FE1420")]
	[AsyncStateMachine(typeof(OPOGGMJIFMG))]
	private Task MJACBELPHDC(BCCLEKKJGLB LINJEFIAFHO, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x6FE1560", Offset = "0x6FE0760", VA = "0x186FE1560")]
	[AsyncStateMachine(typeof(ALIHIMJOPAI))]
	private Task NIDDOAFCPBL(BCCLEKKJGLB LINJEFIAFHO, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x6FE1000", Offset = "0x6FE0200", VA = "0x186FE1000")]
	[AsyncStateMachine(typeof(FGBECPLAAGL))]
	private Task KHPOFECAIJA(Guid BLDBPNFIAPG, List<CNEDOEIINNH> FCGOCDPHAPF, NONNNPKNJHH GNKFHIIIPHB, BCCLEKKJGLB LINJEFIAFHO, CancellationToken EOCJCEFCOOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x6FE09D0", Offset = "0x6FDFBD0", VA = "0x186FE09D0")]
	[AsyncStateMachine(typeof(PIAJBODKKPG))]
	private Task AOGKIGGKNAO(BCCLEKKJGLB LINJEFIAFHO, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x6FE0740", Offset = "0x6FDF940", VA = "0x186FE0740")]
	[AsyncStateMachine(typeof(NMEHDBMMELB))]
	private Task AEMCLNCLDAB(Guid KCMKEFIHCLF, BCCLEKKJGLB LINJEFIAFHO, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x6FE12E0", Offset = "0x6FE04E0", VA = "0x186FE12E0")]
	[AsyncStateMachine(typeof(JBAKKAMGEEF))]
	private Task MHBNJPAJGBL(Guid KCMKEFIHCLF, OADONCMLPJG<string>.HILOONJJDHL NHJCJOFGMEE, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x6FE0EE0", Offset = "0x6FE00E0", VA = "0x186FE0EE0")]
	private void JDGHIGBGGMI(Guid KCMKEFIHCLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x6FE0CF0", Offset = "0x6FDFEF0", VA = "0x186FE0CF0")]
	private void CEELOAFAJNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x6FE1150", Offset = "0x6FE0350", VA = "0x186FE1150")]
	public Guid LELOEOEJPCG(BAEGFPFJEKP DGDNFAGKJJD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x6FE0B10", Offset = "0x6FDFD10", VA = "0x186FE0B10")]
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
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		public GLMCEPIGLJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private OADONCMLPJG<string>.HILOONJJDHL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private IEnumerator<AIDMEJBIGGB> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x6FDC390", Offset = "0x6FDB590", VA = "0x186FDC390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x6FDCA70", Offset = "0x6FDBC70", VA = "0x186FDCA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000664")]
	private MFEINKDLEHJ EKMGPIDNBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000665")]
	private OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000666")]
	private CancellationToken MPLGBOFHPLM;

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x6FE06D0", Offset = "0x6FDF8D0", VA = "0x186FE06D0")]
	public static Task GKDNMPIMODG(MFEINKDLEHJ EKMGPIDNBAL, OADONCMLPJG<string>.HILOONJJDHL GFNLGFOFJFM, CancellationToken CGFBIGKMGCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x6FE05E0", Offset = "0x6FDF7E0", VA = "0x186FE05E0")]
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
	[Cpp2IlInjected.Token(Token = "0x400066D")]
	public readonly bool DKJALNHCOGO;

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x217A0A0", Offset = "0x21792A0", VA = "0x18217A0A0")]
	public JJNDGMFMLEH(bool PHGCMJDPPHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
public readonly struct JBBKCFOEFFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	public readonly CKJAAMAMPKA? LJIMKCPNMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400066F")]
	public readonly HCPPCCJPAPN NBDIAENDHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000670")]
	public readonly string? CECLABBIDNN;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public IReadOnlyCollection<string> GGAGFAHHLKI
	{
		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x6FE3620", Offset = "0x6FE2820", VA = "0x186FE3620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public IReadOnlyDictionary<long, int> PCMMCOJMKMN
	{
		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x6FE3600", Offset = "0x6FE2800", VA = "0x186FE3600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x6FE3640", Offset = "0x6FE2840", VA = "0x186FE3640")]
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
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public AsyncTaskMethodBuilder<JBBKCFOEFFA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public OPPOPKDPFEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public INAMFDDJCJB serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public LEBMOIGALED roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		private PHCOOIGGHEB <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x6FDD190", Offset = "0x6FDC390", VA = "0x186FDD190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x6FDD800", Offset = "0x6FDCA00", VA = "0x186FDD800", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public INAMFDDJCJB serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		public OPPOPKDPFEJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public JENHGHCEACK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x6FE4300", Offset = "0x6FE3500", VA = "0x186FE4300")]
		internal Task NHHHCEINCAB(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x6FE4520", Offset = "0x6FE3720", VA = "0x186FE4520")]
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
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public JENHGHCEACK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public GLMAGKFFIFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x6FE0570", Offset = "0x6FDF770", VA = "0x186FE0570")]
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
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public JENHGHCEACK CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public OBPNJGNEAOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x6FE9420", Offset = "0x6FE8620", VA = "0x186FE9420")]
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
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public INAMFDDJCJB serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		public OPPOPKDPFEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		private GLMAGKFFIFN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		private PHCOOIGGHEB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x6FE3A30", Offset = "0x6FE2C30", VA = "0x186FE3A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x6FE42A0", Offset = "0x6FE34A0", VA = "0x186FE42A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	private readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.Token(Token = "0x4000672")]
	private static readonly TimeSpan NILDDDBDBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000673")]
	private readonly BOKGGMAHILG HBAOPAHIPOP;

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x6FECEE0", Offset = "0x6FEC0E0", VA = "0x186FECEE0")]
	public OPPOPKDPFEJ(AOOKNBGCDKI HOBEPAEHHJL, BOKGGMAHILG HBAOPAHIPOP, CDLNJDLNIPA KBNCOADBJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0x6FECD10", Offset = "0x6FEBF10", VA = "0x186FECD10")]
	[AsyncStateMachine(typeof(FBMJKKMBOJL))]
	public Task<JBBKCFOEFFA> OPCGAJMHMBL(long MMMJFAODPOA, LEBMOIGALED NNEJNOJGJGB, INAMFDDJCJB MEGACNKHFJL, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC980", Offset = "0x6FEBB80", VA = "0x186FEC980")]
	[AsyncStateMachine(typeof(JDPCHIPGNGA))]
	private Task KLFGEGFIBON(INAMFDDJCJB MEGACNKHFJL, IEnumerable<PersistenceView> LALNNECKACD, StringBuilder ENGOKPLGAKB, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC3D0", Offset = "0x6FEB5D0", VA = "0x186FEC3D0")]
	private JBBKCFOEFFA EOMFACDBNNG(long MMMJFAODPOA, LEBMOIGALED NNEJNOJGJGB, INAMFDDJCJB MEGACNKHFJL, IEnumerable<PersistenceView> LALNNECKACD, StringBuilder ENGOKPLGAKB)
	{
		return default(JBBKCFOEFFA);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBDD0", Offset = "0x6FEAFD0", VA = "0x186FEBDD0")]
	private CKJAAMAMPKA ECOIKMGEIHP(long MMMJFAODPOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x6FECAC0", Offset = "0x6FEBCC0", VA = "0x186FECAC0")]
	private void ODDPCKBJAJI(CKJAAMAMPKA GFOADFAGJGL, StringBuilder ENGOKPLGAKB, IEnumerable<PersistenceView> LALNNECKACD, [In] EJPPCDFMGAB NNIAKJBMFAH, KLAHAGABJNO AAPBDGLHGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBF30", Offset = "0x6FEB130", VA = "0x186FEBF30")]
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
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public KDDDDHELEIK.OFPJCAGGINJ roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public KHMIPGCIMFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x6FE65F0", Offset = "0x6FE57F0", VA = "0x186FE65F0")]
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
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		public AsyncTaskMethodBuilder<(KDDDDHELEIK.OFPJCAGGINJ roomDataUpload, KDDDDHELEIK.OFPJCAGGINJ subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public JBBKCFOEFFA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		public IOFNMIAGIID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		private KHMIPGCIMFH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		private TaskAwaiter<KDDDDHELEIK.OFPJCAGGINJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x6FECF30", Offset = "0x6FEC130", VA = "0x186FECF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x6FED780", Offset = "0x6FEC980", VA = "0x186FED780", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public AsyncTaskMethodBuilder<BMBMOGELPMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public IOFNMIAGIID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public JBBKCFOEFFA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public KAIMFMKFBCK roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		private TaskAwaiter<(KDDDDHELEIK.OFPJCAGGINJ roomDataUpload, KDDDDHELEIK.OFPJCAGGINJ subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		private TaskAwaiter<BMBMOGELPMJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x6FD7D50", Offset = "0x6FD6F50", VA = "0x186FD7D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x6FD83E0", Offset = "0x6FD75E0", VA = "0x186FD83E0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public AsyncTaskMethodBuilder<LLEPICGCMEA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public IOFNMIAGIID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public JBBKCFOEFFA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		private TaskAwaiter<(KDDDDHELEIK.OFPJCAGGINJ roomDataUpload, KDDDDHELEIK.OFPJCAGGINJ subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		private TaskAwaiter<LLEPICGCMEA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x6FDDC40", Offset = "0x6FDCE40", VA = "0x186FDDC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x6FDE050", Offset = "0x6FDD250", VA = "0x186FDE050", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40006BF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006C0")]
			public AsyncTaskMethodBuilder<JHHNPEBPLNM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006C1")]
			public ICOOGILOKNL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006C2")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006C3")]
			private JHHNPEBPLNM <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006C4")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006C5")]
			private TaskAwaiter<LLEPICGCMEA> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006C6")]
			private TaskAwaiter<BMBMOGELPMJ> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006C7")]
			private TaskAwaiter<JHHNPEBPLNM> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0x6FEF080", Offset = "0x6FEE280", VA = "0x186FEF080", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0x6FF0000", Offset = "0x6FEF200", VA = "0x186FF0000", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public IOFNMIAGIID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public JBBKCFOEFFA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public KAIMFMKFBCK roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public JJNDGMFMLEH roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public ICOOGILOKNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x6FE23F0", Offset = "0x6FE15F0", VA = "0x186FE23F0")]
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
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		public AsyncTaskMethodBuilder<JHHNPEBPLNM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		public IOFNMIAGIID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public JBBKCFOEFFA roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public KAIMFMKFBCK roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public JJNDGMFMLEH roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public OADONCMLPJG<string>.HILOONJJDHL stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		private TaskAwaiter<JHHNPEBPLNM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x6FE9B70", Offset = "0x6FE8D70", VA = "0x186FE9B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x6FE9E80", Offset = "0x6FE9080", VA = "0x186FE9E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000696")]
	private static readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private static readonly CDLNJDLNIPA KBKNHCEIBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000698")]
	private readonly OELPCMIPAIF KAGKBNNDDPK;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	private PNHFEHLPHMO NOOCLICDJJM
	{
		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x6FD1A50", Offset = "0x6FD0C50", VA = "0x186FD1A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE2B80", Offset = "0x6FE1D80", VA = "0x186FE2B80")]
	public IOFNMIAGIID(AOOKNBGCDKI HOBEPAEHHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x6FE2520", Offset = "0x6FE1720", VA = "0x186FE2520")]
	[AsyncStateMachine(typeof(PBBBFBGEEKC))]
	private Task<(KDDDDHELEIK.OFPJCAGGINJ, KDDDDHELEIK.OFPJCAGGINJ)> FLGKJCLCBHA(JBBKCFOEFFA HLJMJFBMCDD, long DIMOGDCMBFM, long KJMNNDODHCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x6FE2970", Offset = "0x6FE1B70", VA = "0x186FE2970")]
	[AsyncStateMachine(typeof(AGJLPMKGJKE))]
	public Task<BMBMOGELPMJ> KILMPIGDEFN(int HDFLMOLOCCD, [CanBeNull] KAIMFMKFBCK BJEDAIHNLGI, JBBKCFOEFFA HLJMJFBMCDD, long DIMOGDCMBFM, long KJMNNDODHCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x6FE2660", Offset = "0x6FE1860", VA = "0x186FE2660")]
	[AsyncStateMachine(typeof(FFMNMKIKIKD))]
	private Task<LLEPICGCMEA> IBEFOMBMBBH(string CNCIKMOKNCG, int HDFLMOLOCCD, JBBKCFOEFFA HLJMJFBMCDD, long DIMOGDCMBFM, long KJMNNDODHCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x6FE27D0", Offset = "0x6FE19D0", VA = "0x186FE27D0")]
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
	[Cpp2IlInjected.Token(Token = "0x40006D4")]
	internal readonly PNHFEHLPHMO HFPIOMLCALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D5")]
	private int? DKHDGICDBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D6")]
	protected readonly Guid BCGKIOLOHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D7")]
	protected readonly KPFIKNDEFFO IPFOHGNPEKN;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	protected T FBLEFNNFHEC
	{
		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x40B9FD0", Offset = "0x40B91D0", VA = "0x1840B9FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x40BA370", Offset = "0x40B9570", VA = "0x1840BA370")]
	internal JKOFPHHMCIB(PNHFEHLPHMO NKLGIGDEHPG, KPFIKNDEFFO OFNDKLGKJDP, [Optional] Guid? KPMGFINBLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x40BA290", Offset = "0x40B9490", VA = "0x1840BA290")]
	private JHHNPEBPLNM PENLDJAENCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "4")]
	protected virtual void PEKBGBCPAFB(JHHNPEBPLNM JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x40BA030", Offset = "0x40B9230", VA = "0x1840BA030")]
	public T KJEEAGABNJN(LCMANADAOPN GFABMNOLKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x40BA0C0", Offset = "0x40B92C0", VA = "0x1840BA0C0")]
	public T KLGMHMFMGJM(int GNKJGCJCNCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x40BA160", Offset = "0x40B9360", VA = "0x1840BA160", Slot = "5")]
	public virtual Task<DGFDNIJCPMA> NLMPIJBFLPJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
public class JNAKBMBBKNN : JKOFPHHMCIB<JNAKBMBBKNN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	private JBBIANFGILF MIJPDJDOIDB;

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5540", Offset = "0x6FE4740", VA = "0x186FE5540")]
	internal JNAKBMBBKNN(PNHFEHLPHMO NKLGIGDEHPG, KPFIKNDEFFO OFNDKLGKJDP, [Optional] Guid? KPMGFINBLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x65063A0", Offset = "0x65055A0", VA = "0x1865063A0")]
	public JNAKBMBBKNN DKFDBKAIPAL(JBBIANFGILF MIJPDJDOIDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5470", Offset = "0x6FE4670", VA = "0x186FE5470", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private struct EDFKPOAPOML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public AsyncTaskMethodBuilder<DGFDNIJCPMA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public PKDPFMCHDKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		private TaskAwaiter<DGFDNIJCPMA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x6FDB4A0", Offset = "0x6FDA6A0", VA = "0x186FDB4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x6FDB840", Offset = "0x6FDAA40", VA = "0x186FDB840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	private NEGBDBAAHJL OJMGIAOGCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	private string JKHIABFAKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private KAIMFMKFBCK MIJPDJDOIDB;

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE260", Offset = "0x6FED460", VA = "0x186FEE260")]
	internal PKDPFMCHDKO(PNHFEHLPHMO NKLGIGDEHPG, KPFIKNDEFFO OFNDKLGKJDP, [Optional] Guid? KPMGFINBLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x6FEDF90", Offset = "0x6FED190", VA = "0x186FEDF90")]
	public PKDPFMCHDKO CJJIFNBEFLM(string OLBMKMHMAID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x6FEDF40", Offset = "0x6FED140", VA = "0x186FEDF40")]
	public PKDPFMCHDKO ANIMIMMOMJN(bool IFNMMJBNOOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x6FEDF60", Offset = "0x6FED160", VA = "0x186FEDF60")]
	public PKDPFMCHDKO CGDKPENHAOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE0F0", Offset = "0x6FED2F0", VA = "0x186FEE0F0", Slot = "4")]
	protected override void PEKBGBCPAFB(JHHNPEBPLNM JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE000", Offset = "0x6FED200", VA = "0x186FEE000", Slot = "5")]
	[AsyncStateMachine(typeof(EDFKPOAPOML))]
	public override Task<DGFDNIJCPMA> NLMPIJBFLPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x6FEDFC0", Offset = "0x6FED1C0", VA = "0x186FEDFC0")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<DGFDNIJCPMA> NIGHHPCGLLN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
internal static class COCNFEPHPJE
{
	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x6FDAA20", Offset = "0x6FD9C20", VA = "0x186FDAA20")]
	public static void EMKJDLKKJMJ(this PEJDDGDCLFF OPGANEAFOBB, MDBDBMHCDOA EJBBNMBAICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x6FDAB70", Offset = "0x6FD9D70", VA = "0x186FDAB70")]
	public static void GLEGLCIMJNP(this MDBDBMHCDOA AKLKCJCNCJP, [Optional] string JNNDBFGKHHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
public static class ONAHBABICHB
{
	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB020", Offset = "0x6FEA220", VA = "0x186FEB020")]
	public static KEOGFOOKLEH OCOHMLNJCMB(this MJHHKFADFIN KIKMALBGNCI)
	{
		return default(KEOGFOOKLEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x6FEAF70", Offset = "0x6FEA170", VA = "0x186FEAF70")]
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
			[Cpp2IlInjected.Token(Token = "0x40006E8")]
			public IOJDCLBFPMF ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006E9")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006EA")]
			public IOJDCLBFPMF HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006EB")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006EC")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006ED")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		private static IOJDCLBFPMF[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		private Dictionary<IOJDCLBFPMF, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x6FF06E0", Offset = "0x6FEF8E0", VA = "0x186FF06E0")]
		public bool LDOIADAMLNM(IOJDCLBFPMF MNCJHJGEMJG, [Out] ResultConfig AACIHKHGIHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x6FF05A0", Offset = "0x6FEF7A0", VA = "0x186FF05A0")]
		public ResultConfig INOGKEJOMCC(IOJDCLBFPMF NPGFMGMHJJL, [Optional] HashSet<IOJDCLBFPMF> PJIJOJLNADK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0CB0", Offset = "0x6FEFEB0", VA = "0x186FF0CB0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0750", Offset = "0x6FEF950", VA = "0x186FF0750", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x8BE920", Offset = "0x8BDB20", VA = "0x1808BE920")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
public class FFLJAJFGIDB : HMBECBJGGMK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private struct HKNPPIIGCJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public FFLJAJFGIDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public OADONCMLPJG<string>.HILOONJJDHL timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3AF0", Offset = "0x6FF2CF0", VA = "0x186FF3AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3C80", Offset = "0x6FF2E80", VA = "0x186FF3C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private struct NMJMMCGDMIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		public OADONCMLPJG<string>.HILOONJJDHL timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		public HMBECBJGGMK preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		private OADONCMLPJG<string>.HILOONJJDHL <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x6FF4EC0", Offset = "0x6FF40C0", VA = "0x186FF4EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x6FF53D0", Offset = "0x6FF45D0", VA = "0x186FF53D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006F3")]
	private readonly PACBCALNBML JEKFPFMEPOA;

	[Cpp2IlInjected.Token(Token = "0x40006F4")]
	private static readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public string PLJPJLPBCDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x6FDD980", Offset = "0x6FDCB80", VA = "0x186FDD980", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0x6FDDAD0", Offset = "0x6FDCCD0", VA = "0x186FDDAD0")]
	[GDGALFJPCGE(JAFPILLCEJB.Root, JMIPDAHBNNG.GameOnly)]
	private static void JNAGAGBOGMF(INCIOHANCNE LDLMDJOAIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x8523E0", VA = "0x1808531E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public FFLJAJFGIDB([OMAPKKAGFIL(null)] PACBCALNBML JEKFPFMEPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x6FDD870", Offset = "0x6FDCA70", VA = "0x186FDD870", Slot = "5")]
	[AsyncStateMachine(typeof(HKNPPIIGCJE))]
	public Task AGALHLJOLPH(OADONCMLPJG<string>.HILOONJJDHL DOAFLGODEDJ, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x6FDD9B0", Offset = "0x6FDCBB0", VA = "0x186FDD9B0")]
	[AsyncStateMachine(typeof(NMJMMCGDMIN))]
	private Task CHAIIPLLPOK(HMBECBJGGMK AIEAPICLDBH, OADONCMLPJG<string>.HILOONJJDHL DOAFLGODEDJ, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
public interface PACBCALNBML : HMBECBJGGMK
{
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
public interface HMBECBJGGMK
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	string PLJPJLPBCDK
	{
		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AGALHLJOLPH(OADONCMLPJG<string>.HILOONJJDHL DOAFLGODEDJ, CancellationToken MPLGBOFHPLM);
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
public static class HHBANNGACOC
{
	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x6FF36E0", Offset = "0x6FF28E0", VA = "0x186FF36E0")]
	[GDGALFJPCGE(JMIPDAHBNNG.GameOnly)]
	private static void CEJDNEABNOB(INCIOHANCNE LDLMDJOAIBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
public interface NCKGPLMHNNB : IEquatable<NCKGPLMHNNB>
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	DateTime CDOJLDGOHIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IGLJKNPEBFK();

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FLEPJADKKGI(long DIMOGDCMBFM, long MMMJFAODPOA, [Out] JBBKCFOEFFA HLJMJFBMCDD);
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
internal class BAIIAJAOGAH : APCMDALIFAP
{
	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	[CompilerGenerated]
	private sealed class MKGEJBEALMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public HCEEFOPOCMM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public MKGEJBEALMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x6FF4B20", Offset = "0x6FF3D20", VA = "0x186FF4B20")]
		internal object HILAFDMLMPO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000702")]
	private readonly PDMHIOFNOPB GDDDILGMPMI;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<NCKGPLMHNNB> FIPANKDGOFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x6FF11C0", Offset = "0x6FF03C0", VA = "0x186FF11C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1B40", Offset = "0x6FF0D40", VA = "0x186FF1B40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x8523E0", VA = "0x1808531E0")]
	[UnityEngine.Scripting.Preserve]
	public BAIIAJAOGAH([OMAPKKAGFIL(null)] PDMHIOFNOPB GDDDILGMPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1270", Offset = "0x6FF0470", VA = "0x186FF1270", Slot = "6")]
	public bool BGOHNIEEPOG(long DIMOGDCMBFM, long MMMJFAODPOA, JBBKCFOEFFA HLJMJFBMCDD, HCEEFOPOCMM LKIPKDFOIKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x1C339C0", Offset = "0x1C32BC0", VA = "0x181C339C0")]
	private void DCPMOMGGEIJ(NCKGPLMHNNB NHABHPPMDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1050", Offset = "0x6FF0250", VA = "0x186FF1050", Slot = "7")]
	public bool AMEPMODJGEG(long DIMOGDCMBFM, long MMMJFAODPOA, [Out] NCKGPLMHNNB HEEEABJCCCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1970", Offset = "0x6FF0B70", VA = "0x186FF1970", Slot = "8")]
	public bool HNIMFMKAJPB(long DIMOGDCMBFM, long MMMJFAODPOA, HCEEFOPOCMM LKIPKDFOIKO, [Out] NCKGPLMHNNB HEEEABJCCCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1550", Offset = "0x6FF0750", VA = "0x186FF1550")]
	private void BKBJFGHMADN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1A20", Offset = "0x6FF0C20", VA = "0x186FF1A20", Slot = "9")]
	public void IHHNIIDNNKG(long DIMOGDCMBFM, long MMMJFAODPOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
internal abstract class FNABHGGPMDG : PDMHIOFNOPB
{
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	protected enum LMIIJCPEHGG : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[CompilerGenerated]
	private sealed class MLCFCHICDHB : IEnumerable<NCKGPLMHNNB>, IEnumerable, IEnumerator<NCKGPLMHNNB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		private NCKGPLMHNNB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		public FNABHGGPMDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		private HCEEFOPOCMM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		public HCEEFOPOCMM <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		private NCKGPLMHNNB System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000673")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x89FB40", Offset = "0x89ED40", VA = "0x18089FB40")]
		[DebuggerHidden]
		public MLCFCHICDHB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x6FF4B90", Offset = "0x6FF3D90", VA = "0x186FF4B90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x6FF4E70", Offset = "0x6FF4070", VA = "0x186FF4E70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x6FF4DC0", Offset = "0x6FF3FC0", VA = "0x186FF4DC0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NCKGPLMHNNB> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x6FF4DC0", Offset = "0x6FF3FC0", VA = "0x186FF4DC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[CompilerGenerated]
	private sealed class CAJEAPOJAJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		public HCEEFOPOCMM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public CAJEAPOJAJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2BB0", Offset = "0x6FF1DB0", VA = "0x186FF2BB0")]
		internal object HHPEHHGJNNP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[CompilerGenerated]
	private sealed class BIMDNNLPEAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public FNABHGGPMDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public BIMDNNLPEAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1BF0", Offset = "0x6FF0DF0", VA = "0x186FF1BF0")]
		internal void KAJFMGNMAGC(BODEGEDJFLM.KNDNPIAAOJO ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000708")]
	private readonly object KMHKNAKFPLJ;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	protected string JALMHGGOKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3240", Offset = "0x6FF2440", VA = "0x186FF3240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public abstract NJNINEFDHOO LDONDENFFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3660", Offset = "0x6FF2860", VA = "0x186FF3660")]
	protected FNABHGGPMDG([CanBeNull] string JGDBHEDCOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2CC0", Offset = "0x6FF1EC0", VA = "0x186FF2CC0", Slot = "5")]
	public bool GABAFEMFKLM(long DIMOGDCMBFM, long MMMJFAODPOA, HCEEFOPOCMM LKIPKDFOIKO, [Out] NCKGPLMHNNB NHABHPPMDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x6FF35D0", Offset = "0x6FF27D0", VA = "0x186FF35D0", Slot = "6")]
	[IteratorStateMachine(typeof(MLCFCHICDHB))]
	public IEnumerable<NCKGPLMHNNB> OIPJIEMLAMM(HCEEFOPOCMM LKIPKDFOIKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void CPEAEKPGHDH(Stream BNJJDODGDJC, long DIMOGDCMBFM, long MMMJFAODPOA, JBBKCFOEFFA HLJMJFBMCDD);

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool BHEHJCNOINI(Stream MMOLAPACPMC, long DIMOGDCMBFM, long MMMJFAODPOA, IOPFFLOBCBM GLPDMIFJKNA, [Out] JBBKCFOEFFA HLJMJFBMCDD);

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3250", Offset = "0x6FF2450", VA = "0x186FF3250", Slot = "7")]
	public NCKGPLMHNNB NINJAPGBAPF(long DIMOGDCMBFM, long MMMJFAODPOA, JBBKCFOEFFA HLJMJFBMCDD, HCEEFOPOCMM LKIPKDFOIKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo FMPENCBMNAB(long DIMOGDCMBFM, long MMMJFAODPOA, HCEEFOPOCMM LKIPKDFOIKO, LMIIJCPEHGG GFALHOIMFPG);

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo JNOIECBPKHC(HCEEFOPOCMM LKIPKDFOIKO, LMIIJCPEHGG GFALHOIMFPG);

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2C50", Offset = "0x6FF1E50", VA = "0x186FF2C50")]
	protected void FMFBLIKAKBD(BODEGEDJFLM.KNDNPIAAOJO KNBEEMJODEI, string ALLEHOLILJB, FileInfo NMFNNOJLCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2EB0", Offset = "0x6FF20B0", VA = "0x186FF2EB0")]
	internal bool GGALNMKFMLH(FileInfo LHALDDCEPNI, long DIMOGDCMBFM, long MMMJFAODPOA, [Out] JBBKCFOEFFA HLJMJFBMCDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
	private void DOBDIENEIOJ(Exception NKAKJFGNGPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A7")]
internal class LCJFCBFJIIL : FNABHGGPMDG
{
	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public override NJNINEFDHOO LDONDENFFCN
	{
		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0xCAF740", Offset = "0xCAE940", VA = "0x180CAF740", Slot = "8")]
		get
		{
			return default(NJNINEFDHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4AE0", Offset = "0x6FF3CE0", VA = "0x186FF4AE0")]
	public LCJFCBFJIIL([Optional] string JGDBHEDCOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4960", Offset = "0x6FF3B60", VA = "0x186FF4960")]
	private void IJOLNNCNOCK(HCEEFOPOCMM LKIPKDFOIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x6FF45E0", Offset = "0x6FF37E0", VA = "0x186FF45E0", Slot = "9")]
	internal override void CPEAEKPGHDH(Stream BNJJDODGDJC, long DIMOGDCMBFM, long MMMJFAODPOA, JBBKCFOEFFA HLJMJFBMCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4000", Offset = "0x6FF3200", VA = "0x186FF4000", Slot = "10")]
	internal override bool BHEHJCNOINI(Stream MMOLAPACPMC, long DIMOGDCMBFM, long MMMJFAODPOA, IOPFFLOBCBM GLPDMIFJKNA, [Out] JBBKCFOEFFA HLJMJFBMCDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4870", Offset = "0x6FF3A70", VA = "0x186FF4870", Slot = "11")]
	protected override FileInfo FMPENCBMNAB(long DIMOGDCMBFM, long MMMJFAODPOA, HCEEFOPOCMM LKIPKDFOIKO, LMIIJCPEHGG GFALHOIMFPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x6FF49E0", Offset = "0x6FF3BE0", VA = "0x186FF49E0", Slot = "12")]
	protected override DirectoryInfo JNOIECBPKHC(HCEEFOPOCMM LKIPKDFOIKO, LMIIJCPEHGG GFALHOIMFPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
internal sealed class PDDMKIGFEOI : FNABHGGPMDG
{
	[Cpp2IlInjected.Token(Token = "0x4000718")]
	private static readonly byte[] NDDCLPHCEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000719")]
	private readonly byte[] ACPBGFGNPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400071A")]
	private readonly byte[] MINLNEFMHEG;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public override NJNINEFDHOO LDONDENFFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x5D9B8E0", Offset = "0x5D9AAE0", VA = "0x185D9B8E0", Slot = "8")]
		get
		{
			return default(NJNINEFDHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6710", Offset = "0x6FF5910", VA = "0x186FF6710")]
	public PDDMKIGFEOI([Optional] string JGDBHEDCOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x6FF60C0", Offset = "0x6FF52C0", VA = "0x186FF60C0", Slot = "9")]
	internal override void CPEAEKPGHDH(Stream BNJJDODGDJC, long DIMOGDCMBFM, long MMMJFAODPOA, JBBKCFOEFFA HLJMJFBMCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x6FF58F0", Offset = "0x6FF4AF0", VA = "0x186FF58F0", Slot = "10")]
	internal override bool BHEHJCNOINI(Stream MMOLAPACPMC, long DIMOGDCMBFM, long MMMJFAODPOA, IOPFFLOBCBM GLPDMIFJKNA, [Out] JBBKCFOEFFA HLJMJFBMCDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6380", Offset = "0x6FF5580", VA = "0x186FF6380")]
	private void FFFHPGPEGLO(byte[] DDNKCFIIBGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6440", Offset = "0x6FF5640", VA = "0x186FF6440", Slot = "11")]
	protected override FileInfo FMPENCBMNAB(long DIMOGDCMBFM, long MMMJFAODPOA, HCEEFOPOCMM LKIPKDFOIKO, LMIIJCPEHGG GFALHOIMFPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6570", Offset = "0x6FF5770", VA = "0x186FF6570", Slot = "12")]
	protected override DirectoryInfo JNOIECBPKHC(HCEEFOPOCMM LKIPKDFOIKO, LMIIJCPEHGG GFALHOIMFPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
public enum NJNINEFDHOO : byte
{
	[Cpp2IlInjected.Token(Token = "0x400071C")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x400071D")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x400071E")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001AA")]
internal class BJGOPAHGMNK : PDMHIOFNOPB
{
	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[CompilerGenerated]
	private sealed class NOKHNFDAFNO : IEnumerable<NCKGPLMHNNB>, IEnumerable, IEnumerator<NCKGPLMHNNB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		private NCKGPLMHNNB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		public BJGOPAHGMNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		private HCEEFOPOCMM autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		public HCEEFOPOCMM <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		private NJNINEFDHOO[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		private IEnumerator<NCKGPLMHNNB> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		private NCKGPLMHNNB System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000698")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600069A")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x89FB40", Offset = "0x89ED40", VA = "0x18089FB40")]
		[DebuggerHidden]
		public NOKHNFDAFNO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5860", Offset = "0x6FF4A60", VA = "0x186FF5860", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5480", Offset = "0x6FF4680", VA = "0x186FF5480", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5430", Offset = "0x6FF4630", VA = "0x186FF5430")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5810", Offset = "0x6FF4A10", VA = "0x186FF5810", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5760", Offset = "0x6FF4960", VA = "0x186FF5760", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NCKGPLMHNNB> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5760", Offset = "0x6FF4960", VA = "0x186FF5760", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400071F")]
	private readonly NJNINEFDHOO[] LDBFPDFCCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000720")]
	private readonly Dictionary<NJNINEFDHOO, PDMHIOFNOPB> KMMCJNEPACA;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public NJNINEFDHOO LDONDENFFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2650", Offset = "0x6FF1850", VA = "0x186FF2650", Slot = "4")]
		get
		{
			return default(NJNINEFDHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2860", Offset = "0x6FF1A60", VA = "0x186FF2860")]
	[UnityEngine.Scripting.Preserve]
	public BJGOPAHGMNK(params PDMHIOFNOPB[] FAIKPHELKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2500", Offset = "0x6FF1700", VA = "0x186FF2500", Slot = "5")]
	public bool GABAFEMFKLM(long DIMOGDCMBFM, long MMMJFAODPOA, HCEEFOPOCMM LKIPKDFOIKO, [Out] NCKGPLMHNNB NHABHPPMDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x6FF22E0", Offset = "0x6FF14E0", VA = "0x186FF22E0")]
	private void DFFFBBMOJKB(int KJLNIBNFALP, long DIMOGDCMBFM, long MMMJFAODPOA, HCEEFOPOCMM LKIPKDFOIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x6FF27D0", Offset = "0x6FF19D0", VA = "0x186FF27D0", Slot = "6")]
	[IteratorStateMachine(typeof(NOKHNFDAFNO))]
	public IEnumerable<NCKGPLMHNNB> OIPJIEMLAMM(HCEEFOPOCMM LKIPKDFOIKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2680", Offset = "0x6FF1880", VA = "0x186FF2680", Slot = "7")]
	public NCKGPLMHNNB NINJAPGBAPF(long DIMOGDCMBFM, long MMMJFAODPOA, JBBKCFOEFFA HLJMJFBMCDD, HCEEFOPOCMM LKIPKDFOIKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AD")]
internal static class IIIFNHKDNCH
{
	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3CE0", Offset = "0x6FF2EE0", VA = "0x186FF3CE0")]
	internal static byte[] HBPMLDJOMEN(byte[] DDNKCFIIBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3DA0", Offset = "0x6FF2FA0", VA = "0x186FF3DA0")]
	public static void JBIAPOEPLLI(Stream EDOGOHPOPNO, byte[] HNENGEFLMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3E20", Offset = "0x6FF3020", VA = "0x186FF3E20")]
	public static bool NOCKNFNDHKD(Stream EDOGOHPOPNO, long DMNDKKPPFFL, IOPFFLOBCBM KBOLGJGNIGE, [Out] byte[] ANCDIFNJCND)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
internal sealed class BJBFNGEEGKK : NCKGPLMHNNB, IEquatable<NCKGPLMHNNB>, IEquatable<BJBFNGEEGKK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400072E")]
	private readonly FNABHGGPMDG EKGGLPDLAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400072F")]
	public readonly FileInfo MNCEOGOIGEH;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public NJNINEFDHOO LDONDENFFCN
	{
		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x69BA380", Offset = "0x69B9580", VA = "0x1869BA380", Slot = "9")]
		get
		{
			return default(NJNINEFDHOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public DateTime CDOJLDGOHIF
	{
		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1F00", Offset = "0x6FF1100", VA = "0x186FF1F00", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x6FF21D0", Offset = "0x6FF13D0", VA = "0x186FF21D0")]
	public BJBFNGEEGKK(FNABHGGPMDG OJKACGONHKN, FileInfo LHALDDCEPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2120", Offset = "0x6FF1320", VA = "0x186FF2120", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2060", Offset = "0x6FF1260", VA = "0x186FF2060", Slot = "5")]
	public void IGLJKNPEBFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1F90", Offset = "0x6FF1190", VA = "0x186FF1F90", Slot = "6")]
	public bool FLEPJADKKGI(long DIMOGDCMBFM, long MMMJFAODPOA, [Out] JBBKCFOEFFA HLJMJFBMCDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1E20", Offset = "0x6FF1020", VA = "0x186FF1E20", Slot = "7")]
	public bool Equals(NCKGPLMHNNB OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1D60", Offset = "0x6FF0F60", VA = "0x186FF1D60", Slot = "8")]
	public bool Equals(BJBFNGEEGKK OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1C70", Offset = "0x6FF0E70", VA = "0x186FF1C70", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x6FF1FD0", Offset = "0x6FF11D0", VA = "0x186FF1FD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
public delegate void IOPFFLOBCBM(BODEGEDJFLM.KNDNPIAAOJO KLOBGAANGMC, string JNNDBFGKHHD);
[Cpp2IlInjected.Token(Token = "0x20001B0")]
internal interface PDMHIOFNOPB
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	NJNINEFDHOO LDONDENFFCN
	{
		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GABAFEMFKLM(long DIMOGDCMBFM, long MMMJFAODPOA, HCEEFOPOCMM LKIPKDFOIKO, [Out] NCKGPLMHNNB NHABHPPMDON);

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<NCKGPLMHNNB> OIPJIEMLAMM(HCEEFOPOCMM LKIPKDFOIKO);

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
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
