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
		[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
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
		[Cpp2IlInjected.Address(RVA = "0x6838C20", Offset = "0x6837A20", VA = "0x186838C20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D9DC0", Offset = "0x7D8BC0", VA = "0x1807D9DC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D9E00", Offset = "0x7D8C00", VA = "0x1807D9E00")]
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
	public class LogRegistrationIndex : KGHKLAJDNIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6834560", Offset = "0x6833360", VA = "0x186834560", Slot = "4")]
		public override void GEBEKKCKBFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JODLNMDPGOK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6830C10", Offset = "0x682FA10", VA = "0x186830C10")]
	public JODLNMDPGOK(string HPJAAILCALJ, Exception KDFDHMLGGAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class EKCKCJJIMBC : JPKKEHBHLLP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct CLFBPEOEEFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<BHFFEFMOLAM>> <>t__builder;

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
		private TaskAwaiter<PJLBOEMGEBL<BHFFEFMOLAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x681FE70", Offset = "0x681EC70", VA = "0x18681FE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x68200B0", Offset = "0x681EEB0", VA = "0x1868200B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct KKNMBCGEIHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<LLLDMNIJMMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<LLLDMNIJMMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6832000", Offset = "0x6830E00", VA = "0x186832000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6832210", Offset = "0x6831010", VA = "0x186832210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	[UnityEngine.Scripting.Preserve]
	public EKCKCJJIMBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6821960", Offset = "0x6820760", VA = "0x186821960", Slot = "4")]
	[AsyncStateMachine(typeof(CLFBPEOEEFO))]
	public Task<IReadOnlyList<BHFFEFMOLAM>> FMAOMDFAGGF(long EKMDOMOGGBC, long LCDEHGNNMHO, [Optional] CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6821A80", Offset = "0x6820880", VA = "0x186821A80", Slot = "5")]
	[AsyncStateMachine(typeof(KKNMBCGEIHO))]
	public Task<IReadOnlyList<LLLDMNIJMMO>> LOKAABHLHGO(IReadOnlyList<int> PGLOBJMILJF, [Optional] CancellationToken KANPDHELHMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NAHLGPBFOKN : IEquatable<NAHLGPBFOKN>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int NPMBKHHBEAM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	LLLDMNIJMMO EABCAFHFHCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime CMDIAGJCDBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	AMEEKGGICDG? JCPBKDPPNBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	KMEFIMFCBBL? ONLKOAHIPDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	APDLIKACNHL LCMDMKFDACB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<OECPMONDBOC> CMGLJEAOGED();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum APDLIKACNHL
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JPKKEHBHLLP
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<BHFFEFMOLAM>> FMAOMDFAGGF(long EKMDOMOGGBC, long LCDEHGNNMHO, [Optional] CancellationToken KANPDHELHMD);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<LLLDMNIJMMO>> LOKAABHLHGO(IReadOnlyList<int> PGLOBJMILJF, [Optional] CancellationToken KANPDHELHMD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class EFAAFGAFGDG
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class HJBAOAEPDKA : NAHLGPBFOKN, IEquatable<NAHLGPBFOKN>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct BCBHMIBBGDC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<OECPMONDBOC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public HJBAOAEPDKA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private DNOECDKDHOC <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<GGLDCNABNOB> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<OECPMONDBOC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x681E2D0", Offset = "0x681D0D0", VA = "0x18681E2D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x681E770", Offset = "0x681D570", VA = "0x18681E770", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly BHFFEFMOLAM FMAACADHBNG;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int NPMBKHHBEAM
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7AE670", Offset = "0x7AD470", VA = "0x1807AE670", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public LLLDMNIJMMO EABCAFHFHCI
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime EJJCABKHHKI
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x54BB980", Offset = "0x54BA780", VA = "0x1854BB980", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public AMEEKGGICDG? JCPBKDPPNBB
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1A3C1F0", Offset = "0x1A3AFF0", VA = "0x181A3C1F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public KMEFIMFCBBL? ONLKOAHIPDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x54BBA60", Offset = "0x54BA860", VA = "0x1854BBA60", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public APDLIKACNHL LCMDMKFDACB
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x874150", Offset = "0x872F50", VA = "0x180874150", Slot = "10")]
			get
			{
				return default(APDLIKACNHL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6829C60", Offset = "0x6828A60", VA = "0x186829C60", Slot = "9")]
		[AsyncStateMachine(typeof(BCBHMIBBGDC))]
		public Task<OECPMONDBOC> CMGLJEAOGED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6829F50", Offset = "0x6828D50", VA = "0x186829F50")]
		public HJBAOAEPDKA(int KJFBGACJGAI, LLLDMNIJMMO IHJGGHEBJDP, BHFFEFMOLAM FMAACADHBNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6829E00", Offset = "0x6828C00", VA = "0x186829E00", Slot = "11")]
		public bool Equals(NAHLGPBFOKN GGINNHLAMLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6829D60", Offset = "0x6828B60", VA = "0x186829D60", Slot = "0")]
		public override bool Equals(object EIFMADKIHON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6829F10", Offset = "0x6828D10", VA = "0x186829F10")]
		private bool LNDPOICBAGP(HJBAOAEPDKA GGINNHLAMLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6829E90", Offset = "0x6828C90", VA = "0x186829E90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class CLBDCABGKCI : NAHLGPBFOKN, IEquatable<NAHLGPBFOKN>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct ANGGLNJBEGB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<OECPMONDBOC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public CLBDCABGKCI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<OECPMONDBOC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x681D2B0", Offset = "0x681C0B0", VA = "0x18681D2B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x681D4E0", Offset = "0x681C2E0", VA = "0x18681D4E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly GAIIFIKOGEE KPPAFFNEBKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly AMEEKGGICDG BHHEKAJHHKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly KMEFIMFCBBL BLIGKGBDMEA;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int NPMBKHHBEAM
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x681F930", Offset = "0x681E730", VA = "0x18681F930", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LLLDMNIJMMO EABCAFHFHCI
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x681FC80", Offset = "0x681EA80", VA = "0x18681FC80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime EJJCABKHHKI
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x681FBB0", Offset = "0x681E9B0", VA = "0x18681FBB0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AMEEKGGICDG? JCPBKDPPNBB
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x681FD70", Offset = "0x681EB70", VA = "0x18681FD70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public KMEFIMFCBBL? ONLKOAHIPDG
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x681F8E0", Offset = "0x681E6E0", VA = "0x18681F8E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public APDLIKACNHL LCMDMKFDACB
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x900CB0", Offset = "0x8FFAB0", VA = "0x180900CB0", Slot = "10")]
			get
			{
				return default(APDLIKACNHL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xEE32E0", Offset = "0xEE20E0", VA = "0x180EE32E0")]
		public CLBDCABGKCI(GAIIFIKOGEE OCFMBNHGGCK, AMEEKGGICDG HLAGFEOKDCA, KMEFIMFCBBL BGGGOIABLPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x681F970", Offset = "0x681E770", VA = "0x18681F970", Slot = "9")]
		[AsyncStateMachine(typeof(ANGGLNJBEGB))]
		public Task<OECPMONDBOC> CMGLJEAOGED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x681FB10", Offset = "0x681E910", VA = "0x18681FB10", Slot = "11")]
		public bool Equals(NAHLGPBFOKN GGINNHLAMLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x681FA60", Offset = "0x681E860", VA = "0x18681FA60", Slot = "0")]
		public override bool Equals(object EIFMADKIHON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x681FD10", Offset = "0x681EB10", VA = "0x18681FD10")]
		private bool LNDPOICBAGP(CLBDCABGKCI GGINNHLAMLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x681FC00", Offset = "0x681EA00", VA = "0x18681FC00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class PBGKDBKMCPC : NAHLGPBFOKN, IEquatable<NAHLGPBFOKN>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct MDEKDMLKFMH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<OECPMONDBOC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<OECPMONDBOC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6834940", Offset = "0x6833740", VA = "0x186834940", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6834B80", Offset = "0x6833980", VA = "0x186834B80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly LLLDMNIJMMO AIOHEIGNFMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly AMEEKGGICDG BHHEKAJHHKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly KMEFIMFCBBL BLIGKGBDMEA;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int NPMBKHHBEAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x683A800", Offset = "0x6839600", VA = "0x18683A800", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public LLLDMNIJMMO EABCAFHFHCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime EJJCABKHHKI
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public AMEEKGGICDG? JCPBKDPPNBB
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x683AC90", Offset = "0x6839A90", VA = "0x18683AC90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public KMEFIMFCBBL? ONLKOAHIPDG
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x683A7B0", Offset = "0x68395B0", VA = "0x18683A7B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public APDLIKACNHL LCMDMKFDACB
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "10")]
			get
			{
				return default(APDLIKACNHL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xEE32E0", Offset = "0xEE20E0", VA = "0x180EE32E0")]
		public PBGKDBKMCPC(LLLDMNIJMMO IHJGGHEBJDP, AMEEKGGICDG HLAGFEOKDCA, KMEFIMFCBBL BGGGOIABLPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x683A820", Offset = "0x6839620", VA = "0x18683A820", Slot = "9")]
		[AsyncStateMachine(typeof(MDEKDMLKFMH))]
		public Task<OECPMONDBOC> CMGLJEAOGED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x683AA10", Offset = "0x6839810", VA = "0x18683AA10", Slot = "11")]
		public bool Equals(NAHLGPBFOKN GGINNHLAMLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x683A8F0", Offset = "0x68396F0", VA = "0x18683A8F0", Slot = "0")]
		public override bool Equals(object EIFMADKIHON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x683AB20", Offset = "0x6839920", VA = "0x18683AB20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x683ABB0", Offset = "0x68399B0", VA = "0x18683ABB0")]
		private bool LNDPOICBAGP(PBGKDBKMCPC GGINNHLAMLI)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct HIGPJCFGGCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<NAHLGPBFOKN>> <>t__builder;

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
		public EFAAFGAFGDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<BHFFEFMOLAM> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<BHFFEFMOLAM>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, LLLDMNIJMMO account, BHFFEFMOLAM roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6828D60", Offset = "0x6827B60", VA = "0x186828D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6829BF0", Offset = "0x68289F0", VA = "0x186829BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct LGDLEBPBGLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, LLLDMNIJMMO account, BHFFEFMOLAM roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<BHFFEFMOLAM> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public EFAAFGAFGDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<LLLDMNIJMMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x68331D0", Offset = "0x6831FD0", VA = "0x1868331D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6833B70", Offset = "0x6832970", VA = "0x186833B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly LHLPICHLENL BJNCADCKJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly JPKKEHBHLLP AFPGAMJHMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly BOJOLBFIKDD OCFMAGIDGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly EMHJELMEIHN<(long, long), IReadOnlyList<BHFFEFMOLAM>> FHMKEHGGCAA;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6821830", Offset = "0x6820630", VA = "0x186821830")]
	[UnityEngine.Scripting.Preserve]
	public EFAAFGAFGDG([PENMPEOFMMN(null)] JPKKEHBHLLP IAGBFCMFCFA, [PENMPEOFMMN(null)] BOJOLBFIKDD IPLEPKEMGAB, [PENMPEOFMMN(null)] LHLPICHLENL OPPOCEOIOGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x68216E0", Offset = "0x68204E0", VA = "0x1868216E0")]
	[AsyncStateMachine(typeof(HIGPJCFGGCA))]
	public Task<IList<NAHLGPBFOKN>> PCMJHEOBNLN(long EKMDOMOGGBC, long EEFFKLADGPB, bool LNDLIJHACKP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6821430", Offset = "0x6820230", VA = "0x186821430")]
	private bool BLNDNPOAHCK(DateTime? BIJEAEIHDKC, long EKMDOMOGGBC, long EEFFKLADGPB, [Out] GAIIFIKOGEE OHKLPLEDHBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x68215D0", Offset = "0x68203D0", VA = "0x1868215D0")]
	[AsyncStateMachine(typeof(LGDLEBPBGLC))]
	private Task<IReadOnlyList<(int, LLLDMNIJMMO, BHFFEFMOLAM)>> LEKCFMPGAPF(IReadOnlyList<BHFFEFMOLAM> PIONJJIEEEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BOJOLBFIKDD
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<GAIIFIKOGEE> CFAMEKKPKNP;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PMKPBCJFFFE(long EKMDOMOGGBC, long EEFFKLADGPB, MEHGPBKCCCN CDMEONEAOGC, ACEMKOMODMN LKDJIBAIBLB);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NABKOFDIDIJ(long EKMDOMOGGBC, long EEFFKLADGPB, [Out] GAIIFIKOGEE OHKLPLEDHBI);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JOFCLAIHGJO(long EKMDOMOGGBC, long EEFFKLADGPB, ACEMKOMODMN LKDJIBAIBLB, [Out] GAIIFIKOGEE OHKLPLEDHBI);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EAMOMEACOJD(long EKMDOMOGGBC, long EEFFKLADGPB);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface PGJJGJOGAKN : LNHBAHDCKCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool JKOLDBBFCGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task EMLHDCHHFID
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PFLNLBEIGOF(Task JKCFEOGKFBB, string LMMNIKIDMEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface IEPFAOPCMJP : LNHBAHDCKCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OECPMONDBOC> AIEMMJAMLIP(GAIIFIKOGEE OHKLPLEDHBI);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CBGOHFAOBMK(CancellationToken KANPDHELHMD);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface ACJPHMIEAOG : LNHBAHDCKCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	BJDCNDLDLFM LAJCHLEMLDM
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HNPODANDCJN();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ECMBBGKDFEE();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface LNHBAHDCKCE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBPIHILNAPB(KIAEAACOCKM CPCGINCDIDM);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface OHFKCALEDIM
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan NIGDCDJGNND
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan LMLKCOLPLHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan OCJHCBBHAKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan HGECJDGOIFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool BPEKCADIJCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool LNBGLAPNIOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool PIKDHOHNNJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int IOAMDLMDAHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool GPEGMHEKMGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool EJDFLDIFJMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum DHBFJFKLBGO
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum GCPKBMBFOIH
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
public struct PBCDELOMGHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long JGAFAAHDFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long LCDEHGNNMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly DHBFJFKLBGO DDEINLAGLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception LFHODPMMEDA;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x683A740", Offset = "0x6839540", VA = "0x18683A740")]
	public PBCDELOMGHD(long JGAFAAHDFNL, long LCDEHGNNMHO, DHBFJFKLBGO DDEINLAGLLL, [CanBeNull] Exception LFHODPMMEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x683A6F0", Offset = "0x68394F0", VA = "0x18683A6F0")]
	public static PBCDELOMGHD LMFLNJNPHGE(OCJDEGLDIGA MLBJDJNHJCC, DHBFJFKLBGO DDEINLAGLLL, [Optional] Exception LFHODPMMEDA)
	{
		return default(PBCDELOMGHD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public delegate void FPLJJKJDEAG(PBCDELOMGHD JBHCDECLMHO);
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface HNIHAFJMCPN : LNHBAHDCKCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action ANFJOIHMELC;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event FPLJJKJDEAG ADHNMPIAGAK;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event FPLJJKJDEAG CNGPLOMKAOP;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event FPLJJKJDEAG CBOHHPJKNKE;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<GCPKBMBFOIH, bool> DACMBFLEJBO;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FLGHKCILGCM();

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GMENPLGKEHG(PBCDELOMGHD JBHCDECLMHO);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EOPHAOJBMFF(PBCDELOMGHD JBHCDECLMHO);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HCGPDJMEJDN(PBCDELOMGHD JBHCDECLMHO);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NDBNLDFNNCP(GCPKBMBFOIH KDMILBNDNEE, bool KINLMAENCJL);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface AMKMLOBCIOL : LNHBAHDCKCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MNHKOKDEIKD();

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LJMKHPANAEJ();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface LCNJANPHKFJ : LNHBAHDCKCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TaskStatus OOENBHOBCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DHIDNFKMLOG(OCJDEGLDIGA LJLKIGBMLBA, KNLLEOKCJHM ECHLNEHAPPP, CancellationToken DHIPGGMBELH);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class PBENEEBLPPN
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x683A760", Offset = "0x6839560", VA = "0x18683A760")]
	public static bool JHKCNLEEOKH(this LCNJANPHKFJ NKGMLFBEFEF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public delegate Task DLNLCOIIFBI(OLDEKHHOPEO EEKNEAJDFKG, CancellationToken ADNDMAGEPOK);
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface CJLBNANOOLK : LNHBAHDCKCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PIBMNOLLOJD(DLNLCOIIFBI NFDIENLGHGE);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface KIAEAACOCKM : DNOECDKDHOC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CancellationToken BAFFJEBAAPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	NAINNGGFMLM HAEBKGMHLHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	BBFGEEDHNOO IKBIGBJEFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	IFMCAPKBIBK BIMCLKEDAMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	PIJDGALKJHE PKCNFGEOGLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	DOANNFDMAAF CJBNCFNJCPE
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	HOEKMBEDHNK FELJPBDAGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	HCDDMOHPJIM ILDOHPHPOJH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	PIILEDCECBM INPGAAOCIHO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	PGJJGJOGAKN CFIPGHLKHPG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	IEPFAOPCMJP ILHILDAJLJH
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	HNIHAFJMCPN BLFHMELIGOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	AMKMLOBCIOL PHGPOEBOEBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	LCNJANPHKFJ PJIHLGLGEIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	CJLBNANOOLK NCNCBBLEIOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	BANJNPEAECO IJKIMJILJJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	ADINMIGPHOJ NDEFNMFJOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	FKICEOCDPKC LBAGHPDODJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	MCPKLEJDHLO OPBNJOEIJOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	EDAMGDNGLNA LBDMJDNDOHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	FIAMPGNHNAE KAGAHHLJEMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	CHFKIEIBFEO PGHFLLNAEIH
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	INBJLHEKHNG JENBBDKDOEL
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	EHJHFNJGDIP CGNGMDPECFI
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	BGNKLOPIMKB APHPJMLHICF
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	ACJPHMIEAOG FCBGEPOBDDI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	OHFKCALEDIM LLLJHFDDMHD
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	DHEKBMONMEK KLLJGOJFFBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	BOJOLBFIKDD HJJHCDMPPOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	JFFFPNKIDJH IFLPAACNAHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	GMKIHJDJHAK PEEMEDDBCNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	FDIIECAHINA MJKEDFCKMHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void ABFEDPAJNFG(KNLLEOKCJHM BODGIBNIJPN);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface BANJNPEAECO : LNHBAHDCKCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OJIAEEMNBEF HDCMKJKDALC(Guid GJAFHBAGEBC);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BOIJHFOIOPE(Guid GJAFHBAGEBC);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JLGONOALHMG(Guid GJAFHBAGEBC, Task IMFCHEPCJKA);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FJKJKFOMOGC(Guid GJAFHBAGEBC, OECPMONDBOC OBGONBOBDON);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(OECPMONDBOC, Task)> KNMFJHCMLMG(Guid GJAFHBAGEBC);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface BIFIKJAOKAA : LNHBAHDCKCE, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface ADINMIGPHOJ : LNHBAHDCKCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANLFDLCMLHD(LDPKGMHDMGO HPJAAILCALJ);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BHPHBOCPKDM(LDPKGMHDMGO HPJAAILCALJ);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<LJHFIKGIIKE> DBPLODANKPK(CancellationToken OBLFHBKHNIE);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface FKICEOCDPKC : LNHBAHDCKCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OJIAEEMNBEF KFGHEOHFBLE(LDPKGMHDMGO BGNKDFCMKKC);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PIJAFGHDPDE(Guid GJAFHBAGEBC, Task IMFCHEPCJKA);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface MCPKLEJDHLO : LNHBAHDCKCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OECPMONDBOC> OPBNJOEIJOK(LDPKGMHDMGO JPEHPPABONL);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface EDAMGDNGLNA : LNHBAHDCKCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LLMIKIIPGIJ> OFLPEOLDJHE(DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, OCJDEGLDIGA LJLKIGBMLBA, CancellationToken KANPDHELHMD);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface CHFKIEIBFEO : LNHBAHDCKCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OECPMONDBOC MKCOIPGGABN(CMFDBPHCNJN BMFJLMEFDLM);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KAIOALCAPML(string CCKBKBLBNND);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface FIAMPGNHNAE : LNHBAHDCKCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LDPKGMHDMGO> EHNEHNPMHON(LDPKGMHDMGO AIAKOJMKOGA, AGPIMNGHJGG JOBJABEIAGA, CancellationToken KANPDHELHMD);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<LDPKGMHDMGO> PMCKEDLEPCH(CancellationToken KANPDHELHMD, AGPIMNGHJGG JOBJABEIAGA);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CANPFPNADBJ IFPGJLAJEBG(BOEKIHBNIFD JDPAFOHCKCL, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CANPFPNADBJ PBOGNJJHNDL(BOEKIHBNIFD JDPAFOHCKCL, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface INBJLHEKHNG : LNHBAHDCKCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OECPMONDBOC LPDAFLPIEAL(CMFDBPHCNJN BMFJLMEFDLM, LJHFIKGIIKE HMDFOAIFOKF);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OECPMONDBOC CLLAMLIKOBG(CMFDBPHCNJN JKJGLHFMMLO);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface EHJHFNJGDIP
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NCIINJKLPIB(FOMPOOOMAEN MBOMIDHGMHO);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GFNAONHFEJD(FOMPOOOMAEN MBOMIDHGMHO);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KLICABIDEFF(FOMPOOOMAEN MBOMIDHGMHO);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AAFMFKGGDKI(FOMPOOOMAEN MBOMIDHGMHO);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class FOMPOOOMAEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly OCJDEGLDIGA AFAOJLIFBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> KKPCJIHPNEF;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public DIMFGGHDEDI<string> NDLOEEMPJPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7B1940", Offset = "0x7B0740", VA = "0x1807B1940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B0AB0", VA = "0x1807B1CB0")]
	public FOMPOOOMAEN(OCJDEGLDIGA OMOAKIOOHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6824010", Offset = "0x6822E10", VA = "0x186824010")]
	public FOMPOOOMAEN IJBMKMHOMGN(string OBPLDLNDJLE, string DIBNBLEEFNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x68240E0", Offset = "0x6822EE0", VA = "0x1868240E0")]
	public bool JPHNLMIJKBP([Out] IEnumerable<KeyValuePair<string, string>> ELKBJMJEPHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5B466F0", Offset = "0x5B454F0", VA = "0x185B466F0")]
	public FOMPOOOMAEN BCNKHDEPDGA(DIMFGGHDEDI<string> DPOENBOPPGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface DHEKBMONMEK
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool MJGJMJPPPLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	string GMKCFCKGBMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool FIECLMOLIEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NCBPOKMKGPB();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GKGMGJLKJEB NAKFLFFDLLD(long KOBEPCIBNJP);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LMKLEKPDHNC<PLDLJCNGAPD, KDCMAGFKGCK> PCGKNEJCPHE(long KOBEPCIBNJP);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LMKLEKPDHNC<PLDLJCNGAPD, CCLFGPLFGKK> FJMKJCMFGPB(long KOBEPCIBNJP);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LMKLEKPDHNC<long, JDGGJOGFMEL> PIGJAFIOIIC();

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EKABJHKAGKI(long KOBEPCIBNJP, [Out] bool EEKLHGHPAMF);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> ACDCHFHNNLG(byte[] ALLJPLNAGKO, byte[] MOCIDOBECLP, CancellationToken KANPDHELHMD);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface DNOECDKDHOC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool JHKCNLEEOKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool CBPHHKFAGFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	KNLLEOKCJHM JBBALBKNOED
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action ANFJOIHMELC;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event FPLJJKJDEAG ADHNMPIAGAK;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event FPLJJKJDEAG CNGPLOMKAOP;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event FPLJJKJDEAG CBOHHPJKNKE;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<GCPKBMBFOIH, bool> DACMBFLEJBO;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LJMKHPANAEJ();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	EGPNOKONMCA EPECGEHFOLG();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	DOOFFMNBFII DCLFFDIJNIK();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<OECPMONDBOC> AIEMMJAMLIP(GAIIFIKOGEE OCFMBNHGGCK);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task CBGOHFAOBMK(CancellationToken KANPDHELHMD);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface DOANNFDMAAF
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool KEPIHLMJFJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string PLIKOIDKDCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBPEDJBFLKO(Scene DMIIMHOIFBH);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task KJKENPPEPJK(BLCBLPPLECJ DGDKJKLCLOE, CancellationToken KANPDHELHMD);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task PAHLLILLFKL();

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task FKFHGPLMCPM();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface PIJDGALKJHE
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	PAICLNCIIMP FABCENIMEEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool FDKIEJAPDHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool LBBMHECCMGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool NBGLCACKPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool FOPKLEPDFKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	int FEFDFMCJIPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool KHGLODEHEOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool PPOCKJMGKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool PLPNGOFDPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	float HNCGOINKIAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> CHDIGKCIALG;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NAINNGGFMLM ELDOACNEDPO(NAINNGGFMLM NCOAFEMCDOP);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JHBKHLPNLPI(NAINNGGFMLM COEPBABOGAM);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LGHGNLMIPPF();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task IMCEGBHAJAI(DIMFGGHDEDI<string>.NJDBOGMFDFJ JCFJFIPEMMI, CancellationToken KANPDHELHMD);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void INCEELJHKDG(float OEDPFJODJIM);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void COLFJBLCMFB(string HMNIBMPKHAC);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<IJFHPKHOLLG> MEDAIGGEPFN();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable MFMHLPIGKNN(object EJDIFPAIGMC, IJFHPKHOLLG MDGGHFOMEDJ);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KDCMAGFKGCK GODPDGBOIBM(IEnumerable<DOPOCMMEPIO> HLJCAFKFBJI);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CDCFHMOEFGD(int DEBOKPNAGFI);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task OGIGACJDNFJ();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HBICOHEGDPJ();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool KHCGEMEOKJD();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task JHJLJMFDNOB(CancellationToken KANPDHELHMD);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task JCAEGHPDNOM(CancellationToken KANPDHELHMD);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<AONMJCOEIHI> KLEKEAMCHBK(DateTime MOCAHHMFHKP, CancellationToken KANPDHELHMD);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<bool> ACPGPDNOMLM(CancellationToken KANPDHELHMD);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void MDLGBIFGCHA(string HPJAAILCALJ = "", float GAPIMALKIHE = 3f);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "24")]
	AIJJFMGMGOD FLEMNOCAIDA(MAHEKPHEIFA CJENGHADNMC, MPENOININPH GFKKIHICKLH, CCLFGPLFGKK LFJBCNDLOGO, IEnumerable<PersistenceView> CDFNDFLOFGG, KLEKDAMEDMN GCCCGIENACK);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void CBHDLMBCLOP(CCLFGPLFGKK LFJBCNDLOGO);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void IMDLMKOFCFH(DOPOCMMEPIO NGOHHJIGFPK, [In] AIJJFMGMGOD NKICMCMFAIB);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task IFFLAFAKFFL(CCLFGPLFGKK FPNINNJGGGP, bool GNFLBMIHEEL, CancellationToken KANPDHELHMD);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task BNINONGCFHD(CancellationToken KANPDHELHMD);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void JAIPLMABMGB(long EKMDOMOGGBC, long LCDEHGNNMHO, GGLDCNABNOB ADBAADHGFJH, BHFFEFMOLAM HJHHFJEAGMP, MEHGPBKCCCN CDMEONEAOGC, DDAACBOALJE? KEGBFOEHEOI, HCNEBGIHOKG? DHPCNKIGKGM);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void GNMNFBJJGLB(long EKMDOMOGGBC, long LCDEHGNNMHO, HCNEBGIHOKG? DHPCNKIGKGM);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void IPMHNEMONJP(PersistenceView JADIBEIICDP);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool MDHPPCHHLEE(PersistenceView EJDIPDNLCEK);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool FEKAHHJGKIM(DOPOCMMEPIO NGOHHJIGFPK, HLHGHFGIPAC DMPLLLPADHC, [Out] IEAONBGGGDD OHIJGHMPHGA);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task JOEMEAMEEKH(CancellationToken KANPDHELHMD);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void IPFJIHOBKGD();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "36")]
	IDisposable LMPMJNNDLJE();

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void BIACOBGOBAH(CCLFGPLFGKK FPNINNJGGGP, HLHGHFGIPAC DMPLLLPADHC);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<bool> GMPINAFGAHE(BBFGEEDHNOO JLJLCJEJIMH, CancellationToken KANPDHELHMD, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void EAONIGLCDCM(CancellationToken KANPDHELHMD);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<JCEJPJKGHOG> HDOCJCFNNFM(GBJELOBDELK AIAKOJMKOGA);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<GGLDCNABNOB> MDGPGOFCPBK(long EKMDOMOGGBC, bool CFBOKMICDJF, CancellationToken KANPDHELHMD);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<BHFFEFMOLAM> GAMCKJPOCKE(long EKMDOMOGGBC, long LCDEHGNNMHO, long KIBPONOCMID, CancellationToken KANPDHELHMD);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<AFHGGNKAGMJ> MIPNPPFOBDI(string NMGHGLDODNE, CancellationToken KANPDHELHMD);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<AFHGGNKAGMJ> ODLOHBAFPCG(string NMGHGLDODNE, long EKMDOMOGGBC, long LCDEHGNNMHO, string EKOKIJAKHED, NMEELHLCCAH.AENCKPECJMJ EEKNEAJDFKG, NMEELHLCCAH.AENCKPECJMJ MOCIDOBECLP, int IHONMAEKGNO);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool HAJMKMCKGBF();

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool IAKGBINAJAI();

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool LNCGIMGAMCM(IEnumerable<IEAONBGGGDD> HCEOHJBPEBA);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void LNALKJEAOLG(List<GameObject> PCJEBMIDHHM);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "50")]
	float ECBJDDGDKEP();

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "51")]
	Task<Scene> GBDNFLEIAJO(string ONFIFMPHJHJ, LoadSceneMode CCOBMJBNHFA, bool FHFALKBLLEO, DIMFGGHDEDI<string>.NJDBOGMFDFJ DPOENBOPPGM);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void POIHANBDJHF();

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void PFKHKEDBBND(bool CDHMHHFKHDG);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void JPCGMADGMNH(OCJDEGLDIGA OLCNHBKKMNM);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "60")]
	Task LILCFHPPHJC(DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "61")]
	Task EJMEKCFBMDK(DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "62")]
	Task KOOELGPOGLG(DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "63")]
	IDisposable PMAPDHNIPLE();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "64")]
	FFILBAPELNN BDJNEFBKBNA();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "65")]
	Task NGDBJOFINCD(CancellationToken KANPDHELHMD);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface FFILBAPELNN
{
	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task COBDNILJECE(CancellationToken KANPDHELHMD);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MCAJHOGLFFI(CancellationToken KANPDHELHMD);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct AIJJFMGMGOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> PPBMDKAIPOM;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum AONMJCOEIHI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct MAHEKPHEIFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string EFCPABFKMCK;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface PAICLNCIIMP
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	OCJDEGLDIGA EGMJBHCANAD
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	GGLDCNABNOB NDGMDEFAAJB
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	DEONINFIMOK BOINBIELPHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool BBDHMCIOEEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool GCHEPGMJFGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	int ALBLLCJCFEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action PLENKLBKJBE;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> MOEHFJOAILO;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FLMFPONABHE();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.JHHEDPHAMGD> MICAHKADEAN(long KOBEPCIBNJP, [Optional] CancellationToken KANPDHELHMD);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<NCLBHIPALEM> DHIJFDOFDDI();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task NPODJGMOJMJ();

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(OCJDEGLDIGA, KNLLEOKCJHM) NENPNEKEIPN();

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "15")]
	GAEAKKKNDMC MBPFJFNBGGN();

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PDKCIKHDFJK(long KOBEPCIBNJP);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface BGNKLOPIMKB
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FLPHHBLHHJF([Out] IEnumerable<int> NKBFJPMJAEI);

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DCKNLBJEHCM(NNMEDCEFICD ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BAIEOLJIDHO(NNMEDCEFICD ADNDMAGEPOK);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface EEFHMPIDNEP
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LOBLHMALBOG(OECPMONDBOC DOFILCPHLKP);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface GINKKBDFNJC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HDADJGFHPLJ(IHBACOKMKNI.DGDECEAIMGN FAJJBDPLKIK);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JHNBPNGIOLG(IHBACOKMKNI.DGDECEAIMGN FAJJBDPLKIK);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface HOEKMBEDHNK : GINKKBDFNJC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OECPMONDBOC GGADNKDFKEJ(CMFDBPHCNJN JKJGLHFMMLO);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface HCDDMOHPJIM : GINKKBDFNJC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OECPMONDBOC MKCOIPGGABN(CMFDBPHCNJN CIJPLICOMPO);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface GKGMGJLKJEB
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PJPNKGNAEHO<BLCBLPPLECJ, PCJEOFJNKHC>> KJAMLLEOEBD(string EKOKIJAKHED, long KOBEPCIBNJP, long? EKMDOMOGGBC, long? LCDEHGNNMHO, OIKFLJHMPGM.IPOBIDMEEFE NEDHPPFFPGE, CancellationToken KANPDHELHMD);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface LMKLEKPDHNC<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PJPNKGNAEHO<BLCPLJPDMPC<TData>, PCJEOFJNKHC>> ECNHGLIKHGC(TGetDataArg PNJHNPALLNI, CancellationToken KANPDHELHMD);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class JPONGNPPDEA : KIAEAACOCKM, DNOECDKDHOC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct JECCBFDHPKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder<OECPMONDBOC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public JPONGNPPDEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public GAIIFIKOGEE autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<OECPMONDBOC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x6830920", Offset = "0x682F720", VA = "0x186830920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6830BA0", Offset = "0x682F9A0", VA = "0x186830BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct APOIFNOMIJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public JPONGNPPDEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x681E040", Offset = "0x681CE40", VA = "0x18681E040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x681E270", Offset = "0x681D070", VA = "0x18681E270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class OKPHPJGILCI : IEnumerable<LNHBAHDCKCE>, IEnumerable, IEnumerator<LNHBAHDCKCE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private LNHBAHDCKCE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public JPONGNPPDEA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		private LNHBAHDCKCE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x802B10", Offset = "0x801910", VA = "0x180802B10")]
		[DebuggerHidden]
		public OKPHPJGILCI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x683A240", Offset = "0x6839040", VA = "0x18683A240", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x683A6A0", Offset = "0x68394A0", VA = "0x18683A6A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x683A5F0", Offset = "0x68393F0", VA = "0x18683A5F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LNHBAHDCKCE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x683A5F0", Offset = "0x68393F0", VA = "0x18683A5F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource KOCLMJEDLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly NAINNGGFMLM COEPBABOGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool COIBHEFKPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private KDHMLKEKHIF EKMMHHDJFEF;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public BBFGEEDHNOO IKBIGBJEFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7AE540", Offset = "0x7AD340", VA = "0x1807AE540", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7AE520", Offset = "0x7AD320", VA = "0x1807AE520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public IFMCAPKBIBK BIMCLKEDAMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7B5870", Offset = "0x7B4670", VA = "0x1807B5870", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7B5880", Offset = "0x7B4680", VA = "0x1807B5880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public PIJDGALKJHE PKCNFGEOGLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7B5850", Offset = "0x7B4650", VA = "0x1807B5850", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7B5860", Offset = "0x7B4660", VA = "0x1807B5860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public DOANNFDMAAF CJBNCFNJCPE
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7B5840", Offset = "0x7B4640", VA = "0x1807B5840", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7B5890", Offset = "0x7B4690", VA = "0x1807B5890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public HOEKMBEDHNK FELJPBDAGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7B7050", Offset = "0x7B5E50", VA = "0x1807B7050", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7B7060", Offset = "0x7B5E60", VA = "0x1807B7060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public HCDDMOHPJIM ILDOHPHPOJH
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7B7070", Offset = "0x7B5E70", VA = "0x1807B7070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public PIILEDCECBM INPGAAOCIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7AE530", Offset = "0x7AD330", VA = "0x1807AE530", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7AE5D0", Offset = "0x7AD3D0", VA = "0x1807AE5D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public PGJJGJOGAKN CFIPGHLKHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7AE4C0", Offset = "0x7AD2C0", VA = "0x1807AE4C0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7AE4B0", Offset = "0x7AD2B0", VA = "0x1807AE4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public IEPFAOPCMJP ILHILDAJLJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7AE680", Offset = "0x7AD480", VA = "0x1807AE680", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7AE560", Offset = "0x7AD360", VA = "0x1807AE560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public HNIHAFJMCPN BLFHMELIGOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x98BA90", Offset = "0x98A890", VA = "0x18098BA90", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x98BB70", Offset = "0x98A970", VA = "0x18098BB70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public AMKMLOBCIOL PHGPOEBOEBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7AE5B0", Offset = "0x7AD3B0", VA = "0x1807AE5B0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7AE4D0", Offset = "0x7AD2D0", VA = "0x1807AE4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public LCNJANPHKFJ PJIHLGLGEIF
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x879BF0", Offset = "0x8789F0", VA = "0x180879BF0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x879D10", Offset = "0x878B10", VA = "0x180879D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public CJLBNANOOLK NCNCBBLEIOP
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7BB630", Offset = "0x7BA430", VA = "0x1807BB630", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7BB680", Offset = "0x7BA480", VA = "0x1807BB680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public BANJNPEAECO IJKIMJILJJK
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA14410", Offset = "0xA13210", VA = "0x180A14410", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xA1CCF0", Offset = "0xA1BAF0", VA = "0x180A1CCF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public BIFIKJAOKAA FNFJKCLKJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x95C0D0", Offset = "0x95AED0", VA = "0x18095C0D0", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x95C0E0", Offset = "0x95AEE0", VA = "0x18095C0E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public ADINMIGPHOJ NDEFNMFJOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9A6110", Offset = "0x9A4F10", VA = "0x1809A6110", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA1CCB0", Offset = "0xA1BAB0", VA = "0x180A1CCB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public FKICEOCDPKC LBAGHPDODJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8CF3D0", Offset = "0x8CE1D0", VA = "0x1808CF3D0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA1CD30", Offset = "0xA1BB30", VA = "0x180A1CD30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public MCPKLEJDHLO OPBNJOEIJOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8FEB50", Offset = "0x8FD950", VA = "0x1808FEB50", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x97E240", Offset = "0x97D040", VA = "0x18097E240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public EDAMGDNGLNA LBDMJDNDOHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7BB620", Offset = "0x7BA420", VA = "0x1807BB620", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7BB6A0", Offset = "0x7BA4A0", VA = "0x1807BB6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public FIAMPGNHNAE KAGAHHLJEMA
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8811E0", Offset = "0x87FFE0", VA = "0x1808811E0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x87DA30", Offset = "0x87C830", VA = "0x18087DA30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public CHFKIEIBFEO PGHFLLNAEIH
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8D6190", Offset = "0x8D4F90", VA = "0x1808D6190", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8D61B0", Offset = "0x8D4FB0", VA = "0x1808D61B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public INBJLHEKHNG JENBBDKDOEL
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8FE9E0", Offset = "0x8FD7E0", VA = "0x1808FE9E0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA1CD10", Offset = "0xA1BB10", VA = "0x180A1CD10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public EHJHFNJGDIP CGNGMDPECFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x881290", Offset = "0x880090", VA = "0x180881290", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x87C600", Offset = "0x87B400", VA = "0x18087C600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public BGNKLOPIMKB APHPJMLHICF
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8FE980", Offset = "0x8FD780", VA = "0x1808FE980", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA1CCD0", Offset = "0xA1BAD0", VA = "0x180A1CCD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public ACJPHMIEAOG FCBGEPOBDDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9A5250", Offset = "0x9A4050", VA = "0x1809A5250", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA1CED0", Offset = "0xA1BCD0", VA = "0x180A1CED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public OHFKCALEDIM LLLJHFDDMHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8EC200", Offset = "0x8EB000", VA = "0x1808EC200", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA1CEB0", Offset = "0xA1BCB0", VA = "0x180A1CEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public DHEKBMONMEK KLLJGOJFFBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x85CF70", Offset = "0x85BD70", VA = "0x18085CF70", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA1CE10", Offset = "0xA1BC10", VA = "0x180A1CE10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public BOJOLBFIKDD HJJHCDMPPOB
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x97E120", Offset = "0x97CF20", VA = "0x18097E120", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public JFFFPNKIDJH IFLPAACNAHC
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8EC220", Offset = "0x8EB020", VA = "0x1808EC220", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public GMKIHJDJHAK PEEMEDDBCNI
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8EC210", Offset = "0x8EB010", VA = "0x1808EC210", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public FDIIECAHINA MJKEDFCKMHN
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9A4E60", Offset = "0x9A3C60", VA = "0x1809A4E60", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public KNLLEOKCJHM JBBALBKNOED
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9A5360", Offset = "0x9A4160", VA = "0x1809A5360", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x998DE0", Offset = "0x997BE0", VA = "0x180998DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	private bool JALLODLAGJE
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6830D70", Offset = "0x682FB70", VA = "0x186830D70", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	private bool GMAKKMPCILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6831520", Offset = "0x6830320", VA = "0x186831520", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private CancellationToken DOIAGEPCBFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6831110", Offset = "0x682FF10", VA = "0x186831110", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	private NAINNGGFMLM DIDNHMLHJNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action HELHBOMNAEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x68313A0", Offset = "0x68301A0", VA = "0x1868313A0", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6831050", Offset = "0x682FE50", VA = "0x186831050", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event FPLJJKJDEAG CAHCBLCHFOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6831680", Offset = "0x6830480", VA = "0x186831680", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6830E60", Offset = "0x682FC60", VA = "0x186830E60", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event FPLJJKJDEAG HDOJGPHEJAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6831230", Offset = "0x6830030", VA = "0x186831230", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6831460", Offset = "0x6830260", VA = "0x186831460", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event FPLJJKJDEAG FGLBALHJPPB
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x68315A0", Offset = "0x68303A0", VA = "0x1868315A0", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x68310B0", Offset = "0x682FEB0", VA = "0x1868310B0", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<GCPKBMBFOIH, bool> HJLKHPGFDNF
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6831400", Offset = "0x6830200", VA = "0x186831400", Slot = "45")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6830D10", Offset = "0x682FB10", VA = "0x186830D10", Slot = "46")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x998DE0", Offset = "0x997BE0", VA = "0x180998DE0", Slot = "36")]
	public void ABFEDPAJNFG(KNLLEOKCJHM BODGIBNIJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x68317D0", Offset = "0x68305D0", VA = "0x1868317D0")]
	[UnityEngine.Scripting.Preserve]
	internal JPONGNPPDEA([PENMPEOFMMN(null)] NAINNGGFMLM COEPBABOGAM, [PENMPEOFMMN(null)] BBFGEEDHNOO JLJLCJEJIMH, [PENMPEOFMMN(null)] IFMCAPKBIBK HBBMHEHIHJL, [PENMPEOFMMN(null)] PIJDGALKJHE EEEILKJFPBG, [PENMPEOFMMN(null)] DOANNFDMAAF PDDEHBMLKDC, [PENMPEOFMMN(null)] HOEKMBEDHNK BMCPCKOPBKN, [PENMPEOFMMN(null)] HCDDMOHPJIM HHHKDEMNGKP, [PENMPEOFMMN(null)] PIILEDCECBM KPKCBMFEIKA, [PENMPEOFMMN(null)] PGJJGJOGAKN AGMFEENJELA, [PENMPEOFMMN(null)] IEPFAOPCMJP ECIIHPOHGIH, [PENMPEOFMMN(null)] HNIHAFJMCPN NADMMCKECPK, [PENMPEOFMMN(null)] AMKMLOBCIOL HBFFHPKCMEJ, [PENMPEOFMMN(null)] LCNJANPHKFJ NKGMLFBEFEF, [PENMPEOFMMN(null)] CJLBNANOOLK KAHJKGCAPED, [PENMPEOFMMN(null)] BANJNPEAECO JEHIOEKEDCB, [PENMPEOFMMN(null)] BIFIKJAOKAA AAGBNGMBCHJ, [PENMPEOFMMN(null)] ADINMIGPHOJ KNFMCFLANMN, [PENMPEOFMMN(null)] FKICEOCDPKC PAOJILBMAIE, [PENMPEOFMMN(null)] MCPKLEJDHLO BICJGPECIPB, [PENMPEOFMMN(null)] EDAMGDNGLNA KBINNIDGPHI, [PENMPEOFMMN(null)] CHFKIEIBFEO JOHIIABAPMN, [PENMPEOFMMN(null)] FIAMPGNHNAE OBBJCMDEKNK, [PENMPEOFMMN(null)] INBJLHEKHNG GOHEENBOJLG, [PENMPEOFMMN(null)] EHJHFNJGDIP IHOJPBODCPH, [PENMPEOFMMN(null)] BGNKLOPIMKB DICEBECJCLL, [PENMPEOFMMN(null)] OHFKCALEDIM IACOOBGNHEJ, [PENMPEOFMMN(null)] DHEKBMONMEK JOFMIMPDDBH, [PENMPEOFMMN(null)] BOJOLBFIKDD DCPBBEPKAIA, [PENMPEOFMMN(null)] JFFFPNKIDJH IOAANBNLDKH, [PENMPEOFMMN(null)] GMKIHJDJHAK PDCKPDBOAMH, [PENMPEOFMMN(null)] FDIIECAHINA POCGBGLONJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6831130", Offset = "0x682FF30", VA = "0x186831130")]
	private void HBPIHILNAPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6830EC0", Offset = "0x682FCC0", VA = "0x186830EC0", Slot = "55")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x68311E0", Offset = "0x682FFE0", VA = "0x1868311E0", Slot = "49")]
	private void IFMCOPJICPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6830C80", Offset = "0x682FA80", VA = "0x186830C80", Slot = "50")]
	private EGPNOKONMCA ABHFDCLMNEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6830DD0", Offset = "0x682FBD0", VA = "0x186830DD0", Slot = "51")]
	private DOOFFMNBFII CKGNPMCHHHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6831290", Offset = "0x6830090", VA = "0x186831290", Slot = "52")]
	[AsyncStateMachine(typeof(JECCBFDHPKK))]
	private Task<OECPMONDBOC> JFAGMEAOLJK(GAIIFIKOGEE OHKLPLEDHBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x68316E0", Offset = "0x68304E0", VA = "0x1868316E0", Slot = "53")]
	[AsyncStateMachine(typeof(APOIFNOMIJK))]
	private Task PLACDAAPJKH(CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6831600", Offset = "0x6830400", VA = "0x186831600")]
	[IteratorStateMachine(typeof(OKPHPJGILCI))]
	private IEnumerable<LNHBAHDCKCE> OFEDFGMMFME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x68314C0", Offset = "0x68302C0", VA = "0x1868314C0")]
	[CompilerGenerated]
	private void KNGDIICBIFH(LNHBAHDCKCE FFDKILKJFCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class EBLLFEDPELD : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0xD98B40", Offset = "0xD97940", VA = "0x180D98B40")]
	public EBLLFEDPELD(string HPJAAILCALJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal class AANOMMAKOCO : MDHLONPEOGJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct NDFPNNGIFAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AANOMMAKOCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x68358F0", Offset = "0x68346F0", VA = "0x1868358F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6835C30", Offset = "0x6834A30", VA = "0x186835C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly KIAEAACOCKM CPCGINCDIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly PIJDGALKJHE EEEILKJFPBG;

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7B6D90", Offset = "0x7B5B90", VA = "0x1807B6D90")]
	public AANOMMAKOCO(KIAEAACOCKM CPCGINCDIDM, PIJDGALKJHE EEEILKJFPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x681CC30", Offset = "0x681BA30", VA = "0x18681CC30", Slot = "4")]
	[AsyncStateMachine(typeof(NDFPNNGIFAH))]
	public Task<bool> FJOMIGKAAMK(CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x681CB50", Offset = "0x681B950", VA = "0x18681CB50")]
	[CompilerGenerated]
	private object CBNCBPALNBO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class PNFPOPMMBFF : MDHLONPEOGJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct NEECMMCBBKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public PNFPOPMMBFF <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6835CA0", Offset = "0x6834AA0", VA = "0x186835CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x68363B0", Offset = "0x68351B0", VA = "0x1868363B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly KIAEAACOCKM CPCGINCDIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly PIJDGALKJHE EEEILKJFPBG;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private PAICLNCIIMP FABCENIMEEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x683AEF0", Offset = "0x6839CF0", VA = "0x18683AEF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x7B6D90", Offset = "0x7B5B90", VA = "0x1807B6D90")]
	public PNFPOPMMBFF(KIAEAACOCKM CPCGINCDIDM, PIJDGALKJHE EEEILKJFPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x683ADC0", Offset = "0x6839BC0", VA = "0x18683ADC0", Slot = "4")]
	[AsyncStateMachine(typeof(NEECMMCBBKM))]
	public Task<bool> FJOMIGKAAMK(CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x683ACE0", Offset = "0x6839AE0", VA = "0x18683ACE0")]
	[CompilerGenerated]
	private object BOCAOPDMPLM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal class ELHPIJDJONF : MDHLONPEOGJ
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class HLMANNHGJLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public ELHPIJDJONF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public NCLBHIPALEM result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public OCJDEGLDIGA newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public HLMANNHGJLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x682A710", Offset = "0x6829510", VA = "0x18682A710")]
		internal object IDFKEGLJCOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x682A800", Offset = "0x6829600", VA = "0x18682A800")]
		internal object NHFMIEAGFFP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x682A670", Offset = "0x6829470", VA = "0x18682A670")]
		internal object DDLBPJPMGCG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct LLDPPNMCKOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public ELHPIJDJONF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private HLMANNHGJLH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<NCLBHIPALEM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x6833BE0", Offset = "0x68329E0", VA = "0x186833BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x68344F0", Offset = "0x68332F0", VA = "0x1868344F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly KIAEAACOCKM CPCGINCDIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly PIJDGALKJHE EEEILKJFPBG;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private PAICLNCIIMP FABCENIMEEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x6821CB0", Offset = "0x6820AB0", VA = "0x186821CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7B6D90", Offset = "0x7B5B90", VA = "0x1807B6D90")]
	public ELHPIJDJONF(KIAEAACOCKM CPCGINCDIDM, PIJDGALKJHE EEEILKJFPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6821B90", Offset = "0x6820990", VA = "0x186821B90", Slot = "4")]
	[AsyncStateMachine(typeof(LLDPPNMCKOC))]
	public Task<bool> FJOMIGKAAMK(CancellationToken KANPDHELHMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal interface MDHLONPEOGJ
{
	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> FJOMIGKAAMK(CancellationToken KANPDHELHMD);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal struct KLBHKPGOKGI
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class AFDDNCJNHEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public KIAEAACOCKM manager;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public AFDDNCJNHEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x681CD90", Offset = "0x681BB90", VA = "0x18681CD90")]
		internal Task NNFJDELPLLC(OLDEKHHOPEO data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct IFOGFPKEMPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public KLBHKPGOKGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private GAIIFIKOGEE <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<AONMJCOEIHI> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter<OECPMONDBOC> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x682FB50", Offset = "0x682E950", VA = "0x18682FB50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x68300E0", Offset = "0x682EEE0", VA = "0x1868300E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct OCIJJINIKKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public KLBHKPGOKGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6838CA0", Offset = "0x6837AA0", VA = "0x186838CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x6838FC0", Offset = "0x6837DC0", VA = "0x186838FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly CancellationToken KANPDHELHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly KIAEAACOCKM JOMBJDFNECI;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private BBFGEEDHNOO IKBIGBJEFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x68328A0", Offset = "0x68316A0", VA = "0x1868328A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private PIJDGALKJHE PKCNFGEOGLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6832850", Offset = "0x6831650", VA = "0x186832850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private PAICLNCIIMP FABCENIMEEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x68326A0", Offset = "0x68314A0", VA = "0x1868326A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private IEPFAOPCMJP ILHILDAJLJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6832390", Offset = "0x6831190", VA = "0x186832390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x1E32C00", Offset = "0x1E31A00", VA = "0x181E32C00")]
	public KLBHKPGOKGI(CancellationToken KANPDHELHMD, KIAEAACOCKM JOMBJDFNECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x68323E0", Offset = "0x68311E0", VA = "0x1868323E0")]
	public static DLNLCOIIFBI GGHIPDPPFKB(KIAEAACOCKM JOMBJDFNECI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x6832280", Offset = "0x6831080", VA = "0x186832280")]
	[AsyncStateMachine(typeof(IFOGFPKEMPE))]
	public Task<bool> AHOFDHJJGBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x6832490", Offset = "0x6831290", VA = "0x186832490")]
	private bool HBHIJPBKFMK([Out] GAIIFIKOGEE OHKLPLEDHBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x68328F0", Offset = "0x68316F0", VA = "0x1868328F0")]
	[AsyncStateMachine(typeof(OCIJJINIKKH))]
	private Task OEBLHANLBFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x6832720", Offset = "0x6831520", VA = "0x186832720")]
	private Task<AONMJCOEIHI> JJIOEIEABBF(GAIIFIKOGEE DOGDFKBLFEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct OJIAEEMNBEF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly BANJNPEAECO JEHIOEKEDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly Guid GJAFHBAGEBC;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private Task<(OECPMONDBOC, Task)> LNMIECNLLBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6839070", Offset = "0x6837E70", VA = "0x186839070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x3D9F980", Offset = "0x3D9E780", VA = "0x183D9F980")]
	public OJIAEEMNBEF(BANJNPEAECO JEHIOEKEDCB, Guid GJAFHBAGEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6839020", Offset = "0x6837E20", VA = "0x186839020")]
	public TaskAwaiter<(OECPMONDBOC, Task)> AGKNNCIHMJP()
	{
		return default(TaskAwaiter<(OECPMONDBOC, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6839140", Offset = "0x6837F40", VA = "0x186839140", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal struct KBDGAFPPMEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly TaskCompletionSource<(OECPMONDBOC, Task)> OFNKKCGKAAK;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public Task<(OECPMONDBOC, Task)> LNMIECNLLBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6831C30", Offset = "0x6830A30", VA = "0x186831C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6831E80", Offset = "0x6830C80", VA = "0x186831E80")]
	public KBDGAFPPMEL(TimeSpan JODGDKECNNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6831DE0", Offset = "0x6830BE0", VA = "0x186831DE0")]
	public void GEBMCACIBIK(Task IMFCHEPCJKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6831C70", Offset = "0x6830A70", VA = "0x186831C70")]
	public void DBMLMEGMMMK(OECPMONDBOC DOFILCPHLKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6831D90", Offset = "0x6830B90", VA = "0x186831D90")]
	public void EHCDCFGIPAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6831D00", Offset = "0x6830B00", VA = "0x186831D00")]
	internal void DPDPFIIELNJ(string HPJAAILCALJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class FBJDEFCOHJO
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class GOJEGJNDEFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public BHFFEFMOLAM subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public GOJEGJNDEFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6828D30", Offset = "0x6827B30", VA = "0x186828D30")]
		internal bool PDHBOOCHEGP(DEONINFIMOK s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x68227B0", Offset = "0x68215B0", VA = "0x1868227B0")]
	public static LLMIKIIPGIJ ANGJMEBBFOG(long JGAFAAHDFNL, long LCDEHGNNMHO, string NMGHGLDODNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6822840", Offset = "0x6821640", VA = "0x186822840")]
	public static LLMIKIIPGIJ ANGJMEBBFOG(long JGAFAAHDFNL, long LCDEHGNNMHO, PLDLJCNGAPD ALLJPLNAGKO, long KIBPONOCMID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6822900", Offset = "0x6821700", VA = "0x186822900")]
	public static LLMIKIIPGIJ ANGJMEBBFOG(JCEJPJKGHOG PCBEAJCAFDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6822A90", Offset = "0x6821890", VA = "0x186822A90")]
	public static LLMIKIIPGIJ ANGJMEBBFOG(GGLDCNABNOB DMINLHNBFHF, BHFFEFMOLAM HGEEJDMIPKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6822E50", Offset = "0x6821C50", VA = "0x186822E50")]
	public static LLMIKIIPGIJ NICAOMMLFFI(this LLMIKIIPGIJ PENMOOOPINK, GGLDCNABNOB LKEBACFMEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6822CC0", Offset = "0x6821AC0", VA = "0x186822CC0")]
	public static LLMIKIIPGIJ EIODBAJHOHH(this LLMIKIIPGIJ PENMOOOPINK, BHFFEFMOLAM MHKJBABMPLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[RecRoom.NoEngine.Common.Preserve]
internal class NOONIFLNMDL : PGJJGJOGAKN, LNHBAHDCKCE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct DAMAJACIMFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public NOONIFLNMDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private HPLMCKJNNAF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x6820120", Offset = "0x681EF20", VA = "0x186820120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x68207A0", Offset = "0x681F5A0", VA = "0x1868207A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly NNMEDCEFICD CIKGAIDAKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private string JGKMBLLNNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Task OBKNELDJNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private KIAEAACOCKM CPCGINCDIDM;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool JKOLDBBFCGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6838970", Offset = "0x6837770", VA = "0x186838970", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public Task EMLHDCHHFID
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x68389A0", Offset = "0x68377A0", VA = "0x1868389A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7B1ED0", Offset = "0x7B0CD0", VA = "0x1807B1ED0", Slot = "7")]
	public void HBPIHILNAPB(KIAEAACOCKM CPCGINCDIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6838A30", Offset = "0x6837830", VA = "0x186838A30", Slot = "6")]
	public void PFLNLBEIGOF(Task JKCFEOGKFBB, string LMMNIKIDMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6838850", Offset = "0x6837650", VA = "0x186838850")]
	[AsyncStateMachine(typeof(DAMAJACIMFG))]
	private Task JCBPPAMMBDA(Task ABGBJAGAPCL, string LMMNIKIDMEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6838B90", Offset = "0x6837990", VA = "0x186838B90")]
	public NOONIFLNMDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class FKALHMOMDOK : ACJPHMIEAOG, LNHBAHDCKCE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool MFCPNAHCIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private BJDCNDLDLFM EMBABJBCJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private BBFGEEDHNOO JLJLCJEJIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private OHFKCALEDIM IACOOBGNHEJ;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public BJDCNDLDLFM LAJCHLEMLDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x68234C0", Offset = "0x68222C0", VA = "0x1868234C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6823530", Offset = "0x6822330", VA = "0x186823530", Slot = "7")]
	public void HBPIHILNAPB(KIAEAACOCKM CPCGINCDIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6823770", Offset = "0x6822570", VA = "0x186823770", Slot = "5")]
	public void HNPODANDCJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6823480", Offset = "0x6822280", VA = "0x186823480", Slot = "6")]
	public void ECMBBGKDFEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x68236B0", Offset = "0x68224B0", VA = "0x1868236B0")]
	private Task HGNMCKDHLAG(NCEGPPEFCMD KDBMKOJJIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6823480", Offset = "0x6822280", VA = "0x186823480", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public FKALHMOMDOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class FLKDFJAJCKB : OHFKCALEDIM
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	private class KIEFBAFGNMJ<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly EDCCCCKFKJD KJGBIBABCBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly string OBPLDLNDJLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly T OPPINNBBHIO;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public T ACOGNAIJGCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x801870", Offset = "0x800670", VA = "0x180801870")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x8682F0", Offset = "0x8670F0", VA = "0x1808682F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3D0BA90", Offset = "0x3D0A890", VA = "0x183D0BA90")]
		public KIEFBAFGNMJ(EDCCCCKFKJD KJGBIBABCBF, string OBPLDLNDJLE, T OPPINNBBHIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3D0B7E0", Offset = "0x3D0A5E0", VA = "0x183D0B7E0")]
		private void ANPAFLEMAFL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly EDCCCCKFKJD KJGBIBABCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly KIEFBAFGNMJ<TimeSpan> CNKMBJBFDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly KIEFBAFGNMJ<TimeSpan> LIGCMJDGNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly KIEFBAFGNMJ<TimeSpan> CLNJGBIEFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly KIEFBAFGNMJ<TimeSpan> CGKHIGKNDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly KIEFBAFGNMJ<bool> KKHNDMFLIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly KIEFBAFGNMJ<bool> PFBKELGIJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly KIEFBAFGNMJ<bool> LMLIPMDBEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly KIEFBAFGNMJ<int> MHKODKHBNOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly KIEFBAFGNMJ<bool> DNDKICLPKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly KIEFBAFGNMJ<bool> OJDJGJBNHGH;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public TimeSpan NIGDCDJGNND
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6823B60", Offset = "0x6822960", VA = "0x186823B60", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public TimeSpan LMLKCOLPLHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x68239E0", Offset = "0x68227E0", VA = "0x1868239E0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public TimeSpan OCJHCBBHAKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x6823A20", Offset = "0x6822820", VA = "0x186823A20", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public TimeSpan HGECJDGOIFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6823A60", Offset = "0x6822860", VA = "0x186823A60", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool BPEKCADIJCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x68239A0", Offset = "0x68227A0", VA = "0x1868239A0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool LNBGLAPNIOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x6823920", Offset = "0x6822720", VA = "0x186823920", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool PIKDHOHNNJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x6823AA0", Offset = "0x68228A0", VA = "0x186823AA0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public int IOAMDLMDAHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x6823AE0", Offset = "0x68228E0", VA = "0x186823AE0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool GPEGMHEKMGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x6823960", Offset = "0x6822760", VA = "0x186823960", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool EJDFLDIFJMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x6823B20", Offset = "0x6822920", VA = "0x186823B20", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6823BA0", Offset = "0x68229A0", VA = "0x186823BA0")]
	[UnityEngine.Scripting.Preserve]
	public FLKDFJAJCKB([PENMPEOFMMN(null)] EDCCCCKFKJD KJGBIBABCBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[UnityEngine.Scripting.Preserve]
internal class ANMCADAMOAJ : HNIHAFJMCPN, LNHBAHDCKCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class NCFDJPDJBHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public PBCDELOMGHD roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public NCFDJPDJBHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x6835810", Offset = "0x6834610", VA = "0x186835810")]
		internal object CFDMAGNOPOC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action ANFJOIHMELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x681DCC0", Offset = "0x681CAC0", VA = "0x18681DCC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x681DA60", Offset = "0x681C860", VA = "0x18681DA60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event FPLJJKJDEAG ADHNMPIAGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x681D580", Offset = "0x681C380", VA = "0x18681D580", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x681DEB0", Offset = "0x681CCB0", VA = "0x18681DEB0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event FPLJJKJDEAG CNGPLOMKAOP
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x681D990", Offset = "0x681C790", VA = "0x18681D990", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x681DD60", Offset = "0x681CB60", VA = "0x18681DD60", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event FPLJJKJDEAG CBOHHPJKNKE
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x681D810", Offset = "0x681C610", VA = "0x18681D810", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x681DF50", Offset = "0x681CD50", VA = "0x18681DF50", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<GCPKBMBFOIH, bool> DACMBFLEJBO
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x681D8B0", Offset = "0x681C6B0", VA = "0x18681D8B0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x681DE00", Offset = "0x681CC00", VA = "0x18681DE00", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "19")]
	public void HBPIHILNAPB(KIAEAACOCKM CPCGINCDIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x681D620", Offset = "0x681C420", VA = "0x18681D620", Slot = "14")]
	public void FLGHKCILGCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x681D960", Offset = "0x681C760", VA = "0x18681D960", Slot = "15")]
	public void GMENPLGKEHG(PBCDELOMGHD JBHCDECLMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x681D550", Offset = "0x681C350", VA = "0x18681D550", Slot = "16")]
	public void EOPHAOJBMFF(PBCDELOMGHD JBHCDECLMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x681DA30", Offset = "0x681C830", VA = "0x18681DA30", Slot = "17")]
	public void HCGPDJMEJDN(PBCDELOMGHD JBHCDECLMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x681DFF0", Offset = "0x681CDF0", VA = "0x18681DFF0", Slot = "18")]
	public void NDBNLDFNNCP(GCPKBMBFOIH KDMILBNDNEE, bool KINLMAENCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x681DB00", Offset = "0x681C900", VA = "0x18681DB00")]
	private void HEPNPPEJLJB(FPLJJKJDEAG MDGGHFOMEDJ, PBCDELOMGHD JBHCDECLMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public ANMCADAMOAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[UnityEngine.Scripting.Preserve]
internal class NMAFCGLLMHF : AMKMLOBCIOL, LNHBAHDCKCE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct FFEPOCKOEAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public NMAFCGLLMHF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private HPLMCKJNNAF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x6822F40", Offset = "0x6821D40", VA = "0x186822F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x6823420", Offset = "0x6822220", VA = "0x186823420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct HJLONCEPFGP : IAsyncStateMachine
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
		public NMAFCGLLMHF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private HPLMCKJNNAF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x6829FB0", Offset = "0x6828DB0", VA = "0x186829FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x682A610", Offset = "0x6829410", VA = "0x18682A610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class AEHGANHFJDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public AEHGANHFJDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x681CD20", Offset = "0x681BB20", VA = "0x18681CD20")]
		internal object LCCNNJLCLIK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct GGPKIKHIOHE : IAsyncStateMachine
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
		public NMAFCGLLMHF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private AEHGANHFJDH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private HPLMCKJNNAF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6828580", Offset = "0x6827380", VA = "0x186828580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6828CC0", Offset = "0x6827AC0", VA = "0x186828CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class NMDEHLCMNDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public NMDEHLCMNDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x68387E0", Offset = "0x68375E0", VA = "0x1868387E0")]
		internal object FOJEOIDJDKA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly JNOMMELLEMA LEDKGOEDJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private KIAEAACOCKM CPCGINCDIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private PIJDGALKJHE EEEILKJFPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private MDHLONPEOGJ[] MGPMJLBONIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private CancellationTokenSource PGKPKKCBGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private int GFNKCHMBOCG;

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6837F10", Offset = "0x6836D10", VA = "0x186837F10", Slot = "6")]
	public void HBPIHILNAPB(KIAEAACOCKM CPCGINCDIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6837AB0", Offset = "0x68368B0", VA = "0x186837AB0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6838520", Offset = "0x6837320", VA = "0x186838520", Slot = "8")]
	public void NAFIDGCMLCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6838280", Offset = "0x6837080", VA = "0x186838280", Slot = "5")]
	public void LJMKHPANAEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6838450", Offset = "0x6837250", VA = "0x186838450", Slot = "4")]
	[AsyncStateMachine(typeof(FFEPOCKOEAF))]
	public Task MNHKOKDEIKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6837BF0", Offset = "0x68369F0", VA = "0x186837BF0")]
	private void FLLMGNIPFNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6838350", Offset = "0x6837150", VA = "0x186838350")]
	[AsyncStateMachine(typeof(HJLONCEPFGP))]
	private Task MDJHGNOANGF(CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6838620", Offset = "0x6837420", VA = "0x186838620")]
	[AsyncStateMachine(typeof(GGPKIKHIOHE))]
	private Task<bool> OBHONKMGOAH(int AELAKOMEEDP, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6837F90", Offset = "0x6836D90", VA = "0x186837F90")]
	private void IMGMNJGOPDB(int AELAKOMEEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6838070", Offset = "0x6836E70", VA = "0x186838070")]
	private void INBCCGGOBCC(int AELAKOMEEDP, bool KINLMAENCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6838150", Offset = "0x6836F50", VA = "0x186838150")]
	private void KOCJALONFPP(int AELAKOMEEDP, Exception MCKOJGJOINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x6837AC0", Offset = "0x68368C0", VA = "0x186837AC0")]
	private void EEMEJAENICE(CancellationToken KANPDHELHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public NMAFCGLLMHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[RecRoom.NoEngine.Common.Preserve]
internal class GBADMFAABGK : LCNJANPHKFJ, LNHBAHDCKCE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct BPPIFEBKBFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public OCJDEGLDIGA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public GBADMFAABGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public KNLLEOKCJHM customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private HPLMCKJNNAF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x681E7E0", Offset = "0x681D5E0", VA = "0x18681E7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x681F130", Offset = "0x681DF30", VA = "0x18681F130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct MMJGLOMNJJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public GBADMFAABGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public OCJDEGLDIGA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public KNLLEOKCJHM customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private DIMFGGHDEDI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private HPLMCKJNNAF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private AGPIMNGHJGG <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private FOMPOOOMAEN <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x6834BF0", Offset = "0x68339F0", VA = "0x186834BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x68357B0", Offset = "0x68345B0", VA = "0x1868357B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class CLDHGGAIPKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public Matchmaking.FPOPFDGOKJN result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public NPJKGLPELML errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public CLDHGGAIPKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x681FDC0", Offset = "0x681EBC0", VA = "0x18681FDC0")]
		internal object MMPILBLCNHG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class JHPDPMJMEGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public Task<LLMIKIIPGIJ> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public JHPDPMJMEGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
		internal Task<LLMIKIIPGIJ> IBPMKCADAPO(DIMFGGHDEDI<string>.NJDBOGMFDFJ _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct HNBOJDGNKCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public GBADMFAABGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public OCJDEGLDIGA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public KNLLEOKCJHM customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public AGPIMNGHJGG joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private JHPDPMJMEGM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private BFFFHIMMFJB <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private HPLMCKJNNAF <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <connectToRoomAndRunLoadLogicTimer>5__5;

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
		private IHGOAOGGGHG <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private Task<Matchmaking.JHHEDPHAMGD> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private IBHLJKGGLFL <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <>7__wrap12;

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
		private TaskAwaiter<Matchmaking.JHHEDPHAMGD> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private TaskAwaiter<LLMIKIIPGIJ> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x682A870", Offset = "0x6829670", VA = "0x18682A870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x682F9F0", Offset = "0x682E7F0", VA = "0x18682F9F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct ELIPMLLIALH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public GBADMFAABGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private HPLMCKJNNAF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <disconnectTimerScope>5__3;

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
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6821D00", Offset = "0x6820B00", VA = "0x186821D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6822750", Offset = "0x6821550", VA = "0x186822750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct ALEECOOJNGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public GBADMFAABGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private NAINNGGFMLM <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x681CDE0", Offset = "0x681BBE0", VA = "0x18681CDE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x681D250", Offset = "0x681C050", VA = "0x18681D250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct INNGCDAOGDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public AsyncTaskMethodBuilder<Matchmaking.JHHEDPHAMGD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public OCJDEGLDIGA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public GBADMFAABGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private TaskAwaiter<Matchmaking.JHHEDPHAMGD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x68301F0", Offset = "0x682EFF0", VA = "0x1868301F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x68306E0", Offset = "0x682F4E0", VA = "0x1868306E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct CGBJLDIFBAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public Matchmaking.JHHEDPHAMGD serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public GBADMFAABGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public AGPIMNGHJGG joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private HPLMCKJNNAF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private TaskAwaiter<LPBOFAKHLOD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x681F190", Offset = "0x681DF90", VA = "0x18681F190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x681F880", Offset = "0x681E680", VA = "0x18681F880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class MBNJMIDDNBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public OCJDEGLDIGA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public MBNJMIDDNBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x6834740", Offset = "0x6833540", VA = "0x186834740")]
		internal object BOPAHOMFMAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6834840", Offset = "0x6833640", VA = "0x186834840")]
		internal string GNJLCOGGMMM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct ECGMKALLOAG : IAsyncStateMachine
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
		public OCJDEGLDIGA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public GBADMFAABGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private MBNJMIDDNBF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private HPLMCKJNNAF <>7__wrap1;

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

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6820800", Offset = "0x681F600", VA = "0x186820800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x68213D0", Offset = "0x68201D0", VA = "0x1868213D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct FPAKEDOJBFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public GBADMFAABGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public AGPIMNGHJGG joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public LLMIKIIPGIJ initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public OCJDEGLDIGA targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public BFFFHIMMFJB progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6824170", Offset = "0x6822F70", VA = "0x186824170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6824A80", Offset = "0x6823880", VA = "0x186824A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct NLCGLENKMHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public GBADMFAABGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private HPLMCKJNNAF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <>7__wrap3;

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

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6836420", Offset = "0x6835220", VA = "0x186836420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6837A50", Offset = "0x6836850", VA = "0x186837A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct LEBNCPFHFJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public OLDEKHHOPEO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public GBADMFAABGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private HPLMCKJNNAF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private TaskAwaiter<OECPMONDBOC> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x68329C0", Offset = "0x68317C0", VA = "0x1868329C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6833170", Offset = "0x6831F70", VA = "0x186833170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class JAMODCKALCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public OCJDEGLDIGA targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public JAMODCKALCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6830750", Offset = "0x682F550", VA = "0x186830750")]
		internal object PPGNGCCMDDL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class IINDDBHJFPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public IINDDBHJFPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6830150", Offset = "0x682EF50", VA = "0x186830150")]
		internal void EKOFKJHHJCM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class POEEHHJFFMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public OCJDEGLDIGA targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public POEEHHJFFMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x683AF40", Offset = "0x6839D40", VA = "0x18683AF40")]
		internal object CAOCAECHFDP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class ICCNALGLHPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public OCJDEGLDIGA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public ICCNALGLHPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x682FA50", Offset = "0x682E850", VA = "0x18682FA50")]
		internal string AGHJFCOHBLO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly JNOMMELLEMA LEDKGOEDJCM;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly JNOMMELLEMA JAPDOKKOEBM;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly JNOMMELLEMA IJCMLFDGBLO;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly JNOMMELLEMA KNIGOPDCBFI;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly string HAGKCIKMBAN;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly string PABIDIFNGDB;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly string PINFAKGIDEJ;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public static readonly Guid FEEHKGHLJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private PIILEDCECBM KPKCBMFEIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private IFMCAPKBIBK HBBMHEHIHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private BBFGEEDHNOO JLJLCJEJIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private KIAEAACOCKM CPCGINCDIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private PIJDGALKJHE EEEILKJFPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private AMKMLOBCIOL HBFFHPKCMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private PGJJGJOGAKN AGMFEENJELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private HNIHAFJMCPN NADMMCKECPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private GMKIHJDJHAK PDCKPDBOAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private JFFFPNKIDJH IOAANBNLDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private IDisposable IFJLLKFJICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly NNMEDCEFICD IEAJEHBOBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly NNMEDCEFICD DELPKPCNKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private IBHLJKGGLFL GONFKAMGOOG;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public TaskStatus OOENBHOBCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0xAD5DF0", Offset = "0xAD4BF0", VA = "0x180AD5DF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xB24680", Offset = "0xB23480", VA = "0x180B24680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private PAICLNCIIMP FABCENIMEEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x68266C0", Offset = "0x68254C0", VA = "0x1868266C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x6825ED0", Offset = "0x6824CD0", VA = "0x186825ED0", Slot = "6")]
	public void HBPIHILNAPB(KIAEAACOCKM CPCGINCDIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x6825A20", Offset = "0x6824820", VA = "0x186825A20", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x68255C0", Offset = "0x68243C0", VA = "0x1868255C0", Slot = "5")]
	[AsyncStateMachine(typeof(BPPIFEBKBFG))]
	public Task DHIDNFKMLOG(OCJDEGLDIGA LJLKIGBMLBA, KNLLEOKCJHM ECHLNEHAPPP, CancellationToken DHIPGGMBELH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x6825D20", Offset = "0x6824B20", VA = "0x186825D20")]
	[AsyncStateMachine(typeof(MMJGLOMNJJE))]
	private Task GHGAKLOBNNC(OCJDEGLDIGA LJLKIGBMLBA, KNLLEOKCJHM ECHLNEHAPPP, CancellationToken DHIPGGMBELH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6827B60", Offset = "0x6826960", VA = "0x186827B60")]
	private static void OAKNPFBFLIK(GMKIHJDJHAK PDCKPDBOAMH, OCJDEGLDIGA LJLKIGBMLBA, Exception MCKOJGJOINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6826B90", Offset = "0x6825990", VA = "0x186826B90")]
	private static void KKPGKKDEMFN(FOMPOOOMAEN FDBKEOCCEPG, Exception MCKOJGJOINA, [Optional] List<int> FDJNHHAJMMD, int GFNKCHMBOCG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6825BC0", Offset = "0x68249C0", VA = "0x186825BC0")]
	[AsyncStateMachine(typeof(HNBOJDGNKCJ))]
	private Task FLJDFIJJFHL(DIMFGGHDEDI<string>.NJDBOGMFDFJ DPOENBOPPGM, OCJDEGLDIGA LJLKIGBMLBA, KNLLEOKCJHM ECHLNEHAPPP, AGPIMNGHJGG BIPLJCMMANC, CancellationToken DHIPGGMBELH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x6827F20", Offset = "0x6826D20", VA = "0x186827F20")]
	private void OBFJCLHGJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6825700", Offset = "0x6824500", VA = "0x186825700")]
	[AsyncStateMachine(typeof(ELIPMLLIALH))]
	private Task DHKDFPLGKAM(DIMFGGHDEDI<string>.NJDBOGMFDFJ DPOENBOPPGM, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6824AE0", Offset = "0x68238E0", VA = "0x186824AE0")]
	private void ABILDEIKKHE(OCJDEGLDIGA LJLKIGBMLBA, CancellationToken DHIPGGMBELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6827810", Offset = "0x6826610", VA = "0x186827810")]
	private void MLEMCFGLJPH(OCJDEGLDIGA LJLKIGBMLBA, AGPIMNGHJGG BIPLJCMMANC, OperationCanceledException PEOAIBCLKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x6825030", Offset = "0x6823E30", VA = "0x186825030")]
	private void BNBBONBIIOM(OCJDEGLDIGA LJLKIGBMLBA, AGPIMNGHJGG BIPLJCMMANC, Exception MCKOJGJOINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x68253C0", Offset = "0x68241C0", VA = "0x1868253C0")]
	private void CLALGFKLMIL(OCJDEGLDIGA LJLKIGBMLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6825E70", Offset = "0x6824C70", VA = "0x186825E70")]
	private static PBCDELOMGHD GHJKEDGJKBE(OCJDEGLDIGA LJLKIGBMLBA)
	{
		return default(PBCDELOMGHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6826560", Offset = "0x6825360", VA = "0x186826560")]
	[AsyncStateMachine(typeof(ALEECOOJNGL))]
	private Task ICPGBMPIHLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x68276B0", Offset = "0x68264B0", VA = "0x1868276B0")]
	[AsyncStateMachine(typeof(INNGCDAOGDG))]
	private Task<Matchmaking.JHHEDPHAMGD> MICAHKADEAN(OCJDEGLDIGA LJLKIGBMLBA, DIMFGGHDEDI<string>.NJDBOGMFDFJ DPOENBOPPGM, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6824E10", Offset = "0x6823C10", VA = "0x186824E10")]
	private static LPBOFAKHLOD AJGMEHLPEKK(Matchmaking.JHHEDPHAMGD JFJEBHLKDFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6828070", Offset = "0x6826E70", VA = "0x186828070")]
	[AsyncStateMachine(typeof(CGBJLDIFBAB))]
	private Task ODIGLHONKFN(Matchmaking.JHHEDPHAMGD JFJEBHLKDFJ, AGPIMNGHJGG BIPLJCMMANC, DIMFGGHDEDI<string>.NJDBOGMFDFJ DPOENBOPPGM, CancellationToken BILMPCDIOME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6826810", Offset = "0x6825610", VA = "0x186826810")]
	[AsyncStateMachine(typeof(ECGMKALLOAG))]
	private Task JDIJLKEFHDA(OCJDEGLDIGA LJLKIGBMLBA, CancellationTokenSource HAMFLONFHOE, Task JFIMLNDEOJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6825250", Offset = "0x6824050", VA = "0x186825250")]
	[AsyncStateMachine(typeof(FPAKEDOJBFE))]
	private Task BPBMADPHEHH(LLMIKIIPGIJ FFPJOPMJGFI, BFFFHIMMFJB JJJCMAKNBGA, OCJDEGLDIGA BCIBAAGKDMJ, AGPIMNGHJGG KANGLCJMNEL, DIMFGGHDEDI<string>.NJDBOGMFDFJ DPOENBOPPGM, CancellationToken ELBJADNPEEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6825830", Offset = "0x6824630", VA = "0x186825830")]
	private AGPIMNGHJGG DIICOGKAFKM(AGPIMNGHJGG KANGLCJMNEL, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6827A30", Offset = "0x6826830", VA = "0x186827A30")]
	[AsyncStateMachine(typeof(NLCGLENKMHB))]
	private Task NMLOKGLNCCJ(DIMFGGHDEDI<string>.NJDBOGMFDFJ DPOENBOPPGM, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6827410", Offset = "0x6826210", VA = "0x186827410")]
	[AsyncStateMachine(typeof(LEBNCPFHFJO))]
	private Task LALJPBPBOCC(OLDEKHHOPEO LHODDAGAJKC, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6827530", Offset = "0x6826330", VA = "0x186827530")]
	private static void MFJONPHJDCO(OCJDEGLDIGA LJLKIGBMLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6826390", Offset = "0x6825190", VA = "0x186826390")]
	private void IADOODDIMNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6826630", Offset = "0x6825430", VA = "0x186826630")]
	private void IFBMGAFEGLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6826B00", Offset = "0x6825900", VA = "0x186826B00")]
	private void KKDFFLDIJFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6828220", Offset = "0x6827020", VA = "0x186828220")]
	private void PBHLCKCCOHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6825A70", Offset = "0x6824870", VA = "0x186825A70")]
	private static void FJGHOGHJKMC(OCJDEGLDIGA LJLKIGBMLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6824F20", Offset = "0x6823D20", VA = "0x186824F20")]
	private static CancellationTokenRegistration BEHEKAMEKKF(OCJDEGLDIGA LJLKIGBMLBA, CancellationToken BILMPCDIOME)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6826710", Offset = "0x6825510", VA = "0x186826710")]
	private static void IOLKFBOBMMI(OCJDEGLDIGA LJLKIGBMLBA, Exception MCKOJGJOINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6826950", Offset = "0x6825750", VA = "0x186826950")]
	private void KBDMCEHCBLM(OCJDEGLDIGA LJLKIGBMLBA, Task JFIMLNDEOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x68281C0", Offset = "0x6826FC0", VA = "0x1868281C0")]
	private static void OEJDKKHBHHB(Func<string> DAMMFDJOPGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x68284B0", Offset = "0x68272B0", VA = "0x1868284B0")]
	public GBADMFAABGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x6825B60", Offset = "0x6824960", VA = "0x186825B60")]
	[CompilerGenerated]
	internal static (int, int?) FKHPLAHAJNF(NPJKGLPELML BEPIHCHFDKJ)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[RecRoom.NoEngine.Common.Preserve]
internal class OKGNNJMCFGK : CJLBNANOOLK, LNHBAHDCKCE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct PEHGDIMPNON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public OKGNNJMCFGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public OLDEKHHOPEO roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x6857790", Offset = "0x6856590", VA = "0x186857790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x6857B50", Offset = "0x6856950", VA = "0x186857B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class KKNKPOJDEMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public OKGNNJMCFGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public OLDEKHHOPEO roomData;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public KKNKPOJDEMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x6851820", Offset = "0x6850620", VA = "0x186851820")]
		internal List<Task> NIDONOPGHAL(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct BIFINJLIKMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public DLNLCOIIFBI taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public OLDEKHHOPEO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private HPLMCKJNNAF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x683D5B0", Offset = "0x683C3B0", VA = "0x18683D5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x683D930", Offset = "0x683C730", VA = "0x18683D930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct ILFNPFJGKLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public OKGNNJMCFGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x684D080", Offset = "0x684BE80", VA = "0x18684D080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x684D340", Offset = "0x684C140", VA = "0x18684D340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private readonly HashSet<DLNLCOIIFBI> FNIMOGOLHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private IFMCAPKBIBK HBBMHEHIHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private KIAEAACOCKM CPCGINCDIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private IJFHPKHOLLG BDICAECMKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private EEENOOCBJFC LCMKAHEOBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private IDisposable IFJLLKFJICD;

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6839860", Offset = "0x6838660", VA = "0x186839860", Slot = "5")]
	public void HBPIHILNAPB(KIAEAACOCKM CPCGINCDIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6839420", Offset = "0x6838220", VA = "0x186839420", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x683A150", Offset = "0x6838F50", VA = "0x18683A150", Slot = "4")]
	public bool PIBMNOLLOJD(DLNLCOIIFBI NFDIENLGHGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6839480", Offset = "0x6838280", VA = "0x186839480")]
	private void EFGHMMHFKEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6839680", Offset = "0x6838480", VA = "0x186839680")]
	private void HAKPCBHFACE(OLDEKHHOPEO EEKNEAJDFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6839330", Offset = "0x6838130", VA = "0x186839330")]
	[AsyncStateMachine(typeof(PEHGDIMPNON))]
	private Task DBJLLKOBOIF(OLDEKHHOPEO EEKNEAJDFKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6839AE0", Offset = "0x68388E0", VA = "0x186839AE0")]
	private Func<CancellationToken, List<Task>> IOJCABEFBCK(OLDEKHHOPEO EEKNEAJDFKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x6839BB0", Offset = "0x68389B0", VA = "0x186839BB0")]
	private List<Task> KBIFHKJELKP(OLDEKHHOPEO EEKNEAJDFKG, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x6839210", Offset = "0x6838010", VA = "0x186839210")]
	[AsyncStateMachine(typeof(BIFINJLIKMO))]
	private Task AHLLMEDEFAA(DLNLCOIIFBI AKAIMONCJJD, OLDEKHHOPEO LHODDAGAJKC, CancellationToken ADNDMAGEPOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x68395B0", Offset = "0x68383B0", VA = "0x1868395B0")]
	[AsyncStateMachine(typeof(ILFNPFJGKLL))]
	private Task GGFGFFLNEEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x683A0D0", Offset = "0x6838ED0", VA = "0x18683A0D0")]
	private void NAFIDGCMLCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x683A1B0", Offset = "0x6838FB0", VA = "0x18683A1B0")]
	public OKGNNJMCFGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[UnityEngine.Scripting.Preserve]
internal sealed class JCNFEMFPOHK : BANJNPEAECO, LNHBAHDCKCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class NGAENCJMBNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public NGAENCJMBNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x6854C80", Offset = "0x6853A80", VA = "0x186854C80")]
		internal object CNOGKCJJFLG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class MFAECNOBMHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public MFAECNOBMHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x6854530", Offset = "0x6853330", VA = "0x186854530")]
		internal object IGAPIIPFMAH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class NDCKOCICLKI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public NDCKOCICLKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class IMCOBADMLFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public IMCOBADMLFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x684D3A0", Offset = "0x684C1A0", VA = "0x18684D3A0")]
		internal object DDHHBEGMIDD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class LJCLFJNIALM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public LJCLFJNIALM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x68534C0", Offset = "0x68522C0", VA = "0x1868534C0")]
		internal object AGGEGDNPPFI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly Dictionary<Guid, KBDGAFPPMEL> JEHIOEKEDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private readonly TimeSpan JANPBDEBEPN;

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "9")]
	public void HBPIHILNAPB(KIAEAACOCKM CPCGINCDIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x684E170", Offset = "0x684CF70", VA = "0x18684E170", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x684E360", Offset = "0x684D160", VA = "0x18684E360", Slot = "4")]
	public OJIAEEMNBEF HDCMKJKDALC(Guid GJAFHBAGEBC)
	{
		return default(OJIAEEMNBEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x684DF60", Offset = "0x684CD60", VA = "0x18684DF60", Slot = "5")]
	public bool BOIJHFOIOPE(Guid GJAFHBAGEBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x684E7B0", Offset = "0x684D5B0", VA = "0x18684E7B0", Slot = "6")]
	public bool JLGONOALHMG(Guid GJAFHBAGEBC, Task IMFCHEPCJKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x684E180", Offset = "0x684CF80", VA = "0x18684E180", Slot = "7")]
	public bool FJKJKFOMOGC(Guid GJAFHBAGEBC, OECPMONDBOC DOFILCPHLKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x684EAE0", Offset = "0x684D8E0", VA = "0x18684EAE0", Slot = "8")]
	public Task<(OECPMONDBOC, Task)> KNMFJHCMLMG(Guid GJAFHBAGEBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x684E580", Offset = "0x684D380", VA = "0x18684E580")]
	private void IDDBODOLEHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x684EB50", Offset = "0x684D950", VA = "0x18684EB50")]
	public JCNFEMFPOHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[RecRoom.NoEngine.Common.Preserve]
internal class BPHKDKKJMOK : BIFIKJAOKAA, LNHBAHDCKCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private class LGOMPOJHGCO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private readonly OCJDEGLDIGA OLCNHBKKMNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private readonly CancellationTokenSource PGKPKKCBGGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public readonly CancellationToken IIDPGEKHGAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private bool EHKIPPOIFNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private bool KJIMDOIMIPD;

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x6853410", Offset = "0x6852210", VA = "0x186853410")]
		public LGOMPOJHGCO(OCJDEGLDIGA OLCNHBKKMNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x68532C0", Offset = "0x68520C0", VA = "0x1868532C0")]
		public void NAFIDGCMLCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x6853290", Offset = "0x6852090", VA = "0x186853290", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class LPEBLOFNDPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public NCEGPPEFCMD disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public LPEBLOFNDPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6853520", Offset = "0x6852320", VA = "0x186853520")]
		internal object OCGKLJKDBKC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct GLDEEAJOALC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public NCEGPPEFCMD disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public BPHKDKKJMOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private HPLMCKJNNAF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x68498F0", Offset = "0x68486F0", VA = "0x1868498F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6849CA0", Offset = "0x6848AA0", VA = "0x186849CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class CBBMFBFFCPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public CBBMFBFFCPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x68420E0", Offset = "0x6840EE0", VA = "0x1868420E0")]
		internal object BLBAMCLICIO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct BNPBKHPALEF : IAsyncStateMachine
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
		public BPHKDKKJMOK <>4__this;

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
		private HPLMCKJNNAF <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x683E7D0", Offset = "0x683D5D0", VA = "0x18683E7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x898D70", Offset = "0x897B70", VA = "0x180898D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class HEHKGCDAHID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public OCJDEGLDIGA newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public HEHKGCDAHID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x684B8A0", Offset = "0x684A6A0", VA = "0x18684B8A0")]
		internal object AMEIKONLCKB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x684B940", Offset = "0x684A740", VA = "0x18684B940")]
		internal object DOJKEMOLPII()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x684B980", Offset = "0x684A780", VA = "0x18684B980")]
		internal object FNPAGFKJODC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class NPKLCAFIEEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public NPKLCAFIEEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x6854E20", Offset = "0x6853C20", VA = "0x186854E20")]
		internal void NPNMDLNGEKK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private struct FCMFNBEDOMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public OCJDEGLDIGA newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public BPHKDKKJMOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public KNLLEOKCJHM customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private HEHKGCDAHID <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private HPLMCKJNNAF <>7__wrap1;

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

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x6847070", Offset = "0x6845E70", VA = "0x186847070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x6847FE0", Offset = "0x6846DE0", VA = "0x186847FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly JNOMMELLEMA LEDKGOEDJCM;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly KOHHCCDICBO.CLJAHPGHANK KKNGEFEMACH;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly GNGEALOEHNM FLIIGMDANLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private IFMCAPKBIBK HBBMHEHIHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private KIAEAACOCKM CPCGINCDIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private AMKMLOBCIOL HBFFHPKCMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private PIJDGALKJHE EEEILKJFPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private OHFKCALEDIM IACOOBGNHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private LCNJANPHKFJ NKGMLFBEFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private long GJHBDHHLKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private LGOMPOJHGCO EMGAPHMGCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private bool GOFEJIHACFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private Task HAPEIDFNEJC;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	private PAICLNCIIMP FABCENIMEEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x6840110", Offset = "0x683EF10", VA = "0x186840110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool BIOCOOCKCIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x108A3A0", Offset = "0x10891A0", VA = "0x18108A3A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x683F940", Offset = "0x683E740", VA = "0x18683F940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x683FCF0", Offset = "0x683EAF0", VA = "0x18683FCF0", Slot = "4")]
	public void HBPIHILNAPB(KIAEAACOCKM CPCGINCDIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x683F950", Offset = "0x683E750", VA = "0x18683F950", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6840160", Offset = "0x683EF60", VA = "0x186840160")]
	[AsyncStateMachine(typeof(GLDEEAJOALC))]
	private Task KNAHFHLLNGD(NCEGPPEFCMD MPILHPNNBDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x68407F0", Offset = "0x683F5F0", VA = "0x1868407F0")]
	private void PLENKLBKJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x68405A0", Offset = "0x683F3A0", VA = "0x1868405A0")]
	private void NNCEOEAODCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x683FF90", Offset = "0x683ED90", VA = "0x18683FF90")]
	private void IBOPLILPJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6840730", Offset = "0x683F530", VA = "0x186840730")]
	private bool OKLNDJGEKAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x68404D0", Offset = "0x683F2D0", VA = "0x1868404D0")]
	[AsyncStateMachine(typeof(BNPBKHPALEF))]
	private void MOEHFJOAILO(int EKDOAMOHCJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6840250", Offset = "0x683F050", VA = "0x186840250")]
	private void MHPFDJLDDKE([Out] IDisposable DALFAHPCHML, [Out] IDisposable BFEAFNFLDAD, [Out] IDisposable KMNFEBBFKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x683FAC0", Offset = "0x683E8C0", VA = "0x18683FAC0")]
	private bool FPGPPGKNCDL(OCJDEGLDIGA OLCNHBKKMNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x68407A0", Offset = "0x683F5A0", VA = "0x1868407A0")]
	private void PAFGENLBOHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x683FBC0", Offset = "0x683E9C0", VA = "0x18683FBC0")]
	[AsyncStateMachine(typeof(FCMFNBEDOMD))]
	private Task GHGAKLOBNNC(OCJDEGLDIGA OLCNHBKKMNM, KNLLEOKCJHM ECHLNEHAPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6840D20", Offset = "0x683FB20", VA = "0x186840D20")]
	public BPHKDKKJMOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[UnityEngine.Scripting.Preserve]
internal sealed class GMLNAMLCHAD : ADINMIGPHOJ, LNHBAHDCKCE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private struct EOKPHHOFJDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public AsyncTaskMethodBuilder<LJHFIKGIIKE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public GMLNAMLCHAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private TaskAwaiter<LJHFIKGIIKE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x6846190", Offset = "0x6844F90", VA = "0x186846190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x6846420", Offset = "0x6845220", VA = "0x186846420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class ONKPMMHENBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public LDPKGMHDMGO message;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public ONKPMMHENBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x6856D30", Offset = "0x6855B30", VA = "0x186856D30")]
		internal object EJFLCAADHOI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class NLDAPJOHELO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public LDPKGMHDMGO messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public NLDAPJOHELO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x6854CE0", Offset = "0x6853AE0", VA = "0x186854CE0")]
		internal object HHPFLIPMCBD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class EEBPJJDNJAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public LDPKGMHDMGO request;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public EEBPJJDNJAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x68450C0", Offset = "0x6843EC0", VA = "0x1868450C0")]
		internal object JGNJJELANAI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct LCHBNLLKBGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public LDPKGMHDMGO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public GMLNAMLCHAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private HPLMCKJNNAF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private TaskAwaiter<BOEKIHBNIFD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x6852970", Offset = "0x6851770", VA = "0x186852970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x6853230", Offset = "0x6852030", VA = "0x186853230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class INPEFIBCPOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public LDPKGMHDMGO operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public INPEFIBCPOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x684D400", Offset = "0x684C200", VA = "0x18684D400")]
		internal object EHFOLAOPCMJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct BAAKELANDJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public LDPKGMHDMGO operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public GMLNAMLCHAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private HPLMCKJNNAF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private AGPIMNGHJGG <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private TaskAwaiter<LDPKGMHDMGO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x683C9F0", Offset = "0x683B7F0", VA = "0x18683C9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x683D550", Offset = "0x683C350", VA = "0x18683D550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct APEKGIOHOPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public AsyncTaskMethodBuilder<BOEKIHBNIFD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public GMLNAMLCHAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public LDPKGMHDMGO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private NNDGNAPLMNI.NCIJBKEPDOL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private AGPIMNGHJGG <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private TaskAwaiter<LDPKGMHDMGO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x683C460", Offset = "0x683B260", VA = "0x18683C460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x683C980", Offset = "0x683B780", VA = "0x18683C980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class OHHPBMNFLDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public BOEKIHBNIFD operation;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public OHHPBMNFLDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x6856CB0", Offset = "0x6855AB0", VA = "0x186856CB0")]
		internal object DCHCFNDJADD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private struct NAFDFDMNONE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public BOEKIHBNIFD operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public GMLNAMLCHAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private HPLMCKJNNAF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private DIMFGGHDEDI<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x68545F0", Offset = "0x68533F0", VA = "0x1868545F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6854C20", Offset = "0x6853A20", VA = "0x186854C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class CCFIBOIJLHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public LDPKGMHDMGO request;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public CCFIBOIJLHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x68421C0", Offset = "0x6840FC0", VA = "0x1868421C0")]
		internal object LBMBAGMABCA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class CCLKHOMBGNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public LDPKGMHDMGO request;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public CCLKHOMBGNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x6842220", Offset = "0x6841020", VA = "0x186842220")]
		internal object PIOFOIPKNDF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private KIAEAACOCKM CPCGINCDIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private PGJJGJOGAKN AGMFEENJELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private FKICEOCDPKC PAOJILBMAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private FIAMPGNHNAE OBBJCMDEKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private BBFGEEDHNOO JLJLCJEJIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private TaskCompletionSource<LJHFIKGIIKE> DKOMMHCOGHI;

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x684A6A0", Offset = "0x68494A0", VA = "0x18684A6A0", Slot = "7")]
	public void HBPIHILNAPB(KIAEAACOCKM CPCGINCDIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x684A590", Offset = "0x6849390", VA = "0x18684A590", Slot = "6")]
	[AsyncStateMachine(typeof(EOKPHHOFJDB))]
	public Task<LJHFIKGIIKE> DBPLODANKPK(CancellationToken OBLFHBKHNIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6849D00", Offset = "0x6848B00", VA = "0x186849D00", Slot = "4")]
	public void ANLFDLCMLHD(LDPKGMHDMGO HPJAAILCALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x684A1A0", Offset = "0x6848FA0", VA = "0x18684A1A0", Slot = "5")]
	public void BHPHBOCPKDM(LDPKGMHDMGO MACMONAPJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x684A090", Offset = "0x6848E90", VA = "0x18684A090")]
	[AsyncStateMachine(typeof(LCHBNLLKBGF))]
	private Task BCAONBHLJFH(LDPKGMHDMGO AIAKOJMKOGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x684A790", Offset = "0x6849590", VA = "0x18684A790")]
	[AsyncStateMachine(typeof(BAAKELANDJG))]
	private Task INPFGJMCKIL(LDPKGMHDMGO APONAHFAKLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x684A8A0", Offset = "0x68496A0", VA = "0x18684A8A0")]
	[AsyncStateMachine(typeof(APEKGIOHOPF))]
	private Task<BOEKIHBNIFD> KPKNHJFDIAL(LDPKGMHDMGO AIAKOJMKOGA, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x684A500", Offset = "0x6849300", VA = "0x18684A500")]
	private AGPIMNGHJGG BOOFMPEHHHP(LDPKGMHDMGO JPEHPPABONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x684A9F0", Offset = "0x68497F0", VA = "0x18684A9F0")]
	[AsyncStateMachine(typeof(NAFDFDMNONE))]
	private Task LCPHFKMOJEN(BOEKIHBNIFD OLONHMONGPM, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x684AEA0", Offset = "0x6849CA0", VA = "0x18684AEA0")]
	private BOEKIHBNIFD NNMFBGHEOIA(LDPKGMHDMGO AIAKOJMKOGA, AGPIMNGHJGG JOBJABEIAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x28C7860", Offset = "0x28C6660", VA = "0x1828C7860")]
	private T GCLLNBJNGOG<T>(T DIBNBLEEFNN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x684AB10", Offset = "0x6849910", VA = "0x18684AB10")]
	private BOEKIHBNIFD LJMOHDHCPAA(LDPKGMHDMGO AIAKOJMKOGA, AGPIMNGHJGG JOBJABEIAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public GMLNAMLCHAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[UnityEngine.Scripting.Preserve]
internal sealed class CNAJEBPDFKI : FKICEOCDPKC, LNHBAHDCKCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class DMPGKKDLLBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public DMPGKKDLLBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x6845050", Offset = "0x6843E50", VA = "0x186845050")]
		internal object FGGEAKBFPPD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class DAHDGPECGBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public DAHDGPECGBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x6844FE0", Offset = "0x6843DE0", VA = "0x186844FE0")]
		internal object OJNMFBGMGMM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private BBFGEEDHNOO JLJLCJEJIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private INBJLHEKHNG GOHEENBOJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private ADINMIGPHOJ KNFMCFLANMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private BANJNPEAECO JEHIOEKEDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private BGNKLOPIMKB DICEBECJCLL;

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6843380", Offset = "0x6842180", VA = "0x186843380", Slot = "6")]
	public void HBPIHILNAPB(KIAEAACOCKM CPCGINCDIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6842D60", Offset = "0x6841B60", VA = "0x186842D60", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x6843790", Offset = "0x6842590", VA = "0x186843790", Slot = "4")]
	public OJIAEEMNBEF KFGHEOHFBLE(LDPKGMHDMGO BGNKDFCMKKC)
	{
		return default(OJIAEEMNBEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x6844170", Offset = "0x6842F70", VA = "0x186844170", Slot = "5")]
	public void PIJAFGHDPDE(Guid GJAFHBAGEBC, Task IMFCHEPCJKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x6843E20", Offset = "0x6842C20", VA = "0x186843E20")]
	private void OEKKECHKPBC(byte JFHJBNFICLM, int HLJBHMIHLEB, object BJNGANKJPJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x6842E10", Offset = "0x6841C10", VA = "0x186842E10")]
	private void FFHMDPCBAME(JOGOGIDDAPM LGLMJBOBFOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x6842600", Offset = "0x6841400", VA = "0x186842600")]
	private void COOBLHADAGA(JOGOGIDDAPM LGLMJBOBFOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x6842B20", Offset = "0x6841920", VA = "0x186842B20")]
	private void DMFFDCIAEMG(JOGOGIDDAPM LGLMJBOBFOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x68428F0", Offset = "0x68416F0", VA = "0x1868428F0")]
	private OECPMONDBOC CPJCKALFAIH(LDPKGMHDMGO JPEHPPABONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6842400", Offset = "0x6841200", VA = "0x186842400")]
	private void CFMODPACNHE(LDPKGMHDMGO APONAHFAKLK, OECPMONDBOC DOFILCPHLKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x68434F0", Offset = "0x68422F0", VA = "0x1868434F0")]
	private bool HKBANKIFJKP(LDPKGMHDMGO APONAHFAKLK, OECPMONDBOC DOFILCPHLKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6843BB0", Offset = "0x68429B0", VA = "0x186843BB0")]
	private bool NKLBAFKPKBC(LDPKGMHDMGO CJBMMOIGIFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6843EF0", Offset = "0x6842CF0", VA = "0x186843EF0")]
	private bool OPKNJOAEEFP(byte JFHJBNFICLM, ExitGames.Client.Photon.Hashtable LGLMJBOBFOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public CNAJEBPDFKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[UnityEngine.Scripting.Preserve]
internal sealed class LAPMNPBLEEP : MCPKLEJDHLO, LNHBAHDCKCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class AJNHMDDPDCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public LJHFIKGIIKE operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public LAPMNPBLEEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public LDPKGMHDMGO roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public AJNHMDDPDCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x683BFC0", Offset = "0x683ADC0", VA = "0x18683BFC0")]
		internal object DNFIFIGFIPG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x683C030", Offset = "0x683AE30", VA = "0x18683C030")]
		internal object GOHBAFOLIDD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct JHNJJOMBCBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public AsyncTaskMethodBuilder<OECPMONDBOC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public LAPMNPBLEEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public LDPKGMHDMGO roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private HPLMCKJNNAF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private TaskAwaiter<OECPMONDBOC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x684ED60", Offset = "0x684DB60", VA = "0x18684ED60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x684F3E0", Offset = "0x684E1E0", VA = "0x18684F3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class BPMFGGEBFBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public LJHFIKGIIKE operationType;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public BPMFGGEBFBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x6840D90", Offset = "0x683FB90", VA = "0x186840D90")]
		internal object DMAPINBNJLB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class JFCAIFEPDNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public LDPKGMHDMGO request;

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public JFCAIFEPDNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x684EC80", Offset = "0x684DA80", VA = "0x18684EC80")]
		internal object JKDMGANCPOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x684ECF0", Offset = "0x684DAF0", VA = "0x18684ECF0")]
		internal object KJIHNJAJOMP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x684EC10", Offset = "0x684DA10", VA = "0x18684EC10")]
		internal object CPAMNICCCIG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct GJNOGJMIJKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public AsyncTaskMethodBuilder<OECPMONDBOC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public LDPKGMHDMGO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public LAPMNPBLEEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private JFCAIFEPDNI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private HPLMCKJNNAF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private OJIAEEMNBEF <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private OECPMONDBOC <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private TaskAwaiter<(OECPMONDBOC validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x6848FD0", Offset = "0x6847DD0", VA = "0x186848FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x6849880", Offset = "0x6848680", VA = "0x186849880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private BBFGEEDHNOO JLJLCJEJIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private INBJLHEKHNG GOHEENBOJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private FKICEOCDPKC PAOJILBMAIE;

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x6852590", Offset = "0x6851390", VA = "0x186852590", Slot = "5")]
	public void HBPIHILNAPB(KIAEAACOCKM CPCGINCDIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x6852470", Offset = "0x6851270", VA = "0x186852470", Slot = "4")]
	[AsyncStateMachine(typeof(JHNJJOMBCBH))]
	private Task<OECPMONDBOC> EOPPPEBGLBD(LDPKGMHDMGO JPEHPPABONL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x6852780", Offset = "0x6851580", VA = "0x186852780")]
	private bool MMIICHHLMEB(LJHFIKGIIKE KDMILBNDNEE, [Out] OECPMONDBOC FJMMLPMLLGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x6852640", Offset = "0x6851440", VA = "0x186852640")]
	[AsyncStateMachine(typeof(GJNOGJMIJKI))]
	private Task<OECPMONDBOC> IJINLKAMAGN(LDPKGMHDMGO AIAKOJMKOGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public LAPMNPBLEEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class JANOJMCIEOG : EDAMGDNGLNA, LNHBAHDCKCE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private struct AILBBFGJENJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public AsyncTaskMethodBuilder<LLMIKIIPGIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public OCJDEGLDIGA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public JANOJMCIEOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private TaskAwaiter<GGLDCNABNOB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x683BAA0", Offset = "0x683A8A0", VA = "0x18683BAA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x683BF50", Offset = "0x683AD50", VA = "0x18683BF50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class PJHKFGIKCCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public PJHKFGIKCCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x6859070", Offset = "0x6857E70", VA = "0x186859070")]
		internal object AFONPKAIGON()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct PPDCNKAPDME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public AsyncTaskMethodBuilder<GGLDCNABNOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public JANOJMCIEOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public OCJDEGLDIGA targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private PJHKFGIKCCK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<GGLDCNABNOB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x68596A0", Offset = "0x68584A0", VA = "0x1868596A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x6859C90", Offset = "0x6858A90", VA = "0x186859C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class IODGBPHIBJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public IODGBPHIBJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x14DFED0", Offset = "0x14DECD0", VA = "0x1814DFED0")]
		internal bool MLGDJBAPKFJ(DEONINFIMOK sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private PIJDGALKJHE EEEILKJFPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private FDIIECAHINA POCGBGLONJL;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static readonly (PLDLJCNGAPD superRoomData, long subRoomDataSaveId) OCCJKICFLIG;

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x684D720", Offset = "0x684C520", VA = "0x18684D720", Slot = "5")]
	public void HBPIHILNAPB(KIAEAACOCKM CPCGINCDIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x684DD30", Offset = "0x684CB30", VA = "0x18684DD30", Slot = "4")]
	[AsyncStateMachine(typeof(AILBBFGJENJ))]
	public Task<LLMIKIIPGIJ> OFLPEOLDJHE(DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, OCJDEGLDIGA LJLKIGBMLBA, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x684DA90", Offset = "0x684C890", VA = "0x18684DA90")]
	[AsyncStateMachine(typeof(PPDCNKAPDME))]
	private Task<GGLDCNABNOB> MNKIDAINBOJ(OCJDEGLDIGA LJLKIGBMLBA, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x684DBF0", Offset = "0x684C9F0", VA = "0x18684DBF0")]
	private LLMIKIIPGIJ NHPMOKKKNPH(OCJDEGLDIGA LJLKIGBMLBA, GGLDCNABNOB JFFMGNMCEKP, long EEFFKLADGPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x684D7B0", Offset = "0x684C5B0", VA = "0x18684D7B0")]
	private (PLDLJCNGAPD, long) JKGCHBIKKCD(OCJDEGLDIGA LJLKIGBMLBA, GGLDCNABNOB JFFMGNMCEKP, long EEFFKLADGPB)
	{
		return default((PLDLJCNGAPD, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public JANOJMCIEOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[UnityEngine.Scripting.Preserve]
internal sealed class MCAIJPNGKIF : FIAMPGNHNAE, LNHBAHDCKCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class FDOBPLHGGFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public LDPKGMHDMGO request;

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public FDOBPLHGGFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x6848040", Offset = "0x6846E40", VA = "0x186848040")]
		internal object PGEGOCHKLAC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct KPGDLFBAGMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public AsyncTaskMethodBuilder<LDPKGMHDMGO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public LDPKGMHDMGO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public MCAIJPNGKIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public AGPIMNGHJGG pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private HPLMCKJNNAF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private TaskAwaiter<LDPKGMHDMGO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x6851DF0", Offset = "0x6850BF0", VA = "0x186851DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x6852400", Offset = "0x6851200", VA = "0x186852400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct PEJOOOBJIOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public AsyncTaskMethodBuilder<LDPKGMHDMGO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public MCAIJPNGKIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public AGPIMNGHJGG pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private HPLMCKJNNAF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private TaskAwaiter<GNHGJNHAJCC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x6857BB0", Offset = "0x68569B0", VA = "0x186857BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x68581A0", Offset = "0x6856FA0", VA = "0x1868581A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class AHFOACAEOCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public LDPKGMHDMGO request;

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public AHFOACAEOCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x683BA40", Offset = "0x683A840", VA = "0x18683BA40")]
		internal object BDCLLHMLAIJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct CNMJFPGFNDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public AsyncTaskMethodBuilder<LDPKGMHDMGO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public LDPKGMHDMGO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public MCAIJPNGKIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public AGPIMNGHJGG pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private HPLMCKJNNAF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private IAGHONIGDIK <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private IGFBPJMIIGK <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private TaskAwaiter<GNHGJNHAJCC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x6844380", Offset = "0x6843180", VA = "0x186844380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x6844F70", Offset = "0x6843D70", VA = "0x186844F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private BBFGEEDHNOO JLJLCJEJIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	private ACJPHMIEAOG EEMLBLCEDOF;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private BJDCNDLDLFM LAJCHLEMLDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x6853E50", Offset = "0x6852C50", VA = "0x186853E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x6853F10", Offset = "0x6852D10", VA = "0x186853F10", Slot = "8")]
	public void HBPIHILNAPB(KIAEAACOCKM CPCGINCDIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x6853CF0", Offset = "0x6852AF0", VA = "0x186853CF0", Slot = "4")]
	[AsyncStateMachine(typeof(KPGDLFBAGMP))]
	public Task<LDPKGMHDMGO> EHNEHNPMHON(LDPKGMHDMGO AIAKOJMKOGA, AGPIMNGHJGG JOBJABEIAGA, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x68543E0", Offset = "0x68531E0", VA = "0x1868543E0", Slot = "5")]
	[AsyncStateMachine(typeof(PEJOOOBJIOD))]
	public Task<LDPKGMHDMGO> PMCKEDLEPCH(CancellationToken KANPDHELHMD, AGPIMNGHJGG JOBJABEIAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x6853FA0", Offset = "0x6852DA0", VA = "0x186853FA0", Slot = "6")]
	public CANPFPNADBJ IFPGJLAJEBG(BOEKIHBNIFD JDPAFOHCKCL, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x68541B0", Offset = "0x6852FB0", VA = "0x1868541B0", Slot = "7")]
	public CANPFPNADBJ PBOGNJJHNDL(BOEKIHBNIFD JDPAFOHCKCL, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x6853B90", Offset = "0x6852990", VA = "0x186853B90")]
	[AsyncStateMachine(typeof(CNMJFPGFNDL))]
	private Task<LDPKGMHDMGO> BLGKICHBNOG(LDPKGMHDMGO AIAKOJMKOGA, AGPIMNGHJGG JOBJABEIAGA, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x26FF3C0", Offset = "0x26FE1C0", VA = "0x1826FF3C0")]
	private static byte[] CCHMAPMNHHP(LDPKGMHDMGO HPJAAILCALJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public MCAIJPNGKIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[UnityEngine.Scripting.Preserve]
internal sealed class ENELNNJFNJE : INBJLHEKHNG, LNHBAHDCKCE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private HOEKMBEDHNK BMCPCKOPBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private BBFGEEDHNOO JLJLCJEJIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private PGJJGJOGAKN AGMFEENJELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private CHFKIEIBFEO JOHIIABAPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private PIJDGALKJHE EEEILKJFPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private LCNJANPHKFJ NKGMLFBEFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private CJLBNANOOLK KAHJKGCAPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private OHFKCALEDIM IACOOBGNHEJ;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private PAICLNCIIMP FABCENIMEEF
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x6845890", Offset = "0x6844690", VA = "0x186845890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private static OECPMONDBOC ENPEDOGEHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x6845AB0", Offset = "0x68448B0", VA = "0x186845AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x6845720", Offset = "0x6844520", VA = "0x186845720", Slot = "6")]
	public void HBPIHILNAPB(KIAEAACOCKM CPCGINCDIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x6845940", Offset = "0x6844740", VA = "0x186845940", Slot = "4")]
	public OECPMONDBOC LPDAFLPIEAL(CMFDBPHCNJN BMFJLMEFDLM, LJHFIKGIIKE HMDFOAIFOKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x6845420", Offset = "0x6844220", VA = "0x186845420", Slot = "5")]
	public OECPMONDBOC CLLAMLIKOBG(CMFDBPHCNJN JKJGLHFMMLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x68458E0", Offset = "0x68446E0", VA = "0x1868458E0")]
	private static OECPMONDBOC KMJGEMKNJJP(OLFJBACEIPB JNFKLJKGAMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public ENELNNJFNJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public class EKMDDFOENIA : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x68453E0", Offset = "0x68441E0", VA = "0x1868453E0")]
	public EKMDDFOENIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x5D8E380", Offset = "0x5D8D180", VA = "0x185D8E380")]
	public EKMDDFOENIA(string HPJAAILCALJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[UnityEngine.Scripting.Preserve]
internal sealed class OEMPBAJNNGI : IEPFAOPCMJP, LNHBAHDCKCE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct EPAKCNDJAJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder<OECPMONDBOC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public OEMPBAJNNGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public GAIIFIKOGEE autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private DIMFGGHDEDI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private FPBPJLAMGMC <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private TaskAwaiter<OECPMONDBOC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x6846490", Offset = "0x6845290", VA = "0x186846490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x6847000", Offset = "0x6845E00", VA = "0x186847000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct IIILKIELGKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public OEMPBAJNNGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x684C8F0", Offset = "0x684B6F0", VA = "0x18684C8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x684D020", Offset = "0x684BE20", VA = "0x18684D020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct GFBHOEPHLEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public OEMPBAJNNGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x6848700", Offset = "0x6847500", VA = "0x186848700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x6848C10", Offset = "0x6847A10", VA = "0x186848C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct PAJGEMBNBJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public OEMPBAJNNGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x6856FE0", Offset = "0x6855DE0", VA = "0x186856FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x6857730", Offset = "0x6856530", VA = "0x186857730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct FOCLMMDLNLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public OEMPBAJNNGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x68480A0", Offset = "0x6846EA0", VA = "0x1868480A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x6848240", Offset = "0x6847040", VA = "0x186848240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct OFDAPAAONFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public OEMPBAJNNGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x6855FD0", Offset = "0x6854DD0", VA = "0x186855FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x68566E0", Offset = "0x68554E0", VA = "0x1868566E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct MBGOKJGNNCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public OEMPBAJNNGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x68536C0", Offset = "0x68524C0", VA = "0x1868536C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x6853B30", Offset = "0x6852930", VA = "0x186853B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct BJJGKNOPIPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public OEMPBAJNNGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public ACEMKOMODMN autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private DIMFGGHDEDI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x683D990", Offset = "0x683C790", VA = "0x18683D990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x683DEF0", Offset = "0x683CCF0", VA = "0x18683DEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private BBFGEEDHNOO JLJLCJEJIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private KIAEAACOCKM CPCGINCDIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private PIJDGALKJHE EEEILKJFPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private FIAMPGNHNAE OBBJCMDEKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private PGJJGJOGAKN AGMFEENJELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private CJLBNANOOLK KAHJKGCAPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private CancellationTokenSource OOHICMKAFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private Task FJLDNJJIBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	private TaskCompletionSource<int> AJOCAEOKFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	private int PMKAAKBNGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	private int CPMFCFGJDKE;

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x68556D0", Offset = "0x68544D0", VA = "0x1868556D0", Slot = "6")]
	public void HBPIHILNAPB(KIAEAACOCKM CPCGINCDIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x9061B0", Offset = "0x904FB0", VA = "0x1809061B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x6855210", Offset = "0x6854010", VA = "0x186855210")]
	private void BCLMOPKBAAA(float JNEKAMEOOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x68550E0", Offset = "0x6853EE0", VA = "0x1868550E0", Slot = "4")]
	[AsyncStateMachine(typeof(EPAKCNDJAJC))]
	public Task<OECPMONDBOC> AIEMMJAMLIP(GAIIFIKOGEE OHKLPLEDHBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x68554D0", Offset = "0x68542D0", VA = "0x1868554D0", Slot = "5")]
	[AsyncStateMachine(typeof(IIILKIELGKH))]
	public Task CBGOHFAOBMK([Optional] CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x9061B0", Offset = "0x904FB0", VA = "0x1809061B0")]
	public void LEAILPOMHAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x6855E60", Offset = "0x6854C60", VA = "0x186855E60")]
	private FPBPJLAMGMC NHLOMMIOJLD(GAIIFIKOGEE OHKLPLEDHBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x68552F0", Offset = "0x68540F0", VA = "0x1868552F0")]
	[AsyncStateMachine(typeof(GFBHOEPHLEN))]
	private Task BDJLEMDIKIB(OLDEKHHOPEO KDBMKOJJIJP, CancellationToken DHIPGGMBELH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x6855880", Offset = "0x6854680", VA = "0x186855880")]
	[AsyncStateMachine(typeof(PAJGEMBNBJB))]
	private Task IOFDPENLMKC(CancellationToken DHIPGGMBELH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x68553E0", Offset = "0x68541E0", VA = "0x1868553E0")]
	[AsyncStateMachine(typeof(FOCLMMDLNLI))]
	private Task BILIBPOGMBF([Optional] CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x6855B10", Offset = "0x6854910", VA = "0x186855B10")]
	[AsyncStateMachine(typeof(OFDAPAAONFK))]
	private Task KOOOBLDEPFH(CancellationToken DHIPGGMBELH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x6854FE0", Offset = "0x6853DE0", VA = "0x186854FE0")]
	[AsyncStateMachine(typeof(MBGOKJGNNCH))]
	private Task AADGFAHFMOG(CancellationToken CHMKAFMBNBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x6855980", Offset = "0x6854780", VA = "0x186855980")]
	private Task KCKKPBOMPDG(ACEMKOMODMN LKDJIBAIBLB, CancellationToken DHIPGGMBELH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x68555C0", Offset = "0x68543C0", VA = "0x1868555C0")]
	[AsyncStateMachine(typeof(BJJGKNOPIPL))]
	private Task GGMCLCCBNDJ(ACEMKOMODMN LKDJIBAIBLB, CancellationToken DHIPGGMBELH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x6855C00", Offset = "0x6854A00", VA = "0x186855C00")]
	private bool MKCOIPGGABN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public OEMPBAJNNGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[UnityEngine.Scripting.Preserve]
internal class PJMFIKONHPG : CHFKIEIBFEO, LNHBAHDCKCE, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct IFBKMFDHDNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public PJMFIKONHPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private DIMFGGHDEDI<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x684BB60", Offset = "0x684A960", VA = "0x18684BB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x684C0C0", Offset = "0x684AEC0", VA = "0x18684C0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private HCDDMOHPJIM HHHKDEMNGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private KIAEAACOCKM CPCGINCDIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private INBJLHEKHNG GOHEENBOJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private FIAMPGNHNAE OBBJCMDEKNK;

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x6859260", Offset = "0x6858060", VA = "0x186859260", Slot = "6")]
	public void HBPIHILNAPB(KIAEAACOCKM CPCGINCDIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x6859210", Offset = "0x6858010", VA = "0x186859210", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x6859540", Offset = "0x6858340", VA = "0x186859540", Slot = "5")]
	[AsyncStateMachine(typeof(IFBKMFDHDNL))]
	public Task KAIOALCAPML(string CCKBKBLBNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x6859640", Offset = "0x6858440", VA = "0x186859640", Slot = "4")]
	public OECPMONDBOC MKCOIPGGABN(CMFDBPHCNJN BMFJLMEFDLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x6859120", Offset = "0x6857F20", VA = "0x186859120")]
	private MABFDAEFPAA BCMBMMPHMIK(string CCKBKBLBNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public PJMFIKONHPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public static class JKHOGCFIPML
{
	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x684F980", Offset = "0x684E780", VA = "0x18684F980")]
	public static void LAMGLFONDKN(NAINNGGFMLM COEPBABOGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x684FBC0", Offset = "0x684E9C0", VA = "0x18684FBC0")]
	internal static void LKBPNODBPHB(NAINNGGFMLM COEPBABOGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x684F8A0", Offset = "0x684E6A0", VA = "0x18684F8A0")]
	internal static void KGMEGCMMBAB(NAINNGGFMLM COEPBABOGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x684F450", Offset = "0x684E250", VA = "0x18684F450")]
	internal static void JEKGOFMEELC(NAINNGGFMLM COEPBABOGAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal class BJKLPNBPPHC : IHDOJHEKCLG<LDPKGMHDMGO>
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class GIHCCBPJCMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public LDPKGMHDMGO message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public GIHCCBPJCMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x6848C70", Offset = "0x6847A70", VA = "0x186848C70")]
		internal object NDFIFLBOMGF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly BJKLPNBPPHC LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x683E560", Offset = "0x683D360", VA = "0x18683E560")]
	public ExitGames.Client.Photon.Hashtable JPFDICAGNEF(LDPKGMHDMGO HPJAAILCALJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x683DF50", Offset = "0x683CD50", VA = "0x18683DF50", Slot = "5")]
	protected override void ABNMMBPNMMN(LDPKGMHDMGO HPJAAILCALJ, IDictionary<object, object> LHODDAGAJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x683E330", Offset = "0x683D130", VA = "0x18683E330", Slot = "6")]
	public override LDPKGMHDMGO FPNHMAJLCHC(IDictionary<object, object> LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x683E5F0", Offset = "0x683D3F0", VA = "0x18683E5F0")]
	private static void OEJDKKHBHHB(string CBFKJDHBEEH, LDPKGMHDMGO HPJAAILCALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x683E790", Offset = "0x683D590", VA = "0x18683E790")]
	public BJKLPNBPPHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x683E080", Offset = "0x683CE80", VA = "0x18683E080")]
	[CompilerGenerated]
	internal static string ANGPFKIODCL(LLMIKIIPGIJ PENMOOOPINK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class GAJHIFGANOF
{
	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public static OECPMONDBOC ENPEDOGEHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x6845AB0", Offset = "0x68448B0", VA = "0x186845AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x68482A0", Offset = "0x68470A0", VA = "0x1868482A0")]
	public static bool BJJJLONKDNC(this OECPMONDBOC DOFILCPHLKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x68458E0", Offset = "0x68446E0", VA = "0x1868458E0")]
	public static OECPMONDBOC KMJGEMKNJJP(OLFJBACEIPB BJLNHMKHOBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x68482C0", Offset = "0x68470C0", VA = "0x1868482C0")]
	public static OECPMONDBOC DFLBPBFPBPM(IEnumerable<OECPMONDBOC> KNBBIJDIMJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x68484B0", Offset = "0x68472B0", VA = "0x1868484B0")]
	public static string GCBEKCBPABL(this OECPMONDBOC FJMMLPMLLGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public abstract class IHBACOKMKNI : GINKKBDFNJC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public delegate OECPMONDBOC DGDECEAIMGN([NotNull] CMFDBPHCNJN MPGADOBENPE);

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class AFNEGNAJPAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public CMFDBPHCNJN photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public AFNEGNAJPAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x5F832D0", Offset = "0x5F820D0", VA = "0x185F832D0")]
		internal OECPMONDBOC NFCMNDJJHLC(DGDECEAIMGN v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private bool COIBHEFKPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	protected readonly HashSet<DGDECEAIMGN> CICCJCKEPDM;

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x684C3D0", Offset = "0x684B1D0", VA = "0x18684C3D0", Slot = "4")]
	public void HDADJGFHPLJ(DGDECEAIMGN FAJJBDPLKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x684C430", Offset = "0x684B230", VA = "0x18684C430", Slot = "5")]
	public void JHNBPNGIOLG(DGDECEAIMGN FAJJBDPLKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x684C380", Offset = "0x684B180", VA = "0x18684C380", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x684C490", Offset = "0x684B290", VA = "0x18684C490")]
	protected OECPMONDBOC KDPPHOOHJIH(CMFDBPHCNJN JKJGLHFMMLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x684C720", Offset = "0x684B520", VA = "0x18684C720")]
	protected IHBACOKMKNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public class MALLFOJCFCK : IHBACOKMKNI, HOEKMBEDHNK, GINKKBDFNJC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[CompilerGenerated]
	private sealed class MLJNGMBEHIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public OECPMONDBOC result;

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public MLJNGMBEHIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x6854590", Offset = "0x6853390", VA = "0x186854590")]
		internal object MLHOKIENCPI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x68423F0", Offset = "0x68411F0", VA = "0x1868423F0")]
	[UnityEngine.Scripting.Preserve]
	public MALLFOJCFCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x68535B0", Offset = "0x68523B0", VA = "0x1868535B0", Slot = "8")]
	public OECPMONDBOC GGADNKDFKEJ(CMFDBPHCNJN JKJGLHFMMLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class CLLLHJGFPLE : IHBACOKMKNI, HCDDMOHPJIM, GINKKBDFNJC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class CJEFGKGAAPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public OECPMONDBOC result;

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public CJEFGKGAAPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x6842280", Offset = "0x6841080", VA = "0x186842280")]
		internal object HGFECIGNMDP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x68423F0", Offset = "0x68411F0", VA = "0x1868423F0")]
	[UnityEngine.Scripting.Preserve]
	public CLLLHJGFPLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x68422E0", Offset = "0x68410E0", VA = "0x1868422E0", Slot = "8")]
	public OECPMONDBOC MKCOIPGGABN(CMFDBPHCNJN CIJPLICOMPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class IFEBKPPOBFH
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private sealed class IPFNPKIEJOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public DIMFGGHDEDI<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public IPFNPKIEJOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x684D460", Offset = "0x684C260", VA = "0x18684D460")]
		internal object JBPEIOOCJKC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x684C1E0", Offset = "0x684AFE0", VA = "0x18684C1E0")]
	public static DIMFGGHDEDI<string> NAKNIPJKEIP(JNOMMELLEMA LEDKGOEDJCM, [Optional] string BCHMDJCIKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x684C120", Offset = "0x684AF20", VA = "0x18684C120")]
	public static void GEHPKJIEDIF(DIMFGGHDEDI<string> DPOENBOPPGM, JNOMMELLEMA LEDKGOEDJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x684C2C0", Offset = "0x684B0C0", VA = "0x18684C2C0")]
	public static string NCGDCOOPAEA(LDPKGMHDMGO JPEHPPABONL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal static class IHLJMBKDJBI
{
	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x684C7B0", Offset = "0x684B5B0", VA = "0x18684C7B0")]
	public static void FHHLENILBOC(this BBFGEEDHNOO JLJLCJEJIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x684C8E0", Offset = "0x684B6E0", VA = "0x18684C8E0")]
	public static void OAHACAPDGOG(this BBFGEEDHNOO JLJLCJEJIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x684C7C0", Offset = "0x684B5C0", VA = "0x18684C7C0")]
	private static void IALDHLBPHHN(this BBFGEEDHNOO JLJLCJEJIMH, bool FECEAOLHENC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class OGFOJLLGFIA : NFOLOGPLIPC, NFPANEKDLDE, GDOJBJEEDJP, NKKIGLOOPOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private readonly NFPANEKDLDE BGJJABOJAJE;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public CMFDBPHCNJN KMOGGEGKNFE
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x6856BC0", Offset = "0x68559C0", VA = "0x186856BC0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public int NJNJDHLPMFG
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x6856740", Offset = "0x6855540", VA = "0x186856740", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public int OMNILGAGHMO
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x6856A90", Offset = "0x6855890", VA = "0x186856A90", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public bool KIIMIIMONHH
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x7CA590", Offset = "0x7C9390", VA = "0x1807CA590", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int IOPBJIGJLFK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x874150", Offset = "0x872F50", VA = "0x180874150", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event CIMLAIKEOFN.IGMJDBKOPLK BABIGPPKIPB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event OBGMAIBNCKH GLNIHGHFAAM
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x68568E0", Offset = "0x68556E0", VA = "0x1868568E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x6856C10", Offset = "0x6855A10", VA = "0x186856C10", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> GPAKEJOOGDA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<CMFDBPHCNJN> POIFACACDPB
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action MELIANLGGOF
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x68569A0", Offset = "0x68557A0", VA = "0x1868569A0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x6856840", Offset = "0x6855640", VA = "0x186856840", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0xD90AD0", Offset = "0xD8F8D0", VA = "0x180D90AD0")]
	public OGFOJLLGFIA(NFPANEKDLDE BGJJABOJAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x6856790", Offset = "0x6855590", VA = "0x186856790", Slot = "8")]
	public bool FEAFAFALEIC(byte JFHJBNFICLM, ExitGames.Client.Photon.Hashtable INJALPFHONC, OOIBPFOFLNA LHLBLFDHCJC, SendOptions BHPPHHKOFNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x6856AE0", Offset = "0x68558E0", VA = "0x186856AE0", Slot = "16")]
	public CMFDBPHCNJN MHLLPNAMAKJ(int FBPJACPIKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "19")]
	public void NAAMBLGEHON(object ADNDMAGEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "20")]
	public void NOPDELAODGM(object ADNDMAGEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "21")]
	public void CDCKEMGJPFP(object ADNDMAGEPOK, bool ACBKMGMNLJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x6856A40", Offset = "0x6855840", VA = "0x186856A40", Slot = "22")]
	public IDisposable KMHAFNCLOHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "23")]
	private bool HEHOAOGLMPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "24")]
	public void EKCLILAMCIA(StringBuilder PEFJEFMJEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x6856980", Offset = "0x6855780", VA = "0x186856980", Slot = "25")]
	public bool HMKNDECBCJD(bool FPKEMABOPHM, [Out] string EPIMHJFIPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x82EA10", Offset = "0x82D810", VA = "0x18082EA10", Slot = "28")]
	public void ABOJNLKPBNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal struct JOGOGIDDAPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private readonly IDictionary<object, object> LGLMJBOBFOG;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x93C860", Offset = "0x93B660", VA = "0x18093C860")]
	public JOGOGIDDAPM(IDictionary<object, object> LGLMJBOBFOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x684FFF0", Offset = "0x684EDF0", VA = "0x18684FFF0")]
	public bool PBLOMPKICOL([Out] LDPKGMHDMGO HPJAAILCALJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x684FF40", Offset = "0x684ED40", VA = "0x18684FF40")]
	public Guid EBBBBGPIKDE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x684FE10", Offset = "0x684EC10", VA = "0x18684FE10")]
	public OECPMONDBOC BCFMIPGOMPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x684FD20", Offset = "0x684EB20", VA = "0x18684FD20")]
	public static ExitGames.Client.Photon.Hashtable ANGJMEBBFOG(LDPKGMHDMGO HPJAAILCALJ, OECPMONDBOC DOFILCPHLKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal static class HILNKCBBKFI
{
	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x684B9C0", Offset = "0x684A7C0", VA = "0x18684B9C0")]
	public static bool FCLBNDGHBDB(this OCJDEGLDIGA OMOAKIOOHPA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal struct EEENOOCBJFC : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct JAAAECMMCNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public EEENOOCBJFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x684D4E0", Offset = "0x684C2E0", VA = "0x18684D4E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x684D6C0", Offset = "0x684C4C0", VA = "0x18684D6C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	private readonly CancellationTokenSource PGKPKKCBGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private bool COIBHEFKPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private Task JKCFEOGKFBB;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public bool GOBGLGCFBCN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x6845280", Offset = "0x6844080", VA = "0x186845280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x68452B0", Offset = "0x68440B0", VA = "0x1868452B0")]
	public EEENOOCBJFC(CancellationToken KANPDHELHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x6845170", Offset = "0x6843F70", VA = "0x186845170")]
	[AsyncStateMachine(typeof(JAAAECMMCNK))]
	public Task HPBCPONAGCL(Func<CancellationToken, List<Task>> CJICDDKCAEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x6845120", Offset = "0x6843F20", VA = "0x186845120", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public readonly struct HKIBPEHNKKM<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct PBJIMHJFBFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<BLCPLJPDMPC<TData>, PCJEOFJNKHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public HKIBPEHNKKM<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private TaskAwaiter<PJPNKGNAEHO<BLCPLJPDMPC<TData>, PCJEOFJNKHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x41C2E50", Offset = "0x41C1C50", VA = "0x1841C2E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x34C5980", Offset = "0x34C4780", VA = "0x1834C5980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private readonly LMKLEKPDHNC<TGetDataArg, TData> PIBJMGMHGME;

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x93C860", Offset = "0x93B660", VA = "0x18093C860")]
	internal HKIBPEHNKKM(LMKLEKPDHNC<TGetDataArg, TData> GLJEJHKFIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x39C9B60", Offset = "0x39C8960", VA = "0x1839C9B60")]
	[AsyncStateMachine(typeof(HKIBPEHNKKM<, >.PBJIMHJFBFB))]
	public Task<PJPNKGNAEHO<BLCPLJPDMPC<TData>, PCJEOFJNKHC>> AJACPJBBLPK(TGetDataArg PNJHNPALLNI, string CLPKDAOCALC, DIMFGGHDEDI<string>.NJDBOGMFDFJ DPOENBOPPGM, CancellationToken KANPDHELHMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public static class JGFKJABILBK
{
	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x27D5200", Offset = "0x27D4000", VA = "0x1827D5200")]
	public static HKIBPEHNKKM<TGetDataArg, TData> KHDJPNLCMFA<TGetDataArg, TData>(LMKLEKPDHNC<TGetDataArg, TData> GLJEJHKFIBB)
	{
		return default(HKIBPEHNKKM<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public struct NPJKGLPELML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public readonly int HFAAHELHFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public readonly int? EOPLGCNDDEP;

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x3D9FD30", Offset = "0x3D9EB30", VA = "0x183D9FD30")]
	public NPJKGLPELML(int DEBOKPNAGFI, [Optional] int? DBOKOHMFEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x6854D40", Offset = "0x6853B40", VA = "0x186854D40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public interface MPBGNGLCKFJ<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EFPIOCLCOLJ();

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MPBGNGLCKFJ<T> PBDGMNANHKE(string NJMOGJMJHOJ);

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MPBGNGLCKFJ<T> LEMHIDAPOPP(MHGKIMKKKGK<T> KFJKDCLLHGA);

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MPBGNGLCKFJ<T> BJHAFAFGDMF(int BEPIHCHFDKJ);

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MPBGNGLCKFJ<T> LLEMMHOAPBD(int BEPIHCHFDKJ, IANLEKPDGAJ<T> MEBIKNDPHHA);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public interface GMKIHJDJHAK
{
	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MPBGNGLCKFJ<T> NKDGALJOAEM<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ICPHCNNPILM GHONLBGJLAI(Exception MCKOJGJOINA);

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NPJKGLPELML BBLEINABOLH(Exception MCKOJGJOINA);
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public delegate string MHGKIMKKKGK<in T>(T MCKOJGJOINA) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public delegate int IANLEKPDGAJ<in T>(T MCKOJGJOINA) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal class KKDFAHFEBEJ : GMKIHJDJHAK
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private delegate string NKOCENBBHFE(Exception MCKOJGJOINA);

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	private delegate int GIICJABMAPB(Exception MCKOJGJOINA);

	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	private class FNOHLJOJECE<T> : MPBGNGLCKFJ<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private sealed class HOOGOALPPKH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public HOOGOALPPKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
			internal string GKCIEPDGFMB(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private sealed class HBDGGNAMLAJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000314")]
			public MHGKIMKKKGK<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public HBDGGNAMLAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x385B820", Offset = "0x385A620", VA = "0x18385B820")]
			internal string LBFCDOOBLAB(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E5")]
		[CompilerGenerated]
		private sealed class FMLHLCFJAPA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			public IANLEKPDGAJ<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public FMLHLCFJAPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x385B820", Offset = "0x385A620", VA = "0x18385B820")]
			internal int GFEHIKOGDDC(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private readonly KKDFAHFEBEJ PDCKPDBOAMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private readonly Type AJMKIOGGDJH;

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x38633E0", Offset = "0x38621E0", VA = "0x1838633E0")]
		internal FNOHLJOJECE(KKDFAHFEBEJ PDCKPDBOAMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x3863090", Offset = "0x3861E90", VA = "0x183863090", Slot = "4")]
		public void EFPIOCLCOLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x38632E0", Offset = "0x38620E0", VA = "0x1838632E0", Slot = "5")]
		public MPBGNGLCKFJ<T> PBDGMNANHKE(string NJMOGJMJHOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x38630C0", Offset = "0x3861EC0", VA = "0x1838630C0", Slot = "6")]
		public MPBGNGLCKFJ<T> LEMHIDAPOPP(MHGKIMKKKGK<T> KFJKDCLLHGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x3863050", Offset = "0x3861E50", VA = "0x183863050", Slot = "7")]
		public MPBGNGLCKFJ<T> BJHAFAFGDMF(int BEPIHCHFDKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x38631C0", Offset = "0x3861FC0", VA = "0x1838631C0", Slot = "8")]
		public MPBGNGLCKFJ<T> LLEMMHOAPBD(int BEPIHCHFDKJ, IANLEKPDGAJ<T> MEBIKNDPHHA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private class PAAHOBCAGLG<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private bool EFGNGMLNLFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private readonly List<Type> EEFHPGPMOJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private readonly Dictionary<Type, TVal> ALNJIDNGAFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private readonly Dictionary<Type, int> IGHHHMBDDAN;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public IReadOnlyList<Type> EOHEHOCJPPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x41B8D00", Offset = "0x41B7B00", VA = "0x1841B8D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x41B9020", Offset = "0x41B7E20", VA = "0x1841B9020")]
		public PAAHOBCAGLG(Dictionary<Type, int> IGHHHMBDDAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x41B8B20", Offset = "0x41B7920", VA = "0x1841B8B20")]
		public void HDCMKJKDALC(Type OBPLDLNDJLE, TVal FLOENDBPFOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x41B8FE0", Offset = "0x41B7DE0", VA = "0x1841B8FE0")]
		public bool PLGAEABEBPN(Type AJMKIOGGDJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x41B8E60", Offset = "0x41B7C60", VA = "0x1841B8E60")]
		public bool JOEEKNMILFN(TVal DIBNBLEEFNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x41B8AE0", Offset = "0x41B78E0", VA = "0x1841B8AE0")]
		public TVal DJGCEJBDGHO(Type DDEINLAGLLL)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x41B8EA0", Offset = "0x41B7CA0", VA = "0x1841B8EA0")]
		[CompilerGenerated]
		private int KDINGEBBBEM(Type CIMNBIGPADF, Type CBOGIILOFGO)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class HBLKLKKOJPB : IEnumerable<NPJKGLPELML>, IEnumerable, IEnumerator<NPJKGLPELML>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private NPJKGLPELML <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public KKDFAHFEBEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private IEnumerator<NPJKGLPELML> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		private NPJKGLPELML System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x35212D0", Offset = "0x35200D0", VA = "0x1835212D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(NPJKGLPELML);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600041C")]
			[Cpp2IlInjected.Address(RVA = "0x684B700", Offset = "0x684A500", VA = "0x18684B700", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x802B10", Offset = "0x801910", VA = "0x180802B10")]
		[DebuggerHidden]
		public HBLKLKKOJPB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x684B750", Offset = "0x684A550", VA = "0x18684B750", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x684B150", Offset = "0x6849F50", VA = "0x18684B150", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x684B0B0", Offset = "0x6849EB0", VA = "0x18684B0B0")]
		private void DJJHEMEPHNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x684B100", Offset = "0x6849F00", VA = "0x18684B100")]
		private void MHENGEIGMCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x684B6B0", Offset = "0x684A4B0", VA = "0x18684B6B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x684B5F0", Offset = "0x684A3F0", VA = "0x18684B5F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NPJKGLPELML> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x684B5F0", Offset = "0x684A3F0", VA = "0x18684B5F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	private static readonly NPJKGLPELML AGLLPDOIODP;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	private static readonly Dictionary<Type, int> NMGJODDMFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private readonly HashSet<Type> OEOODJKCENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private readonly PAAHOBCAGLG<int> CIABPDCMDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private readonly PAAHOBCAGLG<GIICJABMAPB> PMLKILHAFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	private readonly PAAHOBCAGLG<NKOCENBBHFE> JEIIIDKOGPF;

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x6850B00", Offset = "0x684F900", VA = "0x186850B00")]
	[DPHBJKOLDBD(OHNOEEJKPCM.GameOnly)]
	private static void NHIOCKBFPIL(NAINNGGFMLM LMEEFHNMKLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x68514F0", Offset = "0x68502F0", VA = "0x1868514F0")]
	[RecRoom.NoEngine.Common.Preserve]
	public KKDFAHFEBEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x269D350", Offset = "0x269C150", VA = "0x18269D350", Slot = "4")]
	public MPBGNGLCKFJ<T> NKDGALJOAEM<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x68507A0", Offset = "0x684F5A0", VA = "0x1868507A0", Slot = "5")]
	public ICPHCNNPILM GHONLBGJLAI(Exception MCKOJGJOINA)
	{
		return default(ICPHCNNPILM);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x68504C0", Offset = "0x684F2C0", VA = "0x1868504C0", Slot = "6")]
	public NPJKGLPELML BBLEINABOLH(Exception? MCKOJGJOINA)
	{
		return default(NPJKGLPELML);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x6850E40", Offset = "0x684FC40", VA = "0x186850E40", Slot = "7")]
	[IteratorStateMachine(typeof(HBLKLKKOJPB))]
	public IEnumerable<NPJKGLPELML> OMGBFBAJMAP(Exception MCKOJGJOINA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x6850830", Offset = "0x684F630", VA = "0x186850830", Slot = "8")]
	public string GNIOHCJKCLL(Exception? MCKOJGJOINA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x6851130", Offset = "0x684FF30", VA = "0x186851130")]
	private string POLOELDCFJB(AggregateException JGOOENCNHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x6850110", Offset = "0x684EF10", VA = "0x186850110")]
	private void AAHHFALODGH(Type AJMKIOGGDJH, int BEPIHCHFDKJ, GIICJABMAPB? MOGDFOIIBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x6850EE0", Offset = "0x684FCE0", VA = "0x186850EE0")]
	private void PDICFOCKPIH(Type AJMKIOGGDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x6850B70", Offset = "0x684F970", VA = "0x186850B70")]
	private void NPGHJLMBHOJ(Type AJMKIOGGDJH, NKOCENBBHFE AHHDHNDKCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x6850980", Offset = "0x684F780", VA = "0x186850980")]
	private static int HCNFCGCNKPN(Type AJMKIOGGDJH, Dictionary<Type, int> IGHHHMBDDAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x294D660", Offset = "0x294C460", VA = "0x18294D660")]
	private static bool JLJEIPIKEJH<TVal>(PAAHOBCAGLG<TVal> NIEBKKPIOLC, Type AJMKIOGGDJH, [Out] TVal DIBNBLEEFNN) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x68506C0", Offset = "0x684F4C0", VA = "0x1868506C0")]
	[CompilerGenerated]
	internal static int DGNNHEEOPMC(Type NMBLEFFPEGO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public struct ICPHCNNPILM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public readonly NPJKGLPELML DFKIFMANGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public readonly string KOOPLMBAPJH;

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x684BB40", Offset = "0x684A940", VA = "0x18684BB40")]
	public ICPHCNNPILM(string KFCPIKMJHNA, NPJKGLPELML BEPIHCHFDKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x684BAA0", Offset = "0x684A8A0", VA = "0x18684BAA0")]
	public string MOLFOCGADIL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public class PIILEDCECBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private readonly IJOABPEABIK KOLDBMLLNKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private string GDKNAIIDGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	private long? HBGAGGGAGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private long? MFBEMCMHJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	private long? NDNMMLMFDKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private string BKJMPJCBACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private ICBFKGNMMDL FMHGKOCCJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private long? OKFOBLAALLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private bool FDPMCKFJOOE;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public string PMNLMIPABGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public long DJMENKOMIJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x6858CE0", Offset = "0x6857AE0", VA = "0x186858CE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public long IMOCDOJJPCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x68585C0", Offset = "0x68573C0", VA = "0x1868585C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public long MLKOEFILJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x6858AB0", Offset = "0x68578B0", VA = "0x186858AB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public string JFIGMDLGGIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x6858580", Offset = "0x6857380", VA = "0x186858580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public ICBFKGNMMDL JLABNNIPFEL
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xDBA7E0", Offset = "0xDB95E0", VA = "0x180DBA7E0")]
		get
		{
			return default(ICBFKGNMMDL);
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x6858B10", Offset = "0x6857910", VA = "0x186858B10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public long CLOPNEJHFCP
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x6858C80", Offset = "0x6857A80", VA = "0x186858C80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x6859030", Offset = "0x6857E30", VA = "0x186859030")]
	[UnityEngine.Scripting.Preserve]
	public PIILEDCECBM([PENMPEOFMMN(null)] IJOABPEABIK KOLDBMLLNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x6858DE0", Offset = "0x6857BE0", VA = "0x186858DE0")]
	private void PGNEILDLPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x6858620", Offset = "0x6857420", VA = "0x186858620")]
	public void HIOHIFAJHLK(long EKMDOMOGGBC, long EEFFKLADGPB, [Optional] long? KOBEPCIBNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x6858D40", Offset = "0x6857B40", VA = "0x186858D40")]
	public void NPHPGAIEMAO(long KOBEPCIBNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x6858C00", Offset = "0x6857A00", VA = "0x186858C00")]
	public void KCBLJBALCHF(string ALFFEFNNHAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x6858210", Offset = "0x6857010", VA = "0x186858210")]
	public void ACIPCMAKAJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal class CANPFPNADBJ : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct KOOMLANKAKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public AsyncTaskMethodBuilder<LDPKGMHDMGO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public LDPKGMHDMGO roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public CANPFPNADBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private TaskAwaiter<BJDCNDLDLFM.PPMGMAKIKBG<LDPKGMHDMGO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x6851850", Offset = "0x6850650", VA = "0x186851850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x6851D80", Offset = "0x6850B80", VA = "0x186851D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct OBCPEIIKNIB<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class ALDOCECCOND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public LDPKGMHDMGO roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public ALDOCECCOND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x683C160", Offset = "0x683AF60", VA = "0x18683C160")]
		internal LDPKGMHDMGO LLDKFNPLJGJ(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct ENNJKBAACIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public AsyncTaskMethodBuilder<BJDCNDLDLFM.PPMGMAKIKBG<LDPKGMHDMGO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public LDPKGMHDMGO roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public CANPFPNADBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private IAGHONIGDIK <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private TaskAwaiter<BJDCNDLDLFM.PPMGMAKIKBG<LDPKGMHDMGO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x6845B10", Offset = "0x6844910", VA = "0x186845B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x6846120", Offset = "0x6844F20", VA = "0x186846120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct LAJJLHJAEHJ<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public CANPFPNADBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x3DA5A90", Offset = "0x3DA4890", VA = "0x183DA5A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x3470F10", Offset = "0x346FD10", VA = "0x183470F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct AOBHOJCNBII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public CANPFPNADBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x683C240", Offset = "0x683B040", VA = "0x18683C240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x683C400", Offset = "0x683B200", VA = "0x18683C400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class OCODLLPGHHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public OCODLLPGHHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x6854EC0", Offset = "0x6853CC0", VA = "0x186854EC0")]
		internal object AAPHGFPMHFE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x6854F20", Offset = "0x6853D20", VA = "0x186854F20")]
		internal bool CEMLCMBDBKL(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class IBLKDINPCHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public IBLKDINPCHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x684BA40", Offset = "0x684A840", VA = "0x18684BA40")]
		internal object OLOCCELAAJH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private sealed class CBJJHPJGOBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public CBJJHPJGOBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x6842150", Offset = "0x6840F50", VA = "0x186842150")]
		internal object JLKMLGACPCM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private sealed class KDODEIOMHDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public KDODEIOMHDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x68500A0", Offset = "0x684EEA0", VA = "0x1868500A0")]
		internal object PMJPAAMLIOH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class OOBIMJILHFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public CANPFPNADBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public OOBIMJILHFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x6856D90", Offset = "0x6855B90", VA = "0x186856D90")]
		internal object NDFIFLBOMGF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private static readonly Guid LAPDJFNCKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public readonly BOEKIHBNIFD MOOEMJHBBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private readonly BJDCNDLDLFM EHMGDLKOICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private readonly GDOJBJEEDJP JLJLCJEJIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private readonly NKKIGLOOPOB DIOOLBBLEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private bool HBEFFOGNMCO;

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x6841EB0", Offset = "0x6840CB0", VA = "0x186841EB0")]
	public CANPFPNADBJ(BOEKIHBNIFD OLONHMONGPM, BJDCNDLDLFM EHMGDLKOICE, GDOJBJEEDJP JLJLCJEJIMH, NKKIGLOOPOB DIOOLBBLEAJ, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x6840FE0", Offset = "0x683FDE0", VA = "0x186840FE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x6840FE0", Offset = "0x683FDE0", VA = "0x186840FE0")]
	public void PPJDKCNNECH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x6841510", Offset = "0x6840310", VA = "0x186841510")]
	public void JGACAMFLHNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x68418B0", Offset = "0x68406B0", VA = "0x1868418B0")]
	public void MMBBOECECKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x6840E00", Offset = "0x683FC00", VA = "0x186840E00")]
	[AsyncStateMachine(typeof(KOOMLANKAKM))]
	internal Task<LDPKGMHDMGO> BIHLCBPPHCP(DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, LDPKGMHDMGO JPEHPPABONL, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x26FF3C0", Offset = "0x26FE1C0", VA = "0x1826FF3C0")]
	private static byte[] MNCNKODCKBO<T>(T HPJAAILCALJ) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x26FEF10", Offset = "0x26FDD10", VA = "0x1826FEF10")]
	private static T ENLKLLKIJCL<T>(MessageParser<T> HCIHBPJGEGN, byte[] HPJAAILCALJ, T CAMFMONNIFP) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x6841D10", Offset = "0x6840B10", VA = "0x186841D10")]
	[AsyncStateMachine(typeof(ENNJKBAACIG))]
	private Task<BJDCNDLDLFM.PPMGMAKIKBG<LDPKGMHDMGO>> PLACEACFACK(LDPKGMHDMGO JPEHPPABONL, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x26FF140", Offset = "0x26FDF40", VA = "0x1826FF140")]
	[AsyncStateMachine(typeof(LAJJLHJAEHJ<>))]
	internal Task<T> KHBKPICHINF<T>(CancellationToken DHIPGGMBELH, Func<CancellationToken, Task<T>> BKAJICOJIID, int EFGPCCPFOOD = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x6841730", Offset = "0x6840530", VA = "0x186841730")]
	[AsyncStateMachine(typeof(AOBHOJCNBII))]
	internal Task KHBKPICHINF(CancellationToken DHIPGGMBELH, Func<CancellationToken, Task> BKAJICOJIID, int EFGPCCPFOOD = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x6841380", Offset = "0x6840180", VA = "0x186841380")]
	public IOKIOMILIFK GIPIHMKECAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x6840F60", Offset = "0x683FD60", VA = "0x186840F60")]
	public HLECMGBMBCM CKFBFGNMNGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x6841100", Offset = "0x683FF00", VA = "0x186841100")]
	public LNPMEJPNJDE EAPKMLCJGOK([Optional] JNOMMELLEMA? LEDKGOEDJCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x68415D0", Offset = "0x68403D0", VA = "0x1868415D0")]
	public void JHFGPCOEDDB(Func<Guid, bool> NONFADNOHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x6841400", Offset = "0x6840200", VA = "0x186841400")]
	public void IEFDPJEAGEC(Func<Guid, bool> FBJNEPGNGLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x6841A80", Offset = "0x6840880", VA = "0x186841A80")]
	public Guid OKENNABPHAA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x6841C00", Offset = "0x6840A00", VA = "0x186841C00")]
	public void ONALAIFLFME(Guid PKBEDCGHOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x6841250", Offset = "0x6840050", VA = "0x186841250")]
	public void EHNJLBMIJFP(LDPKGMHDMGO HADKALHHHDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x6841970", Offset = "0x6840770", VA = "0x186841970")]
	public void OEJDKKHBHHB(string HBMAHABCPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x26FF060", Offset = "0x26FDE60", VA = "0x1826FF060")]
	private T GCLLNBJNGOG<T>(T DIBNBLEEFNN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x6841860", Offset = "0x6840660", VA = "0x186841860")]
	public void KOOCCMCDOLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x26FEC70", Offset = "0x26FDA70", VA = "0x1826FEC70")]
	[CompilerGenerated]
	internal static string EJHCJDBPAAC<T>(byte[] KKAMOMBNLOJ, int FDGBOAPMAKJ, OBCPEIIKNIB<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal sealed class BDGGAMAIBAF : BOEKIHBNIFD
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class GEBPDDICEAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public GEBPDDICEAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x6864280", Offset = "0x6863080", VA = "0x186864280")]
		internal object BINFDPDIDCH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct CJCBGPGHFKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public BDGGAMAIBAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public CANPFPNADBJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private GAEAKKKNDMC <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private HLECMGBMBCM <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x68600C0", Offset = "0x685EEC0", VA = "0x1868600C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x6860990", Offset = "0x685F790", VA = "0x186860990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private struct CDDPKOABMJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public BDGGAMAIBAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private bool <omIsEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private bool <omShouldBeEnabled>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private TaskAwaiter<GGLDCNABNOB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		private TaskAwaiter<byte> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x685F0B0", Offset = "0x685DEB0", VA = "0x18685F0B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x685F840", Offset = "0x685E640", VA = "0x18685F840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private struct IONACFHCPKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public BDGGAMAIBAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private TaskAwaiter<BHFFEFMOLAM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x6868A80", Offset = "0x6867880", VA = "0x186868A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x6868D90", Offset = "0x6867B90", VA = "0x186868D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class MDEDBECOFFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public GAEAKKKNDMC presence;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public MDEDBECOFFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x686BDA0", Offset = "0x686ABA0", VA = "0x18686BDA0")]
		internal object FCKAFACIKEG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private static readonly JNOMMELLEMA LEDKGOEDJCM;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private static readonly JNOMMELLEMA LCNLHGDCFAA;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private static readonly JNOMMELLEMA EHHFJHJLFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	private readonly LLMIKIIPGIJ FFPJOPMJGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	private readonly OCJDEGLDIGA IICGEBFPJNO;

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x685D420", Offset = "0x685C220", VA = "0x18685D420")]
	public BDGGAMAIBAF(LLMIKIIPGIJ FFPJOPMJGFI, OCJDEGLDIGA IICGEBFPJNO, Guid GJAFHBAGEBC, KIAEAACOCKM CPCGINCDIDM, AGPIMNGHJGG PJFGANPBDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x685CF50", Offset = "0x685BD50", VA = "0x18685CF50", Slot = "7")]
	[AsyncStateMachine(typeof(CJCBGPGHFKD))]
	protected override Task ECDNPACFHNM(CANPFPNADBJ OJNAOMBNMBB, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x685D250", Offset = "0x685C050", VA = "0x18685D250")]
	[AsyncStateMachine(typeof(CDDPKOABMJG))]
	private Task PFKHKEDBBND(CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x685CE40", Offset = "0x685BC40", VA = "0x18685CE40")]
	[AsyncStateMachine(typeof(IONACFHCPKK))]
	private Task<byte> EANFAELNDCE(CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x685D090", Offset = "0x685BE90", VA = "0x18685D090")]
	private GAEAKKKNDMC MBPFJFNBGGN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
internal class FPBPJLAMGMC : BOEKIHBNIFD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct HJJEAKPIKKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public FPBPJLAMGMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public CANPFPNADBJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private TaskAwaiter<JCEJPJKGHOG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x6866090", Offset = "0x6864E90", VA = "0x186866090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x6866A00", Offset = "0x6865800", VA = "0x186866A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	private readonly int PPBAENMAMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	private readonly GAIIFIKOGEE OCFMBNHGGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public readonly long KCKKLGOLFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public readonly long JNOMGPFJHLH;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public JCEJPJKGHOG DFMLLDFGILL
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x7AE680", Offset = "0x7AD480", VA = "0x1807AE680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x7AE560", Offset = "0x7AD360", VA = "0x1807AE560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x6863FA0", Offset = "0x6862DA0", VA = "0x186863FA0")]
	public FPBPJLAMGMC(Guid GJAFHBAGEBC, KIAEAACOCKM CPCGINCDIDM, AGPIMNGHJGG PJFGANPBDOK, int PPBAENMAMEC, GAIIFIKOGEE OCFMBNHGGCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x6863E80", Offset = "0x6862C80", VA = "0x186863E80", Slot = "7")]
	[AsyncStateMachine(typeof(HJJEAKPIKKC))]
	protected override Task ECDNPACFHNM(CANPFPNADBJ OJNAOMBNMBB, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
internal abstract class JHGNKKMCIKF : BOEKIHBNIFD
{
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private sealed class OCABIEHGGLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public JHGNKKMCIKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public FFILBAPELNN playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public OCABIEHGGLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x686CA90", Offset = "0x686B890", VA = "0x18686CA90")]
		internal Task AANOGGLPFNG(DIMFGGHDEDI<string>.NJDBOGMFDFJ postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x686CAD0", Offset = "0x686B8D0", VA = "0x18686CAD0")]
		internal object LKBLLHOMJJP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private struct CHOLBDNOOIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public JHGNKKMCIKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public CANPFPNADBJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private OCABIEHGGLK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x685F8A0", Offset = "0x685E6A0", VA = "0x18685F8A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x6860060", Offset = "0x685EE60", VA = "0x186860060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private struct LMHAJKLFJJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public FFILBAPELNN playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public JHGNKKMCIKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x686B5F0", Offset = "0x686A3F0", VA = "0x18686B5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x686BB80", Offset = "0x686A980", VA = "0x18686BB80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x68691C0", Offset = "0x6867FC0", VA = "0x1868691C0")]
	public JHGNKKMCIKF(Guid GJAFHBAGEBC, KIAEAACOCKM CPCGINCDIDM, AGPIMNGHJGG PJFGANPBDOK, string PCEGJAODJOP, GCPKBMBFOIH KDMILBNDNEE, bool CDLNBNIJBOH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x6868F40", Offset = "0x6867D40", VA = "0x186868F40", Slot = "7")]
	[AsyncStateMachine(typeof(CHOLBDNOOIE))]
	protected override Task ECDNPACFHNM(CANPFPNADBJ OJNAOMBNMBB, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task LACDABDPMDB(CANPFPNADBJ OJNAOMBNMBB, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD);

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x6869080", Offset = "0x6867E80", VA = "0x186869080")]
	[AsyncStateMachine(typeof(LMHAJKLFJJJ))]
	private Task NMAGJLOICAC(IDisposable MPKEBCOMOGG, FFILBAPELNN OMICCDCNNGC, DIMFGGHDEDI<string>.NJDBOGMFDFJ DPOENBOPPGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal class CAOILHFKGDD : BOEKIHBNIFD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private struct PKBKJEKHGNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public CAOILHFKGDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public CANPFPNADBJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private TaskAwaiter<MEHGPBKCCCN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x6870670", Offset = "0x686F470", VA = "0x186870670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x6870BD0", Offset = "0x686F9D0", VA = "0x186870BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400039F")]
	private readonly ACEMKOMODMN LKDJIBAIBLB;

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x685F010", Offset = "0x685DE10", VA = "0x18685F010")]
	public CAOILHFKGDD(Guid GJAFHBAGEBC, KIAEAACOCKM CPCGINCDIDM, AGPIMNGHJGG PJFGANPBDOK, ACEMKOMODMN LKDJIBAIBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x685EF30", Offset = "0x685DD30", VA = "0x18685EF30", Slot = "6")]
	protected override string OIODBEBAMPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x685EE10", Offset = "0x685DC10", VA = "0x18685EE10", Slot = "7")]
	[AsyncStateMachine(typeof(PKBKJEKHGNA))]
	protected override Task ECDNPACFHNM(CANPFPNADBJ OJNAOMBNMBB, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal abstract class BOEKIHBNIFD : PNNOEIFPDFF
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	public delegate Task BCGFCNAPPKH(DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD);

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class MPBGHPLCPPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public BOEKIHBNIFD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public MPBGHPLCPPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x686C1E0", Offset = "0x686AFE0", VA = "0x18686C1E0")]
		internal Task JHMDEEKMLAL(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private sealed class GLOPLNAPGFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public MPBGHPLCPPL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public GLOPLNAPGFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x68653A0", Offset = "0x68641A0", VA = "0x1868653A0")]
		internal object OGJGFLLLCGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x68652E0", Offset = "0x68640E0", VA = "0x1868652E0")]
		internal object EJLLEGGFOHD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct KNJLPBOKPHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public BOEKIHBNIFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public Func<BOEKIHBNIFD, DIMFGGHDEDI<string>.NJDBOGMFDFJ, CANPFPNADBJ> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private MPBGHPLCPPL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private CANPFPNADBJ <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private TaskAwaiter<LDPKGMHDMGO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x6869E20", Offset = "0x6868C20", VA = "0x186869E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x686B020", Offset = "0x6869E20", VA = "0x18686B020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct KFNPEBDODND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x6869330", Offset = "0x6868130", VA = "0x186869330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x6869DC0", Offset = "0x6868BC0", VA = "0x186869DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct OLPIMELKKCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public BOEKIHBNIFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x686EB40", Offset = "0x686D940", VA = "0x18686EB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x686EEA0", Offset = "0x686DCA0", VA = "0x18686EEA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public readonly Guid MDALPHBHGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public readonly ByteString LHNLFNGCNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public readonly AGPIMNGHJGG CLFFKDOFFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	protected readonly string GNIGIDOGGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	private readonly KIAEAACOCKM CPCGINCDIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	private readonly bool CDLNBNIJBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private readonly Queue<BCGFCNAPPKH> FJBMBKDLJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private readonly IHGOAOGGGHG FPONCKHEIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	private readonly GCPKBMBFOIH KDMILBNDNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	private bool HDPACECKILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public ICBFKGNMMDL DODCJBLANLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public ICBFKGNMMDL LNOEPLHNMHJ;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public KIAEAACOCKM JCOLBCDBHEM
	{
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x7B1EF0", Offset = "0x7B0CF0", VA = "0x1807B1EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public PIJDGALKJHE PKCNFGEOGLO
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x685E3D0", Offset = "0x685D1D0", VA = "0x18685E3D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public DOANNFDMAAF CJBNCFNJCPE
	{
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x685DDA0", Offset = "0x685CBA0", VA = "0x18685DDA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public PAICLNCIIMP FABCENIMEEF
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x685E200", Offset = "0x685D000", VA = "0x18685E200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event DOELIBPJNPB EAHCNALPKDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x685E460", Offset = "0x685D260", VA = "0x18685E460", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x685E480", Offset = "0x685D280", VA = "0x18685E480", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x685E4A0", Offset = "0x685D2A0", VA = "0x18685E4A0")]
	protected BOEKIHBNIFD(Guid GJAFHBAGEBC, KIAEAACOCKM CPCGINCDIDM, AGPIMNGHJGG PJFGANPBDOK, string PCEGJAODJOP, GCPKBMBFOIH KDMILBNDNEE, bool CDLNBNIJBOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x685E420", Offset = "0x685D220", VA = "0x18685E420", Slot = "6")]
	protected virtual string OIODBEBAMPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x685DF00", Offset = "0x685CD00", VA = "0x18685DF00")]
	public void EHOALECMJOJ(BCGFCNAPPKH AKAIMONCJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x685DDF0", Offset = "0x685CBF0", VA = "0x18685DDF0")]
	protected void CGIDNMIJIBA(float OKKFAPHNPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x685DB30", Offset = "0x685C930", VA = "0x18685DB30")]
	[AsyncStateMachine(typeof(KNJLPBOKPHB))]
	public Task AHOFDHJJGBG(CancellationToken KANPDHELHMD, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, [Optional] Func<BOEKIHBNIFD, DIMFGGHDEDI<string>.NJDBOGMFDFJ, CANPFPNADBJ> LPDIDBCNCJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x685DF60", Offset = "0x685CD60", VA = "0x18685DF60")]
	[AsyncStateMachine(typeof(KFNPEBDODND))]
	private static Task EOJFDOCACJH(Func<CancellationToken, Task> OAMJHILDGDE, Func<CancellationToken, Task> AEELMMGFGML, CancellationToken DHIPGGMBELH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x685E280", Offset = "0x685D080", VA = "0x18685E280")]
	private void KHOEAPCEJOA(bool KINLMAENCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x685DE10", Offset = "0x685CC10", VA = "0x18685DE10")]
	private void COBOOFPAOCE(CANPFPNADBJ OJNAOMBNMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task ECDNPACFHNM(CANPFPNADBJ OJNAOMBNMBB, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD);

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x685DC80", Offset = "0x685CA80", VA = "0x18685DC80")]
	[AsyncStateMachine(typeof(OLPIMELKKCN))]
	private Task CALGCMMLDEA(DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x685E090", Offset = "0x685CE90", VA = "0x18685E090")]
	public LDPKGMHDMGO EPLHOALIDFE(IAGHONIGDIK PJLIMMBDFOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x685E110", Offset = "0x685CF10", VA = "0x18685E110")]
	[CompilerGenerated]
	private Task GDPPKOLOPOK(CancellationToken HKJAKBPEJHH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal sealed class OEKKEONJMPM : JHGNKKMCIKF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct CLPPFKBLACF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public OEKKEONJMPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public CANPFPNADBJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private PBCDELOMGHD <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private HLECMGBMBCM <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x68611F0", Offset = "0x685FFF0", VA = "0x1868611F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x6861960", Offset = "0x6860760", VA = "0x186861960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private readonly LLMIKIIPGIJ CLOJPJGBDLA;

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x686EA90", Offset = "0x686D890", VA = "0x18686EA90")]
	public OEKKEONJMPM(Guid GJAFHBAGEBC, KIAEAACOCKM CPCGINCDIDM, LLMIKIIPGIJ CLOJPJGBDLA, AGPIMNGHJGG PJFGANPBDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x686E940", Offset = "0x686D740", VA = "0x18686E940", Slot = "8")]
	[AsyncStateMachine(typeof(CLPPFKBLACF))]
	protected override Task LACDABDPMDB(CANPFPNADBJ OJNAOMBNMBB, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
internal class MABFDAEFPAA : BOEKIHBNIFD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct NEPDPIEJEMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public MABFDAEFPAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public CANPFPNADBJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private TaskAwaiter<MEHGPBKCCCN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x686C310", Offset = "0x686B110", VA = "0x18686C310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x686C6C0", Offset = "0x686B4C0", VA = "0x18686C6C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	private readonly string HKKNBOMGFEF;

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x686BCF0", Offset = "0x686AAF0", VA = "0x18686BCF0")]
	public MABFDAEFPAA(Guid GJAFHBAGEBC, KIAEAACOCKM CPCGINCDIDM, AGPIMNGHJGG PJFGANPBDOK, string HKKNBOMGFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x686BBE0", Offset = "0x686A9E0", VA = "0x18686BBE0", Slot = "7")]
	[AsyncStateMachine(typeof(NEPDPIEJEMO))]
	protected override Task ECDNPACFHNM(CANPFPNADBJ OJNAOMBNMBB, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
internal class CAJFHHGOGMK : JHGNKKMCIKF
{
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class FHMAFBLMKFK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000114")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public AsyncTaskMethodBuilder<LDPKGMHDMGO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public FHMAFBLMKFK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			private TaskAwaiter<MEHGPBKCCCN> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			private TaskAwaiter<LDPKGMHDMGO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x6873A60", Offset = "0x6872860", VA = "0x186873A60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0x6873F20", Offset = "0x6872D20", VA = "0x186873F20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public CAJFHHGOGMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public LNPMEJPNJDE serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public MAHEKPHEIFA roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public IOKIOMILIFK uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public HCNEBGIHOKG roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public FHMAFBLMKFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x6863D60", Offset = "0x6862B60", VA = "0x186863D60")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<LDPKGMHDMGO> ECJIALNLAGB(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private struct BAGIHJFGFEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public CAJFHHGOGMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public CANPFPNADBJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private FHMAFBLMKFK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private PBCDELOMGHD <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private HLECMGBMBCM <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private LDPKGMHDMGO <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private TaskAwaiter<LDPKGMHDMGO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x685BD40", Offset = "0x685AB40", VA = "0x18685BD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x685CC90", Offset = "0x685BA90", VA = "0x18685CC90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private static readonly JNOMMELLEMA LEDKGOEDJCM;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	private static readonly JNOMMELLEMA LCNLHGDCFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	private readonly int IHONMAEKGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	[CanBeNull]
	private readonly DDAACBOALJE KEGBFOEHEOI;

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x685ED60", Offset = "0x685DB60", VA = "0x18685ED60")]
	public CAJFHHGOGMK(Guid GJAFHBAGEBC, KIAEAACOCKM CPCGINCDIDM, int IHONMAEKGNO, DDAACBOALJE KEGBFOEHEOI, AGPIMNGHJGG PJFGANPBDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x685EB70", Offset = "0x685D970", VA = "0x18685EB70", Slot = "8")]
	[AsyncStateMachine(typeof(BAGIHJFGFEH))]
	protected override Task LACDABDPMDB(CANPFPNADBJ OJNAOMBNMBB, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x685EA70", Offset = "0x685D870", VA = "0x18685EA70")]
	private void JMAJFHIJJLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x685E8A0", Offset = "0x685D6A0", VA = "0x18685E8A0")]
	private void APAHCOGKEOC(DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, PBCDELOMGHD JBHCDECLMHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
internal abstract class AHGIELAAHNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public readonly BOEKIHBNIFD MOOEMJHBBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public readonly CANPFPNADBJ IOMELKAEONK;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public PIJDGALKJHE PKCNFGEOGLO
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x685A880", Offset = "0x6859680", VA = "0x18685A880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public PAICLNCIIMP FABCENIMEEF
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x685A7F0", Offset = "0x68595F0", VA = "0x18685A7F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x685A8F0", Offset = "0x68596F0", VA = "0x18685A8F0")]
	protected AHGIELAAHNK(CANPFPNADBJ OJNAOMBNMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x685A8D0", Offset = "0x68596D0", VA = "0x18685A8D0")]
	protected void OEJDKKHBHHB(string HBMAHABCPPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal struct DPGCEICFAEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public Dictionary<Guid, List<FOGLFKMOEIL>> DJADGNICAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public Dictionary<Guid, List<FOGLFKMOEIL>> MLGIJEAHAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public Dictionary<Guid, List<FOGLFKMOEIL>> GEBFDEHCJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public List<Guid> NKDHBGGMCEG;

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x68630F0", Offset = "0x6861EF0", VA = "0x1868630F0")]
	public static DPGCEICFAEF DJGCEJBDGHO(PIJDGALKJHE EEEILKJFPBG, ICBFKGNMMDL BKHGPIDMNJJ, OLDEKHHOPEO HFMKEAHAEFP)
	{
		return default(DPGCEICFAEF);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000119")]
internal struct GBPDFNLGLPI
{
	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240")]
	public static GBPDFNLGLPI ANGJMEBBFOG()
	{
		return default(GBPDFNLGLPI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal struct DPNENNHFMPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public readonly GGLDCNABNOB ADBAADHGFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public readonly DEONINFIMOK CAIKMHJAMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public readonly string EKOKIJAKHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public readonly PLDLJCNGAPD ALLJPLNAGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public readonly PLDLJCNGAPD MOCIDOBECLP;

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x68636F0", Offset = "0x68624F0", VA = "0x1868636F0")]
	public DPNENNHFMPP(GGLDCNABNOB ADBAADHGFJH, DEONINFIMOK CAIKMHJAMDG, string EKOKIJAKHED, PLDLJCNGAPD ALLJPLNAGKO, PLDLJCNGAPD MOCIDOBECLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal struct GAKBIGGFBFK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly CANPFPNADBJ OJNAOMBNMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private readonly Guid PKBEDCGHOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private bool KINLMAENCJL;

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x68641D0", Offset = "0x6862FD0", VA = "0x1868641D0")]
	public static GAKBIGGFBFK OKENNABPHAA(CANPFPNADBJ OJNAOMBNMBB)
	{
		return default(GAKBIGGFBFK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x819610", Offset = "0x818410", VA = "0x180819610")]
	public void DONJIMOLJJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x68640D0", Offset = "0x6862ED0", VA = "0x1868640D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x6864230", Offset = "0x6863030", VA = "0x186864230")]
	private GAKBIGGFBFK(CANPFPNADBJ OJNAOMBNMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x68640D0", Offset = "0x6862ED0", VA = "0x1868640D0")]
	private void ONALAIFLFME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x6864130", Offset = "0x6862F30", VA = "0x186864130")]
	private Func<Guid, bool> LFJBALKADJE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal class HLECMGBMBCM : AHGIELAAHNK, PNNOEIFPDFF
{
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	public delegate Task<ICBFKGNMMDL> EOIIKDCIOOH(OLDEKHHOPEO LHODDAGAJKC, ONCAPDNNLDO EFNPDKCFBJM, IHGOAOGGGHG JJJCMAKNBGA, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private struct DACMBKDEGNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public HLECMGBMBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public LLMIKIIPGIJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private GAKBIGGFBFK <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private TaskAwaiter<LDPKGMHDMGO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x6862490", Offset = "0x6861290", VA = "0x186862490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x6862C00", Offset = "0x6861A00", VA = "0x186862C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private struct HPAHNDLNHNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public AsyncTaskMethodBuilder<LDPKGMHDMGO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public HLECMGBMBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public LLMIKIIPGIJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private TaskAwaiter<LDPKGMHDMGO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x6868600", Offset = "0x6867400", VA = "0x186868600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x6868A10", Offset = "0x6867810", VA = "0x186868A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct ECEMMBFCFPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public HLECMGBMBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public LLMIKIIPGIJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x6863770", Offset = "0x6862570", VA = "0x186863770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x6863C00", Offset = "0x6862A00", VA = "0x186863C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private sealed class CJPLBFLOJOJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000122")]
		private struct <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			public AsyncTaskMethodBuilder<DPNENNHFMPP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			public CJPLBFLOJOJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			private DPNENNHFMPP <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			private TaskAwaiter<ICBFKGNMMDL> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			private TaskAwaiter<DPNENNHFMPP> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004FC")]
			[Cpp2IlInjected.Address(RVA = "0x6871FD0", Offset = "0x6870DD0", VA = "0x186871FD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FD")]
			[Cpp2IlInjected.Address(RVA = "0x6872760", Offset = "0x6871560", VA = "0x186872760", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			public AsyncTaskMethodBuilder<OLDEKHHOPEO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public CJPLBFLOJOJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			private OLDEKHHOPEO <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private TaskAwaiter<ICBFKGNMMDL> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			private TaskAwaiter<OLDEKHHOPEO> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60004FE")]
			[Cpp2IlInjected.Address(RVA = "0x68727D0", Offset = "0x68715D0", VA = "0x1868727D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FF")]
			[Cpp2IlInjected.Address(RVA = "0x6872F80", Offset = "0x6871D80", VA = "0x186872F80", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public CJPLBFLOJOJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			private TaskAwaiter<ICBFKGNMMDL> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			private ONCAPDNNLDO <timedYielder>5__2;

			[Cpp2IlInjected.Token(Token = "0x6000500")]
			[Cpp2IlInjected.Address(RVA = "0x6870C30", Offset = "0x686FA30", VA = "0x186870C30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000501")]
			[Cpp2IlInjected.Address(RVA = "0x6871F70", Offset = "0x6870D70", VA = "0x186871F70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public HLECMGBMBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public LLMIKIIPGIJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public IHGOAOGGGHG preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public IHGOAOGGGHG downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public DPNENNHFMPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public IHGOAOGGGHG postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public OLDEKHHOPEO phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public OIKFLJHMPGM.IPOBIDMEEFE <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public CJPLBFLOJOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x6860C20", Offset = "0x685FA20", VA = "0x186860C20")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<DPNENNHFMPP> OIKGKNPALHB(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x6860AF0", Offset = "0x685F8F0", VA = "0x186860AF0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<OLDEKHHOPEO> HGGANBGJGDE(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x6860D60", Offset = "0x685FB60", VA = "0x186860D60")]
		internal void POJFIHACMBJ(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x68609F0", Offset = "0x685F7F0", VA = "0x1868609F0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task AFHCLBCNINI(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct AHJGKLDLHLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public HLECMGBMBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public LLMIKIIPGIJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private CJPLBFLOJOJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private TaskAwaiter<DPNENNHFMPP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private TaskAwaiter<OLDEKHHOPEO> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x685A950", Offset = "0x6859750", VA = "0x18685A950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x685B540", Offset = "0x685A340", VA = "0x18685B540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct AMOLHGMFBKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public HLECMGBMBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x685B5A0", Offset = "0x685A3A0", VA = "0x18685B5A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x685BCE0", Offset = "0x685AAE0", VA = "0x18685BCE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct GMHBAFCHHMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public HLECMGBMBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public OLDEKHHOPEO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public IHGOAOGGGHG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private TaskAwaiter<ICBFKGNMMDL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x6865460", Offset = "0x6864260", VA = "0x186865460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x6865DC0", Offset = "0x6864BC0", VA = "0x186865DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct PDPLEBPPKKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public AsyncTaskMethodBuilder<ICBFKGNMMDL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public HLECMGBMBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public OLDEKHHOPEO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public IHGOAOGGGHG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private TaskAwaiter<ICBFKGNMMDL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x686F480", Offset = "0x686E280", VA = "0x18686F480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x6870600", Offset = "0x686F400", VA = "0x186870600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct ODIDOIIADOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public AsyncTaskMethodBuilder<ICBFKGNMMDL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public HLECMGBMBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public OLDEKHHOPEO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public IHGOAOGGGHG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public ONCAPDNNLDO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private TaskAwaiter<ICBFKGNMMDL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x686CB60", Offset = "0x686B960", VA = "0x18686CB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x686DF20", Offset = "0x686CD20", VA = "0x18686DF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct MNMOALIPMPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public AsyncTaskMethodBuilder<ICBFKGNMMDL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public HLECMGBMBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public ICBFKGNMMDL operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public IHGOAOGGGHG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public OLDEKHHOPEO deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private TaskAwaiter<ICBFKGNMMDL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x686BEE0", Offset = "0x686ACE0", VA = "0x18686BEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x686C170", Offset = "0x686AF70", VA = "0x18686C170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private sealed class JLDNPJJNEDB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012D")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			public AsyncTaskMethodBuilder<ICBFKGNMMDL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			public JLDNPJJNEDB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400049B")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400049C")]
			private HPLMCKJNNAF <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400049D")]
			private TaskAwaiter<ICBFKGNMMDL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000516")]
			[Cpp2IlInjected.Address(RVA = "0x6872FF0", Offset = "0x6871DF0", VA = "0x186872FF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0x6873600", Offset = "0x6872400", VA = "0x186873600", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public HLECMGBMBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public OLDEKHHOPEO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public IHGOAOGGGHG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public EOIIKDCIOOH masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public ONCAPDNNLDO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public ICBFKGNMMDL originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public JLDNPJJNEDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x6869210", Offset = "0x6868010", VA = "0x186869210")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<ICBFKGNMMDL> KGEBDGLGBEK(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct KPJKMHEMIIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public AsyncTaskMethodBuilder<ICBFKGNMMDL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public HLECMGBMBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public OLDEKHHOPEO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public IHGOAOGGGHG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public EOIIKDCIOOH masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public ONCAPDNNLDO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private HPLMCKJNNAF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private TaskAwaiter<ICBFKGNMMDL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x686B080", Offset = "0x6869E80", VA = "0x18686B080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x686B580", Offset = "0x686A380", VA = "0x18686B580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct BNPLEOFLBMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public HLECMGBMBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public OLDEKHHOPEO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public IHGOAOGGGHG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private ICBFKGNMMDL <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private IEnumerator<ICBFKGNMMDL> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private TaskAwaiter<ICBFKGNMMDL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x685D5B0", Offset = "0x685C3B0", VA = "0x18685D5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x685DAD0", Offset = "0x685C8D0", VA = "0x18685DAD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct NGJKNFGFCNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public HLECMGBMBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public OLDEKHHOPEO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x686C720", Offset = "0x686B520", VA = "0x18686C720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x686CA30", Offset = "0x686B830", VA = "0x18686CA30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private struct BOIMEGKBPGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public HLECMGBMBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public OLDEKHHOPEO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x685E600", Offset = "0x685D400", VA = "0x18685E600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x685E840", Offset = "0x685D640", VA = "0x18685E840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private readonly NNMEDCEFICD FDKLJIFAJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	private readonly NNMEDCEFICD GLKDOPBNGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private readonly PIILEDCECBM KPKCBMFEIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private readonly GKNCNNJEJJJ MFCDGJLDBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private readonly LPLJPLOFCAI EKKHBJIKPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400041A")]
	private readonly BFFFHIMMFJB INHEBBHBABM;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private KIAEAACOCKM JCOLBCDBHEM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x68672A0", Offset = "0x68660A0", VA = "0x1868672A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event DOELIBPJNPB EAHCNALPKDL
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x6868070", Offset = "0x6866E70", VA = "0x186868070", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x6868340", Offset = "0x6867140", VA = "0x186868340", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x6868360", Offset = "0x6867160", VA = "0x186868360")]
	public HLECMGBMBCM(CANPFPNADBJ OJNAOMBNMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x68681F0", Offset = "0x6866FF0", VA = "0x1868681F0")]
	[AsyncStateMachine(typeof(DACMBKDEGNN))]
	public Task PFIGLJDIHDB(LLMIKIIPGIJ AIAKOJMKOGA, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x6868090", Offset = "0x6866E90", VA = "0x186868090")]
	[AsyncStateMachine(typeof(HPAHNDLNHNG))]
	private Task<LDPKGMHDMGO> OPBKKOBNAJB(LLMIKIIPGIJ AIAKOJMKOGA, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x6867820", Offset = "0x6866620", VA = "0x186867820")]
	[AsyncStateMachine(typeof(ECEMMBFCFPL))]
	private Task LFBAEAOKCDP(LLMIKIIPGIJ AIAKOJMKOGA, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x68672D0", Offset = "0x68660D0", VA = "0x1868672D0")]
	[AsyncStateMachine(typeof(AHJGKLDLHLD))]
	private Task KBECCBDNFAH(LLMIKIIPGIJ AIAKOJMKOGA, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken JDHCGOIFFAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x6867AB0", Offset = "0x68668B0", VA = "0x186867AB0")]
	[AsyncStateMachine(typeof(AMOLHGMFBKN))]
	private Task LILCFHPPHJC(DIMFGGHDEDI<string>.NJDBOGMFDFJ DPOENBOPPGM, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x6867960", Offset = "0x6866760", VA = "0x186867960")]
	[AsyncStateMachine(typeof(GMHBAFCHHMD))]
	private Task LIACDPPNKAG(OLDEKHHOPEO LHODDAGAJKC, IHGOAOGGGHG JJJCMAKNBGA, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x6867D10", Offset = "0x6866B10", VA = "0x186867D10")]
	[AsyncStateMachine(typeof(PDPLEBPPKKJ))]
	private Task<ICBFKGNMMDL> LOIPAHJGHJG(OLDEKHHOPEO LHODDAGAJKC, ONCAPDNNLDO DGAMLDJJNKF, IHGOAOGGGHG JJJCMAKNBGA, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x6866B50", Offset = "0x6865950", VA = "0x186866B50")]
	[AsyncStateMachine(typeof(ODIDOIIADOH))]
	private Task<ICBFKGNMMDL> BGELKCMCHGJ(OLDEKHHOPEO LHODDAGAJKC, ONCAPDNNLDO DGAMLDJJNKF, IHGOAOGGGHG JJJCMAKNBGA, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x6867410", Offset = "0x6866210", VA = "0x186867410")]
	[AsyncStateMachine(typeof(MNMOALIPMPK))]
	private Task<ICBFKGNMMDL> KCGGOBKLPJA(ICBFKGNMMDL BKHGPIDMNJJ, OLDEKHHOPEO HFMKEAHAEFP, IHGOAOGGGHG JJJCMAKNBGA, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD, bool MBCECKGDEGH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x6866A60", Offset = "0x6865860", VA = "0x186866A60")]
	private bool AJPKIFGNDFJ(OLDEKHHOPEO JILFPILIPIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x6866D20", Offset = "0x6865B20", VA = "0x186866D20")]
	[AsyncStateMachine(typeof(KPJKMHEMIIO))]
	protected Task<ICBFKGNMMDL> DNLFNDBAOHN(OLDEKHHOPEO LHODDAGAJKC, ONCAPDNNLDO DGAMLDJJNKF, IHGOAOGGGHG JJJCMAKNBGA, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD, EOIIKDCIOOH OCDOOMELALK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x6867000", Offset = "0x6865E00", VA = "0x186867000")]
	[AsyncStateMachine(typeof(BNPLEOFLBMK))]
	private Task FHEIGLDMDIP(OLDEKHHOPEO LHODDAGAJKC, IHGOAOGGGHG JJJCMAKNBGA, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x6866CD0", Offset = "0x6865AD0", VA = "0x186866CD0")]
	private void BJPDEPIENLH(ICBFKGNMMDL HEEMFAHMPII, IHGOAOGGGHG JJJCMAKNBGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x6866EB0", Offset = "0x6865CB0", VA = "0x186866EB0")]
	private void EDFKJJFIMKA(ICBFKGNMMDL ONDOFCGBBCJ, [Out] ICBFKGNMMDL KAOGDPDJIMF, [Out] ICBFKGNMMDL FPFACNNIDHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x6868010", Offset = "0x6866E10", VA = "0x186868010")]
	private Task<DPNENNHFMPP> NPAGBNPONOK(LLMIKIIPGIJ AIAKOJMKOGA, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x6867FD0", Offset = "0x6866DD0", VA = "0x186867FD0")]
	private Task<OLDEKHHOPEO> NOLEMPJLOBJ(DPNENNHFMPP LHODDAGAJKC, OIKFLJHMPGM.IPOBIDMEEFE NEDHPPFFPGE, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x6867590", Offset = "0x6866390", VA = "0x186867590")]
	[AsyncStateMachine(typeof(NGJKNFGFCNM))]
	private Task KCINAGLLGBM(OLDEKHHOPEO LHODDAGAJKC, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD, bool FDCOENFMBEO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x6866F10", Offset = "0x6865D10", VA = "0x186866F10")]
	[AsyncStateMachine(typeof(BOIMEGKBPGI))]
	private Task FGODGPHIMAJ(OLDEKHHOPEO LHODDAGAJKC, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x68676E0", Offset = "0x68664E0", VA = "0x1868676E0")]
	private Task KOMCCNCHGMB(OLDEKHHOPEO LHODDAGAJKC, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x6867280", Offset = "0x6866080", VA = "0x186867280")]
	private Task IDDOLOFJPPM(OLDEKHHOPEO LHODDAGAJKC, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x6868050", Offset = "0x6866E50", VA = "0x186868050")]
	private Task NPNFFNMJDHI(OLDEKHHOPEO LHODDAGAJKC, ONCAPDNNLDO DGAMLDJJNKF, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x6867BC0", Offset = "0x68669C0", VA = "0x186867BC0")]
	private Task LMKAPOKLJLG(OLDEKHHOPEO LHODDAGAJKC, ONCAPDNNLDO DGAMLDJJNKF, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x68671A0", Offset = "0x6865FA0", VA = "0x1868671A0")]
	private static Task GLIMHDDDPJI(CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x6867E70", Offset = "0x6866C70", VA = "0x186867E70")]
	private Task MHFCLBHEOCM(OLDEKHHOPEO LHODDAGAJKC, ONCAPDNNLDO DGAMLDJJNKF, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x6867E90", Offset = "0x6866C90", VA = "0x186867E90")]
	private Task NNGHIJKBECA(OLDEKHHOPEO LHODDAGAJKC, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x6867150", Offset = "0x6865F50", VA = "0x186867150")]
	private void GIKLAPOIMEG(LLMIKIIPGIJ AIAKOJMKOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x6866EF0", Offset = "0x6865CF0", VA = "0x186866EF0")]
	public void EOHGCFOOGKM(long KOBEPCIBNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
	private static void CJMCKNBMDGI(GGLDCNABNOB ADBAADHGFJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal struct CKOMMAHNBMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	private KIAEAACOCKM CPCGINCDIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	private OLDEKHHOPEO LHODDAGAJKC;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private PIJDGALKJHE PKCNFGEOGLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x68611A0", Offset = "0x685FFA0", VA = "0x1868611A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x68610C0", Offset = "0x685FEC0", VA = "0x1868610C0")]
	public static Task AHOFDHJJGBG(KIAEAACOCKM CPCGINCDIDM, OLDEKHHOPEO LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x6860EB0", Offset = "0x685FCB0", VA = "0x186860EB0")]
	private void AHOFDHJJGBG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal struct KPNEBOOKMJD
{
	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x68671A0", Offset = "0x6865FA0", VA = "0x1868671A0")]
	public static Task AHOFDHJJGBG(CancellationToken KANPDHELHMD)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000134")]
internal struct JGHJHFCCDJE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct PABGANBGPEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public CANPFPNADBJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public OLDEKHHOPEO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private HPLMCKJNNAF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x686EF00", Offset = "0x686DD00", VA = "0x18686EF00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x686F420", Offset = "0x686E220", VA = "0x18686F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x6868E00", Offset = "0x6867C00", VA = "0x186868E00")]
	[AsyncStateMachine(typeof(PABGANBGPEG))]
	public static Task AHOFDHJJGBG(CANPFPNADBJ OJNAOMBNMBB, OLDEKHHOPEO LHODDAGAJKC, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal struct GLCJEGCBCBK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct GGGPPILFJKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public CANPFPNADBJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public OLDEKHHOPEO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public ONCAPDNNLDO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private ICBFKGNMMDL <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private KIAEAACOCKM <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private PIJDGALKJHE <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private HPLMCKJNNAF <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private List<(PersistenceView, DOPOCMMEPIO)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private DOPOCMMEPIO <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x68642F0", Offset = "0x68630F0", VA = "0x1868642F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x6864F40", Offset = "0x6863D40", VA = "0x186864F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x6864FA0", Offset = "0x6863DA0", VA = "0x186864FA0")]
	[AsyncStateMachine(typeof(GGGPPILFJKI))]
	public static Task AHOFDHJJGBG(CANPFPNADBJ OJNAOMBNMBB, OLDEKHHOPEO LHODDAGAJKC, ONCAPDNNLDO DGAMLDJJNKF, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x68650F0", Offset = "0x6863EF0", VA = "0x1868650F0")]
	private static void HCGBHFMDKDE(PersistenceView EJDIPDNLCEK, DOPOCMMEPIO NGOHHJIGFPK, OLDEKHHOPEO LHODDAGAJKC, ICBFKGNMMDL BKHGPIDMNJJ, bool GNFLBMIHEEL)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct CKGJAKILGLP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private struct DJMPKAKPLGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public KIAEAACOCKM roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public OLDEKHHOPEO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x6862C60", Offset = "0x6861A60", VA = "0x186862C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x6863090", Offset = "0x6861E90", VA = "0x186863090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x6860DA0", Offset = "0x685FBA0", VA = "0x186860DA0")]
	[AsyncStateMachine(typeof(DJMPKAKPLGF))]
	public static Task AHOFDHJJGBG(KIAEAACOCKM CPCGINCDIDM, OLDEKHHOPEO LHODDAGAJKC, CancellationToken KANPDHELHMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct DAAMBBGKDIL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct GNBDCCDANJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public KIAEAACOCKM roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public OLDEKHHOPEO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public CANPFPNADBJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x6865E20", Offset = "0x6864C20", VA = "0x186865E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x6866030", Offset = "0x6864E30", VA = "0x186866030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private sealed class AFNCBBPMFAK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200013E")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004F4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004F5")]
			public DIMFGGHDEDI<string>.NJDBOGMFDFJ timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F6")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004F7")]
			public AFNCBBPMFAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004F8")]
			private DIMFGGHDEDI<string>.NJDBOGMFDFJ <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004F9")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600053C")]
			[Cpp2IlInjected.Address(RVA = "0x6873670", Offset = "0x6872470", VA = "0x186873670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053D")]
			[Cpp2IlInjected.Address(RVA = "0x6873A00", Offset = "0x6872800", VA = "0x186873A00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public AFNCBBPMFAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x685A6D0", Offset = "0x68594D0", VA = "0x18685A6D0")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task DKAIIOPBCLH(DIMFGGHDEDI<string>.NJDBOGMFDFJ timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct OEBAAOCLJBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public DAAMBBGKDIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		private HPLMCKJNNAF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private TaskAwaiter<LDPKGMHDMGO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x686DF90", Offset = "0x686CD90", VA = "0x18686DF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x686E8E0", Offset = "0x686D6E0", VA = "0x18686E8E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private sealed class OLHJPKGLLPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public HLHGHFGIPAC version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public OLHJPKGLLPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x688C240", Offset = "0x688B040", VA = "0x18688C240")]
		internal object MCLFFHBKLGF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x688C190", Offset = "0x688AF90", VA = "0x18688C190")]
		internal object AFPNHODMMNE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private KIAEAACOCKM CPCGINCDIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	private OLDEKHHOPEO LHODDAGAJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	private CANPFPNADBJ OJNAOMBNMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	private bool FDCOENFMBEO;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	private static readonly ByteString NLLIDBANCJB;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private PIJDGALKJHE PKCNFGEOGLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x68623B0", Offset = "0x68611B0", VA = "0x1868623B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private PAICLNCIIMP FABCENIMEEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x6862310", Offset = "0x6861110", VA = "0x186862310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x68619C0", Offset = "0x68607C0", VA = "0x1868619C0")]
	[AsyncStateMachine(typeof(GNBDCCDANJF))]
	public static Task AHOFDHJJGBG(KIAEAACOCKM CPCGINCDIDM, OLDEKHHOPEO LHODDAGAJKC, CANPFPNADBJ OJNAOMBNMBB, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD, bool FDCOENFMBEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x6861B10", Offset = "0x6860910", VA = "0x186861B10")]
	[AsyncStateMachine(typeof(OEBAAOCLJBB))]
	private Task AHOFDHJJGBG(DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x6861C90", Offset = "0x6860A90", VA = "0x186861C90")]
	private void HJEDADFPKFO([NotNull] CCLFGPLFGKK FPNINNJGGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x6861C50", Offset = "0x6860A50", VA = "0x186861C50")]
	private bool EIFPDJHHFBK(HLHGHFGIPAC MIJEJKOAIDK, CCLFGPLFGKK FPNINNJGGGP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
internal struct CGKNNFKKBGH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct DHDDBJKLCFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public AsyncTaskMethodBuilder<OLDEKHHOPEO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public CGKNNFKKBGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public OIKFLJHMPGM.IPOBIDMEEFE downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private HPLMCKJNNAF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private TaskAwaiter<(PJPNKGNAEHO<BLCBLPPLECJ, PCJEOFJNKHC>, PJPNKGNAEHO<BLCPLJPDMPC<CCLFGPLFGKK>, PCJEOFJNKHC>, PJPNKGNAEHO<BLCPLJPDMPC<KDCMAGFKGCK>, PCJEOFJNKHC>, PJPNKGNAEHO<BLCPLJPDMPC<JDGGJOGFMEL>, PCJEOFJNKHC>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x687C7B0", Offset = "0x687B5B0", VA = "0x18687C7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x687D260", Offset = "0x687C060", VA = "0x18687D260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct FBDFHDOLLPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<BLCBLPPLECJ, PCJEOFJNKHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public CGKNNFKKBGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public OIKFLJHMPGM.IPOBIDMEEFE downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private HPLMCKJNNAF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		private TaskAwaiter<PJPNKGNAEHO<BLCBLPPLECJ, PCJEOFJNKHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x687EB10", Offset = "0x687D910", VA = "0x18687EB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x687F120", Offset = "0x687DF20", VA = "0x18687F120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	private HKIBPEHNKKM<PLDLJCNGAPD, KDCMAGFKGCK> HLDDAANFNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private HKIBPEHNKKM<PLDLJCNGAPD, CCLFGPLFGKK> PCHMJOLLPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	private HKIBPEHNKKM<long, JDGGJOGFMEL> KGPGJABCLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private GKGMGJLKJEB CAIFMGKFJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private GGLDCNABNOB ADBAADHGFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private DEONINFIMOK CAIKMHJAMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private string EKOKIJAKHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	private PLDLJCNGAPD ALLJPLNAGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	private PLDLJCNGAPD MOCIDOBECLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private long KOBEPCIBNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	private DIMFGGHDEDI<string>.NJDBOGMFDFJ DPOENBOPPGM;

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x687AD20", Offset = "0x6879B20", VA = "0x18687AD20")]
	public static Task<OLDEKHHOPEO> NNCECNGBBCE(KIAEAACOCKM CPCGINCDIDM, [In] DPNENNHFMPP LHODDAGAJKC, OIKFLJHMPGM.IPOBIDMEEFE NEDHPPFFPGE, DIMFGGHDEDI<string>.NJDBOGMFDFJ DPOENBOPPGM, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x687A9D0", Offset = "0x68797D0", VA = "0x18687A9D0")]
	[AsyncStateMachine(typeof(DHDDBJKLCFJ))]
	private Task<OLDEKHHOPEO> AHOFDHJJGBG(OIKFLJHMPGM.IPOBIDMEEFE NEDHPPFFPGE, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x687AB60", Offset = "0x6879960", VA = "0x18687AB60")]
	[AsyncStateMachine(typeof(FBDFHDOLLPH))]
	private Task<PJPNKGNAEHO<BLCBLPPLECJ, PCJEOFJNKHC>> HJMNPNDDPJJ(string EKOKIJAKHED, long KOBEPCIBNJP, long? EKMDOMOGGBC, long? LCDEHGNNMHO, OIKFLJHMPGM.IPOBIDMEEFE NEDHPPFFPGE, DIMFGGHDEDI<string>.NJDBOGMFDFJ GJKMJFAEELB, CancellationToken KANPDHELHMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
internal struct NPKOHGEOPKG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct IDDMFFKHHDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public AsyncTaskMethodBuilder<DPNENNHFMPP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public NPKOHGEOPKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private TaskAwaiter<DPNENNHFMPP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x6882520", Offset = "0x6881320", VA = "0x186882520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x6882920", Offset = "0x6881720", VA = "0x186882920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct MDPKLINAGEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public AsyncTaskMethodBuilder<DPNENNHFMPP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public NPKOHGEOPKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private TaskAwaiter<DPNENNHFMPP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x6887B90", Offset = "0x6886990", VA = "0x186887B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x6887FC0", Offset = "0x6886DC0", VA = "0x186887FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class CPOOHNEKGDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public CPOOHNEKGDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x14DFED0", Offset = "0x14DECD0", VA = "0x1814DFED0")]
		internal bool PLPGGPBIKIJ(DEONINFIMOK sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct BHAIENFPPKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public AsyncTaskMethodBuilder<DPNENNHFMPP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public PLDLJCNGAPD superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public PIJDGALKJHE callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private CPOOHNEKGDD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public DHEKBMONMEK roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private GGLDCNABNOB <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private DEONINFIMOK <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private PLDLJCNGAPD <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private PLDLJCNGAPD <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private TaskAwaiter<GGLDCNABNOB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private TaskAwaiter<AFHGGNKAGMJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private TaskAwaiter<BHFFEFMOLAM> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x6876D70", Offset = "0x6875B70", VA = "0x186876D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x6877EA0", Offset = "0x6876CA0", VA = "0x186877EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private PIJDGALKJHE EEEILKJFPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private PIILEDCECBM KPKCBMFEIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private DHEKBMONMEK JOFMIMPDDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private DIMFGGHDEDI<string>.NJDBOGMFDFJ DPOENBOPPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	private long EKMDOMOGGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	private long EEFFKLADGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private long KIBPONOCMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	private string NMGHGLDODNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	private PLDLJCNGAPD KPBJAHNLPNP;

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x6889F00", Offset = "0x6888D00", VA = "0x186889F00")]
	public static Task<DPNENNHFMPP> NNCECNGBBCE(KIAEAACOCKM CPCGINCDIDM, LLMIKIIPGIJ AIAKOJMKOGA, DIMFGGHDEDI<string>.NJDBOGMFDFJ DPOENBOPPGM, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x6889D80", Offset = "0x6888B80", VA = "0x186889D80")]
	[AsyncStateMachine(typeof(IDDMFFKHHDG))]
	private Task<DPNENNHFMPP> AHOFDHJJGBG(CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x688A310", Offset = "0x6889110", VA = "0x18688A310")]
	[AsyncStateMachine(typeof(MDPKLINAGEM))]
	private Task<DPNENNHFMPP> NPAGBNPONOK(DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x688A170", Offset = "0x6888F70", VA = "0x18688A170")]
	[AsyncStateMachine(typeof(BHAIENFPPKN))]
	private static Task<DPNENNHFMPP> NPAGBNPONOK(PIJDGALKJHE EEEILKJFPBG, DHEKBMONMEK JOFMIMPDDBH, long EKMDOMOGGBC, long EEFFKLADGPB, long KIBPONOCMID, string NMGHGLDODNE, PLDLJCNGAPD KPBJAHNLPNP, CancellationToken KANPDHELHMD, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x6889ED0", Offset = "0x6888CD0", VA = "0x186889ED0")]
	private void ICJPNNFEGFN(GGLDCNABNOB ADBAADHGFJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal struct FOABOBOBKGM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct OGBINBBHBJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public FOABOBOBKGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x688AC00", Offset = "0x6889A00", VA = "0x18688AC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x688B190", Offset = "0x6889F90", VA = "0x18688B190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	private PIJDGALKJHE EEEILKJFPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	private OLDEKHHOPEO LHODDAGAJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	private DIMFGGHDEDI<string>.NJDBOGMFDFJ DPOENBOPPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	private float JFCLKLNHKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	private float JOJLCPCNLOH;

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x68804B0", Offset = "0x687F2B0", VA = "0x1868804B0")]
	public static Task FIEGJFBDADG(KIAEAACOCKM CPCGINCDIDM, OLDEKHHOPEO LHODDAGAJKC, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x6880040", Offset = "0x687EE40", VA = "0x186880040")]
	[AsyncStateMachine(typeof(OGBINBBHBJM))]
	public Task AHOFDHJJGBG(CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x6880380", Offset = "0x687F180", VA = "0x186880380")]
	private static void DLPNPFJLNCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x6880160", Offset = "0x687EF60", VA = "0x186880160")]
	private void APOFHBHIGLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x68802C0", Offset = "0x687F0C0", VA = "0x1868802C0")]
	private static float BAKAGKJFDJK(PIJDGALKJHE EEEILKJFPBG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x6880650", Offset = "0x687F450", VA = "0x186880650")]
	private static float JIPKJJJGDDE()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal struct IOJHOIKAHJM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct BOMGIEMPBLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public CANPFPNADBJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public OLDEKHHOPEO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private HPLMCKJNNAF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private BOEKIHBNIFD <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private KIAEAACOCKM <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private AJJGJMDLFHN.IMJAGDCDNGF <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private TaskAwaiter<LDPKGMHDMGO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x68796C0", Offset = "0x68784C0", VA = "0x1868796C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x687A060", Offset = "0x6878E60", VA = "0x18687A060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct OIPOEENDKOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private HPLMCKJNNAF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x688BE40", Offset = "0x688AC40", VA = "0x18688BE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x688C130", Offset = "0x688AF30", VA = "0x18688C130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x6883960", Offset = "0x6882760", VA = "0x186883960")]
	[AsyncStateMachine(typeof(BOMGIEMPBLA))]
	public static Task AHOFDHJJGBG(CANPFPNADBJ OJNAOMBNMBB, OLDEKHHOPEO LHODDAGAJKC, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x6883AA0", Offset = "0x68828A0", VA = "0x186883AA0")]
	private static Task<LDPKGMHDMGO> CDLFHNMLNEJ(CANPFPNADBJ OJNAOMBNMBB, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x6883B10", Offset = "0x6882910", VA = "0x186883B10")]
	[AsyncStateMachine(typeof(OIPOEENDKOJ))]
	private static Task PJJGFDIFFNP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
internal struct DOBDIHEBOIJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct OCOFOPDCGFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public DOBDIHEBOIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x688A470", Offset = "0x6889270", VA = "0x18688A470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x688AB20", Offset = "0x6889920", VA = "0x18688AB20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private sealed class OEGMNLHHAKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public OEGMNLHHAKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x688AB80", Offset = "0x6889980", VA = "0x18688AB80")]
		internal object GBAGKHFOHIE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct PLPFNCMBDJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public DOBDIHEBOIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private HPLMCKJNNAF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private JNOKAMMOPIN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x688D570", Offset = "0x688C370", VA = "0x18688D570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x688DB30", Offset = "0x688C930", VA = "0x18688DB30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	private bool DBFGECBDKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000573")]
	private DIMFGGHDEDI<string>.NJDBOGMFDFJ DPOENBOPPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000574")]
	private KIAEAACOCKM CPCGINCDIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000575")]
	private CancellationToken KANPDHELHMD;

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x687D3C0", Offset = "0x687C1C0", VA = "0x18687D3C0")]
	public static Task DBJKCOMMHGP(KIAEAACOCKM CPCGINCDIDM, bool DBFGECBDKGF, DIMFGGHDEDI<string>.NJDBOGMFDFJ DPOENBOPPGM, CancellationToken BILMPCDIOME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x687D2D0", Offset = "0x687C0D0", VA = "0x18687D2D0")]
	[AsyncStateMachine(typeof(OCOFOPDCGFP))]
	private Task AHOFDHJJGBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x687D430", Offset = "0x687C230", VA = "0x18687D430")]
	[AsyncStateMachine(typeof(PLPFNCMBDJO))]
	private Task PIPCLGHBDFP(bool FHFALKBLLEO, string ONFIFMPHJHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240")]
	private bool NNHFHAOIHNP(bool DBFGECBDKGF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal struct BCCBMBDECIH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct OIGFKGCFBPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public BCCBMBDECIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x688B860", Offset = "0x688A660", VA = "0x18688B860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x688BDD0", Offset = "0x688ABD0", VA = "0x18688BDD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private sealed class CBKLOBEFFHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public CBKLOBEFFHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x687A890", Offset = "0x6879690", VA = "0x18687A890")]
		internal object GBAGKHFOHIE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct JJIFLMLCFED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public BCCBMBDECIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private HPLMCKJNNAF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private JNOKAMMOPIN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x6885030", Offset = "0x6883E30", VA = "0x186885030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x68855F0", Offset = "0x68843F0", VA = "0x1868855F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000586")]
	private COOBEHIAGKA KJIAAMCMIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000587")]
	private DIMFGGHDEDI<string>.NJDBOGMFDFJ DPOENBOPPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000588")]
	private KIAEAACOCKM CPCGINCDIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000589")]
	private bool BCNKNBLBBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400058A")]
	private OLDEKHHOPEO LHODDAGAJKC;

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x68768B0", Offset = "0x68756B0", VA = "0x1868768B0")]
	public static Task<Scene> AMKJKPLOEPA(KIAEAACOCKM CPCGINCDIDM, COOBEHIAGKA NDGADFHLJLL, DIMFGGHDEDI<string>.NJDBOGMFDFJ DPOENBOPPGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x6876790", Offset = "0x6875590", VA = "0x186876790")]
	[AsyncStateMachine(typeof(OIGFKGCFBPK))]
	private Task<Scene> AHOFDHJJGBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x6876930", Offset = "0x6875730", VA = "0x186876930")]
	private bool LIKDPLCLGBO(OLDEKHHOPEO LHODDAGAJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x6876AB0", Offset = "0x68758B0", VA = "0x186876AB0")]
	private void POIHANBDJHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x6876960", Offset = "0x6875760", VA = "0x186876960")]
	[AsyncStateMachine(typeof(JJIFLMLCFED))]
	private Task<Scene> PIPCLGHBDFP(string ONFIFMPHJHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
internal struct LPLJPLOFCAI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct IKLIGINJOJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public AsyncTaskMethodBuilder<ICBFKGNMMDL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public LPLJPLOFCAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public ICBFKGNMMDL nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public OLDEKHHOPEO deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private TaskAwaiter<ICBFKGNMMDL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x6882E10", Offset = "0x6881C10", VA = "0x186882E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x68838F0", Offset = "0x68826F0", VA = "0x1868838F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct CIGBFMDGOPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public AsyncTaskMethodBuilder<ICBFKGNMMDL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public LPLJPLOFCAI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public ICBFKGNMMDL state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		private TaskAwaiter<LDPKGMHDMGO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x687B080", Offset = "0x6879E80", VA = "0x18687B080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x687B360", Offset = "0x687A160", VA = "0x18687B360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000598")]
	private readonly CANPFPNADBJ OJNAOMBNMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000599")]
	private readonly PIILEDCECBM KPKCBMFEIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400059A")]
	private readonly GKNCNNJEJJJ MFCDGJLDBML;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private BOEKIHBNIFD MOOEMJHBBLH
	{
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x50ED600", Offset = "0x50EC400", VA = "0x1850ED600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x6887B30", Offset = "0x6886930", VA = "0x186887B30")]
	public LPLJPLOFCAI(CANPFPNADBJ OJNAOMBNMBB, PIILEDCECBM KPKCBMFEIKA, GKNCNNJEJJJ MFCDGJLDBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x6887800", Offset = "0x6886600", VA = "0x186887800")]
	[AsyncStateMachine(typeof(IKLIGINJOJF))]
	public Task<ICBFKGNMMDL> FFIJMCKGIAK(ICBFKGNMMDL KLMFCBJMONM, OLDEKHHOPEO HFMKEAHAEFP, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD, bool MBCECKGDEGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x68879B0", Offset = "0x68867B0", VA = "0x1868879B0")]
	[AsyncStateMachine(typeof(CIGBFMDGOPB))]
	private Task<ICBFKGNMMDL> NJDFFCEMLKM(DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, ICBFKGNMMDL DEPIDMABJHK, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x6887980", Offset = "0x6886780", VA = "0x186887980")]
	private bool JHBBCDGHPNJ(ICBFKGNMMDL LEEMEHHEGKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x6887B10", Offset = "0x6886910", VA = "0x186887B10")]
	private void OEJDKKHBHHB(string DAMMFDJOPGA)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct PLMDKNAEANG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct OHBAIDHJBKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public BOEKIHBNIFD operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public OLDEKHHOPEO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public ONCAPDNNLDO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private HPLMCKJNNAF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		private List<(PersistenceView, DOPOCMMEPIO)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private (PersistenceView, DOPOCMMEPIO) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x688B1F0", Offset = "0x6889FF0", VA = "0x18688B1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x688B800", Offset = "0x688A600", VA = "0x18688B800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x688D430", Offset = "0x688C230", VA = "0x18688D430")]
	[AsyncStateMachine(typeof(OHBAIDHJBKL))]
	public static Task AHOFDHJJGBG(BOEKIHBNIFD OLONHMONGPM, OLDEKHHOPEO LHODDAGAJKC, ONCAPDNNLDO DGAMLDJJNKF, CancellationToken KANPDHELHMD)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal struct NEILCNLBIMA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct EMJDKLLEEKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public BOEKIHBNIFD operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public OLDEKHHOPEO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public ONCAPDNNLDO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private HLHGHFGIPAC <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private HPLMCKJNNAF <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		private List<(PersistenceView, DOPOCMMEPIO)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		private DOPOCMMEPIO <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x687E260", Offset = "0x687D060", VA = "0x18687E260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x687EAB0", Offset = "0x687D8B0", VA = "0x18687EAB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x6888F60", Offset = "0x6887D60", VA = "0x186888F60")]
	[AsyncStateMachine(typeof(EMJDKLLEEKO))]
	public static Task AHOFDHJJGBG(BOEKIHBNIFD OLONHMONGPM, OLDEKHHOPEO LHODDAGAJKC, ONCAPDNNLDO DGAMLDJJNKF, CancellationToken KANPDHELHMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal struct AJJGJMDLFHN
{
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	public struct IMJAGDCDNGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public List<IEAONBGGGDD> DDBPLIAJCND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public List<DOPOCMMEPIO> HGDDMPJIJBO;

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x93C520", Offset = "0x93B320", VA = "0x18093C520")]
		public IMJAGDCDNGF(List<IEAONBGGGDD> DDBPLIAJCND, List<DOPOCMMEPIO> HGDDMPJIJBO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class LAHNACCNLKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public IEnumerable<IEAONBGGGDD> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public LAHNACCNLKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x6885D10", Offset = "0x6884B10", VA = "0x186885D10")]
		internal object AADBHEALGBM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private KIAEAACOCKM CPCGINCDIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C8")]
	private OLDEKHHOPEO LHODDAGAJKC;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private PIJDGALKJHE PKCNFGEOGLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x68761B0", Offset = "0x6874FB0", VA = "0x1868761B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x6875780", Offset = "0x6874580", VA = "0x186875780")]
	public static IMJAGDCDNGF AHOFDHJJGBG(KIAEAACOCKM CPCGINCDIDM, OLDEKHHOPEO LHODDAGAJKC)
	{
		return default(IMJAGDCDNGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x68757E0", Offset = "0x68745E0", VA = "0x1868757E0")]
	private IMJAGDCDNGF AHOFDHJJGBG()
	{
		return default(IMJAGDCDNGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x6875C00", Offset = "0x6874A00", VA = "0x186875C00")]
	private IMJAGDCDNGF KMHJHIKLIDB(CCLFGPLFGKK FPNINNJGGGP, HLHGHFGIPAC DMPLLLPADHC)
	{
		return default(IMJAGDCDNGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x6875A30", Offset = "0x6874830", VA = "0x186875A30")]
	private bool HHGBCOBMMKD(IEnumerable<IEAONBGGGDD> DDBPLIAJCND)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000161")]
internal struct GBCJHICOCFD
{
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class KBFALHBIHKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public AJJGJMDLFHN.IMJAGDCDNGF instantiations;

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public KBFALHBIHKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x6885660", Offset = "0x6884460", VA = "0x186885660")]
		internal object DKAIIOPBCLH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private sealed class IPFJOAHHOLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public IPFJOAHHOLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x68842B0", Offset = "0x68830B0", VA = "0x1868842B0")]
		internal object JHMDEEKMLAL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x6880670", Offset = "0x687F470", VA = "0x186880670")]
	public static void AHOFDHJJGBG(BOEKIHBNIFD OLONHMONGPM, OLDEKHHOPEO LHODDAGAJKC, AJJGJMDLFHN.IMJAGDCDNGF IAOOKGHGLND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
internal class GKNCNNJEJJJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct CBJGNFHEMNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public GKNCNNJEJJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public ICBFKGNMMDL operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public OLDEKHHOPEO deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x687A0C0", Offset = "0x6878EC0", VA = "0x18687A0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x687A830", Offset = "0x6879630", VA = "0x18687A830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private sealed class CDDOEPDFCJD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000167")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005DD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005DE")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005DF")]
			public CDDOEPDFCJD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005E0")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005E1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x688DD90", Offset = "0x688CB90", VA = "0x18688DD90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AF")]
			[Cpp2IlInjected.Address(RVA = "0x688E050", Offset = "0x688CE50", VA = "0x18688E050", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public GKNCNNJEJJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public OLDEKHHOPEO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public CDDOEPDFCJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x687A8E0", Offset = "0x68796E0", VA = "0x18687A8E0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task MIADJGAFAPE(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct KHFKPLONGJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public GKNCNNJEJJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public OLDEKHHOPEO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		private CDDOEPDFCJD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x6885780", Offset = "0x6884580", VA = "0x186885780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x6885CB0", Offset = "0x6884AB0", VA = "0x186885CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct JHKEMACHHKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public GKNCNNJEJJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public OLDEKHHOPEO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		private Dictionary<Guid, List<FOGLFKMOEIL>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x6884A20", Offset = "0x6883820", VA = "0x186884A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x6884FD0", Offset = "0x6883DD0", VA = "0x186884FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct IPLPNGFOAJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public GKNCNNJEJJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public OLDEKHHOPEO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private Dictionary<Guid, List<FOGLFKMOEIL>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x6884340", Offset = "0x6883140", VA = "0x186884340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x68849C0", Offset = "0x68837C0", VA = "0x1868849C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class BLCOFHOLJPN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016C")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000601")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000602")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000603")]
			public FOGLFKMOEIL handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000604")]
			public BLCOFHOLJPN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000605")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0x688DB90", Offset = "0x688C990", VA = "0x18688DB90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BB")]
			[Cpp2IlInjected.Address(RVA = "0x688DD30", Offset = "0x688CB30", VA = "0x18688DD30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public GIMNDFMJAKA runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public List<FOGLFKMOEIL> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public OLDEKHHOPEO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public BLCOFHOLJPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x6878C20", Offset = "0x6877A20", VA = "0x186878C20")]
		internal object FMJJGLHOCMB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x6878D10", Offset = "0x6877B10", VA = "0x186878D10")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task PEBOFANIIGE(FOGLFKMOEIL handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x6878B30", Offset = "0x6877930", VA = "0x186878B30")]
		internal object EGADELKCIJL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private struct DFFAMHFMPPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public GIMNDFMJAKA runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public List<FOGLFKMOEIL> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public OLDEKHHOPEO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		private BLCOFHOLJPN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x687C290", Offset = "0x687B090", VA = "0x18687C290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x687C750", Offset = "0x687B550", VA = "0x18687C750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private struct EJFAPODJMOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public GKNCNNJEJJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public OLDEKHHOPEO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x687DC40", Offset = "0x687CA40", VA = "0x18687DC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x687E200", Offset = "0x687D000", VA = "0x18687E200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private sealed class ALOILKANAJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public ALOILKANAJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x6876200", Offset = "0x6875000", VA = "0x186876200")]
		internal object DJKKLNOICON()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct ANKAODEKNKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public GKNCNNJEJJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public OLDEKHHOPEO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		private HPLMCKJNNAF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x6876270", Offset = "0x6875070", VA = "0x186876270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x6876730", Offset = "0x6875530", VA = "0x186876730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class LFLJKGAHOLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public LFLJKGAHOLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x6885D90", Offset = "0x6884B90", VA = "0x186885D90")]
		internal object NMNCEBMNKDH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct PCEGJALGKDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public GKNCNNJEJJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		private HPLMCKJNNAF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		private TaskAwaiter<LDPKGMHDMGO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x688C320", Offset = "0x688B120", VA = "0x18688C320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x688C950", Offset = "0x688B750", VA = "0x18688C950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private sealed class AFHHMLGOCNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public AFHHMLGOCNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x6874730", Offset = "0x6873530", VA = "0x186874730")]
		internal object LCOOFGEBLLP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private readonly CANPFPNADBJ OJNAOMBNMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	private DPGCEICFAEF MFCDGJLDBML;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private BOEKIHBNIFD MOOEMJHBBLH
	{
		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x10B0D10", Offset = "0x10AFB10", VA = "0x1810B0D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B0AB0", VA = "0x1807B1CB0")]
	public GKNCNNJEJJJ(CANPFPNADBJ OJNAOMBNMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x6880D60", Offset = "0x687FB60", VA = "0x186880D60")]
	[AsyncStateMachine(typeof(CBJGNFHEMNG))]
	public Task AHOFDHJJGBG(ICBFKGNMMDL BKHGPIDMNJJ, OLDEKHHOPEO HFMKEAHAEFP, DIMFGGHDEDI<string>.NJDBOGMFDFJ DPOENBOPPGM, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x68812D0", Offset = "0x68800D0", VA = "0x1868812D0")]
	[AsyncStateMachine(typeof(KHFKPLONGJM))]
	private Task JBFEMKLOHBP(OLDEKHHOPEO LHODDAGAJKC, DIMFGGHDEDI<string>.NJDBOGMFDFJ DPOENBOPPGM, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x6881600", Offset = "0x6880400", VA = "0x186881600")]
	[AsyncStateMachine(typeof(JHKEMACHHKM))]
	private Task LBMLNGCPBCL(OLDEKHHOPEO LHODDAGAJKC, DIMFGGHDEDI<string>.NJDBOGMFDFJ DPOENBOPPGM, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x6881740", Offset = "0x6880540", VA = "0x186881740")]
	[AsyncStateMachine(typeof(IPLPNGFOAJM))]
	private Task MHAHFNGLMFC(OLDEKHHOPEO LHODDAGAJKC, DIMFGGHDEDI<string>.NJDBOGMFDFJ DPOENBOPPGM, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x6880EB0", Offset = "0x687FCB0", VA = "0x186880EB0")]
	[AsyncStateMachine(typeof(DFFAMHFMPPP))]
	private Task BOOJIEIOLPP(Guid LCEFBCPFJLM, List<FOGLFKMOEIL> DGNFOPBDDJM, GIMNDFMJAKA ANGAKLGMJOI, OLDEKHHOPEO LHODDAGAJKC, CancellationToken ADNDMAGEPOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x68814C0", Offset = "0x68802C0", VA = "0x1868814C0")]
	[AsyncStateMachine(typeof(EJFAPODJMOJ))]
	private Task JLKPFAKAJJG(OLDEKHHOPEO LHODDAGAJKC, DIMFGGHDEDI<string>.NJDBOGMFDFJ DPOENBOPPGM, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x6881000", Offset = "0x687FE00", VA = "0x186881000")]
	[AsyncStateMachine(typeof(ANKAODEKNKK))]
	private Task FOGKJJMMKDL(Guid CKPBKOCDLNF, OLDEKHHOPEO LHODDAGAJKC, DIMFGGHDEDI<string>.NJDBOGMFDFJ DPOENBOPPGM, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x6880C20", Offset = "0x687FA20", VA = "0x186880C20")]
	[AsyncStateMachine(typeof(PCEGJALGKDM))]
	private Task AFPEMHHADHJ(Guid CKPBKOCDLNF, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x6881A50", Offset = "0x6880850", VA = "0x186881A50")]
	private void PEFJHPACNJI(Guid CKPBKOCDLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x6881410", Offset = "0x6880210", VA = "0x186881410")]
	private void JHJKDNEPNOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x6881140", Offset = "0x687FF40", VA = "0x186881140")]
	public Guid GNIHPBNJFLB(ICBFKGNMMDL HEEMFAHMPII)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x6881880", Offset = "0x6880680", VA = "0x186881880")]
	[CompilerGenerated]
	private object OBJJAABPAGL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
public readonly struct HCNEBGIHOKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400062D")]
	public readonly bool CCJFOBFHKHK;

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0xCAAFD0", Offset = "0xCA9DD0", VA = "0x180CAAFD0")]
	public HCNEBGIHOKG(bool MIMOFCAOFDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
public readonly struct MEHGPBKCCCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400062E")]
	public readonly CCLFGPLFGKK? KPLBOIOBCBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400062F")]
	public readonly EKHBGJIDFDE LIPJDJIIKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000630")]
	public readonly string? EFCPABFKMCK;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public IReadOnlyCollection<string> GGGLGHLGFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x6888030", Offset = "0x6886E30", VA = "0x186888030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public IReadOnlyDictionary<long, int> KOAOBIJEMKK
	{
		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x6888050", Offset = "0x6886E50", VA = "0x186888050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x6888070", Offset = "0x6886E70", VA = "0x186888070")]
	public MEHGPBKCCCN(CCLFGPLFGKK? EEKNEAJDFKG, EKHBGJIDFDE FGFOPOGNDPK, string? EKOKIJAKHED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
internal class LNPMEJPNJDE : AHGIELAAHNK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct MJGAKLBJDHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public AsyncTaskMethodBuilder<MEHGPBKCCCN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public LNPMEJPNJDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public MPENOININPH serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public MAHEKPHEIFA roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private HPLMCKJNNAF <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x6888210", Offset = "0x6887010", VA = "0x186888210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x6888880", Offset = "0x6887680", VA = "0x186888880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class DBJOGALIENO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public MPENOININPH serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public LNPMEJPNJDE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public DBJOGALIENO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x687BC80", Offset = "0x687AA80", VA = "0x18687BC80")]
		internal Task IIHNPCGJACM(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x687BE90", Offset = "0x687AC90", VA = "0x18687BE90")]
		internal Task NGCKDPIFCLI(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private sealed class EAADBDBGGFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public DBJOGALIENO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public EAADBDBGGFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x687D9F0", Offset = "0x687C7F0", VA = "0x18687D9F0")]
		internal object OBCPOPKLNNF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private sealed class ECENFOGFCKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public DBJOGALIENO CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public ECENFOGFCKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x687DA60", Offset = "0x687C860", VA = "0x18687DA60")]
		internal Task NGHFPGPFNHM(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct BMBKFJMDNNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public MPENOININPH serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public LNPMEJPNJDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		private EAADBDBGGFP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		private HPLMCKJNNAF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x6878E00", Offset = "0x6877C00", VA = "0x186878E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x6879660", Offset = "0x6878460", VA = "0x186879660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000631")]
	private readonly JNOMMELLEMA LEDKGOEDJCM;

	[Cpp2IlInjected.Token(Token = "0x4000632")]
	private static readonly TimeSpan KBCNMDBKNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000633")]
	private readonly EMCPEKIBHEL AOFNHBFOLLO;

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x68872F0", Offset = "0x68860F0", VA = "0x1868872F0")]
	public LNPMEJPNJDE(CANPFPNADBJ OJNAOMBNMBB, EMCPEKIBHEL AOFNHBFOLLO, JNOMMELLEMA LEDKGOEDJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x68864A0", Offset = "0x68852A0", VA = "0x1868864A0")]
	[AsyncStateMachine(typeof(MJGAKLBJDHD))]
	public Task<MEHGPBKCCCN> JPFDICAGNEF(long EEFFKLADGPB, MAHEKPHEIFA CJENGHADNMC, MPENOININPH GFKKIHICKLH, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x6886210", Offset = "0x6885010", VA = "0x186886210")]
	[AsyncStateMachine(typeof(BMBKFJMDNNJ))]
	private Task FDKIDIKFMIA(MPENOININPH GFKKIHICKLH, IEnumerable<PersistenceView> CDFNDFLOFGG, StringBuilder BAKPGDEMMEC, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x6886CE0", Offset = "0x6885AE0", VA = "0x186886CE0")]
	private MEHGPBKCCCN NHLAHELHJBL(long EEFFKLADGPB, MAHEKPHEIFA CJENGHADNMC, MPENOININPH GFKKIHICKLH, IEnumerable<PersistenceView> CDFNDFLOFGG, StringBuilder BAKPGDEMMEC)
	{
		return default(MEHGPBKCCCN);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x6886350", Offset = "0x6885150", VA = "0x186886350")]
	private CCLFGPLFGKK HCOLIFFBONP(long EEFFKLADGPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x6886A90", Offset = "0x6885890", VA = "0x186886A90")]
	private void MEOKLJDOHEI(CCLFGPLFGKK LFJBCNDLOGO, StringBuilder BAKPGDEMMEC, IEnumerable<PersistenceView> CDFNDFLOFGG, [In] AIJJFMGMGOD NKICMCMFAIB, KLEKDAMEDMN GCCCGIENACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x6886600", Offset = "0x6885400", VA = "0x186886600")]
	private void LBJCABDMPMH(CCLFGPLFGKK LFJBCNDLOGO, StringBuilder BAKPGDEMMEC, PersistenceView EJDIPDNLCEK, KLEKDAMEDMN GCCCGIENACK, [In] AIJJFMGMGOD NKICMCMFAIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal class IOKIOMILIFK : AHGIELAAHNK
{
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private sealed class AALFCBFPNPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public NMEELHLCCAH.AENCKPECJMJ roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public AALFCBFPNPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x6874360", Offset = "0x6873160", VA = "0x186874360")]
		internal object AENMKMKOKHK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct FDPKIEPMNHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public AsyncTaskMethodBuilder<(NMEELHLCCAH.AENCKPECJMJ roomDataUpload, NMEELHLCCAH.AENCKPECJMJ subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public MEHGPBKCCCN roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public IOKIOMILIFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		private AALFCBFPNPD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		private TaskAwaiter<NMEELHLCCAH.AENCKPECJMJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x687F2C0", Offset = "0x687E0C0", VA = "0x18687F2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x687FB10", Offset = "0x687E910", VA = "0x18687FB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct GOEPOJBMCEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public AsyncTaskMethodBuilder<JCEJPJKGHOG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public IOKIOMILIFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public MEHGPBKCCCN roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		public DDAACBOALJE roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private TaskAwaiter<(NMEELHLCCAH.AENCKPECJMJ roomDataUpload, NMEELHLCCAH.AENCKPECJMJ subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private TaskAwaiter<JCEJPJKGHOG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x6881B60", Offset = "0x6880960", VA = "0x186881B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x6882180", Offset = "0x6880F80", VA = "0x186882180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private struct IHALCGAEGBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public AsyncTaskMethodBuilder<AFHGGNKAGMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public IOKIOMILIFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public MEHGPBKCCCN roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		private TaskAwaiter<(NMEELHLCCAH.AENCKPECJMJ roomDataUpload, NMEELHLCCAH.AENCKPECJMJ subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		private TaskAwaiter<AFHGGNKAGMJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x6882990", Offset = "0x6881790", VA = "0x186882990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x6882DA0", Offset = "0x6881BA0", VA = "0x186882DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class FCPLODMKCFL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000184")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400067F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000680")]
			public AsyncTaskMethodBuilder<LDPKGMHDMGO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000681")]
			public FCPLODMKCFL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000682")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000683")]
			private LDPKGMHDMGO <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000684")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000685")]
			private TaskAwaiter<AFHGGNKAGMJ> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000686")]
			private TaskAwaiter<JCEJPJKGHOG> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000687")]
			private TaskAwaiter<LDPKGMHDMGO> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x688E0B0", Offset = "0x688CEB0", VA = "0x18688E0B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x688F020", Offset = "0x688DE20", VA = "0x18688F020", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public IOKIOMILIFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public MEHGPBKCCCN roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public DDAACBOALJE roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public HCNEBGIHOKG roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public FCPLODMKCFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x687F190", Offset = "0x687DF90", VA = "0x18687F190")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<LDPKGMHDMGO> EPBNNFJCCNH(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private struct AEAJCCKJFIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public AsyncTaskMethodBuilder<LDPKGMHDMGO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public IOKIOMILIFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public MEHGPBKCCCN roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public DDAACBOALJE roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public HCNEBGIHOKG roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		private TaskAwaiter<LDPKGMHDMGO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x68743B0", Offset = "0x68731B0", VA = "0x1868743B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x68746C0", Offset = "0x68734C0", VA = "0x1868746C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000656")]
	private static readonly JNOMMELLEMA LEDKGOEDJCM;

	[Cpp2IlInjected.Token(Token = "0x4000657")]
	private static readonly JNOMMELLEMA LCNLHGDCFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000658")]
	private readonly EDAMGDNGLNA KBINNIDGPHI;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private KIAEAACOCKM JCOLBCDBHEM
	{
		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x68672A0", Offset = "0x68660A0", VA = "0x1868672A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x6884220", Offset = "0x6883020", VA = "0x186884220")]
	public IOKIOMILIFK(CANPFPNADBJ OJNAOMBNMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x6883D40", Offset = "0x6882B40", VA = "0x186883D40")]
	[AsyncStateMachine(typeof(FDPKIEPMNHI))]
	private Task<(NMEELHLCCAH.AENCKPECJMJ, NMEELHLCCAH.AENCKPECJMJ)> KMFJCOOODPH(MEHGPBKCCCN CDMEONEAOGC, long EKMDOMOGGBC, long LCDEHGNNMHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x6883BD0", Offset = "0x68829D0", VA = "0x186883BD0")]
	[AsyncStateMachine(typeof(GOEPOJBMCEK))]
	public Task<JCEJPJKGHOG> HNPADICFIFN(int IHONMAEKGNO, [CanBeNull] DDAACBOALJE KEGBFOEHEOI, MEHGPBKCCCN CDMEONEAOGC, long EKMDOMOGGBC, long LCDEHGNNMHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x6884020", Offset = "0x6882E20", VA = "0x186884020")]
	[AsyncStateMachine(typeof(IHALCGAEGBK))]
	private Task<AFHGGNKAGMJ> OCGKBGEBKFM(string NMGHGLDODNE, int IHONMAEKGNO, MEHGPBKCCCN CDMEONEAOGC, long EKMDOMOGGBC, long LCDEHGNNMHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x6883E80", Offset = "0x6882C80", VA = "0x186883E80")]
	[AsyncStateMachine(typeof(AEAJCCKJFIE))]
	public Task<LDPKGMHDMGO> MKLLBHGFPOH(int IHONMAEKGNO, DDAACBOALJE? KEGBFOEHEOI, MEHGPBKCCCN CDMEONEAOGC, long EKMDOMOGGBC, long LCDEHGNNMHO, HCNEBGIHOKG DHPCNKIGKGM, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG, CancellationToken KANPDHELHMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
public abstract class CEPLNACBNAI<T> where T : CEPLNACBNAI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000694")]
	internal readonly KIAEAACOCKM DGNPLBELOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000695")]
	private int? FLFHJGEENPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000696")]
	protected readonly Guid MDALPHBHGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000697")]
	protected readonly LJHFIKGIIKE AFFFCCJGDKB;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	protected T CAGCPEEFJIG
	{
		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x4C4F530", Offset = "0x4C4E330", VA = "0x184C4F530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x4C4F730", Offset = "0x4C4E530", VA = "0x184C4F730")]
	internal CEPLNACBNAI(KIAEAACOCKM DJHOBBGHBFK, LJHFIKGIIKE HMDFOAIFOKF, [Optional] Guid? GJAFHBAGEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x4C4F450", Offset = "0x4C4E250", VA = "0x184C4F450")]
	private LDPKGMHDMGO CFAOFGMFMGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "4")]
	protected virtual void KLMOJHJNDBF(LDPKGMHDMGO HPJAAILCALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x4C4F6A0", Offset = "0x4C4E4A0", VA = "0x184C4F6A0")]
	public T JHDHCMAEDJI(CMFDBPHCNJN CIJPLICOMPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x4C4F3C0", Offset = "0x4C4E1C0", VA = "0x184C4F3C0")]
	public T APHALOBNJLH(int NHAGAIHCDLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x4C4F590", Offset = "0x4C4E390", VA = "0x184C4F590", Slot = "5")]
	public virtual Task<OECPMONDBOC> IDKDBMJDOEJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
public class EGPNOKONMCA : CEPLNACBNAI<EGPNOKONMCA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000698")]
	private LLMIKIIPGIJ PENMOOOPINK;

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x687DB70", Offset = "0x687C970", VA = "0x18687DB70")]
	internal EGPNOKONMCA(KIAEAACOCKM DJHOBBGHBFK, LJHFIKGIIKE HMDFOAIFOKF, [Optional] Guid? GJAFHBAGEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x5E61DD0", Offset = "0x5E60BD0", VA = "0x185E61DD0")]
	public EGPNOKONMCA PECFDCPBBBO(LLMIKIIPGIJ PENMOOOPINK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x687DAA0", Offset = "0x687C8A0", VA = "0x18687DAA0", Slot = "4")]
	protected override void KLMOJHJNDBF(LDPKGMHDMGO HPJAAILCALJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
public class DOOFFMNBFII : CEPLNACBNAI<DOOFFMNBFII>
{
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	internal enum DJKBKBOBCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private struct LMFIIJEBGOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public AsyncTaskMethodBuilder<OECPMONDBOC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public DOOFFMNBFII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		private TaskAwaiter<OECPMONDBOC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x6885E00", Offset = "0x6884C00", VA = "0x186885E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x68861A0", Offset = "0x6884FA0", VA = "0x1868861A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000699")]
	private DJKBKBOBCFJ AJIODKOBHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400069A")]
	private string OLHLNNLHFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400069B")]
	private DDAACBOALJE PENMOOOPINK;

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x687D880", Offset = "0x687C680", VA = "0x18687D880")]
	internal DOOFFMNBFII(KIAEAACOCKM DJHOBBGHBFK, LJHFIKGIIKE HMDFOAIFOKF, [Optional] Guid? GJAFHBAGEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x687D590", Offset = "0x687C390", VA = "0x18687D590")]
	public DOOFFMNBFII HAFGMDFPJHC(string HCNOEAOOGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x687D6B0", Offset = "0x687C4B0", VA = "0x18687D6B0")]
	public DOOFFMNBFII JFCHPFKDHJC(bool FMBKCDBBOEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x687D560", Offset = "0x687C360", VA = "0x18687D560")]
	public DOOFFMNBFII GGKNEKHDDPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x687D6D0", Offset = "0x687C4D0", VA = "0x18687D6D0", Slot = "4")]
	protected override void KLMOJHJNDBF(LDPKGMHDMGO HPJAAILCALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x687D5C0", Offset = "0x687C3C0", VA = "0x18687D5C0", Slot = "5")]
	[AsyncStateMachine(typeof(LMFIIJEBGOE))]
	public override Task<OECPMONDBOC> IDKDBMJDOEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x687D840", Offset = "0x687C640", VA = "0x18687D840")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<OECPMONDBOC> ONDEHPBBLCL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal static class BFGGDNPDLAE
{
	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x6876B20", Offset = "0x6875920", VA = "0x186876B20")]
	public static void ABIEDHGBAPK(this GAEAKKKNDMC BGAHOPHFEEB, OCJDEGLDIGA IICGEBFPJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x6876C70", Offset = "0x6875A70", VA = "0x186876C70")]
	public static void MFJONPHJDCO(this OCJDEGLDIGA OMOAKIOOHPA, [Optional] string HPJAAILCALJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
public static class NEMMPDENMKH
{
	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x68890A0", Offset = "0x6887EA0", VA = "0x1868890A0")]
	public static PLDLJCNGAPD JANDAHBDFKB(this BALAIPHHCIJ JMPFKCLJFNO)
	{
		return default(PLDLJCNGAPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x6889140", Offset = "0x6887F40", VA = "0x186889140")]
	public static BALAIPHHCIJ NOGHDLOLNLP(this PLDLJCNGAPD FPLIMEMNPED)
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
			[Cpp2IlInjected.Token(Token = "0x40006A8")]
			public OLFJBACEIPB ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006A9")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006AA")]
			public OLFJBACEIPB HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006AB")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006AC")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006AD")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		private static OLFJBACEIPB[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		private Dictionary<OLFJBACEIPB, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x688F6C0", Offset = "0x688E4C0", VA = "0x18688F6C0")]
		public bool APEJEGIEJDN(OLFJBACEIPB BJLNHMKHOBI, [Out] ResultConfig IACOOBGNHEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x688F730", Offset = "0x688E530", VA = "0x18688F730")]
		public ResultConfig ECJBJOEGKNL(OLFJBACEIPB JNFKLJKGAMI, [Optional] HashSet<OLFJBACEIPB> OLCFAPCMIIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x688FE10", Offset = "0x688EC10", VA = "0x18688FE10", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x688F870", Offset = "0x688E670", VA = "0x18688F870", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x89A860", Offset = "0x899660", VA = "0x18089A860")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public static class FHDFGIEGFNO
{
	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x687FB80", Offset = "0x687E980", VA = "0x18687FB80")]
	[DPHBJKOLDBD(OHNOEEJKPCM.GameOnly)]
	private static void LLBAHKJCIHJ(NAINNGGFMLM LMEEFHNMKLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
public interface GAIIFIKOGEE : IEquatable<GAIIFIKOGEE>
{
	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	DateTime CFBNGFNHBPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BAKIMJPHECI();

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BDIPELNAOEH(long EKMDOMOGGBC, long EEFFKLADGPB, [Out] MEHGPBKCCCN CDMEONEAOGC);
}
[Cpp2IlInjected.Token(Token = "0x2000192")]
internal class NFLEDEHBAJN : BOJOLBFIKDD
{
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private sealed class KHCAHKLADKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public ACEMKOMODMN autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public KHCAHKLADKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x6885710", Offset = "0x6884510", VA = "0x186885710")]
		internal object KJBFEHKLHFM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B3")]
	private readonly KJHOOEGPPDG OPOAGAMGEAI;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<GAIIFIKOGEE> CFAMEKKPKNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x68891F0", Offset = "0x6887FF0", VA = "0x1868891F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x6889CD0", Offset = "0x6888AD0", VA = "0x186889CD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B0AB0", VA = "0x1807B1CB0")]
	[UnityEngine.Scripting.Preserve]
	public NFLEDEHBAJN([PENMPEOFMMN(null)] KJHOOEGPPDG OPOAGAMGEAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x68899F0", Offset = "0x68887F0", VA = "0x1868899F0", Slot = "6")]
	public bool PMKPBCJFFFE(long EKMDOMOGGBC, long EEFFKLADGPB, MEHGPBKCCCN CDMEONEAOGC, ACEMKOMODMN LKDJIBAIBLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x1A6A440", Offset = "0x1A69240", VA = "0x181A6A440")]
	private void IBJCHDOHKDJ(GAIIFIKOGEE OCFMBNHGGCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x6889880", Offset = "0x6888680", VA = "0x186889880", Slot = "7")]
	public bool NABKOFDIDIJ(long EKMDOMOGGBC, long EEFFKLADGPB, [Out] GAIIFIKOGEE OHKLPLEDHBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x68897D0", Offset = "0x68885D0", VA = "0x1868897D0", Slot = "8")]
	public bool JOFCLAIHGJO(long EKMDOMOGGBC, long EEFFKLADGPB, ACEMKOMODMN LKDJIBAIBLB, [Out] GAIIFIKOGEE OHKLPLEDHBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x68892A0", Offset = "0x68880A0", VA = "0x1868892A0")]
	private void DIKJGLDPAED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x68896C0", Offset = "0x68884C0", VA = "0x1868896C0", Slot = "9")]
	public void EAMOMEACOJD(long EKMDOMOGGBC, long EEFFKLADGPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
internal abstract class PIGAIAFJIDL : KJHOOEGPPDG
{
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	protected enum CNEHFNDKBJL : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private sealed class ICBGNKMFIMM : IEnumerable<GAIIFIKOGEE>, IEnumerable, IEnumerator<GAIIFIKOGEE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private GAIIFIKOGEE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		public PIGAIAFJIDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		private ACEMKOMODMN autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public ACEMKOMODMN <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		private GAIIFIKOGEE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000646")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x802B10", Offset = "0x801910", VA = "0x180802B10")]
		[DebuggerHidden]
		public ICBGNKMFIMM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x68821F0", Offset = "0x6880FF0", VA = "0x1868821F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x68824D0", Offset = "0x68812D0", VA = "0x1868824D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x6882420", Offset = "0x6881220", VA = "0x186882420", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GAIIFIKOGEE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x6882420", Offset = "0x6881220", VA = "0x186882420", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private sealed class MHAGIOJPGML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		public ACEMKOMODMN autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public MHAGIOJPGML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x6888170", Offset = "0x6886F70", VA = "0x186888170")]
		internal object HNJJEIGNINF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private sealed class BGFEEOPMFDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		public PIGAIAFJIDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public BGFEEOPMFDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x6876CF0", Offset = "0x6875AF0", VA = "0x186876CF0")]
		internal void APEPJKAFFPM(PMKINDHKDIJ.NMGHAHIMEON ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B9")]
	protected readonly string PMGLNIILAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006BA")]
	private readonly object LBOFMEBCKIG;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public abstract BNLNADKNHCK KCAPPCOOABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x688D390", Offset = "0x688C190", VA = "0x18688D390")]
	protected PIGAIAFJIDL([CanBeNull] string AOCAOAPPMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x688C9B0", Offset = "0x688B7B0", VA = "0x18688C9B0", Slot = "5")]
	public bool AEDFDNEDGIL(long EKMDOMOGGBC, long EEFFKLADGPB, ACEMKOMODMN LKDJIBAIBLB, [Out] GAIIFIKOGEE OCFMBNHGGCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x688CF20", Offset = "0x688BD20", VA = "0x18688CF20", Slot = "6")]
	[IteratorStateMachine(typeof(ICBGNKMFIMM))]
	public IEnumerable<GAIIFIKOGEE> GBHJKDPCMFL(ACEMKOMODMN LKDJIBAIBLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void LIFPHKJBIHE(Stream MPCDPEKDFJD, long EKMDOMOGGBC, long EEFFKLADGPB, MEHGPBKCCCN CDMEONEAOGC);

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool AHHONGEFFAJ(Stream PHCKCLNDFGC, long EKMDOMOGGBC, long EEFFKLADGPB, DNPINNABCAB GFGBMHIEMIH, [Out] MEHGPBKCCCN CDMEONEAOGC);

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x688CFB0", Offset = "0x688BDB0", VA = "0x18688CFB0", Slot = "7")]
	public GAIIFIKOGEE PHJGFLHOGNB(long EKMDOMOGGBC, long EEFFKLADGPB, MEHGPBKCCCN CDMEONEAOGC, ACEMKOMODMN LKDJIBAIBLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo NAPKHBPJKFB(long EKMDOMOGGBC, long EEFFKLADGPB, ACEMKOMODMN LKDJIBAIBLB, CNEHFNDKBJL DBFAIJADPMN);

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo FOGFFHLKBDE(ACEMKOMODMN LKDJIBAIBLB, CNEHFNDKBJL DBFAIJADPMN);

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x688D320", Offset = "0x688C120", VA = "0x18688D320")]
	protected void PHOMABDNLDK(PMKINDHKDIJ.NMGHAHIMEON MICKAOFCKIA, string DAMMFDJOPGA, FileInfo PHPMJPGDGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x688CB90", Offset = "0x688B990", VA = "0x18688CB90")]
	internal bool DDFJCCJDAIN(FileInfo NOMJEIENHKO, long EKMDOMOGGBC, long EEFFKLADGPB, [Out] MEHGPBKCCCN CDMEONEAOGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
	private void KDGCGBAHEEM(Exception AGDNDCIGOME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
internal class BJJFDGIHEPN : PIGAIAFJIDL
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public override BNLNADKNHCK KCAPPCOOABI
	{
		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0xC10B20", Offset = "0xC0F920", VA = "0x180C10B20", Slot = "8")]
		get
		{
			return default(BNLNADKNHCK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x6878A70", Offset = "0x6877870", VA = "0x186878A70")]
	public BJJFDGIHEPN([Optional] string AOCAOAPPMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x6878670", Offset = "0x6877470", VA = "0x186878670")]
	private void KGCEHLHAEIM(ACEMKOMODMN LKDJIBAIBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x68786F0", Offset = "0x68774F0", VA = "0x1868786F0", Slot = "9")]
	internal override void LIFPHKJBIHE(Stream MPCDPEKDFJD, long EKMDOMOGGBC, long EEFFKLADGPB, MEHGPBKCCCN CDMEONEAOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x6877F10", Offset = "0x6876D10", VA = "0x186877F10", Slot = "10")]
	internal override bool AHHONGEFFAJ(Stream PHCKCLNDFGC, long EKMDOMOGGBC, long EEFFKLADGPB, DNPINNABCAB GFGBMHIEMIH, [Out] MEHGPBKCCCN CDMEONEAOGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x6878980", Offset = "0x6877780", VA = "0x186878980", Slot = "11")]
	protected override FileInfo NAPKHBPJKFB(long EKMDOMOGGBC, long EEFFKLADGPB, ACEMKOMODMN LKDJIBAIBLB, CNEHFNDKBJL DBFAIJADPMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x6878560", Offset = "0x6877360", VA = "0x186878560", Slot = "12")]
	protected override DirectoryInfo FOGFFHLKBDE(ACEMKOMODMN LKDJIBAIBLB, CNEHFNDKBJL DBFAIJADPMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
internal sealed class AGJHPJNABAJ : PIGAIAFJIDL
{
	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	private static readonly byte[] OBPLDLNDJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006CB")]
	private readonly byte[] HCEMJDIIANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006CC")]
	private readonly byte[] FHJIAEEHHOB;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public override BNLNADKNHCK KCAPPCOOABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x571B550", Offset = "0x571A350", VA = "0x18571B550", Slot = "8")]
		get
		{
			return default(BNLNADKNHCK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x6875620", Offset = "0x6874420", VA = "0x186875620")]
	public AGJHPJNABAJ([Optional] string AOCAOAPPMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x68751A0", Offset = "0x6873FA0", VA = "0x1868751A0", Slot = "9")]
	internal override void LIFPHKJBIHE(Stream MPCDPEKDFJD, long EKMDOMOGGBC, long EEFFKLADGPB, MEHGPBKCCCN CDMEONEAOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x68747A0", Offset = "0x68735A0", VA = "0x1868747A0", Slot = "10")]
	internal override bool AHHONGEFFAJ(Stream PHCKCLNDFGC, long EKMDOMOGGBC, long EEFFKLADGPB, DNPINNABCAB GFGBMHIEMIH, [Out] MEHGPBKCCCN CDMEONEAOGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x6874FD0", Offset = "0x6873DD0", VA = "0x186874FD0")]
	private void CPLEGIHNHOL(byte[] KKAMOMBNLOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x6875460", Offset = "0x6874260", VA = "0x186875460", Slot = "11")]
	protected override FileInfo NAPKHBPJKFB(long EKMDOMOGGBC, long EEFFKLADGPB, ACEMKOMODMN LKDJIBAIBLB, CNEHFNDKBJL DBFAIJADPMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x6875090", Offset = "0x6873E90", VA = "0x186875090", Slot = "12")]
	protected override DirectoryInfo FOGFFHLKBDE(ACEMKOMODMN LKDJIBAIBLB, CNEHFNDKBJL DBFAIJADPMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
public enum BNLNADKNHCK : byte
{
	[Cpp2IlInjected.Token(Token = "0x40006CE")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40006CF")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40006D0")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
internal class CIIIIKPNJME : KJHOOEGPPDG
{
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[CompilerGenerated]
	private sealed class LONNJEFKCGL : IEnumerable<GAIIFIKOGEE>, IEnumerable, IEnumerator<GAIIFIKOGEE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		private GAIIFIKOGEE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		public CIIIIKPNJME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		private ACEMKOMODMN autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		public ACEMKOMODMN <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		private BNLNADKNHCK[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		private IEnumerator<GAIIFIKOGEE> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		private GAIIFIKOGEE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600066B")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x802B10", Offset = "0x801910", VA = "0x180802B10")]
		[DebuggerHidden]
		public LONNJEFKCGL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x6887770", Offset = "0x6886570", VA = "0x186887770", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x6887390", Offset = "0x6886190", VA = "0x186887390", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x6887340", Offset = "0x6886140", VA = "0x186887340")]
		private void DJJHEMEPHNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x6887720", Offset = "0x6886520", VA = "0x186887720", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x6887670", Offset = "0x6886470", VA = "0x186887670", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GAIIFIKOGEE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x6887670", Offset = "0x6886470", VA = "0x186887670", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006D1")]
	private readonly BNLNADKNHCK[] DADMJLNFCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006D2")]
	private readonly Dictionary<BNLNADKNHCK, KJHOOEGPPDG> AAKBJPAPNPB;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public BNLNADKNHCK KCAPPCOOABI
	{
		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x687B5B0", Offset = "0x687A3B0", VA = "0x18687B5B0", Slot = "4")]
		get
		{
			return default(BNLNADKNHCK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x687B950", Offset = "0x687A750", VA = "0x18687B950")]
	[UnityEngine.Scripting.Preserve]
	public CIIIIKPNJME(params KJHOOEGPPDG[] LNIHKEGGFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x687B3D0", Offset = "0x687A1D0", VA = "0x18687B3D0", Slot = "5")]
	public bool AEDFDNEDGIL(long EKMDOMOGGBC, long EEFFKLADGPB, ACEMKOMODMN LKDJIBAIBLB, [Out] GAIIFIKOGEE OCFMBNHGGCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x687B730", Offset = "0x687A530", VA = "0x18687B730")]
	private void PNFCJMOMDFC(int NPGPNOPDJPI, long EKMDOMOGGBC, long EEFFKLADGPB, ACEMKOMODMN LKDJIBAIBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x687B520", Offset = "0x687A320", VA = "0x18687B520", Slot = "6")]
	[IteratorStateMachine(typeof(LONNJEFKCGL))]
	public IEnumerable<GAIIFIKOGEE> GBHJKDPCMFL(ACEMKOMODMN LKDJIBAIBLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x687B5E0", Offset = "0x687A3E0", VA = "0x18687B5E0", Slot = "7")]
	public GAIIFIKOGEE PHJGFLHOGNB(long EKMDOMOGGBC, long EEFFKLADGPB, MEHGPBKCCCN CDMEONEAOGC, ACEMKOMODMN LKDJIBAIBLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
internal static class DCBJEMGIPHK
{
	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x687BFF0", Offset = "0x687ADF0", VA = "0x18687BFF0")]
	internal static byte[] GJDGNOCFCMI(byte[] KKAMOMBNLOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x687BF70", Offset = "0x687AD70", VA = "0x18687BF70")]
	public static void GAOCFLBEBFL(Stream MEDEAOCENEP, byte[] EKCIJDMICPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x687C0B0", Offset = "0x687AEB0", VA = "0x18687C0B0")]
	public static bool ODAHHCCNLHG(Stream MEDEAOCENEP, long HCIILJIDIFL, DNPINNABCAB CJNIIFHNJOO, [Out] byte[] HANHJEBJDFC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
internal sealed class MPEBMPPPHIF : GAIIFIKOGEE, IEquatable<GAIIFIKOGEE>, IEquatable<MPEBMPPPHIF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006E0")]
	private readonly PIGAIAFJIDL FOPAEBAINNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006E1")]
	public readonly FileInfo AGAOMKOLAHA;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public BNLNADKNHCK KCAPPCOOABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x62BFFE0", Offset = "0x62BEDE0", VA = "0x1862BFFE0", Slot = "9")]
		get
		{
			return default(BNLNADKNHCK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public DateTime CFBNGFNHBPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x6888D10", Offset = "0x6887B10", VA = "0x186888D10", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x6888E50", Offset = "0x6887C50", VA = "0x186888E50")]
	public MPEBMPPPHIF(PIGAIAFJIDL LCLDBNOBBJI, FileInfo NOMJEIENHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x6888DA0", Offset = "0x6887BA0", VA = "0x186888DA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x68888F0", Offset = "0x68876F0", VA = "0x1868888F0", Slot = "5")]
	public void BAKIMJPHECI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x68889B0", Offset = "0x68877B0", VA = "0x1868889B0", Slot = "6")]
	public bool BDIPELNAOEH(long EKMDOMOGGBC, long EEFFKLADGPB, [Out] MEHGPBKCCCN CDMEONEAOGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x6888BA0", Offset = "0x68879A0", VA = "0x186888BA0", Slot = "7")]
	public bool Equals(GAIIFIKOGEE GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x6888AE0", Offset = "0x68878E0", VA = "0x186888AE0", Slot = "8")]
	public bool Equals(MPEBMPPPHIF GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x68889F0", Offset = "0x68877F0", VA = "0x1868889F0", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x6888C80", Offset = "0x6887A80", VA = "0x186888C80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
public delegate void DNPINNABCAB(PMKINDHKDIJ.NMGHAHIMEON BALBJILGNFP, string HPJAAILCALJ);
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal interface KJHOOEGPPDG
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	BNLNADKNHCK KCAPPCOOABI
	{
		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AEDFDNEDGIL(long EKMDOMOGGBC, long EEFFKLADGPB, ACEMKOMODMN LKDJIBAIBLB, [Out] GAIIFIKOGEE OCFMBNHGGCK);

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<GAIIFIKOGEE> GBHJKDPCMFL(ACEMKOMODMN LKDJIBAIBLB);

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GAIIFIKOGEE PHJGFLHOGNB(long EKMDOMOGGBC, long EEFFKLADGPB, MEHGPBKCCCN CDMEONEAOGC, ACEMKOMODMN LKDJIBAIBLB);
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
