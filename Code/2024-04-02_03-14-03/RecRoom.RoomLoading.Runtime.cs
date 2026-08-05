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
		[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x67246D0", Offset = "0x67232D0", VA = "0x1867246D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DB530", Offset = "0x7DA130", VA = "0x1807DB530")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DB570", Offset = "0x7DA170", VA = "0x1807DB570")]
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
	public class LogRegistrationIndex : DHLIEKNFJHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x671BB50", Offset = "0x671A750", VA = "0x18671BB50", Slot = "4")]
		public override void FAEDNEGPAEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MHJOFOLLLGB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x671C020", Offset = "0x671AC20", VA = "0x18671C020")]
	public MHJOFOLLLGB(string COECLHOAJJF, Exception PFLAIKMDCHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class BLLLFPDIHEL : PAMKDKMPIDB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct HPIAFFCLCIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<JPFIIAMMGLD>> <>t__builder;

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
		private TaskAwaiter<JIEAHHFKLNI<JPFIIAMMGLD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6714910", Offset = "0x6713510", VA = "0x186714910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6714B50", Offset = "0x6713750", VA = "0x186714B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct NNBMLCBLDJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<DFOKONDMHLJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<DFOKONDMHLJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6723960", Offset = "0x6722560", VA = "0x186723960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6723B70", Offset = "0x6722770", VA = "0x186723B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	[UnityEngine.Scripting.Preserve]
	public BLLLFPDIHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x670B250", Offset = "0x6709E50", VA = "0x18670B250", Slot = "4")]
	[AsyncStateMachine(typeof(HPIAFFCLCIL))]
	public Task<IReadOnlyList<JPFIIAMMGLD>> GFMKOKHFBAC(long MGDJPIEDFNB, long FLKBFMIKIPD, [Optional] CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x670B140", Offset = "0x6709D40", VA = "0x18670B140", Slot = "5")]
	[AsyncStateMachine(typeof(NNBMLCBLDJK))]
	public Task<IReadOnlyList<DFOKONDMHLJ>> FHBDGGELCFP(IReadOnlyList<int> IJENEPJCNGF, [Optional] CancellationToken EJGJLLMBDIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OBEGEBDHIMO : IEquatable<OBEGEBDHIMO>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int INCPPKEEOIL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	DFOKONDMHLJ HPPICNHOAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime GGMEPDEABCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	PBEIMPJAGEL? DJDKFLBNPOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	HHMGGNBAOJG? EFCGBEPHKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	MBCCKIIMHAA IKHDEGAAADH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<HAGKOKKBGGA> OCGMPANPHPI();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum MBCCKIIMHAA
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PAMKDKMPIDB
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<JPFIIAMMGLD>> GFMKOKHFBAC(long MGDJPIEDFNB, long FLKBFMIKIPD, [Optional] CancellationToken EJGJLLMBDIN);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<DFOKONDMHLJ>> FHBDGGELCFP(IReadOnlyList<int> IJENEPJCNGF, [Optional] CancellationToken EJGJLLMBDIN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class DJFOPJLMIBL
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class BHMGJDBDGIB : OBEGEBDHIMO, IEquatable<OBEGEBDHIMO>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct JNEMJBACBBB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<HAGKOKKBGGA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public BHMGJDBDGIB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private AFGLODOCJFH <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<EOHIAKIOJAN> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<HAGKOKKBGGA> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x67163A0", Offset = "0x6714FA0", VA = "0x1867163A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6716840", Offset = "0x6715440", VA = "0x186716840", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly JPFIIAMMGLD BNNJNEHDBMF;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int INCPPKEEOIL
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7B1560", Offset = "0x7B0160", VA = "0x1807B1560", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public DFOKONDMHLJ HPPICNHOAFG
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime AMIAGCCEOFB
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x53E2400", Offset = "0x53E1000", VA = "0x1853E2400", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public PBEIMPJAGEL? DJDKFLBNPOP
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1A06500", Offset = "0x1A05100", VA = "0x181A06500", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public HHMGGNBAOJG? EFCGBEPHKEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x53E24E0", Offset = "0x53E10E0", VA = "0x1853E24E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MBCCKIIMHAA IKHDEGAAADH
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8729D0", Offset = "0x8715D0", VA = "0x1808729D0", Slot = "10")]
			get
			{
				return default(MBCCKIIMHAA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x670AFE0", Offset = "0x6709BE0", VA = "0x18670AFE0", Slot = "9")]
		[AsyncStateMachine(typeof(JNEMJBACBBB))]
		public Task<HAGKOKKBGGA> OCGMPANPHPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x670B0E0", Offset = "0x6709CE0", VA = "0x18670B0E0")]
		public BHMGJDBDGIB(int IKBGDFJOBFI, DFOKONDMHLJ MIHMKNGJLNA, JPFIIAMMGLD BNNJNEHDBMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x670ADF0", Offset = "0x67099F0", VA = "0x18670ADF0", Slot = "11")]
		public bool Equals(OBEGEBDHIMO NAFFCAIMPLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x670AE80", Offset = "0x6709A80", VA = "0x18670AE80", Slot = "0")]
		public override bool Equals(object OGGNGHKHHGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x670AFA0", Offset = "0x6709BA0", VA = "0x18670AFA0")]
		private bool NFHILJJMBOL(BHMGJDBDGIB NAFFCAIMPLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x670AF20", Offset = "0x6709B20", VA = "0x18670AF20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class CJKALAAFEMO : OBEGEBDHIMO, IEquatable<OBEGEBDHIMO>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct IOADIIANECE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<HAGKOKKBGGA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public CJKALAAFEMO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<HAGKOKKBGGA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6715B00", Offset = "0x6714700", VA = "0x186715B00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6715D30", Offset = "0x6714930", VA = "0x186715D30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly GEKIPCCOKMO MBKJKIGCLDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly PBEIMPJAGEL ABICADEBCPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly HHMGGNBAOJG KAMNHLNJMCC;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int INCPPKEEOIL
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x670BE00", Offset = "0x670AA00", VA = "0x18670BE00", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public DFOKONDMHLJ HPPICNHOAFG
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x670BE90", Offset = "0x670AA90", VA = "0x18670BE90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime AMIAGCCEOFB
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x670BD30", Offset = "0x670A930", VA = "0x18670BD30", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public PBEIMPJAGEL? DJDKFLBNPOP
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x670BE40", Offset = "0x670AA40", VA = "0x18670BE40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public HHMGGNBAOJG? EFCGBEPHKEN
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x670BB90", Offset = "0x670A790", VA = "0x18670BB90", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public MBCCKIIMHAA IKHDEGAAADH
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x91C340", Offset = "0x91AF40", VA = "0x18091C340", Slot = "10")]
			get
			{
				return default(MBCCKIIMHAA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xEFBA90", Offset = "0xEFA690", VA = "0x180EFBA90")]
		public CJKALAAFEMO(GEKIPCCOKMO JFCBPOJCGFH, PBEIMPJAGEL GJFIHJBLNML, HHMGGNBAOJG ONCAMGPINNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x670BF80", Offset = "0x670AB80", VA = "0x18670BF80", Slot = "9")]
		[AsyncStateMachine(typeof(IOADIIANECE))]
		public Task<HAGKOKKBGGA> OCGMPANPHPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x670BBE0", Offset = "0x670A7E0", VA = "0x18670BBE0", Slot = "11")]
		public bool Equals(OBEGEBDHIMO NAFFCAIMPLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x670BC80", Offset = "0x670A880", VA = "0x18670BC80", Slot = "0")]
		public override bool Equals(object OGGNGHKHHGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x670BF20", Offset = "0x670AB20", VA = "0x18670BF20")]
		private bool NFHILJJMBOL(CJKALAAFEMO NAFFCAIMPLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x670BD80", Offset = "0x670A980", VA = "0x18670BD80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class HNDEFGBAAIF : OBEGEBDHIMO, IEquatable<OBEGEBDHIMO>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct BNOFIOGOLFI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<HAGKOKKBGGA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<HAGKOKKBGGA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x670B370", Offset = "0x6709F70", VA = "0x18670B370", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x670B5B0", Offset = "0x670A1B0", VA = "0x18670B5B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly DFOKONDMHLJ POGHLOCMMMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly PBEIMPJAGEL ABICADEBCPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly HHMGGNBAOJG KAMNHLNJMCC;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int INCPPKEEOIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6713C40", Offset = "0x6712840", VA = "0x186713C40", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public DFOKONDMHLJ HPPICNHOAFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime AMIAGCCEOFB
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7B0210", Offset = "0x7AEE10", VA = "0x1807B0210", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public PBEIMPJAGEL? DJDKFLBNPOP
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6713C60", Offset = "0x6712860", VA = "0x186713C60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public HHMGGNBAOJG? EFCGBEPHKEN
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6713930", Offset = "0x6712530", VA = "0x186713930", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public MBCCKIIMHAA IKHDEGAAADH
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7B0210", Offset = "0x7AEE10", VA = "0x1807B0210", Slot = "10")]
			get
			{
				return default(MBCCKIIMHAA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xEFBA90", Offset = "0xEFA690", VA = "0x180EFBA90")]
		public HNDEFGBAAIF(DFOKONDMHLJ MIHMKNGJLNA, PBEIMPJAGEL GJFIHJBLNML, HHMGGNBAOJG ONCAMGPINNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6713D90", Offset = "0x6712990", VA = "0x186713D90", Slot = "9")]
		[AsyncStateMachine(typeof(BNOFIOGOLFI))]
		public Task<HAGKOKKBGGA> OCGMPANPHPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6713AA0", Offset = "0x67126A0", VA = "0x186713AA0", Slot = "11")]
		public bool Equals(OBEGEBDHIMO NAFFCAIMPLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6713980", Offset = "0x6712580", VA = "0x186713980", Slot = "0")]
		public override bool Equals(object OGGNGHKHHGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6713BB0", Offset = "0x67127B0", VA = "0x186713BB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6713CB0", Offset = "0x67128B0", VA = "0x186713CB0")]
		private bool NFHILJJMBOL(HNDEFGBAAIF NAFFCAIMPLI)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct AGKBGKDMMEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<OBEGEBDHIMO>> <>t__builder;

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
		public DJFOPJLMIBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<JPFIIAMMGLD> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<JPFIIAMMGLD>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, DFOKONDMHLJ account, JPFIIAMMGLD roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6707FD0", Offset = "0x6706BD0", VA = "0x186707FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6708DB0", Offset = "0x67079B0", VA = "0x186708DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct IGJLJMPIKPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, DFOKONDMHLJ account, JPFIIAMMGLD roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<JPFIIAMMGLD> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public DJFOPJLMIBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<DFOKONDMHLJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6714BC0", Offset = "0x67137C0", VA = "0x186714BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x67155B0", Offset = "0x67141B0", VA = "0x1867155B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly CHOMCPFFNMB OGAGCGEBLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly PAMKDKMPIDB PFBKAOFNHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly BMEFCDCOBGJ HNJDHACHJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly OPKNNDEGFGB<(long, long), IReadOnlyList<JPFIIAMMGLD>> ELFIDOHEPDJ;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x670DDD0", Offset = "0x670C9D0", VA = "0x18670DDD0")]
	[UnityEngine.Scripting.Preserve]
	public DJFOPJLMIBL([NNEMKPMNJAE(null)] PAMKDKMPIDB GLEOPPDNGGN, [NNEMKPMNJAE(null)] BMEFCDCOBGJ DPGICEFLMEM, [NNEMKPMNJAE(null)] CHOMCPFFNMB PKHFJCMNGKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x670D9D0", Offset = "0x670C5D0", VA = "0x18670D9D0")]
	[AsyncStateMachine(typeof(AGKBGKDMMEL))]
	public Task<IList<OBEGEBDHIMO>> AMLABAIPFIE(long MGDJPIEDFNB, long FPCFGLFPIMK, bool FECEHACOEKP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x670DC30", Offset = "0x670C830", VA = "0x18670DC30")]
	private bool JONNMINBBFL(DateTime? OPLDBGBBIBD, long MGDJPIEDFNB, long FPCFGLFPIMK, [Out] GEKIPCCOKMO FEBLDJCELMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x670DB20", Offset = "0x670C720", VA = "0x18670DB20")]
	[AsyncStateMachine(typeof(IGJLJMPIKPE))]
	private Task<IReadOnlyList<(int, DFOKONDMHLJ, JPFIIAMMGLD)>> JAEIONIFFNF(IReadOnlyList<JPFIIAMMGLD> BLENEPHMCMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BMEFCDCOBGJ
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<GEKIPCCOKMO> PLLDJPLFJAK;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OEECCCFBHKA(long MGDJPIEDFNB, long FPCFGLFPIMK, NJFIHEFGFDH LMDPDBHCJEG, NBPGIDCICPL GKFJBPLKJAE);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CLKMIODDEGD(long MGDJPIEDFNB, long FPCFGLFPIMK, [Out] GEKIPCCOKMO FEBLDJCELMO);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NCJGBBKMMDM(long MGDJPIEDFNB, long FPCFGLFPIMK, NBPGIDCICPL GKFJBPLKJAE, [Out] GEKIPCCOKMO FEBLDJCELMO);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GGALEODDKDH(long MGDJPIEDFNB, long FPCFGLFPIMK);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface GFEHHOKDKNO : KINGOFPACJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool APECJAOPGJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task DNICAOLMKKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DCDLNIPBOEJ(Task BKPEJJIHAHC, string BPLOMNOMILF);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface FKNCPDJFAMI : KINGOFPACJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HAGKOKKBGGA> EHAHEDNGODI(GEKIPCCOKMO FEBLDJCELMO);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BOGNDIAPNPD(CancellationToken EJGJLLMBDIN);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface NDAGHOBLHOB : KINGOFPACJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	MNMJHIIHKJP AOHOIIFNJAP
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DPHMFKABNMP();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DNCPNKILOIJ();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface KINGOFPACJO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HAJAGMDCLHL(OEENMHGGAHN KLNOEOGFLGJ);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface KFAFPFCILEP
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan IHOKAMPGJCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan MHEKPAMIBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan EGDPCJMJLIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan AKCGLBKEODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool HHGHOOBJMHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool EHPBCIJBOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool ELMMJBDHAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int OIAEAODFJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool EPIDOGIEFLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool DODDHHECNHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum JNKPJJDHOMC
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum GAHKMCKFJJJ
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
public struct PBDIFHMPODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long NNCEFMNLAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long FLKBFMIKIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly JNKPJJDHOMC CJEAJMFMNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception BADNNOBAPJM;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x67256A0", Offset = "0x67242A0", VA = "0x1867256A0")]
	public PBDIFHMPODG(long NNCEFMNLAMF, long FLKBFMIKIPD, JNKPJJDHOMC CJEAJMFMNNJ, [CanBeNull] Exception BADNNOBAPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6725650", Offset = "0x6724250", VA = "0x186725650")]
	public static PBDIFHMPODG APADDLNAEBN(JENGLAFMNAE OIIJIIBDCGH, JNKPJJDHOMC CJEAJMFMNNJ, [Optional] Exception BADNNOBAPJM)
	{
		return default(PBDIFHMPODG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public delegate void FNAFABKPKJL(PBDIFHMPODG NJNINILBPDK);
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface FOLJNBPENFB : KINGOFPACJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action BACIMDDNEBB;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event FNAFABKPKJL EGEDOBHHGAC;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event FNAFABKPKJL DAIKGMIHFEG;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event FNAFABKPKJL HEOABEBHLEH;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<GAHKMCKFJJJ, bool> IBBJMNGEEFA;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ODEFFFILHIA();

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KJKBIIGICED(PBDIFHMPODG NJNINILBPDK);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GHCHBCNFKDK(PBDIFHMPODG NJNINILBPDK);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PLBDJCLOEDJ(PBDIFHMPODG NJNINILBPDK);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GNJKBADIEON(GAHKMCKFJJJ ACDBBCINPON, bool DHFBKAPIONA);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface EOOHCGOPALF : KINGOFPACJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task EEGHDIDKDGE();

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JOFOLLBNKKK();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface KHMMPJOGLIM : KINGOFPACJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TaskStatus ICEJODFAAEK
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task EHKDPCNDIOC(JENGLAFMNAE PBJKAENPEMP, JCNLMJJPKDF ECADBFJFBGH, CancellationToken NFEFCAGIEPH);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class LHJAECFBDMD
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x671BB00", Offset = "0x671A700", VA = "0x18671BB00")]
	public static bool KJMJKDCMALK(this KHMMPJOGLIM JANPGPNIJLJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public delegate Task IKMLAGKNNKI(GPMIMHCABEE MAOJLJBOFIK, CancellationToken DGPOLLDAHJK);
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface OEOCHODKCLE : KINGOFPACJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JELKMAJFAMP(IKMLAGKNNKI JGBCCLGMFCH);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface OEENMHGGAHN : AFGLODOCJFH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CancellationToken AEIIMJNIEDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	OJEGDOKHPNO HAMOMEBNMGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	IILECEBHMOO ENNPACHDKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	FDMBAAMNDEP GBGNGGADHEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NCPOJFNGNHJ KOIOJGFJDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	GJAJGPAHGBO FADJPPPEIIH
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	JOAOOFHFNGE MFMEIDCDKPA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	OFPGEKNONIJ FPIOAJDPCBB
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	FKNHFKFGPNP CILHHMMODOE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	GFEHHOKDKNO MMDNPOJNPNH
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	FKNCPDJFAMI FINPBEKJEBI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	FOLJNBPENFB OGHJEEDILFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	EOOHCGOPALF MAFGEKLELEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	KHMMPJOGLIM EHAPJMCKDFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	OEOCHODKCLE PADMCDBHCBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	DODMCLJGNGH FOOPDHNDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	MBMBLPNEHHG FCBKFDAJAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	KPMEJKPDGDP GEGIONPDPOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	GKFEGHGDEHH NJGNMDIIHIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	DDDLPBOPCJH AIACEENPIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	GCDHECDBFHP KEOAALJPHJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	HJEOEBFAIKO NMKBPGDJAID
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	FLCMKIENGNI FLLHKGJFMCC
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	BDNKNOODLOF ACKPEPGHKDN
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	ODMMMMBOMOJ NONEMFHMACN
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	NDAGHOBLHOB MBIAEIDOGLA
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	KFAFPFCILEP IPFAONGAAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	HCEKDBKMJPN JAHDKNCCGMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	BMEFCDCOBGJ CLHOJKFHHED
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	MGCBNOFKFNA FEGJFJDKLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	IGMACCECEBE MLKBKFANBPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	EBEHLNDFOAM GHDPDAPFFCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void CDGLPABMGND(JCNLMJJPKDF PCOHFDNGICC);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface DODMCLJGNGH : KINGOFPACJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AJPELLBGLGP BGJHDHHBMPP(Guid BJNGDHCNCJP);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DMBJGENFJDP(Guid BJNGDHCNCJP);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OFFKFPIENLO(Guid BJNGDHCNCJP, Task MGGINNBKKGC);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IGPMOOHIEKN(Guid BJNGDHCNCJP, HAGKOKKBGGA LCDACBKPLJM);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(HAGKOKKBGGA, Task)> PBFGDGFADKI(Guid BJNGDHCNCJP);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface HBKOLBMJMCG : KINGOFPACJO, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface MBMBLPNEHHG : KINGOFPACJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EOCAFOFEBCF(GAGOKAHMDNO COECLHOAJJF);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PDACPPBIHLN(GAGOKAHMDNO COECLHOAJJF);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<IDCOIPDFBIB> NJHHPDPCCBD(CancellationToken JBHIKAGOLCH);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface KPMEJKPDGDP : KINGOFPACJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AJPELLBGLGP CLGGPHPBCHF(GAGOKAHMDNO FABPGJPKKAF);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ABEKLKJCKKP(Guid BJNGDHCNCJP, Task MGGINNBKKGC);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface GKFEGHGDEHH : KINGOFPACJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HAGKOKKBGGA> NJGNMDIIHIH(GAGOKAHMDNO CGFOLHGCPPN);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface DDDLPBOPCJH : KINGOFPACJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CGNOFECNPIB> KKALOJINMDA(DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, JENGLAFMNAE PBJKAENPEMP, CancellationToken EJGJLLMBDIN);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface HJEOEBFAIKO : KINGOFPACJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HAGKOKKBGGA GPILHJLEAFD(IFDGJPHDBFK NKEHCHDOADO);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GGLLJFOHCLN(string CMCOOMKLEBK);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface GCDHECDBFHP : KINGOFPACJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GAGOKAHMDNO> PDGOCPCFPCI(GAGOKAHMDNO MLHMNLDOBPP, IOAFANGBINH IJPCDOKMFBA, CancellationToken EJGJLLMBDIN);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<GAGOKAHMDNO> BMOEGBJGPHN(CancellationToken EJGJLLMBDIN, IOAFANGBINH IJPCDOKMFBA);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GHPEMABLJJA FOFLBKDIOJL(PBAGONGALMM CDPDFLHGOOD, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GHPEMABLJJA DAMFDEBLGCJ(PBAGONGALMM CDPDFLHGOOD, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface FLCMKIENGNI : KINGOFPACJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HAGKOKKBGGA MBBPMKNMEJF(IFDGJPHDBFK NKEHCHDOADO, IDCOIPDFBIB JLFKIJMCLBB);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HAGKOKKBGGA NOMIKOCAHOP(IFDGJPHDBFK HMLJMNEDGLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface BDNKNOODLOF
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DDJMEHEAHOE(PDEAPHDCOIE LGPHFIFJFJM);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IHILCAGBAJM(PDEAPHDCOIE LGPHFIFJFJM);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IFHKPFMPPJJ(PDEAPHDCOIE LGPHFIFJFJM);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LKPBKOLCLMK(PDEAPHDCOIE LGPHFIFJFJM);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class PDEAPHDCOIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly JENGLAFMNAE DDAGGAOPIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> BPFBPENHFPL;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public DBCLHGHLEMD<string> BLLGHBHOMOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B40", Offset = "0x7B1740", VA = "0x1807B2B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
	public PDEAPHDCOIE(JENGLAFMNAE OANIEGOBMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x67257D0", Offset = "0x67243D0", VA = "0x1867257D0")]
	public PDEAPHDCOIE LAPHPCKDJFH(string CGGNJKGENIH, string BLKAHBIJBJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6725740", Offset = "0x6724340", VA = "0x186725740")]
	public bool GOMHNHMDCMF([Out] IEnumerable<KeyValuePair<string, string>> LDJCHMNOGAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5A69E00", Offset = "0x5A68A00", VA = "0x185A69E00")]
	public PDEAPHDCOIE DOHAHOPCHHA(DBCLHGHLEMD<string> KAMOOCNEONO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface HCEKDBKMJPN
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool HMEKAOHFFCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	string KAPJENAIBNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool NNMENFMFBGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EHCCIFMCCKB();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IKJFFMMBPPE CLLKFPFFELH(long NGMKLALOJDI);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OBPOJGLFOBK<PBNLADHBLCA, MHLNEPCFHJN> DOJNEBEJKPC(long NGMKLALOJDI);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OBPOJGLFOBK<PBNLADHBLCA, KAILJKAMMLK> KCJDBLCADGG(long NGMKLALOJDI);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	OBPOJGLFOBK<long, MHMDDPIMCBA> MFPJJKOIDLB();

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LHIPCILMCOD(long NGMKLALOJDI, [Out] bool OOPPELNFNBP);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> EALKAMHAOMF(byte[] DNCEPNILLJE, byte[] BDEPKDCJGAK, CancellationToken EJGJLLMBDIN);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface AFGLODOCJFH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool KJMJKDCMALK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool HLJFFKBADOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	JCNLMJJPKDF HDHEKNDEBLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action BACIMDDNEBB;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event FNAFABKPKJL EGEDOBHHGAC;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event FNAFABKPKJL DAIKGMIHFEG;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event FNAFABKPKJL HEOABEBHLEH;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<GAHKMCKFJJJ, bool> IBBJMNGEEFA;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JOFOLLBNKKK();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	KPHNEGJGLOF FNNDDPCFIJH();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	DPOFENGHMKM DCPILJDBLCE();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<HAGKOKKBGGA> EHAHEDNGODI(GEKIPCCOKMO JFCBPOJCGFH);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task BOGNDIAPNPD(CancellationToken EJGJLLMBDIN);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface GJAJGPAHGBO
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool LEHCGIBKNKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string DGDAAACAMMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNOHPHDIGHC(Scene EHLIFOIBJKP);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task JLKENJCGMCO(PAJJLMJCCHC EEKKLICNKBB, CancellationToken EJGJLLMBDIN);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task KNGCKDLIMII();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface NCPOJFNGNHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	EELKBCOPMKF GFOFKJKPJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool EKMNIAMNNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool OLHDPEPILAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool IOOEHGJFDNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool NKNFDLBCIIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool OHGFCJENHIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool BFMKPLMKAPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool FHOGNOCOCHL
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	float GCAMKDNEPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> IFIIOJPANOE;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OJEGDOKHPNO POFEIBPNIHO(OJEGDOKHPNO GHINPDOJACO);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LNOHJCNLBJO(OJEGDOKHPNO JEAKPHJODOO);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NDJDOBHCCCH();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task DGFJHEHIACL(DBCLHGHLEMD<string>.OGCCDEKKEPE CDEGEPAMGDA, CancellationToken EJGJLLMBDIN);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KANGCBFNAGF(float MKBLEIDLDAF);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JOBCDEHGPPP(string KHJIEAFENDF);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<PFKOEEMDGOH> NJLEILOAFBB();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable FGMMHGGCLFC(object LAMCDJBBCDK, PFKOEEMDGOH LIEBEJAOEBM);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	MHLNEPCFHJN NONGLMAJINH(IEnumerable<LJJGPBMCLBA> OKOKJGBIJME);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FHHHALGPFNH(int HGPDOHBCNJK);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task GICOIAMFPJK();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OHPIEICKPNP();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool GLABAEHIPIC();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task ELOLHDKLJBE(CancellationToken EJGJLLMBDIN);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task DOCFAMOLHPH(CancellationToken EJGJLLMBDIN);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<IJPNKHBIBCD> DDBOIJKFICH(DateTime BPFHNCHPKDG, CancellationToken EJGJLLMBDIN);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<bool> GMGBKFCMCKM(CancellationToken EJGJLLMBDIN);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void EDNIGMLLPBH(string ADPDONPDLBA = "", float FBOJEGKGGFB = 3f);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "23")]
	FPNDLBGAGEC JIBGCDGOOAA(JBEHIOFFAIM NBIHJDKAMLA, KDFHOLOHIGA HFEJFGIGBPH, KAILJKAMMLK IGNDJEHIDIE, IEnumerable<PersistenceView> MGELHEOMGDD, MILKCCKGIBO GEGIAKKFEFM);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void LBJJMBHFOEP(KAILJKAMMLK IGNDJEHIDIE);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void HBOKPLELGIL(LJJGPBMCLBA AIAFICPGPCD, [In] FPNDLBGAGEC LDBMCHPCEOC);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task NGHLPMCHOJG(KAILJKAMMLK FGEOGAODJCF, bool CFLEMFJDOOP, CancellationToken EJGJLLMBDIN);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task LMKONPBNEDI(CancellationToken EJGJLLMBDIN);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void NCGFPBPKCJF(long MGDJPIEDFNB, long FLKBFMIKIPD, EOHIAKIOJAN GMBOAKOAEEF, JPFIIAMMGLD IIJFKOAGDDP, NJFIHEFGFDH LMDPDBHCJEG, KCLHKFMCGHF? KEMGBKKIEOD, CGLPPOIENKE? HLMODPDGJJL);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void EMBFIFKLOBA(long MGDJPIEDFNB, long FLKBFMIKIPD, CGLPPOIENKE? HLMODPDGJJL);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void IKPFCNOBFDE(PersistenceView POJODNAJJBL);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool APGMHCDMIIE(PersistenceView BPGBGHDKKFL);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool AGPHAMCKDAE(LJJGPBMCLBA AIAFICPGPCD, LPGOBKPNDLH CPEEBGFGIHC, [Out] PBKGAKIMKJB ODPJCJHONKD);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task JEAPFDHGFCO(CancellationToken EJGJLLMBDIN);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void KDGDGIPLJPL();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "35")]
	IDisposable FEAIDBJJHDP();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void EAOLLBKIOFD(KAILJKAMMLK FGEOGAODJCF, LPGOBKPNDLH CPEEBGFGIHC);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Task<bool> GFCKKIFMEGL(IILECEBHMOO GHMLFJKNGCO, CancellationToken EJGJLLMBDIN, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void DJEPCFFEMIC(CancellationToken EJGJLLMBDIN);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<GILBFMDGNPJ> HANCHNCFPKE(NILEPDAMHLA MLHMNLDOBPP);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<EOHIAKIOJAN> BNNOJBKPPLD(long MGDJPIEDFNB, bool KFJHMAFLAIM, CancellationToken EJGJLLMBDIN);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<JPFIIAMMGLD> CMBFOABFNIC(long MGDJPIEDFNB, long FLKBFMIKIPD, long GLPKLLPKLFE, CancellationToken EJGJLLMBDIN);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<HFEHGMAKIHJ> FNPONDNIMPN(string EOAALFBIDOK, CancellationToken EJGJLLMBDIN);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<HFEHGMAKIHJ> MDDEPDPCBMD(string EOAALFBIDOK, long MGDJPIEDFNB, long FLKBFMIKIPD, string FJDNDBMAKEF, IHANGNLMDAL.DPNKFNDKGEA MAOJLJBOFIK, IHANGNLMDAL.DPNKFNDKGEA BDEPKDCJGAK, int PEBMEEJPPHO);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool DAJCNFODLFF();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool HIJLHMPBKKJ();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool OPLNGPLAKAO(IEnumerable<PBKGAKIMKJB> NINMKHKOKEB);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void LKOJMPCIJNN(List<GameObject> LAMPFMNKNEL);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "49")]
	float CCMMMHOPJDJ();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "50")]
	Task<Scene> FELAPDICJOI(string MIKEHJBIAOG, LoadSceneMode EHJNIGHCIEH, bool KPPDPLFKNAG, DBCLHGHLEMD<string>.OGCCDEKKEPE KAMOOCNEONO);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void JAAAPICPKIM();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void OBHOOCGLFFI(bool OOAKOKIGOGO);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void PLMKIFHKICG(JENGLAFMNAE FMBCMIJJNFA);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "59")]
	Task MOFJLKKHDBB(DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "60")]
	Task PFLHFLLMPPD(DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "61")]
	Task KJDLBCCEMLD(DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "62")]
	IDisposable NJDGMNNLJKM();

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "63")]
	OHOCGHNOABF FCFIKBLOIKI();

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "64")]
	Task HEGIGAJMDHM(CancellationToken EJGJLLMBDIN);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface OHOCGHNOABF
{
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DENDHEBLGFE(CancellationToken EJGJLLMBDIN);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HOPJPILKKCM(CancellationToken EJGJLLMBDIN);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct FPNDLBGAGEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> DMKCNMGGEON;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum IJPNKHBIBCD : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct JBEHIOFFAIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string JMANPIAOOFN;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface EELKBCOPMKF
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	JENGLAFMNAE ABOJJHFMNIG
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	EOHIAKIOJAN PABKEANJOMP
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	GOCLPCOPMCO PEHMBPJFFFM
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool ABPLMGGNKCH
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool KIAFMMCLOJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	int HOKCIJGPBBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action FPCEKGEPICP;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> BKEEFPNLGNN;

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NLPAMAMIKDN();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.GKGMBNIMODP> JJFEBABLJEN(long NGMKLALOJDI, [Optional] CancellationToken EJGJLLMBDIN);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<LDAKHHJJNAL> KHGDEEDJFIB();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task HPKPMGKAGHJ();

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(JENGLAFMNAE, JCNLMJJPKDF) NJPBLMHJGPH();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "15")]
	ICIKGNAKMLM PGJPGHBJHCO();

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LCONGJHKGEN(long NGMKLALOJDI);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface ODMMMMBOMOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KDHICPGKFGJ([Out] IEnumerable<int> CDIHDCIOKBC);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPPPDFIGGID(CAPELAHPHJP DGPOLLDAHJK);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DEMPJJOAHEA(CAPELAHPHJP DGPOLLDAHJK);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface FCOOBDKOOHG
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string FBJLFAGLBAG(HAGKOKKBGGA OGBAEECNMFD);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface LMMOAKJEDAK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PEOPFBOBDNJ(GGDKCBKAOBH.MAKKGAAOKAJ FDNGFEGPIDH);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HGAOEHOEDHG(GGDKCBKAOBH.MAKKGAAOKAJ FDNGFEGPIDH);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface JOAOOFHFNGE : LMMOAKJEDAK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HAGKOKKBGGA JHANMCAFANL(IFDGJPHDBFK HMLJMNEDGLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface OFPGEKNONIJ : LMMOAKJEDAK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HAGKOKKBGGA GPILHJLEAFD(IFDGJPHDBFK ANJKAMGJFHP);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface IKJFFMMBPPE
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DGKNLHNBBJB<PAJJLMJCCHC, PHFFNBEEJOM>> EJFCCKPELHF(string FJDNDBMAKEF, long NGMKLALOJDI, long? MGDJPIEDFNB, long? FLKBFMIKIPD, MIEEKFFIHAB.FDNHOCOAACA JOGJGGAMIAA, CancellationToken EJGJLLMBDIN);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface OBPOJGLFOBK<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DGKNLHNBBJB<POBLOMHIDDD<TData>, PHFFNBEEJOM>> PCGPMOOJKEL(TGetDataArg KPLKBKJIAEI, CancellationToken EJGJLLMBDIN);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class MMHJELMJIIA : OEENMHGGAHN, AFGLODOCJFH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct MANLODDNGBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder<HAGKOKKBGGA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public MMHJELMJIIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public GEKIPCCOKMO autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<HAGKOKKBGGA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x671BD30", Offset = "0x671A930", VA = "0x18671BD30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x671BFB0", Offset = "0x671ABB0", VA = "0x18671BFB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct CPBMHJHGEEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public MMHJELMJIIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x670C760", Offset = "0x670B360", VA = "0x18670C760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x670C990", Offset = "0x670B590", VA = "0x18670C990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class PIANEDHAOGK : IEnumerable<KINGOFPACJO>, IEnumerable, IEnumerator<KINGOFPACJO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private KINGOFPACJO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public MMHJELMJIIA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		private KINGOFPACJO System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x808950", Offset = "0x807550", VA = "0x180808950")]
		[DebuggerHidden]
		public PIANEDHAOGK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x67258F0", Offset = "0x67244F0", VA = "0x1867258F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x6725D50", Offset = "0x6724950", VA = "0x186725D50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6725CA0", Offset = "0x67248A0", VA = "0x186725CA0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KINGOFPACJO> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6725CA0", Offset = "0x67248A0", VA = "0x186725CA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource OEPJHAFDANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly OJEGDOKHPNO JEAKPHJODOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool KLIIIEHJHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private FBKAAHKANGB HJEOCDKJELB;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public IILECEBHMOO ENNPACHDKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7B1640", Offset = "0x7B0240", VA = "0x1807B1640", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7B1730", Offset = "0x7B0330", VA = "0x1807B1730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public FDMBAAMNDEP GBGNGGADHEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7B7990", Offset = "0x7B6590", VA = "0x1807B7990", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7B79E0", Offset = "0x7B65E0", VA = "0x1807B79E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public NCPOJFNGNHJ KOIOJGFJDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A00", Offset = "0x7B6600", VA = "0x1807B7A00", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7B79C0", Offset = "0x7B65C0", VA = "0x1807B79C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public GJAJGPAHGBO FADJPPPEIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A10", Offset = "0x7B6610", VA = "0x1807B7A10", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7B79B0", Offset = "0x7B65B0", VA = "0x1807B79B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public JOAOOFHFNGE MFMEIDCDKPA
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A20", Offset = "0x7B6620", VA = "0x1807B7A20", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7B79A0", Offset = "0x7B65A0", VA = "0x1807B79A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public OFPGEKNONIJ FPIOAJDPCBB
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7B79F0", Offset = "0x7B65F0", VA = "0x1807B79F0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7B79D0", Offset = "0x7B65D0", VA = "0x1807B79D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public FKNHFKFGPNP CILHHMMODOE
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7B1600", Offset = "0x7B0200", VA = "0x1807B1600", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7B1720", Offset = "0x7B0320", VA = "0x1807B1720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public GFEHHOKDKNO MMDNPOJNPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7B1650", Offset = "0x7B0250", VA = "0x1807B1650", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7B16D0", Offset = "0x7B02D0", VA = "0x1807B16D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public FKNCPDJFAMI FINPBEKJEBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7B1610", Offset = "0x7B0210", VA = "0x1807B1610", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7B1580", Offset = "0x7B0180", VA = "0x1807B1580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public FOLJNBPENFB OGHJEEDILFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x985820", Offset = "0x984420", VA = "0x180985820", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x984630", Offset = "0x983230", VA = "0x180984630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public EOOHCGOPALF MAFGEKLELEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7B1630", Offset = "0x7B0230", VA = "0x1807B1630", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7B16E0", Offset = "0x7B02E0", VA = "0x1807B16E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public KHMMPJOGLIM EHAPJMCKDFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x878330", Offset = "0x876F30", VA = "0x180878330", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x878450", Offset = "0x877050", VA = "0x180878450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public OEOCHODKCLE PADMCDBHCBG
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7BB8E0", Offset = "0x7BA4E0", VA = "0x1807BB8E0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7BB8C0", Offset = "0x7BA4C0", VA = "0x1807BB8C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public DODMCLJGNGH FOOPDHNDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA16DC0", Offset = "0xA159C0", VA = "0x180A16DC0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA1ED40", Offset = "0xA1D940", VA = "0x180A1ED40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public HBKOLBMJMCG FLFDMMHFGJA
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x961110", Offset = "0x95FD10", VA = "0x180961110", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x961120", Offset = "0x95FD20", VA = "0x180961120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public MBMBLPNEHHG FCBKFDAJAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9A7300", Offset = "0x9A5F00", VA = "0x1809A7300", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA1ECC0", Offset = "0xA1D8C0", VA = "0x180A1ECC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public KPMEJKPDGDP GEGIONPDPOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8F41D0", Offset = "0x8F2DD0", VA = "0x1808F41D0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x978A40", Offset = "0x977640", VA = "0x180978A40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public GKFEGHGDEHH NJGNMDIIHIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8FEE40", Offset = "0x8FDA40", VA = "0x1808FEE40", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x978A60", Offset = "0x977660", VA = "0x180978A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public DDDLPBOPCJH AIACEENPIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7BB890", Offset = "0x7BA490", VA = "0x1807BB890", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7BB8F0", Offset = "0x7BA4F0", VA = "0x1807BB8F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public GCDHECDBFHP KEOAALJPHJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x87F770", Offset = "0x87E370", VA = "0x18087F770", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x87C8F0", Offset = "0x87B4F0", VA = "0x18087C8F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public HJEOEBFAIKO NMKBPGDJAID
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8D4140", Offset = "0x8D2D40", VA = "0x1808D4140", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8D45A0", Offset = "0x8D31A0", VA = "0x1808D45A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public FLCMKIENGNI FLLHKGJFMCC
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8FECC0", Offset = "0x8FD8C0", VA = "0x1808FECC0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA1ED60", Offset = "0xA1D960", VA = "0x180A1ED60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public BDNKNOODLOF ACKPEPGHKDN
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x87F820", Offset = "0x87E420", VA = "0x18087F820", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x87C8D0", Offset = "0x87B4D0", VA = "0x18087C8D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public ODMMMMBOMOJ NONEMFHMACN
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8FEC60", Offset = "0x8FD860", VA = "0x1808FEC60", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA1ED20", Offset = "0xA1D920", VA = "0x180A1ED20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public NDAGHOBLHOB MBIAEIDOGLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9A6470", Offset = "0x9A5070", VA = "0x1809A6470", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA1EEC0", Offset = "0xA1DAC0", VA = "0x180A1EEC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public KFAFPFCILEP IPFAONGAAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8F05B0", Offset = "0x8EF1B0", VA = "0x1808F05B0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA1EEA0", Offset = "0xA1DAA0", VA = "0x180A1EEA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public HCEKDBKMJPN JAHDKNCCGMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x85ECE0", Offset = "0x85D8E0", VA = "0x18085ECE0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA1EE00", Offset = "0xA1DA00", VA = "0x180A1EE00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public BMEFCDCOBGJ CLHOJKFHHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9A7660", Offset = "0x9A6260", VA = "0x1809A7660", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public MGCBNOFKFNA FEGJFJDKLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8F05D0", Offset = "0x8EF1D0", VA = "0x1808F05D0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public IGMACCECEBE MLKBKFANBPM
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8F05C0", Offset = "0x8EF1C0", VA = "0x1808F05C0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public EBEHLNDFOAM GHDPDAPFFCE
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9A61D0", Offset = "0x9A4DD0", VA = "0x1809A61D0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public JCNLMJJPKDF HDHEKNDEBLE
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9A6570", Offset = "0x9A5170", VA = "0x1809A6570", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x99A750", Offset = "0x999350", VA = "0x18099A750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private bool IJCHKMKBFFK
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x671C910", Offset = "0x671B510", VA = "0x18671C910", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	private bool FGMGONIDGCO
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x671C0F0", Offset = "0x671ACF0", VA = "0x18671C0F0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	private CancellationToken HLEFNMPPNBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x671C740", Offset = "0x671B340", VA = "0x18671C740", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private OJEGDOKHPNO NKAKEDCNAMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action JLKNPPAKCND
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x671C5F0", Offset = "0x671B1F0", VA = "0x18671C5F0", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x671CB30", Offset = "0x671B730", VA = "0x18671CB30", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event FNAFABKPKJL MJLLPNJOHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x671C7C0", Offset = "0x671B3C0", VA = "0x18671C7C0", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x671C650", Offset = "0x671B250", VA = "0x18671C650", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event FNAFABKPKJL DKIFMGJEHHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x671C820", Offset = "0x671B420", VA = "0x18671C820", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x671C250", Offset = "0x671AE50", VA = "0x18671C250", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event FNAFABKPKJL NNJGINHOPGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x671CAD0", Offset = "0x671B6D0", VA = "0x18671CAD0", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x671C170", Offset = "0x671AD70", VA = "0x18671C170", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<GAHKMCKFJJJ, bool> OGHBGMJIFMA
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x671CB90", Offset = "0x671B790", VA = "0x18671CB90", Slot = "45")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x671C760", Offset = "0x671B360", VA = "0x18671C760", Slot = "46")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x99A750", Offset = "0x999350", VA = "0x18099A750", Slot = "36")]
	public void CDGLPABMGND(JCNLMJJPKDF PCOHFDNGICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x671CBF0", Offset = "0x671B7F0", VA = "0x18671CBF0")]
	[UnityEngine.Scripting.Preserve]
	internal MMHJELMJIIA([NNEMKPMNJAE(null)] OJEGDOKHPNO JEAKPHJODOO, [NNEMKPMNJAE(null)] IILECEBHMOO GHMLFJKNGCO, [NNEMKPMNJAE(null)] FDMBAAMNDEP AOABEOLLNPP, [NNEMKPMNJAE(null)] NCPOJFNGNHJ FOHLLAJCPJF, [NNEMKPMNJAE(null)] GJAJGPAHGBO JJKKNEEKBHC, [NNEMKPMNJAE(null)] JOAOOFHFNGE GBNEDIOHLLD, [NNEMKPMNJAE(null)] OFPGEKNONIJ GJGCFDEOILN, [NNEMKPMNJAE(null)] FKNHFKFGPNP GDECNFBKPIF, [NNEMKPMNJAE(null)] GFEHHOKDKNO BPNGCPNGOFE, [NNEMKPMNJAE(null)] FKNCPDJFAMI PEMEFCCACCB, [NNEMKPMNJAE(null)] FOLJNBPENFB KPMEDAIGLLH, [NNEMKPMNJAE(null)] EOOHCGOPALF KFJBDIDOLEL, [NNEMKPMNJAE(null)] KHMMPJOGLIM JANPGPNIJLJ, [NNEMKPMNJAE(null)] OEOCHODKCLE AJLBNLJNPHJ, [NNEMKPMNJAE(null)] DODMCLJGNGH IDDEIKHDDOG, [NNEMKPMNJAE(null)] HBKOLBMJMCG KJEIFEAHCPO, [NNEMKPMNJAE(null)] MBMBLPNEHHG CPOONBINHEG, [NNEMKPMNJAE(null)] KPMEJKPDGDP CHPADNIDKEG, [NNEMKPMNJAE(null)] GKFEGHGDEHH HOMMJMBPOPG, [NNEMKPMNJAE(null)] DDDLPBOPCJH LALNDCPIKBK, [NNEMKPMNJAE(null)] HJEOEBFAIKO NPLOJODCEEF, [NNEMKPMNJAE(null)] GCDHECDBFHP OCLLJLDDHPD, [NNEMKPMNJAE(null)] FLCMKIENGNI KCPIPLJPGML, [NNEMKPMNJAE(null)] BDNKNOODLOF DLHCMGLGFKD, [NNEMKPMNJAE(null)] ODMMMMBOMOJ NLEFAEJKOLP, [NNEMKPMNJAE(null)] KFAFPFCILEP LCKLFNLGOKK, [NNEMKPMNJAE(null)] HCEKDBKMJPN LEAHPKHFLDJ, [NNEMKPMNJAE(null)] BMEFCDCOBGJ CCPGABEKEFK, [NNEMKPMNJAE(null)] MGCBNOFKFNA GKGCFCBONBF, [NNEMKPMNJAE(null)] IGMACCECEBE KCNBDPIGCCJ, [NNEMKPMNJAE(null)] EBEHLNDFOAM BPDNFCBIMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x671C540", Offset = "0x671B140", VA = "0x18671C540")]
	private void HAJAGMDCLHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x671C2B0", Offset = "0x671AEB0", VA = "0x18671C2B0", Slot = "55")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x671CA80", Offset = "0x671B680", VA = "0x18671CA80", Slot = "49")]
	private void MONEAMMLKKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x671C6B0", Offset = "0x671B2B0", VA = "0x18671C6B0", Slot = "50")]
	private KPHNEGJGLOF IJAGBFFOIBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x671C880", Offset = "0x671B480", VA = "0x18671C880", Slot = "51")]
	private DPOFENGHMKM KGEECPEKBBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x671C970", Offset = "0x671B570", VA = "0x18671C970", Slot = "52")]
	[AsyncStateMachine(typeof(MANLODDNGBJ))]
	private Task<HAGKOKKBGGA> MOCMCPEKBFG(GEKIPCCOKMO FEBLDJCELMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x671C450", Offset = "0x671B050", VA = "0x18671C450", Slot = "53")]
	[AsyncStateMachine(typeof(CPBMHJHGEEG))]
	private Task GNJLEBPGKLN(CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x671C1D0", Offset = "0x671ADD0", VA = "0x18671C1D0")]
	[IteratorStateMachine(typeof(PIANEDHAOGK))]
	private IEnumerable<KINGOFPACJO> AMDNMHPEOAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x671C090", Offset = "0x671AC90", VA = "0x18671C090")]
	[CompilerGenerated]
	private void ADKMCOADECD(KINGOFPACJO AHNMMBDFHCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class MOBOHBMPJHL : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0xD67A80", Offset = "0xD66680", VA = "0x180D67A80")]
	public MOBOHBMPJHL(string COECLHOAJJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal class FOALMMKPEJB : HNAMPNCAGBO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct NOPNGJDEAPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public FOALMMKPEJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x6724320", Offset = "0x6722F20", VA = "0x186724320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6724660", Offset = "0x6723260", VA = "0x186724660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly OEENMHGGAHN KLNOEOGFLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly NCPOJFNGNHJ FOHLLAJCPJF;

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x7BF470", Offset = "0x7BE070", VA = "0x1807BF470")]
	public FOALMMKPEJB(OEENMHGGAHN KLNOEOGFLGJ, NCPOJFNGNHJ FOHLLAJCPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6710A30", Offset = "0x670F630", VA = "0x186710A30", Slot = "4")]
	[AsyncStateMachine(typeof(NOPNGJDEAPE))]
	public Task<bool> MEEJFHCHGFO(CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6710950", Offset = "0x670F550", VA = "0x186710950")]
	[CompilerGenerated]
	private object AFBNKHKGJEJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class OAHLKELGOEO : HNAMPNCAGBO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct DCBFFLFOIOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public OAHLKELGOEO <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x670C9F0", Offset = "0x670B5F0", VA = "0x18670C9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x670D100", Offset = "0x670BD00", VA = "0x18670D100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly OEENMHGGAHN KLNOEOGFLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly NCPOJFNGNHJ FOHLLAJCPJF;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private EELKBCOPMKF GFOFKJKPJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6724750", Offset = "0x6723350", VA = "0x186724750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x7BF470", Offset = "0x7BE070", VA = "0x1807BF470")]
	public OAHLKELGOEO(OEENMHGGAHN KLNOEOGFLGJ, NCPOJFNGNHJ FOHLLAJCPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6724880", Offset = "0x6723480", VA = "0x186724880", Slot = "4")]
	[AsyncStateMachine(typeof(DCBFFLFOIOD))]
	public Task<bool> MEEJFHCHGFO(CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x67247A0", Offset = "0x67233A0", VA = "0x1867247A0")]
	[CompilerGenerated]
	private object GPHPKPHKPGN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal class GCDBJNEPIAM : HNAMPNCAGBO
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class HHDHDPAOEDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public GCDBJNEPIAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public LDAKHHJJNAL result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public JENGLAFMNAE newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public HHDHDPAOEDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x6713240", Offset = "0x6711E40", VA = "0x186713240")]
		internal object JGGEKJBGODO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x6713130", Offset = "0x6711D30", VA = "0x186713130")]
		internal object BALFBHFLANF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x67131A0", Offset = "0x6711DA0", VA = "0x1867131A0")]
		internal object CMADCIINNHJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct EOKKJPHKLEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public GCDBJNEPIAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private HHDHDPAOEDO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<LDAKHHJJNAL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x670E280", Offset = "0x670CE80", VA = "0x18670E280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x670EBB0", Offset = "0x670D7B0", VA = "0x18670EBB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly OEENMHGGAHN KLNOEOGFLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly NCPOJFNGNHJ FOHLLAJCPJF;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private EELKBCOPMKF GFOFKJKPJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6710CF0", Offset = "0x670F8F0", VA = "0x186710CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x7BF470", Offset = "0x7BE070", VA = "0x1807BF470")]
	public GCDBJNEPIAM(OEENMHGGAHN KLNOEOGFLGJ, NCPOJFNGNHJ FOHLLAJCPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6710D40", Offset = "0x670F940", VA = "0x186710D40", Slot = "4")]
	[AsyncStateMachine(typeof(EOKKJPHKLEK))]
	public Task<bool> MEEJFHCHGFO(CancellationToken EJGJLLMBDIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal interface HNAMPNCAGBO
{
	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> MEEJFHCHGFO(CancellationToken EJGJLLMBDIN);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal struct NONNBGJMPPM
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class PGAAOMHKKHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public OEENMHGGAHN manager;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public PGAAOMHKKHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x67258A0", Offset = "0x67244A0", VA = "0x1867258A0")]
		internal Task JKNIHFCKPLJ(GPMIMHCABEE data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct HKIIJGEMNFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public NONNBGJMPPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private GEKIPCCOKMO <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<IJPNKHBIBCD> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter<HAGKOKKBGGA> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6713330", Offset = "0x6711F30", VA = "0x186713330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x67138C0", Offset = "0x67124C0", VA = "0x1867138C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct EILHDJFJBCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public NONNBGJMPPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x670DF00", Offset = "0x670CB00", VA = "0x18670DF00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x670E220", Offset = "0x670CE20", VA = "0x18670E220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly CancellationToken EJGJLLMBDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly OEENMHGGAHN DFCFBMIMDHA;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private IILECEBHMOO ENNPACHDKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6724100", Offset = "0x6722D00", VA = "0x186724100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private NCPOJFNGNHJ KOIOJGFJDFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6724150", Offset = "0x6722D50", VA = "0x186724150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private EELKBCOPMKF GFOFKJKPJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6723CB0", Offset = "0x67228B0", VA = "0x186723CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private FKNCPDJFAMI FINPBEKJEBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x67242D0", Offset = "0x6722ED0", VA = "0x1867242D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x1DF5DA0", Offset = "0x1DF49A0", VA = "0x181DF5DA0")]
	public NONNBGJMPPM(CancellationToken EJGJLLMBDIN, OEENMHGGAHN DFCFBMIMDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x6724050", Offset = "0x6722C50", VA = "0x186724050")]
	public static IKMLAGKNNKI EMHOGEGODGP(OEENMHGGAHN DFCFBMIMDHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x6723F40", Offset = "0x6722B40", VA = "0x186723F40")]
	[AsyncStateMachine(typeof(HKIIJGEMNFF))]
	public Task<bool> EDEDADACBKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6723D30", Offset = "0x6722930", VA = "0x186723D30")]
	private bool CELKANLCPOI([Out] GEKIPCCOKMO FEBLDJCELMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x6723BE0", Offset = "0x67227E0", VA = "0x186723BE0")]
	[AsyncStateMachine(typeof(EILHDJFJBCL))]
	private Task BBOOINNBBDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x67241A0", Offset = "0x6722DA0", VA = "0x1867241A0")]
	private Task<IJPNKHBIBCD> JCOIGKJHCDC(GEKIPCCOKMO LIFCIPHPEMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct AJPELLBGLGP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly DODMCLJGNGH IDDEIKHDDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly Guid BJNGDHCNCJP;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private Task<(HAGKOKKBGGA, Task)> LHLBDHDKNNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6709C70", Offset = "0x6708870", VA = "0x186709C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x3BF4F70", Offset = "0x3BF3B70", VA = "0x183BF4F70")]
	public AJPELLBGLGP(DODMCLJGNGH IDDEIKHDDOG, Guid BJNGDHCNCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6709C20", Offset = "0x6708820", VA = "0x186709C20")]
	public TaskAwaiter<(HAGKOKKBGGA, Task)> FLKOPGGPIPE()
	{
		return default(TaskAwaiter<(HAGKOKKBGGA, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6709B50", Offset = "0x6708750", VA = "0x186709B50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal struct HGHGMFCOFBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly TaskCompletionSource<(HAGKOKKBGGA, Task)> BHIDCMPBHMN;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public Task<(HAGKOKKBGGA, Task)> LHLBDHDKNNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x6712F60", Offset = "0x6711B60", VA = "0x186712F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6712FA0", Offset = "0x6711BA0", VA = "0x186712FA0")]
	public HGHGMFCOFBD(TimeSpan IAJJLFLHIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6712D50", Offset = "0x6711950", VA = "0x186712D50")]
	public void AICBAGCNNHC(Task MGGINNBKKGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6712E80", Offset = "0x6711A80", VA = "0x186712E80")]
	public void HBLKPNMBJJM(HAGKOKKBGGA OGBAEECNMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6712F10", Offset = "0x6711B10", VA = "0x186712F10")]
	public void HDIADCCBACF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6712DF0", Offset = "0x67119F0", VA = "0x186712DF0")]
	internal void FGHFLPANPGD(string COECLHOAJJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class NAFENCMMCFF
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class JGDDJIELHIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public JPFIIAMMGLD subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public JGDDJIELHIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6716370", Offset = "0x6714F70", VA = "0x186716370")]
		internal bool ABGODJAECOB(GOCLPCOPMCO s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x671E2F0", Offset = "0x671CEF0", VA = "0x18671E2F0")]
	public static CGNOFECNPIB JOBBHNKGDPO(long NNCEFMNLAMF, long FLKBFMIKIPD, string EOAALFBIDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x671E230", Offset = "0x671CE30", VA = "0x18671E230")]
	public static CGNOFECNPIB JOBBHNKGDPO(long NNCEFMNLAMF, long FLKBFMIKIPD, PBNLADHBLCA DNCEPNILLJE, long GLPKLLPKLFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x671E0A0", Offset = "0x671CCA0", VA = "0x18671E0A0")]
	public static CGNOFECNPIB JOBBHNKGDPO(GILBFMDGNPJ LNAEJAOIPJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x671E380", Offset = "0x671CF80", VA = "0x18671E380")]
	public static CGNOFECNPIB JOBBHNKGDPO(EOHIAKIOJAN HHAGBHFHLJN, JPFIIAMMGLD MLGNGBHBCBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x671DFB0", Offset = "0x671CBB0", VA = "0x18671DFB0")]
	public static CGNOFECNPIB CPLAOOEMJFD(this CGNOFECNPIB FGGJAKAMDOE, EOHIAKIOJAN PGLIJHFOMAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x671E5B0", Offset = "0x671D1B0", VA = "0x18671E5B0")]
	public static CGNOFECNPIB JPDOOPCPPFM(this CGNOFECNPIB FGGJAKAMDOE, JPFIIAMMGLD AGGCLKCJHHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[RecRoom.NoEngine.Common.Preserve]
internal class IPBIICDKMNC : GFEHHOKDKNO, KINGOFPACJO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct CKBLMANEJOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public IPBIICDKMNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private LPACJKPPDGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x670C070", Offset = "0x670AC70", VA = "0x18670C070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x670C700", Offset = "0x670B300", VA = "0x18670C700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly CAPELAHPHJP MKCOEPDEFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private string LGHPHLAKDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Task HCIHDKEENJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private OEENMHGGAHN KLNOEOGFLGJ;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool APECJAOPGJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6716020", Offset = "0x6714C20", VA = "0x186716020", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public Task DNICAOLMKKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6716050", Offset = "0x6714C50", VA = "0x186716050", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7B2B10", Offset = "0x7B1710", VA = "0x1807B2B10", Slot = "7")]
	public void HAJAGMDCLHL(OEENMHGGAHN KLNOEOGFLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6715EC0", Offset = "0x6714AC0", VA = "0x186715EC0", Slot = "6")]
	public void DCDLNIPBOEJ(Task BKPEJJIHAHC, string BPLOMNOMILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6715DA0", Offset = "0x67149A0", VA = "0x186715DA0")]
	[AsyncStateMachine(typeof(CKBLMANEJOE))]
	private Task CAMFNDPEFKO(Task MAPICHAOKBD, string BPLOMNOMILF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x67160E0", Offset = "0x6714CE0", VA = "0x1867160E0")]
	public IPBIICDKMNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class BEGHONBPEGL : NDAGHOBLHOB, KINGOFPACJO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool OGFOIBPMHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private MNMJHIIHKJP GIFHIJMFABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private IILECEBHMOO GHMLFJKNGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private KFAFPFCILEP LCKLFNLGOKK;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public MNMJHIIHKJP AOHOIIFNJAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x670A1B0", Offset = "0x6708DB0", VA = "0x18670A1B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x670A030", Offset = "0x6708C30", VA = "0x18670A030", Slot = "7")]
	public void HAJAGMDCLHL(OEENMHGGAHN KLNOEOGFLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6709E80", Offset = "0x6708A80", VA = "0x186709E80", Slot = "5")]
	public void DPHMFKABNMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6709E40", Offset = "0x6708A40", VA = "0x186709E40", Slot = "6")]
	public void DNCPNKILOIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x670A220", Offset = "0x6708E20", VA = "0x18670A220")]
	private Task POPJDOGJDBM(BMIKKLFNHJL BGBHFDMLCDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6709E40", Offset = "0x6708A40", VA = "0x186709E40", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public BEGHONBPEGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class ADCPNGCPDPB : KFAFPFCILEP
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	private class JPJOGFGPLNF<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly PLBKOCBJDEA HODNAMPDCOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly string CGGNJKGENIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly T FCKGAANHHID;

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public T BLAEOCKJGCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x8029C0", Offset = "0x8015C0", VA = "0x1808029C0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x869490", Offset = "0x868090", VA = "0x180869490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3B30510", Offset = "0x3B2F110", VA = "0x183B30510")]
		public JPJOGFGPLNF(PLBKOCBJDEA HODNAMPDCOC, string CGGNJKGENIH, T FCKGAANHHID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3B301B0", Offset = "0x3B2EDB0", VA = "0x183B301B0")]
		private void BCGEFJLDCIO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly PLBKOCBJDEA HODNAMPDCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly JPJOGFGPLNF<TimeSpan> GOEKGJMEGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly JPJOGFGPLNF<TimeSpan> BHGFEEKKIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly JPJOGFGPLNF<TimeSpan> CJCPNCADMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly JPJOGFGPLNF<TimeSpan> CAHILKDIEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly JPJOGFGPLNF<bool> DDOLNDCJHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly JPJOGFGPLNF<bool> MLPEOMNBAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly JPJOGFGPLNF<bool> BAJFGNDADFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly JPJOGFGPLNF<int> PPAPMJEKLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly JPJOGFGPLNF<bool> BKLNOPNPOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly JPJOGFGPLNF<bool> NCFOHKFDKIP;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public TimeSpan IHOKAMPGJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6707AE0", Offset = "0x67066E0", VA = "0x186707AE0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public TimeSpan MHEKPAMIBEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6707920", Offset = "0x6706520", VA = "0x186707920", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public TimeSpan EGDPCJMJLIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6707B20", Offset = "0x6706720", VA = "0x186707B20", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public TimeSpan AKCGLBKEODC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x67079E0", Offset = "0x67065E0", VA = "0x1867079E0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool HHGHOOBJMHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x67079A0", Offset = "0x67065A0", VA = "0x1867079A0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool EHPBCIJBOIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6707A60", Offset = "0x6706660", VA = "0x186707A60", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool ELMMJBDHAOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x6707AA0", Offset = "0x67066A0", VA = "0x186707AA0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int OIAEAODFJLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x67078E0", Offset = "0x67064E0", VA = "0x1867078E0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool EPIDOGIEFLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x6707960", Offset = "0x6706560", VA = "0x186707960", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool DODDHHECNHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x6707A20", Offset = "0x6706620", VA = "0x186707A20", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6707B60", Offset = "0x6706760", VA = "0x186707B60")]
	[UnityEngine.Scripting.Preserve]
	public ADCPNGCPDPB([NNEMKPMNJAE(null)] PLBKOCBJDEA HODNAMPDCOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[UnityEngine.Scripting.Preserve]
internal class BHADNOOOHAD : FOLJNBPENFB, KINGOFPACJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class FMIMOMDNGCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public PBDIFHMPODG roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public FMIMOMDNGCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x67101B0", Offset = "0x670EDB0", VA = "0x1867101B0")]
		internal object ECOKAPEPHDP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action BACIMDDNEBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x670AC70", Offset = "0x6709870", VA = "0x18670AC70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x670A880", Offset = "0x6709480", VA = "0x18670A880", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event FNAFABKPKJL EGEDOBHHGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x670A380", Offset = "0x6708F80", VA = "0x18670A380", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x670A2E0", Offset = "0x6708EE0", VA = "0x18670A2E0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event FNAFABKPKJL DAIKGMIHFEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x670A920", Offset = "0x6709520", VA = "0x18670A920", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x670A5F0", Offset = "0x67091F0", VA = "0x18670A5F0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event FNAFABKPKJL HEOABEBHLEH
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x670A7B0", Offset = "0x67093B0", VA = "0x18670A7B0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x670A6C0", Offset = "0x67092C0", VA = "0x18670A6C0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<GAHKMCKFJJJ, bool> IBBJMNGEEFA
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x670ABC0", Offset = "0x67097C0", VA = "0x18670ABC0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x670AD40", Offset = "0x6709940", VA = "0x18670AD40", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "19")]
	public void HAJAGMDCLHL(OEENMHGGAHN KLNOEOGFLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x670A9C0", Offset = "0x67095C0", VA = "0x18670A9C0", Slot = "14")]
	public void ODEFFFILHIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x670A850", Offset = "0x6709450", VA = "0x18670A850", Slot = "15")]
	public void KJKBIIGICED(PBDIFHMPODG NJNINILBPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x670A690", Offset = "0x6709290", VA = "0x18670A690", Slot = "16")]
	public void GHCHBCNFKDK(PBDIFHMPODG NJNINILBPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x670AD10", Offset = "0x6709910", VA = "0x18670AD10", Slot = "17")]
	public void PLBDJCLOEDJ(PBDIFHMPODG NJNINILBPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x670A760", Offset = "0x6709360", VA = "0x18670A760", Slot = "18")]
	public void GNJKBADIEON(GAHKMCKFJJJ ACDBBCINPON, bool DHFBKAPIONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x670A420", Offset = "0x6709020", VA = "0x18670A420")]
	private void EMODIMFPKPL(FNAFABKPKJL LIEBEJAOEBM, PBDIFHMPODG NJNINILBPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public BHADNOOOHAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[UnityEngine.Scripting.Preserve]
internal class AHNIIPAPNLJ : EOOHCGOPALF, KINGOFPACJO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct ODGIBHCMDGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public AHNIIPAPNLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private LPACJKPPDGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x67249B0", Offset = "0x67235B0", VA = "0x1867249B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x6724E90", Offset = "0x6723A90", VA = "0x186724E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct FNOPGDJKDAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public AHNIIPAPNLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private LPACJKPPDGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x6710290", Offset = "0x670EE90", VA = "0x186710290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x67108F0", Offset = "0x670F4F0", VA = "0x1867108F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class GDDNDIPGBLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public GDDNDIPGBLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x6710E60", Offset = "0x670FA60", VA = "0x186710E60")]
		internal object HFHGEOKLFKK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct DDBMDGIIHDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public AHNIIPAPNLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private GDDNDIPGBLL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private LPACJKPPDGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x670D170", Offset = "0x670BD70", VA = "0x18670D170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x670D8C0", Offset = "0x670C4C0", VA = "0x18670D8C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class GGLKONGJDBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public GGLKONGJDBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6711B00", Offset = "0x6710700", VA = "0x186711B00")]
		internal object NFFPFIAAFFF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly HEENJBKIIAO BNEDOBBKLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private OEENMHGGAHN KLNOEOGFLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private NCPOJFNGNHJ FOHLLAJCPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private HNAMPNCAGBO[] KFPDMPMNDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private CancellationTokenSource PMGENMHPOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private int LJBOBGOGMLM;

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6709550", Offset = "0x6708150", VA = "0x186709550", Slot = "6")]
	public void HAJAGMDCLHL(OEENMHGGAHN KLNOEOGFLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6709080", Offset = "0x6707C80", VA = "0x186709080", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x67098E0", Offset = "0x67084E0", VA = "0x1867098E0", Slot = "8")]
	public void NBNGJGKDAIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x67096D0", Offset = "0x67082D0", VA = "0x1867096D0", Slot = "5")]
	public void JOFOLLBNKKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6709090", Offset = "0x6707C90", VA = "0x186709090", Slot = "4")]
	[AsyncStateMachine(typeof(ODGIBHCMDGK))]
	public Task EEGHDIDKDGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6709240", Offset = "0x6707E40", VA = "0x186709240")]
	private void GDDBLCPLDNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x67095D0", Offset = "0x67081D0", VA = "0x1867095D0")]
	[AsyncStateMachine(typeof(FNOPGDJKDAF))]
	private Task HBHANAHIGEB(CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x67097A0", Offset = "0x67083A0", VA = "0x1867097A0")]
	[AsyncStateMachine(typeof(DDBMDGIIHDI))]
	private Task<bool> MCPGLMBBKMB(int PMIDLPOCCEE, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6709160", Offset = "0x6707D60", VA = "0x186709160")]
	private void EPGKPMINKDM(int PMIDLPOCCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x67099E0", Offset = "0x67085E0", VA = "0x1867099E0")]
	private void OICDHJIPLGN(int PMIDLPOCCEE, bool DHFBKAPIONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6708F50", Offset = "0x6707B50", VA = "0x186708F50")]
	private void CPHBFOHBGOI(int PMIDLPOCCEE, Exception BJCOEJJDGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6708E20", Offset = "0x6707A20", VA = "0x186708E20")]
	private void CICNPBEIFHG(CancellationToken EJGJLLMBDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public AHNIIPAPNLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[RecRoom.NoEngine.Common.Preserve]
internal class KKFLHBGHAAH : KHMMPJOGLIM, KINGOFPACJO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct HFOPCLKKNCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public JENGLAFMNAE targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public KKFLHBGHAAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public JCNLMJJPKDF customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private LPACJKPPDGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6712390", Offset = "0x6710F90", VA = "0x186712390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x6712CF0", Offset = "0x67118F0", VA = "0x186712CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct FFJBNENCCHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public KKFLHBGHAAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public JENGLAFMNAE targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public JCNLMJJPKDF customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private DBCLHGHLEMD<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private LPACJKPPDGK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private IOAFANGBINH <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private PDEAPHDCOIE <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x670F590", Offset = "0x670E190", VA = "0x18670F590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x6710150", Offset = "0x670ED50", VA = "0x186710150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class JNMMBHMEKEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public Matchmaking.NINDAGCEEDI result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public GKLIGJLPBPE errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public JNMMBHMEKEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x67168B0", Offset = "0x67154B0", VA = "0x1867168B0")]
		internal object HDJJANBNAHG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class GNCAIOHJPDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public Task<CGNOFECNPIB> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public GNCAIOHJPDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
		internal Task<CGNOFECNPIB> GNFGPJICABG(DBCLHGHLEMD<string>.OGCCDEKKEPE _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct NGELKDMBEFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public KKFLHBGHAAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public JENGLAFMNAE targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public JCNLMJJPKDF customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public IOAFANGBINH joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private GNCAIOHJPDO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private EMAPDACIFNI <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private LPACJKPPDGK <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <connectToRoomAndRunLoadLogicTimer>5__5;

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
		private NDDFDGFOGCA <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private Task<Matchmaking.GKGMBNIMODP> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private LKLHBHIGFAI <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <>7__wrap12;

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
		private TaskAwaiter<Matchmaking.GKGMBNIMODP> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private TaskAwaiter<CGNOFECNPIB> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x671E740", Offset = "0x671D340", VA = "0x18671E740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6723900", Offset = "0x6722500", VA = "0x186723900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct HOBHHOBHPFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public KKFLHBGHAAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private LPACJKPPDGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <disconnectTimerScope>5__3;

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
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x6713E60", Offset = "0x6712A60", VA = "0x186713E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x67148B0", Offset = "0x67134B0", VA = "0x1867148B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct INNKAEEHDPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public KKFLHBGHAAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private OJEGDOKHPNO <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6715620", Offset = "0x6714220", VA = "0x186715620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6715AA0", Offset = "0x67146A0", VA = "0x186715AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct CJECLPCMLJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public AsyncTaskMethodBuilder<Matchmaking.GKGMBNIMODP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public JENGLAFMNAE targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public KKFLHBGHAAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private TaskAwaiter<Matchmaking.GKGMBNIMODP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x670B620", Offset = "0x670A220", VA = "0x18670B620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x670BB20", Offset = "0x670A720", VA = "0x18670BB20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct OJAOIFKDJNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public Matchmaking.GKGMBNIMODP serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public KKFLHBGHAAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public IOAFANGBINH joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private LPACJKPPDGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private TaskAwaiter<HHBOLPEHAKP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6724EF0", Offset = "0x6723AF0", VA = "0x186724EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x67255F0", Offset = "0x67241F0", VA = "0x1867255F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class JFLEEJKCOLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public JENGLAFMNAE targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public JFLEEJKCOLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6716270", Offset = "0x6714E70", VA = "0x186716270")]
		internal object DKEFOGAAHIN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x6716170", Offset = "0x6714D70", VA = "0x186716170")]
		internal string AOBJICPJIHD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct GGJIBONEFEE : IAsyncStateMachine
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
		public JENGLAFMNAE targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public KKFLHBGHAAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private JFLEEJKCOLF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private LPACJKPPDGK <>7__wrap1;

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

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x6710ED0", Offset = "0x670FAD0", VA = "0x186710ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6711AA0", Offset = "0x67106A0", VA = "0x186711AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct FDCKKJPLGLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public KKFLHBGHAAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public IOAFANGBINH joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public CGNOFECNPIB initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public JENGLAFMNAE targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public EMAPDACIFNI progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x670EC20", Offset = "0x670D820", VA = "0x18670EC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x670F530", Offset = "0x670E130", VA = "0x18670F530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct LDHEDOJBJAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public KKFLHBGHAAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private LPACJKPPDGK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <>7__wrap3;

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

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x671A460", Offset = "0x6719060", VA = "0x18671A460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x671BAA0", Offset = "0x671A6A0", VA = "0x18671BAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct GLECGJPPPKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public GPMIMHCABEE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public KKFLHBGHAAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private LPACJKPPDGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private TaskAwaiter<HAGKOKKBGGA> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6711B70", Offset = "0x6710770", VA = "0x186711B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6712330", Offset = "0x6710F30", VA = "0x186712330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class FPJAAHNBNGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public JENGLAFMNAE targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public FPJAAHNBNGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6710B20", Offset = "0x670F720", VA = "0x186710B20")]
		internal object JOCOCLGGMGH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class DJBFKJJCPGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public DJBFKJJCPGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x670D930", Offset = "0x670C530", VA = "0x18670D930")]
		internal void NLBBKOIPGDM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class PCCLJHLKIMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public JENGLAFMNAE targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public PCCLJHLKIMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x67256C0", Offset = "0x67242C0", VA = "0x1867256C0")]
		internal object INANOJMGKMO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class BBOHKNDDKCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public JENGLAFMNAE targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public BBOHKNDDKCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x6709D40", Offset = "0x6708940", VA = "0x186709D40")]
		internal string EPFDFMPOOPJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly HEENJBKIIAO BNEDOBBKLOJ;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly HEENJBKIIAO HEHFIGGABPP;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly HEENJBKIIAO NGFFFIAIKFD;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly HEENJBKIIAO AENPPLPMNPH;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly string FJNONFPOPBM;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly string EMOLIMCDNGN;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly string BMNJKMBBIDB;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static readonly Guid MGOEJDPEHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private FKNHFKFGPNP GDECNFBKPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private FDMBAAMNDEP AOABEOLLNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private IILECEBHMOO GHMLFJKNGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private OEENMHGGAHN KLNOEOGFLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private NCPOJFNGNHJ FOHLLAJCPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private EOOHCGOPALF KFJBDIDOLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private GFEHHOKDKNO BPNGCPNGOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private FOLJNBPENFB KPMEDAIGLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private IGMACCECEBE KCNBDPIGCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private MGCBNOFKFNA GKGCFCBONBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private IDisposable KJPOMMNALBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly CAPELAHPHJP BNOAFBMGONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly CAPELAHPHJP FEOCJOAPHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private LKLHBHIGFAI GDCMHDGMDJB;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public TaskStatus ICEJODFAAEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8785B0", Offset = "0x8771B0", VA = "0x1808785B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xB2CB80", Offset = "0xB2B780", VA = "0x180B2CB80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private EELKBCOPMKF GFOFKJKPJCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6716C50", Offset = "0x6715850", VA = "0x186716C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x6717FE0", Offset = "0x6716BE0", VA = "0x186717FE0", Slot = "6")]
	public void HAJAGMDCLHL(OEENMHGGAHN KLNOEOGFLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x6716EE0", Offset = "0x6715AE0", VA = "0x186716EE0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x6717620", Offset = "0x6716220", VA = "0x186717620", Slot = "5")]
	[AsyncStateMachine(typeof(HFOPCLKKNCB))]
	public Task EHKDPCNDIOC(JENGLAFMNAE PBJKAENPEMP, JCNLMJJPKDF ECADBFJFBGH, CancellationToken NFEFCAGIEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x6716D90", Offset = "0x6715990", VA = "0x186716D90")]
	[AsyncStateMachine(typeof(FFJBNENCCHN))]
	private Task DFMICCBPONE(JENGLAFMNAE PBJKAENPEMP, JCNLMJJPKDF ECADBFJFBGH, CancellationToken NFEFCAGIEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x6716F30", Offset = "0x6715B30", VA = "0x186716F30")]
	private static void ECHAPELJKML(IGMACCECEBE KCNBDPIGCCJ, JENGLAFMNAE PBJKAENPEMP, Exception BJCOEJJDGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x6719560", Offset = "0x6718160", VA = "0x186719560")]
	private static void PBNFOCGBALL(PDEAPHDCOIE LAOCJPOKHKO, Exception BJCOEJJDGCE, [Optional] List<int> KOKLILLFCLK, int LJBOBGOGMLM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6717D30", Offset = "0x6716930", VA = "0x186717D30")]
	[AsyncStateMachine(typeof(NGELKDMBEFB))]
	private Task GNLJDECLLCG(DBCLHGHLEMD<string>.OGCCDEKKEPE KAMOOCNEONO, JENGLAFMNAE PBJKAENPEMP, JCNLMJJPKDF ECADBFJFBGH, IOAFANGBINH CLBLPDEOJIN, CancellationToken NFEFCAGIEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6717E90", Offset = "0x6716A90", VA = "0x186717E90")]
	private void GPECBBKGJGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6718F40", Offset = "0x6717B40", VA = "0x186718F40")]
	[AsyncStateMachine(typeof(HOBHHOBHPFN))]
	private Task MJELHINKMIA(DBCLHGHLEMD<string>.OGCCDEKKEPE KAMOOCNEONO, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x67172F0", Offset = "0x6715EF0", VA = "0x1867172F0")]
	private void EFCLJONHJEN(JENGLAFMNAE PBJKAENPEMP, CancellationToken NFEFCAGIEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6719DF0", Offset = "0x67189F0", VA = "0x186719DF0")]
	private void PNMBAPPCNHJ(JENGLAFMNAE PBJKAENPEMP, IOAFANGBINH CLBLPDEOJIN, OperationCanceledException DDPAMMJFLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6718D10", Offset = "0x6717910", VA = "0x186718D10")]
	private void MAPIFBIBCNP(JENGLAFMNAE PBJKAENPEMP, IOAFANGBINH CLBLPDEOJIN, Exception BJCOEJJDGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x67184A0", Offset = "0x67170A0", VA = "0x1867184A0")]
	private void HEBACBAIDKB(JENGLAFMNAE PBJKAENPEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x67186B0", Offset = "0x67172B0", VA = "0x1867186B0")]
	private static PBDIFHMPODG HKIIGPPKEOH(JENGLAFMNAE PBJKAENPEMP)
	{
		return default(PBDIFHMPODG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x67191E0", Offset = "0x6717DE0", VA = "0x1867191E0")]
	[AsyncStateMachine(typeof(INNKAEEHDPO))]
	private Task NEHJMKOOPHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x67187A0", Offset = "0x67173A0", VA = "0x1867187A0")]
	[AsyncStateMachine(typeof(CJECLPCMLJK))]
	private Task<Matchmaking.GKGMBNIMODP> JJFEBABLJEN(JENGLAFMNAE PBJKAENPEMP, DBCLHGHLEMD<string>.OGCCDEKKEPE KAMOOCNEONO, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6719340", Offset = "0x6717F40", VA = "0x186719340")]
	private static HHBOLPEHAKP OACKHDOCKEI(Matchmaking.GKGMBNIMODP COJHPEKADEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x671A020", Offset = "0x6718C20", VA = "0x18671A020")]
	[AsyncStateMachine(typeof(OJAOIFKDJNB))]
	private Task POPKAAHAMFE(Matchmaking.GKGMBNIMODP COJHPEKADEB, IOAFANGBINH CLBLPDEOJIN, DBCLHGHLEMD<string>.OGCCDEKKEPE KAMOOCNEONO, CancellationToken NAKKCADDMGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6718900", Offset = "0x6717500", VA = "0x186718900")]
	[AsyncStateMachine(typeof(GGJIBONEFEE))]
	private Task JNCJLCGIADO(JENGLAFMNAE PBJKAENPEMP, CancellationTokenSource PHHMHCIHOAM, Task DBKIBDNCDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6719070", Offset = "0x6717C70", VA = "0x186719070")]
	[AsyncStateMachine(typeof(FDCKKJPLGLE))]
	private Task MJHKMPDAEFA(CGNOFECNPIB FDELMALCMCO, EMAPDACIFNI LACIDJBKBIF, JENGLAFMNAE OMOOKHBGLBJ, IOAFANGBINH MOGLNLCMNML, DBCLHGHLEMD<string>.OGCCDEKKEPE KAMOOCNEONO, CancellationToken PFOCBKCCICM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x67177F0", Offset = "0x67163F0", VA = "0x1867177F0")]
	private IOAFANGBINH GCJJPAJEKIM(IOAFANGBINH MOGLNLCMNML, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6716B20", Offset = "0x6715720", VA = "0x186716B20")]
	[AsyncStateMachine(typeof(LDHEDOJBJAK))]
	private Task BHAKGGFFMEK(DBCLHGHLEMD<string>.OGCCDEKKEPE KAMOOCNEONO, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6718A40", Offset = "0x6717640", VA = "0x186718A40")]
	[AsyncStateMachine(typeof(GLECGJPPPKH))]
	private Task JPHLBPOKNBE(GPMIMHCABEE KOMCCCIEHEA, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6717BB0", Offset = "0x67167B0", VA = "0x186717BB0")]
	private static void GIIKEJELEFN(JENGLAFMNAE PBJKAENPEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x67179E0", Offset = "0x67165E0", VA = "0x1867179E0")]
	private void GHLKILCEJJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6718710", Offset = "0x6717310", VA = "0x186718710")]
	private void HPLKLFOMMCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6717760", Offset = "0x6716360", VA = "0x186717760")]
	private void FPALFONLFLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x67192B0", Offset = "0x6717EB0", VA = "0x1867192B0")]
	private void NIFKGMFKPPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6716CA0", Offset = "0x67158A0", VA = "0x186716CA0")]
	private static void DDNGBHAGDEN(JENGLAFMNAE PBJKAENPEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6719450", Offset = "0x6718050", VA = "0x186719450")]
	private static CancellationTokenRegistration OIGHIEINHEF(JENGLAFMNAE PBJKAENPEMP, CancellationToken NAKKCADDMGB)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6716960", Offset = "0x6715560", VA = "0x186716960")]
	private static void AEFEPNJNPAC(JENGLAFMNAE PBJKAENPEMP, Exception BJCOEJJDGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6718B60", Offset = "0x6717760", VA = "0x186718B60")]
	private void LCDNFKALJAM(JENGLAFMNAE PBJKAENPEMP, Task DBKIBDNCDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6716A60", Offset = "0x6715660", VA = "0x186716A60")]
	private static void AGKNLPHAFKB(Func<string> OHNFGHCKMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x671A390", Offset = "0x6718F90", VA = "0x18671A390")]
	public KKFLHBGHAAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x6716AC0", Offset = "0x67156C0", VA = "0x186716AC0")]
	[CompilerGenerated]
	internal static (int, int?) AJPPCMIAIDB(GKLIGJLPBPE OECLKDJBFMA)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[RecRoom.NoEngine.Common.Preserve]
internal class MNIODLNJPDN : OEOCHODKCLE, KINGOFPACJO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct LJMLEIEAEPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public MNIODLNJPDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public GPMIMHCABEE roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x673CDB0", Offset = "0x673B9B0", VA = "0x18673CDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x673D170", Offset = "0x673BD70", VA = "0x18673D170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class ALLKHMPOIHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public MNIODLNJPDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public GPMIMHCABEE roomData;

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public ALLKHMPOIHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x6727FA0", Offset = "0x6726BA0", VA = "0x186727FA0")]
		internal List<Task> AKHHDIKIKHL(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct IPOEFAINLBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public IKMLAGKNNKI taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public GPMIMHCABEE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private LPACJKPPDGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x67356E0", Offset = "0x67342E0", VA = "0x1867356E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x6735A70", Offset = "0x6734670", VA = "0x186735A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct JLHMKEGBEBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public MNIODLNJPDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x6737760", Offset = "0x6736360", VA = "0x186737760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6737A20", Offset = "0x6736620", VA = "0x186737A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private readonly HashSet<IKMLAGKNNKI> DLCKBBNBOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private FDMBAAMNDEP AOABEOLLNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private OEENMHGGAHN KLNOEOGFLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private PFKOEEMDGOH HFHBFADEANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private ECCGJHFFMJB LLOFHGPKLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private IDisposable KJPOMMNALBF;

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x671D8D0", Offset = "0x671C4D0", VA = "0x18671D8D0", Slot = "5")]
	public void HAJAGMDCLHL(OEENMHGGAHN KLNOEOGFLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x671D570", Offset = "0x671C170", VA = "0x18671D570", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x671DD10", Offset = "0x671C910", VA = "0x18671DD10", Slot = "4")]
	public bool JELKMAJFAMP(IKMLAGKNNKI JGBCCLGMFCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x671DD70", Offset = "0x671C970", VA = "0x18671DD70")]
	private void KOMGLNAPAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x671D5D0", Offset = "0x671C1D0", VA = "0x18671D5D0")]
	private void FLLHDEECOBB(GPMIMHCABEE MAOJLJBOFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x671DC20", Offset = "0x671C820", VA = "0x18671DC20")]
	[AsyncStateMachine(typeof(LJMLEIEAEPK))]
	private Task IMHFALBFJFN(GPMIMHCABEE MAOJLJBOFIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x671D4A0", Offset = "0x671C0A0", VA = "0x18671D4A0")]
	private Func<CancellationToken, List<Task>> CHCKBKFEBFJ(GPMIMHCABEE MAOJLJBOFIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x671D050", Offset = "0x671BC50", VA = "0x18671D050")]
	private List<Task> BJKLJBDGGML(GPMIMHCABEE MAOJLJBOFIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x671D7B0", Offset = "0x671C3B0", VA = "0x18671D7B0")]
	[AsyncStateMachine(typeof(IPOEFAINLBP))]
	private Task GJBCHGMKBJF(IKMLAGKNNKI FEHDNOGINLN, GPMIMHCABEE KOMCCCIEHEA, CancellationToken DGPOLLDAHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x671DB50", Offset = "0x671C750", VA = "0x18671DB50")]
	[AsyncStateMachine(typeof(JLHMKEGBEBO))]
	private Task HEECOLCMJON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x671DEA0", Offset = "0x671CAA0", VA = "0x18671DEA0")]
	private void NBNGJGKDAIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x671DF20", Offset = "0x671CB20", VA = "0x18671DF20")]
	public MNIODLNJPDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[UnityEngine.Scripting.Preserve]
internal sealed class LIEAJFHGALI : DODMCLJGNGH, KINGOFPACJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class PDNBOJAIJMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public PDNBOJAIJMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6743E70", Offset = "0x6742A70", VA = "0x186743E70")]
		internal object MADIMHCPIDN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class PLKFBHEMJLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public PLKFBHEMJLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x6743FB0", Offset = "0x6742BB0", VA = "0x186743FB0")]
		internal object IPPGPKOEDOL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class LGHJJNOKNPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public LGHJJNOKNPG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class ELHHPMPBBBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public ELHHPMPBBBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x672D1B0", Offset = "0x672BDB0", VA = "0x18672D1B0")]
		internal object BDCHBHIJONJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class PGBMPJDJKGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public PGBMPJDJKGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x6743ED0", Offset = "0x6742AD0", VA = "0x186743ED0")]
		internal object FGDFDNLLLMP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly Dictionary<Guid, HGHGMFCOFBD> IDDEIKHDDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private readonly TimeSpan GECGHEGHABC;

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "9")]
	public void HAJAGMDCLHL(OEENMHGGAHN KLNOEOGFLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x673BBE0", Offset = "0x673A7E0", VA = "0x18673BBE0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x673B7B0", Offset = "0x673A3B0", VA = "0x18673B7B0", Slot = "4")]
	public AJPELLBGLGP BGJHDHHBMPP(Guid BJNGDHCNCJP)
	{
		return default(AJPELLBGLGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x673B9D0", Offset = "0x673A5D0", VA = "0x18673B9D0", Slot = "5")]
	public bool DMBJGENFJDP(Guid BJNGDHCNCJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x673C000", Offset = "0x673AC00", VA = "0x18673C000", Slot = "6")]
	public bool OFFKFPIENLO(Guid BJNGDHCNCJP, Task MGGINNBKKGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x673BE20", Offset = "0x673AA20", VA = "0x18673BE20", Slot = "7")]
	public bool IGPMOOHIEKN(Guid BJNGDHCNCJP, HAGKOKKBGGA OGBAEECNMFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x673C330", Offset = "0x673AF30", VA = "0x18673C330", Slot = "8")]
	public Task<(HAGKOKKBGGA, Task)> PBFGDGFADKI(Guid BJNGDHCNCJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x673BBF0", Offset = "0x673A7F0", VA = "0x18673BBF0")]
	private void GFMKPIFOBCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x673C3A0", Offset = "0x673AFA0", VA = "0x18673C3A0")]
	public LIEAJFHGALI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[RecRoom.NoEngine.Common.Preserve]
internal class PNMECIBNPOL : HBKOLBMJMCG, KINGOFPACJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private class DGIAEBOOKPA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private readonly JENGLAFMNAE FMBCMIJJNFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private readonly CancellationTokenSource PMGENMHPOOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public readonly CancellationToken HMNPIMLNDBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private bool CKFNILNJDIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private bool DLLGBEPLAAB;

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x672B090", Offset = "0x6729C90", VA = "0x18672B090")]
		public DGIAEBOOKPA(JENGLAFMNAE FMBCMIJJNFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x672AF40", Offset = "0x6729B40", VA = "0x18672AF40")]
		public void NBNGJGKDAIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x672AF10", Offset = "0x6729B10", VA = "0x18672AF10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class LIGKEPCFOMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public BMIKKLFNHJL disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public LIGKEPCFOMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x673C460", Offset = "0x673B060", VA = "0x18673C460")]
		internal object GEBLHDPKNIC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct OFGMKNNFKGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public BMIKKLFNHJL disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public PNMECIBNPOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private LPACJKPPDGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x6743420", Offset = "0x6742020", VA = "0x186743420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x67437D0", Offset = "0x67423D0", VA = "0x1867437D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class PMMBMJHBNEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public PMMBMJHBNEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6744010", Offset = "0x6742C10", VA = "0x186744010")]
		internal object DFNFHEMOEKG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct JBENGOCDNDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public PNMECIBNPOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private LPACJKPPDGK <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x6735AD0", Offset = "0x67346D0", VA = "0x186735AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x892CC0", Offset = "0x8918C0", VA = "0x180892CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class LIIMIMJBDKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public JENGLAFMNAE newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public LIIMIMJBDKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x673C570", Offset = "0x673B170", VA = "0x18673C570")]
		internal object LLAHAPICAOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x673C530", Offset = "0x673B130", VA = "0x18673C530")]
		internal object DOCIJJOMOFM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x673C4F0", Offset = "0x673B0F0", VA = "0x18673C4F0")]
		internal object CCHHJFOJMOK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class DBAAKKFJMKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public DBAAKKFJMKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x672A210", Offset = "0x6728E10", VA = "0x18672A210")]
		internal void PHFEFJDEPFE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private struct NLMEJMEIAEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public JENGLAFMNAE newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public PNMECIBNPOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public JCNLMJJPKDF customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private LIIMIMJBDKG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private LPACJKPPDGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6741050", Offset = "0x673FC50", VA = "0x186741050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x6741FD0", Offset = "0x6740BD0", VA = "0x186741FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly HEENJBKIIAO BNEDOBBKLOJ;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly PGKDDGKGDMA.IBLECEMBOJA LADLLFFGEJJ;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly AKHLLDOOCCK CFAEDAMPABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private FDMBAAMNDEP AOABEOLLNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private OEENMHGGAHN KLNOEOGFLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private EOOHCGOPALF KFJBDIDOLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private NCPOJFNGNHJ FOHLLAJCPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private KFAFPFCILEP LCKLFNLGOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private KHMMPJOGLIM JANPGPNIJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private long HANHDFCHBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private DGIAEBOOKPA EDEMEJGEGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private bool FDBBENGEBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private Task EKFOFGMKMKE;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private EELKBCOPMKF GFOFKJKPJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x67442E0", Offset = "0x6742EE0", VA = "0x1867442E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool KMNPDEMGFJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x1069480", Offset = "0x1068080", VA = "0x181069480")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x6744FD0", Offset = "0x6743BD0", VA = "0x186744FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6744920", Offset = "0x6743520", VA = "0x186744920", Slot = "4")]
	public void HAJAGMDCLHL(OEENMHGGAHN KLNOEOGFLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6744460", Offset = "0x6743060", VA = "0x186744460", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6744830", Offset = "0x6743430", VA = "0x186744830")]
	[AsyncStateMachine(typeof(OFGMKNNFKGB))]
	private Task GJBHAHILPIN(BMIKKLFNHJL GHIBBNIFJNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6744690", Offset = "0x6743290", VA = "0x186744690")]
	private void FPCEKGEPICP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6744080", Offset = "0x6742C80", VA = "0x186744080")]
	private void ABEEEJFIHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6744BC0", Offset = "0x67437C0", VA = "0x186744BC0")]
	private void IAJEKGJCNNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6744620", Offset = "0x6743220", VA = "0x186744620")]
	private bool FCFOJKADILL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6744210", Offset = "0x6742E10", VA = "0x186744210")]
	[AsyncStateMachine(typeof(JBENGOCDNDH))]
	private void BKEEFPNLGNN(int BEIODOEPHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6744D40", Offset = "0x6743940", VA = "0x186744D40")]
	private void IEABLCPCFLL([Out] IDisposable OGDKBEMHDFE, [Out] IDisposable IJNDJOJCBHN, [Out] IDisposable AHPJFEBKFOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x6744FE0", Offset = "0x6743BE0", VA = "0x186744FE0")]
	private bool MOBKOOMAIDC(JENGLAFMNAE FMBCMIJJNFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x67445D0", Offset = "0x67431D0", VA = "0x1867445D0")]
	private void EGEFIGGEFLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x6744330", Offset = "0x6742F30", VA = "0x186744330")]
	[AsyncStateMachine(typeof(NLMEJMEIAEF))]
	private Task DFMICCBPONE(JENGLAFMNAE FMBCMIJJNFA, JCNLMJJPKDF ECADBFJFBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x67454B0", Offset = "0x67440B0", VA = "0x1867454B0")]
	public PNMECIBNPOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[UnityEngine.Scripting.Preserve]
internal sealed class DJEGFGOCHAK : MBMBLPNEHHG, KINGOFPACJO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private struct HPEMMEFPJMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public AsyncTaskMethodBuilder<IDCOIPDFBIB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public DJEGFGOCHAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private TaskAwaiter<IDCOIPDFBIB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x6733670", Offset = "0x6732270", VA = "0x186733670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x6733900", Offset = "0x6732500", VA = "0x186733900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class HPPAPJLKAFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public GAGOKAHMDNO message;

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public HPPAPJLKAFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x6733970", Offset = "0x6732570", VA = "0x186733970")]
		internal object GNAFDEBONBN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class ALCIJMJFNKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public GAGOKAHMDNO messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public ALCIJMJFNKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x6727F40", Offset = "0x6726B40", VA = "0x186727F40")]
		internal object DFLILCDGGCI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class OAFCDLGJHGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public GAGOKAHMDNO request;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public OAFCDLGJHGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x6742030", Offset = "0x6740C30", VA = "0x186742030")]
		internal object OIHPFNCNFOP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct FMKEKEPBAMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public GAGOKAHMDNO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public DJEGFGOCHAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private LPACJKPPDGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private TaskAwaiter<PBAGONGALMM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x672F3D0", Offset = "0x672DFD0", VA = "0x18672F3D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x672FC90", Offset = "0x672E890", VA = "0x18672FC90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class LPEFBLLPCDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public GAGOKAHMDNO operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public LPEFBLLPCDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x673D240", Offset = "0x673BE40", VA = "0x18673D240")]
		internal object FMKCPCMAIPF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct FCHJHJLDPMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public GAGOKAHMDNO operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public DJEGFGOCHAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private LPACJKPPDGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private IOAFANGBINH <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private TaskAwaiter<GAGOKAHMDNO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x672D210", Offset = "0x672BE10", VA = "0x18672D210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x672DD80", Offset = "0x672C980", VA = "0x18672DD80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct BDABFAFCMCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public AsyncTaskMethodBuilder<PBAGONGALMM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public DJEGFGOCHAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public GAGOKAHMDNO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private IBLCAMPNLOK.NMDFLGFKOMG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private IOAFANGBINH <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private TaskAwaiter<GAGOKAHMDNO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x6728170", Offset = "0x6726D70", VA = "0x186728170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x6728690", Offset = "0x6727290", VA = "0x186728690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class PJOBKHOPPBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public PBAGONGALMM operation;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public PJOBKHOPPBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6743F30", Offset = "0x6742B30", VA = "0x186743F30")]
		internal object EKDOBKPEDFB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private struct AEILMECICFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public PBAGONGALMM operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public DJEGFGOCHAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private LPACJKPPDGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private DBCLHGHLEMD<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x67268B0", Offset = "0x67254B0", VA = "0x1867268B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x6726EF0", Offset = "0x6725AF0", VA = "0x186726EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class CBCLCFLBLLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public GAGOKAHMDNO request;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public CBCLCFLBLLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6729320", Offset = "0x6727F20", VA = "0x186729320")]
		internal object KJOOIJCFBLD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class OHCDFNILKMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public GAGOKAHMDNO request;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public OHCDFNILKMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x6743870", Offset = "0x6742470", VA = "0x186743870")]
		internal object CNKLAOFPGHG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private OEENMHGGAHN KLNOEOGFLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private GFEHHOKDKNO BPNGCPNGOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private KPMEJKPDGDP CHPADNIDKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private GCDHECDBFHP OCLLJLDDHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private IILECEBHMOO GHMLFJKNGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private TaskCompletionSource<IDCOIPDFBIB> CBJKIOEHCLG;

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x672C1B0", Offset = "0x672ADB0", VA = "0x18672C1B0", Slot = "7")]
	public void HAJAGMDCLHL(OEENMHGGAHN KLNOEOGFLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x672C5C0", Offset = "0x672B1C0", VA = "0x18672C5C0", Slot = "6")]
	[AsyncStateMachine(typeof(HPEMMEFPJMG))]
	public Task<IDCOIPDFBIB> NJHHPDPCCBD(CancellationToken JBHIKAGOLCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x672BA00", Offset = "0x672A600", VA = "0x18672BA00", Slot = "4")]
	public void EOCAFOFEBCF(GAGOKAHMDNO COECLHOAJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x672C6D0", Offset = "0x672B2D0", VA = "0x18672C6D0", Slot = "5")]
	public void PDACPPBIHLN(GAGOKAHMDNO DLFHHHGHOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x672B7D0", Offset = "0x672A3D0", VA = "0x18672B7D0")]
	[AsyncStateMachine(typeof(FMKEKEPBAMG))]
	private Task BBDHEFJNICM(GAGOKAHMDNO MLHMNLDOBPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x672C4B0", Offset = "0x672B0B0", VA = "0x18672C4B0")]
	[AsyncStateMachine(typeof(FCHJHJLDPMN))]
	private Task MPKNEPPEIJB(GAGOKAHMDNO FAEOKCJMKPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x672B680", Offset = "0x672A280", VA = "0x18672B680")]
	[AsyncStateMachine(typeof(BDABFAFCMCE))]
	private Task<PBAGONGALMM> AEHAAOOGBLO(GAGOKAHMDNO MLHMNLDOBPP, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x672C120", Offset = "0x672AD20", VA = "0x18672C120")]
	private IOAFANGBINH FIKEANMFPCK(GAGOKAHMDNO CGFOLHGCPPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x672B8E0", Offset = "0x672A4E0", VA = "0x18672B8E0")]
	[AsyncStateMachine(typeof(AEILMECICFP))]
	private Task ELODDPAMCKL(PBAGONGALMM ELLJNACABMF, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x672C2A0", Offset = "0x672AEA0", VA = "0x18672C2A0")]
	private PBAGONGALMM HCGGACEPCHP(GAGOKAHMDNO MLHMNLDOBPP, IOAFANGBINH IJPCDOKMFBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x2672060", Offset = "0x2670C60", VA = "0x182672060")]
	private T LLMLFOAIMEE<T>(T BLKAHBIJBJO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x672BD90", Offset = "0x672A990", VA = "0x18672BD90")]
	private PBAGONGALMM FCJGCLGHPME(GAGOKAHMDNO MLHMNLDOBPP, IOAFANGBINH IJPCDOKMFBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public DJEGFGOCHAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[UnityEngine.Scripting.Preserve]
internal sealed class KGCGKLEPCNG : KPMEJKPDGDP, KINGOFPACJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class NHFOFPECNIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public NHFOFPECNIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x6740870", Offset = "0x673F470", VA = "0x186740870")]
		internal object OEJKMOFPMBH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class LAAPIKEBFOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public LAAPIKEBFOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x673B6E0", Offset = "0x673A2E0", VA = "0x18673B6E0")]
		internal object OOLGCCBOGEB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private IILECEBHMOO GHMLFJKNGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private FLCMKIENGNI KCPIPLJPGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private MBMBLPNEHHG CPOONBINHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private DODMCLJGNGH IDDEIKHDDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private ODMMMMBOMOJ NLEFAEJKOLP;

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6739490", Offset = "0x6738090", VA = "0x186739490", Slot = "6")]
	public void HAJAGMDCLHL(OEENMHGGAHN KLNOEOGFLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6738F90", Offset = "0x6737B90", VA = "0x186738F90", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x67388D0", Offset = "0x67374D0", VA = "0x1867388D0", Slot = "4")]
	public AJPELLBGLGP CLGGPHPBCHF(GAGOKAHMDNO FABPGJPKKAF)
	{
		return default(AJPELLBGLGP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x67385F0", Offset = "0x67371F0", VA = "0x1867385F0", Slot = "5")]
	public void ABEKLKJCKKP(Guid BJNGDHCNCJP, Task MGGINNBKKGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x6738800", Offset = "0x6737400", VA = "0x186738800")]
	private void BGCDEDIHGMO(byte ONEOHOBMJLD, int FOGDIMNNGDP, object DKJOOLGBBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x6739E50", Offset = "0x6738A50", VA = "0x186739E50")]
	private void PJOFLFCOCDI(GENBBDFGOHK JOAOCJCBGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x67398B0", Offset = "0x67384B0", VA = "0x1867398B0")]
	private void LNIPDPIBPHC(GENBBDFGOHK JOAOCJCBGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x6739250", Offset = "0x6737E50", VA = "0x186739250")]
	private void GCEECCHIMAO(GENBBDFGOHK JOAOCJCBGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x67383B0", Offset = "0x6736FB0", VA = "0x1867383B0")]
	private HAGKOKKBGGA AAFDIFDFEFJ(GAGOKAHMDNO CGFOLHGCPPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x6739040", Offset = "0x6737C40", VA = "0x186739040")]
	private void FDBHDLFPEMJ(GAGOKAHMDNO FAEOKCJMKPN, HAGKOKKBGGA OGBAEECNMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6739600", Offset = "0x6738200", VA = "0x186739600")]
	private bool HLKBPAEMMJH(GAGOKAHMDNO FAEOKCJMKPN, HAGKOKKBGGA OGBAEECNMFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6738D10", Offset = "0x6737910", VA = "0x186738D10")]
	private bool DFEHCLIONDG(GAGOKAHMDNO PKEJOAGFILG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6739BC0", Offset = "0x67387C0", VA = "0x186739BC0")]
	private bool MHECMBOHCEH(byte ONEOHOBMJLD, ExitGames.Client.Photon.Hashtable JOAOCJCBGCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public KGCGKLEPCNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[UnityEngine.Scripting.Preserve]
internal sealed class AHGOEOMLHKH : GKFEGHGDEHH, KINGOFPACJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class AOIDGKIBHNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public IDCOIPDFBIB operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public AHGOEOMLHKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public GAGOKAHMDNO roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public AOIDGKIBHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x6727FD0", Offset = "0x6726BD0", VA = "0x186727FD0")]
		internal object GCCKEAECDLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x6728040", Offset = "0x6726C40", VA = "0x186728040")]
		internal object PAHJDMPGJGC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct NLCDJCGIMNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public AsyncTaskMethodBuilder<HAGKOKKBGGA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public AHGOEOMLHKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public GAGOKAHMDNO roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private LPACJKPPDGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private TaskAwaiter<HAGKOKKBGGA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x6740950", Offset = "0x673F550", VA = "0x186740950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x6740FE0", Offset = "0x673FBE0", VA = "0x186740FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class GBLKPKNOEBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public IDCOIPDFBIB operationType;

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public GBLKPKNOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x67302F0", Offset = "0x672EEF0", VA = "0x1867302F0")]
		internal object JKDFBCEGPFD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class AHBMPEDPHJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public GAGOKAHMDNO request;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public AHBMPEDPHJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x6726FC0", Offset = "0x6725BC0", VA = "0x186726FC0")]
		internal object NPEKEBBOFOA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x6727030", Offset = "0x6725C30", VA = "0x186727030")]
		internal object OKGBCJBNBOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x6726F50", Offset = "0x6725B50", VA = "0x186726F50")]
		internal object ILGDCAKEEIE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct GFBEBLMKBGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public AsyncTaskMethodBuilder<HAGKOKKBGGA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public GAGOKAHMDNO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public AHGOEOMLHKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private AHBMPEDPHJC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private LPACJKPPDGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private AJPELLBGLGP <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private HAGKOKKBGGA <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private TaskAwaiter<(HAGKOKKBGGA validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x67306F0", Offset = "0x672F2F0", VA = "0x1867306F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x6730FA0", Offset = "0x672FBA0", VA = "0x186730FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private IILECEBHMOO GHMLFJKNGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private FLCMKIENGNI KCPIPLJPGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private KPMEJKPDGDP CHPADNIDKEG;

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x67273B0", Offset = "0x6725FB0", VA = "0x1867273B0", Slot = "5")]
	public void HAJAGMDCLHL(OEENMHGGAHN KLNOEOGFLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x67270A0", Offset = "0x6725CA0", VA = "0x1867270A0", Slot = "4")]
	[AsyncStateMachine(typeof(NLCDJCGIMNM))]
	private Task<HAGKOKKBGGA> AKOJAILFBEN(GAGOKAHMDNO CGFOLHGCPPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x67271C0", Offset = "0x6725DC0", VA = "0x1867271C0")]
	private bool CILKIPMCBAM(IDCOIPDFBIB ACDBBCINPON, [Out] HAGKOKKBGGA MGHLKGJFBCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x6727460", Offset = "0x6726060", VA = "0x186727460")]
	[AsyncStateMachine(typeof(GFBEBLMKBGF))]
	private Task<HAGKOKKBGGA> OPOAKEMJHDK(GAGOKAHMDNO MLHMNLDOBPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public AHGOEOMLHKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class KHJBGGPAKHI : DDDLPBOPCJH, KINGOFPACJO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private struct IJOBDFPLCFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public AsyncTaskMethodBuilder<CGNOFECNPIB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public JENGLAFMNAE targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public KHJBGGPAKHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private TaskAwaiter<EOHIAKIOJAN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x67351C0", Offset = "0x6733DC0", VA = "0x1867351C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x6735670", Offset = "0x6734270", VA = "0x186735670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class IEJBHBGGNJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public IEJBHBGGNJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x6735110", Offset = "0x6733D10", VA = "0x186735110")]
		internal object DPIFPAJPIIF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct BNCJPDKNONC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public AsyncTaskMethodBuilder<EOHIAKIOJAN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public KHJBGGPAKHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public JENGLAFMNAE targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private IEJBHBGGNJD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<EOHIAKIOJAN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x6728CC0", Offset = "0x67278C0", VA = "0x186728CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x67292B0", Offset = "0x6727EB0", VA = "0x1867292B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class APCLFBEHFMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public APCLFBEHFMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x14E0170", Offset = "0x14DED70", VA = "0x1814E0170")]
		internal bool JMMIICHIGMJ(GOCLPCOPMCO sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private NCPOJFNGNHJ FOHLLAJCPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private EBEHLNDFOAM BPDNFCBIMIM;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static readonly (PBNLADHBLCA superRoomData, long subRoomDataSaveId) FEIPPLKCEOI;

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x673B2E0", Offset = "0x6739EE0", VA = "0x18673B2E0", Slot = "5")]
	public void HAJAGMDCLHL(OEENMHGGAHN KLNOEOGFLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x673B370", Offset = "0x6739F70", VA = "0x18673B370", Slot = "4")]
	[AsyncStateMachine(typeof(IJOBDFPLCFA))]
	public Task<CGNOFECNPIB> KKALOJINMDA(DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, JENGLAFMNAE PBJKAENPEMP, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x673AE90", Offset = "0x6739A90", VA = "0x18673AE90")]
	[AsyncStateMachine(typeof(BNCJPDKNONC))]
	private Task<EOHIAKIOJAN> BEGJEKIJGBK(JENGLAFMNAE PBJKAENPEMP, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x673B4D0", Offset = "0x673A0D0", VA = "0x18673B4D0")]
	private CGNOFECNPIB NJFJHAGGDHG(JENGLAFMNAE PBJKAENPEMP, EOHIAKIOJAN HGHFFDCBAEB, long FPCFGLFPIMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x673AFF0", Offset = "0x6739BF0", VA = "0x18673AFF0")]
	private (PBNLADHBLCA, long) DOBNFIPLNLN(JENGLAFMNAE PBJKAENPEMP, EOHIAKIOJAN HGHFFDCBAEB, long FPCFGLFPIMK)
	{
		return default((PBNLADHBLCA, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public KHJBGGPAKHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[UnityEngine.Scripting.Preserve]
internal sealed class ALBGMOOOMFC : GCDHECDBFHP, KINGOFPACJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class EIJPMODGELJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public GAGOKAHMDNO request;

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public EIJPMODGELJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x672D150", Offset = "0x672BD50", VA = "0x18672D150")]
		internal object IINKCCACGHN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct NEHFAOMGDMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public AsyncTaskMethodBuilder<GAGOKAHMDNO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public GAGOKAHMDNO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public ALBGMOOOMFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public IOAFANGBINH pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private LPACJKPPDGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private TaskAwaiter<GAGOKAHMDNO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x6740170", Offset = "0x673ED70", VA = "0x186740170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x6740780", Offset = "0x673F380", VA = "0x186740780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct KGGIJAFFGIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public AsyncTaskMethodBuilder<GAGOKAHMDNO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public ALBGMOOOMFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public IOAFANGBINH pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private LPACJKPPDGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private TaskAwaiter<IPDCMPAOKEJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x673A3F0", Offset = "0x6738FF0", VA = "0x18673A3F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x673A9F0", Offset = "0x67395F0", VA = "0x18673A9F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class LEAOOIIECKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public GAGOKAHMDNO request;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public LEAOOIIECKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x673B750", Offset = "0x673A350", VA = "0x18673B750")]
		internal object FNMGMGAGOOO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct DFMLCOFGDLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public AsyncTaskMethodBuilder<GAGOKAHMDNO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public GAGOKAHMDNO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public ALBGMOOOMFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public IOAFANGBINH pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private LPACJKPPDGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private MNCICDEGCNK <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private DPEGIIBFOPO <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private TaskAwaiter<IPDCMPAOKEJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x672A2B0", Offset = "0x6728EB0", VA = "0x18672A2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x672AEA0", Offset = "0x6729AA0", VA = "0x18672AEA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private IILECEBHMOO GHMLFJKNGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	private NDAGHOBLHOB AFPOMEPPHNI;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private MNMJHIIHKJP AOHOIIFNJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x6727BC0", Offset = "0x67267C0", VA = "0x186727BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x6727B30", Offset = "0x6726730", VA = "0x186727B30", Slot = "8")]
	public void HAJAGMDCLHL(OEENMHGGAHN KLNOEOGFLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x6727DE0", Offset = "0x67269E0", VA = "0x186727DE0", Slot = "4")]
	[AsyncStateMachine(typeof(NEHFAOMGDMO))]
	public Task<GAGOKAHMDNO> PDGOCPCFPCI(GAGOKAHMDNO MLHMNLDOBPP, IOAFANGBINH IJPCDOKMFBA, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x67275A0", Offset = "0x67261A0", VA = "0x1867275A0", Slot = "5")]
	[AsyncStateMachine(typeof(KGGIJAFFGIK))]
	public Task<GAGOKAHMDNO> BMOEGBJGPHN(CancellationToken EJGJLLMBDIN, IOAFANGBINH IJPCDOKMFBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x6727920", Offset = "0x6726520", VA = "0x186727920", Slot = "6")]
	public GHPEMABLJJA FOFLBKDIOJL(PBAGONGALMM CDPDFLHGOOD, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x67276F0", Offset = "0x67262F0", VA = "0x1867276F0", Slot = "7")]
	public GHPEMABLJJA DAMFDEBLGCJ(PBAGONGALMM CDPDFLHGOOD, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x6727C80", Offset = "0x6726880", VA = "0x186727C80")]
	[AsyncStateMachine(typeof(DFMLCOFGDLE))]
	private Task<GAGOKAHMDNO> LEJMMMGGCNO(GAGOKAHMDNO MLHMNLDOBPP, IOAFANGBINH IJPCDOKMFBA, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x27DC9A0", Offset = "0x27DB5A0", VA = "0x1827DC9A0")]
	private static byte[] PDNGJJMDLGJ(GAGOKAHMDNO COECLHOAJJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public ALBGMOOOMFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[UnityEngine.Scripting.Preserve]
internal sealed class JJFAOPACLHG : FLCMKIENGNI, KINGOFPACJO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private JOAOOFHFNGE GBNEDIOHLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private IILECEBHMOO GHMLFJKNGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private GFEHHOKDKNO BPNGCPNGOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private HJEOEBFAIKO NPLOJODCEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private NCPOJFNGNHJ FOHLLAJCPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private KHMMPJOGLIM JANPGPNIJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private OEOCHODKCLE AJLBNLJNPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private KFAFPFCILEP LCKLFNLGOKK;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private EELKBCOPMKF GFOFKJKPJCO
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x6737130", Offset = "0x6735D30", VA = "0x186737130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private static HAGKOKKBGGA ICNMPPFCNIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x672B620", Offset = "0x672A220", VA = "0x18672B620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x6737180", Offset = "0x6735D80", VA = "0x186737180", Slot = "6")]
	public void HAJAGMDCLHL(OEENMHGGAHN KLNOEOGFLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x67372F0", Offset = "0x6735EF0", VA = "0x1867372F0", Slot = "4")]
	public HAGKOKKBGGA MBBPMKNMEJF(IFDGJPHDBFK NKEHCHDOADO, IDCOIPDFBIB JLFKIJMCLBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x6737460", Offset = "0x6736060", VA = "0x186737460", Slot = "5")]
	public HAGKOKKBGGA NOMIKOCAHOP(IFDGJPHDBFK HMLJMNEDGLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x672B160", Offset = "0x6729D60", VA = "0x18672B160")]
	private static HAGKOKKBGGA DHCCGJOOMKI(MACAEIGIDMM PBFMPJEICKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public JJFAOPACLHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public class OGPKIMBDMOL : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x6743830", Offset = "0x6742430", VA = "0x186743830")]
	public OGPKIMBDMOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x5CB4380", Offset = "0x5CB2F80", VA = "0x185CB4380")]
	public OGPKIMBDMOL(string COECLHOAJJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[UnityEngine.Scripting.Preserve]
internal sealed class MEAPOCJHDNL : FKNCPDJFAMI, KINGOFPACJO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct ODCAMNFAMLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public AsyncTaskMethodBuilder<HAGKOKKBGGA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public MEAPOCJHDNL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public GEKIPCCOKMO autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private DBCLHGHLEMD<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private KEAEKGBNDMG <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private TaskAwaiter<HAGKOKKBGGA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x6742820", Offset = "0x6741420", VA = "0x186742820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x67433B0", Offset = "0x6741FB0", VA = "0x1867433B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct MAMBBKPGJGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public MEAPOCJHDNL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x673D500", Offset = "0x673C100", VA = "0x18673D500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x673DC50", Offset = "0x673C850", VA = "0x18673DC50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct MGJIGMJBFCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public MEAPOCJHDNL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x673F9C0", Offset = "0x673E5C0", VA = "0x18673F9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x673FED0", Offset = "0x673EAD0", VA = "0x18673FED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct CHMCFCGDGOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public MEAPOCJHDNL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x6729A60", Offset = "0x6728660", VA = "0x186729A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x672A1B0", Offset = "0x6728DB0", VA = "0x18672A1B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct HBBKMMCAIDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public MEAPOCJHDNL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x6732AD0", Offset = "0x67316D0", VA = "0x186732AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x6732C70", Offset = "0x6731870", VA = "0x186732C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct FDIEPJECDOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public MEAPOCJHDNL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x672DDE0", Offset = "0x672C9E0", VA = "0x18672DDE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x672E500", Offset = "0x672D100", VA = "0x18672E500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct JCGMMEFGCHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public MEAPOCJHDNL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x6736C60", Offset = "0x6735860", VA = "0x186736C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x67370D0", Offset = "0x6735CD0", VA = "0x1867370D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct OOFLPBCBJJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public MEAPOCJHDNL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public NBPGIDCICPL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private DBCLHGHLEMD<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x67438D0", Offset = "0x67424D0", VA = "0x1867438D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x6743E10", Offset = "0x6742A10", VA = "0x186743E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private IILECEBHMOO GHMLFJKNGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private OEENMHGGAHN KLNOEOGFLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private NCPOJFNGNHJ FOHLLAJCPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private GCDHECDBFHP OCLLJLDDHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private GFEHHOKDKNO BPNGCPNGOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private OEOCHODKCLE AJLBNLJNPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private CancellationTokenSource BPJMOOHPACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private Task NOILMDBIDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	private TaskCompletionSource<int> PJIHONMIHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	private int DDBONCLNBEF;

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x673F4B0", Offset = "0x673E0B0", VA = "0x18673F4B0", Slot = "6")]
	public void HAJAGMDCLHL(OEENMHGGAHN KLNOEOGFLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x906A10", Offset = "0x905610", VA = "0x180906A10", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x673F660", Offset = "0x673E260", VA = "0x18673F660")]
	private void MDEANLMNNPK(float NEHDOHOANNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x673F080", Offset = "0x673DC80", VA = "0x18673F080", Slot = "4")]
	[AsyncStateMachine(typeof(ODCAMNFAMLP))]
	public Task<HAGKOKKBGGA> EHAHEDNGODI(GEKIPCCOKMO FEBLDJCELMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x673EA20", Offset = "0x673D620", VA = "0x18673EA20", Slot = "5")]
	[AsyncStateMachine(typeof(MAMBBKPGJGG))]
	public Task BOGNDIAPNPD([Optional] CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x906A10", Offset = "0x905610", VA = "0x180906A10")]
	public void KNHIGPKFADD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x673F850", Offset = "0x673E450", VA = "0x18673F850")]
	private KEAEKGBNDMG OANDHAJBDOF(GEKIPCCOKMO FEBLDJCELMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x673EEA0", Offset = "0x673DAA0", VA = "0x18673EEA0")]
	[AsyncStateMachine(typeof(MGJIGMJBFCB))]
	private Task ECDBJPOPBHN(GPMIMHCABEE BGBHFDMLCDN, CancellationToken NFEFCAGIEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x673F1B0", Offset = "0x673DDB0", VA = "0x18673F1B0")]
	[AsyncStateMachine(typeof(CHMCFCGDGOO))]
	private Task FHOHPDKNFCM(CancellationToken NFEFCAGIEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x673F2B0", Offset = "0x673DEB0", VA = "0x18673F2B0")]
	[AsyncStateMachine(typeof(HBBKMMCAIDG))]
	private Task FLODFPOMBLA([Optional] CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x673EF90", Offset = "0x673DB90", VA = "0x18673EF90")]
	[AsyncStateMachine(typeof(FDIEPJECDOG))]
	private Task EFKFCJFKOBF(CancellationToken NFEFCAGIEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x673EDA0", Offset = "0x673D9A0", VA = "0x18673EDA0")]
	[AsyncStateMachine(typeof(JCGMMEFGCHJ))]
	private Task COKPBDLFOLI(CancellationToken MDFMNIBCIGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x673EB10", Offset = "0x673D710", VA = "0x18673EB10")]
	private Task CNPODECGDAA(NBPGIDCICPL GKFJBPLKJAE, CancellationToken NFEFCAGIEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x673F740", Offset = "0x673E340", VA = "0x18673F740")]
	[AsyncStateMachine(typeof(OOFLPBCBJJE))]
	private Task NOEBAEBLFBN(NBPGIDCICPL GKFJBPLKJAE, CancellationToken NFEFCAGIEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x673F3A0", Offset = "0x673DFA0", VA = "0x18673F3A0")]
	private bool GPILHJLEAFD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public MEAPOCJHDNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[UnityEngine.Scripting.Preserve]
internal class FNNJAKDCCAM : HJEOEBFAIKO, KINGOFPACJO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct BLANKBHJHOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public FNNJAKDCCAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private DBCLHGHLEMD<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x6728700", Offset = "0x6727300", VA = "0x186728700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x6728C60", Offset = "0x6727860", VA = "0x186728C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private OFPGEKNONIJ GJGCFDEOILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private OEENMHGGAHN KLNOEOGFLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private FLCMKIENGNI KCPIPLJPGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private GCDHECDBFHP OCLLJLDDHPD;

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x672FF90", Offset = "0x672EB90", VA = "0x18672FF90", Slot = "6")]
	public void HAJAGMDCLHL(OEENMHGGAHN KLNOEOGFLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x672FDE0", Offset = "0x672E9E0", VA = "0x18672FDE0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x672FE30", Offset = "0x672EA30", VA = "0x18672FE30", Slot = "5")]
	[AsyncStateMachine(typeof(BLANKBHJHOE))]
	public Task GGLLJFOHCLN(string CMCOOMKLEBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x672FF30", Offset = "0x672EB30", VA = "0x18672FF30", Slot = "4")]
	public HAGKOKKBGGA GPILHJLEAFD(IFDGJPHDBFK NKEHCHDOADO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x672FCF0", Offset = "0x672E8F0", VA = "0x18672FCF0")]
	private JDEFODDKDGM APFDELPPFCB(string CMCOOMKLEBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public FNNJAKDCCAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public static class JMFPFIPDKEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x6738170", Offset = "0x6736D70", VA = "0x186738170")]
	public static void NDMJFHJELGG(OJEGDOKHPNO JEAKPHJODOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x6737F30", Offset = "0x6736B30", VA = "0x186737F30")]
	internal static void GCLLPELILMP(OJEGDOKHPNO JEAKPHJODOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x6738090", Offset = "0x6736C90", VA = "0x186738090")]
	internal static void HKIDDEHMFFD(OJEGDOKHPNO JEAKPHJODOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x6737AE0", Offset = "0x67366E0", VA = "0x186737AE0")]
	internal static void AFCCAOLHAKD(OJEGDOKHPNO JEAKPHJODOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal class HFOEDKDLJBM : MNHBOKBFMJL<GAGOKAHMDNO>
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class KGKBLLNNALC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public GAGOKAHMDNO message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public KGKBLLNNALC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x673AA60", Offset = "0x6739660", VA = "0x18673AA60")]
		internal object CFBBAOENLDI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly HFOEDKDLJBM EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x6733010", Offset = "0x6731C10", VA = "0x186733010")]
	public ExitGames.Client.Photon.Hashtable GAPNIKJAJOO(GAGOKAHMDNO COECLHOAJJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x67330A0", Offset = "0x6731CA0", VA = "0x1867330A0", Slot = "5")]
	protected override void GIKHPHEGJGI(GAGOKAHMDNO COECLHOAJJF, IDictionary<object, object> KOMCCCIEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x6732DE0", Offset = "0x67319E0", VA = "0x186732DE0", Slot = "6")]
	public override GAGOKAHMDNO DPCADENMEMJ(IDictionary<object, object> KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x6732CD0", Offset = "0x67318D0", VA = "0x186732CD0")]
	private static void AGKNLPHAFKB(string DFJMNMOKLDD, GAGOKAHMDNO COECLHOAJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x6733510", Offset = "0x6732110", VA = "0x186733510")]
	public HFOEDKDLJBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x67331D0", Offset = "0x6731DD0", VA = "0x1867331D0")]
	[CompilerGenerated]
	internal static string ICKDNDFFFGJ(CGNOFECNPIB FGGJAKAMDOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class DGLCAOEEIGD
{
	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public static HAGKOKKBGGA ICNMPPFCNIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x672B620", Offset = "0x672A220", VA = "0x18672B620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x672B140", Offset = "0x6729D40", VA = "0x18672B140")]
	public static bool CMPPDNANHJF(this HAGKOKKBGGA OGBAEECNMFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x672B160", Offset = "0x6729D60", VA = "0x18672B160")]
	public static HAGKOKKBGGA DHCCGJOOMKI(MACAEIGIDMM NDFGNFFALAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x672B420", Offset = "0x672A020", VA = "0x18672B420")]
	public static HAGKOKKBGGA PCCIEGCGMEG(IEnumerable<HAGKOKKBGGA> DCEDBNIKOFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x672B1C0", Offset = "0x6729DC0", VA = "0x18672B1C0")]
	public static string GNCKPFHFHNE(this HAGKOKKBGGA MGHLKGJFBCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public abstract class GGDKCBKAOBH : LMMOAKJEDAK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public delegate HAGKOKKBGGA MAKKGAAOKAJ([NotNull] IFDGJPHDBFK EMFBHINFCOI);

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class IGDCEKIOFNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public IFDGJPHDBFK photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public IGDCEKIOFNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x5EAFE00", Offset = "0x5EAEA00", VA = "0x185EAFE00")]
		internal HAGKOKKBGGA MNOPCFJPOOG(MAKKGAAOKAJ v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private bool KLIIIEHJHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	protected readonly HashSet<MAKKGAAOKAJ> JPLDKDAHNLA;

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x6731360", Offset = "0x672FF60", VA = "0x186731360", Slot = "4")]
	public void PEOPFBOBDNJ(MAKKGAAOKAJ FDNGFEGPIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x6731300", Offset = "0x672FF00", VA = "0x186731300", Slot = "5")]
	public void HGAOEHOEDHG(MAKKGAAOKAJ FDNGFEGPIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x6731010", Offset = "0x672FC10", VA = "0x186731010", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x6731060", Offset = "0x672FC60", VA = "0x186731060")]
	protected HAGKOKKBGGA GLBLOPGKIHC(IFDGJPHDBFK HMLJMNEDGLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x67313C0", Offset = "0x672FFC0", VA = "0x1867313C0")]
	protected GGDKCBKAOBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public class DJKJOGJMBPE : GGDKCBKAOBH, JOAOOFHFNGE, LMMOAKJEDAK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[CompilerGenerated]
	private sealed class GJCNKAFJJGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public HAGKOKKBGGA result;

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public GJCNKAFJJGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x6732750", Offset = "0x6731350", VA = "0x186732750")]
		internal object GOCFLODIEDB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x672CB40", Offset = "0x672B740", VA = "0x18672CB40")]
	[UnityEngine.Scripting.Preserve]
	public DJKJOGJMBPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x672CA30", Offset = "0x672B630", VA = "0x18672CA30", Slot = "8")]
	public HAGKOKKBGGA JHANMCAFANL(IFDGJPHDBFK HMLJMNEDGLJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class OCFBOKAHKME : GGDKCBKAOBH, OFPGEKNONIJ, LMMOAKJEDAK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class EBCNONHMABJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public HAGKOKKBGGA result;

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public EBCNONHMABJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x672CB50", Offset = "0x672B750", VA = "0x18672CB50")]
		internal object CENNNIIPEHJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x672CB40", Offset = "0x672B740", VA = "0x18672CB40")]
	[UnityEngine.Scripting.Preserve]
	public OCFBOKAHKME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x6742090", Offset = "0x6740C90", VA = "0x186742090", Slot = "8")]
	public HAGKOKKBGGA GPILHJLEAFD(IFDGJPHDBFK ANJKAMGJFHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class LPFLECDIOOK
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private sealed class FOOEGLBCHDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public DBCLHGHLEMD<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public FOOEGLBCHDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x6730270", Offset = "0x672EE70", VA = "0x186730270")]
		internal object FKNFDPBANNF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x673D420", Offset = "0x673C020", VA = "0x18673D420")]
	public static DBCLHGHLEMD<string> NAAEGKKEFNB(HEENJBKIIAO BNEDOBBKLOJ, [Optional] string PNGGLPDCKFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x673D360", Offset = "0x673BF60", VA = "0x18673D360")]
	public static void IBOHCNMCIOK(DBCLHGHLEMD<string> KAMOOCNEONO, HEENJBKIIAO BNEDOBBKLOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x673D2A0", Offset = "0x673BEA0", VA = "0x18673D2A0")]
	public static string CMAKPFBMINI(GAGOKAHMDNO CGFOLHGCPPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal static class CCFFOKBMHOL
{
	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x67294A0", Offset = "0x67280A0", VA = "0x1867294A0")]
	public static void MEFEELJIOMF(this IILECEBHMOO GHMLFJKNGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x67294B0", Offset = "0x67280B0", VA = "0x1867294B0")]
	public static void PNGNHDGBNAD(this IILECEBHMOO GHMLFJKNGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x6729380", Offset = "0x6727F80", VA = "0x186729380")]
	private static void DINGOMNIJNF(this IILECEBHMOO GHMLFJKNGCO, bool GLKCJBJPJJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class MAOKCGIBAAG : LALNFHOFOPG, GMEKEFDMGII, MKFIEGKOAKK, LCPENDGOOKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private readonly GMEKEFDMGII JOPGLLCNOPK;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public IFDGJPHDBFK CIBDPCDMPMI
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x673DED0", Offset = "0x673CAD0", VA = "0x18673DED0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int CBHHCFPLHCH
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x673E130", Offset = "0x673CD30", VA = "0x18673E130", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public int CDGJMIMEINP
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x673DD00", Offset = "0x673C900", VA = "0x18673DD00", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool GNDLLJFJGEH
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7CBA20", Offset = "0x7CA620", VA = "0x1807CBA20", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public int CBGEMMLBKPK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x8729D0", Offset = "0x8715D0", VA = "0x1808729D0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event MIBDPDNAPPM.LJPOMBNMIBN BPBDGEFPOPK
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event EGJPHMJGGKH DEDJADBOGCD
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x673DF20", Offset = "0x673CB20", VA = "0x18673DF20", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x673DE30", Offset = "0x673CA30", VA = "0x18673DE30", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> OCIKJBHPPFO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<IFDGJPHDBFK> HPMLFPJHCOG
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action NHLIHFMOCCC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x673E180", Offset = "0x673CD80", VA = "0x18673E180", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x673DFC0", Offset = "0x673CBC0", VA = "0x18673DFC0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0xD66690", Offset = "0xD65290", VA = "0x180D66690")]
	public MAOKCGIBAAG(GMEKEFDMGII JOPGLLCNOPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x673E060", Offset = "0x673CC60", VA = "0x18673E060", Slot = "8")]
	public bool KAOJLDDGOAP(byte ONEOHOBMJLD, ExitGames.Client.Photon.Hashtable MACGCMOFENL, DLBLDBANNAG MJEFBPMPHGH, SendOptions LHFHGCBJHGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x673DD50", Offset = "0x673C950", VA = "0x18673DD50", Slot = "16")]
	public IFDGJPHDBFK FPKJICCAAOO(int LIPACLDMHDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "19")]
	public void JLHIGKMEBDH(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "20")]
	public void BOGIJNBNCNA(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "21")]
	public void GLGJFDBFFKE(object DGPOLLDAHJK, bool FEFNOLNHMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x673DCB0", Offset = "0x673C8B0", VA = "0x18673DCB0", Slot = "22")]
	public IDisposable DELEMFHNFHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "23")]
	private bool NALEOLMMIAG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "24")]
	public void CEABLFPFIBL(StringBuilder PKIGBHCOCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x673E110", Offset = "0x673CD10", VA = "0x18673E110", Slot = "25")]
	public bool LIHIADLADLJ(bool PBEAIODEPGA, [Out] string JDDBJGCFGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x823220", Offset = "0x821E20", VA = "0x180823220", Slot = "28")]
	public void NBACDHCFNAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal struct GENBBDFGOHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private readonly IDictionary<object, object> JOAOCJCBGCO;

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x93C290", Offset = "0x93AE90", VA = "0x18093C290")]
	public GENBBDFGOHK(IDictionary<object, object> JOAOCJCBGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x6730500", Offset = "0x672F100", VA = "0x186730500")]
	public bool NPAGOELGCIB([Out] GAGOKAHMDNO COECLHOAJJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x6730450", Offset = "0x672F050", VA = "0x186730450")]
	public Guid NJDNOBHADJI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x67305B0", Offset = "0x672F1B0", VA = "0x1867305B0")]
	public HAGKOKKBGGA ODKBNGMJNAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x6730360", Offset = "0x672EF60", VA = "0x186730360")]
	public static ExitGames.Client.Photon.Hashtable JOBBHNKGDPO(GAGOKAHMDNO COECLHOAJJF, HAGKOKKBGGA OGBAEECNMFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal static class NGIFMIPOMBJ
{
	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x67407F0", Offset = "0x673F3F0", VA = "0x1867407F0")]
	public static bool CPAFDIFLADI(this JENGLAFMNAE OANIEGOBMMB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal struct ECCGJHFFMJB : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct MHEADHKDHGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public ECCGJHFFMJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x673FF30", Offset = "0x673EB30", VA = "0x18673FF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x6740110", Offset = "0x673ED10", VA = "0x186740110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private readonly CancellationTokenSource PMGENMHPOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	private bool KLIIIEHJHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private Task BKPEJJIHAHC;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool CBDMCJHEAKH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x672CC00", Offset = "0x672B800", VA = "0x18672CC00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x672CD40", Offset = "0x672B940", VA = "0x18672CD40")]
	public ECCGJHFFMJB(CancellationToken EJGJLLMBDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x672CC30", Offset = "0x672B830", VA = "0x18672CC30")]
	[AsyncStateMachine(typeof(MHEADHKDHGD))]
	public Task KFCGNNBAIEK(Func<CancellationToken, List<Task>> BHBKDGHCAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x672CBB0", Offset = "0x672B7B0", VA = "0x18672CBB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public readonly struct MHBILPKPHOO<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct PKPLBCAJEGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<POBLOMHIDDD<TData>, PHFFNBEEJOM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public MHBILPKPHOO<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private TaskAwaiter<DGKNLHNBBJB<POBLOMHIDDD<TData>, PHFFNBEEJOM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x411C9B0", Offset = "0x411B5B0", VA = "0x18411C9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x38DDBF0", Offset = "0x38DC7F0", VA = "0x1838DDBF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private readonly OBPOJGLFOBK<TGetDataArg, TData> AJFJAGOPOOC;

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x93C290", Offset = "0x93AE90", VA = "0x18093C290")]
	internal MHBILPKPHOO(OBPOJGLFOBK<TGetDataArg, TData> BNNGNHILECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x3E25FB0", Offset = "0x3E24BB0", VA = "0x183E25FB0")]
	[AsyncStateMachine(typeof(MHBILPKPHOO<, >.PKPLBCAJEGH))]
	public Task<DGKNLHNBBJB<POBLOMHIDDD<TData>, PHFFNBEEJOM>> LJGMDDLCBGP(TGetDataArg KPLKBKJIAEI, string DMLNNAAGNOB, DBCLHGHLEMD<string>.OGCCDEKKEPE KAMOOCNEONO, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public static class JAOFLOAJPLK
{
	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x2597F60", Offset = "0x2596B60", VA = "0x182597F60")]
	public static MHBILPKPHOO<TGetDataArg, TData> CIGBOGDFGOD<TGetDataArg, TData>(OBPOJGLFOBK<TGetDataArg, TData> BNNGNHILECN)
	{
		return default(MHBILPKPHOO<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public struct GKLIGJLPBPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public readonly int PEDLELNEMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public readonly int? LAIBODMBOPO;

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x3BF5020", Offset = "0x3BF3C20", VA = "0x183BF5020")]
	public GKLIGJLPBPE(int HGPDOHBCNJK, [Optional] int? DOOLHBJJDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x67329F0", Offset = "0x67315F0", VA = "0x1867329F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public interface JPACOACGDMO<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFKLAJNPMJK();

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JPACOACGDMO<T> KOOBKONIPNE(string IHHJDMCPGLC);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JPACOACGDMO<T> HJMEGENNDGA(CBEAEEOGEGB<T> ENCDJKFHKIM);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JPACOACGDMO<T> EMPKKEFEFFK(int OECLKDJBFMA);

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JPACOACGDMO<T> HECLPFBBKDH(int OECLKDJBFMA, AKBIHEJDKMB<T> IEMACCBCEDI);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public interface IGMACCECEBE
{
	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JPACOACGDMO<T> PHNDMALLFLJ<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ECIJGFAMBPJ MDKLHLIAMLA(Exception BJCOEJJDGCE);

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GKLIGJLPBPE OHIGOLOINKB(Exception BJCOEJJDGCE);
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public delegate string CBEAEEOGEGB<in T>(T BJCOEJJDGCE) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public delegate int AKBIHEJDKMB<in T>(T BJCOEJJDGCE) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal class ICCKBPNKMJJ : IGMACCECEBE
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private delegate string LBJFLELDIFA(Exception BJCOEJJDGCE);

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	private delegate int DJIOCFMNEIE(Exception BJCOEJJDGCE);

	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	private class MNOAENMGNGB<T> : JPACOACGDMO<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private sealed class NFFGBCAAJKD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public NFFGBCAAJKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
			internal string OFLHIKBLNCD(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private sealed class CJBPJEMHFPI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			public CBEAEEOGEGB<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public CJBPJEMHFPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0x47F0BD0", Offset = "0x47EF7D0", VA = "0x1847F0BD0")]
			internal string IJJJOGCHOGG(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E5")]
		[CompilerGenerated]
		private sealed class BLEBBKFNPAN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000314")]
			public AKBIHEJDKMB<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public BLEBBKFNPAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x47F0BD0", Offset = "0x47EF7D0", VA = "0x1847F0BD0")]
			internal int GFLCLGNGMNP(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private readonly ICCKBPNKMJJ KCNBDPIGCCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private readonly Type DNNIMINKAHJ;

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x3E91990", Offset = "0x3E90590", VA = "0x183E91990")]
		internal MNOAENMGNGB(ICCKBPNKMJJ KCNBDPIGCCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x3E91620", Offset = "0x3E90220", VA = "0x183E91620", Slot = "4")]
		public void GFKLAJNPMJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x3E91880", Offset = "0x3E90480", VA = "0x183E91880", Slot = "5")]
		public JPACOACGDMO<T> KOOBKONIPNE(string IHHJDMCPGLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x3E91770", Offset = "0x3E90370", VA = "0x183E91770", Slot = "6")]
		public JPACOACGDMO<T> HJMEGENNDGA(CBEAEEOGEGB<T> ENCDJKFHKIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x3E915E0", Offset = "0x3E901E0", VA = "0x183E915E0", Slot = "7")]
		public JPACOACGDMO<T> EMPKKEFEFFK(int OECLKDJBFMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x3E91650", Offset = "0x3E90250", VA = "0x183E91650", Slot = "8")]
		public JPACOACGDMO<T> HECLPFBBKDH(int OECLKDJBFMA, AKBIHEJDKMB<T> IEMACCBCEDI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private class JCOABMLHHAL<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private bool JAFAOMGDKEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private readonly List<Type> MNPCFHNHLAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private readonly Dictionary<Type, TVal> ENNDPHCCPKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private readonly Dictionary<Type, int> EMJEMGAODFF;

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public IReadOnlyList<Type> GDCLELOIBIL
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x3AEFB40", Offset = "0x3AEE740", VA = "0x183AEFB40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x3AEFE10", Offset = "0x3AEEA10", VA = "0x183AEFE10")]
		public JCOABMLHHAL(Dictionary<Type, int> EMJEMGAODFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF840", Offset = "0x3AEE440", VA = "0x183AEF840")]
		public void BGJHDHHBMPP(Type CGGNJKGENIH, TVal NOPNOIONIBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x3AEFCC0", Offset = "0x3AEE8C0", VA = "0x183AEFCC0")]
		public bool NACCEONLIPD(Type DNNIMINKAHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF9C0", Offset = "0x3AEE5C0", VA = "0x183AEF9C0")]
		public bool FFNOFAOGPCB(TVal BLKAHBIJBJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF980", Offset = "0x3AEE580", VA = "0x183AEF980")]
		public TVal CPPPHMALPOD(Type CJEAJMFMNNJ)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x3AEFAA0", Offset = "0x3AEE6A0", VA = "0x183AEFAA0")]
		[CompilerGenerated]
		private int HIDICJDAJNA(Type HEBOELIBBEE, Type KGMEKPOGIHC)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class MDGCPBCDANA : IEnumerable<GKLIGJLPBPE>, IEnumerable, IEnumerator<GKLIGJLPBPE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private GKLIGJLPBPE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public ICCKBPNKMJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private IEnumerator<GKLIGJLPBPE> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		private GKLIGJLPBPE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x339F1A0", Offset = "0x339DDA0", VA = "0x18339F1A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(GKLIGJLPBPE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x673E880", Offset = "0x673D480", VA = "0x18673E880", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x808950", Offset = "0x807550", VA = "0x180808950")]
		[DebuggerHidden]
		public MDGCPBCDANA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x673E8D0", Offset = "0x673D4D0", VA = "0x18673E8D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x673E2C0", Offset = "0x673CEC0", VA = "0x18673E2C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x673E220", Offset = "0x673CE20", VA = "0x18673E220")]
		private void DPHAFEJOOLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x673E270", Offset = "0x673CE70", VA = "0x18673E270")]
		private void KFBCLBKCPOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x673E830", Offset = "0x673D430", VA = "0x18673E830", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x673E770", Offset = "0x673D370", VA = "0x18673E770", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GKLIGJLPBPE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x673E770", Offset = "0x673D370", VA = "0x18673E770", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	private static readonly GKLIGJLPBPE JOIFNMDDILG;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	private static readonly Dictionary<Type, int> BJFLPNMMOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	private readonly HashSet<Type> OPIKDDEMGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private readonly JCOABMLHHAL<int> OOKNKHKLDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private readonly JCOABMLHHAL<DJIOCFMNEIE> EIDDACDHADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private readonly JCOABMLHHAL<LBJFLELDIFA> BFIPOMMALKC;

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x67339D0", Offset = "0x67325D0", VA = "0x1867339D0")]
	[JDFNDIEGGDI(COFBNFOEGIB.GameOnly)]
	private static void ADHPCFGLOFB(OJEGDOKHPNO KFDFGHNENJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x6734DD0", Offset = "0x67339D0", VA = "0x186734DD0")]
	[RecRoom.NoEngine.Common.Preserve]
	public ICCKBPNKMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x2690E60", Offset = "0x268FA60", VA = "0x182690E60", Slot = "4")]
	public JPACOACGDMO<T> PHNDMALLFLJ<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x67347A0", Offset = "0x67333A0", VA = "0x1867347A0", Slot = "5")]
	public ECIJGFAMBPJ MDKLHLIAMLA(Exception BJCOEJJDGCE)
	{
		return default(ECIJGFAMBPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x6734B00", Offset = "0x6733700", VA = "0x186734B00", Slot = "6")]
	public GKLIGJLPBPE OHIGOLOINKB(Exception? BJCOEJJDGCE)
	{
		return default(GKLIGJLPBPE);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x6733C70", Offset = "0x6732870", VA = "0x186733C70", Slot = "7")]
	[IteratorStateMachine(typeof(MDGCPBCDANA))]
	public IEnumerable<GKLIGJLPBPE> DLHFFDMAIIM(Exception BJCOEJJDGCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x6733B20", Offset = "0x6732720", VA = "0x186733B20", Slot = "8")]
	public string BCGCNDKIJHK(Exception? BJCOEJJDGCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x67340E0", Offset = "0x6732CE0", VA = "0x1867340E0")]
	private string KKNFMIKAHBF(AggregateException DONCEANCOOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x67343F0", Offset = "0x6732FF0", VA = "0x1867343F0")]
	private void LFFOODDHPGO(Type DNNIMINKAHJ, int OECLKDJBFMA, DJIOCFMNEIE? FGOANMOMHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x6733D10", Offset = "0x6732910", VA = "0x186733D10")]
	private void EPEJFJMEACK(Type DNNIMINKAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x6734830", Offset = "0x6733430", VA = "0x186734830")]
	private void OBDLBNKIHEE(Type DNNIMINKAHJ, LBJFLELDIFA BBCMDKINIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x6733F60", Offset = "0x6732B60", VA = "0x186733F60")]
	private static int IEJAJGDHOLJ(Type DNNIMINKAHJ, Dictionary<Type, int> EMJEMGAODFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x2803B40", Offset = "0x2802740", VA = "0x182803B40")]
	private static bool DCHMDAPBKND<TVal>(JCOABMLHHAL<TVal> BEGLJNBNMKI, Type DNNIMINKAHJ, [Out] TVal BLKAHBIJBJO) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x6733A40", Offset = "0x6732640", VA = "0x186733A40")]
	[CompilerGenerated]
	internal static int AIGJICCMMKB(Type PLODIMGOLBB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public struct ECIJGFAMBPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public readonly GKLIGJLPBPE ELCNMPECPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public readonly string HBIOLODJJFA;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x672CF10", Offset = "0x672BB10", VA = "0x18672CF10")]
	public ECIJGFAMBPJ(string DHCONFHCNBK, GKLIGJLPBPE OECLKDJBFMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x672CE70", Offset = "0x672BA70", VA = "0x18672CE70")]
	public string BCPEJECOGMO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public class FKNHFKFGPNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	private readonly PPHJJGMPHOI GJAPHKFCHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private string CJBNIABMHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private long? BDONMNKEKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	private long? ANNBLOPJLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private long? ODMNBCFIOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	private string FGAACEAFGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private KGFEPDLLDBL JHEOCOEPMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private long? EKDNBIIFIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private bool OOLKBBDBMEM;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public string GOIDLDEBGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public long ENEDGBJGHEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x672EC00", Offset = "0x672D800", VA = "0x18672EC00")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public long PENAEKPICJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x672EF10", Offset = "0x672DB10", VA = "0x18672EF10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public long JGDHNBIKCLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x672EC60", Offset = "0x672D860", VA = "0x18672EC60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public string OKCMEHIFBPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x672E560", Offset = "0x672D160", VA = "0x18672E560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public KGFEPDLLDBL MDLDCHOGBBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xDB7620", Offset = "0xDB6220", VA = "0x180DB7620")]
		get
		{
			return default(KGFEPDLLDBL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x672E5A0", Offset = "0x672D1A0", VA = "0x18672E5A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public long EANOHHHDJLO
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x672E690", Offset = "0x672D290", VA = "0x18672E690")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x672F390", Offset = "0x672DF90", VA = "0x18672F390")]
	[UnityEngine.Scripting.Preserve]
	public FKNHFKFGPNP([NNEMKPMNJAE(null)] PPHJJGMPHOI GJAPHKFCHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x672ECC0", Offset = "0x672D8C0", VA = "0x18672ECC0")]
	private void NHOJCMDEFKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x672E6F0", Offset = "0x672D2F0", VA = "0x18672E6F0")]
	public void HHIDHMBJLJM(long MGDJPIEDFNB, long FPCFGLFPIMK, [Optional] long? NGMKLALOJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x672F2F0", Offset = "0x672DEF0", VA = "0x18672F2F0")]
	public void PEKLJLEBIJI(long NGMKLALOJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x672EB80", Offset = "0x672D780", VA = "0x18672EB80")]
	public void JGFNKGLGDNC(string DDGJLFOGKNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x672EF70", Offset = "0x672DB70", VA = "0x18672EF70")]
	public void OFFLDNPBDNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal class GHPEMABLJJA : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct CEPIMIOIICD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public AsyncTaskMethodBuilder<GAGOKAHMDNO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public GAGOKAHMDNO roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public GHPEMABLJJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private TaskAwaiter<MNMJHIIHKJP.EKLJMCEJHAF<GAGOKAHMDNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x67294C0", Offset = "0x67280C0", VA = "0x1867294C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x67299F0", Offset = "0x67285F0", VA = "0x1867299F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct HEKJHBHGLCK<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class KHAOKDNALCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public GAGOKAHMDNO roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public KHAOKDNALCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x673ADB0", Offset = "0x67399B0", VA = "0x18673ADB0")]
		internal GAGOKAHMDNO OBCNACFEFAP(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct OCGNAJGBNCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public AsyncTaskMethodBuilder<MNMJHIIHKJP.EKLJMCEJHAF<GAGOKAHMDNO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public GAGOKAHMDNO roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public GHPEMABLJJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private MNCICDEGCNK <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private TaskAwaiter<MNMJHIIHKJP.EKLJMCEJHAF<GAGOKAHMDNO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x67421A0", Offset = "0x6740DA0", VA = "0x1867421A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x67427B0", Offset = "0x67413B0", VA = "0x1867427B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct HIKDOEGMHNC<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public GHPEMABLJJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x386D5A0", Offset = "0x386C1A0", VA = "0x18386D5A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x372A550", Offset = "0x3729150", VA = "0x18372A550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct EIJFPAICGNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public GHPEMABLJJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x672CF30", Offset = "0x672BB30", VA = "0x18672CF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x672D0F0", Offset = "0x672BCF0", VA = "0x18672D0F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class HLCOKMINHEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public HLCOKMINHEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x6733610", Offset = "0x6732210", VA = "0x186733610")]
		internal object LMPPJKBFCEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x6733550", Offset = "0x6732150", VA = "0x186733550")]
		internal bool GIEMPFLEFMA(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class JMDAKPHLINK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public JMDAKPHLINK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x6737A80", Offset = "0x6736680", VA = "0x186737A80")]
		internal object AAEOIBFAIGE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private sealed class LOODCKALHOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public LOODCKALHOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x673D1D0", Offset = "0x673BDD0", VA = "0x18673D1D0")]
		internal object KDINMNONOKA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private sealed class NKOKCDPEBEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public NKOKCDPEBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x67408E0", Offset = "0x673F4E0", VA = "0x1867408E0")]
		internal object BAMGOFLCHAJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class GKHEOGHNELA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public GHPEMABLJJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public GKHEOGHNELA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x67327B0", Offset = "0x67313B0", VA = "0x1867327B0")]
		internal object CFBBAOENLDI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private static readonly Guid FMPMOMGEABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public readonly PBAGONGALMM NAPHNIIEAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private readonly MNMJHIIHKJP OINGGDBGDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private readonly MKFIEGKOAKK GHMLFJKNGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private readonly LCPENDGOOKA HFOJBNIKOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private bool HEKOBHHFGCC;

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x6732520", Offset = "0x6731120", VA = "0x186732520")]
	public GHPEMABLJJA(PBAGONGALMM ELLJNACABMF, MNMJHIIHKJP OINGGDBGDDH, MKFIEGKOAKK GHMLFJKNGCO, LCPENDGOOKA HFOJBNIKOMD, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x67315B0", Offset = "0x67301B0", VA = "0x1867315B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x67315B0", Offset = "0x67301B0", VA = "0x1867315B0")]
	public void FPBLIOFFJOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x6731E30", Offset = "0x6730A30", VA = "0x186731E30")]
	public void HENIEOAIALM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x6731C60", Offset = "0x6730860", VA = "0x186731C60")]
	public void GFOPNPCDLAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x6731F70", Offset = "0x6730B70", VA = "0x186731F70")]
	[AsyncStateMachine(typeof(CEPIMIOIICD))]
	internal Task<GAGOKAHMDNO> JHHKBOHJPIN(DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, GAGOKAHMDNO CGFOLHGCPPN, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x27DC9A0", Offset = "0x27DB5A0", VA = "0x1827DC9A0")]
	private static byte[] PPELIEAACHI<T>(T COECLHOAJJF) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x27DC850", Offset = "0x27DB450", VA = "0x1827DC850")]
	private static T NBMCCCJGFMF<T>(MessageParser<T> CFBJNHPPKHG, byte[] COECLHOAJJF, T MHNBGMEGFLC) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x67320D0", Offset = "0x6730CD0", VA = "0x1867320D0")]
	[AsyncStateMachine(typeof(OCGNAJGBNCN))]
	private Task<MNMJHIIHKJP.EKLJMCEJHAF<GAGOKAHMDNO>> MDJALBIIKOB(GAGOKAHMDNO CGFOLHGCPPN, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x27DC4E0", Offset = "0x27DB0E0", VA = "0x1827DC4E0")]
	[AsyncStateMachine(typeof(HIKDOEGMHNC<>))]
	internal Task<T> ELCDOLFICAO<T>(CancellationToken NFEFCAGIEPH, Func<CancellationToken, Task<T>> LNHKGEDNPMN, int HPAJIJEPPFL = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x6731750", Offset = "0x6730350", VA = "0x186731750")]
	[AsyncStateMachine(typeof(EIJFPAICGNA))]
	internal Task ELCDOLFICAO(CancellationToken NFEFCAGIEPH, Func<CancellationToken, Task> LNHKGEDNPMN, int HPAJIJEPPFL = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x67316D0", Offset = "0x67302D0", VA = "0x1867316D0")]
	public MNMLLHFKGBF EBCIAMLPGDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x6731EF0", Offset = "0x6730AF0", VA = "0x186731EF0")]
	public CEELIFJHAPK HNBBPMCBCFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x6731B10", Offset = "0x6730710", VA = "0x186731B10")]
	public APEGMDBPPMF GEIKHCIDNAI([Optional] HEENJBKIIAO? BNEDOBBKLOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x6732210", Offset = "0x6730E10", VA = "0x186732210")]
	public void NJLDCHGDOOD(Func<Guid, bool> FIBMFFMADMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x6731D20", Offset = "0x6730920", VA = "0x186731D20")]
	public void GOILADCEOEP(Func<Guid, bool> MNPNPCLHNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x6731990", Offset = "0x6730590", VA = "0x186731990")]
	public Guid FPJPOOPOEOH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x6731880", Offset = "0x6730480", VA = "0x186731880")]
	public void FCBMODBOHID(Guid CLLNNDFKDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x6732370", Offset = "0x6730F70", VA = "0x186732370")]
	public void OAAKNLOIMHE(GAGOKAHMDNO MONCPDKFMLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x6731450", Offset = "0x6730050", VA = "0x186731450")]
	public void AGKNLPHAFKB(string ABNAHAKKPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x27DC760", Offset = "0x27DB360", VA = "0x1827DC760")]
	private T LLMLFOAIMEE<T>(T BLKAHBIJBJO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x6731560", Offset = "0x6730160", VA = "0x186731560")]
	public void CPEHJNFLPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x27DC230", Offset = "0x27DAE30", VA = "0x1827DC230")]
	[CompilerGenerated]
	internal static string BANOOKNLBBJ<T>(byte[] PJGIELDOKCN, int ONLOKNDIICL, HEKJHBHGLCK<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal sealed class LJIHBAKABMP : PBAGONGALMM
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class FNKOIHBNDID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public FNKOIHBNDID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x674EEA0", Offset = "0x674DAA0", VA = "0x18674EEA0")]
		internal object HILAGMEKOAE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct FDPLHEMCPBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public LJIHBAKABMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public GHPEMABLJJA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private ICIKGNAKMLM <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private CEELIFJHAPK <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x674DC10", Offset = "0x674C810", VA = "0x18674DC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x674E3F0", Offset = "0x674CFF0", VA = "0x18674E3F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private struct LBADAGLCBMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public LJIHBAKABMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private bool <omIsEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private bool <omShouldBeEnabled>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private TaskAwaiter<EOHIAKIOJAN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private TaskAwaiter<byte> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x67559C0", Offset = "0x67545C0", VA = "0x1867559C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x6756070", Offset = "0x6754C70", VA = "0x186756070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private struct JDDCBHPEPOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public LJIHBAKABMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private TaskAwaiter<JPFIIAMMGLD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x6752C40", Offset = "0x6751840", VA = "0x186752C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x6752F60", Offset = "0x6751B60", VA = "0x186752F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class DECAEJIIDOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public ICIKGNAKMLM presence;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public DECAEJIIDOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x674AE30", Offset = "0x6749A30", VA = "0x18674AE30")]
		internal object HDAEHAGGEIJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private static readonly HEENJBKIIAO BNEDOBBKLOJ;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private static readonly HEENJBKIIAO LGBIBAMCPDJ;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private static readonly HEENJBKIIAO GMGGHMBFJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private readonly CGNOFECNPIB FDELMALCMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	private readonly JENGLAFMNAE ACFIBGFBPOJ;

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x673CC20", Offset = "0x673B820", VA = "0x18673CC20")]
	public LJIHBAKABMP(CGNOFECNPIB FDELMALCMCO, JENGLAFMNAE ACFIBGFBPOJ, Guid BJNGDHCNCJP, OEENMHGGAHN KLNOEOGFLGJ, IOAFANGBINH AKBNCMIKDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x673C720", Offset = "0x673B320", VA = "0x18673C720", Slot = "7")]
	[AsyncStateMachine(typeof(FDPLHEMCPBK))]
	protected override Task NCEOEIDLMPF(GHPEMABLJJA ABCGAGONEBP, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x673C860", Offset = "0x673B460", VA = "0x18673C860")]
	[AsyncStateMachine(typeof(LBADAGLCBMG))]
	private Task OBHOOCGLFFI(CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x673C610", Offset = "0x673B210", VA = "0x18673C610")]
	[AsyncStateMachine(typeof(JDDCBHPEPOP))]
	private Task<byte> AIOIEKAOOOH(CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x673C960", Offset = "0x673B560", VA = "0x18673C960")]
	private ICIKGNAKMLM PGJPGHBJHCO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
internal class KEAEKGBNDMG : PBAGONGALMM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct IKAONBKDNCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public KEAEKGBNDMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public GHPEMABLJJA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private TaskAwaiter<GILBFMDGNPJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x6751E50", Offset = "0x6750A50", VA = "0x186751E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x67527D0", Offset = "0x67513D0", VA = "0x1867527D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400037D")]
	private readonly int LLEDKGILKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	private readonly GEKIPCCOKMO JFCBPOJCGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public readonly long NBHCAKIGHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public readonly long PAHEHFDDMNK;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public GILBFMDGNPJ HOPDKIBKAOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x7B1610", Offset = "0x7B0210", VA = "0x1807B1610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x7B1580", Offset = "0x7B0180", VA = "0x1807B1580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x67554A0", Offset = "0x67540A0", VA = "0x1867554A0")]
	public KEAEKGBNDMG(Guid BJNGDHCNCJP, OEENMHGGAHN KLNOEOGFLGJ, IOAFANGBINH AKBNCMIKDJH, int LLEDKGILKGI, GEKIPCCOKMO JFCBPOJCGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x6755380", Offset = "0x6753F80", VA = "0x186755380", Slot = "7")]
	[AsyncStateMachine(typeof(IKAONBKDNCH))]
	protected override Task NCEOEIDLMPF(GHPEMABLJJA ABCGAGONEBP, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
internal abstract class KHGHGJFACJN : PBAGONGALMM
{
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private sealed class JGBFLANOKGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public KHGHGJFACJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public OHOCGHNOABF playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public JGBFLANOKGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x6753220", Offset = "0x6751E20", VA = "0x186753220")]
		internal Task PPCMHPNNAIJ(DBCLHGHLEMD<string>.OGCCDEKKEPE postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x6753190", Offset = "0x6751D90", VA = "0x186753190")]
		internal object PBLBGMPPGFF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private struct LDFICJFENAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public KHGHGJFACJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public GHPEMABLJJA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private JGBFLANOKGM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x67560D0", Offset = "0x6754CD0", VA = "0x1867560D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x6756890", Offset = "0x6755490", VA = "0x186756890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private struct OANAABPCPDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public OHOCGHNOABF playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public KHGHGJFACJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x6759BD0", Offset = "0x67587D0", VA = "0x186759BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x675A160", Offset = "0x6758D60", VA = "0x18675A160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x6755850", Offset = "0x6754450", VA = "0x186755850")]
	public KHGHGJFACJN(Guid BJNGDHCNCJP, OEENMHGGAHN KLNOEOGFLGJ, IOAFANGBINH AKBNCMIKDJH, string GFCFPBLDNOF, GAHKMCKFJJJ ACDBBCINPON, bool AKNJKPMNNHI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x6755710", Offset = "0x6754310", VA = "0x186755710", Slot = "7")]
	[AsyncStateMachine(typeof(LDFICJFENAE))]
	protected override Task NCEOEIDLMPF(GHPEMABLJJA ABCGAGONEBP, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task LHOBHJDNFFK(GHPEMABLJJA ABCGAGONEBP, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN);

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x67555D0", Offset = "0x67541D0", VA = "0x1867555D0")]
	[AsyncStateMachine(typeof(OANAABPCPDP))]
	private Task NBEFFAFFAEC(IDisposable LIJGMDIFKNK, OHOCGHNOABF DDECJIKOOEE, DBCLHGHLEMD<string>.OGCCDEKKEPE KAMOOCNEONO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal class BGGFKGKBEGP : PBAGONGALMM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private struct OOPDEEEJAPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public BGGFKGKBEGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public GHPEMABLJJA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private TaskAwaiter<NJFIHEFGFDH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x675B240", Offset = "0x6759E40", VA = "0x18675B240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x675B7B0", Offset = "0x675A3B0", VA = "0x18675B7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400039E")]
	private readonly NBPGIDCICPL GKFJBPLKJAE;

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x6748010", Offset = "0x6746C10", VA = "0x186748010")]
	public BGGFKGKBEGP(Guid BJNGDHCNCJP, OEENMHGGAHN KLNOEOGFLGJ, IOAFANGBINH AKBNCMIKDJH, NBPGIDCICPL GKFJBPLKJAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x6747E10", Offset = "0x6746A10", VA = "0x186747E10", Slot = "6")]
	protected override string CJKOAHPOFDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x6747EF0", Offset = "0x6746AF0", VA = "0x186747EF0", Slot = "7")]
	[AsyncStateMachine(typeof(OOPDEEEJAPH))]
	protected override Task NCEOEIDLMPF(GHPEMABLJJA ABCGAGONEBP, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal abstract class PBAGONGALMM : AMNFJMOMPJL
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	public delegate Task FNKCEOIDNLL(DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN);

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class MMDEJGHAKKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public PBAGONGALMM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public MMDEJGHAKKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x67582E0", Offset = "0x6756EE0", VA = "0x1867582E0")]
		internal Task NHJOAGGGLCF(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private sealed class EAEDJCEPHPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public MMDEJGHAKKM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public EAEDJCEPHPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x674C710", Offset = "0x674B310", VA = "0x18674C710")]
		internal object IJKKOOJHIPD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x674C650", Offset = "0x674B250", VA = "0x18674C650")]
		internal object FEIMIAJKMAK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct DEGONJOCGPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public PBAGONGALMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public Func<PBAGONGALMM, DBCLHGHLEMD<string>.OGCCDEKKEPE, GHPEMABLJJA> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private MMDEJGHAKKM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private GHPEMABLJJA <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private TaskAwaiter<GAGOKAHMDNO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x674AF70", Offset = "0x6749B70", VA = "0x18674AF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x674C170", Offset = "0x674AD70", VA = "0x18674C170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct ODNEAMKEEHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x675A1C0", Offset = "0x6758DC0", VA = "0x18675A1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x675AC40", Offset = "0x6759840", VA = "0x18675AC40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct NICKEEFHGJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public PBAGONGALMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x67594A0", Offset = "0x67580A0", VA = "0x1867594A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x6759800", Offset = "0x6758400", VA = "0x186759800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public readonly Guid FCHEOIGLPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public readonly ByteString CFKICJEGGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public readonly IOAFANGBINH HHALDHLCDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	protected readonly string POMKEECDAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	private readonly OEENMHGGAHN KLNOEOGFLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	private readonly bool AKNJKPMNNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	private readonly Queue<FNKCEOIDNLL> BJEOFDDIJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private readonly NDDFDGFOGCA GCLDHGPLCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private readonly GAHKMCKFJJJ ACDBBCINPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	private bool DKDENPFIDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public KGFEPDLLDBL NHNGMEOPNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public KGFEPDLLDBL HGHJEECEDGM;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public OEENMHGGAHN LJLGNBJPEBP
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B70", Offset = "0x7B1770", VA = "0x1807B2B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public NCPOJFNGNHJ KOIOJGFJDFD
	{
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x675BEE0", Offset = "0x675AAE0", VA = "0x18675BEE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public GJAJGPAHGBO FADJPPPEIIH
	{
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x675C240", Offset = "0x675AE40", VA = "0x18675C240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public EELKBCOPMKF GFOFKJKPJCO
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x675B920", Offset = "0x675A520", VA = "0x18675B920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event FPDJLJEPFPL FLJFAGEPIMF
	{
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x675C1A0", Offset = "0x675ADA0", VA = "0x18675C1A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x675BEA0", Offset = "0x675AAA0", VA = "0x18675BEA0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x675C290", Offset = "0x675AE90", VA = "0x18675C290")]
	protected PBAGONGALMM(Guid BJNGDHCNCJP, OEENMHGGAHN KLNOEOGFLGJ, IOAFANGBINH AKBNCMIKDJH, string GFCFPBLDNOF, GAHKMCKFJJJ ACDBBCINPON, bool AKNJKPMNNHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x675BAD0", Offset = "0x675A6D0", VA = "0x18675BAD0", Slot = "6")]
	protected virtual string CJKOAHPOFDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x675BF30", Offset = "0x675AB30", VA = "0x18675BF30")]
	public void ILNGHJBNMMD(FNKCEOIDNLL FEHDNOGINLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x675BEC0", Offset = "0x675AAC0", VA = "0x18675BEC0")]
	protected void HMGLEDGLCDD(float HLHHCNMEOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x675BD50", Offset = "0x675A950", VA = "0x18675BD50")]
	[AsyncStateMachine(typeof(DEGONJOCGPP))]
	public Task EDEDADACBKL(CancellationToken EJGJLLMBDIN, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, [Optional] Func<PBAGONGALMM, DBCLHGHLEMD<string>.OGCCDEKKEPE, GHPEMABLJJA> DNEGCJBPGJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x675B9A0", Offset = "0x675A5A0", VA = "0x18675B9A0")]
	[AsyncStateMachine(typeof(ODNEAMKEEHN))]
	private static Task CEOGLEPOLDC(Func<CancellationToken, Task> NNLMMCFPHME, Func<CancellationToken, Task> HJNKDLIODJB, CancellationToken NFEFCAGIEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x675BB10", Offset = "0x675A710", VA = "0x18675BB10")]
	private void DIBNLHBFBFC(bool DHFBKAPIONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x675BF90", Offset = "0x675AB90", VA = "0x18675BF90")]
	private void JCIDEMPBILC(GHPEMABLJJA ABCGAGONEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task NCEOEIDLMPF(GHPEMABLJJA ABCGAGONEBP, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x675C080", Offset = "0x675AC80", VA = "0x18675C080")]
	[AsyncStateMachine(typeof(NICKEEFHGJH))]
	private Task KCBOKFLDKCI(DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x675C1C0", Offset = "0x675ADC0", VA = "0x18675C1C0")]
	public GAGOKAHMDNO PCLOLAGIGMC(MNCICDEGCNK EDDMAMLGFAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x675BC60", Offset = "0x675A860", VA = "0x18675BC60")]
	[CompilerGenerated]
	private Task DMJGOIFDHBL(CancellationToken JIGADAOLAJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal sealed class ONJHJHENBHB : KHGHGJFACJN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct EIFOCLOOMBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public ONJHJHENBHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public GHPEMABLJJA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private PBDIFHMPODG <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private CEELIFJHAPK <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x674C7D0", Offset = "0x674B3D0", VA = "0x18674C7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x674CF40", Offset = "0x674BB40", VA = "0x18674CF40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private readonly CGNOFECNPIB NPGPEKFCPCF;

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x675B190", Offset = "0x6759D90", VA = "0x18675B190")]
	public ONJHJHENBHB(Guid BJNGDHCNCJP, OEENMHGGAHN KLNOEOGFLGJ, CGNOFECNPIB NPGPEKFCPCF, IOAFANGBINH AKBNCMIKDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x675B040", Offset = "0x6759C40", VA = "0x18675B040", Slot = "8")]
	[AsyncStateMachine(typeof(EIFOCLOOMBM))]
	protected override Task LHOBHJDNFFK(GHPEMABLJJA ABCGAGONEBP, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
internal class JDEFODDKDGM : PBAGONGALMM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct ILHNPDHACEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public JDEFODDKDGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public GHPEMABLJJA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private TaskAwaiter<NJFIHEFGFDH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x6752830", Offset = "0x6751430", VA = "0x186752830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x6752BE0", Offset = "0x67517E0", VA = "0x186752BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	private readonly string KNAABMGLEBB;

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x67530E0", Offset = "0x6751CE0", VA = "0x1867530E0")]
	public JDEFODDKDGM(Guid BJNGDHCNCJP, OEENMHGGAHN KLNOEOGFLGJ, IOAFANGBINH AKBNCMIKDJH, string KNAABMGLEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x6752FD0", Offset = "0x6751BD0", VA = "0x186752FD0", Slot = "7")]
	[AsyncStateMachine(typeof(ILHNPDHACEN))]
	protected override Task NCEOEIDLMPF(GHPEMABLJJA ABCGAGONEBP, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
internal class FJHAPHIGKKB : KHGHGJFACJN
{
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class FHDAACJDGCP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000114")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public AsyncTaskMethodBuilder<GAGOKAHMDNO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public FHDAACJDGCP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			private TaskAwaiter<NJFIHEFGFDH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			private TaskAwaiter<GAGOKAHMDNO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0x675FBD0", Offset = "0x675E7D0", VA = "0x18675FBD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0x6760090", Offset = "0x675EC90", VA = "0x186760090", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public FJHAPHIGKKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public APEGMDBPPMF serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public JBEHIOFFAIM roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public MNMLLHFKGBF uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public CGLPPOIENKE roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public FHDAACJDGCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x674E450", Offset = "0x674D050", VA = "0x18674E450")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<GAGOKAHMDNO> CNLNBBHJEIE(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private struct HKADGPJKHFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public FJHAPHIGKKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public GHPEMABLJJA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private FHDAACJDGCP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private PBDIFHMPODG <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private CEELIFJHAPK <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private TaskAwaiter<GAGOKAHMDNO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x67509E0", Offset = "0x674F5E0", VA = "0x1867509E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x6751880", Offset = "0x6750480", VA = "0x186751880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	private static readonly HEENJBKIIAO BNEDOBBKLOJ;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private static readonly HEENJBKIIAO LGBIBAMCPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	private readonly int PEBMEEJPPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	[CanBeNull]
	private readonly KCLHKFMCGHF KEMGBKKIEOD;

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x674EA30", Offset = "0x674D630", VA = "0x18674EA30")]
	public FJHAPHIGKKB(Guid BJNGDHCNCJP, OEENMHGGAHN KLNOEOGFLGJ, int PEBMEEJPPHO, KCLHKFMCGHF KEMGBKKIEOD, IOAFANGBINH AKBNCMIKDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x674E670", Offset = "0x674D270", VA = "0x18674E670", Slot = "8")]
	[AsyncStateMachine(typeof(HKADGPJKHFI))]
	protected override Task LHOBHJDNFFK(GHPEMABLJJA ABCGAGONEBP, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x674E570", Offset = "0x674D170", VA = "0x18674E570")]
	private void KLHPOJODMPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x674E7B0", Offset = "0x674D3B0", VA = "0x18674E7B0")]
	private void MGDBIGNDHCE(DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, PBDIFHMPODG NJNINILBPDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
internal abstract class KALBNOPHLNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public readonly PBAGONGALMM NAPHNIIEAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public readonly GHPEMABLJJA MDMKIAHJIGH;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public NCPOJFNGNHJ KOIOJGFJDFD
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x67540E0", Offset = "0x6752CE0", VA = "0x1867540E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public EELKBCOPMKF GFOFKJKPJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x6754050", Offset = "0x6752C50", VA = "0x186754050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x6754130", Offset = "0x6752D30", VA = "0x186754130")]
	protected KALBNOPHLNO(GHPEMABLJJA ABCGAGONEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x6754030", Offset = "0x6752C30", VA = "0x186754030")]
	protected void AGKNLPHAFKB(string ABNAHAKKPMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal struct HAILNMELGFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public Dictionary<Guid, List<EEJLJDHCNLJ>> DFHOELABKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public Dictionary<Guid, List<EEJLJDHCNLJ>> KPIIFLAOGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public Dictionary<Guid, List<EEJLJDHCNLJ>> MGPAOKJKCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public List<Guid> CAFFONNJIPI;

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x674F0C0", Offset = "0x674DCC0", VA = "0x18674F0C0")]
	public static HAILNMELGFP CPPPHMALPOD(NCPOJFNGNHJ FOHLLAJCPJF, KGFEPDLLDBL PIKBIOCBCKJ, GPMIMHCABEE GOAOCOIGDBP)
	{
		return default(HAILNMELGFP);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000119")]
internal struct DFNIKIMIMLG
{
	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30")]
	public static DFNIKIMIMLG JOBBHNKGDPO()
	{
		return default(DFNIKIMIMLG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal struct PGGGFDOJOMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public readonly EOHIAKIOJAN GMBOAKOAEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public readonly GOCLPCOPMCO CLIOLGILJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public readonly string FJDNDBMAKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public readonly PBNLADHBLCA DNCEPNILLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public readonly PBNLADHBLCA BDEPKDCJGAK;

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x675CE70", Offset = "0x675BA70", VA = "0x18675CE70")]
	public PGGGFDOJOMF(EOHIAKIOJAN GMBOAKOAEEF, GOCLPCOPMCO CLIOLGILJPD, string FJDNDBMAKEF, PBNLADHBLCA DNCEPNILLJE, PBNLADHBLCA BDEPKDCJGAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal struct GOEMBGPMOOI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	private readonly GHPEMABLJJA ABCGAGONEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private readonly Guid CLLNNDFKDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private bool DHFBKAPIONA;

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x674EF70", Offset = "0x674DB70", VA = "0x18674EF70")]
	public static GOEMBGPMOOI FPJPOOPOEOH(GHPEMABLJJA ABCGAGONEBP)
	{
		return default(GOEMBGPMOOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x833370", Offset = "0x831F70", VA = "0x180833370")]
	public void AJBIGPCHHHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x674EF10", Offset = "0x674DB10", VA = "0x18674EF10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x674F070", Offset = "0x674DC70", VA = "0x18674F070")]
	private GOEMBGPMOOI(GHPEMABLJJA ABCGAGONEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x674EF10", Offset = "0x674DB10", VA = "0x18674EF10")]
	private void FCBMODBOHID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x674EFD0", Offset = "0x674DBD0", VA = "0x18674EFD0")]
	private Func<Guid, bool> JMHCGDKGOHL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal class CEELIFJHAPK : KALBNOPHLNO, AMNFJMOMPJL
{
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	public delegate Task<KGFEPDLLDBL> AJNEBPCIGKC(GPMIMHCABEE KOMCCCIEHEA, JIIAOAAIJLH ODLOIMCAGLF, NDDFDGFOGCA LACIDJBKBIF, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private struct PDNMFNMJFIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public CEELIFJHAPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public CGNOFECNPIB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private GOEMBGPMOOI <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private TaskAwaiter<GAGOKAHMDNO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x675C3F0", Offset = "0x675AFF0", VA = "0x18675C3F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x675CB60", Offset = "0x675B760", VA = "0x18675CB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private struct DPPHBIMHBNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public AsyncTaskMethodBuilder<GAGOKAHMDNO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public CEELIFJHAPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public CGNOFECNPIB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private TaskAwaiter<GAGOKAHMDNO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x674C1D0", Offset = "0x674ADD0", VA = "0x18674C1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x674C5E0", Offset = "0x674B1E0", VA = "0x18674C5E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct BHEHEBHPFBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public CEELIFJHAPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public CGNOFECNPIB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x67480B0", Offset = "0x6746CB0", VA = "0x1867480B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x6748540", Offset = "0x6747140", VA = "0x186748540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private sealed class OKAONJHKOGB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000122")]
		private struct <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public AsyncTaskMethodBuilder<PGGGFDOJOMF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public OKAONJHKOGB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			private PGGGFDOJOMF <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			private TaskAwaiter<KGFEPDLLDBL> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			private TaskAwaiter<PGGGFDOJOMF> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x675E290", Offset = "0x675CE90", VA = "0x18675E290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x675EA20", Offset = "0x675D620", VA = "0x18675EA20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000123")]
		private struct <<LoadRoomLocal>b__4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			public AsyncTaskMethodBuilder<GPMIMHCABEE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			public OKAONJHKOGB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			private GPMIMHCABEE <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			private TaskAwaiter<KGFEPDLLDBL> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			private TaskAwaiter<GPMIMHCABEE> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004FC")]
			[Cpp2IlInjected.Address(RVA = "0x675EA90", Offset = "0x675D690", VA = "0x18675EA90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FD")]
			[Cpp2IlInjected.Address(RVA = "0x675F0E0", Offset = "0x675DCE0", VA = "0x18675F0E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000124")]
		private struct <<LoadRoomLocal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public OKAONJHKOGB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			private TaskAwaiter<KGFEPDLLDBL> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			private JIIAOAAIJLH <timedYielder>5__2;

			[Cpp2IlInjected.Token(Token = "0x60004FE")]
			[Cpp2IlInjected.Address(RVA = "0x675CEF0", Offset = "0x675BAF0", VA = "0x18675CEF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FF")]
			[Cpp2IlInjected.Address(RVA = "0x675E230", Offset = "0x675CE30", VA = "0x18675E230", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public CEELIFJHAPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public CGNOFECNPIB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public NDDFDGFOGCA preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public NDDFDGFOGCA downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public PGGGFDOJOMF data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public NDDFDGFOGCA postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public GPMIMHCABEE phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public MIEEKFFIHAB.FDNHOCOAACA <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public OKAONJHKOGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x675AEC0", Offset = "0x6759AC0", VA = "0x18675AEC0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<PGGGFDOJOMF> LCKLJDGNBJN(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x675ADA0", Offset = "0x67599A0", VA = "0x18675ADA0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<GPMIMHCABEE> EIFPMDCELGF(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x675B000", Offset = "0x6759C00", VA = "0x18675B000")]
		internal void MHLJHGDDPME(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x675ACA0", Offset = "0x67598A0", VA = "0x18675ACA0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task ACBMGGOLBPB(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct FBAFMJGMKJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public CEELIFJHAPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public CGNOFECNPIB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private OKAONJHKOGB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private TaskAwaiter<PGGGFDOJOMF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private TaskAwaiter<GPMIMHCABEE> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x674CFA0", Offset = "0x674BBA0", VA = "0x18674CFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x674DBB0", Offset = "0x674C7B0", VA = "0x18674DBB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct BFHBMFOPLDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public CEELIFJHAPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x6747670", Offset = "0x6746270", VA = "0x186747670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x6747DB0", Offset = "0x67469B0", VA = "0x186747DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct BJFIGGDDLPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public CEELIFJHAPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public GPMIMHCABEE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public NDDFDGFOGCA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private TaskAwaiter<KGFEPDLLDBL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x67485A0", Offset = "0x67471A0", VA = "0x1867485A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x6748F00", Offset = "0x6747B00", VA = "0x186748F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct KDBIGCMKIGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public AsyncTaskMethodBuilder<KGFEPDLLDBL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public CEELIFJHAPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public GPMIMHCABEE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public NDDFDGFOGCA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private TaskAwaiter<KGFEPDLLDBL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x6754190", Offset = "0x6752D90", VA = "0x186754190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x6755310", Offset = "0x6753F10", VA = "0x186755310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct LKFGMMJONDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public AsyncTaskMethodBuilder<KGFEPDLLDBL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public CEELIFJHAPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public GPMIMHCABEE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public NDDFDGFOGCA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public JIIAOAAIJLH timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private TaskAwaiter<KGFEPDLLDBL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x6756EB0", Offset = "0x6755AB0", VA = "0x186756EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x6758270", Offset = "0x6756E70", VA = "0x186758270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct HIJHICLIDGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public AsyncTaskMethodBuilder<KGFEPDLLDBL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public CEELIFJHAPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public KGFEPDLLDBL operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public NDDFDGFOGCA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public GPMIMHCABEE deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		private TaskAwaiter<KGFEPDLLDBL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x6750390", Offset = "0x674EF90", VA = "0x186750390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x6750620", Offset = "0x674F220", VA = "0x186750620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private sealed class KKODDLMIMOA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012D")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000495")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public AsyncTaskMethodBuilder<KGFEPDLLDBL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			public KKODDLMIMOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			private LPACJKPPDGK <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			private TaskAwaiter<KGFEPDLLDBL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x675F150", Offset = "0x675DD50", VA = "0x18675F150", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0x675F770", Offset = "0x675E370", VA = "0x18675F770", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public CEELIFJHAPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public GPMIMHCABEE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public NDDFDGFOGCA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public AJNEBPCIGKC masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public JIIAOAAIJLH timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public KGFEPDLLDBL originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public KKODDLMIMOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x67558A0", Offset = "0x67544A0", VA = "0x1867558A0")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<KGFEPDLLDBL> PBPFOMNKPAH(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct IEGGCKACGMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public AsyncTaskMethodBuilder<KGFEPDLLDBL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public CEELIFJHAPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public GPMIMHCABEE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public NDDFDGFOGCA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public AJNEBPCIGKC masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public JIIAOAAIJLH timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private LPACJKPPDGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private TaskAwaiter<KGFEPDLLDBL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x67518E0", Offset = "0x67504E0", VA = "0x1867518E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x6751DE0", Offset = "0x67509E0", VA = "0x186751DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct MNHMCMAGFGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public CEELIFJHAPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public GPMIMHCABEE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public NDDFDGFOGCA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private KGFEPDLLDBL <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private IEnumerator<KGFEPDLLDBL> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private TaskAwaiter<KGFEPDLLDBL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x6758410", Offset = "0x6757010", VA = "0x186758410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x6758940", Offset = "0x6757540", VA = "0x186758940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct NJJGNCMKDFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public CEELIFJHAPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public GPMIMHCABEE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x6759860", Offset = "0x6758460", VA = "0x186759860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x6759B70", Offset = "0x6758770", VA = "0x186759B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private struct PFDIAPLHKKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public CEELIFJHAPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public GPMIMHCABEE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x675CBC0", Offset = "0x675B7C0", VA = "0x18675CBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x675CE10", Offset = "0x675BA10", VA = "0x18675CE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private readonly CAPELAHPHJP PIHKDLDEMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private readonly CAPELAHPHJP JADBHNCNBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private readonly FKNHFKFGPNP GDECNFBKPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	private readonly CICAAEIEHMD EGPDDKPOBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private readonly JBPEGNMIILE LNBNLCBPGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private readonly EMAPDACIFNI JENEKHNPABB;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private OEENMHGGAHN LJLGNBJPEBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x6749ED0", Offset = "0x6748AD0", VA = "0x186749ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event FPDJLJEPFPL FLJFAGEPIMF
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x674A8C0", Offset = "0x67494C0", VA = "0x18674A8C0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x6749E90", Offset = "0x6748A90", VA = "0x186749E90", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x674AB80", Offset = "0x6749780", VA = "0x18674AB80")]
	public CEELIFJHAPK(GHPEMABLJJA ABCGAGONEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x674A610", Offset = "0x6749210", VA = "0x18674A610")]
	[AsyncStateMachine(typeof(PDNMFNMJFIH))]
	public Task NCJONOLPLAG(CGNOFECNPIB MLHMNLDOBPP, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x67499E0", Offset = "0x67485E0", VA = "0x1867499E0")]
	[AsyncStateMachine(typeof(DPPHBIMHBNM))]
	private Task<GAGOKAHMDNO> EGPNFKCHNKI(CGNOFECNPIB MLHMNLDOBPP, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x674A250", Offset = "0x6748E50", VA = "0x18674A250")]
	[AsyncStateMachine(typeof(BHEHEBHPFBE))]
	private Task KDLLCGNOJKH(CGNOFECNPIB MLHMNLDOBPP, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x67498A0", Offset = "0x67484A0", VA = "0x1867498A0")]
	[AsyncStateMachine(typeof(FBAFMJGMKJH))]
	private Task EDJBNEMHLLB(CGNOFECNPIB MLHMNLDOBPP, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken PCCFJIAANHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x674A500", Offset = "0x6749100", VA = "0x18674A500")]
	[AsyncStateMachine(typeof(BFHBMFOPLDM))]
	private Task MOFJLKKHDBB(DBCLHGHLEMD<string>.OGCCDEKKEPE KAMOOCNEONO, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x6749460", Offset = "0x6748060", VA = "0x186749460")]
	[AsyncStateMachine(typeof(BJFIGGDDLPA))]
	private Task BEEANIMKOOM(GPMIMHCABEE KOMCCCIEHEA, NDDFDGFOGCA LACIDJBKBIF, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x6749B40", Offset = "0x6748740", VA = "0x186749B40")]
	[AsyncStateMachine(typeof(KDBIGCMKIGF))]
	private Task<KGFEPDLLDBL> FHFCFIHHIDP(GPMIMHCABEE KOMCCCIEHEA, JIIAOAAIJLH BCKADBOPJBM, NDDFDGFOGCA LACIDJBKBIF, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x674A920", Offset = "0x6749520", VA = "0x18674A920")]
	[AsyncStateMachine(typeof(LKFGMMJONDD))]
	private Task<KGFEPDLLDBL> PIOMAGHOONM(GPMIMHCABEE KOMCCCIEHEA, JIIAOAAIJLH BCKADBOPJBM, NDDFDGFOGCA LACIDJBKBIF, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x674A0D0", Offset = "0x6748CD0", VA = "0x18674A0D0")]
	[AsyncStateMachine(typeof(HIJHICLIDGJ))]
	private Task<KGFEPDLLDBL> JANAJKJIMIL(KGFEPDLLDBL PIKBIOCBCKJ, GPMIMHCABEE GOAOCOIGDBP, NDDFDGFOGCA LACIDJBKBIF, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN, bool FDOAEHDOKHC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x6749280", Offset = "0x6747E80", VA = "0x186749280")]
	private bool AMIOEDLDKLB(GPMIMHCABEE KAICNOLHIJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x67495B0", Offset = "0x67481B0", VA = "0x1867495B0")]
	[AsyncStateMachine(typeof(IEGGCKACGMA))]
	protected Task<KGFEPDLLDBL> BGFMAPJGJIM(GPMIMHCABEE KOMCCCIEHEA, JIIAOAAIJLH BCKADBOPJBM, NDDFDGFOGCA LACIDJBKBIF, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN, AJNEBPCIGKC KCMHCJKNBAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x6749CF0", Offset = "0x67488F0", VA = "0x186749CF0")]
	[AsyncStateMachine(typeof(MNHMCMAGFGD))]
	private Task FOHOCGIHKFE(GPMIMHCABEE KOMCCCIEHEA, NDDFDGFOGCA LACIDJBKBIF, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x6749E40", Offset = "0x6748A40", VA = "0x186749E40")]
	private void GEEACOHDCNM(KGFEPDLLDBL AKMFOOFGDCG, NDDFDGFOGCA LACIDJBKBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x6749F00", Offset = "0x6748B00", VA = "0x186749F00")]
	private void HMOHKGFIIOE(KGFEPDLLDBL IBCADNANCOM, [Out] KGFEPDLLDBL ANMHFOBOFDM, [Out] KGFEPDLLDBL MHODCFIOOJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x6749F40", Offset = "0x6748B40", VA = "0x186749F40")]
	private Task<PGGGFDOJOMF> IDDHBJJLOKL(CGNOFECNPIB MLHMNLDOBPP, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x674A8E0", Offset = "0x67494E0", VA = "0x18674A8E0")]
	private Task<GPMIMHCABEE> OKHCLJAACHG(PGGGFDOJOMF KOMCCCIEHEA, MIEEKFFIHAB.FDNHOCOAACA JOGJGGAMIAA, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x674A3B0", Offset = "0x6748FB0", VA = "0x18674A3B0")]
	[AsyncStateMachine(typeof(NJJGNCMKDFA))]
	private Task MIHDIMABJEJ(GPMIMHCABEE KOMCCCIEHEA, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN, bool MJLKBLGEOCA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x6749370", Offset = "0x6747F70", VA = "0x186749370")]
	[AsyncStateMachine(typeof(PFDIAPLHKKG))]
	private Task BDPDHJPHMOC(GPMIMHCABEE KOMCCCIEHEA, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x674A760", Offset = "0x6749360", VA = "0x18674A760")]
	private Task NGEPNIDCNHJ(GPMIMHCABEE KOMCCCIEHEA, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x674A8A0", Offset = "0x67494A0", VA = "0x18674A8A0")]
	private Task NKFALFHDCJN(GPMIMHCABEE KOMCCCIEHEA, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x674A390", Offset = "0x6748F90", VA = "0x18674A390")]
	private Task LLMFOGGFKBN(GPMIMHCABEE KOMCCCIEHEA, JIIAOAAIJLH BCKADBOPJBM, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x6749F80", Offset = "0x6748B80", VA = "0x186749F80")]
	private Task IGKNAHPOBDL(GPMIMHCABEE KOMCCCIEHEA, JIIAOAAIJLH BCKADBOPJBM, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x674AAA0", Offset = "0x67496A0", VA = "0x18674AAA0")]
	private static Task PMKIBAKLDGK(CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x6749880", Offset = "0x6748480", VA = "0x186749880")]
	private Task EDBBHOMKMEC(GPMIMHCABEE KOMCCCIEHEA, JIIAOAAIJLH BCKADBOPJBM, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x6749740", Offset = "0x6748340", VA = "0x186749740")]
	private Task DBLKIEFCPMK(GPMIMHCABEE KOMCCCIEHEA, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x6749CA0", Offset = "0x67488A0", VA = "0x186749CA0")]
	private void FJKJAJAAKDA(CGNOFECNPIB MLHMNLDOBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x6749EB0", Offset = "0x6748AB0", VA = "0x186749EB0")]
	public void HIFDDEFIGBI(long NGMKLALOJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200")]
	private static void NGHCHHMJLJC(EOHIAKIOJAN GMBOAKOAEEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal struct BOGBHEBPKFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	private OEENMHGGAHN KLNOEOGFLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	private GPMIMHCABEE KOMCCCIEHEA;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private NCPOJFNGNHJ KOIOJGFJDFD
	{
		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x6749230", Offset = "0x6747E30", VA = "0x186749230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x6748F60", Offset = "0x6747B60", VA = "0x186748F60")]
	public static Task EDEDADACBKL(OEENMHGGAHN KLNOEOGFLGJ, GPMIMHCABEE KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x6749040", Offset = "0x6747C40", VA = "0x186749040")]
	private void EDEDADACBKL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal struct NLGBLKMBDMG
{
	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x674AAA0", Offset = "0x67496A0", VA = "0x18674AAA0")]
	public static Task EDEDADACBKL(CancellationToken EJGJLLMBDIN)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000134")]
internal struct NEILCJGJAML
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct JKHOCDIAMGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public GHPEMABLJJA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public GPMIMHCABEE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private LPACJKPPDGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x6753920", Offset = "0x6752520", VA = "0x186753920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x6753E40", Offset = "0x6752A40", VA = "0x186753E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x6759360", Offset = "0x6757F60", VA = "0x186759360")]
	[AsyncStateMachine(typeof(JKHOCDIAMGP))]
	public static Task EDEDADACBKL(GHPEMABLJJA ABCGAGONEBP, GPMIMHCABEE KOMCCCIEHEA, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal struct HJOKBJFGLEJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct HCCIOPBKCOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public GHPEMABLJJA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public GPMIMHCABEE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public JIIAOAAIJLH timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private KGFEPDLLDBL <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private OEENMHGGAHN <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private NCPOJFNGNHJ <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private LPACJKPPDGK <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private List<(PersistenceView, LJJGPBMCLBA)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private LJJGPBMCLBA <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x674F6D0", Offset = "0x674E2D0", VA = "0x18674F6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x6750330", Offset = "0x674EF30", VA = "0x186750330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x6750890", Offset = "0x674F490", VA = "0x186750890")]
	[AsyncStateMachine(typeof(HCCIOPBKCOD))]
	public static Task EDEDADACBKL(GHPEMABLJJA ABCGAGONEBP, GPMIMHCABEE KOMCCCIEHEA, JIIAOAAIJLH BCKADBOPJBM, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x6750690", Offset = "0x674F290", VA = "0x186750690")]
	private static void DBJPNMGCPFP(PersistenceView BPGBGHDKKFL, LJJGPBMCLBA AIAFICPGPCD, GPMIMHCABEE KOMCCCIEHEA, KGFEPDLLDBL PIKBIOCBCKJ, bool CFLEMFJDOOP)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct OPILJGCLINF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private struct LIHCNIGLFBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public OEENMHGGAHN roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public GPMIMHCABEE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x6756A10", Offset = "0x6755610", VA = "0x186756A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x6756E50", Offset = "0x6755A50", VA = "0x186756E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x675B810", Offset = "0x675A410", VA = "0x18675B810")]
	[AsyncStateMachine(typeof(LIHCNIGLFBH))]
	public static Task EDEDADACBKL(OEENMHGGAHN KLNOEOGFLGJ, GPMIMHCABEE KOMCCCIEHEA, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct AAJDDNAOOKD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct FNACCJIIKNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public OEENMHGGAHN roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public GPMIMHCABEE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public GHPEMABLJJA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x674EAE0", Offset = "0x674D6E0", VA = "0x18674EAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x674ECF0", Offset = "0x674D8F0", VA = "0x18674ECF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private sealed class LIFIEAOBNKE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200013E")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004F1")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004F2")]
			public DBCLHGHLEMD<string>.OGCCDEKKEPE timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F3")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004F4")]
			public LIFIEAOBNKE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004F5")]
			private DBCLHGHLEMD<string>.OGCCDEKKEPE <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004F6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600053A")]
			[Cpp2IlInjected.Address(RVA = "0x675F7E0", Offset = "0x675E3E0", VA = "0x18675F7E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053B")]
			[Cpp2IlInjected.Address(RVA = "0x675FB70", Offset = "0x675E770", VA = "0x18675FB70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public LIFIEAOBNKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x67568F0", Offset = "0x67554F0", VA = "0x1867568F0")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task JKNIEOJDCJC(DBCLHGHLEMD<string>.OGCCDEKKEPE timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct NCLNJKJEADP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public AAJDDNAOOKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private LPACJKPPDGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		private TaskAwaiter<GAGOKAHMDNO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x67589A0", Offset = "0x67575A0", VA = "0x1867589A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x6759300", Offset = "0x6757F00", VA = "0x186759300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private sealed class KACBLFIDJEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public LPGOBKPNDLH version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public KACBLFIDJEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x6753F50", Offset = "0x6752B50", VA = "0x186753F50")]
		internal object PJMMCJHEIKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x6753EA0", Offset = "0x6752AA0", VA = "0x186753EA0")]
		internal object DBDLFEJGHEG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	private OEENMHGGAHN KLNOEOGFLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	private GPMIMHCABEE KOMCCCIEHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private GHPEMABLJJA ABCGAGONEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private bool MJLKBLGEOCA;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	private static readonly ByteString KDPBJEFMIAO;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private NCPOJFNGNHJ KOIOJGFJDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x6746970", Offset = "0x6745570", VA = "0x186746970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private EELKBCOPMKF GFOFKJKPJCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x6745F60", Offset = "0x6744B60", VA = "0x186745F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x6746140", Offset = "0x6744D40", VA = "0x186746140")]
	[AsyncStateMachine(typeof(FNACCJIIKNA))]
	public static Task EDEDADACBKL(OEENMHGGAHN KLNOEOGFLGJ, GPMIMHCABEE KOMCCCIEHEA, GHPEMABLJJA ABCGAGONEBP, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN, bool MJLKBLGEOCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x6746000", Offset = "0x6744C00", VA = "0x186746000")]
	[AsyncStateMachine(typeof(NCLNJKJEADP))]
	private Task EDEDADACBKL(DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x6746290", Offset = "0x6744E90", VA = "0x186746290")]
	private void FEFKPBLPFDF([NotNull] KAILJKAMMLK FGEOGAODJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x6746930", Offset = "0x6745530", VA = "0x186746930")]
	private bool HAGOGOFNPIE(LPGOBKPNDLH KAHEAPGLNDI, KAILJKAMMLK FGEOGAODJCF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
internal struct JJJFODNJFFO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct APKIHOFGGDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public AsyncTaskMethodBuilder<GPMIMHCABEE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public JJJFODNJFFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public MIEEKFFIHAB.FDNHOCOAACA downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private LPACJKPPDGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private TaskAwaiter<(DGKNLHNBBJB<PAJJLMJCCHC, PHFFNBEEJOM>, DGKNLHNBBJB<POBLOMHIDDD<KAILJKAMMLK>, PHFFNBEEJOM>, DGKNLHNBBJB<POBLOMHIDDD<MHLNEPCFHJN>, PHFFNBEEJOM>, DGKNLHNBBJB<POBLOMHIDDD<MHMDDPIMCBA>, PHFFNBEEJOM>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x6746B50", Offset = "0x6745750", VA = "0x186746B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x6747600", Offset = "0x6746200", VA = "0x186747600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct PBNGMOKEKBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<PAJJLMJCCHC, PHFFNBEEJOM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public JJJFODNJFFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public MIEEKFFIHAB.FDNHOCOAACA downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		private LPACJKPPDGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private TaskAwaiter<DGKNLHNBBJB<PAJJLMJCCHC, PHFFNBEEJOM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x6777F90", Offset = "0x6776B90", VA = "0x186777F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x67785A0", Offset = "0x67771A0", VA = "0x1867785A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	private MHBILPKPHOO<PBNLADHBLCA, MHLNEPCFHJN> PAEGOPMPJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	private MHBILPKPHOO<PBNLADHBLCA, KAILJKAMMLK> DJFECMFFCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	private MHBILPKPHOO<long, MHMDDPIMCBA> FGHCDIFDMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	private IKJFFMMBPPE GFPCHHKMNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private EOHIAKIOJAN GMBOAKOAEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	private GOCLPCOPMCO CLIOLGILJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private string FJDNDBMAKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private PBNLADHBLCA DNCEPNILLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private PBNLADHBLCA BDEPKDCJGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private long NGMKLALOJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	private DBCLHGHLEMD<string>.OGCCDEKKEPE KAMOOCNEONO;

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x67535B0", Offset = "0x67521B0", VA = "0x1867535B0")]
	public static Task<GPMIMHCABEE> LJGNGJHPONM(OEENMHGGAHN KLNOEOGFLGJ, [In] PGGGFDOJOMF KOMCCCIEHEA, MIEEKFFIHAB.FDNHOCOAACA JOGJGGAMIAA, DBCLHGHLEMD<string>.OGCCDEKKEPE KAMOOCNEONO, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x6753420", Offset = "0x6752020", VA = "0x186753420")]
	[AsyncStateMachine(typeof(APKIHOFGGDC))]
	private Task<GPMIMHCABEE> EDEDADACBKL(MIEEKFFIHAB.FDNHOCOAACA JOGJGGAMIAA, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x6753260", Offset = "0x6751E60", VA = "0x186753260")]
	[AsyncStateMachine(typeof(PBNGMOKEKBF))]
	private Task<DGKNLHNBBJB<PAJJLMJCCHC, PHFFNBEEJOM>> BELMFMAMFPC(string FJDNDBMAKEF, long NGMKLALOJDI, long? MGDJPIEDFNB, long? FLKBFMIKIPD, MIEEKFFIHAB.FDNHOCOAACA JOGJGGAMIAA, DBCLHGHLEMD<string>.OGCCDEKKEPE HPDCLKODBGP, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
internal struct IBGKAHAPEOC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct OKAPHMJPPAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public AsyncTaskMethodBuilder<PGGGFDOJOMF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public IBGKAHAPEOC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private TaskAwaiter<PGGGFDOJOMF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x6776860", Offset = "0x6775460", VA = "0x186776860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x6776C60", Offset = "0x6775860", VA = "0x186776C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct LJJDMJNNPJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public AsyncTaskMethodBuilder<PGGGFDOJOMF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public IBGKAHAPEOC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private TaskAwaiter<PGGGFDOJOMF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x6773090", Offset = "0x6771C90", VA = "0x186773090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x67734C0", Offset = "0x67720C0", VA = "0x1867734C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class MHGNGBEPINM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public MHGNGBEPINM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x14E0170", Offset = "0x14DED70", VA = "0x1814E0170")]
		internal bool GLGJGAJACBJ(GOCLPCOPMCO sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct DBNPMJIAHON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public AsyncTaskMethodBuilder<PGGGFDOJOMF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public PBNLADHBLCA superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public NCPOJFNGNHJ callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private MHGNGBEPINM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public HCEKDBKMJPN roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private EOHIAKIOJAN <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private GOCLPCOPMCO <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private PBNLADHBLCA <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private PBNLADHBLCA <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private TaskAwaiter<EOHIAKIOJAN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private TaskAwaiter<HFEHGMAKIHJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private TaskAwaiter<JPFIIAMMGLD> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x6767E60", Offset = "0x6766A60", VA = "0x186767E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x6768FA0", Offset = "0x6767BA0", VA = "0x186768FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private NCPOJFNGNHJ FOHLLAJCPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	private FKNHFKFGPNP GDECNFBKPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private HCEKDBKMJPN LEAHPKHFLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private DBCLHGHLEMD<string>.OGCCDEKKEPE KAMOOCNEONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private long MGDJPIEDFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private long FPCFGLFPIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private long GLPKLLPKLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	private string EOAALFBIDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	private PBNLADHBLCA KPOCKGCBFJC;

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x676E960", Offset = "0x676D560", VA = "0x18676E960")]
	public static Task<PGGGFDOJOMF> LJGNGJHPONM(OEENMHGGAHN KLNOEOGFLGJ, CGNOFECNPIB MLHMNLDOBPP, DBCLHGHLEMD<string>.OGCCDEKKEPE KAMOOCNEONO, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x676E4E0", Offset = "0x676D0E0", VA = "0x18676E4E0")]
	[AsyncStateMachine(typeof(OKAPHMJPPAN))]
	private Task<PGGGFDOJOMF> EDEDADACBKL(CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x676E660", Offset = "0x676D260", VA = "0x18676E660")]
	[AsyncStateMachine(typeof(LJJDMJNNPJO))]
	private Task<PGGGFDOJOMF> IDDHBJJLOKL(DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x676E7C0", Offset = "0x676D3C0", VA = "0x18676E7C0")]
	[AsyncStateMachine(typeof(DBNPMJIAHON))]
	private static Task<PGGGFDOJOMF> IDDHBJJLOKL(NCPOJFNGNHJ FOHLLAJCPJF, HCEKDBKMJPN LEAHPKHFLDJ, long MGDJPIEDFNB, long FPCFGLFPIMK, long GLPKLLPKLFE, string EOAALFBIDOK, PBNLADHBLCA KPOCKGCBFJC, CancellationToken EJGJLLMBDIN, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x676E630", Offset = "0x676D230", VA = "0x18676E630")]
	private void ENCGJGGGAJK(EOHIAKIOJAN GMBOAKOAEEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal struct FOHAMEACOCD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct BPHDJDCMIFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public FOHAMEACOCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x67644B0", Offset = "0x67630B0", VA = "0x1867644B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x6764A40", Offset = "0x6763640", VA = "0x186764A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	private NCPOJFNGNHJ FOHLLAJCPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	private GPMIMHCABEE KOMCCCIEHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	private DBCLHGHLEMD<string>.OGCCDEKKEPE KAMOOCNEONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	private float BLBDNCKDMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	private float IHKKMBLMFFE;

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x676BF50", Offset = "0x676AB50", VA = "0x18676BF50")]
	public static Task MHCMKHMLFOL(OEENMHGGAHN KLNOEOGFLGJ, GPMIMHCABEE KOMCCCIEHEA, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x676BC30", Offset = "0x676A830", VA = "0x18676BC30")]
	[AsyncStateMachine(typeof(BPHDJDCMIFO))]
	public Task EDEDADACBKL(CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x676BE10", Offset = "0x676AA10", VA = "0x18676BE10")]
	private static void HJDLHEOGHAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x676C0F0", Offset = "0x676ACF0", VA = "0x18676C0F0")]
	private void MNKNKJKFPKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x676BD50", Offset = "0x676A950", VA = "0x18676BD50")]
	private static float GLKICIFENMC(NCPOJFNGNHJ FOHLLAJCPJF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x676BC10", Offset = "0x676A810", VA = "0x18676BC10")]
	private static float BLHLKEDKNAF()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal struct CIOBLPLEAMM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct BFOMJCMBPCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public GHPEMABLJJA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public GPMIMHCABEE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private LPACJKPPDGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private PBAGONGALMM <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		private OEENMHGGAHN <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private DPLECPPIPOC.GDLKCBELBCB <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private TaskAwaiter<GAGOKAHMDNO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x6762470", Offset = "0x6761070", VA = "0x186762470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x6762E10", Offset = "0x6761A10", VA = "0x186762E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct PIEKAFKKCEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private LPACJKPPDGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x67786B0", Offset = "0x67772B0", VA = "0x1867786B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x67789A0", Offset = "0x67775A0", VA = "0x1867789A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x67671A0", Offset = "0x6765DA0", VA = "0x1867671A0")]
	[AsyncStateMachine(typeof(BFOMJCMBPCF))]
	public static Task EDEDADACBKL(GHPEMABLJJA ABCGAGONEBP, GPMIMHCABEE KOMCCCIEHEA, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x6767130", Offset = "0x6765D30", VA = "0x186767130")]
	private static Task<GAGOKAHMDNO> AKJLINOMKDE(GHPEMABLJJA ABCGAGONEBP, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x67672E0", Offset = "0x6765EE0", VA = "0x1867672E0")]
	[AsyncStateMachine(typeof(PIEKAFKKCEB))]
	private static Task FLOCJBNIDED()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
internal struct GODJLPDGNFL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct IKDJGHINMCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public GODJLPDGNFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x676FC60", Offset = "0x676E860", VA = "0x18676FC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x6770310", Offset = "0x676EF10", VA = "0x186770310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private sealed class LKEOBJHIOOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public LKEOBJHIOOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x6773530", Offset = "0x6772130", VA = "0x186773530")]
		internal object IGPPDODLPLG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct DEHNJILOHNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public GODJLPDGNFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private LPACJKPPDGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private ABDEKINDIGA <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x6769080", Offset = "0x6767C80", VA = "0x186769080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x6769640", Offset = "0x6768240", VA = "0x186769640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	private bool NKEPAONFPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000570")]
	private DBCLHGHLEMD<string>.OGCCDEKKEPE KAMOOCNEONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000571")]
	private OEENMHGGAHN KLNOEOGFLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	private CancellationToken EJGJLLMBDIN;

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x676C630", Offset = "0x676B230", VA = "0x18676C630")]
	public static Task CCOOBHJBNIJ(OEENMHGGAHN KLNOEOGFLGJ, bool NKEPAONFPFA, DBCLHGHLEMD<string>.OGCCDEKKEPE KAMOOCNEONO, CancellationToken NAKKCADDMGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x676C6A0", Offset = "0x676B2A0", VA = "0x18676C6A0")]
	[AsyncStateMachine(typeof(IKDJGHINMCN))]
	private Task EDEDADACBKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x676C790", Offset = "0x676B390", VA = "0x18676C790")]
	[AsyncStateMachine(typeof(DEHNJILOHNC))]
	private Task LEOCFOBILIC(bool KPPDPLFKNAG, string MIKEHJBIAOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30")]
	private bool MKFLCHPDELJ(bool NKEPAONFPFA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal struct LIFKBLBNBBN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct KNCFJOFHOLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public LIFKBLBNBBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x6770DA0", Offset = "0x676F9A0", VA = "0x186770DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x6771310", Offset = "0x676FF10", VA = "0x186771310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private sealed class KFONHEHODDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public KFONHEHODDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x6770A30", Offset = "0x676F630", VA = "0x186770A30")]
		internal object IGPPDODLPLG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct CKBPPNDOJPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public LIFKBLBNBBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		private LPACJKPPDGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		private ABDEKINDIGA <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x67673A0", Offset = "0x6765FA0", VA = "0x1867673A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x6767960", Offset = "0x6766560", VA = "0x186767960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000583")]
	private PMDBJMDCIPH IDJEDJIOJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000584")]
	private DBCLHGHLEMD<string>.OGCCDEKKEPE KAMOOCNEONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000585")]
	private OEENMHGGAHN KLNOEOGFLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000586")]
	private bool ALAGMOJIIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000587")]
	private GPMIMHCABEE KOMCCCIEHEA;

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x6772D00", Offset = "0x6771900", VA = "0x186772D00")]
	public static Task<Scene> AMNBIFCMFOJ(OEENMHGGAHN KLNOEOGFLGJ, PMDBJMDCIPH EDPBJHACMIP, DBCLHGHLEMD<string>.OGCCDEKKEPE KAMOOCNEONO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x6772D80", Offset = "0x6771980", VA = "0x186772D80")]
	[AsyncStateMachine(typeof(KNCFJOFHOLB))]
	private Task<Scene> EDEDADACBKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x6773060", Offset = "0x6771C60", VA = "0x186773060")]
	private bool NFHKJGMDDHL(GPMIMHCABEE KOMCCCIEHEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x6772EA0", Offset = "0x6771AA0", VA = "0x186772EA0")]
	private void JAAAPICPKIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x6772F10", Offset = "0x6771B10", VA = "0x186772F10")]
	[AsyncStateMachine(typeof(CKBPPNDOJPM))]
	private Task<Scene> LEOCFOBILIC(string MIKEHJBIAOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
internal struct JBPEGNMIILE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct ELLOGFDLGFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public AsyncTaskMethodBuilder<KGFEPDLLDBL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public JBPEGNMIILE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public KGFEPDLLDBL nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public GPMIMHCABEE deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private TaskAwaiter<KGFEPDLLDBL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x676ACC0", Offset = "0x67698C0", VA = "0x18676ACC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x676B7A0", Offset = "0x676A3A0", VA = "0x18676B7A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct LAKKBMMKEMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public AsyncTaskMethodBuilder<KGFEPDLLDBL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public JBPEGNMIILE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public KGFEPDLLDBL state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private TaskAwaiter<GAGOKAHMDNO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x6772130", Offset = "0x6770D30", VA = "0x186772130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x6772410", Offset = "0x6771010", VA = "0x186772410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000595")]
	private readonly GHPEMABLJJA ABCGAGONEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000596")]
	private readonly FKNHFKFGPNP GDECNFBKPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000597")]
	private readonly CICAAEIEHMD EGPDDKPOBEK;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private PBAGONGALMM NAPHNIIEAGN
	{
		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x4FEC110", Offset = "0x4FEAD10", VA = "0x184FEC110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x67706A0", Offset = "0x676F2A0", VA = "0x1867706A0")]
	public JBPEGNMIILE(GHPEMABLJJA ABCGAGONEBP, FKNHFKFGPNP GDECNFBKPIF, CICAAEIEHMD EGPDDKPOBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x6770390", Offset = "0x676EF90", VA = "0x186770390")]
	[AsyncStateMachine(typeof(ELLOGFDLGFB))]
	public Task<KGFEPDLLDBL> ALCMLFJKFNH(KGFEPDLLDBL HBBDJPFPANA, GPMIMHCABEE GOAOCOIGDBP, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN, bool FDOAEHDOKHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x6770540", Offset = "0x676F140", VA = "0x186770540")]
	[AsyncStateMachine(typeof(LAKKBMMKEMN))]
	private Task<KGFEPDLLDBL> CPEDIIFNBEH(DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, KGFEPDLLDBL KAADEKGDAHK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x6770510", Offset = "0x676F110", VA = "0x186770510")]
	private bool AOOLOLLPIFB(KGFEPDLLDBL IPJAGNBDKIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x6770370", Offset = "0x676EF70", VA = "0x186770370")]
	private void AGKNLPHAFKB(string OHNFGHCKMFM)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct HKGBFLNIEDI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct BMKKDFEOOOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public PBAGONGALMM operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public GPMIMHCABEE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public JIIAOAAIJLH timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private LPACJKPPDGK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private List<(PersistenceView, LJJGPBMCLBA)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private (PersistenceView, LJJGPBMCLBA) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x6763980", Offset = "0x6762580", VA = "0x186763980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x6763F90", Offset = "0x6762B90", VA = "0x186763F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x676E230", Offset = "0x676CE30", VA = "0x18676E230")]
	[AsyncStateMachine(typeof(BMKKDFEOOOA))]
	public static Task EDEDADACBKL(PBAGONGALMM ELLJNACABMF, GPMIMHCABEE KOMCCCIEHEA, JIIAOAAIJLH BCKADBOPJBM, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal struct DJCKKKPGCJN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct BPLBGEHDLEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public PBAGONGALMM operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public GPMIMHCABEE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public JIIAOAAIJLH timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private LPGOBKPNDLH <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private LPACJKPPDGK <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private List<(PersistenceView, LJJGPBMCLBA)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private LJJGPBMCLBA <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x6764AA0", Offset = "0x67636A0", VA = "0x186764AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x67652F0", Offset = "0x6763EF0", VA = "0x1867652F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x67696A0", Offset = "0x67682A0", VA = "0x1867696A0")]
	[AsyncStateMachine(typeof(BPLBGEHDLEJ))]
	public static Task EDEDADACBKL(PBAGONGALMM ELLJNACABMF, GPMIMHCABEE KOMCCCIEHEA, JIIAOAAIJLH BCKADBOPJBM, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal struct DPLECPPIPOC
{
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	public struct GDLKCBELBCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public List<PBKGAKIMKJB> OGLAGKAIBGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public List<LJJGPBMCLBA> GBNDLDKBNMA;

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x902320", Offset = "0x900F20", VA = "0x180902320")]
		public GDLKCBELBCB(List<PBKGAKIMKJB> OGLAGKAIBGN, List<LJJGPBMCLBA> GBNDLDKBNMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class HMAFKALKLPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public IEnumerable<PBKGAKIMKJB> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public HMAFKALKLPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x676E370", Offset = "0x676CF70", VA = "0x18676E370")]
		internal object LMLKKCENGEH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C4")]
	private OEENMHGGAHN KLNOEOGFLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C5")]
	private GPMIMHCABEE KOMCCCIEHEA;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private NCPOJFNGNHJ KOIOJGFJDFD
	{
		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x676A220", Offset = "0x6768E20", VA = "0x18676A220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x6769A40", Offset = "0x6768640", VA = "0x186769A40")]
	public static GDLKCBELBCB EDEDADACBKL(OEENMHGGAHN KLNOEOGFLGJ, GPMIMHCABEE KOMCCCIEHEA)
	{
		return default(GDLKCBELBCB);
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x67697E0", Offset = "0x67683E0", VA = "0x1867697E0")]
	private GDLKCBELBCB EDEDADACBKL()
	{
		return default(GDLKCBELBCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x6769AA0", Offset = "0x67686A0", VA = "0x186769AA0")]
	private GDLKCBELBCB FOLPCKPMEDI(KAILJKAMMLK FGEOGAODJCF, LPGOBKPNDLH CPEEBGFGIHC)
	{
		return default(GDLKCBELBCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x676A050", Offset = "0x6768C50", VA = "0x18676A050")]
	private bool GJNOLOLKEGK(IEnumerable<PBKGAKIMKJB> OGLAGKAIBGN)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000161")]
internal struct LEEHFGAIKLN
{
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class ACEJIGBJLKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public DPLECPPIPOC.GDLKCBELBCB instantiations;

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public ACEJIGBJLKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x6760500", Offset = "0x675F100", VA = "0x186760500")]
		internal object JKNIEOJDCJC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private sealed class EEPGLFAMPOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public EEPGLFAMPOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x676A700", Offset = "0x6769300", VA = "0x18676A700")]
		internal object NHJOAGGGLCF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x6772750", Offset = "0x6771350", VA = "0x186772750")]
	public static void EDEDADACBKL(PBAGONGALMM ELLJNACABMF, GPMIMHCABEE KOMCCCIEHEA, DPLECPPIPOC.GDLKCBELBCB GELMOCBMPMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
internal class CICAAEIEHMD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct IDKEDPJACDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public CICAAEIEHMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public KGFEPDLLDBL operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public GPMIMHCABEE deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x676EBE0", Offset = "0x676D7E0", VA = "0x18676EBE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x676F350", Offset = "0x676DF50", VA = "0x18676F350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private sealed class HPPBBNHOKFP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000167")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005DA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005DB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005DC")]
			public HPPBBNHOKFP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005DD")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005DE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x6778C00", Offset = "0x6777800", VA = "0x186778C00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x6778EC0", Offset = "0x6777AC0", VA = "0x186778EC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public CICAAEIEHMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public GPMIMHCABEE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public HPPBBNHOKFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x676E3F0", Offset = "0x676CFF0", VA = "0x18676E3F0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task KNGKIDAKLPN(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct OMMPPLIKFFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public CICAAEIEHMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public GPMIMHCABEE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private HPPBBNHOKFP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x6777370", Offset = "0x6775F70", VA = "0x186777370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x67778A0", Offset = "0x67764A0", VA = "0x1867778A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct ADLGHDPILBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public CICAAEIEHMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public GPMIMHCABEE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private Dictionary<Guid, List<EEJLJDHCNLJ>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x67605B0", Offset = "0x675F1B0", VA = "0x1867605B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x6760B60", Offset = "0x675F760", VA = "0x186760B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct HKBAEEAGAKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public CICAAEIEHMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public GPMIMHCABEE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		private DBCLHGHLEMD<string>.OGCCDEKKEPE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private Dictionary<Guid, List<EEJLJDHCNLJ>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x676DB50", Offset = "0x676C750", VA = "0x18676DB50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x676E1D0", Offset = "0x676CDD0", VA = "0x18676E1D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class LECMIIKHOHN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016C")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005FE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005FF")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000600")]
			public EEJLJDHCNLJ handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000601")]
			public LECMIIKHOHN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000602")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005B8")]
			[Cpp2IlInjected.Address(RVA = "0x6778A00", Offset = "0x6777600", VA = "0x186778A00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0x6778BA0", Offset = "0x67777A0", VA = "0x186778BA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public KNFFJIACNGO runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public List<EEJLJDHCNLJ> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public GPMIMHCABEE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public LECMIIKHOHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x6772570", Offset = "0x6771170", VA = "0x186772570")]
		internal object CNPCGBDLMFO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x6772660", Offset = "0x6771260", VA = "0x186772660")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task FAPNBPAGCFF(EEJLJDHCNLJ handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x6772480", Offset = "0x6771080", VA = "0x186772480")]
		internal object AEEDHDLGCOC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private struct EKLIEAGCGOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public KNFFJIACNGO runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public List<EEJLJDHCNLJ> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public GPMIMHCABEE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		private LECMIIKHOHN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x676A790", Offset = "0x6769390", VA = "0x18676A790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x676AC60", Offset = "0x6769860", VA = "0x18676AC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private struct CBINOKEHCEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public CICAAEIEHMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public GPMIMHCABEE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x6765350", Offset = "0x6763F50", VA = "0x186765350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x6765910", Offset = "0x6764510", VA = "0x186765910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private sealed class GEPDNNHAABJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public GEPDNNHAABJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x676C2C0", Offset = "0x676AEC0", VA = "0x18676C2C0")]
		internal object NIBIDIPNBEL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct GOHMENBBOIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public CICAAEIEHMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		public GPMIMHCABEE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		private LPACJKPPDGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x676C8C0", Offset = "0x676B4C0", VA = "0x18676C8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x676CD80", Offset = "0x676B980", VA = "0x18676CD80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class ODDFAKLJFON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public ODDFAKLJFON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x6775ED0", Offset = "0x6774AD0", VA = "0x186775ED0")]
		internal object LHKBFLHNAKE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct OLMCHIHADBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public CICAAEIEHMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		private LPACJKPPDGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		private TaskAwaiter<GAGOKAHMDNO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x6776CD0", Offset = "0x67758D0", VA = "0x186776CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x6777310", Offset = "0x6775F10", VA = "0x186777310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private sealed class DEGDKPANNBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public DEGDKPANNBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x6769010", Offset = "0x6767C10", VA = "0x186769010")]
		internal object LDOKHKFLCFN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005CC")]
	private readonly GHPEMABLJJA ABCGAGONEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005CD")]
	private HAILNMELGFP EGPDDKPOBEK;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private PBAGONGALMM NAPHNIIEAGN
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x10A0DD0", Offset = "0x109F9D0", VA = "0x1810A0DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
	public CICAAEIEHMD(GHPEMABLJJA ABCGAGONEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x6766610", Offset = "0x6765210", VA = "0x186766610")]
	[AsyncStateMachine(typeof(IDKEDPJACDN))]
	public Task EDEDADACBKL(KGFEPDLLDBL PIKBIOCBCKJ, GPMIMHCABEE GOAOCOIGDBP, DBCLHGHLEMD<string>.OGCCDEKKEPE KAMOOCNEONO, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x67668A0", Offset = "0x67654A0", VA = "0x1867668A0")]
	[AsyncStateMachine(typeof(OMMPPLIKFFA))]
	private Task FEMHPHGBCFC(GPMIMHCABEE KOMCCCIEHEA, DBCLHGHLEMD<string>.OGCCDEKKEPE KAMOOCNEONO, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x67669E0", Offset = "0x67655E0", VA = "0x1867669E0")]
	[AsyncStateMachine(typeof(ADLGHDPILBD))]
	private Task FGMBIEPKEPK(GPMIMHCABEE KOMCCCIEHEA, DBCLHGHLEMD<string>.OGCCDEKKEPE KAMOOCNEONO, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x6766DF0", Offset = "0x67659F0", VA = "0x186766DF0")]
	[AsyncStateMachine(typeof(HKBAEEAGAKN))]
	private Task JPGMGHPOHEA(GPMIMHCABEE KOMCCCIEHEA, DBCLHGHLEMD<string>.OGCCDEKKEPE KAMOOCNEONO, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x6766F30", Offset = "0x6765B30", VA = "0x186766F30")]
	[AsyncStateMachine(typeof(EKLIEAGCGOB))]
	private Task KFPHGPCGDHD(Guid FBGENFPEABC, List<EEJLJDHCNLJ> IIPABECPILE, KNFFJIACNGO AJODPMNLHJG, GPMIMHCABEE KOMCCCIEHEA, CancellationToken DGPOLLDAHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x6766760", Offset = "0x6765360", VA = "0x186766760")]
	[AsyncStateMachine(typeof(CBINOKEHCEA))]
	private Task EDMPAIAPGOK(GPMIMHCABEE KOMCCCIEHEA, DBCLHGHLEMD<string>.OGCCDEKKEPE KAMOOCNEONO, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x6766CB0", Offset = "0x67658B0", VA = "0x186766CB0")]
	[AsyncStateMachine(typeof(GOHMENBBOIA))]
	private Task JJHMKFFIDKA(Guid OLALKPNLGDM, GPMIMHCABEE KOMCCCIEHEA, DBCLHGHLEMD<string>.OGCCDEKKEPE KAMOOCNEONO, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x67663B0", Offset = "0x6764FB0", VA = "0x1867663B0")]
	[AsyncStateMachine(typeof(OLMCHIHADBJ))]
	private Task CEIEEJEDBFP(Guid OLALKPNLGDM, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x67664F0", Offset = "0x67650F0", VA = "0x1867664F0")]
	private void CGNBDNJJKAH(Guid OLALKPNLGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x6767080", Offset = "0x6765C80", VA = "0x186767080")]
	private void OECKMJBHAJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x6766B20", Offset = "0x6765720", VA = "0x186766B20")]
	public Guid INMPGACHGNA(KGFEPDLLDBL AKMFOOFGDCG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x67661D0", Offset = "0x6764DD0", VA = "0x1867661D0")]
	[CompilerGenerated]
	private object AGEOFENGJKA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
public readonly struct CGLPPOIENKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400062A")]
	public readonly bool EFCGPDMDHJN;

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0xCB28E0", Offset = "0xCB14E0", VA = "0x180CB28E0")]
	public CGLPPOIENKE(bool JPLJBDFCJCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
public readonly struct NJFIHEFGFDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400062B")]
	public readonly KAILJKAMMLK? EEOHGFDIGGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400062C")]
	public readonly GJNMPGMBBNO IFOABJEJJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400062D")]
	public readonly string? JMANPIAOOFN;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public IReadOnlyCollection<string> FBBDJPMJLJM
	{
		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x6774DD0", Offset = "0x67739D0", VA = "0x186774DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public IReadOnlyDictionary<long, int> MFFLINLBDLG
	{
		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x6774DB0", Offset = "0x67739B0", VA = "0x186774DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x6774DF0", Offset = "0x67739F0", VA = "0x186774DF0")]
	public NJFIHEFGFDH(KAILJKAMMLK? MAOJLJBOFIK, GJNMPGMBBNO ONOODFKFHGD, string? FJDNDBMAKEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
internal class APEGMDBPPMF : KALBNOPHLNO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct BCPKOPPBHNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public AsyncTaskMethodBuilder<NJFIHEFGFDH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public APEGMDBPPMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public KDFHOLOHIGA serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public JBEHIOFFAIM roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		private LPACJKPPDGK <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x6761D90", Offset = "0x6760990", VA = "0x186761D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x6762400", Offset = "0x6761000", VA = "0x186762400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class GNDNKOBBILM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public KDFHOLOHIGA serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public APEGMDBPPMF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public GNDNKOBBILM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x676C330", Offset = "0x676AF30", VA = "0x18676C330")]
		internal Task IBEKJCNGNOJ(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x676C550", Offset = "0x676B150", VA = "0x18676C550")]
		internal Task PGDOMOKCALK(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private sealed class BGELBNLFHLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public GNDNKOBBILM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public BGELBNLFHLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x6762E70", Offset = "0x6761A70", VA = "0x186762E70")]
		internal object NBCEOBCMDOL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private sealed class OIBPBMPKNKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public GNDNKOBBILM CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public OIBPBMPKNKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x6776820", Offset = "0x6775420", VA = "0x186776820")]
		internal Task IPOFGIMFLMF(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct NHBBKDNPIPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public KDFHOLOHIGA serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public APEGMDBPPMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		private BGELBNLFHLJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		private LPACJKPPDGK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x6773E70", Offset = "0x6772A70", VA = "0x186773E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x67746E0", Offset = "0x67732E0", VA = "0x1867746E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400062E")]
	private readonly HEENJBKIIAO BNEDOBBKLOJ;

	[Cpp2IlInjected.Token(Token = "0x400062F")]
	private static readonly TimeSpan IDIKOEILGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000630")]
	private readonly PPMDACEKENA PBGBMPENBEP;

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x6761C10", Offset = "0x6760810", VA = "0x186761C10")]
	public APEGMDBPPMF(GHPEMABLJJA ABCGAGONEBP, PPMDACEKENA PBGBMPENBEP, HEENJBKIIAO BNEDOBBKLOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x6761050", Offset = "0x675FC50", VA = "0x186761050")]
	[AsyncStateMachine(typeof(BCPKOPPBHNC))]
	public Task<NJFIHEFGFDH> GAPNIKJAJOO(long FPCFGLFPIMK, JBEHIOFFAIM NBIHJDKAMLA, KDFHOLOHIGA HFEJFGIGBPH, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x6761A60", Offset = "0x6760660", VA = "0x186761A60")]
	[AsyncStateMachine(typeof(NHBBKDNPIPM))]
	private Task MKIJHGNHNCF(KDFHOLOHIGA HFEJFGIGBPH, IEnumerable<PersistenceView> MGELHEOMGDD, StringBuilder HACGKFKEALJ, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x6760BC0", Offset = "0x675F7C0", VA = "0x186760BC0")]
	private NJFIHEFGFDH CLHODDKICJH(long FPCFGLFPIMK, JBEHIOFFAIM NBIHJDKAMLA, KDFHOLOHIGA HFEJFGIGBPH, IEnumerable<PersistenceView> MGELHEOMGDD, StringBuilder HACGKFKEALJ)
	{
		return default(NJFIHEFGFDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x67611B0", Offset = "0x675FDB0", VA = "0x1867611B0")]
	private KAILJKAMMLK JINKMODBCAA(long FPCFGLFPIMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x6761370", Offset = "0x675FF70", VA = "0x186761370")]
	private void LBHKPODBHFJ(KAILJKAMMLK IGNDJEHIDIE, StringBuilder HACGKFKEALJ, IEnumerable<PersistenceView> MGELHEOMGDD, [In] FPNDLBGAGEC LDBMCHPCEOC, MILKCCKGIBO GEGIAKKFEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x67615C0", Offset = "0x67601C0", VA = "0x1867615C0")]
	private void MIEPCCCBGGE(KAILJKAMMLK IGNDJEHIDIE, StringBuilder HACGKFKEALJ, PersistenceView BPGBGHDKKFL, MILKCCKGIBO GEGIAKKFEFM, [In] FPNDLBGAGEC LDBMCHPCEOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal class MNMLLHFKGBF : KALBNOPHLNO
{
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private sealed class KNNCHNKDEDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public IHANGNLMDAL.DPNKFNDKGEA roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public KNNCHNKDEDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x6771380", Offset = "0x676FF80", VA = "0x186771380")]
		internal object FKJGKOHDPIL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct IFIEBFNCLLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public AsyncTaskMethodBuilder<(IHANGNLMDAL.DPNKFNDKGEA roomDataUpload, IHANGNLMDAL.DPNKFNDKGEA subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public NJFIHEFGFDH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public MNMLLHFKGBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		private KNNCHNKDEDB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private TaskAwaiter<IHANGNLMDAL.DPNKFNDKGEA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x676F3B0", Offset = "0x676DFB0", VA = "0x18676F3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x676FBF0", Offset = "0x676E7F0", VA = "0x18676FBF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct PBFAMOEGMFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public AsyncTaskMethodBuilder<GILBFMDGNPJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public MNMLLHFKGBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public NJFIHEFGFDH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public KCLHKFMCGHF roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private TaskAwaiter<(IHANGNLMDAL.DPNKFNDKGEA roomDataUpload, IHANGNLMDAL.DPNKFNDKGEA subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private TaskAwaiter<GILBFMDGNPJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x6777900", Offset = "0x6776500", VA = "0x186777900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x6777F20", Offset = "0x6776B20", VA = "0x186777F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private struct DAMGELHMGAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		public AsyncTaskMethodBuilder<HFEHGMAKIHJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		public MNMLLHFKGBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		public NJFIHEFGFDH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		private TaskAwaiter<(IHANGNLMDAL.DPNKFNDKGEA roomDataUpload, IHANGNLMDAL.DPNKFNDKGEA subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		private TaskAwaiter<HFEHGMAKIHJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x67679D0", Offset = "0x67665D0", VA = "0x1867679D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x6767DF0", Offset = "0x67669F0", VA = "0x186767DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class BANEHFALDJG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000184")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400067C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400067D")]
			public AsyncTaskMethodBuilder<GAGOKAHMDNO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400067E")]
			public BANEHFALDJG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400067F")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000680")]
			private GAGOKAHMDNO <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000681")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000682")]
			private TaskAwaiter<HFEHGMAKIHJ> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000683")]
			private TaskAwaiter<GILBFMDGNPJ> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000684")]
			private TaskAwaiter<GAGOKAHMDNO> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x6778F20", Offset = "0x6777B20", VA = "0x186778F20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x6779EB0", Offset = "0x6778AB0", VA = "0x186779EB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public MNMLLHFKGBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public NJFIHEFGFDH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public KCLHKFMCGHF roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public CGLPPOIENKE roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public BANEHFALDJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x6761C60", Offset = "0x6760860", VA = "0x186761C60")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<GAGOKAHMDNO> AKPMMLJOIHF(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private struct FEKCDGFAJIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public AsyncTaskMethodBuilder<GAGOKAHMDNO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public MNMLLHFKGBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public NJFIHEFGFDH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public KCLHKFMCGHF roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public CGLPPOIENKE roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public DBCLHGHLEMD<string>.OGCCDEKKEPE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		private TaskAwaiter<GAGOKAHMDNO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x676B810", Offset = "0x676A410", VA = "0x18676B810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x676BB20", Offset = "0x676A720", VA = "0x18676BB20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000653")]
	private static readonly HEENJBKIIAO BNEDOBBKLOJ;

	[Cpp2IlInjected.Token(Token = "0x4000654")]
	private static readonly HEENJBKIIAO LGBIBAMCPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000655")]
	private readonly DDDLPBOPCJH LALNDCPIKBK;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private OEENMHGGAHN LJLGNBJPEBP
	{
		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x6749ED0", Offset = "0x6748AD0", VA = "0x186749ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x6773C10", Offset = "0x6772810", VA = "0x186773C10")]
	public MNMLLHFKGBF(GHPEMABLJJA ABCGAGONEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x67735B0", Offset = "0x67721B0", VA = "0x1867735B0")]
	[AsyncStateMachine(typeof(IFIEBFNCLLL))]
	private Task<(IHANGNLMDAL.DPNKFNDKGEA, IHANGNLMDAL.DPNKFNDKGEA)> BBKHAKIAKJB(NJFIHEFGFDH LMDPDBHCJEG, long MGDJPIEDFNB, long FLKBFMIKIPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x6773A00", Offset = "0x6772600", VA = "0x186773A00")]
	[AsyncStateMachine(typeof(PBFAMOEGMFM))]
	public Task<GILBFMDGNPJ> MPOJKFCHIIK(int PEBMEEJPPHO, [CanBeNull] KCLHKFMCGHF KEMGBKKIEOD, NJFIHEFGFDH LMDPDBHCJEG, long MGDJPIEDFNB, long FLKBFMIKIPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x67736F0", Offset = "0x67722F0", VA = "0x1867736F0")]
	[AsyncStateMachine(typeof(DAMGELHMGAD))]
	private Task<HFEHGMAKIHJ> DNNGHAGPNEF(string EOAALFBIDOK, int PEBMEEJPPHO, NJFIHEFGFDH LMDPDBHCJEG, long MGDJPIEDFNB, long FLKBFMIKIPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x6773860", Offset = "0x6772460", VA = "0x186773860")]
	[AsyncStateMachine(typeof(FEKCDGFAJIO))]
	public Task<GAGOKAHMDNO> JFHDGBOKAKP(int PEBMEEJPPHO, KCLHKFMCGHF? KEMGBKKIEOD, NJFIHEFGFDH LMDPDBHCJEG, long MGDJPIEDFNB, long FLKBFMIKIPD, CGLPPOIENKE HLMODPDGJJL, DBCLHGHLEMD<string>.OGCCDEKKEPE MHBBFODICIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
public abstract class PNHJELLDICC<T> where T : PNHJELLDICC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000691")]
	internal readonly OEENMHGGAHN PBNHNKMHHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000692")]
	private int? PDIEDNGJBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000693")]
	protected readonly Guid FCHEOIGLPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000694")]
	protected readonly IDCOIPDFBIB NNOGPIOIBKF;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	protected T LCANGJKOGGO
	{
		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x4127BB0", Offset = "0x41267B0", VA = "0x184127BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x4127E10", Offset = "0x4126A10", VA = "0x184127E10")]
	internal PNHJELLDICC(OEENMHGGAHN HHGFAOFCABE, IDCOIPDFBIB JLFKIJMCLBB, [Optional] Guid? BJNGDHCNCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x4127D30", Offset = "0x4126930", VA = "0x184127D30")]
	private GAGOKAHMDNO PHBHPCBKPFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "4")]
	protected virtual void LBDGNLOAKIF(GAGOKAHMDNO COECLHOAJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x4127A30", Offset = "0x4126630", VA = "0x184127A30")]
	public T BGGBKALFBEN(IFDGJPHDBFK ANJKAMGJFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x4127B20", Offset = "0x4126720", VA = "0x184127B20")]
	public T JCFFBFCJEED(int CIJEPMLKHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x4127C10", Offset = "0x4126810", VA = "0x184127C10", Slot = "5")]
	public virtual Task<HAGKOKKBGGA> LAMLJNEJHII()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
public class KPHNEGJGLOF : PNHJELLDICC<KPHNEGJGLOF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000695")]
	private CGNOFECNPIB FGGJAKAMDOE;

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x6772060", Offset = "0x6770C60", VA = "0x186772060")]
	internal KPHNEGJGLOF(OEENMHGGAHN HHGFAOFCABE, IDCOIPDFBIB JLFKIJMCLBB, [Optional] Guid? BJNGDHCNCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x5D89E70", Offset = "0x5D88A70", VA = "0x185D89E70")]
	public KPHNEGJGLOF OMAKBGNKIML(CGNOFECNPIB FGGJAKAMDOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x6771F90", Offset = "0x6770B90", VA = "0x186771F90", Slot = "4")]
	protected override void LBDGNLOAKIF(GAGOKAHMDNO COECLHOAJJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
public class DPOFENGHMKM : PNHJELLDICC<DPOFENGHMKM>
{
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	internal enum BBBFKFHLDKI
	{
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private struct OGKAPLHABFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public AsyncTaskMethodBuilder<HAGKOKKBGGA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public DPOFENGHMKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		private TaskAwaiter<HAGKOKKBGGA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x6775F40", Offset = "0x6774B40", VA = "0x186775F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x67762F0", Offset = "0x6774EF0", VA = "0x1867762F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000696")]
	private BBBFKFHLDKI BCGBJLMLAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private string MJGKOIBODOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000698")]
	private KCLHKFMCGHF FGGJAKAMDOE;

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x676A590", Offset = "0x6769190", VA = "0x18676A590")]
	internal DPOFENGHMKM(OEENMHGGAHN HHGFAOFCABE, IDCOIPDFBIB JLFKIJMCLBB, [Optional] Guid? BJNGDHCNCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x676A270", Offset = "0x6768E70", VA = "0x18676A270")]
	public DPOFENGHMKM CFDNDIHGIEC(string PCPJCEHFFMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x676A500", Offset = "0x6769100", VA = "0x18676A500")]
	public DPOFENGHMKM NELNFHDEKIH(bool HDEPLCJAAMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x676A520", Offset = "0x6769120", VA = "0x18676A520")]
	public DPOFENGHMKM NGNJHGCMIDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x676A390", Offset = "0x6768F90", VA = "0x18676A390", Slot = "4")]
	protected override void LBDGNLOAKIF(GAGOKAHMDNO COECLHOAJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x676A2A0", Offset = "0x6768EA0", VA = "0x18676A2A0", Slot = "5")]
	[AsyncStateMachine(typeof(OGKAPLHABFO))]
	public override Task<HAGKOKKBGGA> LAMLJNEJHII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x676A550", Offset = "0x6769150", VA = "0x18676A550")]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task<HAGKOKKBGGA> OBPCOKCDKKP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal static class MPMNFNHAEOC
{
	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x6773CA0", Offset = "0x67728A0", VA = "0x186773CA0")]
	public static void BMEIIPENGHE(this ICIKGNAKMLM CNNADMCCDHF, JENGLAFMNAE ACFIBGFBPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x6773DF0", Offset = "0x67729F0", VA = "0x186773DF0")]
	public static void GIIKEJELEFN(this JENGLAFMNAE OANIEGOBMMB, [Optional] string COECLHOAJJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
public static class HIBJIGCAHEI
{
	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x676DAB0", Offset = "0x676C6B0", VA = "0x18676DAB0")]
	public static PBNLADHBLCA PJDFJBMGGKN(this FAIHJLBMCCO HKEAAGDLOCP)
	{
		return default(PBNLADHBLCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x676DA00", Offset = "0x676C600", VA = "0x18676DA00")]
	public static FAIHJLBMCCO FPJCNJCPJNA(this PBNLADHBLCA EJLDFECLJPI)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200018E")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006A5")]
			public MACAEIGIDMM ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006A6")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006A7")]
			public MACAEIGIDMM HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006A8")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006A9")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006AA")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x600061A")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		private static MACAEIGIDMM[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		private Dictionary<MACAEIGIDMM, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x677A6F0", Offset = "0x67792F0", VA = "0x18677A6F0")]
		public bool LAPOENFKLNA(MACAEIGIDMM NDFGNFFALAF, [Out] ResultConfig LCKLFNLGOKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x677A5B0", Offset = "0x67791B0", VA = "0x18677A5B0")]
		public ResultConfig CIENJLLCJFM(MACAEIGIDMM PBFMPJEICKM, [Optional] HashSet<MACAEIGIDMM> PECKNAKGOME)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x677ACC0", Offset = "0x67798C0", VA = "0x18677ACC0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x677A760", Offset = "0x6779360", VA = "0x18677A760", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x89ACE0", Offset = "0x8998E0", VA = "0x18089ACE0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public static class BNIGEABPPNE
{
	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x6763FF0", Offset = "0x6762BF0", VA = "0x186763FF0")]
	[JDFNDIEGGDI(COFBNFOEGIB.GameOnly)]
	private static void NOGKHDMNIHD(OJEGDOKHPNO KFDFGHNENJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
public interface GEKIPCCOKMO : IEquatable<GEKIPCCOKMO>
{
	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	DateTime GKOEJLIJCGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IDEEGFKBHFE();

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BBFHEOGDAJP(long MGDJPIEDFNB, long FPCFGLFPIMK, [Out] NJFIHEFGFDH LMDPDBHCJEG);
}
[Cpp2IlInjected.Token(Token = "0x2000192")]
internal class KOGIGIILMBM : BMEFCDCOBGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private sealed class GBCNEGJLJCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public NBPGIDCICPL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public GBCNEGJLJCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x676C250", Offset = "0x676AE50", VA = "0x18676C250")]
		internal object OOJKBAOBEDH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B0")]
	private readonly BIOAKFDCFOP OJKMDIPDMAN;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<GEKIPCCOKMO> PLLDJPLFJAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x6771EE0", Offset = "0x6770AE0", VA = "0x186771EE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x6771AA0", Offset = "0x67706A0", VA = "0x186771AA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
	[UnityEngine.Scripting.Preserve]
	public KOGIGIILMBM([NNEMKPMNJAE(null)] BIOAKFDCFOP OJKMDIPDMAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x6771C00", Offset = "0x6770800", VA = "0x186771C00", Slot = "6")]
	public bool OEECCCFBHKA(long MGDJPIEDFNB, long FPCFGLFPIMK, NJFIHEFGFDH LMDPDBHCJEG, NBPGIDCICPL GKFJBPLKJAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x1A308B0", Offset = "0x1A2F4B0", VA = "0x181A308B0")]
	private void OMIKBGDDGIC(GEKIPCCOKMO JFCBPOJCGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x67713D0", Offset = "0x676FFD0", VA = "0x1867713D0", Slot = "7")]
	public bool CLKMIODDEGD(long MGDJPIEDFNB, long FPCFGLFPIMK, [Out] GEKIPCCOKMO FEBLDJCELMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x6771B50", Offset = "0x6770750", VA = "0x186771B50", Slot = "8")]
	public bool NCJGBBKMMDM(long MGDJPIEDFNB, long FPCFGLFPIMK, NBPGIDCICPL GKFJBPLKJAE, [Out] GEKIPCCOKMO FEBLDJCELMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x6771540", Offset = "0x6770140", VA = "0x186771540")]
	private void DGEDCOFALOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x6771970", Offset = "0x6770570", VA = "0x186771970", Slot = "9")]
	public void GGALEODDKDH(long MGDJPIEDFNB, long FPCFGLFPIMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
internal abstract class BLIOCFEKMAA : BIOAKFDCFOP
{
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	protected enum CAIFEGMMLIN : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private sealed class JCBKBGJELNH : IEnumerable<GEKIPCCOKMO>, IEnumerable, IEnumerator<GEKIPCCOKMO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		private GEKIPCCOKMO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public BLIOCFEKMAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private NBPGIDCICPL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public NBPGIDCICPL <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		private GEKIPCCOKMO System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000642")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x808950", Offset = "0x807550", VA = "0x180808950")]
		[DebuggerHidden]
		public JCBKBGJELNH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x6770700", Offset = "0x676F300", VA = "0x186770700", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x67709E0", Offset = "0x676F5E0", VA = "0x1867709E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x6770930", Offset = "0x676F530", VA = "0x186770930", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GEKIPCCOKMO> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x6770930", Offset = "0x676F530", VA = "0x186770930", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private sealed class PHNAGHGIDNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public NBPGIDCICPL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public PHNAGHGIDNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x6778610", Offset = "0x6777210", VA = "0x186778610")]
		internal object HAGGAJHPCKG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private sealed class FIGFBNBPKPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public BLIOCFEKMAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public FIGFBNBPKPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x676BB90", Offset = "0x676A790", VA = "0x18676BB90")]
		internal void HDALDAJGANA(DPEEAPFBNGN.CLGAFAAKIME ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B6")]
	protected readonly string AONBGMPABEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006B7")]
	private readonly object CFOCGCMELKF;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public abstract ODKAGADLDIG OBMLPGLGLLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x67638E0", Offset = "0x67624E0", VA = "0x1867638E0")]
	protected BLIOCFEKMAA([CanBeNull] string NNHEDJEBICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x6763360", Offset = "0x6761F60", VA = "0x186763360", Slot = "5")]
	public bool LDJANPEIKGE(long MGDJPIEDFNB, long FPCFGLFPIMK, NBPGIDCICPL GKFJBPLKJAE, [Out] GEKIPCCOKMO JFCBPOJCGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x6762F50", Offset = "0x6761B50", VA = "0x186762F50", Slot = "6")]
	[IteratorStateMachine(typeof(JCBKBGJELNH))]
	public IEnumerable<GEKIPCCOKMO> DNAJDKOFPLB(NBPGIDCICPL GKFJBPLKJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void AOMPBLBPCMF(Stream KGCELGEGGMK, long MGDJPIEDFNB, long FPCFGLFPIMK, NJFIHEFGFDH LMDPDBHCJEG);

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool LFGGJDGBMGP(Stream JFCDJOANFGD, long MGDJPIEDFNB, long FPCFGLFPIMK, BPBKHBKBGCI CEKBLMHCGCL, [Out] NJFIHEFGFDH LMDPDBHCJEG);

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x6762FE0", Offset = "0x6761BE0", VA = "0x186762FE0", Slot = "7")]
	public GEKIPCCOKMO KEICLJJNIFL(long MGDJPIEDFNB, long FPCFGLFPIMK, NJFIHEFGFDH LMDPDBHCJEG, NBPGIDCICPL GKFJBPLKJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo IBPAAMMKPHK(long MGDJPIEDFNB, long FPCFGLFPIMK, NBPGIDCICPL GKFJBPLKJAE, CAIFEGMMLIN IPICOELPOAG);

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo GHNLMKHJKHC(NBPGIDCICPL GKFJBPLKJAE, CAIFEGMMLIN IPICOELPOAG);

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x6762EE0", Offset = "0x6761AE0", VA = "0x186762EE0")]
	protected void BDDMPCMFIGA(DPEEAPFBNGN.CLGAFAAKIME NHECDELIMJF, string OHNFGHCKMFM, FileInfo GEEDGFJIFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x6763550", Offset = "0x6762150", VA = "0x186763550")]
	internal bool MBILNMHIMOF(FileInfo AHNNMDPPPKM, long MGDJPIEDFNB, long FPCFGLFPIMK, [Out] NJFIHEFGFDH LMDPDBHCJEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200")]
	private void KKCDJAKLODO(Exception BKLOPMPJKCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
internal class HGGLHEDHBGK : BLIOCFEKMAA
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public override ODKAGADLDIG OBMLPGLGLLC
	{
		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0xAC71A0", Offset = "0xAC5DA0", VA = "0x180AC71A0", Slot = "8")]
		get
		{
			return default(ODKAGADLDIG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x676D940", Offset = "0x676C540", VA = "0x18676D940")]
	public HGGLHEDHBGK([Optional] string NNHEDJEBICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x676D070", Offset = "0x676BC70", VA = "0x18676D070")]
	private void DLAIPPNMHNP(NBPGIDCICPL GKFJBPLKJAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x676CDE0", Offset = "0x676B9E0", VA = "0x18676CDE0", Slot = "9")]
	internal override void AOMPBLBPCMF(Stream KGCELGEGGMK, long MGDJPIEDFNB, long FPCFGLFPIMK, NJFIHEFGFDH LMDPDBHCJEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x676D2F0", Offset = "0x676BEF0", VA = "0x18676D2F0", Slot = "10")]
	internal override bool LFGGJDGBMGP(Stream JFCDJOANFGD, long MGDJPIEDFNB, long FPCFGLFPIMK, BPBKHBKBGCI CEKBLMHCGCL, [Out] NJFIHEFGFDH LMDPDBHCJEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x676D200", Offset = "0x676BE00", VA = "0x18676D200", Slot = "11")]
	protected override FileInfo IBPAAMMKPHK(long MGDJPIEDFNB, long FPCFGLFPIMK, NBPGIDCICPL GKFJBPLKJAE, CAIFEGMMLIN IPICOELPOAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x676D0F0", Offset = "0x676BCF0", VA = "0x18676D0F0", Slot = "12")]
	protected override DirectoryInfo GHNLMKHJKHC(NBPGIDCICPL GKFJBPLKJAE, CAIFEGMMLIN IPICOELPOAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
internal sealed class NNEJBOFGMBD : BLIOCFEKMAA
{
	[Cpp2IlInjected.Token(Token = "0x40006C7")]
	private static readonly byte[] CGGNJKGENIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006C8")]
	private readonly byte[] ENEBJHCDJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	private readonly byte[] LOPCNDGKBCP;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public override ODKAGADLDIG OBMLPGLGLLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x5642450", Offset = "0x5641050", VA = "0x185642450", Slot = "8")]
		get
		{
			return default(ODKAGADLDIG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x6775D70", Offset = "0x6774970", VA = "0x186775D70")]
	public NNEJBOFGMBD([Optional] string NNHEDJEBICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x6774EF0", Offset = "0x6773AF0", VA = "0x186774EF0", Slot = "9")]
	internal override void AOMPBLBPCMF(Stream KGCELGEGGMK, long MGDJPIEDFNB, long FPCFGLFPIMK, NJFIHEFGFDH LMDPDBHCJEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x67754B0", Offset = "0x67740B0", VA = "0x1867754B0", Slot = "10")]
	internal override bool LFGGJDGBMGP(Stream JFCDJOANFGD, long MGDJPIEDFNB, long FPCFGLFPIMK, BPBKHBKBGCI CEKBLMHCGCL, [Out] NJFIHEFGFDH LMDPDBHCJEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x67753F0", Offset = "0x6773FF0", VA = "0x1867753F0")]
	private void JMKEHFGMNHO(byte[] PJGIELDOKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x67752C0", Offset = "0x6773EC0", VA = "0x1867752C0", Slot = "11")]
	protected override FileInfo IBPAAMMKPHK(long MGDJPIEDFNB, long FPCFGLFPIMK, NBPGIDCICPL GKFJBPLKJAE, CAIFEGMMLIN IPICOELPOAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x67751B0", Offset = "0x6773DB0", VA = "0x1867751B0", Slot = "12")]
	protected override DirectoryInfo GHNLMKHJKHC(NBPGIDCICPL GKFJBPLKJAE, CAIFEGMMLIN IPICOELPOAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
public enum ODKAGADLDIG : byte
{
	[Cpp2IlInjected.Token(Token = "0x40006CB")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40006CC")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40006CD")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
internal class CGFGOPOEGLB : BIOAKFDCFOP
{
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[CompilerGenerated]
	private sealed class OGODHACDDFF : IEnumerable<GEKIPCCOKMO>, IEnumerable, IEnumerator<GEKIPCCOKMO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		private GEKIPCCOKMO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		public CGFGOPOEGLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		private NBPGIDCICPL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		public NBPGIDCICPL <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		private ODKAGADLDIG[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		private IEnumerator<GEKIPCCOKMO> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		private GEKIPCCOKMO System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000669")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600066B")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x808950", Offset = "0x807550", VA = "0x180808950")]
		[DebuggerHidden]
		public OGODHACDDFF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x6776790", Offset = "0x6775390", VA = "0x186776790", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x67763B0", Offset = "0x6774FB0", VA = "0x1867763B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x6776360", Offset = "0x6774F60", VA = "0x186776360")]
		private void DPHAFEJOOLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x6776740", Offset = "0x6775340", VA = "0x186776740", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x6776690", Offset = "0x6775290", VA = "0x186776690", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GEKIPCCOKMO> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x6776690", Offset = "0x6775290", VA = "0x186776690", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006CE")]
	private readonly ODKAGADLDIG[] FJPKECIBKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006CF")]
	private readonly Dictionary<ODKAGADLDIG, BIOAKFDCFOP> CGEIEBLPKHB;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public ODKAGADLDIG OBMLPGLGLLC
	{
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x6765A00", Offset = "0x6764600", VA = "0x186765A00", Slot = "4")]
		get
		{
			return default(ODKAGADLDIG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x6765E80", Offset = "0x6764A80", VA = "0x186765E80")]
	[UnityEngine.Scripting.Preserve]
	public CGFGOPOEGLB(params BIOAKFDCFOP[] GPBCLOPIHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x6765B10", Offset = "0x6764710", VA = "0x186765B10", Slot = "5")]
	public bool LDJANPEIKGE(long MGDJPIEDFNB, long FPCFGLFPIMK, NBPGIDCICPL GKFJBPLKJAE, [Out] GEKIPCCOKMO JFCBPOJCGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x6765C60", Offset = "0x6764860", VA = "0x186765C60")]
	private void MLNGAHNJFFB(int BOHGMFMIKKB, long MGDJPIEDFNB, long FPCFGLFPIMK, NBPGIDCICPL GKFJBPLKJAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x6765970", Offset = "0x6764570", VA = "0x186765970", Slot = "6")]
	[IteratorStateMachine(typeof(OGODHACDDFF))]
	public IEnumerable<GEKIPCCOKMO> DNAJDKOFPLB(NBPGIDCICPL GKFJBPLKJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x6765A30", Offset = "0x6764630", VA = "0x186765A30", Slot = "7")]
	public GEKIPCCOKMO KEICLJJNIFL(long MGDJPIEDFNB, long FPCFGLFPIMK, NJFIHEFGFDH LMDPDBHCJEG, NBPGIDCICPL GKFJBPLKJAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
internal static class KIENNCFKMMM
{
	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x6770B00", Offset = "0x676F700", VA = "0x186770B00")]
	internal static byte[] PFHFNJNDGJK(byte[] PJGIELDOKCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x6770A80", Offset = "0x676F680", VA = "0x186770A80")]
	public static void CEAPAGBPMPG(Stream LHFBIKKBMMG, byte[] MHIFEELKNBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x6770BC0", Offset = "0x676F7C0", VA = "0x186770BC0")]
	public static bool PJPOMGLKFGB(Stream LHFBIKKBMMG, long OBGPIMGPPBB, BPBKHBKBGCI CDAJAMLIACF, [Out] byte[] OBAHGGJPBOE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
internal sealed class NHMKFKGCLIF : GEKIPCCOKMO, IEquatable<GEKIPCCOKMO>, IEquatable<NHMKFKGCLIF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	private readonly BLIOCFEKMAA EKLBACDPPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006DE")]
	public readonly FileInfo FJKEBKKGLHC;

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public ODKAGADLDIG OBMLPGLGLLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x1F92C40", Offset = "0x1F91840", VA = "0x181F92C40", Slot = "9")]
		get
		{
			return default(ODKAGADLDIG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public DateTime GKOEJLIJCGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x6774A10", Offset = "0x6773610", VA = "0x186774A10", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x6774CA0", Offset = "0x67738A0", VA = "0x186774CA0")]
	public NHMKFKGCLIF(BLIOCFEKMAA PEHECDMEDFI, FileInfo AHNNMDPPPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x6774BF0", Offset = "0x67737F0", VA = "0x186774BF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x6774B30", Offset = "0x6773730", VA = "0x186774B30", Slot = "5")]
	public void IDEEGFKBHFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x6774740", Offset = "0x6773340", VA = "0x186774740", Slot = "6")]
	public bool BBFHEOGDAJP(long MGDJPIEDFNB, long FPCFGLFPIMK, [Out] NJFIHEFGFDH LMDPDBHCJEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x6774780", Offset = "0x6773380", VA = "0x186774780", Slot = "7")]
	public bool Equals(GEKIPCCOKMO NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x6774950", Offset = "0x6773550", VA = "0x186774950", Slot = "8")]
	public bool Equals(NHMKFKGCLIF NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x6774860", Offset = "0x6773460", VA = "0x186774860", Slot = "0")]
	public override bool Equals(object OGGNGHKHHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x6774AA0", Offset = "0x67736A0", VA = "0x186774AA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
public delegate void BPBKHBKBGCI(DPEEAPFBNGN.CLGAFAAKIME JLHLKEJBOFK, string COECLHOAJJF);
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal interface BIOAKFDCFOP
{
	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	ODKAGADLDIG OBMLPGLGLLC
	{
		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LDJANPEIKGE(long MGDJPIEDFNB, long FPCFGLFPIMK, NBPGIDCICPL GKFJBPLKJAE, [Out] GEKIPCCOKMO JFCBPOJCGFH);

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<GEKIPCCOKMO> DNAJDKOFPLB(NBPGIDCICPL GKFJBPLKJAE);

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GEKIPCCOKMO KEICLJJNIFL(long MGDJPIEDFNB, long FPCFGLFPIMK, NJFIHEFGFDH LMDPDBHCJEG, NBPGIDCICPL GKFJBPLKJAE);
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
