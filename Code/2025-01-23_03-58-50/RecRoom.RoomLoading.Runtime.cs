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
using RecRoom.DataLayer.Registration;
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
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7678830", Offset = "0x7677030", VA = "0x187678830")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B60", Offset = "0x8DF360", VA = "0x1808E0B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E0BA0", Offset = "0x8DF3A0", VA = "0x1808E0BA0")]
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
	public class LogRegistrationIndex : GEPCMJPGCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x76758A0", Offset = "0x76740A0", VA = "0x1876758A0", Slot = "4")]
		public override void CCEDGNHHKOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
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
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x767F6A0", Offset = "0x767DEA0", VA = "0x18767F6A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x21F3FE0", Offset = "0x21F27E0", VA = "0x1821F3FE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class KFHNCDMNLPH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x76701A0", Offset = "0x766E9A0", VA = "0x1876701A0")]
	public KFHNCDMNLPH(string PJFOMDHJLBF, Exception OIFLGCNHIPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class ENPJJKPAGNL : HBCAFLOPKHK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct IIBKJNKBEOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<DJPINPOMHEF>> <>t__builder;

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
		private TaskAwaiter<KBJFEOGBAAH<DJPINPOMHEF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x766E220", Offset = "0x766CA20", VA = "0x18766E220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x766E460", Offset = "0x766CC60", VA = "0x18766E460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct IDPJAFJKCDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<KFNGJLJBKPA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<KFNGJLJBKPA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x766DFA0", Offset = "0x766C7A0", VA = "0x18766DFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x766E1B0", Offset = "0x766C9B0", VA = "0x18766E1B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	[UnityEngine.Scripting.Preserve]
	public ENPJJKPAGNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7669090", Offset = "0x7667890", VA = "0x187669090", Slot = "4")]
	[AsyncStateMachine(typeof(IIBKJNKBEOK))]
	public Task<IReadOnlyList<DJPINPOMHEF>> FJMKCPGIIIM(long NKDNOGOOODN, long IFPDLCPBOCG, [Optional] CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7668F80", Offset = "0x7667780", VA = "0x187668F80", Slot = "5")]
	[AsyncStateMachine(typeof(IDPJAFJKCDH))]
	public Task<IReadOnlyList<KFNGJLJBKPA>> CCHNPJPNLDO(IReadOnlyList<int> JOBBGJECCLJ, [Optional] CancellationToken ALKEMFHOMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BGOONGALNCO : IEquatable<BGOONGALNCO>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int IJPKELACNCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	KFNGJLJBKPA GFPGHEALHLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime FGMDCLEGHIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	DILGPODPEFI? KHGDLMIILBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	CMFGILCAHNN? MKKPPPFKGOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	HCOHBPMCNIH HIJBMFHGNAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<NDIOHACFFEO> FMPJGMCHBGK();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum HCOHBPMCNIH
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HBCAFLOPKHK
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<DJPINPOMHEF>> FJMKCPGIIIM(long NKDNOGOOODN, long IFPDLCPBOCG, [Optional] CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<KFNGJLJBKPA>> CCHNPJPNLDO(IReadOnlyList<int> JOBBGJECCLJ, [Optional] CancellationToken ALKEMFHOMCA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class BADLHBGEPEK
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class AJJAHNKBLFN : BGOONGALNCO, IEquatable<BGOONGALNCO>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct HJPKEKGODPM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<NDIOHACFFEO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public AJJAHNKBLFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private IAGIDJJHKCJ <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<NIHPFEHJKNJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<NDIOHACFFEO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x766D380", Offset = "0x766BB80", VA = "0x18766D380", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x766D840", Offset = "0x766C040", VA = "0x18766D840", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly DJPINPOMHEF BEGHGILHCAF;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int IJPKELACNCA
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8BC040", Offset = "0x8BA840", VA = "0x1808BC040", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public KFNGJLJBKPA GFPGHEALHLG
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime HGOKCEJEDHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x60EEC40", Offset = "0x60ED440", VA = "0x1860EEC40", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public DILGPODPEFI? KHGDLMIILBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9C80C0", Offset = "0x9C68C0", VA = "0x1809C80C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public CMFGILCAHNN? MKKPPPFKGOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x60EED40", Offset = "0x60ED540", VA = "0x1860EED40", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public HCOHBPMCNIH HIJBMFHGNAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x92F1C0", Offset = "0x92D9C0", VA = "0x18092F1C0", Slot = "10")]
			get
			{
				return default(HCOHBPMCNIH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7661EC0", Offset = "0x76606C0", VA = "0x187661EC0", Slot = "9")]
		[AsyncStateMachine(typeof(HJPKEKGODPM))]
		public Task<NDIOHACFFEO> FMPJGMCHBGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7662040", Offset = "0x7660840", VA = "0x187662040")]
		public AJJAHNKBLFN(int LDHLFJECJEF, KFNGJLJBKPA BHMMNHENEFD, DJPINPOMHEF BEGHGILHCAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7661E30", Offset = "0x7660630", VA = "0x187661E30", Slot = "11")]
		public bool Equals(BGOONGALNCO LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7661D90", Offset = "0x7660590", VA = "0x187661D90", Slot = "0")]
		public override bool Equals(object INCBEIDOHDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7661D50", Offset = "0x7660550", VA = "0x187661D50")]
		private bool EBALKKMIAEA(AJJAHNKBLFN LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7661FC0", Offset = "0x76607C0", VA = "0x187661FC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class DJJAOCPPLFG : BGOONGALNCO, IEquatable<BGOONGALNCO>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct DGAKGJLBHEO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<NDIOHACFFEO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public DJJAOCPPLFG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<NDIOHACFFEO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7664190", Offset = "0x7662990", VA = "0x187664190", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x76643E0", Offset = "0x7662BE0", VA = "0x1876643E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly JLLNKPIMHOC ABABEEGMCPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly DILGPODPEFI GBACGCCGAOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly CMFGILCAHNN GKHHMBGCOKN;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int IJPKELACNCA
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7664B50", Offset = "0x7663350", VA = "0x187664B50", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public KFNGJLJBKPA GFPGHEALHLG
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x76646B0", Offset = "0x7662EB0", VA = "0x1876646B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime HGOKCEJEDHE
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7664B00", Offset = "0x7663300", VA = "0x187664B00", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public DILGPODPEFI? KHGDLMIILBI
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x76647A0", Offset = "0x7662FA0", VA = "0x1876647A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public CMFGILCAHNN? MKKPPPFKGOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7664940", Offset = "0x7663140", VA = "0x187664940", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public HCOHBPMCNIH HIJBMFHGNAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x926710", Offset = "0x924F10", VA = "0x180926710", Slot = "10")]
			get
			{
				return default(HCOHBPMCNIH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x181CE00", Offset = "0x181B600", VA = "0x18181CE00")]
		public DJJAOCPPLFG(JLLNKPIMHOC AAMKNFCFLGD, DILGPODPEFI OIKOLKEKKLI, CMFGILCAHNN OLCJDNIIMNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7664990", Offset = "0x7663190", VA = "0x187664990", Slot = "9")]
		[AsyncStateMachine(typeof(DGAKGJLBHEO))]
		public Task<NDIOHACFFEO> FMPJGMCHBGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x76647F0", Offset = "0x7662FF0", VA = "0x1876647F0", Slot = "11")]
		public bool Equals(BGOONGALNCO LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7664890", Offset = "0x7663090", VA = "0x187664890", Slot = "0")]
		public override bool Equals(object INCBEIDOHDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7664740", Offset = "0x7662F40", VA = "0x187664740")]
		private bool EBALKKMIAEA(DJJAOCPPLFG LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7664A80", Offset = "0x7663280", VA = "0x187664A80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class KFJFBMGLPIE : BGOONGALNCO, IEquatable<BGOONGALNCO>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct EEBJMLILELL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<NDIOHACFFEO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<NDIOHACFFEO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7666570", Offset = "0x7664D70", VA = "0x187666570", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x76667D0", Offset = "0x7664FD0", VA = "0x1876667D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly KFNGJLJBKPA BNOKBHJIJHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly DILGPODPEFI GBACGCCGAOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly CMFGILCAHNN GKHHMBGCOKN;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int IJPKELACNCA
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x76705E0", Offset = "0x766EDE0", VA = "0x1876705E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public KFNGJLJBKPA GFPGHEALHLG
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime HGOKCEJEDHE
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public DILGPODPEFI? KHGDLMIILBI
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x76702F0", Offset = "0x766EAF0", VA = "0x1876702F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public CMFGILCAHNN? MKKPPPFKGOM
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7670430", Offset = "0x766EC30", VA = "0x187670430", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public HCOHBPMCNIH HIJBMFHGNAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "10")]
			get
			{
				return default(HCOHBPMCNIH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x181CE00", Offset = "0x181B600", VA = "0x18181CE00")]
		public KFJFBMGLPIE(KFNGJLJBKPA BHMMNHENEFD, DILGPODPEFI OIKOLKEKKLI, CMFGILCAHNN OLCJDNIIMNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7670480", Offset = "0x766EC80", VA = "0x187670480", Slot = "9")]
		[AsyncStateMachine(typeof(EEBJMLILELL))]
		public Task<NDIOHACFFEO> FMPJGMCHBGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x76703C0", Offset = "0x766EBC0", VA = "0x1876703C0", Slot = "11")]
		public bool Equals(BGOONGALNCO LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7670340", Offset = "0x766EB40", VA = "0x187670340", Slot = "0")]
		public override bool Equals(object INCBEIDOHDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7670550", Offset = "0x766ED50", VA = "0x187670550", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7670210", Offset = "0x766EA10", VA = "0x187670210")]
		private bool EBALKKMIAEA(KFJFBMGLPIE LIHCAHPMPHD)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct EEJLJMNDFBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<BGOONGALNCO>> <>t__builder;

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
		public BADLHBGEPEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<DJPINPOMHEF> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<DJPINPOMHEF>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, KFNGJLJBKPA account, DJPINPOMHEF roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7666840", Offset = "0x7665040", VA = "0x187666840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7667670", Offset = "0x7665E70", VA = "0x187667670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct KMLNGHACIBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, KFNGJLJBKPA account, DJPINPOMHEF roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<DJPINPOMHEF> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public BADLHBGEPEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<KFNGJLJBKPA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7674B40", Offset = "0x7673340", VA = "0x187674B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7675540", Offset = "0x7673D40", VA = "0x187675540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly ELCDAOMFKJC JDKNEIAHLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly HBCAFLOPKHK DIEINAJJECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly NBHKCAGANPC OCJNBBMJOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly LAMAMKMDIIM<(long, long), IReadOnlyList<DJPINPOMHEF>> AHEOMJMBEBD;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x76624A0", Offset = "0x7660CA0", VA = "0x1876624A0")]
	[UnityEngine.Scripting.Preserve]
	public BADLHBGEPEK([NDCFMLCHJCI(null)] HBCAFLOPKHK OKIFKJKEAHO, [NDCFMLCHJCI(null)] NBHKCAGANPC MPCJPPBEFBN, [NDCFMLCHJCI(null)] ELCDAOMFKJC HIHGFBNEBGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7662350", Offset = "0x7660B50", VA = "0x187662350")]
	[AsyncStateMachine(typeof(EEJLJMNDFBE))]
	public Task<IList<BGOONGALNCO>> PIAABHMKBAN(long NKDNOGOOODN, long ACPFGDPOKJK, bool CEPDLBIKJAG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x76620A0", Offset = "0x76608A0", VA = "0x1876620A0")]
	private bool AIKCHHGNMDA(DateTime? PKICPCMKLOD, long NKDNOGOOODN, long ACPFGDPOKJK, [Out] JLLNKPIMHOC FIBEEOLBGPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7662240", Offset = "0x7660A40", VA = "0x187662240")]
	[AsyncStateMachine(typeof(KMLNGHACIBB))]
	private Task<IReadOnlyList<(int, KFNGJLJBKPA, DJPINPOMHEF)>> MJAINBJHPFN(IReadOnlyList<DJPINPOMHEF> ABKDKEFAJOC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NBHKCAGANPC
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<JLLNKPIMHOC> HMOPDGCHAJJ;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AFNMDODAPKG(long NKDNOGOOODN, long ACPFGDPOKJK, MLONKGHJMMO BNCKJFBLGEG, GIAKNOPIGAP LGKPGNPIEMH);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FPCBAGECNJC(long NKDNOGOOODN, long ACPFGDPOKJK, [Out] JLLNKPIMHOC FIBEEOLBGPB);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OPLECINMPBB(long NKDNOGOOODN, long ACPFGDPOKJK, GIAKNOPIGAP LGKPGNPIEMH, [Out] JLLNKPIMHOC FIBEEOLBGPB);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PIJHEDPFLLH(long NKDNOGOOODN, long ACPFGDPOKJK);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface DFOGKGLJPAP : IJHDFCLIPMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool NBPODBKECOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task IDAIGLKCOJP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JDEAMOHECIE(Task DIGFCMIOIEB, string AEKNFEBENPE);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface PBEGAKKMGKP : IJHDFCLIPMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NDIOHACFFEO> CIJEIBMEOAI(JLLNKPIMHOC FIBEEOLBGPB);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HPFJOKMGDPG(CancellationToken ALKEMFHOMCA);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface EELLJKLPNNH : IJHDFCLIPMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	OKNDNPAECMD EDNDONMKPNN
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OOEAKHGPBOB();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OMGDICDPPJN();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface IJHDFCLIPMB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHFCOOMFLME(PJDNBPNFOAH JCCNNNNOALN);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface DDLHHFMIEGG
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan OMFHELBFEAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan IGNKMAPADMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan AOLENIFAPJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan AHPIGADBNAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool EIECLMHBFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool EHPDOCIOAOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool GIDFJIMOHIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int MLBFLEGOJOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool GFGANBKJGOC
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool EDAGDLJKONG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum IGMOKHNOLEN
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum CCHDDALCCNH
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
public struct BIBPMJIGLBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long EPMECPICIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long IFPDLCPBOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly IGMOKHNOLEN OCLAPBNMMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception CBBMIOJIEEH;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x76639A0", Offset = "0x76621A0", VA = "0x1876639A0")]
	public BIBPMJIGLBK(long EPMECPICIDJ, long IFPDLCPBOCG, IGMOKHNOLEN OCLAPBNMMGE, [CanBeNull] Exception CBBMIOJIEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7663950", Offset = "0x7662150", VA = "0x187663950")]
	public static BIBPMJIGLBK PJGGPIGEKEG(DILBKEMEFHP HCDBJHBHLNA, IGMOKHNOLEN OCLAPBNMMGE, [Optional] Exception CBBMIOJIEEH)
	{
		return default(BIBPMJIGLBK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void HMEJOPJFGLF(BIBPMJIGLBK AKOGEPKEAPE);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface JOCCAOEHDFO : IJHDFCLIPMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action DBOICMOMJCF;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event HMEJOPJFGLF LKLGDCEDIBO;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event HMEJOPJFGLF AJLMJBHFALB;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event HMEJOPJFGLF CANKLBBPAKC;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<CCHDDALCCNH, bool> KCKIGBFOCPN;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PGAEGHPCCCD();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MMGFCAIDOME(BIBPMJIGLBK AKOGEPKEAPE);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EPFODNIDNOL(BIBPMJIGLBK AKOGEPKEAPE);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DAIPEOPCFOI(BIBPMJIGLBK AKOGEPKEAPE);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DAHOPJIDLHD(CCHDDALCCNH CAKEPGIDGEO, bool ANJHFABIGJN);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface AKPMLFACMOB : IJHDFCLIPMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task IBOAKIKFEHH();

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BJDLMOHNDBE();
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface EDKIGICJHAI : IJHDFCLIPMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TaskStatus BNBFMGMNAEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DOANGELBCAL(DILBKEMEFHP EOGDECBBPFB, GMGJCKPIDOB COFODFGPBCD, CancellationToken LCOCKEOACEA);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal static class KJPECJAGFLP
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x76740D0", Offset = "0x76728D0", VA = "0x1876740D0")]
	public static bool MPHCPNJBJHM(this EDKIGICJHAI CPNJLLMGJNF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate Task EIKIKIJKDHH(CancellationToken DJIMHLGHFGI, int FNNMEEPNLFL, NBGFMFDOHOO KAMIPNGFFGD);
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface MNOJCPELDFP : IJHDFCLIPMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DMIECGLIHDG(EIKIKIJKDHH PEBMJKNPMNN);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface PJDNBPNFOAH : IAGIDJJHKCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CancellationToken OPCJAMJKEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	CMONJLKOOCI IDBNEOAELLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	LIMEHMPEEEM HNJDHBNNOAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	GJNLAGFAODO BEFMLKDPPHD
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	PCCBFICHMFB KOJHMMMMDLE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	DLHLIBLDHEL CBPIDHGFGIN
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	EPDKCEBIKOC GODGKOOOGIC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	GKICLCGBOMN GCIEKMGLNOD
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	JDBACAEAFMP CIKJLNOFFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	DFOGKGLJPAP IBNCLNDNFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	PBEGAKKMGKP AHCLAFJKBCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	JOCCAOEHDFO OJHMILIHCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	AKPMLFACMOB FPNFFBBEAOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	EDKIGICJHAI GLMGKPJNJGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	MNOJCPELDFP AOAMFGOJHHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	LICNABCHEMA IENDPJBDODE
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	ANAPOHGFCAE EJHKNBFLCFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	PMJGCCPCNPB POMGELHAMJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	DOJKJBCDKGH EHNCJCOANIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	LOCGHKLNEFM ICKMJPMJLOL
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	OPOIJEOAEKC PCKPALMGFGE
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	DGFDFLCAHPC AHEENJEIHBD
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	LHADMAJEKNN KCPPJFCNFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	LLJILFIJBKF GELDPCJFLKL
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	IBOMOHAPHAO DJBOAFEODHL
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	EELLJKLPNNH FNGJHIDJCJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	DDLHHFMIEGG CANEKAOHJLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	NDJOKDICBGD PIPOCNHJHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	NBHKCAGANPC EHHEFJLNBBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	LNGFDFLNPDH NILMOABFMKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	OFJNNIAAKHB BBKGAEAKAPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	NAHCINMEGBN DHFLMDEEGBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	BPKJJBCEELO LGNNDLOPPIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	new bool CCIBCOMLCFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void AOOPKGOMPDO(GMGJCKPIDOB LEOFNNIBMJD);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface LICNABCHEMA : IJHDFCLIPMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OJGICLADILJ JGCMIIMCCFC(Guid PHACDDBECOP);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CGFLGFPAOEK(Guid PHACDDBECOP);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CBJOAMFNGCB(Guid PHACDDBECOP, Task BNAOBCNJNFM);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GCLDPJCJPFI(Guid PHACDDBECOP, NDIOHACFFEO BHFLFBJPKAO);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(NDIOHACFFEO, Task)> GJCNPMCHJGN(Guid PHACDDBECOP);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface JCMOFLOOICK : IJHDFCLIPMB, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface ANAPOHGFCAE : IJHDFCLIPMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MBOEOILLNLG(AACGOKBLDOD PJFOMDHJLBF);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LDOGOMCJECI(AACGOKBLDOD PJFOMDHJLBF);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<MEHNDAGNNDB> MBCGHLPDDLC(CancellationToken ABHOMKHPBOD);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface PMJGCCPCNPB : IJHDFCLIPMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OJGICLADILJ GIPDJCMIGFI(AACGOKBLDOD CAEPDKFKBIO);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LLMKHBFJDEE(Guid PHACDDBECOP, Task BNAOBCNJNFM);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface DOJKJBCDKGH : IJHDFCLIPMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NDIOHACFFEO> EHNCJCOANIK(AACGOKBLDOD BAAPKBGGPBO);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface LOCGHKLNEFM : IJHDFCLIPMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MIPHOHMODEJ> PKPFCHFAOFD(NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, DILBKEMEFHP EOGDECBBPFB, CancellationToken ALKEMFHOMCA);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface DGFDFLCAHPC : IJHDFCLIPMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NDIOHACFFEO JNMOPIBCGPM(OEDKOGGDKCO FHPLHLDKNNL);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OMAPJKNPIKM(string EDMHAMLCOLN);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface OPOIJEOAEKC : IJHDFCLIPMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AACGOKBLDOD> OJILPLOJBOB(AACGOKBLDOD BPCGMGBPPCA, BOJCINHMKKJ HOBCAPOIMKF, CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<AACGOKBLDOD> PNMOGBPPFAB(CancellationToken ALKEMFHOMCA, BOJCINHMKKJ HOBCAPOIMKF);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FKDGKIDPJEM FMJGMMAFCHB(CHAHCGOKNDN ICGEDPEBNHL, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FKDGKIDPJEM APJENLONPKK(CHAHCGOKNDN ICGEDPEBNHL, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface LHADMAJEKNN : IJHDFCLIPMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NDIOHACFFEO KCFMPHLDFPB(OEDKOGGDKCO FHPLHLDKNNL, MEHNDAGNNDB IOIKOBEMEOA);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NDIOHACFFEO IDAOMBIPMNO(OEDKOGGDKCO LMPNFAPOFCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface LLJILFIJBKF
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NDEDICBBAOP(PHNONDGAJLA BMNEPEEPBPP);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CCFDPJIOBMO(PHNONDGAJLA BMNEPEEPBPP);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BEJMGDDAIPC(PHNONDGAJLA BMNEPEEPBPP);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FGDAHHNCHKD(PHNONDGAJLA BMNEPEEPBPP);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class PHNONDGAJLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly DILBKEMEFHP GDPLBEHAEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> APLHKGMPFCH;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public NGPFCPLNCNC<string> KMDGBLACHNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8B51E0", Offset = "0x8B39E0", VA = "0x1808B51E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8C0090", Offset = "0x8BE890", VA = "0x1808C0090")]
	public PHNONDGAJLA(DILBKEMEFHP FLLIHFEHJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7678B30", Offset = "0x7677330", VA = "0x187678B30")]
	public PHNONDGAJLA IHGEJANGKPA(string KCGKBDGKIOP, string INDENPJBLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7678AA0", Offset = "0x76772A0", VA = "0x187678AA0")]
	public bool IAELKHHAAAI([Out] IEnumerable<KeyValuePair<string, string>> LKLHPHKAGIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x67E2EF0", Offset = "0x67E16F0", VA = "0x1867E2EF0")]
	public PHNONDGAJLA NLHHCBPAFMP(NGPFCPLNCNC<string> IEGOAOCEEPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface NDJOKDICBGD
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool OONKGPODDIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	string ANFGGONLNMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool FIANLGKGNGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OHOEFCOJGKH();

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KDGBIOGMCOE NDNGNFIJONH(long GAFPBFDFBJD);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	APHDDHEBBGD<AMBENGOMJIK, IKLNHKOGGAD> OIHMKHFGKPA(long GAFPBFDFBJD);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	APHDDHEBBGD<AMBENGOMJIK, LAENOPFABFD> ILNBBPFEPPA(long GAFPBFDFBJD);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	APHDDHEBBGD<long, KNKCGNGKHLD> KJEFOLKCDJC();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KMKDPCFPNBL(long GAFPBFDFBJD, [Out] bool MPCPDCPMNMF);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> KGKIFGBDILH(byte[] MLNPIEGNENI, byte[] DIHDJINLOMA, CancellationToken ALKEMFHOMCA);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface IAGIDJJHKCJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool MPHCPNJBJHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool EFDDINGGCLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool CCIBCOMLCFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	GMGJCKPIDOB EPCKGPPNHPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action DBOICMOMJCF;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event HMEJOPJFGLF LKLGDCEDIBO;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event HMEJOPJFGLF AJLMJBHFALB;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event HMEJOPJFGLF CANKLBBPAKC;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<CCHDDALCCNH, bool> KCKIGBFOCPN;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void BJDLMOHNDBE();

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	KOBGPFNKBBG AOFMLEAOMAK();

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	FPHCJAJMDIK ACDMAJKPMAO();

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<NDIOHACFFEO> CIJEIBMEOAI(JLLNKPIMHOC AAMKNFCFLGD);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task HPFJOKMGDPG(CancellationToken ALKEMFHOMCA);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface DLHLIBLDHEL
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool OMMANEAJNNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	string GMOHFBNFPJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLHPKGMNCMG(Scene FFFNBJALLNG);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task HPENFPHFOGF(KGCMKEIEHGC KHFCGJLHCOD, CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task NMPBCBDEKBJ();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task GDDHPAMBFKB();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface PCCBFICHMFB
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	ODFFNGGOBDA PIDJECIHDLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool FCEHDMFGHMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool FBKHIDFHBFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool HKODJMGJGLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool BEMOFNPGMAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	int LACBDIEDFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool CNCEADFAAGA
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool NKIFBIDDNBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	int KEPAABCMGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	int FICALCPHJEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool GAHPCDLDIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool NCJFICLMCKI
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool EDPHAMEAHPK
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	float DFBLNJMCFGE
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> PNDLBKLKLOE;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CMONJLKOOCI LAEOAOAJCBB(CMONJLKOOCI MOELHMGOHPL);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KFFKAHGHLFM(CMONJLKOOCI MFHCHOKEAIG);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MHLFGGHFFNA();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task JOHELDOKOIK(NGPFCPLNCNC<string>.PPCAKDHDCLK LBPKIOFOLME, CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MCHEDMKDCEP(float KCBBFMGKHFJ);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NCDCMAEONCH(string NKMKHNNHPJD);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<KGHNBLFJMNI> BBLEOCDIHAA();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable DNIOMACOMFM(object IKGPEBFFMPK, KGHNBLFJMNI IEBPJDHALBM);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<JMOEKMFMFID> GPGDIGBBLDD();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IKLNHKOGGAD ODJBEGHFGNM(IEnumerable<MAAAODAGNHE> CFLNIEPCKCH);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FLLLLFAFGGB(int KIEPLEFDLFJ);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task HEHHEDHKGJP();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void GOACLKBJPHA();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool LEHCOAFFOLM();

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task EJPPLKIGAKH(CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task OJAHIBNECNN(CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<JIIOCLKPKAI> JPDFDKMBFEJ(DateTime DIKKFMDFBID, CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> EOOEHOPMPNE(CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void LIINIBGLFJE(string PJFOMDHJLBF = "", float IGEHIFGNOPE = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "25")]
	EFHFNGMAHHP CKLCAJCKAHA(PAMKGMCHOGJ CPFMGBGOHPH, HODMHPHBFHJ AIOPKBHNAIB, LAENOPFABFD KLGEGOBKBHE, IEnumerable<PersistenceView> IGKAPEHJNKN, MKBLKEPCJCO CBFGMIKMOGB);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void NMLGPNMEEEF(LAENOPFABFD KLGEGOBKBHE);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void CBOCCGEJGIN(MAAAODAGNHE EJLNBEBPJEL, [In] EFHFNGMAHHP GPMLGMGOAKC);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task DEIPECBBGIJ(LAENOPFABFD HKKBOJHKNDM, bool JOKGANHDIFJ, CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task DLKKNILIACF(CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void KBABFAOFIOK(long NKDNOGOOODN, long IFPDLCPBOCG, NIHPFEHJKNJ GKCMIIJJFKC, DJPINPOMHEF OICKKNEHDOJ, MLONKGHJMMO BNCKJFBLGEG, DBPAABODFCN? AIIKBOENKFJ, GKBBLKJMHOG? ALIDCGPACDF);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void FBBCLPFNJNG(long NKDNOGOOODN, long IFPDLCPBOCG, GKBBLKJMHOG? ALIDCGPACDF);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void GGANLBPLIPH(PersistenceView DFGANGDBGDE);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool KINIANDOPHE(PersistenceView AHOKJACJFBJ);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool OEFDPENGEOI(MAAAODAGNHE EJLNBEBPJEL, BIDADGNHDHM APHEHIIHAII, [Out] KADHOLFHAKF NDJGOFNBNDO);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task EBDGDAKMMCH(CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void BJFNBCAKOLB();

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable GLHPBHCOONK();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void KAPMBHFNBFE(LAENOPFABFD HKKBOJHKNDM, BIDADGNHDHM APHEHIIHAII);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<bool> FLCABCBNELN(LIMEHMPEEEM GPBNDJAMPKD, CancellationToken ALKEMFHOMCA, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void MINIEBNMALN(CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<CNCFEBILFNP> KNBECAMFALD(MKKKKIAHNEO BPCGMGBPPCA);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<NIHPFEHJKNJ> AJDBHFAMAMK(long NKDNOGOOODN, bool BLOANDEHGHJ, CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<DJPINPOMHEF> HIDPMIIHPPD(long NKDNOGOOODN, long IFPDLCPBOCG, long BFNDOACDLFM, CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<DJPINPOMHEF> IIHGCDNCLML(long NKDNOGOOODN, long IFPDLCPBOCG, CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<EAOIDDNCJKJ> GMGDGPGLKHK(string GOCMOGLILOK, CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<EAOIDDNCJKJ> GLEAPFFCECC(string GOCMOGLILOK, long NKDNOGOOODN, long IFPDLCPBOCG, string LMNFKMPPOHE, KANCPKCPDON.KKNDEMLNGCP NKIGLKBMOAI, KANCPKCPDON.KKNDEMLNGCP DIHDJINLOMA, int PFEIMHABCDO);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool ICNCAEAJOPI();

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "49")]
	bool FLMJKAGBLIL();

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool JEFEBOOKJJG(IEnumerable<KADHOLFHAKF> CEKMAJNFGDH);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void HKADILDJALH(List<GameObject> LMPGEFHPECI);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "52")]
	float MJIMHGNLKMH();

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "53")]
	Task<Scene> JKEMCAICLEO(string AINIGHKDABB, LoadSceneMode MEBMIHGNEHD, bool DLOFGKJHJCJ, NGPFCPLNCNC<string>.PPCAKDHDCLK IEGOAOCEEPG);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void JCGDFKLBOGF();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void CDHJKFNAPAM(bool KDHIKINJBAG);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void EGIGGDGKAPP();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void FOCEPCDIKDH();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void ILGKBEANINN(DILBKEMEFHP HPCHMFMFCMP);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Task IFNLMNMPKIJ(NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "69")]
	Task JNOLOLLMFJI(NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "70")]
	Task PDIIJPMJMIO(NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "71")]
	Task PNDOGBBDOJA(NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "72")]
	IDisposable EODNJLIPADD();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "73")]
	EHNLBALKAFN OKEONEBFLFN();

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task ABJAMIKOMAM(CancellationToken ALKEMFHOMCA);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface EHNLBALKAFN
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HGAAMKLGJKO(CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AGNJHAFAHHI(CancellationToken ALKEMFHOMCA);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct EFHFNGMAHHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> AFPFFJPCNFG;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum JIIOCLKPKAI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct PAMKGMCHOGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string EABCBGOOLCK;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface ODFFNGGOBDA
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	DILBKEMEFHP CIDJDODKCNH
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	NIHPFEHJKNJ GIBCGILCNJH
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	IPKCPHEECFE BJCEENEOHCD
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool ENJNALOHOPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool KMPKCPONNJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	int JLJJNDLBOAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action DEBADHGJKHJ;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> FDJBFHNAPPH;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ECIJEALOEKJ();

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.PPMIFLJDEIA> AOBKFJENCGO(long GAFPBFDFBJD, [Optional] CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<PBHNBHHCENJ> KKBDAKDDGGA();

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task EFBGBBKCLEI();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(DILBKEMEFHP, GMGJCKPIDOB) LGKBELJOHFI();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "15")]
	LNHHHAANBGA GNDJEMBFAJD();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JJFAPGIKNGF(long GAFPBFDFBJD);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KMICGBJEBFB(DILBKEMEFHP FLLIHFEHJJM, Matchmaking.JJEIJNLBEMF HANDIANDCDI, (int Major, int? Minor)? EBNOLCJBELN);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface IBOMOHAPHAO
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FIBKJLPNGHN([Out] IEnumerable<int> DCEJABMJHGM);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GMNIKIEMKOA(DEAMBOJPKEE DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MNFMLHPOGCM(DEAMBOJPKEE DJIMHLGHFGI);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface FOICANFGJJM
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string AFOGGBIJCDL(NDIOHACFFEO APFOMFNCNPL);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface GDEKBJLHOOD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPCKIBGHFEA(HJENGLCKNFN.IJENIKAMCJG HDMCLCIMACO);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EHCHNEMNFGB(HJENGLCKNFN.IJENIKAMCJG HDMCLCIMACO);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface EPDKCEBIKOC : GDEKBJLHOOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NDIOHACFFEO KBOIIAECLKM(OEDKOGGDKCO LMPNFAPOFCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface GKICLCGBOMN : GDEKBJLHOOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NDIOHACFFEO JNMOPIBCGPM(OEDKOGGDKCO FPHGJJIHFFP);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface KDGBIOGMCOE
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DNFCNMKAMCE<KGCMKEIEHGC, LHIOHJOJEEI>> IJECFJDDEAI(string LMNFKMPPOHE, long GAFPBFDFBJD, long? NKDNOGOOODN, long? IFPDLCPBOCG, DHIIJCJNKOE.IPCJAFIALIC PNAAKKBFDEP, CancellationToken ALKEMFHOMCA);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface APHDDHEBBGD<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DNFCNMKAMCE<CKCMDPBBFGE<TData>, LHIOHJOJEEI>> DEJFJNHMOKI(TGetDataArg HBIPIPALDEO, CancellationToken ALKEMFHOMCA);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class NOKOMJOLLGA : PJDNBPNFOAH, IAGIDJJHKCJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct LLJEONGPIDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder<NDIOHACFFEO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public NOKOMJOLLGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public JLLNKPIMHOC autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TaskAwaiter<NDIOHACFFEO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x76755B0", Offset = "0x7673DB0", VA = "0x1876755B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7675830", Offset = "0x7674030", VA = "0x187675830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct JPNCLABFJGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public NOKOMJOLLGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x766E6D0", Offset = "0x766CED0", VA = "0x18766E6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x766E900", Offset = "0x766D100", VA = "0x18766E900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class PILHEPHIJEJ : IEnumerable<IJHDFCLIPMB>, IEnumerable, IEnumerator<IJHDFCLIPMB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private IJHDFCLIPMB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public NOKOMJOLLGA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		private IJHDFCLIPMB System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xAC8700", Offset = "0xAC6F00", VA = "0x180AC8700")]
		[DebuggerHidden]
		public PILHEPHIJEJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7678C00", Offset = "0x7677400", VA = "0x187678C00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7679060", Offset = "0x7677860", VA = "0x187679060", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7678FB0", Offset = "0x76777B0", VA = "0x187678FB0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IJHDFCLIPMB> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7678FB0", Offset = "0x76777B0", VA = "0x187678FB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource MEKDINNAKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly CMONJLKOOCI MFHCHOKEAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool BCEDAPNKMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private HNFNOHEEDLK LPELEGBMIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private bool LBLNLLDHMDK;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public LIMEHMPEEEM HNJDHBNNOAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8B7500", Offset = "0x8B5D00", VA = "0x1808B7500", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8B7510", Offset = "0x8B5D10", VA = "0x1808B7510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public GJNLAGFAODO BEFMLKDPPHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8B7520", Offset = "0x8B5D20", VA = "0x1808B7520", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8B7570", Offset = "0x8B5D70", VA = "0x1808B7570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public PCCBFICHMFB KOJHMMMMDLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8B7560", Offset = "0x8B5D60", VA = "0x1808B7560", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8B7550", Offset = "0x8B5D50", VA = "0x1808B7550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public DLHLIBLDHEL CBPIDHGFGIN
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8B7530", Offset = "0x8B5D30", VA = "0x1808B7530", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8B74F0", Offset = "0x8B5CF0", VA = "0x1808B74F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public EPDKCEBIKOC GODGKOOOGIC
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8B7580", Offset = "0x8B5D80", VA = "0x1808B7580", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8B7540", Offset = "0x8B5D40", VA = "0x1808B7540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public GKICLCGBOMN GCIEKMGLNOD
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8BC110", Offset = "0x8BA910", VA = "0x1808BC110", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8BC160", Offset = "0x8BA960", VA = "0x1808BC160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public JDBACAEAFMP CIKJLNOFFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8BC100", Offset = "0x8BA900", VA = "0x1808BC100", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0C0", Offset = "0x8BA8C0", VA = "0x1808BC0C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public DFOGKGLJPAP IBNCLNDNFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0D0", Offset = "0x8BA8D0", VA = "0x1808BC0D0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8BBF90", Offset = "0x8BA790", VA = "0x1808BBF90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public PBEGAKKMGKP AHCLAFJKBCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x996E90", Offset = "0x995690", VA = "0x180996E90", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xE8A230", Offset = "0xE88A30", VA = "0x180E8A230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public JOCCAOEHDFO OJHMILIHCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8BC140", Offset = "0x8BA940", VA = "0x1808BC140", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8BC010", Offset = "0x8BA810", VA = "0x1808BC010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public AKPMLFACMOB FPNFFBBEAOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA7DF10", Offset = "0xA7C710", VA = "0x180A7DF10", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA7DEF0", Offset = "0xA7C6F0", VA = "0x180A7DEF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public EDKIGICJHAI GLMGKPJNJGI
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8C0C70", Offset = "0x8BF470", VA = "0x1808C0C70", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8C0C80", Offset = "0x8BF480", VA = "0x1808C0C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public MNOJCPELDFP AOAMFGOJHHO
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x98AAD0", Offset = "0x9892D0", VA = "0x18098AAD0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA90070", Offset = "0xA8E870", VA = "0x180A90070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public LICNABCHEMA IENDPJBDODE
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x96DD80", Offset = "0x96C580", VA = "0x18096DD80", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x96DD90", Offset = "0x96C590", VA = "0x18096DD90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public JCMOFLOOICK DNFHLFKHHKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9DB540", Offset = "0x9D9D40", VA = "0x1809DB540", Slot = "60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xD0BF00", Offset = "0xD0A700", VA = "0x180D0BF00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public ANAPOHGFCAE EJHKNBFLCFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9DB530", Offset = "0x9D9D30", VA = "0x1809DB530", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9851F0", Offset = "0x9839F0", VA = "0x1809851F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public PMJGCCPCNPB POMGELHAMJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9DB340", Offset = "0x9D9B40", VA = "0x1809DB340", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xADBAA0", Offset = "0xADA2A0", VA = "0x180ADBAA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public DOJKJBCDKGH EHNCJCOANIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8C0CA0", Offset = "0x8BF4A0", VA = "0x1808C0CA0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8C0CF0", Offset = "0x8BF4F0", VA = "0x1808C0CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public LOCGHKLNEFM ICKMJPMJLOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9DB4E0", Offset = "0x9D9CE0", VA = "0x1809DB4E0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xF68360", Offset = "0xF66B60", VA = "0x180F68360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public OPOIJEOAEKC PCKPALMGFGE
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9DB4D0", Offset = "0x9D9CD0", VA = "0x1809DB4D0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xD92420", Offset = "0xD90C20", VA = "0x180D92420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public DGFDFLCAHPC AHEENJEIHBD
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x984640", Offset = "0x982E40", VA = "0x180984640", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x984430", Offset = "0x982C30", VA = "0x180984430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public LHADMAJEKNN KCPPJFCNFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9DB3F0", Offset = "0x9D9BF0", VA = "0x1809DB3F0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xF68340", Offset = "0xF66B40", VA = "0x180F68340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public LLJILFIJBKF GELDPCJFLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x9016B0", Offset = "0x8FFEB0", VA = "0x1809016B0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA5E9C0", Offset = "0xA5D1C0", VA = "0x180A5E9C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public IBOMOHAPHAO DJBOAFEODHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x930D70", Offset = "0x92F570", VA = "0x180930D70", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xE1E020", Offset = "0xE1C820", VA = "0x180E1E020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public EELLJKLPNNH FNGJHIDJCJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x968B60", Offset = "0x967360", VA = "0x180968B60", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9687A0", Offset = "0x966FA0", VA = "0x1809687A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public DDLHHFMIEGG CANEKAOHJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x96AF80", Offset = "0x969780", VA = "0x18096AF80", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x969C50", Offset = "0x968450", VA = "0x180969C50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public NDJOKDICBGD PIPOCNHJHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x981E20", Offset = "0x980620", VA = "0x180981E20", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x97D190", Offset = "0x97B990", VA = "0x18097D190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public NBHKCAGANPC EHHEFJLNBBM
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x9DB460", Offset = "0x9D9C60", VA = "0x1809DB460", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public LNGFDFLNPDH NILMOABFMKA
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x9DB470", Offset = "0x9D9C70", VA = "0x1809DB470", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public OFJNNIAAKHB BBKGAEAKAPB
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x9DB480", Offset = "0x9D9C80", VA = "0x1809DB480", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public NAHCINMEGBN DHFLMDEEGBO
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x9DB490", Offset = "0x9D9C90", VA = "0x1809DB490", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public BPKJJBCEELO LGNNDLOPPIB
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x976780", Offset = "0x974F80", VA = "0x180976780", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public GMGJCKPIDOB EPCKGPPNHPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xED1B20", Offset = "0xED0320", VA = "0x180ED1B20", Slot = "58")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xF683E0", Offset = "0xF66BE0", VA = "0x180F683E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private bool HGPBLNDJNMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x76780C0", Offset = "0x76768C0", VA = "0x1876780C0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private bool HLOIOJLPAKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7678180", Offset = "0x7676980", VA = "0x187678180", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private bool JHCFEDDJFBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x119BA70", Offset = "0x119A270", VA = "0x18119BA70", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private CancellationToken OOEMHICJCCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x76778B0", Offset = "0x76760B0", VA = "0x1876778B0", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private CMONJLKOOCI DJCOFPPFDBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private bool MOGGLCDJCFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x119BA70", Offset = "0x119A270", VA = "0x18119BA70", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x119BEE0", Offset = "0x119A6E0", VA = "0x18119BEE0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action LGADFJPLOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7678060", Offset = "0x7676860", VA = "0x187678060", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x76782F0", Offset = "0x7676AF0", VA = "0x1876782F0", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event HMEJOPJFGLF ANHIGJMHLEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7677C90", Offset = "0x7676490", VA = "0x187677C90", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7677B20", Offset = "0x7676320", VA = "0x187677B20", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event HMEJOPJFGLF MHCOONMPGEK
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7678120", Offset = "0x7676920", VA = "0x187678120", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7678000", Offset = "0x7676800", VA = "0x187678000", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event HMEJOPJFGLF IEGIHHMBCMC
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7678350", Offset = "0x7676B50", VA = "0x187678350", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7677C30", Offset = "0x7676430", VA = "0x187677C30", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<CCHDDALCCNH, bool> OEFGFLDHFFI
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7677920", Offset = "0x7676120", VA = "0x187677920", Slot = "48")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7677850", Offset = "0x7676050", VA = "0x187677850", Slot = "49")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0xF683E0", Offset = "0xF66BE0", VA = "0x180F683E0", Slot = "39")]
	public void AOOPKGOMPDO(GMGJCKPIDOB LEOFNNIBMJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x76783B0", Offset = "0x7676BB0", VA = "0x1876783B0")]
	[UnityEngine.Scripting.Preserve]
	internal NOKOMJOLLGA([NDCFMLCHJCI(null)] CMONJLKOOCI MFHCHOKEAIG, [NDCFMLCHJCI(null)] LIMEHMPEEEM GPBNDJAMPKD, [NDCFMLCHJCI(null)] GJNLAGFAODO DOKPKADNHLB, [NDCFMLCHJCI(null)] PCCBFICHMFB BIJBPNIFOLE, [NDCFMLCHJCI(null)] DLHLIBLDHEL KMKDMLADOFB, [NDCFMLCHJCI(null)] EPDKCEBIKOC FGDCDFOKOBG, [NDCFMLCHJCI(null)] GKICLCGBOMN GIJEODMEHOJ, [NDCFMLCHJCI(null)] JDBACAEAFMP HCLBDKOEIDG, [NDCFMLCHJCI(null)] DFOGKGLJPAP IFDAEFBECOE, [NDCFMLCHJCI(null)] PBEGAKKMGKP ICGDNPPLDEO, [NDCFMLCHJCI(null)] JOCCAOEHDFO PJDPDJMKFNI, [NDCFMLCHJCI(null)] AKPMLFACMOB AMCAKHHBHAB, [NDCFMLCHJCI(null)] EDKIGICJHAI CPNJLLMGJNF, [NDCFMLCHJCI(null)] MNOJCPELDFP GNANILJGGLF, [NDCFMLCHJCI(null)] LICNABCHEMA DKHAIPGDBED, [NDCFMLCHJCI(null)] JCMOFLOOICK PJMIMCGCBHH, [NDCFMLCHJCI(null)] ANAPOHGFCAE ALPOILCKPCI, [NDCFMLCHJCI(null)] PMJGCCPCNPB BKMBGFKKHDI, [NDCFMLCHJCI(null)] DOJKJBCDKGH KFFGOPJMHPJ, [NDCFMLCHJCI(null)] LOCGHKLNEFM NJBIHAHFIDF, [NDCFMLCHJCI(null)] DGFDFLCAHPC PCBOFCHDKED, [NDCFMLCHJCI(null)] OPOIJEOAEKC LPENEHDDHDD, [NDCFMLCHJCI(null)] LHADMAJEKNN LOMPCCHLDML, [NDCFMLCHJCI(null)] LLJILFIJBKF GLCLLPFNMHA, [NDCFMLCHJCI(null)] IBOMOHAPHAO PJHBLDGIFLI, [NDCFMLCHJCI(null)] DDLHHFMIEGG MEGJMJCJPOE, [NDCFMLCHJCI(null)] NDJOKDICBGD OMFPPMBFAGE, [NDCFMLCHJCI(null)] NBHKCAGANPC GGDCJHNJHPL, [NDCFMLCHJCI(null)] LNGFDFLNPDH BIAPKAGKLFB, [NDCFMLCHJCI(null)] OFJNNIAAKHB GOCFKHDDAGO, [NDCFMLCHJCI(null)] NAHCINMEGBN ECGJACEPLLG, [NDCFMLCHJCI(null)] BPKJJBCEELO OIHKIMIDPCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7677B80", Offset = "0x7676380", VA = "0x187677B80")]
	private void EHFCOOMFLME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7677980", Offset = "0x7676180", VA = "0x187677980", Slot = "59")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x76778D0", Offset = "0x76760D0", VA = "0x1876778D0", Slot = "53")]
	private void CJODNGPGOGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7677CF0", Offset = "0x76764F0", VA = "0x187677CF0", Slot = "54")]
	private KOBGPFNKBBG EPJJJDPGKJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7677DE0", Offset = "0x76765E0", VA = "0x187677DE0", Slot = "55")]
	private FPHCJAJMDIK GNGKIIADMJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7677EF0", Offset = "0x76766F0", VA = "0x187677EF0", Slot = "56")]
	[AsyncStateMachine(typeof(LLJEONGPIDL))]
	private Task<NDIOHACFFEO> HEIMNNKHIIB(JLLNKPIMHOC FIBEEOLBGPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7678200", Offset = "0x7676A00", VA = "0x187678200", Slot = "57")]
	[AsyncStateMachine(typeof(JPNCLABFJGO))]
	private Task LNBDKPODGEM(CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x7677E70", Offset = "0x7676670", VA = "0x187677E70")]
	[IteratorStateMachine(typeof(PILHEPHIJEJ))]
	private IEnumerable<IJHDFCLIPMB> HCNLINOPDIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x7677D80", Offset = "0x7676580", VA = "0x187677D80")]
	[CompilerGenerated]
	private void FBNCFBANDDL(IJHDFCLIPMB FGOJHDGPHCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class GCFILBKHDNI : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x12EC8C0", Offset = "0x12EB0C0", VA = "0x1812EC8C0")]
	public GCFILBKHDNI(string PJFOMDHJLBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal class DNFDFAEEDHF : GFOFDAADLCH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct FFJGAFLEBFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public DNFDFAEEDHF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7669B80", Offset = "0x7668380", VA = "0x187669B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7669EC0", Offset = "0x76686C0", VA = "0x187669EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly PJDNBPNFOAH JCCNNNNOALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly PCCBFICHMFB BIJBPNIFOLE;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x8C5E90", Offset = "0x8C4690", VA = "0x1808C5E90")]
	public DNFDFAEEDHF(PJDNBPNFOAH JCCNNNNOALN, PCCBFICHMFB BIJBPNIFOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x76652F0", Offset = "0x7663AF0", VA = "0x1876652F0", Slot = "4")]
	[AsyncStateMachine(typeof(FFJGAFLEBFP))]
	public Task<bool> APGONMEGGJG(CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x76653E0", Offset = "0x7663BE0", VA = "0x1876653E0")]
	[CompilerGenerated]
	private object IBCPNHELJHL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal class DGHBAMLAOIH : GFOFDAADLCH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct HILAAGKFKJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public DGHBAMLAOIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private float <timeoutTime>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x766CBD0", Offset = "0x766B3D0", VA = "0x18766CBD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x766D310", Offset = "0x766BB10", VA = "0x18766D310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly PJDNBPNFOAH JCCNNNNOALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly PCCBFICHMFB BIJBPNIFOLE;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private ODFFNGGOBDA PIDJECIHDLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7664580", Offset = "0x7662D80", VA = "0x187664580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x8C5E90", Offset = "0x8C4690", VA = "0x1808C5E90")]
	public DGHBAMLAOIH(PJDNBPNFOAH JCCNNNNOALN, PCCBFICHMFB BIJBPNIFOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7664450", Offset = "0x7662C50", VA = "0x187664450", Slot = "4")]
	[AsyncStateMachine(typeof(HILAAGKFKJK))]
	public Task<bool> APGONMEGGJG(CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x76645D0", Offset = "0x7662DD0", VA = "0x1876645D0")]
	[CompilerGenerated]
	private object PHOMCMKMEAD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal class BGABAHHFAKN : GFOFDAADLCH
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class ADIPNMPFDEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public BGABAHHFAKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public PBHNBHHCENJ result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public DILBKEMEFHP newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public ADIPNMPFDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x7661B50", Offset = "0x7660350", VA = "0x187661B50")]
		internal object CGDCABMIEFI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7661CE0", Offset = "0x76604E0", VA = "0x187661CE0")]
		internal object OMNIOEFDPLF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7661C40", Offset = "0x7660440", VA = "0x187661C40")]
		internal object KEFAIACNEGL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct KLLKKDHCDDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public BGABAHHFAKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private ADIPNMPFDEI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter<PBHNBHHCENJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7674120", Offset = "0x7672920", VA = "0x187674120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7674AD0", Offset = "0x76732D0", VA = "0x187674AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly PJDNBPNFOAH JCCNNNNOALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly PCCBFICHMFB BIJBPNIFOLE;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private ODFFNGGOBDA PIDJECIHDLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7663200", Offset = "0x7661A00", VA = "0x187663200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x8C5E90", Offset = "0x8C4690", VA = "0x1808C5E90")]
	public BGABAHHFAKN(PJDNBPNFOAH JCCNNNNOALN, PCCBFICHMFB BIJBPNIFOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x76630E0", Offset = "0x76618E0", VA = "0x1876630E0", Slot = "4")]
	[AsyncStateMachine(typeof(KLLKKDHCDDJ))]
	public Task<bool> APGONMEGGJG(CancellationToken ALKEMFHOMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal interface GFOFDAADLCH
{
	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> APGONMEGGJG(CancellationToken ALKEMFHOMCA);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal struct MOBIPDHAKNH
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class GPCDEKDAIBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public PJDNBPNFOAH manager;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public GPCDEKDAIBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x766C480", Offset = "0x766AC80", VA = "0x18766C480")]
		internal Task BHONIAMKCFF(CancellationToken cancellationToken, int roomTotalVersion, NBGFMFDOHOO localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct MOJPLBLHIOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public MOBIPDHAKNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private JLLNKPIMHOC <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter<JIIOCLKPKAI> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private TaskAwaiter<NDIOHACFFEO> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7676D80", Offset = "0x7675580", VA = "0x187676D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7677310", Offset = "0x7675B10", VA = "0x187677310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct EAAPIGIDKHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public MOBIPDHAKNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x76654C0", Offset = "0x7663CC0", VA = "0x1876654C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x76657E0", Offset = "0x7663FE0", VA = "0x1876657E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly CancellationToken ALKEMFHOMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly PJDNBPNFOAH JIPBFCNFKIF;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private LIMEHMPEEEM HNJDHBNNOAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7676880", Offset = "0x7675080", VA = "0x187676880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private PCCBFICHMFB KOJHMMMMDLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7676B20", Offset = "0x7675320", VA = "0x187676B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private ODFFNGGOBDA PIDJECIHDLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x76769A0", Offset = "0x76751A0", VA = "0x1876769A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private PBEGAKKMGKP AHCLAFJKBCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7676A20", Offset = "0x7675220", VA = "0x187676A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x23218C0", Offset = "0x23200C0", VA = "0x1823218C0")]
	public MOBIPDHAKNH(CancellationToken ALKEMFHOMCA, PJDNBPNFOAH JIPBFCNFKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7676A70", Offset = "0x7675270", VA = "0x187676A70")]
	public static EIKIKIJKDHH NADAMCCLIDO(PJDNBPNFOAH JIPBFCNFKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x7676640", Offset = "0x7674E40", VA = "0x187676640")]
	[AsyncStateMachine(typeof(MOJPLBLHIOE))]
	public Task<bool> BDBMLJNBAHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x7676B70", Offset = "0x7675370", VA = "0x187676B70")]
	private bool OBKBDGEJCJI([Out] JLLNKPIMHOC FIBEEOLBGPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x76768D0", Offset = "0x76750D0", VA = "0x1876768D0")]
	[AsyncStateMachine(typeof(EAAPIGIDKHO))]
	private Task JHBCNIKPIMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7676750", Offset = "0x7674F50", VA = "0x187676750")]
	private Task<JIIOCLKPKAI> CAPHNCILGCA(JLLNKPIMHOC DFFEPAKAGDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal struct OJGICLADILJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly LICNABCHEMA DKHAIPGDBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly Guid PHACDDBECOP;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private Task<(NDIOHACFFEO, Task)> KHGLFFELCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x76789D0", Offset = "0x76771D0", VA = "0x1876789D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x46D5DC0", Offset = "0x46D45C0", VA = "0x1846D5DC0")]
	public OJGICLADILJ(LICNABCHEMA DKHAIPGDBED, Guid PHACDDBECOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7678980", Offset = "0x7677180", VA = "0x187678980")]
	public TaskAwaiter<(NDIOHACFFEO, Task)> FJJFOJEIFLM()
	{
		return default(TaskAwaiter<(NDIOHACFFEO, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x76788B0", Offset = "0x76770B0", VA = "0x1876788B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal struct EFEJNJAFEKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly TaskCompletionSource<(NDIOHACFFEO, Task)> COPJIKMAGLD;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public Task<(NDIOHACFFEO, Task)> KHGLFFELCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x76678A0", Offset = "0x76660A0", VA = "0x1876678A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7667930", Offset = "0x7666130", VA = "0x187667930")]
	public EFEJNJAFEKI(TimeSpan DEKMBJOBNGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7667800", Offset = "0x7666000", VA = "0x187667800")]
	public void JABCAEOLNFD(Task BNAOBCNJNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7667770", Offset = "0x7665F70", VA = "0x187667770")]
	public void DBPIBKGGDFB(NDIOHACFFEO APFOMFNCNPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x76678E0", Offset = "0x76660E0", VA = "0x1876678E0")]
	public void PMEOHKMFFNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x76676E0", Offset = "0x7665EE0", VA = "0x1876676E0")]
	internal void AOCHBGIJMHN(string PJFOMDHJLBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class EMOPDONMDOL
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class NBOJNPMBDPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public DJPINPOMHEF subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public NBOJNPMBDPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x7677820", Offset = "0x7676020", VA = "0x187677820")]
		internal bool HLBAMNLCPIE(IPKCPHEECFE s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7667F90", Offset = "0x7666790", VA = "0x187667F90")]
	public static MIPHOHMODEJ JHEOKMMJDLF(long EPMECPICIDJ, long IFPDLCPBOCG, string GOCMOGLILOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7667D40", Offset = "0x7666540", VA = "0x187667D40")]
	public static MIPHOHMODEJ JHEOKMMJDLF(long EPMECPICIDJ, long IFPDLCPBOCG, AMBENGOMJIK MLNPIEGNENI, long BFNDOACDLFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7667E00", Offset = "0x7666600", VA = "0x187667E00")]
	public static MIPHOHMODEJ JHEOKMMJDLF(CNCFEBILFNP COIDLIBLPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7668020", Offset = "0x7666820", VA = "0x187668020")]
	public static MIPHOHMODEJ JHEOKMMJDLF(NIHPFEHJKNJ NNEMEIMEIIP, DJPINPOMHEF INHEBDCGBMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7668250", Offset = "0x7666A50", VA = "0x187668250")]
	public static MIPHOHMODEJ KBDADKJGFPF(this MIPHOHMODEJ OANAMCHLGCB, NIHPFEHJKNJ AOJPCINNJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7667BB0", Offset = "0x76663B0", VA = "0x187667BB0")]
	public static MIPHOHMODEJ CAMCEEGHJFD(this MIPHOHMODEJ OANAMCHLGCB, DJPINPOMHEF DBGCBOFDIKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[RecRoom.NoEngine.Common.Preserve]
internal class GKJLGMJEMIH : DFOGKGLJPAP, IJHDFCLIPMB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct HBOILJAGAMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public GKJLGMJEMIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private DGPGECBENMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x766C4D0", Offset = "0x766ACD0", VA = "0x18766C4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x766CB70", Offset = "0x766B370", VA = "0x18766CB70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly DEAMBOJPKEE FNEMJPJJEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private string IIIKOECKEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Task KDJAHNMEBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private PJDNBPNFOAH JCCNNNNOALN;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool NBPODBKECOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x766C3C0", Offset = "0x766ABC0", VA = "0x18766C3C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Task IDAIGLKCOJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x766C0B0", Offset = "0x766A8B0", VA = "0x18766C0B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8BE300", Offset = "0x8BCB00", VA = "0x1808BE300", Slot = "7")]
	public void EHFCOOMFLME(PJDNBPNFOAH JCCNNNNOALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x766C140", Offset = "0x766A940", VA = "0x18766C140", Slot = "6")]
	public void JDEAMOHECIE(Task DIGFCMIOIEB, string AEKNFEBENPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x766C2A0", Offset = "0x766AAA0", VA = "0x18766C2A0")]
	[AsyncStateMachine(typeof(HBOILJAGAMN))]
	private Task NMKKJCPHGIB(Task EEGJIIFKOGO, string AEKNFEBENPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x766C3F0", Offset = "0x766ABF0", VA = "0x18766C3F0")]
	public GKJLGMJEMIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class MPJOBPPIKGL : EELLJKLPNNH, IJHDFCLIPMB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool MCOALLLBHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private OKNDNPAECMD HAKLDNOOHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private LIMEHMPEEEM GPBNDJAMPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private DDLHHFMIEGG MEGJMJCJPOE;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public OKNDNPAECMD EDNDONMKPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x7677600", Offset = "0x7675E00", VA = "0x187677600", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7677480", Offset = "0x7675C80", VA = "0x187677480", Slot = "7")]
	public void EHFCOOMFLME(PJDNBPNFOAH JCCNNNNOALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7677670", Offset = "0x7675E70", VA = "0x187677670", Slot = "5")]
	public void OOEAKHGPBOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7677380", Offset = "0x7675B80", VA = "0x187677380", Slot = "6")]
	public void OMGDICDPPJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x76773C0", Offset = "0x7675BC0", VA = "0x1876773C0")]
	private Task EEMCBIAMHBH(KJIGGFAPJGG FNGOEBINDAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x7677380", Offset = "0x7675B80", VA = "0x187677380", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public MPJOBPPIKGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal class HPLHNHCKELG : DDLHHFMIEGG
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private class BGDGENOJAAK<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly BLOHICJFBII ONJINLHNHKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly string KCGKBDGKIOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private readonly T DFEJJOPGBKP;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public T MHFLHGKPHDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x95C5D0", Offset = "0x95ADD0", VA = "0x18095C5D0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x95C5F0", Offset = "0x95ADF0", VA = "0x18095C5F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x53AFD40", Offset = "0x53AE540", VA = "0x1853AFD40")]
		public BGDGENOJAAK(BLOHICJFBII ONJINLHNHKC, string KCGKBDGKIOP, T DFEJJOPGBKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x53AF700", Offset = "0x53ADF00", VA = "0x1853AF700")]
		private void DIPIIAACCAO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly BLOHICJFBII ONJINLHNHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly BGDGENOJAAK<TimeSpan> LCINPLKHEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly BGDGENOJAAK<TimeSpan> DJIKANPFBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly BGDGENOJAAK<TimeSpan> GFMEFDDGGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly BGDGENOJAAK<TimeSpan> LICEPPHLEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly BGDGENOJAAK<bool> IHMHEJIPBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly BGDGENOJAAK<bool> AKJKHGNNIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly BGDGENOJAAK<bool> EHGBFFEBPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly BGDGENOJAAK<int> AJAAAKIJMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly BGDGENOJAAK<bool> JIHNCCNPELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly BGDGENOJAAK<bool> OLHHOLNEEDL;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public TimeSpan OMFHELBFEAE
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x766DAB0", Offset = "0x766C2B0", VA = "0x18766DAB0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public TimeSpan IGNKMAPADMD
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x766D8B0", Offset = "0x766C0B0", VA = "0x18766D8B0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public TimeSpan AOLENIFAPJA
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x766D9F0", Offset = "0x766C1F0", VA = "0x18766D9F0", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public TimeSpan AHPIGADBNAO
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x766D930", Offset = "0x766C130", VA = "0x18766D930", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool EIECLMHBFPM
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x766DA30", Offset = "0x766C230", VA = "0x18766DA30", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool EHPDOCIOAOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x766DAF0", Offset = "0x766C2F0", VA = "0x18766DAF0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool GIDFJIMOHIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x766D970", Offset = "0x766C170", VA = "0x18766D970", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public int MLBFLEGOJOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x766D9B0", Offset = "0x766C1B0", VA = "0x18766D9B0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool GFGANBKJGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x766D8F0", Offset = "0x766C0F0", VA = "0x18766D8F0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool EDAGDLJKONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x766DA70", Offset = "0x766C270", VA = "0x18766DA70", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x766DB30", Offset = "0x766C330", VA = "0x18766DB30")]
	[UnityEngine.Scripting.Preserve]
	public HPLHNHCKELG([NDCFMLCHJCI(null)] BLOHICJFBII ONJINLHNHKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[UnityEngine.Scripting.Preserve]
internal class BBKAGECDLAP : JOCCAOEHDFO, IJHDFCLIPMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class FMLBGMEIGOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public BIBPMJIGLBK roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public FMLBGMEIGOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x766A6F0", Offset = "0x7668EF0", VA = "0x18766A6F0")]
		internal object ONLOGKBJBOO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action DBOICMOMJCF
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7662DA0", Offset = "0x76615A0", VA = "0x187662DA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7663040", Offset = "0x7661840", VA = "0x187663040", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event HMEJOPJFGLF LKLGDCEDIBO
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x76629C0", Offset = "0x76611C0", VA = "0x1876629C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x76627B0", Offset = "0x7660FB0", VA = "0x1876627B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event HMEJOPJFGLF AJLMJBHFALB
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x7662D00", Offset = "0x7661500", VA = "0x187662D00", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x7662880", Offset = "0x7661080", VA = "0x187662880", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event HMEJOPJFGLF CANKLBBPAKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x7662920", Offset = "0x7661120", VA = "0x187662920", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7662C30", Offset = "0x7661430", VA = "0x187662C30", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<CCHDDALCCNH, bool> KCKIGBFOCPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x7662700", Offset = "0x7660F00", VA = "0x187662700", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x76625D0", Offset = "0x7660DD0", VA = "0x1876625D0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "19")]
	public void EHFCOOMFLME(PJDNBPNFOAH JCCNNNNOALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x7662E40", Offset = "0x7661640", VA = "0x187662E40", Slot = "14")]
	public void PGAEGHPCCCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x7662CD0", Offset = "0x76614D0", VA = "0x187662CD0", Slot = "15")]
	public void MMGFCAIDOME(BIBPMJIGLBK AKOGEPKEAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x7662850", Offset = "0x7661050", VA = "0x187662850", Slot = "16")]
	public void EPFODNIDNOL(BIBPMJIGLBK AKOGEPKEAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x76626D0", Offset = "0x7660ED0", VA = "0x1876626D0", Slot = "17")]
	public void DAIPEOPCFOI(BIBPMJIGLBK AKOGEPKEAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x7662680", Offset = "0x7660E80", VA = "0x187662680", Slot = "18")]
	public void DAHOPJIDLHD(CCHDDALCCNH CAKEPGIDGEO, bool ANJHFABIGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x7662A60", Offset = "0x7661260", VA = "0x187662A60")]
	private void JOEKNDNMBGL(HMEJOPJFGLF IEBPJDHALBM, BIBPMJIGLBK AKOGEPKEAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public BBKAGECDLAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[UnityEngine.Scripting.Preserve]
internal class EBNHONMBMIM : AKPMLFACMOB, IJHDFCLIPMB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct FPEIHGLJCHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public EBNHONMBMIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private DGPGECBENMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x766ADC0", Offset = "0x76695C0", VA = "0x18766ADC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x766B340", Offset = "0x7669B40", VA = "0x18766B340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct BGJDEBHGMKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public EBNHONMBMIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private DGPGECBENMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x7663250", Offset = "0x7661A50", VA = "0x187663250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x76638F0", Offset = "0x76620F0", VA = "0x1876638F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class KJHBBOIMPEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public KJHBBOIMPEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7674060", Offset = "0x7672860", VA = "0x187674060")]
		internal object ANCLMIPBHFA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct FFNPAJHMKMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public EBNHONMBMIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private KJHBBOIMPEP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private DGPGECBENMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7669F30", Offset = "0x7668730", VA = "0x187669F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x766A680", Offset = "0x7668E80", VA = "0x18766A680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class FOFPPELOIGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public FOFPPELOIGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x766AD50", Offset = "0x7669550", VA = "0x18766AD50")]
		internal object KOOIHNNHLOM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private PJDNBPNFOAH JCCNNNNOALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private PCCBFICHMFB BIJBPNIFOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private GFOFDAADLCH[] GKHKKNFNDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private CancellationTokenSource OENGEKBIAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private int IMMELDPFLEJ;

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x7665920", Offset = "0x7664120", VA = "0x187665920", Slot = "6")]
	public void EHFCOOMFLME(PJDNBPNFOAH JCCNNNNOALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x7665910", Offset = "0x7664110", VA = "0x187665910", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x76663E0", Offset = "0x7664BE0", VA = "0x1876663E0", Slot = "8")]
	public void PEICGLEFBEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x7665840", Offset = "0x7664040", VA = "0x187665840", Slot = "5")]
	public void BJDLMOHNDBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x76659A0", Offset = "0x76641A0", VA = "0x1876659A0", Slot = "4")]
	[AsyncStateMachine(typeof(FPEIHGLJCHP))]
	public Task IBOAKIKFEHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x7665CE0", Offset = "0x76644E0", VA = "0x187665CE0")]
	private void KBFOBHKLKML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x76660D0", Offset = "0x76648D0", VA = "0x1876660D0")]
	[AsyncStateMachine(typeof(BGJDEBHGMKF))]
	private Task NNMALGEGAKE(CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x7665A70", Offset = "0x7664270", VA = "0x187665A70")]
	[AsyncStateMachine(typeof(FFNPAJHMKMK))]
	private Task<bool> IHHBOCFGJPI(int ECDOOAABOPD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x7665FF0", Offset = "0x76647F0", VA = "0x187665FF0")]
	private void NCEELIMAEFL(int ECDOOAABOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x7666300", Offset = "0x7664B00", VA = "0x187666300")]
	private void PDPNDDFDEPI(int ECDOOAABOPD, bool ANJHFABIGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x76661D0", Offset = "0x76649D0", VA = "0x1876661D0")]
	private void OOEFBKOPFKD(int ECDOOAABOPD, Exception HNGGNNBFAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x7665BB0", Offset = "0x76643B0", VA = "0x187665BB0")]
	private void JAIPJEHODFK(CancellationToken ALKEMFHOMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public EBNHONMBMIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[RecRoom.NoEngine.Common.Preserve]
internal class KGAFLBDHFAH : EDKIGICJHAI, IJHDFCLIPMB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct FEEGGPCMKBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public DILBKEMEFHP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public KGAFLBDHFAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public GMGJCKPIDOB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private DGPGECBENMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x76691B0", Offset = "0x76679B0", VA = "0x1876691B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x7669B20", Offset = "0x7668320", VA = "0x187669B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct GCHLBOBLONN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public KGAFLBDHFAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public DILBKEMEFHP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public GMGJCKPIDOB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private NGPFCPLNCNC<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private DGPGECBENMI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private BOJCINHMKKJ <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private PHNONDGAJLA <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x766B3A0", Offset = "0x7669BA0", VA = "0x18766B3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x766C050", Offset = "0x766A850", VA = "0x18766C050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class MELEFEIBEHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public Matchmaking.JJEIJNLBEMF result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public PDFIMGDCOON errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public MELEFEIBEHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7675AC0", Offset = "0x76742C0", VA = "0x187675AC0")]
		internal object MGPMHFPAMAH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class JHNGDHMGECB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public Task<MIPHOHMODEJ> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public JHNGDHMGECB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
		internal Task<MIPHOHMODEJ> NNFHLJCPJGG(NGPFCPLNCNC<string>.PPCAKDHDCLK _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct PLAAEIPCOGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public KGAFLBDHFAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public DILBKEMEFHP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public GMGJCKPIDOB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public BOJCINHMKKJ joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private JHNGDHMGECB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private EGEKMEJJJIB <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private DGPGECBENMI <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private KFOEIFPHEMO <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private Task<Matchmaking.PPMIFLJDEIA> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private EMBIAPBBKKI <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private int <i>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private TaskAwaiter<Matchmaking.PPMIFLJDEIA> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private TaskAwaiter<MIPHOHMODEJ> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x76790B0", Offset = "0x76778B0", VA = "0x1876790B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x767EA40", Offset = "0x767D240", VA = "0x18767EA40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct MKNNJGGDIIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public KGAFLBDHFAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private DGPGECBENMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7675B70", Offset = "0x7674370", VA = "0x187675B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x76765E0", Offset = "0x7674DE0", VA = "0x1876765E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct PMIOBKCODKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public KGAFLBDHFAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private CMONJLKOOCI <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x767EAA0", Offset = "0x767D2A0", VA = "0x18767EAA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x767EF20", Offset = "0x767D720", VA = "0x18767EF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct FNGPOEFLJLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public AsyncTaskMethodBuilder<Matchmaking.PPMIFLJDEIA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public DILBKEMEFHP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public KGAFLBDHFAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private TaskAwaiter<Matchmaking.PPMIFLJDEIA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x766A7D0", Offset = "0x7668FD0", VA = "0x18766A7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x766ACE0", Offset = "0x76694E0", VA = "0x18766ACE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct DLJNBMANDCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Matchmaking.PPMIFLJDEIA serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public KGAFLBDHFAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public BOJCINHMKKJ joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private DGPGECBENMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private TaskAwaiter<APHMPCEFOBA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7664B90", Offset = "0x7663390", VA = "0x187664B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7665290", Offset = "0x7663A90", VA = "0x187665290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class IKEOPJBNDOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public DILBKEMEFHP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public IKEOPJBNDOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x766E4D0", Offset = "0x766CCD0", VA = "0x18766E4D0")]
		internal object FNMFCDJKNNK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x766E5D0", Offset = "0x766CDD0", VA = "0x18766E5D0")]
		internal string GCEMMAKCGNK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct ENBCLBGPBNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public DILBKEMEFHP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public KGAFLBDHFAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private IKEOPJBNDOO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private DGPGECBENMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7668340", Offset = "0x7666B40", VA = "0x187668340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7668F20", Offset = "0x7667720", VA = "0x187668F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct ABOIIIGIMPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public KGAFLBDHFAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public BOJCINHMKKJ joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public MIPHOHMODEJ initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public DILBKEMEFHP targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public EGEKMEJJJIB progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x76611D0", Offset = "0x765F9D0", VA = "0x1876611D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7661AF0", Offset = "0x76602F0", VA = "0x187661AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct KAMLFKONMAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public KGAFLBDHFAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private DGPGECBENMI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private DGPGECBENMI <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private CancellationTokenSource <timeoutTcs>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private CancellationToken <timeoutToken>5__8;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x766E960", Offset = "0x766D160", VA = "0x18766E960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x7670140", Offset = "0x766E940", VA = "0x187670140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct COGLBMEEOEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public NBGFMFDOHOO localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public KGAFLBDHFAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private DGPGECBENMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private TaskAwaiter<NDIOHACFFEO> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x76639C0", Offset = "0x76621C0", VA = "0x1876639C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x7664130", Offset = "0x7662930", VA = "0x187664130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class KBBFCHEPGLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public DILBKEMEFHP targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public KBBFCHEPGLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x7690630", Offset = "0x768EE30", VA = "0x187690630")]
		internal object NBDFMBGINMF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class EPDNNENNFAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public EPDNNENNFAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x7689100", Offset = "0x7687900", VA = "0x187689100")]
		internal void PBIJIAAPLGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class KPILBEPFAAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public DILBKEMEFHP targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public KPILBEPFAAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x7691330", Offset = "0x768FB30", VA = "0x187691330")]
		internal object ILOLOEEGAEM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class GEOKKIEPAMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public DILBKEMEFHP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public GEOKKIEPAMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x768A4A0", Offset = "0x7688CA0", VA = "0x18768A4A0")]
		internal string LPAJNEABIPM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly FICDJCDJOAA MKGKLNKADOK;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly FICDJCDJOAA KADMEHLHBMD;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly FICDJCDJOAA EEGLCKBBABO;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly string KODAMCALCNB;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly string AFPKFPFKOMN;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static readonly string KEHEOEHPBOB;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly Guid PHBHFJBDOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private JDBACAEAFMP HCLBDKOEIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private GJNLAGFAODO DOKPKADNHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private LIMEHMPEEEM GPBNDJAMPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private PJDNBPNFOAH JCCNNNNOALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private PCCBFICHMFB BIJBPNIFOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private AKPMLFACMOB AMCAKHHBHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private DFOGKGLJPAP IFDAEFBECOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private JOCCAOEHDFO PJDPDJMKFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private OFJNNIAAKHB GOCFKHDDAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private LNGFDFLNPDH BIAPKAGKLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private IDisposable PHJIEBMHAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private BPKJJBCEELO OIHKIMIDPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly DEAMBOJPKEE FLPBLFIKKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private EMBIAPBBKKI NKKAAFEOPOL;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public TaskStatus BNBFMGMNAEE
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x8DDBF0", Offset = "0x8DC3F0", VA = "0x1808DDBF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xE7F640", Offset = "0xE7DE40", VA = "0x180E7F640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private ODFFNGGOBDA PIDJECIHDLH
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x76733F0", Offset = "0x7671BF0", VA = "0x1876733F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7671C90", Offset = "0x7670490", VA = "0x187671C90", Slot = "6")]
	public void EHFCOOMFLME(PJDNBPNFOAH JCCNNNNOALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x7671A90", Offset = "0x7670290", VA = "0x187671A90", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x7671950", Offset = "0x7670150", VA = "0x187671950", Slot = "5")]
	[AsyncStateMachine(typeof(FEEGGPCMKBC))]
	public Task DOANGELBCAL(DILBKEMEFHP EOGDECBBPFB, GMGJCKPIDOB COFODFGPBCD, CancellationToken LCOCKEOACEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7673C60", Offset = "0x7672460", VA = "0x187673C60")]
	[AsyncStateMachine(typeof(GCHLBOBLONN))]
	private Task PGEHCDGNKCB(DILBKEMEFHP EOGDECBBPFB, GMGJCKPIDOB COFODFGPBCD, CancellationToken LCOCKEOACEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7672270", Offset = "0x7670A70", VA = "0x187672270")]
	private void FGFHIOKKEBM(OFJNNIAAKHB GOCFKHDDAGO, DILBKEMEFHP EOGDECBBPFB, Exception HNGGNNBFAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x76708B0", Offset = "0x766F0B0", VA = "0x1876708B0")]
	private static void BOAENBBIIJD(PHNONDGAJLA LOCBEHIIJEE, Exception HNGGNNBFAEK, [Optional] List<int> AEKAKDFHCJD, int IMMELDPFLEJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7673990", Offset = "0x7672190", VA = "0x187673990")]
	[AsyncStateMachine(typeof(PLAAEIPCOGM))]
	private Task OFLKMIONGCO(NGPFCPLNCNC<string>.PPCAKDHDCLK IEGOAOCEEPG, DILBKEMEFHP EOGDECBBPFB, GMGJCKPIDOB COFODFGPBCD, BOJCINHMKKJ BFEIBADJAKF, CancellationToken LCOCKEOACEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7672120", Offset = "0x7670920", VA = "0x187672120")]
	private void FBDKMCDLOCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7673720", Offset = "0x7671F20", VA = "0x187673720")]
	[AsyncStateMachine(typeof(MKNNJGGDIIO))]
	private Task MNIIMPEGNPB(NGPFCPLNCNC<string>.PPCAKDHDCLK IEGOAOCEEPG, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7672B30", Offset = "0x7671330", VA = "0x187672B30")]
	private void JLCIKHAICHO(DILBKEMEFHP EOGDECBBPFB, CancellationToken LCOCKEOACEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x76731A0", Offset = "0x76719A0", VA = "0x1876731A0")]
	private void KGBLPBKEBOB(DILBKEMEFHP EOGDECBBPFB, BOJCINHMKKJ BFEIBADJAKF, OperationCanceledException HNPKPGOPGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x7671600", Offset = "0x766FE00", VA = "0x187671600")]
	private void DLNHNIFNBPJ(DILBKEMEFHP EOGDECBBPFB, BOJCINHMKKJ BFEIBADJAKF, Exception HNGGNNBFAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x7672890", Offset = "0x7671090", VA = "0x187672890")]
	private void IBFDNCNDDGF(DILBKEMEFHP EOGDECBBPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x7671230", Offset = "0x766FA30", VA = "0x187671230")]
	private static BIBPMJIGLBK DBEFBIHFDCL(DILBKEMEFHP EOGDECBBPFB)
	{
		return default(BIBPMJIGLBK);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x7671100", Offset = "0x766F900", VA = "0x187671100")]
	[AsyncStateMachine(typeof(PMIOBKCODKA))]
	private Task BPPFOEMFJJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x7670750", Offset = "0x766EF50", VA = "0x187670750")]
	[AsyncStateMachine(typeof(FNGPOEFLJLL))]
	private Task<Matchmaking.PPMIFLJDEIA> AOBKFJENCGO(DILBKEMEFHP EOGDECBBPFB, NGPFCPLNCNC<string>.PPCAKDHDCLK IEGOAOCEEPG, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x7673610", Offset = "0x7671E10", VA = "0x187673610")]
	private static APHMPCEFOBA KOFCNKHHINA(Matchmaking.PPMIFLJDEIA KCBHACCEBEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x7670600", Offset = "0x766EE00", VA = "0x187670600")]
	[AsyncStateMachine(typeof(DLJNBMANDCG))]
	private Task AIOGKGGGALC(Matchmaking.PPMIFLJDEIA KCBHACCEBEL, BOJCINHMKKJ BFEIBADJAKF, NGPFCPLNCNC<string>.PPCAKDHDCLK IEGOAOCEEPG, CancellationToken MHGBHDLPJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x7673850", Offset = "0x7672050", VA = "0x187673850")]
	[AsyncStateMachine(typeof(ENBCLBGPBNP))]
	private Task ODINLHIEONA(DILBKEMEFHP EOGDECBBPFB, CancellationTokenSource KJBFIFILMCG, Task LHIMDPFEFNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x7671FB0", Offset = "0x76707B0", VA = "0x187671FB0")]
	[AsyncStateMachine(typeof(ABOIIIGIMPD))]
	private Task ELFBNENEMKE(MIPHOHMODEJ NIILFELPJIP, EGEKMEJJJIB FFGHGNPMJLM, DILBKEMEFHP MCBJIDIGFBN, BOJCINHMKKJ HMNFFAIFIDH, NGPFCPLNCNC<string>.PPCAKDHDCLK IEGOAOCEEPG, CancellationToken FHCEDJHDMID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x7671410", Offset = "0x766FC10", VA = "0x187671410")]
	private BOJCINHMKKJ DFEFAKBFMLH(BOJCINHMKKJ HMNFFAIFIDH, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x76734D0", Offset = "0x7671CD0", VA = "0x1876734D0")]
	[AsyncStateMachine(typeof(KAMLFKONMAK))]
	private Task KJOEEBOJGNO(NGPFCPLNCNC<string>.PPCAKDHDCLK IEGOAOCEEPG, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7672760", Offset = "0x7670F60", VA = "0x187672760")]
	[AsyncStateMachine(typeof(COGLBMEEOEG))]
	private Task HOHCDDKEHAM(CancellationToken ALKEMFHOMCA, int FNNMEEPNLFL, NBGFMFDOHOO KAMIPNGFFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x7671290", Offset = "0x766FA90", VA = "0x187671290")]
	private static void DEKJEIDJADK(DILBKEMEFHP EOGDECBBPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7672F50", Offset = "0x7671750", VA = "0x187672F50")]
	private void KELOAOGLJEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x7673440", Offset = "0x7671C40", VA = "0x187673440")]
	private void KJNGPEOBAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x7672AA0", Offset = "0x76712A0", VA = "0x187672AA0")]
	private void IMGLCMNJLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x76726D0", Offset = "0x7670ED0", VA = "0x1876726D0")]
	private void GCOHFPFLIOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x7672E60", Offset = "0x7671660", VA = "0x187672E60")]
	private static void JOLCGFEIJJN(DILBKEMEFHP EOGDECBBPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x7673AF0", Offset = "0x76722F0", VA = "0x187673AF0")]
	private static CancellationTokenRegistration OJBDNNOPCFD(DILBKEMEFHP EOGDECBBPFB, CancellationToken MHGBHDLPJFF)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x7671850", Offset = "0x7670050", VA = "0x187671850")]
	private static void DMBJHFEHDAC(DILBKEMEFHP EOGDECBBPFB, Exception HNGGNNBFAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x7671AE0", Offset = "0x76702E0", VA = "0x187671AE0")]
	private void EEFEJBCELGD(DILBKEMEFHP EOGDECBBPFB, Task LHIMDPFEFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x76711D0", Offset = "0x766F9D0", VA = "0x1876711D0")]
	private static void CLLGOIEIHDM(Func<string> HPJAAPABCEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x7673FD0", Offset = "0x76727D0", VA = "0x187673FD0")]
	public KGAFLBDHFAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x7673C00", Offset = "0x7672400", VA = "0x187673C00")]
	[CompilerGenerated]
	internal static (int, int?) PDGMPMEJOBM(PDFIMGDCOON EBNOLCJBELN)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[RecRoom.NoEngine.Common.Preserve]
internal class EEIOIPLKEMD : MNOJCPELDFP, IJHDFCLIPMB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct NBPGKPGNPBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public EEIOIPLKEMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public NBGFMFDOHOO localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7694890", Offset = "0x7693090", VA = "0x187694890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7694D00", Offset = "0x7693500", VA = "0x187694D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class DGIMNMLEFJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public EEIOIPLKEMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public NBGFMFDOHOO localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public DGIMNMLEFJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7686B90", Offset = "0x7685390", VA = "0x187686B90")]
		internal List<Task> GKBNGILMAPI(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct JONHNDGALIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public EIKIKIJKDHH taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public NBGFMFDOHOO localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private DGPGECBENMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x768F640", Offset = "0x768DE40", VA = "0x18768F640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x768F9E0", Offset = "0x768E1E0", VA = "0x18768F9E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private struct GMONFPOCJFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public EEIOIPLKEMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x768AEC0", Offset = "0x76896C0", VA = "0x18768AEC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x768B1A0", Offset = "0x76899A0", VA = "0x18768B1A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private readonly HashSet<EIKIKIJKDHH> GDCPEEFAEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private GJNLAGFAODO DOKPKADNHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private PJDNBPNFOAH JCCNNNNOALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private KGHNBLFJMNI FBIFFKDJFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private GAANCLJPEJK OPFBDBCCPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private IDisposable PHJIEBMHAOD;

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x7686EA0", Offset = "0x76856A0", VA = "0x187686EA0", Slot = "5")]
	public void EHFCOOMFLME(PJDNBPNFOAH JCCNNNNOALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x7686E20", Offset = "0x7685620", VA = "0x187686E20", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x7686DC0", Offset = "0x76855C0", VA = "0x187686DC0", Slot = "4")]
	public bool DMIECGLIHDG(EIKIKIJKDHH PEBMJKNPMNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x7687270", Offset = "0x7685A70", VA = "0x187687270")]
	private void ICLDIHEPJLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7687810", Offset = "0x7686010", VA = "0x187687810")]
	private void MMFONOGEALJ(DLBOGIKOAJL NKIGLKBMOAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x7686CD0", Offset = "0x76854D0", VA = "0x187686CD0")]
	[AsyncStateMachine(typeof(NBPGKPGNPBI))]
	private Task BNPMJHFGGMG(int FNNMEEPNLFL, NBGFMFDOHOO KAMIPNGFFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x7687A30", Offset = "0x7686230", VA = "0x187687A30")]
	private Func<CancellationToken, List<Task>> NNCFOABAHGK(int FNNMEEPNLFL, NBGFMFDOHOO KAMIPNGFFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x7687340", Offset = "0x7685B40", VA = "0x187687340")]
	private List<Task> MCHPLLJMOMN(int FNNMEEPNLFL, NBGFMFDOHOO KAMIPNGFFGD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x7687BB0", Offset = "0x76863B0", VA = "0x187687BB0")]
	[AsyncStateMachine(typeof(JONHNDGALIN))]
	private Task PNBEOHPLJFI(EIKIKIJKDHH KHJDBHICGKH, CancellationToken DJIMHLGHFGI, int FNNMEEPNLFL, NBGFMFDOHOO KAMIPNGFFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x76871A0", Offset = "0x76859A0", VA = "0x1876871A0")]
	[AsyncStateMachine(typeof(GMONFPOCJFH))]
	private Task FCPFJKNNEKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7687B00", Offset = "0x7686300", VA = "0x187687B00")]
	private void PEICGLEFBEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7687CD0", Offset = "0x76864D0", VA = "0x187687CD0")]
	public EEIOIPLKEMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[UnityEngine.Scripting.Preserve]
internal sealed class BIOBJFMCONJ : LICNABCHEMA, IJHDFCLIPMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class LGDNFDJGCGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public LGDNFDJGCGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7691980", Offset = "0x7690180", VA = "0x187691980")]
		internal object MHCDAFKFNFE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class JBNLCDDFMCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public JBNLCDDFMCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x768DF00", Offset = "0x768C700", VA = "0x18768DF00")]
		internal object EJKMJINHKOA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class KEGHHAAOIKA
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public KEGHHAAOIKA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class NDMIICDGJCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public NDMIICDGJCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x7694D60", Offset = "0x7693560", VA = "0x187694D60")]
		internal object BEDHNIBFBDI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class BNAENFBFPBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public BNAENFBFPBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7685E30", Offset = "0x7684630", VA = "0x187685E30")]
		internal object MIAGIHEFANG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private readonly Dictionary<Guid, EFEJNJAFEKI> DKHAIPGDBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private readonly TimeSpan COBOKNEMCCN;

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "9")]
	public void EHFCOOMFLME(PJDNBPNFOAH JCCNNNNOALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7684A60", Offset = "0x7683260", VA = "0x187684A60", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7684CC0", Offset = "0x76834C0", VA = "0x187684CC0", Slot = "4")]
	public OJGICLADILJ JGCMIIMCCFC(Guid PHACDDBECOP)
	{
		return default(OJGICLADILJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7684850", Offset = "0x7683050", VA = "0x187684850", Slot = "5")]
	public bool CGFLGFPAOEK(Guid PHACDDBECOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7684520", Offset = "0x7682D20", VA = "0x187684520", Slot = "6")]
	public bool CBJOAMFNGCB(Guid PHACDDBECOP, Task BNAOBCNJNFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7684A70", Offset = "0x7683270", VA = "0x187684A70", Slot = "7")]
	public bool GCLDPJCJPFI(Guid PHACDDBECOP, NDIOHACFFEO APFOMFNCNPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7684C50", Offset = "0x7683450", VA = "0x187684C50", Slot = "8")]
	public Task<(NDIOHACFFEO, Task)> GJCNPMCHJGN(Guid PHACDDBECOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7684EE0", Offset = "0x76836E0", VA = "0x187684EE0")]
	private void OLIJCCIKOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x7685110", Offset = "0x7683910", VA = "0x187685110")]
	public BIOBJFMCONJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[RecRoom.NoEngine.Common.Preserve]
internal class OEEIOCBJHFA : JCMOFLOOICK, IJHDFCLIPMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private class PPMCLDEBADA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private readonly DILBKEMEFHP HPCHMFMFCMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private readonly CancellationTokenSource OENGEKBIAJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public readonly CancellationToken NKIMAJGLIDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private bool POJLOGOIJBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private bool LOEKDIGJGDI;

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x769E510", Offset = "0x769CD10", VA = "0x18769E510")]
		public PPMCLDEBADA(DILBKEMEFHP HPCHMFMFCMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x769E3C0", Offset = "0x769CBC0", VA = "0x18769E3C0")]
		public void PEICGLEFBEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x769E390", Offset = "0x769CB90", VA = "0x18769E390", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class GALIJHIJGJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public KJIGGFAPJGG disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public GALIJHIJGJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x76897D0", Offset = "0x7687FD0", VA = "0x1876897D0")]
		internal object ADFKMLNKMED()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct EFPMIFNIJFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public KJIGGFAPJGG disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public OEEIOCBJHFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private DGPGECBENMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x7687D60", Offset = "0x7686560", VA = "0x187687D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x7688160", Offset = "0x7686960", VA = "0x187688160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class LMDDKEIANML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public LMDDKEIANML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7692380", Offset = "0x7690B80", VA = "0x187692380")]
		internal object MNOGBAJMEPC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct IIKHIILCCGH : IAsyncStateMachine
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
		public OEEIOCBJHFA <>4__this;

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
		private DGPGECBENMI <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x768CD10", Offset = "0x768B510", VA = "0x18768CD10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x908140", Offset = "0x906940", VA = "0x180908140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class EPCJDKFBFBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public DILBKEMEFHP newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public EPCJDKFBFBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x7689020", Offset = "0x7687820", VA = "0x187689020")]
		internal object IBFPDNDPPBF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7688FE0", Offset = "0x76877E0", VA = "0x187688FE0")]
		internal object BAHGFBMEJIJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x76890C0", Offset = "0x76878C0", VA = "0x1876890C0")]
		internal object LLNEDGGAKOP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class DKOHOBLMGKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public DKOHOBLMGKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7686BD0", Offset = "0x76853D0", VA = "0x187686BD0")]
		internal void MGOMMCLOOAH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct NBHKPJFEEOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public DILBKEMEFHP newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public OEEIOCBJHFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public GMGJCKPIDOB customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private EPCJDKFBFBM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private DGPGECBENMI <>7__wrap1;

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

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x76938A0", Offset = "0x76920A0", VA = "0x1876938A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7694830", Offset = "0x7693030", VA = "0x187694830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly IBKBGLFBDJJ.BFJDJKJCBFL AKIJGEPKBCM;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly OCPAIIEJKGM BDMLEFKMGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private GJNLAGFAODO DOKPKADNHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private PJDNBPNFOAH JCCNNNNOALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private AKPMLFACMOB AMCAKHHBHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private PCCBFICHMFB BIJBPNIFOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private DDLHHFMIEGG MEGJMJCJPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private EDKIGICJHAI CPNJLLMGJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private DILBKEMEFHP IJBHCHCGDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private PPMCLDEBADA AFIONPKKPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private bool JICLGIKCJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private Task CFDLMMNHOMK;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private ODFFNGGOBDA PIDJECIHDLH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x76984C0", Offset = "0x7696CC0", VA = "0x1876984C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public bool LNHBDGNAEFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xAE86A0", Offset = "0xAE6EA0", VA = "0x180AE86A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7697CD0", Offset = "0x76964D0", VA = "0x187697CD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x7697E50", Offset = "0x7696650", VA = "0x187697E50", Slot = "4")]
	public void EHFCOOMFLME(PJDNBPNFOAH JCCNNNNOALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x7697CE0", Offset = "0x76964E0", VA = "0x187697CE0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x76981C0", Offset = "0x76969C0", VA = "0x1876981C0")]
	[AsyncStateMachine(typeof(EFPMIFNIJFE))]
	private Task GACOCDHMNGG(KJIGGFAPJGG IPCFMADOLHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7697B40", Offset = "0x7696340", VA = "0x187697B40")]
	private void DEBADHGJKHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7698330", Offset = "0x7696B30", VA = "0x187698330")]
	private void HGADNGOBMBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7697720", Offset = "0x7695F20", VA = "0x187697720")]
	private void CDGIFHIODJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x76982B0", Offset = "0x7696AB0", VA = "0x1876982B0")]
	private bool GPBCPHEOLLI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x76980F0", Offset = "0x76968F0", VA = "0x1876980F0")]
	[AsyncStateMachine(typeof(IIKHIILCCGH))]
	private void FDJBFHNAPPH(int NEHJMKFJILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x76978A0", Offset = "0x76960A0", VA = "0x1876978A0")]
	private void CPIDOHBNMEK([Out] IDisposable ALPAJHGEEAE, [Out] IDisposable HKBNGKMNCJN, [Out] IDisposable ILHEKKPKIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x7697600", Offset = "0x7695E00", VA = "0x187697600")]
	private bool CDAFDJMHEHJ(DILBKEMEFHP HPCHMFMFCMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x7698510", Offset = "0x7696D10", VA = "0x187698510")]
	private void OPPEKJBALOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x7698560", Offset = "0x7696D60", VA = "0x187698560")]
	[AsyncStateMachine(typeof(NBHKPJFEEOE))]
	private Task PGEHCDGNKCB(DILBKEMEFHP HPCHMFMFCMP, GMGJCKPIDOB COFODFGPBCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x7698A50", Offset = "0x7697250", VA = "0x187698A50")]
	public OEEIOCBJHFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[UnityEngine.Scripting.Preserve]
internal sealed class AONMAMLJEDK : ANAPOHGFCAE, IJHDFCLIPMB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private struct OEOEELBMPFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public AsyncTaskMethodBuilder<MEHNDAGNNDB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public AONMAMLJEDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private TaskAwaiter<MEHNDAGNNDB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7698AC0", Offset = "0x76972C0", VA = "0x187698AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x7698D50", Offset = "0x7697550", VA = "0x187698D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class OCMKKJOEDMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public AACGOKBLDOD message;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public OCMKKJOEDMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x7696E90", Offset = "0x7695690", VA = "0x187696E90")]
		internal object HJDCNHJPMOK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class GBAONAFBFOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public AACGOKBLDOD messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public GBAONAFBFOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x7689860", Offset = "0x7688060", VA = "0x187689860")]
		internal object MOMOKOIDDDK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class LMBNFFFNHHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public AACGOKBLDOD request;

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public LMBNFFFNHHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x7692320", Offset = "0x7690B20", VA = "0x187692320")]
		internal object KAANGKGOGMH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct HIFEKAHIALA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public AACGOKBLDOD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public AONMAMLJEDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private DGPGECBENMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private TaskAwaiter<CHAHCGOKNDN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x768B7B0", Offset = "0x7689FB0", VA = "0x18768B7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x768C080", Offset = "0x768A880", VA = "0x18768C080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class GKKGNBLABGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public AACGOKBLDOD operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public GKKGNBLABGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x768AE60", Offset = "0x7689660", VA = "0x18768AE60")]
		internal object GNEDFBKMLIN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct APLCMMKAHLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public AACGOKBLDOD operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public AONMAMLJEDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private DGPGECBENMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private BOJCINHMKKJ <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private TaskAwaiter<AACGOKBLDOD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x7681150", Offset = "0x767F950", VA = "0x187681150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x7681CC0", Offset = "0x76804C0", VA = "0x187681CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private struct GEAPEMOCDBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public AsyncTaskMethodBuilder<CHAHCGOKNDN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public AONMAMLJEDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public AACGOKBLDOD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private GOEHDJEOGOK.NGGJFDPHAMK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private BOJCINHMKKJ <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private TaskAwaiter<AACGOKBLDOD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x7689F00", Offset = "0x7688700", VA = "0x187689F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x768A430", Offset = "0x7688C30", VA = "0x18768A430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class IFJLCEFEEMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public CHAHCGOKNDN operation;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public IFJLCEFEEMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x768CC90", Offset = "0x768B490", VA = "0x18768CC90")]
		internal object CDOPCMDEIFA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private struct CGPPBLPMMAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public CHAHCGOKNDN operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public AONMAMLJEDK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private DGPGECBENMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private NGPFCPLNCNC<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x7686500", Offset = "0x7684D00", VA = "0x187686500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x7686B30", Offset = "0x7685330", VA = "0x187686B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class FICEEDKEHOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public AACGOKBLDOD request;

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public FICEEDKEHOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x7689400", Offset = "0x7687C00", VA = "0x187689400")]
		internal object AFGFLDDJDPH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private sealed class EBIEJFALOEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public AACGOKBLDOD request;

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public EBIEJFALOEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x7686C70", Offset = "0x7685470", VA = "0x187686C70")]
		internal object HLEJPHLHJID()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private PJDNBPNFOAH JCCNNNNOALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private DFOGKGLJPAP IFDAEFBECOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private PMJGCCPCNPB BKMBGFKKHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private OPOIJEOAEKC LPENEHDDHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private LIMEHMPEEEM GPBNDJAMPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private TaskCompletionSource<MEHNDAGNNDB> KJMCDKFAHID;

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x767FFC0", Offset = "0x767E7C0", VA = "0x18767FFC0", Slot = "7")]
	public void EHFCOOMFLME(PJDNBPNFOAH JCCNNNNOALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x7680C20", Offset = "0x767F420", VA = "0x187680C20", Slot = "6")]
	[AsyncStateMachine(typeof(OEOEELBMPFJ))]
	public Task<MEHNDAGNNDB> MBCGHLPDDLC(CancellationToken ABHOMKHPBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x7680D30", Offset = "0x767F530", VA = "0x187680D30", Slot = "4")]
	public void MBOEOILLNLG(AACGOKBLDOD PJFOMDHJLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x7680530", Offset = "0x767ED30", VA = "0x187680530", Slot = "5")]
	public void LDOGOMCJECI(AACGOKBLDOD PDJCDPNPJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x767FEB0", Offset = "0x767E6B0", VA = "0x18767FEB0")]
	[AsyncStateMachine(typeof(HIFEKAHIALA))]
	private Task DOLEOHPMPLH(AACGOKBLDOD BPCGMGBPPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x767FDA0", Offset = "0x767E5A0", VA = "0x18767FDA0")]
	[AsyncStateMachine(typeof(APLCMMKAHLO))]
	private Task BNMKLAJBHPE(AACGOKBLDOD PHIGODKGHMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x76802C0", Offset = "0x767EAC0", VA = "0x1876802C0")]
	[AsyncStateMachine(typeof(GEAPEMOCDBB))]
	private Task<CHAHCGOKNDN> JEMNEJANNMB(AACGOKBLDOD BPCGMGBPPCA, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x76810C0", Offset = "0x767F8C0", VA = "0x1876810C0")]
	private BOJCINHMKKJ PFNGPEDGPJL(AACGOKBLDOD BAAPKBGGPBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x7680410", Offset = "0x767EC10", VA = "0x187680410")]
	[AsyncStateMachine(typeof(CGPPBLPMMAH))]
	private Task JPBKNILFJJG(CHAHCGOKNDN GFKCDNLMPGP, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x76800B0", Offset = "0x767E8B0", VA = "0x1876800B0")]
	private CHAHCGOKNDN FOLFAFDIDKG(AACGOKBLDOD BPCGMGBPPCA, BOJCINHMKKJ HOBCAPOIMKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x3754670", Offset = "0x3752E70", VA = "0x183754670")]
	private T DKIEOIKHGEK<T>(T INDENPJBLHO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x7680890", Offset = "0x767F090", VA = "0x187680890")]
	private CHAHCGOKNDN LJPCNPHJHMC(AACGOKBLDOD BPCGMGBPPCA, BOJCINHMKKJ HOBCAPOIMKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public AONMAMLJEDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[UnityEngine.Scripting.Preserve]
internal sealed class BCFPBAIFLND : PMJGCCPCNPB, IJHDFCLIPMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class HGLJIKJOGBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public HGLJIKJOGBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x768B740", Offset = "0x7689F40", VA = "0x18768B740")]
		internal object JOPMJMHGFAD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class GPIJFBFKJLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public GPIJFBFKJLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x768B6D0", Offset = "0x7689ED0", VA = "0x18768B6D0")]
		internal object MKMGAIBKMFJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private LIMEHMPEEEM GPBNDJAMPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private LHADMAJEKNN LOMPCCHLDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private ANAPOHGFCAE ALPOILCKPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private LICNABCHEMA DKHAIPGDBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private IBOMOHAPHAO PJHBLDGIFLI;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7682560", Offset = "0x7680D60", VA = "0x187682560", Slot = "6")]
	public void EHFCOOMFLME(PJDNBPNFOAH JCCNNNNOALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x76824B0", Offset = "0x7680CB0", VA = "0x1876824B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x76826D0", Offset = "0x7680ED0", VA = "0x1876826D0", Slot = "4")]
	public OJGICLADILJ GIPDJCMIGFI(AACGOKBLDOD CAEPDKFKBIO)
	{
		return default(OJGICLADILJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x76838E0", Offset = "0x76820E0", VA = "0x1876838E0", Slot = "5")]
	public void LLMKHBFJDEE(Guid PHACDDBECOP, Task BNAOBCNJNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x76835D0", Offset = "0x7681DD0", VA = "0x1876835D0")]
	private void IIHOMLHFNLB(byte LDDLJBFNIGE, int PHOEBDGADNM, object DMCGKHONJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x7683040", Offset = "0x7681840", VA = "0x187683040")]
	private void IDNMFAPDAJD(PLBIOMENPFL NBKLKIFNAIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x76821B0", Offset = "0x76809B0", VA = "0x1876821B0")]
	private void CIBCJIDNKND(PLBIOMENPFL NBKLKIFNAIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x7683AF0", Offset = "0x76822F0", VA = "0x187683AF0")]
	private void LOLMAAOHIIL(PLBIOMENPFL NBKLKIFNAIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x76836A0", Offset = "0x7681EA0", VA = "0x1876836A0")]
	private NDIOHACFFEO JABINHDJNIK(AACGOKBLDOD BAAPKBGGPBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x7681D20", Offset = "0x7680520", VA = "0x187681D20")]
	private void BCFDINCIHIK(AACGOKBLDOD PHIGODKGHMI, NDIOHACFFEO APFOMFNCNPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x7682D90", Offset = "0x7681590", VA = "0x187682D90")]
	private bool HLEICCIBDFN(AACGOKBLDOD PHIGODKGHMI, NDIOHACFFEO APFOMFNCNPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x7681F30", Offset = "0x7680730", VA = "0x187681F30")]
	private bool CEKBFIIMCLH(AACGOKBLDOD DKHICJKBEBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x7682B00", Offset = "0x7681300", VA = "0x187682B00")]
	private bool GKFNPIGDCAK(byte LDDLJBFNIGE, ExitGames.Client.Photon.Hashtable NBKLKIFNAIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public BCFPBAIFLND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[UnityEngine.Scripting.Preserve]
internal sealed class PNGANHDHKNJ : DOJKJBCDKGH, IJHDFCLIPMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class EHHHPOBAFOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public MEHNDAGNNDB operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public PNGANHDHKNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public AACGOKBLDOD roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public EHHHPOBAFOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x76881C0", Offset = "0x76869C0", VA = "0x1876881C0")]
		internal object DCLFHLEGCIM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x7688230", Offset = "0x7686A30", VA = "0x187688230")]
		internal object FAKEPHNDLBI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct OCNDMENCNLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public AsyncTaskMethodBuilder<NDIOHACFFEO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public PNGANHDHKNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public AACGOKBLDOD roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private DGPGECBENMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter<NDIOHACFFEO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x7696EF0", Offset = "0x76956F0", VA = "0x187696EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x7697590", Offset = "0x7695D90", VA = "0x187697590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class CDOFJDMDOPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public MEHNDAGNNDB operationType;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public CDOFJDMDOPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x7686490", Offset = "0x7684C90", VA = "0x187686490")]
		internal object IICHNOKNNEG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class NEMHAHLHPIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public AACGOKBLDOD request;

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public NEMHAHLHPIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x7694E30", Offset = "0x7693630", VA = "0x187694E30")]
		internal object GKJEGHNKPGB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x7694DC0", Offset = "0x76935C0", VA = "0x187694DC0")]
		internal object BJGENJHCMGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x7694EA0", Offset = "0x76936A0", VA = "0x187694EA0")]
		internal object HDMIBEHAFAC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct LJJANGGNJMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public AsyncTaskMethodBuilder<NDIOHACFFEO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public AACGOKBLDOD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public PNGANHDHKNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private NEMHAHLHPIM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private DGPGECBENMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private OJGICLADILJ <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private NDIOHACFFEO <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private TaskAwaiter<(NDIOHACFFEO validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x76919E0", Offset = "0x76901E0", VA = "0x1876919E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x76922B0", Offset = "0x7690AB0", VA = "0x1876922B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private LIMEHMPEEEM GPBNDJAMPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private LHADMAJEKNN LOMPCCHLDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private PMJGCCPCNPB BKMBGFKKHDI;

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x769DC50", Offset = "0x769C450", VA = "0x18769DC50", Slot = "5")]
	public void EHFCOOMFLME(PJDNBPNFOAH JCCNNNNOALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x769E030", Offset = "0x769C830", VA = "0x18769E030", Slot = "4")]
	[AsyncStateMachine(typeof(OCNDMENCNLJ))]
	private Task<NDIOHACFFEO> PEJGENDAHEH(AACGOKBLDOD BAAPKBGGPBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x769DE40", Offset = "0x769C640", VA = "0x18769DE40")]
	private bool KCJOJFKFDCI(MEHNDAGNNDB CAKEPGIDGEO, [Out] NDIOHACFFEO HANDIANDCDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x769DD00", Offset = "0x769C500", VA = "0x18769DD00")]
	[AsyncStateMachine(typeof(LJJANGGNJMA))]
	private Task<NDIOHACFFEO> HBCPHDAKIOH(AACGOKBLDOD BPCGMGBPPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public PNGANHDHKNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class PLNGAHICHCF : LOCGHKLNEFM, IJHDFCLIPMB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct GDEGJIEMIOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<MIPHOHMODEJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public DILBKEMEFHP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public PLNGAHICHCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private TaskAwaiter<NIHPFEHJKNJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<MIPHOHMODEJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x76898C0", Offset = "0x76880C0", VA = "0x1876898C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x7689E90", Offset = "0x7688690", VA = "0x187689E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class BFHMFLAGBDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public BFHMFLAGBDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x7683D30", Offset = "0x7682530", VA = "0x187683D30")]
		internal object KGAMAMNNJBE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct PMHBHOGIOOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public AsyncTaskMethodBuilder<NIHPFEHJKNJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public PLNGAHICHCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public DILBKEMEFHP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private BFHMFLAGBDE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private TaskAwaiter<NIHPFEHJKNJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x769D5F0", Offset = "0x769BDF0", VA = "0x18769D5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x769DBE0", Offset = "0x769C3E0", VA = "0x18769DBE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct EMMEFNFMJMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public AsyncTaskMethodBuilder<MIPHOHMODEJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public PLNGAHICHCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public DILBKEMEFHP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public NIHPFEHJKNJ roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private TaskAwaiter<(AMBENGOMJIK superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x7688B10", Offset = "0x7687310", VA = "0x187688B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x7688F70", Offset = "0x7687770", VA = "0x187688F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class ACKJBKJHGKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public ACKJBKJHGKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xA8C3D0", Offset = "0xA8ABD0", VA = "0x180A8C3D0")]
		internal bool AJHDDHLJEMP(IPKCPHEECFE sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct HKNFAIOOAFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public AsyncTaskMethodBuilder<(AMBENGOMJIK superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public NIHPFEHJKNJ roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public PLNGAHICHCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public DILBKEMEFHP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private TaskAwaiter<(AMBENGOMJIK superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x768C520", Offset = "0x768AD20", VA = "0x18768C520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x768CBC0", Offset = "0x768B3C0", VA = "0x18768CBC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class FKJEPHFAEFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public FKJEPHFAEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x7689460", Offset = "0x7687C60", VA = "0x187689460")]
		internal object HMPFMCPKKHA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct PELBMGCDONF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public AsyncTaskMethodBuilder<(AMBENGOMJIK superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public IPKCPHEECFE subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public PLNGAHICHCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public DILBKEMEFHP dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private FKJEPHFAEFP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private TaskAwaiter<DJPINPOMHEF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x769B0E0", Offset = "0x76998E0", VA = "0x18769B0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x769B810", Offset = "0x769A010", VA = "0x18769B810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private static readonly (AMBENGOMJIK superRoomData, long subRoomDataSaveId) ANNIOIKCNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private PCCBFICHMFB BIJBPNIFOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private NAHCINMEGBN ECGJACEPLLG;

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x769CEF0", Offset = "0x769B6F0", VA = "0x18769CEF0", Slot = "5")]
	public void EHFCOOMFLME(PJDNBPNFOAH JCCNNNNOALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x769D3C0", Offset = "0x769BBC0", VA = "0x18769D3C0", Slot = "4")]
	[AsyncStateMachine(typeof(GDEGJIEMIOI))]
	public Task<MIPHOHMODEJ> PKPFCHFAOFD(NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, DILBKEMEFHP EOGDECBBPFB, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x769D0F0", Offset = "0x769B8F0", VA = "0x18769D0F0")]
	[AsyncStateMachine(typeof(PMHBHOGIOOE))]
	private Task<NIHPFEHJKNJ> KJFOEKCJHPO(DILBKEMEFHP EOGDECBBPFB, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x769CD80", Offset = "0x769B580", VA = "0x18769CD80")]
	[AsyncStateMachine(typeof(EMMEFNFMJMC))]
	private Task<MIPHOHMODEJ> DGIHLLNCEGG(DILBKEMEFHP EOGDECBBPFB, NIHPFEHJKNJ MLGCKEJNBKC, long ACPFGDPOKJK, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x769CF80", Offset = "0x769B780", VA = "0x18769CF80")]
	[AsyncStateMachine(typeof(HKNFAIOOAFD))]
	private Task<(AMBENGOMJIK, long)> GIJPOEDBNJL(DILBKEMEFHP EOGDECBBPFB, NIHPFEHJKNJ MLGCKEJNBKC, long ACPFGDPOKJK, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x769D250", Offset = "0x769BA50", VA = "0x18769D250")]
	[AsyncStateMachine(typeof(PELBMGCDONF))]
	private Task<(AMBENGOMJIK, long)> LEMCLGIGFHG(DILBKEMEFHP CDPKIEMOPAM, IPKCPHEECFE DLFCOLDGOCG, long ACPFGDPOKJK, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public PLNGAHICHCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[UnityEngine.Scripting.Preserve]
internal sealed class MPIPIDABLFA : OPOIJEOAEKC, IJHDFCLIPMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class MOIGGDABPAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public AACGOKBLDOD request;

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public MOIGGDABPAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x7693090", Offset = "0x7691890", VA = "0x187693090")]
		internal object NEHCHEDICGK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct JOBEIKJKLNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public AsyncTaskMethodBuilder<AACGOKBLDOD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public AACGOKBLDOD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public MPIPIDABLFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public BOJCINHMKKJ pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private DGPGECBENMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private TaskAwaiter<AACGOKBLDOD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x768EFC0", Offset = "0x768D7C0", VA = "0x18768EFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x768F5D0", Offset = "0x768DDD0", VA = "0x18768F5D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct MOFMHBCFABO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder<AACGOKBLDOD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public MPIPIDABLFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public BOJCINHMKKJ pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private DGPGECBENMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private TaskAwaiter<LCMNGLNKNED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x7692A20", Offset = "0x7691220", VA = "0x187692A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x7693020", Offset = "0x7691820", VA = "0x187693020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class MMBIMKLOJFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public AACGOKBLDOD request;

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public MMBIMKLOJFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x76923F0", Offset = "0x7690BF0", VA = "0x1876923F0")]
		internal object ELMONMLOGMP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct BJCNCFMHPDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AsyncTaskMethodBuilder<AACGOKBLDOD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public AACGOKBLDOD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public MPIPIDABLFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public BOJCINHMKKJ pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private DGPGECBENMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private DOAEPDDPLFH <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private MPMIAJJIEFA <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private TaskAwaiter<LCMNGLNKNED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x76851D0", Offset = "0x76839D0", VA = "0x1876851D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x7685DC0", Offset = "0x76845C0", VA = "0x187685DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private LIMEHMPEEEM GPBNDJAMPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private EELLJKLPNNH FKONDPHKEHK;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	private OKNDNPAECMD EDNDONMKPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x7693530", Offset = "0x7691D30", VA = "0x187693530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x76933F0", Offset = "0x7691BF0", VA = "0x1876933F0", Slot = "8")]
	public void EHFCOOMFLME(PJDNBPNFOAH JCCNNNNOALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x76935F0", Offset = "0x7691DF0", VA = "0x1876935F0", Slot = "4")]
	[AsyncStateMachine(typeof(JOBEIKJKLNH))]
	public Task<AACGOKBLDOD> OJILPLOJBOB(AACGOKBLDOD BPCGMGBPPCA, BOJCINHMKKJ HOBCAPOIMKF, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x7693750", Offset = "0x7691F50", VA = "0x187693750", Slot = "5")]
	[AsyncStateMachine(typeof(MOFMHBCFABO))]
	public Task<AACGOKBLDOD> PNMOGBPPFAB(CancellationToken ALKEMFHOMCA, BOJCINHMKKJ HOBCAPOIMKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7693480", Offset = "0x7691C80", VA = "0x187693480", Slot = "6")]
	public FKDGKIDPJEM FMJGMMAFCHB(CHAHCGOKNDN ICGEDPEBNHL, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x7693150", Offset = "0x7691950", VA = "0x187693150", Slot = "7")]
	public FKDGKIDPJEM APJENLONPKK(CHAHCGOKNDN ICGEDPEBNHL, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x7693290", Offset = "0x7691A90", VA = "0x187693290")]
	[AsyncStateMachine(typeof(BJCNCFMHPDL))]
	private Task<AACGOKBLDOD> DNIOLKJPCBJ(AACGOKBLDOD BPCGMGBPPCA, BOJCINHMKKJ HOBCAPOIMKF, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x306A980", Offset = "0x3069180", VA = "0x18306A980")]
	private static byte[] NGFGPHPBFDP(AACGOKBLDOD PJFOMDHJLBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public MPIPIDABLFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[UnityEngine.Scripting.Preserve]
internal sealed class BHLEDNGDNBA : LHADMAJEKNN, IJHDFCLIPMB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private EPDKCEBIKOC FGDCDFOKOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private LIMEHMPEEEM GPBNDJAMPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private DFOGKGLJPAP IFDAEFBECOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private DGFDFLCAHPC PCBOFCHDKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private PCCBFICHMFB BIJBPNIFOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private EDKIGICJHAI CPNJLLMGJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private MNOJCPELDFP GNANILJGGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private DDLHHFMIEGG MEGJMJCJPOE;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	private ODFFNGGOBDA PIDJECIHDLH
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x7684490", Offset = "0x7682C90", VA = "0x187684490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	private static NDIOHACFFEO BFENJHDFCEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x76842C0", Offset = "0x7682AC0", VA = "0x1876842C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x7683DE0", Offset = "0x76825E0", VA = "0x187683DE0", Slot = "6")]
	public void EHFCOOMFLME(PJDNBPNFOAH JCCNNNNOALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x7684320", Offset = "0x7682B20", VA = "0x187684320", Slot = "4")]
	public NDIOHACFFEO KCFMPHLDFPB(OEDKOGGDKCO FHPLHLDKNNL, MEHNDAGNNDB IOIKOBEMEOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x7683FB0", Offset = "0x76827B0", VA = "0x187683FB0", Slot = "5")]
	public NDIOHACFFEO IDAOMBIPMNO(OEDKOGGDKCO LMPNFAPOFCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x7683F50", Offset = "0x7682750", VA = "0x187683F50")]
	private static NDIOHACFFEO FEPIJHDHLDN(JKGAFKKEBBK HLONLEDABCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public BHLEDNGDNBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public class BHOEHGHBICO : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x76844E0", Offset = "0x7682CE0", VA = "0x1876844E0")]
	public BHOEHGHBICO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x6A1A090", Offset = "0x6A18890", VA = "0x186A1A090")]
	public BHOEHGHBICO(string PJFOMDHJLBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[UnityEngine.Scripting.Preserve]
internal sealed class NGNHFKOKKAA : PBEGAKKMGKP, IJHDFCLIPMB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct KABOPFNOOJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public AsyncTaskMethodBuilder<NDIOHACFFEO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public NGNHFKOKKAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public JLLNKPIMHOC autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private NGPFCPLNCNC<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private KPKGNNDIFCN <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private TaskAwaiter<NDIOHACFFEO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x768FA40", Offset = "0x768E240", VA = "0x18768FA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x76905C0", Offset = "0x768EDC0", VA = "0x1876905C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct OOIMGNGNCML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public NGNHFKOKKAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x769A840", Offset = "0x7699040", VA = "0x18769A840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x769AFA0", Offset = "0x76997A0", VA = "0x18769AFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct KOLHMJJFPBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public NGNHFKOKKAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x7690DC0", Offset = "0x768F5C0", VA = "0x187690DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x76912D0", Offset = "0x768FAD0", VA = "0x1876912D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct ELBALAFGOJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public NGNHFKOKKAA <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x7688360", Offset = "0x7686B60", VA = "0x187688360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x7688AB0", Offset = "0x76872B0", VA = "0x187688AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct JKLFGDPBFFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public NGNHFKOKKAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x768EDC0", Offset = "0x768D5C0", VA = "0x18768EDC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x768EF60", Offset = "0x768D760", VA = "0x18768EF60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct PGCLANNPGLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public NGNHFKOKKAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x769B880", Offset = "0x769A080", VA = "0x18769B880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x769BFB0", Offset = "0x769A7B0", VA = "0x18769BFB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct GOLIHHGKPDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public NGNHFKOKKAA <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x768B200", Offset = "0x7689A00", VA = "0x18768B200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x768B670", Offset = "0x7689E70", VA = "0x18768B670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private struct MOBOEDKBOKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public NGNHFKOKKAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public GIAKNOPIGAP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private NGPFCPLNCNC<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x7692450", Offset = "0x7690C50", VA = "0x187692450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x76929C0", Offset = "0x76911C0", VA = "0x1876929C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private LIMEHMPEEEM GPBNDJAMPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private PJDNBPNFOAH JCCNNNNOALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private PCCBFICHMFB BIJBPNIFOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private OPOIJEOAEKC LPENEHDDHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private DFOGKGLJPAP IFDAEFBECOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private MNOJCPELDFP GNANILJGGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private CancellationTokenSource JKKPOJBPPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private Task KHDKAOOJPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private TaskCompletionSource<int> FPBEJFBMGBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private int APJDGDPHPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private int GLMGKEJNPMC;

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x76959F0", Offset = "0x76941F0", VA = "0x1876959F0", Slot = "6")]
	public void EHFCOOMFLME(PJDNBPNFOAH JCCNNNNOALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0xE34340", Offset = "0xE32B40", VA = "0x180E34340", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x7695D10", Offset = "0x7694510", VA = "0x187695D10")]
	private void HOIEHBMHDIK(float KHHJNGEBMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x76957D0", Offset = "0x7693FD0", VA = "0x1876957D0", Slot = "4")]
	[AsyncStateMachine(typeof(KABOPFNOOJA))]
	public Task<NDIOHACFFEO> CIJEIBMEOAI(JLLNKPIMHOC FIBEEOLBGPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x7695DF0", Offset = "0x76945F0", VA = "0x187695DF0", Slot = "5")]
	[AsyncStateMachine(typeof(OOIMGNGNCML))]
	public Task HPFJOKMGDPG([Optional] CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0xE34340", Offset = "0xE32B40", VA = "0x180E34340")]
	public void HADIPGHOPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x7695BA0", Offset = "0x76943A0", VA = "0x187695BA0")]
	private KPKGNNDIFCN GCLJIHCAAON(JLLNKPIMHOC FIBEEOLBGPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x76956E0", Offset = "0x7693EE0", VA = "0x1876956E0")]
	[AsyncStateMachine(typeof(KOLHMJJFPBP))]
	private Task BDFJHPJJBFK(CancellationToken LCOCKEOACEA, int FNNMEEPNLFL, NBGFMFDOHOO KAMIPNGFFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x7696260", Offset = "0x7694A60", VA = "0x187696260")]
	[AsyncStateMachine(typeof(ELBALAFGOJO))]
	private Task KHIDALLGNPG(CancellationToken LCOCKEOACEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x7695900", Offset = "0x7694100", VA = "0x187695900")]
	[AsyncStateMachine(typeof(JKLFGDPBFFK))]
	private Task CLKOLNIGPHO([Optional] CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x7695460", Offset = "0x7693C60", VA = "0x187695460")]
	[AsyncStateMachine(typeof(PGCLANNPGLD))]
	private Task ABMHHFMDBME(CancellationToken LCOCKEOACEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x7696160", Offset = "0x7694960", VA = "0x187696160")]
	[AsyncStateMachine(typeof(GOLIHHGKPDI))]
	private Task JOFGKPPANFB(CancellationToken PECNBFOEELF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x7695550", Offset = "0x7693D50", VA = "0x187695550")]
	private Task BADEFLDHDBP(GIAKNOPIGAP LGKPGNPIEMH, CancellationToken LCOCKEOACEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x7696360", Offset = "0x7694B60", VA = "0x187696360")]
	[AsyncStateMachine(typeof(MOBOEDKBOKL))]
	private Task OPNBPHCHLHA(GIAKNOPIGAP LGKPGNPIEMH, CancellationToken LCOCKEOACEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x7695EE0", Offset = "0x76946E0", VA = "0x187695EE0")]
	private bool JNMOPIBCGPM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public NGNHFKOKKAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[UnityEngine.Scripting.Preserve]
internal class CAPOEMGEFDL : DGFDFLCAHPC, IJHDFCLIPMB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private struct LCGPHPFINDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public CAPOEMGEFDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private NGPFCPLNCNC<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x76913B0", Offset = "0x768FBB0", VA = "0x1876913B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x7691920", Offset = "0x7690120", VA = "0x187691920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private GKICLCGBOMN GIJEODMEHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private PJDNBPNFOAH JCCNNNNOALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	private LHADMAJEKNN LOMPCCHLDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	private OPOIJEOAEKC LPENEHDDHDD;

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x7686050", Offset = "0x7684850", VA = "0x187686050", Slot = "6")]
	public void EHFCOOMFLME(PJDNBPNFOAH JCCNNNNOALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x7686000", Offset = "0x7684800", VA = "0x187686000", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x7686390", Offset = "0x7684B90", VA = "0x187686390", Slot = "5")]
	[AsyncStateMachine(typeof(LCGPHPFINDN))]
	public Task OMAPJKNPIKM(string EDMHAMLCOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x7686330", Offset = "0x7684B30", VA = "0x187686330", Slot = "4")]
	public NDIOHACFFEO JNMOPIBCGPM(OEDKOGGDKCO FHPLHLDKNNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x7685F10", Offset = "0x7684710", VA = "0x187685F10")]
	private FAFIIFFKFOJ DPKGBPNCHAJ(string EDMHAMLCOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public CAPOEMGEFDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class PIIKMOFOKNA
{
	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x769C010", Offset = "0x769A810", VA = "0x18769C010")]
	public static void DBHGPMGEKLG(CMONJLKOOCI MFHCHOKEAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x769C250", Offset = "0x769AA50", VA = "0x18769C250")]
	internal static void DFAMKBFEFFP(CMONJLKOOCI MFHCHOKEAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x769C800", Offset = "0x769B000", VA = "0x18769C800")]
	internal static void HBFBAJMKDGM(CMONJLKOOCI MFHCHOKEAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x769C3B0", Offset = "0x769ABB0", VA = "0x18769C3B0")]
	internal static void FMDMOJMAPEA(CMONJLKOOCI MFHCHOKEAIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class NKNGHBOBLEI : ECALEILDDPP<AACGOKBLDOD>
{
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class OLHEADOKAMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public AACGOKBLDOD message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public OLHEADOKAMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x7698DC0", Offset = "0x76975C0", VA = "0x187698DC0")]
		internal object FOGIJGNFPPE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly NKNGHBOBLEI ODDIIHPHFEL;

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x7696850", Offset = "0x7695050", VA = "0x187696850")]
	public ExitGames.Client.Photon.Hashtable KBGBIJFEDIC(AACGOKBLDOD PJFOMDHJLBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x7696720", Offset = "0x7694F20", VA = "0x187696720", Slot = "5")]
	protected override void GJIMCKLGLHD(AACGOKBLDOD PJFOMDHJLBF, IDictionary<object, object> EBNFOODJNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x76968E0", Offset = "0x76950E0", VA = "0x1876968E0", Slot = "6")]
	public override AACGOKBLDOD KDFBDMHOPOO(IDictionary<object, object> EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x7696610", Offset = "0x7694E10", VA = "0x187696610")]
	private static void CLLGOIEIHDM(string NEEFBCKJALG, AACGOKBLDOD PJFOMDHJLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x7696E50", Offset = "0x7695650", VA = "0x187696E50")]
	public NKNGHBOBLEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x7696B10", Offset = "0x7695310", VA = "0x187696B10")]
	[CompilerGenerated]
	internal static string PGIIMDELBDE(MIPHOHMODEJ OANAMCHLGCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public static class KMMAAIEHCCE
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public static NDIOHACFFEO BFENJHDFCEC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x76842C0", Offset = "0x7682AC0", VA = "0x1876842C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x7690DA0", Offset = "0x768F5A0", VA = "0x187690DA0")]
	public static bool GNNBHPCLJBC(this NDIOHACFFEO APFOMFNCNPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x7683F50", Offset = "0x7682750", VA = "0x187683F50")]
	public static NDIOHACFFEO FEPIJHDHLDN(JKGAFKKEBBK FNMHABFFFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x7690BA0", Offset = "0x768F3A0", VA = "0x187690BA0")]
	public static NDIOHACFFEO FKFMKHCAMPE(IEnumerable<NDIOHACFFEO> DMKLIOAEKHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x7690940", Offset = "0x768F140", VA = "0x187690940")]
	public static string CLJNNBHHOBH(this NDIOHACFFEO HANDIANDCDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public abstract class HJENGLCKNFN : GDEKBJLHOOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public delegate NDIOHACFFEO IJENIKAMCJG([NotNull] OEDKOGGDKCO MLPPKHDJMNB);

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class PLFKGMDBJEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public OEDKOGGDKCO photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public PLFKGMDBJEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x6C2ED40", Offset = "0x6C2D540", VA = "0x186C2ED40")]
		internal NDIOHACFFEO DKGEHGKKLKB(IJENIKAMCJG v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private bool BCEDAPNKMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	protected readonly HashSet<IJENIKAMCJG> FAGJFBLLCGL;

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x768C0E0", Offset = "0x768A8E0", VA = "0x18768C0E0", Slot = "4")]
	public void CPCKIBGHFEA(IJENIKAMCJG HDMCLCIMACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x768C190", Offset = "0x768A990", VA = "0x18768C190", Slot = "5")]
	public void EHCHNEMNFGB(IJENIKAMCJG HDMCLCIMACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x768C140", Offset = "0x768A940", VA = "0x18768C140", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x768C1F0", Offset = "0x768A9F0", VA = "0x18768C1F0")]
	protected NDIOHACFFEO JLOKGEDKACK(OEDKOGGDKCO LMPNFAPOFCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x768C490", Offset = "0x768AC90", VA = "0x18768C490")]
	protected HJENGLCKNFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class NJFHPMFBLHE : HJENGLCKNFN, EPDKCEBIKOC, GDEKBJLHOOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private sealed class HNKOLCNHCFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public NDIOHACFFEO result;

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public HNKOLCNHCFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x768CC30", Offset = "0x768B430", VA = "0x18768CC30")]
		internal object DLENALLDOBA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x7696580", Offset = "0x7694D80", VA = "0x187696580")]
	[UnityEngine.Scripting.Preserve]
	public NJFHPMFBLHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x7696470", Offset = "0x7694C70", VA = "0x187696470", Slot = "8")]
	public NDIOHACFFEO KBOIIAECLKM(OEDKOGGDKCO LMPNFAPOFCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class PJINHJFBFFH : HJENGLCKNFN, GKICLCGBOMN, GDEKBJLHOOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private sealed class MPEOGDLHDBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public NDIOHACFFEO result;

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public MPEOGDLHDBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x76930F0", Offset = "0x76918F0", VA = "0x1876930F0")]
		internal object LDCDDFODBEI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x7696580", Offset = "0x7694D80", VA = "0x187696580")]
	[UnityEngine.Scripting.Preserve]
	public PJINHJFBFFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x769C8E0", Offset = "0x769B0E0", VA = "0x18769C8E0", Slot = "8")]
	public NDIOHACFFEO JNMOPIBCGPM(OEDKOGGDKCO FPHGJJIHFFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal static class FFILDKHIFOB
{
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private sealed class BOHEAJEGCII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public NGPFCPLNCNC<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public BOHEAJEGCII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7685E90", Offset = "0x7684690", VA = "0x187685E90")]
		internal object POEJHEAAGKC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x7689320", Offset = "0x7687B20", VA = "0x187689320")]
	public static NGPFCPLNCNC<string> KAGMHBBALGN(FICDJCDJOAA AGHKKLOENAF, [Optional] string BMEJGPMKBBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x76891A0", Offset = "0x76879A0", VA = "0x1876891A0")]
	public static void AOMBHDEPPDO(NGPFCPLNCNC<string> IEGOAOCEEPG, FICDJCDJOAA AGHKKLOENAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x7689260", Offset = "0x7687A60", VA = "0x187689260")]
	public static string BEFCDIDIGKL(AACGOKBLDOD BAAPKBGGPBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal static class KDAHHOBLIJI
{
	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x7690800", Offset = "0x768F000", VA = "0x187690800")]
	public static void KEDKABGJNGK(this LIMEHMPEEEM GPBNDJAMPKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x7690930", Offset = "0x768F130", VA = "0x187690930")]
	public static void PGHAPLGDNLJ(this LIMEHMPEEEM GPBNDJAMPKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x7690810", Offset = "0x768F010", VA = "0x187690810")]
	private static void LLBJGDMNFKF(this LIMEHMPEEEM GPBNDJAMPKD, bool AINCGPCDGLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public class NGFHPAMNPNO : FOHNPGGGNPG, HBMCHPBEIEL, KNJEPKLFJIN, OCOMJIKCDIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	private readonly HBMCHPBEIEL KCBGMGONBBC;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public OEDKOGGDKCO GAJHHPEBEKO
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x76950E0", Offset = "0x76938E0", VA = "0x1876950E0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public int EIGNFCJBOOI
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x7695320", Offset = "0x7693B20", VA = "0x187695320", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int CJELGCIOPKD
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x7694FB0", Offset = "0x76937B0", VA = "0x187694FB0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool ILEJCAKOEMD
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public int NDKGILILCKF
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x92F1C0", Offset = "0x92D9C0", VA = "0x18092F1C0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event OJJCFGIFEDK.MDCMIMDHCCE NOFPMNKPHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event MIACEINFGJO DKPNFMKEKCB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x76953C0", Offset = "0x7693BC0", VA = "0x1876953C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x7695280", Offset = "0x7693A80", VA = "0x187695280", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> LEILHDGPJDP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<OEDKOGGDKCO> AMOCINDBBJF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action JBFOMODCIKL
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x76951E0", Offset = "0x76939E0", VA = "0x1876951E0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x7694F10", Offset = "0x7693710", VA = "0x187694F10", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x93A430", Offset = "0x938C30", VA = "0x18093A430")]
	public NGFHPAMNPNO(HBMCHPBEIEL KCBGMGONBBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x7695130", Offset = "0x7693930", VA = "0x187695130", Slot = "8")]
	public bool BMPPBKPPJNM(byte LDDLJBFNIGE, ExitGames.Client.Photon.Hashtable HOCNKHEKJDK, FFFPNEALPAM DDDGCKEMPHN, SendOptions PCCKLELNGGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x7695000", Offset = "0x7693800", VA = "0x187695000", Slot = "16")]
	public OEDKOGGDKCO BCMHJKKOPKH(int OLKCJJDGMPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "19")]
	public void DEDPAOOCOOK(object DJIMHLGHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "20")]
	public void JHNNJOGDDFM(object DJIMHLGHFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "21")]
	public void GJPONMKGNPD(object DJIMHLGHFGI, bool DCCBIOFBKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x7695370", Offset = "0x7693B70", VA = "0x187695370", Slot = "22")]
	public IDisposable MBCGNJAMKOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "23")]
	private bool GHIFLNEHEKG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "24")]
	public void CIJHBCLCBMN(StringBuilder OEMCDECEAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0xB51AF0", Offset = "0xB502F0", VA = "0x180B51AF0", Slot = "25")]
	public bool FOBCNKINBCC(bool HHCOAHGNHBC, [Out] string JBBHONJKFOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0xAE85A0", Offset = "0xAE6DA0", VA = "0x180AE85A0", Slot = "28")]
	public void FOPEDPEBFGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal struct PLBIOMENPFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	private readonly IDictionary<object, object> NBKLKIFNAIH;

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x95E8E0", Offset = "0x95D0E0", VA = "0x18095E8E0")]
	public PLBIOMENPFL(IDictionary<object, object> NBKLKIFNAIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x769C9F0", Offset = "0x769B1F0", VA = "0x18769C9F0")]
	public bool BGMFEEDJLMF([Out] AACGOKBLDOD PJFOMDHJLBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x769CAA0", Offset = "0x769B2A0", VA = "0x18769CAA0")]
	public Guid CEMHGHNHCMP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x769CB50", Offset = "0x769B350", VA = "0x18769CB50")]
	public NDIOHACFFEO ILBDHOINIAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x769CC90", Offset = "0x769B490", VA = "0x18769CC90")]
	public static ExitGames.Client.Photon.Hashtable JHEOKMMJDLF(AACGOKBLDOD PJFOMDHJLBF, NDIOHACFFEO APFOMFNCNPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal static class NJNBFCFNKOF
{
	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x7696590", Offset = "0x7694D90", VA = "0x187696590")]
	public static bool CFOPABDKPBB(this DILBKEMEFHP FLLIHFEHJJM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct GAANCLJPEJK : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct PNJKDCFNDED : IAsyncStateMachine
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
		public GAANCLJPEJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x769E150", Offset = "0x769C950", VA = "0x18769E150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x769E330", Offset = "0x769CB30", VA = "0x18769E330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	private readonly CancellationTokenSource OENGEKBIAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400031E")]
	private bool BCEDAPNKMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	private Task DIGFCMIOIEB;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool LNCHMIOPEFL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x7689670", Offset = "0x7687E70", VA = "0x187689670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x76896A0", Offset = "0x7687EA0", VA = "0x1876896A0")]
	public GAANCLJPEJK(CancellationToken ALKEMFHOMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x7689560", Offset = "0x7687D60", VA = "0x187689560")]
	[AsyncStateMachine(typeof(PNJKDCFNDED))]
	public Task FHPCKBBBPEK(Func<CancellationToken, List<Task>> GDEALOHBBKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x7689510", Offset = "0x7687D10", VA = "0x187689510", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public readonly struct NHLHCPHODCM<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct NOLHAFCPHDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<CKCMDPBBFGE<TData>, LHIOHJOJEEI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public NHLHCPHODCM<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private TaskAwaiter<DNFCNMKAMCE<CKCMDPBBFGE<TData>, LHIOHJOJEEI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x4A5C120", Offset = "0x4A5A920", VA = "0x184A5C120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x4311320", Offset = "0x430FB20", VA = "0x184311320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private readonly APHDDHEBBGD<TGetDataArg, TData> NNDMPDFKOOK;

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x95E8E0", Offset = "0x95D0E0", VA = "0x18095E8E0")]
	internal NHLHCPHODCM(APHDDHEBBGD<TGetDataArg, TData> HNBDHJIILED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x4A47E70", Offset = "0x4A46670", VA = "0x184A47E70")]
	[AsyncStateMachine(typeof(NHLHCPHODCM<, >.NOLHAFCPHDK))]
	public Task<DNFCNMKAMCE<CKCMDPBBFGE<TData>, LHIOHJOJEEI>> HMLANEKNKOL(TGetDataArg HBIPIPALDEO, string HCNEDFAPNLI, NGPFCPLNCNC<string>.PPCAKDHDCLK IEGOAOCEEPG, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public static class ANKDNEJKJNA
{
	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x2976640", Offset = "0x2974E40", VA = "0x182976640")]
	public static NHLHCPHODCM<TGetDataArg, TData> DFLBOLBHLFN<TGetDataArg, TData>(APHDDHEBBGD<TGetDataArg, TData> HNBDHJIILED)
	{
		return default(NHLHCPHODCM<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public struct PDFIMGDCOON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public readonly int CBCLICGCOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public readonly int? GANIEJFIHIB;

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x46D17A0", Offset = "0x46CFFA0", VA = "0x1846D17A0")]
	public PDFIMGDCOON(int KIEPLEFDLFJ, [Optional] int? FCMHHFKPMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x769B000", Offset = "0x7699800", VA = "0x18769B000", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public interface NJJIKAPOHDK<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HNAAMDOFDML();

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NJJIKAPOHDK<T> PLILKFIIPNO(string DFNPEPOLIKL);

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NJJIKAPOHDK<T> HMKNMLCONJK(LNILOJBOKFO<T> IBPLCOMKIDD);

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NJJIKAPOHDK<T> OFJGFBICBJG(int EBNOLCJBELN);

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NJJIKAPOHDK<T> CIGMCIIFHPL(int EBNOLCJBELN, FIHBHIGKPPL<T> NFIIMPKMECB);
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public interface OFJNNIAAKHB
{
	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NJJIKAPOHDK<T> ICJCNNDCEPN<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GJDHADBJCJM KICGJCBFKEH(Exception HNGGNNBFAEK);

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PDFIMGDCOON MGOPGFGICNH(Exception HNGGNNBFAEK);
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public delegate string LNILOJBOKFO<in T>(T HNGGNNBFAEK) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public delegate int FIHBHIGKPPL<in T>(T HNGGNNBFAEK) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal class ONMGIGCBCKF : OFJNNIAAKHB
{
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private delegate string OBIONOONNEL(Exception HNGGNNBFAEK);

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private delegate int CNEBKLPOAIM(Exception HNGGNNBFAEK);

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	private class ODNLNAOBCBH<T> : NJJIKAPOHDK<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		[CompilerGenerated]
		private sealed class GOLGADGBHEE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public GOLGADGBHEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
			internal string EPEBIEJJLFJ(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		[CompilerGenerated]
		private sealed class CKMAOGJBPPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public LNILOJBOKFO<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public CKMAOGJBPPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x4720180", Offset = "0x471E980", VA = "0x184720180")]
			internal string MGOLNGLNBAN(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[CompilerGenerated]
		private sealed class LDKDEBGDCBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public FIHBHIGKPPL<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public LDKDEBGDCBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x4720180", Offset = "0x471E980", VA = "0x184720180")]
			internal int HJOLMDPDFAI(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private readonly ONMGIGCBCKF GOCFKHDDAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		private readonly Type GKHAHKNFCAD;

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x4B427E0", Offset = "0x4B40FE0", VA = "0x184B427E0")]
		internal ODNLNAOBCBH(ONMGIGCBCKF GOCFKHDDAGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x4B42650", Offset = "0x4B40E50", VA = "0x184B42650", Slot = "4")]
		public void HNAAMDOFDML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x4B426C0", Offset = "0x4B40EC0", VA = "0x184B426C0", Slot = "5")]
		public NJJIKAPOHDK<T> PLILKFIIPNO(string DFNPEPOLIKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x4B42530", Offset = "0x4B40D30", VA = "0x184B42530", Slot = "6")]
		public NJJIKAPOHDK<T> HMKNMLCONJK(LNILOJBOKFO<T> IBPLCOMKIDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x4B42680", Offset = "0x4B40E80", VA = "0x184B42680", Slot = "7")]
		public NJJIKAPOHDK<T> OFJGFBICBJG(int EBNOLCJBELN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x4B42400", Offset = "0x4B40C00", VA = "0x184B42400", Slot = "8")]
		public NJJIKAPOHDK<T> CIGMCIIFHPL(int EBNOLCJBELN, FIHBHIGKPPL<T> NFIIMPKMECB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	private class NNALAJNKABC<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private bool IPENOLIMFKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private readonly List<Type> HLNHPMKONGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private readonly Dictionary<Type, TVal> KLLBGHIOONK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private readonly Dictionary<Type, int> FHIIDGHAMJK;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public IReadOnlyList<Type> KICAEDHAIPE
		{
			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0x4A5B020", Offset = "0x4A59820", VA = "0x184A5B020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x4A5B180", Offset = "0x4A59980", VA = "0x184A5B180")]
		public NNALAJNKABC(Dictionary<Type, int> FHIIDGHAMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x4A5AD80", Offset = "0x4A59580", VA = "0x184A5AD80")]
		public void JGCMIIMCCFC(Type KCGKBDGKIOP, TVal DBIIPNGMHFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x4A5ACE0", Offset = "0x4A594E0", VA = "0x184A5ACE0")]
		public bool DGDEDCOCIJK(Type GKHAHKNFCAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x4A5AD30", Offset = "0x4A59530", VA = "0x184A5AD30")]
		public bool EEHBOHEOPNF(TVal INDENPJBLHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x4A44090", Offset = "0x4A42890", VA = "0x184A44090")]
		public TVal EFGCOGNKKLM(Type OCLAPBNMMGE)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x4A5AF80", Offset = "0x4A59780", VA = "0x184A5AF80")]
		[CompilerGenerated]
		private int MLDPMHJNKMP(Type JIJFEOFBJFM, Type MPCFBHOBFHO)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class GKKDMLLIEGC : IEnumerable<PDFIMGDCOON>, IEnumerable, IEnumerator<PDFIMGDCOON>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private PDFIMGDCOON <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public ONMGIGCBCKF <>4__this;

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
		private IEnumerator<PDFIMGDCOON> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private PDFIMGDCOON System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0x3D49E50", Offset = "0x3D48650", VA = "0x183D49E50", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(PDFIMGDCOON);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0x768ACC0", Offset = "0x76894C0", VA = "0x18768ACC0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0xAC8700", Offset = "0xAC6F00", VA = "0x180AC8700")]
		[DebuggerHidden]
		public GKKDMLLIEGC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x768AD10", Offset = "0x7689510", VA = "0x18768AD10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x768A6B0", Offset = "0x7688EB0", VA = "0x18768A6B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x768AB60", Offset = "0x7689360", VA = "0x18768AB60")]
		private void PPNAIGJNIFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x768A660", Offset = "0x7688E60", VA = "0x18768A660")]
		private void DIDCIHLHMHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x768AC70", Offset = "0x7689470", VA = "0x18768AC70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x768ABB0", Offset = "0x76893B0", VA = "0x18768ABB0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PDFIMGDCOON> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x768ABB0", Offset = "0x76893B0", VA = "0x18768ABB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private static readonly PDFIMGDCOON PHOMOJDECBC;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private static readonly Dictionary<Type, int> LKMOKCNCGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private readonly HashSet<Type> BGPPGFJJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private readonly NNALAJNKABC<int> CLMNAALIHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private readonly NNALAJNKABC<CNEBKLPOAIM> BIDOGCPJMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private readonly NNALAJNKABC<OBIONOONNEL> GOCHGOBPBHD;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x769A3D0", Offset = "0x7698BD0", VA = "0x18769A3D0")]
	[PDAMAKFHAHC.GNFCFDNPMLH.BGLEOICIJCF]
	internal static void NJDIOBPBJFD(CMONJLKOOCI CGNEPIEHDLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x769A510", Offset = "0x7698D10", VA = "0x18769A510")]
	[RecRoom.NoEngine.Common.Preserve]
	public ONMGIGCBCKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x2E619A0", Offset = "0x2E601A0", VA = "0x182E619A0", Slot = "4")]
	public NJJIKAPOHDK<T> ICJCNNDCEPN<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x7699C80", Offset = "0x7698480", VA = "0x187699C80", Slot = "5")]
	public GJDHADBJCJM KICGJCBFKEH(Exception HNGGNNBFAEK)
	{
		return default(GJDHADBJCJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x769A080", Offset = "0x7698880", VA = "0x18769A080", Slot = "6")]
	public PDFIMGDCOON MGOPGFGICNH(Exception? HNGGNNBFAEK)
	{
		return default(PDFIMGDCOON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x7699FE0", Offset = "0x76987E0", VA = "0x187699FE0", Slot = "7")]
	[IteratorStateMachine(typeof(GKKDMLLIEGC))]
	public IEnumerable<PDFIMGDCOON> LKCONHALJEG(Exception HNGGNNBFAEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x769A280", Offset = "0x7698A80", VA = "0x18769A280", Slot = "8")]
	public string MMNGMHCKFPP(Exception? HNGGNNBFAEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x76995A0", Offset = "0x7697DA0", VA = "0x1876995A0")]
	private string GCFONIPLFNK(AggregateException IDKKPPBIGCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x7699110", Offset = "0x7697910", VA = "0x187699110")]
	private void DFMDHCIBLKD(Type GKHAHKNFCAD, int EBNOLCJBELN, CNEBKLPOAIM? HECKHLPKFJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x7699A30", Offset = "0x7698230", VA = "0x187699A30")]
	private void HHJFAFPACGN(Type GKHAHKNFCAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x7699D10", Offset = "0x7698510", VA = "0x187699D10")]
	private void LEGMPFDPAON(Type GKHAHKNFCAD, OBIONOONNEL NBCNBKEBFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x76998B0", Offset = "0x76980B0", VA = "0x1876998B0")]
	private static int HCKMPEKHNNH(Type GKHAHKNFCAD, Dictionary<Type, int> FHIIDGHAMJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x321F220", Offset = "0x321DA20", VA = "0x18321F220")]
	private static bool GJGNHOPJPNN<TVal>(NNALAJNKABC<TVal> MCAFGDLBCDD, Type GKHAHKNFCAD, [Out] TVal INDENPJBLHO) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x76994C0", Offset = "0x7697CC0", VA = "0x1876994C0")]
	[CompilerGenerated]
	internal static int EIJKLOLKDGI(Type KHLNABPIFEH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public struct GJDHADBJCJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public readonly PDFIMGDCOON EOLNLEBDDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public readonly string LDLEADGNOAK;

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x768A640", Offset = "0x7688E40", VA = "0x18768A640")]
	public GJDHADBJCJM(string FIBCDCMBMPN, PDFIMGDCOON EBNOLCJBELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x768A5A0", Offset = "0x7688DA0", VA = "0x18768A5A0")]
	public string KIFBPKFGNMN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public class JDBACAEAFMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private readonly IMIAAEOJJBO LMMHJOHBAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private string GPGEGKENJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private long? ACJEEHMFCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private long? OJMCPLNINDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private long? LKAKEHMCCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private string AINFJLNOMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private HGFPFMBGMGH OMJHACOOMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private long? ICCOJPIKFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private bool KEJAIPJBHBM;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public string PPGBPCEDMAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public long DFENNLPELBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x768ED20", Offset = "0x768D520", VA = "0x18768ED20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public long MGAFBNNKFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x768E090", Offset = "0x768C890", VA = "0x18768E090")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public long EFDLEBOKNND
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x768E0F0", Offset = "0x768C8F0", VA = "0x18768E0F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public string DILGJMKPIFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x768E050", Offset = "0x768C850", VA = "0x18768E050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public HGFPFMBGMGH OPKJIKLKDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x99C870", Offset = "0x99B070", VA = "0x18099C870")]
		get
		{
			return default(HGFPFMBGMGH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x768DF60", Offset = "0x768C760", VA = "0x18768DF60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public long OKAMPACGFFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x768ECC0", Offset = "0x768D4C0", VA = "0x18768ECC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x768ED80", Offset = "0x768D580", VA = "0x18768ED80")]
	[UnityEngine.Scripting.Preserve]
	public JDBACAEAFMP([NDCFMLCHJCI(null)] IMIAAEOJJBO LMMHJOHBAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x768E1F0", Offset = "0x768C9F0", VA = "0x18768E1F0")]
	private void IBMJDFGMEEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x768E440", Offset = "0x768CC40", VA = "0x18768E440")]
	public void IEKFBKNKDBJ(long NKDNOGOOODN, long ACPFGDPOKJK, [Optional] long? GAFPBFDFBJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x768E150", Offset = "0x768C950", VA = "0x18768E150")]
	public void GHJNHNPECNP(long GAFPBFDFBJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x768E8D0", Offset = "0x768D0D0", VA = "0x18768E8D0")]
	public void JCACGMKAAKI(string JBODGMCHKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x768E950", Offset = "0x768D150", VA = "0x18768E950")]
	public void JDIMEKJAMAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal class FKDGKIDPJEM : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct KONMHHOEMHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public AsyncTaskMethodBuilder<AACGOKBLDOD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public AACGOKBLDOD roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public FKDGKIDPJEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private TaskAwaiter<OKNDNPAECMD.AMCKGCKOINK<AACGOKBLDOD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x76AD8F0", Offset = "0x76AC0F0", VA = "0x1876AD8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x76ADE30", Offset = "0x76AC630", VA = "0x1876ADE30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct HEGEDKDLDPA<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class KAKPCKIKLDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public AACGOKBLDOD roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public KAKPCKIKLDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x76AD030", Offset = "0x76AB830", VA = "0x1876AD030")]
		internal AACGOKBLDOD CPENBAELEJJ(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct HMNBLIMBGOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public AsyncTaskMethodBuilder<OKNDNPAECMD.AMCKGCKOINK<AACGOKBLDOD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public AACGOKBLDOD roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public FKDGKIDPJEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private DOAEPDDPLFH <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private TaskAwaiter<OKNDNPAECMD.AMCKGCKOINK<AACGOKBLDOD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x76A8FE0", Offset = "0x76A77E0", VA = "0x1876A8FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x76A95F0", Offset = "0x76A7DF0", VA = "0x1876A95F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct MMAKJFKGFKM<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public FKDGKIDPJEM <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x49E7470", Offset = "0x49E5C70", VA = "0x1849E7470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x39CD7F0", Offset = "0x39CBFF0", VA = "0x1839CD7F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private struct CBMJGOKMNOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public FKDGKIDPJEM <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x76A1B40", Offset = "0x76A0340", VA = "0x1876A1B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x76A1D00", Offset = "0x76A0500", VA = "0x1876A1D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class MEKMCENAFLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public MEKMCENAFLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x76B0C50", Offset = "0x76AF450", VA = "0x1876B0C50")]
		internal object NOHGLGGDJKG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x76B0B90", Offset = "0x76AF390", VA = "0x1876B0B90")]
		internal bool HDBIDBMGFOD(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class EFHENOGENMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public EFHENOGENMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x76A4CB0", Offset = "0x76A34B0", VA = "0x1876A4CB0")]
		internal object LBDKJNMJKMH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class FMDKDJJIEHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public FMDKDJJIEHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x76A7D40", Offset = "0x76A6540", VA = "0x1876A7D40")]
		internal object MNANABNHLJE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class MDCBLDPDDBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public MDCBLDPDDBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x76B0430", Offset = "0x76AEC30", VA = "0x1876B0430")]
		internal object BOPNMMMOFBA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private sealed class BBFKLGPHKDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public FKDGKIDPJEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public BBFKLGPHKDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x769F1F0", Offset = "0x769D9F0", VA = "0x18769F1F0")]
		internal object FOGIJGNFPPE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private static readonly Guid CMMAHNHKIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public readonly CHAHCGOKNDN HCHCMAOFBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private readonly OKNDNPAECMD NMMOLHAHABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private readonly KNJEPKLFJIN GPBNDJAMPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private readonly OCOMJIKCDIE OKMOENKGMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private bool EOEFNMIMEKL;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x76A7B10", Offset = "0x76A6310", VA = "0x1876A7B10")]
	public FKDGKIDPJEM(CHAHCGOKNDN GFKCDNLMPGP, OKNDNPAECMD NMMOLHAHABE, KNJEPKLFJIN GPBNDJAMPKD, OCOMJIKCDIE OKMOENKGMHE, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x76A6C10", Offset = "0x76A5410", VA = "0x1876A6C10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x76A77F0", Offset = "0x76A5FF0", VA = "0x1876A77F0")]
	public void LBOMEGMFPDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x76A69F0", Offset = "0x76A51F0", VA = "0x1876A69F0")]
	public void BOKADFMOBON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x76A7580", Offset = "0x76A5D80", VA = "0x1876A7580")]
	public void IPNJPFKPOBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x76A7420", Offset = "0x76A5C20", VA = "0x1876A7420")]
	[AsyncStateMachine(typeof(KONMHHOEMHE))]
	internal Task<AACGOKBLDOD> HLKPNJJHLNH(NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, AACGOKBLDOD BAAPKBGGPBO, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x306A980", Offset = "0x3069180", VA = "0x18306A980")]
	private static byte[] HLGFDEDNHJD<T>(T PJFOMDHJLBF) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x306AC30", Offset = "0x3069430", VA = "0x18306AC30")]
	private static T OAIBEMFNMGB<T>(MessageParser<T> CIACFIEAMKE, byte[] PJFOMDHJLBF, T AFABMPLNPIA) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x76A6C20", Offset = "0x76A5420", VA = "0x1876A6C20")]
	[AsyncStateMachine(typeof(HMNBLIMBGOJ))]
	private Task<OKNDNPAECMD.AMCKGCKOINK<AACGOKBLDOD>> EBJNHFHLAGC(AACGOKBLDOD BAAPKBGGPBO, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x306A990", Offset = "0x3069190", VA = "0x18306A990")]
	[AsyncStateMachine(typeof(MMAKJFKGFKM<>))]
	internal Task<T> JGDNNGHIGEJ<T>(CancellationToken LCOCKEOACEA, Func<CancellationToken, Task<T>> KGJBJHAKPAM, int KNBLHAOKHPJ = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x76A76C0", Offset = "0x76A5EC0", VA = "0x1876A76C0")]
	[AsyncStateMachine(typeof(CBMJGOKMNOM))]
	internal Task JGDNNGHIGEJ(CancellationToken LCOCKEOACEA, Func<CancellationToken, Task> KGJBJHAKPAM, int KNBLHAOKHPJ = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x76A7640", Offset = "0x76A5E40", VA = "0x1876A7640")]
	public FLBBKMLMNJL JAOPOHLEIJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x76A7A20", Offset = "0x76A6220", VA = "0x1876A7A20")]
	public BPPDGMCJHJB PNJEJPBNNOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x76A6D60", Offset = "0x76A5560", VA = "0x1876A6D60")]
	public NODKLAGHLJH EJHENBBFOGG([Optional] FICDJCDJOAA? AGHKKLOENAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x76A71B0", Offset = "0x76A59B0", VA = "0x1876A71B0")]
	public void GMJNMOFPEGA(Func<Guid, bool> CDPEJJAMJHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x76A7910", Offset = "0x76A6110", VA = "0x1876A7910")]
	public void NNJOBHDIFNJ(Func<Guid, bool> NDGNOLGENOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x76A6EF0", Offset = "0x76A56F0", VA = "0x1876A6EF0")]
	public Guid GAIDMNGFOFA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x76A7310", Offset = "0x76A5B10", VA = "0x1876A7310")]
	public void HCEEIPKCAEL(Guid JPMHCNALEIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x76A7070", Offset = "0x76A5870", VA = "0x1876A7070")]
	public void GJOGKPIBAFI(AACGOKBLDOD BMPMIEBJLJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x76A6B00", Offset = "0x76A5300", VA = "0x1876A6B00")]
	public void CLLGOIEIHDM(string EHLNILBEENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x306A8A0", Offset = "0x30690A0", VA = "0x18306A8A0")]
	private T DKIEOIKHGEK<T>(T INDENPJBLHO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x76A6AB0", Offset = "0x76A52B0", VA = "0x1876A6AB0")]
	public void CIOEDHHOLDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x306A5F0", Offset = "0x3068DF0", VA = "0x18306A5F0")]
	[CompilerGenerated]
	internal static string CICHNKKCGEE<T>(byte[] LMGNHIJGDNP, int BOHJNNAGEEE, HEGEDKDLDPA<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal sealed class CEEOPMBBOHC : CHAHCGOKNDN
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private sealed class OBFCIOIOAEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public OBFCIOIOAEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x76B51C0", Offset = "0x76B39C0", VA = "0x1876B51C0")]
		internal object AKIKFAPLAOA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct MFEDMGDCJJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public CEEOPMBBOHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public FKDGKIDPJEM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private LNHHHAANBGA <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private BPPDGMCJHJB <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x76B0EB0", Offset = "0x76AF6B0", VA = "0x1876B0EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x76B1780", Offset = "0x76AFF80", VA = "0x1876B1780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private struct FEKOALMIHEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public CEEOPMBBOHC <>4__this;

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
		private TaskAwaiter<NIHPFEHJKNJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x76A54D0", Offset = "0x76A3CD0", VA = "0x1876A54D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x76A5C10", Offset = "0x76A4410", VA = "0x1876A5C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private struct FGBCKJLCAAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public CEEOPMBBOHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private TaskAwaiter<DJPINPOMHEF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x76A5C70", Offset = "0x76A4470", VA = "0x1876A5C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x76A5F80", Offset = "0x76A4780", VA = "0x1876A5F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class EDLEHOLAOFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public LNHHHAANBGA presence;

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public EDLEHOLAOFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x76A4B70", Offset = "0x76A3370", VA = "0x1876A4B70")]
		internal object OKBHGPIPAEB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	private static readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	private static readonly FICDJCDJOAA AMHJBMBJBLH;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	private static readonly FICDJCDJOAA KLHNLCIFKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000389")]
	private readonly MIPHOHMODEJ NIILFELPJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400038A")]
	private readonly DILBKEMEFHP FHBBBHDCOBB;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x76A2360", Offset = "0x76A0B60", VA = "0x1876A2360")]
	public CEEOPMBBOHC(MIPHOHMODEJ NIILFELPJIP, DILBKEMEFHP FHBBBHDCOBB, Guid PHACDDBECOP, PJDNBPNFOAH JCCNNNNOALN, BOJCINHMKKJ MNEPGNJOMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x76A2140", Offset = "0x76A0940", VA = "0x1876A2140", Slot = "7")]
	[AsyncStateMachine(typeof(MFEDMGDCJJC))]
	protected override Task PAPDAAJLFEE(FKDGKIDPJEM FLNHJMHABBE, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x76A1D60", Offset = "0x76A0560", VA = "0x1876A1D60")]
	[AsyncStateMachine(typeof(FEKOALMIHEJ))]
	private Task CDHJKFNAPAM(CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x76A1E60", Offset = "0x76A0660", VA = "0x1876A1E60")]
	[AsyncStateMachine(typeof(FGBCKJLCAAM))]
	private Task<int> DEMAPLHBIPH(CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x76A1F70", Offset = "0x76A0770", VA = "0x1876A1F70")]
	private LNHHHAANBGA GNDJEMBFAJD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal class KPKGNNDIFCN : CHAHCGOKNDN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private struct FIBOBAAPDEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public KPKGNNDIFCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public FKDGKIDPJEM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private TaskAwaiter<CNCFEBILFNP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x76A5FF0", Offset = "0x76A47F0", VA = "0x1876A5FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x76A6990", Offset = "0x76A5190", VA = "0x1876A6990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	private readonly int OPKDAEGJPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	private readonly JLLNKPIMHOC AAMKNFCFLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public readonly long FMJKOMLKOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public readonly long HELLELKCIFM;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public CNCFEBILFNP BOFHDOACGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x8BC0D0", Offset = "0x8BA8D0", VA = "0x1808BC0D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x8BBF90", Offset = "0x8BA790", VA = "0x1808BBF90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x76ADFC0", Offset = "0x76AC7C0", VA = "0x1876ADFC0")]
	public KPKGNNDIFCN(Guid PHACDDBECOP, PJDNBPNFOAH JCCNNNNOALN, BOJCINHMKKJ MNEPGNJOMJF, int OPKDAEGJPJM, JLLNKPIMHOC AAMKNFCFLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x76ADEA0", Offset = "0x76AC6A0", VA = "0x1876ADEA0", Slot = "7")]
	[AsyncStateMachine(typeof(FIBOBAAPDEG))]
	protected override Task PAPDAAJLFEE(FKDGKIDPJEM FLNHJMHABBE, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal abstract class CNPLDBHBGMP : CHAHCGOKNDN
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private sealed class HMOBACNANDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public CNPLDBHBGMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public EHNLBALKAFN playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public HMOBACNANDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x76A9660", Offset = "0x76A7E60", VA = "0x1876A9660")]
		internal Task HJHOAEALOJN(NGPFCPLNCNC<string>.PPCAKDHDCLK postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x76A96A0", Offset = "0x76A7EA0", VA = "0x1876A96A0")]
		internal object LLEEFBIJHMD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private struct IPKNBPHONNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public CNPLDBHBGMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public FKDGKIDPJEM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private HMOBACNANDB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x76AAF50", Offset = "0x76A9750", VA = "0x1876AAF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x76AB710", Offset = "0x76A9F10", VA = "0x1876AB710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private struct FEJPPAFKDOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public EHNLBALKAFN playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public CNPLDBHBGMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x76A4ED0", Offset = "0x76A36D0", VA = "0x1876A4ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x76A5470", Offset = "0x76A3C70", VA = "0x1876A5470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x76A4B20", Offset = "0x76A3320", VA = "0x1876A4B20")]
	public CNPLDBHBGMP(Guid PHACDDBECOP, PJDNBPNFOAH JCCNNNNOALN, BOJCINHMKKJ MNEPGNJOMJF, string GMGNFGFAOCJ, CCHDDALCCNH CAKEPGIDGEO, bool FKKOALMIIFP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x76A49E0", Offset = "0x76A31E0", VA = "0x1876A49E0", Slot = "7")]
	[AsyncStateMachine(typeof(IPKNBPHONNJ))]
	protected override Task PAPDAAJLFEE(FKDGKIDPJEM FLNHJMHABBE, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task KFHPMMIKHOC(FKDGKIDPJEM FLNHJMHABBE, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x76A48A0", Offset = "0x76A30A0", VA = "0x1876A48A0")]
	[AsyncStateMachine(typeof(FEJPPAFKDOJ))]
	private Task LGBEOBGEMGG(IDisposable IAGCKEAIOGP, EHNLBALKAFN OJFJGPFHPPG, NGPFCPLNCNC<string>.PPCAKDHDCLK IEGOAOCEEPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
internal class AKOPKFKKHCD : CHAHCGOKNDN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct MDJIJFAENDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public AKOPKFKKHCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public FKDGKIDPJEM operationContext;

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
		private TaskAwaiter<MLONKGHJMMO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x76B04A0", Offset = "0x76AECA0", VA = "0x1876B04A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x76B0A10", Offset = "0x76AF210", VA = "0x1876B0A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	private readonly GIAKNOPIGAP LGKPGNPIEMH;

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x769F150", Offset = "0x769D950", VA = "0x18769F150")]
	public AKOPKFKKHCD(Guid PHACDDBECOP, PJDNBPNFOAH JCCNNNNOALN, BOJCINHMKKJ MNEPGNJOMJF, GIAKNOPIGAP LGKPGNPIEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x769EF50", Offset = "0x769D750", VA = "0x18769EF50", Slot = "6")]
	protected override string JJFEBCBAKME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x769F030", Offset = "0x769D830", VA = "0x18769F030", Slot = "7")]
	[AsyncStateMachine(typeof(MDJIJFAENDH))]
	protected override Task PAPDAAJLFEE(FKDGKIDPJEM FLNHJMHABBE, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
internal abstract class CHAHCGOKNDN : CIFIJBDIPIG
{
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	public delegate Task LPICCHIMIBE(NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class JCBEHHPNMDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public CHAHCGOKNDN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public JCBEHHPNMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x76ABCE0", Offset = "0x76AA4E0", VA = "0x1876ABCE0")]
		internal Task IOFLOFJMOFP(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private sealed class NHGAPJMJOJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public JCBEHHPNMDG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public NHGAPJMJOJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x76B4A60", Offset = "0x76B3260", VA = "0x1876B4A60")]
		internal object DPLNPLJIADP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct JPBMPIGGCJI : IAsyncStateMachine
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
		public CHAHCGOKNDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public Func<CHAHCGOKNDN, NGPFCPLNCNC<string>.PPCAKDHDCLK, FKDGKIDPJEM> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private JCBEHHPNMDG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private FKDGKIDPJEM <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private TaskAwaiter<AACGOKBLDOD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x76ABE10", Offset = "0x76AA610", VA = "0x1876ABE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x76ACFD0", Offset = "0x76AB7D0", VA = "0x1876ACFD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct BPEBOBKPIFP : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x769F4B0", Offset = "0x769DCB0", VA = "0x18769F4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x769FF50", Offset = "0x769E750", VA = "0x18769FF50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private struct MGJFFEBEDGA : IAsyncStateMachine
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
		public CHAHCGOKNDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x76B17E0", Offset = "0x76AFFE0", VA = "0x1876B17E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x76B1B40", Offset = "0x76B0340", VA = "0x1876B1B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public readonly Guid PBIELHOLMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public readonly ByteString HPOMHBMPCKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public readonly BOJCINHMKKJ IHLIHJAEFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	protected readonly string FHEJICBIGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private readonly PJDNBPNFOAH JCCNNNNOALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	private readonly bool FKKOALMIIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private readonly Queue<LPICCHIMIBE> GEGGKPOBCPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private readonly KFOEIFPHEMO MHDKPOPFFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private readonly CCHDDALCCNH CAKEPGIDGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private bool LFNCBEDGCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public HGFPFMBGMGH DGBAOPFCDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public HGFPFMBGMGH BHNEBONDPAK;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public PJDNBPNFOAH ABPCOLDFHJP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x8BB260", Offset = "0x8B9A60", VA = "0x1808BB260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public PCCBFICHMFB KOJHMMMMDLE
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x76A2EA0", Offset = "0x76A16A0", VA = "0x1876A2EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public DLHLIBLDHEL CBPIDHGFGIN
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x76A2BA0", Offset = "0x76A13A0", VA = "0x1876A2BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public ODFFNGGOBDA PIDJECIHDLH
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x76A2B20", Offset = "0x76A1320", VA = "0x1876A2B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event AJDCEPFFECP LLDDOJBPBHK
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x76A2840", Offset = "0x76A1040", VA = "0x1876A2840", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x76A3020", Offset = "0x76A1820", VA = "0x1876A3020", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x76A3040", Offset = "0x76A1840", VA = "0x1876A3040")]
	protected CHAHCGOKNDN(Guid PHACDDBECOP, PJDNBPNFOAH JCCNNNNOALN, BOJCINHMKKJ MNEPGNJOMJF, string GMGNFGFAOCJ, CCHDDALCCNH CAKEPGIDGEO, bool FKKOALMIIFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x76A2880", Offset = "0x76A1080", VA = "0x1876A2880", Slot = "6")]
	protected virtual string JJFEBCBAKME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x76A27E0", Offset = "0x76A0FE0", VA = "0x1876A27E0")]
	public void DDDNAKFKKFJ(LPICCHIMIBE KHJDBHICGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x76A2860", Offset = "0x76A1060", VA = "0x1876A2860")]
	protected void IBCNCIJLBCA(float DOCBAALINAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x76A2610", Offset = "0x76A0E10", VA = "0x1876A2610")]
	[AsyncStateMachine(typeof(JPBMPIGGCJI))]
	public Task BDBMLJNBAHE(CancellationToken ALKEMFHOMCA, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, [Optional] Func<CHAHCGOKNDN, NGPFCPLNCNC<string>.PPCAKDHDCLK, FKDGKIDPJEM> IKCJCCKMJEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x76A2EF0", Offset = "0x76A16F0", VA = "0x1876A2EF0")]
	[AsyncStateMachine(typeof(BPEBOBKPIFP))]
	private static Task ONIKOEFKCOA(Func<CancellationToken, Task> HHHEAKJEOOC, Func<CancellationToken, Task> IHFMFDIDAND, CancellationToken LCOCKEOACEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x76A28C0", Offset = "0x76A10C0", VA = "0x1876A28C0")]
	private void KHCFJOLAIKN(bool ANJHFABIGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x76A2C70", Offset = "0x76A1470", VA = "0x1876A2C70")]
	private void NBLJFJKENOC(FKDGKIDPJEM FLNHJMHABBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task PAPDAAJLFEE(FKDGKIDPJEM FLNHJMHABBE, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA);

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x76A24F0", Offset = "0x76A0CF0", VA = "0x1876A24F0")]
	[AsyncStateMachine(typeof(MGJFFEBEDGA))]
	private Task BCHKNLGAAGI(NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x76A2BF0", Offset = "0x76A13F0", VA = "0x1876A2BF0")]
	public AACGOKBLDOD MDEOBIHBMDG(DOAEPDDPLFH APLGMNHMENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x76A2A30", Offset = "0x76A1230", VA = "0x1876A2A30")]
	[CompilerGenerated]
	private Task KHGIMGEHKAA(CancellationToken EBDGHJJPDEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x76A2760", Offset = "0x76A0F60", VA = "0x1876A2760")]
	[CompilerGenerated]
	private object DCJHEGFPIBL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
internal sealed class GDBALLFHBDL : CNPLDBHBGMP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct HHINONLEAKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public GDBALLFHBDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public FKDGKIDPJEM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private BIBPMJIGLBK <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private BPPDGMCJHJB <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x76A8820", Offset = "0x76A7020", VA = "0x1876A8820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x76A8F80", Offset = "0x76A7780", VA = "0x1876A8F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	private readonly MIPHOHMODEJ DPEPJNKBEGE;

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x76A7F00", Offset = "0x76A6700", VA = "0x1876A7F00")]
	public GDBALLFHBDL(Guid PHACDDBECOP, PJDNBPNFOAH JCCNNNNOALN, MIPHOHMODEJ DPEPJNKBEGE, BOJCINHMKKJ MNEPGNJOMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x76A7DB0", Offset = "0x76A65B0", VA = "0x1876A7DB0", Slot = "8")]
	[AsyncStateMachine(typeof(HHINONLEAKG))]
	protected override Task KFHPMMIKHOC(FKDGKIDPJEM FLNHJMHABBE, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal class FAFIIFFKFOJ : CHAHCGOKNDN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private struct IGMIABPJDPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public FAFIIFFKFOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public FKDGKIDPJEM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		private TaskAwaiter<MLONKGHJMMO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x76A9730", Offset = "0x76A7F30", VA = "0x1876A9730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x76A9AE0", Offset = "0x76A82E0", VA = "0x1876A9AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private readonly string EBNPKEEFCLC;

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x76A4E20", Offset = "0x76A3620", VA = "0x1876A4E20")]
	public FAFIIFFKFOJ(Guid PHACDDBECOP, PJDNBPNFOAH JCCNNNNOALN, BOJCINHMKKJ MNEPGNJOMJF, string EBNPKEEFCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x76A4D10", Offset = "0x76A3510", VA = "0x1876A4D10", Slot = "7")]
	[AsyncStateMachine(typeof(IGMIABPJDPH))]
	protected override Task PAPDAAJLFEE(FKDGKIDPJEM FLNHJMHABBE, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal class IPOIKCEOJMP : CNPLDBHBGMP
{
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private sealed class MDJJHDIMOHD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000119")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			public AsyncTaskMethodBuilder<AACGOKBLDOD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			public MDJJHDIMOHD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400041B")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400041C")]
			private TaskAwaiter<MLONKGHJMMO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400041D")]
			private TaskAwaiter<AACGOKBLDOD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004D7")]
			[Cpp2IlInjected.Address(RVA = "0x76B7F30", Offset = "0x76B6730", VA = "0x1876B7F30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x76B83F0", Offset = "0x76B6BF0", VA = "0x1876B83F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public IPOIKCEOJMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public NODKLAGHLJH serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public PAMKGMCHOGJ roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public FLBBKMLMNJL uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public GKBBLKJMHOG roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public MDJJHDIMOHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x76B0A70", Offset = "0x76AF270", VA = "0x1876B0A70")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<AACGOKBLDOD> CFIJGHKNFHJ(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct LKBJHJOGIIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public IPOIKCEOJMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public FKDGKIDPJEM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private MDJJHDIMOHD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private BIBPMJIGLBK <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private BPPDGMCJHJB <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private AACGOKBLDOD <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private TaskAwaiter<AACGOKBLDOD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x76AE9B0", Offset = "0x76AD1B0", VA = "0x1876AE9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x76AF920", Offset = "0x76AE120", VA = "0x1876AF920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private static readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	private static readonly FICDJCDJOAA AMHJBMBJBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	private readonly int PFEIMHABCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	[CanBeNull]
	private readonly DBPAABODFCN AIIKBOENKFJ;

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x76ABC30", Offset = "0x76AA430", VA = "0x1876ABC30")]
	public IPOIKCEOJMP(Guid PHACDDBECOP, PJDNBPNFOAH JCCNNNNOALN, int PFEIMHABCDO, DBPAABODFCN AIIKBOENKFJ, BOJCINHMKKJ MNEPGNJOMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x76ABA40", Offset = "0x76AA240", VA = "0x1876ABA40", Slot = "8")]
	[AsyncStateMachine(typeof(LKBJHJOGIIE))]
	protected override Task KFHPMMIKHOC(FKDGKIDPJEM FLNHJMHABBE, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x76AB940", Offset = "0x76AA140", VA = "0x1876AB940")]
	private void HJNMICANOIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x76AB770", Offset = "0x76A9F70", VA = "0x1876AB770")]
	private void HDNAGLPKALN(NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, BIBPMJIGLBK AKOGEPKEAPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal abstract class GOBCFIPLILF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public readonly CHAHCGOKNDN HCHCMAOFBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public readonly FKDGKIDPJEM OMMLBEIOHLE;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public PCCBFICHMFB KOJHMMMMDLE
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x76A8160", Offset = "0x76A6960", VA = "0x1876A8160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public ODFFNGGOBDA PIDJECIHDLH
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x76A80D0", Offset = "0x76A68D0", VA = "0x1876A80D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x76A81B0", Offset = "0x76A69B0", VA = "0x1876A81B0")]
	protected GOBCFIPLILF(FKDGKIDPJEM FLNHJMHABBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x76A7FB0", Offset = "0x76A67B0", VA = "0x1876A7FB0")]
	protected void CLLGOIEIHDM(string EHLNILBEENL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal struct HHEECEHLBPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public Dictionary<Guid, List<FBIGDOKFDJI>> BHNIKNBBGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public Dictionary<Guid, List<FBIGDOKFDJI>> CPCEOEJGBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public Dictionary<Guid, List<FBIGDOKFDJI>> PDPFLJANOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public List<Guid> OLOMPLPFDGK;

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x76A8210", Offset = "0x76A6A10", VA = "0x1876A8210")]
	public static HHEECEHLBPE EFGCOGNKKLM(PCCBFICHMFB BIJBPNIFOLE, HGFPFMBGMGH JJMCEIBOMEI, DLBOGIKOAJL ILANIBJGLFP)
	{
		return default(HHEECEHLBPE);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal struct INOHFEDJIDI
{
	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830")]
	public static INOHFEDJIDI JHEOKMMJDLF()
	{
		return default(INOHFEDJIDI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal struct BCEEGFPKODB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public readonly NIHPFEHJKNJ GKCMIIJJFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public readonly IPKCPHEECFE KLMBMCENJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public readonly string LMNFKMPPOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public readonly AMBENGOMJIK MLNPIEGNENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public readonly AMBENGOMJIK DIHDJINLOMA;

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x769F430", Offset = "0x769DC30", VA = "0x18769F430")]
	public BCEEGFPKODB(NIHPFEHJKNJ GKCMIIJJFKC, IPKCPHEECFE KLMBMCENJFC, string LMNFKMPPOHE, AMBENGOMJIK MLNPIEGNENI, AMBENGOMJIK DIHDJINLOMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal struct LKIKGIOHEMJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	private readonly FKDGKIDPJEM FLNHJMHABBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private readonly Guid JPMHCNALEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private bool ANJHFABIGJN;

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x76AF990", Offset = "0x76AE190", VA = "0x1876AF990")]
	public static LKIKGIOHEMJ GAIDMNGFOFA(FKDGKIDPJEM FLNHJMHABBE)
	{
		return default(LKIKGIOHEMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0xD718F0", Offset = "0xD700F0", VA = "0x180D718F0")]
	public void GEJHDKOPDLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x76AF980", Offset = "0x76AE180", VA = "0x1876AF980", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x76AFCA0", Offset = "0x76AE4A0", VA = "0x1876AFCA0")]
	private LKIKGIOHEMJ(FKDGKIDPJEM FLNHJMHABBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x76AF9C0", Offset = "0x76AE1C0", VA = "0x1876AF9C0")]
	private void HCEEIPKCAEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x76AFC00", Offset = "0x76AE400", VA = "0x1876AFC00")]
	private Func<Guid, bool> NGAOCNIMKPA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal class BPPDGMCJHJB : GOBCFIPLILF, CIFIJBDIPIG
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	public delegate Task<HGFPFMBGMGH> IOEOJPLCNBA(DLBOGIKOAJL EBNFOODJNOB, CEJHHODJMIO DNMCALMOAMP, KFOEIFPHEMO FFGHGNPMJLM, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct KLDKOEEJCDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public BPPDGMCJHJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public MIPHOHMODEJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		private LKIKGIOHEMJ <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		private TaskAwaiter<AACGOKBLDOD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x76AD110", Offset = "0x76AB910", VA = "0x1876AD110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x76AD890", Offset = "0x76AC090", VA = "0x1876AD890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct MADDJOACDHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public AsyncTaskMethodBuilder<AACGOKBLDOD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public BPPDGMCJHJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public MIPHOHMODEJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		private TaskAwaiter<AACGOKBLDOD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x76AFF90", Offset = "0x76AE790", VA = "0x1876AFF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x76B03C0", Offset = "0x76AEBC0", VA = "0x1876B03C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct NNMMHFDKCOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public BPPDGMCJHJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public MIPHOHMODEJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x76B4B20", Offset = "0x76B3320", VA = "0x1876B4B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x76B5160", Offset = "0x76B3960", VA = "0x1876B5160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private sealed class OBLDJDBMNFB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000127")]
		private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			public AsyncTaskMethodBuilder<BCEEGFPKODB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			public OBLDJDBMNFB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			private BCEEGFPKODB <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			private TaskAwaiter<HGFPFMBGMGH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			private TaskAwaiter<BCEEGFPKODB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600051D")]
			[Cpp2IlInjected.Address(RVA = "0x76B6A20", Offset = "0x76B5220", VA = "0x1876B6A20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051E")]
			[Cpp2IlInjected.Address(RVA = "0x76B7180", Offset = "0x76B5980", VA = "0x1876B7180", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			public AsyncTaskMethodBuilder<DLBOGIKOAJL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			public OBLDJDBMNFB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			private DLBOGIKOAJL <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000470")]
			private TaskAwaiter<HGFPFMBGMGH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000471")]
			private TaskAwaiter<DLBOGIKOAJL> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600051F")]
			[Cpp2IlInjected.Address(RVA = "0x76B71F0", Offset = "0x76B59F0", VA = "0x1876B71F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(RVA = "0x76B7820", Offset = "0x76B6020", VA = "0x1876B7820", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public BPPDGMCJHJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public MIPHOHMODEJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public KFOEIFPHEMO preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public KFOEIFPHEMO downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public BCEEGFPKODB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public KFOEIFPHEMO postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public DLBOGIKOAJL phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public DHIIJCJNKOE.IPCJAFIALIC <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public OBLDJDBMNFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x76B5650", Offset = "0x76B3E50", VA = "0x1876B5650")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<BCEEGFPKODB> KPHACJOIOJM(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x76B5230", Offset = "0x76B3A30", VA = "0x1876B5230")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<DLBOGIKOAJL> GHEPCOEOGAN(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x76B54B0", Offset = "0x76B3CB0", VA = "0x1876B54B0")]
		internal void HNBGCLJEDGI(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x76B5350", Offset = "0x76B3B50", VA = "0x1876B5350")]
		internal Task HCJDDPHPFJD(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x76B54F0", Offset = "0x76B3CF0", VA = "0x1876B54F0")]
		internal Task HOGIDGEBOBF(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct MHCAPGNJIME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public BPPDGMCJHJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public MIPHOHMODEJ request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private OBLDJDBMNFB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private TaskAwaiter<BCEEGFPKODB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private TaskAwaiter<DLBOGIKOAJL> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x76B1BA0", Offset = "0x76B03A0", VA = "0x1876B1BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x76B28F0", Offset = "0x76B10F0", VA = "0x1876B28F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct PLFFCAEGAPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public BPPDGMCJHJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public DLBOGIKOAJL phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public KFOEIFPHEMO postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private TaskAwaiter<HGFPFMBGMGH> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private CEJHHODJMIO <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x76B5B30", Offset = "0x76B4330", VA = "0x1876B5B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x76B69C0", Offset = "0x76B51C0", VA = "0x1876B69C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct ILNDDBPGPMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public BPPDGMCJHJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x76AA530", Offset = "0x76A8D30", VA = "0x1876AA530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x76AADF0", Offset = "0x76A95F0", VA = "0x1876AADF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct IJNLBLBFBLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public BPPDGMCJHJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public DLBOGIKOAJL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public KFOEIFPHEMO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private TaskAwaiter<HGFPFMBGMGH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x76A9B40", Offset = "0x76A8340", VA = "0x1876A9B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x76AA4D0", Offset = "0x76A8CD0", VA = "0x1876AA4D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct MOPKOFIONOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public AsyncTaskMethodBuilder<HGFPFMBGMGH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public BPPDGMCJHJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public DLBOGIKOAJL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public KFOEIFPHEMO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private TaskAwaiter<HGFPFMBGMGH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x76B2950", Offset = "0x76B1150", VA = "0x1876B2950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x76B3B00", Offset = "0x76B2300", VA = "0x1876B3B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct CNLMLPAKHEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public AsyncTaskMethodBuilder<HGFPFMBGMGH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public BPPDGMCJHJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public DLBOGIKOAJL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public KFOEIFPHEMO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public CEJHHODJMIO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private TaskAwaiter<HGFPFMBGMGH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x76A3730", Offset = "0x76A1F30", VA = "0x1876A3730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x76A4830", Offset = "0x76A3030", VA = "0x1876A4830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct LBBGGLLCAJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public AsyncTaskMethodBuilder<HGFPFMBGMGH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public BPPDGMCJHJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public HGFPFMBGMGH operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public KFOEIFPHEMO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public DLBOGIKOAJL deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private TaskAwaiter<HGFPFMBGMGH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x76AE0F0", Offset = "0x76AC8F0", VA = "0x1876AE0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x76AE390", Offset = "0x76ACB90", VA = "0x1876AE390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private sealed class PHFJFIDOJKL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000132")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004C2")]
			public AsyncTaskMethodBuilder<HGFPFMBGMGH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004C3")]
			public PHFJFIDOJKL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004C4")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C5")]
			private DGPGECBENMI <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004C6")]
			private TaskAwaiter<HGFPFMBGMGH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000537")]
			[Cpp2IlInjected.Address(RVA = "0x76B7890", Offset = "0x76B6090", VA = "0x1876B7890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000538")]
			[Cpp2IlInjected.Address(RVA = "0x76B7EC0", Offset = "0x76B66C0", VA = "0x1876B7EC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public BPPDGMCJHJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public DLBOGIKOAJL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public KFOEIFPHEMO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public IOEOJPLCNBA masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public CEJHHODJMIO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public HGFPFMBGMGH originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public PHFJFIDOJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x76B5A10", Offset = "0x76B4210", VA = "0x1876B5A10")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<HGFPFMBGMGH> CCBJFKGJFHA(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct CHNGJFEFABB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public AsyncTaskMethodBuilder<HGFPFMBGMGH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public BPPDGMCJHJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public DLBOGIKOAJL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public KFOEIFPHEMO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public IOEOJPLCNBA masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public CEJHHODJMIO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private DGPGECBENMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private TaskAwaiter<HGFPFMBGMGH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x76A31A0", Offset = "0x76A19A0", VA = "0x1876A31A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x76A36C0", Offset = "0x76A1EC0", VA = "0x1876A36C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct LCPGOFODLGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public BPPDGMCJHJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public DLBOGIKOAJL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public KFOEIFPHEMO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private HGFPFMBGMGH <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private IEnumerator<HGFPFMBGMGH> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private TaskAwaiter<HGFPFMBGMGH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x76AE400", Offset = "0x76ACC00", VA = "0x1876AE400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x76AE950", Offset = "0x76AD150", VA = "0x1876AE950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct PGMOJBMGBJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public BPPDGMCJHJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public DLBOGIKOAJL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x76B5790", Offset = "0x76B3F90", VA = "0x1876B5790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x76B59B0", Offset = "0x76B41B0", VA = "0x1876B59B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct MENHJFMHMLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public BPPDGMCJHJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public DLBOGIKOAJL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x76B0CB0", Offset = "0x76AF4B0", VA = "0x1876B0CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x76B0E50", Offset = "0x76AF650", VA = "0x1876B0E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct NGMEJKHCODH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public BPPDGMCJHJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public DLBOGIKOAJL phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public KFOEIFPHEMO postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private TaskAwaiter<HGFPFMBGMGH> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private CEJHHODJMIO <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x76B3B70", Offset = "0x76B2370", VA = "0x1876B3B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x76B4A00", Offset = "0x76B3200", VA = "0x1876B4A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private struct MIMEKINBLPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public AsyncTaskMethodBuilder<HGFPFMBGMGH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public BPPDGMCJHJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public DLBOGIKOAJL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public KFOEIFPHEMO progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		private TaskAwaiter<HGFPFMBGMGH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x76CB370", Offset = "0x76C9B70", VA = "0x1876CB370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x76CC070", Offset = "0x76CA870", VA = "0x1876CC070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private readonly DEAMBOJPKEE AHPACHHBEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	private readonly DEAMBOJPKEE LLJBFCPIHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	private readonly JDBACAEAFMP HCLBDKOEIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private readonly ENCNGMMBGIH GGGJMCAFAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	private readonly ABJGFDPFAJH NLFCGKKLOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000440")]
	private ProfilerCounterValue<int> DCOBGPJGBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000441")]
	private readonly EGEKMEJJJIB CEECHGABLGG;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private PJDNBPNFOAH ABPCOLDFHJP
	{
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x76A1140", Offset = "0x769F940", VA = "0x1876A1140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event AJDCEPFFECP LLDDOJBPBHK
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x76A0BB0", Offset = "0x769F3B0", VA = "0x1876A0BB0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x76A1770", Offset = "0x769FF70", VA = "0x1876A1770", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x76A1880", Offset = "0x76A0080", VA = "0x1876A1880")]
	public BPPDGMCJHJB(FKDGKIDPJEM FLNHJMHABBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x76A0E30", Offset = "0x769F630", VA = "0x1876A0E30")]
	[AsyncStateMachine(typeof(KLDKOEEJCDI))]
	public Task JPDDKKJINDC(MIPHOHMODEJ BPCGMGBPPCA, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x76A0900", Offset = "0x769F100", VA = "0x1876A0900")]
	[AsyncStateMachine(typeof(MADDJOACDHC))]
	private Task<AACGOKBLDOD> HIGMCGDICEF(MIPHOHMODEJ BPCGMGBPPCA, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x76A0460", Offset = "0x769EC60", VA = "0x1876A0460")]
	[AsyncStateMachine(typeof(NNMMHFDKCOK))]
	private Task ENBAEKNAING(MIPHOHMODEJ BPCGMGBPPCA, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x76A01E0", Offset = "0x769E9E0", VA = "0x1876A01E0")]
	[AsyncStateMachine(typeof(MHCAPGNJIME))]
	private Task BFPNCOEHGFC(MIPHOHMODEJ BPCGMGBPPCA, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken BOAJAJJBGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x76A07B0", Offset = "0x769EFB0", VA = "0x1876A07B0")]
	[AsyncStateMachine(typeof(PLFFCAEGAPP))]
	private Task HEFHLEKPJNF(DLBOGIKOAJL AAPIJDFJHFC, KFOEIFPHEMO FMGBFPGGENE, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken NJHALMHCBJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x76A0BD0", Offset = "0x769F3D0", VA = "0x1876A0BD0")]
	[AsyncStateMachine(typeof(ILNDDBPGPMI))]
	private Task IFNLMNMPKIJ(NGPFCPLNCNC<string>.PPCAKDHDCLK IEGOAOCEEPG, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x76A0CE0", Offset = "0x769F4E0", VA = "0x1876A0CE0")]
	[AsyncStateMachine(typeof(IJNLBLBFBLF))]
	private Task JOLFIAMLNDO(DLBOGIKOAJL EBNFOODJNOB, KFOEIFPHEMO FFGHGNPMJLM, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x76A1610", Offset = "0x769FE10", VA = "0x1876A1610")]
	[AsyncStateMachine(typeof(MOPKOFIONOG))]
	private Task<HGFPFMBGMGH> OKPJGAENHDH(DLBOGIKOAJL EBNFOODJNOB, CEJHHODJMIO HEGNNFDIIGH, KFOEIFPHEMO FFGHGNPMJLM, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x76A1340", Offset = "0x769FB40", VA = "0x1876A1340")]
	[AsyncStateMachine(typeof(CNLMLPAKHEE))]
	private Task<HGFPFMBGMGH> NJJFLCEAIAC(DLBOGIKOAJL EBNFOODJNOB, CEJHHODJMIO HEGNNFDIIGH, KFOEIFPHEMO FFGHGNPMJLM, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x76A1170", Offset = "0x769F970", VA = "0x1876A1170")]
	[AsyncStateMachine(typeof(LBBGGLLCAJA))]
	private Task<HGFPFMBGMGH> MLPICMFJJLB(HGFPFMBGMGH JJMCEIBOMEI, DLBOGIKOAJL ILANIBJGLFP, KFOEIFPHEMO FFGHGNPMJLM, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA, bool DPCODFCFPNE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x76A1790", Offset = "0x769FF90", VA = "0x1876A1790")]
	private bool PPFGPDKBBII(DLBOGIKOAJL AAPIJDFJHFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x769FFF0", Offset = "0x769E7F0", VA = "0x18769FFF0")]
	[AsyncStateMachine(typeof(CHNGJFEFABB))]
	protected Task<HGFPFMBGMGH> ACPIODAFOIO(DLBOGIKOAJL EBNFOODJNOB, CEJHHODJMIO HEGNNFDIIGH, KFOEIFPHEMO FFGHGNPMJLM, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA, IOEOJPLCNBA CEINOMDDEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x76A0A60", Offset = "0x769F260", VA = "0x1876A0A60")]
	[AsyncStateMachine(typeof(LCPGOFODLGE))]
	private Task HNIPOAAJKEC(DLBOGIKOAJL EBNFOODJNOB, KFOEIFPHEMO FFGHGNPMJLM, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x76A05E0", Offset = "0x769EDE0", VA = "0x1876A05E0")]
	private void FDKNAGAONIA(HGFPFMBGMGH JNOINOFDBFE, KFOEIFPHEMO FFGHGNPMJLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x76A05A0", Offset = "0x769EDA0", VA = "0x1876A05A0")]
	private void FALABIBCGMO(HGFPFMBGMGH CHPJLOBLLFH, [Out] HGFPFMBGMGH MLGFGGJLKOA, [Out] HGFPFMBGMGH KEJCFNOIILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x769FFB0", Offset = "0x769E7B0", VA = "0x18769FFB0")]
	private Task<BCEEGFPKODB> ABDBEANKNCM(MIPHOHMODEJ BPCGMGBPPCA, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x76A1300", Offset = "0x769FB00", VA = "0x1876A1300")]
	private Task<DLBOGIKOAJL> NDGOKMMNGIK(BCEEGFPKODB EBNFOODJNOB, DHIIJCJNKOE.IPCJAFIALIC PNAAKKBFDEP, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x76A0FF0", Offset = "0x769F7F0", VA = "0x1876A0FF0")]
	[AsyncStateMachine(typeof(PGMOJBMGBJM))]
	private Task MDPMKECKIHB(DLBOGIKOAJL EBNFOODJNOB, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA, bool MLNDGCMJHEC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x76A0350", Offset = "0x769EB50", VA = "0x1876A0350")]
	[AsyncStateMachine(typeof(MENHJFMHMLB))]
	private Task COCGLOBNNDI(DLBOGIKOAJL EBNFOODJNOB, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x76A0320", Offset = "0x769EB20", VA = "0x1876A0320")]
	private Task CNGOJMFAGPB(DLBOGIKOAJL EBNFOODJNOB, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x76A01A0", Offset = "0x769E9A0", VA = "0x1876A01A0")]
	private Task AKMGBJGDLHF(DLBOGIKOAJL EBNFOODJNOB, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x76A01C0", Offset = "0x769E9C0", VA = "0x1876A01C0")]
	private Task BAAOCIGCGHC(DLBOGIKOAJL EBNFOODJNOB, CEJHHODJMIO HEGNNFDIIGH, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x76A0440", Offset = "0x769EC40", VA = "0x1876A0440")]
	private Task DIFGNFEALOA(DLBOGIKOAJL EBNFOODJNOB, CEJHHODJMIO HEGNNFDIIGH, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x76A12F0", Offset = "0x769FAF0", VA = "0x1876A12F0")]
	private static Task NBICDMIJKAG(CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x76A0FD0", Offset = "0x769F7D0", VA = "0x1876A0FD0")]
	private Task KLMGOEAPDCI(DLBOGIKOAJL EBNFOODJNOB, CEJHHODJMIO HEGNNFDIIGH, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x76A0630", Offset = "0x769EE30", VA = "0x1876A0630")]
	private Task FHKPGCDLOEL(DLBOGIKOAJL EBNFOODJNOB, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x76A0F80", Offset = "0x769F780", VA = "0x1876A0F80")]
	private void KJAIIKEDEIE(MIPHOHMODEJ BPCGMGBPPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x76A0180", Offset = "0x769E980", VA = "0x1876A0180")]
	public void ADHIEOFFJDL(long GAFPBFDFBJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0")]
	private static void ANMECJOBKKF(NIHPFEHJKNJ GKCMIIJJFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x76A14C0", Offset = "0x769FCC0", VA = "0x1876A14C0")]
	[AsyncStateMachine(typeof(NGMEJKHCODH))]
	private Task OFLLOKMOBJF(DLBOGIKOAJL AAPIJDFJHFC, KFOEIFPHEMO FMGBFPGGENE, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken NJHALMHCBJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x76A0650", Offset = "0x769EE50", VA = "0x1876A0650")]
	[AsyncStateMachine(typeof(MIMEKINBLPL))]
	[CompilerGenerated]
	private Task<HGFPFMBGMGH> GFOMLGOEMML(DLBOGIKOAJL EBNFOODJNOB, CEJHHODJMIO HEGNNFDIIGH, KFOEIFPHEMO FFGHGNPMJLM, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct KKGKIOEDCDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private PJDNBPNFOAH JCCNNNNOALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private DLBOGIKOAJL EBNFOODJNOB;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private PCCBFICHMFB KOJHMMMMDLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x76C9610", Offset = "0x76C7E10", VA = "0x1876C9610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x76C9320", Offset = "0x76C7B20", VA = "0x1876C9320")]
	public static Task BDBMLJNBAHE(PJDNBPNFOAH JCCNNNNOALN, DLBOGIKOAJL EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x76C9400", Offset = "0x76C7C00", VA = "0x1876C9400")]
	private void BDBMLJNBAHE()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct JNGMHBNDCKH
{
	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x76C8EC0", Offset = "0x76C76C0", VA = "0x1876C8EC0")]
	public static Task BDBMLJNBAHE(CancellationToken ALKEMFHOMCA)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct JIOADFLCNIA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct MHHFDOKFMDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public FKDGKIDPJEM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public DLBOGIKOAJL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private DGPGECBENMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x76CAA50", Offset = "0x76C9250", VA = "0x1876CAA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x76CAF80", Offset = "0x76C9780", VA = "0x1876CAF80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x76C8690", Offset = "0x76C6E90", VA = "0x1876C8690")]
	[AsyncStateMachine(typeof(MHHFDOKFMDG))]
	public static Task BDBMLJNBAHE(FKDGKIDPJEM FLNHJMHABBE, DLBOGIKOAJL EBNFOODJNOB, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013D")]
internal struct JHJOJBKKAEK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct PCPMNKNFJEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public FKDGKIDPJEM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public DLBOGIKOAJL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public CEJHHODJMIO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private HGFPFMBGMGH <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private PJDNBPNFOAH <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private PCCBFICHMFB <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private DGPGECBENMI <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private List<(PersistenceView, MAAAODAGNHE)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		private MAAAODAGNHE <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x76D05E0", Offset = "0x76CEDE0", VA = "0x1876D05E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x76D1280", Offset = "0x76CFA80", VA = "0x1876D1280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x76C8340", Offset = "0x76C6B40", VA = "0x1876C8340")]
	[AsyncStateMachine(typeof(PCPMNKNFJEK))]
	public static Task BDBMLJNBAHE(FKDGKIDPJEM FLNHJMHABBE, DLBOGIKOAJL EBNFOODJNOB, CEJHHODJMIO HEGNNFDIIGH, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x76C8490", Offset = "0x76C6C90", VA = "0x1876C8490")]
	private static void MJMMFGJBADO(PersistenceView AHOKJACJFBJ, MAAAODAGNHE EJLNBEBPJEL, DLBOGIKOAJL EBNFOODJNOB, HGFPFMBGMGH JJMCEIBOMEI, bool JOKGANHDIFJ)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct LOLHLEDHPOG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct NHCENMBHHPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public PJDNBPNFOAH roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public DLBOGIKOAJL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private DGPGECBENMI <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x76CD3B0", Offset = "0x76CBBB0", VA = "0x1876CD3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x76CD9D0", Offset = "0x76CC1D0", VA = "0x1876CD9D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x76CA930", Offset = "0x76C9130", VA = "0x1876CA930")]
	[AsyncStateMachine(typeof(NHCENMBHHPL))]
	public static Task BDBMLJNBAHE(PJDNBPNFOAH JCCNNNNOALN, DLBOGIKOAJL EBNFOODJNOB, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
internal struct NOMAAJCMNAO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct HAAMIIJDKIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public PJDNBPNFOAH roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public DLBOGIKOAJL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public FKDGKIDPJEM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x76C4810", Offset = "0x76C3010", VA = "0x1876C4810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x76C4A20", Offset = "0x76C3220", VA = "0x1876C4A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private sealed class MIDFMBMLOOG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000145")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			public NGPFCPLNCNC<string>.PPCAKDHDCLK timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000534")]
			public MIDFMBMLOOG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000535")]
			private NGPFCPLNCNC<string>.PPCAKDHDCLK <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000536")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000561")]
			[Cpp2IlInjected.Address(RVA = "0x76D1B10", Offset = "0x76D0310", VA = "0x1876D1B10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(RVA = "0x76D1EA0", Offset = "0x76D06A0", VA = "0x1876D1EA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public MIDFMBMLOOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x76CAFE0", Offset = "0x76C97E0", VA = "0x1876CAFE0")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task JFFIHLNKAFH(NGPFCPLNCNC<string>.PPCAKDHDCLK timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct NFHCJPFBPBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public NOMAAJCMNAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private DGPGECBENMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private DGPGECBENMI <_>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private TaskAwaiter<AACGOKBLDOD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x76CC740", Offset = "0x76CAF40", VA = "0x1876CC740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x76CD350", Offset = "0x76CBB50", VA = "0x1876CD350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class FBMMBCNAOBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public BIDADGNHDHM version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public FBMMBCNAOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x76C00B0", Offset = "0x76BE8B0", VA = "0x1876C00B0")]
		internal object GABIAOLCEHK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x76C0000", Offset = "0x76BE800", VA = "0x1876C0000")]
		internal object EOCDBOKEJMH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private PJDNBPNFOAH JCCNNNNOALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private DLBOGIKOAJL EBNFOODJNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	private FKDGKIDPJEM FLNHJMHABBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private bool MLNDGCMJHEC;

	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private static readonly ByteString GHBFJGBONJD;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private PCCBFICHMFB KOJHMMMMDLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x76CFDA0", Offset = "0x76CE5A0", VA = "0x1876CFDA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private ODFFNGGOBDA PIDJECIHDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x76CF560", Offset = "0x76CDD60", VA = "0x1876CF560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x76CF410", Offset = "0x76CDC10", VA = "0x1876CF410")]
	[AsyncStateMachine(typeof(HAAMIIJDKIH))]
	public static Task BDBMLJNBAHE(PJDNBPNFOAH JCCNNNNOALN, DLBOGIKOAJL EBNFOODJNOB, FKDGKIDPJEM FLNHJMHABBE, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA, bool MLNDGCMJHEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x76CF2E0", Offset = "0x76CDAE0", VA = "0x1876CF2E0")]
	[AsyncStateMachine(typeof(NFHCJPFBPBD))]
	private Task BDBMLJNBAHE(NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x76CF600", Offset = "0x76CDE00", VA = "0x1876CF600")]
	private void MGIOJAPKBPI([NotNull] LAENOPFABFD HKKBOJHKNDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x76CF2A0", Offset = "0x76CDAA0", VA = "0x1876CF2A0")]
	private bool BBGLEIHENMH(BIDADGNHDHM MAAOIFPNGGJ, LAENOPFABFD HKKBOJHKNDM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
internal struct BHKOKNODFFK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct CCNMDJJJNBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public AsyncTaskMethodBuilder<DLBOGIKOAJL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public BHKOKNODFFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public DHIIJCJNKOE.IPCJAFIALIC downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private DGPGECBENMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		private TaskAwaiter<(DNFCNMKAMCE<KGCMKEIEHGC, LHIOHJOJEEI>, DNFCNMKAMCE<CKCMDPBBFGE<LAENOPFABFD>, LHIOHJOJEEI>, DNFCNMKAMCE<CKCMDPBBFGE<IKLNHKOGGAD>, LHIOHJOJEEI>, DNFCNMKAMCE<CKCMDPBBFGE<KNKCGNGKHLD>, LHIOHJOJEEI>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x76BC970", Offset = "0x76BB170", VA = "0x1876BC970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x76BD420", Offset = "0x76BBC20", VA = "0x1876BD420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct BNDDNFIALEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public AsyncTaskMethodBuilder<DNFCNMKAMCE<KGCMKEIEHGC, LHIOHJOJEEI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public BHKOKNODFFK <>4__this;

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
		public DHIIJCJNKOE.IPCJAFIALIC downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private DGPGECBENMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private TaskAwaiter<DNFCNMKAMCE<KGCMKEIEHGC, LHIOHJOJEEI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x76BA8D0", Offset = "0x76B90D0", VA = "0x1876BA8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x76BAEE0", Offset = "0x76B96E0", VA = "0x1876BAEE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	private NHLHCPHODCM<AMBENGOMJIK, IKLNHKOGGAD> KKGAPCBGCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	private NHLHCPHODCM<AMBENGOMJIK, LAENOPFABFD> ABKIAPCDCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	private NHLHCPHODCM<long, KNKCGNGKHLD> NEAKDGNBDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	private KDGBIOGMCOE EDNHCCICIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	private NIHPFEHJKNJ GKCMIIJJFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	private IPKCPHEECFE KLMBMCENJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	private string LMNFKMPPOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	private AMBENGOMJIK MLNPIEGNENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	private AMBENGOMJIK DIHDJINLOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	private long GAFPBFDFBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	private NGPFCPLNCNC<string>.PPCAKDHDCLK IEGOAOCEEPG;

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x76BA3B0", Offset = "0x76B8BB0", VA = "0x1876BA3B0")]
	public static Task<DLBOGIKOAJL> DNGHNMPMMMN(PJDNBPNFOAH JCCNNNNOALN, [In] BCEEGFPKODB EBNFOODJNOB, DHIIJCJNKOE.IPCJAFIALIC PNAAKKBFDEP, NGPFCPLNCNC<string>.PPCAKDHDCLK IEGOAOCEEPG, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x76BA220", Offset = "0x76B8A20", VA = "0x1876BA220")]
	[AsyncStateMachine(typeof(CCNMDJJJNBO))]
	private Task<DLBOGIKOAJL> BDBMLJNBAHE(DHIIJCJNKOE.IPCJAFIALIC PNAAKKBFDEP, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x76BA710", Offset = "0x76B8F10", VA = "0x1876BA710")]
	[AsyncStateMachine(typeof(BNDDNFIALEG))]
	private Task<DNFCNMKAMCE<KGCMKEIEHGC, LHIOHJOJEEI>> KCHMMNKJIJD(string LMNFKMPPOHE, long GAFPBFDFBJD, long? NKDNOGOOODN, long? IFPDLCPBOCG, DHIIJCJNKOE.IPCJAFIALIC PNAAKKBFDEP, NGPFCPLNCNC<string>.PPCAKDHDCLK IFPMLEGCMDN, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal struct BHJODHAAJKG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct CHDLMMHFILL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public AsyncTaskMethodBuilder<BCEEGFPKODB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public BHJODHAAJKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private TaskAwaiter<BCEEGFPKODB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x76BDAD0", Offset = "0x76BC2D0", VA = "0x1876BDAD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x76BDEE0", Offset = "0x76BC6E0", VA = "0x1876BDEE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct JEIOFALIJFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public AsyncTaskMethodBuilder<BCEEGFPKODB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public BHJODHAAJKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private TaskAwaiter<BCEEGFPKODB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x76C7910", Offset = "0x76C6110", VA = "0x1876C7910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x76C7D40", Offset = "0x76C6540", VA = "0x1876C7D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private sealed class MABKPPOOAJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public MABKPPOOAJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0xA8C3D0", Offset = "0xA8ABD0", VA = "0x180A8C3D0")]
		internal bool DMEBHDAGHOK(IPKCPHEECFE sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct BOEKELEMBJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public AsyncTaskMethodBuilder<BCEEGFPKODB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public AMBENGOMJIK superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public PCCBFICHMFB callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private MABKPPOOAJI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public NDJOKDICBGD roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private NIHPFEHJKNJ <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private IPKCPHEECFE <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private AMBENGOMJIK <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private AMBENGOMJIK <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private TaskAwaiter<NIHPFEHJKNJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private TaskAwaiter<EAOIDDNCJKJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private TaskAwaiter<DJPINPOMHEF> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x76BAF50", Offset = "0x76B9750", VA = "0x1876BAF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x76BC0A0", Offset = "0x76BA8A0", VA = "0x1876BC0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	private PCCBFICHMFB BIJBPNIFOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	private JDBACAEAFMP HCLBDKOEIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private NDJOKDICBGD OMFPPMBFAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private NGPFCPLNCNC<string>.PPCAKDHDCLK IEGOAOCEEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private long NKDNOGOOODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	private long ACPFGDPOKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private long BFNDOACDLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private string GOCMOGLILOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private AMBENGOMJIK DDPKJJNMPFA;

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x76B9FC0", Offset = "0x76B87C0", VA = "0x1876B9FC0")]
	public static Task<BCEEGFPKODB> DNGHNMPMMMN(PJDNBPNFOAH JCCNNNNOALN, MIPHOHMODEJ BPCGMGBPPCA, NGPFCPLNCNC<string>.PPCAKDHDCLK IEGOAOCEEPG, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x76B9E70", Offset = "0x76B8670", VA = "0x1876B9E70")]
	[AsyncStateMachine(typeof(CHDLMMHFILL))]
	private Task<BCEEGFPKODB> BDBMLJNBAHE(CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x76B9D10", Offset = "0x76B8510", VA = "0x1876B9D10")]
	[AsyncStateMachine(typeof(JEIOFALIJFH))]
	private Task<BCEEGFPKODB> ABDBEANKNCM(NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x76B9B70", Offset = "0x76B8370", VA = "0x1876B9B70")]
	[AsyncStateMachine(typeof(BOEKELEMBJN))]
	private static Task<BCEEGFPKODB> ABDBEANKNCM(PCCBFICHMFB BIJBPNIFOLE, NDJOKDICBGD OMFPPMBFAGE, long NKDNOGOOODN, long ACPFGDPOKJK, long BFNDOACDLFM, string GOCMOGLILOK, AMBENGOMJIK DDPKJJNMPFA, CancellationToken ALKEMFHOMCA, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x76BA1F0", Offset = "0x76B89F0", VA = "0x1876BA1F0")]
	private void JCKMKIFAKOO(NIHPFEHJKNJ GKCMIIJJFKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
internal struct CECKKPDKJOA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct HEPHCJKEOHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public CECKKPDKJOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x76C4A80", Offset = "0x76C3280", VA = "0x1876C4A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x76C5010", Offset = "0x76C3810", VA = "0x1876C5010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	private PCCBFICHMFB BIJBPNIFOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000592")]
	private DLBOGIKOAJL EBNFOODJNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000593")]
	private NGPFCPLNCNC<string>.PPCAKDHDCLK IEGOAOCEEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000594")]
	private float CLIKBEONLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000595")]
	private float KJDKCPLOEKK;

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x76BD870", Offset = "0x76BC070", VA = "0x1876BD870")]
	public static Task HIDDEECLCIA(PJDNBPNFOAH JCCNNNNOALN, DLBOGIKOAJL EBNFOODJNOB, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x76BD5D0", Offset = "0x76BBDD0", VA = "0x1876BD5D0")]
	[AsyncStateMachine(typeof(HEPHCJKEOHE))]
	public Task BDBMLJNBAHE(CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x76BD490", Offset = "0x76BBC90", VA = "0x1876BD490")]
	private static void AKKIBBILLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x76BD6F0", Offset = "0x76BBEF0", VA = "0x1876BD6F0")]
	private void BICOKGNHCMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x76BDA10", Offset = "0x76BC210", VA = "0x1876BDA10")]
	private static float JCKOCPMGAPJ(PCCBFICHMFB BIJBPNIFOLE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x76BD850", Offset = "0x76BC050", VA = "0x1876BD850")]
	private static float CKBMDGHPHPF()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal struct MIKAJNMMDIL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct FJABDMGABOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public FKDGKIDPJEM operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public DLBOGIKOAJL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private DGPGECBENMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private CHAHCGOKNDN <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private PJDNBPNFOAH <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private DOCFCGOOFKM.KLELKFKLNFK <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private TaskAwaiter<AACGOKBLDOD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x76C09F0", Offset = "0x76BF1F0", VA = "0x1876C09F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x76C1210", Offset = "0x76BFA10", VA = "0x1876C1210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct BEHKIHBPHEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		private DGPGECBENMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x76B97E0", Offset = "0x76B7FE0", VA = "0x1876B97E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x76B9B10", Offset = "0x76B8310", VA = "0x1876B9B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x76CB100", Offset = "0x76C9900", VA = "0x1876CB100")]
	[AsyncStateMachine(typeof(FJABDMGABOJ))]
	public static Task BDBMLJNBAHE(FKDGKIDPJEM FLNHJMHABBE, DLBOGIKOAJL EBNFOODJNOB, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x76CB300", Offset = "0x76C9B00", VA = "0x1876CB300")]
	private static Task<AACGOKBLDOD> KDJAPINNACA(FKDGKIDPJEM FLNHJMHABBE, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x76CB240", Offset = "0x76C9A40", VA = "0x1876CB240")]
	[AsyncStateMachine(typeof(BEHKIHBPHEK))]
	private static Task JFABNADMPIG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal struct OKEKPKJFPKK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct HNHNOEKLPAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public OKEKPKJFPKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x76C5070", Offset = "0x76C3870", VA = "0x1876C5070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x76C5720", Offset = "0x76C3F20", VA = "0x1876C5720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private sealed class IPNLGBAAGLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public IPNLGBAAGLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x76C7340", Offset = "0x76C5B40", VA = "0x1876C7340")]
		internal object BCPNPJKDOLC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct JAMHIEFPMOC : IAsyncStateMachine
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
		public OKEKPKJFPKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private DGPGECBENMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x76C7430", Offset = "0x76C5C30", VA = "0x1876C7430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x76C78B0", Offset = "0x76C60B0", VA = "0x1876C78B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005B0")]
	private bool HOIBFEJDOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005B1")]
	private NGPFCPLNCNC<string>.PPCAKDHDCLK IEGOAOCEEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B2")]
	private PJDNBPNFOAH JCCNNNNOALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005B3")]
	private CancellationToken ALKEMFHOMCA;

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x76D00B0", Offset = "0x76CE8B0", VA = "0x1876D00B0")]
	public static Task BOJGPEOKOCA(PJDNBPNFOAH JCCNNNNOALN, bool HOIBFEJDOMK, NGPFCPLNCNC<string>.PPCAKDHDCLK IEGOAOCEEPG, CancellationToken MHGBHDLPJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x76CFFC0", Offset = "0x76CE7C0", VA = "0x1876CFFC0")]
	[AsyncStateMachine(typeof(HNHNOEKLPAE))]
	private Task BDBMLJNBAHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x76D0120", Offset = "0x76CE920", VA = "0x1876D0120")]
	[AsyncStateMachine(typeof(JAMHIEFPMOC))]
	private Task GOKOHPAEDML(bool DLOFGKJHJCJ, string AINIGHKDABB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830")]
	private bool BNCIIDJMLAM(bool HOIBFEJDOMK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct OOLCMGCKHPN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct AHMJIJOGICF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public OOLCMGCKHPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x76B9200", Offset = "0x76B7A00", VA = "0x1876B9200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x76B9770", Offset = "0x76B7F70", VA = "0x1876B9770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private sealed class GECGMPCOMDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public GECGMPCOMDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x76C39E0", Offset = "0x76C21E0", VA = "0x1876C39E0")]
		internal object BCPNPJKDOLC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct FLBLACIFJGI : IAsyncStateMachine
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
		public OOLCMGCKHPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private DGPGECBENMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x76C1C60", Offset = "0x76C0460", VA = "0x1876C1C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x76C20F0", Offset = "0x76C08F0", VA = "0x1876C20F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C3")]
	private BDDEIHLNPOI INJALNNHGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C4")]
	private NGPFCPLNCNC<string>.PPCAKDHDCLK IEGOAOCEEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C5")]
	private PJDNBPNFOAH JCCNNNNOALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	private bool MOBDKIHNFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private DLBOGIKOAJL EBNFOODJNOB;

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x76D0560", Offset = "0x76CED60", VA = "0x1876D0560")]
	public static Task<Scene> MMMIEHPNJPH(PJDNBPNFOAH JCCNNNNOALN, BDDEIHLNPOI LJGJFOKAHDF, NGPFCPLNCNC<string>.PPCAKDHDCLK IEGOAOCEEPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x76D0250", Offset = "0x76CEA50", VA = "0x1876D0250")]
	[AsyncStateMachine(typeof(AHMJIJOGICF))]
	private Task<Scene> BDBMLJNBAHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x76D0370", Offset = "0x76CEB70", VA = "0x1876D0370")]
	private bool FJLNJAIBEEF(DLBOGIKOAJL EBNFOODJNOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x76D04F0", Offset = "0x76CECF0", VA = "0x1876D04F0")]
	private void JCGDFKLBOGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x76D03A0", Offset = "0x76CEBA0", VA = "0x1876D03A0")]
	[AsyncStateMachine(typeof(FLBLACIFJGI))]
	private Task<Scene> GOKOHPAEDML(string AINIGHKDABB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal struct ABJGFDPFAJH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private struct GLOAPACMNEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public AsyncTaskMethodBuilder<HGFPFMBGMGH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public ABJGFDPFAJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		public HGFPFMBGMGH nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public DLBOGIKOAJL deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private TaskAwaiter<HGFPFMBGMGH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x76C3CD0", Offset = "0x76C24D0", VA = "0x1876C3CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x76C47A0", Offset = "0x76C2FA0", VA = "0x1876C47A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private struct LAONBPLKIKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public AsyncTaskMethodBuilder<HGFPFMBGMGH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public ABJGFDPFAJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public HGFPFMBGMGH state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		private TaskAwaiter<AACGOKBLDOD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x76C9660", Offset = "0x76C7E60", VA = "0x1876C9660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x76C9940", Offset = "0x76C8140", VA = "0x1876C9940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D4")]
	private readonly FKDGKIDPJEM FLNHJMHABBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	private readonly JDBACAEAFMP HCLBDKOEIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D6")]
	private readonly ENCNGMMBGIH GGGJMCAFAOI;

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	private CHAHCGOKNDN HCHCMAOFBML
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x5D35520", Offset = "0x5D33D20", VA = "0x185D35520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x76B8B00", Offset = "0x76B7300", VA = "0x1876B8B00")]
	public ABJGFDPFAJH(FKDGKIDPJEM FLNHJMHABBE, JDBACAEAFMP HCLBDKOEIDG, ENCNGMMBGIH GGGJMCAFAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x76B8980", Offset = "0x76B7180", VA = "0x1876B8980")]
	[AsyncStateMachine(typeof(GLOAPACMNEN))]
	public Task<HGFPFMBGMGH> NBFKNBDFLPC(HGFPFMBGMGH PKKBOHNOKNA, DLBOGIKOAJL ILANIBJGLFP, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA, bool DPCODFCFPNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x76B87F0", Offset = "0x76B6FF0", VA = "0x1876B87F0")]
	[AsyncStateMachine(typeof(LAONBPLKIKA))]
	private Task<HGFPFMBGMGH> ELFDPEBIGMP(NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, HGFPFMBGMGH LCFHGACCKAF, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x76B8950", Offset = "0x76B7150", VA = "0x1876B8950")]
	private bool LDHCMHKFFEB(HGFPFMBGMGH BNBOGKMKCJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x76B87D0", Offset = "0x76B6FD0", VA = "0x1876B87D0")]
	private void CLLGOIEIHDM(string HPJAAPABCEN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000161")]
internal struct LGEHINKJCIF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct HPKEPNDGIHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public CHAHCGOKNDN operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public DLBOGIKOAJL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public CEJHHODJMIO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		private DGPGECBENMI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		private List<(PersistenceView, MAAAODAGNHE)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		private (PersistenceView, MAAAODAGNHE) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x76C5DF0", Offset = "0x76C45F0", VA = "0x1876C5DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x76C6440", Offset = "0x76C4C40", VA = "0x1876C6440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x76C9F20", Offset = "0x76C8720", VA = "0x1876C9F20")]
	[AsyncStateMachine(typeof(HPKEPNDGIHD))]
	public static Task BDBMLJNBAHE(CHAHCGOKNDN GFKCDNLMPGP, DLBOGIKOAJL EBNFOODJNOB, CEJHHODJMIO HEGNNFDIIGH, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal struct OBEFGDILOHJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private struct FLHHABOKLNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public CHAHCGOKNDN operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public DLBOGIKOAJL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public CEJHHODJMIO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private BIDADGNHDHM <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private DGPGECBENMI <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private List<(PersistenceView, MAAAODAGNHE)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		private MAAAODAGNHE <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x76C2160", Offset = "0x76C0960", VA = "0x1876C2160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x76C2A10", Offset = "0x76C1210", VA = "0x1876C2A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x76CFE80", Offset = "0x76CE680", VA = "0x1876CFE80")]
	[AsyncStateMachine(typeof(FLHHABOKLNE))]
	public static Task BDBMLJNBAHE(CHAHCGOKNDN GFKCDNLMPGP, DLBOGIKOAJL EBNFOODJNOB, CEJHHODJMIO HEGNNFDIIGH, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
internal struct DOCFCGOOFKM
{
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	public struct KLELKFKLNFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public List<KADHOLFHAKF> DHAINAMFFNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public List<MAAAODAGNHE> OLMPFECJEIJ;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0xE64E60", Offset = "0xE63660", VA = "0x180E64E60")]
		public KLELKFKLNFK(List<KADHOLFHAKF> DHAINAMFFNI, List<MAAAODAGNHE> OLMPFECJEIJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private sealed class AGLNNJEHKDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public IEnumerable<KADHOLFHAKF> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public AGLNNJEHKDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x76B9110", Offset = "0x76B7910", VA = "0x1876B9110")]
		internal object MKFGFCAEIJE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000603")]
	private PJDNBPNFOAH JCCNNNNOALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000604")]
	private DLBOGIKOAJL EBNFOODJNOB;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	private PCCBFICHMFB KOJHMMMMDLE
	{
		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x76BE980", Offset = "0x76BD180", VA = "0x1876BE980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x76BE1B0", Offset = "0x76BC9B0", VA = "0x1876BE1B0")]
	public static KLELKFKLNFK BDBMLJNBAHE(PJDNBPNFOAH JCCNNNNOALN, DLBOGIKOAJL EBNFOODJNOB)
	{
		return default(KLELKFKLNFK);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x76BDF50", Offset = "0x76BC750", VA = "0x1876BDF50")]
	private KLELKFKLNFK BDBMLJNBAHE()
	{
		return default(KLELKFKLNFK);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x76BE210", Offset = "0x76BCA10", VA = "0x1876BE210")]
	private KLELKFKLNFK GAFFCFBMJGM(LAENOPFABFD HKKBOJHKNDM, BIDADGNHDHM APHEHIIHAII)
	{
		return default(KLELKFKLNFK);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0x76BE7B0", Offset = "0x76BCFB0", VA = "0x1876BE7B0")]
	private bool KEIJHNMDCCB(IEnumerable<KADHOLFHAKF> DHAINAMFFNI)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal struct ABONOCODDEL
{
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class GLKFBDFCCLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public DOCFCGOOFKM.KLELKFKLNFK instantiations;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public GLKFBDFCCLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x76C3C20", Offset = "0x76C2420", VA = "0x1876C3C20")]
		internal object JFFIHLNKAFH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private sealed class FFDENMFLHCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public FFDENMFLHCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x76C0190", Offset = "0x76BE990", VA = "0x1876C0190")]
		internal object IOFLOFJMOFP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x76B8B60", Offset = "0x76B7360", VA = "0x1876B8B60")]
	public static void BDBMLJNBAHE(CHAHCGOKNDN GFKCDNLMPGP, DLBOGIKOAJL EBNFOODJNOB, DOCFCGOOFKM.KLELKFKLNFK KBCGEFIJPHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
internal class ENCNGMMBGIH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct FIOMMBBJKOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public ENCNGMMBGIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public HGFPFMBGMGH operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public DLBOGIKOAJL deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x76C0220", Offset = "0x76BEA20", VA = "0x1876C0220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x76C0990", Offset = "0x76BF190", VA = "0x1876C0990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class LFPAMDAHFEK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016E")]
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
			public LFPAMDAHFEK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400061C")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400061D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0x76D17F0", Offset = "0x76CFFF0", VA = "0x1876D17F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0x76D1AB0", Offset = "0x76D02B0", VA = "0x1876D1AB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public ENCNGMMBGIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public DLBOGIKOAJL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public LFPAMDAHFEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x76C9E30", Offset = "0x76C8630", VA = "0x1876C9E30")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task IHMFJDMLOOK(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct JFMJLEOCFKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public ENCNGMMBGIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public DLBOGIKOAJL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		private LFPAMDAHFEK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x76C7DB0", Offset = "0x76C65B0", VA = "0x1876C7DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x76C82E0", Offset = "0x76C6AE0", VA = "0x1876C82E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct HNIFIEDCBAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public ENCNGMMBGIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public DLBOGIKOAJL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		private Dictionary<Guid, List<FBIGDOKFDJI>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x76C5780", Offset = "0x76C3F80", VA = "0x1876C5780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x76C5D90", Offset = "0x76C4590", VA = "0x1876C5D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private struct CAGLCEAFAGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public ENCNGMMBGIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public DLBOGIKOAJL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		private Dictionary<Guid, List<FBIGDOKFDJI>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x76BC110", Offset = "0x76BA910", VA = "0x1876BC110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x76BC7B0", Offset = "0x76BAFB0", VA = "0x1876BC7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private sealed class IFGKIMHOMAM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000173")]
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
			public FBIGDOKFDJI handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000640")]
			public IFGKIMHOMAM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000641")]
			private DGPGECBENMI <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000642")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005DF")]
			[Cpp2IlInjected.Address(RVA = "0x76D1320", Offset = "0x76CFB20", VA = "0x1876D1320", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E0")]
			[Cpp2IlInjected.Address(RVA = "0x76D1790", Offset = "0x76CFF90", VA = "0x1876D1790", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public EHABBOMHMMB runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public List<FBIGDOKFDJI> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public DLBOGIKOAJL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public IFGKIMHOMAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x76C6BC0", Offset = "0x76C53C0", VA = "0x1876C6BC0")]
		internal object NMMDEIHKKBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x76C6AC0", Offset = "0x76C52C0", VA = "0x1876C6AC0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task KDPIMDJPGMC(FBIGDOKFDJI handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x76C69D0", Offset = "0x76C51D0", VA = "0x1876C69D0")]
		internal object BMCHPNHMPHE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private struct IBKPCLDHLCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public EHABBOMHMMB runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public List<FBIGDOKFDJI> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public DLBOGIKOAJL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private IFGKIMHOMAM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x76C64A0", Offset = "0x76C4CA0", VA = "0x1876C64A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x76C6970", Offset = "0x76C5170", VA = "0x1876C6970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private struct IIBDGOLGLEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public ENCNGMMBGIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public DLBOGIKOAJL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x76C6CB0", Offset = "0x76C54B0", VA = "0x1876C6CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x76C7270", Offset = "0x76C5A70", VA = "0x1876C7270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private sealed class JAJONHLMHDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public JAJONHLMHDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x76C73C0", Offset = "0x76C5BC0", VA = "0x1876C73C0")]
		internal object KBDNFBDIEPA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct MKICLFIGLOC : IAsyncStateMachine
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
		public ENCNGMMBGIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public DLBOGIKOAJL data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		private DGPGECBENMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x76CC0E0", Offset = "0x76CA8E0", VA = "0x1876CC0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x76CC5A0", Offset = "0x76CADA0", VA = "0x1876CC5A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class IOBAECPNPGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public IOBAECPNPGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x76C72D0", Offset = "0x76C5AD0", VA = "0x1876C72D0")]
		internal object EAEDECNJFID()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private struct GBGDIKIKGDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public ENCNGMMBGIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		private DGPGECBENMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private TaskAwaiter<AACGOKBLDOD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x76C3340", Offset = "0x76C1B40", VA = "0x1876C3340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x76C3980", Offset = "0x76C2180", VA = "0x1876C3980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private sealed class GIAGHBHHHGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public GIAGHBHHHGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x76C3A30", Offset = "0x76C2230", VA = "0x1876C3A30")]
		internal object KCHAOBBANBJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400060B")]
	private readonly FKDGKIDPJEM FLNHJMHABBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400060C")]
	private HHEECEHLBPE GGGJMCAFAOI;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	private CHAHCGOKNDN HCHCMAOFBML
	{
		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0xC978F0", Offset = "0xC960F0", VA = "0x180C978F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x8C0090", Offset = "0x8BE890", VA = "0x1808C0090")]
	public ENCNGMMBGIH(FKDGKIDPJEM FLNHJMHABBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x76BF480", Offset = "0x76BDC80", VA = "0x1876BF480")]
	[AsyncStateMachine(typeof(FIOMMBBJKOK))]
	public Task BDBMLJNBAHE(HGFPFMBGMGH JJMCEIBOMEI, DLBOGIKOAJL ILANIBJGLFP, NGPFCPLNCNC<string>.PPCAKDHDCLK IEGOAOCEEPG, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x76BF0C0", Offset = "0x76BD8C0", VA = "0x1876BF0C0")]
	[AsyncStateMachine(typeof(JFMJLEOCFKC))]
	private Task ADINDKEIGIN(DLBOGIKOAJL EBNFOODJNOB, NGPFCPLNCNC<string>.PPCAKDHDCLK IEGOAOCEEPG, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x76BF340", Offset = "0x76BDB40", VA = "0x1876BF340")]
	[AsyncStateMachine(typeof(HNIFIEDCBAP))]
	private Task AMDLMLBLDNE(DLBOGIKOAJL EBNFOODJNOB, NGPFCPLNCNC<string>.PPCAKDHDCLK IEGOAOCEEPG, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x76BF9D0", Offset = "0x76BE1D0", VA = "0x1876BF9D0")]
	[AsyncStateMachine(typeof(CAGLCEAFAGE))]
	private Task GPFEGNAHEBG(DLBOGIKOAJL EBNFOODJNOB, NGPFCPLNCNC<string>.PPCAKDHDCLK IEGOAOCEEPG, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x76BF710", Offset = "0x76BDF10", VA = "0x1876BF710")]
	[AsyncStateMachine(typeof(IBKPCLDHLCE))]
	private Task ENBFEDBGDJJ(Guid MNNDKKIJILI, List<FBIGDOKFDJI> DHDEDELCCPE, EHABBOMHMMB OECIIGBCPIG, DLBOGIKOAJL EBNFOODJNOB, CancellationToken DJIMHLGHFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x76BF200", Offset = "0x76BDA00", VA = "0x1876BF200")]
	[AsyncStateMachine(typeof(IIBDGOLGLEG))]
	private Task AJKOEGIKKHJ(DLBOGIKOAJL EBNFOODJNOB, NGPFCPLNCNC<string>.PPCAKDHDCLK IEGOAOCEEPG, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x76BF5D0", Offset = "0x76BDDD0", VA = "0x1876BF5D0")]
	[AsyncStateMachine(typeof(MKICLFIGLOC))]
	private Task CDHLOIFPEAA(Guid BFENIBINCAF, DLBOGIKOAJL EBNFOODJNOB, NGPFCPLNCNC<string>.PPCAKDHDCLK IEGOAOCEEPG, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x76BFB10", Offset = "0x76BE310", VA = "0x1876BFB10")]
	[AsyncStateMachine(typeof(GBGDIKIKGDF))]
	private Task GPIJGALDFAO(Guid BFENIBINCAF, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x76BFC50", Offset = "0x76BE450", VA = "0x1876BFC50")]
	private void HDICCAOGIJO(Guid BFENIBINCAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x76BFD70", Offset = "0x76BE570", VA = "0x1876BFD70")]
	private void JLPHIEAEPAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x76BF860", Offset = "0x76BE060", VA = "0x1876BF860")]
	public Guid GKNHMCNMMHO(HGFPFMBGMGH JNOINOFDBFE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x76BFE20", Offset = "0x76BE620", VA = "0x1876BFE20")]
	[CompilerGenerated]
	private object MBCAGEKMLND()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
internal struct CBOEPKGMKJB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct JJCCMNMLCKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public CBOEPKGMKJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		private IEnumerator<JMOEKMFMFID> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x76C87D0", Offset = "0x76C6FD0", VA = "0x1876C87D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x76C8E60", Offset = "0x76C7660", VA = "0x1876C8E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066B")]
	private PCCBFICHMFB BIJBPNIFOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400066C")]
	private NGPFCPLNCNC<string>.PPCAKDHDCLK IEGOAOCEEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400066D")]
	private CancellationToken ALKEMFHOMCA;

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x76BC900", Offset = "0x76BB100", VA = "0x1876BC900")]
	public static Task FHPCKBBBPEK(PCCBFICHMFB BIJBPNIFOLE, NGPFCPLNCNC<string>.PPCAKDHDCLK IEGOAOCEEPG, CancellationToken MHGBHDLPJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x76BC810", Offset = "0x76BB010", VA = "0x1876BC810")]
	[AsyncStateMachine(typeof(JJCCMNMLCKK))]
	private Task BDBMLJNBAHE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
public readonly struct GKBBLKJMHOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	public readonly bool BHOGAIIJFKH;

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x251B6A0", Offset = "0x2519EA0", VA = "0x18251B6A0")]
	public GKBBLKJMHOG(bool KEAOLLIDGAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
public readonly struct MLONKGHJMMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000675")]
	public readonly LAENOPFABFD? HOLEPOPCOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000676")]
	public readonly BFKJLHPIJMG COCJKFJLCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000677")]
	public readonly string? EABCBGOOLCK;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public IReadOnlyCollection<string> KDDIGCFNIBD
	{
		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x76CC620", Offset = "0x76CAE20", VA = "0x1876CC620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public IReadOnlyDictionary<long, int> LOJMDLCCGKA
	{
		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x76CC600", Offset = "0x76CAE00", VA = "0x1876CC600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x76CC640", Offset = "0x76CAE40", VA = "0x1876CC640")]
	public MLONKGHJMMO(LAENOPFABFD? NKIGLKBMOAI, BFKJLHPIJMG LELCBPLDHNL, string? LMNFKMPPOHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class NODKLAGHLJH : GOBCFIPLILF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct EICOLMLJHFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public AsyncTaskMethodBuilder<MLONKGHJMMO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public NODKLAGHLJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public HODMHPHBFHJ serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public PAMKGMCHOGJ roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		private DGPGECBENMI <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x76BE9D0", Offset = "0x76BD1D0", VA = "0x1876BE9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x76BF050", Offset = "0x76BD850", VA = "0x1876BF050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class FJKBOCKGBGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public HODMHPHBFHJ serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public NODKLAGHLJH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public FJKBOCKGBGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x76C1350", Offset = "0x76BFB50", VA = "0x1876C1350")]
		internal Task NPAENNHNEMA(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x76C1270", Offset = "0x76BFA70", VA = "0x1876C1270")]
		internal Task NKOGNCFLJHB(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class AHCNNDIIGAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public FJKBOCKGBGM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public AHCNNDIIGAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x76B9190", Offset = "0x76B7990", VA = "0x1876B9190")]
		internal object AEHJFNLHIDD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	private sealed class PFHBKHICDOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public FJKBOCKGBGM CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public PFHBKHICDOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x76D12E0", Offset = "0x76CFAE0", VA = "0x1876D12E0")]
		internal Task DOMBJJJOBEM(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CompilerGenerated]
	private struct LIOAOFHHOOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public HODMHPHBFHJ serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public NODKLAGHLJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		private AHCNNDIIGAD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		private DGPGECBENMI <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x76CA060", Offset = "0x76C8860", VA = "0x1876CA060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x76CA8D0", Offset = "0x76C90D0", VA = "0x1876CA8D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000678")]
	private readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.Token(Token = "0x4000679")]
	private static readonly TimeSpan EOENBHFMGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400067A")]
	private readonly CPLMHNOLEBE GOGJCMJKAAE;

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x76CF250", Offset = "0x76CDA50", VA = "0x1876CF250")]
	public NODKLAGHLJH(FKDGKIDPJEM FLNHJMHABBE, CPLMHNOLEBE GOGJCMJKAAE, FICDJCDJOAA AGHKKLOENAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x76CE940", Offset = "0x76CD140", VA = "0x1876CE940")]
	[AsyncStateMachine(typeof(EICOLMLJHFE))]
	public Task<MLONKGHJMMO> KBGBIJFEDIC(long ACPFGDPOKJK, PAMKGMCHOGJ CPFMGBGOHPH, HODMHPHBFHJ AIOPKBHNAIB, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x76CEC00", Offset = "0x76CD400", VA = "0x1876CEC00")]
	[AsyncStateMachine(typeof(LIOAOFHHOOH))]
	private Task MNPMJICFKEB(HODMHPHBFHJ AIOPKBHNAIB, IEnumerable<PersistenceView> IGKAPEHJNKN, StringBuilder DFBJJEFKMMF, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x76CE130", Offset = "0x76CC930", VA = "0x1876CE130")]
	private MLONKGHJMMO HELNPIGOALE(long ACPFGDPOKJK, PAMKGMCHOGJ CPFMGBGOHPH, HODMHPHBFHJ AIOPKBHNAIB, IEnumerable<PersistenceView> IGKAPEHJNKN, StringBuilder DFBJJEFKMMF)
	{
		return default(MLONKGHJMMO);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x76CEAA0", Offset = "0x76CD2A0", VA = "0x1876CEAA0")]
	private LAENOPFABFD LMGJLIKEFBK(long ACPFGDPOKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x76CE6F0", Offset = "0x76CCEF0", VA = "0x1876CE6F0")]
	private void IOHBOFNFODF(LAENOPFABFD KLGEGOBKBHE, StringBuilder DFBJJEFKMMF, IEnumerable<PersistenceView> IGKAPEHJNKN, [In] EFHFNGMAHHP GPMLGMGOAKC, MKBLKEPCJCO CBFGMIKMOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x76CED40", Offset = "0x76CD540", VA = "0x1876CED40")]
	private void PGFLOAPLEEH(LAENOPFABFD KLGEGOBKBHE, StringBuilder DFBJJEFKMMF, PersistenceView AHOKJACJFBJ, MKBLKEPCJCO CBFGMIKMOGB, [In] EFHFNGMAHHP GPMLGMGOAKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
internal class FLBBKMLMNJL : GOBCFIPLILF
{
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private sealed class GJPLCEHLLCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public KANCPKCPDON.KKNDEMLNGCP roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public GJPLCEHLLCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x76C3AA0", Offset = "0x76C22A0", VA = "0x1876C3AA0")]
		internal object LFMCOLDFAII()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private struct GBCKNGMHGMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public AsyncTaskMethodBuilder<(KANCPKCPDON.KKNDEMLNGCP roomDataUpload, KANCPKCPDON.KKNDEMLNGCP subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public MLONKGHJMMO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public FLBBKMLMNJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		private GJPLCEHLLCK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		private TaskAwaiter<KANCPKCPDON.KKNDEMLNGCP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x76C2A70", Offset = "0x76C1270", VA = "0x1876C2A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x76C32D0", Offset = "0x76C1AD0", VA = "0x1876C32D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private struct NHNHGCEEOIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public AsyncTaskMethodBuilder<CNCFEBILFNP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public FLBBKMLMNJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public MLONKGHJMMO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public DBPAABODFCN roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		private TaskAwaiter<(KANCPKCPDON.KKNDEMLNGCP roomDataUpload, KANCPKCPDON.KKNDEMLNGCP subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		private TaskAwaiter<CNCFEBILFNP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x76CDA30", Offset = "0x76CC230", VA = "0x1876CDA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x76CE0C0", Offset = "0x76CC8C0", VA = "0x1876CE0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private struct LFHAALNEJIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public AsyncTaskMethodBuilder<EAOIDDNCJKJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public FLBBKMLMNJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public MLONKGHJMMO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		private TaskAwaiter<(KANCPKCPDON.KKNDEMLNGCP roomDataUpload, KANCPKCPDON.KKNDEMLNGCP subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private TaskAwaiter<EAOIDDNCJKJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x76C99B0", Offset = "0x76C81B0", VA = "0x1876C99B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x76C9DC0", Offset = "0x76C85C0", VA = "0x1876C9DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class GKLDBGDMPEM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200018D")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006C6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006C7")]
			public AsyncTaskMethodBuilder<AACGOKBLDOD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006C8")]
			public GKLDBGDMPEM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006C9")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006CA")]
			private AACGOKBLDOD <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006CB")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006CC")]
			private TaskAwaiter<EAOIDDNCJKJ> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006CD")]
			private TaskAwaiter<CNCFEBILFNP> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006CE")]
			private TaskAwaiter<AACGOKBLDOD> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x6000625")]
			[Cpp2IlInjected.Address(RVA = "0x76D1F00", Offset = "0x76D0700", VA = "0x1876D1F00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0x76D2EF0", Offset = "0x76D16F0", VA = "0x1876D2EF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public FLBBKMLMNJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public MLONKGHJMMO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public DBPAABODFCN roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public GKBBLKJMHOG roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public GKLDBGDMPEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x76C3AF0", Offset = "0x76C22F0", VA = "0x1876C3AF0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<AACGOKBLDOD> GPAKOHPLGBF(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private struct JPJOHAFKDOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public AsyncTaskMethodBuilder<AACGOKBLDOD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public FLBBKMLMNJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public MLONKGHJMMO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		public DBPAABODFCN roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		public GKBBLKJMHOG roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		private TaskAwaiter<AACGOKBLDOD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x76C8FA0", Offset = "0x76C77A0", VA = "0x1876C8FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x76C92B0", Offset = "0x76C7AB0", VA = "0x1876C92B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400069D")]
	private static readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.Token(Token = "0x400069E")]
	private static readonly FICDJCDJOAA AMHJBMBJBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400069F")]
	private readonly LOCGHKLNEFM NJBIHAHFIDF;

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	private PJDNBPNFOAH ABPCOLDFHJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x76A1140", Offset = "0x769F940", VA = "0x1876A1140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x76C1BD0", Offset = "0x76C03D0", VA = "0x1876C1BD0")]
	public FLBBKMLMNJL(FKDGKIDPJEM FLNHJMHABBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x76C1570", Offset = "0x76BFD70", VA = "0x1876C1570")]
	[AsyncStateMachine(typeof(GBCKNGMHGMG))]
	private Task<(KANCPKCPDON.KKNDEMLNGCP, KANCPKCPDON.KKNDEMLNGCP)> IBOEDHMAMHI(MLONKGHJMMO BNCKJFBLGEG, long NKDNOGOOODN, long IFPDLCPBOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x76C16B0", Offset = "0x76BFEB0", VA = "0x1876C16B0")]
	[AsyncStateMachine(typeof(NHNHGCEEOIE))]
	public Task<CNCFEBILFNP> JOJGOPEAJCD(int PFEIMHABCDO, [CanBeNull] DBPAABODFCN AIIKBOENKFJ, MLONKGHJMMO BNCKJFBLGEG, long NKDNOGOOODN, long IFPDLCPBOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x76C1820", Offset = "0x76C0020", VA = "0x1876C1820")]
	[AsyncStateMachine(typeof(LFHAALNEJIN))]
	private Task<EAOIDDNCJKJ> LAMNCCPDAPD(string GOCMOGLILOK, int PFEIMHABCDO, MLONKGHJMMO BNCKJFBLGEG, long NKDNOGOOODN, long IFPDLCPBOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x76C1990", Offset = "0x76C0190", VA = "0x1876C1990")]
	[AsyncStateMachine(typeof(JPJOHAFKDOA))]
	public Task<AACGOKBLDOD> OPCAAFEHKDO(int PFEIMHABCDO, DBPAABODFCN? AIIKBOENKFJ, MLONKGHJMMO BNCKJFBLGEG, long NKDNOGOOODN, long IFPDLCPBOCG, GKBBLKJMHOG ALIDCGPACDF, NGPFCPLNCNC<string>.PPCAKDHDCLK NJMHLDMOBDD, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
public abstract class CCOLAHIHLCO<T> where T : CCOLAHIHLCO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	internal readonly PJDNBPNFOAH GPAMHKKLIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	private int? IKDHDNFJDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	protected readonly Guid PBIELHOLMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DE")]
	protected readonly MEHNDAGNNDB JGNPONJLMPA;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	protected T APGLHLLMAPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x583BB70", Offset = "0x583A370", VA = "0x18583BB70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x583BBD0", Offset = "0x583A3D0", VA = "0x18583BBD0")]
	internal CCOLAHIHLCO(PJDNBPNFOAH PEEPEJCAEHH, MEHNDAGNNDB IOIKOBEMEOA, [Optional] Guid? PHACDDBECOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x583BA90", Offset = "0x583A290", VA = "0x18583BA90")]
	private AACGOKBLDOD OMMNEOGMKMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "4")]
	protected virtual void HJHCPLHFPDJ(AACGOKBLDOD PJFOMDHJLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x583B9F0", Offset = "0x583A1F0", VA = "0x18583B9F0")]
	public T JOANKMILMMI(OEDKOGGDKCO FPHGJJIHFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x583B820", Offset = "0x583A020", VA = "0x18583B820")]
	public T BOJILDJBFIJ(int GBOAEBMFHDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x583B8C0", Offset = "0x583A0C0", VA = "0x18583B8C0", Slot = "5")]
	public virtual Task<NDIOHACFFEO> JHBPNNKOAJF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public class KOBGPFNKBBG : CCOLAHIHLCO<KOBGPFNKBBG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006DF")]
	private MIPHOHMODEJ OANAMCHLGCB;

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x76D7F00", Offset = "0x76D6700", VA = "0x1876D7F00")]
	internal KOBGPFNKBBG(PJDNBPNFOAH PEEPEJCAEHH, MEHNDAGNNDB IOIKOBEMEOA, [Optional] Guid? PHACDDBECOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x6AED9E0", Offset = "0x6AEC1E0", VA = "0x186AED9E0")]
	public KOBGPFNKBBG BLNJIICOHKE(MIPHOHMODEJ OANAMCHLGCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x76D7E30", Offset = "0x76D6630", VA = "0x1876D7E30", Slot = "4")]
	protected override void HJHCPLHFPDJ(AACGOKBLDOD PJFOMDHJLBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
public class FPHCJAJMDIK : CCOLAHIHLCO<FPHCJAJMDIK>
{
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	internal enum JMHFKKDCNGC
	{
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private struct IBJOLLFIJLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		public AsyncTaskMethodBuilder<NDIOHACFFEO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		public FPHCJAJMDIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		private TaskAwaiter<NDIOHACFFEO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x76D5FD0", Offset = "0x76D47D0", VA = "0x1876D5FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x76D6370", Offset = "0x76D4B70", VA = "0x1876D6370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006E0")]
	private JMHFKKDCNGC EDLGODCMDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006E1")]
	private string PKHEKGBNEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006E2")]
	private DBPAABODFCN OANAMCHLGCB;

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x76D50C0", Offset = "0x76D38C0", VA = "0x1876D50C0")]
	internal FPHCJAJMDIK(PJDNBPNFOAH PEEPEJCAEHH, MEHNDAGNNDB IOIKOBEMEOA, [Optional] Guid? PHACDDBECOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x76D4D80", Offset = "0x76D3580", VA = "0x1876D4D80")]
	public FPHCJAJMDIK AJBANIJLJPA(string GIMKNCGKHFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x76D4DB0", Offset = "0x76D35B0", VA = "0x1876D4DB0")]
	public FPHCJAJMDIK BMLGLGJPOFC(bool MDANGMGLDHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x76D4DD0", Offset = "0x76D35D0", VA = "0x1876D4DD0")]
	public FPHCJAJMDIK FOJLJNKOJCE(bool BLKJCENANBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x76D5090", Offset = "0x76D3890", VA = "0x1876D5090")]
	public FPHCJAJMDIK JMCCNPOJJKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x76D4DF0", Offset = "0x76D35F0", VA = "0x1876D4DF0", Slot = "4")]
	protected override void HJHCPLHFPDJ(AACGOKBLDOD PJFOMDHJLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x76D4FA0", Offset = "0x76D37A0", VA = "0x1876D4FA0", Slot = "5")]
	[AsyncStateMachine(typeof(IBJOLLFIJLK))]
	public override Task<NDIOHACFFEO> JHBPNNKOAJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x76D4F60", Offset = "0x76D3760", VA = "0x1876D4F60")]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task<NDIOHACFFEO> IANJEAOIDDE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
internal static class FFMDNIEGACB
{
	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x76D4C30", Offset = "0x76D3430", VA = "0x1876D4C30")]
	public static void JBLGLALFJKI(this LNHHHAANBGA LENLOKODCEO, DILBKEMEFHP FHBBBHDCOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x76D4BB0", Offset = "0x76D33B0", VA = "0x1876D4BB0")]
	public static void DEKJEIDJADK(this DILBKEMEFHP FLLIHFEHJJM, [Optional] string PJFOMDHJLBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
public static class BGDJMJDEEHN
{
	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x76D35E0", Offset = "0x76D1DE0", VA = "0x1876D35E0")]
	public static AMBENGOMJIK LHJPANINNCE(this BBKIKBDHAOM ANPGJIABHOP)
	{
		return default(AMBENGOMJIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x76D3530", Offset = "0x76D1D30", VA = "0x1876D3530")]
	public static BBKIKBDHAOM HMFEKGCPHPN(this AMBENGOMJIK IHAHKMJAAEG)
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
			[Cpp2IlInjected.Token(Token = "0x40006EF")]
			public JKGAFKKEBBK ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006F0")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006F1")]
			public JKGAFKKEBBK HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006F2")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006F3")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006F4")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x6000647")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		private static JKGAFKKEBBK[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		private Dictionary<JKGAFKKEBBK, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x76DA290", Offset = "0x76D8A90", VA = "0x1876DA290")]
		public bool NCCBJPDBFEG(JKGAFKKEBBK FNMHABFFFHG, [Out] ResultConfig MEGJMJCJPOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x76DA150", Offset = "0x76D8950", VA = "0x1876DA150")]
		public ResultConfig AHHNKLBOMAM(JKGAFKKEBBK HLONLEDABCF, [Optional] HashSet<JKGAFKKEBBK> FJFPFKIFDNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x76DA8D0", Offset = "0x76D90D0", VA = "0x1876DA8D0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x76DA300", Offset = "0x76D8B00", VA = "0x1876DA300", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x9535A0", Offset = "0x951DA0", VA = "0x1809535A0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
public class MKBJJICEHGP : BPKJJBCEELO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private struct EHGFOILAABP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		public MKBJJICEHGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x76D48C0", Offset = "0x76D30C0", VA = "0x1876D48C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x76D4B50", Offset = "0x76D3350", VA = "0x1876D4B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private struct LMOEOIFNOJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public NGPFCPLNCNC<string>.PPCAKDHDCLK timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public BPKJJBCEELO preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		private NGPFCPLNCNC<string>.PPCAKDHDCLK <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x76D80B0", Offset = "0x76D68B0", VA = "0x1876D80B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x76D85C0", Offset = "0x76D6DC0", VA = "0x1876D85C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006FA")]
	private readonly BHKPCGPFPLN JKAIGKHOCFL;

	[Cpp2IlInjected.Token(Token = "0x40006FB")]
	private static readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public string NEDPFPKIPDC
	{
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x76D9190", Offset = "0x76D7990", VA = "0x1876D9190", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x76D92E0", Offset = "0x76D7AE0", VA = "0x1876D92E0")]
	[PDAMAKFHAHC.GNFCFDNPMLH.BGLEOICIJCF]
	internal static void EGBEIEOHABF(CMONJLKOOCI CGNEPIEHDLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x8C0090", Offset = "0x8BE890", VA = "0x1808C0090")]
	[RecRoom.NoEngine.Common.Preserve]
	public MKBJJICEHGP([NDCFMLCHJCI(null)] BHKPCGPFPLN JKAIGKHOCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x76D9080", Offset = "0x76D7880", VA = "0x1876D9080", Slot = "5")]
	[AsyncStateMachine(typeof(EHGFOILAABP))]
	public Task BDBMLJNBAHE(NGPFCPLNCNC<string>.PPCAKDHDCLK HBJNLOLLLLC, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x76D91C0", Offset = "0x76D79C0", VA = "0x1876D91C0")]
	[AsyncStateMachine(typeof(LMOEOIFNOJP))]
	private Task EDLAKNMEDBJ(BPKJJBCEELO OIHKIMIDPCO, NGPFCPLNCNC<string>.PPCAKDHDCLK HBJNLOLLLLC, CancellationToken ALKEMFHOMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
public interface BHKPCGPFPLN : BPKJJBCEELO
{
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
public interface BPKJJBCEELO
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	string NEDPFPKIPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BDBMLJNBAHE(NGPFCPLNCNC<string>.PPCAKDHDCLK HBJNLOLLLLC, CancellationToken ALKEMFHOMCA);
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
public static class LPEBGABHFNA
{
	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x76D8620", Offset = "0x76D6E20", VA = "0x1876D8620")]
	[PDAMAKFHAHC.GNFCFDNPMLH.BGLEOICIJCF]
	internal static void EDDDBNCFOFG(CMONJLKOOCI CGNEPIEHDLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
public interface JLLNKPIMHOC : IEquatable<JLLNKPIMHOC>
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	DateTime MCCNHHGDJON
	{
		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GLMAONNMJDO();

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MKODCJJEDIH(long NKDNOGOOODN, long ACPFGDPOKJK, [Out] MLONKGHJMMO BNCKJFBLGEG);
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
internal class BGLDPLEMAJI : NBHKCAGANPC
{
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	[CompilerGenerated]
	private sealed class NHHJNNMGKOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		public GIAKNOPIGAP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public NHHJNNMGKOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x76D93C0", Offset = "0x76D7BC0", VA = "0x1876D93C0")]
		internal object OAJCAOBCJDK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000709")]
	private readonly CLOGKADPIPJ OHGIFFBMEDO;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<JLLNKPIMHOC> HMOPDGCHAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x76D3970", Offset = "0x76D2170", VA = "0x1876D3970", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x76D3FB0", Offset = "0x76D27B0", VA = "0x1876D3FB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x8C0090", Offset = "0x8BE890", VA = "0x1808C0090")]
	[UnityEngine.Scripting.Preserve]
	public BGLDPLEMAJI([NDCFMLCHJCI(null)] CLOGKADPIPJ OHGIFFBMEDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x76D3680", Offset = "0x76D1E80", VA = "0x1876D3680", Slot = "6")]
	public bool AFNMDODAPKG(long NKDNOGOOODN, long ACPFGDPOKJK, MLONKGHJMMO BNCKJFBLGEG, GIAKNOPIGAP LGKPGNPIEMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x9E79E0", Offset = "0x9E61E0", VA = "0x1809E79E0")]
	private void KHPLEIDPLOC(JLLNKPIMHOC AAMKNFCFLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x76D3E40", Offset = "0x76D2640", VA = "0x1876D3E40", Slot = "7")]
	public bool FPCBAGECNJC(long NKDNOGOOODN, long ACPFGDPOKJK, [Out] JLLNKPIMHOC FIBEEOLBGPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x76D4060", Offset = "0x76D2860", VA = "0x1876D4060", Slot = "8")]
	public bool OPLECINMPBB(long NKDNOGOOODN, long ACPFGDPOKJK, GIAKNOPIGAP LGKPGNPIEMH, [Out] JLLNKPIMHOC FIBEEOLBGPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x76D3A20", Offset = "0x76D2220", VA = "0x1876D3A20")]
	private void CPJAECOIADE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x76D4110", Offset = "0x76D2910", VA = "0x1876D4110", Slot = "9")]
	public void PIJHEDPFLLH(long NKDNOGOOODN, long ACPFGDPOKJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal abstract class OINNEMGBIOO : CLOGKADPIPJ
{
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	protected enum EEFOHCCGCOG : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[CompilerGenerated]
	private sealed class MCAEOIJHJJE : IEnumerable<JLLNKPIMHOC>, IEnumerable, IEnumerator<JLLNKPIMHOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		private JLLNKPIMHOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public OINNEMGBIOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		private GIAKNOPIGAP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public GIAKNOPIGAP <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		private JLLNKPIMHOC System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600067E")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0xAC8700", Offset = "0xAC6F00", VA = "0x180AC8700")]
		[DebuggerHidden]
		public MCAEOIJHJJE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x76D8A30", Offset = "0x76D7230", VA = "0x1876D8A30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x76D8D10", Offset = "0x76D7510", VA = "0x1876D8D10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x76D8C60", Offset = "0x76D7460", VA = "0x1876D8C60", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JLLNKPIMHOC> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x76D8C60", Offset = "0x76D7460", VA = "0x1876D8C60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[CompilerGenerated]
	private sealed class DOCMEABDHAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		public GIAKNOPIGAP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public DOCMEABDHAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x76D4820", Offset = "0x76D3020", VA = "0x1876D4820")]
		internal object KCJFKOEPNDM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[CompilerGenerated]
	private sealed class LHAHPNCAOGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		public OINNEMGBIOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public LHAHPNCAOGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x76D8030", Offset = "0x76D6830", VA = "0x1876D8030")]
		internal void MMFOFFKECNG(CNBKIKKCFFH.LLONFBDKGHE ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400070F")]
	private readonly object JJGBIAGMLOH;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	protected string LKCCMFGOKGL
	{
		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x76D9C50", Offset = "0x76D8450", VA = "0x1876D9C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public abstract KLLAOFNPMJA CADNFLLMBOH
	{
		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x76D9E40", Offset = "0x76D8640", VA = "0x1876D9E40")]
	protected OINNEMGBIOO([CanBeNull] string FOOBHCJJGMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x76D9C60", Offset = "0x76D8460", VA = "0x1876D9C60", Slot = "5")]
	public bool PKJAILAIIMP(long NKDNOGOOODN, long ACPFGDPOKJK, GIAKNOPIGAP LGKPGNPIEMH, [Out] JLLNKPIMHOC AAMKNFCFLGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x76D9BC0", Offset = "0x76D83C0", VA = "0x1876D9BC0", Slot = "6")]
	[IteratorStateMachine(typeof(MCAEOIJHJJE))]
	public IEnumerable<JLLNKPIMHOC> FFMNOEADALP(GIAKNOPIGAP LGKPGNPIEMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void OHFGGEDGBPO(Stream OOCDKDGDPHL, long NKDNOGOOODN, long ACPFGDPOKJK, MLONKGHJMMO BNCKJFBLGEG);

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool CLKGIBCIMOD(Stream CIEAINNCHID, long NKDNOGOOODN, long ACPFGDPOKJK, DAJFKMBJBFC BPKMFMPBDKK, [Out] MLONKGHJMMO BNCKJFBLGEG);

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x76D9850", Offset = "0x76D8050", VA = "0x1876D9850", Slot = "7")]
	public JLLNKPIMHOC EILFLEBADIE(long NKDNOGOOODN, long ACPFGDPOKJK, MLONKGHJMMO BNCKJFBLGEG, GIAKNOPIGAP LGKPGNPIEMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo CKFEJDBNLBC(long NKDNOGOOODN, long ACPFGDPOKJK, GIAKNOPIGAP LGKPGNPIEMH, EEFOHCCGCOG GEJCFFIFNPB);

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo JNEBBEHDNIF(GIAKNOPIGAP LGKPGNPIEMH, EEFOHCCGCOG GEJCFFIFNPB);

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x76D97E0", Offset = "0x76D7FE0", VA = "0x1876D97E0")]
	protected void DGGHCDAJKBM(CNBKIKKCFFH.LLONFBDKGHE BIJMNBJJDDK, string HPJAAPABCEN, FileInfo OBAJHEBPDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x76D9430", Offset = "0x76D7C30", VA = "0x1876D9430")]
	internal bool CLGHFLKDCFL(FileInfo MMOKGJOPLKE, long NKDNOGOOODN, long ACPFGDPOKJK, [Out] MLONKGHJMMO BNCKJFBLGEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0")]
	private void PGIAONGLHON(Exception IACMJDBHAFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
internal class JOHCAOENPFC : OINNEMGBIOO
{
	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public override KLLAOFNPMJA CADNFLLMBOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x17A2660", Offset = "0x17A0E60", VA = "0x1817A2660", Slot = "8")]
		get
		{
			return default(KLLAOFNPMJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x76D7DF0", Offset = "0x76D65F0", VA = "0x1876D7DF0")]
	public JOHCAOENPFC([Optional] string FOOBHCJJGMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x76D7D70", Offset = "0x76D6570", VA = "0x1876D7D70")]
	private void PJMBKOGPHPG(GIAKNOPIGAP LGKPGNPIEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x76D7AE0", Offset = "0x76D62E0", VA = "0x1876D7AE0", Slot = "9")]
	internal override void OHFGGEDGBPO(Stream OOCDKDGDPHL, long NKDNOGOOODN, long ACPFGDPOKJK, MLONKGHJMMO BNCKJFBLGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x76D73F0", Offset = "0x76D5BF0", VA = "0x1876D73F0", Slot = "10")]
	internal override bool CLKGIBCIMOD(Stream CIEAINNCHID, long NKDNOGOOODN, long ACPFGDPOKJK, DAJFKMBJBFC BPKMFMPBDKK, [Out] MLONKGHJMMO BNCKJFBLGEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x76D7300", Offset = "0x76D5B00", VA = "0x1876D7300", Slot = "11")]
	protected override FileInfo CKFEJDBNLBC(long NKDNOGOOODN, long ACPFGDPOKJK, GIAKNOPIGAP LGKPGNPIEMH, EEFOHCCGCOG GEJCFFIFNPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x76D79E0", Offset = "0x76D61E0", VA = "0x1876D79E0", Slot = "12")]
	protected override DirectoryInfo JNEBBEHDNIF(GIAKNOPIGAP LGKPGNPIEMH, EEFOHCCGCOG GEJCFFIFNPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
internal sealed class IIPDLHIKKHL : OINNEMGBIOO
{
	[Cpp2IlInjected.Token(Token = "0x400071F")]
	private static readonly byte[] KCGKBDGKIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000720")]
	private readonly byte[] CGAGFEFIICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000721")]
	private readonly byte[] OGCGOHKDMAK;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public override KLLAOFNPMJA CADNFLLMBOH
	{
		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x636DAA0", Offset = "0x636C2A0", VA = "0x18636DAA0", Slot = "8")]
		get
		{
			return default(KLLAOFNPMJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x76D7210", Offset = "0x76D5A10", VA = "0x1876D7210")]
	public IIPDLHIKKHL([Optional] string FOOBHCJJGMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x76D6EC0", Offset = "0x76D56C0", VA = "0x1876D6EC0", Slot = "9")]
	internal override void OHFGGEDGBPO(Stream OOCDKDGDPHL, long NKDNOGOOODN, long ACPFGDPOKJK, MLONKGHJMMO BNCKJFBLGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x76D6510", Offset = "0x76D4D10", VA = "0x1876D6510", Slot = "10")]
	internal override bool CLKGIBCIMOD(Stream CIEAINNCHID, long NKDNOGOOODN, long ACPFGDPOKJK, DAJFKMBJBFC BPKMFMPBDKK, [Out] MLONKGHJMMO BNCKJFBLGEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x76D6CF0", Offset = "0x76D54F0", VA = "0x1876D6CF0")]
	private void GIHJJPNLHEH(byte[] LMGNHIJGDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x76D63E0", Offset = "0x76D4BE0", VA = "0x1876D63E0", Slot = "11")]
	protected override FileInfo CKFEJDBNLBC(long NKDNOGOOODN, long ACPFGDPOKJK, GIAKNOPIGAP LGKPGNPIEMH, EEFOHCCGCOG GEJCFFIFNPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x76D6DB0", Offset = "0x76D55B0", VA = "0x1876D6DB0", Slot = "12")]
	protected override DirectoryInfo JNEBBEHDNIF(GIAKNOPIGAP LGKPGNPIEMH, EEFOHCCGCOG GEJCFFIFNPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AA")]
public enum KLLAOFNPMJA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000723")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x4000724")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x4000725")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
internal class GGBBDEHABGA : CLOGKADPIPJ
{
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[CompilerGenerated]
	private sealed class GPFEGCFDADP : IEnumerable<JLLNKPIMHOC>, IEnumerable, IEnumerator<JLLNKPIMHOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		private JLLNKPIMHOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		public GGBBDEHABGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		private GIAKNOPIGAP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		public GIAKNOPIGAP <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		private KLLAOFNPMJA[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		private IEnumerator<JLLNKPIMHOC> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		private JLLNKPIMHOC System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60006A3")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60006A5")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0xAC8700", Offset = "0xAC6F00", VA = "0x180AC8700")]
		[DebuggerHidden]
		public GPFEGCFDADP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x76D5F40", Offset = "0x76D4740", VA = "0x1876D5F40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x76D5B10", Offset = "0x76D4310", VA = "0x1876D5B10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x76D5DF0", Offset = "0x76D45F0", VA = "0x1876D5DF0")]
		private void PPNAIGJNIFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x76D5EF0", Offset = "0x76D46F0", VA = "0x1876D5EF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x76D5E40", Offset = "0x76D4640", VA = "0x1876D5E40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JLLNKPIMHOC> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x76D5E40", Offset = "0x76D4640", VA = "0x1876D5E40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000726")]
	private readonly KLLAOFNPMJA[] KKDKPCLILCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000727")]
	private readonly Dictionary<KLLAOFNPMJA, CLOGKADPIPJ> EMBKKJOOMIM;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public KLLAOFNPMJA CADNFLLMBOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x76D5640", Offset = "0x76D3E40", VA = "0x1876D5640", Slot = "4")]
		get
		{
			return default(KLLAOFNPMJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x76D57C0", Offset = "0x76D3FC0", VA = "0x1876D57C0")]
	[UnityEngine.Scripting.Preserve]
	public GGBBDEHABGA(params CLOGKADPIPJ[] FHNLMJJMDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x76D5670", Offset = "0x76D3E70", VA = "0x1876D5670", Slot = "5")]
	public bool PKJAILAIIMP(long NKDNOGOOODN, long ACPFGDPOKJK, GIAKNOPIGAP LGKPGNPIEMH, [Out] JLLNKPIMHOC AAMKNFCFLGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x76D5410", Offset = "0x76D3C10", VA = "0x1876D5410")]
	private void GHPGONFHOCH(int PHOMFKCBKHB, long NKDNOGOOODN, long ACPFGDPOKJK, GIAKNOPIGAP LGKPGNPIEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x76D5380", Offset = "0x76D3B80", VA = "0x1876D5380", Slot = "6")]
	[IteratorStateMachine(typeof(GPFEGCFDADP))]
	public IEnumerable<JLLNKPIMHOC> FFMNOEADALP(GIAKNOPIGAP LGKPGNPIEMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x76D5230", Offset = "0x76D3A30", VA = "0x1876D5230", Slot = "7")]
	public JLLNKPIMHOC EILFLEBADIE(long NKDNOGOOODN, long ACPFGDPOKJK, MLONKGHJMMO BNCKJFBLGEG, GIAKNOPIGAP LGKPGNPIEMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
internal static class MFPAKBBFHLI
{
	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x76D8D60", Offset = "0x76D7560", VA = "0x1876D8D60")]
	internal static byte[] DNMKFAFNEKG(byte[] LMGNHIJGDNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x76D8E20", Offset = "0x76D7620", VA = "0x1876D8E20")]
	public static void HHDBLBCBBGK(Stream NMANOCJJAAG, byte[] ENMADFLMDEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x76D8EA0", Offset = "0x76D76A0", VA = "0x1876D8EA0")]
	public static bool JFPOKKCDPME(Stream NMANOCJJAAG, long FAGEEIJHONJ, DAJFKMBJBFC GLCPJOCNFLI, [Out] byte[] GNBBFAMCKFJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
internal sealed class BPAIMEGPCNB : JLLNKPIMHOC, IEquatable<JLLNKPIMHOC>, IEquatable<BPAIMEGPCNB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000735")]
	private readonly OINNEMGBIOO KMBNMBPCDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000736")]
	public readonly FileInfo JJOCMIKPJEF;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public KLLAOFNPMJA CADNFLLMBOH
	{
		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x7041450", Offset = "0x703FC50", VA = "0x187041450", Slot = "9")]
		get
		{
			return default(KLLAOFNPMJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public DateTime MCCNHHGDJON
	{
		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x76D4220", Offset = "0x76D2A20", VA = "0x1876D4220", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x76D4710", Offset = "0x76D2F10", VA = "0x1876D4710")]
	public BPAIMEGPCNB(OINNEMGBIOO MPJFMCAEJPG, FileInfo MMOKGJOPLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x76D4660", Offset = "0x76D2E60", VA = "0x1876D4660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x76D44D0", Offset = "0x76D2CD0", VA = "0x1876D44D0", Slot = "5")]
	public void GLMAONNMJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x76D4620", Offset = "0x76D2E20", VA = "0x1876D4620", Slot = "6")]
	public bool MKODCJJEDIH(long NKDNOGOOODN, long ACPFGDPOKJK, [Out] MLONKGHJMMO BNCKJFBLGEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x76D42B0", Offset = "0x76D2AB0", VA = "0x1876D42B0", Slot = "7")]
	public bool Equals(JLLNKPIMHOC LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x76D4410", Offset = "0x76D2C10", VA = "0x1876D4410", Slot = "8")]
	public bool Equals(BPAIMEGPCNB LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0x76D4320", Offset = "0x76D2B20", VA = "0x1876D4320", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0x76D4590", Offset = "0x76D2D90", VA = "0x1876D4590", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public delegate void DAJFKMBJBFC(CNBKIKKCFFH.LLONFBDKGHE FJINKEMJCEP, string PJFOMDHJLBF);
[Cpp2IlInjected.Token(Token = "0x20001B1")]
internal interface CLOGKADPIPJ
{
	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	KLLAOFNPMJA CADNFLLMBOH
	{
		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PKJAILAIIMP(long NKDNOGOOODN, long ACPFGDPOKJK, GIAKNOPIGAP LGKPGNPIEMH, [Out] JLLNKPIMHOC AAMKNFCFLGD);

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<JLLNKPIMHOC> FFMNOEADALP(GIAKNOPIGAP LGKPGNPIEMH);

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JLLNKPIMHOC EILFLEBADIE(long NKDNOGOOODN, long ACPFGDPOKJK, MLONKGHJMMO BNCKJFBLGEG, GIAKNOPIGAP LGKPGNPIEMH);
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
