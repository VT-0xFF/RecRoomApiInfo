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
		[Cpp2IlInjected.Address(RVA = "0x88C9F0", Offset = "0x88AFF0", VA = "0x18088C9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FDA430", Offset = "0x6FD8A30", VA = "0x186FDA430")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x88D740", Offset = "0x88BD40", VA = "0x18088D740")]
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
		[Cpp2IlInjected.Address(RVA = "0x88D780", Offset = "0x88BD80", VA = "0x18088D780")]
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
	public class LogRegistrationIndex : DAMGOKPKJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6FD0F90", Offset = "0x6FCF590", VA = "0x186FD0F90", Slot = "4")]
		public override void PIKNDMFIIPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x88C9F0", Offset = "0x88AFF0", VA = "0x18088C9F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KFOOMDEEGFI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6FCBCE0", Offset = "0x6FCA2E0", VA = "0x186FCBCE0")]
	public KFOOMDEEGFI(string NFOHONOFFAP, Exception EEOIAMFNMDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class HCCMNIAKCBC : ENOOONHJDFJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct HPDLGAMHBMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<MDLNFGMEEFD>> <>t__builder;

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
		private TaskAwaiter<FDFIFNJEENA<MDLNFGMEEFD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6FC8B40", Offset = "0x6FC7140", VA = "0x186FC8B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC8D80", Offset = "0x6FC7380", VA = "0x186FC8D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct NPLAPAGCDGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<MFKCBOOGHPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<MFKCBOOGHPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6FDA1B0", Offset = "0x6FD87B0", VA = "0x186FDA1B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6FDA3C0", Offset = "0x6FD89C0", VA = "0x186FDA3C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	[UnityEngine.Scripting.Preserve]
	public HCCMNIAKCBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6FC5900", Offset = "0x6FC3F00", VA = "0x186FC5900", Slot = "4")]
	[AsyncStateMachine(typeof(HPDLGAMHBMO))]
	public Task<IReadOnlyList<MDLNFGMEEFD>> HDANIGJJAAF(long NBDDMFOIEKN, long ILOMCKJOFJN, [Optional] CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6FC57F0", Offset = "0x6FC3DF0", VA = "0x186FC57F0", Slot = "5")]
	[AsyncStateMachine(typeof(NPLAPAGCDGA))]
	public Task<IReadOnlyList<MFKCBOOGHPL>> FDGFFKHPEAA(IReadOnlyList<int> CCAHAFLCLAC, [Optional] CancellationToken DADBOHKBJNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface GPMNPFGLLNE : IEquatable<GPMNPFGLLNE>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int LOJGJACNJAB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	MFKCBOOGHPL OIGFAHHOJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime HOPCGEIGHIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	KAJLIHHEFAG? BLKLAKFHCBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	MBNCGOMPOKB? FJFOGGDGFFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	BMCAACHDDKJ JMMPOBHNLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<NFKPBMFAMEB> AMOPLMKEJEA();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum BMCAACHDDKJ
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ENOOONHJDFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<MDLNFGMEEFD>> HDANIGJJAAF(long NBDDMFOIEKN, long ILOMCKJOFJN, [Optional] CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<MFKCBOOGHPL>> FDGFFKHPEAA(IReadOnlyList<int> CCAHAFLCLAC, [Optional] CancellationToken DADBOHKBJNO);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class IAIJDPPFOBL
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class MBMHIMKEANA : GPMNPFGLLNE, IEquatable<GPMNPFGLLNE>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct DKJIFGNBBNB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<NFKPBMFAMEB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public MBMHIMKEANA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private GNJFJGDMPAL <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<KBIHKJABELE> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<NFKPBMFAMEB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6FC0E30", Offset = "0x6FBF430", VA = "0x186FC0E30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6FC12D0", Offset = "0x6FBF8D0", VA = "0x186FC12D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly MDLNFGMEEFD NIEPGCGDACP;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int LOJGJACNJAB
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8657F0", Offset = "0x863DF0", VA = "0x1808657F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public MFKCBOOGHPL OIGFAHHOJFM
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8657D0", Offset = "0x863DD0", VA = "0x1808657D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime BDGDEECCGAE
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x5B88BD0", Offset = "0x5B871D0", VA = "0x185B88BD0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public KAJLIHHEFAG? BLKLAKFHCBH
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1C0F650", Offset = "0x1C0DC50", VA = "0x181C0F650", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public MBNCGOMPOKB? FJFOGGDGFFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5B88CB0", Offset = "0x5B872B0", VA = "0x185B88CB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public BMCAACHDDKJ JMMPOBHNLKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8E43B0", Offset = "0x8E29B0", VA = "0x1808E43B0", Slot = "10")]
			get
			{
				return default(BMCAACHDDKJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6FD1520", Offset = "0x6FCFB20", VA = "0x186FD1520", Slot = "9")]
		[AsyncStateMachine(typeof(DKJIFGNBBNB))]
		public Task<NFKPBMFAMEB> AMOPLMKEJEA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6FD1810", Offset = "0x6FCFE10", VA = "0x186FD1810")]
		public MBMHIMKEANA(int ICGJJKGIMLM, MFKCBOOGHPL PKACHECAPBE, MDLNFGMEEFD NIEPGCGDACP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6FD1700", Offset = "0x6FCFD00", VA = "0x186FD1700", Slot = "11")]
		public bool Equals(GPMNPFGLLNE LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6FD1660", Offset = "0x6FCFC60", VA = "0x186FD1660", Slot = "0")]
		public override bool Equals(object HBFCGFKGCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6FD1620", Offset = "0x6FCFC20", VA = "0x186FD1620")]
		private bool BPEJJOFPONI(MBMHIMKEANA LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6FD1790", Offset = "0x6FCFD90", VA = "0x186FD1790", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class KAICACIPMJF : GPMNPFGLLNE, IEquatable<GPMNPFGLLNE>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct EOBLDIABMAN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<NFKPBMFAMEB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public KAICACIPMJF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<NFKPBMFAMEB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6FC3DA0", Offset = "0x6FC23A0", VA = "0x186FC3DA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6FC3FD0", Offset = "0x6FC25D0", VA = "0x186FC3FD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly NKHNFKKJCFE NNKACDNKFDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly KAJLIHHEFAG IOCMFOEHABD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly MBNCGOMPOKB PEMOJDOHAFF;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int LOJGJACNJAB
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6FCB1A0", Offset = "0x6FC97A0", VA = "0x186FCB1A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public MFKCBOOGHPL OIGFAHHOJFM
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6FCB010", Offset = "0x6FC9610", VA = "0x186FCB010", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime BDGDEECCGAE
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6FCB150", Offset = "0x6FC9750", VA = "0x186FCB150", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public KAJLIHHEFAG? BLKLAKFHCBH
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6FCB3B0", Offset = "0x6FC99B0", VA = "0x186FCB3B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public MBNCGOMPOKB? FJFOGGDGFFM
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6FCB100", Offset = "0x6FC9700", VA = "0x186FCB100", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public BMCAACHDDKJ JMMPOBHNLKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8D95E0", Offset = "0x8D7BE0", VA = "0x1808D95E0", Slot = "10")]
			get
			{
				return default(BMCAACHDDKJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x10E52C0", Offset = "0x10E38C0", VA = "0x1810E52C0")]
		public KAICACIPMJF(NKHNFKKJCFE ABJEIILOJGD, KAJLIHHEFAG BNAJINPACLH, MBNCGOMPOKB CJNHJHLLOLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6FCAF20", Offset = "0x6FC9520", VA = "0x186FCAF20", Slot = "9")]
		[AsyncStateMachine(typeof(EOBLDIABMAN))]
		public Task<NFKPBMFAMEB> AMOPLMKEJEA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6FCB290", Offset = "0x6FC9890", VA = "0x186FCB290", Slot = "11")]
		public bool Equals(GPMNPFGLLNE LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6FCB1E0", Offset = "0x6FC97E0", VA = "0x186FCB1E0", Slot = "0")]
		public override bool Equals(object HBFCGFKGCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6FCB0A0", Offset = "0x6FC96A0", VA = "0x186FCB0A0")]
		private bool BPEJJOFPONI(KAICACIPMJF LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6FCB330", Offset = "0x6FC9930", VA = "0x186FCB330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class AAKPNGNDIOO : GPMNPFGLLNE, IEquatable<GPMNPFGLLNE>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct MMCOGNFOJHA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<NFKPBMFAMEB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<NFKPBMFAMEB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6FD2720", Offset = "0x6FD0D20", VA = "0x186FD2720", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6FD2960", Offset = "0x6FD0F60", VA = "0x186FD2960", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly MFKCBOOGHPL BCGIABGLIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly KAJLIHHEFAG IOCMFOEHABD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly MBNCGOMPOKB PEMOJDOHAFF;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int LOJGJACNJAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6FBC980", Offset = "0x6FBAF80", VA = "0x186FBC980", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public MFKCBOOGHPL OIGFAHHOJFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime BDGDEECCGAE
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public KAJLIHHEFAG? BLKLAKFHCBH
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6FBCC60", Offset = "0x6FBB260", VA = "0x186FBCC60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public MBNCGOMPOKB? FJFOGGDGFFM
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6FBC930", Offset = "0x6FBAF30", VA = "0x186FBC930", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public BMCAACHDDKJ JMMPOBHNLKL
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "10")]
			get
			{
				return default(BMCAACHDDKJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x10E52C0", Offset = "0x10E38C0", VA = "0x1810E52C0")]
		public AAKPNGNDIOO(MFKCBOOGHPL PKACHECAPBE, KAJLIHHEFAG BNAJINPACLH, MBNCGOMPOKB CJNHJHLLOLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC780", Offset = "0x6FBAD80", VA = "0x186FBC780", Slot = "9")]
		[AsyncStateMachine(typeof(MMCOGNFOJHA))]
		public Task<NFKPBMFAMEB> AMOPLMKEJEA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC9A0", Offset = "0x6FBAFA0", VA = "0x186FBC9A0", Slot = "11")]
		public bool Equals(GPMNPFGLLNE LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6FBCAB0", Offset = "0x6FBB0B0", VA = "0x186FBCAB0", Slot = "0")]
		public override bool Equals(object HBFCGFKGCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6FBCBD0", Offset = "0x6FBB1D0", VA = "0x186FBCBD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC850", Offset = "0x6FBAE50", VA = "0x186FBC850")]
		private bool BPEJJOFPONI(AAKPNGNDIOO LJAAPFIIPOF)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct BDLJPHMAEAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<GPMNPFGLLNE>> <>t__builder;

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
		public IAIJDPPFOBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<MDLNFGMEEFD> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<MDLNFGMEEFD>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, MFKCBOOGHPL account, MDLNFGMEEFD roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6FBE620", Offset = "0x6FBCC20", VA = "0x186FBE620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF480", Offset = "0x6FBDA80", VA = "0x186FBF480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct AJEIAPGHADM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, MFKCBOOGHPL account, MDLNFGMEEFD roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<MDLNFGMEEFD> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public IAIJDPPFOBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<MFKCBOOGHPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6FBCCB0", Offset = "0x6FBB2B0", VA = "0x186FBCCB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD6A0", Offset = "0x6FBBCA0", VA = "0x186FBD6A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly OBJIAHPFFNB OIGAHLJGMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly ENOOONHJDFJ AEJBOKLNKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly HHIACAIEMCD LDHOECICAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly FMHCEMJFILO<(long, long), IReadOnlyList<MDLNFGMEEFD>> GCMHMJKGODO;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6FC91F0", Offset = "0x6FC77F0", VA = "0x186FC91F0")]
	[UnityEngine.Scripting.Preserve]
	public IAIJDPPFOBL([JFHFHOOOEKP(null)] ENOOONHJDFJ KBHAHFBEEFM, [JFHFHOOOEKP(null)] HHIACAIEMCD MJAPHAFBIOH, [JFHFHOOOEKP(null)] OBJIAHPFFNB JMGBOBHPOIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6FC8DF0", Offset = "0x6FC73F0", VA = "0x186FC8DF0")]
	[AsyncStateMachine(typeof(BDLJPHMAEAG))]
	public Task<IList<GPMNPFGLLNE>> CEBPKAMNPOE(long NBDDMFOIEKN, long JDAJCIDAAMB, bool BDALBENLAHK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6FC9050", Offset = "0x6FC7650", VA = "0x186FC9050")]
	private bool IMJPDAPPCGH(DateTime? AKDBFAOGAMB, long NBDDMFOIEKN, long JDAJCIDAAMB, [Out] NKHNFKKJCFE IAHFOGKOOEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6FC8F40", Offset = "0x6FC7540", VA = "0x186FC8F40")]
	[AsyncStateMachine(typeof(AJEIAPGHADM))]
	private Task<IReadOnlyList<(int, MFKCBOOGHPL, MDLNFGMEEFD)>> HDONHDFDIJI(IReadOnlyList<MDLNFGMEEFD> ABMKMEMCJOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HHIACAIEMCD
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<NKHNFKKJCFE> MPDMAAFJGGL;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FBEDENEHMKL(long NBDDMFOIEKN, long JDAJCIDAAMB, GKKPKPAPFIE BKEEPMDPFLF, MJNMLCHIOPD BBHKMFMMNIP);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PECFFLAFFMG(long NBDDMFOIEKN, long JDAJCIDAAMB, [Out] NKHNFKKJCFE IAHFOGKOOEC);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FKMKLBCHPOM(long NBDDMFOIEKN, long JDAJCIDAAMB, MJNMLCHIOPD BBHKMFMMNIP, [Out] NKHNFKKJCFE IAHFOGKOOEC);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EJOLKPLHOEK(long NBDDMFOIEKN, long JDAJCIDAAMB);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface BKFLIPKCOFF : BNJANPJILMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool MHJACDNNBAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task CCKAGHIIJAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NAGADBGAEGI(Task PEBIPFJADEI, string DCFCFOOFAKD);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface EHJJOKKDPOE : BNJANPJILMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NFKPBMFAMEB> ODIHPINJHHJ(NKHNFKKJCFE IAHFOGKOOEC);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PLECKACEEJE(CancellationToken DADBOHKBJNO);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface ABMMHMOHPPM : BNJANPJILMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	ENLPHOAFKCD ALFEIEGPAHD
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKKJHMAHIGF();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JBJMBFLLEHM();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface BNJANPJILMK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGGINNGCCML(BCKFHKGPDOK ICKJILCADLE);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface KMKKILBFJCF
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan PEHJHGFHOLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan EDCFAHKOKKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan CEFJJDHNBEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan KMLOEOBIJEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool ILBFIOJMIKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool IJNAKKDELNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool EIJANKLAAOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int MNLGPHOAIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool HNBCKHOMGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool CHHDGFOCLCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool GIOOJEAEPOA
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum CJGNELBNGDF
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum COKCNCLLNOC
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
public struct JGEMMLOJFBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long ICPNOAIHCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long ILOMCKJOFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly CJGNELBNGDF PBLNJHEPKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception AAJEKBAADNF;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6FCA900", Offset = "0x6FC8F00", VA = "0x186FCA900")]
	public JGEMMLOJFBN(long ICPNOAIHCPA, long ILOMCKJOFJN, CJGNELBNGDF PBLNJHEPKAE, [CanBeNull] Exception AAJEKBAADNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6FCA8B0", Offset = "0x6FC8EB0", VA = "0x186FCA8B0")]
	public static JGEMMLOJFBN ICICDJFMCPH(BNPDOGINEIM CANBHFHBMDA, CJGNELBNGDF PBLNJHEPKAE, [Optional] Exception AAJEKBAADNF)
	{
		return default(JGEMMLOJFBN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public delegate void MNBIJKILACC(JGEMMLOJFBN IPLGFLLPKBI);
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface HCMBBLCLKIO : BNJANPJILMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action BOOOPLKADGK;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event MNBIJKILACC CHGFFKAEIOO;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event MNBIJKILACC NAOCLHJGPLK;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event MNBIJKILACC LFBCPCHOPIP;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<COKCNCLLNOC, bool> FMBBENKHLHL;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void APPKHPDACPL();

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NHLCKAGKFJA(JGEMMLOJFBN IPLGFLLPKBI);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PBADFNGHHED(JGEMMLOJFBN IPLGFLLPKBI);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PGDNGOGCPCP(JGEMMLOJFBN IPLGFLLPKBI);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MGIKKPPMCMP(COKCNCLLNOC JHHCMNOMIOL, bool EPAOGDMACAO);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface MJDBOLGOOKG : BNJANPJILMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task GECCIHIKHMA();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JFFKGIEHMLH();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface EOACDJBHABE : BNJANPJILMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	TaskStatus FLNHBPEALIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LNJCCHGBBND(BNPDOGINEIM KKOAPODKFFE, CJHMBLDOBAH GMIOPCIMFKL, CancellationToken HCOOOCBFMFM);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class AOLMAMNMPNK
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6FBD9A0", Offset = "0x6FBBFA0", VA = "0x186FBD9A0")]
	public static bool OKEHOHLEOLP(this EOACDJBHABE LKBALMPMNLO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public delegate Task HMDLDHAINHE(PLBPIEKJMAO ENLCDNNHBBD, CancellationToken OEDJKICDDGA);
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface JHODEIDOEJC : BNJANPJILMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PGLBGNLCPEK(HMDLDHAINHE EKOOEOAOADG);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface BCKFHKGPDOK : GNJFJGDMPAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	CancellationToken OBJACIAOCAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	DIIANKCHAHD DHDPDMODHIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	BFABGGACIHJ JHMBNIEGNHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NEGLLEIMIKK JLDBDAGBCPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	MPJECKENMPL OKAMCKPLNOF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	HEJGCIILPDP JAOKDPGMOLH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	FPIPKCCKKLN DCMAJBGFKJI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	HNEJFLCABCA JAOFBHNDNIC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	PHKBEKJCEKE LCECKCOGNAM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	BKFLIPKCOFF HIPLOEKBJOA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	EHJJOKKDPOE FEEDEFCGPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	HCMBBLCLKIO BEJGMLCOBNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	MJDBOLGOOKG HNFEEOIPBJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	EOACDJBHABE FFPBEGBNNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	JHODEIDOEJC BAKENDKCJJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	INIFGBCGIKB EBPGFKDHAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	LOGBNPPHELH MDLLADLNBJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	EJDHGBPDGNA MFOALGIACBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	NEMHBOGJAOH ICDFLABGOCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	KADNCCIKBMN FBHIHOIDPED
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	MJDDMHHOPKA OFJIBNADMNN
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	ACMNAHKBHOB BDNNHNGOFGF
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	HJAEPIOFAGF GNJOJLGEEGE
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	OHNKHFEPKAP NNDJAMDBPHL
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	OLKPLLGGGBP KDCKDKLBFKA
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	ABMMHMOHPPM NOJDOHOLFPE
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	KMKKILBFJCF HKMNIDMPHGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	KDHIFHNDPAK DGKHCKDNLCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	HHIACAIEMCD CJJODLGKJKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	CBDKABACAFE NOEMNAMDOMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	COGPNCEBADI HGEOCLDGHDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	BOAANLGFGMH KMPOMBALKKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void FJLNOEDGMEN(CJHMBLDOBAH OCDIAHEHLOH);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface INIFGBCGIKB : BNJANPJILMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GONHDJILODE MJFEDCBJOBF(Guid PNICJCCCLKL);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GAGDAFIMOPK(Guid PNICJCCCLKL);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NEALLDFBGKA(Guid PNICJCCCLKL, Task DFHGMBELFIN);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool COKJOGGGJCB(Guid PNICJCCCLKL, NFKPBMFAMEB HJFCDIKDMEL);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(NFKPBMFAMEB, Task)> JPDLLFALOCI(Guid PNICJCCCLKL);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface PNPOAFOKJJM : BNJANPJILMK, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface LOGBNPPHELH : BNJANPJILMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CJDDLNAEDIH(ILFKKIOKLHK NFOHONOFFAP);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MDHPBJJLMOL(ILFKKIOKLHK NFOHONOFFAP);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<OBDEAKLOPMH> ONPLLCNIHMI(CancellationToken MJNNLAPANNL);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface EJDHGBPDGNA : BNJANPJILMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GONHDJILODE EEDEGBKILON(ILFKKIOKLHK OCNINHACHEI);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MKPJDKFELMG(Guid PNICJCCCLKL, Task DFHGMBELFIN);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface NEMHBOGJAOH : BNJANPJILMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NFKPBMFAMEB> ICDFLABGOCH(ILFKKIOKLHK EFCACLBAGOG);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface KADNCCIKBMN : BNJANPJILMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HIDIGIEPPEB> ELFFKCOHBOH(DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, BNPDOGINEIM KKOAPODKFFE, CancellationToken DADBOHKBJNO);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface ACMNAHKBHOB : BNJANPJILMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NFKPBMFAMEB HIDDGLIMKHK(NMCPPAKMEBO KPBDJLELCAF);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LHMEMBFJAKD(string AKCHJOKAGJB);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface MJDDMHHOPKA : BNJANPJILMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ILFKKIOKLHK> OBKHPCIAFLF(ILFKKIOKLHK BDMHFDNBPPE, IPKKJLJAFFM AMBGDADIODJ, CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<ILFKKIOKLHK> KFJMDJMGKEK(CancellationToken DADBOHKBJNO, IPKKJLJAFFM AMBGDADIODJ);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HJBBHPAONAL BLNKFDFDPOM(IKCOGJKNDIG KIBKEBAGKGA, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HJBBHPAONAL NOADNDANCEJ(IKCOGJKNDIG KIBKEBAGKGA, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface HJAEPIOFAGF : BNJANPJILMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NFKPBMFAMEB DLOCBMCACIG(NMCPPAKMEBO KPBDJLELCAF, OBDEAKLOPMH PGPOPMKEFPB);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NFKPBMFAMEB LAGJDEIOJOI(NMCPPAKMEBO FKMPKKEKGIC);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface OHNKHFEPKAP
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HIFOCBHCPJK(KCCCBPKMLJN CLKAJLNJJIM);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IFDMHAEEMOM(KCCCBPKMLJN CLKAJLNJJIM);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JAJIIFIANPJ(KCCCBPKMLJN CLKAJLNJJIM);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HMNKFLBAFIC(KCCCBPKMLJN CLKAJLNJJIM);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class KCCCBPKMLJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly BNPDOGINEIM OBCJIHIEAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> IBLOHLGKOKG;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public DJJFGNEEIPJ<string> PGHKMMEIFCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8657D0", Offset = "0x863DD0", VA = "0x1808657D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x864E00", Offset = "0x863400", VA = "0x180864E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x869B90", Offset = "0x868190", VA = "0x180869B90")]
	public KCCCBPKMLJN(BNPDOGINEIM JKCIOCOHNMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6FCB400", Offset = "0x6FC9A00", VA = "0x186FCB400")]
	public KCCCBPKMLJN ENKKJAOFIHH(string BHEIPBKEDLG, string CBAEIEAPLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6FCB4D0", Offset = "0x6FC9AD0", VA = "0x186FCB4D0")]
	public bool FAGLPIFAOKB([Out] IEnumerable<KeyValuePair<string, string>> AGDIOLAGABC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x62559C0", Offset = "0x6253FC0", VA = "0x1862559C0")]
	public KCCCBPKMLJN BGPCFBOKIND(DJJFGNEEIPJ<string> OPELNCJDKIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface KDHIFHNDPAK
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool PGAGNJIHHAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	string JLJMPLKEMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool NGJMPHDBLHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GLLLNMOGGOO();

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DMNONJLJKOG GKFFOFHPGCA(long HFCDLHABEIB);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HDMACEANEIK<HCMHGKFNLLO, HMALNBKCNFI> EPJPMIGABEG(long HFCDLHABEIB);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HDMACEANEIK<HCMHGKFNLLO, EIGMLKEEHNM> HMDIOAHIMCG(long HFCDLHABEIB);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HDMACEANEIK<long, CPNNGLIIIOE> JJGMJIDEJBA();

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool JHNCHDIDLNM(long HFCDLHABEIB, [Out] bool BOFJEPDHADF);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> IPGHKHEDDMG(byte[] KEAPPNMDHKA, byte[] BKFHNCLAJLB, CancellationToken DADBOHKBJNO);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface GNJFJGDMPAL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool OKEHOHLEOLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool HHAMGAGPBGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	CJHMBLDOBAH ALKCDMGMHKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action BOOOPLKADGK;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event MNBIJKILACC CHGFFKAEIOO;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event MNBIJKILACC NAOCLHJGPLK;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event MNBIJKILACC LFBCPCHOPIP;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<COKCNCLLNOC, bool> FMBBENKHLHL;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JFFKGIEHMLH();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	OPANKGMAOKN OHNGHIAMKPI();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CNBPBICCNIL GFOBDDCJAOK();

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<NFKPBMFAMEB> ODIHPINJHHJ(NKHNFKKJCFE ABJEIILOJGD);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task PLECKACEEJE(CancellationToken DADBOHKBJNO);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface HEJGCIILPDP
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool IJNFANPMGLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	string JFKFPGICBKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HKPJBBGDGHO(Scene KPMNEJCNMOC);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task GJGEJKKKJJD(OLIFKCLPPCB ICFIMNKOJIE, CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task FKGELJFEENP();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task HBCCCCCJJHI();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface MPJECKENMPL
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	COKFDBDFLII HKODNONBALC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool FDIONNFIGPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool EDEEBCCBBFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool EBAAJHPBBFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool IABLJGOAGME
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	int DEPMNKCAJOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool KFFFOBNAAHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool JHFELDKOFIL
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	byte NHGKBHOBJMA
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	byte KOJKDLPKACB
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool OBAKHCHLOJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool CFGBFHNJKDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool EMEPKJPPIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	float FGGDHEDOGOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> HFJFKOEHDDM;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DIIANKCHAHD DHMNEBJMILC(DIIANKCHAHD HPJLCLBLBCC);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BJBLBANAHHI(DIIANKCHAHD OMDOLEEBJJJ);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LCPIHCAACLO();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task IHHMKFHCJCI(DJJFGNEEIPJ<string>.DIJMCCGECOP JDINLIJDOBD, CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FFCICIKOBOA(float HJEJDDDNHBP);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ALMABOMLLFN(string KJABOHKGPKO);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<NJJJDPEEPEF> LIPCDBJABMH();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable IEFCBCODJKA(object FFHIJMOJNAI, NJJJDPEEPEF FHKGLGIJDMO);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<FJBAAJDHIHN> NOFIPGBBACG();

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HMALNBKCNFI NHJEANJPHMC(IEnumerable<CGIDLDDLPHO> JLMBIDFEOMF);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CLBIECPBKMJ(int KEFHKMFECFI);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task JKNGDHLBKID();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KNDNCBMFLEI();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool APEPIPJLHEL();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task DMDKKFOJHKB(CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task KHKILLHGADD(CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<NBIEDHEJLMH> JIDJMHJGHCG(DateTime PGCELIKBMOJ, CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> POKJPHNLOCF(CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void HGHGNLGCBDA(string NFOHONOFFAP = "", float DACHNPNJPDB = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "25")]
	ECPGFOJFJIH ONEINBFJNMK(HDKPBALEPOD DFNELONPIOM, OGHKKFAHDCO DBDIEFBCBGK, EIGMLKEEHNM NJEPJKKDBJB, IEnumerable<PersistenceView> HDMNGFGLLKK, DKGAACBKMJC HICOJCFFCFD);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void GAIIGJMBCEI(EIGMLKEEHNM NJEPJKKDBJB);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void OHGOPPBLAHF(CGIDLDDLPHO PKKOMHEOCPG, [In] ECPGFOJFJIH KHNGIJEABPA);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task AKLNCAGCMLB(EIGMLKEEHNM LPNOGJAALGA, bool JNEPFJGMNFD, CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task GLLCOLFBPOH(CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void LGBPMBEPMFC(long NBDDMFOIEKN, long ILOMCKJOFJN, KBIHKJABELE KMGPOBDIGAH, MDLNFGMEEFD BNMDKKKACPK, GKKPKPAPFIE BKEEPMDPFLF, BGDAOBFLICB? HAPCEHIIKKI, LEIHNKGEKLG? NODBACFAJMJ);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void HHBLODBFEFJ(long NBDDMFOIEKN, long ILOMCKJOFJN, LEIHNKGEKLG? NODBACFAJMJ);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void CGGIBKNEDML(PersistenceView BLHHFENDDGH);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool HEHAJNDDJOD(PersistenceView KBOINDMIKMD);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool KAPECJMNPAE(CGIDLDDLPHO PKKOMHEOCPG, NGPKNGOLDBM LLGLNKJCGMM, [Out] NNMILFMEHHN GPBFJEMEDMC);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task ENDHLJMNGPN(CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void JLDOEPHNNMH();

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable IEIODLMCEJF();

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void KBHLNJAJDJO(EIGMLKEEHNM LPNOGJAALGA, NGPKNGOLDBM LLGLNKJCGMM);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<bool> AGCJFJJPOLB(BFABGGACIHJ KJHMNPPBFKI, CancellationToken DADBOHKBJNO, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void NBAEJCLJHAJ(CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<DOIKEIMKJLC> HLMAAJHHGCG(GLEKJELDHII BDMHFDNBPPE);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<KBIHKJABELE> BMNGNGKNKMC(long NBDDMFOIEKN, bool MKNNIFDAAGO, CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<MDLNFGMEEFD> NFPMDNIFBGO(long NBDDMFOIEKN, long ILOMCKJOFJN, long FDJBEKDGJEH, CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<FDFIFNJEENA<MDLNFGMEEFD>> DDCBIAKMJFN(long NBDDMFOIEKN, long ILOMCKJOFJN, int CFKFFPNNJCH = 0, int HAHAJHDNKFA = 10, [Optional] CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<CEBEAJJMCEF> ICBGLDCJCGP(string LGNLNIECDME, CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<CEBEAJJMCEF> ALCIOOKDMAE(string LGNLNIECDME, long NBDDMFOIEKN, long ILOMCKJOFJN, string LJHFHHFIGMM, DPCBEKHGJBE.BFJMMAKLFBE ENLCDNNHBBD, DPCBEKHGJBE.BFJMMAKLFBE BKFHNCLAJLB, int GFBPPFHEBGI);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool LJJKAPIKFFJ();

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "49")]
	bool PGKLNAAHEAI();

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool HOHOOAILEHA(IEnumerable<NNMILFMEHHN> HBHMMCFDEAN);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void PJNGNGCLEMF(List<GameObject> GMGHKHMEMGO);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "52")]
	float AGAGMMEFCEN();

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "53")]
	Task<Scene> DEIFCEDCPMN(string OFICCEEBFIG, LoadSceneMode FAGBFJEPGGD, bool CANNKNKNGIL, DJJFGNEEIPJ<string>.DIJMCCGECOP OPELNCJDKIK);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void KGDHLJDNMHC();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void IGJAOIJAKPJ(bool GFLBKNDOAOE);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void PMGFDDLDMIK();

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void GCIOMOKBBLN();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void AMJICFAFOAD(BNPDOGINEIM NPOIAAMPBOJ);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Task AILBDDMEPBH(DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "69")]
	Task NEENNABLJJJ(DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "70")]
	Task PDKMGGNNKEA(DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "71")]
	Task LEAPKAFDMBO(DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "72")]
	IDisposable IKFLLIDDOAA();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "73")]
	JFOJBGOKDJG NHHHPAKPLIP();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task JGLICCPNNFO(CancellationToken DADBOHKBJNO);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface JFOJBGOKDJG
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HNNIMPKAHHH(CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CIEOJOJMOBI(CancellationToken DADBOHKBJNO);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct ECPGFOJFJIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> BKPNCHPPNFH;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum NBIEDHEJLMH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct HDKPBALEPOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string BMIBKLOGGJG;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface COKFDBDFLII
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	BNPDOGINEIM KPOHJCEBLIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	KBIHKJABELE NLGOFALHAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	OONHFDBOICP PGBEPOIANBL
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool BBIFHPNMCBH
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool IPHKLGGAOAI
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	int CHOJPFPHAMG
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action KAMGHIDJAFM;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> JJBECEJHIBF;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MPFIOGNFCMF();

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.BEDDJGHMMAI> GOPOEPIPPAA(long HFCDLHABEIB, [Optional] CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<KDOECNFBAGL> IFFILMAIJLO();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task FCJLMKJHKKE();

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(BNPDOGINEIM, CJHMBLDOBAH) MGIHPIDCPEH();

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "15")]
	APFHDOCKBNE NDNFEHDGLJC();

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MDOKNEJHPAN(long HFCDLHABEIB);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface OLKPLLGGGBP
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GJNLBCPAKGI([Out] IEnumerable<int> KPOMGFHPMEM);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GDIDGBJKFBA(KHCGFHKKCLN OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AHNFOFPKNJA(KHCGFHKKCLN OEDJKICDDGA);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface MPALNKBLHGH
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string NPKNBKHNMBF(NFKPBMFAMEB PLKNOIJJGAE);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface HALHDOEHAMI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BLACMHFDGDJ(LKGCGOPIMJJ.MGNNJNLGBHE BAFABGKFEEB);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GGLLHMDJIGP(LKGCGOPIMJJ.MGNNJNLGBHE BAFABGKFEEB);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface FPIPKCCKKLN : HALHDOEHAMI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NFKPBMFAMEB POGJMMMEEHH(NMCPPAKMEBO FKMPKKEKGIC);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface HNEJFLCABCA : HALHDOEHAMI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NFKPBMFAMEB HIDDGLIMKHK(NMCPPAKMEBO OFANFPAHCFK);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface DMNONJLJKOG
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PIJKHLBEMKP<OLIFKCLPPCB, FNFMNGCMHCP>> CHJOEKIMNDC(string LJHFHHFIGMM, long HFCDLHABEIB, long? NBDDMFOIEKN, long? ILOMCKJOFJN, BEFCBFDMNMF.HPAGEKKLNLJ NKCHCKFEIPH, CancellationToken DADBOHKBJNO);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface HDMACEANEIK<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PIJKHLBEMKP<LAONMFHHBKK<TData>, FNFMNGCMHCP>> DNMHGNKHPEK(TGetDataArg HFLBLCMJIKA, CancellationToken DADBOHKBJNO);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class HIFEPLJHNOM : BCKFHKGPDOK, GNJFJGDMPAL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct CNOFPKJBLOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder<NFKPBMFAMEB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public HIFEPLJHNOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public NKHNFKKJCFE autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<NFKPBMFAMEB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0250", Offset = "0x6FBE850", VA = "0x186FC0250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x6FC04D0", Offset = "0x6FBEAD0", VA = "0x186FC04D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct ANJPJFBHFMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public HIFEPLJHNOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD710", Offset = "0x6FBBD10", VA = "0x186FBD710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD940", Offset = "0x6FBBF40", VA = "0x186FBD940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class IDMKLCFCNEA : IEnumerable<BNJANPJILMK>, IEnumerable, IEnumerator<BNJANPJILMK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private BNJANPJILMK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public HIFEPLJHNOM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		private BNJANPJILMK System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8BC660", Offset = "0x8BAC60", VA = "0x1808BC660")]
		[DebuggerHidden]
		public IDMKLCFCNEA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6FC9320", Offset = "0x6FC7920", VA = "0x186FC9320", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6FC9780", Offset = "0x6FC7D80", VA = "0x186FC9780", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6FC96D0", Offset = "0x6FC7CD0", VA = "0x186FC96D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BNJANPJILMK> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6FC96D0", Offset = "0x6FC7CD0", VA = "0x186FC96D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource PMBMPEIBFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly DIIANKCHAHD OMDOLEEBJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool MMNAIEEGDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private LKPIJLEGKDA IAFCKLOGFHF;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public BFABGGACIHJ JHMBNIEGNHN
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8689A0", Offset = "0x866FA0", VA = "0x1808689A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x868A50", Offset = "0x867050", VA = "0x180868A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public NEGLLEIMIKK JLDBDAGBCPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x863DF0", Offset = "0x8623F0", VA = "0x180863DF0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x863DC0", Offset = "0x8623C0", VA = "0x180863DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public MPJECKENMPL OKAMCKPLNOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x863E10", Offset = "0x862410", VA = "0x180863E10", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x863E40", Offset = "0x862440", VA = "0x180863E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public HEJGCIILPDP JAOKDPGMOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x863E00", Offset = "0x862400", VA = "0x180863E00", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x863DE0", Offset = "0x8623E0", VA = "0x180863DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public FPIPKCCKKLN DCMAJBGFKJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x863DD0", Offset = "0x8623D0", VA = "0x180863DD0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x863E30", Offset = "0x862430", VA = "0x180863E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public HNEJFLCABCA JAOFBHNDNIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x863E50", Offset = "0x862450", VA = "0x180863E50", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x863E20", Offset = "0x862420", VA = "0x180863E20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public PHKBEKJCEKE LCECKCOGNAM
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x868A10", Offset = "0x867010", VA = "0x180868A10", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x868B10", Offset = "0x867110", VA = "0x180868B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public BKFLIPKCOFF HIPLOEKBJOA
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x868AA0", Offset = "0x8670A0", VA = "0x180868AA0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x868AC0", Offset = "0x8670C0", VA = "0x180868AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public EHJJOKKDPOE FEEDEFCGPFB
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8689D0", Offset = "0x866FD0", VA = "0x1808689D0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8689F0", Offset = "0x866FF0", VA = "0x1808689F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public HCMBBLCLKIO BEJGMLCOBNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9CB870", Offset = "0x9C9E70", VA = "0x1809CB870", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9F3F40", Offset = "0x9F2540", VA = "0x1809F3F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public MJDBOLGOOKG HNFEEOIPBJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x868A30", Offset = "0x867030", VA = "0x180868A30", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x868930", Offset = "0x866F30", VA = "0x180868930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public EOACDJBHABE FFPBEGBNNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9F18C0", Offset = "0x9EFEC0", VA = "0x1809F18C0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9D08B0", Offset = "0x9CEEB0", VA = "0x1809D08B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public JHODEIDOEJC BAKENDKCJJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x86F650", Offset = "0x86DC50", VA = "0x18086F650", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x86F5D0", Offset = "0x86DBD0", VA = "0x18086F5D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public INIFGBCGIKB EBPGFKDHAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xB94710", Offset = "0xB92D10", VA = "0x180B94710", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xB9C700", Offset = "0xB9AD00", VA = "0x180B9C700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public PNPOAFOKJJM IEEIOEIJAGA
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x952510", Offset = "0x950B10", VA = "0x180952510", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x94ED50", Offset = "0x94D350", VA = "0x18094ED50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public LOGBNPPHELH MDLLADLNBJE
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x951CB0", Offset = "0x9502B0", VA = "0x180951CB0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x953250", Offset = "0x951850", VA = "0x180953250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public EJDHGBPDGNA MFOALGIACBK
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8CF1D0", Offset = "0x8CD7D0", VA = "0x1808CF1D0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xB9C740", Offset = "0xB9AD40", VA = "0x180B9C740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public NEMHBOGJAOH ICDFLABGOCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8CE640", Offset = "0x8CCC40", VA = "0x1808CE640", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA2D2F0", Offset = "0xA2B8F0", VA = "0x180A2D2F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public KADNCCIKBMN FBHIHOIDPED
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x86F660", Offset = "0x86DC60", VA = "0x18086F660", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x86F630", Offset = "0x86DC30", VA = "0x18086F630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public MJDDMHHOPKA OFJIBNADMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8ACC30", Offset = "0x8AB230", VA = "0x1808ACC30", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9CD1D0", Offset = "0x9CB7D0", VA = "0x1809CD1D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public ACMNAHKBHOB BDNNHNGOFGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA537B0", Offset = "0xA51DB0", VA = "0x180A537B0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA53350", Offset = "0xA51950", VA = "0x180A53350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public HJAEPIOFAGF GNJOJLGEEGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8CE660", Offset = "0x8CCC60", VA = "0x1808CE660", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xB9C720", Offset = "0xB9AD20", VA = "0x180B9C720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public OHNKHFEPKAP NNDJAMDBPHL
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8CE670", Offset = "0x8CCC70", VA = "0x1808CE670", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9CEF30", Offset = "0x9CD530", VA = "0x1809CEF30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public OLKPLLGGGBP KDCKDKLBFKA
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8CE5C0", Offset = "0x8CCBC0", VA = "0x1808CE5C0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xB9C6E0", Offset = "0xB9ACE0", VA = "0x180B9C6E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public ABMMHMOHPPM NOJDOHOLFPE
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8CE5D0", Offset = "0x8CCBD0", VA = "0x1808CE5D0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xB9C920", Offset = "0xB9AF20", VA = "0x180B9C920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public KMKKILBFJCF HKMNIDMPHGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8CE4A0", Offset = "0x8CCAA0", VA = "0x1808CE4A0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xB9C900", Offset = "0xB9AF00", VA = "0x180B9C900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public KDHIFHNDPAK DGKHCKDNLCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8CE470", Offset = "0x8CCA70", VA = "0x1808CE470", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xB9C880", Offset = "0xB9AE80", VA = "0x180B9C880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public HHIACAIEMCD CJJODLGKJKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8CE3D0", Offset = "0x8CC9D0", VA = "0x1808CE3D0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public CBDKABACAFE NOEMNAMDOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA67E80", Offset = "0xA66480", VA = "0x180A67E80", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public COGPNCEBADI HGEOCLDGHDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8CE650", Offset = "0x8CCC50", VA = "0x1808CE650", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public BOAANLGFGMH KMPOMBALKKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xB022F0", Offset = "0xB008F0", VA = "0x180B022F0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public CJHMBLDOBAH ALKCDMGMHKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xB025A0", Offset = "0xB00BA0", VA = "0x180B025A0", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xB9C8A0", Offset = "0xB9AEA0", VA = "0x180B9C8A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private bool AKLJCEGGHPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x6FC72C0", Offset = "0x6FC58C0", VA = "0x186FC72C0", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private bool IMIPIOLJJOD
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6B60", Offset = "0x6FC5160", VA = "0x186FC6B60", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private CancellationToken MLGNLCBLHLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7500", Offset = "0x6FC5B00", VA = "0x186FC7500", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private DIIANKCHAHD LCKECAHJKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action ALBGLDCJLOC
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6F60", Offset = "0x6FC5560", VA = "0x186FC6F60", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6EA0", Offset = "0x6FC54A0", VA = "0x186FC6EA0", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event MNBIJKILACC JENNPHLHAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6BE0", Offset = "0x6FC51E0", VA = "0x186FC6BE0", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6C40", Offset = "0x6FC5240", VA = "0x186FC6C40", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event MNBIJKILACC APDADNKLPPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6F00", Offset = "0x6FC5500", VA = "0x186FC6F00", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6FC0", Offset = "0x6FC55C0", VA = "0x186FC6FC0", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event MNBIJKILACC JEJHGLIBJPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7180", Offset = "0x6FC5780", VA = "0x186FC7180", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6E40", Offset = "0x6FC5440", VA = "0x186FC6E40", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<COKCNCLLNOC, bool> ECADLBIKFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6FC69C0", Offset = "0x6FC4FC0", VA = "0x186FC69C0", Slot = "45")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x6FC71E0", Offset = "0x6FC57E0", VA = "0x186FC71E0", Slot = "46")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0xB9C8A0", Offset = "0xB9AEA0", VA = "0x180B9C8A0", Slot = "36")]
	public void FJLNOEDGMEN(CJHMBLDOBAH OCDIAHEHLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7520", Offset = "0x6FC5B20", VA = "0x186FC7520")]
	[UnityEngine.Scripting.Preserve]
	internal HIFEPLJHNOM([JFHFHOOOEKP(null)] DIIANKCHAHD OMDOLEEBJJJ, [JFHFHOOOEKP(null)] BFABGGACIHJ KJHMNPPBFKI, [JFHFHOOOEKP(null)] NEGLLEIMIKK DICLPHEOIPP, [JFHFHOOOEKP(null)] MPJECKENMPL AHBNABCBLNH, [JFHFHOOOEKP(null)] HEJGCIILPDP KLBLOKAPMFP, [JFHFHOOOEKP(null)] FPIPKCCKKLN KMPHPCBEMCJ, [JFHFHOOOEKP(null)] HNEJFLCABCA GJCBADABBJD, [JFHFHOOOEKP(null)] PHKBEKJCEKE IIMBIIGOAFL, [JFHFHOOOEKP(null)] BKFLIPKCOFF KFFNFEDHGHD, [JFHFHOOOEKP(null)] EHJJOKKDPOE JEEDECENGNB, [JFHFHOOOEKP(null)] HCMBBLCLKIO JPFKNIEEJNF, [JFHFHOOOEKP(null)] MJDBOLGOOKG EMAACFNEBPC, [JFHFHOOOEKP(null)] EOACDJBHABE LKBALMPMNLO, [JFHFHOOOEKP(null)] JHODEIDOEJC NAAKJCDDNOL, [JFHFHOOOEKP(null)] INIFGBCGIKB PIOLMKAPMIN, [JFHFHOOOEKP(null)] PNPOAFOKJJM KPIJOFKJNLM, [JFHFHOOOEKP(null)] LOGBNPPHELH GFILJFMHINF, [JFHFHOOOEKP(null)] EJDHGBPDGNA KEOHAHHIJBD, [JFHFHOOOEKP(null)] NEMHBOGJAOH EPDCJBMJOBL, [JFHFHOOOEKP(null)] KADNCCIKBMN KILDELCNFBI, [JFHFHOOOEKP(null)] ACMNAHKBHOB AOGKGAIPNKD, [JFHFHOOOEKP(null)] MJDDMHHOPKA IDEPOGBFOCE, [JFHFHOOOEKP(null)] HJAEPIOFAGF GEDGNOKECBO, [JFHFHOOOEKP(null)] OHNKHFEPKAP NDNJLKLBMGM, [JFHFHOOOEKP(null)] OLKPLLGGGBP BLAABNOJHKI, [JFHFHOOOEKP(null)] KMKKILBFJCF FFADDNJMIIP, [JFHFHOOOEKP(null)] KDHIFHNDPAK ONMIHKOKFHC, [JFHFHOOOEKP(null)] HHIACAIEMCD OFONHIBANKB, [JFHFHOOOEKP(null)] CBDKABACAFE KCBODFDAHMK, [JFHFHOOOEKP(null)] COGPNCEBADI KECNIMMMKNG, [JFHFHOOOEKP(null)] BOAANLGFGMH EGKEOGBNGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6FC6AB0", Offset = "0x6FC50B0", VA = "0x186FC6AB0")]
	private void BGGINNGCCML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6FC6CA0", Offset = "0x6FC52A0", VA = "0x186FC6CA0", Slot = "55")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7020", Offset = "0x6FC5620", VA = "0x186FC7020", Slot = "49")]
	private void KLCAHLEBHKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7410", Offset = "0x6FC5A10", VA = "0x186FC7410", Slot = "50")]
	private OPANKGMAOKN OJMKFBIMEGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6FC6A20", Offset = "0x6FC5020", VA = "0x186FC6A20", Slot = "51")]
	private CNBPBICCNIL AKIEDGFOOCE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7070", Offset = "0x6FC5670", VA = "0x186FC7070", Slot = "52")]
	[AsyncStateMachine(typeof(CNOFPKJBLOJ))]
	private Task<NFKPBMFAMEB> LOPOPEGMNMC(NKHNFKKJCFE IAHFOGKOOEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7320", Offset = "0x6FC5920", VA = "0x186FC7320", Slot = "53")]
	[AsyncStateMachine(typeof(ANJPJFBHFMH))]
	private Task NMBADEMHFGC(CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7240", Offset = "0x6FC5840", VA = "0x186FC7240")]
	[IteratorStateMachine(typeof(IDMKLCFCNEA))]
	private IEnumerable<BNJANPJILMK> MOGDMJMEIDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6FC74A0", Offset = "0x6FC5AA0", VA = "0x186FC74A0")]
	[CompilerGenerated]
	private void PABPHJJFEAP(BNJANPJILMK ADPKHCOJMDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class DAPDFDMHKLP : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0xEF8290", Offset = "0xEF6890", VA = "0x180EF8290")]
	public DAPDFDMHKLP(string NFOHONOFFAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal class NMJLFEHINLB : EFNOHFJPKBK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct MBGEFANINFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public NMJLFEHINLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x6FD1170", Offset = "0x6FCF770", VA = "0x186FD1170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x6FD14B0", Offset = "0x6FCFAB0", VA = "0x186FD14B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly BCKFHKGPDOK ICKJILCADLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MPJECKENMPL AHBNABCBLNH;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool DDFJJCCIKCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x8677E0", Offset = "0x865DE0", VA = "0x1808677E0")]
	public NMJLFEHINLB(BCKFHKGPDOK ICKJILCADLE, MPJECKENMPL AHBNABCBLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6FD9670", Offset = "0x6FD7C70", VA = "0x186FD9670", Slot = "4")]
	[AsyncStateMachine(typeof(MBGEFANINFL))]
	public Task<bool> CADIDHNJDAH(CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6FD9760", Offset = "0x6FD7D60", VA = "0x186FD9760")]
	[CompilerGenerated]
	private object PIEPKMFIFLB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class BNGGEIEALNH : EFNOHFJPKBK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct KEDLMMKHMMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public BNGGEIEALNH <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6FCB560", Offset = "0x6FC9B60", VA = "0x186FCB560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6FCBC70", Offset = "0x6FCA270", VA = "0x186FCBC70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly BCKFHKGPDOK ICKJILCADLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly MPJECKENMPL AHBNABCBLNH;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private COKFDBDFLII HKODNONBALC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF700", Offset = "0x6FBDD00", VA = "0x186FBF700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool DDFJJCCIKCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x8677E0", Offset = "0x865DE0", VA = "0x1808677E0")]
	public BNGGEIEALNH(BCKFHKGPDOK ICKJILCADLE, MPJECKENMPL AHBNABCBLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x6FBF4F0", Offset = "0x6FBDAF0", VA = "0x186FBF4F0", Slot = "4")]
	[AsyncStateMachine(typeof(KEDLMMKHMMG))]
	public Task<bool> CADIDHNJDAH(CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x6FBF620", Offset = "0x6FBDC20", VA = "0x186FBF620")]
	[CompilerGenerated]
	private object KFMOJLNCIPI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal class MPDENMHNHHM : EFNOHFJPKBK
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class LLPEAHFBOMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public MPDENMHNHHM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public KDOECNFBAGL result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public BNPDOGINEIM newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public LLPEAHFBOMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6FCD3C0", Offset = "0x6FCB9C0", VA = "0x186FCD3C0")]
		internal object DJBBFHFCOHJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6FCD4B0", Offset = "0x6FCBAB0", VA = "0x186FCD4B0")]
		internal object JDGNECFNLIF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6FCD520", Offset = "0x6FCBB20", VA = "0x186FCD520")]
		internal object KLNDPNBFNHG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct HKEELKFLJCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public MPDENMHNHHM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private LLPEAHFBOMP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<KDOECNFBAGL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6FC81A0", Offset = "0x6FC67A0", VA = "0x186FC81A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6FC8AD0", Offset = "0x6FC70D0", VA = "0x186FC8AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly BCKFHKGPDOK ICKJILCADLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly MPJECKENMPL AHBNABCBLNH;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	private COKFDBDFLII HKODNONBALC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6FD2B20", Offset = "0x6FD1120", VA = "0x186FD2B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool DDFJJCCIKCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x8677E0", Offset = "0x865DE0", VA = "0x1808677E0")]
	public MPDENMHNHHM(BCKFHKGPDOK ICKJILCADLE, MPJECKENMPL AHBNABCBLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2A00", Offset = "0x6FD1000", VA = "0x186FD2A00", Slot = "4")]
	[AsyncStateMachine(typeof(HKEELKFLJCA))]
	public Task<bool> CADIDHNJDAH(CancellationToken DADBOHKBJNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal interface EFNOHFJPKBK
{
	[Cpp2IlInjected.Token(Token = "0x17000090")]
	bool DDFJJCCIKCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> CADIDHNJDAH(CancellationToken DADBOHKBJNO);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal struct FNJGJBGODIP
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class CGCDNPMHDOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public BCKFHKGPDOK manager;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public CGCDNPMHDOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF750", Offset = "0x6FBDD50", VA = "0x186FBF750")]
		internal Task PBGOHLHJHNJ(PLBPIEKJMAO data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct JONGKGMJEAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public FNJGJBGODIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private NKHNFKKJCFE <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<NBIEDHEJLMH> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter<NFKPBMFAMEB> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA920", Offset = "0x6FC8F20", VA = "0x186FCA920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6FCAEB0", Offset = "0x6FC94B0", VA = "0x186FCAEB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct HEFODGALBGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public FNJGJBGODIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6640", Offset = "0x6FC4C40", VA = "0x186FC6640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6960", Offset = "0x6FC4F60", VA = "0x186FC6960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly CancellationToken DADBOHKBJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly BCKFHKGPDOK MFNJBGPIIEN;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private BFABGGACIHJ JHMBNIEGNHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6FC42D0", Offset = "0x6FC28D0", VA = "0x186FC42D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private MPJECKENMPL OKAMCKPLNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4710", Offset = "0x6FC2D10", VA = "0x186FC4710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private COKFDBDFLII HKODNONBALC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4480", Offset = "0x6FC2A80", VA = "0x186FC4480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private EHJJOKKDPOE FEEDEFCGPFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4320", Offset = "0x6FC2920", VA = "0x186FC4320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6B30", Offset = "0x1FB5130", VA = "0x181FB6B30")]
	public FNJGJBGODIP(CancellationToken DADBOHKBJNO, BCKFHKGPDOK MFNJBGPIIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6FC4220", Offset = "0x6FC2820", VA = "0x186FC4220")]
	public static HMDLDHAINHE DMHGFJBBFBB(BCKFHKGPDOK MFNJBGPIIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6FC4370", Offset = "0x6FC2970", VA = "0x186FC4370")]
	[AsyncStateMachine(typeof(JONGKGMJEAA))]
	public Task<bool> JGBGEMHOKIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6FC4500", Offset = "0x6FC2B00", VA = "0x186FC4500")]
	private bool NNDNKLHGNMD([Out] NKHNFKKJCFE IAHFOGKOOEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6FC4760", Offset = "0x6FC2D60", VA = "0x186FC4760")]
	[AsyncStateMachine(typeof(HEFODGALBGE))]
	private Task PLBKCKMIBFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6FC40F0", Offset = "0x6FC26F0", VA = "0x186FC40F0")]
	private Task<NBIEDHEJLMH> DEPELMPDJAI(NKHNFKKJCFE FLADPAKDELK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct GONHDJILODE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly INIFGBCGIKB PIOLMKAPMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly Guid PNICJCCCLKL;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private Task<(NFKPBMFAMEB, Task)> OPLHKNPCHBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4B50", Offset = "0x6FC3150", VA = "0x186FC4B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x4297F90", Offset = "0x4296590", VA = "0x184297F90")]
	public GONHDJILODE(INIFGBCGIKB PIOLMKAPMIN, Guid PNICJCCCLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6FC4B00", Offset = "0x6FC3100", VA = "0x186FC4B00")]
	public TaskAwaiter<(NFKPBMFAMEB, Task)> GCIDINGPBLA()
	{
		return default(TaskAwaiter<(NFKPBMFAMEB, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6FC4A30", Offset = "0x6FC3030", VA = "0x186FC4A30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal struct DGJHAGNBNMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly TaskCompletionSource<(NFKPBMFAMEB, Task)> HDGPDEPAOPG;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public Task<(NFKPBMFAMEB, Task)> OPLHKNPCHBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0640", Offset = "0x6FBEC40", VA = "0x186FC0640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0800", Offset = "0x6FBEE00", VA = "0x186FC0800")]
	public DGJHAGNBNMN(TimeSpan MNIKPDPFHJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0760", Offset = "0x6FBED60", VA = "0x186FC0760")]
	public void PICLMNKBJFD(Task DFHGMBELFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6FC05B0", Offset = "0x6FBEBB0", VA = "0x186FC05B0")]
	public void CLBOBOFHOIG(NFKPBMFAMEB PLKNOIJJGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0680", Offset = "0x6FBEC80", VA = "0x186FC0680")]
	public void KAEHGJBOPLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6FC06D0", Offset = "0x6FBECD0", VA = "0x186FC06D0")]
	internal void LBANDGPNGFO(string NFOHONOFFAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class KGPJNCAONJO
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class MNFGKDKMKEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public MDLNFGMEEFD subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public MNFGKDKMKEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x6FD29D0", Offset = "0x6FD0FD0", VA = "0x186FD29D0")]
		internal bool KMEHCOPFKPD(OONHFDBOICP s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC1D0", Offset = "0x6FCA7D0", VA = "0x186FCC1D0")]
	public static HIDIGIEPPEB GIGNPOIHFIA(long ICPNOAIHCPA, long ILOMCKJOFJN, string LGNLNIECDME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC110", Offset = "0x6FCA710", VA = "0x186FCC110")]
	public static HIDIGIEPPEB GIGNPOIHFIA(long ICPNOAIHCPA, long ILOMCKJOFJN, HCMHGKFNLLO KEAPPNMDHKA, long FDJBEKDGJEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6FCBD50", Offset = "0x6FCA350", VA = "0x186FCBD50")]
	public static HIDIGIEPPEB GIGNPOIHFIA(DOIKEIMKJLC JNFJBMNIGEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6FCBEE0", Offset = "0x6FCA4E0", VA = "0x186FCBEE0")]
	public static HIDIGIEPPEB GIGNPOIHFIA(KBIHKJABELE EGJKKOOHDDE, MDLNFGMEEFD PCDIFMLKGPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC260", Offset = "0x6FCA860", VA = "0x186FCC260")]
	public static HIDIGIEPPEB IMPEIEEDMPH(this HIDIGIEPPEB HJCJCIIFPJE, KBIHKJABELE DAAPMNGJCGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC350", Offset = "0x6FCA950", VA = "0x186FCC350")]
	public static HIDIGIEPPEB JHGOPEFJOAB(this HIDIGIEPPEB HJCJCIIFPJE, MDLNFGMEEFD LLEDFHGAOAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[RecRoom.NoEngine.Common.Preserve]
internal class LHBAJAPHBNO : BKFLIPKCOFF, BNJANPJILMK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct MEJIPBKPKIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public LHBAJAPHBNO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private IAOHNBPIHKI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x6FD1870", Offset = "0x6FCFE70", VA = "0x186FD1870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x6FD1F00", Offset = "0x6FD0500", VA = "0x186FD1F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly KHCGFHKKCLN ACFHOJMCGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private string ADDHAADOBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Task MDLGAEBGHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private BCKFHKGPDOK ICKJILCADLE;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool MHJACDNNBAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6FCCFF0", Offset = "0x6FCB5F0", VA = "0x186FCCFF0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public Task CCKAGHIIJAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6FCD180", Offset = "0x6FCB780", VA = "0x186FCD180", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x866500", Offset = "0x864B00", VA = "0x180866500", Slot = "7")]
	public void BGGINNGCCML(BCKFHKGPDOK ICKJILCADLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD020", Offset = "0x6FCB620", VA = "0x186FCD020", Slot = "6")]
	public void NAGADBGAEGI(Task PEBIPFJADEI, string DCFCFOOFAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD210", Offset = "0x6FCB810", VA = "0x186FCD210")]
	[AsyncStateMachine(typeof(MEJIPBKPKIO))]
	private Task PDGCHOABEMK(Task CBCFOFOIDKK, string DCFCFOOFAKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD330", Offset = "0x6FCB930", VA = "0x186FCD330")]
	public LHBAJAPHBNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class DIGCMIJJJEE : ABMMHMOHPPM, BNJANPJILMK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool BPKOOKBNOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private ENLPHOAFKCD LAIHOKFLLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private BFABGGACIHJ KJHMNPPBFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private KMKKILBFJCF FFADDNJMIIP;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public ENLPHOAFKCD ALFEIEGPAHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0DC0", Offset = "0x6FBF3C0", VA = "0x186FC0DC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0990", Offset = "0x6FBEF90", VA = "0x186FC0990", Slot = "7")]
	public void BGGINNGCCML(BCKFHKGPDOK ICKJILCADLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0B10", Offset = "0x6FBF110", VA = "0x186FC0B10", Slot = "5")]
	public void DKKJHMAHIGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0CC0", Offset = "0x6FBF2C0", VA = "0x186FC0CC0", Slot = "6")]
	public void JBJMBFLLEHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0D00", Offset = "0x6FBF300", VA = "0x186FC0D00")]
	private Task IAGOIJNGNMH(LJHNNDEPHHA JLMICGLMAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0CC0", Offset = "0x6FBF2C0", VA = "0x186FC0CC0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public DIGCMIJJJEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class NFHONPCKBPI : KMKKILBFJCF
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	private class LEEAHKPBJDC<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly IMFFKMNFHIF EMPPEOIJCEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly string BHEIPBKEDLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly T AJMLHGDNPEK;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public T BLBBIKKJHJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x8B5660", Offset = "0x8B3C60", VA = "0x1808B5660")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x9B8470", Offset = "0x9B6A70", VA = "0x1809B8470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x42A86B0", Offset = "0x42A6CB0", VA = "0x1842A86B0")]
		public LEEAHKPBJDC(IMFFKMNFHIF EMPPEOIJCEB, string BHEIPBKEDLG, T AJMLHGDNPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x42A8090", Offset = "0x42A6690", VA = "0x1842A8090")]
		private void GIOKPNOIKNM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly IMFFKMNFHIF EMPPEOIJCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly LEEAHKPBJDC<TimeSpan> MDLOEDOAGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly LEEAHKPBJDC<TimeSpan> AACLLBDJGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly LEEAHKPBJDC<TimeSpan> GCIBJIEFGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly LEEAHKPBJDC<TimeSpan> GBLBDLIFKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly LEEAHKPBJDC<bool> LFPGPHDJIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly LEEAHKPBJDC<bool> BDBJAGNJAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly LEEAHKPBJDC<bool> HHFOLLKPMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly LEEAHKPBJDC<int> FAIILLADJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly LEEAHKPBJDC<bool> PBLAJADJEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly LEEAHKPBJDC<bool> KIAKPNNPNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly LEEAHKPBJDC<bool> JEGNFABFPDM;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public TimeSpan PEHJHGFHOLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8500", Offset = "0x6FD6B00", VA = "0x186FD8500", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public TimeSpan EDCFAHKOKKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x6FD84C0", Offset = "0x6FD6AC0", VA = "0x186FD84C0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public TimeSpan CEFJJDHNBEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8700", Offset = "0x6FD6D00", VA = "0x186FD8700", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public TimeSpan KMLOEOBIJEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8680", Offset = "0x6FD6C80", VA = "0x186FD8680", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool ILBFIOJMIKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8640", Offset = "0x6FD6C40", VA = "0x186FD8640", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool IJNAKKDELNM
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8540", Offset = "0x6FD6B40", VA = "0x186FD8540", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool EIJANKLAAOA
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8580", Offset = "0x6FD6B80", VA = "0x186FD8580", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public int MNLGPHOAIOL
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6FD85C0", Offset = "0x6FD6BC0", VA = "0x186FD85C0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool HNBCKHOMGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8740", Offset = "0x6FD6D40", VA = "0x186FD8740", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool CHHDGFOCLCG
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6FD86C0", Offset = "0x6FD6CC0", VA = "0x186FD86C0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool GIOOJEAEPOA
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8600", Offset = "0x6FD6C00", VA = "0x186FD8600", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8780", Offset = "0x6FD6D80", VA = "0x186FD8780")]
	[UnityEngine.Scripting.Preserve]
	public NFHONPCKBPI([JFHFHOOOEKP(null)] IMFFKMNFHIF EMPPEOIJCEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[UnityEngine.Scripting.Preserve]
internal class KJMGMJDFBLC : HCMBBLCLKIO, BNJANPJILMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class PLAACBEKGMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public JGEMMLOJFBN roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public PLAACBEKGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x6FDA4B0", Offset = "0x6FD8AB0", VA = "0x186FDA4B0")]
		internal object APEHIJKFKMI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action BOOOPLKADGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x6FCC970", Offset = "0x6FCAF70", VA = "0x186FCC970", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6FCCBA0", Offset = "0x6FCB1A0", VA = "0x186FCCBA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event MNBIJKILACC CHGFFKAEIOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6FCC6E0", Offset = "0x6FCACE0", VA = "0x186FCC6E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6FCCA10", Offset = "0x6FCB010", VA = "0x186FCCA10", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event MNBIJKILACC NAOCLHJGPLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x6FCC8D0", Offset = "0x6FCAED0", VA = "0x186FCC8D0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x6FCCAB0", Offset = "0x6FCB0B0", VA = "0x186FCCAB0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event MNBIJKILACC LFBCPCHOPIP
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6FCC830", Offset = "0x6FCAE30", VA = "0x186FCC830", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x6FCCF50", Offset = "0x6FCB550", VA = "0x186FCCF50", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<COKCNCLLNOC, bool> FMBBENKHLHL
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x6FCC780", Offset = "0x6FCAD80", VA = "0x186FCC780", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x6FCCE70", Offset = "0x6FCB470", VA = "0x186FCCE70", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "19")]
	public void BGGINNGCCML(BCKFHKGPDOK ICKJILCADLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6FCC4E0", Offset = "0x6FCAAE0", VA = "0x186FCC4E0", Slot = "14")]
	public void APPKHPDACPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6FCCE10", Offset = "0x6FCB410", VA = "0x186FCCE10", Slot = "15")]
	public void NHLCKAGKFJA(JGEMMLOJFBN IPLGFLLPKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6FCCE40", Offset = "0x6FCB440", VA = "0x186FCCE40", Slot = "16")]
	public void PBADFNGHHED(JGEMMLOJFBN IPLGFLLPKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6FCCF20", Offset = "0x6FCB520", VA = "0x186FCCF20", Slot = "17")]
	public void PGDNGOGCPCP(JGEMMLOJFBN IPLGFLLPKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6FCCB50", Offset = "0x6FCB150", VA = "0x186FCCB50", Slot = "18")]
	public void MGIKKPPMCMP(COKCNCLLNOC JHHCMNOMIOL, bool EPAOGDMACAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6FCCC40", Offset = "0x6FCB240", VA = "0x186FCCC40")]
	private void NGOOLELHLHP(MNBIJKILACC FHKGLGIJDMO, JGEMMLOJFBN IPLGFLLPKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public KJMGMJDFBLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[UnityEngine.Scripting.Preserve]
internal class EBGMADLAMNK : MJDBOLGOOKG, BNJANPJILMK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct GPPPFNNLEIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public EBGMADLAMNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private IAOHNBPIHKI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4C20", Offset = "0x6FC3220", VA = "0x186FC4C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC52B0", Offset = "0x6FC38B0", VA = "0x186FC52B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct INLGBFDBEHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public EBGMADLAMNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private IAOHNBPIHKI <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x6FC97D0", Offset = "0x6FC7DD0", VA = "0x186FC97D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA2E0", Offset = "0x6FC88E0", VA = "0x186FCA2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class NLCCMICHILC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public NLCCMICHILC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x6FD9600", Offset = "0x6FD7C00", VA = "0x186FD9600")]
		internal object FBFDCHBADPG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct MFDNCMEECCI : IAsyncStateMachine
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
		public EBGMADLAMNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private NLCCMICHILC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private IAOHNBPIHKI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x6FD1F60", Offset = "0x6FD0560", VA = "0x186FD1F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x6FD26B0", Offset = "0x6FD0CB0", VA = "0x186FD26B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class DALHBNDEGAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public DALHBNDEGAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0540", Offset = "0x6FBEB40", VA = "0x186FC0540")]
		internal object JGHLEOLBNPB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly ICJNMGNJFIN CAJBNIGHKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private BCKFHKGPDOK ICKJILCADLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private MPJECKENMPL AHBNABCBLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private EFNOHFJPKBK[] EOLBFJLGCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private CancellationTokenSource MIOOFKEFBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private CancellationTokenSource DFJPEDGJNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private Task MANJCOMJNDM;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool PJNMNHJLKND
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1B90", Offset = "0x6FC0190", VA = "0x186FC1B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1650", Offset = "0x6FBFC50", VA = "0x186FC1650", Slot = "6")]
	public void BGGINNGCCML(BCKFHKGPDOK ICKJILCADLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6FC17E0", Offset = "0x6FBFDE0", VA = "0x186FC17E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6FC18C0", Offset = "0x6FBFEC0", VA = "0x186FC18C0", Slot = "8")]
	public void GLLCMOEOPNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6FC19E0", Offset = "0x6FBFFE0", VA = "0x186FC19E0", Slot = "5")]
	public void JFFKGIEHMLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x6FC17F0", Offset = "0x6FBFDF0", VA = "0x186FC17F0", Slot = "4")]
	[AsyncStateMachine(typeof(GPPPFNNLEIK))]
	public Task GECCIHIKHMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x6FC16D0", Offset = "0x6FBFCD0", VA = "0x186FC16D0")]
	[AsyncStateMachine(typeof(INLGBFDBEHK))]
	private Task CBIADJJBBCE(CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1340", Offset = "0x6FBF940", VA = "0x186FC1340")]
	private void AFFEEEBAGKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1CA0", Offset = "0x6FC02A0", VA = "0x186FC1CA0")]
	[AsyncStateMachine(typeof(MFDNCMEECCI))]
	private Task<bool> NOOBACBMIND(int LLPJHIPCNFD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1AB0", Offset = "0x6FC00B0", VA = "0x186FC1AB0")]
	private void JOEMHPIGILG(int LLPJHIPCNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1BC0", Offset = "0x6FC01C0", VA = "0x186FC1BC0")]
	private void LGPBGOJDCBE(int LLPJHIPCNFD, bool EPAOGDMACAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1DE0", Offset = "0x6FC03E0", VA = "0x186FC1DE0")]
	private void OOLPDCHNCIG(int LLPJHIPCNFD, Exception CNGGKHFOGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public EBGMADLAMNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[RecRoom.NoEngine.Common.Preserve]
internal class LNEIOAFABAJ : EOACDJBHABE, BNJANPJILMK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct NIHJBPGNDJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public BNPDOGINEIM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public LNEIOAFABAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public CJHMBLDOBAH customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private IAOHNBPIHKI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8C40", Offset = "0x6FD7240", VA = "0x186FD8C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6FD95A0", Offset = "0x6FD7BA0", VA = "0x186FD95A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct HEFDNBLDMFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public LNEIOAFABAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public BNPDOGINEIM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public CJHMBLDOBAH customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private DJJFGNEEIPJ<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private IAOHNBPIHKI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private IPKKJLJAFFM <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private KCCCBPKMLJN <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5A20", Offset = "0x6FC4020", VA = "0x186FC5A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6FC65E0", Offset = "0x6FC4BE0", VA = "0x186FC65E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class EOFKHFJCGJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public Matchmaking.BBJFBDIPLIO result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public OCNFEEFMNOB errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public EOFKHFJCGJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4040", Offset = "0x6FC2640", VA = "0x186FC4040")]
		internal object BGIFIIADKHO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class AIBDFHEAJAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public Task<HIDIGIEPPEB> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public AIBDFHEAJAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0")]
		internal Task<HIDIGIEPPEB> DDAKGIPIFPF(DJJFGNEEIPJ<string>.DIJMCCGECOP _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct NEIIKDDGCLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public LNEIOAFABAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public BNPDOGINEIM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public CJHMBLDOBAH customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public IPKKJLJAFFM joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private AIBDFHEAJAA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private GHDHKPLGDOG <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private IAOHNBPIHKI <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private JPGEAIOKJKE <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private Task<Matchmaking.BEDDJGHMMAI> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private OILPODLNFIL <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private int <i>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private TaskAwaiter<Matchmaking.BEDDJGHMMAI> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private TaskAwaiter<HIDIGIEPPEB> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6FD2B70", Offset = "0x6FD1170", VA = "0x186FD2B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8460", Offset = "0x6FD6A60", VA = "0x186FD8460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct CKMFBCKOJBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public LNEIOAFABAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private IAOHNBPIHKI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF7A0", Offset = "0x6FBDDA0", VA = "0x186FBF7A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6FC01F0", Offset = "0x6FBE7F0", VA = "0x186FC01F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct HBEPODDKNNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public LNEIOAFABAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private DIIANKCHAHD <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5310", Offset = "0x6FC3910", VA = "0x186FC5310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5790", Offset = "0x6FC3D90", VA = "0x186FC5790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct JFAPJKFCDNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public AsyncTaskMethodBuilder<Matchmaking.BEDDJGHMMAI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public BNPDOGINEIM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public LNEIOAFABAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private TaskAwaiter<Matchmaking.BEDDJGHMMAI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA340", Offset = "0x6FC8940", VA = "0x186FCA340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA840", Offset = "0x6FC8E40", VA = "0x186FCA840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct EMIIFKELJMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Matchmaking.BEDDJGHMMAI serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public LNEIOAFABAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public IPKKJLJAFFM joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private IAOHNBPIHKI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private TaskAwaiter<CPNHKBMKJIJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3640", Offset = "0x6FC1C40", VA = "0x186FC3640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3D40", Offset = "0x6FC2340", VA = "0x186FC3D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class FPGEKJNNJEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public BNPDOGINEIM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public FPGEKJNNJEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4830", Offset = "0x6FC2E30", VA = "0x186FC4830")]
		internal object EAMLJAFGMPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4930", Offset = "0x6FC2F30", VA = "0x186FC4930")]
		internal string JFBEOOLPFCP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct APKDNPCLOCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public BNPDOGINEIM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public LNEIOAFABAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private FPGEKJNNJEH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private IAOHNBPIHKI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD9F0", Offset = "0x6FBBFF0", VA = "0x186FBD9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x6FBE5C0", Offset = "0x6FBCBC0", VA = "0x186FBE5C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct NPHAFBEKAGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public LNEIOAFABAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public IPKKJLJAFFM joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public HIDIGIEPPEB initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public BNPDOGINEIM targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public GHDHKPLGDOG progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x6FD9840", Offset = "0x6FD7E40", VA = "0x186FD9840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6FDA150", Offset = "0x6FD8750", VA = "0x186FDA150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct EGDHCHFFAOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public LNEIOAFABAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private IAOHNBPIHKI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private CancellationTokenSource <timeoutTcs>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private CancellationToken <timeoutToken>5__7;

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1FA0", Offset = "0x6FC05A0", VA = "0x186FC1FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6FC35E0", Offset = "0x6FC1BE0", VA = "0x186FC35E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct HKAPCEOOJAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public PLBPIEKJMAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public LNEIOAFABAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private IAOHNBPIHKI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private TaskAwaiter<NFKPBMFAMEB> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7980", Offset = "0x6FC5F80", VA = "0x186FC7980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC8140", Offset = "0x6FC6740", VA = "0x186FC8140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class LOODLNKNBOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public BNPDOGINEIM targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public LOODLNKNBOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3A30", Offset = "0x6FF2030", VA = "0x186FF3A30")]
		internal object DIAMBBGJGGG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class DLNDGIKCLAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public DLNDGIKCLAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x6FE45A0", Offset = "0x6FE2BA0", VA = "0x186FE45A0")]
		internal void JMEEKCBAPGL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class ANHLNLIHPMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public BNPDOGINEIM targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public ANHLNLIHPMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x6FDBB10", Offset = "0x6FDA110", VA = "0x186FDBB10")]
		internal object CFEBDBGPCCK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class EBFNLFDGKMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public BNPDOGINEIM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public EBFNLFDGKMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x6FE50F0", Offset = "0x6FE36F0", VA = "0x186FE50F0")]
		internal string FDJNAPMCIPC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly ICJNMGNJFIN CAJBNIGHKAB;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static readonly ICJNMGNJFIN BAKOBHKALEE;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly ICJNMGNJFIN CDINOBGFFCG;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly ICJNMGNJFIN FNGIBHGEHAE;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static readonly string AJMPKGDFKGN;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static readonly string ENFDAFBOPKC;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static readonly string JIIPOCKODIH;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static readonly Guid FEOBLGEGGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private PHKBEKJCEKE IIMBIIGOAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NEGLLEIMIKK DICLPHEOIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private BFABGGACIHJ KJHMNPPBFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private BCKFHKGPDOK ICKJILCADLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private MPJECKENMPL AHBNABCBLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private MJDBOLGOOKG EMAACFNEBPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private BKFLIPKCOFF KFFNFEDHGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private HCMBBLCLKIO JPFKNIEEJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private COGPNCEBADI KECNIMMMKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private CBDKABACAFE KCBODFDAHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IDisposable DFPMMFGLILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly KHCGFHKKCLN NLLKLAPCMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly KHCGFHKKCLN GACPNNFPHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private OILPODLNFIL BBDFGLCIBPJ;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public TaskStatus FLNHBPEALIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8CE550", Offset = "0x8CCB50", VA = "0x1808CE550", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xC8C580", Offset = "0xC8AB80", VA = "0x180C8C580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private COKFDBDFLII HKODNONBALC
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x6FD0170", Offset = "0x6FCE770", VA = "0x186FD0170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD7F0", Offset = "0x6FCBDF0", VA = "0x186FCD7F0", Slot = "6")]
	public void BGGINNGCCML(BCKFHKGPDOK ICKJILCADLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6FCDE30", Offset = "0x6FCC430", VA = "0x186FCDE30", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6FD01C0", Offset = "0x6FCE7C0", VA = "0x186FD01C0", Slot = "5")]
	[AsyncStateMachine(typeof(NIHJBPGNDJH))]
	public Task LNJCCHGBBND(BNPDOGINEIM KKOAPODKFFE, CJHMBLDOBAH GMIOPCIMFKL, CancellationToken HCOOOCBFMFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF370", Offset = "0x6FCD970", VA = "0x186FCF370")]
	[AsyncStateMachine(typeof(HEFDNBLDMFM))]
	private Task IKAOBAGBENN(BNPDOGINEIM KKOAPODKFFE, CJHMBLDOBAH GMIOPCIMFKL, CancellationToken HCOOOCBFMFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6FCE370", Offset = "0x6FCC970", VA = "0x186FCE370")]
	private static void FKAMHMNCGOF(COGPNCEBADI KECNIMMMKNG, BNPDOGINEIM KKOAPODKFFE, Exception CNGGKHFOGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF8B0", Offset = "0x6FCDEB0", VA = "0x186FCF8B0")]
	private static void KHDMLCJMDGB(KCCCBPKMLJN NLHLLKHINOF, Exception CNGGKHFOGEI, [Optional] List<int> CMDBNEHKMIJ, int ECCNKJHDEIE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6FCDC40", Offset = "0x6FCC240", VA = "0x186FCDC40")]
	[AsyncStateMachine(typeof(NEIIKDDGCLA))]
	private Task DIGDFPEAEJL(DJJFGNEEIPJ<string>.DIJMCCGECOP OPELNCJDKIK, BNPDOGINEIM KKOAPODKFFE, CJHMBLDOBAH GMIOPCIMFKL, IPKKJLJAFFM LDKHCIADJKG, CancellationToken HCOOOCBFMFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6FCDAF0", Offset = "0x6FCC0F0", VA = "0x186FCDAF0")]
	private void CHNPKPDMNBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD6C0", Offset = "0x6FCBCC0", VA = "0x186FCD6C0")]
	[AsyncStateMachine(typeof(CKMFBCKOJBP))]
	private Task AIOBNNDFHJN(DJJFGNEEIPJ<string>.DIJMCCGECOP OPELNCJDKIK, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF040", Offset = "0x6FCD640", VA = "0x186FCF040")]
	private void IEODMHKEKPC(BNPDOGINEIM KKOAPODKFFE, CancellationToken HCOOOCBFMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6FCEE10", Offset = "0x6FCD410", VA = "0x186FCEE10")]
	private void HKDOBNPCHID(BNPDOGINEIM KKOAPODKFFE, IPKKJLJAFFM LDKHCIADJKG, OperationCanceledException BJAJGGADICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6FD0300", Offset = "0x6FCE900", VA = "0x186FD0300")]
	private void LNPJBJPOMHJ(BNPDOGINEIM KKOAPODKFFE, IPKKJLJAFFM LDKHCIADJKG, Exception CNGGKHFOGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6FCE0D0", Offset = "0x6FCC6D0", VA = "0x186FCE0D0")]
	private void EMPCCMKBOEI(BNPDOGINEIM KKOAPODKFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF590", Offset = "0x6FCDB90", VA = "0x186FCF590")]
	private static JGEMMLOJFBN JENFOPKKDNE(BNPDOGINEIM KKOAPODKFFE)
	{
		return default(JGEMMLOJFBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF4C0", Offset = "0x6FCDAC0", VA = "0x186FCF4C0")]
	[AsyncStateMachine(typeof(HBEPODDKNNO))]
	private Task IKCLDNGLOCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6FCE960", Offset = "0x6FCCF60", VA = "0x186FCE960")]
	[AsyncStateMachine(typeof(JFAPJKFCDNO))]
	private Task<Matchmaking.BEDDJGHMMAI> GOPOEPIPPAA(BNPDOGINEIM KKOAPODKFFE, DJJFGNEEIPJ<string>.DIJMCCGECOP OPELNCJDKIK, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6FD0B90", Offset = "0x6FCF190", VA = "0x186FD0B90")]
	private static CPNHKBMKJIJ PJOENIOCMGP(Matchmaking.BEDDJGHMMAI PDGOHHKDHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF5F0", Offset = "0x6FCDBF0", VA = "0x186FCF5F0")]
	[AsyncStateMachine(typeof(EMIIFKELJMK))]
	private Task JFIIKJFFBLG(Matchmaking.BEDDJGHMMAI PDGOHHKDHOJ, IPKKJLJAFFM LDKHCIADJKG, DJJFGNEEIPJ<string>.DIJMCCGECOP OPELNCJDKIK, CancellationToken PECMODKKDDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x6FD0530", Offset = "0x6FCEB30", VA = "0x186FD0530")]
	[AsyncStateMachine(typeof(APKDNPCLOCA))]
	private Task MCIBBMCPNJC(BNPDOGINEIM KKOAPODKFFE, CancellationTokenSource LHMAEABIDLH, Task MGLMFJDOMJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF740", Offset = "0x6FCDD40", VA = "0x186FCF740")]
	[AsyncStateMachine(typeof(NPHAFBEKAGI))]
	private Task JKGLMBFLMAF(HIDIGIEPPEB AAAKHBIFODE, GHDHKPLGDOG FHPOCMIFHMD, BNPDOGINEIM IHOIBKGFKDM, IPKKJLJAFFM NHDGMOICHFB, DJJFGNEEIPJ<string>.DIJMCCGECOP OPELNCJDKIK, CancellationToken BFMNNLOCCHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x6FCDE80", Offset = "0x6FCC480", VA = "0x186FCDE80")]
	private IPKKJLJAFFM EMILLJKDEEE(IPKKJLJAFFM NHDGMOICHFB, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x6FD06D0", Offset = "0x6FCECD0", VA = "0x186FD06D0")]
	[AsyncStateMachine(typeof(EGDHCHFFAOD))]
	private Task MEOOBBIMHEP(DJJFGNEEIPJ<string>.DIJMCCGECOP OPELNCJDKIK, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6FD0A70", Offset = "0x6FCF070", VA = "0x186FD0A70")]
	[AsyncStateMachine(typeof(HKAPCEOOJAC))]
	private Task OHKBAMJBLPK(PLBPIEKJMAO FHNKDHIILBL, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6FD0800", Offset = "0x6FCEE00", VA = "0x186FD0800")]
	private static void MNPALFHGFHL(BNPDOGINEIM KKOAPODKFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x6FCE730", Offset = "0x6FCCD30", VA = "0x186FCE730")]
	private void FPNDMBMPIMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x6FCE2E0", Offset = "0x6FCC8E0", VA = "0x186FCE2E0")]
	private void FEKKHEJNJEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6FCEAC0", Offset = "0x6FCD0C0", VA = "0x186FCEAC0")]
	private void HBNLIOPNOCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x6FCDDA0", Offset = "0x6FCC3A0", VA = "0x186FCDDA0")]
	private void DPNDCJDIOCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x6FD0980", Offset = "0x6FCEF80", VA = "0x186FD0980")]
	private static void NAHMLCKGPPM(BNPDOGINEIM KKOAPODKFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6FCEB50", Offset = "0x6FCD150", VA = "0x186FCEB50")]
	private static CancellationTokenRegistration HCAJLNEEHPJ(BNPDOGINEIM KKOAPODKFFE, CancellationToken PECMODKKDDI)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6FCD5C0", Offset = "0x6FCBBC0", VA = "0x186FCD5C0")]
	private static void ADMAJKLEAJF(BNPDOGINEIM KKOAPODKFFE, Exception CNGGKHFOGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6FCEC60", Offset = "0x6FCD260", VA = "0x186FCEC60")]
	private void HGJJOKOCBCI(BNPDOGINEIM KKOAPODKFFE, Task MGLMFJDOMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x6FCE070", Offset = "0x6FCC670", VA = "0x186FCE070")]
	private static void EMMOGPNJFNP(Func<string> FMMDGAOKDIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x6FD0EC0", Offset = "0x6FCF4C0", VA = "0x186FD0EC0")]
	public LNEIOAFABAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x6FD0670", Offset = "0x6FCEC70", VA = "0x186FD0670")]
	[CompilerGenerated]
	internal static (int, int?) MCMEKLLLCMN(OCNFEEFMNOB NIEIPBDODCM)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[RecRoom.NoEngine.Common.Preserve]
internal class MJNGMCKMEME : JHODEIDOEJC, BNJANPJILMK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct FLAAPFBMEJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public MJNGMCKMEME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public PLBPIEKJMAO roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6FE9050", Offset = "0x6FE7650", VA = "0x186FE9050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6FE94C0", Offset = "0x6FE7AC0", VA = "0x186FE94C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class JCNKDMGPOAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public MJNGMCKMEME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public PLBPIEKJMAO roomData;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public JCNKDMGPOAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0AF0", Offset = "0x6FEF0F0", VA = "0x186FF0AF0")]
		internal List<Task> IPPGFGNAKBN(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct HNMDHHIEDHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public HMDLDHAINHE taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public PLBPIEKJMAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private IAOHNBPIHKI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x6FEDEC0", Offset = "0x6FEC4C0", VA = "0x186FEDEC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE250", Offset = "0x6FEC850", VA = "0x186FEE250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct FMNNAKKEHDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public MJNGMCKMEME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x6FE9520", Offset = "0x6FE7B20", VA = "0x186FE9520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x6FE97E0", Offset = "0x6FE7DE0", VA = "0x186FE97E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private readonly HashSet<HMDLDHAINHE> DBGKDIKGBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private NEGLLEIMIKK DICLPHEOIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private BCKFHKGPDOK ICKJILCADLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private NJJJDPEEPEF BCEIPFDFOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private KHJPBHDJOIA EDKDGAMLPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private IDisposable DFPMMFGLILC;

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6FF43B0", Offset = "0x6FF29B0", VA = "0x186FF43B0", Slot = "5")]
	public void BGGINNGCCML(BCKFHKGPDOK ICKJILCADLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6FF46B0", Offset = "0x6FF2CB0", VA = "0x186FF46B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5320", Offset = "0x6FF3920", VA = "0x186FF5320", Slot = "4")]
	public bool PGLBGNLCPEK(HMDLDHAINHE EKOOEOAOADG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4CA0", Offset = "0x6FF32A0", VA = "0x186FF4CA0")]
	private void MGDMHMBKLFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4AC0", Offset = "0x6FF30C0", VA = "0x186FF4AC0")]
	private void MABOHLIBHOP(PLBPIEKJMAO ENLCDNNHBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4730", Offset = "0x6FF2D30", VA = "0x186FF4730")]
	[AsyncStateMachine(typeof(FLAAPFBMEJO))]
	private Task FMOAHFEBBHG(PLBPIEKJMAO ENLCDNNHBBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x6FF49F0", Offset = "0x6FF2FF0", VA = "0x186FF49F0")]
	private Func<CancellationToken, List<Task>> LHNLAKBKCMI(PLBPIEKJMAO ENLCDNNHBBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4E40", Offset = "0x6FF3440", VA = "0x186FF4E40")]
	private List<Task> OPNJGEHEFNL(PLBPIEKJMAO ENLCDNNHBBD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6FF48D0", Offset = "0x6FF2ED0", VA = "0x186FF48D0")]
	[AsyncStateMachine(typeof(HNMDHHIEDHH))]
	private Task JLOELJCBFOA(HMDLDHAINHE CGMLOOJFLHN, PLBPIEKJMAO FHNKDHIILBL, CancellationToken OEDJKICDDGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4D70", Offset = "0x6FF3370", VA = "0x186FF4D70")]
	[AsyncStateMachine(typeof(FMNNAKKEHDG))]
	private Task MOIHLINBEOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6FF4820", Offset = "0x6FF2E20", VA = "0x186FF4820")]
	private void GLLCMOEOPNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5380", Offset = "0x6FF3980", VA = "0x186FF5380")]
	public MJNGMCKMEME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[UnityEngine.Scripting.Preserve]
internal sealed class BKKLOCIIECO : INIFGBCGIKB, BNJANPJILMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class DCIEDFDMGFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public DCIEDFDMGFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x6FE3E80", Offset = "0x6FE2480", VA = "0x186FE3E80")]
		internal object KAEADFCGLMI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class GDKDFNLPKIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public GDKDFNLPKIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x6FEA890", Offset = "0x6FE8E90", VA = "0x186FEA890")]
		internal object FINANCJJCCA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class AGAGJCFOAON
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public AGAGJCFOAON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class PHOKLALNHAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public PHOKLALNHAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x6FFA5F0", Offset = "0x6FF8BF0", VA = "0x186FFA5F0")]
		internal object CLIAMJLLLEO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class KOOGDFKMNBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public KOOGDFKMNBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x6FF34D0", Offset = "0x6FF1AD0", VA = "0x186FF34D0")]
		internal object FPNCLEKGECF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private readonly Dictionary<Guid, DGJHAGNBNMN> PIOLMKAPMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private readonly TimeSpan AGAABOHLKDO;

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "9")]
	public void BGGINNGCCML(BCKFHKGPDOK ICKJILCADLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x6FDC180", Offset = "0x6FDA780", VA = "0x186FDC180", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6FDC410", Offset = "0x6FDAA10", VA = "0x186FDC410", Slot = "4")]
	public GONHDJILODE MJFEDCBJOBF(Guid PNICJCCCLKL)
	{
		return default(GONHDJILODE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6FDC190", Offset = "0x6FDA790", VA = "0x186FDC190", Slot = "5")]
	public bool GAGDAFIMOPK(Guid PNICJCCCLKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6FDC630", Offset = "0x6FDAC30", VA = "0x186FDC630", Slot = "6")]
	public bool NEALLDFBGKA(Guid PNICJCCCLKL, Task DFHGMBELFIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6FDBFA0", Offset = "0x6FDA5A0", VA = "0x186FDBFA0", Slot = "7")]
	public bool COKJOGGGJCB(Guid PNICJCCCLKL, NFKPBMFAMEB PLKNOIJJGAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6FDC3A0", Offset = "0x6FDA9A0", VA = "0x186FDC3A0", Slot = "8")]
	public Task<(NFKPBMFAMEB, Task)> JPDLLFALOCI(Guid PNICJCCCLKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6FDC960", Offset = "0x6FDAF60", VA = "0x186FDC960")]
	private void NHMMDNGMPBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6FDCB90", Offset = "0x6FDB190", VA = "0x186FDCB90")]
	public BKKLOCIIECO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[RecRoom.NoEngine.Common.Preserve]
internal class ILJBBAMBBOB : PNPOAFOKJJM, BNJANPJILMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private class NNDCGLIDKAF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private readonly BNPDOGINEIM NPOIAAMPBOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private readonly CancellationTokenSource GKNCGENIMLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public readonly CancellationToken EANNOFDJPJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private bool FFPEGMOGJCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private bool KIHONPKCMEM;

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5910", Offset = "0x6FF3F10", VA = "0x186FF5910")]
		public NNDCGLIDKAF(BNPDOGINEIM NPOIAAMPBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x6FF57C0", Offset = "0x6FF3DC0", VA = "0x186FF57C0")]
		public void GLLCMOEOPNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5790", Offset = "0x6FF3D90", VA = "0x186FF5790", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class PMGMALHAMAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public LJHNNDEPHHA disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public PMGMALHAMAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x6FFA650", Offset = "0x6FF8C50", VA = "0x186FFA650")]
		internal object NCFPEEHIADE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct AOHCFBECIHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public LJHNNDEPHHA disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public ILJBBAMBBOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private IAOHNBPIHKI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x6FDBB90", Offset = "0x6FDA190", VA = "0x186FDBB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x6FDBF40", Offset = "0x6FDA540", VA = "0x186FDBF40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class EBPDCBNDCCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public EBPDCBNDCCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x6FE57B0", Offset = "0x6FE3DB0", VA = "0x186FE57B0")]
		internal object PBFDHLPLJBC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct OPGHCKMNIOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public ILJBBAMBBOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private IAOHNBPIHKI <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x6FF7070", Offset = "0x6FF5670", VA = "0x186FF7070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x9F6B90", Offset = "0x9F5190", VA = "0x1809F6B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class FIGJLIOBLBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public BNPDOGINEIM newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public FIGJLIOBLBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8FB0", Offset = "0x6FE75B0", VA = "0x186FE8FB0")]
		internal object OPLFIINOFNI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8F30", Offset = "0x6FE7530", VA = "0x186FE8F30")]
		internal object DGCLOLHIEPK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8F70", Offset = "0x6FE7570", VA = "0x186FE8F70")]
		internal object DGDDHPGDLBG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class HIBHLGCIOIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public HIBHLGCIOIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x6FECAA0", Offset = "0x6FEB0A0", VA = "0x186FECAA0")]
		internal void AOFPCACEBDC()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private struct FDFFHFNKCPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public BNPDOGINEIM newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public ILJBBAMBBOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public CJHMBLDOBAH customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private FIGJLIOBLBP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private IAOHNBPIHKI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x6FE76D0", Offset = "0x6FE5CD0", VA = "0x186FE76D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8650", Offset = "0x6FE6C50", VA = "0x186FE8650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly ICJNMGNJFIN CAJBNIGHKAB;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly EICJPDLOPKL.AHOIBHDCMHK OIEHHBBEJEO;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly GOEEOAIPPMA KGNOGABMDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private NEGLLEIMIKK DICLPHEOIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private BCKFHKGPDOK ICKJILCADLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private MJDBOLGOOKG EMAACFNEBPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private MPJECKENMPL AHBNABCBLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private KMKKILBFJCF FFADDNJMIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private EOACDJBHABE LKBALMPMNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private long BHOOAPODBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private NNDCGLIDKAF ABJIJMLNJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private bool GBONOCDAMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private Task DLBIPBELONB;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	private COKFDBDFLII HKODNONBALC
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x6FEF540", Offset = "0x6FEDB40", VA = "0x186FEF540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool CPDCNHIAKIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x92F0C0", Offset = "0x92D6C0", VA = "0x18092F0C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x6FEF390", Offset = "0x6FED990", VA = "0x186FEF390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE810", Offset = "0x6FECE10", VA = "0x186FEE810", Slot = "4")]
	public void BGGINNGCCML(BCKFHKGPDOK ICKJILCADLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6FEEC00", Offset = "0x6FED200", VA = "0x186FEEC00", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE720", Offset = "0x6FECD20", VA = "0x186FEE720")]
	[AsyncStateMachine(typeof(AOHCFBECIHC))]
	private Task BBMGODCHAAO(LJHNNDEPHHA DEFNHPECHEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF3A0", Offset = "0x6FED9A0", VA = "0x186FEF3A0")]
	private void KAMGHIDJAFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF000", Offset = "0x6FED600", VA = "0x186FEF000")]
	private void IELDCMMKGBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF600", Offset = "0x6FEDC00", VA = "0x186FEF600")]
	private void NCNBLABBMPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF590", Offset = "0x6FEDB90", VA = "0x186FEF590")]
	private bool MBFLOLFJJON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF2C0", Offset = "0x6FED8C0", VA = "0x186FEF2C0")]
	[AsyncStateMachine(typeof(OPGHCKMNIOP))]
	private void JJBECEJHIBF(int AOKMKNGFNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6FEED70", Offset = "0x6FED370", VA = "0x186FEED70")]
	private void HFIGLBGKMFD([Out] IDisposable MKIKLIGCMNH, [Out] IDisposable GCDHGFGLGBD, [Out] IDisposable JOEDNMOLLKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6FEEAB0", Offset = "0x6FED0B0", VA = "0x186FEEAB0")]
	private bool BJLFJGGEGDJ(BNPDOGINEIM NPOIAAMPBOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6FEEBB0", Offset = "0x6FED1B0", VA = "0x186FEEBB0")]
	private void CMJPCDHJCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF190", Offset = "0x6FED790", VA = "0x186FEF190")]
	[AsyncStateMachine(typeof(FDFFHFNKCPK))]
	private Task IKAOBAGBENN(BNPDOGINEIM NPOIAAMPBOJ, CJHMBLDOBAH GMIOPCIMFKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x6FEFB50", Offset = "0x6FEE150", VA = "0x186FEFB50")]
	public ILJBBAMBBOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[UnityEngine.Scripting.Preserve]
internal sealed class GHLNONOOCDE : LOGBNPPHELH, BNJANPJILMK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private struct MMHBGLIMAIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public AsyncTaskMethodBuilder<OBDEAKLOPMH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public GHLNONOOCDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private TaskAwaiter<OBDEAKLOPMH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5410", Offset = "0x6FF3A10", VA = "0x186FF5410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6FF56A0", Offset = "0x6FF3CA0", VA = "0x186FF56A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class IJEBNFPFNAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public ILFKKIOKLHK message;

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public IJEBNFPFNAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE6C0", Offset = "0x6FECCC0", VA = "0x186FEE6C0")]
		internal object GFDIOOKNCFP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class OLOMHBMLPDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public ILFKKIOKLHK messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public OLOMHBMLPDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x6FF7010", Offset = "0x6FF5610", VA = "0x186FF7010")]
		internal object NFBCKAPJAAA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class GGNHNMBHAJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public ILFKKIOKLHK request;

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public GGNHNMBHAJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x6FEAB50", Offset = "0x6FE9150", VA = "0x186FEAB50")]
		internal object IPDKPNEGNIM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct CCKAMOGICJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public ILFKKIOKLHK request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public GHLNONOOCDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private IAOHNBPIHKI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private TaskAwaiter<IKCOGJKNDIG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x6FDFB20", Offset = "0x6FDE120", VA = "0x186FDFB20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x6FE03E0", Offset = "0x6FDE9E0", VA = "0x186FE03E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class KEBAMALHPEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public ILFKKIOKLHK operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public KEBAMALHPEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x6FF18B0", Offset = "0x6FEFEB0", VA = "0x186FF18B0")]
		internal object MHBANAENDHC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct CNCBOAJDOIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public ILFKKIOKLHK operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public GHLNONOOCDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private IAOHNBPIHKI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private IPKKJLJAFFM <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private TaskAwaiter<ILFKKIOKLHK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x6FE2B10", Offset = "0x6FE1110", VA = "0x186FE2B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x6FE3680", Offset = "0x6FE1C80", VA = "0x186FE3680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct IPDBOEDCNFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public AsyncTaskMethodBuilder<IKCOGJKNDIG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public GHLNONOOCDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public ILFKKIOKLHK request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private DLPHFOPFBPP.CGOKNJNKMMO <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private IPKKJLJAFFM <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private TaskAwaiter<ILFKKIOKLHK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x6FEFBC0", Offset = "0x6FEE1C0", VA = "0x186FEFBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x6FF00E0", Offset = "0x6FEE6E0", VA = "0x186FF00E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class HKBFMGIEGFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public IKCOGJKNDIG operation;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public HKBFMGIEGFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x6FEDE40", Offset = "0x6FEC440", VA = "0x186FEDE40")]
		internal object HFFBCDKNKGJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private struct JIBMFKKHOFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public IKCOGJKNDIG operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public GHLNONOOCDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private IAOHNBPIHKI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private DJJFGNEEIPJ<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1070", Offset = "0x6FEF670", VA = "0x186FF1070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x6FF16B0", Offset = "0x6FEFCB0", VA = "0x186FF16B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class OAMLHMIPCNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public ILFKKIOKLHK request;

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public OAMLHMIPCNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5B10", Offset = "0x6FF4110", VA = "0x186FF5B10")]
		internal object FFLGKPCECJM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class LGIOPEINFBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public ILFKKIOKLHK request;

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public LGIOPEINFBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3590", Offset = "0x6FF1B90", VA = "0x186FF3590")]
		internal object KPLOMAIEEME()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private BCKFHKGPDOK ICKJILCADLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private BKFLIPKCOFF KFFNFEDHGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private EJDHGBPDGNA KEOHAHHIJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private MJDDMHHOPKA IDEPOGBFOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private BFABGGACIHJ KJHMNPPBFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private TaskCompletionSource<OBDEAKLOPMH> NBKMCJDBJME;

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB170", Offset = "0x6FE9770", VA = "0x186FEB170", Slot = "7")]
	public void BGGINNGCCML(BCKFHKGPDOK ICKJILCADLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC410", Offset = "0x6FEAA10", VA = "0x186FEC410", Slot = "6")]
	[AsyncStateMachine(typeof(MMHBGLIMAIG))]
	public Task<OBDEAKLOPMH> ONPLLCNIHMI(CancellationToken MJNNLAPANNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB260", Offset = "0x6FE9860", VA = "0x186FEB260", Slot = "4")]
	public void CJDDLNAEDIH(ILFKKIOKLHK NFOHONOFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBE50", Offset = "0x6FEA450", VA = "0x186FEBE50", Slot = "5")]
	public void MDHPBJJLMOL(ILFKKIOKLHK OBPGJNHJMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC1B0", Offset = "0x6FEA7B0", VA = "0x186FEC1B0")]
	[AsyncStateMachine(typeof(CCKAMOGICJD))]
	private Task OFLBNNCBDNN(ILFKKIOKLHK BDMHFDNBPPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBB90", Offset = "0x6FEA190", VA = "0x186FEBB90")]
	[AsyncStateMachine(typeof(CNCBOAJDOIP))]
	private Task EHAMENNLGEN(ILFKKIOKLHK AEKGCHJECPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC2C0", Offset = "0x6FEA8C0", VA = "0x186FEC2C0")]
	[AsyncStateMachine(typeof(IPDBOEDCNFH))]
	private Task<IKCOGJKNDIG> OHBOOBMDDLB(ILFKKIOKLHK BDMHFDNBPPE, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBCA0", Offset = "0x6FEA2A0", VA = "0x186FEBCA0")]
	private IPKKJLJAFFM HNPJLHKBAJJ(ILFKKIOKLHK EFCACLBAGOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBD30", Offset = "0x6FEA330", VA = "0x186FEBD30")]
	[AsyncStateMachine(typeof(JIBMFKKHOFD))]
	private Task JKBDOHKAMOH(IKCOGJKNDIG DNEKMHCKHLJ, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB5F0", Offset = "0x6FE9BF0", VA = "0x186FEB5F0")]
	private IKCOGJKNDIG DDBJGEEEEEM(ILFKKIOKLHK BDMHFDNBPPE, IPKKJLJAFFM AMBGDADIODJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x2B01EE0", Offset = "0x2B004E0", VA = "0x182B01EE0")]
	private T JNPBOOIDLPB<T>(T CBAEIEAPLIH) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB800", Offset = "0x6FE9E00", VA = "0x186FEB800")]
	private IKCOGJKNDIG ECENHEKCCML(ILFKKIOKLHK BDMHFDNBPPE, IPKKJLJAFFM AMBGDADIODJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public GHLNONOOCDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[UnityEngine.Scripting.Preserve]
internal sealed class BOGCEPIECDP : EJDHGBPDGNA, BNJANPJILMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class KHDGGEKENDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public KHDGGEKENDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3140", Offset = "0x6FF1740", VA = "0x186FF3140")]
		internal object GCICGAGBADE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class AHDOKFCIMND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public AHDOKFCIMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x6FDBA60", Offset = "0x6FDA060", VA = "0x186FDBA60")]
		internal object IJPPPNOECFC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private BFABGGACIHJ KJHMNPPBFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private HJAEPIOFAGF GEDGNOKECBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private LOGBNPPHELH GFILJFMHINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private INIFGBCGIKB PIOLMKAPMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private OLKPLLGGGBP BLAABNOJHKI;

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6FDCD70", Offset = "0x6FDB370", VA = "0x186FDCD70", Slot = "6")]
	public void BGGINNGCCML(BCKFHKGPDOK ICKJILCADLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x6FDD9C0", Offset = "0x6FDBFC0", VA = "0x186FDD9C0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x6FDDA70", Offset = "0x6FDC070", VA = "0x186FDDA70", Slot = "4")]
	public GONHDJILODE EEDEGBKILON(ILFKKIOKLHK OCNINHACHEI)
	{
		return default(GONHDJILODE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x6FDE580", Offset = "0x6FDCB80", VA = "0x186FDE580", Slot = "5")]
	public void MKPJDKFELMG(Guid PNICJCCCLKL, Task DFHGMBELFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x6FDE790", Offset = "0x6FDCD90", VA = "0x186FDE790")]
	private void OABHEPOLHHD(byte DKBJDCFDNLF, int DGMGNCFDIHK, object LDACPAAEKGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x6FDD190", Offset = "0x6FDB790", VA = "0x186FDD190")]
	private void DFPIHHDDBAI(AFMIHJILGAJ PHGGMGHAANF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x6FDE860", Offset = "0x6FDCE60", VA = "0x186FDE860")]
	private void PAJGNBLCMOB(AFMIHJILGAJ PHGGMGHAANF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x6FDE0C0", Offset = "0x6FDC6C0", VA = "0x186FDE0C0")]
	private void IEIKIAKBMPJ(AFMIHJILGAJ PHGGMGHAANF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x6FDEB70", Offset = "0x6FDD170", VA = "0x186FDEB70")]
	private NFKPBMFAMEB PEHIFABBBCA(ILFKKIOKLHK EFCACLBAGOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x6FDDEB0", Offset = "0x6FDC4B0", VA = "0x186FDDEB0")]
	private void HJGOEMNDFNN(ILFKKIOKLHK AEKGCHJECPC, NFKPBMFAMEB PLKNOIJJGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x6FDCEE0", Offset = "0x6FDB4E0", VA = "0x186FDCEE0")]
	private bool CFIJBKIDGMN(ILFKKIOKLHK AEKGCHJECPC, NFKPBMFAMEB PLKNOIJJGAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x6FDE300", Offset = "0x6FDC900", VA = "0x186FDE300")]
	private bool ILPJMJLBDAL(ILFKKIOKLHK EGEINKCAJGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x6FDD730", Offset = "0x6FDBD30", VA = "0x186FDD730")]
	private bool DIAHAGFMDAK(byte DKBJDCFDNLF, ExitGames.Client.Photon.Hashtable PHGGMGHAANF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public BOGCEPIECDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[UnityEngine.Scripting.Preserve]
internal sealed class POCBNIDJKDE : NEMHBOGJAOH, BNJANPJILMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class JLPDAMPMAIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public OBDEAKLOPMH operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public POCBNIDJKDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public ILFKKIOKLHK roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public JLPDAMPMAIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1840", Offset = "0x6FEFE40", VA = "0x186FF1840")]
		internal object PCDLKKJKNEP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1710", Offset = "0x6FEFD10", VA = "0x186FF1710")]
		internal object HKAAANICCPB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct OIPOIMLLEJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public AsyncTaskMethodBuilder<NFKPBMFAMEB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public POCBNIDJKDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public ILFKKIOKLHK roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private IAOHNBPIHKI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter<NFKPBMFAMEB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6910", Offset = "0x6FF4F10", VA = "0x186FF6910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6FA0", Offset = "0x6FF55A0", VA = "0x186FF6FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class AAEKGLKADAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public OBDEAKLOPMH operationType;

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public AAEKGLKADAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x6FDB0F0", Offset = "0x6FD96F0", VA = "0x186FDB0F0")]
		internal object JLDFEHDHDBK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class NNIHPNGILNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public ILFKKIOKLHK request;

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public NNIHPNGILNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5AA0", Offset = "0x6FF40A0", VA = "0x186FF5AA0")]
		internal object JKBLILAGFPJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x6FF59C0", Offset = "0x6FF3FC0", VA = "0x186FF59C0")]
		internal object BPBNGGCJNBL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5A30", Offset = "0x6FF4030", VA = "0x186FF5A30")]
		internal object ILGKLLBNGAD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct PGPAOPLFKDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public AsyncTaskMethodBuilder<NFKPBMFAMEB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public ILFKKIOKLHK request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public POCBNIDJKDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private NNIHPNGILNE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private IAOHNBPIHKI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private GONHDJILODE <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private NFKPBMFAMEB <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private TaskAwaiter<(NFKPBMFAMEB validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8E60", Offset = "0x6FF7460", VA = "0x186FF8E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x6FF9710", Offset = "0x6FF7D10", VA = "0x186FF9710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private BFABGGACIHJ KJHMNPPBFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private HJAEPIOFAGF GEDGNOKECBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private EJDHGBPDGNA KEOHAHHIJBD;

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x6FFA6E0", Offset = "0x6FF8CE0", VA = "0x186FFA6E0", Slot = "5")]
	public void BGGINNGCCML(BCKFHKGPDOK ICKJILCADLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x6FFAAC0", Offset = "0x6FF90C0", VA = "0x186FFAAC0", Slot = "4")]
	[AsyncStateMachine(typeof(OIPOIMLLEJA))]
	private Task<NFKPBMFAMEB> PIPOKMLEMAN(ILFKKIOKLHK EFCACLBAGOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x6FFA790", Offset = "0x6FF8D90", VA = "0x186FFA790")]
	private bool EEMOEJOFBKE(OBDEAKLOPMH JHHCMNOMIOL, [Out] NFKPBMFAMEB HJBJAPKPPFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x6FFA980", Offset = "0x6FF8F80", VA = "0x186FFA980")]
	[AsyncStateMachine(typeof(PGPAOPLFKDI))]
	private Task<NFKPBMFAMEB> MHKHCMJBCCJ(ILFKKIOKLHK BDMHFDNBPPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public POCBNIDJKDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class DNNKMBKKDLJ : KADNCCIKBMN, BNJANPJILMK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private struct ODJJHGOPEGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<HIDIGIEPPEB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public BNPDOGINEIM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public DNNKMBKKDLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private TaskAwaiter<KBIHKJABELE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<HIDIGIEPPEB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5C50", Offset = "0x6FF4250", VA = "0x186FF5C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6220", Offset = "0x6FF4820", VA = "0x186FF6220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class CBGOIFGGAHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public CBGOIFGGAHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x6FDF280", Offset = "0x6FDD880", VA = "0x186FDF280")]
		internal object PBPELGHFPMI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct DIMGBKGBOMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public AsyncTaskMethodBuilder<KBIHKJABELE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public DNNKMBKKDLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public BNPDOGINEIM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private CBGOIFGGAHN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private TaskAwaiter<KBIHKJABELE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x6FE3F40", Offset = "0x6FE2540", VA = "0x186FE3F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x6FE4530", Offset = "0x6FE2B30", VA = "0x186FE4530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct JHBCEFCHLEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public AsyncTaskMethodBuilder<HIDIGIEPPEB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public DNNKMBKKDLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public BNPDOGINEIM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public KBIHKJABELE roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private TaskAwaiter<(HCMHGKFNLLO superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x6FF0BA0", Offset = "0x6FEF1A0", VA = "0x186FF0BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1000", Offset = "0x6FEF600", VA = "0x186FF1000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class ELNADBGJKEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public ELNADBGJKEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x943810", Offset = "0x941E10", VA = "0x180943810")]
		internal bool JJIKMEOIDEH(OONHFDBOICP sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct CGLKOGOKFLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public AsyncTaskMethodBuilder<(HCMHGKFNLLO superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public KBIHKJABELE roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public DNNKMBKKDLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public BNPDOGINEIM targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private TaskAwaiter<(HCMHGKFNLLO superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x6FE0550", Offset = "0x6FDEB50", VA = "0x186FE0550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x6FE0BF0", Offset = "0x6FDF1F0", VA = "0x186FE0BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class DANGLPEAAIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public DANGLPEAAIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x6FE36E0", Offset = "0x6FE1CE0", VA = "0x186FE36E0")]
		internal object NLFLKKANLCB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct EPGFBALAKDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public AsyncTaskMethodBuilder<(HCMHGKFNLLO superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public OONHFDBOICP subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public DNNKMBKKDLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public BNPDOGINEIM dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private DANGLPEAAIB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private TaskAwaiter<FDFIFNJEENA<MDLNFGMEEFD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6870", Offset = "0x6FE4E70", VA = "0x186FE6870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6FF0", Offset = "0x6FE55F0", VA = "0x186FE6FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private static readonly (HCMHGKFNLLO superRoomData, long subRoomDataSaveId) ODGCENANGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private MPJECKENMPL AHBNABCBLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private BOAANLGFGMH EGKEOGBNGFH;

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x6FE4640", Offset = "0x6FE2C40", VA = "0x186FE4640", Slot = "5")]
	public void BGGINNGCCML(BCKFHKGPDOK ICKJILCADLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x6FE4830", Offset = "0x6FE2E30", VA = "0x186FE4830", Slot = "4")]
	[AsyncStateMachine(typeof(ODJJHGOPEGA))]
	public Task<HIDIGIEPPEB> ELFFKCOHBOH(DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, BNPDOGINEIM KKOAPODKFFE, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x6FE46D0", Offset = "0x6FE2CD0", VA = "0x186FE46D0")]
	[AsyncStateMachine(typeof(DIMGBKGBOMD))]
	private Task<KBIHKJABELE> BLKBAOGGEDO(BNPDOGINEIM KKOAPODKFFE, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE4990", Offset = "0x6FE2F90", VA = "0x186FE4990")]
	[AsyncStateMachine(typeof(JHBCEFCHLEB))]
	private Task<HIDIGIEPPEB> FKGCLIEHGID(BNPDOGINEIM KKOAPODKFFE, KBIHKJABELE DPMMJNEEKNM, long JDAJCIDAAMB, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE4C70", Offset = "0x6FE3270", VA = "0x186FE4C70")]
	[AsyncStateMachine(typeof(CGLKOGOKFLJ))]
	private Task<(HCMHGKFNLLO, long)> JMHKJILOGEG(BNPDOGINEIM KKOAPODKFFE, KBIHKJABELE DPMMJNEEKNM, long JDAJCIDAAMB, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x6FE4B00", Offset = "0x6FE3100", VA = "0x186FE4B00")]
	[AsyncStateMachine(typeof(EPGFBALAKDK))]
	private Task<(HCMHGKFNLLO, long)> GBPAHNBEFMM(BNPDOGINEIM PHMGKPDFJCL, OONHFDBOICP EHIBGNOFBHI, long JDAJCIDAAMB, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public DNNKMBKKDLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[UnityEngine.Scripting.Preserve]
internal sealed class JCBDEIPCIAK : MJDDMHHOPKA, BNJANPJILMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class GCJCAFOJKAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public ILFKKIOKLHK request;

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public GCJCAFOJKAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x6FEA830", Offset = "0x6FE8E30", VA = "0x186FEA830")]
		internal object HCJLEPEFBLH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct OFOJLGCPCAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public AsyncTaskMethodBuilder<ILFKKIOKLHK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public ILFKKIOKLHK request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public JCBDEIPCIAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public IPKKJLJAFFM pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private IAOHNBPIHKI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private TaskAwaiter<ILFKKIOKLHK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6290", Offset = "0x6FF4890", VA = "0x186FF6290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x6FF68A0", Offset = "0x6FF4EA0", VA = "0x186FF68A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct FBGJAOAEGEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder<ILFKKIOKLHK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public JCBDEIPCIAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public IPKKJLJAFFM pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private IAOHNBPIHKI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private TaskAwaiter<EHNHPFOEBGC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x6FE7060", Offset = "0x6FE5660", VA = "0x186FE7060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x6FE7660", Offset = "0x6FE5C60", VA = "0x186FE7660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private sealed class LABEFNFPDJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public ILFKKIOKLHK request;

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public LABEFNFPDJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3530", Offset = "0x6FF1B30", VA = "0x186FF3530")]
		internal object IEFPOPKOKEH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct PBMFEFHNLHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AsyncTaskMethodBuilder<ILFKKIOKLHK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public ILFKKIOKLHK request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public JCBDEIPCIAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public IPKKJLJAFFM pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private IAOHNBPIHKI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private CCFCAIEEDHG <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private OFIPOIHCJPD <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private TaskAwaiter<EHNHPFOEBGC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8200", Offset = "0x6FF6800", VA = "0x186FF8200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8DF0", Offset = "0x6FF73F0", VA = "0x186FF8DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private BFABGGACIHJ KJHMNPPBFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private ABMMHMOHPPM DGALHOBPLKO;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	private ENLPHOAFKCD ALFEIEGPAHD
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x6FF06A0", Offset = "0x6FEECA0", VA = "0x186FF06A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x6FF0150", Offset = "0x6FEE750", VA = "0x186FF0150", Slot = "8")]
	public void BGGINNGCCML(BCKFHKGPDOK ICKJILCADLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x6FF0990", Offset = "0x6FEEF90", VA = "0x186FF0990", Slot = "4")]
	[AsyncStateMachine(typeof(OFOJLGCPCAK))]
	public Task<ILFKKIOKLHK> OBKHPCIAFLF(ILFKKIOKLHK BDMHFDNBPPE, IPKKJLJAFFM AMBGDADIODJ, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x6FF0550", Offset = "0x6FEEB50", VA = "0x186FF0550", Slot = "5")]
	[AsyncStateMachine(typeof(FBGJAOAEGEP))]
	public Task<ILFKKIOKLHK> KFJMDJMGKEK(CancellationToken DADBOHKBJNO, IPKKJLJAFFM AMBGDADIODJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x6FF01E0", Offset = "0x6FEE7E0", VA = "0x186FF01E0", Slot = "6")]
	public HJBBHPAONAL BLNKFDFDPOM(IKCOGJKNDIG KIBKEBAGKGA, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x6FF0760", Offset = "0x6FEED60", VA = "0x186FF0760", Slot = "7")]
	public HJBBHPAONAL NOADNDANCEJ(IKCOGJKNDIG KIBKEBAGKGA, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x6FF03F0", Offset = "0x6FEE9F0", VA = "0x186FF03F0")]
	[AsyncStateMachine(typeof(PBMFEFHNLHK))]
	private Task<ILFKKIOKLHK> GJKPKHHEOAO(ILFKKIOKLHK BDMHFDNBPPE, IPKKJLJAFFM AMBGDADIODJ, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x2B0D830", Offset = "0x2B0BE30", VA = "0x182B0D830")]
	private static byte[] GPEJKGAHFMJ(ILFKKIOKLHK NFOHONOFFAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public JCBDEIPCIAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[UnityEngine.Scripting.Preserve]
internal sealed class DCBBJKPKBEK : HJAEPIOFAGF, BNJANPJILMK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private FPIPKCCKKLN KMPHPCBEMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private BFABGGACIHJ KJHMNPPBFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private BKFLIPKCOFF KFFNFEDHGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private ACMNAHKBHOB AOGKGAIPNKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private MPJECKENMPL AHBNABCBLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private EOACDJBHABE LKBALMPMNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private JHODEIDOEJC NAAKJCDDNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private KMKKILBFJCF FFADDNJMIIP;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	private COKFDBDFLII HKODNONBALC
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x6FE3AD0", Offset = "0x6FE20D0", VA = "0x186FE3AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private static NFKPBMFAMEB ODLJDHNBHLE
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x6FE3A70", Offset = "0x6FE2070", VA = "0x186FE3A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x6FE3790", Offset = "0x6FE1D90", VA = "0x186FE3790", Slot = "6")]
	public void BGGINNGCCML(BCKFHKGPDOK ICKJILCADLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x6FE3900", Offset = "0x6FE1F00", VA = "0x186FE3900", Slot = "4")]
	public NFKPBMFAMEB DLOCBMCACIG(NMCPPAKMEBO KPBDJLELCAF, OBDEAKLOPMH PGPOPMKEFPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE3B20", Offset = "0x6FE2120", VA = "0x186FE3B20", Slot = "5")]
	public NFKPBMFAMEB LAGJDEIOJOI(NMCPPAKMEBO FKMPKKEKGIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x6FE3E20", Offset = "0x6FE2420", VA = "0x186FE3E20")]
	private static NFKPBMFAMEB PAGKAKMONFO(FDBDPAGJBNM CLPBFEAPBCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public DCBBJKPKBEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class AMFLLKMDOLJ : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x6FDBAD0", Offset = "0x6FDA0D0", VA = "0x186FDBAD0")]
	public AMFLLKMDOLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x648ED20", Offset = "0x648D320", VA = "0x18648ED20")]
	public AMFLLKMDOLJ(string NFOHONOFFAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[UnityEngine.Scripting.Preserve]
internal sealed class FOKIKGLFGBP : EHJJOKKDPOE, BNJANPJILMK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct KEGFADAHDKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public AsyncTaskMethodBuilder<NFKPBMFAMEB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public FOKIKGLFGBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public NKHNFKKJCFE autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private DJJFGNEEIPJ<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private KLJAAHFBDMA <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private TaskAwaiter<NFKPBMFAMEB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1910", Offset = "0x6FEFF10", VA = "0x186FF1910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x6FF24A0", Offset = "0x6FF0AA0", VA = "0x186FF24A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct KGKMLMHCHAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public FOKIKGLFGBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x6FF2990", Offset = "0x6FF0F90", VA = "0x186FF2990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x6FF30E0", Offset = "0x6FF16E0", VA = "0x186FF30E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct CKBIIMLNJLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public FOKIKGLFGBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x6FE23A0", Offset = "0x6FE09A0", VA = "0x186FE23A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x6FE28B0", Offset = "0x6FE0EB0", VA = "0x186FE28B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct MFBCJFLEHPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public FOKIKGLFGBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3C00", Offset = "0x6FF2200", VA = "0x186FF3C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x6FF4350", Offset = "0x6FF2950", VA = "0x186FF4350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct CMNMLGBDMDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public FOKIKGLFGBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x6FE2910", Offset = "0x6FE0F10", VA = "0x186FE2910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x6FE2AB0", Offset = "0x6FE10B0", VA = "0x186FE2AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct EENHBPECPCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public FOKIKGLFGBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x6FE5820", Offset = "0x6FE3E20", VA = "0x186FE5820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x6FE5F40", Offset = "0x6FE4540", VA = "0x186FE5F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct BPOOOHCAKHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public FOKIKGLFGBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x6FDEDB0", Offset = "0x6FDD3B0", VA = "0x186FDEDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x6FDF220", Offset = "0x6FDD820", VA = "0x186FDF220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct EBHKBCBOCFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public FOKIKGLFGBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public MJNMLCHIOPD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private DJJFGNEEIPJ<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x6FE51F0", Offset = "0x6FE37F0", VA = "0x186FE51F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x6FE5750", Offset = "0x6FE3D50", VA = "0x186FE5750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private BFABGGACIHJ KJHMNPPBFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private BCKFHKGPDOK ICKJILCADLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private MPJECKENMPL AHBNABCBLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private MJDDMHHOPKA IDEPOGBFOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private BKFLIPKCOFF KFFNFEDHGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private JHODEIDOEJC NAAKJCDDNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private CancellationTokenSource AGFBLKEEAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private Task LMHMGDKDLGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private TaskCompletionSource<int> GMAGCNMIMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private int GAKFBNAPEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private int JFOJAFCCEHP;

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9950", Offset = "0x6FE7F50", VA = "0x186FE9950", Slot = "6")]
	public void BGGINNGCCML(BCKFHKGPDOK ICKJILCADLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0xA81060", Offset = "0xA7F660", VA = "0x180A81060", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA660", Offset = "0x6FE8C60", VA = "0x186FEA660")]
	private void OPPGHAGLLII(float OFNAKIBLKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA530", Offset = "0x6FE8B30", VA = "0x186FEA530", Slot = "4")]
	[AsyncStateMachine(typeof(KEGFADAHDKB))]
	public Task<NFKPBMFAMEB> ODIHPINJHHJ(NKHNFKKJCFE IAHFOGKOOEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA740", Offset = "0x6FE8D40", VA = "0x186FEA740", Slot = "5")]
	[AsyncStateMachine(typeof(KGKMLMHCHAF))]
	public Task PLECKACEEJE([Optional] CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0xA81060", Offset = "0xA7F660", VA = "0x180A81060")]
	public void HCKFEEDBNLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA230", Offset = "0x6FE8830", VA = "0x186FEA230")]
	private KLJAAHFBDMA NFPOCFJPOHB(NKHNFKKJCFE IAHFOGKOOEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA140", Offset = "0x6FE8740", VA = "0x186FEA140")]
	[AsyncStateMachine(typeof(CKBIIMLNJLO))]
	private Task JPHDANJDIMN(PLBPIEKJMAO JLMICGLMAKN, CancellationToken HCOOOCBFMFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9C00", Offset = "0x6FE8200", VA = "0x186FE9C00")]
	[AsyncStateMachine(typeof(MFBCJFLEHPM))]
	private Task HCJGDFAEHEJ(CancellationToken HCOOOCBFMFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA050", Offset = "0x6FE8650", VA = "0x186FEA050")]
	[AsyncStateMachine(typeof(CMNMLGBDMDK))]
	private Task JKADPOJDDJI([Optional] CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9F60", Offset = "0x6FE8560", VA = "0x186FE9F60")]
	[AsyncStateMachine(typeof(EENHBPECPCF))]
	private Task IDDPAMLKCKG(CancellationToken HCOOOCBFMFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9B00", Offset = "0x6FE8100", VA = "0x186FE9B00")]
	[AsyncStateMachine(typeof(BPOOOHCAKHH))]
	private Task EOKGNBHCHPP(CancellationToken LDIEJJGNEMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA3A0", Offset = "0x6FE89A0", VA = "0x186FEA3A0")]
	private Task NIKNOMMOBLD(MJNMLCHIOPD BBHKMFMMNIP, CancellationToken HCOOOCBFMFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9840", Offset = "0x6FE7E40", VA = "0x186FE9840")]
	[AsyncStateMachine(typeof(EBHKBCBOCFC))]
	private Task BBKOADLHCJP(MJNMLCHIOPD BBHKMFMMNIP, CancellationToken HCOOOCBFMFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9D00", Offset = "0x6FE8300", VA = "0x186FE9D00")]
	private bool HIDDGLIMKHK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public FOKIKGLFGBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[UnityEngine.Scripting.Preserve]
internal class GJEHAOAJMFA : ACMNAHKBHOB, BNJANPJILMK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private struct GGOGJPPPPMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public GJEHAOAJMFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private DJJFGNEEIPJ<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x6FEABB0", Offset = "0x6FE91B0", VA = "0x186FEABB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x6FEB110", Offset = "0x6FE9710", VA = "0x186FEB110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private HNEJFLCABCA GJCBADABBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private BCKFHKGPDOK ICKJILCADLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	private HJAEPIOFAGF GEDGNOKECBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	private MJDDMHHOPKA IDEPOGBFOCE;

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC520", Offset = "0x6FEAB20", VA = "0x186FEC520", Slot = "6")]
	public void BGGINNGCCML(BCKFHKGPDOK ICKJILCADLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC800", Offset = "0x6FEAE00", VA = "0x186FEC800", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC8B0", Offset = "0x6FEAEB0", VA = "0x186FEC8B0", Slot = "5")]
	[AsyncStateMachine(typeof(GGOGJPPPPMD))]
	public Task LHMEMBFJAKD(string AKCHJOKAGJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC850", Offset = "0x6FEAE50", VA = "0x186FEC850", Slot = "4")]
	public NFKPBMFAMEB HIDDGLIMKHK(NMCPPAKMEBO KPBDJLELCAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC9B0", Offset = "0x6FEAFB0", VA = "0x186FEC9B0")]
	private CKGNPEPDJII OKOAKDPDNKN(string AKCHJOKAGJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public GJEHAOAJMFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public static class EGHOAKJOBNC
{
	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5FA0", Offset = "0x6FE45A0", VA = "0x186FE5FA0")]
	public static void HBDLMGCNILB(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x6FE61E0", Offset = "0x6FE47E0", VA = "0x186FE61E0")]
	internal static void HOBCHAEADBJ(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6340", Offset = "0x6FE4940", VA = "0x186FE6340")]
	internal static void MANLNJECAIO(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6420", Offset = "0x6FE4A20", VA = "0x186FE6420")]
	internal static void OPAPBABLKGE(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal class FFDBGEGFPLF : FEOEEDLGMKH<ILFKKIOKLHK>
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class HOENLDJFPML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public ILFKKIOKLHK message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public HOENLDJFPML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE2B0", Offset = "0x6FEC8B0", VA = "0x186FEE2B0")]
		internal object NLFPEKIDEPD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly FFDBGEGFPLF IBMHAACFGKI;

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8DC0", Offset = "0x6FE73C0", VA = "0x186FE8DC0")]
	public ExitGames.Client.Photon.Hashtable KLDBPIDHOEH(ILFKKIOKLHK NFOHONOFFAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x6FE87C0", Offset = "0x6FE6DC0", VA = "0x186FE87C0", Slot = "5")]
	protected override void ENPPEGKBDHH(ILFKKIOKLHK NFOHONOFFAP, IDictionary<object, object> FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x6FE88F0", Offset = "0x6FE6EF0", VA = "0x186FE88F0", Slot = "6")]
	public override ILFKKIOKLHK JGNOLJBBCJA(IDictionary<object, object> FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x6FE86B0", Offset = "0x6FE6CB0", VA = "0x186FE86B0")]
	private static void EMMOGPNJFNP(string DOLDDKPNFFE, ILFKKIOKLHK NFOHONOFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8EF0", Offset = "0x6FE74F0", VA = "0x186FE8EF0")]
	public FFDBGEGFPLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8B20", Offset = "0x6FE7120", VA = "0x186FE8B20")]
	[CompilerGenerated]
	internal static string KJPLNPEHIHJ(HIDIGIEPPEB HJCJCIIFPJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public static class KFMALFFBPGO
{
	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public static NFKPBMFAMEB ODLJDHNBHLE
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x6FE3A70", Offset = "0x6FE2070", VA = "0x186FE3A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2770", Offset = "0x6FF0D70", VA = "0x186FF2770")]
	public static bool JCKLJKFGDLO(this NFKPBMFAMEB PLKNOIJJGAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x6FE3E20", Offset = "0x6FE2420", VA = "0x186FE3E20")]
	public static NFKPBMFAMEB PAGKAKMONFO(FDBDPAGJBNM EBOADEMOCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2790", Offset = "0x6FF0D90", VA = "0x186FF2790")]
	public static NFKPBMFAMEB OFGMNBJMFEL(IEnumerable<NFKPBMFAMEB> HDDIBIDNCJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2510", Offset = "0x6FF0B10", VA = "0x186FF2510")]
	public static string GDIJEEKKNEF(this NFKPBMFAMEB HJBJAPKPPFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public abstract class LKGCGOPIMJJ : HALHDOEHAMI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public delegate NFKPBMFAMEB MGNNJNLGBHE([NotNull] NMCPPAKMEBO BKINHCMAEFK);

	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private sealed class AKGPBIPMBHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public NMCPPAKMEBO photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public AKGPBIPMBHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x66AECE0", Offset = "0x66AD2E0", VA = "0x1866AECE0")]
		internal NFKPBMFAMEB DDMCNIBHNFH(MGNNJNLGBHE v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private bool MMNAIEEGDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	protected readonly HashSet<MGNNJNLGBHE> GJMNGLPOEAJ;

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x6FF35F0", Offset = "0x6FF1BF0", VA = "0x186FF35F0", Slot = "4")]
	public void BLACMHFDGDJ(MGNNJNLGBHE BAFABGKFEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x6FF36A0", Offset = "0x6FF1CA0", VA = "0x186FF36A0", Slot = "5")]
	public void GGLLHMDJIGP(MGNNJNLGBHE BAFABGKFEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3650", Offset = "0x6FF1C50", VA = "0x186FF3650", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3700", Offset = "0x6FF1D00", VA = "0x186FF3700")]
	protected NFKPBMFAMEB HEAKFNBKMHH(NMCPPAKMEBO FKMPKKEKGIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x6FF39A0", Offset = "0x6FF1FA0", VA = "0x186FF39A0")]
	protected LKGCGOPIMJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class CEAMAMPEEAK : LKGCGOPIMJJ, FPIPKCCKKLN, HALHDOEHAMI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private sealed class KHLABGKINOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public NFKPBMFAMEB result;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public KHLABGKINOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3470", Offset = "0x6FF1A70", VA = "0x186FF3470")]
		internal object AGLPEOOKDKL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x6FDCD60", Offset = "0x6FDB360", VA = "0x186FDCD60")]
	[UnityEngine.Scripting.Preserve]
	public CEAMAMPEEAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6FE0440", Offset = "0x6FDEA40", VA = "0x186FE0440", Slot = "8")]
	public NFKPBMFAMEB POGJMMMEEHH(NMCPPAKMEBO FKMPKKEKGIC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class BNLILODPHHO : LKGCGOPIMJJ, HNEJFLCABCA, HALHDOEHAMI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private sealed class DDKGMLJLBFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public NFKPBMFAMEB result;

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public DDKGMLJLBFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x6FE3EE0", Offset = "0x6FE24E0", VA = "0x186FE3EE0")]
		internal object FLLMAINLAHB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x6FDCD60", Offset = "0x6FDB360", VA = "0x186FDCD60")]
	[UnityEngine.Scripting.Preserve]
	public BNLILODPHHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x6FDCC50", Offset = "0x6FDB250", VA = "0x186FDCC50", Slot = "8")]
	public NFKPBMFAMEB HIDDGLIMKHK(NMCPPAKMEBO OFANFPAHCFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal static class GELDNGECFJJ
{
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private sealed class NKHLDHNGKOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public DJJFGNEEIPJ<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public NKHLDHNGKOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5710", Offset = "0x6FF3D10", VA = "0x186FF5710")]
		internal object MGNPEAMPMGL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA9B0", Offset = "0x6FE8FB0", VA = "0x186FEA9B0")]
	public static DJJFGNEEIPJ<string> FAKCGBNBCOI(ICJNMGNJFIN CAJBNIGHKAB, [Optional] string KCHDIPBIBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA8F0", Offset = "0x6FE8EF0", VA = "0x186FEA8F0")]
	public static void EAKLFHAIIMG(DJJFGNEEIPJ<string> OPELNCJDKIK, ICJNMGNJFIN CAJBNIGHKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x6FEAA90", Offset = "0x6FE9090", VA = "0x186FEAA90")]
	public static string GMGKNCNDFJG(ILFKKIOKLHK EFCACLBAGOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal static class PPDPNCDEGNL
{
	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x6FFAD10", Offset = "0x6FF9310", VA = "0x186FFAD10")]
	public static void GHNBKPMBMPK(this BFABGGACIHJ KJHMNPPBFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x6FFAD00", Offset = "0x6FF9300", VA = "0x186FFAD00")]
	public static void FBIPHGNKOBD(this BFABGGACIHJ KJHMNPPBFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x6FFABE0", Offset = "0x6FF91E0", VA = "0x186FFABE0")]
	private static void EDNJBELAOEC(this BFABGGACIHJ KJHMNPPBFKI, bool DOLOFEOHFJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public class AGALFIEMGIF : KKAINCKHGJC, IBFOKJMNDNJ, OBDMGCOMFAH, BNBMPGKPEIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	private readonly IBFOKJMNDNJ OBGBFJMPNJP;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public NMCPPAKMEBO EGNMAFKFFFA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x6FDBA10", Offset = "0x6FDA010", VA = "0x186FDBA10", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int DMAAPFEGPPP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x6FDB4F0", Offset = "0x6FD9AF0", VA = "0x186FDB4F0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public int OKKEHECKHII
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x6FDB540", Offset = "0x6FD9B40", VA = "0x186FDB540", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool OGPLEDGKMGP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public int ILILDIGGIJK
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x8E43B0", Offset = "0x8E29B0", VA = "0x1808E43B0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event PCBLDEMOMCD.HLABFCAGEJI LJBKOPHCGIA
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event LHPCHHNCOEE NHFALKKMGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x6FDB7F0", Offset = "0x6FD9DF0", VA = "0x186FDB7F0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x6FDB590", Offset = "0x6FD9B90", VA = "0x186FDB590", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> DEPPKAFBEID
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<NMCPPAKMEBO> APAHHADGACM
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action NKINGNCGJIE
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x6FDB750", Offset = "0x6FD9D50", VA = "0x186FDB750", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x6FDB970", Offset = "0x6FD9F70", VA = "0x186FDB970", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0xCB3720", Offset = "0xCB1D20", VA = "0x180CB3720")]
	public AGALFIEMGIF(IBFOKJMNDNJ OBGBFJMPNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x6FDB680", Offset = "0x6FD9C80", VA = "0x186FDB680", Slot = "8")]
	public bool FBEOAGDFCNN(byte DKBJDCFDNLF, ExitGames.Client.Photon.Hashtable KFFHIDGGIJK, BEDMKFCADEJ LANJHNJOOBH, SendOptions IBGCLNOPPFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x6FDB890", Offset = "0x6FD9E90", VA = "0x186FDB890", Slot = "16")]
	public NMCPPAKMEBO NEKOHLLMEPI(int EGHHENCPOKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "19")]
	public void BDHNODFDDLI(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "20")]
	public void IGCBNFMLIHO(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "21")]
	public void BLGFFLONGHE(object OEDJKICDDGA, bool JLJBKAOLCLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x6FDB630", Offset = "0x6FD9C30", VA = "0x186FDB630", Slot = "22")]
	public IDisposable EBFOPLAPBCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0", Slot = "23")]
	private bool EBLPEEELLHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "24")]
	public void EJEHDPNJPJG(StringBuilder HMLOLOIKMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x6FDB730", Offset = "0x6FD9D30", VA = "0x186FDB730", Slot = "25")]
	public bool GOJIOADOOGK(bool ECPPLGGAAEK, [Out] string JCBCIJOKIDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x97C6A0", Offset = "0x97ACA0", VA = "0x18097C6A0", Slot = "28")]
	public void NHPLKFNGCLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal struct AFMIHJILGAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	private readonly IDictionary<object, object> PHGGMGHAANF;

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x9368D0", Offset = "0x934ED0", VA = "0x1809368D0")]
	public AFMIHJILGAJ(IDictionary<object, object> PHGGMGHAANF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x6FDB210", Offset = "0x6FD9810", VA = "0x186FDB210")]
	public bool GDEICJAJMDE([Out] ILFKKIOKLHK NFOHONOFFAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x6FDB160", Offset = "0x6FD9760", VA = "0x186FDB160")]
	public Guid ELFMBNACBIM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x6FDB3B0", Offset = "0x6FD99B0", VA = "0x186FDB3B0")]
	public NFKPBMFAMEB NBLIMNPMJBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x6FDB2C0", Offset = "0x6FD98C0", VA = "0x186FDB2C0")]
	public static ExitGames.Client.Photon.Hashtable GIGNPOIHFIA(ILFKKIOKLHK NFOHONOFFAP, NFKPBMFAMEB PLKNOIJJGAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal static class JFKCGBHHHME
{
	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x6FF0B20", Offset = "0x6FEF120", VA = "0x186FF0B20")]
	public static bool GKLPOCHPMAL(this BNPDOGINEIM JKCIOCOHNMH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal struct KHJPBHDJOIA : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct DPCKIDENCHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public KHJPBHDJOIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x6FE4EB0", Offset = "0x6FE34B0", VA = "0x186FE4EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x6FE5090", Offset = "0x6FE3690", VA = "0x186FE5090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	private readonly CancellationTokenSource GKNCGENIMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400031E")]
	private bool MMNAIEEGDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	private Task PEBIPFJADEI;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool DJDJJCHPPBF
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x6FF31B0", Offset = "0x6FF17B0", VA = "0x186FF31B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3340", Offset = "0x6FF1940", VA = "0x186FF3340")]
	public KHJPBHDJOIA(CancellationToken DADBOHKBJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3230", Offset = "0x6FF1830", VA = "0x186FF3230")]
	[AsyncStateMachine(typeof(DPCKIDENCHJ))]
	public Task PHINEPMEDPF(Func<CancellationToken, List<Task>> BBOCNPPPBOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x6FF31E0", Offset = "0x6FF17E0", VA = "0x186FF31E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public readonly struct HOIMEPFKGDB<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct ANEDHNPOFMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<LAONMFHHBKK<TData>, FNFMNGCMHCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public HOIMEPFKGDB<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private TaskAwaiter<PIJKHLBEMKP<LAONMFHHBKK<TData>, FNFMNGCMHCP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x3E77210", Offset = "0x3E75810", VA = "0x183E77210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x3E77E10", Offset = "0x3E76410", VA = "0x183E77E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private readonly HDMACEANEIK<TGetDataArg, TData> GNFPFODOMGM;

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x9368D0", Offset = "0x934ED0", VA = "0x1809368D0")]
	internal HOIMEPFKGDB(HDMACEANEIK<TGetDataArg, TData> OJGLDAGFLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x3DF4390", Offset = "0x3DF2990", VA = "0x183DF4390")]
	[AsyncStateMachine(typeof(HOIMEPFKGDB<, >.ANEDHNPOFMH))]
	public Task<PIJKHLBEMKP<LAONMFHHBKK<TData>, FNFMNGCMHCP>> OABGKGIGHAA(TGetDataArg HFLBLCMJIKA, string AHDJEMAEEHJ, DJJFGNEEIPJ<string>.DIJMCCGECOP OPELNCJDKIK, CancellationToken DADBOHKBJNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public static class LIKFPLGNLMH
{
	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x2A4EC40", Offset = "0x2A4D240", VA = "0x182A4EC40")]
	public static HOIMEPFKGDB<TGetDataArg, TData> HCLFOFEHDJP<TGetDataArg, TData>(HDMACEANEIK<TGetDataArg, TData> OJGLDAGFLKC)
	{
		return default(HOIMEPFKGDB<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public struct OCNFEEFMNOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public readonly int KLFOAHAAGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public readonly int? LADKOCFGCCJ;

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x4298500", Offset = "0x4296B00", VA = "0x184298500")]
	public OCNFEEFMNOB(int KEFHKMFECFI, [Optional] int? ALHDJIIOEOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5B70", Offset = "0x6FF4170", VA = "0x186FF5B70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public interface CBIPIPLKCNJ<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NOENMMLIJPJ();

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CBIPIPLKCNJ<T> DEBBHDCMDDI(string EPLFNDNPINO);

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CBIPIPLKCNJ<T> EBNOJBDGJDD(JFPAEAFALEP<T> MOGEPDBNPKH);

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CBIPIPLKCNJ<T> BIDKEEMANAH(int NIEIPBDODCM);

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CBIPIPLKCNJ<T> AGKIKPGJOCD(int NIEIPBDODCM, KNOEOLBNKHJ<T> FKDCLJFIBOO);
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public interface COGPNCEBADI
{
	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CBIPIPLKCNJ<T> JKDOAEOAPMJ<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IAOMEFNOPDD KHEHEHDLLHD(Exception CNGGKHFOGEI);

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OCNFEEFMNOB EMCMNBGECBJ(Exception CNGGKHFOGEI);
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public delegate string JFPAEAFALEP<in T>(T CNGGKHFOGEI) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public delegate int KNOEOLBNKHJ<in T>(T CNGGKHFOGEI) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000E3")]
internal class CJCJHLONGKG : COGPNCEBADI
{
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	private delegate string AAJHKIMCBED(Exception CNGGKHFOGEI);

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private delegate int DLBMNEALOMK(Exception CNGGKHFOGEI);

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private class NNGEOIHOMNL<T> : CBIPIPLKCNJ<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[CompilerGenerated]
		private sealed class NJGALELNPEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public NJGALELNPEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0")]
			internal string OEHKCPIPFPA(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		[CompilerGenerated]
		private sealed class NAIEGDACCOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public JFPAEAFALEP<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public NAIEGDACCOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x452F840", Offset = "0x452DE40", VA = "0x18452F840")]
			internal string GKELMKPIFPG(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		[CompilerGenerated]
		private sealed class BNGDIEGFIPJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public KNOEOLBNKHJ<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public BNGDIEGFIPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x452F840", Offset = "0x452DE40", VA = "0x18452F840")]
			internal int JFGNFKKOHDN(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private readonly CJCJHLONGKG KECNIMMMKNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		private readonly Type KFLHHAAEKMF;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x457B220", Offset = "0x4579820", VA = "0x18457B220")]
		internal NNGEOIHOMNL(CJCJHLONGKG KECNIMMMKNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x457B1F0", Offset = "0x45797F0", VA = "0x18457B1F0", Slot = "4")]
		public void NOENMMLIJPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x457AFB0", Offset = "0x45795B0", VA = "0x18457AFB0", Slot = "5")]
		public CBIPIPLKCNJ<T> DEBBHDCMDDI(string EPLFNDNPINO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x457B0D0", Offset = "0x45796D0", VA = "0x18457B0D0", Slot = "6")]
		public CBIPIPLKCNJ<T> EBNOJBDGJDD(JFPAEAFALEP<T> MOGEPDBNPKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x457AF70", Offset = "0x4579570", VA = "0x18457AF70", Slot = "7")]
		public CBIPIPLKCNJ<T> BIDKEEMANAH(int NIEIPBDODCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x457AE30", Offset = "0x4579430", VA = "0x18457AE30", Slot = "8")]
		public CBIPIPLKCNJ<T> AGKIKPGJOCD(int NIEIPBDODCM, KNOEOLBNKHJ<T> FKDCLJFIBOO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	private class AOIJDGIHPEK<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private bool NILEMKFCMDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private readonly List<Type> LOGHIDDDIHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private readonly Dictionary<Type, TVal> DJDPLLMFNJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private readonly Dictionary<Type, int> NJAOBPJOABL;

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public IReadOnlyList<Type> FKAPIIDAFJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x3E7C950", Offset = "0x3E7AF50", VA = "0x183E7C950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x3E7CD10", Offset = "0x3E7B310", VA = "0x183E7CD10")]
		public AOIJDGIHPEK(Dictionary<Type, int> NJAOBPJOABL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x3E7CA10", Offset = "0x3E7B010", VA = "0x183E7CA10")]
		public void MJFEDCBJOBF(Type BHEIPBKEDLG, TVal LECBAKCNNCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C690", Offset = "0x3E7AC90", VA = "0x183E7C690")]
		public bool APACMNFKPAP(Type KFLHHAAEKMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x3E7CB90", Offset = "0x3E7B190", VA = "0x183E7CB90")]
		public bool OPOGKFMEAHP(TVal CBAEIEAPLIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C6F0", Offset = "0x3E7ACF0", VA = "0x183E7C6F0")]
		public TVal BDJJCDMMBKL(Type PBLNJHEPKAE)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C750", Offset = "0x3E7AD50", VA = "0x183E7C750")]
		[CompilerGenerated]
		private int GFDJCFHCMMG(Type AMECDBHOIID, Type MDFPKAOFDAL)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private sealed class CBKBIBKBAHP : IEnumerable<OCNFEEFMNOB>, IEnumerable, IEnumerator<OCNFEEFMNOB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private OCNFEEFMNOB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public CJCJHLONGKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private IEnumerator<OCNFEEFMNOB> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		private OCNFEEFMNOB System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0x3899AB0", Offset = "0x38980B0", VA = "0x183899AB0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(OCNFEEFMNOB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x6FDF980", Offset = "0x6FDDF80", VA = "0x186FDF980", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x8BC660", Offset = "0x8BAC60", VA = "0x1808BC660")]
		[DebuggerHidden]
		public CBKBIBKBAHP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x6FDF9D0", Offset = "0x6FDDFD0", VA = "0x186FDF9D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x6FDF380", Offset = "0x6FDD980", VA = "0x186FDF380", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x6FDF820", Offset = "0x6FDDE20", VA = "0x186FDF820")]
		private void PEOGCCBKFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x6FDF330", Offset = "0x6FDD930", VA = "0x186FDF330")]
		private void LAOHPFDNJCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x6FDF930", Offset = "0x6FDDF30", VA = "0x186FDF930", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x6FDF870", Offset = "0x6FDDE70", VA = "0x186FDF870", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OCNFEEFMNOB> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x6FDF870", Offset = "0x6FDDE70", VA = "0x186FDF870", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private static readonly OCNFEEFMNOB MBIEKMDAFGJ;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private static readonly Dictionary<Type, int> OHFFAIHHJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private readonly HashSet<Type> OHKMPNPFDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private readonly AOIJDGIHPEK<int> JPAHEBLKLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private readonly AOIJDGIHPEK<DLBMNEALOMK> IMCHDPNPOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private readonly AOIJDGIHPEK<AAJHKIMCBED> OFNOBCOBIGC;

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x6FE1AD0", Offset = "0x6FE00D0", VA = "0x186FE1AD0")]
	[PECFDJPHGEK(BOIKMOKIOJG.GameOnly)]
	private static void KOPFFNBBLLA(DIIANKCHAHD MEBNPCGEJCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x6FE2060", Offset = "0x6FE0660", VA = "0x186FE2060")]
	[RecRoom.NoEngine.Common.Preserve]
	public CJCJHLONGKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x291FA00", Offset = "0x291E000", VA = "0x18291FA00", Slot = "4")]
	public CBIPIPLKCNJ<T> JKDOAEOAPMJ<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE1A40", Offset = "0x6FE0040", VA = "0x186FE1A40", Slot = "5")]
	public IAOMEFNOPDD KHEHEHDLLHD(Exception CNGGKHFOGEI)
	{
		return default(IAOMEFNOPDD);
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE0C60", Offset = "0x6FDF260", VA = "0x186FE0C60", Slot = "6")]
	public OCNFEEFMNOB EMCMNBGECBJ(Exception? CNGGKHFOGEI)
	{
		return default(OCNFEEFMNOB);
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x6FE1EF0", Offset = "0x6FE04F0", VA = "0x186FE1EF0", Slot = "7")]
	[IteratorStateMachine(typeof(CBKBIBKBAHP))]
	public IEnumerable<OCNFEEFMNOB> PNMBIGMJLFN(Exception CNGGKHFOGEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x6FE1620", Offset = "0x6FDFC20", VA = "0x186FE1620", Slot = "8")]
	public string HEKEKONKOOH(Exception? CNGGKHFOGEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x6FE0F40", Offset = "0x6FDF540", VA = "0x186FE0F40")]
	private string FEHLIMCFDNL(AggregateException PKPBHNEGAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x6FE1B40", Offset = "0x6FE0140", VA = "0x186FE1B40")]
	private void OLPNDIDGJLN(Type KFLHHAAEKMF, int NIEIPBDODCM, DLBMNEALOMK? GLHOEKDDPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x6FE1250", Offset = "0x6FDF850", VA = "0x186FE1250")]
	private void FKBNBMNKGJK(Type KFLHHAAEKMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x6FE1770", Offset = "0x6FDFD70", VA = "0x186FE1770")]
	private void HLJEKLLMLPF(Type KFLHHAAEKMF, AAJHKIMCBED JNICIDDIJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x6FE14A0", Offset = "0x6FDFAA0", VA = "0x186FE14A0")]
	private static int HAKGIGLAIDE(Type KFLHHAAEKMF, Dictionary<Type, int> NJAOBPJOABL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x291F5F0", Offset = "0x291DBF0", VA = "0x18291F5F0")]
	private static bool EPDAMBGPONN<TVal>(AOIJDGIHPEK<TVal> CNNODMDOLAC, Type KFLHHAAEKMF, [Out] TVal CBAEIEAPLIH) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x6FE0E60", Offset = "0x6FDF460", VA = "0x186FE0E60")]
	[CompilerGenerated]
	internal static int FCJODNDHGCI(Type CMKIFHHILLA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public struct IAOMEFNOPDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public readonly OCNFEEFMNOB MOEMFHOLLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public readonly string KBFPGKKCFEO;

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE6A0", Offset = "0x6FECCA0", VA = "0x186FEE6A0")]
	public IAOMEFNOPDD(string PKLAMLPAIPE, OCNFEEFMNOB NIEIPBDODCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE600", Offset = "0x6FECC00", VA = "0x186FEE600")]
	public string AGLLCOFGHPL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class PHKBEKJCEKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private readonly LCAGPDDFOEC CHGDHKICCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private string BLJPJBHLNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private long? IEJJHFEIAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private long? BEKGOCIEKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private long? LKDKDMBBIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private string APJAKNPPIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private DMHGCACCENH OCNIBKDJOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private long? NICNDBONFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private bool BLKPICGAIAC;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public string MLBBDDFHKKP
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public long GCBECFCHGHF
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x6FF9C00", Offset = "0x6FF8200", VA = "0x186FF9C00")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public long CMEAMIMHIPA
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x6FFA550", Offset = "0x6FF8B50", VA = "0x186FFA550")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public long NLBEFJKLACK
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x6FF9780", Offset = "0x6FF7D80", VA = "0x186FF9780")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public string GBLKFMEBHBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x6FF9D00", Offset = "0x6FF8300", VA = "0x186FF9D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public DMHGCACCENH EEMABJGDECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0xA6A1D0", Offset = "0xA687D0", VA = "0x180A6A1D0")]
		get
		{
			return default(DMHGCACCENH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x6FF9B10", Offset = "0x6FF8110", VA = "0x186FF9B10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public long LIKPKEMDDNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x6FF97E0", Offset = "0x6FF7DE0", VA = "0x186FF97E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x6FFA5B0", Offset = "0x6FF8BB0", VA = "0x186FFA5B0")]
	[UnityEngine.Scripting.Preserve]
	public PHKBEKJCEKE([JFHFHOOOEKP(null)] LCAGPDDFOEC CHGDHKICCKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x6FF98C0", Offset = "0x6FF7EC0", VA = "0x186FF98C0")]
	private void FKLKKBCLEIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x6FFA0C0", Offset = "0x6FF86C0", VA = "0x186FFA0C0")]
	public void PCJFMHAOHID(long NBDDMFOIEKN, long JDAJCIDAAMB, [Optional] long? HFCDLHABEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9C60", Offset = "0x6FF8260", VA = "0x186FF9C60")]
	public void HBAAHPIMGMI(long HFCDLHABEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9840", Offset = "0x6FF7E40", VA = "0x186FF9840")]
	public void FIPJCKGKGHF(string LJJOFJIKNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9D40", Offset = "0x6FF8340", VA = "0x186FF9D40")]
	public void OPLBACEHACH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
internal class HJBBHPAONAL : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct HJLNAIEHCKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public AsyncTaskMethodBuilder<ILFKKIOKLHK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public ILFKKIOKLHK roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public HJBBHPAONAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private TaskAwaiter<ENLPHOAFKCD.OFAJLIEILFA<ILFKKIOKLHK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x70026A0", Offset = "0x7000CA0", VA = "0x1870026A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x7002AA0", Offset = "0x70010A0", VA = "0x187002AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct DMBAODBADNO<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class LCGCDOKPBAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public ILFKKIOKLHK roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public LCGCDOKPBAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x7007450", Offset = "0x7005A50", VA = "0x187007450")]
		internal ILFKKIOKLHK AOGJGKDPBPE(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct LJPMFGEHKHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public AsyncTaskMethodBuilder<ENLPHOAFKCD.OFAJLIEILFA<ILFKKIOKLHK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public ILFKKIOKLHK roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public HJBBHPAONAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private CCFCAIEEDHG <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private TaskAwaiter<ENLPHOAFKCD.OFAJLIEILFA<ILFKKIOKLHK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x7007F80", Offset = "0x7006580", VA = "0x187007F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x7008590", Offset = "0x7006B90", VA = "0x187008590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct NFHMLEECLAF<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public HJBBHPAONAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x45458E0", Offset = "0x4543EE0", VA = "0x1845458E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x3548D80", Offset = "0x3547380", VA = "0x183548D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct POIKPLJDHFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public HJBBHPAONAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x7010DD0", Offset = "0x700F3D0", VA = "0x187010DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x7010F90", Offset = "0x700F590", VA = "0x187010F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class GAAGDKBCJFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public GAAGDKBCJFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x7000230", Offset = "0x6FFE830", VA = "0x187000230")]
		internal object NFEDDPFCIKE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x7000170", Offset = "0x6FFE770", VA = "0x187000170")]
		internal bool BPCLHEPLIBD(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class FCHEJFBDPCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public FCHEJFBDPCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x6FFE5D0", Offset = "0x6FFCBD0", VA = "0x186FFE5D0")]
		internal object CJBKDPJJGCL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class CAGHHPHIIFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public CAGHHPHIIFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x6FFC380", Offset = "0x6FFA980", VA = "0x186FFC380")]
		internal object FDCKOPFHEPK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class FHDCMGCBLAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public FHDCMGCBLAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x6FFEF60", Offset = "0x6FFD560", VA = "0x186FFEF60")]
		internal object HHJHNAPHEFE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class CPKHPLMBOBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public HJBBHPAONAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public CPKHPLMBOBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x6FFC5B0", Offset = "0x6FFABB0", VA = "0x186FFC5B0")]
		internal object NLFPEKIDEPD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private static readonly Guid DAOMAAPHPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public readonly IKCOGJKNDIG KPBNJNNOKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private readonly ENLPHOAFKCD IOLAONNIAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private readonly OBDMGCOMFAH KJHMNPPBFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private readonly BNBMPGKPEIB NBLDAMNOKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private bool KCFMAMHKABO;

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x6FEDC10", Offset = "0x6FEC210", VA = "0x186FEDC10")]
	public HJBBHPAONAL(IKCOGJKNDIG DNEKMHCKHLJ, ENLPHOAFKCD IOLAONNIAEO, OBDMGCOMFAH KJHMNPPBFKI, BNBMPGKPEIB NBLDAMNOKGA, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x6FECBC0", Offset = "0x6FEB1C0", VA = "0x186FECBC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x6FECBC0", Offset = "0x6FEB1C0", VA = "0x186FECBC0")]
	public void AHMOKCIBBEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x6FED6B0", Offset = "0x6FEBCB0", VA = "0x186FED6B0")]
	public void HJJMGENNFIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x6FED5F0", Offset = "0x6FEBBF0", VA = "0x186FED5F0")]
	public void GHAMCPEPMGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x6FED880", Offset = "0x6FEBE80", VA = "0x186FED880")]
	[AsyncStateMachine(typeof(HJLNAIEHCKP))]
	internal Task<ILFKKIOKLHK> NALMIOMAPLA(DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, ILFKKIOKLHK EFCACLBAGOG, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2B0D830", Offset = "0x2B0BE30", VA = "0x182B0D830")]
	private static byte[] AFHLJHEJHIE<T>(T NFOHONOFFAP) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x2B0DE80", Offset = "0x2B0C480", VA = "0x182B0DE80")]
	private static T NPGDMOCOMBB<T>(MessageParser<T> MDOMMNAFODK, byte[] NFOHONOFFAP, T MODONOEGFJM) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x6FED380", Offset = "0x6FEB980", VA = "0x186FED380")]
	[AsyncStateMachine(typeof(LJPMFGEHKHN))]
	private Task<ENLPHOAFKCD.OFAJLIEILFA<ILFKKIOKLHK>> EPGAFLMFLML(ILFKKIOKLHK EFCACLBAGOG, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x2B0D840", Offset = "0x2B0BE40", VA = "0x182B0D840")]
	[AsyncStateMachine(typeof(NFHMLEECLAF<>))]
	internal Task<T> FBMLEBLEDDH<T>(CancellationToken HCOOOCBFMFM, Func<CancellationToken, Task<T>> KDPBPPHLMNJ, int AJAHJHKFGIJ = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x6FED4C0", Offset = "0x6FEBAC0", VA = "0x186FED4C0")]
	[AsyncStateMachine(typeof(POIKPLJDHFC))]
	internal Task FBMLEBLEDDH(CancellationToken HCOOOCBFMFM, Func<CancellationToken, Task> KDPBPPHLMNJ, int AJAHJHKFGIJ = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x6FEDB20", Offset = "0x6FEC120", VA = "0x186FEDB20")]
	public BODFPDOHLLO PPMHMFIOMOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x6FECB40", Offset = "0x6FEB140", VA = "0x186FECB40")]
	public ICKHBOINCDE ADDOINJHDGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x6FED010", Offset = "0x6FEB610", VA = "0x186FED010")]
	public BLGAAKAOAIK EEKEKGHONGH([Optional] ICJNMGNJFIN? CAJBNIGHKAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x6FECD30", Offset = "0x6FEB330", VA = "0x186FECD30")]
	public void BKCDGPAPMDE(Func<Guid, bool> JDHDCKBJAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x6FED160", Offset = "0x6FEB760", VA = "0x186FED160")]
	public void EKFEEMDFLPJ(Func<Guid, bool> PABPIHDLFKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x6FECE90", Offset = "0x6FEB490", VA = "0x186FECE90")]
	public Guid DAHEICECLKE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x6FED770", Offset = "0x6FEBD70", VA = "0x186FED770")]
	public void MLDDKICBILO(Guid GJICKHKJJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x6FED9E0", Offset = "0x6FEBFE0", VA = "0x186FED9E0")]
	public void NLDOJBHOOFD(ILFKKIOKLHK EELFCGHJEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x6FED270", Offset = "0x6FEB870", VA = "0x186FED270")]
	public void EMMOGPNJFNP(string BBEECMIBLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x2B0DD90", Offset = "0x2B0C390", VA = "0x182B0DD90")]
	private T JNPBOOIDLPB<T>(T CBAEIEAPLIH) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x6FECCE0", Offset = "0x6FEB2E0", VA = "0x186FECCE0")]
	public void BEEJMLAFOMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x2B0DAE0", Offset = "0x2B0C0E0", VA = "0x182B0DAE0")]
	[CompilerGenerated]
	internal static string FOHCKBCHAFE<T>(byte[] JFDEDKFKPOF, int EFEECMADLHE, DMBAODBADNO<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
internal sealed class IFAMEGOMHPO : IKCOGJKNDIG
{
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class OMCIDGBFCHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public OMCIDGBFCHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x7010D60", Offset = "0x700F360", VA = "0x187010D60")]
		internal object KHJIJLCBBPO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private struct FDEFOBKGJJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public IFAMEGOMHPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public HJBBHPAONAL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private APFHDOCKBNE <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private ICKHBOINCDE <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x6FFE630", Offset = "0x6FFCC30", VA = "0x186FFE630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x6FFEF00", Offset = "0x6FFD500", VA = "0x186FFEF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct POPIIAOOBEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public IFAMEGOMHPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private bool <omIsEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private bool <omShouldBeEnabled>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private TaskAwaiter<KBIHKJABELE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private TaskAwaiter<byte> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x7010FF0", Offset = "0x700F5F0", VA = "0x187010FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x70117A0", Offset = "0x700FDA0", VA = "0x1870117A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private struct GOHHEHIANBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public IFAMEGOMHPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private TaskAwaiter<MDLNFGMEEFD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x7000780", Offset = "0x6FFED80", VA = "0x187000780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x7000AA0", Offset = "0x6FFF0A0", VA = "0x187000AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private sealed class LHBEJEJEFOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public APFHDOCKBNE presence;

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public LHBEJEJEFOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x7007E40", Offset = "0x7006440", VA = "0x187007E40")]
		internal object FMAOABEHDIF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	private static readonly ICJNMGNJFIN CAJBNIGHKAB;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	private static readonly ICJNMGNJFIN JAPBEHPDHKA;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	private static readonly ICJNMGNJFIN DHBEAFCPFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000389")]
	private readonly HIDIGIEPPEB AAAKHBIFODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400038A")]
	private readonly BNPDOGINEIM PDJODALHJPN;

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x7005660", Offset = "0x7003C60", VA = "0x187005660")]
	public IFAMEGOMHPO(HIDIGIEPPEB AAAKHBIFODE, BNPDOGINEIM PDJODALHJPN, Guid PNICJCCCLKL, BCKFHKGPDOK ICKJILCADLE, IPKKJLJAFFM ANHOABJMDGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x7005050", Offset = "0x7003650", VA = "0x187005050", Slot = "7")]
	[AsyncStateMachine(typeof(FDEFOBKGJJI))]
	protected override Task CEFLGFMLCJE(HJBBHPAONAL PGDPDODKNBI, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x7005190", Offset = "0x7003790", VA = "0x187005190")]
	[AsyncStateMachine(typeof(POPIIAOOBEA))]
	private Task IGJAOIJAKPJ(CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x7005470", Offset = "0x7003A70", VA = "0x187005470")]
	[AsyncStateMachine(typeof(GOHHEHIANBC))]
	private Task<byte> NIMLBOBJDEL(CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x7005290", Offset = "0x7003890", VA = "0x187005290")]
	private APFHDOCKBNE NDNFEHDGLJC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
internal class KLJAAHFBDMA : IKCOGJKNDIG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private struct GPPIPLCOKOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public KLJAAHFBDMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public HJBBHPAONAL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private TaskAwaiter<DOIKEIMKJLC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x7000B10", Offset = "0x6FFF110", VA = "0x187000B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x7001490", Offset = "0x6FFFA90", VA = "0x187001490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	private readonly int HCNGCHEGKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	private readonly NKHNFKKJCFE ABJEIILOJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public readonly long NLCEJDBODNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public readonly long CPOMFKCOFFF;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public DOIKEIMKJLC KNKKADMIJBA
	{
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x8689D0", Offset = "0x866FD0", VA = "0x1808689D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x8689F0", Offset = "0x866FF0", VA = "0x1808689F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x7007320", Offset = "0x7005920", VA = "0x187007320")]
	public KLJAAHFBDMA(Guid PNICJCCCLKL, BCKFHKGPDOK ICKJILCADLE, IPKKJLJAFFM ANHOABJMDGH, int HCNGCHEGKPF, NKHNFKKJCFE ABJEIILOJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x7007200", Offset = "0x7005800", VA = "0x187007200", Slot = "7")]
	[AsyncStateMachine(typeof(GPPIPLCOKOD))]
	protected override Task CEFLGFMLCJE(HJBBHPAONAL PGDPDODKNBI, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal abstract class HCKKOHJOEBL : IKCOGJKNDIG
{
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private sealed class JJMPCHINEMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public HCKKOHJOEBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public JFOJBGOKDJG playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public JJMPCHINEMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x70071C0", Offset = "0x70057C0", VA = "0x1870071C0")]
		internal Task JMAABPFOKGM(DJJFGNEEIPJ<string>.DIJMCCGECOP postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x7007130", Offset = "0x7005730", VA = "0x187007130")]
		internal object HADDHGMHCOE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private struct NHGONFACBNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public HCKKOHJOEBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public HJBBHPAONAL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private JJMPCHINEMC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x700CE00", Offset = "0x700B400", VA = "0x18700CE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x700D5C0", Offset = "0x700BBC0", VA = "0x18700D5C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private struct OKPKCGEEKBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public JFOJBGOKDJG playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public HCKKOHJOEBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x7010770", Offset = "0x700ED70", VA = "0x187010770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x7010D00", Offset = "0x700F300", VA = "0x187010D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x7001770", Offset = "0x6FFFD70", VA = "0x187001770")]
	public HCKKOHJOEBL(Guid PNICJCCCLKL, BCKFHKGPDOK ICKJILCADLE, IPKKJLJAFFM ANHOABJMDGH, string PCJAJIAJDEH, COKCNCLLNOC JHHCMNOMIOL, bool IEIAGCCPCMF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x70014F0", Offset = "0x6FFFAF0", VA = "0x1870014F0", Slot = "7")]
	[AsyncStateMachine(typeof(NHGONFACBNH))]
	protected override Task CEFLGFMLCJE(HJBBHPAONAL PGDPDODKNBI, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task OCEAPHFKDKB(HJBBHPAONAL PGDPDODKNBI, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x7001630", Offset = "0x6FFFC30", VA = "0x187001630")]
	[AsyncStateMachine(typeof(OKPKCGEEKBE))]
	private Task CJMFFBAGAGK(IDisposable AJEEEMHOFPP, JFOJBGOKDJG KFMCGHFBJLG, DJJFGNEEIPJ<string>.DIJMCCGECOP OPELNCJDKIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
internal class AGBJDECMFCM : IKCOGJKNDIG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private struct EOKHIBCAKEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public AGBJDECMFCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public HJBBHPAONAL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private TaskAwaiter<GKKPKPAPFIE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x6FFE000", Offset = "0x6FFC600", VA = "0x186FFE000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x6FFE570", Offset = "0x6FFCB70", VA = "0x186FFE570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	private readonly MJNMLCHIOPD BBHKMFMMNIP;

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x6FFB8D0", Offset = "0x6FF9ED0", VA = "0x186FFB8D0")]
	public AGBJDECMFCM(Guid PNICJCCCLKL, BCKFHKGPDOK ICKJILCADLE, IPKKJLJAFFM ANHOABJMDGH, MJNMLCHIOPD BBHKMFMMNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x6FFB7F0", Offset = "0x6FF9DF0", VA = "0x186FFB7F0", Slot = "6")]
	protected override string FFKEIIEGOLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x6FFB6D0", Offset = "0x6FF9CD0", VA = "0x186FFB6D0", Slot = "7")]
	[AsyncStateMachine(typeof(EOKHIBCAKEC))]
	protected override Task CEFLGFMLCJE(HJBBHPAONAL PGDPDODKNBI, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
internal abstract class IKCOGJKNDIG : CEMIAKLHGHA
{
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	public delegate Task EGNEKFPBIEO(DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private sealed class DIIDKKCIEPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public IKCOGJKNDIG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public DIIDKKCIEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD120", Offset = "0x6FFB720", VA = "0x186FFD120")]
		internal Task PCLDHDLDMJO(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class DMIAPDACHCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public DIIDKKCIEPA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public DMIAPDACHCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD250", Offset = "0x6FFB850", VA = "0x186FFD250")]
		internal object AHBIGBCBJPA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct NDOCNGMGKBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public IKCOGJKNDIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public Func<IKCOGJKNDIG, DJJFGNEEIPJ<string>.DIJMCCGECOP, HJBBHPAONAL> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private DIIDKKCIEPA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private HJBBHPAONAL <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private TaskAwaiter<ILFKKIOKLHK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x700BAA0", Offset = "0x700A0A0", VA = "0x18700BAA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x700CBA0", Offset = "0x700B1A0", VA = "0x18700CBA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct NKENPNPLNPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x700ED10", Offset = "0x700D310", VA = "0x18700ED10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x700F790", Offset = "0x700DD90", VA = "0x18700F790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct DAMHEDCKCLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public IKCOGJKNDIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x6FFCD60", Offset = "0x6FFB360", VA = "0x186FFCD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD0C0", Offset = "0x6FFB6C0", VA = "0x186FFD0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public readonly Guid CLFHPNONDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public readonly ByteString GJLGMCEFOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public readonly IPKKJLJAFFM IDJNCKCJPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	protected readonly string FFKFMFNDDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private readonly BCKFHKGPDOK ICKJILCADLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	private readonly bool IEIAGCCPCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private readonly Queue<EGNEKFPBIEO> BDNJGKIAENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private readonly JPGEAIOKJKE KANGDEHINHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private readonly COKCNCLLNOC JHHCMNOMIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private bool HHDILABKABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public DMHGCACCENH FFKOGEBLGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public DMHGCACCENH HKNEMHBFLCP;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public BCKFHKGPDOK KMCCNKGNGJH
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x86CF30", Offset = "0x86B530", VA = "0x18086CF30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public MPJECKENMPL OKAMCKPLNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x70061B0", Offset = "0x70047B0", VA = "0x1870061B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public HEJGCIILPDP JAOKDPGMOLH
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x7005810", Offset = "0x7003E10", VA = "0x187005810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public COKFDBDFLII HKODNONBALC
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x7006040", Offset = "0x7004640", VA = "0x187006040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event KFLGADPIJKL BPLPOHONNBM
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x7006200", Offset = "0x7004800", VA = "0x187006200", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x7005C10", Offset = "0x7004210", VA = "0x187005C10", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x7006220", Offset = "0x7004820", VA = "0x187006220")]
	protected IKCOGJKNDIG(Guid PNICJCCCLKL, BCKFHKGPDOK ICKJILCADLE, IPKKJLJAFFM ANHOABJMDGH, string PCJAJIAJDEH, COKCNCLLNOC JHHCMNOMIOL, bool IEIAGCCPCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x7005980", Offset = "0x7003F80", VA = "0x187005980", Slot = "6")]
	protected virtual string FFKEIIEGOLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x70059C0", Offset = "0x7003FC0", VA = "0x1870059C0")]
	public void FGFHLNALEKM(EGNEKFPBIEO CGMLOOJFLHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x70057F0", Offset = "0x7003DF0", VA = "0x1870057F0")]
	protected void CBKHOFPPJAH(float EBPGHIDCOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x7005D60", Offset = "0x7004360", VA = "0x187005D60")]
	[AsyncStateMachine(typeof(NDOCNGMGKBK))]
	public Task JGBGEMHOKIJ(CancellationToken DADBOHKBJNO, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, [Optional] Func<IKCOGJKNDIG, DJJFGNEEIPJ<string>.DIJMCCGECOP, HJBBHPAONAL> NKJLEABMJAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x7005C30", Offset = "0x7004230", VA = "0x187005C30")]
	[AsyncStateMachine(typeof(NKENPNPLNPF))]
	private static Task HBGCLIOAFOF(Func<CancellationToken, Task> MJDGECDPIPJ, Func<CancellationToken, Task> PCPEDCBHCGB, CancellationToken HCOOOCBFMFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x7005A20", Offset = "0x7004020", VA = "0x187005A20")]
	private void GGCFHBJGJOB(bool EPAOGDMACAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x7005F30", Offset = "0x7004530", VA = "0x187005F30")]
	private void KKGKHNOLBOF(HJBBHPAONAL PGDPDODKNBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task CEFLGFMLCJE(HJBBHPAONAL PGDPDODKNBI, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x7005860", Offset = "0x7003E60", VA = "0x187005860")]
	[AsyncStateMachine(typeof(DAMHEDCKCLC))]
	private Task EPKODLNOMEH(DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x7005B90", Offset = "0x7004190", VA = "0x187005B90")]
	public ILFKKIOKLHK GKMBNCKKABL(CCFCAIEEDHG ADJIJIOFKKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x70060C0", Offset = "0x70046C0", VA = "0x1870060C0")]
	[CompilerGenerated]
	private Task LNKIGDPHEAP(CancellationToken LBKJPGMAINP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x7005EB0", Offset = "0x70044B0", VA = "0x187005EB0")]
	[CompilerGenerated]
	private object KJPOMGALKEE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
internal sealed class BCDMJIOHJOJ : HCKKOHJOEBL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct PPJAEPGDONH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public BCDMJIOHJOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public HJBBHPAONAL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private JGEMMLOJFBN <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private ICKHBOINCDE <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x7011800", Offset = "0x700FE00", VA = "0x187011800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x7011F70", Offset = "0x7010570", VA = "0x187011F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	private readonly HIDIGIEPPEB PHKDMOOBAAD;

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x6FFBC60", Offset = "0x6FFA260", VA = "0x186FFBC60")]
	public BCDMJIOHJOJ(Guid PNICJCCCLKL, BCKFHKGPDOK ICKJILCADLE, HIDIGIEPPEB PHKDMOOBAAD, IPKKJLJAFFM ANHOABJMDGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x6FFBB10", Offset = "0x6FFA110", VA = "0x186FFBB10", Slot = "8")]
	[AsyncStateMachine(typeof(PPJAEPGDONH))]
	protected override Task OCEAPHFKDKB(HJBBHPAONAL PGDPDODKNBI, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
internal class CKGNPEPDJII : IKCOGJKNDIG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private struct HGEDCGKFMHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public CKGNPEPDJII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public HJBBHPAONAL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		private TaskAwaiter<GKKPKPAPFIE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x7002290", Offset = "0x7000890", VA = "0x187002290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x7002640", Offset = "0x7000C40", VA = "0x187002640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private readonly string NIMBHMIABML;

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x6FFC500", Offset = "0x6FFAB00", VA = "0x186FFC500")]
	public CKGNPEPDJII(Guid PNICJCCCLKL, BCKFHKGPDOK ICKJILCADLE, IPKKJLJAFFM ANHOABJMDGH, string NIMBHMIABML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x6FFC3F0", Offset = "0x6FFA9F0", VA = "0x186FFC3F0", Slot = "7")]
	[AsyncStateMachine(typeof(HGEDCGKFMHO))]
	protected override Task CEFLGFMLCJE(HJBBHPAONAL PGDPDODKNBI, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
internal class CPNLIEHNMEB : HCKKOHJOEBL
{
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private sealed class AGKGHEAAPOD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000118")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			public AsyncTaskMethodBuilder<ILFKKIOKLHK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			public AGKGHEAAPOD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400041B")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400041C")]
			private TaskAwaiter<GKKPKPAPFIE> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400041D")]
			private TaskAwaiter<ILFKKIOKLHK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0x7013520", Offset = "0x7011B20", VA = "0x187013520", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0x70139E0", Offset = "0x7011FE0", VA = "0x1870139E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public CPNLIEHNMEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public BLGAAKAOAIK serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public HDKPBALEPOD roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public BODFPDOHLLO uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public LEIHNKGEKLG roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public AGKGHEAAPOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x6FFB9F0", Offset = "0x6FF9FF0", VA = "0x186FFB9F0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<ILFKKIOKLHK> NAFBJFMMALO(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct NIIHHCJEEPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public CPNLIEHNMEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public HJBBHPAONAL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private AGKGHEAAPOD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private JGEMMLOJFBN <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private ICKHBOINCDE <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private ILFKKIOKLHK <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private TaskAwaiter<ILFKKIOKLHK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x700D620", Offset = "0x700BC20", VA = "0x18700D620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x700E580", Offset = "0x700CB80", VA = "0x18700E580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private static readonly ICJNMGNJFIN CAJBNIGHKAB;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	private static readonly ICJNMGNJFIN JAPBEHPDHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	private readonly int GFBPPFHEBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	[CanBeNull]
	private readonly BGDAOBFLICB HAPCEHIIKKI;

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x6FFCCB0", Offset = "0x6FFB2B0", VA = "0x186FFCCB0")]
	public CPNLIEHNMEB(Guid PNICJCCCLKL, BCKFHKGPDOK ICKJILCADLE, int GFBPPFHEBGI, BGDAOBFLICB HAPCEHIIKKI, IPKKJLJAFFM ANHOABJMDGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x6FFCAC0", Offset = "0x6FFB0C0", VA = "0x186FFCAC0", Slot = "8")]
	[AsyncStateMachine(typeof(NIIHHCJEEPA))]
	protected override Task OCEAPHFKDKB(HJBBHPAONAL PGDPDODKNBI, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x6FFC7F0", Offset = "0x6FFADF0", VA = "0x186FFC7F0")]
	private void ABFDGBGEOFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x6FFC8F0", Offset = "0x6FFAEF0", VA = "0x186FFC8F0")]
	private void DFLPKODDPDP(DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, JGEMMLOJFBN IPLGFLLPKBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal abstract class FKACOPIIIBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public readonly IKCOGJKNDIG KPBNJNNOKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public readonly HJBBHPAONAL NEEEDLCECAF;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public MPJECKENMPL OKAMCKPLNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x6FFF080", Offset = "0x6FFD680", VA = "0x186FFF080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public COKFDBDFLII HKODNONBALC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x6FFEFF0", Offset = "0x6FFD5F0", VA = "0x186FFEFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x6FFF0D0", Offset = "0x6FFD6D0", VA = "0x186FFF0D0")]
	protected FKACOPIIIBN(HJBBHPAONAL PGDPDODKNBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x6FFEFD0", Offset = "0x6FFD5D0", VA = "0x186FFEFD0")]
	protected void EMMOGPNJFNP(string BBEECMIBLBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal struct NJBJEHEMIED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public Dictionary<Guid, List<FGNILMNEMNE>> OBGGMPGBHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public Dictionary<Guid, List<FGNILMNEMNE>> AJGGDPJEEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public Dictionary<Guid, List<FGNILMNEMNE>> KEGPDGADKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public List<Guid> BBHLHILJBBP;

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x700E5E0", Offset = "0x700CBE0", VA = "0x18700E5E0")]
	public static NJBJEHEMIED BDJJCDMMBKL(MPJECKENMPL AHBNABCBLNH, DMHGCACCENH GPGMHDGNGKI, PLBPIEKJMAO AMOMMAANLLG)
	{
		return default(NJBJEHEMIED);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011D")]
internal struct KHDEJCPLHHG
{
	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0")]
	public static KHDEJCPLHHG GIGNPOIHFIA()
	{
		return default(KHDEJCPLHHG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal struct AGHNAPPMNCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public readonly KBIHKJABELE KMGPOBDIGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public readonly OONHFDBOICP CFKFJPKPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public readonly string LJHFHHFIGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public readonly HCMHGKFNLLO KEAPPNMDHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public readonly HCMHGKFNLLO BKFHNCLAJLB;

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x6FFB970", Offset = "0x6FF9F70", VA = "0x186FFB970")]
	public AGHNAPPMNCG(KBIHKJABELE KMGPOBDIGAH, OONHFDBOICP CFKFJPKPBBG, string LJHFHHFIGMM, HCMHGKFNLLO KEAPPNMDHKA, HCMHGKFNLLO BKFHNCLAJLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal struct HPGBFEDNKDP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	private readonly HJBBHPAONAL PGDPDODKNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private readonly Guid GJICKHKJJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private bool EPAOGDMACAO;

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x7002D90", Offset = "0x7001390", VA = "0x187002D90")]
	public static HPGBFEDNKDP DAHEICECLKE(HJBBHPAONAL PGDPDODKNBI)
	{
		return default(HPGBFEDNKDP);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x9A4380", Offset = "0x9A2980", VA = "0x1809A4380")]
	public void IHIIFGALKKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x7002E90", Offset = "0x7001490", VA = "0x187002E90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x7002EF0", Offset = "0x70014F0", VA = "0x187002EF0")]
	private HPGBFEDNKDP(HJBBHPAONAL PGDPDODKNBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x7002E90", Offset = "0x7001490", VA = "0x187002E90")]
	private void MLDDKICBILO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x7002DF0", Offset = "0x70013F0", VA = "0x187002DF0")]
	private Func<Guid, bool> DBLNCPNOHIN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal class ICKHBOINCDE : FKACOPIIIBN, CEMIAKLHGHA
{
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	public delegate Task<DMHGCACCENH> BIKMOKECAGA(PLBPIEKJMAO FHNKDHIILBL, OCOGOEMEIEF FAFKAMIBMIO, JPGEAIOKJKE FHPOCMIFHMD, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private struct HFJAPCACKPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public ICKHBOINCDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public HIDIGIEPPEB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		private HPGBFEDNKDP <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		private TaskAwaiter<ILFKKIOKLHK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x7001AC0", Offset = "0x70000C0", VA = "0x187001AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x7002230", Offset = "0x7000830", VA = "0x187002230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct LNNOAHFPFKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public AsyncTaskMethodBuilder<ILFKKIOKLHK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public ICKHBOINCDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public HIDIGIEPPEB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		private TaskAwaiter<ILFKKIOKLHK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x7008600", Offset = "0x7006C00", VA = "0x187008600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x7008A10", Offset = "0x7007010", VA = "0x187008A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct GFHMACKNGOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public ICKHBOINCDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public HIDIGIEPPEB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x7000290", Offset = "0x6FFE890", VA = "0x187000290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x7000720", Offset = "0x6FFED20", VA = "0x187000720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private sealed class MHGOFDNFGJO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000126")]
		private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			public AsyncTaskMethodBuilder<AGHNAPPMNCG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			public MHGOFDNFGJO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			private AGHNAPPMNCG <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			private TaskAwaiter<DMHGCACCENH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			private TaskAwaiter<AGHNAPPMNCG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x7011FD0", Offset = "0x70105D0", VA = "0x187011FD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x7012760", Offset = "0x7010D60", VA = "0x187012760", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			public AsyncTaskMethodBuilder<PLBPIEKJMAO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			public MHGOFDNFGJO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			private PLBPIEKJMAO <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			private TaskAwaiter<DMHGCACCENH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000470")]
			private TaskAwaiter<PLBPIEKJMAO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0x70127D0", Offset = "0x7010DD0", VA = "0x1870127D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051B")]
			[Cpp2IlInjected.Address(RVA = "0x7012E20", Offset = "0x7011420", VA = "0x187012E20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public ICKHBOINCDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public HIDIGIEPPEB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public JPGEAIOKJKE preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public JPGEAIOKJKE downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public AGHNAPPMNCG data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public JPGEAIOKJKE postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public PLBPIEKJMAO phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public BEFCBFDMNMF.HPAGEKKLNLJ <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public MHGOFDNFGJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x7008BE0", Offset = "0x70071E0", VA = "0x187008BE0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<AGHNAPPMNCG> GJHMBCKMBNP(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x7008EC0", Offset = "0x70074C0", VA = "0x187008EC0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<PLBPIEKJMAO> OFBGMCLOIBJ(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x7008D20", Offset = "0x7007320", VA = "0x187008D20")]
		internal void LIAOJEEEEKL(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x7008A80", Offset = "0x7007080", VA = "0x187008A80")]
		internal Task CBPHHEDLHNE(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x7008D60", Offset = "0x7007360", VA = "0x187008D60")]
		internal Task NGHGGOHAHHE(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct JHDHIPPCOIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public ICKHBOINCDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public HIDIGIEPPEB request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private MHGOFDNFGJO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private TaskAwaiter<AGHNAPPMNCG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private TaskAwaiter<PLBPIEKJMAO> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x7006380", Offset = "0x7004980", VA = "0x187006380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x70070D0", Offset = "0x70056D0", VA = "0x1870070D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct NMJIKHMOKFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public ICKHBOINCDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public PLBPIEKJMAO phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public JPGEAIOKJKE postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private TaskAwaiter<DMHGCACCENH> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private OCOGOEMEIEF <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x700F7F0", Offset = "0x700DDF0", VA = "0x18700F7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x7010710", Offset = "0x700ED10", VA = "0x187010710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct LELOOBJHLIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public ICKHBOINCDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x7007530", Offset = "0x7005B30", VA = "0x187007530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x7007DE0", Offset = "0x70063E0", VA = "0x187007DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct NCJEAJPBOEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public ICKHBOINCDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public PLBPIEKJMAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public JPGEAIOKJKE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private TaskAwaiter<DMHGCACCENH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x700B0C0", Offset = "0x70096C0", VA = "0x18700B0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x700BA40", Offset = "0x700A040", VA = "0x18700BA40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct FODEMNFKOEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public AsyncTaskMethodBuilder<DMHGCACCENH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public ICKHBOINCDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public PLBPIEKJMAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public JPGEAIOKJKE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private TaskAwaiter<DMHGCACCENH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x6FFF130", Offset = "0x6FFD730", VA = "0x186FFF130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x7000100", Offset = "0x6FFE700", VA = "0x187000100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct NANFJPMCBCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public AsyncTaskMethodBuilder<DMHGCACCENH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public ICKHBOINCDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public PLBPIEKJMAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public JPGEAIOKJKE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public OCOGOEMEIEF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private TaskAwaiter<DMHGCACCENH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x7009F60", Offset = "0x7008560", VA = "0x187009F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x700B050", Offset = "0x7009650", VA = "0x18700B050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct HEEFMCPEEGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public AsyncTaskMethodBuilder<DMHGCACCENH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public ICKHBOINCDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public DMHGCACCENH operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public JPGEAIOKJKE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public PLBPIEKJMAO deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private TaskAwaiter<DMHGCACCENH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x70017C0", Offset = "0x6FFFDC0", VA = "0x1870017C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x7001A50", Offset = "0x7000050", VA = "0x187001A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private sealed class NJLMFBFKCCH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000131")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004C1")]
			public AsyncTaskMethodBuilder<DMHGCACCENH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004C2")]
			public NJLMFBFKCCH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004C3")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C4")]
			private IAOHNBPIHKI <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004C5")]
			private TaskAwaiter<DMHGCACCENH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x7012E90", Offset = "0x7011490", VA = "0x187012E90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000533")]
			[Cpp2IlInjected.Address(RVA = "0x70134B0", Offset = "0x7011AB0", VA = "0x1870134B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public ICKHBOINCDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public PLBPIEKJMAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public JPGEAIOKJKE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public BIKMOKECAGA masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public OCOGOEMEIEF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public DMHGCACCENH originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public NJLMFBFKCCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x700EBF0", Offset = "0x700D1F0", VA = "0x18700EBF0")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<DMHGCACCENH> FBGBOEOEBCO(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private struct BPKPEMPCBCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public AsyncTaskMethodBuilder<DMHGCACCENH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public ICKHBOINCDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public PLBPIEKJMAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public JPGEAIOKJKE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public BIKMOKECAGA masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public OCOGOEMEIEF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private IAOHNBPIHKI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private TaskAwaiter<DMHGCACCENH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x6FFBE10", Offset = "0x6FFA410", VA = "0x186FFBE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x6FFC310", Offset = "0x6FFA910", VA = "0x186FFC310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct IDEPBOCKIMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public ICKHBOINCDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public PLBPIEKJMAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public JPGEAIOKJKE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private DMHGCACCENH <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private IEnumerator<DMHGCACCENH> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private TaskAwaiter<DMHGCACCENH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x7004AC0", Offset = "0x70030C0", VA = "0x187004AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x7004FF0", Offset = "0x70035F0", VA = "0x187004FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct HKLLECEEKCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public ICKHBOINCDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public PLBPIEKJMAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x7002B10", Offset = "0x7001110", VA = "0x187002B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x7002D30", Offset = "0x7001330", VA = "0x187002D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct NGABNPNGOEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public ICKHBOINCDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public PLBPIEKJMAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x700CC00", Offset = "0x700B200", VA = "0x18700CC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x700CDA0", Offset = "0x700B3A0", VA = "0x18700CDA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct MMDIKFFDLCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public ICKHBOINCDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public PLBPIEKJMAO phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public JPGEAIOKJKE postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private TaskAwaiter<DMHGCACCENH> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private OCOGOEMEIEF <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x7008FE0", Offset = "0x70075E0", VA = "0x187008FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x7009F00", Offset = "0x7008500", VA = "0x187009F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct ENPGGOIDIGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public AsyncTaskMethodBuilder<DMHGCACCENH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public ICKHBOINCDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public PLBPIEKJMAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public JPGEAIOKJKE progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		private TaskAwaiter<DMHGCACCENH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD460", Offset = "0x6FFBA60", VA = "0x186FFD460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x6FFDF90", Offset = "0x6FFC590", VA = "0x186FFDF90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private readonly KHCGFHKKCLN IMKGKPJDIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	private readonly KHCGFHKKCLN AJBNKODFGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	private readonly PHKBEKJCEKE IIMBIIGOAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private readonly INNPNNGIKHG JAHJNFANHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	private readonly PIFFGGNCAEA LIPICOJKNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000440")]
	private readonly GHDHKPLGDOG IALIEONBCAI;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private BCKFHKGPDOK KMCCNKGNGJH
	{
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x70040B0", Offset = "0x70026B0", VA = "0x1870040B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event KFLGADPIJKL BPLPOHONNBM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x70047F0", Offset = "0x7002DF0", VA = "0x1870047F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x7003750", Offset = "0x7001D50", VA = "0x187003750", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x7004810", Offset = "0x7002E10", VA = "0x187004810")]
	public ICKHBOINCDE(HJBBHPAONAL PGDPDODKNBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x70040E0", Offset = "0x70026E0", VA = "0x1870040E0")]
	[AsyncStateMachine(typeof(HFJAPCACKPI))]
	public Task NAACMDFOIMI(HIDIGIEPPEB BDMHFDNBPPE, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x70044D0", Offset = "0x7002AD0", VA = "0x1870044D0")]
	[AsyncStateMachine(typeof(LNNOAHFPFKM))]
	private Task<ILFKKIOKLHK> OLMGKGBNOLO(HIDIGIEPPEB BDMHFDNBPPE, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x7004230", Offset = "0x7002830", VA = "0x187004230")]
	[AsyncStateMachine(typeof(GFHMACKNGOM))]
	private Task NFLLDGMHDIA(HIDIGIEPPEB BDMHFDNBPPE, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x7003A80", Offset = "0x7002080", VA = "0x187003A80")]
	[AsyncStateMachine(typeof(JHDHIPPCOIL))]
	private Task IMGBFCHIFJA(HIDIGIEPPEB BDMHFDNBPPE, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken EOGLDMMOIKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x70033C0", Offset = "0x70019C0", VA = "0x1870033C0")]
	[AsyncStateMachine(typeof(NMJIKHMOKFG))]
	private Task FFLKPLHGANE(PLBPIEKJMAO MMNBLGGAIEN, JPGEAIOKJKE HCMNECNIGKJ, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken MGAAMOMBIPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x7002F60", Offset = "0x7001560", VA = "0x187002F60")]
	[AsyncStateMachine(typeof(LELOOBJHLIB))]
	private Task AILBDDMEPBH(DJJFGNEEIPJ<string>.DIJMCCGECOP OPELNCJDKIK, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x70038C0", Offset = "0x7001EC0", VA = "0x1870038C0")]
	[AsyncStateMachine(typeof(NCJEAJPBOEE))]
	private Task HPGOKEMAMLK(PLBPIEKJMAO FHNKDHIILBL, JPGEAIOKJKE FHPOCMIFHMD, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x7004370", Offset = "0x7002970", VA = "0x187004370")]
	[AsyncStateMachine(typeof(FODEMNFKOEJ))]
	private Task<DMHGCACCENH> OGFMGENGPDN(PLBPIEKJMAO FHNKDHIILBL, OCOGOEMEIEF MBINDPAJJCA, JPGEAIOKJKE FHPOCMIFHMD, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x7003200", Offset = "0x7001800", VA = "0x187003200")]
	[AsyncStateMachine(typeof(NANFJPMCBCK))]
	private Task<DMHGCACCENH> DDDLCCPPMBK(PLBPIEKJMAO FHNKDHIILBL, OCOGOEMEIEF MBINDPAJJCA, JPGEAIOKJKE FHPOCMIFHMD, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x7003F10", Offset = "0x7002510", VA = "0x187003F10")]
	[AsyncStateMachine(typeof(HEEFMCPEEGO))]
	private Task<DMHGCACCENH> LAJDOLDPDHP(DMHGCACCENH GPGMHDGNGKI, PLBPIEKJMAO AMOMMAANLLG, JPGEAIOKJKE FHPOCMIFHMD, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO, bool AMDFAONPKJI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x7003090", Offset = "0x7001690", VA = "0x187003090")]
	private bool BBEENMFIPNG(PLBPIEKJMAO MMNBLGGAIEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x7004630", Offset = "0x7002C30", VA = "0x187004630")]
	[AsyncStateMachine(typeof(BPKPEMPCBCH))]
	protected Task<DMHGCACCENH> PDFGFBNNBGA(PLBPIEKJMAO FHNKDHIILBL, OCOGOEMEIEF MBINDPAJJCA, JPGEAIOKJKE FHPOCMIFHMD, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO, BIKMOKECAGA NGJJFKLDLBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x7003D60", Offset = "0x7002360", VA = "0x187003D60")]
	[AsyncStateMachine(typeof(IDEPBOCKIMO))]
	private Task JPPEINMIKLL(PLBPIEKJMAO FHNKDHIILBL, JPGEAIOKJKE FHPOCMIFHMD, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x7003A30", Offset = "0x7002030", VA = "0x187003A30")]
	private void ILDMKCHCOGH(DMHGCACCENH NIOCHEDFJIC, JPGEAIOKJKE FHPOCMIFHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x7003EB0", Offset = "0x70024B0", VA = "0x187003EB0")]
	private void KABCPLEKBJD(DMHGCACCENH EDGOKCCDJOK, [Out] DMHGCACCENH MDNKOFEGOPI, [Out] DMHGCACCENH IJFEOFMJOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x7003BC0", Offset = "0x70021C0", VA = "0x187003BC0")]
	private Task<AGHNAPPMNCG> INOAKBILKJB(HIDIGIEPPEB BDMHFDNBPPE, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x7003380", Offset = "0x7001980", VA = "0x187003380")]
	private Task<PLBPIEKJMAO> EHCNEFNPLNH(AGHNAPPMNCG FHNKDHIILBL, BEFCBFDMNMF.HPAGEKKLNLJ NKCHCKFEIPH, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x7003770", Offset = "0x7001D70", VA = "0x187003770")]
	[AsyncStateMachine(typeof(HKLLECEEKCN))]
	private Task HEHGIIDEHGK(PLBPIEKJMAO FHNKDHIILBL, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO, bool CJMOBMFNHCN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x7003660", Offset = "0x7001C60", VA = "0x187003660")]
	[AsyncStateMachine(typeof(NGABNPNGOEB))]
	private Task FIMOGBBGOCF(PLBPIEKJMAO FHNKDHIILBL, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x70031D0", Offset = "0x70017D0", VA = "0x1870031D0")]
	private Task CJDBELJEOCB(PLBPIEKJMAO FHNKDHIILBL, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x7003EF0", Offset = "0x70024F0", VA = "0x187003EF0")]
	private Task KLAHMDGKBIP(PLBPIEKJMAO FHNKDHIILBL, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x7003070", Offset = "0x7001670", VA = "0x187003070")]
	private Task AKIMFDLBENN(PLBPIEKJMAO FHNKDHIILBL, OCOGOEMEIEF MBINDPAJJCA, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x70047D0", Offset = "0x7002DD0", VA = "0x1870047D0")]
	private Task PHKAFKNDICL(PLBPIEKJMAO FHNKDHIILBL, OCOGOEMEIEF MBINDPAJJCA, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x70047C0", Offset = "0x7002DC0", VA = "0x1870047C0")]
	private static Task PHJEIEICALC(CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x7003A10", Offset = "0x7002010", VA = "0x187003A10")]
	private Task IACMFLPOCPD(PLBPIEKJMAO FHNKDHIILBL, OCOGOEMEIEF MBINDPAJJCA, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x7002F40", Offset = "0x7001540", VA = "0x187002F40")]
	private Task ADKNNJOJDMP(PLBPIEKJMAO FHNKDHIILBL, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x7003180", Offset = "0x7001780", VA = "0x187003180")]
	private void BMCFCEDFAFO(HIDIGIEPPEB BDMHFDNBPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x7004090", Offset = "0x7002690", VA = "0x187004090")]
	public void MDBLKHGAAHP(long HFCDLHABEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
	private static void LGELMJIGLEB(KBIHKJABELE KMGPOBDIGAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x7003510", Offset = "0x7001B10", VA = "0x187003510")]
	[AsyncStateMachine(typeof(MMDIKFFDLCM))]
	private Task FFNHIPACAHD(PLBPIEKJMAO MMNBLGGAIEN, JPGEAIOKJKE HCMNECNIGKJ, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken MGAAMOMBIPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x7003C00", Offset = "0x7002200", VA = "0x187003C00")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(ENPGGOIDIGA))]
	private Task<DMHGCACCENH> JEGMJDHFHEB(PLBPIEKJMAO FHNKDHIILBL, OCOGOEMEIEF MBINDPAJJCA, JPGEAIOKJKE FHPOCMIFHMD, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct CIKMCEKCCGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private BCKFHKGPDOK ICKJILCADLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private PLBPIEKJMAO FHNKDHIILBL;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private MPJECKENMPL OKAMCKPLNOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x70187B0", Offset = "0x7016DB0", VA = "0x1870187B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x70186D0", Offset = "0x7016CD0", VA = "0x1870186D0")]
	public static Task JGBGEMHOKIJ(BCKFHKGPDOK ICKJILCADLE, PLBPIEKJMAO FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x70184B0", Offset = "0x7016AB0", VA = "0x1870184B0")]
	private void JGBGEMHOKIJ()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct APEIMEHCKMG
{
	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x7014F20", Offset = "0x7013520", VA = "0x187014F20")]
	public static Task JGBGEMHOKIJ(CancellationToken DADBOHKBJNO)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct LLPGBJEOOAB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private struct HELINNAMAJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public HJBBHPAONAL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public PLBPIEKJMAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private IAOHNBPIHKI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x7020800", Offset = "0x701EE00", VA = "0x187020800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x7020D20", Offset = "0x701F320", VA = "0x187020D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x7027690", Offset = "0x7025C90", VA = "0x187027690")]
	[AsyncStateMachine(typeof(HELINNAMAJP))]
	public static Task JGBGEMHOKIJ(HJBBHPAONAL PGDPDODKNBI, PLBPIEKJMAO FHNKDHIILBL, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013C")]
internal struct NEDHFKNGAJJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct CPHMLNHNNHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public HJBBHPAONAL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public PLBPIEKJMAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public OCOGOEMEIEF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private DMHGCACCENH <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private BCKFHKGPDOK <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private MPJECKENMPL <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private IAOHNBPIHKI <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private List<(PersistenceView, CGIDLDDLPHO)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private CGIDLDDLPHO <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x7019E90", Offset = "0x7018490", VA = "0x187019E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x701AB10", Offset = "0x7019110", VA = "0x18701AB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x7028FF0", Offset = "0x70275F0", VA = "0x187028FF0")]
	[AsyncStateMachine(typeof(CPHMLNHNNHA))]
	public static Task JGBGEMHOKIJ(HJBBHPAONAL PGDPDODKNBI, PLBPIEKJMAO FHNKDHIILBL, OCOGOEMEIEF MBINDPAJJCA, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x7029140", Offset = "0x7027740", VA = "0x187029140")]
	private static void LPOMLOJMODI(PersistenceView KBOINDMIKMD, CGIDLDDLPHO PKKOMHEOCPG, PLBPIEKJMAO FHNKDHIILBL, DMHGCACCENH GPGMHDGNGKI, bool JNEPFJGMNFD)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013F")]
internal struct IOFLOMHOPBC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct KKAPPAJDMDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public BCKFHKGPDOK roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public PLBPIEKJMAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x7026050", Offset = "0x7024650", VA = "0x187026050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x7026490", Offset = "0x7024A90", VA = "0x187026490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x7023A50", Offset = "0x7022050", VA = "0x187023A50")]
	[AsyncStateMachine(typeof(KKAPPAJDMDK))]
	public static Task JGBGEMHOKIJ(BCKFHKGPDOK ICKJILCADLE, PLBPIEKJMAO FHNKDHIILBL, CancellationToken DADBOHKBJNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
internal struct HJOPIDPBAEH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct AGGPECBLPCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public BCKFHKGPDOK roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public PLBPIEKJMAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public HJBBHPAONAL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x7014660", Offset = "0x7012C60", VA = "0x187014660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x7014870", Offset = "0x7012E70", VA = "0x187014870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private sealed class PIOEONNBOKA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000144")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400052E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400052F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			public DJJFGNEEIPJ<string>.DIJMCCGECOP timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			public PIOEONNBOKA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			private DJJFGNEEIPJ<string>.DIJMCCGECOP <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000534")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0x702CDE0", Offset = "0x702B3E0", VA = "0x18702CDE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0x702D170", Offset = "0x702B770", VA = "0x18702D170", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public PIOEONNBOKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x702C7A0", Offset = "0x702ADA0", VA = "0x18702C7A0")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task LDDHEDBMGAB(DJJFGNEEIPJ<string>.DIJMCCGECOP timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct FEFEMFHFECH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public HJOPIDPBAEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private IAOHNBPIHKI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private TaskAwaiter<ILFKKIOKLHK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x701E0E0", Offset = "0x701C6E0", VA = "0x18701E0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x701EAB0", Offset = "0x701D0B0", VA = "0x18701EAB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private sealed class FBKFJGCACCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public NGPKNGOLDBM version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public FBKFJGCACCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x701E000", Offset = "0x701C600", VA = "0x18701E000")]
		internal object JGLHBALGOJP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x701DF50", Offset = "0x701C550", VA = "0x18701DF50")]
		internal object IKJCFIBFIKB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	private BCKFHKGPDOK ICKJILCADLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private PLBPIEKJMAO FHNKDHIILBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private HJBBHPAONAL PGDPDODKNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private bool CJMOBMFNHCN;

	[Cpp2IlInjected.Token(Token = "0x4000523")]
	private static readonly ByteString PODNOBDHEEP;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private MPJECKENMPL OKAMCKPLNOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x7021790", Offset = "0x701FD90", VA = "0x187021790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	private COKFDBDFLII HKODNONBALC
	{
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x70216B0", Offset = "0x701FCB0", VA = "0x1870216B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x7021420", Offset = "0x701FA20", VA = "0x187021420")]
	[AsyncStateMachine(typeof(AGGPECBLPCH))]
	public static Task JGBGEMHOKIJ(BCKFHKGPDOK ICKJILCADLE, PLBPIEKJMAO FHNKDHIILBL, HJBBHPAONAL PGDPDODKNBI, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO, bool CJMOBMFNHCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x7021570", Offset = "0x701FB70", VA = "0x187021570")]
	[AsyncStateMachine(typeof(FEFEMFHFECH))]
	private Task JGBGEMHOKIJ(DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x7020D80", Offset = "0x701F380", VA = "0x187020D80")]
	private void BOAIONEOEBF([NotNull] EIGMLKEEHNM LPNOGJAALGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x7021750", Offset = "0x701FD50", VA = "0x187021750")]
	private bool NFEFHCJCBHP(NGPKNGOLDBM HNNOPDLCPBM, EIGMLKEEHNM LPNOGJAALGA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
internal struct CPPBJEOELFI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct IDLFPIPNGGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public AsyncTaskMethodBuilder<PLBPIEKJMAO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public CPPBJEOELFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public BEFCBFDMNMF.HPAGEKKLNLJ downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private IAOHNBPIHKI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private TaskAwaiter<(PIJKHLBEMKP<OLIFKCLPPCB, FNFMNGCMHCP>, PIJKHLBEMKP<LAONMFHHBKK<EIGMLKEEHNM>, FNFMNGCMHCP>, PIJKHLBEMKP<LAONMFHHBKK<HMALNBKCNFI>, FNFMNGCMHCP>, PIJKHLBEMKP<LAONMFHHBKK<CPNNGLIIIOE>, FNFMNGCMHCP>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x7021920", Offset = "0x701FF20", VA = "0x187021920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x70223D0", Offset = "0x70209D0", VA = "0x1870223D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct ADEDDFAKJAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<OLIFKCLPPCB, FNFMNGCMHCP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public CPPBJEOELFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public BEFCBFDMNMF.HPAGEKKLNLJ downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private IAOHNBPIHKI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private TaskAwaiter<PIJKHLBEMKP<OLIFKCLPPCB, FNFMNGCMHCP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x7013F90", Offset = "0x7012590", VA = "0x187013F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x70145A0", Offset = "0x7012BA0", VA = "0x1870145A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	private HOIMEPFKGDB<HCMHGKFNLLO, HMALNBKCNFI> MJNHHAILHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	private HOIMEPFKGDB<HCMHGKFNLLO, EIGMLKEEHNM> EIFNFLCDMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	private HOIMEPFKGDB<long, CPNNGLIIIOE> KMNEMKOBPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	private DMNONJLJKOG MLDBFINIKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	private KBIHKJABELE KMGPOBDIGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	private OONHFDBOICP CFKFJPKPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	private string LJHFHHFIGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	private HCMHGKFNLLO KEAPPNMDHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	private HCMHGKFNLLO BKFHNCLAJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	private long HFCDLHABEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	private DJJFGNEEIPJ<string>.DIJMCCGECOP OPELNCJDKIK;

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x701AD30", Offset = "0x7019330", VA = "0x18701AD30")]
	public static Task<PLBPIEKJMAO> GKGCLLCJPIB(BCKFHKGPDOK ICKJILCADLE, [In] AGHNAPPMNCG FHNKDHIILBL, BEFCBFDMNMF.HPAGEKKLNLJ NKCHCKFEIPH, DJJFGNEEIPJ<string>.DIJMCCGECOP OPELNCJDKIK, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x701B0A0", Offset = "0x70196A0", VA = "0x18701B0A0")]
	[AsyncStateMachine(typeof(IDLFPIPNGGC))]
	private Task<PLBPIEKJMAO> JGBGEMHOKIJ(BEFCBFDMNMF.HPAGEKKLNLJ NKCHCKFEIPH, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x701AB70", Offset = "0x7019170", VA = "0x18701AB70")]
	[AsyncStateMachine(typeof(ADEDDFAKJAO))]
	private Task<PIJKHLBEMKP<OLIFKCLPPCB, FNFMNGCMHCP>> FAMFOOPOJBG(string LJHFHHFIGMM, long HFCDLHABEIB, long? NBDDMFOIEKN, long? ILOMCKJOFJN, BEFCBFDMNMF.HPAGEKKLNLJ NKCHCKFEIPH, DJJFGNEEIPJ<string>.DIJMCCGECOP EANEOAJPOGK, CancellationToken DADBOHKBJNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
internal struct DCMFEPPBAFD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private struct OLALPOHFAPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public AsyncTaskMethodBuilder<AGHNAPPMNCG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public DCMFEPPBAFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private TaskAwaiter<AGHNAPPMNCG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x702AFE0", Offset = "0x70295E0", VA = "0x18702AFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x702B3E0", Offset = "0x70299E0", VA = "0x18702B3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct JJELAOONHLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public AsyncTaskMethodBuilder<AGHNAPPMNCG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public DCMFEPPBAFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		private TaskAwaiter<AGHNAPPMNCG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x70246E0", Offset = "0x7022CE0", VA = "0x1870246E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x7024B10", Offset = "0x7023110", VA = "0x187024B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class BEFHIOPCAAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public BEFHIOPCAAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x943810", Offset = "0x941E10", VA = "0x180943810")]
		internal bool OHIHADJDMPJ(OONHFDBOICP sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct DDDEJFANHKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public AsyncTaskMethodBuilder<AGHNAPPMNCG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public HCMHGKFNLLO superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public MPJECKENMPL callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private BEFHIOPCAAF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public KDHIFHNDPAK roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private KBIHKJABELE <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private OONHFDBOICP <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private HCMHGKFNLLO <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private HCMHGKFNLLO <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private TaskAwaiter<KBIHKJABELE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private TaskAwaiter<CEBEAJJMCEF> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private TaskAwaiter<MDLNFGMEEFD> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x701B930", Offset = "0x7019F30", VA = "0x18701B930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x701CA70", Offset = "0x701B070", VA = "0x18701CA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000563")]
	private MPJECKENMPL AHBNABCBLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000564")]
	private PHKBEKJCEKE IIMBIIGOAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	private KDHIFHNDPAK ONMIHKOKFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	private DJJFGNEEIPJ<string>.DIJMCCGECOP OPELNCJDKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	private long NBDDMFOIEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private long JDAJCIDAAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private long FDJBEKDGJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private string LGNLNIECDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	private HCMHGKFNLLO CGMKNOJAIEB;

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x701B260", Offset = "0x7019860", VA = "0x18701B260")]
	public static Task<AGHNAPPMNCG> GKGCLLCJPIB(BCKFHKGPDOK ICKJILCADLE, HIDIGIEPPEB BDMHFDNBPPE, DJJFGNEEIPJ<string>.DIJMCCGECOP OPELNCJDKIK, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x701B7E0", Offset = "0x7019DE0", VA = "0x18701B7E0")]
	[AsyncStateMachine(typeof(OLALPOHFAPJ))]
	private Task<AGHNAPPMNCG> JGBGEMHOKIJ(CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x701B4E0", Offset = "0x7019AE0", VA = "0x18701B4E0")]
	[AsyncStateMachine(typeof(JJELAOONHLC))]
	private Task<AGHNAPPMNCG> INOAKBILKJB(DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x701B640", Offset = "0x7019C40", VA = "0x18701B640")]
	[AsyncStateMachine(typeof(DDDEJFANHKJ))]
	private static Task<AGHNAPPMNCG> INOAKBILKJB(MPJECKENMPL AHBNABCBLNH, KDHIFHNDPAK ONMIHKOKFHC, long NBDDMFOIEKN, long JDAJCIDAAMB, long FDJBEKDGJEH, string LGNLNIECDME, HCMHGKFNLLO CGMKNOJAIEB, CancellationToken DADBOHKBJNO, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x701B230", Offset = "0x7019830", VA = "0x18701B230")]
	private void GEJAFHFBDKO(KBIHKJABELE KMGPOBDIGAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
internal struct PAIBFJBACMA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct EICAKMAMHMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public PAIBFJBACMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x701D4D0", Offset = "0x701BAD0", VA = "0x18701D4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x701DA60", Offset = "0x701C060", VA = "0x18701DA60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400058E")]
	private MPJECKENMPL AHBNABCBLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400058F")]
	private PLBPIEKJMAO FHNKDHIILBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000590")]
	private DJJFGNEEIPJ<string>.DIJMCCGECOP OPELNCJDKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	private float KOKPDLDLCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000592")]
	private float FMLEJFOEAIF;

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x702BB60", Offset = "0x702A160", VA = "0x18702BB60")]
	public static Task HBKKCHNKCME(BCKFHKGPDOK ICKJILCADLE, PLBPIEKJMAO FHNKDHIILBL, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x702BD00", Offset = "0x702A300", VA = "0x18702BD00")]
	[AsyncStateMachine(typeof(EICAKMAMHMA))]
	public Task JGBGEMHOKIJ(CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x702B960", Offset = "0x7029F60", VA = "0x18702B960")]
	private static void EGNHDMAKCJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x702BE20", Offset = "0x702A420", VA = "0x18702BE20")]
	private void JOIMEJCCMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x702BAA0", Offset = "0x702A0A0", VA = "0x18702BAA0")]
	private static float FFMMGFLMDLJ(MPJECKENMPL AHBNABCBLNH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x702B940", Offset = "0x7029F40", VA = "0x18702B940")]
	private static float CCOMEBDDKJD()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000152")]
internal struct EHLCCLMMDOI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct KGBAEGBLOPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public HJBBHPAONAL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public PLBPIEKJMAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private IAOHNBPIHKI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private IKCOGJKNDIG <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private BCKFHKGPDOK <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private IPHABGADLDI.LKBHPNKBIKM <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private TaskAwaiter<ILFKKIOKLHK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x7025400", Offset = "0x7023A00", VA = "0x187025400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x7025C20", Offset = "0x7024220", VA = "0x187025C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct ONJGPCNMANC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private IAOHNBPIHKI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x702B450", Offset = "0x7029A50", VA = "0x18702B450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x702B740", Offset = "0x7029D40", VA = "0x18702B740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x701D390", Offset = "0x701B990", VA = "0x18701D390")]
	[AsyncStateMachine(typeof(KGBAEGBLOPK))]
	public static Task JGBGEMHOKIJ(HJBBHPAONAL PGDPDODKNBI, PLBPIEKJMAO FHNKDHIILBL, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x701D320", Offset = "0x701B920", VA = "0x18701D320")]
	private static Task<ILFKKIOKLHK> ANCNMNADEPK(HJBBHPAONAL PGDPDODKNBI, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x701D260", Offset = "0x701B860", VA = "0x18701D260")]
	[AsyncStateMachine(typeof(ONJGPCNMANC))]
	private static Task ABLENBBPPGN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
internal struct NKPHOHHFPIE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct DELGCHNJPGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public NKPHOHHFPIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x701CAE0", Offset = "0x701B0E0", VA = "0x18701CAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x701D190", Offset = "0x701B790", VA = "0x18701D190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private sealed class KJOFENHFFMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public KJOFENHFFMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x7025FD0", Offset = "0x70245D0", VA = "0x187025FD0")]
		internal object CLHIPINOPAJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct KLLEPBGOFKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public NKPHOHHFPIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private IAOHNBPIHKI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private DPJBCACNOOL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x7026880", Offset = "0x7024E80", VA = "0x187026880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x7026E40", Offset = "0x7025440", VA = "0x187026E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005AD")]
	private bool LKALJOCABHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005AE")]
	private DJJFGNEEIPJ<string>.DIJMCCGECOP OPELNCJDKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005AF")]
	private BCKFHKGPDOK ICKJILCADLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005B0")]
	private CancellationToken DADBOHKBJNO;

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x7029FC0", Offset = "0x70285C0", VA = "0x187029FC0")]
	public static Task GHHKAGLPIKM(BCKFHKGPDOK ICKJILCADLE, bool LKALJOCABHI, DJJFGNEEIPJ<string>.DIJMCCGECOP OPELNCJDKIK, CancellationToken PECMODKKDDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x702A030", Offset = "0x7028630", VA = "0x18702A030")]
	[AsyncStateMachine(typeof(DELGCHNJPGK))]
	private Task JGBGEMHOKIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x7029E90", Offset = "0x7028490", VA = "0x187029E90")]
	[AsyncStateMachine(typeof(KLLEPBGOFKD))]
	private Task AICNKOCMCEF(bool CANNKNKNGIL, string OFICCEEBFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0")]
	private bool DEKKCEFDOCO(bool LKALJOCABHI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct KLKONFHNMKL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private struct AODFOMCFAPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public KLKONFHNMKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x7014940", Offset = "0x7012F40", VA = "0x187014940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x7014EB0", Offset = "0x70134B0", VA = "0x187014EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private sealed class BEGBPGGCOIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public BEGBPGGCOIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x7015C10", Offset = "0x7014210", VA = "0x187015C10")]
		internal object CLHIPINOPAJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private struct CLNOMKJBCJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public KLKONFHNMKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		private IAOHNBPIHKI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		private DPJBCACNOOL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x7018800", Offset = "0x7016E00", VA = "0x187018800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x7018DC0", Offset = "0x70173C0", VA = "0x187018DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C1")]
	private HLJDICKLHEP EODDJCNIAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C2")]
	private DJJFGNEEIPJ<string>.DIJMCCGECOP OPELNCJDKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C3")]
	private BCKFHKGPDOK ICKJILCADLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C4")]
	private bool CBHBFDHLFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005C5")]
	private PLBPIEKJMAO FHNKDHIILBL;

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x7026640", Offset = "0x7024C40", VA = "0x187026640")]
	public static Task<Scene> DBCOACAENCF(BCKFHKGPDOK ICKJILCADLE, HLJDICKLHEP IKGIDIFPDMP, DJJFGNEEIPJ<string>.DIJMCCGECOP OPELNCJDKIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x70266F0", Offset = "0x7024CF0", VA = "0x1870266F0")]
	[AsyncStateMachine(typeof(AODFOMCFAPO))]
	private Task<Scene> JGBGEMHOKIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x70266C0", Offset = "0x7024CC0", VA = "0x1870266C0")]
	private bool HDPKCMNFAOF(PLBPIEKJMAO FHNKDHIILBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x7026810", Offset = "0x7024E10", VA = "0x187026810")]
	private void KGDHLJDNMHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x70264F0", Offset = "0x7024AF0", VA = "0x1870264F0")]
	[AsyncStateMachine(typeof(CLNOMKJBCJI))]
	private Task<Scene> AICNKOCMCEF(string OFICCEEBFIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
internal struct PIFFGGNCAEA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct NHBOJLDGCJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public AsyncTaskMethodBuilder<DMHGCACCENH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public PIFFGGNCAEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public DMHGCACCENH nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public PLBPIEKJMAO deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private TaskAwaiter<DMHGCACCENH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x7029340", Offset = "0x7027940", VA = "0x187029340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x7029E20", Offset = "0x7028420", VA = "0x187029E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private struct KIJICOALNMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public AsyncTaskMethodBuilder<DMHGCACCENH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public PIFFGGNCAEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public DMHGCACCENH state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		private TaskAwaiter<ILFKKIOKLHK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x7025C80", Offset = "0x7024280", VA = "0x187025C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x7025F60", Offset = "0x7024560", VA = "0x187025F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D3")]
	private readonly HJBBHPAONAL PGDPDODKNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D4")]
	private readonly PHKBEKJCEKE IIMBIIGOAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	private readonly INNPNNGIKHG JAHJNFANHGM;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	private IKCOGJKNDIG KPBNJNNOKFB
	{
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x5771280", Offset = "0x576F880", VA = "0x185771280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x702C740", Offset = "0x702AD40", VA = "0x18702C740")]
	public PIFFGGNCAEA(HJBBHPAONAL PGDPDODKNBI, PHKBEKJCEKE IIMBIIGOAFL, INNPNNGIKHG JAHJNFANHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x702C590", Offset = "0x702AB90", VA = "0x18702C590")]
	[AsyncStateMachine(typeof(NHBOJLDGCJN))]
	public Task<DMHGCACCENH> NEHEDKFFEAB(DMHGCACCENH LEOPFMJDCFG, PLBPIEKJMAO AMOMMAANLLG, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO, bool AMDFAONPKJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x702C410", Offset = "0x702AA10", VA = "0x18702C410")]
	[AsyncStateMachine(typeof(KIJICOALNMO))]
	private Task<DMHGCACCENH> AINADGDEBLC(DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, DMHGCACCENH NGHALOPECFO, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x702C710", Offset = "0x702AD10", VA = "0x18702C710")]
	private bool PDFBIFJACMH(DMHGCACCENH FNJKIPEAJGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x702C570", Offset = "0x702AB70", VA = "0x18702C570")]
	private void EMMOGPNJFNP(string FMMDGAOKDIH)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000160")]
internal struct GCGHMGHPEHH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private struct IFDJNMLCJLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public IKCOGJKNDIG operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public PLBPIEKJMAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public OCOGOEMEIEF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private IAOHNBPIHKI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		private List<(PersistenceView, CGIDLDDLPHO)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		private (PersistenceView, CGIDLDDLPHO) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x7022480", Offset = "0x7020A80", VA = "0x187022480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x7022A90", Offset = "0x7021090", VA = "0x187022A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x701FCD0", Offset = "0x701E2D0", VA = "0x18701FCD0")]
	[AsyncStateMachine(typeof(IFDJNMLCJLM))]
	public static Task JGBGEMHOKIJ(IKCOGJKNDIG DNEKMHCKHLJ, PLBPIEKJMAO FHNKDHIILBL, OCOGOEMEIEF MBINDPAJJCA, CancellationToken DADBOHKBJNO)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000162")]
internal struct JOKFNNELCNA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private struct GDKKFHIHFLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public IKCOGJKNDIG operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public PLBPIEKJMAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public OCOGOEMEIEF timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private NGPKNGOLDBM <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private IAOHNBPIHKI <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private List<(PersistenceView, CGIDLDDLPHO)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		private CGIDLDDLPHO <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x701FE10", Offset = "0x701E410", VA = "0x18701FE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x7020660", Offset = "0x701EC60", VA = "0x187020660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x70252C0", Offset = "0x70238C0", VA = "0x1870252C0")]
	[AsyncStateMachine(typeof(GDKKFHIHFLL))]
	public static Task JGBGEMHOKIJ(IKCOGJKNDIG DNEKMHCKHLJ, PLBPIEKJMAO FHNKDHIILBL, OCOGOEMEIEF MBINDPAJJCA, CancellationToken DADBOHKBJNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
internal struct IPHABGADLDI
{
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	public struct LKBHPNKBIKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public List<NNMILFMEHHN> LOBGDEGNIKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public List<CGIDLDDLPHO> JJLBHGKOENG;

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0xAB3FA0", Offset = "0xAB25A0", VA = "0x180AB3FA0")]
		public LKBHPNKBIKM(List<NNMILFMEHHN> LOBGDEGNIKL, List<CGIDLDDLPHO> JJLBHGKOENG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private sealed class JBHOLFMMEJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public IEnumerable<NNMILFMEHHN> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public JBHOLFMMEJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x70245F0", Offset = "0x7022BF0", VA = "0x1870245F0")]
		internal object JPCIFNCMHKM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000602")]
	private BCKFHKGPDOK ICKJILCADLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000603")]
	private PLBPIEKJMAO FHNKDHIILBL;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	private MPJECKENMPL OKAMCKPLNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x70245A0", Offset = "0x7022BA0", VA = "0x1870245A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x7023D30", Offset = "0x7022330", VA = "0x187023D30")]
	public static LKBHPNKBIKM JGBGEMHOKIJ(BCKFHKGPDOK ICKJILCADLE, PLBPIEKJMAO FHNKDHIILBL)
	{
		return default(LKBHPNKBIKM);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x7023D90", Offset = "0x7022390", VA = "0x187023D90")]
	private LKBHPNKBIKM JGBGEMHOKIJ()
	{
		return default(LKBHPNKBIKM);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x7023FF0", Offset = "0x70225F0", VA = "0x187023FF0")]
	private LKBHPNKBIKM LLBLJLMIKBJ(EIGMLKEEHNM LPNOGJAALGA, NGPKNGOLDBM LLGLNKJCGMM)
	{
		return default(LKBHPNKBIKM);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x7023B60", Offset = "0x7022160", VA = "0x187023B60")]
	private bool DAAHNGIHAMG(IEnumerable<NNMILFMEHHN> LOBGDEGNIKL)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000167")]
internal struct CMLBIKAIFEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private sealed class IAKAJKBDNJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public IPHABGADLDI.LKBHPNKBIKM instantiations;

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public IAKAJKBDNJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x7021870", Offset = "0x701FE70", VA = "0x187021870")]
		internal object LDDHEDBMGAB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class CAPLEPIAPAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public CAPLEPIAPAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x7018420", Offset = "0x7016A20", VA = "0x187018420")]
		internal object PCLDHDLDMJO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x7018E30", Offset = "0x7017430", VA = "0x187018E30")]
	public static void JGBGEMHOKIJ(IKCOGJKNDIG DNEKMHCKHLJ, PLBPIEKJMAO FHNKDHIILBL, IPHABGADLDI.LKBHPNKBIKM BBPJJMMNAJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
internal class INNPNNGIKHG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private struct FEHJMAGLMCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public INNPNNGIKHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public DMHGCACCENH operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public PLBPIEKJMAO deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x701EB10", Offset = "0x701D110", VA = "0x18701EB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x701F280", Offset = "0x701D880", VA = "0x18701F280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private sealed class OAOFMOKMJEH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016D")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000618")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000619")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400061A")]
			public OAOFMOKMJEH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400061B")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400061C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x702CAC0", Offset = "0x702B0C0", VA = "0x18702CAC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x702CD80", Offset = "0x702B380", VA = "0x18702CD80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public INNPNNGIKHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public PLBPIEKJMAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public OAOFMOKMJEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x702A6B0", Offset = "0x7028CB0", VA = "0x18702A6B0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task NPDJKCEPIOJ(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private struct NONNFKPDGMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public INNPNNGIKHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public PLBPIEKJMAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		private OAOFMOKMJEH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x702A120", Offset = "0x7028720", VA = "0x18702A120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x702A650", Offset = "0x7028C50", VA = "0x18702A650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct MJKDPLFLGHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public INNPNNGIKHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public PLBPIEKJMAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		private Dictionary<Guid, List<FGNILMNEMNE>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x70286A0", Offset = "0x7026CA0", VA = "0x1870286A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x7028C50", Offset = "0x7027250", VA = "0x187028C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct BAKFECPCJCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public INNPNNGIKHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public PLBPIEKJMAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		private Dictionary<Guid, List<FGNILMNEMNE>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x7015530", Offset = "0x7013B30", VA = "0x187015530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x7015BB0", Offset = "0x70141B0", VA = "0x187015BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class LFLBPCJBKMK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000172")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400063C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400063D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400063E")]
			public FGNILMNEMNE handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400063F")]
			public LFLBPCJBKMK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000640")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005DA")]
			[Cpp2IlInjected.Address(RVA = "0x702C8C0", Offset = "0x702AEC0", VA = "0x18702C8C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DB")]
			[Cpp2IlInjected.Address(RVA = "0x702CA60", Offset = "0x702B060", VA = "0x18702CA60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public FFNPJDKJPEB runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public List<FGNILMNEMNE> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public PLBPIEKJMAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public LFLBPCJBKMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x70275A0", Offset = "0x7025BA0", VA = "0x1870275A0")]
		internal object FFNINODIOBN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x70274B0", Offset = "0x7025AB0", VA = "0x1870274B0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task DMKEJNNAAJO(FGNILMNEMNE handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x70273C0", Offset = "0x70259C0", VA = "0x1870273C0")]
		internal object BABGMMMKDGP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private struct APJBIPEFOOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public FFNPJDKJPEB runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public List<FGNILMNEMNE> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public PLBPIEKJMAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		private LFLBPCJBKMK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x7015000", Offset = "0x7013600", VA = "0x187015000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x70154D0", Offset = "0x7013AD0", VA = "0x1870154D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private struct COEAMDMEEMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public INNPNNGIKHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		public PLBPIEKJMAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x7019870", Offset = "0x7017E70", VA = "0x187019870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x7019E30", Offset = "0x7018430", VA = "0x187019E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private sealed class JIINLOHCHFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public JIINLOHCHFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x7024670", Offset = "0x7022C70", VA = "0x187024670")]
		internal object PEHLDDPFPJG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private struct KNAEKONOMPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public INNPNNGIKHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public PLBPIEKJMAO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		private IAOHNBPIHKI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x7026EA0", Offset = "0x70254A0", VA = "0x187026EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x7027360", Offset = "0x7025960", VA = "0x187027360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private sealed class EDJJBEFIJPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public EDJJBEFIJPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x701D1F0", Offset = "0x701B7F0", VA = "0x18701D1F0")]
		internal object NBPNCCIMDPC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct BOICAFEDDMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public INNPNNGIKHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		private IAOHNBPIHKI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private TaskAwaiter<ILFKKIOKLHK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x70174B0", Offset = "0x7015AB0", VA = "0x1870174B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x7017AF0", Offset = "0x70160F0", VA = "0x187017AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class FBKANCOHJBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public FBKANCOHJBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x701DEE0", Offset = "0x701C4E0", VA = "0x18701DEE0")]
		internal object BLGLMCPEHFG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400060A")]
	private readonly HJBBHPAONAL PGDPDODKNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400060B")]
	private NJBJEHEMIED JAHJNFANHGM;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	private IKCOGJKNDIG KPBNJNNOKFB
	{
		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x92FD40", Offset = "0x92E340", VA = "0x18092FD40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x869B90", Offset = "0x868190", VA = "0x180869B90")]
	public INNPNNGIKHG(HJBBHPAONAL PGDPDODKNBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x70232B0", Offset = "0x70218B0", VA = "0x1870232B0")]
	[AsyncStateMachine(typeof(FEHJMAGLMCJ))]
	public Task JGBGEMHOKIJ(DMHGCACCENH GPGMHDGNGKI, PLBPIEKJMAO AMOMMAANLLG, DJJFGNEEIPJ<string>.DIJMCCGECOP OPELNCJDKIK, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x7023720", Offset = "0x7021D20", VA = "0x187023720")]
	[AsyncStateMachine(typeof(NONNFKPDGMF))]
	private Task LGBPLCEBCDM(PLBPIEKJMAO FHNKDHIILBL, DJJFGNEEIPJ<string>.DIJMCCGECOP OPELNCJDKIK, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x7022C80", Offset = "0x7021280", VA = "0x187022C80")]
	[AsyncStateMachine(typeof(MJKDPLFLGHP))]
	private Task BOEBPAGLMPP(PLBPIEKJMAO FHNKDHIILBL, DJJFGNEEIPJ<string>.DIJMCCGECOP OPELNCJDKIK, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x7023910", Offset = "0x7021F10", VA = "0x187023910")]
	[AsyncStateMachine(typeof(BAKFECPCJCD))]
	private Task PHPFHOAFGMD(PLBPIEKJMAO FHNKDHIILBL, DJJFGNEEIPJ<string>.DIJMCCGECOP OPELNCJDKIK, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x7022DC0", Offset = "0x70213C0", VA = "0x187022DC0")]
	[AsyncStateMachine(typeof(APJBIPEFOOG))]
	private Task DLCKLFEFCJF(Guid BNBONCJHMLB, List<FGNILMNEMNE> ANCAFEECNJJ, FFNPJDKJPEB GLBKKJDOOLB, PLBPIEKJMAO FHNKDHIILBL, CancellationToken OEDJKICDDGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x7023170", Offset = "0x7021770", VA = "0x187023170")]
	[AsyncStateMachine(typeof(COEAMDMEEMI))]
	private Task HECCNJAELPM(PLBPIEKJMAO FHNKDHIILBL, DJJFGNEEIPJ<string>.DIJMCCGECOP OPELNCJDKIK, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x70235E0", Offset = "0x7021BE0", VA = "0x1870235E0")]
	[AsyncStateMachine(typeof(KNAEKONOMPP))]
	private Task JLMMBKPBDIL(Guid KKPNKCFMOOI, PLBPIEKJMAO FHNKDHIILBL, DJJFGNEEIPJ<string>.DIJMCCGECOP OPELNCJDKIK, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x7022F10", Offset = "0x7021510", VA = "0x187022F10")]
	[AsyncStateMachine(typeof(BOICAFEDDMH))]
	private Task DMBANAMLGPP(Guid KKPNKCFMOOI, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x7023050", Offset = "0x7021650", VA = "0x187023050")]
	private void GDKIMFFIDHB(Guid KKPNKCFMOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x7023860", Offset = "0x7021E60", VA = "0x187023860")]
	private void MNBCNNFKNMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x7022AF0", Offset = "0x70210F0", VA = "0x187022AF0")]
	public Guid AFNMHJIMCLF(DMHGCACCENH NIOCHEDFJIC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x7023400", Offset = "0x7021A00", VA = "0x187023400")]
	[CompilerGenerated]
	private object JJEGOPHEAEH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
internal struct OJBLHBFFHOL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private struct JLFMDOBFCNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		public OJBLHBFFHOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		private DJJFGNEEIPJ<string>.DIJMCCGECOP <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		private IEnumerator<FJBAAJDHIHN> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x7024B80", Offset = "0x7023180", VA = "0x187024B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x7025260", Offset = "0x7023860", VA = "0x187025260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000668")]
	private MPJECKENMPL AHBNABCBLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000669")]
	private DJJFGNEEIPJ<string>.DIJMCCGECOP OPELNCJDKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400066A")]
	private CancellationToken DADBOHKBJNO;

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x702AF70", Offset = "0x7029570", VA = "0x18702AF70")]
	public static Task PHINEPMEDPF(MPJECKENMPL AHBNABCBLNH, DJJFGNEEIPJ<string>.DIJMCCGECOP OPELNCJDKIK, CancellationToken PECMODKKDDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x702AE80", Offset = "0x7029480", VA = "0x18702AE80")]
	[AsyncStateMachine(typeof(JLFMDOBFCNB))]
	private Task JGBGEMHOKIJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
public readonly struct LEIHNKGEKLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	public readonly bool PKMAKPBJAIJ;

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0xE3ED70", Offset = "0xE3D370", VA = "0x180E3ED70")]
	public LEIHNKGEKLG(bool HGEPHMCGMNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
public readonly struct GKKPKPAPFIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000672")]
	public readonly EIGMLKEEHNM? PCGPPAHKNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000673")]
	public readonly LBKFLMJBKDK EGOPFLLJMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	public readonly string? BMIBKLOGGJG;

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public IReadOnlyCollection<string> ICKIHMLODGB
	{
		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x70206C0", Offset = "0x701ECC0", VA = "0x1870206C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public IReadOnlyDictionary<long, int> GHHDCHEHCNH
	{
		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x70206E0", Offset = "0x701ECE0", VA = "0x1870206E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x7020700", Offset = "0x701ED00", VA = "0x187020700")]
	public GKKPKPAPFIE(EIGMLKEEHNM? ENLCDNNHBBD, LBKFLMJBKDK JBGFMDDMOAF, string? LJHFHHFIGMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
internal class BLGAAKAOAIK : FKACOPIIIBN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct OBCELOGDCIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public AsyncTaskMethodBuilder<GKKPKPAPFIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public BLGAAKAOAIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public OGHKKFAHDCO serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public HDKPBALEPOD roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private IAOHNBPIHKI <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x702A7A0", Offset = "0x7028DA0", VA = "0x18702A7A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x702AE10", Offset = "0x7029410", VA = "0x18702AE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private sealed class LMBOAFAKJLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public OGHKKFAHDCO serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public BLGAAKAOAIK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public LMBOAFAKJLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x70278B0", Offset = "0x7025EB0", VA = "0x1870278B0")]
		internal Task OCLGPFMCJNN(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x70277D0", Offset = "0x7025DD0", VA = "0x1870277D0")]
		internal Task JAEPFBOKMAI(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class ANLKDNMEJEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public LMBOAFAKJLA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public ANLKDNMEJEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x70148D0", Offset = "0x7012ED0", VA = "0x1870148D0")]
		internal object LOMDLOFNNIE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class IELPPMINPBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public LMBOAFAKJLA CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public IELPPMINPBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x7022440", Offset = "0x7020A40", VA = "0x187022440")]
		internal Task NFPGDPALEDC(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private struct CACDMGDEMND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public OGHKKFAHDCO serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public BLGAAKAOAIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		private ANLKDNMEJEN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		private IAOHNBPIHKI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x7017B50", Offset = "0x7016150", VA = "0x187017B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x70183C0", Offset = "0x70169C0", VA = "0x1870183C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000675")]
	private readonly ICJNMGNJFIN CAJBNIGHKAB;

	[Cpp2IlInjected.Token(Token = "0x4000676")]
	private static readonly TimeSpan ECGCGPKPKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000677")]
	private readonly PJIOPINFABJ PDFPIKFAKPN;

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x7016D70", Offset = "0x7015370", VA = "0x187016D70")]
	public BLGAAKAOAIK(HJBBHPAONAL PGDPDODKNBI, PJIOPINFABJ PDFPIKFAKPN, ICJNMGNJFIN CAJBNIGHKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x70165F0", Offset = "0x7014BF0", VA = "0x1870165F0")]
	[AsyncStateMachine(typeof(OBCELOGDCIM))]
	public Task<GKKPKPAPFIE> KLDBPIDHOEH(long JDAJCIDAAMB, HDKPBALEPOD DFNELONPIOM, OGHKKFAHDCO DBDIEFBCBGK, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x7015C60", Offset = "0x7014260", VA = "0x187015C60")]
	[AsyncStateMachine(typeof(CACDMGDEMND))]
	private Task BHHGPAFMPCH(OGHKKFAHDCO DBDIEFBCBGK, IEnumerable<PersistenceView> HDMNGFGLLKK, StringBuilder KEDNAOAHMKO, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x7016750", Offset = "0x7014D50", VA = "0x187016750")]
	private GKKPKPAPFIE NNABIHPMPNK(long JDAJCIDAAMB, HDKPBALEPOD DFNELONPIOM, OGHKKFAHDCO DBDIEFBCBGK, IEnumerable<PersistenceView> HDMNGFGLLKK, StringBuilder KEDNAOAHMKO)
	{
		return default(GKKPKPAPFIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x7015DA0", Offset = "0x70143A0", VA = "0x187015DA0")]
	private EIGMLKEEHNM CBHCLBJDFJG(long JDAJCIDAAMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x7015F00", Offset = "0x7014500", VA = "0x187015F00")]
	private void CHBGJAMMANB(EIGMLKEEHNM NJEPJKKDBJB, StringBuilder KEDNAOAHMKO, IEnumerable<PersistenceView> HDMNGFGLLKK, [In] ECPGFOJFJIH KHNGIJEABPA, DKGAACBKMJC HICOJCFFCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x7016150", Offset = "0x7014750", VA = "0x187016150")]
	private void ENBAEAMNJCM(EIGMLKEEHNM NJEPJKKDBJB, StringBuilder KEDNAOAHMKO, PersistenceView KBOINDMIKMD, DKGAACBKMJC HICOJCFFCFD, [In] ECPGFOJFJIH KHNGIJEABPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
internal class BODFPDOHLLO : FKACOPIIIBN
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	private sealed class ADGEJFLAFEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		public DPCBEKHGJBE.BFJMMAKLFBE roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public ADGEJFLAFEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x7014610", Offset = "0x7012C10", VA = "0x187014610")]
		internal object KGAFONKBKJB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private struct GAENBNGJAGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public AsyncTaskMethodBuilder<(DPCBEKHGJBE.BFJMMAKLFBE roomDataUpload, DPCBEKHGJBE.BFJMMAKLFBE subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public GKKPKPAPFIE roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public BODFPDOHLLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		private ADGEJFLAFEM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		private TaskAwaiter<DPCBEKHGJBE.BFJMMAKLFBE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x701F410", Offset = "0x701DA10", VA = "0x18701F410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x701FC60", Offset = "0x701E260", VA = "0x18701FC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private struct MCHNEAHPPCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public AsyncTaskMethodBuilder<DOIKEIMKJLC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public BODFPDOHLLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public GKKPKPAPFIE roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public BGDAOBFLICB roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		private TaskAwaiter<(DPCBEKHGJBE.BFJMMAKLFBE roomDataUpload, DPCBEKHGJBE.BFJMMAKLFBE subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		private TaskAwaiter<DOIKEIMKJLC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x7027AD0", Offset = "0x70260D0", VA = "0x187027AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x7028160", Offset = "0x7026760", VA = "0x187028160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private struct PHJJOIAMPAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public AsyncTaskMethodBuilder<CEBEAJJMCEF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public BODFPDOHLLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public GKKPKPAPFIE roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private TaskAwaiter<(DPCBEKHGJBE.BFJMMAKLFBE roomDataUpload, DPCBEKHGJBE.BFJMMAKLFBE subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private TaskAwaiter<CEBEAJJMCEF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x702BF80", Offset = "0x702A580", VA = "0x18702BF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x702C3A0", Offset = "0x702A9A0", VA = "0x18702C3A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private sealed class FLIDKKEMHFM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200018C")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006C3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006C4")]
			public AsyncTaskMethodBuilder<ILFKKIOKLHK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006C5")]
			public FLIDKKEMHFM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006C6")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006C7")]
			private ILFKKIOKLHK <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006C8")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006C9")]
			private TaskAwaiter<CEBEAJJMCEF> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006CA")]
			private TaskAwaiter<DOIKEIMKJLC> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006CB")]
			private TaskAwaiter<ILFKKIOKLHK> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x600061F")]
			[Cpp2IlInjected.Address(RVA = "0x702D1D0", Offset = "0x702B7D0", VA = "0x18702D1D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0x702E160", Offset = "0x702C760", VA = "0x18702E160", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public BODFPDOHLLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public GKKPKPAPFIE roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public BGDAOBFLICB roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		public LEIHNKGEKLG roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public FLIDKKEMHFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x701F2E0", Offset = "0x701D8E0", VA = "0x18701F2E0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<ILFKKIOKLHK> KJBGNKBPGMM(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private struct MICMEEGEKNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public AsyncTaskMethodBuilder<ILFKKIOKLHK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public BODFPDOHLLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public GKKPKPAPFIE roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public BGDAOBFLICB roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		public LEIHNKGEKLG roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		public DJJFGNEEIPJ<string>.DIJMCCGECOP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		private TaskAwaiter<ILFKKIOKLHK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x7028320", Offset = "0x7026920", VA = "0x187028320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x7028630", Offset = "0x7026C30", VA = "0x187028630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400069A")]
	private static readonly ICJNMGNJFIN CAJBNIGHKAB;

	[Cpp2IlInjected.Token(Token = "0x400069B")]
	private static readonly ICJNMGNJFIN JAPBEHPDHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400069C")]
	private readonly KADNCCIKBMN KILDELCNFBI;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	private BCKFHKGPDOK KMCCNKGNGJH
	{
		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x70040B0", Offset = "0x70026B0", VA = "0x1870040B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x7017420", Offset = "0x7015A20", VA = "0x187017420")]
	public BODFPDOHLLO(HJBBHPAONAL PGDPDODKNBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x7017240", Offset = "0x7015840", VA = "0x187017240")]
	[AsyncStateMachine(typeof(GAENBNGJAGL))]
	private Task<(DPCBEKHGJBE.BFJMMAKLFBE, DPCBEKHGJBE.BFJMMAKLFBE)> OPEFFLCIEPG(GKKPKPAPFIE BKEEPMDPFLF, long NBDDMFOIEKN, long ILOMCKJOFJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x70170D0", Offset = "0x70156D0", VA = "0x1870170D0")]
	[AsyncStateMachine(typeof(MCHNEAHPPCC))]
	public Task<DOIKEIMKJLC> KCOIOOKLCML(int GFBPPFHEBGI, [CanBeNull] BGDAOBFLICB HAPCEHIIKKI, GKKPKPAPFIE BKEEPMDPFLF, long NBDDMFOIEKN, long ILOMCKJOFJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x7016DC0", Offset = "0x70153C0", VA = "0x187016DC0")]
	[AsyncStateMachine(typeof(PHJJOIAMPAC))]
	private Task<CEBEAJJMCEF> GEMDAELLEOE(string LGNLNIECDME, int GFBPPFHEBGI, GKKPKPAPFIE BKEEPMDPFLF, long NBDDMFOIEKN, long ILOMCKJOFJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x7016F30", Offset = "0x7015530", VA = "0x187016F30")]
	[AsyncStateMachine(typeof(MICMEEGEKNK))]
	public Task<ILFKKIOKLHK> IECIDLJBCFM(int GFBPPFHEBGI, BGDAOBFLICB? HAPCEHIIKKI, GKKPKPAPFIE BKEEPMDPFLF, long NBDDMFOIEKN, long ILOMCKJOFJN, LEIHNKGEKLG NODBACFAJMJ, DJJFGNEEIPJ<string>.DIJMCCGECOP LPMOFKOBAHD, CancellationToken DADBOHKBJNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
public abstract class DNIOPCDDBAE<T> where T : DNIOPCDDBAE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	internal readonly BCKFHKGPDOK BMBJHLJMGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	private int? EOHEIOPMANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	protected readonly Guid CLFHPNONDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	protected readonly OBDEAKLOPMH IFJIGNILOAI;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	protected T FHNDGJHGOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x583E890", Offset = "0x583CE90", VA = "0x18583E890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x583EC50", Offset = "0x583D250", VA = "0x18583EC50")]
	internal DNIOPCDDBAE(BCKFHKGPDOK AJFFODMCMAC, OBDEAKLOPMH PGPOPMKEFPB, [Optional] Guid? PNICJCCCLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x583EB70", Offset = "0x583D170", VA = "0x18583EB70")]
	private ILFKKIOKLHK NKMMIIABMCE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "4")]
	protected virtual void OMENJGPDAJC(ILFKKIOKLHK NFOHONOFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x583E8F0", Offset = "0x583CEF0", VA = "0x18583E8F0")]
	public T DPNJDLFMEAF(NMCPPAKMEBO OFANFPAHCFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x583EAC0", Offset = "0x583D0C0", VA = "0x18583EAC0")]
	public T IDAAFCLNHEN(int IOEKDOMJPJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x583E990", Offset = "0x583CF90", VA = "0x18583E990", Slot = "5")]
	public virtual Task<NFKPBMFAMEB> HALJOKEOOMK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
public class OPANKGMAOKN : DNIOPCDDBAE<OPANKGMAOKN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	private HIDIGIEPPEB HJCJCIIFPJE;

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x702B870", Offset = "0x7029E70", VA = "0x18702B870")]
	internal OPANKGMAOKN(BCKFHKGPDOK AJFFODMCMAC, OBDEAKLOPMH PGPOPMKEFPB, [Optional] Guid? PNICJCCCLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x6564E10", Offset = "0x6563410", VA = "0x186564E10")]
	public OPANKGMAOKN MDFMNFOGEOG(HIDIGIEPPEB HJCJCIIFPJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x702B7A0", Offset = "0x7029DA0", VA = "0x18702B7A0", Slot = "4")]
	protected override void OMENJGPDAJC(ILFKKIOKLHK NFOHONOFFAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public class CNBPBICCNIL : DNIOPCDDBAE<CNBPBICCNIL>
{
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	internal enum CAGEOHLJPHC
	{
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private struct EKAPFHAICMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public AsyncTaskMethodBuilder<NFKPBMFAMEB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public CNBPBICCNIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private TaskAwaiter<NFKPBMFAMEB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x701DAC0", Offset = "0x701C0C0", VA = "0x18701DAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x701DE70", Offset = "0x701C470", VA = "0x18701DE70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	private CAGEOHLJPHC BIMKIGHDNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006DE")]
	private string IHLBEJPFAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006DF")]
	private BGDAOBFLICB HJCJCIIFPJE;

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x7019700", Offset = "0x7017D00", VA = "0x187019700")]
	internal CNBPBICCNIL(BCKFHKGPDOK AJFFODMCMAC, OBDEAKLOPMH PGPOPMKEFPB, [Optional] Guid? PNICJCCCLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x70193E0", Offset = "0x70179E0", VA = "0x1870193E0")]
	public CNBPBICCNIL FPFLAEICNPK(string LDFBANEAJLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x7019570", Offset = "0x7017B70", VA = "0x187019570")]
	public CNBPBICCNIL OJDEIHMBEDB(bool KIEPBGADNPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x7019500", Offset = "0x7017B00", VA = "0x187019500")]
	public CNBPBICCNIL JMEDAMLIKOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x7019590", Offset = "0x7017B90", VA = "0x187019590", Slot = "4")]
	protected override void OMENJGPDAJC(ILFKKIOKLHK NFOHONOFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x7019410", Offset = "0x7017A10", VA = "0x187019410", Slot = "5")]
	[AsyncStateMachine(typeof(EKAPFHAICMI))]
	public override Task<NFKPBMFAMEB> HALJOKEOOMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x7019530", Offset = "0x7017B30", VA = "0x187019530")]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task<NFKPBMFAMEB> KECCPCMPEOH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
internal static class AAJDEFONLHP
{
	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x7013DC0", Offset = "0x70123C0", VA = "0x187013DC0")]
	public static void CAMAJBHPGDB(this APFHDOCKBNE IIGBGBJGAON, BNPDOGINEIM PDJODALHJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x7013F10", Offset = "0x7012510", VA = "0x187013F10")]
	public static void MNPALFHGFHL(this BNPDOGINEIM JKCIOCOHNMH, [Optional] string NFOHONOFFAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
public static class MGEGHGHKLOA
{
	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x70281D0", Offset = "0x70267D0", VA = "0x1870281D0")]
	public static HCMHGKFNLLO BEMIGOFFGNH(this BHFCOGHJEEL KMLAEFDIHCJ)
	{
		return default(HCMHGKFNLLO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x7028270", Offset = "0x7026870", VA = "0x187028270")]
	public static BHFCOGHJEEL NEDLNGHHFAA(this HCMHGKFNLLO GHMEKAJNKHG)
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
			[Cpp2IlInjected.Token(Token = "0x40006EC")]
			public FDBDPAGJBNM ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006ED")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006EE")]
			public FDBDPAGJBNM HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006EF")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006F0")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006F1")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		private static FDBDPAGJBNM[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		private Dictionary<FDBDPAGJBNM, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x702E840", Offset = "0x702CE40", VA = "0x18702E840")]
		public bool HNBIGCHJOGE(FDBDPAGJBNM EBOADEMOCJF, [Out] ResultConfig FFADDNJMIIP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x702E700", Offset = "0x702CD00", VA = "0x18702E700")]
		public ResultConfig CONOLFBMEEM(FDBDPAGJBNM CLPBFEAPBCA, [Optional] HashSet<FDBDPAGJBNM> PEGHLNBAJNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x702EE10", Offset = "0x702D410", VA = "0x18702EE10", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x702E8B0", Offset = "0x702CEB0", VA = "0x18702E8B0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x8CDE30", Offset = "0x8CC430", VA = "0x1808CDE30")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
public static class MLGHBEJCHMD
{
	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x7028CB0", Offset = "0x70272B0", VA = "0x187028CB0")]
	[PECFDJPHGEK(BOIKMOKIOJG.GameOnly)]
	private static void JEEKJHILOBP(DIIANKCHAHD MEBNPCGEJCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
public interface NKHNFKKJCFE : IEquatable<NKHNFKKJCFE>
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	DateTime BJKJFDCKJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NEGJGPINOGD();

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KJEFDHKGLHB(long NBDDMFOIEKN, long JDAJCIDAAMB, [Out] GKKPKPAPFIE BKEEPMDPFLF);
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
internal class BAMACGIPCAB : HHIACAIEMCD
{
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private sealed class HJEDAMGLCEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public MJNMLCHIOPD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public HJEDAMGLCEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x7031A80", Offset = "0x7030080", VA = "0x187031A80")]
		internal object FOBJDBGPJAN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006F7")]
	private readonly AJPCAHLLPNO CPMAIDHGGNO;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<NKHNFKKJCFE> MPDMAAFJGGL
	{
		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x702F1B0", Offset = "0x702D7B0", VA = "0x18702F1B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x702FB50", Offset = "0x702E150", VA = "0x18702FB50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x869B90", Offset = "0x868190", VA = "0x180869B90")]
	[UnityEngine.Scripting.Preserve]
	public BAMACGIPCAB([JFHFHOOOEKP(null)] AJPCAHLLPNO CPMAIDHGGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x702F7C0", Offset = "0x702DDC0", VA = "0x18702F7C0", Slot = "6")]
	public bool FBEDENEHMKL(long NBDDMFOIEKN, long JDAJCIDAAMB, GKKPKPAPFIE BKEEPMDPFLF, MJNMLCHIOPD BBHKMFMMNIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x1C270D0", Offset = "0x1C256D0", VA = "0x181C270D0")]
	private void DLACOCEACBA(NKHNFKKJCFE ABJEIILOJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x702FC00", Offset = "0x702E200", VA = "0x18702FC00", Slot = "7")]
	public bool PECFFLAFFMG(long NBDDMFOIEKN, long JDAJCIDAAMB, [Out] NKHNFKKJCFE IAHFOGKOOEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x702FAA0", Offset = "0x702E0A0", VA = "0x18702FAA0", Slot = "8")]
	public bool FKMKLBCHPOM(long NBDDMFOIEKN, long JDAJCIDAAMB, MJNMLCHIOPD BBHKMFMMNIP, [Out] NKHNFKKJCFE IAHFOGKOOEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x702F260", Offset = "0x702D860", VA = "0x18702F260")]
	private void ALCFPLGMOIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x702F690", Offset = "0x702DC90", VA = "0x18702F690", Slot = "9")]
	public void EJOLKPLHOEK(long NBDDMFOIEKN, long JDAJCIDAAMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
internal abstract class CMNIOHEEBGI : AJPCAHLLPNO
{
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	protected enum LPLNPIPMJHL : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[CompilerGenerated]
	private sealed class BHOPLKLLKNE : IEnumerable<NKHNFKKJCFE>, IEnumerable, IEnumerator<NKHNFKKJCFE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		private NKHNFKKJCFE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public CMNIOHEEBGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		private MJNMLCHIOPD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public MJNMLCHIOPD <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		private NKHNFKKJCFE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000669")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x8BC660", Offset = "0x8BAC60", VA = "0x1808BC660")]
		[DebuggerHidden]
		public BHOPLKLLKNE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x702FD70", Offset = "0x702E370", VA = "0x18702FD70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x7030050", Offset = "0x702E650", VA = "0x187030050", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x702FFA0", Offset = "0x702E5A0", VA = "0x18702FFA0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NKHNFKKJCFE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x702FFA0", Offset = "0x702E5A0", VA = "0x18702FFA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	[CompilerGenerated]
	private sealed class PNAPOJHIEOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		public MJNMLCHIOPD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public PNAPOJHIEOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x7033D00", Offset = "0x7032300", VA = "0x187033D00")]
		internal object LKFCDCMOOPD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	[CompilerGenerated]
	private sealed class HIOILDFINDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		public CMNIOHEEBGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public HIOILDFINDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x7031A00", Offset = "0x7030000", VA = "0x187031A00")]
		internal void GCKFNDNNHNG(OLCAILHHMOI.HHNMBNMHLPD ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006FD")]
	private readonly object FPGDFOFJOBB;

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	protected string MIMPGCFFLAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x7030290", Offset = "0x702E890", VA = "0x187030290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public abstract NOMKLNMDMIO KIGIDCMMNMN
	{
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x7030AB0", Offset = "0x702F0B0", VA = "0x187030AB0")]
	protected CMNIOHEEBGI([CanBeNull] string PFGLAIAMAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x70300A0", Offset = "0x702E6A0", VA = "0x1870300A0", Slot = "5")]
	public bool ADLFMODPJHK(long NBDDMFOIEKN, long JDAJCIDAAMB, MJNMLCHIOPD BBHKMFMMNIP, [Out] NKHNFKKJCFE ABJEIILOJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x70309B0", Offset = "0x702EFB0", VA = "0x1870309B0", Slot = "6")]
	[IteratorStateMachine(typeof(BHOPLKLLKNE))]
	public IEnumerable<NKHNFKKJCFE> KJMFEINHMKE(MJNMLCHIOPD BBHKMFMMNIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void IKLPEDAHMHG(Stream FPPMLPEOIEI, long NBDDMFOIEKN, long JDAJCIDAAMB, GKKPKPAPFIE BKEEPMDPFLF);

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool MLGPKBCDCHA(Stream CELHPFBMJOO, long NBDDMFOIEKN, long JDAJCIDAAMB, GDIACAFNHBA AIABGHCCJPG, [Out] GKKPKPAPFIE BKEEPMDPFLF);

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x70302A0", Offset = "0x702E8A0", VA = "0x1870302A0", Slot = "7")]
	public NKHNFKKJCFE CKEGPFKMHAH(long NBDDMFOIEKN, long JDAJCIDAAMB, GKKPKPAPFIE BKEEPMDPFLF, MJNMLCHIOPD BBHKMFMMNIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo IFPELPLHBBD(long NBDDMFOIEKN, long JDAJCIDAAMB, MJNMLCHIOPD BBHKMFMMNIP, LPLNPIPMJHL JOFPPJPDLOA);

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo ECHEPJBJAEH(MJNMLCHIOPD BBHKMFMMNIP, LPLNPIPMJHL JOFPPJPDLOA);

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x7030A40", Offset = "0x702F040", VA = "0x187030A40")]
	protected void NFCHPOEGEHD(OLCAILHHMOI.HHNMBNMHLPD BOHEELIDNPG, string FMMDGAOKDIH, FileInfo HINJFCGOFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x7030620", Offset = "0x702EC20", VA = "0x187030620")]
	internal bool FMEDHODENPB(FileInfo BNILPKEAEEA, long NBDDMFOIEKN, long JDAJCIDAAMB, [Out] GKKPKPAPFIE BKEEPMDPFLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
	private void IIJHHCFKOIK(Exception MKGEIKBIPFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
internal class KONPKEAOMLK : CMNIOHEEBGI
{
	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public override NOMKLNMDMIO KIGIDCMMNMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0xCB6F20", Offset = "0xCB5520", VA = "0x180CB6F20", Slot = "8")]
		get
		{
			return default(NOMKLNMDMIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x7033800", Offset = "0x7031E00", VA = "0x187033800")]
	public KONPKEAOMLK([Optional] string PFGLAIAMAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x7032D20", Offset = "0x7031320", VA = "0x187032D20")]
	private void DDCHFMNFPID(MJNMLCHIOPD BBHKMFMMNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x7032F90", Offset = "0x7031590", VA = "0x187032F90", Slot = "9")]
	internal override void IKLPEDAHMHG(Stream FPPMLPEOIEI, long NBDDMFOIEKN, long JDAJCIDAAMB, GKKPKPAPFIE BKEEPMDPFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x7033220", Offset = "0x7031820", VA = "0x187033220", Slot = "10")]
	internal override bool MLGPKBCDCHA(Stream CELHPFBMJOO, long NBDDMFOIEKN, long JDAJCIDAAMB, GDIACAFNHBA AIABGHCCJPG, [Out] GKKPKPAPFIE BKEEPMDPFLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x7032EA0", Offset = "0x70314A0", VA = "0x187032EA0", Slot = "11")]
	protected override FileInfo IFPELPLHBBD(long NBDDMFOIEKN, long JDAJCIDAAMB, MJNMLCHIOPD BBHKMFMMNIP, LPLNPIPMJHL JOFPPJPDLOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x7032DA0", Offset = "0x70313A0", VA = "0x187032DA0", Slot = "12")]
	protected override DirectoryInfo ECHEPJBJAEH(MJNMLCHIOPD BBHKMFMMNIP, LPLNPIPMJHL JOFPPJPDLOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal sealed class JNDJCAGGBBA : CMNIOHEEBGI
{
	[Cpp2IlInjected.Token(Token = "0x400070D")]
	private static readonly byte[] BHEIPBKEDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400070E")]
	private readonly byte[] HKGBPLPCIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400070F")]
	private readonly byte[] NOOPHLJIJBB;

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public override NOMKLNMDMIO KIGIDCMMNMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x5E03550", Offset = "0x5E01B50", VA = "0x185E03550", Slot = "8")]
		get
		{
			return default(NOMKLNMDMIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x7032C30", Offset = "0x7031230", VA = "0x187032C30")]
	public JNDJCAGGBBA([Optional] string PFGLAIAMAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x7032050", Offset = "0x7030650", VA = "0x187032050", Slot = "9")]
	internal override void IKLPEDAHMHG(Stream FPPMLPEOIEI, long NBDDMFOIEKN, long JDAJCIDAAMB, GKKPKPAPFIE BKEEPMDPFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x70323D0", Offset = "0x70309D0", VA = "0x1870323D0", Slot = "10")]
	internal override bool MLGPKBCDCHA(Stream CELHPFBMJOO, long NBDDMFOIEKN, long JDAJCIDAAMB, GDIACAFNHBA AIABGHCCJPG, [Out] GKKPKPAPFIE BKEEPMDPFLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x7032310", Offset = "0x7030910", VA = "0x187032310")]
	private void KFDBOGHPNKD(byte[] JFDEDKFKPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0x7031F20", Offset = "0x7030520", VA = "0x187031F20", Slot = "11")]
	protected override FileInfo IFPELPLHBBD(long NBDDMFOIEKN, long JDAJCIDAAMB, MJNMLCHIOPD BBHKMFMMNIP, LPLNPIPMJHL JOFPPJPDLOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x7031E10", Offset = "0x7030410", VA = "0x187031E10", Slot = "12")]
	protected override DirectoryInfo ECHEPJBJAEH(MJNMLCHIOPD BBHKMFMMNIP, LPLNPIPMJHL JOFPPJPDLOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
public enum NOMKLNMDMIO : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000711")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x4000712")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x4000713")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001A5")]
internal class EPFMHFHHADJ : AJPCAHLLPNO
{
	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[CompilerGenerated]
	private sealed class OEGIFNFBICA : IEnumerable<NKHNFKKJCFE>, IEnumerable, IEnumerator<NKHNFKKJCFE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		private NKHNFKKJCFE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		public EPFMHFHHADJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		private MJNMLCHIOPD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		public MJNMLCHIOPD <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		private NOMKLNMDMIO[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		private IEnumerator<NKHNFKKJCFE> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		private NKHNFKKJCFE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000690")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x8BC660", Offset = "0x8BAC60", VA = "0x1808BC660")]
		[DebuggerHidden]
		public OEGIFNFBICA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x7033C70", Offset = "0x7032270", VA = "0x187033C70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x7033840", Offset = "0x7031E40", VA = "0x187033840", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x7033B20", Offset = "0x7032120", VA = "0x187033B20")]
		private void PEOGCCBKFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x7033C20", Offset = "0x7032220", VA = "0x187033C20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x7033B70", Offset = "0x7032170", VA = "0x187033B70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NKHNFKKJCFE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x7033B70", Offset = "0x7032170", VA = "0x187033B70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000714")]
	private readonly NOMKLNMDMIO[] CJANPLHKBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000715")]
	private readonly Dictionary<NOMKLNMDMIO, AJPCAHLLPNO> ACNIAGJFMMM;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public NOMKLNMDMIO KIGIDCMMNMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x7030D60", Offset = "0x702F360", VA = "0x187030D60", Slot = "4")]
		get
		{
			return default(NOMKLNMDMIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x7031040", Offset = "0x702F640", VA = "0x187031040")]
	[UnityEngine.Scripting.Preserve]
	public EPFMHFHHADJ(params AJPCAHLLPNO[] DAGGLOEFJAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x7030B30", Offset = "0x702F130", VA = "0x187030B30", Slot = "5")]
	public bool ADLFMODPJHK(long NBDDMFOIEKN, long JDAJCIDAAMB, MJNMLCHIOPD BBHKMFMMNIP, [Out] NKHNFKKJCFE ABJEIILOJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x7030D90", Offset = "0x702F390", VA = "0x187030D90")]
	private void IJABFKGANKD(int EFJAALNAEDF, long NBDDMFOIEKN, long JDAJCIDAAMB, MJNMLCHIOPD BBHKMFMMNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x7030FB0", Offset = "0x702F5B0", VA = "0x187030FB0", Slot = "6")]
	[IteratorStateMachine(typeof(OEGIFNFBICA))]
	public IEnumerable<NKHNFKKJCFE> KJMFEINHMKE(MJNMLCHIOPD BBHKMFMMNIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x7030C80", Offset = "0x702F280", VA = "0x187030C80", Slot = "7")]
	public NKHNFKKJCFE CKEGPFKMHAH(long NBDDMFOIEKN, long JDAJCIDAAMB, GKKPKPAPFIE BKEEPMDPFLF, MJNMLCHIOPD BBHKMFMMNIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
internal static class JHLBMEFDMJA
{
	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x7031AF0", Offset = "0x70300F0", VA = "0x187031AF0")]
	internal static byte[] BJMAJINKMHD(byte[] JFDEDKFKPOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x7031D90", Offset = "0x7030390", VA = "0x187031D90")]
	public static void IMPHHBGJALK(Stream OBCPGDKFCGC, byte[] MFKGIKCPEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x7031BB0", Offset = "0x70301B0", VA = "0x187031BB0")]
	public static bool DFFMGENFONC(Stream OBCPGDKFCGC, long JJOLLFNFHOB, GDIACAFNHBA MKBIHPJMJNJ, [Out] byte[] CBCJLIMEBPN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
internal sealed class HIAFGLBMICI : NKHNFKKJCFE, IEquatable<NKHNFKKJCFE>, IEquatable<HIAFGLBMICI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000723")]
	private readonly CMNIOHEEBGI APKEIBFIPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000724")]
	public readonly FileInfo EEGIIBPLLGD;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public NOMKLNMDMIO KIGIDCMMNMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x6A03450", Offset = "0x6A01A50", VA = "0x186A03450", Slot = "9")]
		get
		{
			return default(NOMKLNMDMIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public DateTime BJKJFDCKJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x7031620", Offset = "0x702FC20", VA = "0x187031620", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x70318F0", Offset = "0x702FEF0", VA = "0x1870318F0")]
	public HIAFGLBMICI(CMNIOHEEBGI CNECKONFKGH, FileInfo BNILPKEAEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x7031840", Offset = "0x702FE40", VA = "0x187031840", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x7031780", Offset = "0x702FD80", VA = "0x187031780", Slot = "5")]
	public void NEGJGPINOGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x7031740", Offset = "0x702FD40", VA = "0x187031740", Slot = "6")]
	public bool KJEFDHKGLHB(long NBDDMFOIEKN, long JDAJCIDAAMB, [Out] GKKPKPAPFIE BKEEPMDPFLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x7031540", Offset = "0x702FB40", VA = "0x187031540", Slot = "7")]
	public bool Equals(NKHNFKKJCFE LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x7031390", Offset = "0x702F990", VA = "0x187031390", Slot = "8")]
	public bool Equals(HIAFGLBMICI LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x7031450", Offset = "0x702FA50", VA = "0x187031450", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x70316B0", Offset = "0x702FCB0", VA = "0x1870316B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AA")]
public delegate void GDIACAFNHBA(OLCAILHHMOI.HHNMBNMHLPD KCBEFPHPKAM, string NFOHONOFFAP);
[Cpp2IlInjected.Token(Token = "0x20001AB")]
internal interface AJPCAHLLPNO
{
	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	NOMKLNMDMIO KIGIDCMMNMN
	{
		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ADLFMODPJHK(long NBDDMFOIEKN, long JDAJCIDAAMB, MJNMLCHIOPD BBHKMFMMNIP, [Out] NKHNFKKJCFE ABJEIILOJGD);

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<NKHNFKKJCFE> KJMFEINHMKE(MJNMLCHIOPD BBHKMFMMNIP);

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NKHNFKKJCFE CKEGPFKMHAH(long NBDDMFOIEKN, long JDAJCIDAAMB, GKKPKPAPFIE BKEEPMDPFLF, MJNMLCHIOPD BBHKMFMMNIP);
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
