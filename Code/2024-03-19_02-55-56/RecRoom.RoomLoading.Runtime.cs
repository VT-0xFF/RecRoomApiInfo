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
		[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4660", VA = "0x1807E5660")]
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
		[Cpp2IlInjected.Address(RVA = "0x6783F00", Offset = "0x6782F00", VA = "0x186783F00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E62B0", Offset = "0x7E52B0", VA = "0x1807E62B0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7E62F0", Offset = "0x7E52F0", VA = "0x1807E62F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.Logging.Attributes.Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : JEBMLOLOJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x677E3E0", Offset = "0x677D3E0", VA = "0x18677E3E0", Slot = "4")]
		public override void PCEAKBMIBLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4660", VA = "0x1807E5660")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class IOJLOEDNIAC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x677A930", Offset = "0x6779930", VA = "0x18677A930")]
	public IOJLOEDNIAC(string DFJKCKBFLAD, Exception OHPABOEDNNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class PAMAALPHEBF : DGPLDMMCPOF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct HMJKCLONDOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<BKHCCIJBOJK>> <>t__builder;

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
		private TaskAwaiter<EPKHKLMJGIO<BKHCCIJBOJK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6778B10", Offset = "0x6777B10", VA = "0x186778B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6778D50", Offset = "0x6777D50", VA = "0x186778D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct ECAMKJPLBNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<LCBHIJODCGB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<LCBHIJODCGB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x676F770", Offset = "0x676E770", VA = "0x18676F770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x676F980", Offset = "0x676E980", VA = "0x18676F980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	[UnityEngine.Scripting.Preserve]
	public PAMAALPHEBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x67855D0", Offset = "0x67845D0", VA = "0x1867855D0", Slot = "4")]
	[AsyncStateMachine(typeof(HMJKCLONDOO))]
	public Task<IReadOnlyList<BKHCCIJBOJK>> DIPGHCHLGAB(long INFPDCJCIBN, long CNPHGBDAJDM, [Optional] CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x67854C0", Offset = "0x67844C0", VA = "0x1867854C0", Slot = "5")]
	[AsyncStateMachine(typeof(ECAMKJPLBNM))]
	public Task<IReadOnlyList<LCBHIJODCGB>> COPGBNMPACL(IReadOnlyList<int> DFCHCBHKGIB, [Optional] CancellationToken JMJKFNJJBHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DHCMJNHLBGF : IEquatable<DHCMJNHLBGF>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int IMNNOOIKJIE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	LCBHIJODCGB IPCMLFCCMDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime CLKPLFGEMCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	DKLHBOJAPFH? BCAOJAHGCOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	DEGNLJFMCMP? KDPOJINJFKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	GEKKNKCGLMA HJILNDAPPGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<LGMMDMPNFIF> PCLKAKDKOHK();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum GEKKNKCGLMA
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DGPLDMMCPOF
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<BKHCCIJBOJK>> DIPGHCHLGAB(long INFPDCJCIBN, long CNPHGBDAJDM, [Optional] CancellationToken JMJKFNJJBHM);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<LCBHIJODCGB>> COPGBNMPACL(IReadOnlyList<int> DFCHCBHKGIB, [Optional] CancellationToken JMJKFNJJBHM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class HAPOMKHKJGA
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class HNBJBBMGHIG : DHCMJNHLBGF, IEquatable<DHCMJNHLBGF>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct JCIIKLPJPFI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<LGMMDMPNFIF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public HNBJBBMGHIG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private PKJCGOGALJN <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<HHOALKJJLEH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<LGMMDMPNFIF> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x677B130", Offset = "0x677A130", VA = "0x18677B130", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x677B5D0", Offset = "0x677A5D0", VA = "0x18677B5D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly BKHCCIJBOJK BBKEEKIJKLE;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int IMNNOOIKJIE
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7BD1E0", Offset = "0x7BC1E0", VA = "0x1807BD1E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public LCBHIJODCGB IPCMLFCCMDF
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7BD1F0", Offset = "0x7BC1F0", VA = "0x1807BD1F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime JCBAFIBLCFF
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x543BA00", Offset = "0x543AA00", VA = "0x18543BA00", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public DKLHBOJAPFH? BCAOJAHGCOO
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x19D7E00", Offset = "0x19D6E00", VA = "0x1819D7E00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public DEGNLJFMCMP? KDPOJINJFKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x543BAE0", Offset = "0x543AAE0", VA = "0x18543BAE0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public GEKKNKCGLMA HJILNDAPPGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x87D040", Offset = "0x87C040", VA = "0x18087D040", Slot = "10")]
			get
			{
				return default(GEKKNKCGLMA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6779000", Offset = "0x6778000", VA = "0x186779000", Slot = "9")]
		[AsyncStateMachine(typeof(JCIIKLPJPFI))]
		public Task<LGMMDMPNFIF> PCLKAKDKOHK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6779100", Offset = "0x6778100", VA = "0x186779100")]
		public HNBJBBMGHIG(int LLOKBFFLIFC, LCBHIJODCGB MMKNKDKCMNO, BKHCCIJBOJK BBKEEKIJKLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6778EB0", Offset = "0x6777EB0", VA = "0x186778EB0", Slot = "11")]
		public bool Equals(DHCMJNHLBGF PJNBIAFGNNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6778E10", Offset = "0x6777E10", VA = "0x186778E10", Slot = "0")]
		public override bool Equals(object FGOCJODIEMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6778F40", Offset = "0x6777F40", VA = "0x186778F40")]
		private bool FIDGLKNFPJC(HNBJBBMGHIG PJNBIAFGNNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6778F80", Offset = "0x6777F80", VA = "0x186778F80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class PBMHLEHKGGF : DHCMJNHLBGF, IEquatable<DHCMJNHLBGF>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct MBHLHPAILBG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<LGMMDMPNFIF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public PBMHLEHKGGF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<LGMMDMPNFIF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x677E5C0", Offset = "0x677D5C0", VA = "0x18677E5C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x677E7F0", Offset = "0x677D7F0", VA = "0x18677E7F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly KLKBPFAMHHJ ECMNDJPJINI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly DKLHBOJAPFH KAPNBEKJEFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly DEGNLJFMCMP NEFDCCOBMKH;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int IMNNOOIKJIE
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6785790", Offset = "0x6784790", VA = "0x186785790", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LCBHIJODCGB IPCMLFCCMDF
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6785A00", Offset = "0x6784A00", VA = "0x186785A00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime JCBAFIBLCFF
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6785740", Offset = "0x6784740", VA = "0x186785740", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public DKLHBOJAPFH? BCAOJAHGCOO
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x67856F0", Offset = "0x67846F0", VA = "0x1867856F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public DEGNLJFMCMP? KDPOJINJFKK
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6785A90", Offset = "0x6784A90", VA = "0x186785A90", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public GEKKNKCGLMA HJILNDAPPGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x909610", Offset = "0x908610", VA = "0x180909610", Slot = "10")]
			get
			{
				return default(GEKKNKCGLMA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xF00340", Offset = "0xEFF340", VA = "0x180F00340")]
		public PBMHLEHKGGF(KLKBPFAMHHJ IJBMPEEKNEJ, DKLHBOJAPFH CBAABNONHNM, DEGNLJFMCMP HCFFNNBMHJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6785AE0", Offset = "0x6784AE0", VA = "0x186785AE0", Slot = "9")]
		[AsyncStateMachine(typeof(MBHLHPAILBG))]
		public Task<LGMMDMPNFIF> PCLKAKDKOHK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6785880", Offset = "0x6784880", VA = "0x186785880", Slot = "11")]
		public bool Equals(DHCMJNHLBGF PJNBIAFGNNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x67857D0", Offset = "0x67847D0", VA = "0x1867857D0", Slot = "0")]
		public override bool Equals(object FGOCJODIEMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6785920", Offset = "0x6784920", VA = "0x186785920")]
		private bool FIDGLKNFPJC(PBMHLEHKGGF PJNBIAFGNNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6785980", Offset = "0x6784980", VA = "0x186785980", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class DCLMPCGFMHC : DHCMJNHLBGF, IEquatable<DHCMJNHLBGF>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct IKNBENGLAPB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<LGMMDMPNFIF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<LGMMDMPNFIF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6779FF0", Offset = "0x6778FF0", VA = "0x186779FF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x677A230", Offset = "0x6779230", VA = "0x18677A230", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly LCBHIJODCGB JDKCHCIDIJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly DKLHBOJAPFH KAPNBEKJEFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly DEGNLJFMCMP NEFDCCOBMKH;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int IMNNOOIKJIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x676E490", Offset = "0x676D490", VA = "0x18676E490", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public LCBHIJODCGB IPCMLFCCMDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime JCBAFIBLCFF
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7BB290", Offset = "0x7BA290", VA = "0x1807BB290", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public DKLHBOJAPFH? BCAOJAHGCOO
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x676E440", Offset = "0x676D440", VA = "0x18676E440", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public DEGNLJFMCMP? KDPOJINJFKK
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x676E850", Offset = "0x676D850", VA = "0x18676E850", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public GEKKNKCGLMA HJILNDAPPGF
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7BB290", Offset = "0x7BA290", VA = "0x1807BB290", Slot = "10")]
			get
			{
				return default(GEKKNKCGLMA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xF00340", Offset = "0xEFF340", VA = "0x180F00340")]
		public DCLMPCGFMHC(LCBHIJODCGB MMKNKDKCMNO, DKLHBOJAPFH CBAABNONHNM, DEGNLJFMCMP HCFFNNBMHJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x676E8A0", Offset = "0x676D8A0", VA = "0x18676E8A0", Slot = "9")]
		[AsyncStateMachine(typeof(IKNBENGLAPB))]
		public Task<LGMMDMPNFIF> PCLKAKDKOHK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x676E5D0", Offset = "0x676D5D0", VA = "0x18676E5D0", Slot = "11")]
		public bool Equals(DHCMJNHLBGF PJNBIAFGNNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x676E4B0", Offset = "0x676D4B0", VA = "0x18676E4B0", Slot = "0")]
		public override bool Equals(object FGOCJODIEMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x676E7C0", Offset = "0x676D7C0", VA = "0x18676E7C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x676E6E0", Offset = "0x676D6E0", VA = "0x18676E6E0")]
		private bool FIDGLKNFPJC(DCLMPCGFMHC PJNBIAFGNNN)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct OALDHIAGCBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<DHCMJNHLBGF>> <>t__builder;

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
		public HAPOMKHKJGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<BKHCCIJBOJK> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<BKHCCIJBOJK>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, LCBHIJODCGB account, BKHCCIJBOJK roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6783F80", Offset = "0x6782F80", VA = "0x186783F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6784D60", Offset = "0x6783D60", VA = "0x186784D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct KKGJLNEFBIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, LCBHIJODCGB account, BKHCCIJBOJK roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<BKHCCIJBOJK> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public HAPOMKHKJGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<LCBHIJODCGB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x677C810", Offset = "0x677B810", VA = "0x18677C810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x677D200", Offset = "0x677C200", VA = "0x18677D200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly CCDHGMLMFPH LINDGHDFILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly DGPLDMMCPOF ONDDCDEDGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly HJHFFGLMGOI DCHIJCICNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly KEHHDPFBENA<(long, long), IReadOnlyList<BKHCCIJBOJK>> KDIJNLEOGMF;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x67783E0", Offset = "0x67773E0", VA = "0x1867783E0")]
	[UnityEngine.Scripting.Preserve]
	public HAPOMKHKJGA([CJCLEPGLAOP(null)] DGPLDMMCPOF HKFLGHFLHBP, [CJCLEPGLAOP(null)] HJHFFGLMGOI JNKCJCFKFHJ, [CJCLEPGLAOP(null)] CCDHGMLMFPH OPDECBOGBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x67780F0", Offset = "0x67770F0", VA = "0x1867780F0")]
	[AsyncStateMachine(typeof(OALDHIAGCBD))]
	public Task<IList<DHCMJNHLBGF>> HBEAEFLGBDH(long INFPDCJCIBN, long MBGBJFLBPMH, bool BLHKEKNHEJB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6778240", Offset = "0x6777240", VA = "0x186778240")]
	private bool JKAMCOJAOJO(DateTime? KNHCCEAOOLN, long INFPDCJCIBN, long MBGBJFLBPMH, [Out] KLKBPFAMHHJ NNNOIAJIGGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6777FE0", Offset = "0x6776FE0", VA = "0x186777FE0")]
	[AsyncStateMachine(typeof(KKGJLNEFBIA))]
	private Task<IReadOnlyList<(int, LCBHIJODCGB, BKHCCIJBOJK)>> ADDPBMNDDLO(IReadOnlyList<BKHCCIJBOJK> FFLCFFHOOLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HJHFFGLMGOI
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<KLKBPFAMHHJ> DLKPIBIGEEM;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JOLFJCFJHKA(long INFPDCJCIBN, long MBGBJFLBPMH, ELNOFCBKAIC JGCDJIMGDNO, APEKBBKGICD EIJDFFMEHGJ);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OHEPGGDHHJG(long INFPDCJCIBN, long MBGBJFLBPMH, [Out] KLKBPFAMHHJ NNNOIAJIGGD);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IDLFIFNGCKA(long INFPDCJCIBN, long MBGBJFLBPMH, APEKBBKGICD EIJDFFMEHGJ, [Out] KLKBPFAMHHJ NNNOIAJIGGD);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JGLKKIMFKLK(long INFPDCJCIBN, long MBGBJFLBPMH);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface NEGNOCONCHH : MBJMPCJKHOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool JOBKGFEDKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task GJMPPLDEOPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LNNJLGLIANA(Task JCGMNOGFGHB, string MDEPJIJAEFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface BIBICMEENFA : MBJMPCJKHOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LGMMDMPNFIF> HDLGBANOIAD(KLKBPFAMHHJ NNNOIAJIGGD);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KPFJJCPLHBF(CancellationToken JMJKFNJJBHM);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface KMHDIMCNMJP : MBJMPCJKHOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	PLOOJMIBDEL EJFOMLKBIOF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FFCFLMEHMPC();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DMHBEBGHPIK();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface MBJMPCJKHOM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPGLELIALOP(NKMCDKBACFE EFBGGNOIPLA);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface GOOMPBDIADC
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan BBHBELIIEMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan OHNBJLLEGHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan FFKFMIBOEJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan KFGKOGAKCJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool LINKIJALAMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool LJMFEJHFJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool JAGKIFKOBIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int MCGHFBMGDGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool NEJIDENPJDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool PMJBKBNAFDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum DPCAAGNNNDP
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum BHNKCKABCCE
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
public struct LMKKKLFJCGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long MEJANKKICDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long CNPHGBDAJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly DPCAAGNNNDP IKHOLAJCJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception CFGBAOJENOO;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x677D910", Offset = "0x677C910", VA = "0x18677D910")]
	public LMKKKLFJCGI(long MEJANKKICDD, long CNPHGBDAJDM, DPCAAGNNNDP IKHOLAJCJOG, [CanBeNull] Exception CFGBAOJENOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x677D8C0", Offset = "0x677C8C0", VA = "0x18677D8C0")]
	public static LMKKKLFJCGI AAHLBGJBNOI(ICNKHIIJEIP ACLNBCLPBIJ, DPCAAGNNNDP IKHOLAJCJOG, [Optional] Exception CFGBAOJENOO)
	{
		return default(LMKKKLFJCGI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public delegate void KHNGPABAGGL(LMKKKLFJCGI MJOEDHLNHMD);
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface PAMBJPNFIFH : MBJMPCJKHOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action AAFKDPDLLEB;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event KHNGPABAGGL NMNPAPMFDGF;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event KHNGPABAGGL FOEFGELDGHO;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event KHNGPABAGGL HPEHEINOECG;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<BHNKCKABCCE, bool> LBBBJMMALNI;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ANNIJDNJAFM();

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GLJIIKEOCGG(LMKKKLFJCGI MJOEDHLNHMD);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LEFKOEHPHMI(LMKKKLFJCGI MJOEDHLNHMD);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NDEBFIABAPP(LMKKKLFJCGI MJOEDHLNHMD);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AHEFJLECKHN(BHNKCKABCCE ECBICLOFOJH, bool LAFOEMFOPKK);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface LIMBIOPDAGN : MBJMPCJKHOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task GPNAIPHPBEH();

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFMDMFJOJEM();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface AODABJGIPHL : MBJMPCJKHOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TaskStatus ACPMDGHGNDA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GLKJLOFAHNI(ICNKHIIJEIP EBFOGOFHMKC, PGPPIOEAPIJ NDAKDPLBEHJ, CancellationToken JOEEALIOINJ);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class LGCAGGMCCPK
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x677D790", Offset = "0x677C790", VA = "0x18677D790")]
	public static bool AKKBHCHAIAA(this AODABJGIPHL GOFNADGNMFA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public delegate Task JMCKEGHPMPH(PHJGIMFDNFB PCNPJGFONNP, CancellationToken OGACLNNOKDA);
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface GKALEEFJBFC : MBJMPCJKHOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EOBBBKCDKHM(JMCKEGHPMPH JOGFIEECFCF);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface NKMCDKBACFE : PKJCGOGALJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CancellationToken OJOKHGNLCOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	ONGJLMJLNJA FFFKFLNEBJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	CEMECMCIGML EOGFNBKGLFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	AMKDODFOFNJ LPAEGHALAEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	AJDCIPBGOJA CBHMMKHDHNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	MKMNMEHNFGI CHCNLMGGEDC
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	CFCFGBMKNKO KJIDIHLJOBL
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	AFDFEADIGND KNFPINLOFCG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	MGPMMGPNEHM BAGGCNIJPKO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NEGNOCONCHH OAIPIMNAKDG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	BIBICMEENFA AIOMHPNHNIF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	PAMBJPNFIFH KMDJAECILMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	LIMBIOPDAGN PKLPBKPLMLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	AODABJGIPHL OMPPFLIMOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	GKALEEFJBFC JCJHGAKOOEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	GINGLICLBDA IJNCBPDLKGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	GGBNEKLADMG BMEOONLIGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	HFAHGLIBNAP ILPGLFKPCAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	EGGHGCCGEJB IKDGBHPCFKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	KGBIEPEIHBD LCKNNAOABCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	GDDHGAEFLGK CBOEIEJJDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	OAJKGMFDAML EIODIMLIMNI
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	BFIIGPKHFJG OOJMOHFJCIN
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	NCKDJFLGOCD HIIFDOODKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	DGNBFIJCHGK OHBGBBMIDIC
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	KMHDIMCNMJP ACPKFKDPMKA
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	GOOMPBDIADC EOLIJEFAAIL
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	EELLOKKIIGB DCIDKEKEALF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	HJHFFGLMGOI AAPHOEFMCPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	LLEGBCNMAEO PLCGDHKNFPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	CNCBPABFNGK NDHBBHBHMLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void NCEEHBKLNDN(PGPPIOEAPIJ BCKODKKOLMI);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface GINGLICLBDA : MBJMPCJKHOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	INLCMPBBLBB EMJMPPLJJNE(Guid FCBFKEBMKED);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JOBFLKKFIPF(Guid FCBFKEBMKED);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CKOBKLDIPNC(Guid FCBFKEBMKED, Task LPDOPAGNNDC);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JLFPPKIJHBA(Guid FCBFKEBMKED, LGMMDMPNFIF EOJLIPBFIDB);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(LGMMDMPNFIF, Task)> CBBHGCGGLOM(Guid FCBFKEBMKED);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface DGOLAKENKMI : MBJMPCJKHOM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface GGBNEKLADMG : MBJMPCJKHOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANKLJNHELFA(JLMLKKANJKN DFJKCKBFLAD);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DDGPMCKOLIK(JLMLKKANJKN DFJKCKBFLAD);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<DDMMJNHFCED> IKAGKMAAKPN(CancellationToken PPMFKGKHOBM);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface HFAHGLIBNAP : MBJMPCJKHOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	INLCMPBBLBB MEKMHEJIEIA(JLMLKKANJKN LFDHGIAKOKC);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OKBOFLENDPB(Guid FCBFKEBMKED, Task LPDOPAGNNDC);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface EGGHGCCGEJB : MBJMPCJKHOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LGMMDMPNFIF> IKDGBHPCFKP(JLMLKKANJKN EPLNAPFIBMC);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface KGBIEPEIHBD : MBJMPCJKHOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EGDMKLHIGGO> AHMKLIEJGGB(MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, ICNKHIIJEIP EBFOGOFHMKC, CancellationToken JMJKFNJJBHM);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface OAJKGMFDAML : MBJMPCJKHOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LGMMDMPNFIF LJCFFNMCHDJ(IDMICLLCMKN EDNMEBKKAHG);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HFLNNFNGHBH(string MOOBDKACMAL);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface GDDHGAEFLGK : MBJMPCJKHOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JLMLKKANJKN> BNOGNEMJGAD(JLMLKKANJKN LFFEKPPMJHN, DDJAKAGJABA JPIHEEKHHBI, CancellationToken JMJKFNJJBHM);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<JLMLKKANJKN> LHNBOGGECFF(CancellationToken JMJKFNJJBHM, DDJAKAGJABA JPIHEEKHHBI);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ABNEBIHJBDL HMAEFAGJFLB(CAMAINJFJEE AGPOAHNNFLO, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ABNEBIHJBDL BFPAPHILPDA(CAMAINJFJEE AGPOAHNNFLO, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface BFIIGPKHFJG : MBJMPCJKHOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LGMMDMPNFIF CNLGJKDFOLC(IDMICLLCMKN EDNMEBKKAHG, DDMMJNHFCED AKNBDBHMBDA);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LGMMDMPNFIF MKGPKIJNAEL(IDMICLLCMKN CKOPANEAEAH);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface NCKDJFLGOCD
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IHAAMLPECJO(GPGOBGEANDA KFHPBFHLFKA);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FGIKHDAMNMN(GPGOBGEANDA KFHPBFHLFKA);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IIMBIEOHACG(GPGOBGEANDA KFHPBFHLFKA);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ICBBNFFKHPN(GPGOBGEANDA KFHPBFHLFKA);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class GPGOBGEANDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly ICNKHIIJEIP IGJDBMNGIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> MNNDEPBAMNG;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public MFEMJMGOOCM<string> JEMEOHHJLEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1F0", Offset = "0x7BC1F0", VA = "0x1807BD1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1D0", Offset = "0x7BC1D0", VA = "0x1807BD1D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
	public GPGOBGEANDA(ICNKHIIJEIP HCHLADPIBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6777F10", Offset = "0x6776F10", VA = "0x186777F10")]
	public GPGOBGEANDA LNLNNBLIDFC(string IPAJBJLLPIJ, string CFJDHAGGAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6777E80", Offset = "0x6776E80", VA = "0x186777E80")]
	public bool AOKCLKFGIKL([Out] IEnumerable<KeyValuePair<string, string>> IFLBBCBFHEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5AD3B00", Offset = "0x5AD2B00", VA = "0x185AD3B00")]
	public GPGOBGEANDA LAKKILOGOEK(MFEMJMGOOCM<string> HKNHNBDNOFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface EELLOKKIIGB
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool OCBGFDNFIKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string BFHMENAHJBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool BGBPDJOGOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GLMNLGMAJOC();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MOFJNAGLMKN IEHDPLIBAAL(long HADAIDBBLEL);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OEINNMMNFJM<HJJELDEPGMC, PJNIIGNHFFM> NFFHDECCILG(long HADAIDBBLEL);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OEINNMMNFJM<HJJELDEPGMC, GBMJEMECJOI> DHKDJHGDPHD(long HADAIDBBLEL);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	OEINNMMNFJM<long, CMMCDCKCCKK> MPBMCBIMEPN();

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EFBCCMIAPEL(long HADAIDBBLEL, [Out] bool FLPKLGGFJMG);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> OGDBHNCOGFC(byte[] EMCNNGKGOCG, byte[] HFIPDKBOKHN, CancellationToken JMJKFNJJBHM);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface PKJCGOGALJN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool AKKBHCHAIAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool MFMEMLOKMBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	PGPPIOEAPIJ BDIGNPFHCPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action AAFKDPDLLEB;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event KHNGPABAGGL NMNPAPMFDGF;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event KHNGPABAGGL FOEFGELDGHO;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event KHNGPABAGGL HPEHEINOECG;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<BHNKCKABCCE, bool> LBBBJMMALNI;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AFMDMFJOJEM();

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	MCEINMCGGAN LGHDEEPBIHM();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	FJIDIBPLAGN PCOGEKOAHIG();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<LGMMDMPNFIF> HDLGBANOIAD(KLKBPFAMHHJ IJBMPEEKNEJ);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task KPFJJCPLHBF(CancellationToken JMJKFNJJBHM);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface MKMNMEHNFGI
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool OGKFGHHAGHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	string IEBNFFPECLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PKBHKLDLNPB(Scene MDHAFFOGBDM);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task PLOJDMIMFHI(PFJNNALEPML KEIOILMMDJP, CancellationToken JMJKFNJJBHM);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task AKMFDOEEPNE();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface AJDCIPBGOJA
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	PPCOIJKJGJJ NCIAKAPEEMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool FFDEPNOBKAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool AGMBBLOJEMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool NKFCNKJPBJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool PEIKGBDNPHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool OACKHNHPKGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool DNEBCACMNKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool JJEMAJGPEBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float KJFFAKLHBFM
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> BKOMBBPKBOP;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ONGJLMJLNJA PLHOINALAOH(ONGJLMJLNJA JGFBGCNJAEI);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IGMDFCLKKHG(ONGJLMJLNJA CNBEIAALEIM);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KJKFIJPKNJK();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task KCJPHKINOMP(MFEMJMGOOCM<string>.ENJHCLDNEDD IKKGGJADEIH, CancellationToken JMJKFNJJBHM);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LKDDIFLJDPE(float NJANOFHHIBC);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CNMIKPDEILG(string CCNDHICBNLO);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<NIANCEDPPNI> ILOHHPNIPJL();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable FDJLFBEDDFN(object LNLKAOCIPJI, NIANCEDPPNI EPLHPIANHBK);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	PJNIIGNHFFM ADPFPLMENNA(IEnumerable<CLAFHIEHHKM> IIOJFICIFCF);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IDKBFALOJLB(int GKKMNEEGMCJ);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task KAEBLJNFAMB();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GILLBKGOKIN();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool FDPPBLBHBBM();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task LKODCFFJNME(CancellationToken JMJKFNJJBHM);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task HKOKMIHBLMN(CancellationToken JMJKFNJJBHM);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<LDGJPCGHEMF> EKFHKLAOANB(DateTime FAHDIHFMHFA, CancellationToken JMJKFNJJBHM);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<bool> JBGPLCCPFHH(CancellationToken JMJKFNJJBHM);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void CIEAEINKPAC(string PKDHHDEADGP = "", float HNCJAFFEGLP = 3f);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "23")]
	PCDOIBNDDIK EBJLFIIGEPB(HODALNOLPKL GGECJBIIMFM, GMLLKOPLHNF APCBEKFBKDB, GBMJEMECJOI IPANBOPGHMA, IEnumerable<PersistenceView> JIMPAEDHKKD, PIBMDDKMLNE HMIGNIMACFE);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void FGFGAFFPMBJ(GBMJEMECJOI IPANBOPGHMA);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void OODICAAENPO(CLAFHIEHHKM KHIBNGNBOAK, [In] PCDOIBNDDIK COIDJBMJKKI);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task CGCHOMKOAIM(GBMJEMECJOI MLIFACLLCMJ, bool PGJHFNJDCIK, CancellationToken JMJKFNJJBHM);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task GEALEIAHFGL(CancellationToken JMJKFNJJBHM);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void CCHJHGBGEEK(long INFPDCJCIBN, long CNPHGBDAJDM, HHOALKJJLEH PCFDNGLCNCH, BKHCCIJBOJK PACNCDBPKGI, ELNOFCBKAIC JGCDJIMGDNO, MMDLGPJHFOP? NKKHAJMLMLH, EGBBBOLAJBE? DNEHJDAJONI);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void FBFGKJOJAGO(long INFPDCJCIBN, long CNPHGBDAJDM, EGBBBOLAJBE? DNEHJDAJONI);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void IFAELMAABFK(PersistenceView NLMJEFMFLBI);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool OKNJEECIGKF(PersistenceView LAOJDFENHDK);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool FJNJPEJOBKF(CLAFHIEHHKM KHIBNGNBOAK, KJKAGNONJMJ BEPINABCJNO, [Out] PHBOOLAONDI AMBNLMJHMOB);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task GNNKAPHLLNA(CancellationToken JMJKFNJJBHM);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void ANMKFBAAFAD();

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "35")]
	IDisposable DLCCJMGGMLN();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void HFDDOOCPNPF(GBMJEMECJOI MLIFACLLCMJ, KJKAGNONJMJ BEPINABCJNO);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Task<bool> JFAGFLKIAJA(CEMECMCIGML MPJONFIJKNC, CancellationToken JMJKFNJJBHM, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void LLBPJJLGGOM(CancellationToken JMJKFNJJBHM);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<FAOIIDCCPMP> EOHEAMOEPFP(DKICDMCJCLL LFFEKPPMJHN);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<HHOALKJJLEH> MGHMDEIOKIJ(long INFPDCJCIBN, bool DBAOFABAIPF, CancellationToken JMJKFNJJBHM);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<BKHCCIJBOJK> AKBBBIFBFMH(long INFPDCJCIBN, long CNPHGBDAJDM, long DELKKGCNFAO, CancellationToken JMJKFNJJBHM);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<BDLKEIKIHPI> PFMJOOMKPCL(string ENJMNLEIHJP, CancellationToken JMJKFNJJBHM);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<BDLKEIKIHPI> BAOOBMDIJKL(string ENJMNLEIHJP, long INFPDCJCIBN, long CNPHGBDAJDM, string MJPLOANBPHE, OJENABDAKEL.PCMOPFCDMGL PCNPJGFONNP, OJENABDAKEL.PCMOPFCDMGL HFIPDKBOKHN, int PMCHHGHDAJO);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool IMJDFPBACNC();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool HPCNAGLCCEE();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool DNECOFGPMIO(IEnumerable<PHBOOLAONDI> OJNFHFGJPLP);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void EKFDNKMMKPL(List<GameObject> BJGLDBPJEDO);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "49")]
	float OOOPPEAHHBG();

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "50")]
	Task<Scene> HFOAPFLHDEO(string KIPEOJGAHCM, LoadSceneMode NLAJPILJBID, bool HJDKBBNGFEG, MFEMJMGOOCM<string>.ENJHCLDNEDD HKNHNBDNOFH);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void KLJBEAEIGIA();

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void DCBDCNHDOPE(bool PNLCCPNIGII);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void MGIPEBNOGJN(ICNKHIIJEIP LGMKBABLLLM);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "59")]
	Task GPADHODPLEG(MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "60")]
	Task AMHKNBODAPI(MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "61")]
	Task OKPOALAIAOF(MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "62")]
	IDisposable HLBDJFMHCAP();

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "63")]
	JEIIDFGCINL PGKHLHFBOKL();

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "64")]
	Task MANDEEKCGBO(CancellationToken JMJKFNJJBHM);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface JEIIDFGCINL
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task LNAMHJGGGFO(CancellationToken JMJKFNJJBHM);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LIGDGLGCJAI(CancellationToken JMJKFNJJBHM);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct PCDOIBNDDIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> PDIEPPDGNJB;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum LDGJPCGHEMF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct HODALNOLPKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string OEDDJHJDLFF;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface PPCOIJKJGJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	ICNKHIIJEIP BMKCGCPEPEE
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	HHOALKJJLEH CLDIFHIIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	PHHDJLGAGMP EOIBCGJKBPP
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool LJJIFCPNJFL
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool EACHFGFIIGD
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	int NNDACJIHPEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action DPLMKNNEEKA;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> LIPEDIPMFGN;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NFMKKKBPFKP();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.ADJLFKMAKIP> PBLAHMDBBPJ(long HADAIDBBLEL, [Optional] CancellationToken JMJKFNJJBHM);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<BAKJNDIJHEK> EFLEOLGIPCO();

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task EKJKHKHJNAP();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(ICNKHIIJEIP, PGPPIOEAPIJ) CPEBCHLLEFC();

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "15")]
	KFHBOBCFAJF OBOFKKAFLOK();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DKPNDGHAAPH(long HADAIDBBLEL);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface DGNBFIJCHGK
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ECGIIEEHBKI([Out] IEnumerable<int> NANIBOOMKDF);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MCHAPLLNLHD(ABJADLEEAMP OGACLNNOKDA);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AADDKIGLPFO(ABJADLEEAMP OGACLNNOKDA);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface ECBDBFFEHGE
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string PHGHPFHLIIJ(LGMMDMPNFIF AJJPEOADJPA);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface KDHJOPNNILI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PFAGJJMIOIN(KFPDEPBJBMP.BHCPIJKJGJJ NEONJDFPDJK);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KKPDFKGDEMB(KFPDEPBJBMP.BHCPIJKJGJJ NEONJDFPDJK);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface CFCFGBMKNKO : KDHJOPNNILI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LGMMDMPNFIF LIAMKNILNCA(IDMICLLCMKN CKOPANEAEAH);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface AFDFEADIGND : KDHJOPNNILI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LGMMDMPNFIF LJCFFNMCHDJ(IDMICLLCMKN KOIELLGDMII);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface MOFJNAGLMKN
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PBAOJGOHCMJ<PFJNNALEPML, HMMHOLFLIGF>> FHEHHJOBFAD(string MJPLOANBPHE, long HADAIDBBLEL, long? INFPDCJCIBN, long? CNPHGBDAJDM, JNOEDMHOMHE.DEAIMAIHFEP CFHAMMCLEOL, CancellationToken JMJKFNJJBHM);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface OEINNMMNFJM<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PBAOJGOHCMJ<JNKLPPDJIFK<TData>, HMMHOLFLIGF>> FMALAOAPLBC(TGetDataArg OMFIAODHHCI, CancellationToken JMJKFNJJBHM);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class BAKGLKFELHJ : NKMCDKBACFE, PKJCGOGALJN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct POBAADLEICA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public AsyncTaskMethodBuilder<LGMMDMPNFIF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public BAKGLKFELHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public KLKBPFAMHHJ autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter<LGMMDMPNFIF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x67867B0", Offset = "0x67857B0", VA = "0x1867867B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6786A30", Offset = "0x6785A30", VA = "0x186786A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct EBDOPEONHLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public BAKGLKFELHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x676F4E0", Offset = "0x676E4E0", VA = "0x18676F4E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x676F710", Offset = "0x676E710", VA = "0x18676F710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class KNJBCOAKLGF : IEnumerable<MBJMPCJKHOM>, IEnumerable, IEnumerator<MBJMPCJKHOM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private MBJMPCJKHOM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public BAKGLKFELHJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		private MBJMPCJKHOM System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x80FF60", Offset = "0x80EF60", VA = "0x18080FF60")]
		[DebuggerHidden]
		public KNJBCOAKLGF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x677D270", Offset = "0x677C270", VA = "0x18677D270", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x677D6D0", Offset = "0x677C6D0", VA = "0x18677D6D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x677D620", Offset = "0x677C620", VA = "0x18677D620", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MBJMPCJKHOM> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x677D620", Offset = "0x677C620", VA = "0x18677D620", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource NILODAFHADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly ONGJLMJLNJA CNBEIAALEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool FIBIHEBBEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NODACKOAEKE FMACOKKCMOP;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public CEMECMCIGML EOGFNBKGLFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7BC230", Offset = "0x7BB230", VA = "0x1807BC230", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1B0", Offset = "0x7BB1B0", VA = "0x1807BC1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public AMKDODFOFNJ LPAEGHALAEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7C1250", Offset = "0x7C0250", VA = "0x1807C1250", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7C1280", Offset = "0x7C0280", VA = "0x1807C1280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public AJDCIPBGOJA CBHMMKHDHNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7C1270", Offset = "0x7C0270", VA = "0x1807C1270", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7C1260", Offset = "0x7C0260", VA = "0x1807C1260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public MKMNMEHNFGI CHCNLMGGEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7C1230", Offset = "0x7C0230", VA = "0x1807C1230", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7C1240", Offset = "0x7C0240", VA = "0x1807C1240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public CFCFGBMKNKO KJIDIHLJOBL
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7C1290", Offset = "0x7C0290", VA = "0x1807C1290", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7C1220", Offset = "0x7C0220", VA = "0x1807C1220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public AFDFEADIGND KNFPINLOFCG
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7C3250", Offset = "0x7C2250", VA = "0x1807C3250", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7C3170", Offset = "0x7C2170", VA = "0x1807C3170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public MGPMMGPNEHM BAGGCNIJPKO
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7C01B0", Offset = "0x7BF1B0", VA = "0x1807C01B0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7C0060", Offset = "0x7BF060", VA = "0x1807C0060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public NEGNOCONCHH OAIPIMNAKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7C0010", Offset = "0x7BF010", VA = "0x1807C0010", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7C01C0", Offset = "0x7BF1C0", VA = "0x1807C01C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public BIBICMEENFA AIOMHPNHNIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7C00B0", Offset = "0x7BF0B0", VA = "0x1807C00B0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7C0020", Offset = "0x7BF020", VA = "0x1807C0020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public PAMBJPNFIFH KMDJAECILMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x98A1D0", Offset = "0x9891D0", VA = "0x18098A1D0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x988320", Offset = "0x987320", VA = "0x180988320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public LIMBIOPDAGN PKLPBKPLMLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7C0170", Offset = "0x7BF170", VA = "0x1807C0170", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7C0130", Offset = "0x7BF130", VA = "0x1807C0130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public AODABJGIPHL OMPPFLIMOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8828F0", Offset = "0x8818F0", VA = "0x1808828F0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x882A10", Offset = "0x881A10", VA = "0x180882A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public GKALEEFJBFC JCJHGAKOOEM
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7C9760", Offset = "0x7C8760", VA = "0x1807C9760", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7C97C0", Offset = "0x7C87C0", VA = "0x1807C97C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public GINGLICLBDA IJNCBPDLKGE
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA1C7B0", Offset = "0xA1B7B0", VA = "0x180A1C7B0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA25690", Offset = "0xA24690", VA = "0x180A25690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public DGOLAKENKMI ANPCCGBPJLM
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x96AA90", Offset = "0x969A90", VA = "0x18096AA90", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x96AAA0", Offset = "0x969AA0", VA = "0x18096AAA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public GGBNEKLADMG BMEOONLIGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9AED40", Offset = "0x9ADD40", VA = "0x1809AED40", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA25610", Offset = "0xA24610", VA = "0x180A25610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public HFAHGLIBNAP ILPGLFKPCAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8FBA20", Offset = "0x8FAA20", VA = "0x1808FBA20", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x97C3A0", Offset = "0x97B3A0", VA = "0x18097C3A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public EGGHGCCGEJB IKDGBHPCFKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x97EA50", Offset = "0x97DA50", VA = "0x18097EA50", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x97DD10", Offset = "0x97CD10", VA = "0x18097DD10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public KGBIEPEIHBD LCKNNAOABCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7C97B0", Offset = "0x7C87B0", VA = "0x1807C97B0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7C97E0", Offset = "0x7C87E0", VA = "0x1807C97E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public GDDHGAEFLGK CBOEIEJJDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x889CC0", Offset = "0x888CC0", VA = "0x180889CC0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8850B0", Offset = "0x8840B0", VA = "0x1808850B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public OAJKGMFDAML EIODIMLIMNI
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8E4410", Offset = "0x8E3410", VA = "0x1808E4410", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8E4860", Offset = "0x8E3860", VA = "0x1808E4860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public BFIIGPKHFJG OOJMOHFJCIN
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x905720", Offset = "0x904720", VA = "0x180905720", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA246B0", VA = "0x180A256B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public NCKDJFLGOCD HIIFDOODKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x889D70", Offset = "0x888D70", VA = "0x180889D70", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x886E90", Offset = "0x885E90", VA = "0x180886E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public DGNBFIJCHGK OHBGBBMIDIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9055F0", Offset = "0x9045F0", VA = "0x1809055F0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA25670", Offset = "0xA24670", VA = "0x180A25670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public KMHDIMCNMJP ACPKFKDPMKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9056C0", Offset = "0x9046C0", VA = "0x1809056C0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA25830", Offset = "0xA24830", VA = "0x180A25830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public GOOMPBDIADC EOLIJEFAAIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9ADC10", Offset = "0x9ACC10", VA = "0x1809ADC10", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA257F0", Offset = "0xA247F0", VA = "0x180A257F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public EELLOKKIIGB DCIDKEKEALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8692E0", Offset = "0x8682E0", VA = "0x1808692E0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA25750", Offset = "0xA24750", VA = "0x180A25750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public HJHFFGLMGOI AAPHOEFMCPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8F6490", Offset = "0x8F5490", VA = "0x1808F6490", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public LLEGBCNMAEO PLCGDHKNFPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9ADD70", Offset = "0x9ACD70", VA = "0x1809ADD70", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public CNCBPABFNGK NDHBBHBHMLC
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8F64B0", Offset = "0x8F54B0", VA = "0x1808F64B0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public PGPPIOEAPIJ BDIGNPFHCPD
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8F64A0", Offset = "0x8F54A0", VA = "0x1808F64A0", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8F6570", Offset = "0x8F5570", VA = "0x1808F6570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	private bool BPLJEHBLKIP
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6769F90", Offset = "0x6768F90", VA = "0x186769F90", Slot = "46")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	private bool HJNGINIHHED
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x676A120", Offset = "0x6769120", VA = "0x18676A120", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private CancellationToken KLBKHLJFJKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x676A100", Offset = "0x6769100", VA = "0x18676A100", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	private ONGJLMJLNJA BCIIDEPLENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action GDMLHJOOLOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6769D00", Offset = "0x6768D00", VA = "0x186769D00", Slot = "36")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x676A0A0", Offset = "0x67690A0", VA = "0x18676A0A0", Slot = "37")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event KHNGPABAGGL LHPNIFMDNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6769C40", Offset = "0x6768C40", VA = "0x186769C40", Slot = "38")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6769FF0", Offset = "0x6768FF0", VA = "0x186769FF0", Slot = "39")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event KHNGPABAGGL KKLEFHOFLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x67697B0", Offset = "0x67687B0", VA = "0x1867697B0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6769F30", Offset = "0x6768F30", VA = "0x186769F30", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event KHNGPABAGGL KJEGLGHEAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6769B50", Offset = "0x6768B50", VA = "0x186769B50", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6769A60", Offset = "0x6768A60", VA = "0x186769A60", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<BHNKCKABCCE, bool> JJBBFGIHHLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6769ED0", Offset = "0x6768ED0", VA = "0x186769ED0", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6769CA0", Offset = "0x6768CA0", VA = "0x186769CA0", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x8F6570", Offset = "0x8F5570", VA = "0x1808F6570", Slot = "35")]
	public void NCEEHBKLNDN(PGPPIOEAPIJ BCKODKKOLMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x676A310", Offset = "0x6769310", VA = "0x18676A310")]
	[UnityEngine.Scripting.Preserve]
	internal BAKGLKFELHJ([CJCLEPGLAOP(null)] ONGJLMJLNJA CNBEIAALEIM, [CJCLEPGLAOP(null)] CEMECMCIGML MPJONFIJKNC, [CJCLEPGLAOP(null)] AMKDODFOFNJ MADAMCGNEFB, [CJCLEPGLAOP(null)] AJDCIPBGOJA HLIOAAOLCGJ, [CJCLEPGLAOP(null)] MKMNMEHNFGI FICPNHDLFFB, [CJCLEPGLAOP(null)] CFCFGBMKNKO OGEOCLEKCKD, [CJCLEPGLAOP(null)] AFDFEADIGND BKPHLLMGBLC, [CJCLEPGLAOP(null)] MGPMMGPNEHM CNCONLPHCPH, [CJCLEPGLAOP(null)] NEGNOCONCHH FCGNBGJGKLK, [CJCLEPGLAOP(null)] BIBICMEENFA APHLAOMLCFD, [CJCLEPGLAOP(null)] PAMBJPNFIFH HNGAAMFJMAP, [CJCLEPGLAOP(null)] LIMBIOPDAGN NIMKPAMNFCL, [CJCLEPGLAOP(null)] AODABJGIPHL GOFNADGNMFA, [CJCLEPGLAOP(null)] GKALEEFJBFC IOMAIMDGDKK, [CJCLEPGLAOP(null)] GINGLICLBDA KNLDJIGFFGN, [CJCLEPGLAOP(null)] DGOLAKENKMI GFPHOAIPMFC, [CJCLEPGLAOP(null)] GGBNEKLADMG BPMIHMDKHFA, [CJCLEPGLAOP(null)] HFAHGLIBNAP DPLBEKEDHIG, [CJCLEPGLAOP(null)] EGGHGCCGEJB IHHBLKGEBLN, [CJCLEPGLAOP(null)] KGBIEPEIHBD FFBNKBLNLOL, [CJCLEPGLAOP(null)] OAJKGMFDAML KEOABLFBJAC, [CJCLEPGLAOP(null)] GDDHGAEFLGK DMMBODIODOC, [CJCLEPGLAOP(null)] BFIIGPKHFJG DDPPPIJNHLI, [CJCLEPGLAOP(null)] NCKDJFLGOCD PDBJDNMPKNA, [CJCLEPGLAOP(null)] DGNBFIJCHGK FCJNPNIPEMI, [CJCLEPGLAOP(null)] GOOMPBDIADC DJEDGNFIGON, [CJCLEPGLAOP(null)] EELLOKKIIGB MICKLJMAPDC, [CJCLEPGLAOP(null)] HJHFFGLMGOI EHIGLKAPBNG, [CJCLEPGLAOP(null)] LLEGBCNMAEO MEKEALILPHL, [CJCLEPGLAOP(null)] CNCBPABFNGK MOEGNBOLLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6769810", Offset = "0x6768810", VA = "0x186769810")]
	private void DPGLELIALOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x67698C0", Offset = "0x67688C0", VA = "0x1867698C0", Slot = "54")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x676A050", Offset = "0x6769050", VA = "0x18676A050", Slot = "48")]
	private void LLCKALBGEIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6769BB0", Offset = "0x6768BB0", VA = "0x186769BB0", Slot = "49")]
	private MCEINMCGGAN GOCLFAMGIGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6769AC0", Offset = "0x6768AC0", VA = "0x186769AC0", Slot = "50")]
	private FJIDIBPLAGN FLJGLLCEDPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6769D60", Offset = "0x6768D60", VA = "0x186769D60", Slot = "51")]
	[AsyncStateMachine(typeof(POBAADLEICA))]
	private Task<LGMMDMPNFIF> HIFGJOCPFPA(KLKBPFAMHHJ NNNOIAJIGGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x676A220", Offset = "0x6769220", VA = "0x18676A220", Slot = "52")]
	[AsyncStateMachine(typeof(EBDOPEONHLO))]
	private Task PAKDFONPBNL(CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x676A1A0", Offset = "0x67691A0", VA = "0x18676A1A0")]
	[IteratorStateMachine(typeof(KNJBCOAKLGF))]
	private IEnumerable<MBJMPCJKHOM> OODOPPKANDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6769E70", Offset = "0x6768E70", VA = "0x186769E70")]
	[CompilerGenerated]
	private void IKONBDALKJO(MBJMPCJKHOM HDIPHGOKDCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class BCEIGILCAGA : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0xD6E3F0", Offset = "0xD6D3F0", VA = "0x180D6E3F0")]
	public BCEIGILCAGA(string DFJKCKBFLAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal class PHNCBCONCJH : CABNJCCOLKE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct GFCCJBHLDLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public PHNCBCONCJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x6773FD0", Offset = "0x6772FD0", VA = "0x186773FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x6774310", Offset = "0x6773310", VA = "0x186774310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly NKMCDKBACFE EFBGGNOIPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly AJDCIPBGOJA HLIOAAOLCGJ;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7C8740", Offset = "0x7C7740", VA = "0x1807C8740")]
	public PHNCBCONCJH(NKMCDKBACFE EFBGGNOIPLA, AJDCIPBGOJA HLIOAAOLCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6785CB0", Offset = "0x6784CB0", VA = "0x186785CB0", Slot = "4")]
	[AsyncStateMachine(typeof(GFCCJBHLDLA))]
	public Task<bool> LGNOBPOOHOP(CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6785BD0", Offset = "0x6784BD0", VA = "0x186785BD0")]
	[CompilerGenerated]
	private object KALCHOEGNIH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class CPMBIPEDPHN : CABNJCCOLKE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct HOGDOCPHDDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public CPMBIPEDPHN <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6779160", Offset = "0x6778160", VA = "0x186779160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6779870", Offset = "0x6778870", VA = "0x186779870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly NKMCDKBACFE EFBGGNOIPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly AJDCIPBGOJA HLIOAAOLCGJ;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	private PPCOIJKJGJJ NCIAKAPEEMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x676DFE0", Offset = "0x676CFE0", VA = "0x18676DFE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x7C8740", Offset = "0x7C7740", VA = "0x1807C8740")]
	public CPMBIPEDPHN(NKMCDKBACFE EFBGGNOIPLA, AJDCIPBGOJA HLIOAAOLCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x676E110", Offset = "0x676D110", VA = "0x18676E110", Slot = "4")]
	[AsyncStateMachine(typeof(HOGDOCPHDDG))]
	public Task<bool> LGNOBPOOHOP(CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x676E030", Offset = "0x676D030", VA = "0x18676E030")]
	[CompilerGenerated]
	private object HGEIBFPGENP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal class FEMLHMOLJNI : CABNJCCOLKE
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class CPPFHLBPNIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public FEMLHMOLJNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public BAKJNDIJHEK result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public ICNKHIIJEIP newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public CPPFHLBPNIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x676E2E0", Offset = "0x676D2E0", VA = "0x18676E2E0")]
		internal object DPJLNPHHJOF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x676E3D0", Offset = "0x676D3D0", VA = "0x18676E3D0")]
		internal object GDGIGCBNMOC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x676E240", Offset = "0x676D240", VA = "0x18676E240")]
		internal object CDOHNOHGANH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct DMAMGJGAAGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public FEMLHMOLJNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private CPPFHLBPNIN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private TaskAwaiter<BAKJNDIJHEK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x676EB40", Offset = "0x676DB40", VA = "0x18676EB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x676F470", Offset = "0x676E470", VA = "0x18676F470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly NKMCDKBACFE EFBGGNOIPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly AJDCIPBGOJA HLIOAAOLCGJ;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private PPCOIJKJGJJ NCIAKAPEEMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6771B40", Offset = "0x6770B40", VA = "0x186771B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x7C8740", Offset = "0x7C7740", VA = "0x1807C8740")]
	public FEMLHMOLJNI(NKMCDKBACFE EFBGGNOIPLA, AJDCIPBGOJA HLIOAAOLCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6771B90", Offset = "0x6770B90", VA = "0x186771B90", Slot = "4")]
	[AsyncStateMachine(typeof(DMAMGJGAAGI))]
	public Task<bool> LGNOBPOOHOP(CancellationToken JMJKFNJJBHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal interface CABNJCCOLKE
{
	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> LGNOBPOOHOP(CancellationToken JMJKFNJJBHM);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal struct ECHMFOFLNGH
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class HNAFMBNHLGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public NKMCDKBACFE manager;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public HNAFMBNHLGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6778DC0", Offset = "0x6777DC0", VA = "0x186778DC0")]
		internal Task NONNPEPHBKD(PHJGIMFDNFB data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct HBPKKMEDGFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public ECHMFOFLNGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private KLKBPFAMHHJ <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<LDGJPCGHEMF> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<LGMMDMPNFIF> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6778510", Offset = "0x6777510", VA = "0x186778510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6778AA0", Offset = "0x6777AA0", VA = "0x186778AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct ALBABHAPIJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public ECHMFOFLNGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6768700", Offset = "0x6767700", VA = "0x186768700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6768A20", Offset = "0x6767A20", VA = "0x186768A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly CancellationToken JMJKFNJJBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly NKMCDKBACFE JDIOCIOLNIG;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private CEMECMCIGML EOGFNBKGLFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x676F9F0", Offset = "0x676E9F0", VA = "0x18676F9F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private AJDCIPBGOJA CBHMMKHDHNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x676FC90", Offset = "0x676EC90", VA = "0x18676FC90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private PPCOIJKJGJJ NCIAKAPEEMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x676FB40", Offset = "0x676EB40", VA = "0x18676FB40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private BIBICMEENFA AIOMHPNHNIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x676FA40", Offset = "0x676EA40", VA = "0x18676FA40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x1DDB070", Offset = "0x1DDA070", VA = "0x181DDB070")]
	public ECHMFOFLNGH(CancellationToken JMJKFNJJBHM, NKMCDKBACFE JDIOCIOLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x676FA90", Offset = "0x676EA90", VA = "0x18676FA90")]
	public static JMCKEGHPMPH CCMCJKKLDPE(NKMCDKBACFE JDIOCIOLNIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x676FEF0", Offset = "0x676EEF0", VA = "0x18676FEF0")]
	[AsyncStateMachine(typeof(HBPKKMEDGFL))]
	public Task<bool> OIOCKJJDGEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x676FCE0", Offset = "0x676ECE0", VA = "0x18676FCE0")]
	private bool LOGMJKNDHCC([Out] KLKBPFAMHHJ NNNOIAJIGGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x676FBC0", Offset = "0x676EBC0", VA = "0x18676FBC0")]
	[AsyncStateMachine(typeof(ALBABHAPIJP))]
	private Task GEDMOALKCNC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6770000", Offset = "0x676F000", VA = "0x186770000")]
	private Task<LDGJPCGHEMF> PJCOLEKPBCO(KLKBPFAMHHJ DMONGDFPJNE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct INLCMPBBLBB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly GINGLICLBDA KNLDJIGFFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Guid FCBFKEBMKED;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private Task<(LGMMDMPNFIF, Task)> IEDFDIBFHNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x677A810", Offset = "0x6779810", VA = "0x18677A810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8070", Offset = "0x3CC7070", VA = "0x183CC8070")]
	public INLCMPBBLBB(GINGLICLBDA KNLDJIGFFGN, Guid FCBFKEBMKED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x677A8E0", Offset = "0x67798E0", VA = "0x18677A8E0")]
	public TaskAwaiter<(LGMMDMPNFIF, Task)> FLAMAHAJCAD()
	{
		return default(TaskAwaiter<(LGMMDMPNFIF, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x677A740", Offset = "0x6779740", VA = "0x18677A740", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal struct FGLPDPHHHMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly TaskCompletionSource<(LGMMDMPNFIF, Task)> BAEBLGFIMKN;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public Task<(LGMMDMPNFIF, Task)> IEDFDIBFHNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6771D40", Offset = "0x6770D40", VA = "0x186771D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6771F00", Offset = "0x6770F00", VA = "0x186771F00")]
	public FGLPDPHHHMN(TimeSpan ONBAFMEFHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6771D80", Offset = "0x6770D80", VA = "0x186771D80")]
	public void JNLINNLDHIB(Task LPDOPAGNNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6771E20", Offset = "0x6770E20", VA = "0x186771E20")]
	public void NFELHKENNBC(LGMMDMPNFIF AJJPEOADJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6771EB0", Offset = "0x6770EB0", VA = "0x186771EB0")]
	public void NPNLMMBNDGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6771CB0", Offset = "0x6770CB0", VA = "0x186771CB0")]
	internal void CGMPPLIFMBJ(string DFJKCKBFLAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class JBIKDNOGFFB
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class ICCFBAOGOHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public BKHCCIJBOJK subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public ICCFBAOGOHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6779DC0", Offset = "0x6778DC0", VA = "0x186779DC0")]
		internal bool CFKNKMIAPCF(PHHDJLGAGMP s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x677AE70", Offset = "0x6779E70", VA = "0x18677AE70")]
	public static EGDMKLHIGGO OOGKEDOOOJC(long MEJANKKICDD, long CNPHGBDAJDM, string ENJMNLEIHJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x677AC20", Offset = "0x6779C20", VA = "0x18677AC20")]
	public static EGDMKLHIGGO OOGKEDOOOJC(long MEJANKKICDD, long CNPHGBDAJDM, HJJELDEPGMC EMCNNGKGOCG, long DELKKGCNFAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x677ACE0", Offset = "0x6779CE0", VA = "0x18677ACE0")]
	public static EGDMKLHIGGO OOGKEDOOOJC(FAOIIDCCPMP LMMKODMKPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x677AF00", Offset = "0x6779F00", VA = "0x18677AF00")]
	public static EGDMKLHIGGO OOGKEDOOOJC(HHOALKJJLEH NGGALFIANBG, BKHCCIJBOJK LBPFPCMMKKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x677AB30", Offset = "0x6779B30", VA = "0x18677AB30")]
	public static EGDMKLHIGGO OKNNHNNLNJP(this EGDMKLHIGGO CEFJMHIOKFM, HHOALKJJLEH INNBAEPMMPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x677A9A0", Offset = "0x67799A0", VA = "0x18677A9A0")]
	public static EGDMKLHIGGO IFGCIOPJLBO(this EGDMKLHIGGO CEFJMHIOKFM, BKHCCIJBOJK KGNFPAMKAAI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[RecRoom.NoEngine.Common.Preserve]
internal class MEIMMCMEJHL : NEGNOCONCHH, MBJMPCJKHOM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct CDFKBBMBFJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public MEIMMCMEJHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x676B940", Offset = "0x676A940", VA = "0x18676B940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x676BFD0", Offset = "0x676AFD0", VA = "0x18676BFD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly ABJADLEEAMP OHKMAGFCLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private string KPPOGENIJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Task GGBMFHKKNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private NKMCDKBACFE EFBGGNOIPLA;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool JOBKGFEDKHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x677E860", Offset = "0x677D860", VA = "0x18677E860", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public Task GJMPPLDEOPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x677E9B0", Offset = "0x677D9B0", VA = "0x18677E9B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7C21C0", Offset = "0x7C11C0", VA = "0x1807C21C0", Slot = "7")]
	public void DPGLELIALOP(NKMCDKBACFE EFBGGNOIPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x677EA40", Offset = "0x677DA40", VA = "0x18677EA40", Slot = "6")]
	public void LNNJLGLIANA(Task JCGMNOGFGHB, string MDEPJIJAEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x677E890", Offset = "0x677D890", VA = "0x18677E890")]
	[AsyncStateMachine(typeof(CDFKBBMBFJP))]
	private Task GFKEAHLOGDM(Task DMHLCLAKBAO, string MDEPJIJAEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x677EBA0", Offset = "0x677DBA0", VA = "0x18677EBA0")]
	public MEIMMCMEJHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class IMHNDKNJBFB : KMHDIMCNMJP, MBJMPCJKHOM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool NBOIAPFHMGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private PLOOJMIBDEL EMGGCPELLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private CEMECMCIGML MPJONFIJKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private GOOMPBDIADC DJEDGNFIGON;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public PLOOJMIBDEL EJFOMLKBIOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x677A460", Offset = "0x6779460", VA = "0x18677A460", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x677A2E0", Offset = "0x67792E0", VA = "0x18677A2E0", Slot = "7")]
	public void DPGLELIALOP(NKMCDKBACFE EFBGGNOIPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x677A4D0", Offset = "0x67794D0", VA = "0x18677A4D0", Slot = "5")]
	public void FFCFLMEHMPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x677A2A0", Offset = "0x67792A0", VA = "0x18677A2A0", Slot = "6")]
	public void DMHBEBGHPIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x677A680", Offset = "0x6779680", VA = "0x18677A680")]
	private Task GLPGOBPAINE(OIDHNNKKOGG IEHPEJEDEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x677A2A0", Offset = "0x67792A0", VA = "0x18677A2A0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public IMHNDKNJBFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class OLKBOPCPBGC : GOOMPBDIADC
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	private class FNKFCNIACKI<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly MAFPGJFOFOP ACDIGKEICHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly string IPAJBJLLPIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly T BKJBKPCHJIH;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public T ADACBBLDADO
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x80F210", Offset = "0x80E210", VA = "0x18080F210")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x876690", Offset = "0x875690", VA = "0x180876690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3698860", Offset = "0x3697860", VA = "0x183698860")]
		public FNKFCNIACKI(MAFPGJFOFOP ACDIGKEICHE, string IPAJBJLLPIJ, T BKJBKPCHJIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x36985A0", Offset = "0x36975A0", VA = "0x1836985A0")]
		private void BEOJGFMJIBC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly MAFPGJFOFOP ACDIGKEICHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly FNKFCNIACKI<TimeSpan> ECFPGCDJKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly FNKFCNIACKI<TimeSpan> PBEBLBDKBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly FNKFCNIACKI<TimeSpan> AGKOCBJDDFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly FNKFCNIACKI<TimeSpan> FOLPELDDOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly FNKFCNIACKI<bool> NBEFJLGDPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly FNKFCNIACKI<bool> IDCEGNMDAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly FNKFCNIACKI<bool> EHKBKKGIKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly FNKFCNIACKI<int> OIMGDFOCHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly FNKFCNIACKI<bool> GOGJDOMHFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly FNKFCNIACKI<bool> MOHGHPLFGMF;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public TimeSpan BBHBELIIEMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6784E90", Offset = "0x6783E90", VA = "0x186784E90", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public TimeSpan OHNBJLLEGHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x6784E50", Offset = "0x6783E50", VA = "0x186784E50", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public TimeSpan FFKFMIBOEJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6784F90", Offset = "0x6783F90", VA = "0x186784F90", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public TimeSpan KFGKOGAKCJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6784F50", Offset = "0x6783F50", VA = "0x186784F50", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool LINKIJALAMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6784F10", Offset = "0x6783F10", VA = "0x186784F10", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool LJMFEJHFJKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6785010", Offset = "0x6784010", VA = "0x186785010", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool JAGKIFKOBIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x6784E10", Offset = "0x6783E10", VA = "0x186784E10", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public int MCGHFBMGDGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6784DD0", Offset = "0x6783DD0", VA = "0x186784DD0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool NEJIDENPJDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x6784ED0", Offset = "0x6783ED0", VA = "0x186784ED0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool PMJBKBNAFDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x6784FD0", Offset = "0x6783FD0", VA = "0x186784FD0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6785050", Offset = "0x6784050", VA = "0x186785050")]
	[UnityEngine.Scripting.Preserve]
	public OLKBOPCPBGC([CJCLEPGLAOP(null)] MAFPGJFOFOP ACDIGKEICHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[UnityEngine.Scripting.Preserve]
internal class JDCIBANFPCP : PAMBJPNFIFH, MBJMPCJKHOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class LJMJBFBEFPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public LMKKKLFJCGI roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public LJMJBFBEFPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x677D7E0", Offset = "0x677C7E0", VA = "0x18677D7E0")]
		internal object NNMPJPPBGFL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action AAFKDPDLLEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x677BC00", Offset = "0x677AC00", VA = "0x18677BC00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x677B9E0", Offset = "0x677A9E0", VA = "0x18677B9E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event KHNGPABAGGL NMNPAPMFDGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x677C0B0", Offset = "0x677B0B0", VA = "0x18677C0B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x677B690", Offset = "0x677A690", VA = "0x18677B690", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event KHNGPABAGGL FOEFGELDGHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x677C010", Offset = "0x677B010", VA = "0x18677C010", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x677BF70", Offset = "0x677AF70", VA = "0x18677BF70", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event KHNGPABAGGL HPEHEINOECG
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x677BEA0", Offset = "0x677AEA0", VA = "0x18677BEA0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x677BB30", Offset = "0x677AB30", VA = "0x18677BB30", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<BHNKCKABCCE, bool> LBBBJMMALNI
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x677BA80", Offset = "0x677AA80", VA = "0x18677BA80", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x677B730", Offset = "0x677A730", VA = "0x18677B730", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "19")]
	public void DPGLELIALOP(NKMCDKBACFE EFBGGNOIPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x677B7E0", Offset = "0x677A7E0", VA = "0x18677B7E0", Slot = "14")]
	public void ANNIJDNJAFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x677BBD0", Offset = "0x677ABD0", VA = "0x18677BBD0", Slot = "15")]
	public void GLJIIKEOCGG(LMKKKLFJCGI MJOEDHLNHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x677BCA0", Offset = "0x677ACA0", VA = "0x18677BCA0", Slot = "16")]
	public void LEFKOEHPHMI(LMKKKLFJCGI MJOEDHLNHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x677BF40", Offset = "0x677AF40", VA = "0x18677BF40", Slot = "17")]
	public void NDEBFIABAPP(LMKKKLFJCGI MJOEDHLNHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x677B640", Offset = "0x677A640", VA = "0x18677B640", Slot = "18")]
	public void AHEFJLECKHN(BHNKCKABCCE ECBICLOFOJH, bool LAFOEMFOPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x677BCD0", Offset = "0x677ACD0", VA = "0x18677BCD0")]
	private void MLJKNHMHONE(KHNGPABAGGL EPLHPIANHBK, LMKKKLFJCGI MJOEDHLNHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public JDCIBANFPCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[UnityEngine.Scripting.Preserve]
internal class AMCAFKBOAOB : LIMBIOPDAGN, MBJMPCJKHOM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct ENHAHKOPMMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AMCAFKBOAOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6771600", Offset = "0x6770600", VA = "0x186771600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x6771AE0", Offset = "0x6770AE0", VA = "0x186771AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct JLJFDLGCKEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public AMCAFKBOAOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x677C150", Offset = "0x677B150", VA = "0x18677C150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x677C7B0", Offset = "0x677B7B0", VA = "0x18677C7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class LFFHCBHKKNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public LFFHCBHKKNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x677D720", Offset = "0x677C720", VA = "0x18677D720")]
		internal object FMMMPHGCCAO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct BFMDPMNIOBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public AMCAFKBOAOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private LFFHCBHKKNG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x676A750", Offset = "0x6769750", VA = "0x18676A750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x676AEA0", Offset = "0x6769EA0", VA = "0x18676AEA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class CCIOKKOHFEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public CCIOKKOHFEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x676B8D0", Offset = "0x676A8D0", VA = "0x18676B8D0")]
		internal object CDPJGGBIMJA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly LPCGADPJIJD IJDHPGKKFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private NKMCDKBACFE EFBGGNOIPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private AJDCIPBGOJA HLIOAAOLCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private CABNJCCOLKE[] ANJCNANHCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private CancellationTokenSource COPLNLJNKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private int CMFMBHEEEOJ;

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6768C50", Offset = "0x6767C50", VA = "0x186768C50", Slot = "6")]
	public void DPGLELIALOP(NKMCDKBACFE EFBGGNOIPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6768CD0", Offset = "0x6767CD0", VA = "0x186768CD0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6768B50", Offset = "0x6767B50", VA = "0x186768B50", Slot = "8")]
	public void CGDBPHNIEPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6768A80", Offset = "0x6767A80", VA = "0x186768A80", Slot = "5")]
	public void AFMDMFJOJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6768CE0", Offset = "0x6767CE0", VA = "0x186768CE0", Slot = "4")]
	[AsyncStateMachine(typeof(ENHAHKOPMMK))]
	public Task GPNAIPHPBEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6769310", Offset = "0x6768310", VA = "0x186769310")]
	private void ODMDMDBDBPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6769620", Offset = "0x6768620", VA = "0x186769620")]
	[AsyncStateMachine(typeof(JLJFDLGCKEM))]
	private Task PLGFEEELCBJ(CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6768EE0", Offset = "0x6767EE0", VA = "0x186768EE0")]
	[AsyncStateMachine(typeof(BFMDPMNIOBB))]
	private Task<bool> JHNKGKAJDEB(int GCDIELAOHNA, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6769150", Offset = "0x6768150", VA = "0x186769150")]
	private void MIFKGLEFFCF(int GCDIELAOHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6769230", Offset = "0x6768230", VA = "0x186769230")]
	private void NEGGEOBBPIF(int GCDIELAOHNA, bool LAFOEMFOPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6768DB0", Offset = "0x6767DB0", VA = "0x186768DB0")]
	private void IKAGLDPEOPC(int GCDIELAOHNA, Exception NNMGILNOFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6769020", Offset = "0x6768020", VA = "0x186769020")]
	private void KOLBGHFJFJJ(CancellationToken JMJKFNJJBHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public AMCAFKBOAOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[RecRoom.NoEngine.Common.Preserve]
internal class GOLMBHDNGHH : AODABJGIPHL, MBJMPCJKHOM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct BPJDCGKOPLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public ICNKHIIJEIP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public GOLMBHDNGHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public PGPPIOEAPIJ customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x676AF10", Offset = "0x6769F10", VA = "0x18676AF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x676B870", Offset = "0x676A870", VA = "0x18676B870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct CFFMJJMAPBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public GOLMBHDNGHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public ICNKHIIJEIP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public PGPPIOEAPIJ customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private MFEMJMGOOCM<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private MAPKHCDKFJB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private DDJAKAGJABA <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private GPGOBGEANDA <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x676C030", Offset = "0x676B030", VA = "0x18676C030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x676CBF0", Offset = "0x676BBF0", VA = "0x18676CBF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class NNIECIJDLNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public Matchmaking.IFLBHAAICPA result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public DLCJNONDADN errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public NNIECIJDLNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x6783E50", Offset = "0x6782E50", VA = "0x186783E50")]
		internal object NEGHLDIANCH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class GOGLOALDHGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public Task<EGDMKLHIGGO> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public GOGLOALDHGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450")]
		internal Task<EGDMKLHIGGO> HBEAIAEOLFG(MFEMJMGOOCM<string>.ENJHCLDNEDD _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct NKBAAFJIPEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public GOLMBHDNGHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public ICNKHIIJEIP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public PGPPIOEAPIJ customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public DDJAKAGJABA joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private GOGLOALDHGL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private LGECKPAHDHD <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private MAPKHCDKFJB <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private DNGNPLIDLFJ <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private Task<Matchmaking.ADJLFKMAKIP> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private NFIEOGBLLMB <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private int <i>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private TaskAwaiter<Matchmaking.ADJLFKMAKIP> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private TaskAwaiter<EGDMKLHIGGO> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x677EC30", Offset = "0x677DC30", VA = "0x18677EC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x6783DF0", Offset = "0x6782DF0", VA = "0x186783DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct LPEDFKMMOIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public GOLMBHDNGHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x677D930", Offset = "0x677C930", VA = "0x18677D930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x677E380", Offset = "0x677D380", VA = "0x18677E380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct IAKEBNOGCMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public GOLMBHDNGHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private ONGJLMJLNJA <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x67798E0", Offset = "0x67788E0", VA = "0x1867798E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6779D60", Offset = "0x6778D60", VA = "0x186779D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct EJGFDLPEKOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public AsyncTaskMethodBuilder<Matchmaking.ADJLFKMAKIP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public ICNKHIIJEIP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public GOLMBHDNGHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private TaskAwaiter<Matchmaking.ADJLFKMAKIP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6771090", Offset = "0x6770090", VA = "0x186771090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6771590", Offset = "0x6770590", VA = "0x186771590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct CNEPFMNEBKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Matchmaking.ADJLFKMAKIP serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public GOLMBHDNGHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public DDJAKAGJABA joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TaskAwaiter<FJKOJJLBLPK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x676D880", Offset = "0x676C880", VA = "0x18676D880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x676DF80", Offset = "0x676CF80", VA = "0x18676DF80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class ICPCDKPEPII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public ICNKHIIJEIP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public ICPCDKPEPII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6779EF0", Offset = "0x6778EF0", VA = "0x186779EF0")]
		internal object NOPIIBANCOC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6779DF0", Offset = "0x6778DF0", VA = "0x186779DF0")]
		internal string LCPEIJGFGGC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct CMFJPCCDDNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public ICNKHIIJEIP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public GOLMBHDNGHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private ICPCDKPEPII <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x676CC50", Offset = "0x676BC50", VA = "0x18676CC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x676D820", Offset = "0x676C820", VA = "0x18676D820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct PIFHDLAEDFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public GOLMBHDNGHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public DDJAKAGJABA joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public EGDMKLHIGGO initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public ICNKHIIJEIP targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public LGECKPAHDHD progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x6785DA0", Offset = "0x6784DA0", VA = "0x186785DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x67866B0", Offset = "0x67856B0", VA = "0x1867866B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct FOMBNLGDJLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public GOLMBHDNGHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private MAPKHCDKFJB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private CancellationTokenSource <timeoutTcs>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private CancellationToken <timeoutToken>5__7;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x67728B0", Offset = "0x67718B0", VA = "0x1867728B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6773EF0", Offset = "0x6772EF0", VA = "0x186773EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct FIAGODNPMJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public PHJGIMFDNFB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public GOLMBHDNGHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private TaskAwaiter<LGMMDMPNFIF> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6772090", Offset = "0x6771090", VA = "0x186772090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6772850", Offset = "0x6771850", VA = "0x186772850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class DJPHHNJMLCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public ICNKHIIJEIP targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public DJPHHNJMLCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x676E970", Offset = "0x676D970", VA = "0x18676E970")]
		internal object AKCBIIPCGNE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class PMFBCKHCBHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public PMFBCKHCBHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6786710", Offset = "0x6785710", VA = "0x186786710")]
		internal void BHHPOFJPIKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class GEOAFHAKFKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public ICNKHIIJEIP targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public GEOAFHAKFKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6773F50", Offset = "0x6772F50", VA = "0x186773F50")]
		internal object POOJAAPEPOC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class AJPJPAANFEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public ICNKHIIJEIP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public AJPJPAANFEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6768600", Offset = "0x6767600", VA = "0x186768600")]
		internal string IOJMFONKBPD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly LPCGADPJIJD IJDHPGKKFNN;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly LPCGADPJIJD AJGIEKNHKAA;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly LPCGADPJIJD KBEFELPGMDM;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly LPCGADPJIJD CGCGMLHEGAI;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly string AGEBJIBOBPM;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly string FNDPJHMLCGP;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly string MNAIFDBBHFE;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static readonly Guid OPEFOBPCFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private MGPMMGPNEHM CNCONLPHCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private AMKDODFOFNJ MADAMCGNEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private CEMECMCIGML MPJONFIJKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private NKMCDKBACFE EFBGGNOIPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private AJDCIPBGOJA HLIOAAOLCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private LIMBIOPDAGN NIMKPAMNFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private NEGNOCONCHH FCGNBGJGKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private PAMBJPNFIFH HNGAAMFJMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private CNCBPABFNGK MOEGNBOLLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private LLEGBCNMAEO MEKEALILPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private IDisposable DLALHBAONAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly ABJADLEEAMP IMKIMKJCJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly ABJADLEEAMP LACGICFLMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NFIEOGBLLMB IGADOICPGGL;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public TaskStatus ACPMDGHGNDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x883330", Offset = "0x882330", VA = "0x180883330", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xB315C0", Offset = "0xB305C0", VA = "0x180B315C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private PPCOIJKJGJJ NCIAKAPEEMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x6774F00", Offset = "0x6773F00", VA = "0x186774F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6775480", Offset = "0x6774480", VA = "0x186775480", Slot = "6")]
	public void DPGLELIALOP(NKMCDKBACFE EFBGGNOIPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x6775940", Offset = "0x6774940", VA = "0x186775940", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x67762C0", Offset = "0x67752C0", VA = "0x1867762C0", Slot = "5")]
	[AsyncStateMachine(typeof(BPJDCGKOPLD))]
	public Task GLKJLOFAHNI(ICNKHIIJEIP EBFOGOFHMKC, PGPPIOEAPIJ NDAKDPLBEHJ, CancellationToken JOEEALIOINJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x6775DD0", Offset = "0x6774DD0", VA = "0x186775DD0")]
	[AsyncStateMachine(typeof(CFFMJJMAPBG))]
	private Task GFPNELINENG(ICNKHIIJEIP EBFOGOFHMKC, PGPPIOEAPIJ NDAKDPLBEHJ, CancellationToken JOEEALIOINJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x6774660", Offset = "0x6773660", VA = "0x186774660")]
	private static void BKAEJEHBEEO(CNCBPABFNGK MOEGNBOLLHF, ICNKHIIJEIP EBFOGOFHMKC, Exception NNMGILNOFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x6776C40", Offset = "0x6775C40", VA = "0x186776C40")]
	private static void ODBBNLCOILA(GPGOBGEANDA EHOCIKHGPPE, Exception NNMGILNOFJH, [Optional] List<int> OCPFEGCFBDJ, int CMFMBHEEEOJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x6776A50", Offset = "0x6775A50", VA = "0x186776A50")]
	[AsyncStateMachine(typeof(NKBAAFJIPEF))]
	private Task NAADOKGICCM(MFEMJMGOOCM<string>.ENJHCLDNEDD HKNHNBDNOFH, ICNKHIIJEIP EBFOGOFHMKC, PGPPIOEAPIJ NDAKDPLBEHJ, DDJAKAGJABA EPBOAPEOJLD, CancellationToken JOEEALIOINJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x67766C0", Offset = "0x67756C0", VA = "0x1867766C0")]
	private void IJMBAKMDDLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6776500", Offset = "0x6775500", VA = "0x186776500")]
	[AsyncStateMachine(typeof(LPEDFKMMOIF))]
	private Task HAMPDBDBHLB(MFEMJMGOOCM<string>.ENJHCLDNEDD HKNHNBDNOFH, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6774A20", Offset = "0x6773A20", VA = "0x186774A20")]
	private void CDCPCPFHEKI(ICNKHIIJEIP EBFOGOFHMKC, CancellationToken JOEEALIOINJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6775090", Offset = "0x6774090", VA = "0x186775090")]
	private void DGGGNNAHJMP(ICNKHIIJEIP EBFOGOFHMKC, DDJAKAGJABA EPBOAPEOJLD, OperationCanceledException DPLGIIHGJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x67774D0", Offset = "0x67764D0", VA = "0x1867774D0")]
	private void OKOLNFJBGAP(ICNKHIIJEIP EBFOGOFHMKC, DDJAKAGJABA EPBOAPEOJLD, Exception NNMGILNOFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6777700", Offset = "0x6776700", VA = "0x186777700")]
	private void OLMNBCKEMHE(ICNKHIIJEIP EBFOGOFHMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6775F20", Offset = "0x6774F20", VA = "0x186775F20")]
	private static LMKKKLFJCGI GGIPDHFKKDO(ICNKHIIJEIP EBFOGOFHMKC)
	{
		return default(LMKKKLFJCGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6776810", Offset = "0x6775810", VA = "0x186776810")]
	[AsyncStateMachine(typeof(IAKEBNOGCMJ))]
	private Task JBNHPCGPHMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x6777A30", Offset = "0x6776A30", VA = "0x186777A30")]
	[AsyncStateMachine(typeof(EJGFDLPEKOP))]
	private Task<Matchmaking.ADJLFKMAKIP> PBLAHMDBBPJ(ICNKHIIJEIP EBFOGOFHMKC, MFEMJMGOOCM<string>.ENJHCLDNEDD HKNHNBDNOFH, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x67768E0", Offset = "0x67758E0", VA = "0x1867768E0")]
	private static FJKOJJLBLPK KFGOBBFNKHH(Matchmaking.ADJLFKMAKIP MMINHKJEMJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6774DB0", Offset = "0x6773DB0", VA = "0x186774DB0")]
	[AsyncStateMachine(typeof(CNEPFMNEBKK))]
	private Task CLCNJOGJHFG(Matchmaking.ADJLFKMAKIP MMINHKJEMJG, DDJAKAGJABA EPBOAPEOJLD, MFEMJMGOOCM<string>.ENJHCLDNEDD HKNHNBDNOFH, CancellationToken CANFCPFBFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6774F50", Offset = "0x6773F50", VA = "0x186774F50")]
	[AsyncStateMachine(typeof(CMFJPCCDDNL))]
	private Task DDDNJAOHLKF(ICNKHIIJEIP EBFOGOFHMKC, CancellationTokenSource PFHENPMANGD, Task MCAEJGBJDPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6775F80", Offset = "0x6774F80", VA = "0x186775F80")]
	[AsyncStateMachine(typeof(PIFHDLAEDFO))]
	private Task GKMMNNMGFMC(EGDMKLHIGGO KCKIGPKIIIE, LGECKPAHDHD NKKIJLNAOBC, ICNKHIIJEIP JKANDNJOODL, DDJAKAGJABA NGMBKDNKCIJ, MFEMJMGOOCM<string>.ENJHCLDNEDD HKNHNBDNOFH, CancellationToken HOEIJNPKKHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6774470", Offset = "0x6773470", VA = "0x186774470")]
	private DDJAKAGJABA AIDOOCKDKBG(DDJAKAGJABA NGMBKDNKCIJ, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x67752C0", Offset = "0x67742C0", VA = "0x1867752C0")]
	[AsyncStateMachine(typeof(FOMBNLGDJLG))]
	private Task DHBNKBIIGPB(MFEMJMGOOCM<string>.ENJHCLDNEDD HKNHNBDNOFH, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6777910", Offset = "0x6776910", VA = "0x186777910")]
	[AsyncStateMachine(typeof(FIAGODNPMJF))]
	private Task PBDADCEDGOG(PHJGIMFDNFB ELANMAGHLLI, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6775B40", Offset = "0x6774B40", VA = "0x186775B40")]
	private static void EMFDHIPEJAO(ICNKHIIJEIP EBFOGOFHMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x67760F0", Offset = "0x67750F0", VA = "0x1867760F0")]
	private void GLCAEFKGMLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x67753F0", Offset = "0x67743F0", VA = "0x1867753F0")]
	private void DLOHIFBGGCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6776BB0", Offset = "0x6775BB0", VA = "0x186776BB0")]
	private void NEPAHHGBBIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6776630", Offset = "0x6775630", VA = "0x186776630")]
	private void HFHBPHEKEHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6774380", Offset = "0x6773380", VA = "0x186774380")]
	private static void AEKBEPPEDGO(ICNKHIIJEIP EBFOGOFHMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6775CC0", Offset = "0x6774CC0", VA = "0x186775CC0")]
	private static CancellationTokenRegistration FADFOJAHMHD(ICNKHIIJEIP EBFOGOFHMKC, CancellationToken CANFCPFBFKH)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6776400", Offset = "0x6775400", VA = "0x186776400")]
	private static void GOKJMLBJKAI(ICNKHIIJEIP EBFOGOFHMKC, Exception NNMGILNOFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6775990", Offset = "0x6774990", VA = "0x186775990")]
	private void EEOCKIAKOPA(ICNKHIIJEIP EBFOGOFHMKC, Task MCAEJGBJDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x67769F0", Offset = "0x67759F0", VA = "0x1867769F0")]
	private static void LFPFJBDDFDP(Func<string> ONOCGJKGBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6777DB0", Offset = "0x6776DB0", VA = "0x186777DB0")]
	public GOLMBHDNGHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6774D50", Offset = "0x6773D50", VA = "0x186774D50")]
	[CompilerGenerated]
	internal static (int, int?) CFINOPNJJEF(DLCJNONDADN ILDJAPLNIMH)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[RecRoom.NoEngine.Common.Preserve]
internal class EJFCBGEGJAO : GKALEEFJBFC, MBJMPCJKHOM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct BAKIFCMPCGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public EJFCBGEGJAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public PHJGIMFDNFB roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6788CF0", Offset = "0x6787CF0", VA = "0x186788CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x67890B0", Offset = "0x67880B0", VA = "0x1867890B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class LCOEBBDJMAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public EJFCBGEGJAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public PHJGIMFDNFB roomData;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public LCOEBBDJMAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x679B830", Offset = "0x679A830", VA = "0x18679B830")]
		internal List<Task> PENIGNHPBIM(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct GJKMAKCCCGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public JMCKEGHPMPH taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public PHJGIMFDNFB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x6790B70", Offset = "0x678FB70", VA = "0x186790B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x6790F00", Offset = "0x678FF00", VA = "0x186790F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct MBKCPDMOMOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public EJFCBGEGJAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x679CB80", Offset = "0x679BB80", VA = "0x18679CB80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x679CE40", Offset = "0x679BE40", VA = "0x18679CE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private readonly HashSet<JMCKEGHPMPH> DBCLEJGPOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private AMKDODFOFNJ MADAMCGNEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private NKMCDKBACFE EFBGGNOIPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private NIANCEDPPNI GFHKFGJDCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private MLFEDJHCLAG MBPNGIKPOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private IDisposable DLALHBAONAD;

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x67704A0", Offset = "0x676F4A0", VA = "0x1867704A0", Slot = "5")]
	public void DPGLELIALOP(NKMCDKBACFE EFBGGNOIPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x6770720", Offset = "0x676F720", VA = "0x186770720", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x6770780", Offset = "0x676F780", VA = "0x186770780", Slot = "4")]
	public bool EOBBBKCDKHM(JMCKEGHPMPH JOGFIEECFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x67702A0", Offset = "0x676F2A0", VA = "0x1867702A0")]
	private void DBEGLCDMKNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6770900", Offset = "0x676F900", VA = "0x186770900")]
	private void LFNIGJNKGIA(PHJGIMFDNFB PCNPJGFONNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6770130", Offset = "0x676F130", VA = "0x186770130")]
	[AsyncStateMachine(typeof(BAKIFCMPCGE))]
	private Task AOMNHCKLACG(PHJGIMFDNFB PCNPJGFONNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x67703D0", Offset = "0x676F3D0", VA = "0x1867703D0")]
	private Func<CancellationToken, List<Task>> DKPCFAEPDGN(PHJGIMFDNFB PCNPJGFONNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6770BB0", Offset = "0x676FBB0", VA = "0x186770BB0")]
	private List<Task> NDNACBCDGNM(PHJGIMFDNFB PCNPJGFONNP, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x67707E0", Offset = "0x676F7E0", VA = "0x1867707E0")]
	[AsyncStateMachine(typeof(GJKMAKCCCGL))]
	private Task JIHCCGAPHOA(JMCKEGHPMPH JFGBEMDJAJO, PHJGIMFDNFB ELANMAGHLLI, CancellationToken OGACLNNOKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6770AE0", Offset = "0x676FAE0", VA = "0x186770AE0")]
	[AsyncStateMachine(typeof(MBKCPDMOMOJ))]
	private Task MGMDMFDNBCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6770220", Offset = "0x676F220", VA = "0x186770220")]
	private void CGDBPHNIEPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x6771000", Offset = "0x6770000", VA = "0x186771000")]
	public EJFCBGEGJAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[UnityEngine.Scripting.Preserve]
internal sealed class OCEDCCBNFIO : GINGLICLBDA, MBJMPCJKHOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class HDHMEAKNNLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public HDHMEAKNNLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x6791160", Offset = "0x6790160", VA = "0x186791160")]
		internal object MDNJDMONGBF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class KGMCFFKGPME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public KGMCFFKGPME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6797CE0", Offset = "0x6796CE0", VA = "0x186797CE0")]
		internal object DHLFKAENOMN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class DCJDOMACKFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public DCJDOMACKFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class EEEFNJJOHDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public EEEFNJJOHDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x678E950", Offset = "0x678D950", VA = "0x18678E950")]
		internal object KAINMIMBEOL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class LFAABPCKJPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public LFAABPCKJPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x679BD80", Offset = "0x679AD80", VA = "0x18679BD80")]
		internal object FJCHPBHMPGB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private readonly Dictionary<Guid, FGLPDPHHHMN> KNLDJIGFFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly TimeSpan IMJOPOOCGAF;

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "9")]
	public void DPGLELIALOP(NKMCDKBACFE EFBGGNOIPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x67A1970", Offset = "0x67A0970", VA = "0x1867A1970", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x67A1980", Offset = "0x67A0980", VA = "0x1867A1980", Slot = "4")]
	public INLCMPBBLBB EMJMPPLJJNE(Guid FCBFKEBMKED)
	{
		return default(INLCMPBBLBB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x67A1D80", Offset = "0x67A0D80", VA = "0x1867A1D80", Slot = "5")]
	public bool JOBFLKKFIPF(Guid FCBFKEBMKED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x67A1640", Offset = "0x67A0640", VA = "0x1867A1640", Slot = "6")]
	public bool CKOBKLDIPNC(Guid FCBFKEBMKED, Task LPDOPAGNNDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x67A1BA0", Offset = "0x67A0BA0", VA = "0x1867A1BA0", Slot = "7")]
	public bool JLFPPKIJHBA(Guid FCBFKEBMKED, LGMMDMPNFIF AJJPEOADJPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x67A15D0", Offset = "0x67A05D0", VA = "0x1867A15D0", Slot = "8")]
	public Task<(LGMMDMPNFIF, Task)> CBBHGCGGLOM(Guid FCBFKEBMKED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x67A1F90", Offset = "0x67A0F90", VA = "0x1867A1F90")]
	private void MNGIMALKAHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x67A21C0", Offset = "0x67A11C0", VA = "0x1867A21C0")]
	public OCEDCCBNFIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[RecRoom.NoEngine.Common.Preserve]
internal class HFGACLOGOLP : DGOLAKENKMI, MBJMPCJKHOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private class IAJIKJFEHPK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private readonly ICNKHIIJEIP LGMKBABLLLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private readonly CancellationTokenSource COPLNLJNKII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public readonly CancellationToken NGDGLKKPIHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private bool MJIPJLOOEHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private bool HBKBODDFLFH;

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x6793D80", Offset = "0x6792D80", VA = "0x186793D80")]
		public IAJIKJFEHPK(ICNKHIIJEIP LGMKBABLLLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x6793C00", Offset = "0x6792C00", VA = "0x186793C00")]
		public void CGDBPHNIEPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x6793D50", Offset = "0x6792D50", VA = "0x186793D50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class EEBMKPBJJOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public OIDHNNKKOGG disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public EEBMKPBJJOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x678E8C0", Offset = "0x678D8C0", VA = "0x18678E8C0")]
		internal object IJHIPNFOPEG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct EHDEAEHNBDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public OIDHNNKKOGG disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public HFGACLOGOLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x678EA30", Offset = "0x678DA30", VA = "0x18678EA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x678EDE0", Offset = "0x678DDE0", VA = "0x18678EDE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class DODNKOCIGPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public DODNKOCIGPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x678C720", Offset = "0x678B720", VA = "0x18678C720")]
		internal object MEIDAJOPKNM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct DPLCJJJPHAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public HFGACLOGOLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private MAPKHCDKFJB <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x678C8D0", Offset = "0x678B8D0", VA = "0x18678C8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x892030", Offset = "0x891030", VA = "0x180892030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class AODNLNDAJPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public ICNKHIIJEIP newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public AODNLNDAJPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x6788C10", Offset = "0x6787C10", VA = "0x186788C10")]
		internal object FGPKAGIDILN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x6788CB0", Offset = "0x6787CB0", VA = "0x186788CB0")]
		internal object NCMEIIABFKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x6788BD0", Offset = "0x6787BD0", VA = "0x186788BD0")]
		internal object AJJPDMADEOC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class NEBDLEIEKMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public NEBDLEIEKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x679ECF0", Offset = "0x679DCF0", VA = "0x18679ECF0")]
		internal void KKAGIGDCKNP()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private struct CJFOFBHCEOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public ICNKHIIJEIP newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public HFGACLOGOLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public PGPPIOEAPIJ customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private AODNLNDAJPB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x6789F20", Offset = "0x6788F20", VA = "0x186789F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x678AEA0", Offset = "0x6789EA0", VA = "0x18678AEA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static readonly LPCGADPJIJD IJDHPGKKFNN;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly ABKGOKCOHEC.KLOGHFBDNCJ JHNMKODMDIB;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly AHDMNBDNGKC EKLHELFKIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private AMKDODFOFNJ MADAMCGNEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private NKMCDKBACFE EFBGGNOIPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private LIMBIOPDAGN NIMKPAMNFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private AJDCIPBGOJA HLIOAAOLCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private GOOMPBDIADC DJEDGNFIGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private AODABJGIPHL GOFNADGNMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private long MDDFLGMBDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private IAJIKJFEHPK GJBOECKBIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private bool CDKCPIPKJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private Task CAIMJHOEHDD;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private PPCOIJKJGJJ NCIAKAPEEMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x67911C0", Offset = "0x67901C0", VA = "0x1867911C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool PFOHLMGEEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xD72080", Offset = "0xD71080", VA = "0x180D72080")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x67921A0", Offset = "0x67911A0", VA = "0x1867921A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x67914A0", Offset = "0x67904A0", VA = "0x1867914A0", Slot = "4")]
	public void DPGLELIALOP(NKMCDKBACFE EFBGGNOIPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x67919E0", Offset = "0x67909E0", VA = "0x1867919E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x67920B0", Offset = "0x67910B0", VA = "0x1867920B0")]
	[AsyncStateMachine(typeof(EHDEAEHNBDH))]
	private Task OPFNDJLHLOG(OIDHNNKKOGG DMOLHLKBIOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6791840", Offset = "0x6790840", VA = "0x186791840")]
	private void DPLMKNNEEKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6791ED0", Offset = "0x6790ED0", VA = "0x186791ED0")]
	private void MGGKLFBEDML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6791B50", Offset = "0x6790B50", VA = "0x186791B50")]
	private void FAIOAJNFFJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x67921B0", Offset = "0x67911B0", VA = "0x1867921B0")]
	private bool PPPEOJBPHGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6791E00", Offset = "0x6790E00", VA = "0x186791E00")]
	[AsyncStateMachine(typeof(DPLCJJJPHAG))]
	private void LIPEDIPMFGN(int PFILPIPAOOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6791210", Offset = "0x6790210", VA = "0x186791210")]
	private void CPMNBOKGAEE([Out] IDisposable OGAIOLEHFPF, [Out] IDisposable HNKFGLHKDDF, [Out] IDisposable MIGAEOOOHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6791740", Offset = "0x6790740", VA = "0x186791740")]
	private bool DPHOGOHGDJH(ICNKHIIJEIP LGMKBABLLLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6792060", Offset = "0x6791060", VA = "0x186792060")]
	private void OCCGOIOAOPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x6791CD0", Offset = "0x6790CD0", VA = "0x186791CD0")]
	[AsyncStateMachine(typeof(CJFOFBHCEOP))]
	private Task GFPNELINENG(ICNKHIIJEIP LGMKBABLLLM, PGPPIOEAPIJ NDAKDPLBEHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x67925F0", Offset = "0x67915F0", VA = "0x1867925F0")]
	public HFGACLOGOLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[UnityEngine.Scripting.Preserve]
internal sealed class PLDFBBBBLMP : GGBNEKLADMG, MBJMPCJKHOM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private struct ICJBALMLADG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public AsyncTaskMethodBuilder<DDMMJNHFCED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public PLDFBBBBLMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private TaskAwaiter<DDMMJNHFCED> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x67945B0", Offset = "0x67935B0", VA = "0x1867945B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x6794840", Offset = "0x6793840", VA = "0x186794840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class LPJJEKGDHMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public JLMLKKANJKN message;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public LPJJEKGDHMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x679C310", Offset = "0x679B310", VA = "0x18679C310")]
		internal object NDDCOGDKLHG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class FFBNJIDFLME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public JLMLKKANJKN messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public FFBNJIDFLME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x678FC60", Offset = "0x678EC60", VA = "0x18678FC60")]
		internal object DDMIGNCBBCF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class POEAFBLOEDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public JLMLKKANJKN request;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public POEAFBLOEDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x67A5620", Offset = "0x67A4620", VA = "0x1867A5620")]
		internal object HAHLMALFKJD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct JKFLODLOODI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public JLMLKKANJKN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public PLDFBBBBLMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private TaskAwaiter<CAMAINJFJEE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x6796110", Offset = "0x6795110", VA = "0x186796110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x67969D0", Offset = "0x67959D0", VA = "0x1867969D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class MAGKCCLLGIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public JLMLKKANJKN operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public MAGKCCLLGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x679C370", Offset = "0x679B370", VA = "0x18679C370")]
		internal object CGMJDLCCNDD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct POLDFKEKFMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public JLMLKKANJKN operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public PLDFBBBBLMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private DDJAKAGJABA <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private TaskAwaiter<JLMLKKANJKN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x67A5680", Offset = "0x67A4680", VA = "0x1867A5680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x67A61F0", Offset = "0x67A51F0", VA = "0x1867A61F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct BNIFPDFNBBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public AsyncTaskMethodBuilder<CAMAINJFJEE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public PLDFBBBBLMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public JLMLKKANJKN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private AOMJCCCAOCF.OGKHDBPIKBB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private DDJAKAGJABA <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private TaskAwaiter<JLMLKKANJKN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x6789990", Offset = "0x6788990", VA = "0x186789990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6789EB0", Offset = "0x6788EB0", VA = "0x186789EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class EGIMPDAHHMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public CAMAINJFJEE operation;

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public EGIMPDAHHMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x678E9B0", Offset = "0x678D9B0", VA = "0x18678E9B0")]
		internal object BLHFAMCMBPH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private struct MBIGNMCGDPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public CAMAINJFJEE operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public PLDFBBBBLMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private MFEMJMGOOCM<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x679C3D0", Offset = "0x679B3D0", VA = "0x18679C3D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x679CA10", Offset = "0x679BA10", VA = "0x18679CA10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class NGNEIHIMAJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public JLMLKKANJKN request;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public NGNEIHIMAJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x679ED90", Offset = "0x679DD90", VA = "0x18679ED90")]
		internal object JLANHMEAGMB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class LHEGFGJNLMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public JLMLKKANJKN request;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public LHEGFGJNLMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x679BDE0", Offset = "0x679ADE0", VA = "0x18679BDE0")]
		internal object CNNNHFECEGE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private NKMCDKBACFE EFBGGNOIPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private NEGNOCONCHH FCGNBGJGKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private HFAHGLIBNAP DPLBEKEDHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private GDDHGAEFLGK DMMBODIODOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private CEMECMCIGML MPJONFIJKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private TaskCompletionSource<DDMMJNHFCED> FEGOAHIGJAF;

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x67A49F0", Offset = "0x67A39F0", VA = "0x1867A49F0", Slot = "7")]
	public void DPGLELIALOP(NKMCDKBACFE EFBGGNOIPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x67A4D40", Offset = "0x67A3D40", VA = "0x1867A4D40", Slot = "6")]
	[AsyncStateMachine(typeof(ICJBALMLADG))]
	public Task<DDMMJNHFCED> IKAGKMAAKPN(CancellationToken PPMFKGKHOBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x67A4300", Offset = "0x67A3300", VA = "0x1867A4300", Slot = "4")]
	public void ANKLJNHELFA(JLMLKKANJKN DFJKCKBFLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x67A4690", Offset = "0x67A3690", VA = "0x1867A4690", Slot = "5")]
	public void DDGPMCKOLIK(JLMLKKANJKN IDLJALBOKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x67A4C30", Offset = "0x67A3C30", VA = "0x1867A4C30")]
	[AsyncStateMachine(typeof(JKFLODLOODI))]
	private Task HKJDNBKHBKI(JLMLKKANJKN LFFEKPPMJHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x67A5510", Offset = "0x67A4510", VA = "0x1867A5510")]
	[AsyncStateMachine(typeof(POLDFKEKFMO))]
	private Task OPDHFDEAHOA(JLMLKKANJKN HOFJMEMLFHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x67A4AE0", Offset = "0x67A3AE0", VA = "0x1867A4AE0")]
	[AsyncStateMachine(typeof(BNIFPDFNBBD))]
	private Task<CAMAINJFJEE> EJEKAKIIHOL(JLMLKKANJKN LFFEKPPMJHN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x67A4270", Offset = "0x67A3270", VA = "0x1867A4270")]
	private DDJAKAGJABA AGEAGLHPDGG(JLMLKKANJKN EPLNAPFIBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x67A53F0", Offset = "0x67A43F0", VA = "0x1867A53F0")]
	[AsyncStateMachine(typeof(MBIGNMCGDPG))]
	private Task OFCKJPCHOAH(CAMAINJFJEE ODMOFOFBMIL, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x67A51E0", Offset = "0x67A41E0", VA = "0x1867A51E0")]
	private CAMAINJFJEE NNENDECPEED(JLMLKKANJKN LFFEKPPMJHN, DDJAKAGJABA JPIHEEKHHBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x2933BE0", Offset = "0x2932BE0", VA = "0x182933BE0")]
	private T KNNBFFCDMLN<T>(T CFJDHAGGAJO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x67A4E50", Offset = "0x67A3E50", VA = "0x1867A4E50")]
	private CAMAINJFJEE JHMDIBONDBI(JLMLKKANJKN LFFEKPPMJHN, DDJAKAGJABA JPIHEEKHHBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public PLDFBBBBLMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[UnityEngine.Scripting.Preserve]
internal sealed class KPLOPKPPAOG : HFAHGLIBNAP, MBJMPCJKHOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class NAFHJHIFKOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public NAFHJHIFKOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x679E650", Offset = "0x679D650", VA = "0x18679E650")]
		internal object NODMHABIPIE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class ODJPOHGFMPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public ODJPOHGFMPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x67A2280", Offset = "0x67A1280", VA = "0x1867A2280")]
		internal object HEHPKDEBAEJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private CEMECMCIGML MPJONFIJKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private BFIIGPKHFJG DDPPPIJNHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private GGBNEKLADMG BPMIHMDKHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private GINGLICLBDA KNLDJIGFFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private DGNBFIJCHGK FCJNPNIPEMI;

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6799710", Offset = "0x6798710", VA = "0x186799710", Slot = "6")]
	public void DPGLELIALOP(NKMCDKBACFE EFBGGNOIPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6799880", Offset = "0x6798880", VA = "0x186799880", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x679A680", Offset = "0x6799680", VA = "0x18679A680", Slot = "4")]
	public INLCMPBBLBB MEKMHEJIEIA(JLMLKKANJKN LFDHGIAKOKC)
	{
		return default(INLCMPBBLBB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x679ADD0", Offset = "0x6799DD0", VA = "0x18679ADD0", Slot = "5")]
	public void OKBOFLENDPB(Guid FCBFKEBMKED, Task LPDOPAGNNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6799930", Offset = "0x6798930", VA = "0x186799930")]
	private void EBFACOPPOIB(byte DPGGHMFJGPD, int MCANCGADKBN, object BGAIACKDGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x679A0E0", Offset = "0x67990E0", VA = "0x18679A0E0")]
	private void LGBNHKKHFGN(DHCNKDPBEDM KGGAPJLLPNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x679AAC0", Offset = "0x6799AC0", VA = "0x18679AAC0")]
	private void OHMJCODKLHM(DHCNKDPBEDM KGGAPJLLPNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x67994D0", Offset = "0x67984D0", VA = "0x1867994D0")]
	private void BDICKDKILGK(DHCNKDPBEDM KGGAPJLLPNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x6799A00", Offset = "0x6798A00", VA = "0x186799A00")]
	private LGMMDMPNFIF FDIDMHPDFOD(JLMLKKANJKN EPLNAPFIBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x6799C40", Offset = "0x6798C40", VA = "0x186799C40")]
	private void HCNAGJNJFJL(JLMLKKANJKN HOFJMEMLFHF, LGMMDMPNFIF AJJPEOADJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x6799220", Offset = "0x6798220", VA = "0x186799220")]
	private bool AIFCBOAKMJA(JLMLKKANJKN HOFJMEMLFHF, LGMMDMPNFIF AJJPEOADJPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x679AFE0", Offset = "0x6799FE0", VA = "0x18679AFE0")]
	private bool PMOJPEEPFOH(JLMLKKANJKN MPBHEOEMJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6799E50", Offset = "0x6798E50", VA = "0x186799E50")]
	private bool IHMCKADBLCK(byte DPGGHMFJGPD, ExitGames.Client.Photon.Hashtable KGGAPJLLPNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public KPLOPKPPAOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[UnityEngine.Scripting.Preserve]
internal sealed class JBIEIKPECFJ : EGGHGCCGEJB, MBJMPCJKHOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class DBHNMHDKAOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public DDMMJNHFCED operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public JBIEIKPECFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public JLMLKKANJKN roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public DBHNMHDKAOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x678B710", Offset = "0x678A710", VA = "0x18678B710")]
		internal object CHILNKMOJLC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x678B780", Offset = "0x678A780", VA = "0x18678B780")]
		internal object HNLPAILEFKN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct CLLLPGKAMDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder<LGMMDMPNFIF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public JBIEIKPECFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public JLMLKKANJKN roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private TaskAwaiter<LGMMDMPNFIF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x678AF00", Offset = "0x6789F00", VA = "0x18678AF00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x678B590", Offset = "0x678A590", VA = "0x18678B590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class HHONMEOBLGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public DDMMJNHFCED operationType;

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public HHONMEOBLGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x67929B0", Offset = "0x67919B0", VA = "0x1867929B0")]
		internal object BGMAFPNELKJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class FHJOKHIMEMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public JLMLKKANJKN request;

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public FHJOKHIMEMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x678FCC0", Offset = "0x678ECC0", VA = "0x18678FCC0")]
		internal object DBIIMMNGOKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x678FDA0", Offset = "0x678EDA0", VA = "0x18678FDA0")]
		internal object KKPFJJJABDD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x678FD30", Offset = "0x678ED30", VA = "0x18678FD30")]
		internal object GALCAPOPHOL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct PHCGEPMLCIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public AsyncTaskMethodBuilder<LGMMDMPNFIF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public JLMLKKANJKN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public JBIEIKPECFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private FHJOKHIMEMK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private INLCMPBBLBB <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private LGMMDMPNFIF <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private TaskAwaiter<(LGMMDMPNFIF validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x67A32E0", Offset = "0x67A22E0", VA = "0x1867A32E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x67A3B90", Offset = "0x67A2B90", VA = "0x1867A3B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private CEMECMCIGML MPJONFIJKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private BFIIGPKHFJG DDPPPIJNHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private HFAHGLIBNAP DPLBEKEDHIG;

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x6794C10", Offset = "0x6793C10", VA = "0x186794C10", Slot = "5")]
	public void DPGLELIALOP(NKMCDKBACFE EFBGGNOIPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x6794CC0", Offset = "0x6793CC0", VA = "0x186794CC0", Slot = "4")]
	[AsyncStateMachine(typeof(CLLLPGKAMDG))]
	private Task<LGMMDMPNFIF> KFIHNBLNMED(JLMLKKANJKN EPLNAPFIBMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x6794F20", Offset = "0x6793F20", VA = "0x186794F20")]
	private bool MIDNJOBJHIE(DDMMJNHFCED ECBICLOFOJH, [Out] LGMMDMPNFIF HEOGODCLBDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x6794DE0", Offset = "0x6793DE0", VA = "0x186794DE0")]
	[AsyncStateMachine(typeof(PHCGEPMLCIM))]
	private Task<LGMMDMPNFIF> MDCNODGMJFK(JLMLKKANJKN LFFEKPPMJHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public JBIEIKPECFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class BFABAAIPNMD : KGBIEPEIHBD, MBJMPCJKHOM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private struct LDCCCODPJMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public AsyncTaskMethodBuilder<EGDMKLHIGGO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public ICNKHIIJEIP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public BFABAAIPNMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private TaskAwaiter<HHOALKJJLEH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x679B860", Offset = "0x679A860", VA = "0x18679B860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x679BD10", Offset = "0x679AD10", VA = "0x18679BD10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class DANAADIIAFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public DANAADIIAFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x678B660", Offset = "0x678A660", VA = "0x18678B660")]
		internal object JCOHCLIAGMK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct EAIDIICGKEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<HHOALKJJLEH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public BFABAAIPNMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public ICNKHIIJEIP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private DANAADIIAFB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<HHOALKJJLEH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x678DA60", Offset = "0x678CA60", VA = "0x18678DA60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x678E050", Offset = "0x678D050", VA = "0x18678E050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class LILJFFFDPAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public LILJFFFDPAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x14B47B0", Offset = "0x14B37B0", VA = "0x1814B47B0")]
		internal bool EFIOLFOPGHJ(PHHDJLGAGMP sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private AJDCIPBGOJA HLIOAAOLCGJ;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private static readonly (HJJELDEPGMC superRoomData, long subRoomDataSaveId) BAOHAIGPKJM;

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x6789270", Offset = "0x6788270", VA = "0x186789270", Slot = "5")]
	public void DPGLELIALOP(NKMCDKBACFE EFBGGNOIPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x6789110", Offset = "0x6788110", VA = "0x186789110", Slot = "4")]
	[AsyncStateMachine(typeof(LDCCCODPJMO))]
	public Task<EGDMKLHIGGO> AHMKLIEJGGB(MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, ICNKHIIJEIP EBFOGOFHMKC, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x6789760", Offset = "0x6788760", VA = "0x186789760")]
	[AsyncStateMachine(typeof(EAIDIICGKEP))]
	private Task<HHOALKJJLEH> MDBMAEPMHHH(ICNKHIIJEIP EBFOGOFHMKC, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x6789620", Offset = "0x6788620", VA = "0x186789620")]
	private EGDMKLHIGGO IFOAKPIIHIA(ICNKHIIJEIP EBFOGOFHMKC, HHOALKJJLEH LNPOGOAAENH, long MBGBJFLBPMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x67892E0", Offset = "0x67882E0", VA = "0x1867892E0")]
	private (HJJELDEPGMC, long) FOCLLDCGGNM(ICNKHIIJEIP EBFOGOFHMKC, HHOALKJJLEH LNPOGOAAENH, long MBGBJFLBPMH)
	{
		return default((HJJELDEPGMC, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public BFABAAIPNMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[UnityEngine.Scripting.Preserve]
internal sealed class DEKGBKJLGIN : GDDHGAEFLGK, MBJMPCJKHOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class GJFCBAHHPOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public JLMLKKANJKN request;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public GJFCBAHHPOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x6790B10", Offset = "0x678FB10", VA = "0x186790B10")]
		internal object JDMEFCONKML()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct ELCBJDCCJME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public AsyncTaskMethodBuilder<JLMLKKANJKN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public JLMLKKANJKN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public DEKGBKJLGIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public DDJAKAGJABA pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private TaskAwaiter<JLMLKKANJKN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x678F5E0", Offset = "0x678E5E0", VA = "0x18678F5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x678FBF0", Offset = "0x678EBF0", VA = "0x18678FBF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct PKEIAJHBMOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public AsyncTaskMethodBuilder<JLMLKKANJKN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public DEKGBKJLGIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public DDJAKAGJABA pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private TaskAwaiter<AEDLOHAGCEE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x67A3C00", Offset = "0x67A2C00", VA = "0x1867A3C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x67A4200", Offset = "0x67A3200", VA = "0x1867A4200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class JFGDENJDHOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public JLMLKKANJKN request;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public JFGDENJDHOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x6795110", Offset = "0x6794110", VA = "0x186795110")]
		internal object HAADJKEADDI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct JIDPENCCJEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public AsyncTaskMethodBuilder<JLMLKKANJKN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public JLMLKKANJKN request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public DEKGBKJLGIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public DDJAKAGJABA pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private ADEICBIOFEL <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private KGHMAOMGKDP <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private TaskAwaiter<AEDLOHAGCEE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x67954B0", Offset = "0x67944B0", VA = "0x1867954B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x67960A0", Offset = "0x67950A0", VA = "0x1867960A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private CEMECMCIGML MPJONFIJKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	private KMHDIMCNMJP LPFMFLNDGEK;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private PLOOJMIBDEL EJFOMLKBIOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x678BCD0", Offset = "0x678ACD0", VA = "0x18678BCD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x678BC40", Offset = "0x678AC40", VA = "0x18678BC40", Slot = "8")]
	public void DPGLELIALOP(NKMCDKBACFE EFBGGNOIPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x678BAE0", Offset = "0x678AAE0", VA = "0x18678BAE0", Slot = "4")]
	[AsyncStateMachine(typeof(ELCBJDCCJME))]
	public Task<JLMLKKANJKN> BNOGNEMJGAD(JLMLKKANJKN LFFEKPPMJHN, DDJAKAGJABA JPIHEEKHHBI, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x678BFA0", Offset = "0x678AFA0", VA = "0x18678BFA0", Slot = "5")]
	[AsyncStateMachine(typeof(PKEIAJHBMOI))]
	public Task<JLMLKKANJKN> LHNBOGGECFF(CancellationToken JMJKFNJJBHM, DDJAKAGJABA JPIHEEKHHBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x678BD90", Offset = "0x678AD90", VA = "0x18678BD90", Slot = "6")]
	public ABNEBIHJBDL HMAEFAGJFLB(CAMAINJFJEE AGPOAHNNFLO, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x678B8B0", Offset = "0x678A8B0", VA = "0x18678B8B0", Slot = "7")]
	public ABNEBIHJBDL BFPAPHILPDA(CAMAINJFJEE AGPOAHNNFLO, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x678C0F0", Offset = "0x678B0F0", VA = "0x18678C0F0")]
	[AsyncStateMachine(typeof(JIDPENCCJEE))]
	private Task<JLMLKKANJKN> POPPFNJPPBB(JLMLKKANJKN LFFEKPPMJHN, DDJAKAGJABA JPIHEEKHHBI, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x2D7E990", Offset = "0x2D7D990", VA = "0x182D7E990")]
	private static byte[] GEDBEPGPBAI(JLMLKKANJKN DFJKCKBFLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public DEKGBKJLGIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[UnityEngine.Scripting.Preserve]
internal sealed class NDDDOEKLFGI : BFIIGPKHFJG, MBJMPCJKHOM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private CFCFGBMKNKO OGEOCLEKCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private CEMECMCIGML MPJONFIJKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private NEGNOCONCHH FCGNBGJGKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private OAJKGMFDAML KEOABLFBJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private AJDCIPBGOJA HLIOAAOLCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private AODABJGIPHL GOFNADGNMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private GKALEEFJBFC IOMAIMDGDKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private GOOMPBDIADC DJEDGNFIGON;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	private PPCOIJKJGJJ NCIAKAPEEMP
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x679E6C0", Offset = "0x679D6C0", VA = "0x18679E6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private static LGMMDMPNFIF JAAPCKDLMEI
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x6798CE0", Offset = "0x6797CE0", VA = "0x186798CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x679E880", Offset = "0x679D880", VA = "0x18679E880", Slot = "6")]
	public void DPGLELIALOP(NKMCDKBACFE EFBGGNOIPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x679E710", Offset = "0x679D710", VA = "0x18679E710", Slot = "4")]
	public LGMMDMPNFIF CNLGJKDFOLC(IDMICLLCMKN EDNMEBKKAHG, DDMMJNHFCED AKNBDBHMBDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x679E9F0", Offset = "0x679D9F0", VA = "0x18679E9F0", Slot = "5")]
	public LGMMDMPNFIF MKGPKIJNAEL(IDMICLLCMKN CKOPANEAEAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x67991C0", Offset = "0x67981C0", VA = "0x1867991C0")]
	private static LGMMDMPNFIF OMBMPGLMIPA(IFPBPHJPBIP CPHMIDDIJGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public NDDDOEKLFGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public class FLDDEAGCPEC : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x678FE10", Offset = "0x678EE10", VA = "0x18678FE10")]
	public FLDDEAGCPEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x5D1E080", Offset = "0x5D1D080", VA = "0x185D1E080")]
	public FLDDEAGCPEC(string DFJKCKBFLAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[UnityEngine.Scripting.Preserve]
internal sealed class KKDEKAOEEGF : BIBICMEENFA, MBJMPCJKHOM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct HIADFBMNHOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public AsyncTaskMethodBuilder<LGMMDMPNFIF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public KKDEKAOEEGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public KLKBPFAMHHJ autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private MFEMJMGOOCM<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private OCIADCMCGCD <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private TaskAwaiter<LGMMDMPNFIF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x6792A20", Offset = "0x6791A20", VA = "0x186792A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x67935B0", Offset = "0x67925B0", VA = "0x1867935B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct PCDCEPGMNIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public KKDEKAOEEGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x67A2B30", Offset = "0x67A1B30", VA = "0x1867A2B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x67A3280", Offset = "0x67A2280", VA = "0x1867A3280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct LAONOKBKDBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public KKDEKAOEEGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x679B260", Offset = "0x679A260", VA = "0x18679B260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x679B770", Offset = "0x679A770", VA = "0x18679B770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct NLBHAELBNBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public KKDEKAOEEGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x679EDF0", Offset = "0x679DDF0", VA = "0x18679EDF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x679F540", Offset = "0x679E540", VA = "0x18679F540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct GMJCAHOOFAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public KKDEKAOEEGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x6790F60", Offset = "0x678FF60", VA = "0x186790F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x6791100", Offset = "0x6790100", VA = "0x186791100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct IBJJGHOKHGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public KKDEKAOEEGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x6793E30", Offset = "0x6792E30", VA = "0x186793E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x6794550", Offset = "0x6793550", VA = "0x186794550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct LLGPCIMKCBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public KKDEKAOEEGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x679BE40", Offset = "0x679AE40", VA = "0x18679BE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x679C2B0", Offset = "0x679B2B0", VA = "0x18679C2B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct MGCNNFKMPMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public KKDEKAOEEGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public APEKBBKGICD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private MFEMJMGOOCM<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x679CEA0", Offset = "0x679BEA0", VA = "0x18679CEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x679D3E0", Offset = "0x679C3E0", VA = "0x18679D3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private CEMECMCIGML MPJONFIJKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private NKMCDKBACFE EFBGGNOIPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private AJDCIPBGOJA HLIOAAOLCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private GDDHGAEFLGK DMMBODIODOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private NEGNOCONCHH FCGNBGJGKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private GKALEEFJBFC IOMAIMDGDKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private CancellationTokenSource NJLKGDJCBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private Task ALIJIEFMOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private TaskCompletionSource<int> CPADIGKOGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private int IGMBGLAGKAB;

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x6797F50", Offset = "0x6796F50", VA = "0x186797F50", Slot = "6")]
	public void DPGLELIALOP(NKMCDKBACFE EFBGGNOIPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x919840", Offset = "0x918840", VA = "0x180919840", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x67987C0", Offset = "0x67977C0", VA = "0x1867987C0")]
	private void LOAMHAJOAJC(float KKFLGNLBAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x6798100", Offset = "0x6797100", VA = "0x186798100", Slot = "4")]
	[AsyncStateMachine(typeof(HIADFBMNHOO))]
	public Task<LGMMDMPNFIF> HDLGBANOIAD(KLKBPFAMHHJ NNNOIAJIGGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x6798230", Offset = "0x6797230", VA = "0x186798230", Slot = "5")]
	[AsyncStateMachine(typeof(PCDCEPGMNIB))]
	public Task KPFJJCPLHBF([Optional] CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x919840", Offset = "0x918840", VA = "0x180919840")]
	public void NLCLPFBNDMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x6798990", Offset = "0x6797990", VA = "0x186798990")]
	private OCIADCMCGCD PCPBIHKONPH(KLKBPFAMHHJ NNNOIAJIGGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x67988A0", Offset = "0x67978A0", VA = "0x1867988A0")]
	[AsyncStateMachine(typeof(LAONOKBKDBF))]
	private Task OGBBJDBLDKB(PHJGIMFDNFB IEHPEJEDEKI, CancellationToken JOEEALIOINJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x6797D40", Offset = "0x6796D40", VA = "0x186797D40")]
	[AsyncStateMachine(typeof(NLBHAELBNBC))]
	private Task ABHKLKDEKFA(CancellationToken JOEEALIOINJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x6798B00", Offset = "0x6797B00", VA = "0x186798B00")]
	[AsyncStateMachine(typeof(GMJCAHOOFAA))]
	private Task PDOJFCDOJAO([Optional] CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x6798BF0", Offset = "0x6797BF0", VA = "0x186798BF0")]
	[AsyncStateMachine(typeof(IBJJGHOKHGM))]
	private Task PODIDFPOLJJ(CancellationToken JOEEALIOINJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x6798320", Offset = "0x6797320", VA = "0x186798320")]
	[AsyncStateMachine(typeof(LLGPCIMKCBH))]
	private Task LIJPEHHHAGD(CancellationToken JAHPIOKNMPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x6798530", Offset = "0x6797530", VA = "0x186798530")]
	private Task LMBOFLGGFDC(APEKBBKGICD EIJDFFMEHGJ, CancellationToken JOEEALIOINJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x6797E40", Offset = "0x6796E40", VA = "0x186797E40")]
	[AsyncStateMachine(typeof(MGCNNFKMPMO))]
	private Task DNPKMABNMDB(APEKBBKGICD EIJDFFMEHGJ, CancellationToken JOEEALIOINJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x6798420", Offset = "0x6797420", VA = "0x186798420")]
	private bool LJCFFNMCHDJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public KKDEKAOEEGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[UnityEngine.Scripting.Preserve]
internal class PALGDKPHNKI : OAJKGMFDAML, MBJMPCJKHOM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct FOHPPGJDLKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public PALGDKPHNKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private MFEMJMGOOCM<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x6790550", Offset = "0x678F550", VA = "0x186790550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x6790AB0", Offset = "0x678FAB0", VA = "0x186790AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private AFDFEADIGND BKPHLLMGBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private NKMCDKBACFE EFBGGNOIPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private BFIIGPKHFJG DDPPPIJNHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private GDDHGAEFLGK DMMBODIODOC;

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x67A26A0", Offset = "0x67A16A0", VA = "0x1867A26A0", Slot = "6")]
	public void DPGLELIALOP(NKMCDKBACFE EFBGGNOIPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x67A2980", Offset = "0x67A1980", VA = "0x1867A2980", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x67A29D0", Offset = "0x67A19D0", VA = "0x1867A29D0", Slot = "5")]
	[AsyncStateMachine(typeof(FOHPPGJDLKG))]
	public Task HFLNNFNGHBH(string MOOBDKACMAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x67A2AD0", Offset = "0x67A1AD0", VA = "0x1867A2AD0", Slot = "4")]
	public LGMMDMPNFIF LJCFFNMCHDJ(IDMICLLCMKN EDNMEBKKAHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x67A25B0", Offset = "0x67A15B0", VA = "0x1867A25B0")]
	private IPCDOBMEHAG BIJMNKBCOBE(string MOOBDKACMAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public PALGDKPHNKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public static class JKPDOECABEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x6796B10", Offset = "0x6795B10", VA = "0x186796B10")]
	public static void DFLMCNLPECI(ONGJLMJLNJA CNBEIAALEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x67971A0", Offset = "0x67961A0", VA = "0x1867971A0")]
	internal static void PNCNGCOKOJA(ONGJLMJLNJA CNBEIAALEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x6796A30", Offset = "0x6795A30", VA = "0x186796A30")]
	internal static void CIGFBCEGIIA(ONGJLMJLNJA CNBEIAALEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x6796D50", Offset = "0x6795D50", VA = "0x186796D50")]
	internal static void PKLEHCJDJKE(ONGJLMJLNJA CNBEIAALEIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal class NPFOODOEPOP : DOEILDJJAHD<JLMLKKANJKN>
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class HFGDHFJCJBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public JLMLKKANJKN message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public HFGDHFJCJBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x6792660", Offset = "0x6791660", VA = "0x186792660")]
		internal object FGPHJNLJNDL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly NPFOODOEPOP GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x679FD20", Offset = "0x679ED20", VA = "0x18679FD20")]
	public ExitGames.Client.Photon.Hashtable PAKOMNGHIKD(JLMLKKANJKN DFJKCKBFLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x679F9C0", Offset = "0x679E9C0", VA = "0x18679F9C0", Slot = "5")]
	protected override void LPNNHMCAALH(JLMLKKANJKN DFJKCKBFLAD, IDictionary<object, object> ELANMAGHLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x679FAF0", Offset = "0x679EAF0", VA = "0x18679FAF0", Slot = "6")]
	public override JLMLKKANJKN MPIEPNPHGIA(IDictionary<object, object> ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x679F8B0", Offset = "0x679E8B0", VA = "0x18679F8B0")]
	private static void LFPFJBDDFDP(string FCLHAIJIPNH, JLMLKKANJKN DFJKCKBFLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x679FE50", Offset = "0x679EE50", VA = "0x18679FE50")]
	public NPFOODOEPOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x679F610", Offset = "0x679E610", VA = "0x18679F610")]
	[CompilerGenerated]
	internal static string EHFHHJFNBEP(EGDMKLHIGGO CEFJMHIOKFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class KLIDOLJFGED
{
	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public static LGMMDMPNFIF JAAPCKDLMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x6798CE0", Offset = "0x6797CE0", VA = "0x186798CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x6798F40", Offset = "0x6797F40", VA = "0x186798F40")]
	public static bool LPKDOHPDOPG(this LGMMDMPNFIF AJJPEOADJPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x67991C0", Offset = "0x67981C0", VA = "0x1867991C0")]
	public static LGMMDMPNFIF OMBMPGLMIPA(IFPBPHJPBIP CJGNPMMJNFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x6798D40", Offset = "0x6797D40", VA = "0x186798D40")]
	public static LGMMDMPNFIF DGLGLKLIAOH(IEnumerable<LGMMDMPNFIF> JHKBAKMBIFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x6798F60", Offset = "0x6797F60", VA = "0x186798F60")]
	public static string MHBEOCLDEGH(this LGMMDMPNFIF HEOGODCLBDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public abstract class KFPDEPBJBMP : KDHJOPNNILI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public delegate LGMMDMPNFIF BHCPIJKJGJJ([NotNull] IDMICLLCMKN GBJKJGIGHFF);

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class KOFHBIDBJAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public IDMICLLCMKN photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public KOFHBIDBJAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x5F0A990", Offset = "0x5F09990", VA = "0x185F0A990")]
		internal LGMMDMPNFIF IKECPIAMKIK(BHCPIJKJGJJ v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private bool FIBIHEBBEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	protected readonly HashSet<BHCPIJKJGJJ> IHNMPLNDFJM;

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x6797BF0", Offset = "0x6796BF0", VA = "0x186797BF0", Slot = "4")]
	public void PFAGJJMIOIN(BHCPIJKJGJJ NEONJDFPDJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x6797B90", Offset = "0x6796B90", VA = "0x186797B90", Slot = "5")]
	public void KKPDFKGDEMB(BHCPIJKJGJJ NEONJDFPDJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x6797B40", Offset = "0x6796B40", VA = "0x186797B40", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x67978A0", Offset = "0x67968A0", VA = "0x1867978A0")]
	protected LGMMDMPNFIF CMMFFFNOEPI(IDMICLLCMKN CKOPANEAEAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x6797C50", Offset = "0x6796C50", VA = "0x186797C50")]
	protected KFPDEPBJBMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public class MBJCKKFGIAF : KFPDEPBJBMP, CFCFGBMKNKO, KDHJOPNNILI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[CompilerGenerated]
	private sealed class LAPNFGLLNHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public LGMMDMPNFIF result;

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public LAPNFGLLNHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x679B7D0", Offset = "0x679A7D0", VA = "0x18679B7D0")]
		internal object BAFBPKFKEIE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x6794C00", Offset = "0x6793C00", VA = "0x186794C00")]
	[UnityEngine.Scripting.Preserve]
	public MBJCKKFGIAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x679CA70", Offset = "0x679BA70", VA = "0x18679CA70", Slot = "8")]
	public LGMMDMPNFIF LIAMKNILNCA(IDMICLLCMKN CKOPANEAEAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class INJLCAHANCG : KFPDEPBJBMP, AFDFEADIGND, KDHJOPNNILI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class DKLCOKJLDDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public LGMMDMPNFIF result;

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public DKLCOKJLDDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x678C5E0", Offset = "0x678B5E0", VA = "0x18678C5E0")]
		internal object HPNFHCMHBFB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x6794C00", Offset = "0x6793C00", VA = "0x186794C00")]
	[UnityEngine.Scripting.Preserve]
	public INJLCAHANCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x6794AF0", Offset = "0x6793AF0", VA = "0x186794AF0", Slot = "8")]
	public LGMMDMPNFIF LJCFFNMCHDJ(IDMICLLCMKN KOIELLGDMII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class ALFPINLBLHJ
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private sealed class OEDDIGBGILA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public MFEMJMGOOCM<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public OEDDIGBGILA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x67A22F0", Offset = "0x67A12F0", VA = "0x1867A22F0")]
		internal object IEAEECINHNL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x6788A30", Offset = "0x6787A30", VA = "0x186788A30")]
	public static MFEMJMGOOCM<string> CLEJINKOMAM(LPCGADPJIJD IJDHPGKKFNN, [Optional] string IDLJMMKGNMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x6788B10", Offset = "0x6787B10", VA = "0x186788B10")]
	public static void HCOGBGGAAMN(MFEMJMGOOCM<string> HKNHNBDNOFH, LPCGADPJIJD IJDHPGKKFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x6788970", Offset = "0x6787970", VA = "0x186788970")]
	public static string ABFMBMALFEB(JLMLKKANJKN EPLNAPFIBMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal static class DOLLKKPPLBL
{
	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x678C790", Offset = "0x678B790", VA = "0x18678C790")]
	public static void FILHOFAMKHC(this CEMECMCIGML MPJONFIJKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x678C7A0", Offset = "0x678B7A0", VA = "0x18678C7A0")]
	public static void HPEBDFNHACP(this CEMECMCIGML MPJONFIJKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x678C7B0", Offset = "0x678B7B0", VA = "0x18678C7B0")]
	private static void KBPOEOPDBMF(this CEMECMCIGML MPJONFIJKNC, bool ENOGDLJHMCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class HPFBLAOKNBL : OJMCLNOIKLL, DFNMIAGKKNK, EOJLJAJGEPH, ILKHEMKLHHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private readonly DFNMIAGKKNK NDMPFCINGHE;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public IDMICLLCMKN MANEOCFHCMI
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x6793B40", Offset = "0x6792B40", VA = "0x186793B40", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public int JAKJAIBNAAM
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x6793AD0", Offset = "0x6792AD0", VA = "0x186793AD0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public int HDEFPBFOPLA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x6793980", Offset = "0x6792980", VA = "0x186793980", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool BGIEHPPIPPO
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x7D6100", Offset = "0x7D5100", VA = "0x1807D6100", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public int CJNKHEKLKDD
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x87D040", Offset = "0x87C040", VA = "0x18087D040", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event DDAKAEHGEDO.BEGLGFHCFFK DENBEIMMAAL
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event FKAKCJOCFGE OIPBAMBFAPE
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x67938E0", Offset = "0x67928E0", VA = "0x1867938E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x6793840", Offset = "0x6792840", VA = "0x186793840", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> HIHHKAMIGGG
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<IDMICLLCMKN> EGPINLNLFKI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action JMHMBBABAOL
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x6793620", Offset = "0x6792620", VA = "0x186793620", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x67936C0", Offset = "0x67926C0", VA = "0x1867936C0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0xD6B440", Offset = "0xD6A440", VA = "0x180D6B440")]
	public HPFBLAOKNBL(DFNMIAGKKNK NDMPFCINGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x67939D0", Offset = "0x67929D0", VA = "0x1867939D0", Slot = "8")]
	public bool IAEKKKOOKFJ(byte DPGGHMFJGPD, ExitGames.Client.Photon.Hashtable EABIFFJMEFJ, GNOLOIJAHDK IBNOPMOLMGB, SendOptions KDLJKDDOBIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x6793760", Offset = "0x6792760", VA = "0x186793760", Slot = "16")]
	public IDMICLLCMKN BPJKGBJEGLD(int PCGJOGIGFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "19")]
	public void GGBANPJLOGK(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "20")]
	public void FFMCBJHOEDH(object OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "21")]
	public void MLIBGDKHIEA(object OGACLNNOKDA, bool FGFFDENLGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x6793A80", Offset = "0x6792A80", VA = "0x186793A80", Slot = "22")]
	public IDisposable IDPJPLMOLLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "23")]
	private bool ENDOHPKKMMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "24")]
	public void HCHDDFMJHEH(StringBuilder NNCMFNIBBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x6793B20", Offset = "0x6792B20", VA = "0x186793B20", Slot = "25")]
	public bool MMHPMGAGHIN(bool FKLBGEOPHND, [Out] string AIKAPCCDDEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x830020", Offset = "0x82F020", VA = "0x180830020", Slot = "28")]
	public void PJKCLAIEGJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal struct DHCNKDPBEDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private readonly IDictionary<object, object> KGGAPJLLPNF;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x9452D0", Offset = "0x9442D0", VA = "0x1809452D0")]
	public DHCNKDPBEDM(IDictionary<object, object> KGGAPJLLPNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x678C250", Offset = "0x678B250", VA = "0x18678C250")]
	public bool EIBDLEHKJFM([Out] JLMLKKANJKN DFJKCKBFLAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x678C440", Offset = "0x678B440", VA = "0x18678C440")]
	public Guid MCFECIAGJFE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x678C300", Offset = "0x678B300", VA = "0x18678C300")]
	public LGMMDMPNFIF KLLLFDKMOFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x678C4F0", Offset = "0x678B4F0", VA = "0x18678C4F0")]
	public static ExitGames.Client.Photon.Hashtable OOGKEDOOOJC(JLMLKKANJKN DFJKCKBFLAD, LGMMDMPNFIF AJJPEOADJPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal static class FLFJIENNMHG
{
	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x678FE50", Offset = "0x678EE50", VA = "0x18678FE50")]
	public static bool LEGAAEAFECJ(this ICNKHIIJEIP HCHLADPIBDM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal struct MLFEDJHCLAG : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct IJBGBLDFFOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public MLFEDJHCLAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x67948B0", Offset = "0x67938B0", VA = "0x1867948B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x6794A90", Offset = "0x6793A90", VA = "0x186794A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private readonly CancellationTokenSource COPLNLJNKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private bool FIBIHEBBEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private Task JCGMNOGFGHB;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool CJEPHDFADJG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x679E390", Offset = "0x679D390", VA = "0x18679E390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x679E520", Offset = "0x679D520", VA = "0x18679E520")]
	public MLFEDJHCLAG(CancellationToken JMJKFNJJBHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x679E410", Offset = "0x679D410", VA = "0x18679E410")]
	[AsyncStateMachine(typeof(IJBGBLDFFOA))]
	public Task GJICACIADME(Func<CancellationToken, List<Task>> MJHNJJGOMAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x679E3C0", Offset = "0x679D3C0", VA = "0x18679E3C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public readonly struct GOPJGNAENHC<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct BBKGEEEGEBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<JNKLPPDJIFK<TData>, HMMHOLFLIGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public GOPJGNAENHC<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private TaskAwaiter<PBAOJGOHCMJ<JNKLPPDJIFK<TData>, HMMHOLFLIGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x478CDF0", Offset = "0x478BDF0", VA = "0x18478CDF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x3932590", Offset = "0x3931590", VA = "0x183932590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private readonly OEINNMMNFJM<TGetDataArg, TData> KFNEOPKPPMN;

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x9452D0", Offset = "0x9442D0", VA = "0x1809452D0")]
	internal GOPJGNAENHC(OEINNMMNFJM<TGetDataArg, TData> DGILCEAPJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x376A960", Offset = "0x3769960", VA = "0x18376A960")]
	[AsyncStateMachine(typeof(GOPJGNAENHC<, >.BBKGEEEGEBH))]
	public Task<PBAOJGOHCMJ<JNKLPPDJIFK<TData>, HMMHOLFLIGF>> NCFGJMFPMCF(TGetDataArg OMFIAODHHCI, string BANAHKGFMBF, MFEMJMGOOCM<string>.ENJHCLDNEDD HKNHNBDNOFH, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public static class DANPEFDDKBO
{
	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x2634270", Offset = "0x2633270", VA = "0x182634270")]
	public static GOPJGNAENHC<TGetDataArg, TData> NAJBLLJFKKI<TGetDataArg, TData>(OEINNMMNFJM<TGetDataArg, TData> DGILCEAPJEB)
	{
		return default(GOPJGNAENHC<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public struct DLCJNONDADN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public readonly int JPLKBGAMNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public readonly int? CMPBBDCHCHF;

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8640", Offset = "0x3CC7640", VA = "0x183CC8640")]
	public DLCJNONDADN(int GKKMNEEGMCJ, [Optional] int? LFGPALBHMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x678C640", Offset = "0x678B640", VA = "0x18678C640", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public interface JFABPMHPKFN<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IJLLJOBCMDG();

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JFABPMHPKFN<T> CJHLDBOAEDG(string KGDODHFFJDA);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JFABPMHPKFN<T> EBPBGICDKJL(AEAOKNIGPMJ<T> JBNJCHCONLN);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JFABPMHPKFN<T> NBJFIICBFLN(int ILDJAPLNIMH);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JFABPMHPKFN<T> HOHPONFBMAB(int ILDJAPLNIMH, GDGJDJFDCKB<T> LEEMEBJGAJL);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public interface CNCBPABFNGK
{
	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JFABPMHPKFN<T> JGDBAALGDKP<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ACJIBLMEJCG CAIEGHLIJIK(Exception NNMGILNOFJH);

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DLCJNONDADN NLODJENANJO(Exception NNMGILNOFJH);
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public delegate string AEAOKNIGPMJ<in T>(T NNMGILNOFJH) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public delegate int GDGJDJFDCKB<in T>(T NNMGILNOFJH) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal class OBOGKKNGDIL : CNCBPABFNGK
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private delegate string DPDELHPCPMH(Exception NNMGILNOFJH);

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	private delegate int BJOGKIINHDJ(Exception NNMGILNOFJH);

	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	private class AGLJHAFLLPI<T> : JFABPMHPKFN<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private sealed class PFEDLNIEAFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000310")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
			public PFEDLNIEAFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450")]
			internal string GHHGFNBEMNO(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private sealed class OGAGEMHLAKO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			public AEAOKNIGPMJ<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
			public OGAGEMHLAKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x3F47970", Offset = "0x3F46970", VA = "0x183F47970")]
			internal string DPELILMGFIK(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E5")]
		[CompilerGenerated]
		private sealed class NGOGHBNFAGM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			public GDGJDJFDCKB<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
			public NGOGHBNFAGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0x3F47970", Offset = "0x3F46970", VA = "0x183F47970")]
			internal int ILEFPJFGKAD(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private readonly OBOGKKNGDIL MOEGNBOLLHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private readonly Type FFAOKPEGEMH;

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x37A3240", Offset = "0x37A2240", VA = "0x1837A3240")]
		internal AGLJHAFLLPI(OBOGKKNGDIL MOEGNBOLLHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x37A31D0", Offset = "0x37A21D0", VA = "0x1837A31D0", Slot = "4")]
		public void IJLLJOBCMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x37A2E90", Offset = "0x37A1E90", VA = "0x1837A2E90", Slot = "5")]
		public JFABPMHPKFN<T> CJHLDBOAEDG(string KGDODHFFJDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x37A2FA0", Offset = "0x37A1FA0", VA = "0x1837A2FA0", Slot = "6")]
		public JFABPMHPKFN<T> EBPBGICDKJL(AEAOKNIGPMJ<T> JBNJCHCONLN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x37A3200", Offset = "0x37A2200", VA = "0x1837A3200", Slot = "7")]
		public JFABPMHPKFN<T> NBJFIICBFLN(int ILDJAPLNIMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x37A30B0", Offset = "0x37A20B0", VA = "0x1837A30B0", Slot = "8")]
		public JFABPMHPKFN<T> HOHPONFBMAB(int ILDJAPLNIMH, GDGJDJFDCKB<T> LEEMEBJGAJL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private class LJKKKNGAOJF<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private bool KNMCFELDIKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private readonly List<Type> LIDBAAAEBEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private readonly Dictionary<Type, TVal> ICPFAJGFHLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private readonly Dictionary<Type, int> IFGENBPNKPA;

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public IReadOnlyList<Type> GBBGALEILIK
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x3CF1150", Offset = "0x3CF0150", VA = "0x183CF1150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x3CF1450", Offset = "0x3CF0450", VA = "0x183CF1450")]
		public LJKKKNGAOJF(Dictionary<Type, int> IFGENBPNKPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x3CF0F90", Offset = "0x3CEFF90", VA = "0x183CF0F90")]
		public void EMJMPPLJJNE(Type IPAJBJLLPIJ, TVal GKDIIMKFCMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x3CF12D0", Offset = "0x3CF02D0", VA = "0x183CF12D0")]
		public bool NNACINFAKCB(Type FFAOKPEGEMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x3CF10D0", Offset = "0x3CF00D0", VA = "0x183CF10D0")]
		public bool HBMKINACGEC(TVal CFJDHAGGAJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x3CF1110", Offset = "0x3CF0110", VA = "0x183CF1110")]
		public TVal LNKEGHLMDOM(Type IKHOLAJCJOG)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x3CF13B0", Offset = "0x3CF03B0", VA = "0x183CF13B0")]
		[CompilerGenerated]
		private int PCCIIIJLANC(Type OANJGFJCPKK, Type BKAAPOFNBCE)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class EEAGDMMNJPG : IEnumerable<DLCJNONDADN>, IEnumerable, IEnumerator<DLCJNONDADN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private DLCJNONDADN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public OBOGKKNGDIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private IEnumerator<DLCJNONDADN> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		private DLCJNONDADN System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x3384630", Offset = "0x3383630", VA = "0x183384630", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(DLCJNONDADN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x678E720", Offset = "0x678D720", VA = "0x18678E720", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x80FF60", Offset = "0x80EF60", VA = "0x18080FF60")]
		[DebuggerHidden]
		public EEAGDMMNJPG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x678E770", Offset = "0x678D770", VA = "0x18678E770", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x678E160", Offset = "0x678D160", VA = "0x18678E160", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x678E110", Offset = "0x678D110", VA = "0x18678E110")]
		private void GFMFCNEFFMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x678E0C0", Offset = "0x678D0C0", VA = "0x18678E0C0")]
		private void FIEDEKGMCFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x678E6D0", Offset = "0x678D6D0", VA = "0x18678E6D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x678E610", Offset = "0x678D610", VA = "0x18678E610", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DLCJNONDADN> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x678E610", Offset = "0x678D610", VA = "0x18678E610", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	private static readonly DLCJNONDADN EPCLBJMHNLE;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	private static readonly Dictionary<Type, int> DFCFNAEPIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	private readonly HashSet<Type> ONIGKFCBIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	private readonly LJKKKNGAOJF<int> LPEOJOIOOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	private readonly LJKKKNGAOJF<BJOGKIINHDJ> DDGOPPGPFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private readonly LJKKKNGAOJF<DPDELHPCPMH> JJJKLNAAJLO;

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x67A0AC0", Offset = "0x679FAC0", VA = "0x1867A0AC0")]
	[KEBGMDILACL(JMIJNHPDBML.GameOnly)]
	private static void LMNEJCNFFGB(ONGJLMJLNJA COPEDPCEBKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x67A1290", Offset = "0x67A0290", VA = "0x1867A1290")]
	[RecRoom.NoEngine.Common.Preserve]
	public OBOGKKNGDIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x2583BC0", Offset = "0x2582BC0", VA = "0x182583BC0", Slot = "4")]
	public JFABPMHPKFN<T> JGDBAALGDKP<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x67A00E0", Offset = "0x679F0E0", VA = "0x1867A00E0", Slot = "5")]
	public ACJIBLMEJCG CAIEGHLIJIK(Exception NNMGILNOFJH)
	{
		return default(ACJIBLMEJCG);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x67A0FC0", Offset = "0x679FFC0", VA = "0x1867A0FC0", Slot = "6")]
	public DLCJNONDADN NLODJENANJO(Exception? NNMGILNOFJH)
	{
		return default(DLCJNONDADN);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x67A0A20", Offset = "0x679FA20", VA = "0x1867A0A20", Slot = "7")]
	[IteratorStateMachine(typeof(EEAGDMMNJPG))]
	public IEnumerable<DLCJNONDADN> KEJHOEIEDDH(Exception NNMGILNOFJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x67A0520", Offset = "0x679F520", VA = "0x1867A0520", Slot = "8")]
	public string GCBCFAAAMCN(Exception? NNMGILNOFJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x67A0B30", Offset = "0x679FB30", VA = "0x1867A0B30")]
	private string MIKODAJJAKD(AggregateException LGICPFIFHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x67A0670", Offset = "0x679F670", VA = "0x1867A0670")]
	private void JOFGGDFGHMJ(Type FFAOKPEGEMH, int ILDJAPLNIMH, BJOGKIINHDJ? JIHNBJIKHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x679FE90", Offset = "0x679EE90", VA = "0x18679FE90")]
	private void AEBKHJEGINL(Type FFAOKPEGEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x67A0250", Offset = "0x679F250", VA = "0x1867A0250")]
	private void FMMCKHOPPGN(Type FFAOKPEGEMH, DPDELHPCPMH JIDJEGFKDCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x67A0E40", Offset = "0x679FE40", VA = "0x1867A0E40")]
	private static int NLCAKHLJMCK(Type FFAOKPEGEMH, Dictionary<Type, int> IFGENBPNKPA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x2910D70", Offset = "0x290FD70", VA = "0x182910D70")]
	private static bool LAAIEPLOLKB<TVal>(LJKKKNGAOJF<TVal> MHPPDDHIHNG, Type FFAOKPEGEMH, [Out] TVal CFJDHAGGAJO) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x67A0170", Offset = "0x679F170", VA = "0x1867A0170")]
	[CompilerGenerated]
	internal static int EOGCICLBPJE(Type IFPBNOPDHAJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public struct ACJIBLMEJCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public readonly DLCJNONDADN CLBMKKEFOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public readonly string BHLDMOELGCL;

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x6788950", Offset = "0x6787950", VA = "0x186788950")]
	public ACJIBLMEJCG(string DJAKMJIMBKB, DLCJNONDADN ILDJAPLNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x67888B0", Offset = "0x67878B0", VA = "0x1867888B0")]
	public string EBBJHMJDDEJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public class MGPMMGPNEHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	private readonly KPFLOLMDIGJ DILPEJAKOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private string ADOIGLBGCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	private long? ICFJIFBPDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private long? IBIDMMEDMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private long? MMKPBLHODGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	private string AHEADLIMNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private ICBELHKHBOH NDGDJBBDGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	private long? NMINAONNMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private bool OFIHLNKFLKH;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public string FJNEPACHEPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public long PKIJAFLLCEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x679D690", Offset = "0x679C690", VA = "0x18679D690")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public long JGNGEBJHEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x679D9C0", Offset = "0x679C9C0", VA = "0x18679D9C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public long NFONFDMJIOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x679D900", Offset = "0x679C900", VA = "0x18679D900")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public string MKMLJHALHJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x679E230", Offset = "0x679D230", VA = "0x18679E230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public ICBELHKHBOH MPHOGAOKDCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0xDB6230", Offset = "0xDB5230", VA = "0x180DB6230")]
		get
		{
			return default(ICBELHKHBOH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x679D810", Offset = "0x679C810", VA = "0x18679D810")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public long IAOCCHIDNIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x679D960", Offset = "0x679C960", VA = "0x18679D960")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x679E270", Offset = "0x679D270", VA = "0x18679E270")]
	[UnityEngine.Scripting.Preserve]
	public MGPMMGPNEHM([CJCLEPGLAOP(null)] KPFLOLMDIGJ DILPEJAKOPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x679D440", Offset = "0x679C440", VA = "0x18679D440")]
	private void BNLBDKCGKBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x679DDA0", Offset = "0x679CDA0", VA = "0x18679DDA0")]
	public void MMOOLLBIPIL(long INFPDCJCIBN, long MBGBJFLBPMH, [Optional] long? HADAIDBBLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x679D6F0", Offset = "0x679C6F0", VA = "0x18679D6F0")]
	public void HGIENDGFFHI(long HADAIDBBLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x679D790", Offset = "0x679C790", VA = "0x18679D790")]
	public void HLDPOEKHFMP(string JADKPLHBPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x679DA20", Offset = "0x679CA20", VA = "0x18679DA20")]
	public void LPKMFAKGPIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal class ABNEBIHJBDL : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct KBJBMCLIDJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public AsyncTaskMethodBuilder<JLMLKKANJKN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public JLMLKKANJKN roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public ABNEBIHJBDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private TaskAwaiter<PLOOJMIBDEL.JLJENINHCKF<JLMLKKANJKN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x6797300", Offset = "0x6796300", VA = "0x186797300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x6797830", Offset = "0x6796830", VA = "0x186797830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct JCAEPJLPFNG<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class MHDJOPNHMBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public JLMLKKANJKN roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public MHDJOPNHMBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x679E2B0", Offset = "0x679D2B0", VA = "0x18679E2B0")]
		internal JLMLKKANJKN BKGBHMFCBIA(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct FOCMPMLCLDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public AsyncTaskMethodBuilder<PLOOJMIBDEL.JLJENINHCKF<JLMLKKANJKN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public JLMLKKANJKN roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public ABNEBIHJBDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private ADEICBIOFEL <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private TaskAwaiter<PLOOJMIBDEL.JLJENINHCKF<JLMLKKANJKN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x678FED0", Offset = "0x678EED0", VA = "0x18678FED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x67904E0", Offset = "0x678F4E0", VA = "0x1867904E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct FNIGMMEDLBK<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public ABNEBIHJBDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x3697EB0", Offset = "0x3696EB0", VA = "0x183697EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x33286B0", Offset = "0x33276B0", VA = "0x1833286B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct JGOJEBJBBJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public ABNEBIHJBDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x6795170", Offset = "0x6794170", VA = "0x186795170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x6795330", Offset = "0x6794330", VA = "0x186795330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class JHNAOFEPPCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public JHNAOFEPPCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x6795390", Offset = "0x6794390", VA = "0x186795390")]
		internal object IHKMHHNKAHM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x67953F0", Offset = "0x67943F0", VA = "0x1867953F0")]
		internal bool OOKIHBKBDMC(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class CNFIBLDPMNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public CNFIBLDPMNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x678B600", Offset = "0x678A600", VA = "0x18678B600")]
		internal object FEHKELLHALP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private sealed class NNPOOOGOJMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public NNPOOOGOJMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x679F5A0", Offset = "0x679E5A0", VA = "0x18679F5A0")]
		internal object ICIEHAIIIGD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private sealed class HPHJKMNDOGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public HPHJKMNDOGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x6793B90", Offset = "0x6792B90", VA = "0x186793B90")]
		internal object NOFNDDDFPEK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class OEDLOMPGCPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public ABNEBIHJBDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public OEDLOMPGCPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x67A2370", Offset = "0x67A1370", VA = "0x1867A2370")]
		internal object FGPHJNLJNDL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private static readonly Guid PKDBPIJHPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public readonly CAMAINJFJEE PHGPKDLFKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private readonly PLOOJMIBDEL AIDGLEEFEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private readonly EOJLJAJGEPH MPJONFIJKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private readonly ILKHEMKLHHE IABADDHGIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private bool NHKMNCELBIO;

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x6788680", Offset = "0x6787680", VA = "0x186788680")]
	public ABNEBIHJBDL(CAMAINJFJEE ODMOFOFBMIL, PLOOJMIBDEL AIDGLEEFEIN, EOJLJAJGEPH MPJONFIJKNC, ILKHEMKLHHE IABADDHGIAE, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x67877F0", Offset = "0x67867F0", VA = "0x1867877F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x67877F0", Offset = "0x67867F0", VA = "0x1867877F0")]
	public void POLKKGICNNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x6787D10", Offset = "0x6786D10", VA = "0x186787D10")]
	public void LFKFNIENMDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x6787730", Offset = "0x6786730", VA = "0x186787730")]
	public void DEJNMGLMPDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x6787A10", Offset = "0x6786A10", VA = "0x186787A10")]
	[AsyncStateMachine(typeof(KBJBMCLIDJB))]
	internal Task<JLMLKKANJKN> GPIAFFNJJNP(MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, JLMLKKANJKN EPLNAPFIBMC, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x2D7E990", Offset = "0x2D7D990", VA = "0x182D7E990")]
	private static byte[] NIIMKJANNPC<T>(T DFJKCKBFLAD) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x2D7E750", Offset = "0x2D7D750", VA = "0x182D7E750")]
	private static T GBNDHPBLMKC<T>(MessageParser<T> NNCHEJCFHCG, byte[] DFJKCKBFLAD, T FGAHAIJGBCA) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x6788390", Offset = "0x6787390", VA = "0x186788390")]
	[AsyncStateMachine(typeof(FOCMPMLCLDM))]
	private Task<PLOOJMIBDEL.JLJENINHCKF<JLMLKKANJKN>> OMOKPEIDDAD(JLMLKKANJKN EPLNAPFIBMC, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x2D7E9A0", Offset = "0x2D7D9A0", VA = "0x182D7E9A0")]
	[AsyncStateMachine(typeof(FNIGMMEDLBK<>))]
	internal Task<T> OHHOGNGJBFI<T>(CancellationToken JOEEALIOINJ, Func<CancellationToken, Task<T>> DFOGABEFFIA, int FLEJLIHLDKJ = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x6788260", Offset = "0x6787260", VA = "0x186788260")]
	[AsyncStateMachine(typeof(JGOJEBJBBJJ))]
	internal Task OHHOGNGJBFI(CancellationToken JOEEALIOINJ, Func<CancellationToken, Task> DFOGABEFFIA, int FLEJLIHLDKJ = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x6787990", Offset = "0x6786990", VA = "0x186787990")]
	public OFOPOPDFFGM FMKDGPLHELH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x6787910", Offset = "0x6786910", VA = "0x186787910")]
	public CJMHKCLGENP FGPIPPMJFFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x6787B70", Offset = "0x6786B70", VA = "0x186787B70")]
	public KKOJHBDNKNO HBCDLLFJJNN([Optional] LPCGADPJIJD? IJDHPGKKFNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x6787EE0", Offset = "0x6786EE0", VA = "0x186787EE0")]
	public void LLJEPMAEMCG(Func<Guid, bool> NBHPDMKHDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x6788040", Offset = "0x6787040", VA = "0x186788040")]
	public void MHHKMKCOCPN(Func<Guid, bool> LBHHJJGCACE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x67875B0", Offset = "0x67865B0", VA = "0x1867875B0")]
	public Guid CAMIPPPELDJ()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x6788150", Offset = "0x6787150", VA = "0x186788150")]
	public void OEKGEAMFAIJ(Guid LBJDIHAPAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x67884D0", Offset = "0x67874D0", VA = "0x1867884D0")]
	public void PIJLLCJOLAG(JLMLKKANJKN CLMLCFIGNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x6787DD0", Offset = "0x6786DD0", VA = "0x186787DD0")]
	public void LFPFJBDDFDP(string GNGEIPOKKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x2D7E8A0", Offset = "0x2D7D8A0", VA = "0x182D7E8A0")]
	private T KNNBFFCDMLN<T>(T CFJDHAGGAJO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x6787CC0", Offset = "0x6786CC0", VA = "0x186787CC0")]
	public void IFBECIAKNOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x2D7E4A0", Offset = "0x2D7D4A0", VA = "0x182D7E4A0")]
	[CompilerGenerated]
	internal static string EEGGNMPMLFK<T>(byte[] EOMNNFHDHII, int JKABMGFMNKP, JCAEPJLPFNG<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal sealed class EKONFKNEMBE : CAMAINJFJEE
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class BDJNHLNOLKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public BDJNHLNOLKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x67A7490", Offset = "0x67A6490", VA = "0x1867A7490")]
		internal object GJOCKLAPALG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct NELBGFCHPIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public EKONFKNEMBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public ABNEBIHJBDL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private KFHBOBCFAJF <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private CJMHKCLGENP <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x67BA5C0", Offset = "0x67B95C0", VA = "0x1867BA5C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x67BADA0", Offset = "0x67B9DA0", VA = "0x1867BADA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private struct IHOBDPGEHAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public EKONFKNEMBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private bool <omIsEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private bool <omShouldBeEnabled>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private TaskAwaiter<HHOALKJJLEH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private TaskAwaiter<byte> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x67B2F60", Offset = "0x67B1F60", VA = "0x1867B2F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x67B3610", Offset = "0x67B2610", VA = "0x1867B3610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private struct MGBHMEGFMGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public EKONFKNEMBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private TaskAwaiter<BKHCCIJBOJK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x67B7B50", Offset = "0x67B6B50", VA = "0x1867B7B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x67B7E70", Offset = "0x67B6E70", VA = "0x1867B7E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class AGMAHIBGHKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public KFHBOBCFAJF presence;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public AGMAHIBGHKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x67A6F00", Offset = "0x67A5F00", VA = "0x1867A6F00")]
		internal object GMNNIKJONCO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private static readonly LPCGADPJIJD IJDHPGKKFNN;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private static readonly LPCGADPJIJD GCGIPLANDAF;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private static readonly LPCGADPJIJD CHLAHHMDCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private readonly EGDMKLHIGGO KCKIGPKIIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private readonly ICNKHIIJEIP PPAPOBOILOO;

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x678F450", Offset = "0x678E450", VA = "0x18678F450")]
	public EKONFKNEMBE(EGDMKLHIGGO KCKIGPKIIIE, ICNKHIIJEIP PPAPOBOILOO, Guid FCBFKEBMKED, NKMCDKBACFE EFBGGNOIPLA, DDJAKAGJABA JCIPHAGEHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x678F050", Offset = "0x678E050", VA = "0x18678F050", Slot = "7")]
	[AsyncStateMachine(typeof(NELBGFCHPIM))]
	protected override Task NDCOGGCMPOI(ABNEBIHJBDL FIOPLFIAJDP, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x678EE40", Offset = "0x678DE40", VA = "0x18678EE40")]
	[AsyncStateMachine(typeof(IHOBDPGEHAC))]
	private Task DCBDCNHDOPE(CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x678EF40", Offset = "0x678DF40", VA = "0x18678EF40")]
	[AsyncStateMachine(typeof(MGBHMEGFMGB))]
	private Task<byte> HMICIHGBKAN(CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x678F190", Offset = "0x678E190", VA = "0x18678F190")]
	private KFHBOBCFAJF OBOFKKAFLOK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
internal class OCIADCMCGCD : CAMAINJFJEE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct DFCAGLPNOLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public OCIADCMCGCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public ABNEBIHJBDL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private TaskAwaiter<FAOIIDCCPMP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x67AC340", Offset = "0x67AB340", VA = "0x1867AC340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x67ACCC0", Offset = "0x67ABCC0", VA = "0x1867ACCC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400037B")]
	private readonly int GMAOCCOAFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400037C")]
	private readonly KLKBPFAMHHJ IJBMPEEKNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public readonly long NMPEBFBMKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public readonly long DGHNIDBMCBM;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public FAOIIDCCPMP KFDKBAAAMLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x7C00B0", Offset = "0x7BF0B0", VA = "0x1807C00B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x7C0020", Offset = "0x7BF020", VA = "0x1807C0020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x67BC430", Offset = "0x67BB430", VA = "0x1867BC430")]
	public OCIADCMCGCD(Guid FCBFKEBMKED, NKMCDKBACFE EFBGGNOIPLA, DDJAKAGJABA JCIPHAGEHCD, int GMAOCCOAFLJ, KLKBPFAMHHJ IJBMPEEKNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x67BC310", Offset = "0x67BB310", VA = "0x1867BC310", Slot = "7")]
	[AsyncStateMachine(typeof(DFCAGLPNOLI))]
	protected override Task NDCOGGCMPOI(ABNEBIHJBDL FIOPLFIAJDP, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
internal abstract class KEIMDAAIKGA : CAMAINJFJEE
{
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private sealed class PILFENIKHFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public KEIMDAAIKGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public JEIIDFGCINL playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public PILFENIKHFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x67BD790", Offset = "0x67BC790", VA = "0x1867BD790")]
		internal Task CAOCAIDIFEL(MFEMJMGOOCM<string>.ENJHCLDNEDD postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x67BD7D0", Offset = "0x67BC7D0", VA = "0x1867BD7D0")]
		internal object LIMJDNEGODE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private struct IILCKBBOALF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public KEIMDAAIKGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public ABNEBIHJBDL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private PILFENIKHFK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x67B3670", Offset = "0x67B2670", VA = "0x1867B3670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x67B3E30", Offset = "0x67B2E30", VA = "0x1867B3E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private struct BELNEDGCECE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public JEIIDFGCINL playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public KEIMDAAIKGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x67A7500", Offset = "0x67A6500", VA = "0x1867A7500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x67A7A90", Offset = "0x67A6A90", VA = "0x1867A7A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x67B6100", Offset = "0x67B5100", VA = "0x1867B6100")]
	public KEIMDAAIKGA(Guid FCBFKEBMKED, NKMCDKBACFE EFBGGNOIPLA, DDJAKAGJABA JCIPHAGEHCD, string LNLMPOHJJFC, BHNKCKABCCE ECBICLOFOJH, bool BBIFLPKDFGO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x67B5E80", Offset = "0x67B4E80", VA = "0x1867B5E80", Slot = "7")]
	[AsyncStateMachine(typeof(IILCKBBOALF))]
	protected override Task NDCOGGCMPOI(ABNEBIHJBDL FIOPLFIAJDP, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task NJIFJIBMOPA(ABNEBIHJBDL FIOPLFIAJDP, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM);

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x67B5FC0", Offset = "0x67B4FC0", VA = "0x1867B5FC0")]
	[AsyncStateMachine(typeof(BELNEDGCECE))]
	private Task OOFAICBJOBM(IDisposable NAHFHACPIJM, JEIIDFGCINL BBPBFJLMKEK, MFEMJMGOOCM<string>.ENJHCLDNEDD HKNHNBDNOFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal class LGMCEFJKOCJ : CAMAINJFJEE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private struct LKPDNLIDKKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public LGMCEFJKOCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public ABNEBIHJBDL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private TaskAwaiter<ELNOFCBKAIC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x67B7440", Offset = "0x67B6440", VA = "0x1867B7440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x67B79B0", Offset = "0x67B69B0", VA = "0x1867B79B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400039C")]
	private readonly APEKBBKGICD EIJDFFMEHGJ;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x67B73A0", Offset = "0x67B63A0", VA = "0x1867B73A0")]
	public LGMCEFJKOCJ(Guid FCBFKEBMKED, NKMCDKBACFE EFBGGNOIPLA, DDJAKAGJABA JCIPHAGEHCD, APEKBBKGICD EIJDFFMEHGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x67B71A0", Offset = "0x67B61A0", VA = "0x1867B71A0", Slot = "6")]
	protected override string EBKLFKGDDAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x67B7280", Offset = "0x67B6280", VA = "0x1867B7280", Slot = "7")]
	[AsyncStateMachine(typeof(LKPDNLIDKKM))]
	protected override Task NDCOGGCMPOI(ABNEBIHJBDL FIOPLFIAJDP, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal abstract class CAMAINJFJEE : ONCKGMJPNMF
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	public delegate Task BLMKDFPIFGE(MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM);

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class KJLLJAHKFPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public CAMAINJFJEE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public KJLLJAHKFPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x67B6150", Offset = "0x67B5150", VA = "0x1867B6150")]
		internal Task EELMGEGKIKP(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private sealed class DMDNCKCNEIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public KJLLJAHKFPB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public DMDNCKCNEIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x67AE5D0", Offset = "0x67AD5D0", VA = "0x1867AE5D0")]
		internal object APAOAHCLKHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x67AE690", Offset = "0x67AD690", VA = "0x1867AE690")]
		internal object BKAENDKCCHH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct MKHJOCCILHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public CAMAINJFJEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public Func<CAMAINJFJEE, MFEMJMGOOCM<string>.ENJHCLDNEDD, ABNEBIHJBDL> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private KJLLJAHKFPB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private ABNEBIHJBDL <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private TaskAwaiter<JLMLKKANJKN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x67B8450", Offset = "0x67B7450", VA = "0x1867B8450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x67B9650", Offset = "0x67B8650", VA = "0x1867B9650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct JBJCFNDGDFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x67B43C0", Offset = "0x67B33C0", VA = "0x1867B43C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x67B4E40", Offset = "0x67B3E40", VA = "0x1867B4E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct PLMGEFNMDCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public CAMAINJFJEE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x67BD860", Offset = "0x67BC860", VA = "0x1867BD860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x67BDBC0", Offset = "0x67BCBC0", VA = "0x1867BDBC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public readonly Guid CPHBLMDNGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public readonly ByteString IBHCIIEPDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public readonly DDJAKAGJABA KNKAPAOMBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	protected readonly string KOLPBAFNCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	private readonly NKMCDKBACFE EFBGGNOIPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	private readonly bool BBIFLPKDFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	private readonly Queue<BLMKDFPIFGE> AEFBJHBGKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	private readonly DNGNPLIDLFJ HPMGKJLMNBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	private readonly BHNKCKABCCE ECBICLOFOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private bool PGOPKNIFFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public ICBELHKHBOH DFCCPLOLLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public ICBELHKHBOH FEKAGCOMPGB;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public NKMCDKBACFE NMGMHHMNPAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1E0", Offset = "0x7BB1E0", VA = "0x1807BC1E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public AJDCIPBGOJA CBHMMKHDHNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x67A99D0", Offset = "0x67A89D0", VA = "0x1867A99D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public MKMNMEHNFGI CHCNLMGGEDC
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x67A96F0", Offset = "0x67A86F0", VA = "0x1867A96F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public PPCOIJKJGJJ NCIAKAPEEMP
	{
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x67A94C0", Offset = "0x67A84C0", VA = "0x1867A94C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event MFDHAMNIEAL DBBMEJBBKON
	{
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x67A99B0", Offset = "0x67A89B0", VA = "0x1867A99B0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x67A9540", Offset = "0x67A8540", VA = "0x1867A9540", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x67A9D90", Offset = "0x67A8D90", VA = "0x1867A9D90")]
	protected CAMAINJFJEE(Guid FCBFKEBMKED, NKMCDKBACFE EFBGGNOIPLA, DDJAKAGJABA JCIPHAGEHCD, string LNLMPOHJJFC, BHNKCKABCCE ECBICLOFOJH, bool BBIFLPKDFGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x67A95C0", Offset = "0x67A85C0", VA = "0x1867A95C0", Slot = "6")]
	protected virtual string EBKLFKGDDAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x67A9560", Offset = "0x67A8560", VA = "0x1867A9560")]
	public void EAAGHBKOPDK(BLMKDFPIFGE JFGBEMDJAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x67A9420", Offset = "0x67A8420", VA = "0x1867A9420")]
	protected void CAGBPLCJJPG(float GAAEMIDPEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x67A9C40", Offset = "0x67A8C40", VA = "0x1867A9C40")]
	[AsyncStateMachine(typeof(MKHJOCCILHB))]
	public Task OIOCKJJDGEP(CancellationToken JMJKFNJJBHM, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, [Optional] Func<CAMAINJFJEE, MFEMJMGOOCM<string>.ENJHCLDNEDD, ABNEBIHJBDL> OHJFJMCHCHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x67A9B10", Offset = "0x67A8B10", VA = "0x1867A9B10")]
	[AsyncStateMachine(typeof(JBJCFNDGDFE))]
	private static Task NJKIDKEGOKF(Func<CancellationToken, Task> OHKALMMIJMK, Func<CancellationToken, Task> GHIGAGNGIAI, CancellationToken JOEEALIOINJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x67A9860", Offset = "0x67A8860", VA = "0x1867A9860")]
	private void JFPJHGJBBOM(bool LAFOEMFOPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x67A9600", Offset = "0x67A8600", VA = "0x1867A9600")]
	private void FABCCBEICCO(ABNEBIHJBDL FIOPLFIAJDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task NDCOGGCMPOI(ABNEBIHJBDL FIOPLFIAJDP, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM);

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x67A9740", Offset = "0x67A8740", VA = "0x1867A9740")]
	[AsyncStateMachine(typeof(PLMGEFNMDCK))]
	private Task JEOAAOJLGCE(MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x67A9440", Offset = "0x67A8440", VA = "0x1867A9440")]
	public JLMLKKANJKN CCLHIKLJCLB(ADEICBIOFEL FGOJPJCMGCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x67A9A20", Offset = "0x67A8A20", VA = "0x1867A9A20")]
	[CompilerGenerated]
	private Task MLMOKJAGJEH(CancellationToken MPLEEKHPBJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal sealed class MLFOLBOGKPK : KEIMDAAIKGA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct HONKMAEIJKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public MLFOLBOGKPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public ABNEBIHJBDL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private LMKKKLFJCGI <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private CJMHKCLGENP <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x67B22F0", Offset = "0x67B12F0", VA = "0x1867B22F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x67B2A60", Offset = "0x67B1A60", VA = "0x1867B2A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private readonly EGDMKLHIGGO AGOMFNLKNDG;

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x67B9FA0", Offset = "0x67B8FA0", VA = "0x1867B9FA0")]
	public MLFOLBOGKPK(Guid FCBFKEBMKED, NKMCDKBACFE EFBGGNOIPLA, EGDMKLHIGGO AGOMFNLKNDG, DDJAKAGJABA JCIPHAGEHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x67B9E50", Offset = "0x67B8E50", VA = "0x1867B9E50", Slot = "8")]
	[AsyncStateMachine(typeof(HONKMAEIJKC))]
	protected override Task NJIFJIBMOPA(ABNEBIHJBDL FIOPLFIAJDP, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
internal class IPCDOBMEHAG : CAMAINJFJEE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct FADKOKGCALN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public IPCDOBMEHAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public ABNEBIHJBDL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private TaskAwaiter<ELNOFCBKAIC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x67AE8E0", Offset = "0x67AD8E0", VA = "0x1867AE8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x67AEC90", Offset = "0x67ADC90", VA = "0x1867AEC90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	private readonly string AEKFAKLNBJO;

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x67B4310", Offset = "0x67B3310", VA = "0x1867B4310")]
	public IPCDOBMEHAG(Guid FCBFKEBMKED, NKMCDKBACFE EFBGGNOIPLA, DDJAKAGJABA JCIPHAGEHCD, string AEKFAKLNBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x67B4200", Offset = "0x67B3200", VA = "0x1867B4200", Slot = "7")]
	[AsyncStateMachine(typeof(FADKOKGCALN))]
	protected override Task NDCOGGCMPOI(ABNEBIHJBDL FIOPLFIAJDP, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
internal class MLJDKPBNKEH : KEIMDAAIKGA
{
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class JHKHDMEBKFP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000114")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public AsyncTaskMethodBuilder<JLMLKKANJKN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			public JHKHDMEBKFP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			private TaskAwaiter<ELNOFCBKAIC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			private TaskAwaiter<JLMLKKANJKN> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x67C0900", Offset = "0x67BF900", VA = "0x1867C0900", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0x67C0DC0", Offset = "0x67BFDC0", VA = "0x1867C0DC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public MLJDKPBNKEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public KKOJHBDNKNO serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public HODALNOLPKL roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public OFOPOPDFFGM uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public EGBBBOLAJBE roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public JHKHDMEBKFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x67B5110", Offset = "0x67B4110", VA = "0x1867B5110")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<JLMLKKANJKN> IPIJCNDEEKL(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private struct NODEKFPINBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public MLJDKPBNKEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public ABNEBIHJBDL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private JHKHDMEBKFP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private LMKKKLFJCGI <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private CJMHKCLGENP <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private TaskAwaiter<JLMLKKANJKN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x67BB410", Offset = "0x67BA410", VA = "0x1867BB410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x67BC2B0", Offset = "0x67BB2B0", VA = "0x1867BC2B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	private static readonly LPCGADPJIJD IJDHPGKKFNN;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	private static readonly LPCGADPJIJD GCGIPLANDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	private readonly int PMCHHGHDAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	[CanBeNull]
	private readonly MMDLGPJHFOP NKKHAJMLMLH;

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x67BA510", Offset = "0x67B9510", VA = "0x1867BA510")]
	public MLJDKPBNKEH(Guid FCBFKEBMKED, NKMCDKBACFE EFBGGNOIPLA, int PMCHHGHDAJO, MMDLGPJHFOP NKKHAJMLMLH, DDJAKAGJABA JCIPHAGEHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x67BA320", Offset = "0x67B9320", VA = "0x1867BA320", Slot = "8")]
	[AsyncStateMachine(typeof(NODEKFPINBP))]
	protected override Task NJIFJIBMOPA(ABNEBIHJBDL FIOPLFIAJDP, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x67BA050", Offset = "0x67B9050", VA = "0x1867BA050")]
	private void CGAJGCGLMFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x67BA150", Offset = "0x67B9150", VA = "0x1867BA150")]
	private void LDDPBEPNOFD(MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, LMKKKLFJCGI MJOEDHLNHMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
internal abstract class AFEAAELBDBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public readonly CAMAINJFJEE PHGPKDLFKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public readonly ABNEBIHJBDL FDDGNOHAFDH;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public AJDCIPBGOJA CBHMMKHDHNK
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x67A6D20", Offset = "0x67A5D20", VA = "0x1867A6D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public PPCOIJKJGJJ NCIAKAPEEMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x67A6C90", Offset = "0x67A5C90", VA = "0x1867A6C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x67A6D90", Offset = "0x67A5D90", VA = "0x1867A6D90")]
	protected AFEAAELBDBA(ABNEBIHJBDL FIOPLFIAJDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x67A6D70", Offset = "0x67A5D70", VA = "0x1867A6D70")]
	protected void LFPFJBDDFDP(string GNGEIPOKKBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal struct NNCNLLIIPEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public Dictionary<Guid, List<MCOFFDCMDCP>> CMFAEJFKECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public Dictionary<Guid, List<MCOFFDCMDCP>> HEDCEJFNPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public Dictionary<Guid, List<MCOFFDCMDCP>> IMFHPHLCBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public List<Guid> MIKMJGOMNDL;

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x67BAE00", Offset = "0x67B9E00", VA = "0x1867BAE00")]
	public static NNCNLLIIPEJ LNKEGHLMDOM(AJDCIPBGOJA HLIOAAOLCGJ, ICBELHKHBOH DMIEODBAHPE, PHJGIMFDNFB FOKBHBDLHJI)
	{
		return default(NNCNLLIIPEJ);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000119")]
internal struct MGBHCMMIADI
{
	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0")]
	public static MGBHCMMIADI OOGKEDOOOJC()
	{
		return default(MGBHCMMIADI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal struct OJCLBPAJPNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public readonly HHOALKJJLEH PCFDNGLCNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public readonly PHHDJLGAGMP FKNMNBPLPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public readonly string MJPLOANBPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public readonly HJJELDEPGMC EMCNNGKGOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public readonly HJJELDEPGMC HFIPDKBOKHN;

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x67BC560", Offset = "0x67BB560", VA = "0x1867BC560")]
	public OJCLBPAJPNH(HHOALKJJLEH PCFDNGLCNCH, PHHDJLGAGMP FKNMNBPLPCI, string MJPLOANBPHE, HJJELDEPGMC EMCNNGKGOCG, HJJELDEPGMC HFIPDKBOKHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal struct GIJFCJLEKIC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	private readonly ABNEBIHJBDL FIOPLFIAJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	private readonly Guid LBJDIHAPAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	private bool LAFOEMFOPKK;

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x67AFAF0", Offset = "0x67AEAF0", VA = "0x1867AFAF0")]
	public static GIJFCJLEKIC CAMIPPPELDJ(ABNEBIHJBDL FIOPLFIAJDP)
	{
		return default(GIJFCJLEKIC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x8272A0", Offset = "0x8262A0", VA = "0x1808272A0")]
	public void NPEAPLAHEMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x67AFB50", Offset = "0x67AEB50", VA = "0x1867AFB50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x67AFBB0", Offset = "0x67AEBB0", VA = "0x1867AFBB0")]
	private GIJFCJLEKIC(ABNEBIHJBDL FIOPLFIAJDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x67AFB50", Offset = "0x67AEB50", VA = "0x1867AFB50")]
	private void OEKGEAMFAIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x67AFA50", Offset = "0x67AEA50", VA = "0x1867AFA50")]
	private Func<Guid, bool> AONLCDEDIHP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal class CJMHKCLGENP : AFEAAELBDBA, ONCKGMJPNMF
{
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	public delegate Task<ICBELHKHBOH> AMEAAEFBGLM(PHJGIMFDNFB ELANMAGHLLI, HJCNEOFBDMI GJCKPNHMJBN, DNGNPLIDLFJ NKKIJLNAOBC, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private struct JPLGFLADOFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public CJMHKCLGENP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public EGDMKLHIGGO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private GIJFCJLEKIC <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private TaskAwaiter<JLMLKKANJKN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x67B5230", Offset = "0x67B4230", VA = "0x1867B5230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x67B59A0", Offset = "0x67B49A0", VA = "0x1867B59A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private struct KEGFJNGPNHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public AsyncTaskMethodBuilder<JLMLKKANJKN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public CJMHKCLGENP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public EGDMKLHIGGO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private TaskAwaiter<JLMLKKANJKN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x67B5A00", Offset = "0x67B4A00", VA = "0x1867B5A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x67B5E10", Offset = "0x67B4E10", VA = "0x1867B5E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct PGELMOPFNHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public CJMHKCLGENP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public EGDMKLHIGGO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x67BC5E0", Offset = "0x67BB5E0", VA = "0x1867BC5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x67BCA70", Offset = "0x67BBA70", VA = "0x1867BCA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private sealed class FLILAGJEFKC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000122")]
		private struct <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			public AsyncTaskMethodBuilder<OJCLBPAJPNH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public FLILAGJEFKC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			private OJCLBPAJPNH <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			private TaskAwaiter<ICBELHKHBOH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			private TaskAwaiter<OJCLBPAJPNH> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004F8")]
			[Cpp2IlInjected.Address(RVA = "0x67BEFC0", Offset = "0x67BDFC0", VA = "0x1867BEFC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x67BF750", Offset = "0x67BE750", VA = "0x1867BF750", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			public AsyncTaskMethodBuilder<PHJGIMFDNFB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public FLILAGJEFKC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			private PHJGIMFDNFB <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			private TaskAwaiter<ICBELHKHBOH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			private TaskAwaiter<PHJGIMFDNFB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x67BF7C0", Offset = "0x67BE7C0", VA = "0x1867BF7C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x67BFE10", Offset = "0x67BEE10", VA = "0x1867BFE10", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public FLILAGJEFKC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			private TaskAwaiter<ICBELHKHBOH> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			private HJCNEOFBDMI <timedYielder>5__2;

			[Cpp2IlInjected.Token(Token = "0x60004FC")]
			[Cpp2IlInjected.Address(RVA = "0x67BDC20", Offset = "0x67BCC20", VA = "0x1867BDC20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FD")]
			[Cpp2IlInjected.Address(RVA = "0x67BEF60", Offset = "0x67BDF60", VA = "0x1867BEF60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public CJMHKCLGENP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public EGDMKLHIGGO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public DNGNPLIDLFJ preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public DNGNPLIDLFJ downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public OJCLBPAJPNH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public DNGNPLIDLFJ postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public PHJGIMFDNFB phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public JNOEDMHOMHE.DEAIMAIHFEP <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public FLILAGJEFKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x67AF6F0", Offset = "0x67AE6F0", VA = "0x1867AF6F0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<OJCLBPAJPNH> KAHGENMJKIA(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x67AF930", Offset = "0x67AE930", VA = "0x1867AF930")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<PHJGIMFDNFB> NJCNAMHDOPG(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x67AF6B0", Offset = "0x67AE6B0", VA = "0x1867AF6B0")]
		internal void IBANIHOIEPP(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x67AF830", Offset = "0x67AE830", VA = "0x1867AF830")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task LINIBDILINN(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct KNLFNFOEFOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public CJMHKCLGENP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public EGDMKLHIGGO request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private FLILAGJEFKC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private TaskAwaiter<OJCLBPAJPNH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private TaskAwaiter<PHJGIMFDNFB> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x67B6530", Offset = "0x67B5530", VA = "0x1867B6530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x67B7140", Offset = "0x67B6140", VA = "0x1867B7140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct MKOIMKCNAHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public CJMHKCLGENP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x67B96B0", Offset = "0x67B86B0", VA = "0x1867B96B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x67B9DF0", Offset = "0x67B8DF0", VA = "0x1867B9DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct BJKBHCDCIIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public CJMHKCLGENP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public PHJGIMFDNFB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public DNGNPLIDLFJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private TaskAwaiter<ICBELHKHBOH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x67A8610", Offset = "0x67A7610", VA = "0x1867A8610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x67A8F70", Offset = "0x67A7F70", VA = "0x1867A8F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct DHFJDDDAMPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public AsyncTaskMethodBuilder<ICBELHKHBOH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public CJMHKCLGENP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public PHJGIMFDNFB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public DNGNPLIDLFJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private TaskAwaiter<ICBELHKHBOH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x67ACD20", Offset = "0x67ABD20", VA = "0x1867ACD20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x67ADEA0", Offset = "0x67ACEA0", VA = "0x1867ADEA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct GLEDNOBGJLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public AsyncTaskMethodBuilder<ICBELHKHBOH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public CJMHKCLGENP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public PHJGIMFDNFB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public DNGNPLIDLFJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public HJCNEOFBDMI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private TaskAwaiter<ICBELHKHBOH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x67AFC00", Offset = "0x67AEC00", VA = "0x1867AFC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x67B0FC0", Offset = "0x67AFFC0", VA = "0x1867B0FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct BOMIJCAEGJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public AsyncTaskMethodBuilder<ICBELHKHBOH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public CJMHKCLGENP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public ICBELHKHBOH operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public DNGNPLIDLFJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public PHJGIMFDNFB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private TaskAwaiter<ICBELHKHBOH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x67A9120", Offset = "0x67A8120", VA = "0x1867A9120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x67A93B0", Offset = "0x67A83B0", VA = "0x1867A93B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private sealed class HHKOJANEACM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012D")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000493")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000494")]
			public AsyncTaskMethodBuilder<ICBELHKHBOH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000495")]
			public HHKOJANEACM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			private MAPKHCDKFJB <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			private TaskAwaiter<ICBELHKHBOH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000512")]
			[Cpp2IlInjected.Address(RVA = "0x67BFE80", Offset = "0x67BEE80", VA = "0x1867BFE80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000513")]
			[Cpp2IlInjected.Address(RVA = "0x67C04A0", Offset = "0x67BF4A0", VA = "0x1867C04A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public CJMHKCLGENP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public PHJGIMFDNFB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public DNGNPLIDLFJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public AMEAAEFBGLM masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public HJCNEOFBDMI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public ICBELHKHBOH originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public HHKOJANEACM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x67B21D0", Offset = "0x67B11D0", VA = "0x1867B21D0")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<ICBELHKHBOH> EGPCCKDBNFE(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct MHPFOAMEOPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public AsyncTaskMethodBuilder<ICBELHKHBOH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public CJMHKCLGENP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public PHJGIMFDNFB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public DNGNPLIDLFJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public AMEAAEFBGLM masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public HJCNEOFBDMI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private TaskAwaiter<ICBELHKHBOH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x67B7EE0", Offset = "0x67B6EE0", VA = "0x1867B7EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x67B83E0", Offset = "0x67B73E0", VA = "0x1867B83E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct HFCANKCFHCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public CJMHKCLGENP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public PHJGIMFDNFB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public DNGNPLIDLFJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private ICBELHKHBOH <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private IEnumerator<ICBELHKHBOH> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private TaskAwaiter<ICBELHKHBOH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x67B1C40", Offset = "0x67B0C40", VA = "0x1867B1C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x67B2170", Offset = "0x67B1170", VA = "0x1867B2170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct INFFKIOKNAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public CJMHKCLGENP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public PHJGIMFDNFB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x67B3E90", Offset = "0x67B2E90", VA = "0x1867B3E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x67B41A0", Offset = "0x67B31A0", VA = "0x1867B41A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private struct KKDHEBDLFLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public CJMHKCLGENP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public PHJGIMFDNFB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x67B6280", Offset = "0x67B5280", VA = "0x1867B6280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x67B64D0", Offset = "0x67B54D0", VA = "0x1867B64D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private readonly ABJADLEEAMP MHIGEFOMAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly ABJADLEEAMP IOMBKNIFNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private readonly MGPMMGPNEHM CNCONLPHCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private readonly HLPEAAEEDLI PPGDLMGHECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private readonly ANKMKGBMFIA EMNBBHGCDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	private readonly LGECKPAHDHD HHFLBJAIFPA;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private NKMCDKBACFE NMGMHHMNPAL
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x67AABC0", Offset = "0x67A9BC0", VA = "0x1867AABC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event MFDHAMNIEAL DBBMEJBBKON
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x67AB1F0", Offset = "0x67AA1F0", VA = "0x1867AB1F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x67AA600", Offset = "0x67A9600", VA = "0x1867AA600", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x67AB7F0", Offset = "0x67AA7F0", VA = "0x1867AB7F0")]
	public CJMHKCLGENP(ABNEBIHJBDL FIOPLFIAJDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x67A9EF0", Offset = "0x67A8EF0", VA = "0x1867A9EF0")]
	[AsyncStateMachine(typeof(JPLGFLADOFO))]
	public Task ANDHOHHPONG(EGDMKLHIGGO LFFEKPPMJHN, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x67AADD0", Offset = "0x67A9DD0", VA = "0x1867AADD0")]
	[AsyncStateMachine(typeof(KEGFJNGPNHF))]
	private Task<JLMLKKANJKN> IJFDMNDIKPH(EGDMKLHIGGO LFFEKPPMJHN, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x67AA8B0", Offset = "0x67A98B0", VA = "0x1867AA8B0")]
	[AsyncStateMachine(typeof(PGELMOPFNHC))]
	private Task FDOGMLKCPBI(EGDMKLHIGGO LFFEKPPMJHN, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x67AB0B0", Offset = "0x67AA0B0", VA = "0x1867AB0B0")]
	[AsyncStateMachine(typeof(KNLFNFOEFOH))]
	private Task KHIMIKENBLK(EGDMKLHIGGO LFFEKPPMJHN, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken EMJDEPIFJEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x67AABF0", Offset = "0x67A9BF0", VA = "0x1867AABF0")]
	[AsyncStateMachine(typeof(MKOIMKCNAHI))]
	private Task GPADHODPLEG(MFEMJMGOOCM<string>.ENJHCLDNEDD HKNHNBDNOFH, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x67AB210", Offset = "0x67AA210", VA = "0x1867AB210")]
	[AsyncStateMachine(typeof(BJKBHCDCIIC))]
	private Task LEAPHHKHBOP(PHJGIMFDNFB ELANMAGHLLI, DNGNPLIDLFJ NKKIJLNAOBC, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x67AB450", Offset = "0x67AA450", VA = "0x1867AB450")]
	[AsyncStateMachine(typeof(DHFJDDDAMPC))]
	private Task<ICBELHKHBOH> NMBBLGMHGNH(PHJGIMFDNFB ELANMAGHLLI, HJCNEOFBDMI CFDAJLACEJA, DNGNPLIDLFJ NKKIJLNAOBC, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x67AA040", Offset = "0x67A9040", VA = "0x1867AA040")]
	[AsyncStateMachine(typeof(GLEDNOBGJLN))]
	private Task<ICBELHKHBOH> AOFGDOIAPAK(PHJGIMFDNFB ELANMAGHLLI, HJCNEOFBDMI CFDAJLACEJA, DNGNPLIDLFJ NKKIJLNAOBC, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x67AA9F0", Offset = "0x67A99F0", VA = "0x1867AA9F0")]
	[AsyncStateMachine(typeof(BOMIJCAEGJJ))]
	private Task<ICBELHKHBOH> FOOEFECJEPK(ICBELHKHBOH DMIEODBAHPE, PHJGIMFDNFB FOKBHBDLHJI, DNGNPLIDLFJ NKKIJLNAOBC, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM, bool AODGEINNPOG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x67AB700", Offset = "0x67AA700", VA = "0x1867AB700")]
	private bool PFOIMCFHCHA(PHJGIMFDNFB GHDPMGCIJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x67AA720", Offset = "0x67A9720", VA = "0x1867AA720")]
	[AsyncStateMachine(typeof(MHPFOAMEOPA))]
	protected Task<ICBELHKHBOH> ELJCKHFFCCH(PHJGIMFDNFB ELANMAGHLLI, HJCNEOFBDMI CFDAJLACEJA, DNGNPLIDLFJ NKKIJLNAOBC, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM, AMEAAEFBGLM BCFGEBMGPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x67AA360", Offset = "0x67A9360", VA = "0x1867AA360")]
	[AsyncStateMachine(typeof(HFCANKCFHCM))]
	private Task CDIJOAOCGMG(PHJGIMFDNFB ELANMAGHLLI, DNGNPLIDLFJ NKKIJLNAOBC, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x67AAB70", Offset = "0x67A9B70", VA = "0x1867AAB70")]
	private void GKCNLMNKPJH(ICBELHKHBOH OINMMDDFOLD, DNGNPLIDLFJ NKKIJLNAOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x67AAD00", Offset = "0x67A9D00", VA = "0x1867AAD00")]
	private void HFMICDMPONN(ICBELHKHBOH GMMJDMKJMIL, [Out] ICBELHKHBOH MOEIDEEADBH, [Out] ICBELHKHBOH CHCJKKJNIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x67AAD90", Offset = "0x67A9D90", VA = "0x1867AAD90")]
	private Task<OJCLBPAJPNH> IDEELMOELIO(EGDMKLHIGGO LFFEKPPMJHN, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x67AA300", Offset = "0x67A9300", VA = "0x1867AA300")]
	private Task<PHJGIMFDNFB> BNDIJBAPFAF(OJCLBPAJPNH ELANMAGHLLI, JNOEDMHOMHE.DEAIMAIHFEP CFHAMMCLEOL, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x67AB5B0", Offset = "0x67AA5B0", VA = "0x1867AB5B0")]
	[AsyncStateMachine(typeof(INFFKIOKNAO))]
	private Task PDGGJBEDOBG(PHJGIMFDNFB ELANMAGHLLI, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM, bool OACIAFCOGJM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x67AB360", Offset = "0x67AA360", VA = "0x1867AB360")]
	[AsyncStateMachine(typeof(KKDHEBDLFLB))]
	private Task MCBLGDAIDLL(PHJGIMFDNFB ELANMAGHLLI, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x67AA1C0", Offset = "0x67A91C0", VA = "0x1867AA1C0")]
	private Task BENMKFJFKDB(PHJGIMFDNFB ELANMAGHLLI, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x67AB090", Offset = "0x67AA090", VA = "0x1867AB090")]
	private Task KHFNAJGAIHL(PHJGIMFDNFB ELANMAGHLLI, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x67AA340", Offset = "0x67A9340", VA = "0x1867AA340")]
	private Task CBJPBIGENCP(PHJGIMFDNFB ELANMAGHLLI, HJCNEOFBDMI CFDAJLACEJA, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x67AA4B0", Offset = "0x67A94B0", VA = "0x1867AA4B0")]
	private Task DGAKJFJKLDP(PHJGIMFDNFB ELANMAGHLLI, HJCNEOFBDMI CFDAJLACEJA, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x67AA620", Offset = "0x67A9620", VA = "0x1867AA620")]
	private static Task DOBNIIOKDNN(CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x67AAF30", Offset = "0x67A9F30", VA = "0x1867AAF30")]
	private Task IMBMCMFLFFF(PHJGIMFDNFB ELANMAGHLLI, HJCNEOFBDMI CFDAJLACEJA, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x67AAF50", Offset = "0x67A9F50", VA = "0x1867AAF50")]
	private Task IPICHHCBLNB(PHJGIMFDNFB ELANMAGHLLI, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x67AAD40", Offset = "0x67A9D40", VA = "0x1867AAD40")]
	private void ICIDKJEEOAD(EGDMKLHIGGO LFFEKPPMJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x67AA700", Offset = "0x67A9700", VA = "0x1867AA700")]
	public void ECKMGJENDPC(long HADAIDBBLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280")]
	private static void DALJPDPPFME(HHOALKJJLEH PCFDNGLCNCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal struct DEMGILPFFIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	private NKMCDKBACFE EFBGGNOIPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	private PHJGIMFDNFB ELANMAGHLLI;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private AJDCIPBGOJA CBHMMKHDHNK
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x67AC020", Offset = "0x67AB020", VA = "0x1867AC020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x67AC260", Offset = "0x67AB260", VA = "0x1867AC260")]
	public static Task OIOCKJJDGEP(NKMCDKBACFE EFBGGNOIPLA, PHJGIMFDNFB ELANMAGHLLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x67AC070", Offset = "0x67AB070", VA = "0x1867AC070")]
	private void OIOCKJJDGEP()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal struct LINCHBKCGDN
{
	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x67AA620", Offset = "0x67A9620", VA = "0x1867AA620")]
	public static Task OIOCKJJDGEP(CancellationToken JMJKFNJJBHM)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000134")]
internal struct MFODHEGANNL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct DEILLEMIKPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public ABNEBIHJBDL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public PHJGIMFDNFB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x67ABAA0", Offset = "0x67AAAA0", VA = "0x1867ABAA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x67ABFC0", Offset = "0x67AAFC0", VA = "0x1867ABFC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x67B7A10", Offset = "0x67B6A10", VA = "0x1867B7A10")]
	[AsyncStateMachine(typeof(DEILLEMIKPL))]
	public static Task OIOCKJJDGEP(ABNEBIHJBDL FIOPLFIAJDP, PHJGIMFDNFB ELANMAGHLLI, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal struct AOMNOFNHPIE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct PHGPPPEBCGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public ABNEBIHJBDL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public PHJGIMFDNFB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public HJCNEOFBDMI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		private ICBELHKHBOH <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private NKMCDKBACFE <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private AJDCIPBGOJA <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private MAPKHCDKFJB <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private List<(PersistenceView, CLAFHIEHHKM)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private CLAFHIEHHKM <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x67BCAD0", Offset = "0x67BBAD0", VA = "0x1867BCAD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x67BD730", Offset = "0x67BC730", VA = "0x1867BD730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x67A7340", Offset = "0x67A6340", VA = "0x1867A7340")]
	[AsyncStateMachine(typeof(PHGPPPEBCGK))]
	public static Task OIOCKJJDGEP(ABNEBIHJBDL FIOPLFIAJDP, PHJGIMFDNFB ELANMAGHLLI, HJCNEOFBDMI CFDAJLACEJA, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x67A7140", Offset = "0x67A6140", VA = "0x1867A7140")]
	private static void AKFMACNMHEP(PersistenceView LAOJDFENHDK, CLAFHIEHHKM KHIBNGNBOAK, PHJGIMFDNFB ELANMAGHLLI, ICBELHKHBOH DMIEODBAHPE, bool PGJHFNJDCIK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct AFEKAPDKKLF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private struct IBPMDGBIBIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public NKMCDKBACFE roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public PHJGIMFDNFB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x67B2AC0", Offset = "0x67B1AC0", VA = "0x1867B2AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x67B2F00", Offset = "0x67B1F00", VA = "0x1867B2F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x67A6DF0", Offset = "0x67A5DF0", VA = "0x1867A6DF0")]
	[AsyncStateMachine(typeof(IBPMDGBIBIM))]
	public static Task OIOCKJJDGEP(NKMCDKBACFE EFBGGNOIPLA, PHJGIMFDNFB ELANMAGHLLI, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct HDJHICPGDDJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct JDDNGCBMBJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public NKMCDKBACFE roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public PHJGIMFDNFB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public ABNEBIHJBDL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x67B4EA0", Offset = "0x67B3EA0", VA = "0x1867B4EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x67B50B0", Offset = "0x67B40B0", VA = "0x1867B50B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private sealed class GPKLGADFJFI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200013E")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004EE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004EF")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004F0")]
			public MFEMJMGOOCM<string>.ENJHCLDNEDD timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F1")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004F2")]
			public GPKLGADFJFI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004F3")]
			private MFEMJMGOOCM<string>.ENJHCLDNEDD <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004F4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000538")]
			[Cpp2IlInjected.Address(RVA = "0x67C0510", Offset = "0x67BF510", VA = "0x1867C0510", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000539")]
			[Cpp2IlInjected.Address(RVA = "0x67C08A0", Offset = "0x67BF8A0", VA = "0x1867C08A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public GPKLGADFJFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x67B1030", Offset = "0x67B0030", VA = "0x1867B1030")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task NEEHFCPDKFC(MFEMJMGOOCM<string>.ENJHCLDNEDD timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct FIDDABHEJFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public HDJHICPGDDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private TaskAwaiter<JLMLKKANJKN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x67AECF0", Offset = "0x67ADCF0", VA = "0x1867AECF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x67AF650", Offset = "0x67AE650", VA = "0x1867AF650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private sealed class EMFJEEBIPGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public KJKAGNONJMJ version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public EMFJEEBIPGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x67AE800", Offset = "0x67AD800", VA = "0x1867AE800")]
		internal object NCHANHJHMDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x67AE750", Offset = "0x67AD750", VA = "0x1867AE750")]
		internal object LAGLLMLPPCE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	private NKMCDKBACFE EFBGGNOIPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	private PHJGIMFDNFB ELANMAGHLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	private ABNEBIHJBDL FIOPLFIAJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	private bool OACIAFCOGJM;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private static readonly ByteString AMCHIEPHIOD;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private AJDCIPBGOJA CBHMMKHDHNK
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x67B1890", Offset = "0x67B0890", VA = "0x1867B1890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private PPCOIJKJGJJ NCIAKAPEEMP
	{
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x67B1150", Offset = "0x67B0150", VA = "0x1867B1150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x67B1A60", Offset = "0x67B0A60", VA = "0x1867B1A60")]
	[AsyncStateMachine(typeof(JDDNGCBMBJF))]
	public static Task OIOCKJJDGEP(NKMCDKBACFE EFBGGNOIPLA, PHJGIMFDNFB ELANMAGHLLI, ABNEBIHJBDL FIOPLFIAJDP, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM, bool OACIAFCOGJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x67B1920", Offset = "0x67B0920", VA = "0x1867B1920")]
	[AsyncStateMachine(typeof(FIDDABHEJFE))]
	private Task OIOCKJJDGEP(MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x67B11F0", Offset = "0x67B01F0", VA = "0x1867B11F0")]
	private void KGLKHHGFEGD([NotNull] GBMJEMECJOI MLIFACLLCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x67B18E0", Offset = "0x67B08E0", VA = "0x1867B18E0")]
	private bool LHLHDBMLFIH(KJKAGNONJMJ PENODPCCLDA, GBMJEMECJOI MLIFACLLCMJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
internal struct DJFJCBHLBEH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct BIMJPPLLJGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public AsyncTaskMethodBuilder<PHJGIMFDNFB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public DJFJCBHLBEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public JNOEDMHOMHE.DEAIMAIHFEP downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private TaskAwaiter<(PBAOJGOHCMJ<PFJNNALEPML, HMMHOLFLIGF>, PBAOJGOHCMJ<JNKLPPDJIFK<GBMJEMECJOI>, HMMHOLFLIGF>, PBAOJGOHCMJ<JNKLPPDJIFK<PJNIIGNHFFM>, HMMHOLFLIGF>, PBAOJGOHCMJ<JNKLPPDJIFK<CMMCDCKCCKK>, HMMHOLFLIGF>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x67A7AF0", Offset = "0x67A6AF0", VA = "0x1867A7AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x67A85A0", Offset = "0x67A75A0", VA = "0x1867A85A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct KMAGFJPBJCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<PFJNNALEPML, HMMHOLFLIGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public DJFJCBHLBEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public JNOEDMHOMHE.DEAIMAIHFEP downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		private TaskAwaiter<PBAOJGOHCMJ<PFJNNALEPML, HMMHOLFLIGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x67CEFE0", Offset = "0x67CDFE0", VA = "0x1867CEFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x67CF5F0", Offset = "0x67CE5F0", VA = "0x1867CF5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000503")]
	private GOPJGNAENHC<HJJELDEPGMC, PJNIIGNHFFM> LLAJKDGINAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	private GOPJGNAENHC<HJJELDEPGMC, GBMJEMECJOI> LJKFBDKBEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	private GOPJGNAENHC<long, CMMCDCKCCKK> KHJLFDDNPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	private MOFJNAGLMKN ONCOEDCPDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	private HHOALKJJLEH PCFDNGLCNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	private PHHDJLGAGMP FKNMNBPLPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private string MJPLOANBPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	private HJJELDEPGMC EMCNNGKGOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private HJJELDEPGMC HFIPDKBOKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private long HADAIDBBLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private MFEMJMGOOCM<string>.ENJHCLDNEDD HKNHNBDNOFH;

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x67ADF10", Offset = "0x67ACF10", VA = "0x1867ADF10")]
	public static Task<PHJGIMFDNFB> IKMFPAEBEAF(NKMCDKBACFE EFBGGNOIPLA, [In] OJCLBPAJPNH ELANMAGHLLI, JNOEDMHOMHE.DEAIMAIHFEP CFHAMMCLEOL, MFEMJMGOOCM<string>.ENJHCLDNEDD HKNHNBDNOFH, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x67AE440", Offset = "0x67AD440", VA = "0x1867AE440")]
	[AsyncStateMachine(typeof(BIMJPPLLJGG))]
	private Task<PHJGIMFDNFB> OIOCKJJDGEP(JNOEDMHOMHE.DEAIMAIHFEP CFHAMMCLEOL, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x67AE280", Offset = "0x67AD280", VA = "0x1867AE280")]
	[AsyncStateMachine(typeof(KMAGFJPBJCK))]
	private Task<PBAOJGOHCMJ<PFJNNALEPML, HMMHOLFLIGF>> KFKBHBIFBMP(string MJPLOANBPHE, long HADAIDBBLEL, long? INFPDCJCIBN, long? CNPHGBDAJDM, JNOEDMHOMHE.DEAIMAIHFEP CFHAMMCLEOL, MFEMJMGOOCM<string>.ENJHCLDNEDD AIPBFFHLCMN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
internal struct GDCBDHAGPBP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct GDOKBHIPHBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public AsyncTaskMethodBuilder<OJCLBPAJPNH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public GDCBDHAGPBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		private TaskAwaiter<OJCLBPAJPNH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x67CB260", Offset = "0x67CA260", VA = "0x1867CB260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x67CB660", Offset = "0x67CA660", VA = "0x1867CB660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct KHDHFOMCNNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public AsyncTaskMethodBuilder<OJCLBPAJPNH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public GDCBDHAGPBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private TaskAwaiter<OJCLBPAJPNH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x67CD950", Offset = "0x67CC950", VA = "0x1867CD950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x67CDD80", Offset = "0x67CCD80", VA = "0x1867CDD80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class PPDFDJMDJNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public PPDFDJMDJNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x14B47B0", Offset = "0x14B37B0", VA = "0x1814B47B0")]
		internal bool DGDDKIKHIIN(PHHDJLGAGMP sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct PFDJKKNBDGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public AsyncTaskMethodBuilder<OJCLBPAJPNH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public HJJELDEPGMC superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public AJDCIPBGOJA callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private PPDFDJMDJNC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public EELLOKKIIGB roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private HHOALKJJLEH <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private PHHDJLGAGMP <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private HJJELDEPGMC <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private HJJELDEPGMC <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private TaskAwaiter<HHOALKJJLEH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private TaskAwaiter<BDLKEIKIHPI> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private TaskAwaiter<BKHCCIJBOJK> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x67D7820", Offset = "0x67D6820", VA = "0x1867D7820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x67D8960", Offset = "0x67D7960", VA = "0x1867D8960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	private AJDCIPBGOJA HLIOAAOLCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private MGPMMGPNEHM CNCONLPHCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private EELLOKKIIGB MICKLJMAPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	private MFEMJMGOOCM<string>.ENJHCLDNEDD HKNHNBDNOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private long INFPDCJCIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private long MBGBJFLBPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private long DELKKGCNFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private string ENJMNLEIHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private HJJELDEPGMC ECIKFHNCIOI;

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x67CAE90", Offset = "0x67C9E90", VA = "0x1867CAE90")]
	public static Task<OJCLBPAJPNH> IKMFPAEBEAF(NKMCDKBACFE EFBGGNOIPLA, EGDMKLHIGGO LFFEKPPMJHN, MFEMJMGOOCM<string>.ENJHCLDNEDD HKNHNBDNOFH, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x67CB110", Offset = "0x67CA110", VA = "0x1867CB110")]
	[AsyncStateMachine(typeof(GDOKBHIPHBC))]
	private Task<OJCLBPAJPNH> OIOCKJJDGEP(CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x67CAD30", Offset = "0x67C9D30", VA = "0x1867CAD30")]
	[AsyncStateMachine(typeof(KHDHFOMCNNL))]
	private Task<OJCLBPAJPNH> IDEELMOELIO(MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x67CAB90", Offset = "0x67C9B90", VA = "0x1867CAB90")]
	[AsyncStateMachine(typeof(PFDJKKNBDGB))]
	private static Task<OJCLBPAJPNH> IDEELMOELIO(AJDCIPBGOJA HLIOAAOLCGJ, EELLOKKIIGB MICKLJMAPDC, long INFPDCJCIBN, long MBGBJFLBPMH, long DELKKGCNFAO, string ENJMNLEIHJP, HJJELDEPGMC ECIKFHNCIOI, CancellationToken JMJKFNJJBHM, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x67CAB60", Offset = "0x67C9B60", VA = "0x1867CAB60")]
	private void CPNCPBAIGDN(HHOALKJJLEH PCFDNGLCNCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal struct MHMBLFBCFJH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct FCNCPPJAELP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public MHMBLFBCFJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x67C9870", Offset = "0x67C8870", VA = "0x1867C9870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x67C9E00", Offset = "0x67C8E00", VA = "0x1867C9E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	private AJDCIPBGOJA HLIOAAOLCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	private PHJGIMFDNFB ELANMAGHLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	private MFEMJMGOOCM<string>.ENJHCLDNEDD HKNHNBDNOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	private float KCDNDPGGOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	private float IBMMAPLAKOF;

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x67D2200", Offset = "0x67D1200", VA = "0x1867D2200")]
	public static Task PIOHPLKCCAC(NKMCDKBACFE EFBGGNOIPLA, PHJGIMFDNFB ELANMAGHLLI, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x67D20E0", Offset = "0x67D10E0", VA = "0x1867D20E0")]
	[AsyncStateMachine(typeof(FCNCPPJAELP))]
	public Task OIOCKJJDGEP(CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x67D1EC0", Offset = "0x67D0EC0", VA = "0x1867D1EC0")]
	private static void EAJPPEMBNMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x67D1D60", Offset = "0x67D0D60", VA = "0x1867D1D60")]
	private void DLDFKPNCFAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x67D2020", Offset = "0x67D1020", VA = "0x1867D2020")]
	private static float NBNACCKPGGB(AJDCIPBGOJA HLIOAAOLCGJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x67D2000", Offset = "0x67D1000", VA = "0x1867D2000")]
	private static float ICLECENJPHP()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal struct ADAAIADAPJD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct CKGGLLDOHFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public ABNEBIHJBDL operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public PHJGIMFDNFB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private CAMAINJFJEE <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private NKMCDKBACFE <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private PBAFIKKMAME.ACPIPDPGFGM <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		private TaskAwaiter<JLMLKKANJKN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x67C4C60", Offset = "0x67C3C60", VA = "0x1867C4C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x67C5600", Offset = "0x67C4600", VA = "0x1867C5600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct ANMKAAMHBGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x67C2C40", Offset = "0x67C1C40", VA = "0x1867C2C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x67C2F30", Offset = "0x67C1F30", VA = "0x1867C2F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x67C1820", Offset = "0x67C0820", VA = "0x1867C1820")]
	[AsyncStateMachine(typeof(CKGGLLDOHFD))]
	public static Task OIOCKJJDGEP(ABNEBIHJBDL FIOPLFIAJDP, PHJGIMFDNFB ELANMAGHLLI, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x67C17B0", Offset = "0x67C07B0", VA = "0x1867C17B0")]
	private static Task<JLMLKKANJKN> MKPMAJJHOMK(ABNEBIHJBDL FIOPLFIAJDP, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x67C16F0", Offset = "0x67C06F0", VA = "0x1867C16F0")]
	[AsyncStateMachine(typeof(ANMKAAMHBGN))]
	private static Task JENJDEECKBL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
internal struct LLHFJGHMLBE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct LDBDOMBINLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public LLHFJGHMLBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x67CFA00", Offset = "0x67CEA00", VA = "0x1867CFA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x67D00B0", Offset = "0x67CF0B0", VA = "0x1867D00B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private sealed class IDIODKIEIMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public IDIODKIEIMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x67CCA50", Offset = "0x67CBA50", VA = "0x1867CCA50")]
		internal object OAKLPABCFGK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct CNCOCGCJPNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public LLHFJGHMLBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		private OBEECGBCBNL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x67C5660", Offset = "0x67C4660", VA = "0x1867C5660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x67C5C20", Offset = "0x67C4C20", VA = "0x1867C5C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private bool IEFBOMCFJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private MFEMJMGOOCM<string>.ENJHCLDNEDD HKNHNBDNOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	private NKMCDKBACFE EFBGGNOIPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000570")]
	private CancellationToken JMJKFNJJBHM;

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x67D18A0", Offset = "0x67D08A0", VA = "0x1867D18A0")]
	public static Task ELAELKBLJAI(NKMCDKBACFE EFBGGNOIPLA, bool IEFBOMCFJNM, MFEMJMGOOCM<string>.ENJHCLDNEDD HKNHNBDNOFH, CancellationToken CANFCPFBFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x67D1A40", Offset = "0x67D0A40", VA = "0x1867D1A40")]
	[AsyncStateMachine(typeof(LDBDOMBINLF))]
	private Task OIOCKJJDGEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x67D1910", Offset = "0x67D0910", VA = "0x1867D1910")]
	[AsyncStateMachine(typeof(CNCOCGCJPNH))]
	private Task JJEEIMAGIBL(bool HJDKBBNGFEG, string KIPEOJGAHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0")]
	private bool OABONKMCMHF(bool IEFBOMCFJNM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal struct AHKDMFBCADO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct ODFGBEFCICI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public AHKDMFBCADO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x67D4E20", Offset = "0x67D3E20", VA = "0x1867D4E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x67D5390", Offset = "0x67D4390", VA = "0x1867D5390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private sealed class LKMAFFELABP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public LKMAFFELABP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x67D1850", Offset = "0x67D0850", VA = "0x1867D1850")]
		internal object OAKLPABCFGK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct BOEFENOPMOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public AHKDMFBCADO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		private OBEECGBCBNL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x67C3FA0", Offset = "0x67C2FA0", VA = "0x1867C3FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x67C4560", Offset = "0x67C3560", VA = "0x1867C4560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000581")]
	private KKBFOFAMKMI OKCIIKILGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000582")]
	private MFEMJMGOOCM<string>.ENJHCLDNEDD HKNHNBDNOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000583")]
	private NKMCDKBACFE EFBGGNOIPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000584")]
	private bool LBOOOOFIAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000585")]
	private PHJGIMFDNFB ELANMAGHLLI;

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x67C1960", Offset = "0x67C0960", VA = "0x1867C1960")]
	public static Task<Scene> ECGIFJIHMEG(NKMCDKBACFE EFBGGNOIPLA, KKBFOFAMKMI AMPMFKMDFMB, MFEMJMGOOCM<string>.ENJHCLDNEDD HKNHNBDNOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x67C1BD0", Offset = "0x67C0BD0", VA = "0x1867C1BD0")]
	[AsyncStateMachine(typeof(ODFGBEFCICI))]
	private Task<Scene> OIOCKJJDGEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x67C19E0", Offset = "0x67C09E0", VA = "0x1867C19E0")]
	private bool FCDCFMAPEHO(PHJGIMFDNFB ELANMAGHLLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x67C1B60", Offset = "0x67C0B60", VA = "0x1867C1B60")]
	private void KLJBEAEIGIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x67C1A10", Offset = "0x67C0A10", VA = "0x1867C1A10")]
	[AsyncStateMachine(typeof(BOEFENOPMOP))]
	private Task<Scene> JJEEIMAGIBL(string KIPEOJGAHCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
internal struct ANKMKGBMFIA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct OFFFECAKKGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public AsyncTaskMethodBuilder<ICBELHKHBOH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public ANKMKGBMFIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public ICBELHKHBOH nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public PHJGIMFDNFB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private TaskAwaiter<ICBELHKHBOH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x67D5400", Offset = "0x67D4400", VA = "0x1867D5400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x67D5EE0", Offset = "0x67D4EE0", VA = "0x1867D5EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct JOLJEBPBBPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public AsyncTaskMethodBuilder<ICBELHKHBOH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public ANKMKGBMFIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public ICBELHKHBOH state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private TaskAwaiter<JLMLKKANJKN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x67CD0D0", Offset = "0x67CC0D0", VA = "0x1867CD0D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x67CD3B0", Offset = "0x67CC3B0", VA = "0x1867CD3B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000593")]
	private readonly ABNEBIHJBDL FIOPLFIAJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000594")]
	private readonly MGPMMGPNEHM CNCONLPHCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000595")]
	private readonly HLPEAAEEDLI PPGDLMGHECA;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private CAMAINJFJEE PHGPKDLFKCH
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x505F200", Offset = "0x505E200", VA = "0x18505F200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x67C2BE0", Offset = "0x67C1BE0", VA = "0x1867C2BE0")]
	public ANKMKGBMFIA(ABNEBIHJBDL FIOPLFIAJDP, MGPMMGPNEHM CNCONLPHCPH, HLPEAAEEDLI PPGDLMGHECA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x67C28B0", Offset = "0x67C18B0", VA = "0x1867C28B0")]
	[AsyncStateMachine(typeof(OFFFECAKKGP))]
	public Task<ICBELHKHBOH> EAOPILOALOD(ICBELHKHBOH HBKHMEILLIF, PHJGIMFDNFB FOKBHBDLHJI, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM, bool AODGEINNPOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x67C2A80", Offset = "0x67C1A80", VA = "0x1867C2A80")]
	[AsyncStateMachine(typeof(JOLJEBPBBPP))]
	private Task<ICBELHKHBOH> MHOGFDIKCHF(MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, ICBELHKHBOH NLJIDPFGNFP, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x67C2A30", Offset = "0x67C1A30", VA = "0x1867C2A30")]
	private bool IOAGJDMMDFO(ICBELHKHBOH IHFBDPJHLHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x67C2A60", Offset = "0x67C1A60", VA = "0x1867C2A60")]
	private void LFPFJBDDFDP(string ONOCGJKGBIA)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct BCFGJBIIBPD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct BCDBHPHLLMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public CAMAINJFJEE operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public PHJGIMFDNFB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public HJCNEOFBDMI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		private MAPKHCDKFJB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		private List<(PersistenceView, CLAFHIEHHKM)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private (PersistenceView, CLAFHIEHHKM) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x67C2F90", Offset = "0x67C1F90", VA = "0x1867C2F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x67C35A0", Offset = "0x67C25A0", VA = "0x1867C35A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x67C3600", Offset = "0x67C2600", VA = "0x1867C3600")]
	[AsyncStateMachine(typeof(BCDBHPHLLMC))]
	public static Task OIOCKJJDGEP(CAMAINJFJEE ODMOFOFBMIL, PHJGIMFDNFB ELANMAGHLLI, HJCNEOFBDMI CFDAJLACEJA, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal struct DBMJGNLEBCA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct NBBKHNCJEBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public CAMAINJFJEE operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public PHJGIMFDNFB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public HJCNEOFBDMI timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private KJKAGNONJMJ <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private MAPKHCDKFJB <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private List<(PersistenceView, CLAFHIEHHKM)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private CLAFHIEHHKM <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x67D2920", Offset = "0x67D1920", VA = "0x1867D2920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x67D3170", Offset = "0x67D2170", VA = "0x1867D3170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x67C5C80", Offset = "0x67C4C80", VA = "0x1867C5C80")]
	[AsyncStateMachine(typeof(NBBKHNCJEBA))]
	public static Task OIOCKJJDGEP(CAMAINJFJEE ODMOFOFBMIL, PHJGIMFDNFB ELANMAGHLLI, HJCNEOFBDMI CFDAJLACEJA, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal struct PBAFIKKMAME
{
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	public struct ACPIPDPGFGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public List<PHBOOLAONDI> OFPDFGCMPMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public List<CLAFHIEHHKM> AGLMKLAMAPL;

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x909C10", Offset = "0x908C10", VA = "0x180909C10")]
		public ACPIPDPGFGM(List<PHBOOLAONDI> OFPDFGCMPMM, List<CLAFHIEHHKM> AGLMKLAMAPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class PGHPBINFGKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public IEnumerable<PHBOOLAONDI> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public PGHPBINFGKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x67D8CD0", Offset = "0x67D7CD0", VA = "0x1867D8CD0")]
		internal object ABOHCHGLPOG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C2")]
	private NKMCDKBACFE EFBGGNOIPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C3")]
	private PHJGIMFDNFB ELANMAGHLLI;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private AJDCIPBGOJA CBHMMKHDHNK
	{
		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x67D7510", Offset = "0x67D6510", VA = "0x1867D7510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x67D7560", Offset = "0x67D6560", VA = "0x1867D7560")]
	public static ACPIPDPGFGM OIOCKJJDGEP(NKMCDKBACFE EFBGGNOIPLA, PHJGIMFDNFB ELANMAGHLLI)
	{
		return default(ACPIPDPGFGM);
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x67D75C0", Offset = "0x67D65C0", VA = "0x1867D75C0")]
	private ACPIPDPGFGM OIOCKJJDGEP()
	{
		return default(ACPIPDPGFGM);
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x67D6F60", Offset = "0x67D5F60", VA = "0x1867D6F60")]
	private ACPIPDPGFGM JBJFPFNDFGA(GBMJEMECJOI MLIFACLLCMJ, KJKAGNONJMJ BEPINABCJNO)
	{
		return default(ACPIPDPGFGM);
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x67D6D90", Offset = "0x67D5D90", VA = "0x1867D6D90")]
	private bool HJKANEAFOLI(IEnumerable<PHBOOLAONDI> OFPDFGCMPMM)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000161")]
internal struct FONGLFHDJGM
{
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class FDKLLJAKFCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public PBAFIKKMAME.ACPIPDPGFGM instantiations;

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public FDKLLJAKFCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x67C9E60", Offset = "0x67C8E60", VA = "0x1867C9E60")]
		internal object NEEHFCPDKFC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private sealed class MGKDHFBBADD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public MGKDHFBBADD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x67D1CD0", Offset = "0x67D0CD0", VA = "0x1867D1CD0")]
		internal object EELMGEGKIKP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x67CA5B0", Offset = "0x67C95B0", VA = "0x1867CA5B0")]
	public static void OIOCKJJDGEP(CAMAINJFJEE ODMOFOFBMIL, PHJGIMFDNFB ELANMAGHLLI, PBAFIKKMAME.ACPIPDPGFGM EPIECKIJNMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
internal class HLPEAAEEDLI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct NLNCGMCELAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public HLPEAAEEDLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public ICBELHKHBOH operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public PHJGIMFDNFB deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x67D4650", Offset = "0x67D3650", VA = "0x1867D4650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x67D4DC0", Offset = "0x67D3DC0", VA = "0x1867D4DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private sealed class MPNGHMGCPFL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000167")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005D8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005D9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005DA")]
			public MPNGHMGCPFL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005DB")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005DC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005AA")]
			[Cpp2IlInjected.Address(RVA = "0x67D9930", Offset = "0x67D8930", VA = "0x1867D9930", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x67D9BF0", Offset = "0x67D8BF0", VA = "0x1867D9BF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public HLPEAAEEDLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public PHJGIMFDNFB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public MPNGHMGCPFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x67D2830", Offset = "0x67D1830", VA = "0x1867D2830")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task IHLBEALJACI(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct JBPLNMPDBEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public HLPEAAEEDLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public PHJGIMFDNFB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private MPNGHMGCPFL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x67CCB40", Offset = "0x67CBB40", VA = "0x1867CCB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x67CD070", Offset = "0x67CC070", VA = "0x1867CD070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct NENOPEFPCAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public HLPEAAEEDLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public PHJGIMFDNFB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		private Dictionary<Guid, List<MCOFFDCMDCP>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x67D3550", Offset = "0x67D2550", VA = "0x1867D3550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x67D3B00", Offset = "0x67D2B00", VA = "0x1867D3B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct LJJIKBPOHDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public HLPEAAEEDLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public PHJGIMFDNFB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		private MFEMJMGOOCM<string>.ENJHCLDNEDD <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		private Dictionary<Guid, List<MCOFFDCMDCP>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x67D10F0", Offset = "0x67D00F0", VA = "0x1867D10F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x67D1770", Offset = "0x67D0770", VA = "0x1867D1770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class PJAOADEJEEN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016C")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005FC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005FD")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005FE")]
			public MCOFFDCMDCP handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005FF")]
			public PJAOADEJEEN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000600")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x67D9730", Offset = "0x67D8730", VA = "0x1867D9730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B7")]
			[Cpp2IlInjected.Address(RVA = "0x67D98D0", Offset = "0x67D88D0", VA = "0x1867D98D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public KGMCJEPIICM runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public List<MCOFFDCMDCP> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public PHJGIMFDNFB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public PJAOADEJEEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x67D8D50", Offset = "0x67D7D50", VA = "0x1867D8D50")]
		internal object FLOLDECOMKE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x67D8F30", Offset = "0x67D7F30", VA = "0x1867D8F30")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task MGCECGKFGGN(MCOFFDCMDCP handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x67D8E40", Offset = "0x67D7E40", VA = "0x1867D8E40")]
		internal object GDEKJFJDKNP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private struct FAJMGJLGOFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public KGMCJEPIICM runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public List<MCOFFDCMDCP> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public PHJGIMFDNFB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		private PJAOADEJEEN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x67C8A70", Offset = "0x67C7A70", VA = "0x1867C8A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x67C8F40", Offset = "0x67C7F40", VA = "0x1867C8F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private struct EBKDGBHHFLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public HLPEAAEEDLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public PHJGIMFDNFB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x67C6280", Offset = "0x67C5280", VA = "0x1867C6280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x67C6840", Offset = "0x67C5840", VA = "0x1867C6840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private sealed class DNOOANCFAHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public DNOOANCFAHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x67C6210", Offset = "0x67C5210", VA = "0x1867C6210")]
		internal object DOOBDGADMFL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct EEOPHJDGDOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public HLPEAAEEDLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public PHJGIMFDNFB data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x67C68A0", Offset = "0x67C58A0", VA = "0x1867C68A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x67C6D60", Offset = "0x67C5D60", VA = "0x1867C6D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class OHMAFFFBMNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public OHMAFFFBMNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x67D6640", Offset = "0x67D5640", VA = "0x1867D6640")]
		internal object LPMPFPICOAG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct EIFKPJHAHCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public HLPEAAEEDLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		private TaskAwaiter<JLMLKKANJKN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x67C6DC0", Offset = "0x67C5DC0", VA = "0x1867C6DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x67C7400", Offset = "0x67C6400", VA = "0x1867C7400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private sealed class KOBMLDCMECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public KOBMLDCMECN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x67CF990", Offset = "0x67CE990", VA = "0x1867CF990")]
		internal object CBFECCKHNNM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005CA")]
	private readonly ABNEBIHJBDL FIOPLFIAJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005CB")]
	private NNCNLLIIPEJ PPGDLMGHECA;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private CAMAINJFJEE PHGPKDLFKCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x10947C0", Offset = "0x10937C0", VA = "0x1810947C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
	public HLPEAAEEDLI(ABNEBIHJBDL FIOPLFIAJDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x67CC630", Offset = "0x67CB630", VA = "0x1867CC630")]
	[AsyncStateMachine(typeof(NLNCGMCELAG))]
	public Task OIOCKJJDGEP(ICBELHKHBOH DMIEODBAHPE, PHJGIMFDNFB FOKBHBDLHJI, MFEMJMGOOCM<string>.ENJHCLDNEDD HKNHNBDNOFH, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x67CBE10", Offset = "0x67CAE10", VA = "0x1867CBE10")]
	[AsyncStateMachine(typeof(JBPLNMPDBEB))]
	private Task EEKPJODPIBI(PHJGIMFDNFB ELANMAGHLLI, MFEMJMGOOCM<string>.ENJHCLDNEDD HKNHNBDNOFH, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x67CC910", Offset = "0x67CB910", VA = "0x1867CC910")]
	[AsyncStateMachine(typeof(NENOPEFPCAE))]
	private Task POFNPIHAFOE(PHJGIMFDNFB ELANMAGHLLI, MFEMJMGOOCM<string>.ENJHCLDNEDD HKNHNBDNOFH, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x67CC090", Offset = "0x67CB090", VA = "0x1867CC090")]
	[AsyncStateMachine(typeof(LJJIKBPOHDO))]
	private Task GNCCGJILDPM(PHJGIMFDNFB ELANMAGHLLI, MFEMJMGOOCM<string>.ENJHCLDNEDD HKNHNBDNOFH, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x67CC1D0", Offset = "0x67CB1D0", VA = "0x1867CC1D0")]
	[AsyncStateMachine(typeof(FAJMGJLGOFN))]
	private Task JACHFNJDNBP(Guid DDBCJGDOEFB, List<MCOFFDCMDCP> KMHJOMECIHK, KGMCJEPIICM GPHAFBEDOKJ, PHJGIMFDNFB ELANMAGHLLI, CancellationToken OGACLNNOKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x67CBF50", Offset = "0x67CAF50", VA = "0x1867CBF50")]
	[AsyncStateMachine(typeof(EBKDGBHHFLF))]
	private Task GGDAIKNIMLO(PHJGIMFDNFB ELANMAGHLLI, MFEMJMGOOCM<string>.ENJHCLDNEDD HKNHNBDNOFH, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x67CC4F0", Offset = "0x67CB4F0", VA = "0x1867CC4F0")]
	[AsyncStateMachine(typeof(EEOPHJDGDOF))]
	private Task LKEDAHPMOJL(Guid NEOAIOHJCAO, PHJGIMFDNFB ELANMAGHLLI, MFEMJMGOOCM<string>.ENJHCLDNEDD HKNHNBDNOFH, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x67CBAF0", Offset = "0x67CAAF0", VA = "0x1867CBAF0")]
	[AsyncStateMachine(typeof(EIFKPJHAHCA))]
	private Task AKNOKEFIAFP(Guid NEOAIOHJCAO, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x67CC320", Offset = "0x67CB320", VA = "0x1867CC320")]
	private void KFPBODPDCBO(Guid NEOAIOHJCAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x67CC440", Offset = "0x67CB440", VA = "0x1867CC440")]
	private void LGPAHFJGODN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x67CC780", Offset = "0x67CB780", VA = "0x1867CC780")]
	public Guid PJHMHOMOCPG(ICBELHKHBOH OINMMDDFOLD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x67CBC30", Offset = "0x67CAC30", VA = "0x1867CBC30")]
	[CompilerGenerated]
	private object CHBNLNLDOGH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
public readonly struct EGBBBOLAJBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000628")]
	public readonly bool LBCPGBNDHKB;

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0xCB5E60", Offset = "0xCB4E60", VA = "0x180CB5E60")]
	public EGBBBOLAJBE(bool CEFAODKBBCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
public readonly struct ELNOFCBKAIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000629")]
	public readonly GBMJEMECJOI? BLCNAMCGPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400062A")]
	public readonly LJEFADPBJFC IMOJCPIDOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400062B")]
	public readonly string? OEDDJHJDLFF;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public IReadOnlyCollection<string> KOJPLHANKKM
	{
		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x67C7D30", Offset = "0x67C6D30", VA = "0x1867C7D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public IReadOnlyDictionary<long, int> APFGANACPFM
	{
		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x67C7D10", Offset = "0x67C6D10", VA = "0x1867C7D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x67C7D50", Offset = "0x67C6D50", VA = "0x1867C7D50")]
	public ELNOFCBKAIC(GBMJEMECJOI? PCNPJGFONNP, LJEFADPBJFC OPKCBEABKFP, string? MJPLOANBPHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
internal class KKOJHBDNKNO : AFEAAELBDBA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct OLHEBNMAGAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public AsyncTaskMethodBuilder<ELNOFCBKAIC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public KKOJHBDNKNO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public GMLLKOPLHNF serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public HODALNOLPKL roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		private MAPKHCDKFJB <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x67D66B0", Offset = "0x67D56B0", VA = "0x1867D66B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x67D6D20", Offset = "0x67D5D20", VA = "0x1867D6D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class PGCKGENENAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public GMLLKOPLHNF serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public KKOJHBDNKNO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public PGCKGENENAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x67D8AB0", Offset = "0x67D7AB0", VA = "0x1867D8AB0")]
		internal Task KCDNPDDKJKL(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x67D89D0", Offset = "0x67D79D0", VA = "0x1867D89D0")]
		internal Task FGKIHPOEODF(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private sealed class ILMLGKMBFIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public PGCKGENENAI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public ILMLGKMBFIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x67CCAD0", Offset = "0x67CBAD0", VA = "0x1867CCAD0")]
		internal object GCHOJKGKFKA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private sealed class FKNGBEKJCOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public PGCKGENENAI CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public FKNGBEKJCOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x67CA570", Offset = "0x67C9570", VA = "0x1867CA570")]
		internal Task NEHMICLDELN(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct FBMAJCBLEKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public GMLLKOPLHNF serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public KKOJHBDNKNO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private ILMLGKMBFIJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		private MAPKHCDKFJB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x67C8FA0", Offset = "0x67C7FA0", VA = "0x1867C8FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x67C9810", Offset = "0x67C8810", VA = "0x1867C9810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400062C")]
	private readonly LPCGADPJIJD IJDHPGKKFNN;

	[Cpp2IlInjected.Token(Token = "0x400062D")]
	private static readonly TimeSpan NBLOFDPDCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400062E")]
	private readonly JEFCAAJOONN GMFECHNJBAB;

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x67CEF90", Offset = "0x67CDF90", VA = "0x1867CEF90")]
	public KKOJHBDNKNO(ABNEBIHJBDL FIOPLFIAJDP, JEFCAAJOONN GMFECHNJBAB, LPCGADPJIJD IJDHPGKKFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x67CEB70", Offset = "0x67CDB70", VA = "0x1867CEB70")]
	[AsyncStateMachine(typeof(OLHEBNMAGAD))]
	public Task<ELNOFCBKAIC> PAKOMNGHIKD(long MBGBJFLBPMH, HODALNOLPKL GGECJBIIMFM, GMLLKOPLHNF APCBEKFBKDB, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x67CE100", Offset = "0x67CD100", VA = "0x1867CE100")]
	[AsyncStateMachine(typeof(FBMAJCBLEKB))]
	private Task FGDICNOOAMO(GMLLKOPLHNF APCBEKFBKDB, IEnumerable<PersistenceView> JIMPAEDHKKD, StringBuilder KAFIAJCHBIH, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x67CE240", Offset = "0x67CD240", VA = "0x1867CE240")]
	private ELNOFCBKAIC FKFINGJKBEO(long MBGBJFLBPMH, HODALNOLPKL GGECJBIIMFM, GMLLKOPLHNF APCBEKFBKDB, IEnumerable<PersistenceView> JIMPAEDHKKD, StringBuilder KAFIAJCHBIH)
	{
		return default(ELNOFCBKAIC);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x67CDF40", Offset = "0x67CCF40", VA = "0x1867CDF40")]
	private GBMJEMECJOI EGBNIFLEBJP(long MBGBJFLBPMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x67CECD0", Offset = "0x67CDCD0", VA = "0x1867CECD0")]
	private void PMFFEBBKHGG(GBMJEMECJOI IPANBOPGHMA, StringBuilder KAFIAJCHBIH, IEnumerable<PersistenceView> JIMPAEDHKKD, [In] PCDOIBNDDIK COIDJBMJKKI, PIBMDDKMLNE HMIGNIMACFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x67CE6D0", Offset = "0x67CD6D0", VA = "0x1867CE6D0")]
	private void NMOEMNHFHEI(GBMJEMECJOI IPANBOPGHMA, StringBuilder KAFIAJCHBIH, PersistenceView LAOJDFENHDK, PIBMDDKMLNE HMIGNIMACFE, [In] PCDOIBNDDIK COIDJBMJKKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal class OFOPOPDFFGM : AFEAAELBDBA
{
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private sealed class NGCHHACINFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public OJENABDAKEL.PCMOPFCDMGL roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public NGCHHACINFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x67D3B60", Offset = "0x67D2B60", VA = "0x1867D3B60")]
		internal object PCJCIEHEHAI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct EJNBGPPKAIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public AsyncTaskMethodBuilder<(OJENABDAKEL.PCMOPFCDMGL roomDataUpload, OJENABDAKEL.PCMOPFCDMGL subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public ELNOFCBKAIC roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public OFOPOPDFFGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		private NGCHHACINFO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		private TaskAwaiter<OJENABDAKEL.PCMOPFCDMGL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x67C7460", Offset = "0x67C6460", VA = "0x1867C7460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x67C7CA0", Offset = "0x67C6CA0", VA = "0x1867C7CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct CEPEIGHHCPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public AsyncTaskMethodBuilder<FAOIIDCCPMP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public OFOPOPDFFGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public ELNOFCBKAIC roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public MMDLGPJHFOP roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		private TaskAwaiter<(OJENABDAKEL.PCMOPFCDMGL roomDataUpload, OJENABDAKEL.PCMOPFCDMGL subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		private TaskAwaiter<FAOIIDCCPMP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x67C45D0", Offset = "0x67C35D0", VA = "0x1867C45D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x67C4BF0", Offset = "0x67C3BF0", VA = "0x1867C4BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private struct MKCAIBJFPDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		public AsyncTaskMethodBuilder<BDLKEIKIHPI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public OFOPOPDFFGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		public ELNOFCBKAIC roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		private TaskAwaiter<(OJENABDAKEL.PCMOPFCDMGL roomDataUpload, OJENABDAKEL.PCMOPFCDMGL subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		private TaskAwaiter<BDLKEIKIHPI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x67D23A0", Offset = "0x67D13A0", VA = "0x1867D23A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x67D27C0", Offset = "0x67D17C0", VA = "0x1867D27C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class DLELBMEIBHM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000184")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400067A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400067B")]
			public AsyncTaskMethodBuilder<JLMLKKANJKN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400067C")]
			public DLELBMEIBHM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400067D")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400067E")]
			private JLMLKKANJKN <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400067F")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000680")]
			private TaskAwaiter<BDLKEIKIHPI> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000681")]
			private TaskAwaiter<FAOIIDCCPMP> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000682")]
			private TaskAwaiter<JLMLKKANJKN> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0x67D9C50", Offset = "0x67D8C50", VA = "0x1867D9C50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x67DABE0", Offset = "0x67D9BE0", VA = "0x1867DABE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public OFOPOPDFFGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public ELNOFCBKAIC roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public MMDLGPJHFOP roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public EGBBBOLAJBE roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public DLELBMEIBHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x67C60E0", Offset = "0x67C50E0", VA = "0x1867C60E0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<JLMLKKANJKN> BPCDGNJEAOG(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private struct NBGKFBJNMLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public AsyncTaskMethodBuilder<JLMLKKANJKN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public OFOPOPDFFGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public ELNOFCBKAIC roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public MMDLGPJHFOP roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public EGBBBOLAJBE roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public MFEMJMGOOCM<string>.ENJHCLDNEDD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		private TaskAwaiter<JLMLKKANJKN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x67D31D0", Offset = "0x67D21D0", VA = "0x1867D31D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x67D34E0", Offset = "0x67D24E0", VA = "0x1867D34E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000651")]
	private static readonly LPCGADPJIJD IJDHPGKKFNN;

	[Cpp2IlInjected.Token(Token = "0x4000652")]
	private static readonly LPCGADPJIJD GCGIPLANDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000653")]
	private readonly KGBIEPEIHBD FFBNKBLNLOL;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private NKMCDKBACFE NMGMHHMNPAL
	{
		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x67AABC0", Offset = "0x67A9BC0", VA = "0x1867AABC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x67D65B0", Offset = "0x67D55B0", VA = "0x1867D65B0")]
	public OFOPOPDFFGM(ABNEBIHJBDL FIOPLFIAJDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x67D63D0", Offset = "0x67D53D0", VA = "0x1867D63D0")]
	[AsyncStateMachine(typeof(EJNBGPPKAIM))]
	private Task<(OJENABDAKEL.PCMOPFCDMGL, OJENABDAKEL.PCMOPFCDMGL)> PLBBOFPBOGP(ELNOFCBKAIC JGCDJIMGDNO, long INFPDCJCIBN, long CNPHGBDAJDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x67D5F50", Offset = "0x67D4F50", VA = "0x1867D5F50")]
	[AsyncStateMachine(typeof(CEPEIGHHCPA))]
	public Task<FAOIIDCCPMP> BELOFNCGAAH(int PMCHHGHDAJO, [CanBeNull] MMDLGPJHFOP NKKHAJMLMLH, ELNOFCBKAIC JGCDJIMGDNO, long INFPDCJCIBN, long CNPHGBDAJDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x67D60C0", Offset = "0x67D50C0", VA = "0x1867D60C0")]
	[AsyncStateMachine(typeof(MKCAIBJFPDN))]
	private Task<BDLKEIKIHPI> CACJKOMNGGI(string ENJMNLEIHJP, int PMCHHGHDAJO, ELNOFCBKAIC JGCDJIMGDNO, long INFPDCJCIBN, long CNPHGBDAJDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x67D6230", Offset = "0x67D5230", VA = "0x1867D6230")]
	[AsyncStateMachine(typeof(NBGKFBJNMLG))]
	public Task<JLMLKKANJKN> MPKBGMGPEPD(int PMCHHGHDAJO, MMDLGPJHFOP? NKKHAJMLMLH, ELNOFCBKAIC JGCDJIMGDNO, long INFPDCJCIBN, long CNPHGBDAJDM, EGBBBOLAJBE DNEHJDAJONI, MFEMJMGOOCM<string>.ENJHCLDNEDD OKMEHBGBLCN, CancellationToken JMJKFNJJBHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
public abstract class AGMMGAMMCEP<T> where T : AGMMGAMMCEP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068F")]
	internal readonly NKMCDKBACFE MMBDOMODOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000690")]
	private int? HMMBLHCKLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000691")]
	protected readonly Guid CPHBLMDNGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000692")]
	protected readonly DDMMJNHFCED KODJIDLGCOC;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	protected T JFEAGKDBBAD
	{
		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x37A33D0", Offset = "0x37A23D0", VA = "0x1837A33D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x37A36C0", Offset = "0x37A26C0", VA = "0x1837A36C0")]
	internal AGMMGAMMCEP(NKMCDKBACFE MENGDBDPDHG, DDMMJNHFCED AKNBDBHMBDA, [Optional] Guid? FCBFKEBMKED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x37A35E0", Offset = "0x37A25E0", VA = "0x1837A35E0")]
	private JLMLKKANJKN PGLDJMBJDKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "4")]
	protected virtual void PDGMBPGJFAK(JLMLKKANJKN DFJKCKBFLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x37A32E0", Offset = "0x37A22E0", VA = "0x1837A32E0")]
	public T CLINIAPBDIL(IDMICLLCMKN KOIELLGDMII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x37A3550", Offset = "0x37A2550", VA = "0x1837A3550")]
	public T ODAEDFDDBII(int OJGOBMKPBEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x37A3430", Offset = "0x37A2430", VA = "0x1837A3430", Slot = "5")]
	public virtual Task<LGMMDMPNFIF> MICADKKFAKP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
public class MCEINMCGGAN : AGMMGAMMCEP<MCEINMCGGAN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000693")]
	private EGDMKLHIGGO CEFJMHIOKFM;

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x67D1C00", Offset = "0x67D0C00", VA = "0x1867D1C00")]
	internal MCEINMCGGAN(NKMCDKBACFE MENGDBDPDHG, DDMMJNHFCED AKNBDBHMBDA, [Optional] Guid? FCBFKEBMKED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3B60", Offset = "0x5DF2B60", VA = "0x185DF3B60")]
	public MCEINMCGGAN LDCEAELJFIG(EGDMKLHIGGO CEFJMHIOKFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x67D1B30", Offset = "0x67D0B30", VA = "0x1867D1B30", Slot = "4")]
	protected override void PDGMBPGJFAK(JLMLKKANJKN DFJKCKBFLAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
public class FJIDIBPLAGN : AGMMGAMMCEP<FJIDIBPLAGN>
{
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	internal enum KHLBHNPILAE
	{
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private struct GFOLFJKDONE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public AsyncTaskMethodBuilder<LGMMDMPNFIF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		public FJIDIBPLAGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private TaskAwaiter<LGMMDMPNFIF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x67CB6D0", Offset = "0x67CA6D0", VA = "0x1867CB6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x67CBA80", Offset = "0x67CAA80", VA = "0x1867CBA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000694")]
	private KHLBHNPILAE ABDDPCCDGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000695")]
	private string AAHGABMOLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000696")]
	private MMDLGPJHFOP CEFJMHIOKFM;

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x67CA230", Offset = "0x67C9230", VA = "0x1867CA230")]
	internal FJIDIBPLAGN(NKMCDKBACFE MENGDBDPDHG, DDMMJNHFCED AKNBDBHMBDA, [Optional] Guid? FCBFKEBMKED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x67CA060", Offset = "0x67C9060", VA = "0x1867CA060")]
	public FJIDIBPLAGN NNEFBBIOMJJ(string LLMKDGFJDOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x67C9F50", Offset = "0x67C8F50", VA = "0x1867C9F50")]
	public FJIDIBPLAGN MBFEGMEPOMD(bool BCOGMPLKBEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x67CA090", Offset = "0x67C9090", VA = "0x1867CA090")]
	public FJIDIBPLAGN OLABCPMFKGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x67CA0C0", Offset = "0x67C90C0", VA = "0x1867CA0C0", Slot = "4")]
	protected override void PDGMBPGJFAK(JLMLKKANJKN DFJKCKBFLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x67C9F70", Offset = "0x67C8F70", VA = "0x1867C9F70", Slot = "5")]
	[AsyncStateMachine(typeof(GFOLFJKDONE))]
	public override Task<LGMMDMPNFIF> MICADKKFAKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x67C9F10", Offset = "0x67C8F10", VA = "0x1867C9F10")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<LGMMDMPNFIF> CADPHILFCCB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal static class FJKGFOLKHKM
{
	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x67CA3A0", Offset = "0x67C93A0", VA = "0x1867CA3A0")]
	public static void BGCKBCJGJJH(this KFHBOBCFAJF LCEEJAFEKCF, ICNKHIIJEIP PPAPOBOILOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x67CA4F0", Offset = "0x67C94F0", VA = "0x1867CA4F0")]
	public static void EMFDHIPEJAO(this ICNKHIIJEIP HCHLADPIBDM, [Optional] string DFJKCKBFLAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
public static class KJGHNBPCGGC
{
	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x67CDEA0", Offset = "0x67CCEA0", VA = "0x1867CDEA0")]
	public static HJJELDEPGMC PALNDPGALLD(this LGACNDDLIJJ EMGGNDDDKPO)
	{
		return default(HJJELDEPGMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x67CDDF0", Offset = "0x67CCDF0", VA = "0x1867CDDF0")]
	public static LGACNDDLIJJ NJFBICBPNMA(this HJJELDEPGMC GMEAAONBJNB)
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
			[Cpp2IlInjected.Token(Token = "0x40006A3")]
			public IFPBPHJPBIP ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006A4")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006A5")]
			public IFPBPHJPBIP HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006A6")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006A7")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006A8")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		private static IFPBPHJPBIP[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		private Dictionary<IFPBPHJPBIP, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x67DBB70", Offset = "0x67DAB70", VA = "0x1867DBB70")]
		public bool PNKMKNPBNIJ(IFPBPHJPBIP CJGNPMMJNFF, [Out] ResultConfig DJEDGNFIGON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x67DB2E0", Offset = "0x67DA2E0", VA = "0x1867DB2E0")]
		public ResultConfig GJILIBFHOGG(IFPBPHJPBIP CPHMIDDIJGK, [Optional] HashSet<IFPBPHJPBIP> OLPCPCDFBOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x67DB980", Offset = "0x67DA980", VA = "0x1867DB980", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x67DB420", Offset = "0x67DA420", VA = "0x1867DB420", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x8A4C00", Offset = "0x8A3C00", VA = "0x1808A4C00")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public static class JOMLJPIFANB
{
	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x67CD420", Offset = "0x67CC420", VA = "0x1867CD420")]
	[KEBGMDILACL(JMIJNHPDBML.GameOnly)]
	private static void FKKENIGIKEJ(ONGJLMJLNJA COPEDPCEBKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
public interface KLKBPFAMHHJ : IEquatable<KLKBPFAMHHJ>
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	DateTime JNFOHKIEMLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HBCEKGEGKFI();

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CABPMKGMBHL(long INFPDCJCIBN, long MBGBJFLBPMH, [Out] ELNOFCBKAIC JGCDJIMGDNO);
}
[Cpp2IlInjected.Token(Token = "0x2000192")]
internal class AMCFJIOCPKL : HJHFFGLMGOI
{
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private sealed class KABOCIMFKOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public APEKBBKGICD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public KABOCIMFKOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x67CD8E0", Offset = "0x67CC8E0", VA = "0x1867CD8E0")]
		internal object JHELCMHDJGK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006AE")]
	private readonly NABGMGFEPOC ICDMNCIGKEB;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<KLKBPFAMHHJ> DLKPIBIGEEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x67C1DA0", Offset = "0x67C0DA0", VA = "0x1867C1DA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x67C1CF0", Offset = "0x67C0CF0", VA = "0x1867C1CF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
	[UnityEngine.Scripting.Preserve]
	public AMCFJIOCPKL([CJCLEPGLAOP(null)] NABGMGFEPOC ICDMNCIGKEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x67C2460", Offset = "0x67C1460", VA = "0x1867C2460", Slot = "6")]
	public bool JOLFJCFJHKA(long INFPDCJCIBN, long MBGBJFLBPMH, ELNOFCBKAIC JGCDJIMGDNO, APEKBBKGICD EIJDFFMEHGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x1A161A0", Offset = "0x1A151A0", VA = "0x181A161A0")]
	private void CCFAPMJJKEK(KLKBPFAMHHJ IJBMPEEKNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x67C2740", Offset = "0x67C1740", VA = "0x1867C2740", Slot = "7")]
	public bool OHEPGGDHHJG(long INFPDCJCIBN, long MBGBJFLBPMH, [Out] KLKBPFAMHHJ NNNOIAJIGGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x67C2280", Offset = "0x67C1280", VA = "0x1867C2280", Slot = "8")]
	public bool IDLFIFNGCKA(long INFPDCJCIBN, long MBGBJFLBPMH, APEKBBKGICD EIJDFFMEHGJ, [Out] KLKBPFAMHHJ NNNOIAJIGGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x67C1E50", Offset = "0x67C0E50", VA = "0x1867C1E50")]
	private void GAOMGDOFPPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x67C2330", Offset = "0x67C1330", VA = "0x1867C2330", Slot = "9")]
	public void JGLKKIMFKLK(long INFPDCJCIBN, long MBGBJFLBPMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
internal abstract class NLDFEMOCNPC : NABGMGFEPOC
{
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	protected enum KDFEPBECDAH : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private sealed class KNFJIOIMAGI : IEnumerable<KLKBPFAMHHJ>, IEnumerable, IEnumerator<KLKBPFAMHHJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private KLKBPFAMHHJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public NLDFEMOCNPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private APEKBBKGICD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public APEKBBKGICD <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		private KLKBPFAMHHJ System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000642")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x80FF60", Offset = "0x80EF60", VA = "0x18080FF60")]
		[DebuggerHidden]
		public KNFJIOIMAGI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x67CF660", Offset = "0x67CE660", VA = "0x1867CF660", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x67CF940", Offset = "0x67CE940", VA = "0x1867CF940", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x67CF890", Offset = "0x67CE890", VA = "0x1867CF890", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KLKBPFAMHHJ> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x67CF890", Offset = "0x67CE890", VA = "0x1867CF890", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private sealed class PLAFBFLBCED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		public APEKBBKGICD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public PLAFBFLBCED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x67D9020", Offset = "0x67D8020", VA = "0x1867D9020")]
		internal object GFGPMKMGKDL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private sealed class LJPDIJNIABC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public NLDFEMOCNPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public LJPDIJNIABC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x67D17D0", Offset = "0x67D07D0", VA = "0x1867D17D0")]
		internal void GDENMNIIJKJ(NALLKCHCOFL.FPGBBMAKNFE ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B4")]
	protected readonly string PCMIGNDHGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006B5")]
	private readonly object DJOEPJHJDHM;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract NHNLLIOGMAO LGGJAJNAPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x67D45B0", Offset = "0x67D35B0", VA = "0x1867D45B0")]
	protected NLDFEMOCNPC([CanBeNull] string GCHCLIBNGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x67D3FB0", Offset = "0x67D2FB0", VA = "0x1867D3FB0", Slot = "5")]
	public bool FGOOHEOODJH(long INFPDCJCIBN, long MBGBJFLBPMH, APEKBBKGICD EIJDFFMEHGJ, [Out] KLKBPFAMHHJ IJBMPEEKNEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x67D4520", Offset = "0x67D3520", VA = "0x1867D4520", Slot = "6")]
	[IteratorStateMachine(typeof(KNFJIOIMAGI))]
	public IEnumerable<KLKBPFAMHHJ> OFEAHNKHCAN(APEKBBKGICD EIJDFFMEHGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void LHGPAJMGPIL(Stream DANGHNJAJCG, long INFPDCJCIBN, long MBGBJFLBPMH, ELNOFCBKAIC JGCDJIMGDNO);

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool DEOLOABDHIH(Stream CPJOLCGCDFM, long INFPDCJCIBN, long MBGBJFLBPMH, JDNJLGEOCKJ MELCLBGPNHN, [Out] ELNOFCBKAIC JGCDJIMGDNO);

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x67D41A0", Offset = "0x67D31A0", VA = "0x1867D41A0", Slot = "7")]
	public KLKBPFAMHHJ LHDFKOMFFKP(long INFPDCJCIBN, long MBGBJFLBPMH, ELNOFCBKAIC JGCDJIMGDNO, APEKBBKGICD EIJDFFMEHGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo PDFJHAFGFFM(long INFPDCJCIBN, long MBGBJFLBPMH, APEKBBKGICD EIJDFFMEHGJ, KDFEPBECDAH DCLJAAIPAGD);

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo BAECFPDAHHN(APEKBBKGICD EIJDFFMEHGJ, KDFEPBECDAH DCLJAAIPAGD);

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x67D3F40", Offset = "0x67D2F40", VA = "0x1867D3F40")]
	protected void DLGMLBGPNEK(NALLKCHCOFL.FPGBBMAKNFE BDOOPIHHMAH, string ONOCGJKGBIA, FileInfo EMHHMLHPBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x67D3BB0", Offset = "0x67D2BB0", VA = "0x1867D3BB0")]
	internal bool AMCIPDBNMMJ(FileInfo CJFDAMCMHJJ, long INFPDCJCIBN, long MBGBJFLBPMH, [Out] ELNOFCBKAIC JGCDJIMGDNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280")]
	private void EINLLBBGJNO(Exception KGGEIOKLINA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
internal class ENPMGDLAEDI : NLDFEMOCNPC
{
	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public override NHNLLIOGMAO LGGJAJNAPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0xAC4950", Offset = "0xAC3950", VA = "0x180AC4950", Slot = "8")]
		get
		{
			return default(NHNLLIOGMAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x67C89B0", Offset = "0x67C79B0", VA = "0x1867C89B0")]
	public ENPMGDLAEDI([Optional] string GCHCLIBNGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x67C85B0", Offset = "0x67C75B0", VA = "0x1867C85B0")]
	private void GKABOIJDJPH(APEKBBKGICD EIJDFFMEHGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x67C8630", Offset = "0x67C7630", VA = "0x1867C8630", Slot = "9")]
	internal override void LHGPAJMGPIL(Stream DANGHNJAJCG, long INFPDCJCIBN, long MBGBJFLBPMH, ELNOFCBKAIC JGCDJIMGDNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x67C7F60", Offset = "0x67C6F60", VA = "0x1867C7F60", Slot = "10")]
	internal override bool DEOLOABDHIH(Stream CPJOLCGCDFM, long INFPDCJCIBN, long MBGBJFLBPMH, JDNJLGEOCKJ MELCLBGPNHN, [Out] ELNOFCBKAIC JGCDJIMGDNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x67C88C0", Offset = "0x67C78C0", VA = "0x1867C88C0", Slot = "11")]
	protected override FileInfo PDFJHAFGFFM(long INFPDCJCIBN, long MBGBJFLBPMH, APEKBBKGICD EIJDFFMEHGJ, KDFEPBECDAH DCLJAAIPAGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x67C7E50", Offset = "0x67C6E50", VA = "0x1867C7E50", Slot = "12")]
	protected override DirectoryInfo BAECFPDAHHN(APEKBBKGICD EIJDFFMEHGJ, KDFEPBECDAH DCLJAAIPAGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
internal sealed class LDJHMMLNHGI : NLDFEMOCNPC
{
	[Cpp2IlInjected.Token(Token = "0x40006C5")]
	private static readonly byte[] IPAJBJLLPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006C6")]
	private readonly byte[] DPENDHPNENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006C7")]
	private readonly byte[] AAONHIPBAJE;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public override NHNLLIOGMAO LGGJAJNAPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x56ACF10", Offset = "0x56ABF10", VA = "0x1856ACF10", Slot = "8")]
		get
		{
			return default(NHNLLIOGMAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x67D0F90", Offset = "0x67CFF90", VA = "0x1867D0F90")]
	public LDJHMMLNHGI([Optional] string GCHCLIBNGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x67D0B10", Offset = "0x67CFB10", VA = "0x1867D0B10", Slot = "9")]
	internal override void LHGPAJMGPIL(Stream DANGHNJAJCG, long INFPDCJCIBN, long MBGBJFLBPMH, ELNOFCBKAIC JGCDJIMGDNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x67D0220", Offset = "0x67CF220", VA = "0x1867D0220", Slot = "10")]
	internal override bool DEOLOABDHIH(Stream CPJOLCGCDFM, long INFPDCJCIBN, long MBGBJFLBPMH, JDNJLGEOCKJ MELCLBGPNHN, [Out] ELNOFCBKAIC JGCDJIMGDNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x67D0A50", Offset = "0x67CFA50", VA = "0x1867D0A50")]
	private void FJKBKDEJCLL(byte[] EOMNNFHDHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x67D0DD0", Offset = "0x67CFDD0", VA = "0x1867D0DD0", Slot = "11")]
	protected override FileInfo PDFJHAFGFFM(long INFPDCJCIBN, long MBGBJFLBPMH, APEKBBKGICD EIJDFFMEHGJ, KDFEPBECDAH DCLJAAIPAGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x67D0110", Offset = "0x67CF110", VA = "0x1867D0110", Slot = "12")]
	protected override DirectoryInfo BAECFPDAHHN(APEKBBKGICD EIJDFFMEHGJ, KDFEPBECDAH DCLJAAIPAGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
public enum NHNLLIOGMAO : byte
{
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40006CB")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
internal class BEOJHBEKPFG : NABGMGFEPOC
{
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[CompilerGenerated]
	private sealed class AACEECGLNEL : IEnumerable<KLKBPFAMHHJ>, IEnumerable, IEnumerator<KLKBPFAMHHJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		private KLKBPFAMHHJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		public BEOJHBEKPFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		private APEKBBKGICD autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		public APEKBBKGICD <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		private NHNLLIOGMAO[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		private IEnumerator<KLKBPFAMHHJ> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		private KLKBPFAMHHJ System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000667")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000669")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x80FF60", Offset = "0x80EF60", VA = "0x18080FF60")]
		[DebuggerHidden]
		public AACEECGLNEL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x67C1660", Offset = "0x67C0660", VA = "0x1867C1660", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x67C1280", Offset = "0x67C0280", VA = "0x1867C1280", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x67C1230", Offset = "0x67C0230", VA = "0x1867C1230")]
		private void GFMFCNEFFMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x67C1610", Offset = "0x67C0610", VA = "0x1867C1610", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x67C1560", Offset = "0x67C0560", VA = "0x1867C1560", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KLKBPFAMHHJ> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x67C1560", Offset = "0x67C0560", VA = "0x1867C1560", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006CC")]
	private readonly NHNLLIOGMAO[] ODCAJEHBEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006CD")]
	private readonly Dictionary<NHNLLIOGMAO, NABGMGFEPOC> PPPEINHCHOK;

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public NHNLLIOGMAO LGGJAJNAPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x67C3960", Offset = "0x67C2960", VA = "0x1867C3960", Slot = "4")]
		get
		{
			return default(NHNLLIOGMAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x67C3C50", Offset = "0x67C2C50", VA = "0x1867C3C50")]
	[UnityEngine.Scripting.Preserve]
	public BEOJHBEKPFG(params NABGMGFEPOC[] EBNCAFBALDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x67C3990", Offset = "0x67C2990", VA = "0x1867C3990", Slot = "5")]
	public bool FGOOHEOODJH(long INFPDCJCIBN, long MBGBJFLBPMH, APEKBBKGICD EIJDFFMEHGJ, [Out] KLKBPFAMHHJ IJBMPEEKNEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x67C3740", Offset = "0x67C2740", VA = "0x1867C3740")]
	private void AHGMCIPBAGE(int CJIHFLGMGLK, long INFPDCJCIBN, long MBGBJFLBPMH, APEKBBKGICD EIJDFFMEHGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x67C3BC0", Offset = "0x67C2BC0", VA = "0x1867C3BC0", Slot = "6")]
	[IteratorStateMachine(typeof(AACEECGLNEL))]
	public IEnumerable<KLKBPFAMHHJ> OFEAHNKHCAN(APEKBBKGICD EIJDFFMEHGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x67C3AE0", Offset = "0x67C2AE0", VA = "0x1867C3AE0", Slot = "7")]
	public KLKBPFAMHHJ LHDFKOMFFKP(long INFPDCJCIBN, long MBGBJFLBPMH, ELNOFCBKAIC JGCDJIMGDNO, APEKBBKGICD EIJDFFMEHGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
internal static class DJJKLMJBLIK
{
	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x67C6020", Offset = "0x67C5020", VA = "0x1867C6020")]
	internal static byte[] NLGFKEHMMJO(byte[] EOMNNFHDHII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x67C5FA0", Offset = "0x67C4FA0", VA = "0x1867C5FA0")]
	public static void NLBDACDLJKF(Stream OEHHIKFPHHD, byte[] GIBNIJABBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x67C5DC0", Offset = "0x67C4DC0", VA = "0x1867C5DC0")]
	public static bool APHDFJNBMJP(Stream OEHHIKFPHHD, long JMEDDAGNGBB, JDNJLGEOCKJ JLHAHMGCKEA, [Out] byte[] BFACDGCJKGB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
internal sealed class PLFNKKFDPNB : KLKBPFAMHHJ, IEquatable<KLKBPFAMHHJ>, IEquatable<PLFNKKFDPNB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private readonly NLDFEMOCNPC OGMEOGDFIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	public readonly FileInfo AFNFLEPMDEB;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public NHNLLIOGMAO LGGJAJNAPFP
	{
		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x1F6F860", Offset = "0x1F6E860", VA = "0x181F6F860", Slot = "9")]
		get
		{
			return default(NHNLLIOGMAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public DateTime JNFOHKIEMLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x67D90C0", Offset = "0x67D80C0", VA = "0x1867D90C0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x67D9620", Offset = "0x67D8620", VA = "0x1867D9620")]
	public PLFNKKFDPNB(NLDFEMOCNPC HDLMKJBOGCE, FileInfo CJFDAMCMHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x67D9570", Offset = "0x67D8570", VA = "0x1867D9570", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x67D94B0", Offset = "0x67D84B0", VA = "0x1867D94B0", Slot = "5")]
	public void HBCEKGEGKFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x67D9150", Offset = "0x67D8150", VA = "0x1867D9150", Slot = "6")]
	public bool CABPMKGMBHL(long INFPDCJCIBN, long MBGBJFLBPMH, [Out] ELNOFCBKAIC JGCDJIMGDNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x67D9250", Offset = "0x67D8250", VA = "0x1867D9250", Slot = "7")]
	public bool Equals(KLKBPFAMHHJ PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x67D9190", Offset = "0x67D8190", VA = "0x1867D9190", Slot = "8")]
	public bool Equals(PLFNKKFDPNB PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x67D9330", Offset = "0x67D8330", VA = "0x1867D9330", Slot = "0")]
	public override bool Equals(object FGOCJODIEMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x67D9420", Offset = "0x67D8420", VA = "0x1867D9420", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
public delegate void JDNJLGEOCKJ(NALLKCHCOFL.FPGBBMAKNFE KDDLFEDIEAD, string DFJKCKBFLAD);
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal interface NABGMGFEPOC
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	NHNLLIOGMAO LGGJAJNAPFP
	{
		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FGOOHEOODJH(long INFPDCJCIBN, long MBGBJFLBPMH, APEKBBKGICD EIJDFFMEHGJ, [Out] KLKBPFAMHHJ IJBMPEEKNEJ);

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<KLKBPFAMHHJ> OFEAHNKHCAN(APEKBBKGICD EIJDFFMEHGJ);

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KLKBPFAMHHJ LHDFKOMFFKP(long INFPDCJCIBN, long MBGBJFLBPMH, ELNOFCBKAIC JGCDJIMGDNO, APEKBBKGICD EIJDFFMEHGJ);
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
