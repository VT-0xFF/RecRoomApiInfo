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
		[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7047BD0", Offset = "0x70461D0", VA = "0x187047BD0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x888570", Offset = "0x886B70", VA = "0x180888570")]
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
		[Cpp2IlInjected.Address(RVA = "0x8885B0", Offset = "0x886BB0", VA = "0x1808885B0")]
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
	public class LogRegistrationIndex : MHGCIIOBNMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7044120", Offset = "0x7042720", VA = "0x187044120", Slot = "4")]
		public override void OOMCOBOGONK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BKKDJOODNLA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x702CDA0", Offset = "0x702B3A0", VA = "0x18702CDA0")]
	public BKKDJOODNLA(string DICMABMCPKO, Exception GKKDKGGMLEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class MGKCIDKNJIC : PAFLHMCMBKP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct PNPNKIOFHDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<KOKKKOEPCAE>> <>t__builder;

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
		private TaskAwaiter<PNDLHEEAPIF<KOKKKOEPCAE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7049C90", Offset = "0x7048290", VA = "0x187049C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7049ED0", Offset = "0x70484D0", VA = "0x187049ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct JJBDAECOPEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<DOGLCKEJJAA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<DOGLCKEJJAA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x703ED20", Offset = "0x703D320", VA = "0x18703ED20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x703EF30", Offset = "0x703D530", VA = "0x18703EF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	[UnityEngine.Scripting.Preserve]
	public MGKCIDKNJIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7044740", Offset = "0x7042D40", VA = "0x187044740", Slot = "4")]
	[AsyncStateMachine(typeof(PNPNKIOFHDD))]
	public Task<IReadOnlyList<KOKKKOEPCAE>> PLALFLMEKJI(long ECHGOOGHLEN, long IMIHMEAMIDO, [Optional] CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7044630", Offset = "0x7042C30", VA = "0x187044630", Slot = "5")]
	[AsyncStateMachine(typeof(JJBDAECOPEK))]
	public Task<IReadOnlyList<DOGLCKEJJAA>> LELNOGIONNG(IReadOnlyList<int> OPKMOCFGGIH, [Optional] CancellationToken NNGMAHIDECE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OLBKKCHDBNJ : IEquatable<OLBKKCHDBNJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int OIKJCJNLIHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	DOGLCKEJJAA FGIMFDJNPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime DGNIICODFNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	HPAPCIPDNHJ? GBFKDKDPDFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	FNINODBCGAG? BLCINFPOBMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	NEECAIHOCMD CBMCHOCEDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<HPDKHMJHFIJ> AGLGMGGFAGM();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum NEECAIHOCMD
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PAFLHMCMBKP
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<KOKKKOEPCAE>> PLALFLMEKJI(long ECHGOOGHLEN, long IMIHMEAMIDO, [Optional] CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<DOGLCKEJJAA>> LELNOGIONNG(IReadOnlyList<int> OPKMOCFGGIH, [Optional] CancellationToken NNGMAHIDECE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class KELOCDEFDPP
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class DEJNADKNABM : OLBKKCHDBNJ, IEquatable<OLBKKCHDBNJ>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct LOMOBKANFLA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<HPDKHMJHFIJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public DEJNADKNABM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private LKKHHDMCBHJ <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<EKOKDGMBHGJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<HPDKHMJHFIJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7043C10", Offset = "0x7042210", VA = "0x187043C10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x70440B0", Offset = "0x70426B0", VA = "0x1870440B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly KOKKKOEPCAE NEDLBPIPGEK;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int OIKJCJNLIHB
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x861EB0", Offset = "0x8604B0", VA = "0x180861EB0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public DOGLCKEJJAA FGIMFDJNPKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime AAHBAPEBFJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x5BF31A0", Offset = "0x5BF17A0", VA = "0x185BF31A0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HPAPCIPDNHJ? GBFKDKDPDFO
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1CFF040", Offset = "0x1CFD640", VA = "0x181CFF040", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public FNINODBCGAG? BLCINFPOBMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5BF3280", Offset = "0x5BF1880", VA = "0x185BF3280", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public NEECAIHOCMD CBMCHOCEDIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x9BD990", Offset = "0x9BBF90", VA = "0x1809BD990", Slot = "10")]
			get
			{
				return default(NEECAIHOCMD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7032290", Offset = "0x7030890", VA = "0x187032290", Slot = "9")]
		[AsyncStateMachine(typeof(LOMOBKANFLA))]
		public Task<HPDKHMJHFIJ> AGLGMGGFAGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7032580", Offset = "0x7030B80", VA = "0x187032580")]
		public DEJNADKNABM(int JMKAODIAGGC, DOGLCKEJJAA GJGOLOJPPMD, KOKKKOEPCAE NEDLBPIPGEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7032470", Offset = "0x7030A70", VA = "0x187032470", Slot = "11")]
		public bool Equals(OLBKKCHDBNJ OGEIJLCLBIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x70323D0", Offset = "0x70309D0", VA = "0x1870323D0", Slot = "0")]
		public override bool Equals(object CDBNFNMIHPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7032390", Offset = "0x7030990", VA = "0x187032390")]
		private bool EGBHDAFCIIO(DEJNADKNABM OGEIJLCLBIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7032500", Offset = "0x7030B00", VA = "0x187032500", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class DKAABGJMKCA : OLBKKCHDBNJ, IEquatable<OLBKKCHDBNJ>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct BEDMHFEBJPI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<HPDKHMJHFIJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public DKAABGJMKCA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<HPDKHMJHFIJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x702CA00", Offset = "0x702B000", VA = "0x18702CA00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x702CC30", Offset = "0x702B230", VA = "0x18702CC30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly BIELPDNJBMP BALBBAHKBII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HPAPCIPDNHJ GIIEBPBMMPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly FNINODBCGAG LLBCGJFCAKP;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int OIKJCJNLIHB
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7033B30", Offset = "0x7032130", VA = "0x187033B30", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public DOGLCKEJJAA FGIMFDJNPKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x70338F0", Offset = "0x7031EF0", VA = "0x1870338F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime AAHBAPEBFJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7033C40", Offset = "0x7032240", VA = "0x187033C40", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public HPAPCIPDNHJ? GBFKDKDPDFO
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7033BF0", Offset = "0x70321F0", VA = "0x187033BF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public FNINODBCGAG? BLCINFPOBMO
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x70338A0", Offset = "0x7031EA0", VA = "0x1870338A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public NEECAIHOCMD CBMCHOCEDIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9C0200", Offset = "0x9BE800", VA = "0x1809C0200", Slot = "10")]
			get
			{
				return default(NEECAIHOCMD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1290500", Offset = "0x128EB00", VA = "0x181290500")]
		public DKAABGJMKCA(BIELPDNJBMP BABFHOIKFOI, HPAPCIPDNHJ KNLBGFEICJJ, FNINODBCGAG OBGMDBOKFHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x70337B0", Offset = "0x7031DB0", VA = "0x1870337B0", Slot = "9")]
		[AsyncStateMachine(typeof(BEDMHFEBJPI))]
		public Task<HPDKHMJHFIJ> AGLGMGGFAGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7033A90", Offset = "0x7032090", VA = "0x187033A90", Slot = "11")]
		public bool Equals(OLBKKCHDBNJ OGEIJLCLBIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x70339E0", Offset = "0x7031FE0", VA = "0x1870339E0", Slot = "0")]
		public override bool Equals(object CDBNFNMIHPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7033980", Offset = "0x7031F80", VA = "0x187033980")]
		private bool EGBHDAFCIIO(DKAABGJMKCA OGEIJLCLBIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7033B70", Offset = "0x7032170", VA = "0x187033B70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class BKMIAHCDPGP : OLBKKCHDBNJ, IEquatable<OLBKKCHDBNJ>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct IMANMKLBBBI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<HPDKHMJHFIJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<HPDKHMJHFIJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7039060", Offset = "0x7037660", VA = "0x187039060", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x70392A0", Offset = "0x70378A0", VA = "0x1870392A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly DOGLCKEJJAA JNMADPNDJCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly HPAPCIPDNHJ GIIEBPBMMPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly FNINODBCGAG LLBCGJFCAKP;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int OIKJCJNLIHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x702D240", Offset = "0x702B840", VA = "0x18702D240", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public DOGLCKEJJAA FGIMFDJNPKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime AAHBAPEBFJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public HPAPCIPDNHJ? GBFKDKDPDFO
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x702D2F0", Offset = "0x702B8F0", VA = "0x18702D2F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public FNINODBCGAG? BLCINFPOBMO
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x702CEE0", Offset = "0x702B4E0", VA = "0x18702CEE0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public NEECAIHOCMD CBMCHOCEDIN
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "10")]
			get
			{
				return default(NEECAIHOCMD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1290500", Offset = "0x128EB00", VA = "0x181290500")]
		public BKMIAHCDPGP(DOGLCKEJJAA GJGOLOJPPMD, HPAPCIPDNHJ KNLBGFEICJJ, FNINODBCGAG OBGMDBOKFHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x702CE10", Offset = "0x702B410", VA = "0x18702CE10", Slot = "9")]
		[AsyncStateMachine(typeof(IMANMKLBBBI))]
		public Task<HPDKHMJHFIJ> AGLGMGGFAGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x702D010", Offset = "0x702B610", VA = "0x18702D010", Slot = "11")]
		public bool Equals(OLBKKCHDBNJ OGEIJLCLBIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x702D120", Offset = "0x702B720", VA = "0x18702D120", Slot = "0")]
		public override bool Equals(object CDBNFNMIHPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x702D260", Offset = "0x702B860", VA = "0x18702D260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x702CF30", Offset = "0x702B530", VA = "0x18702CF30")]
		private bool EGBHDAFCIIO(BKMIAHCDPGP OGEIJLCLBIC)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct HBDEKOPPHPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<OLBKKCHDBNJ>> <>t__builder;

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
		public KELOCDEFDPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<KOKKKOEPCAE> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<KOKKKOEPCAE>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, DOGLCKEJJAA account, KOKKKOEPCAE roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7036C80", Offset = "0x7035280", VA = "0x187036C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7037AB0", Offset = "0x70360B0", VA = "0x187037AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct GEEGCFJFJGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, DOGLCKEJJAA account, KOKKKOEPCAE roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<KOKKKOEPCAE> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public KELOCDEFDPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<DOGLCKEJJAA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x70357C0", Offset = "0x7033DC0", VA = "0x1870357C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7036170", Offset = "0x7034770", VA = "0x187036170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MBOFBMMLAGF GILNADCKGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly PAFLHMCMBKP ENDKBOANGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly GFNJPGHEMJE MPJLLNAFAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly LKGLDJOEKJK<(long, long), IReadOnlyList<KOKKKOEPCAE>> BDDOBCKNLND;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x703F3D0", Offset = "0x703D9D0", VA = "0x18703F3D0")]
	[UnityEngine.Scripting.Preserve]
	public KELOCDEFDPP([JLPFJOFFNLM(null)] PAFLHMCMBKP DIFOMJICDBL, [JLPFJOFFNLM(null)] GFNJPGHEMJE KGHFNFDCOPP, [JLPFJOFFNLM(null)] MBOFBMMLAGF CDLHDKALBFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x703F0E0", Offset = "0x703D6E0", VA = "0x18703F0E0")]
	[AsyncStateMachine(typeof(HBDEKOPPHPN))]
	public Task<IList<OLBKKCHDBNJ>> EEHCKCAFELK(long ECHGOOGHLEN, long OAOPHNECJFF, bool GDKKPIKDIKA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x703F230", Offset = "0x703D830", VA = "0x18703F230")]
	private bool KNNMCDOOIDC(DateTime? HNGEIOCNJPH, long ECHGOOGHLEN, long OAOPHNECJFF, [Out] BIELPDNJBMP CKBPCDCCCCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x703EFD0", Offset = "0x703D5D0", VA = "0x18703EFD0")]
	[AsyncStateMachine(typeof(GEEGCFJFJGF))]
	private Task<IReadOnlyList<(int, DOGLCKEJJAA, KOKKKOEPCAE)>> DNDDPNKHIEJ(IReadOnlyList<KOKKKOEPCAE> IOJEHJHOLEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface GFNJPGHEMJE
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<BIELPDNJBMP> DDGAAHOGJCF;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DEJJMPLODJG(long ECHGOOGHLEN, long OAOPHNECJFF, CAKNPLNONPM HGFOMMCAKDA, OPKNKODACNB KHBEOAAPNLC);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KGICLOPBFMC(long ECHGOOGHLEN, long OAOPHNECJFF, [Out] BIELPDNJBMP CKBPCDCCCCH);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EHNPOIAENOL(long ECHGOOGHLEN, long OAOPHNECJFF, OPKNKODACNB KHBEOAAPNLC, [Out] BIELPDNJBMP CKBPCDCCCCH);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BBHIKINGEDE(long ECHGOOGHLEN, long OAOPHNECJFF);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface ENDOPHJFGJG : BDDMINNAEKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool JMJLHKGMHJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task JOPMDLDHDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FFOBHDKLFPI(Task OOOMFPPINLE, string EHLHABFAPCH);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface AMOHHLGBNJG : BDDMINNAEKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HPDKHMJHFIJ> BOGLHKNCCDK(BIELPDNJBMP CKBPCDCCCCH);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MMLHKFJOEGH(CancellationToken NNGMAHIDECE);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface GKJFBPNEODH : BDDMINNAEKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	PKDAPLNAFOM LBEOBFABIPE
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MJCDNEDGNMD();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MDEKGKAHOOA();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface BDDMINNAEKA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HGDANEHJCNG(DGKBIEGBPPF EGEPJAHBNCI);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface NOPIHKDGHEM
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan AEKEBKKFOAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan MNICAKGAGDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan HECMOBAMLAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan ECEHINCLMHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool DCEKFECKNCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool GDOPKLIOFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool KLDCKDFKFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int FPHICKHGJBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool CNBFEIKNNIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool AHLEMFAMANO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum HHGIICPMLKO
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum NNMIPMOFGJK
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
public struct CAEPJJKBGAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long FFEKDADGCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long IMIHMEAMIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly HHGIICPMLKO BDKLEMDNAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception HCAGJKCCJAP;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x702D5F0", Offset = "0x702BBF0", VA = "0x18702D5F0")]
	public CAEPJJKBGAM(long FFEKDADGCCD, long IMIHMEAMIDO, HHGIICPMLKO BDKLEMDNAFL, [CanBeNull] Exception HCAGJKCCJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x702D5A0", Offset = "0x702BBA0", VA = "0x18702D5A0")]
	public static CAEPJJKBGAM AINDKFFJENA(HGMCNBIJHOL HDODKJGHNLD, HHGIICPMLKO BDKLEMDNAFL, [Optional] Exception HCAGJKCCJAP)
	{
		return default(CAEPJJKBGAM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public delegate void LIAFHIFBOFC(CAEPJJKBGAM JOJBNKNAMMG);
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface FPHIMNNAHMP : BDDMINNAEKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action MHJAEIMMLMK;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event LIAFHIFBOFC CLFHMKMEGOO;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event LIAFHIFBOFC OFPPJILNJJP;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event LIAFHIFBOFC BEAPLNLIKMK;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<NNMIPMOFGJK, bool> ILDALLJEKCE;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DFKPIONBOGO();

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FKPNMAHKCKI(CAEPJJKBGAM JOJBNKNAMMG);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MALNHCJCMGH(CAEPJJKBGAM JOJBNKNAMMG);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void IBEDLAINJLC(CAEPJJKBGAM JOJBNKNAMMG);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GGFBGMHJCMN(NNMIPMOFGJK FKCGACHMIMJ, bool GCPCBKFMNEC);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface CBNCHEIGJNK : BDDMINNAEKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task LLMMKNIOFOM();

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PMFIKIGNHHJ();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface BEFGPGKBHMM : BDDMINNAEKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TaskStatus LDMIANDNKJM
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AJPCKIFKKEN(HGMCNBIJHOL EKIDHODEHNL, CHINJLLPBEH NMCCKLHAGJO, CancellationToken MEHJFMOAFKE);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class LFDMCEOEHGM
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7040430", Offset = "0x703EA30", VA = "0x187040430")]
	public static bool CEPPKNFOFAC(this BEFGPGKBHMM OGHKBAKCDJN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public delegate Task IIENCKKFJNG(CancellationToken PNPIGCGKNPI, int GJEBBAHEDKL, IDJDNLONMLP COJGCKPIFMN);
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface ECPEOHHOAOL : BDDMINNAEKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KECEPNLJCDL(IIENCKKFJNG FCNFFPKAABK);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface DGKBIEGBPPF : LKKHHDMCBHJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CancellationToken KKLCDICHHFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	JJHPIOCMJGA OBFCFHGMNAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	FLALAMNEBHN PAFBFMHOLND
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	GPPKJFODOCJ OJHMGHPFOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NLIIDIBLEBA NMJFDBBPKEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	CFHJOIPDCCN JMGILNODGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	BMOLNLPEKDN ELNKLDKJHPM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	JEMHDCFBCKM HCJHELPGGNI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	ICAOLNNEGIC IMECHDBEAHL
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	ENDOPHJFGJG CKLLJFIMHHF
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	AMOHHLGBNJG KDOEAMKKFMO
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	FPHIMNNAHMP AIEOELGMNJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	CBNCHEIGJNK LDJMBJKBNJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	BEFGPGKBHMM KHCNDBMFOOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	ECPEOHHOAOL NMGEICFJOLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	MLAFDPCGOID IKHAGGJHICD
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	OACLDMMDJLL MPAAMOFIAED
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	FFCNIOJJAOM BHFCFOIKDDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	HCOHAMMHFKP MMEJPEFBILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	CPFKOHNEIKA IBLPLFEKNMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	HAPFKOABDCC BDLPNJIFDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	DAEJDKENKKH GHELIDPFNEE
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	LJKKPKNLFFF GBBCNBJFICH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	PIJGIFBANNP LGCNNGJFDLK
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	JJKDBLEGMEM FOADOOKABBP
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	GKJFBPNEODH EPNJMBCBEAF
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	NOPIHKDGHEM BKOJDDCCGIM
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	NCJGPNIIKEP GAJLKDALILJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	GFNJPGHEMJE OCJEMEHGEIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	FKCNEOBHCBA NIOHKGGFIIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	DKFFGDNDPIF JNNDLMCPGDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	MADIJKNICIM NKNEJCGECMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	MHAKOOGAPLD EMDPAMPILFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void JKKIBFAJIHD(CHINJLLPBEH GKJOIAOMFCC);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface MLAFDPCGOID : BDDMINNAEKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FDCHOCHDFOM AGMNBECNIJC(Guid MKCPOIIDFLO);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PJEMHMBEIPM(Guid MKCPOIIDFLO);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JMIEBFPPGBO(Guid MKCPOIIDFLO, Task INPIIKLJFOM);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DMEHGDGKLHP(Guid MKCPOIIDFLO, HPDKHMJHFIJ LDBMKFAKLIM);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(HPDKHMJHFIJ, Task)> HEIGEJKBANA(Guid MKCPOIIDFLO);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface LGPGDJGLGNL : BDDMINNAEKA, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface OACLDMMDJLL : BDDMINNAEKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LILCEKMPPPB(JFFNGMFLFPF DICMABMCPKO);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GBIOHJAFNJD(JFFNGMFLFPF DICMABMCPKO);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<NPEAHLFIFPI> JKPIGBDDNBN(CancellationToken IAIMOGBPDOA);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface FFCNIOJJAOM : BDDMINNAEKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FDCHOCHDFOM AAOEDLJENBE(JFFNGMFLFPF PECBFCDENDO);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKEOBIMGNIF(Guid MKCPOIIDFLO, Task INPIIKLJFOM);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface HCOHAMMHFKP : BDDMINNAEKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HPDKHMJHFIJ> MMEJPEFBILJ(JFFNGMFLFPF ACIHLJMOGPE);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface CPFKOHNEIKA : BDDMINNAEKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LDJGBBGIHDL> NCPBBGGLGJP(NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, HGMCNBIJHOL EKIDHODEHNL, CancellationToken NNGMAHIDECE);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface DAEJDKENKKH : BDDMINNAEKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HPDKHMJHFIJ KCMJDPAEHIM(HDIGMKHIDBN PPBAIHEIPKK);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OBJFJFFDKBE(string DLMOEDNDKJK);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface HAPFKOABDCC : BDDMINNAEKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JFFNGMFLFPF> MIDLNKGDLCK(JFFNGMFLFPF FALAJMPCHDK, HHMJIEMKLLO MMKIPOAGEKJ, CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<JFFNGMFLFPF> DMEGJKLFEPI(CancellationToken NNGMAHIDECE, HHMJIEMKLLO MMKIPOAGEKJ);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CHNELKEAFEA JMGPADOLCEF(EMCBHBKNJFL KJKHIMDGLFJ, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CHNELKEAFEA MCJJLNHAAAP(EMCBHBKNJFL KJKHIMDGLFJ, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface LJKKPKNLFFF : BDDMINNAEKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HPDKHMJHFIJ DAPOBGBCIKF(HDIGMKHIDBN PPBAIHEIPKK, NPEAHLFIFPI GDINAMIEDDO);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HPDKHMJHFIJ HJMJNKNNJME(HDIGMKHIDBN FDIALPLINAD);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface PIJGIFBANNP
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CIHIHKGKCHB(LHGAEDBCFJB DFJKPCLNBOG);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IHPOOEGLILO(LHGAEDBCFJB DFJKPCLNBOG);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HIOEIOLHAIK(LHGAEDBCFJB DFJKPCLNBOG);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OJFKGFJHNBA(LHGAEDBCFJB DFJKPCLNBOG);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class LHGAEDBCFJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly HGMCNBIJHOL OIJBIAAANNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> AFHDGAIAGDM;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public NEGKJPNCLPM<string> MKOKAOEPFNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x85F460", Offset = "0x85DA60", VA = "0x18085F460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8682B0", Offset = "0x8668B0", VA = "0x1808682B0")]
	public LHGAEDBCFJB(HGMCNBIJHOL NIMHLKENONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7040E90", Offset = "0x703F490", VA = "0x187040E90")]
	public LHGAEDBCFJB LOKIEOLHFFI(string MNBFPOFIDHA, string FEBGGALLBNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7040F60", Offset = "0x703F560", VA = "0x187040F60")]
	public bool PPIEBEOFHOB([Out] IEnumerable<KeyValuePair<string, string>> LOLJNLKBPGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x62C2230", Offset = "0x62C0830", VA = "0x1862C2230")]
	public LHGAEDBCFJB EKKMFFBOIEN(NEGKJPNCLPM<string> CIAFJLABOOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface NCJGPNIIKEP
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool EHFNDPHAACB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	string EBCLHCEDMDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool EJKEAANOOEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KMOPOCKIKCI();

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FLPAFHNPOFI EAHABGOKBBB(long POCGMPECBEJ);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GHCPBJHELOE<LDJPCHCCHLD, BNHGPMCKPJN> AADHGPOEHEI(long POCGMPECBEJ);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GHCPBJHELOE<LDJPCHCCHLD, POGNJKLFFHD> IFIPLMGMMOA(long POCGMPECBEJ);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GHCPBJHELOE<long, JMMMIGLLOBM> ACLPFFHFAIP();

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool OLKFDPEFNHB(long POCGMPECBEJ, [Out] bool MJBJKEAMKAN);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> EEHOJANDNEF(byte[] OFJHEAGKPLP, byte[] NJMMPFKJOJO, CancellationToken NNGMAHIDECE);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface LKKHHDMCBHJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool CEPPKNFOFAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool OPAINMLKAHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	CHINJLLPBEH HOCICNPBMEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action MHJAEIMMLMK;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event LIAFHIFBOFC CLFHMKMEGOO;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event LIAFHIFBOFC OFPPJILNJJP;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event LIAFHIFBOFC BEAPLNLIKMK;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<NNMIPMOFGJK, bool> ILDALLJEKCE;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PMFIKIGNHHJ();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	MCOCJALIEAM BELAFELHOAG();

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GKINIHEDCFF FIEGBKHOKFC();

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<HPDKHMJHFIJ> BOGLHKNCCDK(BIELPDNJBMP BABFHOIKFOI);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task MMLHKFJOEGH(CancellationToken NNGMAHIDECE);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface CFHJOIPDCCN
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool KHLIIOLNAMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	string DKBGINBNLBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FPBNBHEDODJ(Scene EEEMHAOKMMO);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task KDEPOIFHGEE(MNBHNPFBECL HGFAJCKJIAE, CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task HGMJBLLAJFI();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task HIKODPJMAPN();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface NLIIDIBLEBA
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	CKDFPPPACKB IMNGEJLDDEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool CLDLBJAOAJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool KHADIKAFMPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool EJOABENMOHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool PGJKLCLNCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	int KNFFBGJFAAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool EKAINDMBCKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool MDDLFPOKEBB
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	byte ECIAKAPDBOP
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	byte LKNIOLDCPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool PPKMIDCHGID
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool KGEFEHNKMOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool EHHPKPLJGDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	float KIODMCOEMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> GJGGOEICCGG;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JJHPIOCMJGA BIKMADKNKHM(JJHPIOCMJGA LICOOADAAEP);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AKFBENHMCKJ(JJHPIOCMJGA CEJMOFAPBGN);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DNOAEBENHAN();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task AAFEHGEMJCP(NEGKJPNCLPM<string>.GBKOFALFHEN AJPGBHLDMIL, CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DJPJCPDNHAP(float BHBOBILKEHI);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GGLHBMLKNJM(string FNOBCMGGGAK);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<MPFADGNIAME> MCDOOGICPID();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable BDFABMOKHGD(object MGIHCPMKPNG, MPFADGNIAME CFHMBPIJFPA);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<BBGLIDIDMGK> ABCBNNALDKN();

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	BNHGPMCKPJN COCHBKFBCJH(IEnumerable<LMPEJKGKMKJ> AOPMGJBBKAL);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FHOACEKINEB(int JLNNPAODCHJ);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task PLDODJJOFOB();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CFNMMKJHGPL();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool CMEEAIBEMLP();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task GOAPCDGPKFC(CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task NPMJBIGPACP(CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<OOCFMPGIAFO> BDPGJPCDGHD(DateTime ACOPLPHCGCD, CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> OJLJMDLKBDG(CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void ALNDNBIAGIA(string DICMABMCPKO = "", float FNIKMIIBLGN = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "25")]
	NNIKKLPFIGN FIIKPKMEBPG(AJMJLMGBAMP ONKAHOPPDIC, ALIKKKIHOKB EBOLFKEGOIA, POGNJKLFFHD GCCIBPNMOIL, IEnumerable<PersistenceView> JGJFIICGGKO, OBAOHHAJPLG HKGCLHPIKMC);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void LCKBNHKDELC(POGNJKLFFHD GCCIBPNMOIL);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void CKOHPDGCNKD(LMPEJKGKMKJ DKPOEEMNGFI, [In] NNIKKLPFIGN BLLPKOOEJEP);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task COBBCKOIBII(POGNJKLFFHD ICLJKMONAMK, bool FOJBFIGCAHK, CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task DONMGAOADAP(CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void HHDHAFMACHC(long ECHGOOGHLEN, long IMIHMEAMIDO, EKOKDGMBHGJ OEAIHDKDLGD, KOKKKOEPCAE OKNFENGOICE, CAKNPLNONPM HGFOMMCAKDA, BMGKDPAHECJ? DIKOOGMNLMJ, GFELCKADMED? NMEIHJFPJBM);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void GMGAAEFDDFE(long ECHGOOGHLEN, long IMIHMEAMIDO, GFELCKADMED? NMEIHJFPJBM);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void HFLKAMIAODL(PersistenceView NPMPCCEOKJL);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool LAAGGCCNMOL(PersistenceView EEOIFKIKDHI);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool MKDFABMLFPE(LMPEJKGKMKJ DKPOEEMNGFI, FDIPOBCALOO NNKBKLLGGLD, [Out] HDMHBEBAKGM NHCFKPDINDN);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task NNLEPBFPMFA(CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void PBLGNCJGPCP();

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable BEEPANKILIL();

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void PBFFOKCFPKP(POGNJKLFFHD ICLJKMONAMK, FDIPOBCALOO NNKBKLLGGLD);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<bool> MPHDOFHDAHM(FLALAMNEBHN DKJHBDBMIJF, CancellationToken NNGMAHIDECE, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void KJAIKPJHKLC(CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<BIEOLNCJFEB> BGLDIBDLCDE(GIPDGIEDHAK FALAJMPCHDK);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<EKOKDGMBHGJ> JPCFJOOCOBO(long ECHGOOGHLEN, bool LBDLPMILLOE, CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<KOKKKOEPCAE> KFAJDDOACCF(long ECHGOOGHLEN, long IMIHMEAMIDO, long CIDNMNIGDJH, CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<KOKKKOEPCAE> CHJCAMDEJGK(long ECHGOOGHLEN, long IMIHMEAMIDO, CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<HMNDMLKHLEG> MIHGPHNGGNM(string CHJGLFCKEKA, CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<HMNDMLKHLEG> KEKOGBBNOHK(string CHJGLFCKEKA, long ECHGOOGHLEN, long IMIHMEAMIDO, string EGPKGHKFCDG, PMHJNGIOAJD.HPEKFHFFOEA BMLBCLGKFJE, PMHJNGIOAJD.HPEKFHFFOEA NJMMPFKJOJO, int GENJLEKEJPN);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool FIILOGOAHEI();

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "49")]
	bool DHAHDMIOEKA();

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool FFEBGJECLLO(IEnumerable<HDMHBEBAKGM> AKEIGIABMML);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void KCMPCGHFDCA(List<GameObject> KGJGLMCIMKD);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "52")]
	float ONCLMLMFCOA();

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "53")]
	Task<Scene> EJJDCDPEJOH(string FHGJMMBJGMK, LoadSceneMode HFGEFFBKFGC, bool PONEJMNBEPI, NEGKJPNCLPM<string>.GBKOFALFHEN CIAFJLABOOB);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void NFIJNDOFJJF();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void IIHPLDEABNG(bool BNHEOAIMLAC);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void AHAPENINMMH();

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void DOAIODBMOOH();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void LHCFBNGLKIC(HGMCNBIJHOL BIPKJPPNHLB);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Task EHIDBDCEHHA(NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "69")]
	Task KEBAODANLAN(NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "70")]
	Task GIILOHKNNLA(NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "71")]
	Task LMPHEMFGDGA(NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "72")]
	IDisposable EKBCBFMNPKK();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "73")]
	BHIJAPGKLNN CKBPBNNFENL();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task GAHOOIEOCIC(CancellationToken NNGMAHIDECE);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface BHIJAPGKLNN
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PLAILEEJMFF(CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HFDPKLNLDPI(CancellationToken NNGMAHIDECE);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct NNIKKLPFIGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> ACDCJDBAAFH;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum OOCFMPGIAFO : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct AJMJLMGBAMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string JBDOCHAPBFC;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface CKDFPPPACKB
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	HGMCNBIJHOL OGKLDAINFOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	EKOKDGMBHGJ IMBPCENLKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	DCPEFLIKEJN HFLJACGAIMA
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool BPKLJIEKNJK
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool KOPLHCPABDD
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	int GKNOOMLMIBF
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action EGEMNBIGBCE;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> GDOIKJBHHPF;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LNIMADLJEGD();

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.NDEHINJAKEO> OLFEMKCFAGN(long POCGMPECBEJ, [Optional] CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<KDFOMBJNHHD> DNEMLLBLOAK();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task CCKFGFCMOIA();

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(HGMCNBIJHOL, CHINJLLPBEH) JBJLHBIIKDL();

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "15")]
	BKFAOGFLIJD PDGDFJEGAJO();

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CCJCFLMCLAB(long POCGMPECBEJ);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface JJKDBLEGMEM
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AAMNAHPCDPB([Out] IEnumerable<int> EOEEMKKODFF);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LDNFCGCJBMN(MAOIFBOIJHO PNPIGCGKNPI);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FEHLBBDAJIA(MAOIFBOIJHO PNPIGCGKNPI);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface FJFADGHJGIL
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string MFNKDMNNNCM(HPDKHMJHFIJ IHHIFBKDPEB);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface FLGGGNHJKFH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BCDPHBDPLHA(EFMKJFEFHEN.MBPMGEHPGMN LEHPCHKLHBK);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KPAFNMDNFDL(EFMKJFEFHEN.MBPMGEHPGMN LEHPCHKLHBK);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface BMOLNLPEKDN : FLGGGNHJKFH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HPDKHMJHFIJ EMJHOHONAHP(HDIGMKHIDBN FDIALPLINAD);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface JEMHDCFBCKM : FLGGGNHJKFH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HPDKHMJHFIJ KCMJDPAEHIM(HDIGMKHIDBN CJFAPAOPNFG);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface FLPAFHNPOFI
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HHANDHIMCMH<MNBHNPFBECL, EKHHLAEJNGE>> MDBJIAKLICF(string EGPKGHKFCDG, long POCGMPECBEJ, long? ECHGOOGHLEN, long? IMIHMEAMIDO, EGKEBLFCBLB.JCEOEHMGDOP ADDCOKJPJDA, CancellationToken NNGMAHIDECE);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface GHCPBJHELOE<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HHANDHIMCMH<CIPNPJKLJID<TData>, EKHHLAEJNGE>> PEKBLOKCLKG(TGetDataArg BBMJLAKPCGK, CancellationToken NNGMAHIDECE);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class LIDGFFFCLEO : DGKBIEGBPPF, LKKHHDMCBHJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct MEOMOGFFCFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public AsyncTaskMethodBuilder<HPDKHMJHFIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public LIDGFFFCLEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public BIELPDNJBMP autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<HPDKHMJHFIJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7044340", Offset = "0x7042940", VA = "0x187044340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x70445C0", Offset = "0x7042BC0", VA = "0x1870445C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct LFELJABCKDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public LIDGFFFCLEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7040480", Offset = "0x703EA80", VA = "0x187040480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x70406B0", Offset = "0x703ECB0", VA = "0x1870406B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class DFMICJJFBFM : IEnumerable<BDDMINNAEKA>, IEnumerable, IEnumerator<BDDMINNAEKA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private BDDMINNAEKA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public LIDGFFFCLEO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		private BDDMINNAEKA System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8A8AC0", Offset = "0x8A70C0", VA = "0x1808A8AC0")]
		[DebuggerHidden]
		public DFMICJJFBFM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x70325E0", Offset = "0x7030BE0", VA = "0x1870325E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7032A40", Offset = "0x7031040", VA = "0x187032A40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7032990", Offset = "0x7030F90", VA = "0x187032990", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BDDMINNAEKA> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7032990", Offset = "0x7030F90", VA = "0x187032990", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource CODCBEEGILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly JJHPIOCMJGA CEJMOFAPBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool KKDPLHMNJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NOIKAKLCEEI BOLNFIGJKHG;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public FLALAMNEBHN PAFBFMHOLND
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x861D50", Offset = "0x860350", VA = "0x180861D50", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x861E20", Offset = "0x860420", VA = "0x180861E20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public GPPKJFODOCJ OJHMGHPFOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x861750", Offset = "0x85FD50", VA = "0x180861750", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x861730", Offset = "0x85FD30", VA = "0x180861730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public NLIIDIBLEBA NMJFDBBPKEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x861770", Offset = "0x85FD70", VA = "0x180861770", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x861740", Offset = "0x85FD40", VA = "0x180861740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public CFHJOIPDCCN JMGILNODGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x861760", Offset = "0x85FD60", VA = "0x180861760", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x861780", Offset = "0x85FD80", VA = "0x180861780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public BMOLNLPEKDN ELNKLDKJHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x865680", Offset = "0x863C80", VA = "0x180865680", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x865670", Offset = "0x863C70", VA = "0x180865670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public JEMHDCFBCKM HCJHELPGGNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8656F0", Offset = "0x863CF0", VA = "0x1808656F0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8655B0", Offset = "0x863BB0", VA = "0x1808655B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public ICAOLNNEGIC IMECHDBEAHL
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x861F20", Offset = "0x860520", VA = "0x180861F20", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x861E10", Offset = "0x860410", VA = "0x180861E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public ENDOPHJFGJG CKLLJFIMHHF
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x861D30", Offset = "0x860330", VA = "0x180861D30", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x861E30", Offset = "0x860430", VA = "0x180861E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public AMOHHLGBNJG KDOEAMKKFMO
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x861ED0", Offset = "0x8604D0", VA = "0x180861ED0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x861E70", Offset = "0x860470", VA = "0x180861E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public FPHIMNNAHMP AIEOELGMNJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xAC1500", Offset = "0xABFB00", VA = "0x180AC1500", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xBD4070", Offset = "0xBD2670", VA = "0x180BD4070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public CBNCHEIGJNK LDJMBJKBNJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x861DB0", Offset = "0x8603B0", VA = "0x180861DB0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x861DC0", Offset = "0x8603C0", VA = "0x180861DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public BEFGPGKBHMM KHCNDBMFOOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xB2BCF0", Offset = "0xB2A2F0", VA = "0x180B2BCF0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xAC6350", Offset = "0xAC4950", VA = "0x180AC6350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public ECPEOHHOAOL NMGEICFJOLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8645E0", Offset = "0x862BE0", VA = "0x1808645E0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8645B0", Offset = "0x862BB0", VA = "0x1808645B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public MLAFDPCGOID IKHAGGJHICD
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x98FB60", Offset = "0x98E160", VA = "0x18098FB60", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xC72260", Offset = "0xC70860", VA = "0x180C72260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public LGPGDJGLGNL MCBDBLGMCLF
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA2C8E0", Offset = "0xA2AEE0", VA = "0x180A2C8E0", Slot = "57")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA27220", Offset = "0xA25820", VA = "0x180A27220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public OACLDMMDJLL MPAAMOFIAED
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x96B500", Offset = "0x969B00", VA = "0x18096B500", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA2D620", Offset = "0xA2BC20", VA = "0x180A2D620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public FFCNIOJJAOM BHFCFOIKDDN
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x9A2CB0", Offset = "0x9A12B0", VA = "0x1809A2CB0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xC722A0", Offset = "0xC708A0", VA = "0x180C722A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public HCOHAMMHFKP MMEJPEFBILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9A5430", Offset = "0x9A3A30", VA = "0x1809A5430", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA822A0", Offset = "0xA808A0", VA = "0x180A822A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public CPFKOHNEIKA IBLPLFEKNMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8645D0", Offset = "0x862BD0", VA = "0x1808645D0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x864670", Offset = "0x862C70", VA = "0x180864670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public HAPFKOABDCC BDLPNJIFDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9A0360", Offset = "0x99E960", VA = "0x1809A0360", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA76910", Offset = "0xA74F10", VA = "0x180A76910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public DAEJDKENKKH GHELIDPFNEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xC72150", Offset = "0xC70750", VA = "0x180C72150", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xC722C0", Offset = "0xC708C0", VA = "0x180C722C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public LJKKPKNLFFF GBBCNBJFICH
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9A5450", Offset = "0x9A3A50", VA = "0x1809A5450", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xC72280", Offset = "0xC70880", VA = "0x180C72280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public PIJGIFBANNP LGCNNGJFDLK
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9A5460", Offset = "0x9A3A60", VA = "0x1809A5460", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xAC4F80", Offset = "0xAC3580", VA = "0x180AC4F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public JJKDBLEGMEM FOADOOKABBP
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9A53B0", Offset = "0x9A39B0", VA = "0x1809A53B0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xC72240", Offset = "0xC70840", VA = "0x180C72240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public GKJFBPNEODH EPNJMBCBEAF
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9A53C0", Offset = "0x9A39C0", VA = "0x1809A53C0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xC72480", Offset = "0xC70A80", VA = "0x180C72480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public NOPIHKDGHEM BKOJDDCCGIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x9A52A0", Offset = "0x9A38A0", VA = "0x1809A52A0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xC72440", Offset = "0xC70A40", VA = "0x180C72440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public NCJGPNIIKEP GAJLKDALILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x9A5270", Offset = "0x9A3870", VA = "0x1809A5270", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xC723A0", Offset = "0xC709A0", VA = "0x180C723A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public GFNJPGHEMJE OCJEMEHGEIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x9A51D0", Offset = "0x9A37D0", VA = "0x1809A51D0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public FKCNEOBHCBA NIOHKGGFIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xB41F00", Offset = "0xB40500", VA = "0x180B41F00", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public DKFFGDNDPIF JNNDLMCPGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x9A5440", Offset = "0x9A3A40", VA = "0x1809A5440", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public MADIJKNICIM NKNEJCGECMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xB41F20", Offset = "0xB40520", VA = "0x180B41F20", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public MHAKOOGAPLD EMDPAMPILFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xB41F10", Offset = "0xB40510", VA = "0x180B41F10", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public CHINJLLPBEH HOCICNPBMEN
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xBF7B70", Offset = "0xBF6170", VA = "0x180BF7B70", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xC722E0", Offset = "0xC708E0", VA = "0x180C722E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private bool CNIOCGHILLF
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7041DF0", Offset = "0x70403F0", VA = "0x187041DF0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private bool BGOPNOJOOPL
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x70419E0", Offset = "0x703FFE0", VA = "0x1870419E0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private CancellationToken GJIBFHMDGNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7042240", Offset = "0x7040840", VA = "0x187042240", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private JJHPIOCMJGA PIEPFOMLMBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action JKEENHHOCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7042260", Offset = "0x7040860", VA = "0x187042260", Slot = "38")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7042470", Offset = "0x7040A70", VA = "0x187042470", Slot = "39")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event LIAFHIFBOFC EKIOLGIBEFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7041D00", Offset = "0x7040300", VA = "0x187041D00", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7041F60", Offset = "0x7040560", VA = "0x187041F60", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event LIAFHIFBOFC FOBJKHAJOLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7041980", Offset = "0x703FF80", VA = "0x187041980", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7041AB0", Offset = "0x70400B0", VA = "0x187041AB0", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event LIAFHIFBOFC CALIKIPDJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7042320", Offset = "0x7040920", VA = "0x187042320", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x70422C0", Offset = "0x70408C0", VA = "0x1870422C0", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<NNMIPMOFGJK, bool> HLIBNLBKIGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7042410", Offset = "0x7040A10", VA = "0x187042410", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7041FC0", Offset = "0x70405C0", VA = "0x187041FC0", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0xC722E0", Offset = "0xC708E0", VA = "0x180C722E0", Slot = "37")]
	public void JKKIBFAJIHD(CHINJLLPBEH GKJOIAOMFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x70424D0", Offset = "0x7040AD0", VA = "0x1870424D0")]
	[UnityEngine.Scripting.Preserve]
	internal LIDGFFFCLEO([JLPFJOFFNLM(null)] JJHPIOCMJGA CEJMOFAPBGN, [JLPFJOFFNLM(null)] FLALAMNEBHN DKJHBDBMIJF, [JLPFJOFFNLM(null)] GPPKJFODOCJ PNBEAEGFFLE, [JLPFJOFFNLM(null)] NLIIDIBLEBA FGMBCEGOCBB, [JLPFJOFFNLM(null)] CFHJOIPDCCN JKENJGLDKHB, [JLPFJOFFNLM(null)] BMOLNLPEKDN KLJGOIAJMKG, [JLPFJOFFNLM(null)] JEMHDCFBCKM GDCECAJJDLC, [JLPFJOFFNLM(null)] ICAOLNNEGIC CFPMIOIGHBC, [JLPFJOFFNLM(null)] ENDOPHJFGJG MNEMMLJKKKB, [JLPFJOFFNLM(null)] AMOHHLGBNJG CFICCNKMGFI, [JLPFJOFFNLM(null)] FPHIMNNAHMP DKNHNLDIDMP, [JLPFJOFFNLM(null)] CBNCHEIGJNK PJOICHPFHML, [JLPFJOFFNLM(null)] BEFGPGKBHMM OGHKBAKCDJN, [JLPFJOFFNLM(null)] ECPEOHHOAOL BAFEAEOPOKK, [JLPFJOFFNLM(null)] MLAFDPCGOID JAAJNEJEBLL, [JLPFJOFFNLM(null)] LGPGDJGLGNL PINHOPHCCAF, [JLPFJOFFNLM(null)] OACLDMMDJLL BMAJHGKNCHH, [JLPFJOFFNLM(null)] FFCNIOJJAOM AIPCMJNBLAG, [JLPFJOFFNLM(null)] HCOHAMMHFKP GBDBBFHJMOP, [JLPFJOFFNLM(null)] CPFKOHNEIKA FEPDACDNBDC, [JLPFJOFFNLM(null)] DAEJDKENKKH IIKOEAGJDNM, [JLPFJOFFNLM(null)] HAPFKOABDCC MJAOFLMLIDA, [JLPFJOFFNLM(null)] LJKKPKNLFFF DFFFACFKJEC, [JLPFJOFFNLM(null)] PIJGIFBANNP PGJIMKBANCO, [JLPFJOFFNLM(null)] JJKDBLEGMEM KMPCLNOEIOF, [JLPFJOFFNLM(null)] NOPIHKDGHEM AHDGGDAMLGE, [JLPFJOFFNLM(null)] NCJGPNIIKEP MEGFHIOMCCB, [JLPFJOFFNLM(null)] GFNJPGHEMJE MOLMEICFOFP, [JLPFJOFFNLM(null)] FKCNEOBHCBA HPEMKKEDHAP, [JLPFJOFFNLM(null)] DKFFGDNDPIF HCFAMJCELMB, [JLPFJOFFNLM(null)] MADIJKNICIM NKCCIBMIBBE, [JLPFJOFFNLM(null)] MHAKOOGAPLD DMHONEJLOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x7042020", Offset = "0x7040620", VA = "0x187042020")]
	private void HGDANEHJCNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x7041B70", Offset = "0x7040170", VA = "0x187041B70", Slot = "56")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7041A60", Offset = "0x7040060", VA = "0x187041A60", Slot = "50")]
	private void CKIOCOHHJGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7041D60", Offset = "0x7040360", VA = "0x187041D60", Slot = "51")]
	private MCOCJALIEAM EPMJEPMDECI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7042380", Offset = "0x7040980", VA = "0x187042380", Slot = "52")]
	private GKINIHEDCFF PBIMKAFDLCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7041E50", Offset = "0x7040450", VA = "0x187041E50", Slot = "53")]
	[AsyncStateMachine(typeof(MEOMOGFFCFF))]
	private Task<HPDKHMJHFIJ> FLDHDJIPCAM(BIELPDNJBMP CKBPCDCCCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x70420D0", Offset = "0x70406D0", VA = "0x1870420D0", Slot = "54")]
	[AsyncStateMachine(typeof(LFELJABCKDC))]
	private Task HIKPPEPHILP(CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x70421C0", Offset = "0x70407C0", VA = "0x1870421C0")]
	[IteratorStateMachine(typeof(DFMICJJFBFM))]
	private IEnumerable<BDDMINNAEKA> IFCNCJHKEEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7041B10", Offset = "0x7040110", VA = "0x187041B10")]
	[CompilerGenerated]
	private void CNEOFIIFMKH(BDDMINNAEKA NNFKLCEBDGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class ILMMDOOLCHJ : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x1000BD0", Offset = "0xFFF1D0", VA = "0x181000BD0")]
	public ILMMDOOLCHJ(string DICMABMCPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal class LJKHEHHCJNP : PKEGEEFECBO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct OEPNILONHFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public LJKHEHHCJNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x70486E0", Offset = "0x7046CE0", VA = "0x1870486E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7048A20", Offset = "0x7047020", VA = "0x187048A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly DGKBIEGBPPF EGEPJAHBNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly NLIIDIBLEBA FGMBCEGOCBB;

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x86D260", Offset = "0x86B860", VA = "0x18086D260")]
	public LJKHEHHCJNP(DGKBIEGBPPF EGEPJAHBNCI, NLIIDIBLEBA FGMBCEGOCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7042E20", Offset = "0x7041420", VA = "0x187042E20", Slot = "4")]
	[AsyncStateMachine(typeof(OEPNILONHFH))]
	public Task<bool> DFPDEDBJCAA(CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x7042F10", Offset = "0x7041510", VA = "0x187042F10")]
	[CompilerGenerated]
	private object IDFFKGNKDAP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class BONDCAKJKJF : PKEGEEFECBO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct LHFAGGLOBNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public BONDCAKJKJF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7040710", Offset = "0x703ED10", VA = "0x187040710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7040E20", Offset = "0x703F420", VA = "0x187040E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly DGKBIEGBPPF EGEPJAHBNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly NLIIDIBLEBA FGMBCEGOCBB;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private CKDFPPPACKB IMNGEJLDDEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x702D550", Offset = "0x702BB50", VA = "0x18702D550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x86D260", Offset = "0x86B860", VA = "0x18086D260")]
	public BONDCAKJKJF(DGKBIEGBPPF EGEPJAHBNCI, NLIIDIBLEBA FGMBCEGOCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x702D340", Offset = "0x702B940", VA = "0x18702D340", Slot = "4")]
	[AsyncStateMachine(typeof(LHFAGGLOBNP))]
	public Task<bool> DFPDEDBJCAA(CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x702D470", Offset = "0x702BA70", VA = "0x18702D470")]
	[CompilerGenerated]
	private object DJEKNFADOEI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal class NOCLCKLNCDE : PKEGEEFECBO
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class NLJLBMOHKPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public NOCLCKLNCDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public KDFOMBJNHHD result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public HGMCNBIJHOL newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public NLJLBMOHKPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x70470B0", Offset = "0x70456B0", VA = "0x1870470B0")]
		internal object DHMGCDMNPJK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7047240", Offset = "0x7045840", VA = "0x187047240")]
		internal object LMOBHLMLBKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x70471A0", Offset = "0x70457A0", VA = "0x1870471A0")]
		internal object HBKMIEEMCOA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct LHIEEPIALPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public NOCLCKLNCDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private NLJLBMOHKPE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<KDFOMBJNHHD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7040FF0", Offset = "0x703F5F0", VA = "0x187040FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7041910", Offset = "0x703FF10", VA = "0x187041910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly DGKBIEGBPPF EGEPJAHBNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly NLIIDIBLEBA FGMBCEGOCBB;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private CKDFPPPACKB IMNGEJLDDEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7047B80", Offset = "0x7046180", VA = "0x187047B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x86D260", Offset = "0x86B860", VA = "0x18086D260")]
	public NOCLCKLNCDE(DGKBIEGBPPF EGEPJAHBNCI, NLIIDIBLEBA FGMBCEGOCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x7047A60", Offset = "0x7046060", VA = "0x187047A60", Slot = "4")]
	[AsyncStateMachine(typeof(LHIEEPIALPA))]
	public Task<bool> DFPDEDBJCAA(CancellationToken NNGMAHIDECE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal interface PKEGEEFECBO
{
	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> DFPDEDBJCAA(CancellationToken NNGMAHIDECE);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal struct MOOHPJKEMOH
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class NBAGCANFMID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public DGKBIEGBPPF manager;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public NBAGCANFMID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7046DF0", Offset = "0x70453F0", VA = "0x187046DF0")]
		internal Task DMBHCDNBIGE(CancellationToken cancellationToken, int roomTotalVersion, IDJDNLONMLP localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct BAKFMOABPAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public MOOHPJKEMOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private BIELPDNJBMP <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter<OOCFMPGIAFO> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter<HPDKHMJHFIJ> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x702C400", Offset = "0x702AA00", VA = "0x18702C400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x702C990", Offset = "0x702AF90", VA = "0x18702C990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct HMMAAMMBLEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public MOOHPJKEMOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7038080", Offset = "0x7036680", VA = "0x187038080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x70383A0", Offset = "0x70369A0", VA = "0x1870383A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly CancellationToken NNGMAHIDECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly DGKBIEGBPPF FHLJNPENEDC;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	private FLALAMNEBHN PAFBFMHOLND
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x70460F0", Offset = "0x70446F0", VA = "0x1870460F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private NLIIDIBLEBA NMJFDBBPKEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7046140", Offset = "0x7044740", VA = "0x187046140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private CKDFPPPACKB IMNGEJLDDEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x7046020", Offset = "0x7044620", VA = "0x187046020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private AMOHHLGBNJG KDOEAMKKFMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x70460A0", Offset = "0x70446A0", VA = "0x1870460A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x1FDFE90", Offset = "0x1FDE490", VA = "0x181FDFE90")]
	public MOOHPJKEMOH(CancellationToken NNGMAHIDECE, DGKBIEGBPPF FHLJNPENEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7046190", Offset = "0x7044790", VA = "0x187046190")]
	public static IIENCKKFJNG MINIAFIICMM(DGKBIEGBPPF FHLJNPENEDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7046450", Offset = "0x7044A50", VA = "0x187046450")]
	[AsyncStateMachine(typeof(BAKFMOABPAO))]
	public Task<bool> NGPKEBHLPHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7046240", Offset = "0x7044840", VA = "0x187046240")]
	private bool MJBKIMMOCEB([Out] BIELPDNJBMP CKBPCDCCCCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x7046560", Offset = "0x7044B60", VA = "0x187046560")]
	[AsyncStateMachine(typeof(HMMAAMMBLEG))]
	private Task NLLGOOKPFDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x7045EF0", Offset = "0x70444F0", VA = "0x187045EF0")]
	private Task<OOCFMPGIAFO> EMKMONIJAEJ(BIELPDNJBMP EHAMDBHLENN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct FDCHOCHDFOM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly MLAFDPCGOID JAAJNEJEBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Guid MKCPOIIDFLO;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Task<(HPDKHMJHFIJ, Task)> CBEIOJIJJMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7034780", Offset = "0x7032D80", VA = "0x187034780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x4287290", Offset = "0x4285890", VA = "0x184287290")]
	public FDCHOCHDFOM(MLAFDPCGOID JAAJNEJEBLL, Guid MKCPOIIDFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7034920", Offset = "0x7032F20", VA = "0x187034920")]
	public TaskAwaiter<(HPDKHMJHFIJ, Task)> FLHBGNMEBOM()
	{
		return default(TaskAwaiter<(HPDKHMJHFIJ, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7034850", Offset = "0x7032E50", VA = "0x187034850", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal struct OCAPNHNNAAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly TaskCompletionSource<(HPDKHMJHFIJ, Task)> HGLJDPGPMDC;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Task<(HPDKHMJHFIJ, Task)> CBEIOJIJJMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7047CE0", Offset = "0x70462E0", VA = "0x187047CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7047EA0", Offset = "0x70464A0", VA = "0x187047EA0")]
	public OCAPNHNNAAO(TimeSpan BKEMADGDEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x7047E00", Offset = "0x7046400", VA = "0x187047E00")]
	public void OAPGOCJBMHC(Task INPIIKLJFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7047D20", Offset = "0x7046320", VA = "0x187047D20")]
	public void EEIGJBGLLAI(HPDKHMJHFIJ IHHIFBKDPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7047DB0", Offset = "0x70463B0", VA = "0x187047DB0")]
	public void FENBPHDALCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7047C50", Offset = "0x7046250", VA = "0x187047C50")]
	internal void AMGICADBMAO(string DICMABMCPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class LBNENKCHJGI
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class KBFEAHABGLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public KOKKKOEPCAE subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public KBFEAHABGLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x703EFA0", Offset = "0x703D5A0", VA = "0x18703EFA0")]
		internal bool AOJEGFOEBBD(DCPEFLIKEJN s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x703FCA0", Offset = "0x703E2A0", VA = "0x18703FCA0")]
	public static LDJGBBGIHDL KKJEMJBKDLP(long FFEKDADGCCD, long IMIHMEAMIDO, string CHJGLFCKEKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x703FEC0", Offset = "0x703E4C0", VA = "0x18703FEC0")]
	public static LDJGBBGIHDL KKJEMJBKDLP(long FFEKDADGCCD, long IMIHMEAMIDO, LDJPCHCCHLD OFJHEAGKPLP, long CIDNMNIGDJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x703FD30", Offset = "0x703E330", VA = "0x18703FD30")]
	public static LDJGBBGIHDL KKJEMJBKDLP(BIEOLNCJFEB ODJPOFELAEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x703FF80", Offset = "0x703E580", VA = "0x18703FF80")]
	public static LDJGBBGIHDL KKJEMJBKDLP(EKOKDGMBHGJ NDMNEFEDACD, KOKKKOEPCAE HFDEHPMCJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7040340", Offset = "0x703E940", VA = "0x187040340")]
	public static LDJGBBGIHDL MEEMDOCDGKK(this LDJGBBGIHDL JFHMMOFAOJJ, EKOKDGMBHGJ ICCOCOHKMNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x70401B0", Offset = "0x703E7B0", VA = "0x1870401B0")]
	public static LDJGBBGIHDL LKGMIMMJIFD(this LDJGBBGIHDL JFHMMOFAOJJ, KOKKKOEPCAE FOLEGNFBBMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[RecRoom.NoEngine.Common.Preserve]
internal class PLKMJKHKEAG : ENDOPHJFGJG, BDDMINNAEKA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct OOPGMKGFFNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public PLKMJKHKEAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private ILDHCOMNJFF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x70491E0", Offset = "0x70477E0", VA = "0x1870491E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x7049860", Offset = "0x7047E60", VA = "0x187049860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly MAOIFBOIJHO KOHACCNBAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private string CPPIIOGEJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Task CDDPMFMEOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private DGKBIEGBPPF EGEPJAHBNCI;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool JMJLHKGMHJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x70498C0", Offset = "0x7047EC0", VA = "0x1870498C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public Task JOPMDLDHDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7049B70", Offset = "0x7048170", VA = "0x187049B70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x860CF0", Offset = "0x85F2F0", VA = "0x180860CF0", Slot = "7")]
	public void HGDANEHJCNG(DGKBIEGBPPF EGEPJAHBNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x70498F0", Offset = "0x7047EF0", VA = "0x1870498F0", Slot = "6")]
	public void FFOBHDKLFPI(Task OOOMFPPINLE, string EHLHABFAPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7049A50", Offset = "0x7048050", VA = "0x187049A50")]
	[AsyncStateMachine(typeof(OOPGMKGFFNM))]
	private Task MMHLNDOLAJF(Task KMDNOPFMODC, string EHLHABFAPCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7049C00", Offset = "0x7048200", VA = "0x187049C00")]
	public PLKMJKHKEAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class FNNPALAGNCE : GKJFBPNEODH, BDDMINNAEKA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool DPFKMNGOAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private PKDAPLNAFOM GGIMBNAIKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private FLALAMNEBHN DKJHBDBMIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private NOPIHKDGHEM AHDGGDAMLGE;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public PKDAPLNAFOM LBEOBFABIPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x70354E0", Offset = "0x7033AE0", VA = "0x1870354E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7035360", Offset = "0x7033960", VA = "0x187035360", Slot = "7")]
	public void HGDANEHJCNG(DGKBIEGBPPF EGEPJAHBNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7035610", Offset = "0x7033C10", VA = "0x187035610", Slot = "5")]
	public void MJCDNEDGNMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7035320", Offset = "0x7033920", VA = "0x187035320", Slot = "6")]
	public void MDEKGKAHOOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7035550", Offset = "0x7033B50", VA = "0x187035550")]
	private Task IAIIEJLMHBI(DHNPIAPIPKI CEBMDGFHLLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7035320", Offset = "0x7033920", VA = "0x187035320", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public FNNPALAGNCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class KPNEDCKBJOM : NOPIHKDGHEM
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	private class PHJBLIADGON<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly FJMADKKFIAE IAIHNIPAOFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly string MNBFPOFIDHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly T PBAONJMDGEK;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public T MDPJKNKDANF
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x8AF2A0", Offset = "0x8AD8A0", VA = "0x1808AF2A0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0xAB2620", Offset = "0xAB0C20", VA = "0x180AB2620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x481A2C0", Offset = "0x48188C0", VA = "0x18481A2C0")]
		public PHJBLIADGON(FJMADKKFIAE IAIHNIPAOFG, string MNBFPOFIDHA, T PBAONJMDGEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x4819F00", Offset = "0x4818500", VA = "0x184819F00")]
		private void JJHJIGIOPIP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly FJMADKKFIAE IAIHNIPAOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly PHJBLIADGON<TimeSpan> CELDDKCMEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly PHJBLIADGON<TimeSpan> KEDJLGNCPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly PHJBLIADGON<TimeSpan> KKFAFNMAICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly PHJBLIADGON<TimeSpan> GEDPLACBGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly PHJBLIADGON<bool> FNMBJBLPPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly PHJBLIADGON<bool> ODCHMDMMANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly PHJBLIADGON<bool> HCAHBIOBMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly PHJBLIADGON<int> CCBAEOBKNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly PHJBLIADGON<bool> OFIKCNLKOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly PHJBLIADGON<bool> PHLFMEMFIOF;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public TimeSpan AEKEBKKFOAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x703F640", Offset = "0x703DC40", VA = "0x18703F640", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public TimeSpan MNICAKGAGDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x703F740", Offset = "0x703DD40", VA = "0x18703F740", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public TimeSpan HECMOBAMLAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x703F680", Offset = "0x703DC80", VA = "0x18703F680", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public TimeSpan ECEHINCLMHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x703F5C0", Offset = "0x703DBC0", VA = "0x18703F5C0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool DCEKFECKNCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x703F500", Offset = "0x703DB00", VA = "0x18703F500", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool GDOPKLIOFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x703F600", Offset = "0x703DC00", VA = "0x18703F600", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool KLDCKDFKFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x703F700", Offset = "0x703DD00", VA = "0x18703F700", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int FPHICKHGJBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x703F540", Offset = "0x703DB40", VA = "0x18703F540", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool CNBFEIKNNIN
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x703F6C0", Offset = "0x703DCC0", VA = "0x18703F6C0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool AHLEMFAMANO
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x703F580", Offset = "0x703DB80", VA = "0x18703F580", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x703F780", Offset = "0x703DD80", VA = "0x18703F780")]
	[UnityEngine.Scripting.Preserve]
	public KPNEDCKBJOM([JLPFJOFFNLM(null)] FJMADKKFIAE IAIHNIPAOFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[UnityEngine.Scripting.Preserve]
internal class EHJMGBLDGIF : FPHIMNNAHMP, BDDMINNAEKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class IKFLIGKDLGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public CAEPJJKBGAM roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public IKFLIGKDLGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7038EE0", Offset = "0x70374E0", VA = "0x187038EE0")]
		internal object BFPIINFNCLF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action MHJAEIMMLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7034590", Offset = "0x7032B90", VA = "0x187034590", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7034180", Offset = "0x7032780", VA = "0x187034180", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event LIAFHIFBOFC CLFHMKMEGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x7034380", Offset = "0x7032980", VA = "0x187034380", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7034420", Offset = "0x7032A20", VA = "0x187034420", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event LIAFHIFBOFC OFPPJILNJJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x7033D30", Offset = "0x7032330", VA = "0x187033D30", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x70344C0", Offset = "0x7032AC0", VA = "0x1870344C0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event LIAFHIFBOFC BEAPLNLIKMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x7033C90", Offset = "0x7032290", VA = "0x187033C90", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7034630", Offset = "0x7032C30", VA = "0x187034630", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<NNMIPMOFGJK, bool> ILDALLJEKCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x70342D0", Offset = "0x70328D0", VA = "0x1870342D0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x70346D0", Offset = "0x7032CD0", VA = "0x1870346D0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "19")]
	public void HGDANEHJCNG(DGKBIEGBPPF EGEPJAHBNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x7033F90", Offset = "0x7032590", VA = "0x187033F90", Slot = "14")]
	public void DFKPIONBOGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7034220", Offset = "0x7032820", VA = "0x187034220", Slot = "15")]
	public void FKPNMAHKCKI(CAEPJJKBGAM JOJBNKNAMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7034560", Offset = "0x7032B60", VA = "0x187034560", Slot = "16")]
	public void MALNHCJCMGH(CAEPJJKBGAM JOJBNKNAMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x70342A0", Offset = "0x70328A0", VA = "0x1870342A0", Slot = "17")]
	public void IBEDLAINJLC(CAEPJJKBGAM JOJBNKNAMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x7034250", Offset = "0x7032850", VA = "0x187034250", Slot = "18")]
	public void GGFBGMHJCMN(NNMIPMOFGJK FKCGACHMIMJ, bool GCPCBKFMNEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x7033DD0", Offset = "0x70323D0", VA = "0x187033DD0")]
	private void DFDLGJKGLOI(LIAFHIFBOFC CFHMBPIJFPA, CAEPJJKBGAM JOJBNKNAMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public EHJMGBLDGIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[UnityEngine.Scripting.Preserve]
internal class DGGKBBOFPPP : CBNCHEIGJNK, BDDMINNAEKA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct COJBAPLONFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public DGGKBBOFPPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private ILDHCOMNJFF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x7030F60", Offset = "0x702F560", VA = "0x187030F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7031440", Offset = "0x702FA40", VA = "0x187031440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct ODMLLCKEGGB : IAsyncStateMachine
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
		public DGGKBBOFPPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private ILDHCOMNJFF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7048020", Offset = "0x7046620", VA = "0x187048020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7048680", Offset = "0x7046C80", VA = "0x187048680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class AKOIILEHIBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public AKOIILEHIBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x702C390", Offset = "0x702A990", VA = "0x18702C390")]
		internal object BCEOLDAHAOE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct NMIFIAHJFGD : IAsyncStateMachine
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
		public DGGKBBOFPPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private AKOIILEHIBE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private ILDHCOMNJFF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x70472B0", Offset = "0x70458B0", VA = "0x1870472B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x70479F0", Offset = "0x7045FF0", VA = "0x1870479F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class NDDHDHACPIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public NDDHDHACPIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7046E40", Offset = "0x7045440", VA = "0x187046E40")]
		internal object EKCOLNDPFAP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly CHNLCLDOCNE CNCAEGCNGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private DGKBIEGBPPF EGEPJAHBNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NLIIDIBLEBA FGMBCEGOCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private PKEGEEFECBO[] CJCCNOCAODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private CancellationTokenSource NIGBFOEDEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private int AOAIMBDOAFG;

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x7033300", Offset = "0x7031900", VA = "0x187033300", Slot = "6")]
	public void HGDANEHJCNG(DGKBIEGBPPF EGEPJAHBNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x7032EE0", Offset = "0x70314E0", VA = "0x187032EE0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x7032DE0", Offset = "0x70313E0", VA = "0x187032DE0", Slot = "8")]
	public void CKNDFKENKDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x7033530", Offset = "0x7031B30", VA = "0x187033530", Slot = "5")]
	public void PMFIKIGNHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x7033460", Offset = "0x7031A60", VA = "0x187033460", Slot = "4")]
	[AsyncStateMachine(typeof(COJBAPLONFB))]
	public Task LLMMKNIOFOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x7032EF0", Offset = "0x70314F0", VA = "0x187032EF0")]
	private void FBADIBPKBNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x7033200", Offset = "0x7031800", VA = "0x187033200")]
	[AsyncStateMachine(typeof(ODMLLCKEGGB))]
	private Task GFOCIGMNFMB(CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x7032A90", Offset = "0x7031090", VA = "0x187032A90")]
	[AsyncStateMachine(typeof(NMIFIAHJFGD))]
	private Task<bool> BCFKIBGELJA(int EBDMAJMOJLN, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x7032BD0", Offset = "0x70311D0", VA = "0x187032BD0")]
	private void CDFIPFDCFJM(int EBDMAJMOJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x7033380", Offset = "0x7031980", VA = "0x187033380")]
	private void LKFMLAJENHG(int EBDMAJMOJLN, bool GCPCBKFMNEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x7033600", Offset = "0x7031C00", VA = "0x187033600")]
	private void PPDMKENIPEM(int EBDMAJMOJLN, Exception KLEFNMOCNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x7032CB0", Offset = "0x70312B0", VA = "0x187032CB0")]
	private void CFPAONJAOKM(CancellationToken NNGMAHIDECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public DGGKBBOFPPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[RecRoom.NoEngine.Common.Preserve]
internal class CGLLJNENFJD : BEFGPGKBHMM, BDDMINNAEKA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct FJCGKOOHIBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public HGMCNBIJHOL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public CGLLJNENFJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public CHINJLLPBEH customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private ILDHCOMNJFF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7034970", Offset = "0x7032F70", VA = "0x187034970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x70352C0", Offset = "0x70338C0", VA = "0x1870352C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct LKFDEMEHKEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public CGLLJNENFJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public HGMCNBIJHOL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public CHINJLLPBEH customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private NEGKJPNCLPM<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private ILDHCOMNJFF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private HHMJIEMKLLO <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private LHGAEDBCFJB <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x7042FF0", Offset = "0x70415F0", VA = "0x187042FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7043BB0", Offset = "0x70421B0", VA = "0x187043BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class LAGDDPFFEPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public Matchmaking.EMNCEOKIMPF result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public GNENAGGCEMG errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public LAGDDPFFEPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x703FBF0", Offset = "0x703E1F0", VA = "0x18703FBF0")]
		internal object PKNBHCHCMIK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class AAKPINMCMNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public Task<LDJGBBGIHDL> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public AAKPINMCMNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0")]
		internal Task<LDJGBBGIHDL> OEBCENLIKKD(NEGKJPNCLPM<string>.GBKOFALFHEN _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct JFNGHOAIHNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public CGLLJNENFJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public HGMCNBIJHOL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public CHINJLLPBEH customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public HHMJIEMKLLO joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private AAKPINMCMNC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private ACFLDMOCEIL <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private ILDHCOMNJFF <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <connectToRoomAndRunLoadLogicTimer>5__5;

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
		private ILHJBMNMDOK <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private Task<Matchmaking.NDEHINJAKEO> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private AINEEPIHNPO <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <>7__wrap12;

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
		private TaskAwaiter<Matchmaking.NDEHINJAKEO> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private TaskAwaiter<LDJGBBGIHDL> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x7039310", Offset = "0x7037910", VA = "0x187039310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x703ECC0", Offset = "0x703D2C0", VA = "0x18703ECC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct GLJONJGAFOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public CGLLJNENFJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private ILDHCOMNJFF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <disconnectTimerScope>5__3;

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
		private NEGKJPNCLPM<string>.GBKOFALFHEN <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x70361E0", Offset = "0x70347E0", VA = "0x1870361E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7036C20", Offset = "0x7035220", VA = "0x187036C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct LIENNGKBHBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public CGLLJNENFJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private JJHPIOCMJGA <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7042940", Offset = "0x7040F40", VA = "0x187042940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7042DC0", Offset = "0x70413C0", VA = "0x187042DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct HMFBANMOAIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public AsyncTaskMethodBuilder<Matchmaking.NDEHINJAKEO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public HGMCNBIJHOL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public CGLLJNENFJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private TaskAwaiter<Matchmaking.NDEHINJAKEO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7037B20", Offset = "0x7036120", VA = "0x187037B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7038010", Offset = "0x7036610", VA = "0x187038010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct OOMNGFIKPKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public Matchmaking.NDEHINJAKEO serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public CGLLJNENFJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public HHMJIEMKLLO joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private ILDHCOMNJFF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private TaskAwaiter<NHDHIHLMKKD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7048A90", Offset = "0x7047090", VA = "0x187048A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7049180", Offset = "0x7047780", VA = "0x187049180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class NKIDADOIEEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public HGMCNBIJHOL targetInstance;

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
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public NKIDADOIEEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7046EB0", Offset = "0x70454B0", VA = "0x187046EB0")]
		internal object DMIIOFFEGON()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7046FB0", Offset = "0x70455B0", VA = "0x187046FB0")]
		internal string HHJOKBILFGN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct DDJFDHOPPCG : IAsyncStateMachine
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
		public HGMCNBIJHOL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public CGLLJNENFJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private NKIDADOIEEP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private ILDHCOMNJFF <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x7031670", Offset = "0x702FC70", VA = "0x187031670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7032230", Offset = "0x7030830", VA = "0x187032230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct HNKMIIALKPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public CGLLJNENFJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public HHMJIEMKLLO joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public LDJGBBGIHDL initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public HGMCNBIJHOL targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public ACFLDMOCEIL progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7038400", Offset = "0x7036A00", VA = "0x187038400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7038D10", Offset = "0x7037310", VA = "0x187038D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct MOCBEAHCHDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public CGLLJNENFJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private ILDHCOMNJFF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <>7__wrap3;

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
		[Cpp2IlInjected.Address(RVA = "0x7044860", Offset = "0x7042E60", VA = "0x187044860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7045E90", Offset = "0x7044490", VA = "0x187045E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct NAJCFEHHEKG : IAsyncStateMachine
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
		public IDJDNLONMLP localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public CGLLJNENFJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private ILDHCOMNJFF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private TaskAwaiter<HPDKHMJHFIJ> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7046630", Offset = "0x7044C30", VA = "0x187046630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7046D90", Offset = "0x7045390", VA = "0x187046D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class DABGJIGOEFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public HGMCNBIJHOL targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public DABGJIGOEFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x70314A0", Offset = "0x702FAA0", VA = "0x1870314A0")]
		internal object OJNNDDNMHJJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class IKOICIKHAKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public IKOICIKHAKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7038FC0", Offset = "0x70375C0", VA = "0x187038FC0")]
		internal void OLNGAIIIFJM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class HPBNNGKIBAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public HGMCNBIJHOL targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public HPBNNGKIBAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7038D70", Offset = "0x7037370", VA = "0x187038D70")]
		internal object DAPMNFAMFDN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class BEHDEFCGAAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public HGMCNBIJHOL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public BEHDEFCGAAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x702CCA0", Offset = "0x702B2A0", VA = "0x18702CCA0")]
		internal string MOODLADAJGO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly CHNLCLDOCNE CNCAEGCNGHI;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly CHNLCLDOCNE CFHPNLJPOMP;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly CHNLCLDOCNE IBACAKBKAOJ;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly CHNLCLDOCNE HFHOGIGLHFO;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly string CNKJDFICJIA;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static readonly string DBPCINKOBOJ;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly string PJIFFGJEKJL;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly Guid PDKGIIFCHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private ICAOLNNEGIC CFPMIOIGHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private GPPKJFODOCJ PNBEAEGFFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private FLALAMNEBHN DKJHBDBMIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private DGKBIEGBPPF EGEPJAHBNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private NLIIDIBLEBA FGMBCEGOCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private CBNCHEIGJNK PJOICHPFHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private ENDOPHJFGJG MNEMMLJKKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private FPHIMNNAHMP DKNHNLDIDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private DKFFGDNDPIF HCFAMJCELMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private FKCNEOBHCBA HPEMKKEDHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private IDisposable BFPBMJOEJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private MHAKOOGAPLD DMHONEJLOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly MAOIFBOIJHO BGMPFJMENIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private AINEEPIHNPO LPFKJMFKFDA;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public TaskStatus LDMIANDNKJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x884F60", Offset = "0x883560", VA = "0x180884F60", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xBA99C0", Offset = "0xBA7FC0", VA = "0x180BA99C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private CKDFPPPACKB IMNGEJLDDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x702E500", Offset = "0x702CB00", VA = "0x18702E500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x702ECC0", Offset = "0x702D2C0", VA = "0x18702ECC0", Slot = "6")]
	public void HGDANEHJCNG(DGKBIEGBPPF EGEPJAHBNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x702E1A0", Offset = "0x702C7A0", VA = "0x18702E1A0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x702D6A0", Offset = "0x702BCA0", VA = "0x18702D6A0", Slot = "5")]
	[AsyncStateMachine(typeof(FJCGKOOHIBG))]
	public Task AJPCKIFKKEN(HGMCNBIJHOL EKIDHODEHNL, CHINJLLPBEH NMCCKLHAGJO, CancellationToken MEHJFMOAFKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x702F560", Offset = "0x702DB60", VA = "0x18702F560")]
	[AsyncStateMachine(typeof(LKFDEMEHKEC))]
	private Task KBDHBDCBIIB(HGMCNBIJHOL EKIDHODEHNL, CHINJLLPBEH NMCCKLHAGJO, CancellationToken MEHJFMOAFKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x702E660", Offset = "0x702CC60", VA = "0x18702E660")]
	private static void GEEBMFADDEP(DKFFGDNDPIF HCFAMJCELMB, HGMCNBIJHOL EKIDHODEHNL, Exception KLEFNMOCNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x702FCE0", Offset = "0x702E2E0", VA = "0x18702FCE0")]
	private static void MEJJOBGIAIO(LHGAEDBCFJB FKAECLNIMNO, Exception KLEFNMOCNFP, [Optional] List<int> DFENGIFBHBN, int AOAIMBDOAFG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x702EB60", Offset = "0x702D160", VA = "0x18702EB60")]
	[AsyncStateMachine(typeof(JFNGHOAIHNN))]
	private Task HDLGHENCDCG(NEGKJPNCLPM<string>.GBKOFALFHEN CIAFJLABOOB, HGMCNBIJHOL EKIDHODEHNL, CHINJLLPBEH NMCCKLHAGJO, HHMJIEMKLLO LJEGMAIHPMG, CancellationToken MEHJFMOAFKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x702FA60", Offset = "0x702E060", VA = "0x18702FA60")]
	private void MCOONKCCMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x702EFE0", Offset = "0x702D5E0", VA = "0x18702EFE0")]
	[AsyncStateMachine(typeof(GLJONJGAFOH))]
	private Task IHOHJBCPCNK(NEGKJPNCLPM<string>.GBKOFALFHEN CIAFJLABOOB, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x702D7E0", Offset = "0x702BDE0", VA = "0x18702D7E0")]
	private void ANGHLGAJOCN(HGMCNBIJHOL EKIDHODEHNL, CancellationToken MEHJFMOAFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x702E280", Offset = "0x702C880", VA = "0x18702E280")]
	private void FCEOEGGDCBO(HGMCNBIJHOL EKIDHODEHNL, HHMJIEMKLLO LJEGMAIHPMG, OperationCanceledException EEEBEMALEJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x702DD00", Offset = "0x702C300", VA = "0x18702DD00")]
	private void BNCBAJECGDE(HGMCNBIJHOL EKIDHODEHNL, HHMJIEMKLLO LJEGMAIHPMG, Exception KLEFNMOCNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x702F110", Offset = "0x702D710", VA = "0x18702F110")]
	private void JAABLDKDJPG(HGMCNBIJHOL EKIDHODEHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x70306C0", Offset = "0x702ECC0", VA = "0x1870306C0")]
	private static CAEPJJKBGAM NIHOOCGCLIH(HGMCNBIJHOL EKIDHODEHNL)
	{
		return default(CAEPJJKBGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7030BA0", Offset = "0x702F1A0", VA = "0x187030BA0")]
	[AsyncStateMachine(typeof(LIENNGKBHBC))]
	private Task PFEPIPKJJMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7030A40", Offset = "0x702F040", VA = "0x187030A40")]
	[AsyncStateMachine(typeof(HMFBANMOAIK))]
	private Task<Matchmaking.NDEHINJAKEO> OLFEMKCFAGN(HGMCNBIJHOL EKIDHODEHNL, NEGKJPNCLPM<string>.GBKOFALFHEN CIAFJLABOOB, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x702F450", Offset = "0x702DA50", VA = "0x18702F450")]
	private static NHDHIHLMKKD JPBCLHDCKHC(Matchmaking.NDEHINJAKEO IDINJGJMOIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x702EA10", Offset = "0x702D010", VA = "0x18702EA10")]
	[AsyncStateMachine(typeof(OOMNGFIKPKO))]
	private Task HDIIJHHOLOI(Matchmaking.NDEHINJAKEO IDINJGJMOIK, HHMJIEMKLLO LJEGMAIHPMG, NEGKJPNCLPM<string>.GBKOFALFHEN CIAFJLABOOB, CancellationToken KKHFLHJNGIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7030580", Offset = "0x702EB80", VA = "0x187030580")]
	[AsyncStateMachine(typeof(DDJFDHOPPCG))]
	private Task MELIEOLMBOG(HGMCNBIJHOL EKIDHODEHNL, CancellationTokenSource DMFMGIFNMOL, Task PHIDHCCLHFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x7030720", Offset = "0x702ED20", VA = "0x187030720")]
	[AsyncStateMachine(typeof(HNKMIIALKPE))]
	private Task OAFAOFBBCPO(LDJGBBGIHDL NFJLBLDAECB, ACFLDMOCEIL JOENJHHKMGC, HGMCNBIJHOL MBGJGOECKLB, HHMJIEMKLLO DLOGIHJBNCI, NEGKJPNCLPM<string>.GBKOFALFHEN CIAFJLABOOB, CancellationToken IKBOFPIMGCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x702DB10", Offset = "0x702C110", VA = "0x18702DB10")]
	private HHMJIEMKLLO BLIMGNALJIO(HHMJIEMKLLO DLOGIHJBNCI, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x702FBB0", Offset = "0x702E1B0", VA = "0x18702FBB0")]
	[AsyncStateMachine(typeof(MOCBEAHCHDK))]
	private Task MDPPKGPCFLJ(NEGKJPNCLPM<string>.GBKOFALFHEN CIAFJLABOOB, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x702F320", Offset = "0x702D920", VA = "0x18702F320")]
	[AsyncStateMachine(typeof(NAJCFEHHEKG))]
	private Task JCDNNPOODBD(CancellationToken NNGMAHIDECE, int GJEBBAHEDKL, IDJDNLONMLP COJGCKPIFMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x702F8E0", Offset = "0x702DEE0", VA = "0x18702F8E0")]
	private static void MAIPDFKCAHB(HGMCNBIJHOL EKIDHODEHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x702F6B0", Offset = "0x702DCB0", VA = "0x18702F6B0")]
	private void LFDAOPDJCEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x702D610", Offset = "0x702BC10", VA = "0x18702D610")]
	private void AJDOGIAICFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x702E110", Offset = "0x702C710", VA = "0x18702E110")]
	private void DNKNDBJGECM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x702E1F0", Offset = "0x702C7F0", VA = "0x18702E1F0")]
	private void EPFMBBILFOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x702DF20", Offset = "0x702C520", VA = "0x18702DF20")]
	private static void COJKKLAOIEC(HGMCNBIJHOL EKIDHODEHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x702E550", Offset = "0x702CB50", VA = "0x18702E550")]
	private static CancellationTokenRegistration GCAKCGBHCBI(HGMCNBIJHOL EKIDHODEHNL, CancellationToken KKHFLHJNGIA)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x702E010", Offset = "0x702C610", VA = "0x18702E010")]
	private static void DNFENBFKODD(HGMCNBIJHOL EKIDHODEHNL, Exception KLEFNMOCNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7030890", Offset = "0x702EE90", VA = "0x187030890")]
	private void OGGIHEBKPMA(HGMCNBIJHOL EKIDHODEHNL, Task PHIDHCCLHFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x702E4A0", Offset = "0x702CAA0", VA = "0x18702E4A0")]
	private static void FFHOJNCMEGD(Func<string> BHFCMGBIGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7030ED0", Offset = "0x702F4D0", VA = "0x187030ED0")]
	public CGLLJNENFJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x7030C70", Offset = "0x702F270", VA = "0x187030C70")]
	[CompilerGenerated]
	internal static (int, int?) PIGLIKKECEH(GNENAGGCEMG OJPBOBDPLEA)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[RecRoom.NoEngine.Common.Preserve]
internal class ICFGCHOKBNP : ECPEOHHOAOL, BDDMINNAEKA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct LHEKDFCDMJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public ICFGCHOKBNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public IDJDNLONMLP localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7062210", Offset = "0x7060810", VA = "0x187062210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7062670", Offset = "0x7060C70", VA = "0x187062670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class FKMIEOGFCAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public ICFGCHOKBNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public IDJDNLONMLP localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public FKMIEOGFCAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7053130", Offset = "0x7051730", VA = "0x187053130")]
		internal List<Task> CODAPNAMHFM(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct GHNLAAKDMFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public IIENCKKFJNG taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public IDJDNLONMLP localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private ILDHCOMNJFF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x70551E0", Offset = "0x70537E0", VA = "0x1870551E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7055570", Offset = "0x7053B70", VA = "0x187055570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct NLLPCIMPPCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public ICFGCHOKBNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7067530", Offset = "0x7065B30", VA = "0x187067530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x70677F0", Offset = "0x7065DF0", VA = "0x1870677F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private readonly HashSet<IIENCKKFJNG> GKJCHCFGPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private GPPKJFODOCJ PNBEAEGFFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private DGKBIEGBPPF EGEPJAHBNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private MPFADGNIAME JOJOACAOCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private JNLAJNBFNPL HBBFMGLJFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private IDisposable BFPBMJOEJAM;

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x705AB10", Offset = "0x7059110", VA = "0x18705AB10", Slot = "5")]
	public void HGDANEHJCNG(DGKBIEGBPPF EGEPJAHBNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x705A680", Offset = "0x7058C80", VA = "0x18705A680", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x705AEE0", Offset = "0x70594E0", VA = "0x18705AEE0", Slot = "4")]
	public bool KECEPNLJCDL(IIENCKKFJNG FCNFFPKAABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x705B420", Offset = "0x7059A20", VA = "0x18705B420")]
	private void PMKDDFBGLIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x705A8F0", Offset = "0x7058EF0", VA = "0x18705A8F0")]
	private void GJNKKCKCLEN(BOLFHPPCKNE BMLBCLGKFJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x705A4E0", Offset = "0x7058AE0", VA = "0x18705A4E0")]
	[AsyncStateMachine(typeof(LHEKDFCDMJK))]
	private Task BAADKOBINGN(int GJEBBAHEDKL, IDJDNLONMLP COJGCKPIFMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x705AE10", Offset = "0x7059410", VA = "0x18705AE10")]
	private Func<CancellationToken, List<Task>> IAAHKKNJKOG(int GJEBBAHEDKL, IDJDNLONMLP COJGCKPIFMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x705AF40", Offset = "0x7059540", VA = "0x18705AF40")]
	private List<Task> KELMAKLDKAP(int GJEBBAHEDKL, IDJDNLONMLP COJGCKPIFMN, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x705A7D0", Offset = "0x7058DD0", VA = "0x18705A7D0")]
	[AsyncStateMachine(typeof(GHNLAAKDMFE))]
	private Task GCILIPIAKLI(IIENCKKFJNG NNKIBJPHKJM, CancellationToken PNPIGCGKNPI, int GJEBBAHEDKL, IDJDNLONMLP COJGCKPIFMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x705A700", Offset = "0x7058D00", VA = "0x18705A700")]
	[AsyncStateMachine(typeof(NLLPCIMPPCO))]
	private Task EOHMIMCEAHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x705A5D0", Offset = "0x7058BD0", VA = "0x18705A5D0")]
	private void CKNDFKENKDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x705B4F0", Offset = "0x7059AF0", VA = "0x18705B4F0")]
	public ICFGCHOKBNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[UnityEngine.Scripting.Preserve]
internal sealed class KBDBNOEMJLF : MLAFDPCGOID, BDDMINNAEKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class MPMKAHFDNFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public MPMKAHFDNFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7066030", Offset = "0x7064630", VA = "0x187066030")]
		internal object JBIIMBAKDJE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class GIJCCGNGKJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public GIJCCGNGKJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x7055F70", Offset = "0x7054570", VA = "0x187055F70")]
		internal object AGLNCAMPNJL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class PMKACEIFIDB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public PMKACEIFIDB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class AFKMJCAGLFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public AFKMJCAGLFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x704BC80", Offset = "0x704A280", VA = "0x18704BC80")]
		internal object NGGCOCLEHDB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class FFBAEDPKOCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public FFBAEDPKOCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x70530D0", Offset = "0x70516D0", VA = "0x1870530D0")]
		internal object CBHIEFCDPIK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private readonly Dictionary<Guid, OCAPNHNNAAO> JAAJNEJEBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private readonly TimeSpan NADIKNBBDHN;

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "9")]
	public void HGDANEHJCNG(DGKBIEGBPPF EGEPJAHBNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x70601A0", Offset = "0x705E7A0", VA = "0x1870601A0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x705FB70", Offset = "0x705E170", VA = "0x18705FB70", Slot = "4")]
	public FDCHOCHDFOM AGMNBECNIJC(Guid MKCPOIIDFLO)
	{
		return default(FDCHOCHDFOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7060550", Offset = "0x705EB50", VA = "0x187060550", Slot = "5")]
	public bool PJEMHMBEIPM(Guid MKCPOIIDFLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x7060220", Offset = "0x705E820", VA = "0x187060220", Slot = "6")]
	public bool JMIEBFPPGBO(Guid MKCPOIIDFLO, Task INPIIKLJFOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x705FD90", Offset = "0x705E390", VA = "0x18705FD90", Slot = "7")]
	public bool DMEHGDGKLHP(Guid MKCPOIIDFLO, HPDKHMJHFIJ IHHIFBKDPEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x70601B0", Offset = "0x705E7B0", VA = "0x1870601B0", Slot = "8")]
	public Task<(HPDKHMJHFIJ, Task)> HEIGEJKBANA(Guid MKCPOIIDFLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x705FF70", Offset = "0x705E570", VA = "0x18705FF70")]
	private void DPHOGCDGPLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x7060760", Offset = "0x705ED60", VA = "0x187060760")]
	public KBDBNOEMJLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[RecRoom.NoEngine.Common.Preserve]
internal class HICAPCDKMCI : LGPGDJGLGNL, BDDMINNAEKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private class HEAGCOGHEEB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private readonly HGMCNBIJHOL BIPKJPPNHLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private readonly CancellationTokenSource NIGBFOEDEML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public readonly CancellationToken AKAKJLCCBBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private bool AFBOJKMCJFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private bool PCNGABNNECG;

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x7056DC0", Offset = "0x70553C0", VA = "0x187056DC0")]
		public HEAGCOGHEEB(HGMCNBIJHOL BIPKJPPNHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x7056C40", Offset = "0x7055240", VA = "0x187056C40")]
		public void CKNDFKENKDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7056D90", Offset = "0x7055390", VA = "0x187056D90", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class GBINNPKGCBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public DHNPIAPIPKI disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public GBINNPKGCBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x70531D0", Offset = "0x70517D0", VA = "0x1870531D0")]
		internal object FODGGGKPDIP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct ADOEIBHAPDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public DHNPIAPIPKI disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public HICAPCDKMCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private ILDHCOMNJFF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x704B230", Offset = "0x7049830", VA = "0x18704B230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x704B5E0", Offset = "0x7049BE0", VA = "0x18704B5E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class HKGKIMGOHOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public HKGKIMGOHOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x7059200", Offset = "0x7057800", VA = "0x187059200")]
		internal object AJOHBHMFNBB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct IEMHKHIBNOJ : IAsyncStateMachine
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
		public HICAPCDKMCI <>4__this;

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
		private ILDHCOMNJFF <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x705B580", Offset = "0x7059B80", VA = "0x18705B580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xA798A0", Offset = "0xA77EA0", VA = "0x180A798A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class PBJGLCFAJOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public HGMCNBIJHOL newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public PBJGLCFAJOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x70692B0", Offset = "0x70678B0", VA = "0x1870692B0")]
		internal object MANMNGMNFLG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7069230", Offset = "0x7067830", VA = "0x187069230")]
		internal object ECNNDFNIDDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x7069270", Offset = "0x7067870", VA = "0x187069270")]
		internal object IMJPFADJBKI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class NFJPEFDKCBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public NFJPEFDKCBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x7066960", Offset = "0x7064F60", VA = "0x187066960")]
		internal void IGIMEMOFCKF()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private struct IIMHCFEPCFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public HGMCNBIJHOL newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public HICAPCDKMCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public CHINJLLPBEH customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private PBJGLCFAJOK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private ILDHCOMNJFF <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x705C860", Offset = "0x705AE60", VA = "0x18705C860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x705D7E0", Offset = "0x705BDE0", VA = "0x18705D7E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly CHNLCLDOCNE CNCAEGCNGHI;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly LHHKLEGBDAM.LOPHCIBMKCG GMNIIFEOPNN;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly PHBCBPKFGFE NGBOELDBJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private GPPKJFODOCJ PNBEAEGFFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private DGKBIEGBPPF EGEPJAHBNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private CBNCHEIGJNK PJOICHPFHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private NLIIDIBLEBA FGMBCEGOCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private NOPIHKDGHEM AHDGGDAMLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private BEFGPGKBHMM OGHKBAKCDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private HGMCNBIJHOL OEEMAKONBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private HEAGCOGHEEB KCDHMJGKAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private bool KPNIMICMLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private Task GKNMFEJNCMN;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private CKDFPPPACKB IMNGEJLDDEB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x70583E0", Offset = "0x70569E0", VA = "0x1870583E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool IGANMKGECNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xA07F50", Offset = "0xA06550", VA = "0x180A07F50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x7058150", Offset = "0x7056750", VA = "0x187058150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x7058500", Offset = "0x7056B00", VA = "0x187058500", Slot = "4")]
	public void HGDANEHJCNG(DGKBIEGBPPF EGEPJAHBNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7057FE0", Offset = "0x70565E0", VA = "0x187057FE0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x70582F0", Offset = "0x70568F0", VA = "0x1870582F0")]
	[AsyncStateMachine(typeof(ADOEIBHAPDL))]
	private Task EOIEPGLMOMN(DHNPIAPIPKI LIINOAAKKBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7058160", Offset = "0x7056760", VA = "0x187058160")]
	private void EGEMNBIGBCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7057D30", Offset = "0x7056330", VA = "0x187057D30")]
	private void CILCKNGFFPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x7058C10", Offset = "0x7057210", VA = "0x187058C10")]
	private void PKONIMHMAKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x7058BA0", Offset = "0x70571A0", VA = "0x187058BA0")]
	private bool MLICOFDGECH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x7058430", Offset = "0x7056A30", VA = "0x187058430")]
	[AsyncStateMachine(typeof(IEMHKHIBNOJ))]
	private void GDOIKJBHHPF(int BMFGPCBKKKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x70587A0", Offset = "0x7056DA0", VA = "0x1870587A0")]
	private void IAJFLNIPPCC([Out] IDisposable CAFBIAEKOCF, [Out] IDisposable FFLPBFHIGLD, [Out] IDisposable BMIGOBACNKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x7057EC0", Offset = "0x70564C0", VA = "0x187057EC0")]
	private bool DNOCLBHIOHC(HGMCNBIJHOL BIPKJPPNHLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x7058B50", Offset = "0x7057150", VA = "0x187058B50")]
	private void MGKJDCIDIEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x7058A20", Offset = "0x7057020", VA = "0x187058A20")]
	[AsyncStateMachine(typeof(IIMHCFEPCFH))]
	private Task KBDHBDCBIIB(HGMCNBIJHOL BIPKJPPNHLB, CHINJLLPBEH NMCCKLHAGJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7059130", Offset = "0x7057730", VA = "0x187059130")]
	public HICAPCDKMCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[UnityEngine.Scripting.Preserve]
internal sealed class JAGDOEBPIOP : OACLDMMDJLL, BDDMINNAEKA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private struct MBHBLBICFFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public AsyncTaskMethodBuilder<NPEAHLFIFPI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public JAGDOEBPIOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private TaskAwaiter<NPEAHLFIFPI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x70638D0", Offset = "0x7061ED0", VA = "0x1870638D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x7063B60", Offset = "0x7062160", VA = "0x187063B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class EMKEMLJINHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public JFFNGMFLFPF message;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public EMKEMLJINHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7053070", Offset = "0x7051670", VA = "0x187053070")]
		internal object JGBPMELCDDM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class OKJLCKOFGDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public JFFNGMFLFPF messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public OKJLCKOFGDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x7068B90", Offset = "0x7067190", VA = "0x187068B90")]
		internal object LDCFEOBMMIA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class PEFLGGFKCPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public JFFNGMFLFPF request;

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public PEFLGGFKCPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7069350", Offset = "0x7067950", VA = "0x187069350")]
		internal object ABOGBOBEJPI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct KIODNCMDKAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public JFFNGMFLFPF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public JAGDOEBPIOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private ILDHCOMNJFF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private TaskAwaiter<EMCBHBKNJFL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x70610C0", Offset = "0x705F6C0", VA = "0x1870610C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7061980", Offset = "0x705FF80", VA = "0x187061980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class HJNPMANAENH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public JFFNGMFLFPF operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public HJNPMANAENH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x70591A0", Offset = "0x70577A0", VA = "0x1870591A0")]
		internal object MGDOMOHKNMH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct AJCGJCJKFOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public JFFNGMFLFPF operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public JAGDOEBPIOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private ILDHCOMNJFF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private HHMJIEMKLLO <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private TaskAwaiter<JFFNGMFLFPF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x704BD40", Offset = "0x704A340", VA = "0x18704BD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x704C8A0", Offset = "0x704AEA0", VA = "0x18704C8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct DJLBMIBJJGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<EMCBHBKNJFL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public JAGDOEBPIOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public JFFNGMFLFPF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private GHKMPPLMCBH.OMEAAIFOHJJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private HHMJIEMKLLO <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private TaskAwaiter<JFFNGMFLFPF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x7050F50", Offset = "0x704F550", VA = "0x187050F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x7051470", Offset = "0x704FA70", VA = "0x187051470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class OOAGGGGGHPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public EMCBHBKNJFL operation;

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public OOAGGGGGHPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x7068BF0", Offset = "0x70671F0", VA = "0x187068BF0")]
		internal object GAFKIJNDLFK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private struct DIKKIPNEJMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public EMCBHBKNJFL operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public JAGDOEBPIOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private ILDHCOMNJFF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private NEGKJPNCLPM<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x70508B0", Offset = "0x704EEB0", VA = "0x1870508B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x7050EF0", Offset = "0x704F4F0", VA = "0x187050EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class JKHPLDIGMKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public JFFNGMFLFPF request;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public JKHPLDIGMKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x705EC50", Offset = "0x705D250", VA = "0x18705EC50")]
		internal object FJKHHAEMMIP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class AGKODHDKBPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public JFFNGMFLFPF request;

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public AGKODHDKBPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x704BCE0", Offset = "0x704A2E0", VA = "0x18704BCE0")]
		internal object MODHKLCGNGH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private DGKBIEGBPPF EGEPJAHBNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private ENDOPHJFGJG MNEMMLJKKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private FFCNIOJJAOM AIPCMJNBLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private HAPFKOABDCC MJAOFLMLIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private FLALAMNEBHN DKJHBDBMIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private TaskCompletionSource<NPEAHLFIFPI> EMFJNIIACPP;

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x705E1C0", Offset = "0x705C7C0", VA = "0x18705E1C0", Slot = "7")]
	public void HGDANEHJCNG(DGKBIEGBPPF EGEPJAHBNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x705E640", Offset = "0x705CC40", VA = "0x18705E640", Slot = "6")]
	[AsyncStateMachine(typeof(MBHBLBICFFG))]
	public Task<NPEAHLFIFPI> JKPIGBDDNBN(CancellationToken IAIMOGBPDOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x705E860", Offset = "0x705CE60", VA = "0x18705E860", Slot = "4")]
	public void LILCEKMPPPB(JFFNGMFLFPF DICMABMCPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x705DE60", Offset = "0x705C460", VA = "0x18705DE60", Slot = "5")]
	public void GBIOHJAFNJD(JFFNGMFLFPF IOOBOIMPPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x705E750", Offset = "0x705CD50", VA = "0x18705E750")]
	[AsyncStateMachine(typeof(KIODNCMDKAF))]
	private Task JMDFGAGCLCI(JFFNGMFLFPF FALAJMPCHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x705DAB0", Offset = "0x705C0B0", VA = "0x18705DAB0")]
	[AsyncStateMachine(typeof(AJCGJCJKFOP))]
	private Task EFNJLNALEEE(JFFNGMFLFPF KEDIFEAIFED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x705D960", Offset = "0x705BF60", VA = "0x18705D960")]
	[AsyncStateMachine(typeof(DJLBMIBJJGL))]
	private Task<EMCBHBKNJFL> EBLLADNHBMI(JFFNGMFLFPF FALAJMPCHDK, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x705DBC0", Offset = "0x705C1C0", VA = "0x18705DBC0")]
	private HHMJIEMKLLO FHAEONFFNMG(JFFNGMFLFPF ACIHLJMOGPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x705D840", Offset = "0x705BE40", VA = "0x18705D840")]
	[AsyncStateMachine(typeof(DIKKIPNEJMP))]
	private Task BENJGLCKAHL(EMCBHBKNJFL AOBBNFODCCN, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x705DC50", Offset = "0x705C250", VA = "0x18705DC50")]
	private EMCBHBKNJFL FNJPHKDEDEO(JFFNGMFLFPF FALAJMPCHDK, HHMJIEMKLLO MMKIPOAGEKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x2BB89D0", Offset = "0x2BB6FD0", VA = "0x182BB89D0")]
	private T OABIHFLLACD<T>(T FEBGGALLBNN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x705E2B0", Offset = "0x705C8B0", VA = "0x18705E2B0")]
	private EMCBHBKNJFL IDLKKLDHCCH(JFFNGMFLFPF FALAJMPCHDK, HHMJIEMKLLO MMKIPOAGEKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public JAGDOEBPIOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[UnityEngine.Scripting.Preserve]
internal sealed class GGHKJKKBKNE : FFCNIOJJAOM, BDDMINNAEKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class LBJPEPEKKHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public LBJPEPEKKHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x7062060", Offset = "0x7060660", VA = "0x187062060")]
		internal object IAPLANBKMPD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class OJEOHKJDIAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public OJEOHKJDIAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x7068410", Offset = "0x7066A10", VA = "0x187068410")]
		internal object KHILDJPNPGD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private FLALAMNEBHN DKJHBDBMIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private LJKKPKNLFFF DFFFACFKJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private OACLDMMDJLL BMAJHGKNCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private MLAFDPCGOID JAAJNEJEBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private JJKDBLEGMEM KMPCLNOEIOF;

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x70542A0", Offset = "0x70528A0", VA = "0x1870542A0", Slot = "6")]
	public void HGDANEHJCNG(DGKBIEGBPPF EGEPJAHBNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7053FE0", Offset = "0x70525E0", VA = "0x187053FE0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x7053260", Offset = "0x7051860", VA = "0x187053260", Slot = "4")]
	public FDCHOCHDFOM AAOEDLJENBE(JFFNGMFLFPF PECBFCDENDO)
	{
		return default(FDCHOCHDFOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x7054090", Offset = "0x7052690", VA = "0x187054090", Slot = "5")]
	public void FKEOBIMGNIF(Guid MKCPOIIDFLO, Task INPIIKLJFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x7055110", Offset = "0x7053710", VA = "0x187055110")]
	private void ONBKAEAMJHF(byte CEGADOPBLMK, int IMEOKMCGLID, object KHNPOCNGPLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x7054410", Offset = "0x7052A10", VA = "0x187054410")]
	private void IHEPCPFIKGN(JPACNABPFMO PDMCLEPJIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x7053AB0", Offset = "0x70520B0", VA = "0x187053AB0")]
	private void BAAMIPKPELP(JPACNABPFMO PDMCLEPJIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x7053DA0", Offset = "0x70523A0", VA = "0x187053DA0")]
	private void BLGCEEBDLKO(JPACNABPFMO PDMCLEPJIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x7053880", Offset = "0x7051E80", VA = "0x187053880")]
	private HPDKHMJHFIJ AKPFJPIBGBA(JFFNGMFLFPF ACIHLJMOGPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7053680", Offset = "0x7051C80", VA = "0x187053680")]
	private void AJNPBIJFDPI(JFFNGMFLFPF KEDIFEAIFED, HPDKHMJHFIJ IHHIFBKDPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7054E70", Offset = "0x7053470", VA = "0x187054E70")]
	private bool MDLJNLAHJGK(JFFNGMFLFPF KEDIFEAIFED, HPDKHMJHFIJ IHHIFBKDPEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7054C00", Offset = "0x7053200", VA = "0x187054C00")]
	private bool LJKJLDJEMKN(JFFNGMFLFPF OGNPOEOKNIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7054980", Offset = "0x7052F80", VA = "0x187054980")]
	private bool LGCFONKGANB(byte CEGADOPBLMK, ExitGames.Client.Photon.Hashtable PDMCLEPJIEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public GGHKJKKBKNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[UnityEngine.Scripting.Preserve]
internal sealed class NKHEINDOECE : HCOHAMMHFKP, BDDMINNAEKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class GPNAHAPPFOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public NPEAHLFIFPI operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public NKHEINDOECE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public JFFNGMFLFPF roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public GPNAHAPPFOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x7056580", Offset = "0x7054B80", VA = "0x187056580")]
		internal object EBGAAFEMMMC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x70565F0", Offset = "0x7054BF0", VA = "0x1870565F0")]
		internal object JBAJJHIIJIO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct NOABDHAJEME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public AsyncTaskMethodBuilder<HPDKHMJHFIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public NKHEINDOECE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public JFFNGMFLFPF roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private ILDHCOMNJFF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private TaskAwaiter<HPDKHMJHFIJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x7067850", Offset = "0x7065E50", VA = "0x187067850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x7067ED0", Offset = "0x70664D0", VA = "0x187067ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class CFEMDIOCCCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public NPEAHLFIFPI operationType;

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public CFEMDIOCCCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x704DDF0", Offset = "0x704C3F0", VA = "0x18704DDF0")]
		internal object LCCIBNALIPI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class LIJFHMGELIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public JFFNGMFLFPF request;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public LIJFHMGELIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x70627B0", Offset = "0x7060DB0", VA = "0x1870627B0")]
		internal object OOPHNKFEPHM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x7062740", Offset = "0x7060D40", VA = "0x187062740")]
		internal object NJIIPJOIPNO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x70626D0", Offset = "0x7060CD0", VA = "0x1870626D0")]
		internal object MJPOBHBFKJO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct ELEGBOKKCOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public AsyncTaskMethodBuilder<HPDKHMJHFIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public JFFNGMFLFPF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public NKHEINDOECE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private LIJFHMGELIM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private ILDHCOMNJFF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private FDCHOCHDFOM <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private HPDKHMJHFIJ <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private TaskAwaiter<(HPDKHMJHFIJ validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x7052750", Offset = "0x7050D50", VA = "0x187052750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x7053000", Offset = "0x7051600", VA = "0x187053000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private FLALAMNEBHN DKJHBDBMIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private LJKKPKNLFFF DFFFACFKJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private FFCNIOJJAOM AIPCMJNBLAG;

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x7067150", Offset = "0x7065750", VA = "0x187067150", Slot = "5")]
	public void HGDANEHJCNG(DGKBIEGBPPF EGEPJAHBNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x7067030", Offset = "0x7065630", VA = "0x187067030", Slot = "4")]
	[AsyncStateMachine(typeof(NOABDHAJEME))]
	private Task<HPDKHMJHFIJ> GAJPCODKIAE(JFFNGMFLFPF ACIHLJMOGPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x7067200", Offset = "0x7065800", VA = "0x187067200")]
	private bool IHLFHKEJALG(NPEAHLFIFPI FKCGACHMIMJ, [Out] HPDKHMJHFIJ JKLHKLABFHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x70673F0", Offset = "0x70659F0", VA = "0x1870673F0")]
	[AsyncStateMachine(typeof(ELEGBOKKCOC))]
	private Task<HPDKHMJHFIJ> PBIIOJHGOGF(JFFNGMFLFPF FALAJMPCHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public NKHEINDOECE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class MGFLOMCDHHB : CPFKOHNEIKA, BDDMINNAEKA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private struct AELOFJIPANK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public AsyncTaskMethodBuilder<LDJGBBGIHDL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public HGMCNBIJHOL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public MGFLOMCDHHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private TaskAwaiter<EKOKDGMBHGJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private TaskAwaiter<LDJGBBGIHDL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x704B640", Offset = "0x7049C40", VA = "0x18704B640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x704BC10", Offset = "0x704A210", VA = "0x18704BC10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class HKJNAAHKIHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public HKJNAAHKIHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x7059270", Offset = "0x7057870", VA = "0x187059270")]
		internal object JIMHMADJHLP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct BHECJMNAFKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public AsyncTaskMethodBuilder<EKOKDGMBHGJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public MGFLOMCDHHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public HGMCNBIJHOL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private HKJNAAHKIHF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private TaskAwaiter<EKOKDGMBHGJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x704C900", Offset = "0x704AF00", VA = "0x18704C900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x704CEF0", Offset = "0x704B4F0", VA = "0x18704CEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct GNEFANEOBNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public AsyncTaskMethodBuilder<LDJGBBGIHDL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public MGFLOMCDHHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public HGMCNBIJHOL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public EKOKDGMBHGJ roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private TaskAwaiter<(LDJPCHCCHLD superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x7055FD0", Offset = "0x70545D0", VA = "0x187055FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x7056430", Offset = "0x7054A30", VA = "0x187056430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class EBGOACNCDMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public EBGOACNCDMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xA1AA10", Offset = "0xA19010", VA = "0x180A1AA10")]
		internal bool KOICJFHOEHA(DCPEFLIKEJN sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct OJGILHADMPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public AsyncTaskMethodBuilder<(LDJPCHCCHLD superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public EKOKDGMBHGJ roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public MGFLOMCDHHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public HGMCNBIJHOL targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private TaskAwaiter<(LDJPCHCCHLD superRoomData, long subRoomDataSaveId)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x7068480", Offset = "0x7066A80", VA = "0x187068480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x7068B20", Offset = "0x7067120", VA = "0x187068B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class KIEOJKBLLNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public KIEOJKBLLNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x7061010", Offset = "0x705F610", VA = "0x187061010")]
		internal object OHNFEHEEGAO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct KEFEHNKOBOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public AsyncTaskMethodBuilder<(LDJPCHCCHLD superRoomData, long subRoomDataSaveId)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public DCPEFLIKEJN subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public MGFLOMCDHHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public HGMCNBIJHOL dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private KIEOJKBLLNF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<KOKKKOEPCAE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x7060880", Offset = "0x705EE80", VA = "0x187060880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x7060FA0", Offset = "0x705F5A0", VA = "0x187060FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static readonly (LDJPCHCCHLD superRoomData, long subRoomDataSaveId) JDAOFBFFGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private NLIIDIBLEBA FGMBCEGOCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private MADIJKNICIM NKCCIBMIBBE;

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x70647C0", Offset = "0x7062DC0", VA = "0x1870647C0", Slot = "5")]
	public void HGDANEHJCNG(DGKBIEGBPPF EGEPJAHBNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x7064C90", Offset = "0x7063290", VA = "0x187064C90", Slot = "4")]
	[AsyncStateMachine(typeof(AELOFJIPANK))]
	public Task<LDJGBBGIHDL> NCPBBGGLGJP(NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, HGMCNBIJHOL EKIDHODEHNL, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x7064850", Offset = "0x7062E50", VA = "0x187064850")]
	[AsyncStateMachine(typeof(BHECJMNAFKL))]
	private Task<EKOKDGMBHGJ> HHOJLDDMEKM(HGMCNBIJHOL EKIDHODEHNL, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7064DF0", Offset = "0x70633F0", VA = "0x187064DF0")]
	[AsyncStateMachine(typeof(GNEFANEOBNE))]
	private Task<LDJGBBGIHDL> OPJAIOCGBGI(HGMCNBIJHOL EKIDHODEHNL, EKOKDGMBHGJ GGGFNCHABMK, long OAOPHNECJFF, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x70649B0", Offset = "0x7062FB0", VA = "0x1870649B0")]
	[AsyncStateMachine(typeof(OJGILHADMPG))]
	private Task<(LDJPCHCCHLD, long)> JNFNOHAKGCJ(HGMCNBIJHOL EKIDHODEHNL, EKOKDGMBHGJ GGGFNCHABMK, long OAOPHNECJFF, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x7064B20", Offset = "0x7063120", VA = "0x187064B20")]
	[AsyncStateMachine(typeof(KEFEHNKOBOD))]
	private Task<(LDJPCHCCHLD, long)> MCMDAGJFDNO(HGMCNBIJHOL CEIEHAAFPHA, DCPEFLIKEJN OKPLOAFJIBL, long OAOPHNECJFF, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public MGFLOMCDHHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[UnityEngine.Scripting.Preserve]
internal sealed class GIDFKEAOLIH : HAPFKOABDCC, BDDMINNAEKA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class DHPONMOEJIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public JFFNGMFLFPF request;

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public DHPONMOEJIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x7050850", Offset = "0x704EE50", VA = "0x187050850")]
		internal object CFGMHPBOELL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct KPFCBEKOBDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public AsyncTaskMethodBuilder<JFFNGMFLFPF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public JFFNGMFLFPF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public GIDFKEAOLIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public HHMJIEMKLLO pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private ILDHCOMNJFF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private TaskAwaiter<JFFNGMFLFPF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x70619E0", Offset = "0x705FFE0", VA = "0x1870619E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x7061FF0", Offset = "0x70605F0", VA = "0x187061FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct EENPOMKNJCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public AsyncTaskMethodBuilder<JFFNGMFLFPF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public GIDFKEAOLIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public HHMJIEMKLLO pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private ILDHCOMNJFF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private TaskAwaiter<PMENCPCLKEC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x70514E0", Offset = "0x704FAE0", VA = "0x1870514E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x7051AD0", Offset = "0x70500D0", VA = "0x187051AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private sealed class KBEFDAMALBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public JFFNGMFLFPF request;

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public KBEFDAMALBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x7060820", Offset = "0x705EE20", VA = "0x187060820")]
		internal object HIAHGABPDDB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct HHMGCFKNPFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public AsyncTaskMethodBuilder<JFFNGMFLFPF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public JFFNGMFLFPF request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public GIDFKEAOLIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public HHMJIEMKLLO pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private ILDHCOMNJFF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private OBHAMMOLPMK <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private AKNIMJBBEJA <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private TaskAwaiter<PMENCPCLKEC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x70570D0", Offset = "0x70556D0", VA = "0x1870570D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x7057CC0", Offset = "0x70562C0", VA = "0x187057CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private FLALAMNEBHN DKJHBDBMIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private GKJFBPNEODH FKNOAJHMFKF;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	private PKDAPLNAFOM LBEOBFABIPE
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x7055910", Offset = "0x7053F10", VA = "0x187055910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x7055880", Offset = "0x7053E80", VA = "0x187055880", Slot = "8")]
	public void HGDANEHJCNG(DGKBIEGBPPF EGEPJAHBNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x7055E10", Offset = "0x7054410", VA = "0x187055E10", Slot = "4")]
	[AsyncStateMachine(typeof(KPFCBEKOBDJ))]
	public Task<JFFNGMFLFPF> MIDLNKGDLCK(JFFNGMFLFPF FALAJMPCHDK, HHMJIEMKLLO MMKIPOAGEKJ, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x70555D0", Offset = "0x7053BD0", VA = "0x1870555D0", Slot = "5")]
	[AsyncStateMachine(typeof(EENPOMKNJCK))]
	public Task<JFFNGMFLFPF> DMEGJKLFEPI(CancellationToken NNGMAHIDECE, HHMJIEMKLLO MMKIPOAGEKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x70559D0", Offset = "0x7053FD0", VA = "0x1870559D0", Slot = "6")]
	public CHNELKEAFEA JMGPADOLCEF(EMCBHBKNJFL KJKHIMDGLFJ, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7055BE0", Offset = "0x70541E0", VA = "0x187055BE0", Slot = "7")]
	public CHNELKEAFEA MCJJLNHAAAP(EMCBHBKNJFL KJKHIMDGLFJ, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x7055720", Offset = "0x7053D20", VA = "0x187055720")]
	[AsyncStateMachine(typeof(HHMGCFKNPFP))]
	private Task<JFFNGMFLFPF> FGIBGKKDELN(JFFNGMFLFPF FALAJMPCHDK, HHMJIEMKLLO MMKIPOAGEKJ, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x296BA90", Offset = "0x296A090", VA = "0x18296BA90")]
	private static byte[] CONJAIDJEBI(JFFNGMFLFPF DICMABMCPKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public GIDFKEAOLIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[UnityEngine.Scripting.Preserve]
internal sealed class NHOJKCBANME : LJKKPKNLFFF, BDDMINNAEKA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private BMOLNLPEKDN KLJGOIAJMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	private FLALAMNEBHN DKJHBDBMIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private ENDOPHJFGJG MNEMMLJKKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private DAEJDKENKKH IIKOEAGJDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private NLIIDIBLEBA FGMBCEGOCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private BEFGPGKBHMM OGHKBAKCDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private ECPEOHHOAOL BAFEAEOPOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private NOPIHKDGHEM AHDGGDAMLGE;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private CKDFPPPACKB IMNGEJLDDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x7066B70", Offset = "0x7065170", VA = "0x187066B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	private static HPDKHMJHFIJ HJONLODJBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x7056780", Offset = "0x7054D80", VA = "0x187056780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x7066BC0", Offset = "0x70651C0", VA = "0x187066BC0", Slot = "6")]
	public void HGDANEHJCNG(DGKBIEGBPPF EGEPJAHBNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x7066A00", Offset = "0x7065000", VA = "0x187066A00", Slot = "4")]
	public HPDKHMJHFIJ DAPOBGBCIKF(HDIGMKHIDBN PPBAIHEIPKK, NPEAHLFIFPI GDINAMIEDDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x7066D30", Offset = "0x7065330", VA = "0x187066D30", Slot = "5")]
	public HPDKHMJHFIJ HJMJNKNNJME(HDIGMKHIDBN FDIALPLINAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x7056720", Offset = "0x7054D20", VA = "0x187056720")]
	private static HPDKHMJHFIJ CKINCFOLKKP(ILCLNGBPFIK HBKEEHODHEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public NHOJKCBANME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class EICGNJHFFOI : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x7051F70", Offset = "0x7050570", VA = "0x187051F70")]
	public EICGNJHFFOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x64F8010", Offset = "0x64F6610", VA = "0x1864F8010")]
	public EICGNJHFFOI(string DICMABMCPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[UnityEngine.Scripting.Preserve]
internal sealed class MAMKEEGBNCP : AMOHHLGBNJG, BDDMINNAEKA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct MDPOFBMKDFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public AsyncTaskMethodBuilder<HPDKHMJHFIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public MAMKEEGBNCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public BIELPDNJBMP autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private NEGKJPNCLPM<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private KIPNJDCCGPP <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private TaskAwaiter<HPDKHMJHFIJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x7063BD0", Offset = "0x70621D0", VA = "0x187063BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x7064750", Offset = "0x7062D50", VA = "0x187064750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct MIOHEGJELGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public MAMKEEGBNCP <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7065030", Offset = "0x7063630", VA = "0x187065030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x7065760", Offset = "0x7063D60", VA = "0x187065760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct PIOANCKLMAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public MAMKEEGBNCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x70693B0", Offset = "0x70679B0", VA = "0x1870693B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x70698C0", Offset = "0x7067EC0", VA = "0x1870698C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct EKNOINGHKNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public MAMKEEGBNCP <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7051FB0", Offset = "0x70505B0", VA = "0x187051FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x70526F0", Offset = "0x7050CF0", VA = "0x1870526F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct PPAOELGNEDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public MAMKEEGBNCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7069E90", Offset = "0x7068490", VA = "0x187069E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x706A030", Offset = "0x7068630", VA = "0x18706A030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct JNLNJDMKJOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public MAMKEEGBNCP <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x705EF70", Offset = "0x705D570", VA = "0x18705EF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x705F680", Offset = "0x705DC80", VA = "0x18705F680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct OIPJCCGFDHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public MAMKEEGBNCP <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7067F40", Offset = "0x7066540", VA = "0x187067F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x70683B0", Offset = "0x70669B0", VA = "0x1870683B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct BJOMOGEDODN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public MAMKEEGBNCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public OPKNKODACNB autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private NEGKJPNCLPM<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x704CF60", Offset = "0x704B560", VA = "0x18704CF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x704D4C0", Offset = "0x704BAC0", VA = "0x18704D4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private FLALAMNEBHN DKJHBDBMIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private DGKBIEGBPPF EGEPJAHBNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private NLIIDIBLEBA FGMBCEGOCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private HAPFKOABDCC MJAOFLMLIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private ENDOPHJFGJG MNEMMLJKKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private ECPEOHHOAOL BAFEAEOPOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private CancellationTokenSource KHCNDLOPPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private Task JEDLLJFCJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private TaskCompletionSource<int> EGGOIPLPDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private int JMIHIKMNHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private int HOLFGPIOAED;

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x7062D10", Offset = "0x7061310", VA = "0x187062D10", Slot = "6")]
	public void HGDANEHJCNG(DGKBIEGBPPF EGEPJAHBNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0xB643F0", Offset = "0xB629F0", VA = "0x180B643F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x7063610", Offset = "0x7061C10", VA = "0x187063610")]
	private void PBEHJOCFLNF(float OOGLMEPOOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x70629D0", Offset = "0x7060FD0", VA = "0x1870629D0", Slot = "4")]
	[AsyncStateMachine(typeof(MDPOFBMKDFJ))]
	public Task<HPDKHMJHFIJ> BOGLHKNCCDK(BIELPDNJBMP CKBPCDCCCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x7063120", Offset = "0x7061720", VA = "0x187063120", Slot = "5")]
	[AsyncStateMachine(typeof(MIOHEGJELGK))]
	public Task MMLHKFJOEGH([Optional] CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0xB643F0", Offset = "0xB629F0", VA = "0x180B643F0")]
	public void OKMKLHNKLGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x70633A0", Offset = "0x70619A0", VA = "0x1870633A0")]
	private KIPNJDCCGPP OHPGOLBMOOG(BIELPDNJBMP CKBPCDCCCCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x70628E0", Offset = "0x7060EE0", VA = "0x1870628E0")]
	[AsyncStateMachine(typeof(PIOANCKLMAB))]
	private Task ANPLBHIKGOP(CancellationToken MEHJFMOAFKE, int GJEBBAHEDKL, IDJDNLONMLP COJGCKPIFMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x7062B00", Offset = "0x7061100", VA = "0x187062B00")]
	[AsyncStateMachine(typeof(EKNOINGHKNL))]
	private Task FHKABAJMGFM(CancellationToken MEHJFMOAFKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x70637E0", Offset = "0x7061DE0", VA = "0x1870637E0")]
	[AsyncStateMachine(typeof(PPAOELGNEDM))]
	private Task PKDEJMMJMLD([Optional] CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x70636F0", Offset = "0x7061CF0", VA = "0x1870636F0")]
	[AsyncStateMachine(typeof(JNLNJDMKJOH))]
	private Task PECJILINMOJ(CancellationToken MEHJFMOAFKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x7063510", Offset = "0x7061B10", VA = "0x187063510")]
	[AsyncStateMachine(typeof(OIPJCCGFDHH))]
	private Task PADEJDLFJNC(CancellationToken EBDEOCHDPHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x7063210", Offset = "0x7061810", VA = "0x187063210")]
	private Task MPFNKNADIIE(OPKNKODACNB KHBEOAAPNLC, CancellationToken MEHJFMOAFKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x7062C00", Offset = "0x7061200", VA = "0x187062C00")]
	[AsyncStateMachine(typeof(BJOMOGEDODN))]
	private Task FNNBNCEIPFC(OPKNKODACNB KHBEOAAPNLC, CancellationToken MEHJFMOAFKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x7062EC0", Offset = "0x70614C0", VA = "0x187062EC0")]
	private bool KCMJDPAEHIM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public MAMKEEGBNCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[UnityEngine.Scripting.Preserve]
internal class NABKJOEAGFD : DAEJDKENKKH, BDDMINNAEKA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private struct OPLFCGCCKBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public NABKJOEAGFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private NEGKJPNCLPM<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x7068C70", Offset = "0x7067270", VA = "0x187068C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x70691D0", Offset = "0x70677D0", VA = "0x1870691D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private JEMHDCFBCKM GDCECAJJDLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	private DGKBIEGBPPF EGEPJAHBNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private LJKKPKNLFFF DFFFACFKJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private HAPFKOABDCC MJAOFLMLIDA;

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x70660E0", Offset = "0x70646E0", VA = "0x1870660E0", Slot = "6")]
	public void HGDANEHJCNG(DGKBIEGBPPF EGEPJAHBNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x7066090", Offset = "0x7064690", VA = "0x187066090", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x7066510", Offset = "0x7064B10", VA = "0x187066510", Slot = "5")]
	[AsyncStateMachine(typeof(OPLFCGCCKBF))]
	public Task OBJFJFFDKBE(string DLMOEDNDKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x70663C0", Offset = "0x70649C0", VA = "0x1870663C0", Slot = "4")]
	public HPDKHMJHFIJ KCMJDPAEHIM(HDIGMKHIDBN PPBAIHEIPKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x7066420", Offset = "0x7064A20", VA = "0x187066420")]
	private BLLIDKAOMKE MJNHFPHGOMJ(string DLMOEDNDKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public NABKJOEAGFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public static class BLEHEIKHCAD
{
	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x704D760", Offset = "0x704BD60", VA = "0x18704D760")]
	public static void JCCLPEDHAMB(JJHPIOCMJGA CEJMOFAPBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x704D520", Offset = "0x704BB20", VA = "0x18704D520")]
	internal static void GKINDNGLADA(JJHPIOCMJGA CEJMOFAPBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x704D680", Offset = "0x704BC80", VA = "0x18704D680")]
	internal static void GNGBHONOJKN(JJHPIOCMJGA CEJMOFAPBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x704D9A0", Offset = "0x704BFA0", VA = "0x18704D9A0")]
	internal static void LDLOFNGGAGA(JJHPIOCMJGA CEJMOFAPBGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal class MKKMIBBKEFO : KGLDFBOMHJP<JFFNGMFLFPF>
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class NBKJEOGFKMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public JFFNGMFLFPF message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public NBKJEOGFKMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x7066610", Offset = "0x7064C10", VA = "0x187066610")]
		internal object AICJCCBHPFL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly MKKMIBBKEFO HHHOBHGDEHO;

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x70657C0", Offset = "0x7063DC0", VA = "0x1870657C0")]
	public ExitGames.Client.Photon.Hashtable ALGEABNCNAB(JFFNGMFLFPF DICMABMCPKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x7065E30", Offset = "0x7064430", VA = "0x187065E30", Slot = "5")]
	protected override void MKMKOEKGOIA(JFFNGMFLFPF DICMABMCPKO, IDictionary<object, object> JHLEMCFOEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x7065850", Offset = "0x7063E50", VA = "0x187065850", Slot = "6")]
	public override JFFNGMFLFPF DIPBOAAMMJI(IDictionary<object, object> JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x7065A80", Offset = "0x7064080", VA = "0x187065A80")]
	private static void FFHOJNCMEGD(string JNGNKNMOMFL, JFFNGMFLFPF DICMABMCPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x7065FF0", Offset = "0x70645F0", VA = "0x187065FF0")]
	public MKKMIBBKEFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x7065B90", Offset = "0x7064190", VA = "0x187065B90")]
	[CompilerGenerated]
	internal static string IGFHDFIAJEM(LDJGBBGIHDL JFHMMOFAOJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public static class HCMOHIJACCP
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public static HPDKHMJHFIJ HJONLODJBAA
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x7056780", Offset = "0x7054D80", VA = "0x187056780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x7056C20", Offset = "0x7055220", VA = "0x187056C20")]
	public static bool PLFBGHIFELJ(this HPDKHMJHFIJ IHHIFBKDPEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x7056720", Offset = "0x7054D20", VA = "0x187056720")]
	public static HPDKHMJHFIJ CKINCFOLKKP(ILCLNGBPFIK FLBIIFCJJFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x7056A30", Offset = "0x7055030", VA = "0x187056A30")]
	public static HPDKHMJHFIJ MBDEMIBNEHA(IEnumerable<HPDKHMJHFIJ> DNFAEPINKEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x70567E0", Offset = "0x7054DE0", VA = "0x1870567E0")]
	public static string LBMNKLOGKBI(this HPDKHMJHFIJ JKLHKLABFHH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public abstract class EFMKJFEFHEN : FLGGGNHJKFH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public delegate HPDKHMJHFIJ MBPMGEHPGMN([NotNull] HDIGMKHIDBN DMHBNNGHNLI);

	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private sealed class HDDNHECLKEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public HDIGMKHIDBN photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public HDDNHECLKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x6700FF0", Offset = "0x66FF5F0", VA = "0x186700FF0")]
		internal HPDKHMJHFIJ BFMMIKKHKBD(MBPMGEHPGMN v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private bool KKDPLHMNJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	protected readonly HashSet<MBPMGEHPGMN> NHALLJNCALH;

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x7051B40", Offset = "0x7050140", VA = "0x187051B40", Slot = "4")]
	public void BCDPHBDPLHA(MBPMGEHPGMN LEHPCHKLHBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x7051E80", Offset = "0x7050480", VA = "0x187051E80", Slot = "5")]
	public void KPAFNMDNFDL(MBPMGEHPGMN LEHPCHKLHBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x7051BA0", Offset = "0x70501A0", VA = "0x187051BA0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x7051BF0", Offset = "0x70501F0", VA = "0x187051BF0")]
	protected HPDKHMJHFIJ GBMFEOHBCOH(HDIGMKHIDBN FDIALPLINAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x7051EE0", Offset = "0x70504E0", VA = "0x187051EE0")]
	protected EFMKJFEFHEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class HMHEGOHNCMF : EFMKJFEFHEN, BMOLNLPEKDN, FLGGGNHJKFH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private sealed class FNININCCPAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public HPDKHMJHFIJ result;

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public FNININCCPAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x7053170", Offset = "0x7051770", VA = "0x187053170")]
		internal object OPHECPKEBKC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x7059670", Offset = "0x7057C70", VA = "0x187059670")]
	[UnityEngine.Scripting.Preserve]
	public HMHEGOHNCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x7059560", Offset = "0x7057B60", VA = "0x187059560", Slot = "8")]
	public HPDKHMJHFIJ EMJHOHONAHP(HDIGMKHIDBN FDIALPLINAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class JOCKHMILIGM : EFMKJFEFHEN, JEMHDCFBCKM, FLGGGNHJKFH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private sealed class JBMDDFCHMCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public HPDKHMJHFIJ result;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public JBMDDFCHMCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x705EBF0", Offset = "0x705D1F0", VA = "0x18705EBF0")]
		internal object NFKDNEECOKG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x7059670", Offset = "0x7057C70", VA = "0x187059670")]
	[UnityEngine.Scripting.Preserve]
	public JOCKHMILIGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x705F6E0", Offset = "0x705DCE0", VA = "0x18705F6E0", Slot = "8")]
	public HPDKHMJHFIJ KCMJDPAEHIM(HDIGMKHIDBN CJFAPAOPNFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal static class HEKLNANMJMH
{
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private sealed class IHKABJNPLKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public NEGKJPNCLPM<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public IHKABJNPLKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x705C760", Offset = "0x705AD60", VA = "0x18705C760")]
		internal object ADJNFJMDION()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x7056FF0", Offset = "0x70555F0", VA = "0x187056FF0")]
	public static NEGKJPNCLPM<string> GHHKLIDAMJB(CHNLCLDOCNE CNCAEGCNGHI, [Optional] string CLHKEAHONNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x7056F30", Offset = "0x7055530", VA = "0x187056F30")]
	public static void GFKENALKFOL(NEGKJPNCLPM<string> CIAFJLABOOB, CHNLCLDOCNE CNCAEGCNGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x7056E70", Offset = "0x7055470", VA = "0x187056E70")]
	public static string FCOHBOKFDEA(JFFNGMFLFPF ACIHLJMOGPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal static class LGGBBCIMIOP
{
	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x7062200", Offset = "0x7060800", VA = "0x187062200")]
	public static void JOKABOKJBCJ(this FLALAMNEBHN DKJHBDBMIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x70621F0", Offset = "0x70607F0", VA = "0x1870621F0")]
	public static void BLFGCNOIFNP(this FLALAMNEBHN DKJHBDBMIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x70620D0", Offset = "0x70606D0", VA = "0x1870620D0")]
	private static void BDAHFNOIBJA(this FLALAMNEBHN DKJHBDBMIJF, bool CIFGMILPHGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public class PLHHOIAFHIK : NHJBGGFEMDA, KIOEAKNMKNI, LJDAHJNGHJK, PHFNGDHPOLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	private readonly KIOEAKNMKNI NGONEHJOFAB;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public HDIGMKHIDBN ABFMBIMEGBL
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x7069D50", Offset = "0x7068350", VA = "0x187069D50", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public int PJNLIEBFANF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x7069D00", Offset = "0x7068300", VA = "0x187069D00", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public int FICBKJJDBLL
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x7069CB0", Offset = "0x70682B0", VA = "0x187069CB0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool BKMEKPMOMNC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public int KDIMAAIJGLH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x9BD990", Offset = "0x9BBF90", VA = "0x1809BD990", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event DLIOPHKMJLC.NCEAGOHEJMG AFACODBBOHE
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event FNMHABIMGOE ICGJJPEHFDI
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x7069DF0", Offset = "0x70683F0", VA = "0x187069DF0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x7069B40", Offset = "0x7068140", VA = "0x187069B40", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> BLEKAPGIFAO
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<HDIGMKHIDBN> PLCEBOIOPGB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action FJNLIJFGHHC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7069AA0", Offset = "0x70680A0", VA = "0x187069AA0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x7069A00", Offset = "0x7068000", VA = "0x187069A00", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0xB34D10", Offset = "0xB33310", VA = "0x180B34D10")]
	public PLHHOIAFHIK(KIOEAKNMKNI NGONEHJOFAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x7069C00", Offset = "0x7068200", VA = "0x187069C00", Slot = "8")]
	public bool JPABEBGHGJL(byte CEGADOPBLMK, ExitGames.Client.Photon.Hashtable NAPBHFEGJGG, CIIEIDLKBFO CHEGBPBNFDK, SendOptions IJGCIGLFBFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x7069920", Offset = "0x7067F20", VA = "0x187069920", Slot = "16")]
	public HDIGMKHIDBN BMLMNMLAMCP(int CHDKDNONPDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "19")]
	public void NKFLGEFJFHO(object PNPIGCGKNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "20")]
	public void DACLGFPFPMI(object PNPIGCGKNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "21")]
	public void ENEDHIDCHJI(object PNPIGCGKNPI, bool JOMLCPJCKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x7069DA0", Offset = "0x70683A0", VA = "0x187069DA0", Slot = "22")]
	public IDisposable NFDFGAJFHDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "23")]
	private bool IDPMCKNBPJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "24")]
	public void FMFGKNLLLKM(StringBuilder PDAIPCIFCDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x7069BE0", Offset = "0x70681E0", VA = "0x187069BE0", Slot = "25")]
	public bool GCEAOPLJIKG(bool KBMPJBLKAGK, [Out] string BDGJCBKBDPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0xA4FDF0", Offset = "0xA4E3F0", VA = "0x180A4FDF0", Slot = "28")]
	public void NNAHGJMICAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal struct JPACNABPFMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	private readonly IDictionary<object, object> PDMCLEPJIEA;

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0xA150A0", Offset = "0xA136A0", VA = "0x180A150A0")]
	public JPACNABPFMO(IDictionary<object, object> PDMCLEPJIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x705FAC0", Offset = "0x705E0C0", VA = "0x18705FAC0")]
	public bool LIPJFKCHDMI([Out] JFFNGMFLFPF DICMABMCPKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x705F7F0", Offset = "0x705DDF0", VA = "0x18705F7F0")]
	public Guid ELNPMAJJFFB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x705F990", Offset = "0x705DF90", VA = "0x18705F990")]
	public HPDKHMJHFIJ LBOBGGAGDAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x705F8A0", Offset = "0x705DEA0", VA = "0x18705F8A0")]
	public static ExitGames.Client.Photon.Hashtable KKJEMJBKDLP(JFFNGMFLFPF DICMABMCPKO, HPDKHMJHFIJ IHHIFBKDPEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal static class IIFLOBCAOIN
{
	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x705C7E0", Offset = "0x705ADE0", VA = "0x18705C7E0")]
	public static bool JCAANNKEHDB(this HGMCNBIJHOL NIMHLKENONA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal struct JNLAJNBFNPL : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct HLDJLEDBOHM : IAsyncStateMachine
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
		public JNLAJNBFNPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x7059320", Offset = "0x7057920", VA = "0x187059320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x7059500", Offset = "0x7057B00", VA = "0x187059500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	private readonly CancellationTokenSource NIGBFOEDEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	private bool KKDPLHMNJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	private Task OOOMFPPINLE;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool NEEAOKHHHDA
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x705ED00", Offset = "0x705D300", VA = "0x18705ED00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x705EE40", Offset = "0x705D440", VA = "0x18705EE40")]
	public JNLAJNBFNPL(CancellationToken NNGMAHIDECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x705ED30", Offset = "0x705D330", VA = "0x18705ED30")]
	[AsyncStateMachine(typeof(HLDJLEDBOHM))]
	public Task OKMBMOCICAD(Func<CancellationToken, List<Task>> MNBGFACFFOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x705ECB0", Offset = "0x705D2B0", VA = "0x18705ECB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public readonly struct OAEEJPIMCGF<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct DIKJKCPIFKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<CIPNPJKLJID<TData>, EKHHLAEJNGE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public OAEEJPIMCGF<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private TaskAwaiter<HHANDHIMCMH<CIPNPJKLJID<TData>, EKHHLAEJNGE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x586C3A0", Offset = "0x586A9A0", VA = "0x18586C3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x3D488D0", Offset = "0x3D46ED0", VA = "0x183D488D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	private readonly GHCPBJHELOE<TGetDataArg, TData> JLNBNFBMIEP;

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0xA150A0", Offset = "0xA136A0", VA = "0x180A150A0")]
	internal OAEEJPIMCGF(GHCPBJHELOE<TGetDataArg, TData> MEELJJGMLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x46CF8F0", Offset = "0x46CDEF0", VA = "0x1846CF8F0")]
	[AsyncStateMachine(typeof(OAEEJPIMCGF<, >.DIKJKCPIFKA))]
	public Task<HHANDHIMCMH<CIPNPJKLJID<TData>, EKHHLAEJNGE>> DEGEDEECNOG(TGetDataArg BBMJLAKPCGK, string EGEHBKLIHEJ, NEGKJPNCLPM<string>.GBKOFALFHEN CIAFJLABOOB, CancellationToken NNGMAHIDECE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public static class KIHCFKNCOBH
{
	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x2973790", Offset = "0x2971D90", VA = "0x182973790")]
	public static OAEEJPIMCGF<TGetDataArg, TData> NKOJKFHACJH<TGetDataArg, TData>(GHCPBJHELOE<TGetDataArg, TData> MEELJJGMLGH)
	{
		return default(OAEEJPIMCGF<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public struct GNENAGGCEMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public readonly int JDJOMPPIAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public readonly int? BGLDMJECCFF;

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x4287650", Offset = "0x4285C50", VA = "0x184287650")]
	public GNENAGGCEMG(int JLNNPAODCHJ, [Optional] int? DCIJKGEFDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x70564A0", Offset = "0x7054AA0", VA = "0x1870564A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public interface FEHIKADEHJG<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FGOJEFEJIKO();

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FEHIKADEHJG<T> MAECPMCNPIH(string MDNKALPBOMB);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FEHIKADEHJG<T> LGCLCHCNIJB(MIHDJHPEHFK<T> CDONMDHPPMG);

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FEHIKADEHJG<T> GEHENDGOECK(int OJPBOBDPLEA);

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FEHIKADEHJG<T> ALJIEMKOKPE(int OJPBOBDPLEA, NNAJDJNPKBO<T> IGGIEIPFFCC);
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public interface DKFFGDNDPIF
{
	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FEHIKADEHJG<T> AJPGCJBLDFD<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LNEBELDLOEK JEIDJABKNFK(Exception KLEFNMOCNFP);

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GNENAGGCEMG NJGJPJFPCNK(Exception KLEFNMOCNFP);
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public delegate string MIHDJHPEHFK<in T>(T KLEFNMOCNFP) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public delegate int NNAJDJNPKBO<in T>(T KLEFNMOCNFP) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000E3")]
internal class CPMHPLNBGEI : DKFFGDNDPIF
{
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	private delegate string MMBEGILLDCA(Exception KLEFNMOCNFP);

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private delegate int BEGCLPNNAPD(Exception KLEFNMOCNFP);

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private class MOOKIICJJHM<T> : FEHIKADEHJG<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[CompilerGenerated]
		private sealed class ELNOHGMLPOF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x600041C")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public ELNOHGMLPOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0")]
			internal string JBIANCNOCNA(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		[CompilerGenerated]
		private sealed class NDEAFCBOHBE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public MIHDJHPEHFK<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public NDEAFCBOHBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x3E709F0", Offset = "0x3E6EFF0", VA = "0x183E709F0")]
			internal string CECAIAJJHME(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		[CompilerGenerated]
		private sealed class IPEMOOMFELN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public NNAJDJNPKBO<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public IPEMOOMFELN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x3E709F0", Offset = "0x3E6EFF0", VA = "0x183E709F0")]
			internal int HPFBGICHBMK(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private readonly CPMHPLNBGEI HCFAMJCELMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private readonly Type KFABCDFDCDB;

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x451D400", Offset = "0x451BA00", VA = "0x18451D400")]
		internal MOOKIICJJHM(CPMHPLNBGEI HCFAMJCELMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x451D150", Offset = "0x451B750", VA = "0x18451D150", Slot = "4")]
		public void FGOJEFEJIKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x451D2E0", Offset = "0x451B8E0", VA = "0x18451D2E0", Slot = "5")]
		public FEHIKADEHJG<T> MAECPMCNPIH(string MDNKALPBOMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x451D1C0", Offset = "0x451B7C0", VA = "0x18451D1C0", Slot = "6")]
		public FEHIKADEHJG<T> LGCLCHCNIJB(MIHDJHPEHFK<T> CDONMDHPPMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x451D180", Offset = "0x451B780", VA = "0x18451D180", Slot = "7")]
		public FEHIKADEHJG<T> GEHENDGOECK(int OJPBOBDPLEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x451D010", Offset = "0x451B610", VA = "0x18451D010", Slot = "8")]
		public FEHIKADEHJG<T> ALJIEMKOKPE(int OJPBOBDPLEA, NNAJDJNPKBO<T> IGGIEIPFFCC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	private class LDPEMEJHJNA<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private bool DACNINMFPNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private readonly List<Type> MINBHMEAPJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private readonly Dictionary<Type, TVal> DFMFEIPHIAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private readonly Dictionary<Type, int> PLJDFKPDODE;

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public IReadOnlyList<Type> INBKFPMBGNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x429DE70", Offset = "0x429C470", VA = "0x18429DE70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x429E0B0", Offset = "0x429C6B0", VA = "0x18429E0B0")]
		public LDPEMEJHJNA(Dictionary<Type, int> PLJDFKPDODE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x429DDB0", Offset = "0x429C3B0", VA = "0x18429DDB0")]
		public void AGMNBECNIJC(Type MNBFPOFIDHA, TVal GAELHANIPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x429E050", Offset = "0x429C650", VA = "0x18429E050")]
		public bool LKLFNLHAOPI(Type KFABCDFDCDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x429DFF0", Offset = "0x429C5F0", VA = "0x18429DFF0")]
		public bool JHEKNKIBEGE(TVal FEBGGALLBNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x3E4CCA0", Offset = "0x3E4B2A0", VA = "0x183E4CCA0")]
		public TVal BJJBEHDKBAF(Type BDKLEMDNAFL)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x429DC50", Offset = "0x429C250", VA = "0x18429DC50")]
		[CompilerGenerated]
		private int AAMONLDALJK(Type PFHCHHMDGMG, Type BKBMBPLCBAD)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private sealed class ACAOOEAGPPE : IEnumerable<GNENAGGCEMG>, IEnumerable, IEnumerator<GNENAGGCEMG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private GNENAGGCEMG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public CPMHPLNBGEI <>4__this;

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
		private IEnumerator<GNENAGGCEMG> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		private GNENAGGCEMG System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0x386B860", Offset = "0x3869E60", VA = "0x18386B860", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(GNENAGGCEMG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0x704B090", Offset = "0x7049690", VA = "0x18704B090", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x8A8AC0", Offset = "0x8A70C0", VA = "0x1808A8AC0")]
		[DebuggerHidden]
		public ACAOOEAGPPE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x704B0E0", Offset = "0x70496E0", VA = "0x18704B0E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x704AA90", Offset = "0x7049090", VA = "0x18704AA90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x704AF30", Offset = "0x7049530", VA = "0x18704AF30")]
		private void OGHBNIPNCAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x704AA40", Offset = "0x7049040", VA = "0x18704AA40")]
		private void MKLBAOAGFDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x704B040", Offset = "0x7049640", VA = "0x18704B040", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x704AF80", Offset = "0x7049580", VA = "0x18704AF80", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GNENAGGCEMG> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x704AF80", Offset = "0x7049580", VA = "0x18704AF80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private static readonly GNENAGGCEMG ICEGPPKLBKC;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private static readonly Dictionary<Type, int> BOOCPAKCELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private readonly HashSet<Type> FJLNMDMEFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private readonly LDPEMEJHJNA<int> LFCBKDIPLJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private readonly LDPEMEJHJNA<BEGCLPNNAPD> LPPPHMKFOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private readonly LDPEMEJHJNA<MMBEGILLDCA> COEIKANGDOG;

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x704F140", Offset = "0x704D740", VA = "0x18704F140")]
	[CCEDJDOPMOE(CFIDNIINJOK.GameOnly)]
	private static void EPFABJKOPAP(JJHPIOCMJGA KDALJJNBEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x7050520", Offset = "0x704EB20", VA = "0x187050520")]
	[RecRoom.NoEngine.Common.Preserve]
	public CPMHPLNBGEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x2973880", Offset = "0x2971E80", VA = "0x182973880", Slot = "4")]
	public FEHIKADEHJG<T> AJPGCJBLDFD<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x704F600", Offset = "0x704DC00", VA = "0x18704F600", Slot = "5")]
	public LNEBELDLOEK JEIDJABKNFK(Exception KLEFNMOCNFP)
	{
		return default(LNEBELDLOEK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x704FD10", Offset = "0x704E310", VA = "0x18704FD10", Slot = "6")]
	public GNENAGGCEMG NJGJPJFPCNK(Exception? KLEFNMOCNFP)
	{
		return default(GNENAGGCEMG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x704F330", Offset = "0x704D930", VA = "0x18704F330", Slot = "7")]
	[IteratorStateMachine(typeof(ACAOOEAGPPE))]
	public IEnumerable<GNENAGGCEMG> GIPICKCHCFE(Exception KLEFNMOCNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x704F3D0", Offset = "0x704D9D0", VA = "0x18704F3D0", Slot = "8")]
	public string IBFPMIHCFEH(Exception? KLEFNMOCNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x704FF10", Offset = "0x704E510", VA = "0x18704FF10")]
	private string OMABBFPODPI(AggregateException BIOBABCDPFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x704F690", Offset = "0x704DC90", VA = "0x18704F690")]
	private void JNGJJPDLEIO(Type KFABCDFDCDB, int OJPBOBDPLEA, BEGCLPNNAPD? CMAOAEGMHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x7050210", Offset = "0x704E810", VA = "0x187050210")]
	private void PELBIMPHLFA(Type KFABCDFDCDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x704FA40", Offset = "0x704E040", VA = "0x18704FA40")]
	private void LDLBFCJGIOC(Type KFABCDFDCDB, MMBEGILLDCA EGJGHLPCHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x704F1B0", Offset = "0x704D7B0", VA = "0x18704F1B0")]
	private static int FHNKDBMIDJH(Type KFABCDFDCDB, Dictionary<Type, int> PLJDFKPDODE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x2973910", Offset = "0x2971F10", VA = "0x182973910")]
	private static bool CNDCDNNOKHD<TVal>(LDPEMEJHJNA<TVal> EGCOBBLGNBO, Type KFABCDFDCDB, [Out] TVal FEBGGALLBNN) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x704F520", Offset = "0x704DB20", VA = "0x18704F520")]
	[CompilerGenerated]
	internal static int JANMANNOGOI(Type EPOLDHFIKIM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public struct LNEBELDLOEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public readonly GNENAGGCEMG NHIHLIOKFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public readonly string LKAPKCMKOMH;

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x70628C0", Offset = "0x7060EC0", VA = "0x1870628C0")]
	public LNEBELDLOEK(string GCMLJMJANBL, GNENAGGCEMG OJPBOBDPLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x7062820", Offset = "0x7060E20", VA = "0x187062820")]
	public string AJKJAKBNKKF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class ICAOLNNEGIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private readonly KFDOLDGEEBK LKNPLPJBOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private string DOMJGGEPHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private long? HAFEDICFBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private long? CCOKKCHFHGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private long? NHOJGKHPPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private string INLHIAEANBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private PFFFICEHDFP NPFADMPFNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private long? NMKPBAPAMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private bool LDENJIAENAM;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public string KIIOFFFBHLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public long FCFCDFFOIAA
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x7059680", Offset = "0x7057C80", VA = "0x187059680")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public long PJKKBCIPLBH
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x705A190", Offset = "0x7058790", VA = "0x18705A190")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public long HMKPHGADFML
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x7059BB0", Offset = "0x70581B0", VA = "0x187059BB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public string OPHNNENINNH
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x7059B70", Offset = "0x7058170", VA = "0x187059B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public PFFFICEHDFP LEDFBIBIKMP
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0xB44760", Offset = "0xB42D60", VA = "0x180B44760")]
		get
		{
			return default(PFFFICEHDFP);
		}
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x7059CB0", Offset = "0x70582B0", VA = "0x187059CB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public long OJIGJECPOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x705A1F0", Offset = "0x70587F0", VA = "0x18705A1F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x705A4A0", Offset = "0x7058AA0", VA = "0x18705A4A0")]
	[UnityEngine.Scripting.Preserve]
	public ICAOLNNEGIC([JLPFJOFFNLM(null)] KFDOLDGEEBK LKNPLPJBOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x705A250", Offset = "0x7058850", VA = "0x18705A250")]
	private void PIIELAMGCFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x70596E0", Offset = "0x7057CE0", VA = "0x1870596E0")]
	public void EHKGBAHBNBB(long ECHGOOGHLEN, long OAOPHNECJFF, [Optional] long? POCGMPECBEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7059C10", Offset = "0x7058210", VA = "0x187059C10")]
	public void HLKDODGJHJL(long POCGMPECBEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x705A110", Offset = "0x7058710", VA = "0x18705A110")]
	public void NDMMHKFFNKG(string OLJGIAPGKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x7059DA0", Offset = "0x70583A0", VA = "0x187059DA0")]
	public void MFKOEHBOOIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
internal class CHNELKEAFEA : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct NOFNEIKFNFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public AsyncTaskMethodBuilder<JFFNGMFLFPF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public JFFNGMFLFPF roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public CHNELKEAFEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private TaskAwaiter<PKDAPLNAFOM.PONAHAGHIAG<JFFNGMFLFPF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x707DE90", Offset = "0x707C490", VA = "0x18707DE90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x707E290", Offset = "0x707C890", VA = "0x18707E290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct OCDOIJIIGFF<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class ALADBKAJENO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public JFFNGMFLFPF roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public ALADBKAJENO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x706AD50", Offset = "0x7069350", VA = "0x18706AD50")]
		internal JFFNGMFLFPF IHDFDIEMECC(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct PMABCMMBBMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public AsyncTaskMethodBuilder<PKDAPLNAFOM.PONAHAGHIAG<JFFNGMFLFPF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public JFFNGMFLFPF roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public CHNELKEAFEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private OBHAMMOLPMK <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private TaskAwaiter<PKDAPLNAFOM.PONAHAGHIAG<JFFNGMFLFPF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x7080BC0", Offset = "0x707F1C0", VA = "0x187080BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x70811D0", Offset = "0x707F7D0", VA = "0x1870811D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct PDBHDEGFONC<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public CHNELKEAFEA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x480A2C0", Offset = "0x48088C0", VA = "0x18480A2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x358AEC0", Offset = "0x35894C0", VA = "0x18358AEC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private struct EBEEJDJHCJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public CHNELKEAFEA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7070C00", Offset = "0x706F200", VA = "0x187070C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x7070DC0", Offset = "0x706F3C0", VA = "0x187070DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class EAPABFHMEME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public EAPABFHMEME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x7070AE0", Offset = "0x706F0E0", VA = "0x187070AE0")]
		internal object KJFIBKIGGJE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x7070B40", Offset = "0x706F140", VA = "0x187070B40")]
		internal bool MCCENFHBADM(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class BDIGEGIOLOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public BDIGEGIOLOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x706BF90", Offset = "0x706A590", VA = "0x18706BF90")]
		internal object OOPLIOENHAP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class AKDAHKCMGBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public AKDAHKCMGBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x706ACE0", Offset = "0x70692E0", VA = "0x18706ACE0")]
		internal object ICEPMKMHAEC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class CGBINADMPAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public CGBINADMPAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x706DF00", Offset = "0x706C500", VA = "0x18706DF00")]
		internal object KAEJIBAOPAJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class AHAMBIEKPLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public CHNELKEAFEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public AHAMBIEKPLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x706A9E0", Offset = "0x7068FE0", VA = "0x18706A9E0")]
		internal object AICJCCBHPFL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private static readonly Guid CIPAFICBMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public readonly EMCBHBKNJFL PHKACIKJNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private readonly PKDAPLNAFOM LMPMFLKDMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private readonly LJDAHJNGHJK DKJHBDBMIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private readonly PHFNGDHPOLC ADPKBMGAFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private bool AGKOPMOIDLD;

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x704EF10", Offset = "0x704D510", VA = "0x18704EF10")]
	public CHNELKEAFEA(EMCBHBKNJFL AOBBNFODCCN, PKDAPLNAFOM LMPMFLKDMCP, LJDAHJNGHJK DKJHBDBMIJF, PHFNGDHPOLC ADPKBMGAFAI, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x704E310", Offset = "0x704C910", VA = "0x18704E310", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x704E310", Offset = "0x704C910", VA = "0x18704E310")]
	public void KKHHEMDEOHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x704E250", Offset = "0x704C850", VA = "0x18704E250")]
	public void DDAPENMCEON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x704E190", Offset = "0x704C790", VA = "0x18704E190")]
	public void COFIHCCBDAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x704EAC0", Offset = "0x704D0C0", VA = "0x18704EAC0")]
	[AsyncStateMachine(typeof(NOFNEIKFNFD))]
	internal Task<JFFNGMFLFPF> NFPCFBFNEED(NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, JFFNGMFLFPF ACIHLJMOGPE, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x296BA90", Offset = "0x296A090", VA = "0x18296BA90")]
	private static byte[] GALJALKPLEB<T>(T DICMABMCPKO) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x296BAA0", Offset = "0x296A0A0", VA = "0x18296BAA0")]
	private static T NKAIOIHFPPE<T>(MessageParser<T> KICLBLFHLEK, byte[] DICMABMCPKO, T GJJODCBBGNC) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x704EC20", Offset = "0x704D220", VA = "0x18704EC20")]
	[AsyncStateMachine(typeof(PMABCMMBBMA))]
	private Task<PKDAPLNAFOM.PONAHAGHIAG<JFFNGMFLFPF>> NPEPAPCJNKN(JFFNGMFLFPF ACIHLJMOGPE, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x296B7F0", Offset = "0x2969DF0", VA = "0x18296B7F0")]
	[AsyncStateMachine(typeof(PDBHDEGFONC<>))]
	internal Task<T> FOLABHJDAPA<T>(CancellationToken MEHJFMOAFKE, Func<CancellationToken, Task<T>> AAKBOGJAPEK, int BAEPOBIDCNL = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x704E650", Offset = "0x704CC50", VA = "0x18704E650")]
	[AsyncStateMachine(typeof(EBEEJDJHCJL))]
	internal Task FOLABHJDAPA(CancellationToken MEHJFMOAFKE, Func<CancellationToken, Task> AAKBOGJAPEK, int BAEPOBIDCNL = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x704E9C0", Offset = "0x704CFC0", VA = "0x18704E9C0")]
	public IABIBLPEMDN MNOKOCMFJFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x704EA40", Offset = "0x704D040", VA = "0x18704EA40")]
	public DGGOKOIKOMP NDMCPPJAAPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x704ED60", Offset = "0x704D360", VA = "0x18704ED60")]
	public LHEJNEPONLB PKNHJDIAPJH([Optional] CHNLCLDOCNE? CNCAEGCNGHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x704DEB0", Offset = "0x704C4B0", VA = "0x18704DEB0")]
	public void BHDLEPAJLPJ(Func<Guid, bool> BGOIMLPIHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x704E430", Offset = "0x704CA30", VA = "0x18704E430")]
	public void FCKEHNOAFLM(Func<Guid, bool> OPAMLGPFNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x704E010", Offset = "0x704C610", VA = "0x18704E010")]
	public Guid BHOIJHKCIDL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x704E8B0", Offset = "0x704CEB0", VA = "0x18704E8B0")]
	public void KDGAPCHIDEF(Guid GBHCOKFFHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x704E780", Offset = "0x704CD80", VA = "0x18704E780")]
	public void KAKMJDDICMO(JFFNGMFLFPF PDJHKGAFILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x704E540", Offset = "0x704CB40", VA = "0x18704E540")]
	public void FFHOJNCMEGD(string EFHFMIHNEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x296BBF0", Offset = "0x296A1F0", VA = "0x18296BBF0")]
	private T OABIHFLLACD<T>(T FEBGGALLBNN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x704DE60", Offset = "0x704C460", VA = "0x18704DE60")]
	public void BDDKLJBIANJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x296B550", Offset = "0x2969B50", VA = "0x18296B550")]
	[CompilerGenerated]
	internal static string EOEBBOHJJED<T>(byte[] CNNPIMPOGKL, int IHDCDPNCONH, OCDOIJIIGFF<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
internal sealed class PDCNIIIGGBF : EMCBHBKNJFL
{
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class LJLLKFIOLGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public LJLLKFIOLGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x707C9F0", Offset = "0x707AFF0", VA = "0x18707C9F0")]
		internal object JIKBKHJFEJJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private struct CHLBEKDBCFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public PDCNIIIGGBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public CHNELKEAFEA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private BKFAOGFLIJD <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private DGGOKOIKOMP <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x706DF70", Offset = "0x706C570", VA = "0x18706DF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x706E840", Offset = "0x706CE40", VA = "0x18706E840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct FIDCIHDJCFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public PDCNIIIGGBF <>4__this;

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
		private TaskAwaiter<EKOKDGMBHGJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private TaskAwaiter<byte> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x7073EA0", Offset = "0x70724A0", VA = "0x187073EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x7074640", Offset = "0x7072C40", VA = "0x187074640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private struct MCCLHEHKJPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public PDCNIIIGGBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private TaskAwaiter<KOKKKOEPCAE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x707CF80", Offset = "0x707B580", VA = "0x18707CF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x707D2A0", Offset = "0x707B8A0", VA = "0x18707D2A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private sealed class JGFINDILNCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public BKFAOGFLIJD presence;

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public JGFINDILNCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x7079D20", Offset = "0x7078320", VA = "0x187079D20")]
		internal object BAPAAMHLFIC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	private static readonly CHNLCLDOCNE CNCAEGCNGHI;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	private static readonly CHNLCLDOCNE NDGBKLCCDKD;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	private static readonly CHNLCLDOCNE FCKALKHHHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000387")]
	private readonly LDJGBBGIHDL NFJLBLDAECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000388")]
	private readonly HGMCNBIJHOL HKJCLCHOLPC;

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x707F8B0", Offset = "0x707DEB0", VA = "0x18707F8B0")]
	public PDCNIIIGGBF(LDJGBBGIHDL NFJLBLDAECB, HGMCNBIJHOL HKJCLCHOLPC, Guid MKCPOIIDFLO, DGKBIEGBPPF EGEPJAHBNCI, HHMJIEMKLLO KCFJFHIBKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x707F2C0", Offset = "0x707D8C0", VA = "0x18707F2C0", Slot = "7")]
	[AsyncStateMachine(typeof(CHLBEKDBCFP))]
	protected override Task BPNHCCABIHI(CHNELKEAFEA KIPAKJOBEFI, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x707F400", Offset = "0x707DA00", VA = "0x18707F400")]
	[AsyncStateMachine(typeof(FIDCIHDJCFJ))]
	private Task IIHPLDEABNG(CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x707F500", Offset = "0x707DB00", VA = "0x18707F500")]
	[AsyncStateMachine(typeof(MCCLHEHKJPA))]
	private Task<byte> NHIBBNJFBOL(CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x707F610", Offset = "0x707DC10", VA = "0x18707F610")]
	private BKFAOGFLIJD PDGDFJEGAJO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
internal class KIPNJDCCGPP : EMCBHBKNJFL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private struct ICJOLPBIPIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public KIPNJDCCGPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public CHNELKEAFEA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private TaskAwaiter<BIEOLNCJFEB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x70774E0", Offset = "0x7075AE0", VA = "0x1870774E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x7077E50", Offset = "0x7076450", VA = "0x187077E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	private readonly int HMIEACOBJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	private readonly BIELPDNJBMP BABFHOIKFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public readonly long PGIHBHDLOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public readonly long KKOKOJPJAJN;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public BIEOLNCJFEB MEJCNDJGKFP
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x861ED0", Offset = "0x8604D0", VA = "0x180861ED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x861E70", Offset = "0x860470", VA = "0x180861E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x707B2A0", Offset = "0x70798A0", VA = "0x18707B2A0")]
	public KIPNJDCCGPP(Guid MKCPOIIDFLO, DGKBIEGBPPF EGEPJAHBNCI, HHMJIEMKLLO KCFJFHIBKLG, int HMIEACOBJBC, BIELPDNJBMP BABFHOIKFOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x707B180", Offset = "0x7079780", VA = "0x18707B180", Slot = "7")]
	[AsyncStateMachine(typeof(ICJOLPBIPIO))]
	protected override Task BPNHCCABIHI(CHNELKEAFEA KIPAKJOBEFI, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal abstract class JKCAKDKHOKM : EMCBHBKNJFL
{
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private sealed class KJCAECILALN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public JKCAKDKHOKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public BHIJAPGKLNN playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public KJCAECILALN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x707B460", Offset = "0x7079A60", VA = "0x18707B460")]
		internal Task JADMFENPNDL(NEGKJPNCLPM<string>.GBKOFALFHEN postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x707B3D0", Offset = "0x70799D0", VA = "0x18707B3D0")]
		internal object ALOIONENBBF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private struct JCBPEGLPOBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public JKCAKDKHOKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public CHNELKEAFEA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private KJCAECILALN <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x7079500", Offset = "0x7077B00", VA = "0x187079500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x7079CC0", Offset = "0x70782C0", VA = "0x187079CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private struct PJADPGGLBJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public BHIJAPGKLNN playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public JKCAKDKHOKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x7080420", Offset = "0x707EA20", VA = "0x187080420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x70809B0", Offset = "0x707EFB0", VA = "0x1870809B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x707ABC0", Offset = "0x70791C0", VA = "0x18707ABC0")]
	public JKCAKDKHOKM(Guid MKCPOIIDFLO, DGKBIEGBPPF EGEPJAHBNCI, HHMJIEMKLLO KCFJFHIBKLG, string DABFDLJMNLN, NNMIPMOFGJK FKCGACHMIMJ, bool BDEKOOAIENN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x707A940", Offset = "0x7078F40", VA = "0x18707A940", Slot = "7")]
	[AsyncStateMachine(typeof(JCBPEGLPOBK))]
	protected override Task BPNHCCABIHI(CHNELKEAFEA KIPAKJOBEFI, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task CHAJOIIFAEA(CHNELKEAFEA KIPAKJOBEFI, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x707AA80", Offset = "0x7079080", VA = "0x18707AA80")]
	[AsyncStateMachine(typeof(PJADPGGLBJD))]
	private Task OBKMPCFECFF(IDisposable MAEDNJKIMJN, BHIJAPGKLNN IHMBFNBPFDE, NEGKJPNCLPM<string>.GBKOFALFHEN CIAFJLABOOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
internal class HCLBDEONFPE : EMCBHBKNJFL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private struct DBKBPEPMAGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public HCLBDEONFPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public CHNELKEAFEA operationContext;

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
		private TaskAwaiter<CAKNPLNONPM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x706E8A0", Offset = "0x706CEA0", VA = "0x18706E8A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x706EE00", Offset = "0x706D400", VA = "0x18706EE00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private readonly OPKNKODACNB KHBEOAAPNLC;

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x7075CE0", Offset = "0x70742E0", VA = "0x187075CE0")]
	public HCLBDEONFPE(Guid MKCPOIIDFLO, DGKBIEGBPPF EGEPJAHBNCI, HHMJIEMKLLO KCFJFHIBKLG, OPKNKODACNB KHBEOAAPNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x7075C00", Offset = "0x7074200", VA = "0x187075C00", Slot = "6")]
	protected override string KFHMFENAKOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x7075AE0", Offset = "0x70740E0", VA = "0x187075AE0", Slot = "7")]
	[AsyncStateMachine(typeof(DBKBPEPMAGF))]
	protected override Task BPNHCCABIHI(CHNELKEAFEA KIPAKJOBEFI, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
internal abstract class EMCBHBKNJFL : GONGLEACLPC
{
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	public delegate Task FJDOEGDFGDG(NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private sealed class LBEIPHNNHLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public EMCBHBKNJFL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public LBEIPHNNHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x707C080", Offset = "0x707A680", VA = "0x18707C080")]
		internal Task COBHHDIACNM(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class AJHOHDKBCDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public LBEIPHNNHLK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public AJHOHDKBCDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x706AC20", Offset = "0x7069220", VA = "0x18706AC20")]
		internal object PPFOIHMMPNF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct IINHMHAFIJN : IAsyncStateMachine
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
		public EMCBHBKNJFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public Func<EMCBHBKNJFL, NEGKJPNCLPM<string>.GBKOFALFHEN, CHNELKEAFEA> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private LBEIPHNNHLK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private CHNELKEAFEA <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private TaskAwaiter<JFFNGMFLFPF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x7077EB0", Offset = "0x70764B0", VA = "0x187077EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x7078FB0", Offset = "0x70775B0", VA = "0x187078FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct JJBOPANGFNP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7079E60", Offset = "0x7078460", VA = "0x187079E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x707A8E0", Offset = "0x7078EE0", VA = "0x18707A8E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct LEFKJDDDKCI : IAsyncStateMachine
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
		public EMCBHBKNJFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x707C1B0", Offset = "0x707A7B0", VA = "0x18707C1B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x707C510", Offset = "0x707AB10", VA = "0x18707C510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public readonly Guid CBKPAFEEJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public readonly ByteString FINKMKDBMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public readonly HHMJIEMKLLO KAEMBLCBOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	protected readonly string OCFEBAHNOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	private readonly DGKBIEGBPPF EGEPJAHBNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	private readonly bool BDEKOOAIENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private readonly Queue<FJDOEGDFGDG> HINNBBNGGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	private readonly ILHJBMNMDOK MKNBOCFKEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private readonly NNMIPMOFGJK FKCGACHMIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private bool OGMBBDGKMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public PFFFICEHDFP LHFLNGLFFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public PFFFICEHDFP LAHLIJHFPJD;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public DGKBIEGBPPF KBMEHIINCBK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x8634D0", Offset = "0x861AD0", VA = "0x1808634D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public NLIIDIBLEBA NMJFDBBPKEI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x7072670", Offset = "0x7070C70", VA = "0x187072670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public CFHJOIPDCCN JMGILNODGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x70724F0", Offset = "0x7070AF0", VA = "0x1870724F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public CKDFPPPACKB IMNGEJLDDEB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x70720D0", Offset = "0x70706D0", VA = "0x1870720D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event LPKLEONEBEN DAHNPFPABDP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x70720B0", Offset = "0x70706B0", VA = "0x1870720B0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x7072090", Offset = "0x7070690", VA = "0x187072090", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x7072890", Offset = "0x7070E90", VA = "0x187072890")]
	protected EMCBHBKNJFL(Guid MKCPOIIDFLO, DGKBIEGBPPF EGEPJAHBNCI, HHMJIEMKLLO KCFJFHIBKLG, string DABFDLJMNLN, NNMIPMOFGJK FKCGACHMIMJ, bool BDEKOOAIENN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x7072540", Offset = "0x7070B40", VA = "0x187072540", Slot = "6")]
	protected virtual string KFHMFENAKOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x7072830", Offset = "0x7070E30", VA = "0x187072830")]
	public void PMOCMMPBPAL(FJDOEGDFGDG NNKIBJPHKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x7072810", Offset = "0x7070E10", VA = "0x187072810")]
	protected void PFIEBINNEPG(float DCGDLJBAKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x70726C0", Offset = "0x7070CC0", VA = "0x1870726C0")]
	[AsyncStateMachine(typeof(IINHMHAFIJN))]
	public Task NGPKEBHLPHO(CancellationToken NNGMAHIDECE, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, [Optional] Func<EMCBHBKNJFL, NEGKJPNCLPM<string>.GBKOFALFHEN, CHNELKEAFEA> NCBJBKJEHAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x7071F60", Offset = "0x7070560", VA = "0x187071F60")]
	[AsyncStateMachine(typeof(JJBOPANGFNP))]
	private static Task ENLPCBPJDHB(Func<CancellationToken, Task> AKJLIDMDFKP, Func<CancellationToken, Task> MPOFGDBBDPE, CancellationToken MEHJFMOAFKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x7072150", Offset = "0x7070750", VA = "0x187072150")]
	private void FICOCBGLLFI(bool GCPCBKFMNEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x70722C0", Offset = "0x70708C0", VA = "0x1870722C0")]
	private void GDFHGDPIMPN(CHNELKEAFEA KIPAKJOBEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task BPNHCCABIHI(CHNELKEAFEA KIPAKJOBEFI, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x70723D0", Offset = "0x70709D0", VA = "0x1870723D0")]
	[AsyncStateMachine(typeof(LEFKJDDDKCI))]
	private Task GMNKCIAFCCF(NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x7071EE0", Offset = "0x70704E0", VA = "0x187071EE0")]
	public JFFNGMFLFPF CDIICIPINMB(OBHAMMOLPMK AGHNKOEMDMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x7072580", Offset = "0x7070B80", VA = "0x187072580")]
	[CompilerGenerated]
	private Task MFAFGJHFHJC(CancellationToken GJMDIBEDCBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x7071E60", Offset = "0x7070460", VA = "0x187071E60")]
	[CompilerGenerated]
	private object ACNFFFCBHBH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
internal sealed class MANJLOAOAIG : JKCAKDKHOKM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct BLDJEGCEHDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public MANJLOAOAIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public CHNELKEAFEA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private CAEPJJKBGAM <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private DGGOKOIKOMP <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x706BFF0", Offset = "0x706A5F0", VA = "0x18706BFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x706C760", Offset = "0x706AD60", VA = "0x18706C760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	private readonly LDJGBBGIHDL DKLBNMEHLGI;

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x707CDB0", Offset = "0x707B3B0", VA = "0x18707CDB0")]
	public MANJLOAOAIG(Guid MKCPOIIDFLO, DGKBIEGBPPF EGEPJAHBNCI, LDJGBBGIHDL DKLBNMEHLGI, HHMJIEMKLLO KCFJFHIBKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x707CC60", Offset = "0x707B260", VA = "0x18707CC60", Slot = "8")]
	[AsyncStateMachine(typeof(BLDJEGCEHDB))]
	protected override Task CHAJOIIFAEA(CHNELKEAFEA KIPAKJOBEFI, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
internal class BLLIDKAOMKE : EMCBHBKNJFL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private struct LAAENNBPDJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public BLLIDKAOMKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public CHNELKEAFEA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private TaskAwaiter<CAKNPLNONPM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x707BC70", Offset = "0x707A270", VA = "0x18707BC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x707C020", Offset = "0x707A620", VA = "0x18707C020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	private readonly string GCPAFBFNOEB;

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x706C8D0", Offset = "0x706AED0", VA = "0x18706C8D0")]
	public BLLIDKAOMKE(Guid MKCPOIIDFLO, DGKBIEGBPPF EGEPJAHBNCI, HHMJIEMKLLO KCFJFHIBKLG, string GCPAFBFNOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x706C7C0", Offset = "0x706ADC0", VA = "0x18706C7C0", Slot = "7")]
	[AsyncStateMachine(typeof(LAAENNBPDJK))]
	protected override Task BPNHCCABIHI(CHNELKEAFEA KIPAKJOBEFI, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
internal class FLIAACODPBP : JKCAKDKHOKM
{
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private sealed class MMPLLGCPGIC
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
			public AsyncTaskMethodBuilder<JFFNGMFLFPF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			public MMPLLGCPGIC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			private TaskAwaiter<CAKNPLNONPM> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400041B")]
			private TaskAwaiter<JFFNGMFLFPF> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0x7082780", Offset = "0x7080D80", VA = "0x187082780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x7082C40", Offset = "0x7081240", VA = "0x187082C40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public FLIAACODPBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public LHEJNEPONLB serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public AJMJLMGBAMP roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public IABIBLPEMDN uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public GFELCKADMED roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public MMPLLGCPGIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x707D890", Offset = "0x707BE90", VA = "0x18707D890")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<JFFNGMFLFPF> PJGBEMMKPNH(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct OOHADIAGILL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public FLIAACODPBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public CHNELKEAFEA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private MMPLLGCPGIC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private CAEPJJKBGAM <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private DGGOKOIKOMP <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private JFFNGMFLFPF <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private TaskAwaiter<JFFNGMFLFPF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x707E300", Offset = "0x707C900", VA = "0x18707E300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x707F260", Offset = "0x707D860", VA = "0x18707F260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	private static readonly CHNLCLDOCNE CNCAEGCNGHI;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	private static readonly CHNLCLDOCNE NDGBKLCCDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private readonly int GENJLEKEJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	[CanBeNull]
	private readonly BMGKDPAHECJ DIKOOGMNLMJ;

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x7074CB0", Offset = "0x70732B0", VA = "0x187074CB0")]
	public FLIAACODPBP(Guid MKCPOIIDFLO, DGKBIEGBPPF EGEPJAHBNCI, int GENJLEKEJPN, BMGKDPAHECJ DIKOOGMNLMJ, HHMJIEMKLLO KCFJFHIBKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x70747F0", Offset = "0x7072DF0", VA = "0x1870747F0", Slot = "8")]
	[AsyncStateMachine(typeof(OOHADIAGILL))]
	protected override Task CHAJOIIFAEA(CHNELKEAFEA KIPAKJOBEFI, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x7074930", Offset = "0x7072F30", VA = "0x187074930")]
	private void LFBKOOLBKJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x7074A30", Offset = "0x7073030", VA = "0x187074A30")]
	private void PDFJLEMLIGG(NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CAEPJJKBGAM JOJBNKNAMMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal abstract class NFOKFKPKDGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public readonly EMCBHBKNJFL PHKACIKJNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public readonly CHNELKEAFEA HIBJLJGKOCK;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public NLIIDIBLEBA NMJFDBBPKEI
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x707DD60", Offset = "0x707C360", VA = "0x18707DD60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public CKDFPPPACKB IMNGEJLDDEB
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x707DCD0", Offset = "0x707C2D0", VA = "0x18707DCD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x707DDB0", Offset = "0x707C3B0", VA = "0x18707DDB0")]
	protected NFOKFKPKDGA(CHNELKEAFEA KIPAKJOBEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x707DCB0", Offset = "0x707C2B0", VA = "0x18707DCB0")]
	protected void FFHOJNCMEGD(string EFHFMIHNEPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal struct BPKAHJLHFBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public Dictionary<Guid, List<NMMHOEIHALH>> BDBPECAHHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public Dictionary<Guid, List<NMMHOEIHALH>> JPAJFCGJFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public Dictionary<Guid, List<NMMHOEIHALH>> ELKKCCNMKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public List<Guid> LPPGMGGEFMC;

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x706D900", Offset = "0x706BF00", VA = "0x18706D900")]
	public static BPKAHJLHFBH BJJBEHDKBAF(NLIIDIBLEBA FGMBCEGOCBB, PFFFICEHDFP MJGICMCPBGC, BOLFHPPCKNE JIPLNCJJEGF)
	{
		return default(BPKAHJLHFBH);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011D")]
internal struct NMCCEHAPCGC
{
	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190")]
	public static NMCCEHAPCGC KKJEMJBKDLP()
	{
		return default(NMCCEHAPCGC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal struct NNOLABFBOHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public readonly EKOKDGMBHGJ OEAIHDKDLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public readonly DCPEFLIKEJN ELLAEHCEEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public readonly string EGPKGHKFCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public readonly LDJPCHCCHLD OFJHEAGKPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public readonly LDJPCHCCHLD NJMMPFKJOJO;

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x707DE10", Offset = "0x707C410", VA = "0x18707DE10")]
	public NNOLABFBOHH(EKOKDGMBHGJ OEAIHDKDLGD, DCPEFLIKEJN ELLAEHCEEJF, string EGPKGHKFCDG, LDJPCHCCHLD OFJHEAGKPLP, LDJPCHCCHLD NJMMPFKJOJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal struct PLOEFCDLIPB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	private readonly CHNELKEAFEA KIPAKJOBEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	private readonly Guid GBHCOKFFHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	private bool GCPCBKFMNEC;

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x7080A10", Offset = "0x707F010", VA = "0x187080A10")]
	public static PLOEFCDLIPB BHOIJHKCIDL(CHNELKEAFEA KIPAKJOBEFI)
	{
		return default(PLOEFCDLIPB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0xA95F90", Offset = "0xA94590", VA = "0x180A95F90")]
	public void JKMNPCLCFFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x7080A70", Offset = "0x707F070", VA = "0x187080A70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x7080B70", Offset = "0x707F170", VA = "0x187080B70")]
	private PLOEFCDLIPB(CHNELKEAFEA KIPAKJOBEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x7080A70", Offset = "0x707F070", VA = "0x187080A70")]
	private void KDGAPCHIDEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x7080AD0", Offset = "0x707F0D0", VA = "0x187080AD0")]
	private Func<Guid, bool> NAOKKIDHCDJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal class DGGOKOIKOMP : NFOKFKPKDGA, GONGLEACLPC
{
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	public delegate Task<PFFFICEHDFP> EAIHIHDBEIK(BOLFHPPCKNE JHLEMCFOEMF, BOBEMLEAPBK KIOFCGFKICC, ILHJBMNMDOK JOENJHHKMGC, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private struct KKEBBMBCBKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public DGGOKOIKOMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public LDJGBBGIHDL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private PLOEFCDLIPB <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private TaskAwaiter<JFFNGMFLFPF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x707B4A0", Offset = "0x7079AA0", VA = "0x18707B4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x707BC10", Offset = "0x707A210", VA = "0x18707BC10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct LFFPMLAAHCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public AsyncTaskMethodBuilder<JFFNGMFLFPF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public DGGOKOIKOMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public LDJGBBGIHDL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private TaskAwaiter<JFFNGMFLFPF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x707C570", Offset = "0x707AB70", VA = "0x18707C570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x707C980", Offset = "0x707AF80", VA = "0x18707C980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct IPHMCCGAICC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public DGGOKOIKOMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public LDJGBBGIHDL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x7079010", Offset = "0x7077610", VA = "0x187079010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x70794A0", Offset = "0x7077AA0", VA = "0x1870794A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private sealed class IAHMJPONDOP
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
			public AsyncTaskMethodBuilder<NNOLABFBOHH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			public IAHMJPONDOP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			private NNOLABFBOHH <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			private TaskAwaiter<PFFFICEHDFP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			private TaskAwaiter<NNOLABFBOHH> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x7081240", Offset = "0x707F840", VA = "0x187081240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0x70819D0", Offset = "0x707FFD0", VA = "0x1870819D0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<BOLFHPPCKNE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			public IAHMJPONDOP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			private BOLFHPPCKNE <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			private TaskAwaiter<PFFFICEHDFP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			private TaskAwaiter<BOLFHPPCKNE> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000516")]
			[Cpp2IlInjected.Address(RVA = "0x7081A40", Offset = "0x7080040", VA = "0x187081A40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0x7082090", Offset = "0x7080690", VA = "0x187082090", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public DGGOKOIKOMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public LDJGBBGIHDL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public ILHJBMNMDOK preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public ILHJBMNMDOK downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public NNOLABFBOHH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public ILHJBMNMDOK postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public BOLFHPPCKNE phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public EGKEBLFCBLB.JCEOEHMGDOP <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public IAHMJPONDOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x7077120", Offset = "0x7075720", VA = "0x187077120")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<NNOLABFBOHH> KKNMPFNPIKI(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x7077260", Offset = "0x7075860", VA = "0x187077260")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<BOLFHPPCKNE> MILFNANCNHJ(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x70770E0", Offset = "0x70756E0", VA = "0x1870770E0")]
		internal void GEEHGKKLBPD(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x7076F80", Offset = "0x7075580", VA = "0x187076F80")]
		internal Task EMDNDFNPKBH(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x7077380", Offset = "0x7075980", VA = "0x187077380")]
		internal Task MPEEPFGKPEJ(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct GNCALGJMPLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public DGGOKOIKOMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public LDJGBBGIHDL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private IAHMJPONDOP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private TaskAwaiter<NNOLABFBOHH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private TaskAwaiter<BOLFHPPCKNE> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x7074D60", Offset = "0x7073360", VA = "0x187074D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x7075A80", Offset = "0x7074080", VA = "0x187075A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct HNENLEDDHHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public DGGOKOIKOMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public BOLFHPPCKNE phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public ILHJBMNMDOK postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private TaskAwaiter<PFFFICEHDFP> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private BOBEMLEAPBK <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x7076000", Offset = "0x7074600", VA = "0x187076000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x7076F20", Offset = "0x7075520", VA = "0x187076F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct ENBJKLIJHPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public DGGOKOIKOMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x70729F0", Offset = "0x7070FF0", VA = "0x1870729F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x70732A0", Offset = "0x70718A0", VA = "0x1870732A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct PEGFCPLLDCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public DGGOKOIKOMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public BOLFHPPCKNE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public ILHJBMNMDOK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		private TaskAwaiter<PFFFICEHDFP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x707FA40", Offset = "0x707E040", VA = "0x18707FA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x70803C0", Offset = "0x707E9C0", VA = "0x1870803C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct EEPMJPNLBGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public AsyncTaskMethodBuilder<PFFFICEHDFP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public DGGOKOIKOMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public BOLFHPPCKNE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public ILHJBMNMDOK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private TaskAwaiter<PFFFICEHDFP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x7070E20", Offset = "0x706F420", VA = "0x187070E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x7071DF0", Offset = "0x70703F0", VA = "0x187071DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct BCLJMEPNAJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public AsyncTaskMethodBuilder<PFFFICEHDFP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public DGGOKOIKOMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public BOLFHPPCKNE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public ILHJBMNMDOK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public BOBEMLEAPBK timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private TaskAwaiter<PFFFICEHDFP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x706AE30", Offset = "0x7069430", VA = "0x18706AE30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x706BF20", Offset = "0x706A520", VA = "0x18706BF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct NDMLFOAKNII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public AsyncTaskMethodBuilder<PFFFICEHDFP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public DGGOKOIKOMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public PFFFICEHDFP operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public ILHJBMNMDOK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public BOLFHPPCKNE deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private TaskAwaiter<PFFFICEHDFP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x707D9B0", Offset = "0x707BFB0", VA = "0x18707D9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x707DC40", Offset = "0x707C240", VA = "0x18707DC40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private sealed class MBCPEHFMJLM
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
			public AsyncTaskMethodBuilder<PFFFICEHDFP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004C0")]
			public MBCPEHFMJLM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004C1")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C2")]
			private ILDHCOMNJFF <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004C3")]
			private TaskAwaiter<PFFFICEHDFP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600052E")]
			[Cpp2IlInjected.Address(RVA = "0x7082100", Offset = "0x7080700", VA = "0x187082100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0x7082710", Offset = "0x7080D10", VA = "0x187082710", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public DGGOKOIKOMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public BOLFHPPCKNE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public ILHJBMNMDOK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public EAIHIHDBEIK masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public BOBEMLEAPBK timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public PFFFICEHDFP originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public MBCPEHFMJLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x707CE60", Offset = "0x707B460", VA = "0x18707CE60")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<PFFFICEHDFP> FJLHPHGIAKK(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private struct KBMHDIIFEIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public AsyncTaskMethodBuilder<PFFFICEHDFP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public DGGOKOIKOMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public BOLFHPPCKNE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public ILHJBMNMDOK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public EAIHIHDBEIK masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public BOBEMLEAPBK timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		private ILDHCOMNJFF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private TaskAwaiter<PFFFICEHDFP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x707AC10", Offset = "0x7079210", VA = "0x18707AC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x707B110", Offset = "0x7079710", VA = "0x18707B110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct MIDPJDCOAKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public DGGOKOIKOMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public BOLFHPPCKNE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public ILHJBMNMDOK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private PFFFICEHDFP <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private IEnumerator<PFFFICEHDFP> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private TaskAwaiter<PFFFICEHDFP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x707D310", Offset = "0x707B910", VA = "0x18707D310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x707D830", Offset = "0x707BE30", VA = "0x18707D830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private struct HEAMMKBBOFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public DGGOKOIKOMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public BOLFHPPCKNE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

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
		[Cpp2IlInjected.Address(RVA = "0x7075D80", Offset = "0x7074380", VA = "0x187075D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x7075FA0", Offset = "0x70745A0", VA = "0x187075FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct LNIIKLGENPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public DGGOKOIKOMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public BOLFHPPCKNE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x707CA60", Offset = "0x707B060", VA = "0x18707CA60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x707CC00", Offset = "0x707B200", VA = "0x18707CC00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private struct BMPIJOFMHEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public DGGOKOIKOMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public BOLFHPPCKNE phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public ILHJBMNMDOK postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private TaskAwaiter<PFFFICEHDFP> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private BOBEMLEAPBK <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x706C980", Offset = "0x706AF80", VA = "0x18706C980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x706D8A0", Offset = "0x706BEA0", VA = "0x18706D8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct FGECBAHHJHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public AsyncTaskMethodBuilder<PFFFICEHDFP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public DGGOKOIKOMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public BOLFHPPCKNE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public ILHJBMNMDOK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		private TaskAwaiter<PFFFICEHDFP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x7073300", Offset = "0x7071900", VA = "0x187073300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x7073E30", Offset = "0x7072430", VA = "0x187073E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private readonly MAOIFBOIJHO CFLKADPFJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private readonly MAOIFBOIJHO LMMICMPNIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private readonly ICAOLNNEGIC CFPMIOIGHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	private readonly IEFDDCAAOKJ BGNDOPFLBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	private readonly JNPKPHILOKO KBIEPDKEOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private readonly ACFLDMOCEIL NDIIIAFGNDD;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private DGKBIEGBPPF KBMEHIINCBK
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x7070460", Offset = "0x706EA60", VA = "0x187070460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event LPKLEONEBEN DAHNPFPABDP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x706F8F0", Offset = "0x706DEF0", VA = "0x18706F8F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x706F8D0", Offset = "0x706DED0", VA = "0x18706F8D0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x7070730", Offset = "0x706ED30", VA = "0x187070730")]
	public DGGOKOIKOMP(CHNELKEAFEA KIPAKJOBEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x7070310", Offset = "0x706E910", VA = "0x187070310")]
	[AsyncStateMachine(typeof(KKEBBMBCBKI))]
	public Task PANGAMGFGLO(LDJGBBGIHDL FALAJMPCHDK, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x706EEE0", Offset = "0x706D4E0", VA = "0x18706EEE0")]
	[AsyncStateMachine(typeof(LFFPMLAAHCM))]
	private Task<JFFNGMFLFPF> AOFEHFPEGHM(LDJGBBGIHDL FALAJMPCHDK, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x706F1C0", Offset = "0x706D7C0", VA = "0x18706F1C0")]
	[AsyncStateMachine(typeof(IPHMCCGAICC))]
	private Task BHHGPHEINNM(LDJGBBGIHDL FALAJMPCHDK, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x706FA00", Offset = "0x706E000", VA = "0x18706FA00")]
	[AsyncStateMachine(typeof(GNCALGJMPLD))]
	private Task IAGHFKHHNFF(LDJGBBGIHDL FALAJMPCHDK, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken EFDNBFICLGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x706F300", Offset = "0x706D900", VA = "0x18706F300")]
	[AsyncStateMachine(typeof(HNENLEDDHHB))]
	private Task BNPLMGMKMAH(BOLFHPPCKNE ABFAPGHGKGK, ILHJBMNMDOK DOMJOCEBIPB, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken KOJDMKINMPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x706F630", Offset = "0x706DC30", VA = "0x18706F630")]
	[AsyncStateMachine(typeof(ENBJKLIJHPI))]
	private Task EHIDBDCEHHA(NEGKJPNCLPM<string>.GBKOFALFHEN CIAFJLABOOB, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x706FFD0", Offset = "0x706E5D0", VA = "0x18706FFD0")]
	[AsyncStateMachine(typeof(PEGFCPLLDCC))]
	private Task NKOLAANBIKH(BOLFHPPCKNE JHLEMCFOEMF, ILHJBMNMDOK JOENJHHKMGC, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x706F060", Offset = "0x706D660", VA = "0x18706F060")]
	[AsyncStateMachine(typeof(EEPMJPNLBGP))]
	private Task<PFFFICEHDFP> BAPJKOIEPPI(BOLFHPPCKNE JHLEMCFOEMF, BOBEMLEAPBK GCPAGIIPLHJ, ILHJBMNMDOK JOENJHHKMGC, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x7070140", Offset = "0x706E740", VA = "0x187070140")]
	[AsyncStateMachine(typeof(BCLJMEPNAJL))]
	private Task<PFFFICEHDFP> OCFDFCJBNAN(BOLFHPPCKNE JHLEMCFOEMF, BOBEMLEAPBK GCPAGIIPLHJ, ILHJBMNMDOK JOENJHHKMGC, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x706FB80", Offset = "0x706E180", VA = "0x18706FB80")]
	[AsyncStateMachine(typeof(NDMLFOAKNII))]
	private Task<PFFFICEHDFP> IIGGGLKHMFA(PFFFICEHDFP MJGICMCPBGC, BOLFHPPCKNE JIPLNCJJEGF, ILHJBMNMDOK JOENJHHKMGC, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE, bool MNPEDEGBBMH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x706F910", Offset = "0x706DF10", VA = "0x18706F910")]
	private bool HIIDEKGLCEN(BOLFHPPCKNE ABFAPGHGKGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x706F740", Offset = "0x706DD40", VA = "0x18706F740")]
	[AsyncStateMachine(typeof(KBMHDIIFEIA))]
	protected Task<PFFFICEHDFP> EHJHOFFBHJO(BOLFHPPCKNE JHLEMCFOEMF, BOBEMLEAPBK GCPAGIIPLHJ, ILHJBMNMDOK JOENJHHKMGC, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE, EAIHIHDBEIK NDJGLGILLKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x70705E0", Offset = "0x706EBE0", VA = "0x1870705E0")]
	[AsyncStateMachine(typeof(MIDPJDCOAKB))]
	private Task PMFBKKINFIC(BOLFHPPCKNE JHLEMCFOEMF, ILHJBMNMDOK JOENJHHKMGC, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x706EE90", Offset = "0x706D490", VA = "0x18706EE90")]
	private void AMGNCJNEEMG(PFFFICEHDFP MDLHFBOENEI, ILHJBMNMDOK JOENJHHKMGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x706FD40", Offset = "0x706E340", VA = "0x18706FD40")]
	private void KLGFKHANIMJ(PFFFICEHDFP KBJKNFINEKM, [Out] PFFFICEHDFP LIKIBDNHNGJ, [Out] PFFFICEHDFP GFCOOCJIELJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x706F450", Offset = "0x706DA50", VA = "0x18706F450")]
	private Task<NNOLABFBOHH> DAJDPMAFKIF(LDJGBBGIHDL FALAJMPCHDK, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x70702C0", Offset = "0x706E8C0", VA = "0x1870702C0")]
	private Task<BOLFHPPCKNE> ONBJCLGJCFC(NNOLABFBOHH JHLEMCFOEMF, EGKEBLFCBLB.JCEOEHMGDOP ADDCOKJPJDA, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x7070490", Offset = "0x706EA90", VA = "0x187070490")]
	[AsyncStateMachine(typeof(HEAMMKBBOFA))]
	private Task PJAIIEEFPAP(BOLFHPPCKNE JHLEMCFOEMF, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE, bool ELMLAMPGENC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x706FD80", Offset = "0x706E380", VA = "0x18706FD80")]
	[AsyncStateMachine(typeof(LNIIKLGENPD))]
	private Task NEOMNGIHKIF(BOLFHPPCKNE JHLEMCFOEMF, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x706EE60", Offset = "0x706D460", VA = "0x18706EE60")]
	private Task AAKOHPEOPOI(BOLFHPPCKNE JHLEMCFOEMF, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x7070120", Offset = "0x706E720", VA = "0x187070120")]
	private Task OALAKDLDBGM(BOLFHPPCKNE JHLEMCFOEMF, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x706FD20", Offset = "0x706E320", VA = "0x18706FD20")]
	private Task JPINIPBPHNF(BOLFHPPCKNE JHLEMCFOEMF, BOBEMLEAPBK GCPAGIIPLHJ, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x706FD00", Offset = "0x706E300", VA = "0x18706FD00")]
	private Task JLNKMMEKEGD(BOLFHPPCKNE JHLEMCFOEMF, BOBEMLEAPBK GCPAGIIPLHJ, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x7070300", Offset = "0x706E900", VA = "0x187070300")]
	private static Task OOELOPCOKFA(CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x706FB40", Offset = "0x706E140", VA = "0x18706FB40")]
	private Task IDACCHNCMFG(BOLFHPPCKNE JHLEMCFOEMF, BOBEMLEAPBK GCPAGIIPLHJ, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x706F040", Offset = "0x706D640", VA = "0x18706F040")]
	private Task BAPJIKCNJAE(BOLFHPPCKNE JHLEMCFOEMF, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x706F5E0", Offset = "0x706DBE0", VA = "0x18706F5E0")]
	private void EBDOCPACKOE(LDJGBBGIHDL FALAJMPCHDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x706FB60", Offset = "0x706E160", VA = "0x18706FB60")]
	public void IGJENKKFKKE(long POCGMPECBEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
	private static void HIFOFFLLBHM(EKOKDGMBHGJ OEAIHDKDLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x706F490", Offset = "0x706DA90", VA = "0x18706F490")]
	[AsyncStateMachine(typeof(BMPIJOFMHEN))]
	private Task DCKGKIDIDOM(BOLFHPPCKNE ABFAPGHGKGK, ILHJBMNMDOK DOMJOCEBIPB, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken KOJDMKINMPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x706FE70", Offset = "0x706E470", VA = "0x18706FE70")]
	[AsyncStateMachine(typeof(FGECBAHHJHD))]
	[CompilerGenerated]
	private Task<PFFFICEHDFP> NIEJLOIOEDL(BOLFHPPCKNE JHLEMCFOEMF, BOBEMLEAPBK GCPAGIIPLHJ, ILHJBMNMDOK JOENJHHKMGC, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal struct HJNKIEMIHFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private DGKBIEGBPPF EGEPJAHBNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private BOLFHPPCKNE JHLEMCFOEMF;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private NLIIDIBLEBA NMJFDBBPKEI
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x708CA30", Offset = "0x708B030", VA = "0x18708CA30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x708CA80", Offset = "0x708B080", VA = "0x18708CA80")]
	public static Task NGPKEBHLPHO(DGKBIEGBPPF EGEPJAHBNCI, BOLFHPPCKNE JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x708CB60", Offset = "0x708B160", VA = "0x18708CB60")]
	private void NGPKEBHLPHO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct KJHNMNABCIN
{
	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x7091C90", Offset = "0x7090290", VA = "0x187091C90")]
	public static Task NGPKEBHLPHO(CancellationToken NNGMAHIDECE)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct PENCBMMACMF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private struct GDCACBOGHCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public CHNELKEAFEA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public BOLFHPPCKNE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private ILDHCOMNJFF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x708ABC0", Offset = "0x70891C0", VA = "0x18708ABC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x708B0E0", Offset = "0x70896E0", VA = "0x18708B0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x709AF90", Offset = "0x7099590", VA = "0x18709AF90")]
	[AsyncStateMachine(typeof(GDCACBOGHCA))]
	public static Task NGPKEBHLPHO(CHNELKEAFEA KIPAKJOBEFI, BOLFHPPCKNE JHLEMCFOEMF, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013C")]
internal struct GAHFGHLOGLH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct LFLDDLNFADG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public CHNELKEAFEA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public BOLFHPPCKNE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public BOBEMLEAPBK timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private PFFFICEHDFP <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private DGKBIEGBPPF <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private NLIIDIBLEBA <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private ILDHCOMNJFF <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private List<(PersistenceView, LMPEJKGKMKJ)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private LMPEJKGKMKJ <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x7093D60", Offset = "0x7092360", VA = "0x187093D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x70949D0", Offset = "0x7092FD0", VA = "0x1870949D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x708AA70", Offset = "0x7089070", VA = "0x18708AA70")]
	[AsyncStateMachine(typeof(LFLDDLNFADG))]
	public static Task NGPKEBHLPHO(CHNELKEAFEA KIPAKJOBEFI, BOLFHPPCKNE JHLEMCFOEMF, BOBEMLEAPBK GCPAGIIPLHJ, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x708A880", Offset = "0x7088E80", VA = "0x18708A880")]
	private static void HDFKLOLLDLM(PersistenceView EEOIFKIKDHI, LMPEJKGKMKJ DKPOEEMNGFI, BOLFHPPCKNE JHLEMCFOEMF, PFFFICEHDFP MJGICMCPBGC, bool FOJBFIGCAHK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013F")]
internal struct IHFCKCMBGGC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct FMCOGMHDELB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public DGKBIEGBPPF roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public BOLFHPPCKNE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x7089DC0", Offset = "0x70883C0", VA = "0x187089DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x708A1F0", Offset = "0x70887F0", VA = "0x18708A1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x708EE80", Offset = "0x708D480", VA = "0x18708EE80")]
	[AsyncStateMachine(typeof(FMCOGMHDELB))]
	public static Task NGPKEBHLPHO(DGKBIEGBPPF EGEPJAHBNCI, BOLFHPPCKNE JHLEMCFOEMF, CancellationToken NNGMAHIDECE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
internal struct KBKFOALALLD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct LINLAHFLLEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public DGKBIEGBPPF roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public BOLFHPPCKNE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public CHNELKEAFEA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x7095B60", Offset = "0x7094160", VA = "0x187095B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x7095D70", Offset = "0x7094370", VA = "0x187095D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private sealed class MHDAACGCLHK
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
			public NEGKJPNCLPM<string>.GBKOFALFHEN timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400052F")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			public MHDAACGCLHK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			private NEGKJPNCLPM<string>.GBKOFALFHEN <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000558")]
			[Cpp2IlInjected.Address(RVA = "0x709BC80", Offset = "0x709A280", VA = "0x18709BC80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000559")]
			[Cpp2IlInjected.Address(RVA = "0x709C010", Offset = "0x709A610", VA = "0x18709C010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public MHDAACGCLHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x7096820", Offset = "0x7094E20", VA = "0x187096820")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task MFEKMCBOMGE(NEGKJPNCLPM<string>.GBKOFALFHEN timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct KOOBMEINCPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public KBKFOALALLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private ILDHCOMNJFF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private TaskAwaiter<JFFNGMFLFPF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x7092300", Offset = "0x7090900", VA = "0x187092300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x7092CC0", Offset = "0x70912C0", VA = "0x187092CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private sealed class BHKACLNKIAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public FDIPOBCALOO version;

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
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public BHKACLNKIAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x7086140", Offset = "0x7084740", VA = "0x187086140")]
		internal object NLOOPMKKEDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x7086090", Offset = "0x7084690", VA = "0x187086090")]
		internal object KDBOMEPKJIB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	private DGKBIEGBPPF EGEPJAHBNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	private BOLFHPPCKNE JHLEMCFOEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	private CHNELKEAFEA KIPAKJOBEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private bool ELMLAMPGENC;

	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private static readonly ByteString AAPCNFFPMKA;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private NLIIDIBLEBA NMJFDBBPKEI
	{
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x70912A0", Offset = "0x708F8A0", VA = "0x1870912A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private CKDFPPPACKB IMNGEJLDDEB
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x70911C0", Offset = "0x708F7C0", VA = "0x1870911C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x70912F0", Offset = "0x708F8F0", VA = "0x1870912F0")]
	[AsyncStateMachine(typeof(LINLAHFLLEJ))]
	public static Task NGPKEBHLPHO(DGKBIEGBPPF EGEPJAHBNCI, BOLFHPPCKNE JHLEMCFOEMF, CHNELKEAFEA KIPAKJOBEFI, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE, bool ELMLAMPGENC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x7091440", Offset = "0x708FA40", VA = "0x187091440")]
	[AsyncStateMachine(typeof(KOOBMEINCPP))]
	private Task NGPKEBHLPHO(NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x7091580", Offset = "0x708FB80", VA = "0x187091580")]
	private void NHENLGCLGJD([NotNull] POGNJKLFFHD ICLJKMONAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x7091260", Offset = "0x708F860", VA = "0x187091260")]
	private bool KONCFFLHFJC(FDIPOBCALOO PKICDAADPKG, POGNJKLFFHD ICLJKMONAMK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
internal struct MIEMDNIILIB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct FJNLGKMEGEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public AsyncTaskMethodBuilder<BOLFHPPCKNE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public MIEMDNIILIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public EGKEBLFCBLB.JCEOEHMGDOP downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private ILDHCOMNJFF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private TaskAwaiter<(HHANDHIMCMH<MNBHNPFBECL, EKHHLAEJNGE>, HHANDHIMCMH<CIPNPJKLJID<POGNJKLFFHD>, EKHHLAEJNGE>, HHANDHIMCMH<CIPNPJKLJID<BNHGPMCKPJN>, EKHHLAEJNGE>, HHANDHIMCMH<CIPNPJKLJID<JMMMIGLLOBM>, EKHHLAEJNGE>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x70892A0", Offset = "0x70878A0", VA = "0x1870892A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x7089D50", Offset = "0x7088350", VA = "0x187089D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct DGIGIHPINOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<MNBHNPFBECL, EKHHLAEJNGE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public MIEMDNIILIB <>4__this;

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
		public EGKEBLFCBLB.JCEOEHMGDOP downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		private ILDHCOMNJFF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private TaskAwaiter<HHANDHIMCMH<MNBHNPFBECL, EKHHLAEJNGE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x70882E0", Offset = "0x70868E0", VA = "0x1870882E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x70888F0", Offset = "0x7086EF0", VA = "0x1870888F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	private OAEEJPIMCGF<LDJPCHCCHLD, BNHGPMCKPJN> KCMOMNIMIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	private OAEEJPIMCGF<LDJPCHCCHLD, POGNJKLFFHD> PDBDLONKPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	private OAEEJPIMCGF<long, JMMMIGLLOBM> LODDMPLDLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	private FLPAFHNPOFI AEHHBMGDJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	private EKOKDGMBHGJ OEAIHDKDLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	private DCPEFLIKEJN ELLAEHCEEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	private string EGPKGHKFCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	private LDJPCHCCHLD OFJHEAGKPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	private LDJPCHCCHLD NJMMPFKJOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	private long POCGMPECBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	private NEGKJPNCLPM<string>.GBKOFALFHEN CIAFJLABOOB;

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x7096940", Offset = "0x7094F40", VA = "0x187096940")]
	public static Task<BOLFHPPCKNE> BGIILCFFIJO(DGKBIEGBPPF EGEPJAHBNCI, [In] NNOLABFBOHH JHLEMCFOEMF, EGKEBLFCBLB.JCEOEHMGDOP ADDCOKJPJDA, NEGKJPNCLPM<string>.GBKOFALFHEN CIAFJLABOOB, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x7096E60", Offset = "0x7095460", VA = "0x187096E60")]
	[AsyncStateMachine(typeof(FJNLGKMEGEJ))]
	private Task<BOLFHPPCKNE> NGPKEBHLPHO(EGKEBLFCBLB.JCEOEHMGDOP ADDCOKJPJDA, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x7096CA0", Offset = "0x70952A0", VA = "0x187096CA0")]
	[AsyncStateMachine(typeof(DGIGIHPINOC))]
	private Task<HHANDHIMCMH<MNBHNPFBECL, EKHHLAEJNGE>> LNBEEAGDNHG(string EGPKGHKFCDG, long POCGMPECBEJ, long? ECHGOOGHLEN, long? IMIHMEAMIDO, EGKEBLFCBLB.JCEOEHMGDOP ADDCOKJPJDA, NEGKJPNCLPM<string>.GBKOFALFHEN LNDJFADIOCJ, CancellationToken NNGMAHIDECE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
internal struct INEEMAJLJID
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private struct EMIBKFOJFGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public AsyncTaskMethodBuilder<NNOLABFBOHH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public INEEMAJLJID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private TaskAwaiter<NNOLABFBOHH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x70889A0", Offset = "0x7086FA0", VA = "0x1870889A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x7088DA0", Offset = "0x70873A0", VA = "0x187088DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct ILJIAFBHGKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public AsyncTaskMethodBuilder<NNOLABFBOHH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public INEEMAJLJID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private TaskAwaiter<NNOLABFBOHH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x708EF90", Offset = "0x708D590", VA = "0x18708EF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x708F3C0", Offset = "0x708D9C0", VA = "0x18708F3C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class KHNLINAIJAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public KHNLINAIJAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0xA1AA10", Offset = "0xA19010", VA = "0x180A1AA10")]
		internal bool GCEFJDGOBCN(DCPEFLIKEJN sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct BGNHHKBOJDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public AsyncTaskMethodBuilder<NNOLABFBOHH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public LDJPCHCCHLD superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public NLIIDIBLEBA callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		private KHNLINAIJAF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public NCJGPNIIKEP roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private EKOKDGMBHGJ <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private DCPEFLIKEJN <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private LDJPCHCCHLD <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private LDJPCHCCHLD <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private TaskAwaiter<EKOKDGMBHGJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private TaskAwaiter<HMNDMLKHLEG> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private TaskAwaiter<KOKKKOEPCAE> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x7084EF0", Offset = "0x70834F0", VA = "0x187084EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x7086020", Offset = "0x7084620", VA = "0x187086020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000561")]
	private NLIIDIBLEBA FGMBCEGOCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000562")]
	private ICAOLNNEGIC CFPMIOIGHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000563")]
	private NCJGPNIIKEP MEGFHIOMCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000564")]
	private NEGKJPNCLPM<string>.GBKOFALFHEN CIAFJLABOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	private long ECHGOOGHLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	private long OAOPHNECJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	private long CIDNMNIGDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private string CHJGLFCKEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private LDJPCHCCHLD FJMHDBPOKLE;

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x708F430", Offset = "0x708DA30", VA = "0x18708F430")]
	public static Task<NNOLABFBOHH> BGIILCFFIJO(DGKBIEGBPPF EGEPJAHBNCI, LDJGBBGIHDL FALAJMPCHDK, NEGKJPNCLPM<string>.GBKOFALFHEN CIAFJLABOOB, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x708F9A0", Offset = "0x708DFA0", VA = "0x18708F9A0")]
	[AsyncStateMachine(typeof(EMIBKFOJFGG))]
	private Task<NNOLABFBOHH> NGPKEBHLPHO(CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x708F6A0", Offset = "0x708DCA0", VA = "0x18708F6A0")]
	[AsyncStateMachine(typeof(ILJIAFBHGKI))]
	private Task<NNOLABFBOHH> DAJDPMAFKIF(NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x708F800", Offset = "0x708DE00", VA = "0x18708F800")]
	[AsyncStateMachine(typeof(BGNHHKBOJDD))]
	private static Task<NNOLABFBOHH> DAJDPMAFKIF(NLIIDIBLEBA FGMBCEGOCBB, NCJGPNIIKEP MEGFHIOMCCB, long ECHGOOGHLEN, long OAOPHNECJFF, long CIDNMNIGDJH, string CHJGLFCKEKA, LDJPCHCCHLD FJMHDBPOKLE, CancellationToken NNGMAHIDECE, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x708FAF0", Offset = "0x708E0F0", VA = "0x18708FAF0")]
	private void PNKPMAFNKKB(EKOKDGMBHGJ OEAIHDKDLGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
internal struct FPMMEFFJCMH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct PANIBBIPNGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public FPMMEFFJCMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x709A650", Offset = "0x7098C50", VA = "0x18709A650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x709ABE0", Offset = "0x70991E0", VA = "0x18709ABE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400058C")]
	private NLIIDIBLEBA FGMBCEGOCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400058D")]
	private BOLFHPPCKNE JHLEMCFOEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400058E")]
	private NEGKJPNCLPM<string>.GBKOFALFHEN CIAFJLABOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400058F")]
	private float FJAIGJMOJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000590")]
	private float BMBDJCIJNNI;

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x708A3B0", Offset = "0x70889B0", VA = "0x18708A3B0")]
	public static Task GIECIFDINLM(DGKBIEGBPPF EGEPJAHBNCI, BOLFHPPCKNE JHLEMCFOEMF, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x708A630", Offset = "0x7088C30", VA = "0x18708A630")]
	[AsyncStateMachine(typeof(PANIBBIPNGM))]
	public Task NGPKEBHLPHO(CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x708A750", Offset = "0x7088D50", VA = "0x18708A750")]
	private static void PDPBMCIPJOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x708A250", Offset = "0x7088850", VA = "0x18708A250")]
	private void EPNIJBMIJFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x708A550", Offset = "0x7088B50", VA = "0x18708A550")]
	private static float LKLFCPAIAMA(NLIIDIBLEBA FGMBCEGOCBB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x708A610", Offset = "0x7088C10", VA = "0x18708A610")]
	private static float MHMCCIPJOPP()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000152")]
internal struct HEIEHACEOED
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct OHHABPIEGAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public CHNELKEAFEA operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public BOLFHPPCKNE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private ILDHCOMNJFF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private EMCBHBKNJFL <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private DGKBIEGBPPF <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private MPHCPCJOLJA.PAMDDBHLCIB <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private TaskAwaiter<JFFNGMFLFPF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x70997D0", Offset = "0x7097DD0", VA = "0x1870997D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x7099FE0", Offset = "0x70985E0", VA = "0x187099FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct PBCMEGHEFBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private ILDHCOMNJFF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x709AC40", Offset = "0x7099240", VA = "0x18709AC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x709AF30", Offset = "0x7099530", VA = "0x18709AF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x708C7B0", Offset = "0x708ADB0", VA = "0x18708C7B0")]
	[AsyncStateMachine(typeof(OHHABPIEGAG))]
	public static Task NGPKEBHLPHO(CHNELKEAFEA KIPAKJOBEFI, BOLFHPPCKNE JHLEMCFOEMF, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x708C740", Offset = "0x708AD40", VA = "0x18708C740")]
	private static Task<JFFNGMFLFPF> HLAPFCPINHO(CHNELKEAFEA KIPAKJOBEFI, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x708C680", Offset = "0x708AC80", VA = "0x18708C680")]
	[AsyncStateMachine(typeof(PBCMEGHEFBH))]
	private static Task CGPLEENPMIN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
internal struct JMMNHIBBHJJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct HAEEPFJODAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public JMMNHIBBHJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x708BF70", Offset = "0x708A570", VA = "0x18708BF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x708C620", Offset = "0x708AC20", VA = "0x18708C620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private sealed class AAPPLEJIPKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public AAPPLEJIPKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x7083060", Offset = "0x7081660", VA = "0x187083060")]
		internal object LIIDNPDBLME()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct CFAMCHMADJG : IAsyncStateMachine
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
		public JMMNHIBBHJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private ILDHCOMNJFF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x7086DF0", Offset = "0x70853F0", VA = "0x187086DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x7087250", Offset = "0x7085850", VA = "0x187087250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005AB")]
	private bool MNIBKJAHOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005AC")]
	private NEGKJPNCLPM<string>.GBKOFALFHEN CIAFJLABOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005AD")]
	private DGKBIEGBPPF EGEPJAHBNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005AE")]
	private CancellationToken NNGMAHIDECE;

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x7090CD0", Offset = "0x708F2D0", VA = "0x187090CD0")]
	public static Task KIJIFIBAPNC(DGKBIEGBPPF EGEPJAHBNCI, bool MNIBKJAHOEC, NEGKJPNCLPM<string>.GBKOFALFHEN CIAFJLABOOB, CancellationToken KKHFLHJNGIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x7090D40", Offset = "0x708F340", VA = "0x187090D40")]
	[AsyncStateMachine(typeof(HAEEPFJODAF))]
	private Task NGPKEBHLPHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x7090BA0", Offset = "0x708F1A0", VA = "0x187090BA0")]
	[AsyncStateMachine(typeof(CFAMCHMADJG))]
	private Task FNHGBHCOGIN(bool PONEJMNBEPI, string FHGJMMBJGMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190")]
	private bool LGJGLMAPDIH(bool MNIBKJAHOEC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct CHKAEOKHACH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private struct GMLNILKHNHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public CHKAEOKHACH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x708B990", Offset = "0x7089F90", VA = "0x18708B990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x708BF00", Offset = "0x708A500", VA = "0x18708BF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private sealed class HNKDFCBCMHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public HNKDFCBCMHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x708D7A0", Offset = "0x708BDA0", VA = "0x18708D7A0")]
		internal object LIIDNPDBLME()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private struct LCHDDNEONOI : IAsyncStateMachine
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
		public CHKAEOKHACH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		private ILDHCOMNJFF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x7092D20", Offset = "0x7091320", VA = "0x187092D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x70931A0", Offset = "0x70917A0", VA = "0x1870931A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005BE")]
	private CMPIECDJDIC DJLGFBKDAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005BF")]
	private NEGKJPNCLPM<string>.GBKOFALFHEN CIAFJLABOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C0")]
	private DGKBIEGBPPF EGEPJAHBNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C1")]
	private bool LPNEBDAKDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005C2")]
	private BOLFHPPCKNE JHLEMCFOEMF;

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x70872B0", Offset = "0x70858B0", VA = "0x1870872B0")]
	public static Task<Scene> BNNFJLCAADK(DGKBIEGBPPF EGEPJAHBNCI, CMPIECDJDIC OGCCLJGNIIG, NEGKJPNCLPM<string>.GBKOFALFHEN CIAFJLABOOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x7087520", Offset = "0x7085B20", VA = "0x187087520")]
	[AsyncStateMachine(typeof(GMLNILKHNHE))]
	private Task<Scene> NGPKEBHLPHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x7087330", Offset = "0x7085930", VA = "0x187087330")]
	private bool EAJNJHGKKMB(BOLFHPPCKNE JHLEMCFOEMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x70874B0", Offset = "0x7085AB0", VA = "0x1870874B0")]
	private void NFIJNDOFJJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x7087360", Offset = "0x7085960", VA = "0x187087360")]
	[AsyncStateMachine(typeof(LCHDDNEONOI))]
	private Task<Scene> FNHGBHCOGIN(string FHGJMMBJGMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
internal struct JNPKPHILOKO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct LEIMKMGLJKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public AsyncTaskMethodBuilder<PFFFICEHDFP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public JNPKPHILOKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public PFFFICEHDFP nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public BOLFHPPCKNE deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		private TaskAwaiter<PFFFICEHDFP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x7093210", Offset = "0x7091810", VA = "0x187093210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x7093CF0", Offset = "0x70922F0", VA = "0x187093CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private struct GKKMFEIOODK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public AsyncTaskMethodBuilder<PFFFICEHDFP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public JNPKPHILOKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public PFFFICEHDFP state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		private TaskAwaiter<JFFNGMFLFPF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x708B640", Offset = "0x7089C40", VA = "0x18708B640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x708B920", Offset = "0x7089F20", VA = "0x18708B920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private readonly CHNELKEAFEA KIPAKJOBEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	private readonly ICAOLNNEGIC CFPMIOIGHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	private readonly IEFDDCAAOKJ BGNDOPFLBGP;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private EMCBHBKNJFL PHKACIKJNGF
	{
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x5824870", Offset = "0x5822E70", VA = "0x185824870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x7091160", Offset = "0x708F760", VA = "0x187091160")]
	public JNPKPHILOKO(CHNELKEAFEA KIPAKJOBEFI, ICAOLNNEGIC CFPMIOIGHBC, IEFDDCAAOKJ BGNDOPFLBGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x7090FE0", Offset = "0x708F5E0", VA = "0x187090FE0")]
	[AsyncStateMachine(typeof(LEIMKMGLJKM))]
	public Task<PFFFICEHDFP> GFNENNNDENG(PFFFICEHDFP FKBNNPADMIL, BOLFHPPCKNE JIPLNCJJEGF, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE, bool MNPEDEGBBMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x7090E30", Offset = "0x708F430", VA = "0x187090E30")]
	[AsyncStateMachine(typeof(GKKMFEIOODK))]
	private Task<PFFFICEHDFP> BHFKJEBFOID(NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, PFFFICEHDFP HJBEGIDNCHF, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x7090F90", Offset = "0x708F590", VA = "0x187090F90")]
	private bool DFFPBFKAFBM(PFFFICEHDFP IAGNBBHKGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x7090FC0", Offset = "0x708F5C0", VA = "0x187090FC0")]
	private void FFHOJNCMEGD(string BHFCMGBIGMC)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000160")]
internal struct HHLNMFMKDJN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private struct HMAIACDFMOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public EMCBHBKNJFL operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public BOLFHPPCKNE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public BOBEMLEAPBK timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		private ILDHCOMNJFF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private List<(PersistenceView, LMPEJKGKMKJ)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private (PersistenceView, LMPEJKGKMKJ) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x708D130", Offset = "0x708B730", VA = "0x18708D130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x708D740", Offset = "0x708BD40", VA = "0x18708D740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x708C8F0", Offset = "0x708AEF0", VA = "0x18708C8F0")]
	[AsyncStateMachine(typeof(HMAIACDFMOI))]
	public static Task NGPKEBHLPHO(EMCBHBKNJFL AOBBNFODCCN, BOLFHPPCKNE JHLEMCFOEMF, BOBEMLEAPBK GCPAGIIPLHJ, CancellationToken NNGMAHIDECE)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000162")]
internal struct BGDIKLPIAKE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private struct LNBELOKPGED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public EMCBHBKNJFL operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public BOLFHPPCKNE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public BOBEMLEAPBK timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private FDIPOBCALOO <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private ILDHCOMNJFF <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private List<(PersistenceView, LMPEJKGKMKJ)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private LMPEJKGKMKJ <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x7095DD0", Offset = "0x70943D0", VA = "0x187095DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x7096620", Offset = "0x7094C20", VA = "0x187096620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x7084DB0", Offset = "0x70833B0", VA = "0x187084DB0")]
	[AsyncStateMachine(typeof(LNBELOKPGED))]
	public static Task NGPKEBHLPHO(EMCBHBKNJFL AOBBNFODCCN, BOLFHPPCKNE JHLEMCFOEMF, BOBEMLEAPBK GCPAGIIPLHJ, CancellationToken NNGMAHIDECE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
internal struct MPHCPCJOLJA
{
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	public struct PAMDDBHLCIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public List<HDMHBEBAKGM> HAKGBABOBHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public List<LMPEJKGKMKJ> KFDCLPPGLKJ;

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0xB912D0", Offset = "0xB8F8D0", VA = "0x180B912D0")]
		public PAMDDBHLCIB(List<HDMHBEBAKGM> HAKGBABOBHO, List<LMPEJKGKMKJ> KFDCLPPGLKJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private sealed class NGKJOENBCFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public IEnumerable<HDMHBEBAKGM> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public NGKJOENBCFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x7098200", Offset = "0x7096800", VA = "0x187098200")]
		internal object NEJGEMNJFAD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005FE")]
	private DGKBIEGBPPF EGEPJAHBNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005FF")]
	private BOLFHPPCKNE JHLEMCFOEMF;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private NLIIDIBLEBA NMJFDBBPKEI
	{
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x7097950", Offset = "0x7095F50", VA = "0x187097950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x70981A0", Offset = "0x70967A0", VA = "0x1870981A0")]
	public static PAMDDBHLCIB NGPKEBHLPHO(DGKBIEGBPPF EGEPJAHBNCI, BOLFHPPCKNE JHLEMCFOEMF)
	{
		return default(PAMDDBHLCIB);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x7097F50", Offset = "0x7096550", VA = "0x187097F50")]
	private PAMDDBHLCIB NGPKEBHLPHO()
	{
		return default(PAMDDBHLCIB);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x70979A0", Offset = "0x7095FA0", VA = "0x1870979A0")]
	private PAMDDBHLCIB MHGNKHLOAAO(POGNJKLFFHD ICLJKMONAMK, FDIPOBCALOO NNKBKLLGGLD)
	{
		return default(PAMDDBHLCIB);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x7097780", Offset = "0x7095D80", VA = "0x187097780")]
	private bool FJIPKIPMKPA(IEnumerable<HDMHBEBAKGM> HAKGBABOBHO)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000167")]
internal struct COJMONILEOK
{
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private sealed class MJOOKKBMAJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public MPHCPCJOLJA.PAMDDBHLCIB instantiations;

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public MJOOKKBMAJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x7096FF0", Offset = "0x70955F0", VA = "0x187096FF0")]
		internal object MFEKMCBOMGE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class ODKMIBMGCCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public ODKMIBMGCCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x7099740", Offset = "0x7097D40", VA = "0x187099740")]
		internal object COBHHDIACNM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x7087910", Offset = "0x7085F10", VA = "0x187087910")]
	public static void NGPKEBHLPHO(EMCBHBKNJFL AOBBNFODCCN, BOLFHPPCKNE JHLEMCFOEMF, MPHCPCJOLJA.PAMDDBHLCIB DEHBENNOIGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
internal class IEFDDCAAOKJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private struct NLMAOMKGPPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public IEFDDCAAOKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public PFFFICEHDFP operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public BOLFHPPCKNE deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x7098960", Offset = "0x7096F60", VA = "0x187098960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x70990D0", Offset = "0x70976D0", VA = "0x1870990D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private sealed class OCNFNFODIHG
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
			public OCNFNFODIHG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000617")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000618")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0x709B960", Offset = "0x7099F60", VA = "0x18709B960", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x709BC20", Offset = "0x709A220", VA = "0x18709BC20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public IEFDDCAAOKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public BOLFHPPCKNE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public OCNFNFODIHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x7099650", Offset = "0x7097C50", VA = "0x187099650")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task EOKDIFLDBCF(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private struct KLHLLLCLFGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public IEFDDCAAOKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public BOLFHPPCKNE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		private OCNFNFODIHG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x7091D70", Offset = "0x7090370", VA = "0x187091D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x70922A0", Offset = "0x70908A0", VA = "0x1870922A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct ONGIEBFHPEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public IEFDDCAAOKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public BOLFHPPCKNE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		private Dictionary<Guid, List<NMMHOEIHALH>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x709A040", Offset = "0x7098640", VA = "0x18709A040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x709A5F0", Offset = "0x7098BF0", VA = "0x18709A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct NIJHCEABFMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public IEFDDCAAOKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public BOLFHPPCKNE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		private Dictionary<Guid, List<NMMHOEIHALH>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x7098280", Offset = "0x7096880", VA = "0x187098280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x7098900", Offset = "0x7096F00", VA = "0x187098900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class CHOJMNGJGMN
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
			public NMMHOEIHALH handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400063B")]
			public CHOJMNGJGMN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400063C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(RVA = "0x709B760", Offset = "0x7099D60", VA = "0x18709B760", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0x709B900", Offset = "0x7099F00", VA = "0x18709B900", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public LFBHEPKIOGH runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public List<NMMHOEIHALH> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public BOLFHPPCKNE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public CHOJMNGJGMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x7087640", Offset = "0x7085C40", VA = "0x187087640")]
		internal object AGFNNEMOAHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x7087820", Offset = "0x7085E20", VA = "0x187087820")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task OBOBOCPODCB(NMMHOEIHALH handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x7087730", Offset = "0x7085D30", VA = "0x187087730")]
		internal object BEPNOCBLOHD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private struct OBCOKFCOMED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public LFBHEPKIOGH runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public List<NMMHOEIHALH> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public BOLFHPPCKNE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		private CHOJMNGJGMN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x7099130", Offset = "0x7097730", VA = "0x187099130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x70995F0", Offset = "0x7097BF0", VA = "0x1870995F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private struct JFIGABLKNOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public IEFDDCAAOKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public BOLFHPPCKNE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN timer;

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
		[Cpp2IlInjected.Address(RVA = "0x708FC70", Offset = "0x708E270", VA = "0x18708FC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x7090230", Offset = "0x708E830", VA = "0x187090230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private sealed class ICNKNCEHBGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public ICNKNCEHBGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x708DED0", Offset = "0x708C4D0", VA = "0x18708DED0")]
		internal object HKNAHPAIFLK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private struct APDGILDFLCL : IAsyncStateMachine
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
		public IEFDDCAAOKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public BOLFHPPCKNE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		private ILDHCOMNJFF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x70845A0", Offset = "0x7082BA0", VA = "0x1870845A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x7084A60", Offset = "0x7083060", VA = "0x187084A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private sealed class AAALNHJLMFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public AAALNHJLMFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x7082FF0", Offset = "0x70815F0", VA = "0x187082FF0")]
		internal object MBKMBIPKDHN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct PFFJCPOJOEN : IAsyncStateMachine
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
		public IEFDDCAAOKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		private ILDHCOMNJFF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		private TaskAwaiter<JFFNGMFLFPF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x709B0D0", Offset = "0x70996D0", VA = "0x18709B0D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x709B700", Offset = "0x7099D00", VA = "0x18709B700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class AGMKDJLGKKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public AGMKDJLGKKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x7083B60", Offset = "0x7082160", VA = "0x187083B60")]
		internal object EHJIMCADONN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000606")]
	private readonly CHNELKEAFEA KIPAKJOBEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000607")]
	private BPKAHJLHFBH BGNDOPFLBGP;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private EMCBHBKNJFL PHKACIKJNGF
	{
		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x9B4250", Offset = "0x9B2850", VA = "0x1809B4250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x8682B0", Offset = "0x8668B0", VA = "0x1808682B0")]
	public IEFDDCAAOKJ(CHNELKEAFEA KIPAKJOBEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x708E990", Offset = "0x708CF90", VA = "0x18708E990")]
	[AsyncStateMachine(typeof(NLMAOMKGPPC))]
	public Task NGPKEBHLPHO(PFFFICEHDFP MJGICMCPBGC, BOLFHPPCKNE JIPLNCJJEGF, NEGKJPNCLPM<string>.GBKOFALFHEN CIAFJLABOOB, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x708E270", Offset = "0x708C870", VA = "0x18708E270")]
	[AsyncStateMachine(typeof(KLHLLLCLFGL))]
	private Task FMHCKKKPCHO(BOLFHPPCKNE JHLEMCFOEMF, NEGKJPNCLPM<string>.GBKOFALFHEN CIAFJLABOOB, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x708E3B0", Offset = "0x708C9B0", VA = "0x18708E3B0")]
	[AsyncStateMachine(typeof(ONGIEBFHPEP))]
	private Task GNCLGAKAAKA(BOLFHPPCKNE JHLEMCFOEMF, NEGKJPNCLPM<string>.GBKOFALFHEN CIAFJLABOOB, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x708DFF0", Offset = "0x708C5F0", VA = "0x18708DFF0")]
	[AsyncStateMachine(typeof(NIJHCEABFMC))]
	private Task EOKGILIPNGF(BOLFHPPCKNE JHLEMCFOEMF, NEGKJPNCLPM<string>.GBKOFALFHEN CIAFJLABOOB, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x708EAE0", Offset = "0x708D0E0", VA = "0x18708EAE0")]
	[AsyncStateMachine(typeof(OBCOKFCOMED))]
	private Task NKAAAHEDHOM(Guid INEDDKLIFOE, List<NMMHOEIHALH> EPKILGGDNLG, LFBHEPKIOGH EHOEJAGGLAB, BOLFHPPCKNE JHLEMCFOEMF, CancellationToken PNPIGCGKNPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x708E130", Offset = "0x708C730", VA = "0x18708E130")]
	[AsyncStateMachine(typeof(JFIGABLKNOB))]
	private Task FKBBGGPOIAA(BOLFHPPCKNE JHLEMCFOEMF, NEGKJPNCLPM<string>.GBKOFALFHEN CIAFJLABOOB, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x708ED40", Offset = "0x708D340", VA = "0x18708ED40")]
	[AsyncStateMachine(typeof(APDGILDFLCL))]
	private Task OPPGCNDGFFK(Guid EFNBCEHGCJH, BOLFHPPCKNE JHLEMCFOEMF, NEGKJPNCLPM<string>.GBKOFALFHEN CIAFJLABOOB, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x708E850", Offset = "0x708CE50", VA = "0x18708E850")]
	[AsyncStateMachine(typeof(PFFJCPOJOEN))]
	private Task LOFLBBKMDFC(Guid EFNBCEHGCJH, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x708EC30", Offset = "0x708D230", VA = "0x18708EC30")]
	private void ODADFPKHJGG(Guid EFNBCEHGCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x708DF40", Offset = "0x708C540", VA = "0x18708DF40")]
	private void DPILDMIMJKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x708E4F0", Offset = "0x708CAF0", VA = "0x18708E4F0")]
	public Guid JGNOLILHKBD(PFFFICEHDFP MDLHFBOENEI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x708E680", Offset = "0x708CC80", VA = "0x18708E680")]
	[CompilerGenerated]
	private object LJDFLHGPFAA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
internal struct AJGBLDNKHJP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private struct AGNBDKLHBLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		public AJGBLDNKHJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private IEnumerator<BBGLIDIDMGK> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x7083BD0", Offset = "0x70821D0", VA = "0x187083BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x70842B0", Offset = "0x70828B0", VA = "0x1870842B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000664")]
	private NLIIDIBLEBA FGMBCEGOCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000665")]
	private NEGKJPNCLPM<string>.GBKOFALFHEN CIAFJLABOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000666")]
	private CancellationToken NNGMAHIDECE;

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x7084530", Offset = "0x7082B30", VA = "0x187084530")]
	public static Task OKMBMOCICAD(NLIIDIBLEBA FGMBCEGOCBB, NEGKJPNCLPM<string>.GBKOFALFHEN CIAFJLABOOB, CancellationToken KKHFLHJNGIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x7084440", Offset = "0x7082A40", VA = "0x187084440")]
	[AsyncStateMachine(typeof(AGNBDKLHBLD))]
	private Task NGPKEBHLPHO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
public readonly struct GFELCKADMED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066D")]
	public readonly bool FIMPIBAANCN;

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x21A1BB0", Offset = "0x21A01B0", VA = "0x1821A1BB0")]
	public GFELCKADMED(bool JHKBNDALJAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
public readonly struct CAKNPLNONPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	public readonly POGNJKLFFHD? OIHDGPIJFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400066F")]
	public readonly INHBEBODAPG OAPHKELFIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000670")]
	public readonly string? JBDOCHAPBFC;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public IReadOnlyCollection<string> AOOGCNAPKMB
	{
		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x7086CB0", Offset = "0x70852B0", VA = "0x187086CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public IReadOnlyDictionary<long, int> FDIEJENHCKK
	{
		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x7086CD0", Offset = "0x70852D0", VA = "0x187086CD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x7086CF0", Offset = "0x70852F0", VA = "0x187086CF0")]
	public CAKNPLNONPM(POGNJKLFFHD? BMLBCLGKFJE, INHBEBODAPG OGEJJGKCBMA, string? EGPKGHKFCDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
internal class LHEJNEPONLB : NFOKFKPKDGA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct MLAHOPAEBJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public AsyncTaskMethodBuilder<CAKNPLNONPM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public LHEJNEPONLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public ALIKKKIHOKB serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public AJMJLMGBAMP roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		private ILDHCOMNJFF <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x70970A0", Offset = "0x70956A0", VA = "0x1870970A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x7097710", Offset = "0x7095D10", VA = "0x187097710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private sealed class BCECCFNLMNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public ALIKKKIHOKB serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		public LHEJNEPONLB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public BCECCFNLMNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x7084BA0", Offset = "0x70831A0", VA = "0x187084BA0")]
		internal Task GPPHOOBPEBD(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x7084AC0", Offset = "0x70830C0", VA = "0x187084AC0")]
		internal Task DNDFLBIBADB(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private sealed class GEJNIHBMHML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public BCECCFNLMNF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public GEJNIHBMHML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x708B140", Offset = "0x7089740", VA = "0x18708B140")]
		internal object IHGGENJPKCF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class DMCMENFMADF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public BCECCFNLMNF CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public DMCMENFMADF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x7088960", Offset = "0x7086F60", VA = "0x187088960")]
		internal Task LFPONGOAJIH(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private struct BLPGOALDBIL : IAsyncStateMachine
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
		public ALIKKKIHOKB serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		public LHEJNEPONLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		private GEJNIHBMHML <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		private ILDHCOMNJFF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x7086220", Offset = "0x7084820", VA = "0x187086220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x7086A80", Offset = "0x7085080", VA = "0x187086A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	private readonly CHNLCLDOCNE CNCAEGCNGHI;

	[Cpp2IlInjected.Token(Token = "0x4000672")]
	private static readonly TimeSpan JMAMINHCICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000673")]
	private readonly AHEHGOGPCGO BJHHMGAOJGH;

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x7095B10", Offset = "0x7094110", VA = "0x187095B10")]
	public LHEJNEPONLB(CHNELKEAFEA KIPAKJOBEFI, AHEHGOGPCGO BJHHMGAOJGH, CHNLCLDOCNE CNCAEGCNGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0x7094A30", Offset = "0x7093030", VA = "0x187094A30")]
	[AsyncStateMachine(typeof(MLAHOPAEBJE))]
	public Task<CAKNPLNONPM> ALGEABNCNAB(long OAOPHNECJFF, AJMJLMGBAMP ONKAHOPPDIC, ALIKKKIHOKB EBOLFKEGOIA, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x7095270", Offset = "0x7093870", VA = "0x187095270")]
	[AsyncStateMachine(typeof(BLPGOALDBIL))]
	private Task FGILECANBHJ(ALIKKKIHOKB EBOLFKEGOIA, IEnumerable<PersistenceView> JGJFIICGGKO, StringBuilder FGAINDDLOHH, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x7095500", Offset = "0x7093B00", VA = "0x187095500")]
	private CAKNPLNONPM NLJNEIJMIEE(long OAOPHNECJFF, AJMJLMGBAMP ONKAHOPPDIC, ALIKKKIHOKB EBOLFKEGOIA, IEnumerable<PersistenceView> JGJFIICGGKO, StringBuilder FGAINDDLOHH)
	{
		return default(CAKNPLNONPM);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x70953B0", Offset = "0x70939B0", VA = "0x1870953B0")]
	private POGNJKLFFHD HHBBCPCBFHI(long OAOPHNECJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x7094B90", Offset = "0x7093190", VA = "0x187094B90")]
	private void ECOFJHFAOLF(POGNJKLFFHD GCCIBPNMOIL, StringBuilder FGAINDDLOHH, IEnumerable<PersistenceView> JGJFIICGGKO, [In] NNIKKLPFIGN BLLPKOOEJEP, OBAOHHAJPLG HKGCLHPIKMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x7094DE0", Offset = "0x70933E0", VA = "0x187094DE0")]
	private void ENLHDGDDMLF(POGNJKLFFHD GCCIBPNMOIL, StringBuilder FGAINDDLOHH, PersistenceView EEOIFKIKDHI, OBAOHHAJPLG HKGCLHPIKMC, [In] NNIKKLPFIGN BLLPKOOEJEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
internal class IABIBLPEMDN : NFOKFKPKDGA
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	private sealed class JHCKFEEKEHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public PMHJNGIOAJD.HPEKFHFFOEA roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public JHCKFEEKEHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x7090290", Offset = "0x708E890", VA = "0x187090290")]
		internal object JGCPDLABPCH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private struct JIAOBCHFCFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		public AsyncTaskMethodBuilder<(PMHJNGIOAJD.HPEKFHFFOEA roomDataUpload, PMHJNGIOAJD.HPEKFHFFOEA subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public CAKNPLNONPM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		public IABIBLPEMDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		private JHCKFEEKEHI <>8__1;

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
		private TaskAwaiter<PMHJNGIOAJD.HPEKFHFFOEA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x70902E0", Offset = "0x708E8E0", VA = "0x1870902E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x7090B30", Offset = "0x708F130", VA = "0x187090B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private struct ACIIIKFJDEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		public AsyncTaskMethodBuilder<BIEOLNCJFEB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public IABIBLPEMDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public CAKNPLNONPM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public BMGKDPAHECJ roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		private TaskAwaiter<(PMHJNGIOAJD.HPEKFHFFOEA roomDataUpload, PMHJNGIOAJD.HPEKFHFFOEA subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		private TaskAwaiter<BIEOLNCJFEB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x7083460", Offset = "0x7081A60", VA = "0x187083460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x7083AF0", Offset = "0x70820F0", VA = "0x187083AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private struct FHOAHAPGMGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public AsyncTaskMethodBuilder<HMNDMLKHLEG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public IABIBLPEMDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public CAKNPLNONPM roomSerializedData;

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
		private TaskAwaiter<(PMHJNGIOAJD.HPEKFHFFOEA roomDataUpload, PMHJNGIOAJD.HPEKFHFFOEA subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		private TaskAwaiter<HMNDMLKHLEG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x7088E10", Offset = "0x7087410", VA = "0x187088E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x7089230", Offset = "0x7087830", VA = "0x187089230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private sealed class AIPOEKDCIKI
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
			public AsyncTaskMethodBuilder<JFFNGMFLFPF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006C1")]
			public AIPOEKDCIKI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006C2")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006C3")]
			private JFFNGMFLFPF <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006C4")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006C5")]
			private TaskAwaiter<HMNDMLKHLEG> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006C6")]
			private TaskAwaiter<BIEOLNCJFEB> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006C7")]
			private TaskAwaiter<JFFNGMFLFPF> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0x709C070", Offset = "0x709A670", VA = "0x18709C070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0x709CFF0", Offset = "0x709B5F0", VA = "0x18709CFF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		public IABIBLPEMDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public CAKNPLNONPM roomSerializedData;

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
		public BMGKDPAHECJ roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public GFELCKADMED roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public AIPOEKDCIKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x7084310", Offset = "0x7082910", VA = "0x187084310")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<JFFNGMFLFPF> GHJGKPNLDPF(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private struct ABHOHENDIPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		public AsyncTaskMethodBuilder<JFFNGMFLFPF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		public IABIBLPEMDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		public CAKNPLNONPM roomSerializedData;

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
		public BMGKDPAHECJ roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public GFELCKADMED roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		private TaskAwaiter<JFFNGMFLFPF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x70830E0", Offset = "0x70816E0", VA = "0x1870830E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x70833F0", Offset = "0x70819F0", VA = "0x1870833F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000696")]
	private static readonly CHNLCLDOCNE CNCAEGCNGHI;

	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private static readonly CHNLCLDOCNE NDGBKLCCDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000698")]
	private readonly CPFKOHNEIKA FEPDACDNBDC;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	private DGKBIEGBPPF KBMEHIINCBK
	{
		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x7070460", Offset = "0x706EA60", VA = "0x187070460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x708DE40", Offset = "0x708C440", VA = "0x18708DE40")]
	public IABIBLPEMDN(CHNELKEAFEA KIPAKJOBEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x708DAD0", Offset = "0x708C0D0", VA = "0x18708DAD0")]
	[AsyncStateMachine(typeof(JIAOBCHFCFC))]
	private Task<(PMHJNGIOAJD.HPEKFHFFOEA, PMHJNGIOAJD.HPEKFHFFOEA)> LANEGAAGDBA(CAKNPLNONPM HGFOMMCAKDA, long ECHGOOGHLEN, long IMIHMEAMIDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x708D960", Offset = "0x708BF60", VA = "0x18708D960")]
	[AsyncStateMachine(typeof(ACIIIKFJDEP))]
	public Task<BIEOLNCJFEB> FAHGNINBHCE(int GENJLEKEJPN, [CanBeNull] BMGKDPAHECJ DIKOOGMNLMJ, CAKNPLNONPM HGFOMMCAKDA, long ECHGOOGHLEN, long IMIHMEAMIDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x708D7F0", Offset = "0x708BDF0", VA = "0x18708D7F0")]
	[AsyncStateMachine(typeof(FHOAHAPGMGF))]
	private Task<HMNDMLKHLEG> DMJOKPEKGEA(string CHJGLFCKEKA, int GENJLEKEJPN, CAKNPLNONPM HGFOMMCAKDA, long ECHGOOGHLEN, long IMIHMEAMIDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x708DC10", Offset = "0x708C210", VA = "0x18708DC10")]
	[AsyncStateMachine(typeof(ABHOHENDIPL))]
	public Task<JFFNGMFLFPF> NCOEKEAALJP(int GENJLEKEJPN, BMGKDPAHECJ? DIKOOGMNLMJ, CAKNPLNONPM HGFOMMCAKDA, long ECHGOOGHLEN, long IMIHMEAMIDO, GFELCKADMED NMEIHJFPJBM, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM, CancellationToken NNGMAHIDECE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
public abstract class KOGKFFPMPAG<T> where T : KOGKFFPMPAG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D4")]
	internal readonly DGKBIEGBPPF POENNMEJHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D5")]
	private int? IBDCEBDELBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D6")]
	protected readonly Guid CBKPAFEEJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D7")]
	protected readonly NPEAHLFIFPI HIJMIMPEMMJ;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	protected T DFMNJGKHHDO
	{
		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x4218230", Offset = "0x4216830", VA = "0x184218230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x4218470", Offset = "0x4216A70", VA = "0x184218470")]
	internal KOGKFFPMPAG(DGKBIEGBPPF MGGLPCOMCCK, NPEAHLFIFPI GDINAMIEDDO, [Optional] Guid? MKCPOIIDFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x42180B0", Offset = "0x42166B0", VA = "0x1842180B0")]
	private JFFNGMFLFPF HNHMIJDICFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "4")]
	protected virtual void NBCLEJNOCCF(JFFNGMFLFPF DICMABMCPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x4218190", Offset = "0x4216790", VA = "0x184218190")]
	public T LKKGCPAOEGE(HDIGMKHIDBN CJFAPAOPNFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x42183C0", Offset = "0x42169C0", VA = "0x1842183C0")]
	public T PIBGCMPDEEN(int ILKCJAEAAGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x4218290", Offset = "0x4216890", VA = "0x184218290", Slot = "5")]
	public virtual Task<HPDKHMJHFIJ> ONBGGNIKMHG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
public class MCOCJALIEAM : KOGKFFPMPAG<MCOCJALIEAM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	private LDJGBBGIHDL JFHMMOFAOJJ;

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x7096750", Offset = "0x7094D50", VA = "0x187096750")]
	internal MCOCJALIEAM(DGKBIEGBPPF MGGLPCOMCCK, NPEAHLFIFPI GDINAMIEDDO, [Optional] Guid? MKCPOIIDFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x65CA6E0", Offset = "0x65C8CE0", VA = "0x1865CA6E0")]
	public MCOCJALIEAM PIJOBDBNKDD(LDJGBBGIHDL JFHMMOFAOJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x7096680", Offset = "0x7094C80", VA = "0x187096680", Slot = "4")]
	protected override void NBCLEJNOCCF(JFFNGMFLFPF DICMABMCPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public class GKINIHEDCFF : KOGKFFPMPAG<GKINIHEDCFF>
{
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	internal enum FFCKHFAMGHF
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
	private struct DCACGLMOEFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public AsyncTaskMethodBuilder<HPDKHMJHFIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public GKINIHEDCFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		private TaskAwaiter<HPDKHMJHFIJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x7087EC0", Offset = "0x70864C0", VA = "0x187087EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x7088270", Offset = "0x7086870", VA = "0x187088270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	private FFCKHFAMGHF CGGBBFLDKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	private string KOBIGHCBJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private BMGKDPAHECJ JFHMMOFAOJJ;

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x708B4D0", Offset = "0x7089AD0", VA = "0x18708B4D0")]
	internal GKINIHEDCFF(DGKBIEGBPPF MGGLPCOMCCK, NPEAHLFIFPI GDINAMIEDDO, [Optional] Guid? MKCPOIIDFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x708B1F0", Offset = "0x70897F0", VA = "0x18708B1F0")]
	public GKINIHEDCFF HGLPGKHHPKH(string EJBGBCFNIJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x708B3C0", Offset = "0x70899C0", VA = "0x18708B3C0")]
	public GKINIHEDCFF OGBPDPLJNKE(bool FOHAEIKJIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x708B220", Offset = "0x7089820", VA = "0x18708B220")]
	public GKINIHEDCFF MMBGFGOFFFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x708B250", Offset = "0x7089850", VA = "0x18708B250", Slot = "4")]
	protected override void NBCLEJNOCCF(JFFNGMFLFPF DICMABMCPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x708B3E0", Offset = "0x70899E0", VA = "0x18708B3E0", Slot = "5")]
	[AsyncStateMachine(typeof(DCACGLMOEFA))]
	public override Task<HPDKHMJHFIJ> ONBGGNIKMHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x708B1B0", Offset = "0x70897B0", VA = "0x18708B1B0")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<HPDKHMJHFIJ> BHKCAAKDKJN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
internal static class BPFGLOBCIMF
{
	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x7086AE0", Offset = "0x70850E0", VA = "0x187086AE0")]
	public static void AJPJNJHPDMP(this BKFAOGFLIJD HDFEFDJNHBA, HGMCNBIJHOL HKJCLCHOLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x7086C30", Offset = "0x7085230", VA = "0x187086C30")]
	public static void MAIPDFKCAHB(this HGMCNBIJHOL NIMHLKENONA, [Optional] string DICMABMCPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
public static class JEIKICPALIC
{
	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x708FBD0", Offset = "0x708E1D0", VA = "0x18708FBD0")]
	public static LDJPCHCCHLD ICNKFDMJFCO(this FMOHEJDKNCG HBACFKOHFJB)
	{
		return default(LDJPCHCCHLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x708FB20", Offset = "0x708E120", VA = "0x18708FB20")]
	public static FMOHEJDKNCG GDJADLKOLHN(this LDJPCHCCHLD ENFCGKDJCMB)
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
			public ILCLNGBPFIK ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006E9")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006EA")]
			public ILCLNGBPFIK HandleAs;

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
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		private static ILCLNGBPFIK[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		private Dictionary<ILCLNGBPFIK, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x709D680", Offset = "0x709BC80", VA = "0x18709D680")]
		public bool LJJGDBHJPNC(ILCLNGBPFIK FLBIIFCJJFG, [Out] ResultConfig AHDGGDAMLGE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x709D540", Offset = "0x709BB40", VA = "0x18709D540")]
		public ResultConfig BBHHNKHKFHA(ILCLNGBPFIK HBKEEHODHEK, [Optional] HashSet<ILCLNGBPFIK> MDDIIOAJKKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x709DC20", Offset = "0x709C220", VA = "0x18709DC20", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x709D6F0", Offset = "0x709BCF0", VA = "0x18709D6F0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x942CD0", Offset = "0x9412D0", VA = "0x180942CD0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
public class HLAADDCCCGM : MHAKOOGAPLD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private struct APFINLBLLBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public HLAADDCCCGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x709F010", Offset = "0x709D610", VA = "0x18709F010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x709F1A0", Offset = "0x709D7A0", VA = "0x18709F1A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private struct GHGGEHKGBDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		public MHAKOOGAPLD preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x70A0CD0", Offset = "0x709F2D0", VA = "0x1870A0CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x70A11E0", Offset = "0x709F7E0", VA = "0x1870A11E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006F3")]
	private readonly JAFJAGHCCAJ NGKJMGCLENG;

	[Cpp2IlInjected.Token(Token = "0x40006F4")]
	private static readonly CHNLCLDOCNE CNCAEGCNGHI;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public string MDLNHCLINHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x708CE90", Offset = "0x708B490", VA = "0x18708CE90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0x708CEC0", Offset = "0x708B4C0", VA = "0x18708CEC0")]
	[CCEDJDOPMOE(GIKFHLNFMKF.Root, CFIDNIINJOK.GameOnly)]
	private static void MLANPAMCCDJ(JJHPIOCMJGA KDALJJNBEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x8682B0", Offset = "0x8668B0", VA = "0x1808682B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public HLAADDCCCGM([JLPFJOFFNLM(null)] JAFJAGHCCAJ NGKJMGCLENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x708CFB0", Offset = "0x708B5B0", VA = "0x18708CFB0", Slot = "5")]
	[AsyncStateMachine(typeof(APFINLBLLBI))]
	public Task NGPKEBHLPHO(NEGKJPNCLPM<string>.GBKOFALFHEN CLOBAOOEDCO, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x708CD70", Offset = "0x708B370", VA = "0x18708CD70")]
	[AsyncStateMachine(typeof(GHGGEHKGBDF))]
	private Task AJPNAGKEKDG(MHAKOOGAPLD DMHONEJLOBJ, NEGKJPNCLPM<string>.GBKOFALFHEN CLOBAOOEDCO, CancellationToken NNGMAHIDECE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
public interface JAFJAGHCCAJ : MHAKOOGAPLD
{
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
public interface MHAKOOGAPLD
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	string MDLNHCLINHD
	{
		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NGPKEBHLPHO(NEGKJPNCLPM<string>.GBKOFALFHEN CLOBAOOEDCO, CancellationToken NNGMAHIDECE);
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
public static class OBCOGEMGNLN
{
	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x70A2550", Offset = "0x70A0B50", VA = "0x1870A2550")]
	[CCEDJDOPMOE(CFIDNIINJOK.GameOnly)]
	private static void DGJGMJJCAOC(JJHPIOCMJGA KDALJJNBEFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
public interface BIELPDNJBMP : IEquatable<BIELPDNJBMP>
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	DateTime ECGAKLFGBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IGNOKKBFBCE();

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FFPDJFGEIDO(long ECHGOOGHLEN, long OAOPHNECJFF, [Out] CAKNPLNONPM HGFOMMCAKDA);
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
internal class AHKHIBPLFDK : GFNJPGHEMJE
{
	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	[CompilerGenerated]
	private sealed class JJFJKBFILFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public OPKNKODACNB autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public JJFJKBFILFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x70A2440", Offset = "0x70A0A40", VA = "0x1870A2440")]
		internal object PNPEDGBJCIP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000702")]
	private readonly PDGMFOKLBHC LLNFDHMFIMH;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<BIELPDNJBMP> DDGAAHOGJCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x709E910", Offset = "0x709CF10", VA = "0x18709E910", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x709EF60", Offset = "0x709D560", VA = "0x18709EF60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x8682B0", Offset = "0x8668B0", VA = "0x1808682B0")]
	[UnityEngine.Scripting.Preserve]
	public AHKHIBPLFDK([JLPFJOFFNLM(null)] PDGMFOKLBHC LLNFDHMFIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x709E580", Offset = "0x709CB80", VA = "0x18709E580", Slot = "6")]
	public bool DEJJMPLODJG(long ECHGOOGHLEN, long OAOPHNECJFF, CAKNPLNONPM HGFOMMCAKDA, OPKNKODACNB KHBEOAAPNLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x1D2E310", Offset = "0x1D2C910", VA = "0x181D2E310")]
	private void GLEJJOGNEFG(BIELPDNJBMP BABFHOIKFOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x709E9C0", Offset = "0x709CFC0", VA = "0x18709E9C0", Slot = "7")]
	public bool KGICLOPBFMC(long ECHGOOGHLEN, long OAOPHNECJFF, [Out] BIELPDNJBMP CKBPCDCCCCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x709E860", Offset = "0x709CE60", VA = "0x18709E860", Slot = "8")]
	public bool EHNPOIAENOL(long ECHGOOGHLEN, long OAOPHNECJFF, OPKNKODACNB KHBEOAAPNLC, [Out] BIELPDNJBMP CKBPCDCCCCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x709EB30", Offset = "0x709D130", VA = "0x18709EB30")]
	private void NBBACFPMIJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x709E460", Offset = "0x709CA60", VA = "0x18709E460", Slot = "9")]
	public void BBHIKINGEDE(long ECHGOOGHLEN, long OAOPHNECJFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
internal abstract class PJMNOJIPEAC : PDGMFOKLBHC
{
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	protected enum OPEKHFKCIJL : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[CompilerGenerated]
	private sealed class BPNMOJEDBKJ : IEnumerable<BIELPDNJBMP>, IEnumerable, IEnumerator<BIELPDNJBMP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		private BIELPDNJBMP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		public PJMNOJIPEAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		private OPKNKODACNB autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		public OPKNKODACNB <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		private BIELPDNJBMP System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x8A8AC0", Offset = "0x8A70C0", VA = "0x1808A8AC0")]
		[DebuggerHidden]
		public BPNMOJEDBKJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x709F200", Offset = "0x709D800", VA = "0x18709F200", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x709F4E0", Offset = "0x709DAE0", VA = "0x18709F4E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x709F430", Offset = "0x709DA30", VA = "0x18709F430", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BIELPDNJBMP> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x709F430", Offset = "0x709DA30", VA = "0x18709F430", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[CompilerGenerated]
	private sealed class LGLGODCDEME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		public OPKNKODACNB autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public LGLGODCDEME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x70A24B0", Offset = "0x70A0AB0", VA = "0x1870A24B0")]
		internal object JKONMHOCHMD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[CompilerGenerated]
	private sealed class IGCLLOAAGLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public PJMNOJIPEAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public IGCLLOAAGLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x70A1D50", Offset = "0x70A0350", VA = "0x1870A1D50")]
		internal void EDIHGLDDDML(LDDBGLDKIOI.OHLOKEKBNOL ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000708")]
	private readonly object PMOGJBJGMHD;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	protected string CPPALBOLDOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x70A35D0", Offset = "0x70A1BD0", VA = "0x1870A35D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public abstract HLLKMPOFHDI NOLDMKCDCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x70A3670", Offset = "0x70A1C70", VA = "0x1870A3670")]
	protected PJMNOJIPEAC([CanBeNull] string DMDKAAOKDBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x70A33F0", Offset = "0x70A19F0", VA = "0x1870A33F0", Slot = "5")]
	public bool JBFAAMOHGMH(long ECHGOOGHLEN, long OAOPHNECJFF, OPKNKODACNB KHBEOAAPNLC, [Out] BIELPDNJBMP BABFHOIKFOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x70A35E0", Offset = "0x70A1BE0", VA = "0x1870A35E0", Slot = "6")]
	[IteratorStateMachine(typeof(BPNMOJEDBKJ))]
	public IEnumerable<BIELPDNJBMP> NDDNFMBEMFJ(OPKNKODACNB KHBEOAAPNLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void JIPFMOIFAHJ(Stream PAHOFONIBCF, long ECHGOOGHLEN, long OAOPHNECJFF, CAKNPLNONPM HGFOMMCAKDA);

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool DOKINNEFKFH(Stream FBJBGNLMENL, long ECHGOOGHLEN, long OAOPHNECJFF, IECPJGEIEPH KBFIABGPCHK, [Out] CAKNPLNONPM HGFOMMCAKDA);

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x70A3010", Offset = "0x70A1610", VA = "0x1870A3010", Slot = "7")]
	public BIELPDNJBMP IPCNJOHIFBE(long ECHGOOGHLEN, long OAOPHNECJFF, CAKNPLNONPM HGFOMMCAKDA, OPKNKODACNB KHBEOAAPNLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo OGOOGEBDCOF(long ECHGOOGHLEN, long OAOPHNECJFF, OPKNKODACNB KHBEOAAPNLC, OPEKHFKCIJL JJKMEPFFLJN);

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo GHEMFADLOJB(OPKNKODACNB KHBEOAAPNLC, OPEKHFKCIJL JJKMEPFFLJN);

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x70A3380", Offset = "0x70A1980", VA = "0x1870A3380")]
	protected void IPEDEFILJKF(LDDBGLDKIOI.OHLOKEKBNOL FPDNONACHGM, string BHFCMGBIGMC, FileInfo GMOIDGHKAFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x70A2C80", Offset = "0x70A1280", VA = "0x1870A2C80")]
	internal bool GBCNKNLNJHI(FileInfo OHMKLJDEJEI, long ECHGOOGHLEN, long OAOPHNECJFF, [Out] CAKNPLNONPM HGFOMMCAKDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
	private void GFFJDENGFHB(Exception DDPOICLDNND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A7")]
internal class HCDCFNCEJOB : PJMNOJIPEAC
{
	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public override HLLKMPOFHDI NOLDMKCDCNO
	{
		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0xD17E80", Offset = "0xD16480", VA = "0x180D17E80", Slot = "8")]
		get
		{
			return default(HLLKMPOFHDI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x70A1D10", Offset = "0x70A0310", VA = "0x1870A1D10")]
	public HCDCFNCEJOB([Optional] string DMDKAAOKDBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x70A1910", Offset = "0x709FF10", VA = "0x1870A1910")]
	private void GKENIDEGHHJ(OPKNKODACNB KHBEOAAPNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x70A1990", Offset = "0x709FF90", VA = "0x1870A1990", Slot = "9")]
	internal override void JIPFMOIFAHJ(Stream PAHOFONIBCF, long ECHGOOGHLEN, long OAOPHNECJFF, CAKNPLNONPM HGFOMMCAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0x70A1240", Offset = "0x709F840", VA = "0x1870A1240", Slot = "10")]
	internal override bool DOKINNEFKFH(Stream FBJBGNLMENL, long ECHGOOGHLEN, long OAOPHNECJFF, IECPJGEIEPH KBFIABGPCHK, [Out] CAKNPLNONPM HGFOMMCAKDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x70A1C20", Offset = "0x70A0220", VA = "0x1870A1C20", Slot = "11")]
	protected override FileInfo OGOOGEBDCOF(long ECHGOOGHLEN, long OAOPHNECJFF, OPKNKODACNB KHBEOAAPNLC, OPEKHFKCIJL JJKMEPFFLJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x70A1810", Offset = "0x709FE10", VA = "0x1870A1810", Slot = "12")]
	protected override DirectoryInfo GHEMFADLOJB(OPKNKODACNB KHBEOAAPNLC, OPEKHFKCIJL JJKMEPFFLJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
internal sealed class EDOJPMAHNHL : PJMNOJIPEAC
{
	[Cpp2IlInjected.Token(Token = "0x4000718")]
	private static readonly byte[] MNBFPOFIDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000719")]
	private readonly byte[] IMDAFDGOFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400071A")]
	private readonly byte[] OFHMKDAJGPM;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public override HLLKMPOFHDI NOLDMKCDCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x5E6DDE0", Offset = "0x5E6C3E0", VA = "0x185E6DDE0", Slot = "8")]
		get
		{
			return default(HLLKMPOFHDI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x70A0BE0", Offset = "0x709F1E0", VA = "0x1870A0BE0")]
	public EDOJPMAHNHL([Optional] string DMDKAAOKDBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x70A06B0", Offset = "0x709ECB0", VA = "0x1870A06B0", Slot = "9")]
	internal override void JIPFMOIFAHJ(Stream PAHOFONIBCF, long ECHGOOGHLEN, long OAOPHNECJFF, CAKNPLNONPM HGFOMMCAKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x709FDE0", Offset = "0x709E3E0", VA = "0x18709FDE0", Slot = "10")]
	internal override bool DOKINNEFKFH(Stream FBJBGNLMENL, long ECHGOOGHLEN, long OAOPHNECJFF, IECPJGEIEPH KBFIABGPCHK, [Out] CAKNPLNONPM HGFOMMCAKDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x70A0960", Offset = "0x709EF60", VA = "0x1870A0960")]
	private void NFKMGBFHABN(byte[] CNNPIMPOGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x70A0A20", Offset = "0x709F020", VA = "0x1870A0A20", Slot = "11")]
	protected override FileInfo OGOOGEBDCOF(long ECHGOOGHLEN, long OAOPHNECJFF, OPKNKODACNB KHBEOAAPNLC, OPEKHFKCIJL JJKMEPFFLJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x70A05A0", Offset = "0x709EBA0", VA = "0x1870A05A0", Slot = "12")]
	protected override DirectoryInfo GHEMFADLOJB(OPKNKODACNB KHBEOAAPNLC, OPEKHFKCIJL JJKMEPFFLJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
public enum HLLKMPOFHDI : byte
{
	[Cpp2IlInjected.Token(Token = "0x400071C")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x400071D")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x400071E")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001AA")]
internal class EBJADMJLFOG : PDGMFOKLBHC
{
	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[CompilerGenerated]
	private sealed class AAAIFJOGBGI : IEnumerable<BIELPDNJBMP>, IEnumerable, IEnumerator<BIELPDNJBMP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		private BIELPDNJBMP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		public EBJADMJLFOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		private OPKNKODACNB autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		public OPKNKODACNB <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		private HLLKMPOFHDI[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		private IEnumerator<BIELPDNJBMP> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		private BIELPDNJBMP System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000698")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x8A8AC0", Offset = "0x8A70C0", VA = "0x1808A8AC0")]
		[DebuggerHidden]
		public AAAIFJOGBGI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x709E3D0", Offset = "0x709C9D0", VA = "0x18709E3D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x709DFA0", Offset = "0x709C5A0", VA = "0x18709DFA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x709E280", Offset = "0x709C880", VA = "0x18709E280")]
		private void OGHBNIPNCAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x709E380", Offset = "0x709C980", VA = "0x18709E380", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x709E2D0", Offset = "0x709C8D0", VA = "0x18709E2D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BIELPDNJBMP> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x709E2D0", Offset = "0x709C8D0", VA = "0x18709E2D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400071F")]
	private readonly HLLKMPOFHDI[] PAMKPMPHKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000720")]
	private readonly Dictionary<HLLKMPOFHDI, PDGMFOKLBHC> IODNAAGCLFO;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public HLLKMPOFHDI NOLDMKCDCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x709F530", Offset = "0x709DB30", VA = "0x18709F530", Slot = "4")]
		get
		{
			return default(HLLKMPOFHDI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x709FAB0", Offset = "0x709E0B0", VA = "0x18709FAB0")]
	[UnityEngine.Scripting.Preserve]
	public EBJADMJLFOG(params PDGMFOKLBHC[] LJPOJJIBLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x709F6B0", Offset = "0x709DCB0", VA = "0x18709F6B0", Slot = "5")]
	public bool JBFAAMOHGMH(long ECHGOOGHLEN, long OAOPHNECJFF, OPKNKODACNB KHBEOAAPNLC, [Out] BIELPDNJBMP BABFHOIKFOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x709F800", Offset = "0x709DE00", VA = "0x18709F800")]
	private void JCOFIGJGCIO(int NDDPEGAEBAM, long ECHGOOGHLEN, long OAOPHNECJFF, OPKNKODACNB KHBEOAAPNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x709FA20", Offset = "0x709E020", VA = "0x18709FA20", Slot = "6")]
	[IteratorStateMachine(typeof(AAAIFJOGBGI))]
	public IEnumerable<BIELPDNJBMP> NDDNFMBEMFJ(OPKNKODACNB KHBEOAAPNLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x709F560", Offset = "0x709DB60", VA = "0x18709F560", Slot = "7")]
	public BIELPDNJBMP IPCNJOHIFBE(long ECHGOOGHLEN, long OAOPHNECJFF, CAKNPLNONPM HGFOMMCAKDA, OPKNKODACNB KHBEOAAPNLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AD")]
internal static class OBIAHECDCBH
{
	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x70A2BC0", Offset = "0x70A11C0", VA = "0x1870A2BC0")]
	internal static byte[] KPNDLLLLHGG(byte[] CNNPIMPOGKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x70A2960", Offset = "0x70A0F60", VA = "0x1870A2960")]
	public static void CFPLKAFPBOF(Stream LIBFPOKLOEB, byte[] DCNPGPENCGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x70A29E0", Offset = "0x70A0FE0", VA = "0x1870A29E0")]
	public static bool JPLIIMMHMKA(Stream LIBFPOKLOEB, long ODPPKMCIKHJ, IECPJGEIEPH OHPGPIMACGC, [Out] byte[] GNJFHJCGNBL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
internal sealed class JGOJKPCGEAM : BIELPDNJBMP, IEquatable<BIELPDNJBMP>, IEquatable<JGOJKPCGEAM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400072E")]
	private readonly PJMNOJIPEAC NAKCFJAGEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400072F")]
	public readonly FileInfo EMPDOBFHENE;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public HLLKMPOFHDI NOLDMKCDCNO
	{
		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x6A76600", Offset = "0x6A74C00", VA = "0x186A76600", Slot = "9")]
		get
		{
			return default(HLLKMPOFHDI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public DateTime ECGAKLFGBKD
	{
		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x70A2130", Offset = "0x70A0730", VA = "0x1870A2130", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x70A2330", Offset = "0x70A0930", VA = "0x1870A2330")]
	public JGOJKPCGEAM(PJMNOJIPEAC ADNDIBIBDJC, FileInfo OHMKLJDEJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x70A2280", Offset = "0x70A0880", VA = "0x1870A2280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x70A21C0", Offset = "0x70A07C0", VA = "0x1870A21C0", Slot = "5")]
	public void IGNOKKBFBCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x70A2060", Offset = "0x70A0660", VA = "0x1870A2060", Slot = "6")]
	public bool FFPDJFGEIDO(long ECHGOOGHLEN, long OAOPHNECJFF, [Out] CAKNPLNONPM HGFOMMCAKDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x70A1F80", Offset = "0x70A0580", VA = "0x1870A1F80", Slot = "7")]
	public bool Equals(BIELPDNJBMP OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x70A1EC0", Offset = "0x70A04C0", VA = "0x1870A1EC0", Slot = "8")]
	public bool Equals(JGOJKPCGEAM OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x70A1DD0", Offset = "0x70A03D0", VA = "0x1870A1DD0", Slot = "0")]
	public override bool Equals(object CDBNFNMIHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x70A20A0", Offset = "0x70A06A0", VA = "0x1870A20A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
public delegate void IECPJGEIEPH(LDDBGLDKIOI.OHLOKEKBNOL OICJBJFKAOO, string DICMABMCPKO);
[Cpp2IlInjected.Token(Token = "0x20001B0")]
internal interface PDGMFOKLBHC
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	HLLKMPOFHDI NOLDMKCDCNO
	{
		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JBFAAMOHGMH(long ECHGOOGHLEN, long OAOPHNECJFF, OPKNKODACNB KHBEOAAPNLC, [Out] BIELPDNJBMP BABFHOIKFOI);

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<BIELPDNJBMP> NDDNFMBEMFJ(OPKNKODACNB KHBEOAAPNLC);

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BIELPDNJBMP IPCNJOHIFBE(long ECHGOOGHLEN, long OAOPHNECJFF, CAKNPLNONPM HGFOMMCAKDA, OPKNKODACNB KHBEOAAPNLC);
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
