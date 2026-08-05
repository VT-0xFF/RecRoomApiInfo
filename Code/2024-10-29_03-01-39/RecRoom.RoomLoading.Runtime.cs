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
using RecRoom.DataLayer.Attributes;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;
using RecRoom.Persistence;
using Unity.Profiling;
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
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
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
		[Cpp2IlInjected.Address(RVA = "0x7583090", Offset = "0x7582090", VA = "0x187583090")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0550", Offset = "0x8DF550", VA = "0x1808E0550")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E0590", Offset = "0x8DF590", VA = "0x1808E0590")]
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
	public class LogRegistrationIndex : FEPIOKBKKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x757E8F0", Offset = "0x757D8F0", VA = "0x18757E8F0", Slot = "4")]
		public override void EPIGOBOFFNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : PFMKOBANMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x75854F0", Offset = "0x75844F0", VA = "0x1875854F0", Slot = "8")]
		public override void NCHGKCJDJHF(GLGFPKOIELC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6565350", Offset = "0x6564350", VA = "0x186565350")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class AHDIJOKANGM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7568600", Offset = "0x7567600", VA = "0x187568600")]
	public AHDIJOKANGM(string ABHPFCOODAJ, Exception AHKLKPABMPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class EOBKIOPDOLC : PHHCLDDAGNA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct OPCNJLDHEOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<BLNDCCHFGLB>> <>t__builder;

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
		private TaskAwaiter<PBDFLLBOCJL<BLNDCCHFGLB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7583110", Offset = "0x7582110", VA = "0x187583110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7583350", Offset = "0x7582350", VA = "0x187583350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct FHNBLMPJMDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<MKICDJLEHGJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<MKICDJLEHGJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7570F20", Offset = "0x756FF20", VA = "0x187570F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7571130", Offset = "0x7570130", VA = "0x187571130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	[UnityEngine.Scripting.Preserve]
	public EOBKIOPDOLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x75700A0", Offset = "0x756F0A0", VA = "0x1875700A0", Slot = "4")]
	[AsyncStateMachine(typeof(OPCNJLDHEOP))]
	public Task<IReadOnlyList<BLNDCCHFGLB>> CDAOMCFKELK(long AHNLEKFKAGC, long ABKHIAFPEJM, [Optional] CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x75701C0", Offset = "0x756F1C0", VA = "0x1875701C0", Slot = "5")]
	[AsyncStateMachine(typeof(FHNBLMPJMDJ))]
	public Task<IReadOnlyList<MKICDJLEHGJ>> EOCJNNJGJFG(IReadOnlyList<int> MHNBKDDNNOA, [Optional] CancellationToken CLIKNEKJHEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface EMGNCANMJNG : IEquatable<EMGNCANMJNG>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int JDLAOELJGFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	MKICDJLEHGJ BDBNJBOGEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime HHHHPGHJKAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	HHHENMEGENB? KDMBCGDPGJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	EBMBBHCDCFH? GGLPGHAKIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	NHCHCNMOADF LNLCNOILDDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<JECONNLHJLM> DGMMKALCJBD();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum NHCHCNMOADF
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PHHCLDDAGNA
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<BLNDCCHFGLB>> CDAOMCFKELK(long AHNLEKFKAGC, long ABKHIAFPEJM, [Optional] CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<MKICDJLEHGJ>> EOCJNNJGJFG(IReadOnlyList<int> MHNBKDDNNOA, [Optional] CancellationToken CLIKNEKJHEI);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class HBPBDENIGMG
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class KBPCLMEMAKO : EMGNCANMJNG, IEquatable<EMGNCANMJNG>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct BONIABLMGJA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<JECONNLHJLM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public KBPCLMEMAKO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private FJPHLODGACH <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<CDBHFDKLKGA> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<JECONNLHJLM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7568DB0", Offset = "0x7567DB0", VA = "0x187568DB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7569270", Offset = "0x7568270", VA = "0x187569270", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly BLNDCCHFGLB ALMKFGMOHLI;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int JDLAOELJGFI
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8B8390", Offset = "0x8B7390", VA = "0x1808B8390", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public MKICDJLEHGJ BDBNJBOGEED
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime EKJCGGGCCBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x60B9D70", Offset = "0x60B8D70", VA = "0x1860B9D70", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HHHENMEGENB? KDMBCGDPGJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9C97C0", Offset = "0x9C87C0", VA = "0x1809C97C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public EBMBBHCDCFH? GGLPGHAKIGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x60B9E50", Offset = "0x60B8E50", VA = "0x1860B9E50", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public NHCHCNMOADF LNLCNOILDDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x93D780", Offset = "0x93C780", VA = "0x18093D780", Slot = "10")]
			get
			{
				return default(NHCHCNMOADF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x757AF60", Offset = "0x7579F60", VA = "0x18757AF60", Slot = "9")]
		[AsyncStateMachine(typeof(BONIABLMGJA))]
		public Task<JECONNLHJLM> DGMMKALCJBD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x757B210", Offset = "0x757A210", VA = "0x18757B210")]
		public KBPCLMEMAKO(int BCJPBNDAFNB, MKICDJLEHGJ CNGPJMHCBKG, BLNDCCHFGLB ALMKFGMOHLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x757B060", Offset = "0x757A060", VA = "0x18757B060", Slot = "11")]
		public bool Equals(EMGNCANMJNG DFABCHNPEEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x757B0F0", Offset = "0x757A0F0", VA = "0x18757B0F0", Slot = "0")]
		public override bool Equals(object IFPBFCLBBDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x757AF20", Offset = "0x7579F20", VA = "0x18757AF20")]
		private bool BNMJPKBJEII(KBPCLMEMAKO DFABCHNPEEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x757B190", Offset = "0x757A190", VA = "0x18757B190", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class ACNJPNNGFIA : EMGNCANMJNG, IEquatable<EMGNCANMJNG>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct AGDFOIILMDA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<JECONNLHJLM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public ACNJPNNGFIA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<JECONNLHJLM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7568340", Offset = "0x7567340", VA = "0x187568340", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7568590", Offset = "0x7567590", VA = "0x187568590", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly DDMELBGCFHO BFIKAELEDAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HHHENMEGENB FCBLAJDAMLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly EBMBBHCDCFH BJBKFHIGOCO;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int JDLAOELJGFI
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7567290", Offset = "0x7566290", VA = "0x187567290", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public MKICDJLEHGJ BDBNJBOGEED
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x75675E0", Offset = "0x75665E0", VA = "0x1875675E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime EKJCGGGCCBP
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7567670", Offset = "0x7566670", VA = "0x187567670", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public HHHENMEGENB? KDMBCGDPGJE
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x75676C0", Offset = "0x75666C0", VA = "0x1875676C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public EBMBBHCDCFH? GGLPGHAKIGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7567510", Offset = "0x7566510", VA = "0x187567510", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public NHCHCNMOADF LNLCNOILDDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x941F20", Offset = "0x940F20", VA = "0x180941F20", Slot = "10")]
			get
			{
				return default(NHCHCNMOADF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x18AEBA0", Offset = "0x18ADBA0", VA = "0x1818AEBA0")]
		public ACNJPNNGFIA(DDMELBGCFHO BMHPAPNFNDF, HHHENMEGENB IDBPMHNIPCJ, EBMBBHCDCFH LDGECCHPBNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x75672D0", Offset = "0x75662D0", VA = "0x1875672D0", Slot = "9")]
		[AsyncStateMachine(typeof(AGDFOIILMDA))]
		public Task<JECONNLHJLM> DGMMKALCJBD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7567470", Offset = "0x7566470", VA = "0x187567470", Slot = "11")]
		public bool Equals(EMGNCANMJNG DFABCHNPEEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x75673C0", Offset = "0x75663C0", VA = "0x1875673C0", Slot = "0")]
		public override bool Equals(object IFPBFCLBBDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7567230", Offset = "0x7566230", VA = "0x187567230")]
		private bool BNMJPKBJEII(ACNJPNNGFIA DFABCHNPEEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7567560", Offset = "0x7566560", VA = "0x187567560", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class IFLJDNGCGBK : EMGNCANMJNG, IEquatable<EMGNCANMJNG>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct FHBAKFBFKFE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<JECONNLHJLM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<JECONNLHJLM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7570C50", Offset = "0x756FC50", VA = "0x187570C50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7570EB0", Offset = "0x756FEB0", VA = "0x187570EB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly MKICDJLEHGJ GHCMAHJJJBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly HHHENMEGENB FCBLAJDAMLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly EBMBBHCDCFH BJBKFHIGOCO;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int JDLAOELJGFI
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7578840", Offset = "0x7577840", VA = "0x187578840", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public MKICDJLEHGJ BDBNJBOGEED
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime EKJCGGGCCBP
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public HHHENMEGENB? KDMBCGDPGJE
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7578B00", Offset = "0x7577B00", VA = "0x187578B00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public EBMBBHCDCFH? GGLPGHAKIGK
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7578A20", Offset = "0x7577A20", VA = "0x187578A20", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public NHCHCNMOADF LNLCNOILDDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "10")]
			get
			{
				return default(NHCHCNMOADF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x18AEBA0", Offset = "0x18ADBA0", VA = "0x1818AEBA0")]
		public IFLJDNGCGBK(MKICDJLEHGJ CNGPJMHCBKG, HHHENMEGENB IDBPMHNIPCJ, EBMBBHCDCFH LDGECCHPBNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7578860", Offset = "0x7577860", VA = "0x187578860", Slot = "9")]
		[AsyncStateMachine(typeof(FHBAKFBFKFE))]
		public Task<JECONNLHJLM> DGMMKALCJBD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7578930", Offset = "0x7577930", VA = "0x187578930", Slot = "11")]
		public bool Equals(EMGNCANMJNG DFABCHNPEEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x75789A0", Offset = "0x75779A0", VA = "0x1875789A0", Slot = "0")]
		public override bool Equals(object IFPBFCLBBDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7578A70", Offset = "0x7577A70", VA = "0x187578A70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7578760", Offset = "0x7577760", VA = "0x187578760")]
		private bool BNMJPKBJEII(IFLJDNGCGBK DFABCHNPEEM)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct IOMIGEICIAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<EMGNCANMJNG>> <>t__builder;

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
		public HBPBDENIGMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<BLNDCCHFGLB> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<BLNDCCHFGLB>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, MKICDJLEHGJ account, BLNDCCHFGLB roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7579290", Offset = "0x7578290", VA = "0x187579290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x757A0D0", Offset = "0x75790D0", VA = "0x18757A0D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct LIBPAIDBHDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, MKICDJLEHGJ account, BLNDCCHFGLB roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<BLNDCCHFGLB> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public HBPBDENIGMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<MKICDJLEHGJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x757DEB0", Offset = "0x757CEB0", VA = "0x18757DEB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x757E880", Offset = "0x757D880", VA = "0x18757E880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly BOEPBCOOIOC DLGAELAPKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly PHHCLDDAGNA DGEHCJHAAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly HICNBKJEEFO AIEDBKIJKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly BDGGAOKPMHJ<(long, long), IReadOnlyList<BLNDCCHFGLB>> AHEKEEJMOBH;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x75776D0", Offset = "0x75766D0", VA = "0x1875776D0")]
	[UnityEngine.Scripting.Preserve]
	public HBPBDENIGMG([GAHPILLNNBL(null)] PHHCLDDAGNA INCAPLHFBNG, [GAHPILLNNBL(null)] HICNBKJEEFO ODAGGIAKCBI, [GAHPILLNNBL(null)] BOEPBCOOIOC IGIDPFOJJIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x75772D0", Offset = "0x75762D0", VA = "0x1875772D0")]
	[AsyncStateMachine(typeof(IOMIGEICIAB))]
	public Task<IList<EMGNCANMJNG>> GDIOLNLIMGH(long AHNLEKFKAGC, long PDLBLPPCJKC, bool IHKHNEAJHAN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7577530", Offset = "0x7576530", VA = "0x187577530")]
	private bool OONLONPEGNA(DateTime? JICCHMMHNAM, long AHNLEKFKAGC, long PDLBLPPCJKC, [Out] DDMELBGCFHO CBNDKFAOHGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7577420", Offset = "0x7576420", VA = "0x187577420")]
	[AsyncStateMachine(typeof(LIBPAIDBHDF))]
	private Task<IReadOnlyList<(int, MKICDJLEHGJ, BLNDCCHFGLB)>> HFLFHLMKOLG(IReadOnlyList<BLNDCCHFGLB> BDDODMAKCEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HICNBKJEEFO
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<DDMELBGCFHO> HPCJECBCHMM;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PGDAMKEIEDK(long AHNLEKFKAGC, long PDLBLPPCJKC, APNIAAHHPPH DDPKEDDGOEO, FJAPFOIPONE PFCJJJAILGH);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CCDOEMELLAB(long AHNLEKFKAGC, long PDLBLPPCJKC, [Out] DDMELBGCFHO CBNDKFAOHGJ);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LKKABLCLJKD(long AHNLEKFKAGC, long PDLBLPPCJKC, FJAPFOIPONE PFCJJJAILGH, [Out] DDMELBGCFHO CBNDKFAOHGJ);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EEHPHFJAMFJ(long AHNLEKFKAGC, long PDLBLPPCJKC);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface BHAEJLBNBBO : AMEJAADBFPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool MEFHFOIGJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task IBEOGPEDNBN
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void INKMJJKNCBD(Task KDFIPCHFLGF, string JMMGBDNJIIA);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface CKPJMGIAIBO : AMEJAADBFPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JECONNLHJLM> PBELBGDLOFM(DDMELBGCFHO CBNDKFAOHGJ);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LAKELOKKBMK(CancellationToken CLIKNEKJHEI);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface IAENGOKJJDM : AMEJAADBFPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	CMOHEPIBNDC IBMBPEEGMLF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GLNLCKJJIFJ();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OLAMMJBINJN();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface AMEJAADBFPI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPDDJGLEDNE(NDFFAKPPKGI GAIEJGCLEHG);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface GGNDNDFMJFF
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan GPOPLDPDGIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan NDFMNNDEGPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan NABOHIMLOLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan HDFJKHFJHCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool HDBEOMFKFNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool MDHMLEBJJCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool NFNNIPKHOEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int OPOPKKGHNLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool PLBLGBLNFGE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool NOJLLPFAHGM
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum MHLDIAKADNE
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum NNCNNOMHHHL
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
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct JNNCAHPPKJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long KAPPOFOAIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long ABKHIAFPEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly MHLDIAKADNE PFCMGBLCCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception GGBBLHPCPMG;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x757A590", Offset = "0x7579590", VA = "0x18757A590")]
	public JNNCAHPPKJI(long KAPPOFOAIGF, long ABKHIAFPEJM, MHLDIAKADNE PFCMGBLCCPJ, [CanBeNull] Exception GGBBLHPCPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x757A540", Offset = "0x7579540", VA = "0x18757A540")]
	public static JNNCAHPPKJI DPIOBCKIDMC(DACBMNFKIFK KPINCKMOJGA, MHLDIAKADNE PFCMGBLCCPJ, [Optional] Exception GGBBLHPCPMG)
	{
		return default(JNNCAHPPKJI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void OFOLFKINMBL(JNNCAHPPKJI MCPCCOBALOP);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface KGPJCADDDPH : AMEJAADBFPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action PLCALAHBKPO;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event OFOLFKINMBL KMLEOMOBLAM;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event OFOLFKINMBL KBFLIBHLGOC;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event OFOLFKINMBL HDJEIMCKHLN;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<NNCNNOMHHHL, bool> IJKMGJIDDDM;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CKJECNLDFEP();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MNLLABGNLAN(JNNCAHPPKJI MCPCCOBALOP);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ICGEOIBBJLH(JNNCAHPPKJI MCPCCOBALOP);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NDNLEEIONIF(JNNCAHPPKJI MCPCCOBALOP);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FGNJMFGFJCH(NNCNNOMHHHL HOAFJBCIPPP, bool BDKLGGLGLFK);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface CKAJIHJAIFJ : AMEJAADBFPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MNCOBPOIEHI();

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNKGAPJGGGP();
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface COGJJJEDKIO : AMEJAADBFPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TaskStatus FFALFFHDGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task APFCEKABJKJ(DACBMNFKIFK MKMEIBFGEOE, HFFOFFCNLJO PEJFIBOIAKE, CancellationToken OJBNPAMIAFA);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal static class IAEDOGHBEMH
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7578710", Offset = "0x7577710", VA = "0x187578710")]
	public static bool FKJIPCCCJNG(this COGJJJEDKIO MCMPAJJBLML)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate Task EFCGCAALBMD(CancellationToken NANMDIJGGLP, int NCJNNFEFBME, FCBKKHIFGAP DOELOEGGKAH);
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface EPOCDPBBMKI : AMEJAADBFPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GNHJJHOBEHI(EFCGCAALBMD KNAEJLOGHJJ);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface NDFFAKPPKGI : FJPHLODGACH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CancellationToken BGEFMGCLMIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	MAONAIOKEHK KCDIPLANOJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	ADPKBHEBFGA GFDFJIONEDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	NAMMGGILKND EEABMHEBHBO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	BJLINKIKEOI PAMCFEMCNIH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	IHGEMGGPDFH IOKPAKKICCH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	CIPEABMEBIL NHPAAHDFMHG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	IOKFDEJPJJE EIFDAJBBDLP
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	DFJODANGFCB LHGABIKKFIF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	BHAEJLBNBBO HPEIOELBJJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	CKPJMGIAIBO IFJIJIOFDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	KGPJCADDDPH PILOGMPKBLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	CKAJIHJAIFJ BHJPAKGMKGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	COGJJJEDKIO AOBAHGNMMBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	EPOCDPBBMKI JMLEELIDPMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	AKPMHDCOBDM GGFHEIMOOGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	EHPDHKHGABG ECGLBHNBFBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	FEHMJBGBGCJ GAHEBOMKHFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	MCFJKGCDPKP HPECJPIFDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	LLBIHPPACPN DIDENHOMEGE
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	PJODHFMOMFN FEFEIMGBJEB
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	EGOFNGONCHP JLCNIDEEHGK
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	LPJPPDEEHAD BINAIJPMKFB
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	KOJFEOAFNNE JGDFAFMDDGI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	MGPNOBNFNBD BKPEELDJGGC
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	IAENGOKJJDM BMLFDOKOMFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	GGNDNDFMJFF AIIPGOFCKEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	BDINCNLOEGO IHAKDFMJOCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	HICNBKJEEFO CKABEBLJMOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	JPCAEPIBHHL PFBLKEKGAPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	JLNHNNPKCNJ JKJIOHIBNKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	JGHFHJBGHPA FDBANICCKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	IHHBGHBEOLK FEGFNOHKKAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void OPGHOGCGLGK(HFFOFFCNLJO KADCNDCDAFC);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface AKPMHDCOBDM : AMEJAADBFPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NECOPEBCFFK OPFOFHIGBEE(Guid HIKJHHIHDMH);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CAKBCGBONLK(Guid HIKJHHIHDMH);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NBFHNGDJLCC(Guid HIKJHHIHDMH, Task GHANJBMHKCM);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DMHCJBGOKOM(Guid HIKJHHIHDMH, JECONNLHJLM HLGJFMJFIBD);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(JECONNLHJLM, Task)> BMKGEPPEECC(Guid HIKJHHIHDMH);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface MJGAJININMG : AMEJAADBFPI, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface EHPDHKHGABG : AMEJAADBFPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KPNIFGLHMPA(MELJGKFCAHJ ABHPFCOODAJ);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EKDPGFKAGBP(MELJGKFCAHJ ABHPFCOODAJ);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<OCIBBNFFMGC> GIJPEIKIIME(CancellationToken EPAOOCHDBOC);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface FEHMJBGBGCJ : AMEJAADBFPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NECOPEBCFFK KNGLILGJOAK(MELJGKFCAHJ LFCHFBAICPK);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EJIACLGEFHJ(Guid HIKJHHIHDMH, Task GHANJBMHKCM);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface MCFJKGCDPKP : AMEJAADBFPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JECONNLHJLM> HPECJPIFDLJ(MELJGKFCAHJ FIDPBJKINIB);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface LLBIHPPACPN : AMEJAADBFPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AICBJAIGANE> AALIFACJLHB(NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, DACBMNFKIFK MKMEIBFGEOE, CancellationToken CLIKNEKJHEI);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface EGOFNGONCHP : AMEJAADBFPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JECONNLHJLM JAAIODLAGNA(NKLIIMCFHAI AABOBDCMGCM);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JCDJCMMDIMP(string MBDMHLKHKIH);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface PJODHFMOMFN : AMEJAADBFPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MELJGKFCAHJ> DCBODNIKHKH(MELJGKFCAHJ ONMEAHDGGOB, DDJLHCONOLF ECCDJCBJDOD, CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<MELJGKFCAHJ> LLLCIJIMCDK(CancellationToken CLIKNEKJHEI, DDJLHCONOLF ECCDJCBJDOD);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEGLONMBGEN ENIHPEFKLOL(JMFJELLGOJH JPBCDGCOPME, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IEGLONMBGEN PMJEMFOIGBO(JMFJELLGOJH JPBCDGCOPME, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface LPJPPDEEHAD : AMEJAADBFPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JECONNLHJLM HLDICDCMEIM(NKLIIMCFHAI AABOBDCMGCM, OCIBBNFFMGC JKDKBHMNLIK);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JECONNLHJLM CGOJNOLEGEE(NKLIIMCFHAI DBBMECBIAHN);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface KOJFEOAFNNE
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LPJOELPKOOK(CCGMLMENJMD DNEEBJBKBNH);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MJEDJHPACFB(CCGMLMENJMD DNEEBJBKBNH);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KCJAHGJHGCH(CCGMLMENJMD DNEEBJBKBNH);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EFEFBBHKNPF(CCGMLMENJMD DNEEBJBKBNH);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class CCGMLMENJMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly DACBMNFKIFK IOPNKMFDHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> FAPEBFPLJCP;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public NPOAFBCOAIB<string> DADAHCOOHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8B6670", Offset = "0x8B5670", VA = "0x1808B6670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
	public CCGMLMENJMD(DACBMNFKIFK NFDMLIINBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x75692E0", Offset = "0x75682E0", VA = "0x1875692E0")]
	public CCGMLMENJMD CKOBPLNMILC(string MLAECOMLIEC, string BJDKOHEGDOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x75693B0", Offset = "0x75683B0", VA = "0x1875693B0")]
	public bool OIKMMLGPGBC([Out] IEnumerable<KeyValuePair<string, string>> JFGFFHLLLCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x67A0EB0", Offset = "0x679FEB0", VA = "0x1867A0EB0")]
	public CCGMLMENJMD HPBCEBOHDIB(NPOAFBCOAIB<string> FCPMHEOCJMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface BDINCNLOEGO
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool GHMHEIIKGBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	string GIKEFJEOFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool ONBDOFBKCKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HMKPGDNOMIP();

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JIDCMNNOIND ELKDDPDOEAG(long GEKHFNOGIOM);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MHEEBKLHMMD<LMNKCNKLBML, DPOFJEJGEFI> KIHFIMHMDMP(long GEKHFNOGIOM);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MHEEBKLHMMD<LMNKCNKLBML, MEGLOJMOHAP> GINIHFEPEDC(long GEKHFNOGIOM);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MHEEBKLHMMD<long, GCKCDKOFDGL> LBJDDNIONAB();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ABKBCJEAJLH(long GEKHFNOGIOM, [Out] bool HLOKHLJIFLL);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> LIPICOCCMPC(byte[] NMDHLPMFPLI, byte[] MOMPGFLGKNK, CancellationToken CLIKNEKJHEI);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface FJPHLODGACH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool FKJIPCCCJNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool LNPNJMHINNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	HFFOFFCNLJO OMAKKOGLJEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action PLCALAHBKPO;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event OFOLFKINMBL KMLEOMOBLAM;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event OFOLFKINMBL KBFLIBHLGOC;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event OFOLFKINMBL HDJEIMCKHLN;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<NNCNNOMHHHL, bool> IJKMGJIDDDM;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MNKGAPJGGGP();

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	LCKKNCFGDNL LKJCOMIGCNH();

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	JKOJDPOHFGC JPJFCHHHMNF();

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<JECONNLHJLM> PBELBGDLOFM(DDMELBGCFHO BMHPAPNFNDF);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task LAKELOKKBMK(CancellationToken CLIKNEKJHEI);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface IHGEMGGPDFH
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool CHOEKDBBJDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	string IKDPMPIMHEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JJCCPCJMHGO(Scene AIEPFDPEPFK);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task IIJPELHBICP(FELHNEMNIPM NIDAFJFKCHN, CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task DMEOPDOPFDG();

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task FPAFGLFCEOB();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface BJLINKIKEOI
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	GEDBAAOCPGO AOEDKDNFHGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool NGEDOBGILAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool DPGMMDCBKGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool EIHOJMDLMBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool NCNBJENHMDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	int FODJGMFBKOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool KGPIABHINMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool JOJHELEFBJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	int CFFLHMHDOIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	int PMNPDPLMJBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool FFCBCLKLPJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool EEFOMPOCKGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool KBPEKAMDIPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	float PLMIGPABIOH
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> GJOEAKHJGML;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MAONAIOKEHK DDFCDOOOKCC(MAONAIOKEHK FOEMAPKAAKA);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EBABPFCNAEA(MAONAIOKEHK GHHOPPHGNHJ);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LAFJOPALCBJ();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task GALAIMMOICE(NPOAFBCOAIB<string>.HFMLKGGDOCE HMKMCPGKLFM, CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GDOOJDANJEH(float FIDENFMFGLC);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void APBPDCCLHCE(string MHHGEPFPLHI);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<PHOFBAJGOEC> GOCAIIJLPIE();

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable DBOIGEDCODC(object NDMMIOJEOEB, PHOFBAJGOEC ECOGMCELFGJ);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<MJJDDOEJJFG> EOPBEJMJKKC();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DPOFJEJGEFI EBLJDCLMACF(IEnumerable<KGIKLNIIDMO> KFNIHDBIDNH);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MKEAEKCOAIJ(int NNMDNPOJCMN);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task MKNNOLIPPHE();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HDBFJMEAECK();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool EOEKCHPGODO();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task LCCFPMEJPMD(CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task JCOJAPPFGBK(CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<LKCMCONAKNK> KGIJCMKMIHK(DateTime LIMGCBPAOIM, CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> IBMNCFBHKPE(CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void PFMADFMKFCI(string ABHPFCOODAJ = "", float DHLFCHNFAOO = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "25")]
	MJIBNOBNJIH NFGCACCAJOJ(KHAOILFELCE MHDGHCKINHD, HGLLLDPICKK LOIODDCFEOI, MEGLOJMOHAP FMPDLEPAFOK, IEnumerable<PersistenceView> FBHEJKKKMFL, MDLEJLBEGJJ LHPIEFMJMFF);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void KJPDEFPDEFB(MEGLOJMOHAP FMPDLEPAFOK);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void LJIKEHNFFHP(KGIKLNIIDMO DBMIMADNHFB, [In] MJIBNOBNJIH DKKAILAIDCO);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task JPHNJDGFMEH(MEGLOJMOHAP MFJLOFOELBM, bool OEBGKDGHCKO, CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task IPAPBPLKLBB(CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void DDOPANIIBID(long AHNLEKFKAGC, long ABKHIAFPEJM, CDBHFDKLKGA JFCCOFMCJEI, BLNDCCHFGLB GFPCOFAOENO, APNIAAHHPPH DDPKEDDGOEO, MMJLHMCGMEI? BMGCMOIFIKB, BDJMLMAMKGL? ECFOOHBJAFO);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void IGADJGFNJNO(long AHNLEKFKAGC, long ABKHIAFPEJM, BDJMLMAMKGL? ECFOOHBJAFO);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void KFABDPBIOPC(PersistenceView NHAMJNEOMDF);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool BFOPGOJFEMI(PersistenceView NJFNPGALOJK);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool EIPNOFKIGOJ(KGIKLNIIDMO DBMIMADNHFB, PMEDDBIJCLE POFDAGBFGME, [Out] FIPIAHAGJDH FABDPPCOGEG);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task ELIGDACOMJM(CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void POBNEKAAOHE();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable HIBDMJJHGOJ();

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void FABPLKBIMKA(MEGLOJMOHAP MFJLOFOELBM, PMEDDBIJCLE POFDAGBFGME);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<bool> LMACMHEJPFK(ADPKBHEBFGA INDOLNBFLPL, CancellationToken CLIKNEKJHEI, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void ENOMHHMICFG(CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<PNDDKICJKKP> ADBEMCMENLB(COBJAIIOCOI ONMEAHDGGOB);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<CDBHFDKLKGA> OOODAJPAPLO(long AHNLEKFKAGC, bool HNODMJIGHDL, CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<BLNDCCHFGLB> MNMPICFGGAG(long AHNLEKFKAGC, long ABKHIAFPEJM, long ADPOGHGNAJP, CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<BLNDCCHFGLB> GJADKMBIDMG(long AHNLEKFKAGC, long ABKHIAFPEJM, CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<FEPJAEOAPIH> NDMHGKMAOCF(string PBJMLELNKLD, CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<FEPJAEOAPIH> MBEDMMNCJIB(string PBJMLELNKLD, long AHNLEKFKAGC, long ABKHIAFPEJM, string HABIMNBKOCK, FMDNIBANCGK.ELIBJFNAEOD EBLANDLJNLN, FMDNIBANCGK.ELIBJFNAEOD MOMPGFLGKNK, int ILCJANKFAMK);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool MPABPKDGDKB();

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "49")]
	bool FGLJIMMFAIE();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool GOKBMJHIDOC(IEnumerable<FIPIAHAGJDH> CCHPDJMDPFD);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void PKGNLKFIDNK(List<GameObject> OKLJFDEACOC);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "52")]
	float LPJFNFEEDEP();

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "53")]
	Task<Scene> PBOPDEAEKMM(string DEJGJBPGHEM, LoadSceneMode HNNKFMAKPEO, bool NNIIFEPANPE, NPOAFBCOAIB<string>.HFMLKGGDOCE FCPMHEOCJMB);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void AMIMKBOBFHN();

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void NDHOHBLEGLB(bool MBINENIOFBM);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void NEHCLAOEHJH();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void JKMFENGKDBF();

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void AODGJAGGNEA(DACBMNFKIFK PEPCMELAIJD);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Task PBAPKPKEFCO(NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "69")]
	Task JJGJCBAJNOB(NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "70")]
	Task NLOEJHHACCI(NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "71")]
	Task LECFBIJDMEH(NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "72")]
	IDisposable HLDADPKLOEA();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "73")]
	ALGFHKDIPPP MFCFNFEPMID();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task KFINPDIAIOC(CancellationToken CLIKNEKJHEI);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface ALGFHKDIPPP
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task OAHAKMMKGLO(CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GKFMEJKBPDB(CancellationToken CLIKNEKJHEI);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct MJIBNOBNJIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> JECFEPBOENE;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum LKCMCONAKNK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct KHAOILFELCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string MLNAJKCBPOJ;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface GEDBAAOCPGO
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	DACBMNFKIFK GCCNOMJGODC
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	CDBHFDKLKGA HEMLAFJPHME
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	ALMBCFFNDNC JGPAJBMMKGK
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool NMJICJOFOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool MAFMPNLIGEA
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	int FDHFNEMNENC
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action NNEINJPEKPN;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> GIOEMPADANF;

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CKGIAGEGOHO();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.BDLOKBIGMPF> PHBNOFFPFDH(long GEKHFNOGIOM, [Optional] CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<GLMIOBONDBE> GEPOFJHMMLG();

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task FDHOAFBBMGN();

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(DACBMNFKIFK, HFFOFFCNLJO) DFAIMLCGICF();

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "15")]
	ICGKNEKHLMH CGIKFENPENK();

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void AOMJCHOMCMH(long GEKHFNOGIOM);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DFMKOEGELLH(DACBMNFKIFK NFDMLIINBHB, Matchmaking.FHLDJHEDPPB POCKBMKNJHC, (int Major, int? Minor)? HPCOEPBBODK);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface MGPNOBNFNBD
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GDNLIJILMKH([Out] IEnumerable<int> KNEKNGLJMDA);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ANMJOMMKMOL(FMCPMEFHBJK NANMDIJGGLP);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ILMKOMFNIIC(FMCPMEFHBJK NANMDIJGGLP);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface FLFOCLPDCHC
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string IOAKJHHPEHO(JECONNLHJLM BBBCHCBNGPL);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface OPCNAAKGIKC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CHLDIFNOLAF(NEAAIJPPJCI.JCPGPOOHDEP FMNFFIDNIHB);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BMPCMKFPPKL(NEAAIJPPJCI.JCPGPOOHDEP FMNFFIDNIHB);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface CIPEABMEBIL : OPCNAAKGIKC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JECONNLHJLM PBCBOAECJFH(NKLIIMCFHAI DBBMECBIAHN);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface IOKFDEJPJJE : OPCNAAKGIKC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JECONNLHJLM JAAIODLAGNA(NKLIIMCFHAI FOMGKNFCKEA);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface JIDCMNNOIND
{
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OBFFLKDLIBJ<FELHNEMNIPM, PPOILIOPEKP>> HEMBLCNMPCO(string HABIMNBKOCK, long GEKHFNOGIOM, long? AHNLEKFKAGC, long? ABKHIAFPEJM, MLCHNALLIKI.NPOLGANCKCJ INGCDLNACPB, CancellationToken CLIKNEKJHEI);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface MHEEBKLHMMD<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OBFFLKDLIBJ<IIOIPHLGGKA<TData>, PPOILIOPEKP>> EAJMLMFKOEC(TGetDataArg FPMIIFOGKII, CancellationToken CLIKNEKJHEI);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class MFNOOJJJMHG : NDFFAKPPKGI, FJPHLODGACH, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct PKPBODDENGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public AsyncTaskMethodBuilder<JECONNLHJLM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public MFNOOJJJMHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public DDMELBGCFHO autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<JECONNLHJLM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x75833C0", Offset = "0x75823C0", VA = "0x1875833C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7583640", Offset = "0x7582640", VA = "0x187583640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct MCPHKANCIEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public MFNOOJJJMHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x757ED10", Offset = "0x757DD10", VA = "0x18757ED10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x757EF40", Offset = "0x757DF40", VA = "0x18757EF40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class CNKCDMHCCMJ : IEnumerable<AMEJAADBFPI>, IEnumerable, IEnumerator<AMEJAADBFPI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private AMEJAADBFPI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public MFNOOJJJMHG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		private AMEJAADBFPI System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x90ECF0", Offset = "0x90DCF0", VA = "0x18090ECF0")]
		[DebuggerHidden]
		public CNKCDMHCCMJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7569E20", Offset = "0x7568E20", VA = "0x187569E20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x756A280", Offset = "0x7569280", VA = "0x18756A280", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x756A1D0", Offset = "0x75691D0", VA = "0x18756A1D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<AMEJAADBFPI> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x756A1D0", Offset = "0x75691D0", VA = "0x18756A1D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource JOKLJFHIPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly MAONAIOKEHK GHHOPPHGNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool PPKGDGFGJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private PDMKPIOFBAK PLKIIEEABMJ;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public ADPKBHEBFGA GFDFJIONEDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8B42A0", Offset = "0x8B32A0", VA = "0x1808B42A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8B42D0", Offset = "0x8B32D0", VA = "0x1808B42D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public NAMMGGILKND EEABMHEBHBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8B4280", Offset = "0x8B3280", VA = "0x1808B4280", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8B42B0", Offset = "0x8B32B0", VA = "0x1808B42B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public BJLINKIKEOI PAMCFEMCNIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8B4290", Offset = "0x8B3290", VA = "0x1808B4290", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8B4240", Offset = "0x8B3240", VA = "0x1808B4240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public IHGEMGGPDFH IOKPAKKICCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8B4270", Offset = "0x8B3270", VA = "0x1808B4270", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8B42C0", Offset = "0x8B32C0", VA = "0x1808B42C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public CIPEABMEBIL NHPAAHDFMHG
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8B4260", Offset = "0x8B3260", VA = "0x1808B4260", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8B4250", Offset = "0x8B3250", VA = "0x1808B4250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public IOKFDEJPJJE EIFDAJBBDLP
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8B81A0", Offset = "0x8B71A0", VA = "0x1808B81A0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8B8320", Offset = "0x8B7320", VA = "0x1808B8320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public DFJODANGFCB LHGABIKKFIF
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8B8270", Offset = "0x8B7270", VA = "0x1808B8270", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8B8380", Offset = "0x8B7380", VA = "0x1808B8380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public BHAEJLBNBBO HPEIOELBJJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8B82B0", Offset = "0x8B72B0", VA = "0x1808B82B0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8B81B0", Offset = "0x8B71B0", VA = "0x1808B81B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public CKPJMGIAIBO IFJIJIOFDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x952970", Offset = "0x951970", VA = "0x180952970", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xECA090", Offset = "0xEC9090", VA = "0x180ECA090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public KGPJCADDDPH PILOGMPKBLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8B8220", Offset = "0x8B7220", VA = "0x1808B8220", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8B82D0", Offset = "0x8B72D0", VA = "0x1808B82D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public CKAJIHJAIFJ BHJPAKGMKGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xAC53E0", Offset = "0xAC43E0", VA = "0x180AC53E0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xAC0B90", Offset = "0xABFB90", VA = "0x180AC0B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public COGJJJEDKIO AOBAHGNMMBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8BEAB0", Offset = "0x8BDAB0", VA = "0x1808BEAB0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8BEA70", Offset = "0x8BDA70", VA = "0x1808BEA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public EPOCDPBBMKI JMLEELIDPMK
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x9517A0", VA = "0x1809527A0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BB0", Offset = "0xAC6BB0", VA = "0x180AC7BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public AKPMHDCOBDM GGFHEIMOOGC
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x98EE20", Offset = "0x98DE20", VA = "0x18098EE20", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x98EE30", Offset = "0x98DE30", VA = "0x18098EE30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public MJGAJININMG AMGKKEFIAAI
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA17170", Offset = "0xA16170", VA = "0x180A17170", Slot = "57")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xD1DF70", Offset = "0xD1CF70", VA = "0x180D1DF70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public EHPDHKHGABG ECGLBHNBFBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x93E360", Offset = "0x93D360", VA = "0x18093E360", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9C0320", Offset = "0x9BF320", VA = "0x1809C0320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public FEHMJBGBGCJ GAHEBOMKHFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA16F90", Offset = "0xA15F90", VA = "0x180A16F90", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xB1D550", Offset = "0xB1C550", VA = "0x180B1D550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public MCFJKGCDPKP HPECJPIFDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8BEA60", Offset = "0x8BDA60", VA = "0x1808BEA60", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8BEAC0", Offset = "0x8BDAC0", VA = "0x1808BEAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public LLBIHPPACPN DIDENHOMEGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x952790", Offset = "0x951790", VA = "0x180952790", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xDC4CC0", Offset = "0xDC3CC0", VA = "0x180DC4CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public PJODHFMOMFN FEFEIMGBJEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA17120", Offset = "0xA16120", VA = "0x180A17120", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xF7D730", Offset = "0xF7C730", VA = "0x180F7D730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public EGOFNGONCHP JLCNIDEEHGK
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x900980", Offset = "0x8FF980", VA = "0x180900980", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9BEC50", Offset = "0x9BDC50", VA = "0x1809BEC50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public LPJPPDEEHAD BINAIJPMKFB
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA17040", Offset = "0xA16040", VA = "0x180A17040", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xDC3B50", Offset = "0xDC2B50", VA = "0x180DC3B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public KOJFEOAFNNE JGDFAFMDDGI
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA171F0", Offset = "0xA161F0", VA = "0x180A171F0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xAB0170", Offset = "0xAAF170", VA = "0x180AB0170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public MGPNOBNFNBD BKPEELDJGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x96BCF0", Offset = "0x96ACF0", VA = "0x18096BCF0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xF7D850", Offset = "0xF7C850", VA = "0x180F7D850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public IAENGOKJJDM BMLFDOKOMFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x9A3680", Offset = "0x9A2680", VA = "0x1809A3680", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x9A32F0", Offset = "0x9A22F0", VA = "0x1809A32F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public GGNDNDFMJFF AIIPGOFCKEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x9A5F70", Offset = "0x9A4F70", VA = "0x1809A5F70", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x9A3870", Offset = "0x9A2870", VA = "0x1809A3870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public BDINCNLOEGO IHAKDFMJOCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9BCF80", Offset = "0x9BBF80", VA = "0x1809BCF80", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x9B7CA0", Offset = "0x9B6CA0", VA = "0x1809B7CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public HICNBKJEEFO CKABEBLJMOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA170B0", Offset = "0xA160B0", VA = "0x180A170B0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public JPCAEPIBHHL PFBLKEKGAPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA170C0", Offset = "0xA160C0", VA = "0x180A170C0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public JLNHNNPKCNJ JKJIOHIBNKM
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA170D0", Offset = "0xA160D0", VA = "0x180A170D0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public JGHFHJBGHPA FDBANICCKEK
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA170E0", Offset = "0xA160E0", VA = "0x180A170E0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public IHHBGHBEOLK FEGFNOHKKAL
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x9B1A40", Offset = "0x9B0A40", VA = "0x1809B1A40", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public HFFOFFCNLJO OMAKKOGLJEG
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xB08460", Offset = "0xB07460", VA = "0x180B08460", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xB7DBA0", Offset = "0xB7CBA0", VA = "0x180B7DBA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private bool IDPDMOPPNDN
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x757FA30", Offset = "0x757EA30", VA = "0x18757FA30", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private bool EMBDCAOLPCK
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x757F720", Offset = "0x757E720", VA = "0x18757F720", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private CancellationToken MHGIADLLIGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x757F700", Offset = "0x757E700", VA = "0x18757F700", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private MAONAIOKEHK LIDIOBCJKAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action LHMNKBMMNIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x757F520", Offset = "0x757E520", VA = "0x18757F520", Slot = "38")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x757FA90", Offset = "0x757EA90", VA = "0x18757FA90", Slot = "39")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event OFOLFKINMBL KNKJAKEJOMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x757F640", Offset = "0x757E640", VA = "0x18757F640", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x757F000", Offset = "0x757E000", VA = "0x18757F000", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event OFOLFKINMBL IKEHANDJJOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x757F6A0", Offset = "0x757E6A0", VA = "0x18757F6A0", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x757F580", Offset = "0x757E580", VA = "0x18757F580", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event OFOLFKINMBL OJNOEKJNGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x757EFA0", Offset = "0x757DFA0", VA = "0x18757EFA0", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x757F5E0", Offset = "0x757E5E0", VA = "0x18757F5E0", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<NNCNNOMHHHL, bool> KNKMHGGBJGN
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x757F460", Offset = "0x757E460", VA = "0x18757F460", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x757F4C0", Offset = "0x757E4C0", VA = "0x18757F4C0", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0xB7DBA0", Offset = "0xB7CBA0", VA = "0x180B7DBA0", Slot = "37")]
	public void OPGHOGCGLGK(HFFOFFCNLJO KADCNDCDAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x757FAF0", Offset = "0x757EAF0", VA = "0x18757FAF0")]
	[UnityEngine.Scripting.Preserve]
	internal MFNOOJJJMHG([GAHPILLNNBL(null)] MAONAIOKEHK GHHOPPHGNHJ, [GAHPILLNNBL(null)] ADPKBHEBFGA INDOLNBFLPL, [GAHPILLNNBL(null)] NAMMGGILKND ECAGNCOFFKH, [GAHPILLNNBL(null)] BJLINKIKEOI LAFNKOLGHIB, [GAHPILLNNBL(null)] IHGEMGGPDFH HMFMADKBEDF, [GAHPILLNNBL(null)] CIPEABMEBIL FKAFANCBEPF, [GAHPILLNNBL(null)] IOKFDEJPJJE PLCEJCAGGKI, [GAHPILLNNBL(null)] DFJODANGFCB EMONDMHOGFB, [GAHPILLNNBL(null)] BHAEJLBNBBO ABGGLBKKFBI, [GAHPILLNNBL(null)] CKPJMGIAIBO HFLNHDFBHGB, [GAHPILLNNBL(null)] KGPJCADDDPH OMDLBKEDMJF, [GAHPILLNNBL(null)] CKAJIHJAIFJ MCJDGPBKPGO, [GAHPILLNNBL(null)] COGJJJEDKIO MCMPAJJBLML, [GAHPILLNNBL(null)] EPOCDPBBMKI KBLGPBCBKIE, [GAHPILLNNBL(null)] AKPMHDCOBDM CHFJMFHPHPC, [GAHPILLNNBL(null)] MJGAJININMG JIACDNOIGEB, [GAHPILLNNBL(null)] EHPDHKHGABG ILFFJFPJDNJ, [GAHPILLNNBL(null)] FEHMJBGBGCJ DFIMLPFMBDG, [GAHPILLNNBL(null)] MCFJKGCDPKP HHODAEDCDGO, [GAHPILLNNBL(null)] LLBIHPPACPN BINNPDPCHJM, [GAHPILLNNBL(null)] EGOFNGONCHP JBEMOPCOPFE, [GAHPILLNNBL(null)] PJODHFMOMFN AGKPKBKPFAG, [GAHPILLNNBL(null)] LPJPPDEEHAD GCLEJPJHOHE, [GAHPILLNNBL(null)] KOJFEOAFNNE BDOEEDJPBNF, [GAHPILLNNBL(null)] MGPNOBNFNBD EILHMPIKCHF, [GAHPILLNNBL(null)] GGNDNDFMJFF CLGKEAHKEGA, [GAHPILLNNBL(null)] BDINCNLOEGO EILEBHOKJGN, [GAHPILLNNBL(null)] HICNBKJEEFO CEEBOIKJBDE, [GAHPILLNNBL(null)] JPCAEPIBHHL BMPGPDNDFKB, [GAHPILLNNBL(null)] JLNHNNPKCNJ LINNCDPHGFG, [GAHPILLNNBL(null)] JGHFHJBGHPA BMLKMEAHKAO, [GAHPILLNNBL(null)] IHHBGHBEOLK GKELIIIBCBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x757F1D0", Offset = "0x757E1D0", VA = "0x18757F1D0")]
	private void CPDDJGLEDNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x757F2D0", Offset = "0x757E2D0", VA = "0x18757F2D0", Slot = "56")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x757F280", Offset = "0x757E280", VA = "0x18757F280", Slot = "50")]
	private void DICLPKAAEBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x757F9A0", Offset = "0x757E9A0", VA = "0x18757F9A0", Slot = "51")]
	private LCKKNCFGDNL MBCFIAELONB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x757F0E0", Offset = "0x757E0E0", VA = "0x18757F0E0", Slot = "52")]
	private JKOJDPOHFGC CDOMGJPJDII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x757F7A0", Offset = "0x757E7A0", VA = "0x18757F7A0", Slot = "53")]
	[AsyncStateMachine(typeof(PKPBODDENGG))]
	private Task<JECONNLHJLM> LFKBDGFIBAB(DDMELBGCFHO CBNDKFAOHGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x757F8B0", Offset = "0x757E8B0", VA = "0x18757F8B0", Slot = "54")]
	[AsyncStateMachine(typeof(MCPHKANCIEC))]
	private Task LJOKMFPNPNI(CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x757F060", Offset = "0x757E060", VA = "0x18757F060")]
	[IteratorStateMachine(typeof(CNKCDMHCCMJ))]
	private IEnumerable<AMEJAADBFPI> AODBBCFJHAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x757F170", Offset = "0x757E170", VA = "0x18757F170")]
	[CompilerGenerated]
	private void CHAGGCJLNKD(AMEJAADBFPI GEICOLLOJJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class FIINCCCMMKF : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x1310E00", Offset = "0x130FE00", VA = "0x181310E00")]
	public FIINCCCMMKF(string ABHPFCOODAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal class FKKCOCEBMCF : JPDIEHLGINJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct EMGKIFHIBKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public FKKCOCEBMCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x756FCF0", Offset = "0x756ECF0", VA = "0x18756FCF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7570030", Offset = "0x756F030", VA = "0x187570030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly NDFFAKPPKGI GAIEJGCLEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly BJLINKIKEOI LAFNKOLGHIB;

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x8C0B80", Offset = "0x8BFB80", VA = "0x1808C0B80")]
	public FKKCOCEBMCF(NDFFAKPPKGI GAIEJGCLEHG, BJLINKIKEOI LAFNKOLGHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x7576C90", Offset = "0x7575C90", VA = "0x187576C90", Slot = "4")]
	[AsyncStateMachine(typeof(EMGKIFHIBKA))]
	public Task<bool> JKKGLFJHGLK(CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x7576BB0", Offset = "0x7575BB0", VA = "0x187576BB0")]
	[CompilerGenerated]
	private object BNHCCNMIAFN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal class CLADAKHEJGC : JPDIEHLGINJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct CHBIIAJIEBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public CLADAKHEJGC <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7569440", Offset = "0x7568440", VA = "0x187569440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7569B50", Offset = "0x7568B50", VA = "0x187569B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly NDFFAKPPKGI GAIEJGCLEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly BJLINKIKEOI LAFNKOLGHIB;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private GEDBAAOCPGO AOEDKDNFHGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7569CF0", Offset = "0x7568CF0", VA = "0x187569CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x8C0B80", Offset = "0x8BFB80", VA = "0x1808C0B80")]
	public CLADAKHEJGC(NDFFAKPPKGI GAIEJGCLEHG, BJLINKIKEOI LAFNKOLGHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x7569BC0", Offset = "0x7568BC0", VA = "0x187569BC0", Slot = "4")]
	[AsyncStateMachine(typeof(CHBIIAJIEBK))]
	public Task<bool> JKKGLFJHGLK(CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x7569D40", Offset = "0x7568D40", VA = "0x187569D40")]
	[CompilerGenerated]
	private object NDPMMKKHIGC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal class NDKMGOBNFDO : JPDIEHLGINJ
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class MBINBMCBAJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public NDKMGOBNFDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public GLMIOBONDBE result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public DACBMNFKIFK newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public MBINBMCBAJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x757EB10", Offset = "0x757DB10", VA = "0x18757EB10")]
		internal object DAEAAKJCMBD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x757ECA0", Offset = "0x757DCA0", VA = "0x18757ECA0")]
		internal object NPPMCDCLECB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x757EC00", Offset = "0x757DC00", VA = "0x18757EC00")]
		internal object GMGIODHICDB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct FFIGIENAPLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public NDKMGOBNFDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private MBINBMCBAJP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<GLMIOBONDBE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x75702D0", Offset = "0x756F2D0", VA = "0x1875702D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x7570BE0", Offset = "0x756FBE0", VA = "0x187570BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly NDFFAKPPKGI GAIEJGCLEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly BJLINKIKEOI LAFNKOLGHIB;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private GEDBAAOCPGO AOEDKDNFHGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x75828D0", Offset = "0x75818D0", VA = "0x1875828D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x8C0B80", Offset = "0x8BFB80", VA = "0x1808C0B80")]
	public NDKMGOBNFDO(NDFFAKPPKGI GAIEJGCLEHG, BJLINKIKEOI LAFNKOLGHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x75827B0", Offset = "0x75817B0", VA = "0x1875827B0", Slot = "4")]
	[AsyncStateMachine(typeof(FFIGIENAPLE))]
	public Task<bool> JKKGLFJHGLK(CancellationToken CLIKNEKJHEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal interface JPDIEHLGINJ
{
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> JKKGLFJHGLK(CancellationToken CLIKNEKJHEI);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal struct IKLJHLCJJMI
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class BKFKCEAPNFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public NDFFAKPPKGI manager;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public BKFKCEAPNFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7568D60", Offset = "0x7567D60", VA = "0x187568D60")]
		internal Task DJECEHAPFOL(CancellationToken cancellationToken, int roomTotalVersion, FCBKKHIFGAP localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct PPEIKDNDCCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public IKLJHLCJJMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private DDMELBGCFHO <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter<LKCMCONAKNK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter<JECONNLHJLM> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7584830", Offset = "0x7583830", VA = "0x187584830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7584DC0", Offset = "0x7583DC0", VA = "0x187584DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct PLJACMGKNEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public IKLJHLCJJMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x75836B0", Offset = "0x75826B0", VA = "0x1875836B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x75839D0", Offset = "0x75829D0", VA = "0x1875839D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly CancellationToken CLIKNEKJHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly NDFFAKPPKGI PMNMDCCMPDH;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	private ADPKBHEBFGA GFDFJIONEDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7578C50", Offset = "0x7577C50", VA = "0x187578C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private BJLINKIKEOI PAMCFEMCNIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7578B50", Offset = "0x7577B50", VA = "0x187578B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private GEDBAAOCPGO AOEDKDNFHGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7578DC0", Offset = "0x7577DC0", VA = "0x187578DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private CKPJMGIAIBO IFJIJIOFDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7578D70", Offset = "0x7577D70", VA = "0x187578D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x23003F0", Offset = "0x22FF3F0", VA = "0x1823003F0")]
	public IKLJHLCJJMI(CancellationToken CLIKNEKJHEI, NDFFAKPPKGI PMNMDCCMPDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x7578BA0", Offset = "0x7577BA0", VA = "0x187578BA0")]
	public static EFCGCAALBMD DDOPJEAAOBC(NDFFAKPPKGI PMNMDCCMPDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x7578E40", Offset = "0x7577E40", VA = "0x187578E40")]
	[AsyncStateMachine(typeof(PPEIKDNDCCH))]
	public Task<bool> LAHPNPBPBKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x7578F50", Offset = "0x7577F50", VA = "0x187578F50")]
	private bool LPFMMEBOAOG([Out] DDMELBGCFHO CBNDKFAOHGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x7578CA0", Offset = "0x7577CA0", VA = "0x187578CA0")]
	[AsyncStateMachine(typeof(PLJACMGKNEF))]
	private Task FFFOKNGHCEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7579160", Offset = "0x7578160", VA = "0x187579160")]
	private Task<LKCMCONAKNK> NBPHBAHCDCE(DDMELBGCFHO GCDICEJLIDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal struct NECOPEBCFFK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly AKPMHDCOBDM CHFJMFHPHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Guid HIKJHHIHDMH;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Task<(JECONNLHJLM, Task)> BAOMMGELEGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7582A40", Offset = "0x7581A40", VA = "0x187582A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x470CA70", Offset = "0x470BA70", VA = "0x18470CA70")]
	public NECOPEBCFFK(AKPMHDCOBDM CHFJMFHPHPC, Guid HIKJHHIHDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7582920", Offset = "0x7581920", VA = "0x187582920")]
	public TaskAwaiter<(JECONNLHJLM, Task)> ALMCJCFOGEI()
	{
		return default(TaskAwaiter<(JECONNLHJLM, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7582970", Offset = "0x7581970", VA = "0x187582970", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal struct DGDPAMDNOFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly TaskCompletionSource<(JECONNLHJLM, Task)> FIAKMNCADJH;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Task<(JECONNLHJLM, Task)> BAOMMGELEGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x756AB30", Offset = "0x7569B30", VA = "0x18756AB30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x756AC10", Offset = "0x7569C10", VA = "0x18756AC10")]
	public DGDPAMDNOFL(TimeSpan AMBGDNGJBFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x756AB70", Offset = "0x7569B70", VA = "0x18756AB70")]
	public void NFAPBEDCKAO(Task GHANJBMHKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x756A9C0", Offset = "0x75699C0", VA = "0x18756A9C0")]
	public void DAKCIPCJOAK(JECONNLHJLM BBBCHCBNGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x756AA50", Offset = "0x7569A50", VA = "0x18756AA50")]
	public void JDMMCDAAGND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x756AAA0", Offset = "0x7569AA0", VA = "0x18756AAA0")]
	internal void MHAAGAIDLKJ(string ABHPFCOODAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class MMFNECFFMID
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class JHGMKHIHHMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public BLNDCCHFGLB subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public JHGMKHIHHMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x757A510", Offset = "0x7579510", VA = "0x18757A510")]
		internal bool NLKFEADFBDP(ALMBCFFNDNC s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x757FF70", Offset = "0x757EF70", VA = "0x18757FF70")]
	public static AICBJAIGANE AIOPMLNOOEO(long KAPPOFOAIGF, long ABKHIAFPEJM, string PBJMLELNKLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7580000", Offset = "0x757F000", VA = "0x187580000")]
	public static AICBJAIGANE AIOPMLNOOEO(long KAPPOFOAIGF, long ABKHIAFPEJM, LMNKCNKLBML NMDHLPMFPLI, long ADPOGHGNAJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x75802F0", Offset = "0x757F2F0", VA = "0x1875802F0")]
	public static AICBJAIGANE AIOPMLNOOEO(PNDDKICJKKP HFHHPECCNOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x75800C0", Offset = "0x757F0C0", VA = "0x1875800C0")]
	public static AICBJAIGANE AIOPMLNOOEO(CDBHFDKLKGA EMEOAOHFFAF, BLNDCCHFGLB AFMFNHPKOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7580480", Offset = "0x757F480", VA = "0x187580480")]
	public static AICBJAIGANE HJDGJJCEKKB(this AICBJAIGANE NDBAHEIEDNL, CDBHFDKLKGA PEIMMHNPEJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7580570", Offset = "0x757F570", VA = "0x187580570")]
	public static AICBJAIGANE KCEMNNBCCMG(this AICBJAIGANE NDBAHEIEDNL, BLNDCCHFGLB DNHAJMPABPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[RecRoom.NoEngine.Common.Preserve]
internal class JDLHPLOCINI : BHAEJLBNBBO, AMEJAADBFPI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct BGNCAJPELFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public JDLHPLOCINI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private JMBOKLBNKIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7568670", Offset = "0x7567670", VA = "0x187568670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7568D00", Offset = "0x7567D00", VA = "0x187568D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly FMCPMEFHBJK ADDDBFFGPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private string BDMCINBCLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Task IJBBAKKJGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private NDFFAKPPKGI GAIEJGCLEHG;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool MEFHFOIGJBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x757A140", Offset = "0x7579140", VA = "0x18757A140", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public Task IBEOGPEDNBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x757A170", Offset = "0x7579170", VA = "0x18757A170", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x8BB020", Offset = "0x8BA020", VA = "0x1808BB020", Slot = "7")]
	public void CPDDJGLEDNE(NDFFAKPPKGI GAIEJGCLEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x757A200", Offset = "0x7579200", VA = "0x18757A200", Slot = "6")]
	public void INKMJJKNCBD(Task KDFIPCHFLGF, string JMMGBDNJIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x757A360", Offset = "0x7579360", VA = "0x18757A360")]
	[AsyncStateMachine(typeof(BGNCAJPELFG))]
	private Task OPFEOKLIFMO(Task DDMEOAEPJBC, string JMMGBDNJIIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x757A480", Offset = "0x7579480", VA = "0x18757A480")]
	public JDLHPLOCINI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class NCOIIFFFPGN : IAENGOKJJDM, AMEJAADBFPI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool MCCCLDJJDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private CMOHEPIBNDC DKAOOHMEJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private ADPKBHEBFGA INDOLNBFLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private GGNDNDFMJFF CLGKEAHKEGA;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public CMOHEPIBNDC IBMBPEEGMLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7581C50", Offset = "0x7580C50", VA = "0x187581C50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7581820", Offset = "0x7580820", VA = "0x187581820", Slot = "7")]
	public void CPDDJGLEDNE(NDFFAKPPKGI GAIEJGCLEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7581AA0", Offset = "0x7580AA0", VA = "0x187581AA0", Slot = "5")]
	public void GLNLCKJJIFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x75819A0", Offset = "0x75809A0", VA = "0x1875819A0", Slot = "6")]
	public void OLAMMJBINJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x75819E0", Offset = "0x75809E0", VA = "0x1875819E0")]
	private Task FDDCEEPMBAE(HLBMMCGLCGG BEELICCCBAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x75819A0", Offset = "0x75809A0", VA = "0x1875819A0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public NCOIIFFFPGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal class DALJLFDBBAH : GGNDNDFMJFF
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private class FNGPCMJMOFI<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly OJMFEDOPAFE JFKDGCHPBMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly string MLAECOMLIEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly T MJBMFFMBOMO;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public T DMNEEJMINJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x98E930", Offset = "0x98D930", VA = "0x18098E930")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0xA3A990", Offset = "0xA39990", VA = "0x180A3A990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x401A190", Offset = "0x4019190", VA = "0x18401A190")]
		public FNGPCMJMOFI(OJMFEDOPAFE JFKDGCHPBMJ, string MLAECOMLIEC, T MJBMFFMBOMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x4019D70", Offset = "0x4018D70", VA = "0x184019D70")]
		private void GNLAGMNHMLH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly OJMFEDOPAFE JFKDGCHPBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly FNGPCMJMOFI<TimeSpan> KKFNHOENOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly FNGPCMJMOFI<TimeSpan> PNMDBJAJPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly FNGPCMJMOFI<TimeSpan> IAOBBKELKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly FNGPCMJMOFI<TimeSpan> IMOJBANCDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly FNGPCMJMOFI<bool> FIICABKGIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly FNGPCMJMOFI<bool> INMMCGGMPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly FNGPCMJMOFI<bool> NPMDPDKJEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly FNGPCMJMOFI<int> OCEAFLHAFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly FNGPCMJMOFI<bool> ADIIDBOCGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly FNGPCMJMOFI<bool> CNEBACFKCIL;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public TimeSpan GPOPLDPDGIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x756A310", Offset = "0x7569310", VA = "0x18756A310", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public TimeSpan NDFMNNDEGPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x756A2D0", Offset = "0x75692D0", VA = "0x18756A2D0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public TimeSpan NABOHIMLOLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x756A410", Offset = "0x7569410", VA = "0x18756A410", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public TimeSpan HDFJKHFJHCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x756A510", Offset = "0x7569510", VA = "0x18756A510", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool HDBEOMFKFNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x756A3D0", Offset = "0x75693D0", VA = "0x18756A3D0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool MDHMLEBJJCE
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x756A4D0", Offset = "0x75694D0", VA = "0x18756A4D0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool NFNNIPKHOEN
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x756A450", Offset = "0x7569450", VA = "0x18756A450", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int OPOPKKGHNLP
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x756A490", Offset = "0x7569490", VA = "0x18756A490", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool PLBLGBLNFGE
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x756A390", Offset = "0x7569390", VA = "0x18756A390", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool NOJLLPFAHGM
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x756A350", Offset = "0x7569350", VA = "0x18756A350", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x756A550", Offset = "0x7569550", VA = "0x18756A550")]
	[UnityEngine.Scripting.Preserve]
	public DALJLFDBBAH([GAHPILLNNBL(null)] OJMFEDOPAFE JFKDGCHPBMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[UnityEngine.Scripting.Preserve]
internal class NCOMJJPAIKP : KGPJCADDDPH, AMEJAADBFPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class PNHHODLKFLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public JNNCAHPPKJI roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public PNHHODLKFLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x7583A30", Offset = "0x7582A30", VA = "0x187583A30")]
		internal object EJPKANMPLHI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action PLCALAHBKPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x75824C0", Offset = "0x75814C0", VA = "0x1875824C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x7581F50", Offset = "0x7580F50", VA = "0x187581F50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event OFOLFKINMBL KMLEOMOBLAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7582590", Offset = "0x7581590", VA = "0x187582590", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x7581CC0", Offset = "0x7580CC0", VA = "0x187581CC0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event OFOLFKINMBL KBFLIBHLGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7582370", Offset = "0x7581370", VA = "0x187582370", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7582040", Offset = "0x7581040", VA = "0x187582040", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event OFOLFKINMBL HDJEIMCKHLN
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7582710", Offset = "0x7581710", VA = "0x187582710", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x75820E0", Offset = "0x75810E0", VA = "0x1875820E0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<NNCNNOMHHHL, bool> IJKMGJIDDDM
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x7582660", Offset = "0x7581660", VA = "0x187582660", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x7582410", Offset = "0x7581410", VA = "0x187582410", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "19")]
	public void CPDDJGLEDNE(NDFFAKPPKGI GAIEJGCLEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x7581D60", Offset = "0x7580D60", VA = "0x187581D60", Slot = "14")]
	public void CKJECNLDFEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x7582560", Offset = "0x7581560", VA = "0x187582560", Slot = "15")]
	public void MNLLABGNLAN(JNNCAHPPKJI MCPCCOBALOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x7582180", Offset = "0x7581180", VA = "0x187582180", Slot = "16")]
	public void ICGEOIBBJLH(JNNCAHPPKJI MCPCCOBALOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7582630", Offset = "0x7581630", VA = "0x187582630", Slot = "17")]
	public void NDNLEEIONIF(JNNCAHPPKJI MCPCCOBALOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7581FF0", Offset = "0x7580FF0", VA = "0x187581FF0", Slot = "18")]
	public void FGNJMFGFJCH(NNCNNOMHHHL HOAFJBCIPPP, bool BDKLGGLGLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x75821B0", Offset = "0x75811B0", VA = "0x1875821B0")]
	private void IJNFOBHJKBL(OFOLFKINMBL ECOGMCELFGJ, JNNCAHPPKJI MCPCCOBALOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public NCOMJJPAIKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[UnityEngine.Scripting.Preserve]
internal class PNLFIPHHFIN : CKAJIHJAIFJ, AMEJAADBFPI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct GMIMIPJFGHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public PNLFIPHHFIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private JMBOKLBNKIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7576D80", Offset = "0x7575D80", VA = "0x187576D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x7577270", Offset = "0x7576270", VA = "0x187577270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct DNEMCJDKDAC : IAsyncStateMachine
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
		public PNLFIPHHFIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private JMBOKLBNKIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x756E7C0", Offset = "0x756D7C0", VA = "0x18756E7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x756EE60", Offset = "0x756DE60", VA = "0x18756EE60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class HMNGAMPBLAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public HMNGAMPBLAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x75786A0", Offset = "0x75776A0", VA = "0x1875786A0")]
		internal object EHIMDBIIGNL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct MMJMELLAPDP : IAsyncStateMachine
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
		public PNLFIPHHFIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private HMNGAMPBLAK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private JMBOKLBNKIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7580700", Offset = "0x757F700", VA = "0x187580700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7580E50", Offset = "0x757FE50", VA = "0x187580E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class KCHDOPJIBKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public KCHDOPJIBKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x757B270", Offset = "0x757A270", VA = "0x18757B270")]
		internal object GGDIHOKPNOC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly CDBONJBDMGH IKKEHAGICFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private NDFFAKPPKGI GAIEJGCLEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private BJLINKIKEOI LAFNKOLGHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private JPDIEHLGINJ[] CCHFKCBMALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private CancellationTokenSource OCGANIIFAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private int EOFKKEIFFPJ;

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x7583B10", Offset = "0x7582B10", VA = "0x187583B10", Slot = "6")]
	public void CPDDJGLEDNE(NDFFAKPPKGI GAIEJGCLEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x7583CD0", Offset = "0x7582CD0", VA = "0x187583CD0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x7583CE0", Offset = "0x7582CE0", VA = "0x187583CE0", Slot = "8")]
	public void GENFIPMJGEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x75843D0", Offset = "0x75833D0", VA = "0x1875843D0", Slot = "5")]
	public void MNKGAPJGGGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x7584300", Offset = "0x7583300", VA = "0x187584300", Slot = "4")]
	[AsyncStateMachine(typeof(GMIMIPJFGHH))]
	public Task MNCOBPOIEHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x75844A0", Offset = "0x75834A0", VA = "0x1875844A0")]
	private void PDKAKOLJJEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x7583FA0", Offset = "0x7582FA0", VA = "0x187583FA0")]
	[AsyncStateMachine(typeof(DNEMCJDKDAC))]
	private Task JHLAGLLBPDO(CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x7583B90", Offset = "0x7582B90", VA = "0x187583B90")]
	[AsyncStateMachine(typeof(MMJMELLAPDP))]
	private Task<bool> DEELGLGCFNO(int KHAIDMGPIED, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x7583DE0", Offset = "0x7582DE0", VA = "0x187583DE0")]
	private void HPGKBBEEAHK(int KHAIDMGPIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x7583EC0", Offset = "0x7582EC0", VA = "0x187583EC0")]
	private void IDBGHNEDBNH(int KHAIDMGPIED, bool BDKLGGLGLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x75840A0", Offset = "0x75830A0", VA = "0x1875840A0")]
	private void LCJBGOGLODG(int KHAIDMGPIED, Exception BKFPPGLJAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x75841D0", Offset = "0x75831D0", VA = "0x1875841D0")]
	private void MKMCHPJONOJ(CancellationToken CLIKNEKJHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public PNLFIPHHFIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[RecRoom.NoEngine.Common.Preserve]
internal class DMKBBLDNLPM : COGJJJEDKIO, AMEJAADBFPI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct HHNLFECOIHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public DACBMNFKIFK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public DMKBBLDNLPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public HFFOFFCNLJO customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private JMBOKLBNKIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7577CE0", Offset = "0x7576CE0", VA = "0x187577CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7578640", Offset = "0x7577640", VA = "0x187578640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct KMBCBAKMCLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public DMKBBLDNLPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public DACBMNFKIFK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public HFFOFFCNLJO customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private NPOAFBCOAIB<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private JMBOKLBNKIG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private DDJLHCONOLF <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private CCGMLMENJMD <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x757C9E0", Offset = "0x757B9E0", VA = "0x18757C9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x757D680", Offset = "0x757C680", VA = "0x18757D680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class EHMKPKJACEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public Matchmaking.FHLDJHEDPPB result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public IJJHCLBIEIK errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public EHMKPKJACEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x756EFB0", Offset = "0x756DFB0", VA = "0x18756EFB0")]
		internal object IKPKEBKOBFH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class IIGMEPFCLAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public Task<AICBJAIGANE> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public IIGMEPFCLAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
		internal Task<AICBJAIGANE> MMGOGIAMEKI(NPOAFBCOAIB<string>.HFMLKGGDOCE _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct FIBLNMILDPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public DMKBBLDNLPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public DACBMNFKIFK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public HFFOFFCNLJO customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public DDJLHCONOLF joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private IIGMEPFCLAD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private GFBJONOOLIG <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private JMBOKLBNKIG <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <connectToRoomAndRunLoadLogicTimer>5__5;

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
		private LNGPHIHDADF <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private Task<Matchmaking.BDLOKBIGMPF> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private BKGHLOFFNNG <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <>7__wrap12;

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
		private TaskAwaiter<Matchmaking.BDLOKBIGMPF> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private TaskAwaiter<AICBJAIGANE> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x75711A0", Offset = "0x75701A0", VA = "0x1875711A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7576B50", Offset = "0x7575B50", VA = "0x187576B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct ELHOOLHKBDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public DMKBBLDNLPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private JMBOKLBNKIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <disconnectTimerScope>5__3;

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
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x756F230", Offset = "0x756E230", VA = "0x18756F230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x756FC90", Offset = "0x756EC90", VA = "0x18756FC90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct HFDDIOIMBJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public DMKBBLDNLPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private MAONAIOKEHK <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7577800", Offset = "0x7576800", VA = "0x187577800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7577C80", Offset = "0x7576C80", VA = "0x187577C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct NGIKACBCNEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public AsyncTaskMethodBuilder<Matchmaking.BDLOKBIGMPF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public DACBMNFKIFK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public DMKBBLDNLPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private TaskAwaiter<Matchmaking.BDLOKBIGMPF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7582B10", Offset = "0x7581B10", VA = "0x187582B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7583020", Offset = "0x7582020", VA = "0x187583020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct MNMMKBPBJGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public Matchmaking.BDLOKBIGMPF serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public DMKBBLDNLPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public DDJLHCONOLF joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private JMBOKLBNKIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private TaskAwaiter<MKIFOCJHKAC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7580EC0", Offset = "0x757FEC0", VA = "0x187580EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x75815C0", Offset = "0x75805C0", VA = "0x1875815C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class NAGHFNAIIJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public DACBMNFKIFK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public NAGHFNAIIJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7581620", Offset = "0x7580620", VA = "0x187581620")]
		internal object FPNGHADBMHO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7581720", Offset = "0x7580720", VA = "0x187581720")]
		internal string JHIBJHIIHEI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct AFMHKEIEABG : IAsyncStateMachine
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
		public DACBMNFKIFK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public DMKBBLDNLPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private NAGHFNAIIJI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private JMBOKLBNKIG <>7__wrap1;

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

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7567710", Offset = "0x7566710", VA = "0x187567710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x75682E0", Offset = "0x75672E0", VA = "0x1875682E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct KAAEIHILLFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public DMKBBLDNLPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public DDJLHCONOLF joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public AICBJAIGANE initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public DACBMNFKIFK targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public GFBJONOOLIG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x757A5B0", Offset = "0x75795B0", VA = "0x18757A5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x757AEC0", Offset = "0x7579EC0", VA = "0x18757AEC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct KHJCCPNGJBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public DMKBBLDNLPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private JMBOKLBNKIG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <>7__wrap3;

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

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x757B2E0", Offset = "0x757A2E0", VA = "0x18757B2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x757C980", Offset = "0x757B980", VA = "0x18757C980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct LDPLCPOFGOC : IAsyncStateMachine
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
		public FCBKKHIFGAP localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public DMKBBLDNLPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private JMBOKLBNKIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private TaskAwaiter<JECONNLHJLM> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x757D6E0", Offset = "0x757C6E0", VA = "0x18757D6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x757DE50", Offset = "0x757CE50", VA = "0x18757DE50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class EIINNCPJPGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public DACBMNFKIFK targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public EIINNCPJPGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x756F060", Offset = "0x756E060", VA = "0x18756F060")]
		internal object JAAFGDBMHMD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class NJJAOMNHIFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public NJJAOMNHIFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x75A0400", Offset = "0x759F400", VA = "0x1875A0400")]
		internal void MKJKFBFMLEJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class IPJALHOODGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public DACBMNFKIFK targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public IPJALHOODGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x759AB10", Offset = "0x7599B10", VA = "0x18759AB10")]
		internal object AHCEJOFCEJE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class JIECLHMNJJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public DACBMNFKIFK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public JIECLHMNJJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x759B2A0", Offset = "0x759A2A0", VA = "0x18759B2A0")]
		internal string CGKDOLIDBCG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly CDBONJBDMGH IKKEHAGICFD;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly CDBONJBDMGH PDAMGLIIGIC;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly CDBONJBDMGH JEOBHEHBBBM;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly CDBONJBDMGH HNNALPLCLPH;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly string NCKLNLEJKNB;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly string LHOIMKJPLJN;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly string EDNKJLKHFHO;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly Guid CGPKMJKBOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private DFJODANGFCB EMONDMHOGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private NAMMGGILKND ECAGNCOFFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private ADPKBHEBFGA INDOLNBFLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private NDFFAKPPKGI GAIEJGCLEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private BJLINKIKEOI LAFNKOLGHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private CKAJIHJAIFJ MCJDGPBKPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private BHAEJLBNBBO ABGGLBKKFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private KGPJCADDDPH OMDLBKEDMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private JLNHNNPKCNJ LINNCDPHGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private JPCAEPIBHHL BMPGPDNDFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private IDisposable BPMOJEJFEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private IHHBGHBEOLK GKELIIIBCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly FMCPMEFHBJK FJIJCKCHNMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private BKGHLOFFNNG PKNLPHBCFMA;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public TaskStatus FFALFFHDGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8DCE10", Offset = "0x8DBE10", VA = "0x1808DCE10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xEA5480", Offset = "0xEA4480", VA = "0x180EA5480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private GEDBAAOCPGO AOEDKDNFHGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x756C9A0", Offset = "0x756B9A0", VA = "0x18756C9A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x756B030", Offset = "0x756A030", VA = "0x18756B030", Slot = "6")]
	public void CPDDJGLEDNE(NDFFAKPPKGI GAIEJGCLEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x756B610", Offset = "0x756A610", VA = "0x18756B610", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x756AE90", Offset = "0x7569E90", VA = "0x18756AE90", Slot = "5")]
	[AsyncStateMachine(typeof(HHNLFECOIHC))]
	public Task APFCEKABJKJ(DACBMNFKIFK MKMEIBFGEOE, HFFOFFCNLJO PEJFIBOIAKE, CancellationToken OJBNPAMIAFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x756CE30", Offset = "0x756BE30", VA = "0x18756CE30")]
	[AsyncStateMachine(typeof(KMBCBAKMCLN))]
	private Task MIJOMGBFJFP(DACBMNFKIFK MKMEIBFGEOE, HFFOFFCNLJO PEJFIBOIAKE, CancellationToken OJBNPAMIAFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x756DE60", Offset = "0x756CE60", VA = "0x18756DE60")]
	private void OJFDIBMGOEL(JLNHNNPKCNJ LINNCDPHGFG, DACBMNFKIFK MKMEIBFGEOE, Exception BKFPPGLJAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x756D620", Offset = "0x756C620", VA = "0x18756D620")]
	private static void OINKMJKIGGF(CCGMLMENJMD PNHGMHPIBIC, Exception BKFPPGLJAII, [Optional] List<int> MCOAONBLDEF, int EOFKKEIFFPJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x756B4B0", Offset = "0x756A4B0", VA = "0x18756B4B0")]
	[AsyncStateMachine(typeof(FIBLNMILDPK))]
	private Task DPHHEGCCPGE(NPOAFBCOAIB<string>.HFMLKGGDOCE FCPMHEOCJMB, DACBMNFKIFK MKMEIBFGEOE, HFFOFFCNLJO PEJFIBOIAKE, DDJLHCONOLF AKGKKJNPBKK, CancellationToken OJBNPAMIAFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x756BF30", Offset = "0x756AF30", VA = "0x18756BF30")]
	private void HOCINPDJNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x756B660", Offset = "0x756A660", VA = "0x18756B660")]
	[AsyncStateMachine(typeof(ELHOOLHKBDB))]
	private Task EOJNPEMCGFM(NPOAFBCOAIB<string>.HFMLKGGDOCE FCPMHEOCJMB, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x756CB00", Offset = "0x756BB00", VA = "0x18756CB00")]
	private void LJPCBNFHHJH(DACBMNFKIFK MKMEIBFGEOE, CancellationToken OJBNPAMIAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x756D160", Offset = "0x756C160", VA = "0x18756D160")]
	private void NIAFMLABNCJ(DACBMNFKIFK MKMEIBFGEOE, DDJLHCONOLF AKGKKJNPBKK, OperationCanceledException CKMGNDDMPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x756BCE0", Offset = "0x756ACE0", VA = "0x18756BCE0")]
	private void HIEGHGKFDGM(DACBMNFKIFK MKMEIBFGEOE, DDJLHCONOLF AKGKKJNPBKK, Exception BKFPPGLJAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x756B790", Offset = "0x756A790", VA = "0x18756B790")]
	private void FBIMLLFEJIC(DACBMNFKIFK MKMEIBFGEOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x756BC80", Offset = "0x756AC80", VA = "0x18756BC80")]
	private static JNNCAHPPKJI FOCKBPPECPO(DACBMNFKIFK MKMEIBFGEOE)
	{
		return default(JNNCAHPPKJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x756C6C0", Offset = "0x756B6C0", VA = "0x18756C6C0")]
	[AsyncStateMachine(typeof(HFDDIOIMBJL))]
	private Task JHDOCPPADEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x756E2C0", Offset = "0x756D2C0", VA = "0x18756E2C0")]
	[AsyncStateMachine(typeof(NGIKACBCNEH))]
	private Task<Matchmaking.BDLOKBIGMPF> PHBNOFFPFDH(DACBMNFKIFK MKMEIBFGEOE, NPOAFBCOAIB<string>.HFMLKGGDOCE FCPMHEOCJMB, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x756E420", Offset = "0x756D420", VA = "0x18756E420")]
	private static MKIFOCJHKAC PHEFHPJMJDH(Matchmaking.BDLOKBIGMPF HJLJEBGKPDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x756CF80", Offset = "0x756BF80", VA = "0x18756CF80")]
	[AsyncStateMachine(typeof(MNMMKBPBJGF))]
	private Task MKDCPFODDEE(Matchmaking.BDLOKBIGMPF HJLJEBGKPDD, DDJLHCONOLF AKGKKJNPBKK, NPOAFBCOAIB<string>.HFMLKGGDOCE FCPMHEOCJMB, CancellationToken EKJCJBIKJEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x756D4E0", Offset = "0x756C4E0", VA = "0x18756D4E0")]
	[AsyncStateMachine(typeof(AFMHKEIEABG))]
	private Task NOIGDEPAHBG(DACBMNFKIFK MKMEIBFGEOE, CancellationTokenSource MPOLLHHBDGA, Task GINLAHAPILC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x756C080", Offset = "0x756B080", VA = "0x18756C080")]
	[AsyncStateMachine(typeof(KAAEIHILLFM))]
	private Task HPAPEKALIDI(AICBJAIGANE HBECBJPMHLJ, GFBJONOOLIG FHLPCAIEKLF, DACBMNFKIFK GGHEFAJOHNA, DDJLHCONOLF HOMBANKKFII, NPOAFBCOAIB<string>.HFMLKGGDOCE FCPMHEOCJMB, CancellationToken DPMIBOLFDLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x756C280", Offset = "0x756B280", VA = "0x18756C280")]
	private DDJLHCONOLF IPJPBCMOMGK(DDJLHCONOLF HOMBANKKFII, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x756D3B0", Offset = "0x756C3B0", VA = "0x18756D3B0")]
	[AsyncStateMachine(typeof(KHJCCPNGJBA))]
	private Task NIPDMNNIMDG(NPOAFBCOAIB<string>.HFMLKGGDOCE FCPMHEOCJMB, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x756BB50", Offset = "0x756AB50", VA = "0x18756BB50")]
	[AsyncStateMachine(typeof(LDPLCPOFGOC))]
	private Task FHIKFJAGDKI(CancellationToken CLIKNEKJHEI, int NCJNNFEFBME, FCBKKHIFGAP DOELOEGGKAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x756C820", Offset = "0x756B820", VA = "0x18756C820")]
	private static void KHJIOKMPJOK(DACBMNFKIFK MKMEIBFGEOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x756C470", Offset = "0x756B470", VA = "0x18756C470")]
	private void IPPGDMMJOFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x756C1F0", Offset = "0x756B1F0", VA = "0x18756C1F0")]
	private void IDCGCHEPIKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x756C790", Offset = "0x756B790", VA = "0x18756C790")]
	private void KAKALINDNEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x756D0D0", Offset = "0x756C0D0", VA = "0x18756D0D0")]
	private void NFDIAJJEGDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x756B3C0", Offset = "0x756A3C0", VA = "0x18756B3C0")]
	private static void DMBOPBDOMCL(DACBMNFKIFK MKMEIBFGEOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x756C9F0", Offset = "0x756B9F0", VA = "0x18756C9F0")]
	private static CancellationTokenRegistration KPMKBOABEON(DACBMNFKIFK MKMEIBFGEOE, CancellationToken EKJCJBIKJEN)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x756AD90", Offset = "0x7569D90", VA = "0x18756AD90")]
	private static void ANHOLEFKPBA(DACBMNFKIFK MKMEIBFGEOE, Exception BKFPPGLJAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x756B9A0", Offset = "0x756A9A0", VA = "0x18756B9A0")]
	private void FDALNICHFDN(DACBMNFKIFK MKMEIBFGEOE, Task GINLAHAPILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x756AFD0", Offset = "0x7569FD0", VA = "0x18756AFD0")]
	private static void CDMGIBILAAG(Func<string> PAPKMHJKCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x756E730", Offset = "0x756D730", VA = "0x18756E730")]
	public DMKBBLDNLPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x756B360", Offset = "0x756A360", VA = "0x18756B360")]
	[CompilerGenerated]
	internal static (int, int?) DBONDEMIMJE(IJJHCLBIEIK HPCOEPBBODK)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[RecRoom.NoEngine.Common.Preserve]
internal class LANBPMKPFAG : EPOCDPBBMKI, AMEJAADBFPI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct LCBKABJDNFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public LANBPMKPFAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public FCBKKHIFGAP localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x759C5D0", Offset = "0x759B5D0", VA = "0x18759C5D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x759CA30", Offset = "0x759BA30", VA = "0x18759CA30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class KAHIIHCCGNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public LANBPMKPFAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public FCBKKHIFGAP localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public KAHIIHCCGNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x759B3A0", Offset = "0x759A3A0", VA = "0x18759B3A0")]
		internal List<Task> KEHPLPNBBLK(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct EHCFBCOPFLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public EFCGCAALBMD taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public FCBKKHIFGAP localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private JMBOKLBNKIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x75934C0", Offset = "0x75924C0", VA = "0x1875934C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7593860", Offset = "0x7592860", VA = "0x187593860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private struct ENOHCLBCBAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public LANBPMKPFAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x75938C0", Offset = "0x75928C0", VA = "0x1875938C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7593BA0", Offset = "0x7592BA0", VA = "0x187593BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private readonly HashSet<EFCGCAALBMD> JJLNBDMNJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private NAMMGGILKND ECAGNCOFFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private NDFFAKPPKGI GAIEJGCLEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private PHOFBAJGOEC FIBPPNNPFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private BENCCHGJIPB KJGMGBGPJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private IDisposable BPMOJEJFEJB;

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x759BA10", Offset = "0x759AA10", VA = "0x18759BA10", Slot = "5")]
	public void CPDDJGLEDNE(NDFFAKPPKGI GAIEJGCLEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x759BF30", Offset = "0x759AF30", VA = "0x18759BF30", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x759C150", Offset = "0x759B150", VA = "0x18759C150", Slot = "4")]
	public bool GNHJJHOBEHI(EFCGCAALBMD KNAEJLOGHJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x759C2D0", Offset = "0x759B2D0", VA = "0x18759C2D0")]
	private void IDCALGDJBGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x759BD10", Offset = "0x759AD10", VA = "0x18759BD10")]
	private void DCOHCBAJKNI(GAAHBJLKBPP EBLANDLJNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x759BFB0", Offset = "0x759AFB0", VA = "0x18759BFB0")]
	[AsyncStateMachine(typeof(LCBKABJDNFE))]
	private Task FMIGNFBCNJH(int NCJNNFEFBME, FCBKKHIFGAP DOELOEGGKAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x759C3A0", Offset = "0x759B3A0", VA = "0x18759C3A0")]
	private Func<CancellationToken, List<Task>> NFNOHBLJAIP(int NCJNNFEFBME, FCBKKHIFGAP DOELOEGGKAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x759B530", Offset = "0x759A530", VA = "0x18759B530")]
	private List<Task> CKHDFLDBBKL(int NCJNNFEFBME, FCBKKHIFGAP DOELOEGGKAH, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x759C1B0", Offset = "0x759B1B0", VA = "0x18759C1B0")]
	[AsyncStateMachine(typeof(EHCFBCOPFLN))]
	private Task HJPHHFOEBKK(EFCGCAALBMD FONDONNFFHP, CancellationToken NANMDIJGGLP, int NCJNNFEFBME, FCBKKHIFGAP DOELOEGGKAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x759C470", Offset = "0x759B470", VA = "0x18759C470")]
	[AsyncStateMachine(typeof(ENOHCLBCBAG))]
	private Task OOAPLBEOACC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x759C0A0", Offset = "0x759B0A0", VA = "0x18759C0A0")]
	private void GENFIPMJGEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x759C540", Offset = "0x759B540", VA = "0x18759C540")]
	public LANBPMKPFAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[UnityEngine.Scripting.Preserve]
internal sealed class CAOOKIGLIGE : AKPMHDCOBDM, AMEJAADBFPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class HKBNBNJPGOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public HKBNBNJPGOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x7598170", Offset = "0x7597170", VA = "0x187598170")]
		internal object NBKOAEHCNFN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class DBKNFCCONII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public DBKNFCCONII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x7590480", Offset = "0x758F480", VA = "0x187590480")]
		internal object HGHADBHBLKM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class PMCOCHFEDAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public PMCOCHFEDAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class IJPMKAKLCFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public IJPMKAKLCFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x759A2A0", Offset = "0x75992A0", VA = "0x18759A2A0")]
		internal object JMLLCCJBABN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class PJIEPPIOLJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public PJIEPPIOLJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x75A51F0", Offset = "0x75A41F0", VA = "0x1875A51F0")]
		internal object NJHBLDGIPMA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private readonly Dictionary<Guid, DGDPAMDNOFL> CHFJMFHPHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private readonly TimeSpan PEJJMOJLFCM;

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "9")]
	public void CPDDJGLEDNE(NDFFAKPPKGI GAIEJGCLEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x758C3A0", Offset = "0x758B3A0", VA = "0x18758C3A0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x758C910", Offset = "0x758B910", VA = "0x18758C910", Slot = "4")]
	public NECOPEBCFFK OPFOFHIGBEE(Guid HIKJHHIHDMH)
	{
		return default(NECOPEBCFFK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x758BFB0", Offset = "0x758AFB0", VA = "0x18758BFB0", Slot = "5")]
	public bool CAKBCGBONLK(Guid HIKJHHIHDMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x758C5E0", Offset = "0x758B5E0", VA = "0x18758C5E0", Slot = "6")]
	public bool NBFHNGDJLCC(Guid HIKJHHIHDMH, Task GHANJBMHKCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x758C1C0", Offset = "0x758B1C0", VA = "0x18758C1C0", Slot = "7")]
	public bool DMHCJBGOKOM(Guid HIKJHHIHDMH, JECONNLHJLM BBBCHCBNGPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x758BF40", Offset = "0x758AF40", VA = "0x18758BF40", Slot = "8")]
	public Task<(JECONNLHJLM, Task)> BMKGEPPEECC(Guid HIKJHHIHDMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x758C3B0", Offset = "0x758B3B0", VA = "0x18758C3B0")]
	private void MDONOJDBDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x758CB30", Offset = "0x758BB30", VA = "0x18758CB30")]
	public CAOOKIGLIGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[RecRoom.NoEngine.Common.Preserve]
internal class ABDBLHLLINJ : MJGAJININMG, AMEJAADBFPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private class LDDNKPIJOCG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private readonly DACBMNFKIFK PEPCMELAIJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private readonly CancellationTokenSource OCGANIIFAKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public readonly CancellationToken FMPODIFCDLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private bool FLBJGKBGODG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private bool GNHIBNEGODJ;

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x759CC10", Offset = "0x759BC10", VA = "0x18759CC10")]
		public LDDNKPIJOCG(DACBMNFKIFK PEPCMELAIJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x759CAC0", Offset = "0x759BAC0", VA = "0x18759CAC0")]
		public void GENFIPMJGEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x759CA90", Offset = "0x759BA90", VA = "0x18759CA90", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class MHCNHELPLNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public HLBMMCGLCGG disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public MHCNHELPLNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x759EA50", Offset = "0x759DA50", VA = "0x18759EA50")]
		internal object FEJIAAPOMDG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct LPPJPMENEEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public HLBMMCGLCGG disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public ABDBLHLLINJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private JMBOKLBNKIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x759E590", Offset = "0x759D590", VA = "0x18759E590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x759E990", Offset = "0x759D990", VA = "0x18759E990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class BPNJEFLOGHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public BPNJEFLOGHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x758BED0", Offset = "0x758AED0", VA = "0x18758BED0")]
		internal object DIDNAEPEBLM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct PECCLPAMBKC : IAsyncStateMachine
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
		public ABDBLHLLINJ <>4__this;

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
		private JMBOKLBNKIG <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x75A1FD0", Offset = "0x75A0FD0", VA = "0x1875A1FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x9031A0", Offset = "0x9021A0", VA = "0x1809031A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class BHCFJPPNNCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public DACBMNFKIFK newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public BHCFJPPNNCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x758A790", Offset = "0x7589790", VA = "0x18758A790")]
		internal object PLEEMFANOHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x758A710", Offset = "0x7589710", VA = "0x18758A710")]
		internal object IFEOJOJLKBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x758A750", Offset = "0x7589750", VA = "0x18758A750")]
		internal object MNNBFCBMJGM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class PMGBENIAMGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public PMGBENIAMGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x75A5250", Offset = "0x75A4250", VA = "0x1875A5250")]
		internal void CHFJJEOMFFL()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct NHEIDHILIDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public DACBMNFKIFK newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public ABDBLHLLINJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public HFFOFFCNLJO customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private BHCFJPPNNCO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private JMBOKLBNKIG <>7__wrap1;

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

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x759F0C0", Offset = "0x759E0C0", VA = "0x18759F0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x75A0050", Offset = "0x759F050", VA = "0x1875A0050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly CDBONJBDMGH IKKEHAGICFD;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly MOHDDHLJAFN.BMNFNCNKDAI AMLPDOGKAKI;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly IFNJBMDJFEC KMNKMEPBNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private NAMMGGILKND ECAGNCOFFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private NDFFAKPPKGI GAIEJGCLEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private CKAJIHJAIFJ MCJDGPBKPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private BJLINKIKEOI LAFNKOLGHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private GGNDNDFMJFF CLGKEAHKEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private COGJJJEDKIO MCMPAJJBLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private DACBMNFKIFK PFCIABAPEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private LDDNKPIJOCG ACMLECFFDDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private bool PBFBJMNMOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private Task AHOPLMEOOCM;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private GEDBAAOCPGO AOEDKDNFHGL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x7586690", Offset = "0x7585690", VA = "0x187586690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool AMINKELPONI
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xB19BA0", Offset = "0xB18BA0", VA = "0x180B19BA0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7586AC0", Offset = "0x7585AC0", VA = "0x187586AC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7586050", Offset = "0x7585050", VA = "0x187586050", Slot = "4")]
	public void CPDDJGLEDNE(NDFFAKPPKGI GAIEJGCLEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7586450", Offset = "0x7585450", VA = "0x187586450", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x75862F0", Offset = "0x75852F0", VA = "0x1875862F0")]
	[AsyncStateMachine(typeof(LPPJPMENEEK))]
	private Task DAIEEKOMMDG(HLBMMCGLCGG AHMOFBJCEFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x7586AD0", Offset = "0x7585AD0", VA = "0x187586AD0")]
	private void NNEINJPEKPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x75866E0", Offset = "0x75856E0", VA = "0x1875866E0")]
	private void LGMGMDIAEMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x7585BF0", Offset = "0x7584BF0", VA = "0x187585BF0")]
	private void ALIGBFCFNGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x75863E0", Offset = "0x75853E0", VA = "0x1875863E0")]
	private bool DLIGKJEGBBO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x75865C0", Offset = "0x75855C0", VA = "0x1875865C0")]
	[AsyncStateMachine(typeof(PECCLPAMBKC))]
	private void GIOEMPADANF(int IGGGJEBFAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x7585DC0", Offset = "0x7584DC0", VA = "0x187585DC0")]
	private void BPLMKGAKLHI([Out] IDisposable OLOFEHGAAOL, [Out] IDisposable PFKOEGCGAMA, [Out] IDisposable IHEIJCMJGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7586870", Offset = "0x7585870", VA = "0x187586870")]
	private bool LLBNAGDCCKJ(DACBMNFKIFK PEPCMELAIJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7585D70", Offset = "0x7584D70", VA = "0x187585D70")]
	private void AMFNNNGOEOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7586990", Offset = "0x7585990", VA = "0x187586990")]
	[AsyncStateMachine(typeof(NHEIDHILIDC))]
	private Task MIJOMGBFJFP(DACBMNFKIFK PEPCMELAIJD, HFFOFFCNLJO PEJFIBOIAKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x7586FF0", Offset = "0x7585FF0", VA = "0x187586FF0")]
	public ABDBLHLLINJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[UnityEngine.Scripting.Preserve]
internal sealed class FNLBACCDHCN : EHPDHKHGABG, AMEJAADBFPI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private struct PPENIDBCOBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public AsyncTaskMethodBuilder<OCIBBNFFMGC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public FNLBACCDHCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private TaskAwaiter<OCIBBNFFMGC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x75A52F0", Offset = "0x75A42F0", VA = "0x1875A52F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x75A5580", Offset = "0x75A4580", VA = "0x1875A5580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class LNOJBDGIMGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public MELJGKFCAHJ message;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public LNOJBDGIMGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x759D920", Offset = "0x759C920", VA = "0x18759D920")]
		internal object HKCBGHOPOHB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class NCEHJFJJOPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public MELJGKFCAHJ messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public NCEHJFJJOPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x759EC30", Offset = "0x759DC30", VA = "0x18759EC30")]
		internal object BCHOIABBLAH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class ECFEHENIDAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public MELJGKFCAHJ request;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public ECFEHENIDAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x7593200", Offset = "0x7592200", VA = "0x187593200")]
		internal object EECEBOAEPPE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct BPEGBCKJKII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public MELJGKFCAHJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public FNLBACCDHCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private JMBOKLBNKIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private TaskAwaiter<JMFJELLGOJH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x758B5A0", Offset = "0x758A5A0", VA = "0x18758B5A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x758BE70", Offset = "0x758AE70", VA = "0x18758BE70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class MAEAOOACJEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public MELJGKFCAHJ operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public MAEAOOACJEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x759E9F0", Offset = "0x759D9F0", VA = "0x18759E9F0")]
		internal object BCEDCALEJCP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct GLCEMKILFEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public MELJGKFCAHJ operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public FNLBACCDHCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private JMBOKLBNKIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private DDJLHCONOLF <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private TaskAwaiter<MELJGKFCAHJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x7597490", Offset = "0x7596490", VA = "0x187597490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x7598000", Offset = "0x7597000", VA = "0x187598000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private struct OGAMKHDKLGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<JMFJELLGOJH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public FNLBACCDHCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public MELJGKFCAHJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private HFHDHPFJPCO.ADAJGIGPDNM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private DDJLHCONOLF <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private TaskAwaiter<MELJGKFCAHJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x75A1240", Offset = "0x75A0240", VA = "0x1875A1240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x75A1770", Offset = "0x75A0770", VA = "0x1875A1770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class ODFJEMOHAHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public JMFJELLGOJH operation;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public ODFJEMOHAHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x75A11C0", Offset = "0x75A01C0", VA = "0x1875A11C0")]
		internal object NCFGAMPIBEE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private struct FEHAIMJAGLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public JMFJELLGOJH operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public FNLBACCDHCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private JMBOKLBNKIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private NPOAFBCOAIB<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x75942C0", Offset = "0x75932C0", VA = "0x1875942C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x75948F0", Offset = "0x75938F0", VA = "0x1875948F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class KIJMPKAPKBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public MELJGKFCAHJ request;

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public KIJMPKAPKBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x759B420", Offset = "0x759A420", VA = "0x18759B420")]
		internal object ENGJFKGODEK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private sealed class LPFLONMKOJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public MELJGKFCAHJ request;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public LPFLONMKOJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x759E530", Offset = "0x759D530", VA = "0x18759E530")]
		internal object KJLNFPCLPMA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private NDFFAKPPKGI GAIEJGCLEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private BHAEJLBNBBO ABGGLBKKFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private FEHMJBGBGCJ DFIMLPFMBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private PJODHFMOMFN AGKPKBKPFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private ADPKBHEBFGA INDOLNBFLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private TaskCompletionSource<OCIBBNFFMGC> CMAOGMFCALD;

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x7595180", Offset = "0x7594180", VA = "0x187595180", Slot = "7")]
	public void CPDDJGLEDNE(NDFFAKPPKGI GAIEJGCLEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x75955D0", Offset = "0x75945D0", VA = "0x1875955D0", Slot = "6")]
	[AsyncStateMachine(typeof(PPENIDBCOBA))]
	public Task<OCIBBNFFMGC> GIJPEIKIIME(CancellationToken EPAOOCHDBOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x7595A20", Offset = "0x7594A20", VA = "0x187595A20", Slot = "4")]
	public void KPNIFGLHMPA(MELJGKFCAHJ ABHPFCOODAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x7595270", Offset = "0x7594270", VA = "0x187595270", Slot = "5")]
	public void EKDPGFKAGBP(MELJGKFCAHJ ODLBDLJEADN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x75957F0", Offset = "0x75947F0", VA = "0x1875957F0")]
	[AsyncStateMachine(typeof(BPEGBCKJKII))]
	private Task KLMBHDFIIEN(MELJGKFCAHJ ONMEAHDGGOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x75956E0", Offset = "0x75946E0", VA = "0x1875956E0")]
	[AsyncStateMachine(typeof(GLCEMKILFEO))]
	private Task IFFDFNKJCLL(MELJGKFCAHJ BNEOEICEAPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x7596350", Offset = "0x7595350", VA = "0x187596350")]
	[AsyncStateMachine(typeof(OGAMKHDKLGC))]
	private Task<JMFJELLGOJH> OIFMLEDIDJO(MELJGKFCAHJ ONMEAHDGGOB, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x75950F0", Offset = "0x75940F0", VA = "0x1875950F0")]
	private DDJLHCONOLF AKPJGFGMDHH(MELJGKFCAHJ FIDPBJKINIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x7595900", Offset = "0x7594900", VA = "0x187595900")]
	[AsyncStateMachine(typeof(FEHAIMJAGLI))]
	private Task KMBPCKDHGII(JMFJELLGOJH HBPGOBBKEPK, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x7595DB0", Offset = "0x7594DB0", VA = "0x187595DB0")]
	private JMFJELLGOJH MKMNAAGHDFB(MELJGKFCAHJ ONMEAHDGGOB, DDJLHCONOLF ECCDJCBJDOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x2F5D030", Offset = "0x2F5C030", VA = "0x182F5D030")]
	private T HACAKFJHPEB<T>(T BJDKOHEGDOK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x7595FC0", Offset = "0x7594FC0", VA = "0x187595FC0")]
	private JMFJELLGOJH MMKHIHKOLNM(MELJGKFCAHJ ONMEAHDGGOB, DDJLHCONOLF ECCDJCBJDOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public FNLBACCDHCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[UnityEngine.Scripting.Preserve]
internal sealed class PFHNNMNDJKI : FEHMJBGBGCJ, AMEJAADBFPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class LOCEPFMABLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public LOCEPFMABLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x759D980", Offset = "0x759C980", VA = "0x18759D980")]
		internal object ODLKIMPNHMN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class GEJCNCOFILN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public GEJCNCOFILN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x75971A0", Offset = "0x75961A0", VA = "0x1875971A0")]
		internal object FAJKGCHNPPP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private ADPKBHEBFGA INDOLNBFLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private LPJPPDEEHAD GCLEJPJHOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private EHPDHKHGABG ILFFJFPJDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private AKPMHDCOBDM CHFJMFHPHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private MGPNOBNFNBD EILHMPIKCHF;

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x75A3420", Offset = "0x75A2420", VA = "0x1875A3420", Slot = "6")]
	public void CPDDJGLEDNE(NDFFAKPPKGI GAIEJGCLEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x75A37C0", Offset = "0x75A27C0", VA = "0x1875A37C0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x75A4A70", Offset = "0x75A3A70", VA = "0x1875A4A70", Slot = "4")]
	public NECOPEBCFFK KNGLILGJOAK(MELJGKFCAHJ LFCHFBAICPK)
	{
		return default(NECOPEBCFFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x75A3940", Offset = "0x75A2940", VA = "0x1875A3940", Slot = "5")]
	public void EJIACLGEFHJ(Guid HIKJHHIHDMH, Task GHANJBMHKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x75A3870", Offset = "0x75A2870", VA = "0x1875A3870")]
	private void EBPEKNBNGCB(byte FGPIBDOMONC, int KABGFMFIEPA, object JGJKKDNHGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x75A3B50", Offset = "0x75A2B50", VA = "0x1875A3B50")]
	private void GDOKIIPPIFM(OAHCLMOMPDP POADLBAMAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x75A4580", Offset = "0x75A3580", VA = "0x1875A4580")]
	private void ILJBDEBLJFF(OAHCLMOMPDP POADLBAMAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x75A4340", Offset = "0x75A3340", VA = "0x1875A4340")]
	private void HNAKCFLPOLI(OAHCLMOMPDP POADLBAMAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x75A3590", Offset = "0x75A2590", VA = "0x1875A3590")]
	private JECONNLHJLM DGELEPBALNO(MELJGKFCAHJ FIDPBJKINIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x75A4870", Offset = "0x75A3870", VA = "0x1875A4870")]
	private void KALOMICOJPH(MELJGKFCAHJ BNEOEICEAPF, JECONNLHJLM BBBCHCBNGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x75A4E90", Offset = "0x75A3E90", VA = "0x1875A4E90")]
	private bool OIELMAOIHBM(MELJGKFCAHJ BNEOEICEAPF, JECONNLHJLM BBBCHCBNGPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x75A31B0", Offset = "0x75A21B0", VA = "0x1875A31B0")]
	private bool BPONCJJGFKO(MELJGKFCAHJ IBPGCCNKBOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x75A40C0", Offset = "0x75A30C0", VA = "0x1875A40C0")]
	private bool HJHKHKDHAJH(byte FGPIBDOMONC, ExitGames.Client.Photon.Hashtable POADLBAMAOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public PFHNNMNDJKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[UnityEngine.Scripting.Preserve]
internal sealed class LOOBCNKPMOO : MCFJKGCDPKP, AMEJAADBFPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class EODEJFGKINL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public OCIBBNFFMGC operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public LOOBCNKPMOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public MELJGKFCAHJ roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public EODEJFGKINL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x7593D30", Offset = "0x7592D30", VA = "0x187593D30")]
		internal object IGAODIFJHLD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x7593C00", Offset = "0x7592C00", VA = "0x187593C00")]
		internal object BKOAHEIFMGK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct JHPEOJOHHEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public AsyncTaskMethodBuilder<JECONNLHJLM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public LOOBCNKPMOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public MELJGKFCAHJ roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private JMBOKLBNKIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private TaskAwaiter<JECONNLHJLM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x759AB90", Offset = "0x7599B90", VA = "0x18759AB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x759B230", Offset = "0x759A230", VA = "0x18759B230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class IPGECPIEINF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public OCIBBNFFMGC operationType;

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public IPGECPIEINF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x759AAA0", Offset = "0x7599AA0", VA = "0x18759AAA0")]
		internal object IFENMAKOMDC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class MNGAEMIMCBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public MELJGKFCAHJ request;

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public MNGAEMIMCBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x759EAE0", Offset = "0x759DAE0", VA = "0x18759EAE0")]
		internal object BMKFOGLAMNF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x759EBC0", Offset = "0x759DBC0", VA = "0x18759EBC0")]
		internal object OMCEAEEJDHD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x759EB50", Offset = "0x759DB50", VA = "0x18759EB50")]
		internal object DDMPAHAKEBA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct CMLEGIHPFAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public AsyncTaskMethodBuilder<JECONNLHJLM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public MELJGKFCAHJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public LOOBCNKPMOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private MNGAEMIMCBO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private JMBOKLBNKIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private NECOPEBCFFK <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private JECONNLHJLM <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private TaskAwaiter<(JECONNLHJLM validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x758FA00", Offset = "0x758EA00", VA = "0x18758FA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x75902D0", Offset = "0x758F2D0", VA = "0x1875902D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private ADPKBHEBFGA INDOLNBFLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private LPJPPDEEHAD GCLEJPJHOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private FEHMJBGBGCJ DFIMLPFMBDG;

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x759D9F0", Offset = "0x759C9F0", VA = "0x18759D9F0", Slot = "5")]
	public void CPDDJGLEDNE(NDFFAKPPKGI GAIEJGCLEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x759DBE0", Offset = "0x759CBE0", VA = "0x18759DBE0", Slot = "4")]
	[AsyncStateMachine(typeof(JHPEOJOHHEP))]
	private Task<JECONNLHJLM> NKHBIALCNMI(MELJGKFCAHJ FIDPBJKINIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x759DD00", Offset = "0x759CD00", VA = "0x18759DD00")]
	private bool NMEOJODJOPB(OCIBBNFFMGC HOAFJBCIPPP, [Out] JECONNLHJLM POCKBMKNJHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x759DAA0", Offset = "0x759CAA0", VA = "0x18759DAA0")]
	[AsyncStateMachine(typeof(CMLEGIHPFAG))]
	private Task<JECONNLHJLM> MKKOEHCNDCP(MELJGKFCAHJ ONMEAHDGGOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public LOOBCNKPMOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class DDGDOLGIOKE : LLBIHPPACPN, AMEJAADBFPI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct CDFMLIKAGLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public AsyncTaskMethodBuilder<AICBJAIGANE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public DACBMNFKIFK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public DDGDOLGIOKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private TaskAwaiter<CDBHFDKLKGA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private TaskAwaiter<AICBJAIGANE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x758CBF0", Offset = "0x758BBF0", VA = "0x18758CBF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x758D1C0", Offset = "0x758C1C0", VA = "0x18758D1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class HAGEDACDJJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public HAGEDACDJJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x7598060", Offset = "0x7597060", VA = "0x187598060")]
		internal object BFOPNBIOKNM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct ABLPLCIHDBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public AsyncTaskMethodBuilder<CDBHFDKLKGA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public DDGDOLGIOKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public DACBMNFKIFK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private HAGEDACDJJF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private TaskAwaiter<CDBHFDKLKGA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x7587060", Offset = "0x7586060", VA = "0x187587060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x7587650", Offset = "0x7586650", VA = "0x187587650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct CDKJFGJLCLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public AsyncTaskMethodBuilder<AICBJAIGANE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public DDGDOLGIOKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public DACBMNFKIFK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public CDBHFDKLKGA roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private TaskAwaiter<(LMNKCNKLBML superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x758D230", Offset = "0x758C230", VA = "0x18758D230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x758D690", Offset = "0x758C690", VA = "0x18758D690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class MEIOLKOGAHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public MEIOLKOGAHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xAC6BF0", Offset = "0xAC5BF0", VA = "0x180AC6BF0")]
		internal bool LJNFEJNHBMJ(ALMBCFFNDNC sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct AELKBPCDHHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public AsyncTaskMethodBuilder<(LMNKCNKLBML superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public CDBHFDKLKGA roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public DDGDOLGIOKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public DACBMNFKIFK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private TaskAwaiter<(LMNKCNKLBML superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x75876C0", Offset = "0x75866C0", VA = "0x1875876C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x7587D60", Offset = "0x7586D60", VA = "0x187587D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class LAJHNIPNJEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public LAJHNIPNJEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x759B480", Offset = "0x759A480", VA = "0x18759B480")]
		internal object GCAKNHFCNDG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct FKKMEPFDDPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public AsyncTaskMethodBuilder<(LMNKCNKLBML superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public ALMBCFFNDNC subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public DDGDOLGIOKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public DACBMNFKIFK dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private LAJHNIPNJEN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<BLNDCCHFGLB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x7594950", Offset = "0x7593950", VA = "0x187594950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x7595080", Offset = "0x7594080", VA = "0x187595080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static readonly (LMNKCNKLBML superRoomData, long subRoomDataSaveId) OLGIHOAGIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private BJLINKIKEOI LAFNKOLGHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private JGHFHJBGHPA BMLKMEAHKAO;

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x7590920", Offset = "0x758F920", VA = "0x187590920", Slot = "5")]
	public void CPDDJGLEDNE(NDFFAKPPKGI GAIEJGCLEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x75904E0", Offset = "0x758F4E0", VA = "0x1875904E0", Slot = "4")]
	[AsyncStateMachine(typeof(CDFMLIKAGLG))]
	public Task<AICBJAIGANE> AALIFACJLHB(NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, DACBMNFKIFK MKMEIBFGEOE, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x7590B20", Offset = "0x758FB20", VA = "0x187590B20")]
	[AsyncStateMachine(typeof(ABLPLCIHDBJ))]
	private Task<CDBHFDKLKGA> MCHBFNAAFEB(DACBMNFKIFK MKMEIBFGEOE, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x75909B0", Offset = "0x758F9B0", VA = "0x1875909B0")]
	[AsyncStateMachine(typeof(CDKJFGJLCLA))]
	private Task<AICBJAIGANE> FAKOLJHGDOK(DACBMNFKIFK MKMEIBFGEOE, CDBHFDKLKGA DOIEOJODELN, long PDLBLPPCJKC, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x75907B0", Offset = "0x758F7B0", VA = "0x1875907B0")]
	[AsyncStateMachine(typeof(AELKBPCDHHG))]
	private Task<(LMNKCNKLBML, long)> AKOKNBMGNFF(DACBMNFKIFK MKMEIBFGEOE, CDBHFDKLKGA DOIEOJODELN, long PDLBLPPCJKC, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7590640", Offset = "0x758F640", VA = "0x187590640")]
	[AsyncStateMachine(typeof(FKKMEPFDDPE))]
	private Task<(LMNKCNKLBML, long)> AGJKKNPFGMK(DACBMNFKIFK PEMMENONANF, ALMBCFFNDNC NKLFGHAHOLL, long PDLBLPPCJKC, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public DDGDOLGIOKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[UnityEngine.Scripting.Preserve]
internal sealed class NOHCKJIHHPA : PJODHFMOMFN, AMEJAADBFPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class HDCOCOKFDEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public MELJGKFCAHJ request;

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public HDCOCOKFDEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x7598110", Offset = "0x7597110", VA = "0x187598110")]
		internal object PJPMCJIGAMB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct OOFAOCBPABH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public AsyncTaskMethodBuilder<MELJGKFCAHJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public MELJGKFCAHJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public NOHCKJIHHPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public DDJLHCONOLF pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private JMBOKLBNKIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private TaskAwaiter<MELJGKFCAHJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x75A1950", Offset = "0x75A0950", VA = "0x1875A1950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x75A1F60", Offset = "0x75A0F60", VA = "0x1875A1F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct FPLKAGHBKNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public AsyncTaskMethodBuilder<MELJGKFCAHJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public NOHCKJIHHPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public DDJLHCONOLF pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private JMBOKLBNKIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private TaskAwaiter<NPFHICCEFBD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x7596B40", Offset = "0x7595B40", VA = "0x187596B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x7597130", Offset = "0x7596130", VA = "0x187597130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class ICMFHKFGBGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public MELJGKFCAHJ request;

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public ICMFHKFGBGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x75981D0", Offset = "0x75971D0", VA = "0x1875981D0")]
		internal object HHMFAHJEKHI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct LIHHFIMLLLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public AsyncTaskMethodBuilder<MELJGKFCAHJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public MELJGKFCAHJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public NOHCKJIHHPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public DDJLHCONOLF pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private JMBOKLBNKIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private DEIBCGBKIHM <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private MANNMKGLMJP <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private TaskAwaiter<NPFHICCEFBD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x759CCC0", Offset = "0x759BCC0", VA = "0x18759CCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x759D8B0", Offset = "0x759C8B0", VA = "0x18759D8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private ADPKBHEBFGA INDOLNBFLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private IAENGOKJJDM ENGPONOIAHC;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	private CMOHEPIBNDC IBMBPEEGMLF
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x75A0B50", Offset = "0x759FB50", VA = "0x1875A0B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x75A0600", Offset = "0x759F600", VA = "0x1875A0600", Slot = "8")]
	public void CPDDJGLEDNE(NDFFAKPPKGI GAIEJGCLEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x75A0690", Offset = "0x759F690", VA = "0x1875A0690", Slot = "4")]
	[AsyncStateMachine(typeof(OOFAOCBPABH))]
	public Task<MELJGKFCAHJ> DCBODNIKHKH(MELJGKFCAHJ ONMEAHDGGOB, DDJLHCONOLF ECCDJCBJDOD, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x75A0A00", Offset = "0x759FA00", VA = "0x1875A0A00", Slot = "5")]
	[AsyncStateMachine(typeof(FPLKAGHBKNK))]
	public Task<MELJGKFCAHJ> LLLCIJIMCDK(CancellationToken CLIKNEKJHEI, DDJLHCONOLF ECCDJCBJDOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x75A07F0", Offset = "0x759F7F0", VA = "0x1875A07F0", Slot = "6")]
	public IEGLONMBGEN ENIHPEFKLOL(JMFJELLGOJH JPBCDGCOPME, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x75A0C10", Offset = "0x759FC10", VA = "0x1875A0C10", Slot = "7")]
	public IEGLONMBGEN PMJEMFOIGBO(JMFJELLGOJH JPBCDGCOPME, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x75A04A0", Offset = "0x759F4A0", VA = "0x1875A04A0")]
	[AsyncStateMachine(typeof(LIHHFIMLLLO))]
	private Task<MELJGKFCAHJ> ALPJNBHJIEC(MELJGKFCAHJ ONMEAHDGGOB, DDJLHCONOLF ECCDJCBJDOD, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x2FA8920", Offset = "0x2FA7920", VA = "0x182FA8920")]
	private static byte[] ACOIENHOCAH(MELJGKFCAHJ ABHPFCOODAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public NOHCKJIHHPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[UnityEngine.Scripting.Preserve]
internal sealed class LOOMPCDPFIP : LPJPPDEEHAD, AMEJAADBFPI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private CIPEABMEBIL FKAFANCBEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	private ADPKBHEBFGA INDOLNBFLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private BHAEJLBNBBO ABGGLBKKFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private EGOFNGONCHP JBEMOPCOPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private BJLINKIKEOI LAFNKOLGHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private COGJJJEDKIO MCMPAJJBLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private EPOCDPBBMKI KBLGPBCBKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private GGNDNDFMJFF CLGKEAHKEGA;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private GEDBAAOCPGO AOEDKDNFHGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x759E4E0", Offset = "0x759D4E0", VA = "0x18759E4E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private static JECONNLHJLM ANOMCJDKION
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x7594010", Offset = "0x7593010", VA = "0x187594010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x759E200", Offset = "0x759D200", VA = "0x18759E200", Slot = "6")]
	public void CPDDJGLEDNE(NDFFAKPPKGI GAIEJGCLEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x759E370", Offset = "0x759D370", VA = "0x18759E370", Slot = "4")]
	public JECONNLHJLM HLDICDCMEIM(NKLIIMCFHAI AABOBDCMGCM, OCIBBNFFMGC JKDKBHMNLIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x759DEF0", Offset = "0x759CEF0", VA = "0x18759DEF0", Slot = "5")]
	public JECONNLHJLM CGOJNOLEGEE(NKLIIMCFHAI DBBMECBIAHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x7594260", Offset = "0x7593260", VA = "0x187594260")]
	private static JECONNLHJLM MMBADLGENIC(DFPKDJHLGGI BMAADIIMEEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public LOOMPCDPFIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public class KIEKKIBDPHC : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x759B3E0", Offset = "0x759A3E0", VA = "0x18759B3E0")]
	public KIEKKIBDPHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x69D51E0", Offset = "0x69D41E0", VA = "0x1869D51E0")]
	public KIEKKIBDPHC(string ABHPFCOODAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[UnityEngine.Scripting.Preserve]
internal sealed class DODGIHDLEPJ : CKPJMGIAIBO, AMEJAADBFPI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct CIJGIPACKMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public AsyncTaskMethodBuilder<JECONNLHJLM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public DODGIHDLEPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public DDMELBGCFHO autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private NPOAFBCOAIB<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private MGAJMAHLEKO <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private TaskAwaiter<JECONNLHJLM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x758D700", Offset = "0x758C700", VA = "0x18758D700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x758E280", Offset = "0x758D280", VA = "0x18758E280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct IOOOEIDAKLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public DODGIHDLEPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x759A300", Offset = "0x7599300", VA = "0x18759A300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x759AA40", Offset = "0x7599A40", VA = "0x18759AA40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct IGACNJHFMMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public DODGIHDLEPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x7599540", Offset = "0x7598540", VA = "0x187599540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7599A50", Offset = "0x7598A50", VA = "0x187599A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct BJHKMNGIPCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public DODGIHDLEPJ <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x758A830", Offset = "0x7589830", VA = "0x18758A830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x758AF70", Offset = "0x7589F70", VA = "0x18758AF70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct GLBMAEPDKPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public DODGIHDLEPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x7597290", Offset = "0x7596290", VA = "0x187597290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7597430", Offset = "0x7596430", VA = "0x187597430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct BCOOACIEANK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public DODGIHDLEPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x7588F10", Offset = "0x7587F10", VA = "0x187588F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x7589620", Offset = "0x7588620", VA = "0x187589620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct IHHKCPCLGBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public DODGIHDLEPJ <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x7599CF0", Offset = "0x7598CF0", VA = "0x187599CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x759A160", Offset = "0x7599160", VA = "0x18759A160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private struct DNEPCLBBAMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public DODGIHDLEPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public FJAPFOIPONE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private NPOAFBCOAIB<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x7591C20", Offset = "0x7590C20", VA = "0x187591C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x7592190", Offset = "0x7591190", VA = "0x187592190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private ADPKBHEBFGA INDOLNBFLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private NDFFAKPPKGI GAIEJGCLEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private BJLINKIKEOI LAFNKOLGHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private PJODHFMOMFN AGKPKBKPFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private BHAEJLBNBBO ABGGLBKKFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private EPOCDPBBMKI KBLGPBCBKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private CancellationTokenSource OAAMDKPIPIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private Task ADMJIHDMMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private TaskCompletionSource<int> BHPLMOANMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private int JMOIECHOBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private int BCBAOHEBJHI;

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x75921F0", Offset = "0x75911F0", VA = "0x1875921F0", Slot = "6")]
	public void CPDDJGLEDNE(NDFFAKPPKGI GAIEJGCLEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0xE4AAC0", Offset = "0xE49AC0", VA = "0x180E4AAC0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x7592C70", Offset = "0x7591C70", VA = "0x187592C70")]
	private void KICFAMCLEKL(float BHICBBMLNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x7592FD0", Offset = "0x7591FD0", VA = "0x187592FD0", Slot = "4")]
	[AsyncStateMachine(typeof(CIJGIPACKMF))]
	public Task<JECONNLHJLM> PBELBGDLOFM(DDMELBGCFHO CBNDKFAOHGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x7592D50", Offset = "0x7591D50", VA = "0x187592D50", Slot = "5")]
	[AsyncStateMachine(typeof(IOOOEIDAKLN))]
	public Task LAKELOKKBMK([Optional] CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0xE4AAC0", Offset = "0xE49AC0", VA = "0x180E4AAC0")]
	public void COHKAOJIPMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x7592590", Offset = "0x7591590", VA = "0x187592590")]
	private MGAJMAHLEKO FKHOEAANNGM(DDMELBGCFHO CBNDKFAOHGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x7592900", Offset = "0x7591900", VA = "0x187592900")]
	[AsyncStateMachine(typeof(IGACNJHFMMK))]
	private Task IGIKLKLNACO(CancellationToken OJBNPAMIAFA, int NCJNNFEFBME, FCBKKHIFGAP DOELOEGGKAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x7593100", Offset = "0x7592100", VA = "0x187593100")]
	[AsyncStateMachine(typeof(BJHKMNGIPCE))]
	private Task PHFFJKLDBOE(CancellationToken OJBNPAMIAFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x75924A0", Offset = "0x75914A0", VA = "0x1875924A0")]
	[AsyncStateMachine(typeof(GLBMAEPDKPO))]
	private Task ELJFJADKEGD([Optional] CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x7592810", Offset = "0x7591810", VA = "0x187592810")]
	[AsyncStateMachine(typeof(BCOOACIEANK))]
	private Task IEDILLENNAO(CancellationToken OJBNPAMIAFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x75923A0", Offset = "0x75913A0", VA = "0x1875923A0")]
	[AsyncStateMachine(typeof(IHHKCPCLGBG))]
	private Task DDJGOOLLBCD(CancellationToken EAIFGGBKJMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x7592E40", Offset = "0x7591E40", VA = "0x187592E40")]
	private Task LDEEPBDDKIB(FJAPFOIPONE PFCJJJAILGH, CancellationToken OJBNPAMIAFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x7592700", Offset = "0x7591700", VA = "0x187592700")]
	[AsyncStateMachine(typeof(DNEPCLBBAMI))]
	private Task GJLNFKPINBJ(FJAPFOIPONE PFCJJJAILGH, CancellationToken OJBNPAMIAFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x75929F0", Offset = "0x75919F0", VA = "0x1875929F0")]
	private bool JAAIODLAGNA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public DODGIHDLEPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[UnityEngine.Scripting.Preserve]
internal class FPBDODLBFNL : EGOFNGONCHP, AMEJAADBFPI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private struct BFCELBKEAOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public FPBDODLBFNL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private NPOAFBCOAIB<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7589940", Offset = "0x7588940", VA = "0x187589940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x7589EB0", Offset = "0x7588EB0", VA = "0x187589EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private IOKFDEJPJJE PLCEJCAGGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	private NDFFAKPPKGI GAIEJGCLEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private LPJPPDEEHAD GCLEJPJHOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private PJODHFMOMFN AGKPKBKPFAG;

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x7596590", Offset = "0x7595590", VA = "0x187596590", Slot = "6")]
	public void CPDDJGLEDNE(NDFFAKPPKGI GAIEJGCLEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x7596870", Offset = "0x7595870", VA = "0x187596870", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x7596920", Offset = "0x7595920", VA = "0x187596920", Slot = "5")]
	[AsyncStateMachine(typeof(BFCELBKEAOH))]
	public Task JCDJCMMDIMP(string MBDMHLKHKIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x75968C0", Offset = "0x75958C0", VA = "0x1875968C0", Slot = "4")]
	public JECONNLHJLM JAAIODLAGNA(NKLIIMCFHAI AABOBDCMGCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x75964A0", Offset = "0x75954A0", VA = "0x1875964A0")]
	private MDENIBOMIGF CBKCNMBHEDE(string MBDMHLKHKIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public FPBDODLBFNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class AEPNLAMFHCG
{
	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x7587DD0", Offset = "0x7586DD0", VA = "0x187587DD0")]
	public static void DKDHEECHEBC(MAONAIOKEHK GHHOPPHGNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x7588540", Offset = "0x7587540", VA = "0x187588540")]
	internal static void KNDFEDOHHBA(MAONAIOKEHK GHHOPPHGNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x7588460", Offset = "0x7587460", VA = "0x187588460")]
	internal static void EEOOEKBPMJK(MAONAIOKEHK GHHOPPHGNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x7588010", Offset = "0x7587010", VA = "0x187588010")]
	internal static void DOOKGKKLGMD(MAONAIOKEHK GHHOPPHGNHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class AMBDFCJOKOF : HEHIHJELPGD<MELJGKFCAHJ>
{
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class NHFIFCJCECB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public MELJGKFCAHJ message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public NHFIFCJCECB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x75A00B0", Offset = "0x759F0B0", VA = "0x1875A00B0")]
		internal object JCODILMOOIH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly AMBDFCJOKOF LONLOOPDCMJ;

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x75887B0", Offset = "0x75877B0", VA = "0x1875887B0")]
	public ExitGames.Client.Photon.Hashtable EKFEJLFJOKC(MELJGKFCAHJ ABHPFCOODAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x7588840", Offset = "0x7587840", VA = "0x187588840", Slot = "5")]
	protected override void IKGIHBDEKPE(MELJGKFCAHJ ABHPFCOODAJ, IDictionary<object, object> CONAFKKIHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x7588C10", Offset = "0x7587C10", VA = "0x187588C10", Slot = "6")]
	public override MELJGKFCAHJ OGCNNFLPKKP(IDictionary<object, object> CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x75886A0", Offset = "0x75876A0", VA = "0x1875886A0")]
	private static void CDMGIBILAAG(string DBBAEMKBIGC, MELJGKFCAHJ ABHPFCOODAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x7588ED0", Offset = "0x7587ED0", VA = "0x187588ED0")]
	public AMBDFCJOKOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x7588970", Offset = "0x7587970", VA = "0x187588970")]
	[CompilerGenerated]
	internal static string LOJHAEDHOMB(AICBJAIGANE NDBAHEIEDNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public static class FBCDDPMLNIN
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public static JECONNLHJLM ANOMCJDKION
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x7594010", Offset = "0x7593010", VA = "0x187594010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x7593FF0", Offset = "0x7592FF0", VA = "0x187593FF0")]
	public static bool CENEGAMJANJ(this JECONNLHJLM BBBCHCBNGPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x7594260", Offset = "0x7593260", VA = "0x187594260")]
	public static JECONNLHJLM MMBADLGENIC(DFPKDJHLGGI IDOMJPIHNHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x7594070", Offset = "0x7593070", VA = "0x187594070")]
	public static JECONNLHJLM GHCDALAELKP(IEnumerable<JECONNLHJLM> FNBEEOFAIGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x7593DA0", Offset = "0x7592DA0", VA = "0x187593DA0")]
	public static string AIIDPFEOGGH(this JECONNLHJLM POCKBMKNJHC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public abstract class NEAAIJPPJCI : OPCNAAKGIKC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public delegate JECONNLHJLM JCPGPOOHDEP([NotNull] NKLIIMCFHAI PHAFKBHJAEK);

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class MCACBGFILDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public NKLIIMCFHAI photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public MCACBGFILDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x6BDFD40", Offset = "0x6BDED40", VA = "0x186BDFD40")]
		internal JECONNLHJLM KCLIJDHBDGG(JCPGPOOHDEP v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private bool PPKGDGFGJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	protected readonly HashSet<JCPGPOOHDEP> HJLLCFJHBMM;

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x759EF80", Offset = "0x759DF80", VA = "0x18759EF80", Slot = "4")]
	public void CHLDIFNOLAF(JCPGPOOHDEP FMNFFIDNIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x759EF20", Offset = "0x759DF20", VA = "0x18759EF20", Slot = "5")]
	public void BMPCMKFPPKL(JCPGPOOHDEP FMNFFIDNIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x759EFE0", Offset = "0x759DFE0", VA = "0x18759EFE0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x759EC90", Offset = "0x759DC90", VA = "0x18759EC90")]
	protected JECONNLHJLM AGABGHBEIGB(NKLIIMCFHAI DBBMECBIAHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x759F030", Offset = "0x759E030", VA = "0x18759F030")]
	protected NEAAIJPPJCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class OHEFOOJKJCI : NEAAIJPPJCI, CIPEABMEBIL, OPCNAAKGIKC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private sealed class OLBLDDFMFBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public JECONNLHJLM result;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public OLBLDDFMFBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x75A18F0", Offset = "0x75A08F0", VA = "0x1875A18F0")]
		internal object FHLDOOOEOKA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x7596B30", Offset = "0x7595B30", VA = "0x187596B30")]
	[UnityEngine.Scripting.Preserve]
	public OHEFOOJKJCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x75A17E0", Offset = "0x75A07E0", VA = "0x1875A17E0", Slot = "8")]
	public JECONNLHJLM PBCBOAECJFH(NKLIIMCFHAI DBBMECBIAHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class FPCJKEDBGBG : NEAAIJPPJCI, IOKFDEJPJJE, OPCNAAKGIKC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private sealed class DKJFJIPLKNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public JECONNLHJLM result;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public DKJFJIPLKNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7591BC0", Offset = "0x7590BC0", VA = "0x187591BC0")]
		internal object LHPIGHCEELA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x7596B30", Offset = "0x7595B30", VA = "0x187596B30")]
	[UnityEngine.Scripting.Preserve]
	public FPCJKEDBGBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x7596A20", Offset = "0x7595A20", VA = "0x187596A20", Slot = "8")]
	public JECONNLHJLM JAAIODLAGNA(NKLIIMCFHAI FOMGKNFCKEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal static class EECBDDDICPK
{
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private sealed class BOHNAAKMGJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public NPOAFBCOAIB<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public BOHNAAKMGJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x758B520", Offset = "0x758A520", VA = "0x18758B520")]
		internal object LIFBCLFCHDG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x7593260", Offset = "0x7592260", VA = "0x187593260")]
	public static NPOAFBCOAIB<string> BCAKFDGEHBL(CDBONJBDMGH IKKEHAGICFD, [Optional] string AEPBMBJKDCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x7593400", Offset = "0x7592400", VA = "0x187593400")]
	public static void PKNGANAMEBE(NPOAFBCOAIB<string> FCPMHEOCJMB, CDBONJBDMGH IKKEHAGICFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x7593340", Offset = "0x7592340", VA = "0x187593340")]
	public static string OJPMIDOAGGP(MELJGKFCAHJ FIDPBJKINIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal static class CPLPLOJNNGH
{
	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x7590470", Offset = "0x758F470", VA = "0x187590470")]
	public static void KPLPNAMEHHM(this ADPKBHEBFGA INDOLNBFLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x7590340", Offset = "0x758F340", VA = "0x187590340")]
	public static void CBLFLMADNLJ(this ADPKBHEBFGA INDOLNBFLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x7590350", Offset = "0x758F350", VA = "0x187590350")]
	private static void CEFJPAMPAEN(this ADPKBHEBFGA INDOLNBFLPL, bool GCCGICBJLMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public class BNLHDAKLBKJ : HADDODNKPJF, FCODHPEDOLN, OLKEHEKCACE, CEGCMKNPNLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	private readonly FCODHPEDOLN GOPNAODKNJF;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public NKLIIMCFHAI JNLEFHOCOBD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x758B430", Offset = "0x758A430", VA = "0x18758B430", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public int FGKHDGDPLNL
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x758B3E0", Offset = "0x758A3E0", VA = "0x18758B3E0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public int JFCODCLCDPN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x758B2F0", Offset = "0x758A2F0", VA = "0x18758B2F0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool KOIICPLLLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public int LKDECEGIMAA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x93D780", Offset = "0x93C780", VA = "0x18093D780", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event MMOFCKDNGKA.KKNCIMGILBD CCAFJIPGJBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event OMPCDMHLPFH KKMCPOABIAI
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x758B020", Offset = "0x758A020", VA = "0x18758B020", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x758B250", Offset = "0x758A250", VA = "0x18758B250", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> LDCAJHJMNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<NKLIIMCFHAI> EBAIGMPHHAI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action CDCPPMEADAI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x758B480", Offset = "0x758A480", VA = "0x18758B480", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x758B340", Offset = "0x758A340", VA = "0x18758B340", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x9843C0", Offset = "0x9833C0", VA = "0x1809843C0")]
	public BNLHDAKLBKJ(FCODHPEDOLN GOPNAODKNJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x758B1A0", Offset = "0x758A1A0", VA = "0x18758B1A0", Slot = "8")]
	public bool KKAEDJAFGKE(byte FGPIBDOMONC, ExitGames.Client.Photon.Hashtable DPOCOOKGEDK, IKPJHLPAHIK KIMCGCECDJB, SendOptions DMHBPCBMOAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x758B0C0", Offset = "0x758A0C0", VA = "0x18758B0C0", Slot = "16")]
	public NKLIIMCFHAI JOGAOOCPFDN(int CIJDBDHEIID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "19")]
	public void KLBPPLHNGAH(object NANMDIJGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "20")]
	public void DIGFOCHNJJE(object NANMDIJGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "21")]
	public void HHAEKKDMLCK(object NANMDIJGGLP, bool BFKLCFNPCAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x758AFD0", Offset = "0x7589FD0", VA = "0x18758AFD0", Slot = "22")]
	public IDisposable BPOPOFHGCPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "23")]
	private bool ONENAMIEGFI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "24")]
	public void AABCCKJDEDF(StringBuilder FJFJFNICPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0xB89720", Offset = "0xB88720", VA = "0x180B89720", Slot = "25")]
	public bool BKKOEMCDGBP(bool MKDKOCBKMJP, [Out] string IPLILPPMPOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0xABE740", Offset = "0xABD740", VA = "0x180ABE740", Slot = "28")]
	public void AAFMOHBEKBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal struct OAHCLMOMPDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	private readonly IDictionary<object, object> POADLBAMAOE;

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x997970", Offset = "0x996970", VA = "0x180997970")]
	public OAHCLMOMPDP(IDictionary<object, object> POADLBAMAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x75A0FE0", Offset = "0x759FFE0", VA = "0x1875A0FE0")]
	public bool CCKDFENNPDK([Out] MELJGKFCAHJ ABHPFCOODAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x75A0F30", Offset = "0x759FF30", VA = "0x1875A0F30")]
	public Guid ALJJPCFECHD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x75A1090", Offset = "0x75A0090", VA = "0x1875A1090")]
	public JECONNLHJLM JNGLIIEAFLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x75A0E40", Offset = "0x759FE40", VA = "0x1875A0E40")]
	public static ExitGames.Client.Photon.Hashtable AIOPMLNOOEO(MELJGKFCAHJ ABHPFCOODAJ, JECONNLHJLM BBBCHCBNGPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal static class GEMCGDEFNGP
{
	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x7597210", Offset = "0x7596210", VA = "0x187597210")]
	public static bool AGNNPFDBOCI(this DACBMNFKIFK NFDMLIINBHB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct BENCCHGJIPB : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct IGKCEJOBACP : IAsyncStateMachine
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
		public BENCCHGJIPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x7599AB0", Offset = "0x7598AB0", VA = "0x187599AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x7599C90", Offset = "0x7598C90", VA = "0x187599C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	private readonly CancellationTokenSource OCGANIIFAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	private bool PPKGDGFGJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	private Task KDFIPCHFLGF;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool MNCIMEONHOG
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x7589680", Offset = "0x7588680", VA = "0x187589680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x7589810", Offset = "0x7588810", VA = "0x187589810")]
	public BENCCHGJIPB(CancellationToken CLIKNEKJHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x7589700", Offset = "0x7588700", VA = "0x187589700")]
	[AsyncStateMachine(typeof(IGKCEJOBACP))]
	public Task ECMIFDDKICB(Func<CancellationToken, List<Task>> DOJDBNDPKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x75896B0", Offset = "0x75886B0", VA = "0x1875896B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public readonly struct JJHGGOFNDGB<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct FJLMIBKJEMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<IIOIPHLGGKA<TData>, PPOILIOPEKP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public JJHGGOFNDGB<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private TaskAwaiter<OBFFLKDLIBJ<IIOIPHLGGKA<TData>, PPOILIOPEKP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x400C5E0", Offset = "0x400B5E0", VA = "0x18400C5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x400D1C0", Offset = "0x400C1C0", VA = "0x18400D1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	private readonly MHEEBKLHMMD<TGetDataArg, TData> PBAEBCPCIME;

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x997970", Offset = "0x996970", VA = "0x180997970")]
	internal JJHGGOFNDGB(MHEEBKLHMMD<TGetDataArg, TData> IKBDGBPPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x45948B0", Offset = "0x45938B0", VA = "0x1845948B0")]
	[AsyncStateMachine(typeof(JJHGGOFNDGB<, >.FJLMIBKJEMJ))]
	public Task<OBFFLKDLIBJ<IIOIPHLGGKA<TData>, PPOILIOPEKP>> DLBEBFMDIFA(TGetDataArg FPMIIFOGKII, string GFKKFFDOBNG, NPOAFBCOAIB<string>.HFMLKGGDOCE FCPMHEOCJMB, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public static class ANPFDJHICEK
{
	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x2D5F9A0", Offset = "0x2D5E9A0", VA = "0x182D5F9A0")]
	public static JJHGGOFNDGB<TGetDataArg, TData> EJLELCHFLID<TGetDataArg, TData>(MHEEBKLHMMD<TGetDataArg, TData> IKBDGBPPCAB)
	{
		return default(JJHGGOFNDGB<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public struct IJJHCLBIEIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public readonly int NODJDDFLMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public readonly int? EAEOKDCFCJE;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x470CE40", Offset = "0x470BE40", VA = "0x18470CE40")]
	public IJJHCLBIEIK(int NNMDNPOJCMN, [Optional] int? IDKICGNAPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x759A1C0", Offset = "0x75991C0", VA = "0x18759A1C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public interface HAPHGNEDFJL<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EALOBJDJOHF();

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HAPHGNEDFJL<T> JGHBJMFIFDD(string JPPIGCHNINA);

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HAPHGNEDFJL<T> CHCLJNPJOEK(EFMFLLGMFGL<T> FPIKHKOGKMF);

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HAPHGNEDFJL<T> MGMMJDDMDHM(int HPCOEPBBODK);

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HAPHGNEDFJL<T> NNDBADJICLD(int HPCOEPBBODK, GKLEINMMJMF<T> NFPCECBCFBD);
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public interface JLNHNNPKCNJ
{
	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HAPHGNEDFJL<T> EPLFJBINMLD<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PIBIECMKJKF NOHPNNHOKPK(Exception BKFPPGLJAII);

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IJJHCLBIEIK DKALPGNEFML(Exception BKFPPGLJAII);
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public delegate string EFMFLLGMFGL<in T>(T BKFPPGLJAII) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public delegate int GKLEINMMJMF<in T>(T BKFPPGLJAII) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal class CLCGMBIHGEP : JLNHNNPKCNJ
{
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private delegate string COCNLGCGDAK(Exception BKFPPGLJAII);

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private delegate int PDHDAPLNAMG(Exception BKFPPGLJAII);

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	private class LJJCCMKICEE<T> : HAPHGNEDFJL<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		[CompilerGenerated]
		private sealed class AJHJPEJDBDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public AJHJPEJDBDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
			internal string FPCDCLGMMAI(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		[CompilerGenerated]
		private sealed class EAJPAGJJDGF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public EFMFLLGMFGL<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public EAJPAGJJDGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x3C3C720", Offset = "0x3C3B720", VA = "0x183C3C720")]
			internal string ELPHJJMNONF(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[CompilerGenerated]
		private sealed class DMLGJKPJLCM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public GKLEINMMJMF<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public DMLGJKPJLCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x3C3C720", Offset = "0x3C3B720", VA = "0x183C3C720")]
			internal int ODLEJBPNKMN(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private readonly CLCGMBIHGEP LINNCDPHGFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private readonly Type PPLMJHACBGI;

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x475B040", Offset = "0x475A040", VA = "0x18475B040")]
		internal LJJCCMKICEE(CLCGMBIHGEP LINNCDPHGFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x475AD70", Offset = "0x4759D70", VA = "0x18475AD70", Slot = "4")]
		public void EALOBJDJOHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x475ADA0", Offset = "0x4759DA0", VA = "0x18475ADA0", Slot = "5")]
		public HAPHGNEDFJL<T> JGHBJMFIFDD(string JPPIGCHNINA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x475AC50", Offset = "0x4759C50", VA = "0x18475AC50", Slot = "6")]
		public HAPHGNEDFJL<T> CHCLJNPJOEK(EFMFLLGMFGL<T> FPIKHKOGKMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x475AEC0", Offset = "0x4759EC0", VA = "0x18475AEC0", Slot = "7")]
		public HAPHGNEDFJL<T> MGMMJDDMDHM(int HPCOEPBBODK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x475AF00", Offset = "0x4759F00", VA = "0x18475AF00", Slot = "8")]
		public HAPHGNEDFJL<T> NNDBADJICLD(int HPCOEPBBODK, GKLEINMMJMF<T> NFPCECBCFBD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	private class EOICDHGGKOJ<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private bool NGCAEMLIAOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private readonly List<Type> JFFIJIAIOPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private readonly Dictionary<Type, TVal> INDNNOCPEIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private readonly Dictionary<Type, int> EAKMOMLKLOP;

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public IReadOnlyList<Type> DAPAANFJDIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x3C75AF0", Offset = "0x3C74AF0", VA = "0x183C75AF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x3C76050", Offset = "0x3C75050", VA = "0x183C76050")]
		public EOICDHGGKOJ(Dictionary<Type, int> EAKMOMLKLOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x3C75F90", Offset = "0x3C74F90", VA = "0x183C75F90")]
		public void OPFOFHIGBEE(Type MLAECOMLIEC, TVal ADMAMDKLPIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x3C75E10", Offset = "0x3C74E10", VA = "0x183C75E10")]
		public bool KDAFJHNILAD(Type PPLMJHACBGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x3C75C70", Offset = "0x3C74C70", VA = "0x183C75C70")]
		public bool BPJPJKHHOKJ(TVal BJDKOHEGDOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x3C75E70", Offset = "0x3C74E70", VA = "0x183C75E70")]
		public TVal KIJHOBDIGPJ(Type PFCMGBLCCPJ)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x3C75D70", Offset = "0x3C74D70", VA = "0x183C75D70")]
		[CompilerGenerated]
		private int GGNJBFDGAGF(Type CJLMOGPNFNE, Type PLNOEEPMBBM)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class BFLIMPBMPCP : IEnumerable<IJJHCLBIEIK>, IEnumerable, IEnumerator<IJJHCLBIEIK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private IJJHCLBIEIK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public CLCGMBIHGEP <>4__this;

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
		private IEnumerator<IJJHCLBIEIK> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		private IJJHCLBIEIK System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0x3CD0410", Offset = "0x3CCF410", VA = "0x183CD0410", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(IJJHCLBIEIK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0x758A570", Offset = "0x7589570", VA = "0x18758A570", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x90ECF0", Offset = "0x90DCF0", VA = "0x18090ECF0")]
		[DebuggerHidden]
		public BFLIMPBMPCP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x758A5C0", Offset = "0x75895C0", VA = "0x18758A5C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x7589FB0", Offset = "0x7588FB0", VA = "0x187589FB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x7589F60", Offset = "0x7588F60", VA = "0x187589F60")]
		private void CLDKBJALKHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x7589F10", Offset = "0x7588F10", VA = "0x187589F10")]
		private void AFDHGAJFOOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x758A520", Offset = "0x7589520", VA = "0x18758A520", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x758A460", Offset = "0x7589460", VA = "0x18758A460", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IJJHCLBIEIK> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x758A460", Offset = "0x7589460", VA = "0x18758A460", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private static readonly IJJHCLBIEIK FIHLEDAOFBB;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private static readonly Dictionary<Type, int> FDNBDGHDBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private readonly HashSet<Type> IEIANBPGDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private readonly EOICDHGGKOJ<int> DJCOAFEAFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private readonly EOICDHGGKOJ<PDHDAPLNAMG> GBCPBIELIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private readonly EOICDHGGKOJ<COCNLGCGDAK> LEKDPNJKLEA;

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x758EE40", Offset = "0x758DE40", VA = "0x18758EE40")]
	[AEDCCIMPEFD.GIGKNHONDJE.KBDJNGCKNKK]
	internal static void MKFFGPHAFOG(MAONAIOKEHK OLAHEEDNGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x758F6D0", Offset = "0x758E6D0", VA = "0x18758F6D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public CLCGMBIHGEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x2D6B850", Offset = "0x2D6A850", VA = "0x182D6B850", Slot = "4")]
	public HAPHGNEDFJL<T> EPLFJBINMLD<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x758F030", Offset = "0x758E030", VA = "0x18758F030", Slot = "5")]
	public PIBIECMKJKF NOHPNNHOKPK(Exception BKFPPGLJAII)
	{
		return default(PIBIECMKJKF);
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x758E440", Offset = "0x758D440", VA = "0x18758E440", Slot = "6")]
	public IJJHCLBIEIK DKALPGNEFML(Exception? BKFPPGLJAII)
	{
		return default(IJJHCLBIEIK);
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x758E9F0", Offset = "0x758D9F0", VA = "0x18758E9F0", Slot = "7")]
	[IteratorStateMachine(typeof(BFLIMPBMPCP))]
	public IEnumerable<IJJHCLBIEIK> JLNLMPMEDJA(Exception BKFPPGLJAII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x758E2F0", Offset = "0x758D2F0", VA = "0x18758E2F0", Slot = "8")]
	public string DAFMHDCMIBA(Exception? BKFPPGLJAII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x758F310", Offset = "0x758E310", VA = "0x18758F310")]
	private string PHDNCAABPGL(AggregateException PHCGOLAIKIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x758E640", Offset = "0x758D640", VA = "0x18758E640")]
	private void EFAFKDNIPJJ(Type PPLMJHACBGI, int HPCOEPBBODK, PDHDAPLNAMG? DKFKDMKOEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x758F0C0", Offset = "0x758E0C0", VA = "0x18758F0C0")]
	private void PDBCHBAODFF(Type PPLMJHACBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x758EA90", Offset = "0x758DA90", VA = "0x18758EA90")]
	private void KKCNIMHJCHH(Type PPLMJHACBGI, COCNLGCGDAK IHPGHHENPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x758EEB0", Offset = "0x758DEB0", VA = "0x18758EEB0")]
	private static int NKGKPJCEAMC(Type PPLMJHACBGI, Dictionary<Type, int> EAKMOMLKLOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x2D6B8E0", Offset = "0x2D6A8E0", VA = "0x182D6B8E0")]
	private static bool OPGPEAJNMPN<TVal>(EOICDHGGKOJ<TVal> CMDOFHABOHN, Type PPLMJHACBGI, [Out] TVal BJDKOHEGDOK) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x758ED60", Offset = "0x758DD60", VA = "0x18758ED60")]
	[CompilerGenerated]
	internal static int MCBHOOGHAPO(Type MEAHAJMHDLP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public struct PIBIECMKJKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public readonly IJJHCLBIEIK JOGEJILDPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public readonly string CFECOHHENEA;

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x75A51D0", Offset = "0x75A41D0", VA = "0x1875A51D0")]
	public PIBIECMKJKF(string GNOBKLJILLN, IJJHCLBIEIK HPCOEPBBODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x75A5130", Offset = "0x75A4130", VA = "0x1875A5130")]
	public string IKJHEIBODHI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public class DFJODANGFCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private readonly AANDAFLIKBC IOIFNPONCDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private string KEIEJBCGPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private long? GIGCMKNAFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private long? DPGNAFJCBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private long? ALMALBBHPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private string HJALHIOEPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private GDNCNIBJNMK ALMEKEIFDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private long? JDALMMOCIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private bool CJHPBLEFNGL;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public string IFGJMHEPDGL
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public long JEBMELABJKM
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x7590F40", Offset = "0x758FF40", VA = "0x187590F40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public long LJJKNKLGBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x7591720", Offset = "0x7590720", VA = "0x187591720")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public long AJHFOKBALDC
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x7590D90", Offset = "0x758FD90", VA = "0x187590D90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public string MHIOINBKMGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x7590D50", Offset = "0x758FD50", VA = "0x187590D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public GDNCNIBJNMK AOGAAIJDFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x9E6280", Offset = "0x9E5280", VA = "0x1809E6280")]
		get
		{
			return default(GDNCNIBJNMK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x7590E50", Offset = "0x758FE50", VA = "0x187590E50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public long AELACMGNHIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x7590DF0", Offset = "0x758FDF0", VA = "0x187590DF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7591B80", Offset = "0x7590B80", VA = "0x187591B80")]
	[UnityEngine.Scripting.Preserve]
	public DFJODANGFCB([GAHPILLNNBL(null)] AANDAFLIKBC IOIFNPONCDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x7591040", Offset = "0x7590040", VA = "0x187591040")]
	private void JFJOABEHIFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x7591290", Offset = "0x7590290", VA = "0x187591290")]
	public void LNOMHBJKPPL(long AHNLEKFKAGC, long PDLBLPPCJKC, [Optional] long? GEKHFNOGIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x7590FA0", Offset = "0x758FFA0", VA = "0x187590FA0")]
	public void HJGEEFNCFGI(long GEKHFNOGIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x7591B00", Offset = "0x7590B00", VA = "0x187591B00")]
	public void OJBPLILHELJ(string IEFIBPPJBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x7591780", Offset = "0x7590780", VA = "0x187591780")]
	public void OCPONENMIEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal class IEGLONMBGEN : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct FDICJCLGCEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public AsyncTaskMethodBuilder<MELJGKFCAHJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public MELJGKFCAHJ roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public IEGLONMBGEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private TaskAwaiter<CMOHEPIBNDC.MAILHFADANC<MELJGKFCAHJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x75B0190", Offset = "0x75AF190", VA = "0x1875B0190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x75B05A0", Offset = "0x75AF5A0", VA = "0x1875B05A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct NOFIJABCHPK<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class NNHOBIPNMPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public MELJGKFCAHJ roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public NNHOBIPNMPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x75BAB50", Offset = "0x75B9B50", VA = "0x1875BAB50")]
		internal MELJGKFCAHJ IJBDNGDPCBI(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct JNCAHBJDONK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public AsyncTaskMethodBuilder<CMOHEPIBNDC.MAILHFADANC<MELJGKFCAHJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public MELJGKFCAHJ roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public IEGLONMBGEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private DEIBCGBKIHM <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private TaskAwaiter<CMOHEPIBNDC.MAILHFADANC<MELJGKFCAHJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x75B58A0", Offset = "0x75B48A0", VA = "0x1875B58A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x75B5EB0", Offset = "0x75B4EB0", VA = "0x1875B5EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct FIHAKOOAOGL<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public IEGLONMBGEN <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x4003250", Offset = "0x4002250", VA = "0x184003250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x39463F0", Offset = "0x39453F0", VA = "0x1839463F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private struct IPEEMAEGFJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public IEGLONMBGEN <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x75B3870", Offset = "0x75B2870", VA = "0x1875B3870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x75B3A30", Offset = "0x75B2A30", VA = "0x1875B3A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class BIDKPGGAEJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public BIDKPGGAEJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x75AA440", Offset = "0x75A9440", VA = "0x1875AA440")]
		internal object MEGMKFDAOMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x75AA4A0", Offset = "0x75A94A0", VA = "0x1875AA4A0")]
		internal bool OMPNLHIPJLO(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class EODJOIDHCLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public EODJOIDHCLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x75AFD70", Offset = "0x75AED70", VA = "0x1875AFD70")]
		internal object LMEDJOIANHF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class AKCEBBFKBLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public AKCEBBFKBLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x75A8B40", Offset = "0x75A7B40", VA = "0x1875A8B40")]
		internal object BHNCFBCJHMM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class GLNFPIBOCDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public GLNFPIBOCDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x75B13E0", Offset = "0x75B03E0", VA = "0x1875B13E0")]
		internal object ENMLEKBNIDE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private sealed class HPPBBMHMKJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public IEGLONMBGEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public HPPBBMHMKJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x75B1DD0", Offset = "0x75B0DD0", VA = "0x1875B1DD0")]
		internal object JCODILMOOIH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private static readonly Guid HGIJDKMHJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public readonly JMFJELLGOJH MPIGFDGDADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private readonly CMOHEPIBNDC LJNJHEMFEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private readonly OLKEHEKCACE INDOLNBFLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private readonly CEGCMKNPNLO KLHOMMDLKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private bool IJNCEKKFAEN;

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x7599310", Offset = "0x7598310", VA = "0x187599310")]
	public IEGLONMBGEN(JMFJELLGOJH HBPGOBBKEPK, CMOHEPIBNDC LJNJHEMFEIC, OLKEHEKCACE INDOLNBFLPL, CEGCMKNPNLO KLHOMMDLKHD, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x7598750", Offset = "0x7597750", VA = "0x187598750", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x7598750", Offset = "0x7597750", VA = "0x187598750")]
	public void MABGCMFIDJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x7598390", Offset = "0x7597390", VA = "0x187598390")]
	public void BGDHKFBGGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x7598690", Offset = "0x7597690", VA = "0x187598690")]
	public void DIGILPPAHAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x7598A20", Offset = "0x7597A20", VA = "0x187598A20")]
	[AsyncStateMachine(typeof(FDICJCLGCEF))]
	internal Task<MELJGKFCAHJ> FJKIMCBAPIE(NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, MELJGKFCAHJ FIDPBJKINIB, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x2FA8920", Offset = "0x2FA7920", VA = "0x182FA8920")]
	private static byte[] GLGNKLNNPCE<T>(T ABHPFCOODAJ) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2FA8530", Offset = "0x2FA7530", VA = "0x182FA8530")]
	private static T ELHAKPINEFJ<T>(MessageParser<T> GOMGLEICMJB, byte[] ABHPFCOODAJ, T BDJMFCBAEKI) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x7598D80", Offset = "0x7597D80", VA = "0x187598D80")]
	[AsyncStateMachine(typeof(JNCAHBJDONK))]
	private Task<CMOHEPIBNDC.MAILHFADANC<MELJGKFCAHJ>> GEJJEDFABFJ(MELJGKFCAHJ FIDPBJKINIB, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x2FA8680", Offset = "0x2FA7680", VA = "0x182FA8680")]
	[AsyncStateMachine(typeof(FIHAKOOAOGL<>))]
	internal Task<T> FEDCFAACAKK<T>(CancellationToken OJBNPAMIAFA, Func<CancellationToken, Task<T>> HCKBHINGECH, int MBFJLPMIHJG = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x75988F0", Offset = "0x75978F0", VA = "0x1875988F0")]
	[AsyncStateMachine(typeof(IPEEMAEGFJJ))]
	internal Task FEDCFAACAKK(CancellationToken OJBNPAMIAFA, Func<CancellationToken, Task> HCKBHINGECH, int MBFJLPMIHJG = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x7598D00", Offset = "0x7597D00", VA = "0x187598D00")]
	public HPBFIFDAEJF GAJIDMFCIKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x7598870", Offset = "0x7597870", VA = "0x187598870")]
	public DGIEFAKGIHI EFMICNKLLMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x7599020", Offset = "0x7598020", VA = "0x187599020")]
	public EJJBDNIDCMO IKHBEOEIMND([Optional] CDBONJBDMGH? IKKEHAGICFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x7598230", Offset = "0x7597230", VA = "0x187598230")]
	public void ALNKCPJHFDG(Func<Guid, bool> DCAFIDMFICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x7598F10", Offset = "0x7597F10", VA = "0x187598F10")]
	public void HJHHDGIDMFC(Func<Guid, bool> MJMPFCNBEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x7598B80", Offset = "0x7597B80", VA = "0x187598B80")]
	public Guid FNKBCGKKKMO()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x75991A0", Offset = "0x75981A0", VA = "0x1875991A0")]
	public void KIJAKABIIJO(Guid OJJFBEAGHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x7598560", Offset = "0x7597560", VA = "0x187598560")]
	public void DGIIHDLPNMF(MELJGKFCAHJ EOOPEIPEMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x7598450", Offset = "0x7597450", VA = "0x187598450")]
	public void CDMGIBILAAG(string BDCBPMKELGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x2FA8930", Offset = "0x2FA7930", VA = "0x182FA8930")]
	private T HACAKFJHPEB<T>(T BJDKOHEGDOK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x7598EC0", Offset = "0x7597EC0", VA = "0x187598EC0")]
	public void HBONHMNIALE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x2FA8A20", Offset = "0x2FA7A20", VA = "0x182FA8A20")]
	[CompilerGenerated]
	internal static string ICHEAKBBDII<T>(byte[] HPKNAAFAALO, int FDICHMHOOJD, NOFIJABCHPK<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal sealed class BCFNJAMPNIO : JMFJELLGOJH
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private sealed class HGBCBGABCGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public HGBCBGABCGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x75B1C60", Offset = "0x75B0C60", VA = "0x1875B1C60")]
		internal object LHMCPEBOPFA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct AAGOEDFLLFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public BCFNJAMPNIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public IEGLONMBGEN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private ICGKNEKHLMH <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private DGIEFAKGIHI <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x75A5F40", Offset = "0x75A4F40", VA = "0x1875A5F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x75A6810", Offset = "0x75A5810", VA = "0x1875A6810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private struct DCLJPMEDFDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public BCFNJAMPNIO <>4__this;

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
		private TaskAwaiter<CDBHFDKLKGA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x75AC250", Offset = "0x75AB250", VA = "0x1875AC250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x75ACA00", Offset = "0x75ABA00", VA = "0x1875ACA00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private struct LNBPABIAEMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public BCFNJAMPNIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private TaskAwaiter<BLNDCCHFGLB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x75B99D0", Offset = "0x75B89D0", VA = "0x1875B99D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x75B9CE0", Offset = "0x75B8CE0", VA = "0x1875B9CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class DMHFGODBIGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public ICGKNEKHLMH presence;

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public DMHFGODBIGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x75AF190", Offset = "0x75AE190", VA = "0x1875AF190")]
		internal object EFNKPFADICH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	private static readonly CDBONJBDMGH IKKEHAGICFD;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	private static readonly CDBONJBDMGH PJJEAGJIKEF;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	private static readonly CDBONJBDMGH BHKDBBKBJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000387")]
	private readonly AICBJAIGANE HBECBJPMHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000388")]
	private readonly DACBMNFKIFK GCDLLOJCOFL;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x75A9B80", Offset = "0x75A8B80", VA = "0x1875A9B80")]
	public BCFNJAMPNIO(AICBJAIGANE HBECBJPMHLJ, DACBMNFKIFK GCDLLOJCOFL, Guid HIKJHHIHDMH, NDFFAKPPKGI GAIEJGCLEHG, DDJLHCONOLF FKBNHEMIFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x75A9970", Offset = "0x75A8970", VA = "0x1875A9970", Slot = "7")]
	[AsyncStateMachine(typeof(AAGOEDFLLFL))]
	protected override Task PEEGILEEPGP(IEGLONMBGEN AADLMFJNHJD, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x75A9870", Offset = "0x75A8870", VA = "0x1875A9870")]
	[AsyncStateMachine(typeof(DCLJPMEDFDP))]
	private Task NDHOHBLEGLB(CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x75A9760", Offset = "0x75A8760", VA = "0x1875A9760")]
	[AsyncStateMachine(typeof(LNBPABIAEMO))]
	private Task<int> DDECEHJDGGE(CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x75A9590", Offset = "0x75A8590", VA = "0x1875A9590")]
	private ICGKNEKHLMH CGIKFENPENK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal class MGAJMAHLEKO : JMFJELLGOJH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private struct ONHENBNPKLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public MGAJMAHLEKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public IEGLONMBGEN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private TaskAwaiter<PNDDKICJKKP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x75BAC30", Offset = "0x75B9C30", VA = "0x1875BAC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x75BB5D0", Offset = "0x75BA5D0", VA = "0x1875BB5D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	private readonly int KBIABKKNFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	private readonly DDMELBGCFHO BMHPAPNFNDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public readonly long GMMHODNCMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public readonly long KDLKNDBBIMC;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public PNDDKICJKKP CNCBNNILADP
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x8B82B0", Offset = "0x8B72B0", VA = "0x1808B82B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x8B81B0", Offset = "0x8B71B0", VA = "0x1808B81B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x75BAA20", Offset = "0x75B9A20", VA = "0x1875BAA20")]
	public MGAJMAHLEKO(Guid HIKJHHIHDMH, NDFFAKPPKGI GAIEJGCLEHG, DDJLHCONOLF FKBNHEMIFCL, int KBIABKKNFHE, DDMELBGCFHO BMHPAPNFNDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x75BA900", Offset = "0x75B9900", VA = "0x1875BA900", Slot = "7")]
	[AsyncStateMachine(typeof(ONHENBNPKLA))]
	protected override Task PEEGILEEPGP(IEGLONMBGEN AADLMFJNHJD, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal abstract class GDDMNGOHJBD : JMFJELLGOJH
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private sealed class LIHLCJLDELL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public GDDMNGOHJBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public ALGFHKDIPPP playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public LIHLCJLDELL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x75B7D30", Offset = "0x75B6D30", VA = "0x1875B7D30")]
		internal Task BMHABKBKGLB(NPOAFBCOAIB<string>.HFMLKGGDOCE postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x75B7D70", Offset = "0x75B6D70", VA = "0x1875B7D70")]
		internal object POLNKOLJDHK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private struct IJOLIKAAILG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public GDDMNGOHJBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public IEGLONMBGEN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private LIHLCJLDELL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x75B3050", Offset = "0x75B2050", VA = "0x1875B3050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x75B3810", Offset = "0x75B2810", VA = "0x1875B3810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private struct BICJKIGOCCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public ALGFHKDIPPP playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public GDDMNGOHJBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x75A9E40", Offset = "0x75A8E40", VA = "0x1875A9E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x75AA3E0", Offset = "0x75A93E0", VA = "0x1875AA3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x75B1390", Offset = "0x75B0390", VA = "0x1875B1390")]
	public GDDMNGOHJBD(Guid HIKJHHIHDMH, NDFFAKPPKGI GAIEJGCLEHG, DDJLHCONOLF FKBNHEMIFCL, string OJMAIKPAPGH, NNCNNOMHHHL HOAFJBCIPPP, bool EIKNBGKLHJO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x75B1250", Offset = "0x75B0250", VA = "0x1875B1250", Slot = "7")]
	[AsyncStateMachine(typeof(IJOLIKAAILG))]
	protected override Task PEEGILEEPGP(IEGLONMBGEN AADLMFJNHJD, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task CHMPHGMNMFK(IEGLONMBGEN AADLMFJNHJD, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x75B1110", Offset = "0x75B0110", VA = "0x1875B1110")]
	[AsyncStateMachine(typeof(BICJKIGOCCF))]
	private Task NODALLAKFAF(IDisposable ACEEPMGKLPJ, ALGFHKDIPPP HDDOFCFCGGN, NPOAFBCOAIB<string>.HFMLKGGDOCE FCPMHEOCJMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
internal class JPHCODOPGMG : JMFJELLGOJH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct KBHGHPOGBMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public JPHCODOPGMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public IEGLONMBGEN operationContext;

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
		private TaskAwaiter<APNIAAHHPPH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x75B61C0", Offset = "0x75B51C0", VA = "0x1875B61C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x75B6730", Offset = "0x75B5730", VA = "0x1875B6730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private readonly FJAPFOIPONE PFCJJJAILGH;

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x75B6120", Offset = "0x75B5120", VA = "0x1875B6120")]
	public JPHCODOPGMG(Guid HIKJHHIHDMH, NDFFAKPPKGI GAIEJGCLEHG, DDJLHCONOLF FKBNHEMIFCL, FJAPFOIPONE PFCJJJAILGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x75B6040", Offset = "0x75B5040", VA = "0x1875B6040", Slot = "6")]
	protected override string PODKCLGBKKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x75B5F20", Offset = "0x75B4F20", VA = "0x1875B5F20", Slot = "7")]
	[AsyncStateMachine(typeof(KBHGHPOGBMC))]
	protected override Task PEEGILEEPGP(IEGLONMBGEN AADLMFJNHJD, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
internal abstract class JMFJELLGOJH : ODIJIHPCMIA
{
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	public delegate Task JGGFCCEKFPI(NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class BHNJAHDIAJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public JMFJELLGOJH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public BHNJAHDIAJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x75A9D10", Offset = "0x75A8D10", VA = "0x1875A9D10")]
		internal Task ABIILFPPCJO(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private sealed class AOJDBDAHIDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public BHNJAHDIAJO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public AOJDBDAHIDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x75A94D0", Offset = "0x75A84D0", VA = "0x1875A94D0")]
		internal object NIAJDHHGDBI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct ADHOEEJEKBD : IAsyncStateMachine
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
		public JMFJELLGOJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public Func<JMFJELLGOJH, NPOAFBCOAIB<string>.HFMLKGGDOCE, IEGLONMBGEN> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private BHNJAHDIAJO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private IEGLONMBGEN <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private TaskAwaiter<MELJGKFCAHJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x75A6870", Offset = "0x75A5870", VA = "0x1875A6870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x75A7970", Offset = "0x75A6970", VA = "0x1875A7970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct FLKIFNBGGNG : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x75B0610", Offset = "0x75AF610", VA = "0x1875B0610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x75B10B0", Offset = "0x75B00B0", VA = "0x1875B10B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private struct EPDJLDEOLIO : IAsyncStateMachine
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
		public JMFJELLGOJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x75AFDD0", Offset = "0x75AEDD0", VA = "0x1875AFDD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x75B0130", Offset = "0x75AF130", VA = "0x1875B0130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public readonly Guid GFAHNAHMKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public readonly ByteString IFABNBFAFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public readonly DDJLHCONOLF LDFIIOAJJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	protected readonly string JNIOOGBNEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	private readonly NDFFAKPPKGI GAIEJGCLEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	private readonly bool EIKNBGKLHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private readonly Queue<JGGFCCEKFPI> DICJJBGDLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	private readonly LNGPHIHDADF AIPCNBDNNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private readonly NNCNNOMHHHL HOAFJBCIPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private bool COAFKFMEBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public GDNCNIBJNMK MEHKCMNAADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public GDNCNIBJNMK KLPJHIKEOJL;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public NDFFAKPPKGI MMDKFLKIJGL
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E90", Offset = "0x8B8E90", VA = "0x1808B9E90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public BJLINKIKEOI PAMCFEMCNIH
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x75B4D00", Offset = "0x75B3D00", VA = "0x1875B4D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public IHGEMGGPDFH IOKPAKKICCH
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x75B5240", Offset = "0x75B4240", VA = "0x1875B5240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public GEDBAAOCPGO AOEDKDNFHGL
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x75B5400", Offset = "0x75B4400", VA = "0x1875B5400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event DAGADGHJCCE CNHNFGNJFKN
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x75B4D50", Offset = "0x75B3D50", VA = "0x1875B4D50", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x75B5080", Offset = "0x75B4080", VA = "0x1875B5080", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x75B5740", Offset = "0x75B4740", VA = "0x1875B5740")]
	protected JMFJELLGOJH(Guid HIKJHHIHDMH, NDFFAKPPKGI GAIEJGCLEHG, DDJLHCONOLF FKBNHEMIFCL, string OJMAIKPAPGH, NNCNNOMHHHL HOAFJBCIPPP, bool EIKNBGKLHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x75B5700", Offset = "0x75B4700", VA = "0x1875B5700", Slot = "6")]
	protected virtual string PODKCLGBKKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x75B4D90", Offset = "0x75B3D90", VA = "0x1875B4D90")]
	public void CCHHCPPDIHC(JGGFCCEKFPI FONDONNFFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x75B4D70", Offset = "0x75B3D70", VA = "0x1875B4D70")]
	protected void BNJPPEKKHOC(float NLBDJHPCOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x75B5480", Offset = "0x75B4480", VA = "0x1875B5480")]
	[AsyncStateMachine(typeof(ADHOEEJEKBD))]
	public Task LAHPNPBPBKK(CancellationToken CLIKNEKJHEI, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, [Optional] Func<JMFJELLGOJH, NPOAFBCOAIB<string>.HFMLKGGDOCE, IEGLONMBGEN> DKKJFNADELI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x75B55D0", Offset = "0x75B45D0", VA = "0x1875B55D0")]
	[AsyncStateMachine(typeof(FLKIFNBGGNG))]
	private static Task MCDKEFBPMPP(Func<CancellationToken, Task> IJLBBIHHMHL, Func<CancellationToken, Task> AGEKIBKJAPC, CancellationToken OJBNPAMIAFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x75B4DF0", Offset = "0x75B3DF0", VA = "0x1875B4DF0")]
	private void CDAPBNBOLHM(bool BDKLGGLGLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x75B4F70", Offset = "0x75B3F70", VA = "0x1875B4F70")]
	private void EBJPOIHEMOP(IEGLONMBGEN AADLMFJNHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task PEEGILEEPGP(IEGLONMBGEN AADLMFJNHJD, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x75B50A0", Offset = "0x75B40A0", VA = "0x1875B50A0")]
	[AsyncStateMachine(typeof(EPDJLDEOLIO))]
	private Task GFMNKCJCPJO(NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x75B51C0", Offset = "0x75B41C0", VA = "0x1875B51C0")]
	public MELJGKFCAHJ GHLMMFLMFCD(DEIBCGBKIHM MLAOIPLBGOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x75B5290", Offset = "0x75B4290", VA = "0x1875B5290")]
	[CompilerGenerated]
	private Task HMHPOBJLDNC(CancellationToken JJJGJKKAJDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x75B5380", Offset = "0x75B4380", VA = "0x1875B5380")]
	[CompilerGenerated]
	private object JBNKOOAIJKC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
internal sealed class PHCBECODLJP : GDDMNGOHJBD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct CPGMHMKPGCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public PHCBECODLJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public IEGLONMBGEN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private JNNCAHPPKJI <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private DGIEFAKGIHI <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x75AAD10", Offset = "0x75A9D10", VA = "0x1875AAD10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x75AB470", Offset = "0x75AA470", VA = "0x1875AB470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	private readonly AICBJAIGANE HGMAGGKDCBI;

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x75BC860", Offset = "0x75BB860", VA = "0x1875BC860")]
	public PHCBECODLJP(Guid HIKJHHIHDMH, NDFFAKPPKGI GAIEJGCLEHG, AICBJAIGANE HGMAGGKDCBI, DDJLHCONOLF FKBNHEMIFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x75BC710", Offset = "0x75BB710", VA = "0x1875BC710", Slot = "8")]
	[AsyncStateMachine(typeof(CPGMHMKPGCN))]
	protected override Task CHMPHGMNMFK(IEGLONMBGEN AADLMFJNHJD, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal class MDENIBOMIGF : JMFJELLGOJH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private struct LBDKHCMPEHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public MDENIBOMIGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public IEGLONMBGEN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private TaskAwaiter<APNIAAHHPPH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x75B6940", Offset = "0x75B5940", VA = "0x1875B6940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x75B6CF0", Offset = "0x75B5CF0", VA = "0x1875B6CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	private readonly string NPBJAGIJBDC;

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x75BA850", Offset = "0x75B9850", VA = "0x1875BA850")]
	public MDENIBOMIGF(Guid HIKJHHIHDMH, NDFFAKPPKGI GAIEJGCLEHG, DDJLHCONOLF FKBNHEMIFCL, string NPBJAGIJBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x75BA740", Offset = "0x75B9740", VA = "0x1875BA740", Slot = "7")]
	[AsyncStateMachine(typeof(LBDKHCMPEHL))]
	protected override Task PEEGILEEPGP(IEGLONMBGEN AADLMFJNHJD, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal class LIIPICLMMJI : GDDMNGOHJBD
{
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private sealed class JIEFKEPBDIK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000119")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			public AsyncTaskMethodBuilder<MELJGKFCAHJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			public JIEFKEPBDIK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			private TaskAwaiter<APNIAAHHPPH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400041B")]
			private TaskAwaiter<MELJGKFCAHJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x75BDE70", Offset = "0x75BCE70", VA = "0x1875BDE70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0x75BE330", Offset = "0x75BD330", VA = "0x1875BE330", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public LIIPICLMMJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public EJJBDNIDCMO serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public KHAOILFELCE roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public HPBFIFDAEJF uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public BDJMLMAMKGL roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public JIEFKEPBDIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x75B4BE0", Offset = "0x75B3BE0", VA = "0x1875B4BE0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<MELJGKFCAHJ> IDPNAOEDMFH(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct LDBMJDLDJHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public LIIPICLMMJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public IEGLONMBGEN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private JIEFKEPBDIK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private JNNCAHPPKJI <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private DGIEFAKGIHI <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private MELJGKFCAHJ <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private TaskAwaiter<MELJGKFCAHJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x75B6D50", Offset = "0x75B5D50", VA = "0x1875B6D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x75B7CD0", Offset = "0x75B6CD0", VA = "0x1875B7CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	private static readonly CDBONJBDMGH IKKEHAGICFD;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	private static readonly CDBONJBDMGH PJJEAGJIKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private readonly int ILCJANKFAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	[CanBeNull]
	private readonly MMJLHMCGMEI BMGCMOIFIKB;

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x75B87B0", Offset = "0x75B77B0", VA = "0x1875B87B0")]
	public LIIPICLMMJI(Guid HIKJHHIHDMH, NDFFAKPPKGI GAIEJGCLEHG, int ILCJANKFAMK, MMJLHMCGMEI BMGCMOIFIKB, DDJLHCONOLF FKBNHEMIFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x75B82F0", Offset = "0x75B72F0", VA = "0x1875B82F0", Slot = "8")]
	[AsyncStateMachine(typeof(LDBMJDLDJHO))]
	protected override Task CHMPHGMNMFK(IEGLONMBGEN AADLMFJNHJD, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x75B8430", Offset = "0x75B7430", VA = "0x1875B8430")]
	private void GEKFEAIBFJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x75B8530", Offset = "0x75B7530", VA = "0x1875B8530")]
	private void OPCOILFGGED(NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, JNNCAHPPKJI MCPCCOBALOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal abstract class OPHIOOFODOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public readonly JMFJELLGOJH MPIGFDGDADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public readonly IEGLONMBGEN EAEENIPAJHO;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public BJLINKIKEOI PAMCFEMCNIH
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x75BC5B0", Offset = "0x75BB5B0", VA = "0x1875BC5B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public GEDBAAOCPGO AOEDKDNFHGL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x75BC620", Offset = "0x75BB620", VA = "0x1875BC620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x75BC6B0", Offset = "0x75BB6B0", VA = "0x1875BC6B0")]
	protected OPHIOOFODOB(IEGLONMBGEN AADLMFJNHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x75BC600", Offset = "0x75BB600", VA = "0x1875BC600")]
	protected void CDMGIBILAAG(string BDCBPMKELGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal struct EAJGBJHKECJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public Dictionary<Guid, List<EGFDFDBABAP>> BPCNJICDDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public Dictionary<Guid, List<EGFDFDBABAP>> NFCJGBDCCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public Dictionary<Guid, List<EGFDFDBABAP>> BOFPCNBOKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public List<Guid> PAMFCACOCEL;

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x75AF2D0", Offset = "0x75AE2D0", VA = "0x1875AF2D0")]
	public static EAJGBJHKECJ KIJHOBDIGPJ(BJLINKIKEOI LAFNKOLGHIB, GDNCNIBJNMK LIODBJBFMDO, GAAHBJLKBPP NCJBJNMKCCH)
	{
		return default(EAJGBJHKECJ);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal struct IHLBOLOMIKP
{
	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40")]
	public static IHLBOLOMIKP AIOPMLNOOEO()
	{
		return default(IHLBOLOMIKP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal struct JDEDAABFNCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public readonly CDBHFDKLKGA JFCCOFMCJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public readonly ALMBCFFNDNC KNCAJJHONLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public readonly string HABIMNBKOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public readonly LMNKCNKLBML NMDHLPMFPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public readonly LMNKCNKLBML MOMPGFLGKNK;

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x75B4A10", Offset = "0x75B3A10", VA = "0x1875B4A10")]
	public JDEDAABFNCK(CDBHFDKLKGA JFCCOFMCJEI, ALMBCFFNDNC KNCAJJHONLO, string HABIMNBKOCK, LMNKCNKLBML NMDHLPMFPLI, LMNKCNKLBML MOMPGFLGKNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal struct KKLFAPLMGOJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	private readonly IEGLONMBGEN AADLMFJNHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	private readonly Guid OJJFBEAGHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	private bool BDKLGGLGLFK;

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x75B67F0", Offset = "0x75B57F0", VA = "0x1875B67F0")]
	public static KKLFAPLMGOJ FNKBCGKKKMO(IEGLONMBGEN AADLMFJNHJD)
	{
		return default(KKLFAPLMGOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0xD576C0", Offset = "0xD566C0", VA = "0x180D576C0")]
	public void MKHHFCHBIPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x75B6790", Offset = "0x75B5790", VA = "0x1875B6790", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x75B68F0", Offset = "0x75B58F0", VA = "0x1875B68F0")]
	private KKLFAPLMGOJ(IEGLONMBGEN AADLMFJNHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x75B6790", Offset = "0x75B5790", VA = "0x1875B6790")]
	private void KIJAKABIIJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x75B6850", Offset = "0x75B5850", VA = "0x1875B6850")]
	private Func<Guid, bool> MFONELKNECJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal class DGIEFAKGIHI : OPHIOOFODOB, ODIJIHPCMIA
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	public delegate Task<GDNCNIBJNMK> HJDOFJGJMPO(GAAHBJLKBPP CONAFKKIHKL, JGPCKPACCNF ADAAIPEPIKA, LNGPHIHDADF FHLPCAIEKLF, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct IJCELLMKBIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public DGIEFAKGIHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public AICBJAIGANE request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private KKLFAPLMGOJ <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		private TaskAwaiter<MELJGKFCAHJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x75B2880", Offset = "0x75B1880", VA = "0x1875B2880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x75B2FF0", Offset = "0x75B1FF0", VA = "0x1875B2FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct EHNMALHFBLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public AsyncTaskMethodBuilder<MELJGKFCAHJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public DGIEFAKGIHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public AICBJAIGANE request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private TaskAwaiter<MELJGKFCAHJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x75AF8D0", Offset = "0x75AE8D0", VA = "0x1875AF8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x75AFD00", Offset = "0x75AED00", VA = "0x1875AFD00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct LIHPKFBMFEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public DGIEFAKGIHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public AICBJAIGANE request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x75B7E00", Offset = "0x75B6E00", VA = "0x1875B7E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x75B8290", Offset = "0x75B7290", VA = "0x1875B8290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private sealed class IHOMCPIEGNN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000127")]
		private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			public AsyncTaskMethodBuilder<JDEDAABFNCK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			public IHOMCPIEGNN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			private JDEDAABFNCK <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			private TaskAwaiter<GDNCNIBJNMK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			private TaskAwaiter<JDEDAABFNCK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0x75BC910", Offset = "0x75BB910", VA = "0x1875BC910", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x75BD0B0", Offset = "0x75BC0B0", VA = "0x1875BD0B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000128")]
		private struct <<LoadRoomLocal>b__3>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			public AsyncTaskMethodBuilder<GAAHBJLKBPP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			public IHOMCPIEGNN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			private GAAHBJLKBPP <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			private TaskAwaiter<GDNCNIBJNMK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			private TaskAwaiter<GAAHBJLKBPP> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x75BD120", Offset = "0x75BC120", VA = "0x1875BD120", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0x75BD770", Offset = "0x75BC770", VA = "0x1875BD770", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public DGIEFAKGIHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public AICBJAIGANE request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public LNGPHIHDADF preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public LNGPHIHDADF downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public JDEDAABFNCK data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public LNGPHIHDADF postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public GAAHBJLKBPP phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public MLCHNALLIKI.NPOLGANCKCJ <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public IHOMCPIEGNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x75B2320", Offset = "0x75B1320", VA = "0x1875B2320")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<JDEDAABFNCK> ANGOPKBECDL(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x75B2460", Offset = "0x75B1460", VA = "0x1875B2460")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<GAAHBJLKBPP> DCNEIPPHHEE(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x75B26E0", Offset = "0x75B16E0", VA = "0x1875B26E0")]
		internal void KBJCOPLPAGL(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x75B2720", Offset = "0x75B1720", VA = "0x1875B2720")]
		internal Task NHHPKAEFKLI(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x75B2580", Offset = "0x75B1580", VA = "0x1875B2580")]
		internal Task GPDHACAIHMG(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct DBCJMNIGEIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public DGIEFAKGIHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public AICBJAIGANE request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private IHOMCPIEGNN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private TaskAwaiter<JDEDAABFNCK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private TaskAwaiter<GAAHBJLKBPP> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x75AB4D0", Offset = "0x75AA4D0", VA = "0x1875AB4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x75AC1F0", Offset = "0x75AB1F0", VA = "0x1875AC1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct OOENJPIBFCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public DGIEFAKGIHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public GAAHBJLKBPP phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public LNGPHIHDADF postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private TaskAwaiter<GDNCNIBJNMK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private JGPCKPACCNF <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x75BB630", Offset = "0x75BA630", VA = "0x1875BB630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x75BC550", Offset = "0x75BB550", VA = "0x1875BC550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct AMGKJBIHEFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public DGIEFAKGIHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x75A8BB0", Offset = "0x75A7BB0", VA = "0x1875A8BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x75A9470", Offset = "0x75A8470", VA = "0x1875A9470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct MALJFCIFIOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public DGIEFAKGIHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public GAAHBJLKBPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public LNGPHIHDADF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private TaskAwaiter<GDNCNIBJNMK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x75B9D50", Offset = "0x75B8D50", VA = "0x1875B9D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x75BA6E0", Offset = "0x75B96E0", VA = "0x1875BA6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct AIKBAOJGHGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public AsyncTaskMethodBuilder<GDNCNIBJNMK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public DGIEFAKGIHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public GAAHBJLKBPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public LNGPHIHDADF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private TaskAwaiter<GDNCNIBJNMK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x75A79D0", Offset = "0x75A69D0", VA = "0x1875A79D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x75A89B0", Offset = "0x75A79B0", VA = "0x1875A89B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct LMFEIEEEPCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public AsyncTaskMethodBuilder<GDNCNIBJNMK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public DGIEFAKGIHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public GAAHBJLKBPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public LNGPHIHDADF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public JGPCKPACCNF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private TaskAwaiter<GDNCNIBJNMK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x75B8860", Offset = "0x75B7860", VA = "0x1875B8860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x75B9960", Offset = "0x75B8960", VA = "0x1875B9960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct IABEPNCMCLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public AsyncTaskMethodBuilder<GDNCNIBJNMK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public DGIEFAKGIHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public GDNCNIBJNMK operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public LNGPHIHDADF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public GAAHBJLKBPP deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private TaskAwaiter<GDNCNIBJNMK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x75B2010", Offset = "0x75B1010", VA = "0x1875B2010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x75B22B0", Offset = "0x75B12B0", VA = "0x1875B22B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private sealed class AINHIEAPPHF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000132")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004BF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004C0")]
			public AsyncTaskMethodBuilder<GDNCNIBJNMK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004C1")]
			public AINHIEAPPHF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004C2")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C3")]
			private JMBOKLBNKIG <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004C4")]
			private TaskAwaiter<GDNCNIBJNMK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000531")]
			[Cpp2IlInjected.Address(RVA = "0x75BD7E0", Offset = "0x75BC7E0", VA = "0x1875BD7E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x75BDE00", Offset = "0x75BCE00", VA = "0x1875BDE00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public DGIEFAKGIHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public GAAHBJLKBPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public LNGPHIHDADF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public HJDOFJGJMPO masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public JGPCKPACCNF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public GDNCNIBJNMK originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public AINHIEAPPHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x75A8A20", Offset = "0x75A7A20", VA = "0x1875A8A20")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<GDNCNIBJNMK> CJHFOEJCNLI(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct HEBOBMEAEAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public AsyncTaskMethodBuilder<GDNCNIBJNMK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public DGIEFAKGIHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public GAAHBJLKBPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public LNGPHIHDADF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public HJDOFJGJMPO masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public JGPCKPACCNF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private JMBOKLBNKIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private TaskAwaiter<GDNCNIBJNMK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x75B16D0", Offset = "0x75B06D0", VA = "0x1875B16D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x75B1BF0", Offset = "0x75B0BF0", VA = "0x1875B1BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct CLFHNOHPEFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public DGIEFAKGIHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public GAAHBJLKBPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public LNGPHIHDADF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private GDNCNIBJNMK <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private IEnumerator<GDNCNIBJNMK> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private TaskAwaiter<GDNCNIBJNMK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x75AA760", Offset = "0x75A9760", VA = "0x1875AA760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x75AACB0", Offset = "0x75A9CB0", VA = "0x1875AACB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct HCNAGGPMPDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public DGIEFAKGIHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public GAAHBJLKBPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x75B1450", Offset = "0x75B0450", VA = "0x1875B1450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x75B1670", Offset = "0x75B0670", VA = "0x1875B1670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct CDCMJHLEGAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public DGIEFAKGIHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public GAAHBJLKBPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x75AA560", Offset = "0x75A9560", VA = "0x1875AA560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x75AA700", Offset = "0x75A9700", VA = "0x1875AA700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct IPMCEBGNIJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public DGIEFAKGIHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public GAAHBJLKBPP phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public LNGPHIHDADF postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private TaskAwaiter<GDNCNIBJNMK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private JGPCKPACCNF <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x75B3A90", Offset = "0x75B2A90", VA = "0x1875B3A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x75B49B0", Offset = "0x75B39B0", VA = "0x1875B49B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private struct DLFNILJNNCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public AsyncTaskMethodBuilder<GDNCNIBJNMK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public DGIEFAKGIHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public GAAHBJLKBPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public LNGPHIHDADF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		private TaskAwaiter<GDNCNIBJNMK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x75AE5F0", Offset = "0x75AD5F0", VA = "0x1875AE5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x75AF120", Offset = "0x75AE120", VA = "0x1875AF120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private readonly FMCPMEFHBJK NNJJMOIDEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private readonly FMCPMEFHBJK FFGHOLJNAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private readonly DFJODANGFCB EMONDMHOGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	private readonly NPPJMKCOMHB DHNKFAANBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	private readonly FKHKEECKICD LHGPPEKJBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private ProfilerCounterValue<int> LCEPHIKPEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	private readonly GFBJONOOLIG LIHBEAAHFKN;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private NDFFAKPPKGI MMDKFLKIJGL
	{
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x75AD7C0", Offset = "0x75AC7C0", VA = "0x1875AD7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event DAGADGHJCCE CNHNFGNJFKN
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x75ACE80", Offset = "0x75ABE80", VA = "0x1875ACE80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x75AD620", Offset = "0x75AC620", VA = "0x1875AD620", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x75AE330", Offset = "0x75AD330", VA = "0x1875AE330")]
	public DGIEFAKGIHI(IEGLONMBGEN AADLMFJNHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x75ACA60", Offset = "0x75ABA60", VA = "0x1875ACA60")]
	[AsyncStateMachine(typeof(IJCELLMKBIG))]
	public Task AEOCDBOJCII(AICBJAIGANE ONMEAHDGGOB, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x75ACFF0", Offset = "0x75ABFF0", VA = "0x1875ACFF0")]
	[AsyncStateMachine(typeof(EHNMALHFBLJ))]
	private Task<MELJGKFCAHJ> CMJPPJLEMHA(AICBJAIGANE ONMEAHDGGOB, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x75AD390", Offset = "0x75AC390", VA = "0x1875AD390")]
	[AsyncStateMachine(typeof(LIHPKFBMFEO))]
	private Task EOFIECKHJLD(AICBJAIGANE ONMEAHDGGOB, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x75ACD40", Offset = "0x75ABD40", VA = "0x1875ACD40")]
	[AsyncStateMachine(typeof(DBCJMNIGEIO))]
	private Task BCKPCEENJAN(AICBJAIGANE ONMEAHDGGOB, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken GDCGLIMCMOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x75AD150", Offset = "0x75AC150", VA = "0x1875AD150")]
	[AsyncStateMachine(typeof(OOENJPIBFCG))]
	private Task EAAIMFHOIIJ(GAAHBJLKBPP JHPONCJMJOL, LNGPHIHDADF JDPDGKAOLCI, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CHHAHLGOCHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x75AE220", Offset = "0x75AD220", VA = "0x1875AE220")]
	[AsyncStateMachine(typeof(AMGKJBIHEFK))]
	private Task PBAPKPKEFCO(NPOAFBCOAIB<string>.HFMLKGGDOCE FCPMHEOCJMB, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x75ADCB0", Offset = "0x75ACCB0", VA = "0x1875ADCB0")]
	[AsyncStateMachine(typeof(MALJFCIFIOI))]
	private Task KIMNGLMDMJL(GAAHBJLKBPP CONAFKKIHKL, LNGPHIHDADF FHLPCAIEKLF, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x75AE080", Offset = "0x75AD080", VA = "0x1875AE080")]
	[AsyncStateMachine(typeof(AIKBAOJGHGI))]
	private Task<GDNCNIBJNMK> NMJEMACHBLA(GAAHBJLKBPP CONAFKKIHKL, JGPCKPACCNF DCHMNKJPJPJ, LNGPHIHDADF FHLPCAIEKLF, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x75ADB30", Offset = "0x75ACB30", VA = "0x1875ADB30")]
	[AsyncStateMachine(typeof(LMFEIEEEPCH))]
	private Task<GDNCNIBJNMK> JKEENHECEBA(GAAHBJLKBPP CONAFKKIHKL, JGPCKPACCNF DCHMNKJPJPJ, LNGPHIHDADF FHLPCAIEKLF, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x75AD640", Offset = "0x75AC640", VA = "0x1875AD640")]
	[AsyncStateMachine(typeof(IABEPNCMCLM))]
	private Task<GDNCNIBJNMK> GHPKALLIFKK(GDNCNIBJNMK LIODBJBFMDO, GAAHBJLKBPP NCJBJNMKCCH, LNGPHIHDADF FHLPCAIEKLF, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI, bool LFMAOOIJEDD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x75ADF50", Offset = "0x75ACF50", VA = "0x1875ADF50")]
	private bool MNHADKAKFHF(GAAHBJLKBPP JHPONCJMJOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x75ACBB0", Offset = "0x75ABBB0", VA = "0x1875ACBB0")]
	[AsyncStateMachine(typeof(HEBOBMEAEAN))]
	protected Task<GDNCNIBJNMK> AOALEDKDPFH(GAAHBJLKBPP CONAFKKIHKL, JGPCKPACCNF DCHMNKJPJPJ, LNGPHIHDADF FHLPCAIEKLF, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI, HJDOFJGJMPO FFGPPKINALE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x75AD4D0", Offset = "0x75AC4D0", VA = "0x1875AD4D0")]
	[AsyncStateMachine(typeof(CLFHNOHPEFI))]
	private Task FDGNCFCGKDG(GAAHBJLKBPP CONAFKKIHKL, LNGPHIHDADF FHLPCAIEKLF, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x75AD970", Offset = "0x75AC970", VA = "0x1875AD970")]
	private void ICNKPKBEJGD(GDNCNIBJNMK EJFJHDCPBAO, LNGPHIHDADF FHLPCAIEKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x75ADEC0", Offset = "0x75ACEC0", VA = "0x1875ADEC0")]
	private void LPDCAPBKGFB(GDNCNIBJNMK NKPHDMFEOCM, [Out] GDNCNIBJNMK LIFHGBDAJMK, [Out] GDNCNIBJNMK ACIAMIJPFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x75AE1E0", Offset = "0x75AD1E0", VA = "0x1875AE1E0")]
	private Task<JDEDAABFNCK> OFHJJALHFCB(AICBJAIGANE ONMEAHDGGOB, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x75ADE00", Offset = "0x75ACE00", VA = "0x1875ADE00")]
	private Task<GAAHBJLKBPP> KPDDGCKNICH(JDEDAABFNCK CONAFKKIHKL, MLCHNALLIKI.NPOLGANCKCJ INGCDLNACPB, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x75AD9C0", Offset = "0x75AC9C0", VA = "0x1875AD9C0")]
	[AsyncStateMachine(typeof(HCNAGGPMPDH))]
	private Task IFFNCDDAFHI(GAAHBJLKBPP CONAFKKIHKL, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI, bool PDJEEKHHCFI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x75AD2A0", Offset = "0x75AC2A0", VA = "0x1875AD2A0")]
	[AsyncStateMachine(typeof(CDCMJHLEGAB))]
	private Task EKLECFEHMDI(GAAHBJLKBPP CONAFKKIHKL, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x75ADE90", Offset = "0x75ACE90", VA = "0x1875ADE90")]
	private Task LKNIBIBCGNJ(GAAHBJLKBPP CONAFKKIHKL, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x75ADF00", Offset = "0x75ACF00", VA = "0x1875ADF00")]
	private Task MDNKPHHIDCM(GAAHBJLKBPP CONAFKKIHKL, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x75ADF20", Offset = "0x75ACF20", VA = "0x1875ADF20")]
	private Task MGPHBGMCFIP(GAAHBJLKBPP CONAFKKIHKL, JGPCKPACCNF DCHMNKJPJPJ, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x75AE040", Offset = "0x75AD040", VA = "0x1875AE040")]
	private Task MPHOIPJIAJL(GAAHBJLKBPP CONAFKKIHKL, JGPCKPACCNF DCHMNKJPJPJ, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x75ADF40", Offset = "0x75ACF40", VA = "0x1875ADF40")]
	private static Task MHEHJODEHPG(CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x75AD7F0", Offset = "0x75AC7F0", VA = "0x1875AD7F0")]
	private Task GMIMOGJFJBC(GAAHBJLKBPP CONAFKKIHKL, JGPCKPACCNF DCHMNKJPJPJ, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x75AE060", Offset = "0x75AD060", VA = "0x1875AE060")]
	private Task NCPOIEJKKDN(GAAHBJLKBPP CONAFKKIHKL, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x75ADE40", Offset = "0x75ACE40", VA = "0x1875ADE40")]
	private void LIJCPIIJGAF(AICBJAIGANE ONMEAHDGGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x75ADB10", Offset = "0x75ACB10", VA = "0x1875ADB10")]
	public void ILMNBLPAHEM(long GEKHFNOGIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
	private static void CGMMIKDDKAI(CDBHFDKLKGA JFCCOFMCJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x75ACEA0", Offset = "0x75ABEA0", VA = "0x1875ACEA0")]
	[AsyncStateMachine(typeof(IPMCEBGNIJO))]
	private Task CFCKOAMHKAC(GAAHBJLKBPP JHPONCJMJOL, LNGPHIHDADF JDPDGKAOLCI, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CHHAHLGOCHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x75AD810", Offset = "0x75AC810", VA = "0x1875AD810")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(DLFNILJNNCB))]
	private Task<GDNCNIBJNMK> HJFNKCOHKCP(GAAHBJLKBPP CONAFKKIHKL, JGPCKPACCNF DCHMNKJPJPJ, LNGPHIHDADF FHLPCAIEKLF, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct JIIPFLAPECO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private NDFFAKPPKGI GAIEJGCLEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private GAAHBJLKBPP CONAFKKIHKL;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private BJLINKIKEOI PAMCFEMCNIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x75CFE30", Offset = "0x75CEE30", VA = "0x1875CFE30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x75D0090", Offset = "0x75CF090", VA = "0x1875D0090")]
	public static Task LAHPNPBPBKK(NDFFAKPPKGI GAIEJGCLEHG, GAAHBJLKBPP CONAFKKIHKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x75CFE80", Offset = "0x75CEE80", VA = "0x1875CFE80")]
	private void LAHPNPBPBKK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct FABBNIIHCMH
{
	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x75C8C10", Offset = "0x75C7C10", VA = "0x1875C8C10")]
	public static Task LAHPNPBPBKK(CancellationToken CLIKNEKJHEI)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct IKBOLGNKMGG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct FFEIGBJANDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public IEGLONMBGEN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public GAAHBJLKBPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private JMBOKLBNKIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x75C93F0", Offset = "0x75C83F0", VA = "0x1875C93F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x75C9920", Offset = "0x75C8920", VA = "0x1875C9920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x75CF170", Offset = "0x75CE170", VA = "0x1875CF170")]
	[AsyncStateMachine(typeof(FFEIGBJANDA))]
	public static Task LAHPNPBPBKK(IEGLONMBGEN AADLMFJNHJD, GAAHBJLKBPP CONAFKKIHKL, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013D")]
internal struct NGPKBEGONAG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct AFGKLAOFAPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public IEGLONMBGEN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public GAAHBJLKBPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public JGPCKPACCNF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private GDNCNIBJNMK <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private NDFFAKPPKGI <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private BJLINKIKEOI <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private JMBOKLBNKIG <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private List<(PersistenceView, KGIKLNIIDMO)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private KGIKLNIIDMO <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x75BE6E0", Offset = "0x75BD6E0", VA = "0x1875BE6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x75BF370", Offset = "0x75BE370", VA = "0x1875BF370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x75D3710", Offset = "0x75D2710", VA = "0x1875D3710")]
	[AsyncStateMachine(typeof(AFGKLAOFAPF))]
	public static Task LAHPNPBPBKK(IEGLONMBGEN AADLMFJNHJD, GAAHBJLKBPP CONAFKKIHKL, JGPCKPACCNF DCHMNKJPJPJ, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x75D3520", Offset = "0x75D2520", VA = "0x1875D3520")]
	private static void KAIDFECJDIA(PersistenceView NJFNPGALOJK, KGIKLNIIDMO DBMIMADNHFB, GAAHBJLKBPP CONAFKKIHKL, GDNCNIBJNMK LIODBJBFMDO, bool OEBGKDGHCKO)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct EMPOKLEHLFK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct AMEJDIHCADG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public NDFFAKPPKGI roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public GAAHBJLKBPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x75BF7E0", Offset = "0x75BE7E0", VA = "0x1875BF7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x75BFC10", Offset = "0x75BEC10", VA = "0x1875BFC10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x75C7860", Offset = "0x75C6860", VA = "0x1875C7860")]
	[AsyncStateMachine(typeof(AMEJDIHCADG))]
	public static Task LAHPNPBPBKK(NDFFAKPPKGI GAIEJGCLEHG, GAAHBJLKBPP CONAFKKIHKL, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
internal struct PLMLCBLFGLN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct EOAOMPNNKBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public NDFFAKPPKGI roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public GAAHBJLKBPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public IEGLONMBGEN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x75C7970", Offset = "0x75C6970", VA = "0x1875C7970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x75C7B80", Offset = "0x75C6B80", VA = "0x1875C7B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private sealed class FNBCCHCIJBG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000145")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400052D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400052E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400052F")]
			public NPOAFBCOAIB<string>.HFMLKGGDOCE timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			public FNBCCHCIJBG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private NPOAFBCOAIB<string>.HFMLKGGDOCE <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0x75D7590", Offset = "0x75D6590", VA = "0x1875D7590", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0x75D7920", Offset = "0x75D6920", VA = "0x1875D7920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public FNBCCHCIJBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x75CACC0", Offset = "0x75C9CC0", VA = "0x1875CACC0")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task PCNIMFPLGBA(NPOAFBCOAIB<string>.HFMLKGGDOCE timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct DJJFFDGENIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public PLMLCBLFGLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private JMBOKLBNKIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private TaskAwaiter<MELJGKFCAHJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x75C4B10", Offset = "0x75C3B10", VA = "0x1875C4B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x75C54E0", Offset = "0x75C44E0", VA = "0x1875C54E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class HGMKFBOAOOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public PMEDDBIJCLE version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public HGMKFBOAOOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x75CDD80", Offset = "0x75CCD80", VA = "0x1875CDD80")]
		internal object LPPEAACJCLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x75CDCD0", Offset = "0x75CCCD0", VA = "0x1875CDCD0")]
		internal object KKICPCDLGMJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	private NDFFAKPPKGI GAIEJGCLEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	private GAAHBJLKBPP CONAFKKIHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private IEGLONMBGEN AADLMFJNHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private bool PDJEEKHHCFI;

	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private static readonly ByteString KJCMEPOAJOI;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private BJLINKIKEOI PAMCFEMCNIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x75D62B0", Offset = "0x75D52B0", VA = "0x1875D62B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private GEDBAAOCPGO AOEDKDNFHGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x75D69C0", Offset = "0x75D59C0", VA = "0x1875D69C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x75D6BA0", Offset = "0x75D5BA0", VA = "0x1875D6BA0")]
	[AsyncStateMachine(typeof(EOAOMPNNKBH))]
	public static Task LAHPNPBPBKK(NDFFAKPPKGI GAIEJGCLEHG, GAAHBJLKBPP CONAFKKIHKL, IEGLONMBGEN AADLMFJNHJD, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI, bool PDJEEKHHCFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x75D6A60", Offset = "0x75D5A60", VA = "0x1875D6A60")]
	[AsyncStateMachine(typeof(DJJFFDGENIJ))]
	private Task LAHPNPBPBKK(NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x75D6340", Offset = "0x75D5340", VA = "0x1875D6340")]
	private void JLKCIHBCEMA([NotNull] MEGLOJMOHAP MFJLOFOELBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x75D6300", Offset = "0x75D5300", VA = "0x1875D6300")]
	private bool FIGEEJPHLNI(PMEDDBIJCLE FNBFBBNHKCM, MEGLOJMOHAP MFJLOFOELBM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
internal struct KECJIACCPJB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct BJFBKMBLMMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public AsyncTaskMethodBuilder<GAAHBJLKBPP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public KECJIACCPJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public MLCHNALLIKI.NPOLGANCKCJ downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private JMBOKLBNKIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private TaskAwaiter<(OBFFLKDLIBJ<FELHNEMNIPM, PPOILIOPEKP>, OBFFLKDLIBJ<IIOIPHLGGKA<MEGLOJMOHAP>, PPOILIOPEKP>, OBFFLKDLIBJ<IIOIPHLGGKA<DPOFJEJGEFI>, PPOILIOPEKP>, OBFFLKDLIBJ<IIOIPHLGGKA<GCKCDKOFDGL>, PPOILIOPEKP>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x75C0FC0", Offset = "0x75BFFC0", VA = "0x1875C0FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x75C1A70", Offset = "0x75C0A70", VA = "0x1875C1A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct HEIMMPDJEEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<FELHNEMNIPM, PPOILIOPEKP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public KECJIACCPJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public MLCHNALLIKI.NPOLGANCKCJ downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private JMBOKLBNKIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private TaskAwaiter<OBFFLKDLIBJ<FELHNEMNIPM, PPOILIOPEKP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x75CD650", Offset = "0x75CC650", VA = "0x1875CD650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x75CDC60", Offset = "0x75CCC60", VA = "0x1875CDC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	private JJHGGOFNDGB<LMNKCNKLBML, DPOFJEJGEFI> JOBGPGILDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	private JJHGGOFNDGB<LMNKCNKLBML, MEGLOJMOHAP> NPGMDMKFDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	private JJHGGOFNDGB<long, GCKCDKOFDGL> KCFNNPOHIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	private JIDCMNNOIND LHMIOKGMDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	private CDBHFDKLKGA JFCCOFMCJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	private ALMBCFFNDNC KNCAJJHONLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	private string HABIMNBKOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	private LMNKCNKLBML NMDHLPMFPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	private LMNKCNKLBML MOMPGFLGKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	private long GEKHFNOGIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	private NPOAFBCOAIB<string>.HFMLKGGDOCE FCPMHEOCJMB;

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x75D0A50", Offset = "0x75CFA50", VA = "0x1875D0A50")]
	public static Task<GAAHBJLKBPP> GHAIHGKBAKD(NDFFAKPPKGI GAIEJGCLEHG, [In] JDEDAABFNCK CONAFKKIHKL, MLCHNALLIKI.NPOLGANCKCJ INGCDLNACPB, NPOAFBCOAIB<string>.HFMLKGGDOCE FCPMHEOCJMB, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x75D0DC0", Offset = "0x75CFDC0", VA = "0x1875D0DC0")]
	[AsyncStateMachine(typeof(BJFBKMBLMMK))]
	private Task<GAAHBJLKBPP> LAHPNPBPBKK(MLCHNALLIKI.NPOLGANCKCJ INGCDLNACPB, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x75D0890", Offset = "0x75CF890", VA = "0x1875D0890")]
	[AsyncStateMachine(typeof(HEIMMPDJEEL))]
	private Task<OBFFLKDLIBJ<FELHNEMNIPM, PPOILIOPEKP>> FHJHNDJDKPG(string HABIMNBKOCK, long GEKHFNOGIOM, long? AHNLEKFKAGC, long? ABKHIAFPEJM, MLCHNALLIKI.NPOLGANCKCJ INGCDLNACPB, NPOAFBCOAIB<string>.HFMLKGGDOCE LOKFEGHEHJM, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal struct FHANIEEMJJK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct BPEMJBPBDFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public AsyncTaskMethodBuilder<JDEDAABFNCK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public FHANIEEMJJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private TaskAwaiter<JDEDAABFNCK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x75C2CA0", Offset = "0x75C1CA0", VA = "0x1875C2CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x75C30B0", Offset = "0x75C20B0", VA = "0x1875C30B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct LCCMJEOBJBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public AsyncTaskMethodBuilder<JDEDAABFNCK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public FHANIEEMJJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private TaskAwaiter<JDEDAABFNCK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x75D1480", Offset = "0x75D0480", VA = "0x1875D1480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x75D18B0", Offset = "0x75D08B0", VA = "0x1875D18B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private sealed class BINIHOFEDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public BINIHOFEDPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0xAC6BF0", Offset = "0xAC5BF0", VA = "0x180AC6BF0")]
		internal bool GNMCFADEJPM(ALMBCFFNDNC sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct BLLKJBLAJEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public AsyncTaskMethodBuilder<JDEDAABFNCK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public LMNKCNKLBML superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public BJLINKIKEOI callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private BINIHOFEDPB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public BDINCNLOEGO roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private CDBHFDKLKGA <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private ALMBCFFNDNC <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private LMNKCNKLBML <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private LMNKCNKLBML <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private TaskAwaiter<CDBHFDKLKGA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private TaskAwaiter<FEPJAEOAPIH> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private TaskAwaiter<BLNDCCHFGLB> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x75C1AE0", Offset = "0x75C0AE0", VA = "0x1875C1AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x75C2C30", Offset = "0x75C1C30", VA = "0x1875C2C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000562")]
	private BJLINKIKEOI LAFNKOLGHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000563")]
	private DFJODANGFCB EMONDMHOGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000564")]
	private BDINCNLOEGO EILEBHOKJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	private NPOAFBCOAIB<string>.HFMLKGGDOCE FCPMHEOCJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	private long AHNLEKFKAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	private long PDLBLPPCJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private long ADPOGHGNAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private string PBJMLELNKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private LMNKCNKLBML IDJEMPFCMGA;

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x75CA240", Offset = "0x75C9240", VA = "0x1875CA240")]
	public static Task<JDEDAABFNCK> GHAIHGKBAKD(NDFFAKPPKGI GAIEJGCLEHG, AICBJAIGANE ONMEAHDGGOB, NPOAFBCOAIB<string>.HFMLKGGDOCE FCPMHEOCJMB, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x75CA4E0", Offset = "0x75C94E0", VA = "0x1875CA4E0")]
	[AsyncStateMachine(typeof(BPEMJBPBDFL))]
	private Task<JDEDAABFNCK> LAHPNPBPBKK(CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x75CA7D0", Offset = "0x75C97D0", VA = "0x1875CA7D0")]
	[AsyncStateMachine(typeof(LCCMJEOBJBJ))]
	private Task<JDEDAABFNCK> OFHJJALHFCB(NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x75CA630", Offset = "0x75C9630", VA = "0x1875CA630")]
	[AsyncStateMachine(typeof(BLLKJBLAJEI))]
	private static Task<JDEDAABFNCK> OFHJJALHFCB(BJLINKIKEOI LAFNKOLGHIB, BDINCNLOEGO EILEBHOKJGN, long AHNLEKFKAGC, long PDLBLPPCJKC, long ADPOGHGNAJP, string PBJMLELNKLD, LMNKCNKLBML IDJEMPFCMGA, CancellationToken CLIKNEKJHEI, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x75CA4B0", Offset = "0x75C94B0", VA = "0x1875CA4B0")]
	private void ICLBLKJMMNE(CDBHFDKLKGA JFCCOFMCJEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
internal struct DAMEMBCONJC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct EOOAIFCMNMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public DAMEMBCONJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x75C7BE0", Offset = "0x75C6BE0", VA = "0x1875C7BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x75C8170", Offset = "0x75C7170", VA = "0x1875C8170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400058D")]
	private BJLINKIKEOI LAFNKOLGHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400058E")]
	private GAAHBJLKBPP CONAFKKIHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400058F")]
	private NPOAFBCOAIB<string>.HFMLKGGDOCE FCPMHEOCJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000590")]
	private float ONBAJCEHMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	private float KEIPPGGOBJB;

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x75C3D30", Offset = "0x75C2D30", VA = "0x1875C3D30")]
	public static Task PFINKICEABK(NDFFAKPPKGI GAIEJGCLEHG, GAAHBJLKBPP CONAFKKIHKL, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x75C39D0", Offset = "0x75C29D0", VA = "0x1875C39D0")]
	[AsyncStateMachine(typeof(EOOAIFCMNMD))]
	public Task LAHPNPBPBKK(CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x75C38A0", Offset = "0x75C28A0", VA = "0x1875C38A0")]
	private static void DKEMOMNBHNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x75C3AF0", Offset = "0x75C2AF0", VA = "0x1875C3AF0")]
	private void LCDKCDGMKND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x75C3C70", Offset = "0x75C2C70", VA = "0x1875C3C70")]
	private static float NPDFDBKKKEC(BJLINKIKEOI LAFNKOLGHIB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x75C3C50", Offset = "0x75C2C50", VA = "0x1875C3C50")]
	private static float LKPEGMHBPOB()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal struct LOOHEBFNDCP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct GBEAGMCDDOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public IEGLONMBGEN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public GAAHBJLKBPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private JMBOKLBNKIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private JMFJELLGOJH <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private NDFFAKPPKGI <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private MDJAEKECPNK.HNHMICFBACC <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private TaskAwaiter<MELJGKFCAHJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x75CB6F0", Offset = "0x75CA6F0", VA = "0x1875CB6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x75CBF10", Offset = "0x75CAF10", VA = "0x1875CBF10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct DFEMCMBIDIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private JMBOKLBNKIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x75C3ED0", Offset = "0x75C2ED0", VA = "0x1875C3ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x75C4200", Offset = "0x75C3200", VA = "0x1875C4200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x75D1C30", Offset = "0x75D0C30", VA = "0x1875D1C30")]
	[AsyncStateMachine(typeof(GBEAGMCDDOL))]
	public static Task LAHPNPBPBKK(IEGLONMBGEN AADLMFJNHJD, GAAHBJLKBPP CONAFKKIHKL, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x75D1B00", Offset = "0x75D0B00", VA = "0x1875D1B00")]
	private static Task<MELJGKFCAHJ> AMOPGEAFPDJ(IEGLONMBGEN AADLMFJNHJD, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x75D1B70", Offset = "0x75D0B70", VA = "0x1875D1B70")]
	[AsyncStateMachine(typeof(DFEMCMBIDIJ))]
	private static Task KNNDIMCIIID()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal struct KEALLCBJIFE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct DLOEPADEADD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public KEALLCBJIFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x75C5540", Offset = "0x75C4540", VA = "0x1875C5540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x75C5BF0", Offset = "0x75C4BF0", VA = "0x1875C5BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private sealed class NPGGHBNOCKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public NPGGHBNOCKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x75D3B00", Offset = "0x75D2B00", VA = "0x1875D3B00")]
		internal object JHMFPOPDCHP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct DMBKIHENJEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public KEALLCBJIFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private JMBOKLBNKIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x75C5C50", Offset = "0x75C4C50", VA = "0x1875C5C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x75C60D0", Offset = "0x75C50D0", VA = "0x1875C60D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005AC")]
	private bool DGICFBEIAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005AD")]
	private NPOAFBCOAIB<string>.HFMLKGGDOCE FCPMHEOCJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005AE")]
	private NDFFAKPPKGI GAIEJGCLEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005AF")]
	private CancellationToken CLIKNEKJHEI;

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x75D0600", Offset = "0x75CF600", VA = "0x1875D0600")]
	public static Task IMHHDIAIPKF(NDFFAKPPKGI GAIEJGCLEHG, bool DGICFBEIAIL, NPOAFBCOAIB<string>.HFMLKGGDOCE FCPMHEOCJMB, CancellationToken EKJCJBIKJEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x75D0670", Offset = "0x75CF670", VA = "0x1875D0670")]
	[AsyncStateMachine(typeof(DLOEPADEADD))]
	private Task LAHPNPBPBKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x75D0760", Offset = "0x75CF760", VA = "0x1875D0760")]
	[AsyncStateMachine(typeof(DMBKIHENJEG))]
	private Task PPEENBBIIFE(bool NNIIFEPANPE, string DEJGJBPGHEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40")]
	private bool OCIAPHEGMDE(bool DGICFBEIAIL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct DGPBHCENJDD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct EGJOPJEMHCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public DGPBHCENJDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x75C6130", Offset = "0x75C5130", VA = "0x1875C6130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x75C66A0", Offset = "0x75C56A0", VA = "0x1875C66A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private sealed class BEEKLEGEADP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public BEEKLEGEADP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x75C0920", Offset = "0x75BF920", VA = "0x1875C0920")]
		internal object JHMFPOPDCHP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct JIBMFOCBPGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public DGPBHCENJDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		private JMBOKLBNKIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x75CF940", Offset = "0x75CE940", VA = "0x1875CF940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x75CFDC0", Offset = "0x75CEDC0", VA = "0x1875CFDC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005BF")]
	private IJNGGLNAAKI KKKEACBFDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C0")]
	private NPOAFBCOAIB<string>.HFMLKGGDOCE FCPMHEOCJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C1")]
	private NDFFAKPPKGI GAIEJGCLEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C2")]
	private bool IKHKDFPBJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005C3")]
	private GAAHBJLKBPP CONAFKKIHKL;

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x75C4420", Offset = "0x75C3420", VA = "0x1875C4420")]
	public static Task<Scene> NHDLPHINDIF(NDFFAKPPKGI GAIEJGCLEHG, IJNGGLNAAKI DCMAFMOMKFH, NPOAFBCOAIB<string>.HFMLKGGDOCE FCPMHEOCJMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x75C4300", Offset = "0x75C3300", VA = "0x1875C4300")]
	[AsyncStateMachine(typeof(EGJOPJEMHCB))]
	private Task<Scene> LAHPNPBPBKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x75C42D0", Offset = "0x75C32D0", VA = "0x1875C42D0")]
	private bool DDKKPFHMOBH(GAAHBJLKBPP CONAFKKIHKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x75C4260", Offset = "0x75C3260", VA = "0x1875C4260")]
	private void AMIMKBOBFHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x75C44A0", Offset = "0x75C34A0", VA = "0x1875C44A0")]
	[AsyncStateMachine(typeof(JIBMFOCBPGF))]
	private Task<Scene> PPEENBBIIFE(string DEJGJBPGHEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal struct FKHKEECKICD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private struct BAEDKOHPOJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public AsyncTaskMethodBuilder<GDNCNIBJNMK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public FKHKEECKICD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public GDNCNIBJNMK nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public GAAHBJLKBPP deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		private TaskAwaiter<GDNCNIBJNMK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x75BFDB0", Offset = "0x75BEDB0", VA = "0x1875BFDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x75C08B0", Offset = "0x75BF8B0", VA = "0x1875C08B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private struct BHAIFECNHJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public AsyncTaskMethodBuilder<GDNCNIBJNMK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public FKHKEECKICD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public GDNCNIBJNMK state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private TaskAwaiter<MELJGKFCAHJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x75C0C70", Offset = "0x75BFC70", VA = "0x1875C0C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x75C0F50", Offset = "0x75BFF50", VA = "0x1875C0F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	private readonly IEGLONMBGEN AADLMFJNHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	private readonly DFJODANGFCB EMONDMHOGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D2")]
	private readonly NPPJMKCOMHB DHNKFAANBCG;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private JMFJELLGOJH MPIGFDGDADF
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x5CC8730", Offset = "0x5CC7730", VA = "0x185CC8730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x75CAC60", Offset = "0x75C9C60", VA = "0x1875CAC60")]
	public FKHKEECKICD(IEGLONMBGEN AADLMFJNHJD, DFJODANGFCB EMONDMHOGFB, NPPJMKCOMHB DHNKFAANBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x75CAAE0", Offset = "0x75C9AE0", VA = "0x1875CAAE0")]
	[AsyncStateMachine(typeof(BAEDKOHPOJK))]
	public Task<GDNCNIBJNMK> NCBDADIOOOD(GDNCNIBJNMK CBAKBIDONIO, GAAHBJLKBPP NCJBJNMKCCH, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI, bool LFMAOOIJEDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x75CA950", Offset = "0x75C9950", VA = "0x1875CA950")]
	[AsyncStateMachine(typeof(BHAIFECNHJI))]
	private Task<GDNCNIBJNMK> INLGMIKEKLI(NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, GDNCNIBJNMK LNHGKEAKACI, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x75CAAB0", Offset = "0x75C9AB0", VA = "0x1875CAAB0")]
	private bool MAICEJHLNOB(GDNCNIBJNMK GAEENPFJJIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x75CA930", Offset = "0x75C9930", VA = "0x1875CA930")]
	private void CDMGIBILAAG(string PAPKMHJKCLN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000161")]
internal struct NHMFFKDCOHB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct NFOEFONHMBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public JMFJELLGOJH operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public GAAHBJLKBPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public JGPCKPACCNF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private JMBOKLBNKIG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private List<(PersistenceView, KGIKLNIIDMO)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private (PersistenceView, KGIKLNIIDMO) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x75D2E70", Offset = "0x75D1E70", VA = "0x1875D2E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x75D34C0", Offset = "0x75D24C0", VA = "0x1875D34C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x75D3860", Offset = "0x75D2860", VA = "0x1875D3860")]
	[AsyncStateMachine(typeof(NFOEFONHMBA))]
	public static Task LAHPNPBPBKK(JMFJELLGOJH HBPGOBBKEPK, GAAHBJLKBPP CONAFKKIHKL, JGPCKPACCNF DCHMNKJPJPJ, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal struct IABLPNEAHDF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private struct FOJLIMOFFKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public JMFJELLGOJH operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public GAAHBJLKBPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public JGPCKPACCNF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private PMEDDBIJCLE <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		private JMBOKLBNKIG <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private List<(PersistenceView, KGIKLNIIDMO)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private KGIKLNIIDMO <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x75CADE0", Offset = "0x75C9DE0", VA = "0x1875CADE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x75CB690", Offset = "0x75CA690", VA = "0x1875CB690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x75CE540", Offset = "0x75CD540", VA = "0x1875CE540")]
	[AsyncStateMachine(typeof(FOJLIMOFFKM))]
	public static Task LAHPNPBPBKK(JMFJELLGOJH HBPGOBBKEPK, GAAHBJLKBPP CONAFKKIHKL, JGPCKPACCNF DCHMNKJPJPJ, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
internal struct MDJAEKECPNK
{
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	public struct HNHMICFBACC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public List<FIPIAHAGJDH> FKHDAHAPFOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public List<KGIKLNIIDMO> INCOAGOABAP;

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0xE8C760", Offset = "0xE8B760", VA = "0x180E8C760")]
		public HNHMICFBACC(List<FIPIAHAGJDH> FKHDAHAPFOP, List<KGIKLNIIDMO> INCOAGOABAP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private sealed class GDECILDFCIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public IEnumerable<FIPIAHAGJDH> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public GDECILDFCIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x75CBF70", Offset = "0x75CAF70", VA = "0x1875CBF70")]
		internal object CEHLDBPPEJK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005FF")]
	private NDFFAKPPKGI GAIEJGCLEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000600")]
	private GAAHBJLKBPP CONAFKKIHKL;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private BJLINKIKEOI PAMCFEMCNIH
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x75D1D70", Offset = "0x75D0D70", VA = "0x1875D1D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x75D2530", Offset = "0x75D1530", VA = "0x1875D2530")]
	public static HNHMICFBACC LAHPNPBPBKK(NDFFAKPPKGI GAIEJGCLEHG, GAAHBJLKBPP CONAFKKIHKL)
	{
		return default(HNHMICFBACC);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x75D2590", Offset = "0x75D1590", VA = "0x1875D2590")]
	private HNHMICFBACC LAHPNPBPBKK()
	{
		return default(HNHMICFBACC);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x75D1F90", Offset = "0x75D0F90", VA = "0x1875D1F90")]
	private HNHMICFBACC JIPKANHMHEM(MEGLOJMOHAP MFJLOFOELBM, PMEDDBIJCLE POFDAGBFGME)
	{
		return default(HNHMICFBACC);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x75D1DC0", Offset = "0x75D0DC0", VA = "0x1875D1DC0")]
	private bool CGEEEMONLIN(IEnumerable<FIPIAHAGJDH> FKHDAHAPFOP)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal struct IJFKNKPPMOH
{
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class PLCKFDBOOIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public MDJAEKECPNK.HNHMICFBACC instantiations;

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public PLCKFDBOOIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x75D6200", Offset = "0x75D5200", VA = "0x1875D6200")]
		internal object PCNIMFPLGBA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private sealed class CMBBANMKEGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public CMBBANMKEGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x75C3810", Offset = "0x75C2810", VA = "0x1875C3810")]
		internal object ABIILFPPCJO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x75CEBC0", Offset = "0x75CDBC0", VA = "0x1875CEBC0")]
	public static void LAHPNPBPBKK(JMFJELLGOJH HBPGOBBKEPK, GAAHBJLKBPP CONAFKKIHKL, MDJAEKECPNK.HNHMICFBACC LCHIICODDMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
internal class NPPJMKCOMHB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct PJEJNMJAEGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public NPPJMKCOMHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public GDNCNIBJNMK operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public GAAHBJLKBPP deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x75D5A30", Offset = "0x75D4A30", VA = "0x1875D5A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x75D61A0", Offset = "0x75D51A0", VA = "0x1875D61A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class OLNMPNFLKML
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016E")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000615")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000616")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000617")]
			public OLNMPNFLKML <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000618")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000619")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x75D7270", Offset = "0x75D6270", VA = "0x1875D7270", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x75D7530", Offset = "0x75D6530", VA = "0x1875D7530", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public NPPJMKCOMHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public GAAHBJLKBPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public OLNMPNFLKML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x75D5880", Offset = "0x75D4880", VA = "0x1875D5880")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task LGEMHIGMJHO(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct HBGBCCEPHFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public NPPJMKCOMHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public GAAHBJLKBPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private OLNMPNFLKML <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x75CD0C0", Offset = "0x75CC0C0", VA = "0x1875CD0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x75CD5F0", Offset = "0x75CC5F0", VA = "0x1875CD5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct EPJAKDNCHFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public NPPJMKCOMHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public GAAHBJLKBPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		private Dictionary<Guid, List<EGFDFDBABAP>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x75C81D0", Offset = "0x75C71D0", VA = "0x1875C81D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x75C87E0", Offset = "0x75C77E0", VA = "0x1875C87E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private struct FCNEOLLDAFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public NPPJMKCOMHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public GAAHBJLKBPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		private Dictionary<Guid, List<EGFDFDBABAP>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x75C8CF0", Offset = "0x75C7CF0", VA = "0x1875C8CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x75C9390", Offset = "0x75C8390", VA = "0x1875C9390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private sealed class GMFDGNPBDBF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000173")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000639")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400063A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400063B")]
			public EGFDFDBABAP handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400063C")]
			public GMFDGNPBDBF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400063D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0x75D7070", Offset = "0x75D6070", VA = "0x1875D7070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DA")]
			[Cpp2IlInjected.Address(RVA = "0x75D7210", Offset = "0x75D6210", VA = "0x1875D7210", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public APNALELFGOP runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public List<EGFDFDBABAP> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public GAAHBJLKBPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public GMFDGNPBDBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x75CC7E0", Offset = "0x75CB7E0", VA = "0x1875CC7E0")]
		internal object HOPPINGCKGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x75CC8D0", Offset = "0x75CB8D0", VA = "0x1875CC8D0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task PDJIIIJNEAL(EGFDFDBABAP handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x75CC6F0", Offset = "0x75CB6F0", VA = "0x1875CC6F0")]
		internal object FGHHLPHDKLL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private struct LALOLLIELAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public APNALELFGOP runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public List<EGFDFDBABAP> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public GAAHBJLKBPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		private GMFDGNPBDBF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x75D0F50", Offset = "0x75CFF50", VA = "0x1875D0F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x75D1420", Offset = "0x75D0420", VA = "0x1875D1420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private struct MKJPKIKKAHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public NPPJMKCOMHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public GAAHBJLKBPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x75D27E0", Offset = "0x75D17E0", VA = "0x1875D27E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x75D2DA0", Offset = "0x75D1DA0", VA = "0x1875D2DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private sealed class OMCOPLEDKIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public OMCOPLEDKIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x75D5970", Offset = "0x75D4970", VA = "0x1875D5970")]
		internal object NBFBLONKMEK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private struct DJHOHJFACNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public NPPJMKCOMHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public GAAHBJLKBPP data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		private JMBOKLBNKIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x75C45F0", Offset = "0x75C35F0", VA = "0x1875C45F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x75C4AB0", Offset = "0x75C3AB0", VA = "0x1875C4AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private sealed class OFGFDGBCHNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public OFGFDGBCHNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x75D5390", Offset = "0x75D4390", VA = "0x1875D5390")]
		internal object IEFBEAMNPNE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private struct JGDNPCPCMHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public NPPJMKCOMHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private JMBOKLBNKIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		private TaskAwaiter<MELJGKFCAHJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x75CF2B0", Offset = "0x75CE2B0", VA = "0x1875CF2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x75CF8E0", Offset = "0x75CE8E0", VA = "0x1875CF8E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private sealed class IJFADLPIFIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public IJFADLPIFIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x75CEB50", Offset = "0x75CDB50", VA = "0x1875CEB50")]
		internal object KNOFJPHLFMH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000607")]
	private readonly IEGLONMBGEN AADLMFJNHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000608")]
	private EAJGBJHKECJ DHNKFAANBCG;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private JMFJELLGOJH MPIGFDGDADF
	{
		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0xCE1240", Offset = "0xCE0240", VA = "0x180CE1240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
	public NPPJMKCOMHB(IEGLONMBGEN AADLMFJNHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x75D4490", Offset = "0x75D3490", VA = "0x1875D4490")]
	[AsyncStateMachine(typeof(PJEJNMJAEGO))]
	public Task LAHPNPBPBKK(GDNCNIBJNMK LIODBJBFMDO, GAAHBJLKBPP NCJBJNMKCCH, NPOAFBCOAIB<string>.HFMLKGGDOCE FCPMHEOCJMB, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x75D4730", Offset = "0x75D3730", VA = "0x1875D4730")]
	[AsyncStateMachine(typeof(HBGBCCEPHFM))]
	private Task MGFPPJOFIKJ(GAAHBJLKBPP CONAFKKIHKL, NPOAFBCOAIB<string>.HFMLKGGDOCE FCPMHEOCJMB, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x75D4180", Offset = "0x75D3180", VA = "0x1875D4180")]
	[AsyncStateMachine(typeof(EPJAKDNCHFE))]
	private Task DCDKPAMOPNL(GAAHBJLKBPP CONAFKKIHKL, NPOAFBCOAIB<string>.HFMLKGGDOCE FCPMHEOCJMB, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x75D3D10", Offset = "0x75D2D10", VA = "0x1875D3D10")]
	[AsyncStateMachine(typeof(FCNEOLLDAFE))]
	private Task AONGCEOIOLO(GAAHBJLKBPP CONAFKKIHKL, NPOAFBCOAIB<string>.HFMLKGGDOCE FCPMHEOCJMB, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x75D45E0", Offset = "0x75D35E0", VA = "0x1875D45E0")]
	[AsyncStateMachine(typeof(LALOLLIELAC))]
	private Task LJBEAEGENPC(Guid PAHENMCEKHG, List<EGFDFDBABAP> HAMLIMOPMEA, APNALELFGOP BOPMMOANGNF, GAAHBJLKBPP CONAFKKIHKL, CancellationToken NANMDIJGGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x75D4040", Offset = "0x75D3040", VA = "0x1875D4040")]
	[AsyncStateMachine(typeof(MKJPKIKKAHB))]
	private Task CEKJJAGKMGM(GAAHBJLKBPP CONAFKKIHKL, NPOAFBCOAIB<string>.HFMLKGGDOCE FCPMHEOCJMB, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x75D3E50", Offset = "0x75D2E50", VA = "0x1875D3E50")]
	[AsyncStateMachine(typeof(DJHOHJFACNK))]
	private Task BKGENPPPADG(Guid HPPGPMDGIOE, GAAHBJLKBPP CONAFKKIHKL, NPOAFBCOAIB<string>.HFMLKGGDOCE FCPMHEOCJMB, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x75D4870", Offset = "0x75D3870", VA = "0x1875D4870")]
	[AsyncStateMachine(typeof(JGDNPCPCMHJ))]
	private Task OLDNKPJGMJO(Guid HPPGPMDGIOE, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x75D49B0", Offset = "0x75D39B0", VA = "0x1875D49B0")]
	private void PJPMLJPECHG(Guid HPPGPMDGIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x75D3F90", Offset = "0x75D2F90", VA = "0x1875D3F90")]
	private void BMPCCOHHBJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x75D3B80", Offset = "0x75D2B80", VA = "0x1875D3B80")]
	public Guid AIMOLDJLDFD(GDNCNIBJNMK EJFJHDCPBAO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x75D42C0", Offset = "0x75D32C0", VA = "0x1875D42C0")]
	[CompilerGenerated]
	private object JGPBAIAKFPM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
internal struct NMCMOELGOAP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct GLMFAMMAOOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public NMCMOELGOAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private IEnumerator<MJJDDOEJJFG> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x75CBFF0", Offset = "0x75CAFF0", VA = "0x1875CBFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x75CC690", Offset = "0x75CB690", VA = "0x1875CC690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000665")]
	private BJLINKIKEOI LAFNKOLGHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000666")]
	private NPOAFBCOAIB<string>.HFMLKGGDOCE FCPMHEOCJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000667")]
	private CancellationToken CLIKNEKJHEI;

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x75D39A0", Offset = "0x75D29A0", VA = "0x1875D39A0")]
	public static Task ECMIFDDKICB(BJLINKIKEOI LAFNKOLGHIB, NPOAFBCOAIB<string>.HFMLKGGDOCE FCPMHEOCJMB, CancellationToken EKJCJBIKJEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x75D3A10", Offset = "0x75D2A10", VA = "0x1875D3A10")]
	[AsyncStateMachine(typeof(GLMFAMMAOOH))]
	private Task LAHPNPBPBKK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
public readonly struct BDJMLMAMKGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	public readonly bool AJGFOPKLIPA;

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x24BC480", Offset = "0x24BB480", VA = "0x1824BC480")]
	public BDJMLMAMKGL(bool LBFPDKEFPPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
public readonly struct APNIAAHHPPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066F")]
	public readonly MEGLOJMOHAP? LENDAJAKEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000670")]
	public readonly HKGFMNENEAB DHBBDGMPEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	public readonly string? MLNAJKCBPOJ;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public IReadOnlyCollection<string> FKEGOACHKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x75BFC90", Offset = "0x75BEC90", VA = "0x1875BFC90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public IReadOnlyDictionary<long, int> KFFLMCKEJNN
	{
		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x75BFC70", Offset = "0x75BEC70", VA = "0x1875BFC70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x75BFCB0", Offset = "0x75BECB0", VA = "0x1875BFCB0")]
	public APNIAAHHPPH(MEGLOJMOHAP? EBLANDLJNLN, HKGFMNENEAB IFBKIGFGDOF, string? HABIMNBKOCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class EJJBDNIDCMO : OPHIOOFODOB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct CCNNCOHJDGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public AsyncTaskMethodBuilder<APNIAAHHPPH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public EJJBDNIDCMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public HGLLLDPICKK serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public KHAOILFELCE roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		private JMBOKLBNKIG <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x75C3120", Offset = "0x75C2120", VA = "0x1875C3120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x75C37A0", Offset = "0x75C27A0", VA = "0x1875C37A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class PNEEOBECEPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public HGLLLDPICKK serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public EJJBDNIDCMO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public PNEEOBECEPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x75D6D80", Offset = "0x75D5D80", VA = "0x1875D6D80")]
		internal Task DKLPDCJMLEK(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x75D6F90", Offset = "0x75D5F90", VA = "0x1875D6F90")]
		internal Task HIGOJKLOECO(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class NDBLKPJCHBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public PNEEOBECEPN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public NDBLKPJCHBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x75D2E00", Offset = "0x75D1E00", VA = "0x1875D2E00")]
		internal object ELBLGELPIOO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private sealed class LLPIKCLAONJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public PNEEOBECEPN CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public LLPIKCLAONJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x75D1AC0", Offset = "0x75D0AC0", VA = "0x1875D1AC0")]
		internal Task DOINHIKDGHG(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private struct FFLDJPPFHML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public HGLLLDPICKK serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public EJJBDNIDCMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		private NDBLKPJCHBF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		private JMBOKLBNKIG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x75C9980", Offset = "0x75C8980", VA = "0x1875C9980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x75CA1E0", Offset = "0x75C91E0", VA = "0x1875CA1E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000672")]
	private readonly CDBONJBDMGH IKKEHAGICFD;

	[Cpp2IlInjected.Token(Token = "0x4000673")]
	private static readonly TimeSpan IFBFIMHJNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	private readonly CAKHDHJNCMD CKHJHKDHDJO;

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x75C7810", Offset = "0x75C6810", VA = "0x1875C7810")]
	public EJJBDNIDCMO(IEGLONMBGEN AADLMFJNHJD, CAKHDHJNCMD CKHJHKDHDJO, CDBONJBDMGH IKKEHAGICFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x75C6CE0", Offset = "0x75C5CE0", VA = "0x1875C6CE0")]
	[AsyncStateMachine(typeof(CCNNCOHJDGL))]
	public Task<APNIAAHHPPH> EKFEJLFJOKC(long PDLBLPPCJKC, KHAOILFELCE MHDGHCKINHD, HGLLLDPICKK LOIODDCFEOI, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x75C6BA0", Offset = "0x75C5BA0", VA = "0x1875C6BA0")]
	[AsyncStateMachine(typeof(FFLDJPPFHML))]
	private Task EJOAEOJNNGP(HGLLLDPICKK LOIODDCFEOI, IEnumerable<PersistenceView> FBHEJKKKMFL, StringBuilder JFGAAFFCLCL, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x75C6E40", Offset = "0x75C5E40", VA = "0x1875C6E40")]
	private APNIAAHHPPH FKDJLLAOPMJ(long PDLBLPPCJKC, KHAOILFELCE MHDGHCKINHD, HGLLLDPICKK LOIODDCFEOI, IEnumerable<PersistenceView> FBHEJKKKMFL, StringBuilder JFGAAFFCLCL)
	{
		return default(APNIAAHHPPH);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x75C7650", Offset = "0x75C6650", VA = "0x1875C7650")]
	private MEGLOJMOHAP MFCCBGBPOJK(long PDLBLPPCJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x75C7400", Offset = "0x75C6400", VA = "0x1875C7400")]
	private void LAHCGACKALH(MEGLOJMOHAP FMPDLEPAFOK, StringBuilder JFGAAFFCLCL, IEnumerable<PersistenceView> FBHEJKKKMFL, [In] MJIBNOBNJIH DKKAILAIDCO, MDLEJLBEGJJ LHPIEFMJMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x75C6710", Offset = "0x75C5710", VA = "0x1875C6710")]
	private void AGLDMCBGFCJ(MEGLOJMOHAP FMPDLEPAFOK, StringBuilder JFGAAFFCLCL, PersistenceView NJFNPGALOJK, MDLEJLBEGJJ LHPIEFMJMFF, [In] MJIBNOBNJIH DKKAILAIDCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
internal class HPBFIFDAEJF : OPHIOOFODOB
{
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private sealed class PELPCBOEDIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public FMDNIBANCGK.ELIBJFNAEOD roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public PELPCBOEDIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x75D59E0", Offset = "0x75D49E0", VA = "0x1875D59E0")]
		internal object OKFFOJLJKDM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private struct OAJMPCOGAEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public AsyncTaskMethodBuilder<(FMDNIBANCGK.ELIBJFNAEOD roomDataUpload, FMDNIBANCGK.ELIBJFNAEOD subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		public APNIAAHHPPH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public HPBFIFDAEJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private PELPCBOEDIB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		private TaskAwaiter<FMDNIBANCGK.ELIBJFNAEOD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x75D4AC0", Offset = "0x75D3AC0", VA = "0x1875D4AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x75D5320", Offset = "0x75D4320", VA = "0x1875D5320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private struct HAPDKNJDHNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public AsyncTaskMethodBuilder<PNDDKICJKKP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public HPBFIFDAEJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public APNIAAHHPPH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public MMJLHMCGMEI roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		private TaskAwaiter<(FMDNIBANCGK.ELIBJFNAEOD roomDataUpload, FMDNIBANCGK.ELIBJFNAEOD subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		private TaskAwaiter<PNDDKICJKKP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x75CC9C0", Offset = "0x75CB9C0", VA = "0x1875CC9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x75CD050", Offset = "0x75CC050", VA = "0x1875CD050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private struct OJICJNJBHPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public AsyncTaskMethodBuilder<FEPJAEOAPIH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public HPBFIFDAEJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public APNIAAHHPPH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		private TaskAwaiter<(FMDNIBANCGK.ELIBJFNAEOD roomDataUpload, FMDNIBANCGK.ELIBJFNAEOD subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private TaskAwaiter<FEPJAEOAPIH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x75D5400", Offset = "0x75D4400", VA = "0x1875D5400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x75D5810", Offset = "0x75D4810", VA = "0x1875D5810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class BGOGHJKPOEI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200018D")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006C0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006C1")]
			public AsyncTaskMethodBuilder<MELJGKFCAHJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006C2")]
			public BGOGHJKPOEI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006C3")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006C4")]
			private MELJGKFCAHJ <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006C5")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006C6")]
			private TaskAwaiter<FEPJAEOAPIH> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006C7")]
			private TaskAwaiter<PNDDKICJKKP> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006C8")]
			private TaskAwaiter<MELJGKFCAHJ> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0x75D7980", Offset = "0x75D6980", VA = "0x1875D7980", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061F")]
			[Cpp2IlInjected.Address(RVA = "0x75D8900", Offset = "0x75D7900", VA = "0x1875D8900", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public HPBFIFDAEJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public APNIAAHHPPH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public MMJLHMCGMEI roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public BDJMLMAMKGL roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public BGOGHJKPOEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x75C0970", Offset = "0x75BF970", VA = "0x1875C0970")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<MELJGKFCAHJ> INBAJJHOINN(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private struct IFOFOEBBHNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		public AsyncTaskMethodBuilder<MELJGKFCAHJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public HPBFIFDAEJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public APNIAAHHPPH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public MMJLHMCGMEI roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public BDJMLMAMKGL roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		private TaskAwaiter<MELJGKFCAHJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x75CE7D0", Offset = "0x75CD7D0", VA = "0x1875CE7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x75CEAE0", Offset = "0x75CDAE0", VA = "0x1875CEAE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private static readonly CDBONJBDMGH IKKEHAGICFD;

	[Cpp2IlInjected.Token(Token = "0x4000698")]
	private static readonly CDBONJBDMGH PJJEAGJIKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000699")]
	private readonly LLBIHPPACPN BINNPDPCHJM;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	private NDFFAKPPKGI MMDKFLKIJGL
	{
		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x75AD7C0", Offset = "0x75AC7C0", VA = "0x1875AD7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x75CE4B0", Offset = "0x75CD4B0", VA = "0x1875CE4B0")]
	public HPBFIFDAEJF(IEGLONMBGEN AADLMFJNHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x75CDE60", Offset = "0x75CCE60", VA = "0x1875CDE60")]
	[AsyncStateMachine(typeof(OAJMPCOGAEN))]
	private Task<(FMDNIBANCGK.ELIBJFNAEOD, FMDNIBANCGK.ELIBJFNAEOD)> BMJHDJALJOI(APNIAAHHPPH DDPKEDDGOEO, long AHNLEKFKAGC, long ABKHIAFPEJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x75CE110", Offset = "0x75CD110", VA = "0x1875CE110")]
	[AsyncStateMachine(typeof(HAPDKNJDHNJ))]
	public Task<PNDDKICJKKP> LDDOLPADNPN(int ILCJANKFAMK, [CanBeNull] MMJLHMCGMEI BMGCMOIFIKB, APNIAAHHPPH DDPKEDDGOEO, long AHNLEKFKAGC, long ABKHIAFPEJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x75CDFA0", Offset = "0x75CCFA0", VA = "0x1875CDFA0")]
	[AsyncStateMachine(typeof(OJICJNJBHPO))]
	private Task<FEPJAEOAPIH> ICGBALMMGOK(string PBJMLELNKLD, int ILCJANKFAMK, APNIAAHHPPH DDPKEDDGOEO, long AHNLEKFKAGC, long ABKHIAFPEJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x75CE280", Offset = "0x75CD280", VA = "0x1875CE280")]
	[AsyncStateMachine(typeof(IFOFOEBBHNN))]
	public Task<MELJGKFCAHJ> LOPMOJIKOBC(int ILCJANKFAMK, MMJLHMCGMEI? BMGCMOIFIKB, APNIAAHHPPH DDPKEDDGOEO, long AHNLEKFKAGC, long ABKHIAFPEJM, BDJMLMAMKGL ECFOOHBJAFO, NPOAFBCOAIB<string>.HFMLKGGDOCE HHBKLOANIBO, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
public abstract class FKEFBNPGOIG<T> where T : FKEFBNPGOIG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D5")]
	internal readonly NDFFAKPPKGI JKOPEBBOMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D6")]
	private int? FJKJLAKOOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D7")]
	protected readonly Guid GFAHNAHMKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	protected readonly OCIBBNFFMGC PGJOKDHDBAG;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	protected T PPKANLMHACA
	{
		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x400D4B0", Offset = "0x400C4B0", VA = "0x18400D4B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x400D6A0", Offset = "0x400C6A0", VA = "0x18400D6A0")]
	internal FKEFBNPGOIG(NDFFAKPPKGI JIOAEIIJLNO, OCIBBNFFMGC JKDKBHMNLIK, [Optional] Guid? HIKJHHIHDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x400D5C0", Offset = "0x400C5C0", VA = "0x18400D5C0")]
	private MELJGKFCAHJ NBEADNLCGBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "4")]
	protected virtual void ACPNBCMPCOF(MELJGKFCAHJ ABHPFCOODAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x400D390", Offset = "0x400C390", VA = "0x18400D390")]
	public T COPJHHBCOGB(NKLIIMCFHAI FOMGKNFCKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x400D510", Offset = "0x400C510", VA = "0x18400D510")]
	public T LBLBJDKNOHJ(int COIOBKKFPJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x400D260", Offset = "0x400C260", VA = "0x18400D260", Slot = "5")]
	public virtual Task<JECONNLHJLM> CIMIPOOHJOE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public class LCKKNCFGDNL : FKEFBNPGOIG<LCKKNCFGDNL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	private AICBJAIGANE NDBAHEIEDNL;

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x75D19F0", Offset = "0x75D09F0", VA = "0x1875D19F0")]
	internal LCKKNCFGDNL(NDFFAKPPKGI JIOAEIIJLNO, OCIBBNFFMGC JKDKBHMNLIK, [Optional] Guid? HIKJHHIHDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6520", Offset = "0x6AA5520", VA = "0x186AA6520")]
	public LCKKNCFGDNL HEMBMMGJFOA(AICBJAIGANE NDBAHEIEDNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x75D1920", Offset = "0x75D0920", VA = "0x1875D1920", Slot = "4")]
	protected override void ACPNBCMPCOF(MELJGKFCAHJ ABHPFCOODAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
public class JKOJDPOHFGC : FKEFBNPGOIG<JKOJDPOHFGC>
{
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	internal enum COFMJOMBNBO
	{
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private struct AJEDAADIEMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public AsyncTaskMethodBuilder<JECONNLHJLM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		public JKOJDPOHFGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		private TaskAwaiter<JECONNLHJLM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x75BF3D0", Offset = "0x75BE3D0", VA = "0x1875BF3D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x75BF770", Offset = "0x75BE770", VA = "0x1875BF770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	private COFMJOMBNBO AIFFJPGGIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private string KFJHMDKIHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	private MMJLHMCGMEI NDBAHEIEDNL;

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x75D0490", Offset = "0x75CF490", VA = "0x1875D0490")]
	internal JKOJDPOHFGC(NDFFAKPPKGI JIOAEIIJLNO, OCIBBNFFMGC JKDKBHMNLIK, [Optional] Guid? HIKJHHIHDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x75D02E0", Offset = "0x75CF2E0", VA = "0x1875D02E0")]
	public JKOJDPOHFGC BFOMCOPENCA(string GOFABEAKLNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x75D0440", Offset = "0x75CF440", VA = "0x1875D0440")]
	public JKOJDPOHFGC ILBMBLKHEFJ(bool NEEPNGDDBOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x75D0460", Offset = "0x75CF460", VA = "0x1875D0460")]
	public JKOJDPOHFGC MONKNMAANMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x75D0170", Offset = "0x75CF170", VA = "0x1875D0170", Slot = "4")]
	protected override void ACPNBCMPCOF(MELJGKFCAHJ ABHPFCOODAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x75D0310", Offset = "0x75CF310", VA = "0x1875D0310", Slot = "5")]
	[AsyncStateMachine(typeof(AJEDAADIEMP))]
	public override Task<JECONNLHJLM> CIMIPOOHJOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x75D0400", Offset = "0x75CF400", VA = "0x1875D0400")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<JECONNLHJLM> HOEHGKJHJOH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
internal static class BGPKNKCHNKK
{
	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x75C0B20", Offset = "0x75BFB20", VA = "0x1875C0B20")]
	public static void NAAKPADANNI(this ICGKNEKHLMH PEEJPLOENID, DACBMNFKIFK GCDLLOJCOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x75C0AA0", Offset = "0x75BFAA0", VA = "0x1875C0AA0")]
	public static void KHJIOKMPJOK(this DACBMNFKIFK NFDMLIINBHB, [Optional] string ABHPFCOODAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
public static class IAKENOBCGPM
{
	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x75CE730", Offset = "0x75CD730", VA = "0x1875CE730")]
	public static LMNKCNKLBML FMCKEFOEIML(this MKEGMGKNGKO NCHBBNNCJNE)
	{
		return default(LMNKCNKLBML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x75CE680", Offset = "0x75CD680", VA = "0x1875CE680")]
	public static MKEGMGKNGKO CECEDMFJECC(this LMNKCNKLBML JGDHPFLCHMG)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000197")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006E9")]
			public DFPKDJHLGGI ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006EA")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006EB")]
			public DFPKDJHLGGI HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006EC")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006ED")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006EE")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		private static DFPKDJHLGGI[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private Dictionary<DFPKDJHLGGI, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x75D8E50", Offset = "0x75D7E50", VA = "0x1875D8E50")]
		public bool ABCLMABBAJI(DFPKDJHLGGI IDOMJPIHNHG, [Out] ResultConfig CLGKEAHKEGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x75D8EC0", Offset = "0x75D7EC0", VA = "0x1875D8EC0")]
		public ResultConfig LOLKJFAGNPJ(DFPKDJHLGGI BMAADIIMEEA, [Optional] HashSet<DFPKDJHLGGI> OMHFBJDCMGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x75D9530", Offset = "0x75D8530", VA = "0x1875D9530", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x75D9000", Offset = "0x75D8000", VA = "0x1875D9000", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x976580", Offset = "0x975580", VA = "0x180976580")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
public class EPNNNPFFFAE : IHHBGHBEOLK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private struct HKGENHIHKBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public EPNNNPFFFAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x75DC850", Offset = "0x75DB850", VA = "0x1875DC850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x75DC9E0", Offset = "0x75DB9E0", VA = "0x1875DC9E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private struct HJHEOLAHPCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		public NPOAFBCOAIB<string>.HFMLKGGDOCE timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		public IHHBGHBEOLK preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		private NPOAFBCOAIB<string>.HFMLKGGDOCE <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x75DC2D0", Offset = "0x75DB2D0", VA = "0x1875DC2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x75DC7F0", Offset = "0x75DB7F0", VA = "0x1875DC7F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006F4")]
	private readonly LAJFJHBKBCB IEIIAJBMGBM;

	[Cpp2IlInjected.Token(Token = "0x40006F5")]
	private static readonly CDBONJBDMGH IKKEHAGICFD;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public string NMOEDCCMEOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x75C8840", Offset = "0x75C7840", VA = "0x1875C8840", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x75C8980", Offset = "0x75C7980", VA = "0x1875C8980")]
	[AEDCCIMPEFD.GIGKNHONDJE.KBDJNGCKNKK]
	internal static void MHIJNHBLKEJ(MAONAIOKEHK OLAHEEDNGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
	[RecRoom.NoEngine.Common.Preserve]
	public EPNNNPFFFAE([GAHPILLNNBL(null)] LAJFJHBKBCB IEIIAJBMGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x75C8870", Offset = "0x75C7870", VA = "0x1875C8870", Slot = "5")]
	[AsyncStateMachine(typeof(HKGENHIHKBC))]
	public Task LAHPNPBPBKK(NPOAFBCOAIB<string>.HFMLKGGDOCE ONBOJLEJFNB, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x75C8A80", Offset = "0x75C7A80", VA = "0x1875C8A80")]
	[AsyncStateMachine(typeof(HJHEOLAHPCB))]
	private Task OFMJBIOLFMF(IHHBGHBEOLK GKELIIIBCBA, NPOAFBCOAIB<string>.HFMLKGGDOCE ONBOJLEJFNB, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
public interface LAJFJHBKBCB : IHHBGHBEOLK
{
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
public interface IHHBGHBEOLK
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	string NMOEDCCMEOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LAHPNPBPBKK(NPOAFBCOAIB<string>.HFMLKGGDOCE ONBOJLEJFNB, CancellationToken CLIKNEKJHEI);
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
public static class PKLOGMCHIMK
{
	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x75DEC10", Offset = "0x75DDC10", VA = "0x1875DEC10")]
	[AEDCCIMPEFD.GIGKNHONDJE.KBDJNGCKNKK]
	internal static void LPMGDCHBOCO(MAONAIOKEHK OLAHEEDNGNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
public interface DDMELBGCFHO : IEquatable<DDMELBGCFHO>
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	DateTime KEMFMBPEACA
	{
		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LJGJHCEJOJC();

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JKHKGJNMKIJ(long AHNLEKFKAGC, long PDLBLPPCJKC, [Out] APNIAAHHPPH DDPKEDDGOEO);
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
internal class KEDOOPMLAMM : HICNBKJEEFO
{
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	[CompilerGenerated]
	private sealed class CMLEJHKLNFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public FJAPFOIPONE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public CMLEJHKLNFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x75DA7C0", Offset = "0x75D97C0", VA = "0x1875DA7C0")]
		internal object PHKJLGFHOCP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000703")]
	private readonly NJBDFHANJLO OAAFKBPNPMA;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<DDMELBGCFHO> HPCJECBCHMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x75DDCD0", Offset = "0x75DCCD0", VA = "0x1875DDCD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x75DE010", Offset = "0x75DD010", VA = "0x1875DE010", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
	[UnityEngine.Scripting.Preserve]
	public KEDOOPMLAMM([GAHPILLNNBL(null)] NJBDFHANJLO OAAFKBPNPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x75DE590", Offset = "0x75DD590", VA = "0x1875DE590", Slot = "6")]
	public bool PGDAMKEIEDK(long AHNLEKFKAGC, long PDLBLPPCJKC, APNIAAHHPPH DDPKEDDGOEO, FJAPFOIPONE PFCJJJAILGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0xA20240", Offset = "0xA1F240", VA = "0x180A20240")]
	private void CHGNGDOAHFJ(DDMELBGCFHO BMHPAPNFNDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x75DDD80", Offset = "0x75DCD80", VA = "0x1875DDD80", Slot = "7")]
	public bool CCDOEMELLAB(long AHNLEKFKAGC, long PDLBLPPCJKC, [Out] DDMELBGCFHO CBNDKFAOHGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x75DE4E0", Offset = "0x75DD4E0", VA = "0x1875DE4E0", Slot = "8")]
	public bool LKKABLCLJKD(long AHNLEKFKAGC, long PDLBLPPCJKC, FJAPFOIPONE PFCJJJAILGH, [Out] DDMELBGCFHO CBNDKFAOHGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x75DE0C0", Offset = "0x75DD0C0", VA = "0x1875DE0C0")]
	private void HPAEJKKBLJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x75DDEF0", Offset = "0x75DCEF0", VA = "0x1875DDEF0", Slot = "9")]
	public void EEHPHFJAMFJ(long AHNLEKFKAGC, long PDLBLPPCJKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal abstract class JBGGOENBECH : NJBDFHANJLO
{
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	protected enum LNHLNOACGHK : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[CompilerGenerated]
	private sealed class KBBPFCBAHCN : IEnumerable<DDMELBGCFHO>, IEnumerable, IEnumerator<DDMELBGCFHO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		private DDMELBGCFHO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		public JBGGOENBECH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		private FJAPFOIPONE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		public FJAPFOIPONE <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		private DDMELBGCFHO System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000674")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000676")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x90ECF0", Offset = "0x90DCF0", VA = "0x18090ECF0")]
		[DebuggerHidden]
		public KBBPFCBAHCN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x75DD9A0", Offset = "0x75DC9A0", VA = "0x1875DD9A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x75DDC80", Offset = "0x75DCC80", VA = "0x1875DDC80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x75DDBD0", Offset = "0x75DCBD0", VA = "0x1875DDBD0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DDMELBGCFHO> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x75DDBD0", Offset = "0x75DCBD0", VA = "0x1875DDBD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[CompilerGenerated]
	private sealed class HAHBMJOLMLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public FJAPFOIPONE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public HAHBMJOLMLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x75DC230", Offset = "0x75DB230", VA = "0x1875DC230")]
		internal object OBDAOLDGNKP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[CompilerGenerated]
	private sealed class KNJGIEPOBEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public JBGGOENBECH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public KNJGIEPOBEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x75DE870", Offset = "0x75DD870", VA = "0x1875DE870")]
		internal void CGAAPMJBAOF(KDAFPGMPPEB.MGCBPJOHBII ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000709")]
	private readonly object BNKGFFJKEDP;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	protected string MNDFGGLEKOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x75DD910", Offset = "0x75DC910", VA = "0x1875DD910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public abstract BFKLDICFKCI KMFMDJPCHMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x75DD920", Offset = "0x75DC920", VA = "0x1875DD920")]
	protected JBGGOENBECH([CanBeNull] string FHMCPIJMJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x75DD2E0", Offset = "0x75DC2E0", VA = "0x1875DD2E0", Slot = "5")]
	public bool GBOFCLBKCGL(long AHNLEKFKAGC, long PDLBLPPCJKC, FJAPFOIPONE PFCJJJAILGH, [Out] DDMELBGCFHO BMHPAPNFNDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x75DD4D0", Offset = "0x75DC4D0", VA = "0x1875DD4D0", Slot = "6")]
	[IteratorStateMachine(typeof(KBBPFCBAHCN))]
	public IEnumerable<DDMELBGCFHO> LOMDNLAOODL(FJAPFOIPONE PFCJJJAILGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void ILIFJCOMKPG(Stream FMEMDEDMCAP, long AHNLEKFKAGC, long PDLBLPPCJKC, APNIAAHHPPH DDPKEDDGOEO);

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool APPHHGONGCH(Stream DECLGLIPCJC, long AHNLEKFKAGC, long PDLBLPPCJKC, OIGHCGOLAAD DHMKMENANJJ, [Out] APNIAAHHPPH DDPKEDDGOEO);

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x75DCF70", Offset = "0x75DBF70", VA = "0x1875DCF70", Slot = "7")]
	public DDMELBGCFHO CNGIHBKPAGP(long AHNLEKFKAGC, long PDLBLPPCJKC, APNIAAHHPPH DDPKEDDGOEO, FJAPFOIPONE PFCJJJAILGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo FPGGLEAGKAG(long AHNLEKFKAGC, long PDLBLPPCJKC, FJAPFOIPONE PFCJJJAILGH, LNHLNOACGHK MHCEKKNAGID);

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo KFBEJDDHJPJ(FJAPFOIPONE PFCJJJAILGH, LNHLNOACGHK MHCEKKNAGID);

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x75DCF00", Offset = "0x75DBF00", VA = "0x1875DCF00")]
	protected void AOIIHPOHCMB(KDAFPGMPPEB.MGCBPJOHBII EOOIMKKNNFN, string PAPKMHJKCLN, FileInfo DANFKPHBIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x75DD560", Offset = "0x75DC560", VA = "0x1875DD560")]
	internal bool MGHGGAFGDHB(FileInfo CDPJEEOFBNC, long AHNLEKFKAGC, long PDLBLPPCJKC, [Out] APNIAAHHPPH DDPKEDDGOEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
	private void JIABHEHCAFM(Exception MGAOLPCHOAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
internal class FBECFGKJLEM : JBGGOENBECH
{
	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public override BFKLDICFKCI KMFMDJPCHMA
	{
		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x17FBE10", Offset = "0x17FAE10", VA = "0x1817FBE10", Slot = "8")]
		get
		{
			return default(BFKLDICFKCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0x75DB320", Offset = "0x75DA320", VA = "0x1875DB320")]
	public FBECFGKJLEM([Optional] string FHMCPIJMJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x75DAF10", Offset = "0x75D9F10", VA = "0x1875DAF10")]
	private void GOCMIPLDBBK(FJAPFOIPONE PFCJJJAILGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x75DAF90", Offset = "0x75D9F90", VA = "0x1875DAF90", Slot = "9")]
	internal override void ILIFJCOMKPG(Stream FMEMDEDMCAP, long AHNLEKFKAGC, long PDLBLPPCJKC, APNIAAHHPPH DDPKEDDGOEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x75DA830", Offset = "0x75D9830", VA = "0x1875DA830", Slot = "10")]
	internal override bool APPHHGONGCH(Stream DECLGLIPCJC, long AHNLEKFKAGC, long PDLBLPPCJKC, OIGHCGOLAAD DHMKMENANJJ, [Out] APNIAAHHPPH DDPKEDDGOEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x75DAE20", Offset = "0x75D9E20", VA = "0x1875DAE20", Slot = "11")]
	protected override FileInfo FPGGLEAGKAG(long AHNLEKFKAGC, long PDLBLPPCJKC, FJAPFOIPONE PFCJJJAILGH, LNHLNOACGHK MHCEKKNAGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x75DB220", Offset = "0x75DA220", VA = "0x1875DB220", Slot = "12")]
	protected override DirectoryInfo KFBEJDDHJPJ(FJAPFOIPONE PFCJJJAILGH, LNHLNOACGHK MHCEKKNAGID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
internal sealed class BMFCOODIEDA : JBGGOENBECH
{
	[Cpp2IlInjected.Token(Token = "0x4000719")]
	private static readonly byte[] MLAECOMLIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400071A")]
	private readonly byte[] NNLFOEFNFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400071B")]
	private readonly byte[] NAPHEJOALKM;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public override BFKLDICFKCI KMFMDJPCHMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x63347D0", Offset = "0x63337D0", VA = "0x1863347D0", Slot = "8")]
		get
		{
			return default(BFKLDICFKCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x75DA6D0", Offset = "0x75D96D0", VA = "0x1875DA6D0")]
	public BMFCOODIEDA([Optional] string FHMCPIJMJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x75DA1C0", Offset = "0x75D91C0", VA = "0x1875DA1C0", Slot = "9")]
	internal override void ILIFJCOMKPG(Stream FMEMDEDMCAP, long AHNLEKFKAGC, long PDLBLPPCJKC, APNIAAHHPPH DDPKEDDGOEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x75D98B0", Offset = "0x75D88B0", VA = "0x1875D98B0", Slot = "10")]
	internal override bool APPHHGONGCH(Stream DECLGLIPCJC, long AHNLEKFKAGC, long PDLBLPPCJKC, OIGHCGOLAAD DHMKMENANJJ, [Out] APNIAAHHPPH DDPKEDDGOEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x75DA470", Offset = "0x75D9470", VA = "0x1875DA470")]
	private void JIKBOIPFGFH(byte[] HPKNAAFAALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x75DA090", Offset = "0x75D9090", VA = "0x1875DA090", Slot = "11")]
	protected override FileInfo FPGGLEAGKAG(long AHNLEKFKAGC, long PDLBLPPCJKC, FJAPFOIPONE PFCJJJAILGH, LNHLNOACGHK MHCEKKNAGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x75DA530", Offset = "0x75D9530", VA = "0x1875DA530", Slot = "12")]
	protected override DirectoryInfo KFBEJDDHJPJ(FJAPFOIPONE PFCJJJAILGH, LNHLNOACGHK MHCEKKNAGID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AA")]
public enum BFKLDICFKCI : byte
{
	[Cpp2IlInjected.Token(Token = "0x400071D")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x400071E")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x400071F")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
internal class GKAJHHCNMEF : NJBDFHANJLO
{
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[CompilerGenerated]
	private sealed class IHGEGNIAGFC : IEnumerable<DDMELBGCFHO>, IEnumerable, IEnumerator<DDMELBGCFHO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		private DDMELBGCFHO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		public GKAJHHCNMEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		private FJAPFOIPONE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		public FJAPFOIPONE <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		private BFKLDICFKCI[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		private IEnumerator<DDMELBGCFHO> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		private DDMELBGCFHO System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600069B")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600069D")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x90ECF0", Offset = "0x90DCF0", VA = "0x18090ECF0")]
		[DebuggerHidden]
		public IHGEGNIAGFC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x75DCE70", Offset = "0x75DBE70", VA = "0x1875DCE70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x75DCA90", Offset = "0x75DBA90", VA = "0x1875DCA90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x75DCA40", Offset = "0x75DBA40", VA = "0x1875DCA40")]
		private void CLDKBJALKHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x75DCE20", Offset = "0x75DBE20", VA = "0x1875DCE20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x75DCD70", Offset = "0x75DBD70", VA = "0x1875DCD70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DDMELBGCFHO> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x75DCD70", Offset = "0x75DBD70", VA = "0x1875DCD70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000720")]
	private readonly BFKLDICFKCI[] LIJDEFKBFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000721")]
	private readonly Dictionary<BFKLDICFKCI, NJBDFHANJLO> PNHLNPKKKOF;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public BFKLDICFKCI KMFMDJPCHMA
	{
		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x75DB840", Offset = "0x75DA840", VA = "0x1875DB840", Slot = "4")]
		get
		{
			return default(BFKLDICFKCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x75DB900", Offset = "0x75DA900", VA = "0x1875DB900")]
	[UnityEngine.Scripting.Preserve]
	public GKAJHHCNMEF(params NJBDFHANJLO[] LDLFCFMKOPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x75DB6F0", Offset = "0x75DA6F0", VA = "0x1875DB6F0", Slot = "5")]
	public bool GBOFCLBKCGL(long AHNLEKFKAGC, long PDLBLPPCJKC, FJAPFOIPONE PFCJJJAILGH, [Out] DDMELBGCFHO BMHPAPNFNDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x75DB4B0", Offset = "0x75DA4B0", VA = "0x1875DB4B0")]
	private void DPEBKICNKFO(int NCDBIIEIDGG, long AHNLEKFKAGC, long PDLBLPPCJKC, FJAPFOIPONE PFCJJJAILGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x75DB870", Offset = "0x75DA870", VA = "0x1875DB870", Slot = "6")]
	[IteratorStateMachine(typeof(IHGEGNIAGFC))]
	public IEnumerable<DDMELBGCFHO> LOMDNLAOODL(FJAPFOIPONE PFCJJJAILGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x75DB360", Offset = "0x75DA360", VA = "0x1875DB360", Slot = "7")]
	public DDMELBGCFHO CNGIHBKPAGP(long AHNLEKFKAGC, long PDLBLPPCJKC, APNIAAHHPPH DDPKEDDGOEO, FJAPFOIPONE PFCJJJAILGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
internal static class LPPEFIEGPNO
{
	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x75DEAD0", Offset = "0x75DDAD0", VA = "0x1875DEAD0")]
	internal static byte[] DMGNANHCNJO(byte[] HPKNAAFAALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x75DEB90", Offset = "0x75DDB90", VA = "0x1875DEB90")]
	public static void GGAKPJKDNAE(Stream DONEMIPDOAM, byte[] KIDJNBEPOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x75DE8F0", Offset = "0x75DD8F0", VA = "0x1875DE8F0")]
	public static bool ABFAHIMLDJK(Stream DONEMIPDOAM, long CAOPHOPPECA, OIGHCGOLAAD FICMHJNJPOO, [Out] byte[] FCJEDIKNDOK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
internal sealed class GPDIKKCNHEC : DDMELBGCFHO, IEquatable<DDMELBGCFHO>, IEquatable<GPDIKKCNHEC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400072F")]
	private readonly JBGGOENBECH AEPGMBMHNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000730")]
	public readonly FileInfo NMPNADNMGKN;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public BFKLDICFKCI KMFMDJPCHMA
	{
		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x6F79A00", Offset = "0x6F78A00", VA = "0x186F79A00", Slot = "9")]
		get
		{
			return default(BFKLDICFKCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public DateTime KEMFMBPEACA
	{
		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x75DBC30", Offset = "0x75DAC30", VA = "0x1875DBC30", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x75DC120", Offset = "0x75DB120", VA = "0x1875DC120")]
	public GPDIKKCNHEC(JBGGOENBECH AIGLMJFNFBD, FileInfo CDPJEEOFBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x75DC070", Offset = "0x75DB070", VA = "0x1875DC070", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x75DBFB0", Offset = "0x75DAFB0", VA = "0x1875DBFB0", Slot = "5")]
	public void LJGJHCEJOJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x75DBF70", Offset = "0x75DAF70", VA = "0x1875DBF70", Slot = "6")]
	public bool JKHKGJNMKIJ(long AHNLEKFKAGC, long PDLBLPPCJKC, [Out] APNIAAHHPPH DDPKEDDGOEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x75DBE70", Offset = "0x75DAE70", VA = "0x1875DBE70", Slot = "7")]
	public bool Equals(DDMELBGCFHO DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x75DBCC0", Offset = "0x75DACC0", VA = "0x1875DBCC0", Slot = "8")]
	public bool Equals(GPDIKKCNHEC DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x75DBD80", Offset = "0x75DAD80", VA = "0x1875DBD80", Slot = "0")]
	public override bool Equals(object IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x75DBEE0", Offset = "0x75DAEE0", VA = "0x1875DBEE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public delegate void OIGHCGOLAAD(KDAFPGMPPEB.MGCBPJOHBII PLKNJAGCFFJ, string ABHPFCOODAJ);
[Cpp2IlInjected.Token(Token = "0x20001B1")]
internal interface NJBDFHANJLO
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	BFKLDICFKCI KMFMDJPCHMA
	{
		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GBOFCLBKCGL(long AHNLEKFKAGC, long PDLBLPPCJKC, FJAPFOIPONE PFCJJJAILGH, [Out] DDMELBGCFHO BMHPAPNFNDF);

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<DDMELBGCFHO> LOMDNLAOODL(FJAPFOIPONE PFCJJJAILGH);

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DDMELBGCFHO CNGIHBKPAGP(long AHNLEKFKAGC, long PDLBLPPCJKC, APNIAAHHPPH DDPKEDDGOEO, FJAPFOIPONE PFCJJJAILGH);
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
