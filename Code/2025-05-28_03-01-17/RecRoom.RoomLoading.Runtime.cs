using System;
using System.Buffers;
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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x85CE1A0", Offset = "0x85CCFA0", VA = "0x1885CE1A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA34390", Offset = "0xA33190", VA = "0x180A34390")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA343D0", Offset = "0xA331D0", VA = "0x180A343D0")]
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
	public class LogRegistrationIndex : FNHPAIPGMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x85CC260", Offset = "0x85CB060", VA = "0x1885CC260", Slot = "4")]
		public override void KEMEJJLNDFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85D7340", Offset = "0x85D6140", VA = "0x1885D7340", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x26D4E40", Offset = "0x26D3C40", VA = "0x1826D4E40")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class PGEHAPMNMGP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x85D2ED0", Offset = "0x85D1CD0", VA = "0x1885D2ED0")]
	public PGEHAPMNMGP(string NJJDPBHNDPA, Exception IGKCCLCOBDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class GGBCOBICPOE : ADJNCKMOEOE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct OFIMOHBHGOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<DOPKLEOCCDO>> <>t__builder;

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
		private TaskAwaiter<IEHHPLNDNNN<ENAHMCDKIIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x85CE610", Offset = "0x85CD410", VA = "0x1885CE610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x85CE850", Offset = "0x85CD650", VA = "0x1885CE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct AAAMIANOILH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<AOMCMMJDIIK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<AOMCMMJDIIK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x85B6900", Offset = "0x85B5700", VA = "0x1885B6900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x85B6B10", Offset = "0x85B5910", VA = "0x1885B6B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	[UnityEngine.Scripting.Preserve]
	public GGBCOBICPOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x85C4ED0", Offset = "0x85C3CD0", VA = "0x1885C4ED0", Slot = "4")]
	[AsyncStateMachine(typeof(OFIMOHBHGOM))]
	public Task<IReadOnlyList<DOPKLEOCCDO>> HOMKIDCLPEF(long CEACGIDOODJ, long AIBOEBCNHLB, [Optional] CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x85C4DC0", Offset = "0x85C3BC0", VA = "0x1885C4DC0", Slot = "5")]
	[AsyncStateMachine(typeof(AAAMIANOILH))]
	public Task<IReadOnlyList<AOMCMMJDIIK>> AHLIJNHOGNH(IReadOnlyList<int> GKEFFKPGGEA, [Optional] CancellationToken GHKBKDKNIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface AKPKDGLOHEL : IEquatable<AKPKDGLOHEL>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int CHBIIDEFPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	AOMCMMJDIIK GEJCHDPOEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime GPJKNHKCOFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	PAMJNKEHFFA? MPLOFMKCMOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	HGNOHPJPPIO? PAIPDNBIPBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	KHBLCAEOJAF IBBPIIIGONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<NPEBMFOKKKC> BHAOELLCPEM();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum KHBLCAEOJAF
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ADJNCKMOEOE
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<DOPKLEOCCDO>> HOMKIDCLPEF(long CEACGIDOODJ, long AIBOEBCNHLB, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<AOMCMMJDIIK>> AHLIJNHOGNH(IReadOnlyList<int> GKEFFKPGGEA, [Optional] CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class DOFPOMADFHC
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class HMJDOCNIFFF : AKPKDGLOHEL, IEquatable<AKPKDGLOHEL>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct NENEFGOLGBO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<NPEBMFOKKKC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public HMJDOCNIFFF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private HKGPCHIOHCC <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<IEHEOOILKKD> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<NPEBMFOKKKC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x85CD140", Offset = "0x85CBF40", VA = "0x1885CD140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x85CD6D0", Offset = "0x85CC4D0", VA = "0x1885CD6D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly DOPKLEOCCDO MJHLCAJBFJO;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int CHBIIDEFPJD
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xA0D990", Offset = "0xA0C790", VA = "0x180A0D990", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public AOMCMMJDIIK GEJCHDPOEED
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime IOKDKFBHCBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x85C5D80", Offset = "0x85C4B80", VA = "0x1885C5D80", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public PAMJNKEHFFA? MPLOFMKCMOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x2A5E100", Offset = "0x2A5CF00", VA = "0x182A5E100", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public HGNOHPJPPIO? PAIPDNBIPBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x85C5DA0", Offset = "0x85C4BA0", VA = "0x1885C5DA0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public KHBLCAEOJAF IBBPIIIGONP
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xBFF4C0", Offset = "0xBFE2C0", VA = "0x180BFF4C0", Slot = "10")]
			get
			{
				return default(KHBLCAEOJAF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x85C5C80", Offset = "0x85C4A80", VA = "0x1885C5C80", Slot = "9")]
		[AsyncStateMachine(typeof(NENEFGOLGBO))]
		public Task<NPEBMFOKKKC> BHAOELLCPEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x85C5FB0", Offset = "0x85C4DB0", VA = "0x1885C5FB0")]
		public HMJDOCNIFFF(int DOALPIKIKNL, AOMCMMJDIIK ANAAIFCMLBD, DOPKLEOCCDO MJHLCAJBFJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x85C5DC0", Offset = "0x85C4BC0", VA = "0x1885C5DC0", Slot = "11")]
		public bool Equals(AKPKDGLOHEL HBLONCAMFLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x85C5E50", Offset = "0x85C4C50", VA = "0x1885C5E50", Slot = "0")]
		public override bool Equals(object GLEBGNJJOHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x85C5F70", Offset = "0x85C4D70", VA = "0x1885C5F70")]
		private bool IBFHDNIDBJI(HMJDOCNIFFF HBLONCAMFLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x85C5EF0", Offset = "0x85C4CF0", VA = "0x1885C5EF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class INNCAKBAJJD : AKPKDGLOHEL, IEquatable<AKPKDGLOHEL>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct AKGNFANAOLD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<NPEBMFOKKKC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public INNCAKBAJJD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<NPEBMFOKKKC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x85BDA80", Offset = "0x85BC880", VA = "0x1885BDA80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x85BDCD0", Offset = "0x85BCAD0", VA = "0x1885BDCD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly ONKMAFKLDAF PNHCINEIKPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly PAMJNKEHFFA FDOIOCHMMAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly HGNOHPJPPIO NFOPHDCCPJG;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int CHBIIDEFPJD
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x85C6B50", Offset = "0x85C5950", VA = "0x1885C6B50", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public AOMCMMJDIIK GEJCHDPOEED
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x85C6AC0", Offset = "0x85C58C0", VA = "0x1885C6AC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime IOKDKFBHCBB
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x85C67A0", Offset = "0x85C55A0", VA = "0x1885C67A0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public PAMJNKEHFFA? MPLOFMKCMOI
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x85C6990", Offset = "0x85C5790", VA = "0x1885C6990", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public HGNOHPJPPIO? PAIPDNBIPBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x85C67F0", Offset = "0x85C55F0", VA = "0x1885C67F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public KHBLCAEOJAF IBBPIIIGONP
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xBFC230", Offset = "0xBFB030", VA = "0x180BFC230", Slot = "10")]
			get
			{
				return default(KHBLCAEOJAF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1ECDD40", Offset = "0x1ECCB40", VA = "0x181ECDD40")]
		public INNCAKBAJJD(ONKMAFKLDAF MKJDENHNJAB, PAMJNKEHFFA ALBEOCEICEN, HGNOHPJPPIO JJMEIOMFCNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x85C66B0", Offset = "0x85C54B0", VA = "0x1885C66B0", Slot = "9")]
		[AsyncStateMachine(typeof(AKGNFANAOLD))]
		public Task<NPEBMFOKKKC> BHAOELLCPEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x85C68F0", Offset = "0x85C56F0", VA = "0x1885C68F0", Slot = "11")]
		public bool Equals(AKPKDGLOHEL HBLONCAMFLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x85C6840", Offset = "0x85C5640", VA = "0x1885C6840", Slot = "0")]
		public override bool Equals(object GLEBGNJJOHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x85C6A60", Offset = "0x85C5860", VA = "0x1885C6A60")]
		private bool IBFHDNIDBJI(INNCAKBAJJD HBLONCAMFLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85C69E0", Offset = "0x85C57E0", VA = "0x1885C69E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class GHBIFAKAAGD : AKPKDGLOHEL, IEquatable<AKPKDGLOHEL>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct LPOFBIFOAAB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<NPEBMFOKKKC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<NPEBMFOKKKC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x85CBF90", Offset = "0x85CAD90", VA = "0x1885CBF90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x85CC1F0", Offset = "0x85CAFF0", VA = "0x1885CC1F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly AOMCMMJDIIK PMDOGKEFPLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly PAMJNKEHFFA FDOIOCHMMAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly HGNOHPJPPIO NFOPHDCCPJG;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int CHBIIDEFPJD
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x85C5B60", Offset = "0x85C4960", VA = "0x1885C5B60", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public AOMCMMJDIIK GEJCHDPOEED
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime IOKDKFBHCBB
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public PAMJNKEHFFA? MPLOFMKCMOI
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x85C59A0", Offset = "0x85C47A0", VA = "0x1885C59A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public HGNOHPJPPIO? PAIPDNBIPBF
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x85C5860", Offset = "0x85C4660", VA = "0x1885C5860", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public KHBLCAEOJAF IBBPIIIGONP
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "10")]
			get
			{
				return default(KHBLCAEOJAF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1ECDD40", Offset = "0x1ECCB40", VA = "0x181ECDD40")]
		public GHBIFAKAAGD(AOMCMMJDIIK ANAAIFCMLBD, PAMJNKEHFFA ALBEOCEICEN, HGNOHPJPPIO JJMEIOMFCNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x85C5790", Offset = "0x85C4590", VA = "0x1885C5790", Slot = "9")]
		[AsyncStateMachine(typeof(LPOFBIFOAAB))]
		public Task<NPEBMFOKKKC> BHAOELLCPEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x85C5930", Offset = "0x85C4730", VA = "0x1885C5930", Slot = "11")]
		public bool Equals(AKPKDGLOHEL HBLONCAMFLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x85C58B0", Offset = "0x85C46B0", VA = "0x1885C58B0", Slot = "0")]
		public override bool Equals(object GLEBGNJJOHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x85C59F0", Offset = "0x85C47F0", VA = "0x1885C59F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x85C5A80", Offset = "0x85C4880", VA = "0x1885C5A80")]
		private bool IBFHDNIDBJI(GHBIFAKAAGD HBLONCAMFLG)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct EIBAHIFNIAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<AKPKDGLOHEL>> <>t__builder;

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
		public DOFPOMADFHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<DOPKLEOCCDO> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<DOPKLEOCCDO>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, AOMCMMJDIIK account, DOPKLEOCCDO roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x85C3080", Offset = "0x85C1E80", VA = "0x1885C3080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x85C3EE0", Offset = "0x85C2CE0", VA = "0x1885C3EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct DBEBMIJCDPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, AOMCMMJDIIK account, DOPKLEOCCDO roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<DOPKLEOCCDO> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public DOFPOMADFHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<AOMCMMJDIIK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x85BEDB0", Offset = "0x85BDBB0", VA = "0x1885BEDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x85BF7C0", Offset = "0x85BE5C0", VA = "0x1885BF7C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly CABLHEBFPCF INPJLFGFIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly ADJNCKMOEOE LAIAIGKODMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly PANKIDIEDAK MCKJEEJJENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly NDJENDDAKLA<(long, long), IReadOnlyList<DOPKLEOCCDO>> OOLAFCKPONF;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x85C2420", Offset = "0x85C1220", VA = "0x1885C2420")]
	[UnityEngine.Scripting.Preserve]
	public DOFPOMADFHC([LCNEJNNIOGA(null)] ADJNCKMOEOE IHMGAIJLEOP, [LCNEJNNIOGA(null)] PANKIDIEDAK MPKCICPEGAI, [LCNEJNNIOGA(null)] CABLHEBFPCF EBEHAFMIKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x85C22D0", Offset = "0x85C10D0", VA = "0x1885C22D0")]
	[AsyncStateMachine(typeof(EIBAHIFNIAB))]
	public Task<IList<AKPKDGLOHEL>> EEGGABIBMFI(long CEACGIDOODJ, long DPMNLDKPNGD, bool BNLFNFNHLFK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x85C2130", Offset = "0x85C0F30", VA = "0x1885C2130")]
	private bool BMMAKNMPPMM(DateTime? AAAEECOCEKL, long CEACGIDOODJ, long DPMNLDKPNGD, [Out] ONKMAFKLDAF GCOKBAEPGNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x85C2020", Offset = "0x85C0E20", VA = "0x1885C2020")]
	[AsyncStateMachine(typeof(DBEBMIJCDPJ))]
	private Task<IReadOnlyList<(int, AOMCMMJDIIK, DOPKLEOCCDO)>> BKHIIPNACFD(IReadOnlyList<DOPKLEOCCDO> OHIIIOLIPMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface PANKIDIEDAK
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<ONKMAFKLDAF> NFOBLMGHMAC;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GBFNDMPIEAC(long CEACGIDOODJ, long DPMNLDKPNGD, ABCJCMNNNGP EPCLCPLDMJG, ILAAIKBOLJH DGLHGHKAGGH);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JACANJAAKHK(long CEACGIDOODJ, long DPMNLDKPNGD, [Out] ONKMAFKLDAF GCOKBAEPGNP);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AEMHAEHBPEM(long CEACGIDOODJ, long DPMNLDKPNGD, ILAAIKBOLJH DGLHGHKAGGH, [Out] ONKMAFKLDAF GCOKBAEPGNP);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JANDEIEOMNE(long CEACGIDOODJ, long DPMNLDKPNGD);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface FKBNPLCEDMG : EFFGJDOCBHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool PJOMDJFDICE
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task EPPLEFHOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PMMEIDBJHIH(Task JDEJDGHOHNF, string HJPFPPBGHGH);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface MMFENADFOFA : EFFGJDOCBHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NPEBMFOKKKC> PHIPKBNLPLD(ONKMAFKLDAF GCOKBAEPGNP);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DBFBBJHDIHJ(CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface AKCEBBAKJMD : EFFGJDOCBHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	OJHCGNKMJME NMMHPMMBLLA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BAJJFEAACNI();

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IAEPAKEAIBB();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface EFFGJDOCBHN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IANLJFINMMK(GMNLHEBCJHB PPAOCCCONKJ);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface FLLFABBPDNP
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan PDGGNOBGAPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan KIKIHKIFODH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan GCIAHGIIENM
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan KPJCNBDLMOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool KDLMAMOOMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool GEDFKDDHDEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool MHPEHIHGAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int KPKPAJHIHLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool JAFDOPKJNKA
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool NOJHKECIIMA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool AJIHJJPKNOH
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum HCGCICEFMNK
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum LKEHMNNHDHP
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
public struct LHFNDJOEGHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long IOOGOLJCMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long AIBOEBCNHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly HCGCICEFMNK AAFMBEEMJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception PEOMHKBOGHH;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x85CBE00", Offset = "0x85CAC00", VA = "0x1885CBE00")]
	public LHFNDJOEGHO(long IOOGOLJCMGG, long AIBOEBCNHLB, HCGCICEFMNK AAFMBEEMJAC, [CanBeNull] Exception PEOMHKBOGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x85CBDB0", Offset = "0x85CABB0", VA = "0x1885CBDB0")]
	public static LHFNDJOEGHO CAOJKMJCLDE(DAFHNINMJHP HBKGIAMJIGM, HCGCICEFMNK AAFMBEEMJAC, [Optional] Exception PEOMHKBOGHH)
	{
		return default(LHFNDJOEGHO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void ONLGPJJNKGI(LHFNDJOEGHO LFNOMKAPHON);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface OGDPOBHAJLA : EFFGJDOCBHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action LLJBJNLIFLN;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event ONLGPJJNKGI KNDMINJHFLC;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event ONLGPJJNKGI KDMGPIDFDCA;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event ONLGPJJNKGI DGKIIMEOOOM;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<LKEHMNNHDHP, bool> BFFJMGAGCJL;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FFKLJDCBAFG();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IMANCLPPPLJ(LHFNDJOEGHO LFNOMKAPHON);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NJJNEOELAHL(LHFNDJOEGHO LFNOMKAPHON);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ICMPIFJPJIL(LHFNDJOEGHO LFNOMKAPHON);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MGINDINLIKE(LKEHMNNHDHP CHNEHFOJOHF, bool FHEDCABKFLG);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface CLGEKOKCCID : EFFGJDOCBHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public enum Reason
	{
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		TestCase,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		ServerDisconnect_ClientTimeout,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		ServerDisconnect_ServerTimeout,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		ServerDisconnect_ByServer,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		ServerDisconnect_ByClient,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		ServerDisconnect_Other,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		PresenceUpdate_SentToInvalidInstance,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		UnhandledExceptionDuringInitialRoomLoad,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		UnhandledExceptionDuringNonInitialLoad,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		FallbackFailure_UnhandledException,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		FallbackFailure_NoInternetConnection,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		FallbackFailure_Timeout,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		FallbackFailure_Cancelled,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		FallbackFailure_EndedInInvalidInstance,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		FallbackFailure_EndedInIncorrectInstance,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		FallbackFailure_EndedInIncorrectScene,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		FallbackFailure_AlreadyInTargetInstance,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		FallbackFailure_MatchmakingError
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool DMDLKCPFEGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CHIOMOALGPM(Reason KLOPBEMIGAO = Reason.Unknown);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HDHMLEOOMIM();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface JBIDHHLDGEM : EFFGJDOCBHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	TaskStatus AOPKDKEBEEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GCGCDHDOKJJ(DAFHNINMJHP LLANMJGNIHG, ACOLPPBLNNC MBNGJDJKBDI, CancellationToken KKIGNHNCIEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class CNCGFJLEGGK
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x85BED60", Offset = "0x85BDB60", VA = "0x1885BED60")]
	public static bool BCNAIFNDDJD(this JBIDHHLDGEM FFKOMCHKHBE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public delegate Task AOFGFCPMAHF(CancellationToken JLFLGDNCANL, int HLNLCIPOMGH, OKJOLANABCP IOINOICOAPE);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface LELEALOGJCL : EFFGJDOCBHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GKCNOFHDLGB(AOFGFCPMAHF IMCBLKNGABF);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface GMNLHEBCJHB : HKGPCHIOHCC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	CancellationToken OLGLADFBIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	NAELDDAANND NFNIJIAHECJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	PNEPNDOKHCF PCDGBLIDLLN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	OOALADCCJDG ABJGGDELABK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	KHIJDEHFOJA NLOFNFPCHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	BIPJBOOKCJI FCGOCHJLJPK
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	BPJFPFLMOMA GOGCPGBCDLD
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	PGBAMBHBOMF BDBJDCOPBDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	HMCLAFELGLA MFFNDFGGHCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	FKBNPLCEDMG IBLCNJNFCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	MMFENADFOFA GPCBBJGCAMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	OGDPOBHAJLA BLJDKHGNDJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	CLGEKOKCCID DLJGHAPBJOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	JBIDHHLDGEM OOGJGMCGOLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	LELEALOGJCL AKECNBGLCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	ALIJJKDAOBM IDCJFGDDBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	AICMHOPJHHA DKPLLPOMMKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	BJAOKJCOCOJ MMOAGIJNNMP
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	EGIPCKEJEEF NOECIPGGHNO
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	DIPENBPMFLI JAPDAFHOGJC
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	MINEBKJHCFN DMOFHJCKCKP
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	LAKFJEOHOAC PAEBNFGIHCG
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	NFMCGGLGEDK EDLADPFJNNP
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	ENHLNEAIPEI PCJNABGKINB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	DPKHKMABECE CLHJLBCHAGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	AKCEBBAKJMD GNIMOLDHBOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	FLLFABBPDNP NLEDFONIOCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	HKHLJMHFNLH CHIBLOPEFKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	PANKIDIEDAK NFNIEGEAJCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	IFKLAILBPMB AECIMJOJCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	LMAKAKBFNCK CKPOPCHGHOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	FOEDDKHMNOB BJCLGAKHDMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	PMOBBKDCDFN EMLGHPNHEFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	new bool DGLPMBGAABA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void DBGFBCKLBLK(ACOLPPBLNNC ABCMKDJBFGH);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface ALIJJKDAOBM : EFFGJDOCBHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GDBEHCBBGEI AIKICPLLADB(Guid LGNCELEMLNH);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FKCGDELNEED(Guid LGNCELEMLNH);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NFPEANLIMIK(Guid LGNCELEMLNH, Task DELLKDOKFMM);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool APFKNMOAGAK(Guid LGNCELEMLNH, NPEBMFOKKKC OIDJJGFKNNC);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(NPEBMFOKKKC, Task)> ALGJLBGDBBM(Guid LGNCELEMLNH);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface DGLFJMDONOJ : EFFGJDOCBHN, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface AICMHOPJHHA : EFFGJDOCBHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HDAMJJCIIDC(JCNIBNHHJJK NJJDPBHNDPA);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JACLGHLGFJA(JCNIBNHHJJK NJJDPBHNDPA);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<OHMAAOBKPPJ> OKBMACHEFDD(CancellationToken NEMPCADIIIP);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface BJAOKJCOCOJ : EFFGJDOCBHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GDBEHCBBGEI JOAOONBKLAH(JCNIBNHHJJK OMBHAFGMJJN);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KECPLENIJGB(Guid LGNCELEMLNH, Task DELLKDOKFMM);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface EGIPCKEJEEF : EFFGJDOCBHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NPEBMFOKKKC> NOECIPGGHNO(JCNIBNHHJJK FGGHFEPNPLK);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface DIPENBPMFLI : EFFGJDOCBHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EJLGFFHHDJD> JAHJKEKANJD(HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, DAFHNINMJHP LLANMJGNIHG, CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface LAKFJEOHOAC : EFFGJDOCBHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NPEBMFOKKKC PKFLMMMNOBG(AHNIMKBJLEJ OIMMHJNPNEH);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task APNNEMJDJDP(string NOBPJADLJBL);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface MINEBKJHCFN : EFFGJDOCBHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JCNIBNHHJJK> BNAADEKEIIL(JCNIBNHHJJK OHDJLNAKLPC, DKMOFLOMOKC JCGPNELIJIN, CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<JCNIBNHHJJK> JBNFPNNNOPA(CancellationToken GHKBKDKNIOM, DKMOFLOMOKC JCGPNELIJIN);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HPFPDDDCBJJ FMKJFGHCMCO(OGJNGIMJFAN IHNPOBAJILE, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HPFPDDDCBJJ AMLMCHJDEAO(OGJNGIMJFAN IHNPOBAJILE, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface NFMCGGLGEDK : EFFGJDOCBHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NPEBMFOKKKC FIBLCMAMJOF(AHNIMKBJLEJ OIMMHJNPNEH, OHMAAOBKPPJ ECJGLDHJAKL);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NPEBMFOKKKC JBPMJHGAPEO(AHNIMKBJLEJ COJGENHFAGP);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface CEMGLJFPJKA
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	const int ANOONFEJPPP = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	IReadOnlyDictionary<Guid, MPFMBABACOH> JIMLDJKNLIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Action IGJBBIKJMKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<Guid> DOCCMBAAMLH();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task BBAIKJABALK([Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task HCECOJBDBMH([Optional] CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface ENHLNEAIPEI
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NEKKCPOCGNL(FNEPCBJJIOG PIDOAGGKJHH);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JOMHJEAFMNP(FNEPCBJJIOG PIDOAGGKJHH);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ILLMMCMBFJM(FNEPCBJJIOG PIDOAGGKJHH);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CNADJCGJCLM(FNEPCBJJIOG PIDOAGGKJHH);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class FNEPCBJJIOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly DAFHNINMJHP LHAAFHMLOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Dictionary<string, string> IEAIEKCDOCO;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public HBCKFDINPOH<string> HJAHEHLLNCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
	public FNEPCBJJIOG(DAFHNINMJHP GLJABNGDFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x85C4B00", Offset = "0x85C3900", VA = "0x1885C4B00")]
	public FNEPCBJJIOG DILMFGBHDPE(string MAKJJJECHHB, string OAIIHELJHLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x85C4A70", Offset = "0x85C3870", VA = "0x1885C4A70")]
	public bool BACFPPLHNII([Out] IEnumerable<KeyValuePair<string, string>> LLAICLOJOOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x74347F0", Offset = "0x74335F0", VA = "0x1874347F0")]
	public FNEPCBJJIOG HOEFDCKCBCN(HBCKFDINPOH<string> HMLAIBMJFEO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface HKHLJMHFNLH
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool BNCMGGEHNAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string MFJNKOGGBIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool JMKALGMOIIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OJAMMKIEPHE();

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JMIDENOHBFD GHBFIJKDPEF(long KEIIDMOKGJE);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HHAHEEOIDKG<CKNMKLKMAFP, MMIHAIKLLOA> NEFIECPLCBE(long KEIIDMOKGJE);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HHAHEEOIDKG<CKNMKLKMAFP, IEHAENGDKAI> IJGDBCKFGOE(long KEIIDMOKGJE);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HHAHEEOIDKG<long, PPPBEPLDMBL> DMFJCIOHOMM();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<IReadOnlyCollection<FDPEOBPEHPG>> FAPLBNEIFMP(long KEIIDMOKGJE, IReadOnlyCollection<FDPEOBPEHPG> FKIEJHDECMF, CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool EDMCMCGEMMJ(long KEIIDMOKGJE, [Out] bool AJKIIHOLHDL);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<bool> ALLHPJKMDLK(byte[] JINFFCDMHMF, byte[] LINKDNKHHPK, IReadOnlyCollection<Guid> JLEFIJLEGHC, CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface ALACNOHNDBC
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EJLGFFHHDJD BHEMCOAOOEF(long IOOGOLJCMGG, long AIBOEBCNHLB, string LOPKMJOKGEI);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EJLGFFHHDJD BHEMCOAOOEF(long IOOGOLJCMGG, long AIBOEBCNHLB, CKNMKLKMAFP JINFFCDMHMF, Guid? OICMNLFEKDO, long JCHKNPOGNLH, bool MIEJNIDEEMC);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EJLGFFHHDJD BHEMCOAOOEF(HIFJOJHPHLI NOIGPBLOOGE);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EJLGFFHHDJD BHEMCOAOOEF(IEHEOOILKKD IPMOLJAFIMD, DOPKLEOCCDO COEAMHDJCMI);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface HKGPCHIOHCC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool BCNAIFNDDJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool FLMCPCNDFHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool DGLPMBGAABA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	ALACNOHNDBC LLEGLPGCBLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	ACOLPPBLNNC INBEEOFLAAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action LLJBJNLIFLN;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event ONLGPJJNKGI KNDMINJHFLC;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event ONLGPJJNKGI KDMGPIDFDCA;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event ONLGPJJNKGI DGKIIMEOOOM;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<LKEHMNNHDHP, bool> BFFJMGAGCJL;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HDHMLEOOMIM();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	FMCIILJJKCO FIHODIMMKCG();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	HLCOPCGLHDG BDCNICMJKJP();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task NBAPJKJDNOE(int JFFMBFCFHJI, KKDADIJBPAI LANGIPGHPFC, Func<ABCJCMNNNGP, ABCJCMNNNGP> EDKBIAIMAMI);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<NPEBMFOKKKC> PHIPKBNLPLD(ONKMAFKLDAF MKJDENHNJAB);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task DBFBBJHDIHJ(CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface BIPJBOOKCJI
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool HIAFCOOPOEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool JGBBEDPHEOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Guid? IBDKBFMOHKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JFPCHBEAFAC(Scene FJKBPIGIHCH);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task MKFDLBBIKIL(GNLGNOAMCMK NFHHDCFCODF, IReadOnlyList<GNLGNOAMCMK> ODFBGFDBHDO, IReadOnlyList<GNLGNOAMCMK> EJHHJBLFPIA, CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LELFOFGLMBL(Guid DGIHKBKLLKL, IReadOnlyList<Guid> JLEFIJLEGHC, EAPJEEPAOBC PMLHOGPNILK, [Optional] object HDOBNIPOLCL);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task GMDAEEAGMPB(IReadOnlyList<Guid> IKGDOEFEMLK, CancellationToken NNLNEPNCBIE);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ODKLBJOEAND GKFAMMJDHCJ();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task GKJCCJBDBEM();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CIEMDGKMJHP(GameObject CIEOFCKLMHA);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task AFMBEHJBODL();
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface KHIJDEHFOJA
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	HNJJDFCNNLG NGAOLAIDCMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool KKAGAOLAMCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool FJOOMBJFBFO
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool IHOJGEACJOO
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool HOPPOLKCPEG
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	int HBAFEFDNPIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool NDANJPPHLGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool KKHMIMKFEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	int GOPCKBIEAAD
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	int OKMGHGFMOLC
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool HHONGLBHPJI
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool HAHNLIDCONH
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool KHDPDNBCLJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	float GMPJMBGONLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> EENHBJJPGAA;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NAELDDAANND BMOFBAOCBOG(NAELDDAANND DKLAAEGCAJG);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KLMNPMCAODD(NAELDDAANND AHGNCOFKLHK);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BPNGFNFDCFA();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task KMLHNAPFAOJ(HBCKFDINPOH<string>.DLKHFLDLCIN FHFDCLKDMLD, CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KAMJCECMKGL(float LAOLBIOBMCC);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FGKFGNNGAKB(string OFBHKEAMPFJ);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<LBAKINFFCND> LHMFDMODJEC();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable MLNOMIOCHCI(object JAPGNGDBBIF, LBAKINFFCND EAEFPGALELD);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<HEDKMGEOMGG> BJJPJIEDBCN();

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	MMIHAIKLLOA BIMKMDMIGFE(IEnumerable<HDCAPCJGFLN> OAGFADOJLLC);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CHEAPOEGGMJ(int OICKECDHHGJ);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task ANHGJLPMPJD();

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void NOLIIINKKKJ();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool NDHJACDPFAB();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task LDLMBFMFPAA(CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task GPEJLCEHOCF(CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<CNPAIGBENAC> NFPLFCOLPIL(DateTime CFANNFADOAP, CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> NNGOKDINLLB(CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void OMHKDAJPEKK(string NJJDPBHNDPA = "", float NFGIPBFMCLH = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "25")]
	LIMDEMJFMGD KPIJLLEKPKA(IBOBFJDJKHF KIADMCLAHNB, IDJDAJKALCK JLPAALCHFHL, IEHAENGDKAI JHOJNDIIPGJ, IEnumerable<PersistenceView> PIONDFDBMMC, HHCHLLLJFNE EAHKNEDDMEF);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void KCADHHDNMJF(IEHAENGDKAI JHOJNDIIPGJ);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void FLIOLBGKJDN(HDCAPCJGFLN KBPNMENODAC, [In] LIMDEMJFMGD CMDFAJDAGCE);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task AGCLEODCHOA(IEHAENGDKAI POBCDALIHIP, bool HLHAANACKAD, CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task ONJOMNJJAAO(CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void EIBKJJMFGIK(long CEACGIDOODJ, long AIBOEBCNHLB, IEHEOOILKKD OBHLDKPHIMF, DOPKLEOCCDO INGFLLKEOMP, ABCJCMNNNGP EPCLCPLDMJG, KKDADIJBPAI? LANGIPGHPFC, BBDLPBCCOHO? IFFCOIOHFKP);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void KLAKFIEKOFN(long CEACGIDOODJ, long AIBOEBCNHLB, BBDLPBCCOHO? IFFCOIOHFKP);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void FGJOOIIMKKB(PersistenceView OILHCBBJHMD);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void OOOGHCEDFOK(string DEOPMKGJEIH, DAFHNINMJHP GLJABNGDFFO, FDBBKNBANNJ KLDPEFLBHJI, [Optional] string? HCGFIHGDBOC, [Optional] string? DGFFMPMLLNK, [Optional] string? JAGEMFNEMAI);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool DDMOJOMJNLD(PersistenceView IOEIHBPMNDC);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool NHFKLBKOIFI(HDCAPCJGFLN KBPNMENODAC, OBHJNBIABOM NBEPHOLFLDJ, [Out] CMFLKMCPKHF CJGLCDNMACA);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task HHNAOOFJFGK(CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void BDHJDLEPENM();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "38")]
	IDisposable JHNEGNENLFO();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void CDJJFIDPLCN(IEHAENGDKAI POBCDALIHIP, OBHJNBIABOM NBEPHOLFLDJ);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<bool> MFHIBJDJOEO(PNEPNDOKHCF KLBDPNGJELI, CancellationToken GHKBKDKNIOM, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void DGEMHKHMAOP(CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<HIFJOJHPHLI> OFEJGKCHNAO(AFJINEFPFEP OHDJLNAKLPC);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<IEHEOOILKKD> HMKMPCLPKEL(long CEACGIDOODJ, bool LLGNOINHLAG, CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<ENAHMCDKIIN> ABLMMJJBCJJ(long CEACGIDOODJ, long AIBOEBCNHLB, long JCHKNPOGNLH, CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<ENAHMCDKIIN> KIJPKFJIADN(long CEACGIDOODJ, long AIBOEBCNHLB, CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<JLKEEJPFIPN> JFNPMLHJLPM(long CEACGIDOODJ, Guid DPNCEHGJPKD, long? DPMNLDKPNGD, CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "47")]
	HHAHEEOIDKG<JLKEEJPFIPN, IEnumerable<DBPOPHMEDLM>> HDGMOGKKLCA();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "48")]
	Task<JILIMMDDMOA> AHMPIFKCJPI(string LOPKMJOKGEI, CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task<JILIMMDDMOA> OHDBNDBOHDD(string LOPKMJOKGEI, long CEACGIDOODJ, long AIBOEBCNHLB, Guid? DGIHKBKLLKL, DNDMPIPNEEC.KDGPAGGMFHO MLFFBNNKHKH, DNDMPIPNEEC.KDGPAGGMFHO LINKDNKHHPK, int JFFMBFCFHJI);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool OGFNCDMLIPI();

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool PNDDEKOOGNO();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool MNPKGJFEJBF(IEnumerable<CMFLKMCPKHF> HIHCKMIICKP);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void OCJHCNJCFHK(List<GameObject> IAHIODBCIIP);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "55")]
	float FGBNLKDBDDC();

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "56")]
	Task<bool> OGNPNNPGKKM(CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "57")]
	Task<Scene> LBGLBIDCPBF(string HNANIJLJDBI, LoadSceneMode GIONLNKGCDL, bool KMLMFPECCJP, HBCKFDINPOH<string>.DLKHFLDLCIN HMLAIBMJFEO);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void FBJGOMCCDHD();

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "63")]
	void OCKPNFMCPHK(bool MAFNDJNJAOJ);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void KEIEJNMMJJJ();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void NECDPOCLDHC();

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void OOHPMAALDLK(bool NFCGBCGGPMJ);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "72")]
	Task<DNDMPIPNEEC.KDGPAGGMFHO> IDIJHPENFGO(byte[] FFEMKICJPKP, DNDMPIPNEEC.BGHBEGCPDBE LJBOMOKGEMC, DIGIGCMPGLC MMBOPKHEKCA, [Optional] IReadOnlyCollection<string>? DCOBNNPPGGJ, [Optional] string? GGKOMBHGPIE);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void CGLLGGDJLOF(DAFHNINMJHP DFFKLNAFJEO);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task FNLDLEFOECA(HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "75")]
	Task HPFDMOKIJNJ(HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "76")]
	Task LEGNHHFKFMO(HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "77")]
	Task INPCPAPFJDE(HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "78")]
	IDisposable CLMLAALLNOF();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "79")]
	PLOMLBDJMJM DJAGNMBDEPJ();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "80")]
	Task PABOEDFFIKC(CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface PLOMLBDJMJM
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task FAEKDIOMNIN(CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OKMGLEHHENA(CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct LIMDEMJFMGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public HashSet<int> IEGIPLHLFFE;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum CNPAIGBENAC : byte
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	No,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct IBOBFJDJKHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Guid? JHILAODNCDJ;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface HNJJDFCNNLG
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	DAFHNINMJHP NFFBJEMLMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	IEHEOOILKKD DDJPPKMGDGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	HLKGJIPFKJP DLMBOMDIGFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool DCBPLOLDDJH
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool NEOEMIEOMKH
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	int DDKDNJEKJHO
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action JONAGOBBMLO;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> JLNIODINFHO;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JEPLFFMOAGM();

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.LHIBODNCGEG> CCJPMHIMLLD(long KEIIDMOKGJE, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<IMBDKHEFFFL> HAFPIAGPFBG(DAFHNINMJHP GLJABNGDFFO, [Optional] ACOLPPBLNNC MBNGJDJKBDI);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<IMBDKHEFFFL> KMCNEACNHHH();

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task PKMPNABFCPE();

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "15")]
	(DAFHNINMJHP, ACOLPPBLNNC) GPOHDDEFHJO();

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "16")]
	PAONFCHNCDI FMPPLIIEFFA();

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PAPOABGHCCC(long KEIIDMOKGJE);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void MIFEOOAAFNH(DAFHNINMJHP GLJABNGDFFO, Matchmaking.LCOHEPLGIOM BPINCJLADGC, (int Major, int? Minor)? DMDAMPNBMKA);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface DPKHKMABECE
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DFCCHCOJCME([Out] IEnumerable<int> OCLHAJKFOKP);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void POLBJJEDLLM(DPBIDJALKLM JLFLGDNCANL);

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OOOHICEINOF(DPBIDJALKLM JLFLGDNCANL);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface JAIDLBOFJCO
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string KGOOJIGNEML(NPEBMFOKKKC MJMCEHEEBGD);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface EMDPBBBEDAJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGOBEGEJACB(FGOKPJMHAAM.MPCEKBCBMNI LOCPONBEOEB);

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DNLDCMFDDBP(FGOKPJMHAAM.MPCEKBCBMNI LOCPONBEOEB);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface BPJFPFLMOMA : EMDPBBBEDAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NPEBMFOKKKC OOHGMCEDJCA(AHNIMKBJLEJ COJGENHFAGP);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface PGBAMBHBOMF : EMDPBBBEDAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NPEBMFOKKKC PKFLMMMNOBG(AHNIMKBJLEJ ALDGPAKLOOK);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface JMIDENOHBFD
{
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JKEBLLKKBOM<KFPGMEKLIPK, DDPPOHMMKFK>> GFJDFDFHIIF(Guid? DGIHKBKLLKL, IReadOnlyCollection<FDPEOBPEHPG> HCILPACHGBE, IReadOnlyCollection<FDPEOBPEHPG> NGHKOJHJAIA, FKKNENHMCMB CNNHJJBHAPC, long? CEACGIDOODJ, long? AIBOEBCNHLB, KPPIONNPJCL.FDCOECOEOKN NODBBLEALIC, CancellationToken GHKBKDKNIOM, bool PNGGJPFNHPB = false);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class KFPGMEKLIPK
{
	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public GNLGNOAMCMK NCEPGBMHGPI
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public IReadOnlyList<GNLGNOAMCMK> HGCJOHILPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public IReadOnlyList<GNLGNOAMCMK> BBLCIKMHEFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0xC59BA0", Offset = "0xC589A0", VA = "0x180C59BA0")]
	public KFPGMEKLIPK(GNLGNOAMCMK PFEINOOCINJ, IReadOnlyList<GNLGNOAMCMK> HDPDMHEJEBH, IReadOnlyList<GNLGNOAMCMK> KJMBLFKDDHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface HHAHEEOIDKG<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JKEBLLKKBOM<HBACGGNKINL<TData>, DDPPOHMMKFK>> LHOGLHEHMDD(TGetDataArg EMEICEFCBEP, CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class AKBFLKFLKIM : GMNLHEBCJHB, HKGPCHIOHCC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct KAHONJGPMMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AsyncTaskMethodBuilder<NPEBMFOKKKC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public AKBFLKFLKIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public ONKMAFKLDAF autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter<NPEBMFOKKKC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x85C9790", Offset = "0x85C8590", VA = "0x1885C9790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x85C9A10", Offset = "0x85C8810", VA = "0x1885C9A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct JEJODPGJDCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AKBFLKFLKIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x85C8D30", Offset = "0x85C7B30", VA = "0x1885C8D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x85C8F60", Offset = "0x85C7D60", VA = "0x1885C8F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class KOAAGAIHNAB : IEnumerable<EFFGJDOCBHN>, IEnumerable, IEnumerator<EFFGJDOCBHN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private EFFGJDOCBHN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public AKBFLKFLKIM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private EFFGJDOCBHN System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xED60C0", Offset = "0xED4EC0", VA = "0x180ED60C0")]
		[DebuggerHidden]
		public KOAAGAIHNAB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x85CA450", Offset = "0x85C9250", VA = "0x1885CA450", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x85CA8B0", Offset = "0x85C96B0", VA = "0x1885CA8B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x85CA800", Offset = "0x85C9600", VA = "0x1885CA800", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<EFFGJDOCBHN> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x85CA800", Offset = "0x85C9600", VA = "0x1885CA800", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly CancellationTokenSource FAGIHCHOBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly NAELDDAANND AHGNCOFKLHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool EKADHKFOHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private OMPIHDKDMGP KEDIOKLINNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private bool LGKKNLADIJA;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public PNEPNDOKHCF PCDGBLIDLLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA0D020", Offset = "0xA0BE20", VA = "0x180A0D020", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA0D010", Offset = "0xA0BE10", VA = "0x180A0D010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public OOALADCCJDG ABJGGDELABK
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA0D000", Offset = "0xA0BE00", VA = "0x180A0D000", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA0D030", Offset = "0xA0BE30", VA = "0x180A0D030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public KHIJDEHFOJA NLOFNFPCHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA0CFF0", Offset = "0xA0BDF0", VA = "0x180A0CFF0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA0CFE0", Offset = "0xA0BDE0", VA = "0x180A0CFE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public BIPJBOOKCJI FCGOCHJLJPK
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA0D040", Offset = "0xA0BE40", VA = "0x180A0D040", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA0CFD0", Offset = "0xA0BDD0", VA = "0x180A0CFD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public BPJFPFLMOMA GOGCPGBCDLD
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECC0", Offset = "0xA0DAC0", VA = "0x180A0ECC0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED20", Offset = "0xA0DB20", VA = "0x180A0ED20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public PGBAMBHBOMF BDBJDCOPBDG
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA0D8A0", Offset = "0xA0C6A0", VA = "0x180A0D8A0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA0D8E0", Offset = "0xA0C6E0", VA = "0x180A0D8E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public ALACNOHNDBC LLEGLPGCBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA0D9C0", Offset = "0xA0C7C0", VA = "0x180A0D9C0", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA0D960", Offset = "0xA0C760", VA = "0x180A0D960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public HMCLAFELGLA MFFNDFGGHCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA0D980", Offset = "0xA0C780", VA = "0x180A0D980", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA0DA30", Offset = "0xA0C830", VA = "0x180A0DA30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public FKBNPLCEDMG IBLCNJNFCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xBFED10", Offset = "0xBFDB10", VA = "0x180BFED10", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x135D320", Offset = "0x135C120", VA = "0x18135D320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public MMFENADFOFA GPCBBJGCAMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA0DA10", Offset = "0xA0C810", VA = "0x180A0DA10", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA0D930", Offset = "0xA0C730", VA = "0x180A0D930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public OGDPOBHAJLA BLJDKHGNDJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xCFC430", Offset = "0xCFB230", VA = "0x180CFC430", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xE8AF40", Offset = "0xE89D40", VA = "0x180E8AF40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public CLGEKOKCCID DLJGHAPBJOM
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA0BC20", Offset = "0xA0AA20", VA = "0x180A0BC20", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA0BC50", Offset = "0xA0AA50", VA = "0x180A0BC50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public JBIDHHLDGEM OOGJGMCGOLC
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xD8BC60", Offset = "0xD8AA60", VA = "0x180D8BC60", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xE8DAA0", Offset = "0xE8C8A0", VA = "0x180E8DAA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public LELEALOGJCL AKECNBGLCJM
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xD6F900", Offset = "0xD6E700", VA = "0x180D6F900", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xD6F910", Offset = "0xD6E710", VA = "0x180D6F910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public ALIJJKDAOBM IDCJFGDDBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xCFC260", Offset = "0xCFB060", VA = "0x180CFC260", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x11CB5E0", Offset = "0x11CA3E0", VA = "0x1811CB5E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public DGLFJMDONOJ ELOGFOMHEIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xCE6EA0", Offset = "0xCE5CA0", VA = "0x180CE6EA0", Slot = "62")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xDA0210", Offset = "0xD9F010", VA = "0x180DA0210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public AICMHOPJHHA DKPLLPOMMKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xABCDE0", Offset = "0xABBBE0", VA = "0x180ABCDE0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xABCDC0", Offset = "0xABBBC0", VA = "0x180ABCDC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public BJAOKJCOCOJ MMOAGIJNNMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xA0BBF0", Offset = "0xA0A9F0", VA = "0x180A0BBF0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA0BBD0", Offset = "0xA0A9D0", VA = "0x180A0BBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public EGIPCKEJEEF NOECIPGGHNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xAE22D0", Offset = "0xAE10D0", VA = "0x180AE22D0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xBCF790", Offset = "0xBCE590", VA = "0x180BCF790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public DIPENBPMFLI JAPDAFHOGJC
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xADDA20", Offset = "0xADC820", VA = "0x180ADDA20", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xADC740", Offset = "0xADB540", VA = "0x180ADC740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public MINEBKJHCFN DMOFHJCKCKP
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xAC1A00", Offset = "0xAC0800", VA = "0x180AC1A00", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xAC0B80", Offset = "0xABF980", VA = "0x180AC0B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public LAKFJEOHOAC PAEBNFGIHCG
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xAC1A10", Offset = "0xAC0810", VA = "0x180AC1A10", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xAC1480", Offset = "0xAC0280", VA = "0x180AC1480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public NFMCGGLGEDK EDLADPFJNNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xAE2C70", Offset = "0xAE1A70", VA = "0x180AE2C70", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xBAE3F0", Offset = "0xBAD1F0", VA = "0x180BAE3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public ENHLNEAIPEI PCJNABGKINB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA884F0", Offset = "0xA872F0", VA = "0x180A884F0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA88580", Offset = "0xA87380", VA = "0x180A88580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public DPKHKMABECE CLHJLBCHAGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA88200", Offset = "0xA87000", VA = "0x180A88200", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA88560", Offset = "0xA87360", VA = "0x180A88560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public AKCEBBAKJMD GNIMOLDHBOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA872C0", Offset = "0xA860C0", VA = "0x180A872C0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA826B0", Offset = "0xA814B0", VA = "0x180A826B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public FLLFABBPDNP NLEDFONIOCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xACD6D0", Offset = "0xACC4D0", VA = "0x180ACD6D0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xACF580", Offset = "0xACE380", VA = "0x180ACF580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public HKHLJMHFNLH CHIBLOPEFKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA871C0", Offset = "0xA85FC0", VA = "0x180A871C0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA82FD0", Offset = "0xA81DD0", VA = "0x180A82FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public PANKIDIEDAK NFNIEGEAJCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xACA520", Offset = "0xAC9320", VA = "0x180ACA520", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public IFKLAILBPMB AECIMJOJCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xAC8080", Offset = "0xAC6E80", VA = "0x180AC8080", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public LMAKAKBFNCK CKPOPCHGHOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xAC3570", Offset = "0xAC2370", VA = "0x180AC3570", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public FOEDDKHMNOB BJCLGAKHDMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xACE460", Offset = "0xACD260", VA = "0x180ACE460", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public PMOBBKDCDFN EMLGHPNHEFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xAE1950", Offset = "0xAE0750", VA = "0x180AE1950", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public ACOLPPBLNNC INBEEOFLAAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xAC3580", Offset = "0xAC2380", VA = "0x180AC3580", Slot = "60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xC49890", Offset = "0xC48690", VA = "0x180C49890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool EFHKPFINIOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x85BCD30", Offset = "0x85BBB30", VA = "0x1885BCD30", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool APFAJGGKFMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x85BD530", Offset = "0x85BC330", VA = "0x1885BD530", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool CBECEGPGMPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x1C89A30", Offset = "0x1C88830", VA = "0x181C89A30", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private CancellationToken KNIFGODNGMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x85BD200", Offset = "0x85BC000", VA = "0x1885BD200", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private NAELDDAANND FEPCEPPPIAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private bool KIEGDEFBFIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x1C89A30", Offset = "0x1C88830", VA = "0x181C89A30", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x1C87B00", Offset = "0x1C86900", VA = "0x181C87B00", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action BLOHAENGDJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x85BCFC0", Offset = "0x85BBDC0", VA = "0x1885BCFC0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x85BCC10", Offset = "0x85BBA10", VA = "0x1885BCC10", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event ONLGPJJNKGI FKADGPFHKCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x85BCC70", Offset = "0x85BBA70", VA = "0x1885BCC70", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x85BCD90", Offset = "0x85BBB90", VA = "0x1885BCD90", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event ONLGPJJNKGI ENDOHLLEACD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x85BCF60", Offset = "0x85BBD60", VA = "0x1885BCF60", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x85BCF00", Offset = "0x85BBD00", VA = "0x1885BCF00", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event ONLGPJJNKGI JELKFLDJAGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x85BD020", Offset = "0x85BBE20", VA = "0x1885BD020", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x85BC810", Offset = "0x85BB610", VA = "0x1885BC810", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<LKEHMNNHDHP, bool> NEPBKGNDDBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x85BCEA0", Offset = "0x85BBCA0", VA = "0x1885BCEA0", Slot = "48")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x85BCCD0", Offset = "0x85BBAD0", VA = "0x1885BCCD0", Slot = "49")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0xC49890", Offset = "0xC48690", VA = "0x180C49890", Slot = "39")]
	public void DBGFBCKLBLK(ACOLPPBLNNC ABCMKDJBFGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x85BD5B0", Offset = "0x85BC3B0", VA = "0x1885BD5B0")]
	[UnityEngine.Scripting.Preserve]
	internal AKBFLKFLKIM([LCNEJNNIOGA(null)] NAELDDAANND AHGNCOFKLHK, [LCNEJNNIOGA(null)] PNEPNDOKHCF KLBDPNGJELI, [LCNEJNNIOGA(null)] OOALADCCJDG EPHBDDJFCDO, [LCNEJNNIOGA(null)] KHIJDEHFOJA LKIBPKBGCOO, [LCNEJNNIOGA(null)] BIPJBOOKCJI ANLIOIJIDJG, [LCNEJNNIOGA(null)] BPJFPFLMOMA LKGMJJACBNP, [LCNEJNNIOGA(null)] PGBAMBHBOMF HANFOIBOOBP, [LCNEJNNIOGA(null)] HMCLAFELGLA NFPANFIHGFH, [LCNEJNNIOGA(null)] FKBNPLCEDMG AOAALKNJFNE, [LCNEJNNIOGA(null)] MMFENADFOFA CNCMMAGDNBI, [LCNEJNNIOGA(null)] OGDPOBHAJLA ELMBDFGIJCN, [LCNEJNNIOGA(null)] CLGEKOKCCID PLMICPCEJMC, [LCNEJNNIOGA(null)] JBIDHHLDGEM FFKOMCHKHBE, [LCNEJNNIOGA(null)] LELEALOGJCL HNMIHLHLGBA, [LCNEJNNIOGA(null)] ALIJJKDAOBM NONODBCJHHC, [LCNEJNNIOGA(null)] DGLFJMDONOJ BLCMHGGLIHG, [LCNEJNNIOGA(null)] AICMHOPJHHA FJHGCGAFCFH, [LCNEJNNIOGA(null)] BJAOKJCOCOJ IJLBJECHKKL, [LCNEJNNIOGA(null)] EGIPCKEJEEF GIPKFIJGCCH, [LCNEJNNIOGA(null)] DIPENBPMFLI NAJEIHPDHAB, [LCNEJNNIOGA(null)] LAKFJEOHOAC IIHOKJDMJLB, [LCNEJNNIOGA(null)] MINEBKJHCFN HDIPNEJKKKO, [LCNEJNNIOGA(null)] NFMCGGLGEDK EDJECMIICJG, [LCNEJNNIOGA(null)] ENHLNEAIPEI EFJAHEFBEKI, [LCNEJNNIOGA(null)] DPKHKMABECE GLLMJNOCNDG, [LCNEJNNIOGA(null)] FLLFABBPDNP EKMDFFAGMPN, [LCNEJNNIOGA(null)] HKHLJMHFNLH COHKMHPAMKN, [LCNEJNNIOGA(null)] PANKIDIEDAK BILJBDDHDJH, [LCNEJNNIOGA(null)] IFKLAILBPMB CDKPMDBACAH, [LCNEJNNIOGA(null)] LMAKAKBFNCK DLBECODNACL, [LCNEJNNIOGA(null)] FOEDDKHMNOB AILCICFGDMC, [LCNEJNNIOGA(null)] PMOBBKDCDFN AFLKOENIBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x85BCDF0", Offset = "0x85BBBF0", VA = "0x1885BCDF0")]
	private void IANLJFINMMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x85BC9E0", Offset = "0x85BB7E0", VA = "0x1885BC9E0", Slot = "61")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x85BC6B0", Offset = "0x85BB4B0", VA = "0x1885BC6B0", Slot = "53")]
	private void AOGCDIOHHDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x85BD170", Offset = "0x85BBF70", VA = "0x1885BD170", Slot = "54")]
	private FMCIILJJKCO MHBOJOFAHGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x85BCB80", Offset = "0x85BB980", VA = "0x1885BCB80", Slot = "55")]
	private HLCOPCGLHDG EAFDIOGIHEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x85BD220", Offset = "0x85BC020", VA = "0x1885BD220", Slot = "57")]
	public Task NBAPJKJDNOE(int JFFMBFCFHJI, KKDADIJBPAI LANGIPGHPFC, Func<ABCJCMNNNGP, ABCJCMNNNGP> EDKBIAIMAMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x85BC870", Offset = "0x85BB670", VA = "0x1885BC870")]
	private NJKJCLDHHFP DDNENGODMEF(int JFFMBFCFHJI, KKDADIJBPAI LANGIPGHPFC, Func<ABCJCMNNNGP, ABCJCMNNNGP> EDKBIAIMAMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x85BC700", Offset = "0x85BB500", VA = "0x1885BC700", Slot = "58")]
	[AsyncStateMachine(typeof(KAHONJGPMMI))]
	private Task<NPEBMFOKKKC> BMIOAFEGBOP(ONKMAFKLDAF GCOKBAEPGNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x85BD080", Offset = "0x85BBE80", VA = "0x1885BD080", Slot = "59")]
	[AsyncStateMachine(typeof(JEJODPGJDCH))]
	private Task MBBCBHJLGPL(CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x85BC630", Offset = "0x85BB430", VA = "0x1885BC630")]
	[IteratorStateMachine(typeof(KOAAGAIHNAB))]
	private IEnumerable<EFFGJDOCBHN> AIAAOGLOANK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x85BC980", Offset = "0x85BB780", VA = "0x1885BC980")]
	[CompilerGenerated]
	private void DPDCOAAALEG(EFFGJDOCBHN OFNOAHMACNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class ECMDAKLEECD : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x1856650", Offset = "0x1855450", VA = "0x181856650")]
	public ECMDAKLEECD(string NJJDPBHNDPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal class BMDBKIENJNG : ECMGPLECEJM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct EFMAKLHAEPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder<ECMGPLECEJM.OICBIJPCEPP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public HashSet<CLGEKOKCCID.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public BMDBKIENJNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x85C2B80", Offset = "0x85C1980", VA = "0x1885C2B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x85C2E90", Offset = "0x85C1C90", VA = "0x1885C2E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly GMNLHEBCJHB PPAOCCCONKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly KHIJDEHFOJA LKIBPKBGCOO;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private string CHIMFDKCDGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x85BE7D0", Offset = "0x85BD5D0", VA = "0x1885BE7D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0xA17110", Offset = "0xA15F10", VA = "0x180A17110")]
	public BMDBKIENJNG(GMNLHEBCJHB PPAOCCCONKJ, KHIJDEHFOJA LKIBPKBGCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x85BE800", Offset = "0x85BD600", VA = "0x1885BE800", Slot = "5")]
	[AsyncStateMachine(typeof(EFMAKLHAEPM))]
	public Task<ECMGPLECEJM.OICBIJPCEPP> KKNGEDNIMJD(HashSet<CLGEKOKCCID.Reason> ONMINPNJMJM, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal class DCGHFOKAHEN : EHADFNJPDEA, ECMGPLECEJM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct DDMBMGPNPNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder<ECMGPLECEJM.OICBIJPCEPP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public DCGHFOKAHEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public HashSet<CLGEKOKCCID.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private DAFHNINMJHP <localRoomInstance>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private long <preFallbackInstance>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private bool <currentIsOffline>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TaskAwaiter<ECMGPLECEJM.OICBIJPCEPP> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x85BFD60", Offset = "0x85BEB60", VA = "0x1885BFD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x85C06C0", Offset = "0x85BF4C0", VA = "0x1885C06C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private string CHIMFDKCDGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x85BF830", Offset = "0x85BE630", VA = "0x1885BF830", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0xA17110", Offset = "0xA15F10", VA = "0x180A17110")]
	public DCGHFOKAHEN(GMNLHEBCJHB PPAOCCCONKJ, KHIJDEHFOJA LKIBPKBGCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x85BF860", Offset = "0x85BE660", VA = "0x1885BF860", Slot = "5")]
	[AsyncStateMachine(typeof(DDMBMGPNPNI))]
	public Task<ECMGPLECEJM.OICBIJPCEPP> KKNGEDNIMJD(HashSet<CLGEKOKCCID.Reason> ONMINPNJMJM, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal class IDMJCLLEHNJ : EHADFNJPDEA, ECMGPLECEJM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct NKDPDEEGOOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public AsyncTaskMethodBuilder<ECMGPLECEJM.OICBIJPCEPP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public IDMJCLLEHNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public HashSet<CLGEKOKCCID.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private TaskAwaiter<IMBDKHEFFFL> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private TaskAwaiter<ECMGPLECEJM.OICBIJPCEPP> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x85CD740", Offset = "0x85CC540", VA = "0x1885CD740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x85CE130", Offset = "0x85CCF30", VA = "0x1885CE130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private string CHIMFDKCDGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x85C64B0", Offset = "0x85C52B0", VA = "0x1885C64B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0xA17110", Offset = "0xA15F10", VA = "0x180A17110")]
	public IDMJCLLEHNJ(GMNLHEBCJHB PPAOCCCONKJ, KHIJDEHFOJA LKIBPKBGCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x85C64E0", Offset = "0x85C52E0", VA = "0x1885C64E0", Slot = "5")]
	[AsyncStateMachine(typeof(NKDPDEEGOOC))]
	public Task<ECMGPLECEJM.OICBIJPCEPP> KKNGEDNIMJD(HashSet<CLGEKOKCCID.Reason> ONMINPNJMJM, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal class LCNBKDDAOFF : EHADFNJPDEA, ECMGPLECEJM
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class LOBHFOJLKLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public IMBDKHEFFFL matchmakingErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public DAFHNINMJHP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public long preFallbackInstance;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public LOBHFOJLKLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x85CBE50", Offset = "0x85CAC50", VA = "0x1885CBE50")]
		internal object BCCIIIFMFMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x85CBED0", Offset = "0x85CACD0", VA = "0x1885CBED0")]
		internal object OGBDEKGOLEC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct KPGKEBICNBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public AsyncTaskMethodBuilder<ECMGPLECEJM.OICBIJPCEPP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public LCNBKDDAOFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public HashSet<CLGEKOKCCID.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private LOBHFOJLKLL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private TaskAwaiter<IMBDKHEFFFL> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private TaskAwaiter<ECMGPLECEJM.OICBIJPCEPP> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x85CA900", Offset = "0x85C9700", VA = "0x1885CA900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x85CB540", Offset = "0x85CA340", VA = "0x1885CB540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private string CHIMFDKCDGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x85CBBB0", Offset = "0x85CA9B0", VA = "0x1885CBBB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0xA17110", Offset = "0xA15F10", VA = "0x180A17110")]
	public LCNBKDDAOFF(GMNLHEBCJHB PPAOCCCONKJ, KHIJDEHFOJA LKIBPKBGCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x85CBBE0", Offset = "0x85CA9E0", VA = "0x1885CBBE0", Slot = "5")]
	[AsyncStateMachine(typeof(KPGKEBICNBE))]
	public Task<ECMGPLECEJM.OICBIJPCEPP> KKNGEDNIMJD(HashSet<CLGEKOKCCID.Reason> ONMINPNJMJM, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal abstract class EHADFNJPDEA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct EDCANMJAEDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public IEBEPMGFCGH log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public HashSet<CLGEKOKCCID.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public EHADFNJPDEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private OGIJLBDGAHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private List<CLGEKOKCCID.Reason> <newDisconnectTriggers>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x85C2600", Offset = "0x85C1400", VA = "0x1885C2600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x85C2B20", Offset = "0x85C1920", VA = "0x1885C2B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	protected readonly GMNLHEBCJHB PPAOCCCONKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	protected readonly KHIJDEHFOJA LKIBPKBGCOO;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	protected HNJJDFCNNLG NGAOLAIDCMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x85C2F00", Offset = "0x85C1D00", VA = "0x1885C2F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0xA17110", Offset = "0xA15F10", VA = "0x180A17110")]
	public EHADFNJPDEA(GMNLHEBCJHB PPAOCCCONKJ, KHIJDEHFOJA LKIBPKBGCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x85C2F50", Offset = "0x85C1D50", VA = "0x1885C2F50")]
	[AsyncStateMachine(typeof(EDCANMJAEDE))]
	protected Task GCDGKGFFLLF(IEBEPMGFCGH NHLEILEPJMB, HashSet<CLGEKOKCCID.Reason> ONMINPNJMJM, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class DFDBDLDDKJI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct OANEPIPAEMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public AsyncTaskMethodBuilder<ECMGPLECEJM.OICBIJPCEPP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public KHIJDEHFOJA callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x85CE220", Offset = "0x85CD020", VA = "0x1885CE220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x85CE5A0", Offset = "0x85CD3A0", VA = "0x1885CE5A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class GJCCBHMMGKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public string fallbackName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public GMNLHEBCJHB roomManager;

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public GJCCBHMMGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x85C5B80", Offset = "0x85C4980", VA = "0x1885C5B80")]
		internal object JFNEHCOGPIO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static readonly float OMKJOHIFPGD;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	internal static readonly HashSet<CLGEKOKCCID.Reason> JINOJHLNMLK;

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x85C0730", Offset = "0x85BF530", VA = "0x1885C0730")]
	[AsyncStateMachine(typeof(OANEPIPAEMD))]
	internal static Task<ECMGPLECEJM.OICBIJPCEPP> LNAIBCGGBEM(KHIJDEHFOJA LKIBPKBGCOO, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x85C0840", Offset = "0x85BF640", VA = "0x1885C0840")]
	internal static void PLCGOPINICB(GMNLHEBCJHB PPAOCCCONKJ, IEBEPMGFCGH NHLEILEPJMB, string DEOPMKGJEIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal interface ECMGPLECEJM
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct OICBIJPCEPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public bool FHEDCABKFLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public CLGEKOKCCID.Reason KLOPBEMIGAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Enum? JAGEMFNEMAI;

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x85D2D40", Offset = "0x85D1B40", VA = "0x1885D2D40")]
		public static OICBIJPCEPP LGKACBKCCFB()
		{
			return default(OICBIJPCEPP);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x85D2D50", Offset = "0x85D1B50", VA = "0x1885D2D50")]
		public static OICBIJPCEPP PDBHMFEGDCN(CLGEKOKCCID.Reason KLOPBEMIGAO, [Optional] Enum? JAGEMFNEMAI)
		{
			return default(OICBIJPCEPP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	string JEMGHNCEOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<OICBIJPCEPP> KKNGEDNIMJD(HashSet<CLGEKOKCCID.Reason> ONMINPNJMJM, CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal struct DLIFOGILNOB
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class JPIKIJEKIBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public GMNLHEBCJHB manager;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public JPIKIJEKIBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x85C9740", Offset = "0x85C8540", VA = "0x1885C9740")]
		internal Task KAANNMOAMAL(CancellationToken cancellationToken, int roomTotalVersion, OKJOLANABCP localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct KPHLNJOAIOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public DLIFOGILNOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private ONKMAFKLDAF <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private TaskAwaiter<CNPAIGBENAC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TaskAwaiter<NPEBMFOKKKC> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x85CB5B0", Offset = "0x85CA3B0", VA = "0x1885CB5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x85CBB40", Offset = "0x85CA940", VA = "0x1885CBB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct FCKMIJDKKCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public DLIFOGILNOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x85C3F50", Offset = "0x85C2D50", VA = "0x1885C3F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x85C4270", Offset = "0x85C3070", VA = "0x1885C4270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly CancellationToken GHKBKDKNIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly GMNLHEBCJHB HBNPNMJNNHB;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private PNEPNDOKHCF PCDGBLIDLLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x85C1BE0", Offset = "0x85C09E0", VA = "0x1885C1BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private KHIJDEHFOJA NLOFNFPCHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x85C1B10", Offset = "0x85C0910", VA = "0x1885C1B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private HNJJDFCNNLG NGAOLAIDCMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x85C1B60", Offset = "0x85C0960", VA = "0x1885C1B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private MMFENADFOFA GPCBBJGCAMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x85C1AC0", Offset = "0x85C08C0", VA = "0x1885C1AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x282CE40", Offset = "0x282BC40", VA = "0x18282CE40")]
	public DLIFOGILNOB(CancellationToken GHKBKDKNIOM, GMNLHEBCJHB HBNPNMJNNHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x85C1A10", Offset = "0x85C0810", VA = "0x1885C1A10")]
	public static AOFGFCPMAHF BCKBCPEOANI(GMNLHEBCJHB HBNPNMJNNHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x85C1D60", Offset = "0x85C0B60", VA = "0x1885C1D60")]
	[AsyncStateMachine(typeof(KPHLNJOAIOG))]
	public Task<bool> LECHDFIDIED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x85C1800", Offset = "0x85C0600", VA = "0x1885C1800")]
	private bool AEHGEGIFBKM([Out] ONKMAFKLDAF GCOKBAEPGNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x85C1E70", Offset = "0x85C0C70", VA = "0x1885C1E70")]
	[AsyncStateMachine(typeof(FCKMIJDKKCE))]
	private Task NNCMHPKBCHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x85C1C30", Offset = "0x85C0A30", VA = "0x1885C1C30")]
	private Task<CNPAIGBENAC> KNAIIELMEFM(ONKMAFKLDAF BNKKNPEBCKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct GDBEHCBBGEI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly ALIJJKDAOBM NONODBCJHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly Guid LGNCELEMLNH;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private Task<(NPEBMFOKKKC, Task)> HJFLOPKNCDA
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x85C4C20", Offset = "0x85C3A20", VA = "0x1885C4C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x513F450", Offset = "0x513E250", VA = "0x18513F450")]
	public GDBEHCBBGEI(ALIJJKDAOBM NONODBCJHHC, Guid LGNCELEMLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x85C4BD0", Offset = "0x85C39D0", VA = "0x1885C4BD0")]
	public TaskAwaiter<(NPEBMFOKKKC, Task)> BCGDNIKCDKC()
	{
		return default(TaskAwaiter<(NPEBMFOKKKC, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x85C4CF0", Offset = "0x85C3AF0", VA = "0x1885C4CF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal struct BFMDFMBDOON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly TaskCompletionSource<(NPEBMFOKKKC, Task)> NCIBEADJBPB;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Task<(NPEBMFOKKKC, Task)> HJFLOPKNCDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x85BE480", Offset = "0x85BD280", VA = "0x1885BE480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x85BE640", Offset = "0x85BD440", VA = "0x1885BE640")]
	public BFMDFMBDOON(TimeSpan LCJLIMHGKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x85BE5A0", Offset = "0x85BD3A0", VA = "0x1885BE5A0")]
	public void MGBPFMOMNDM(Task DELLKDOKFMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x85BE3F0", Offset = "0x85BD1F0", VA = "0x1885BE3F0")]
	public void AJKJMBICGMJ(NPEBMFOKKKC MJMCEHEEBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x85BE550", Offset = "0x85BD350", VA = "0x1885BE550")]
	public void LMBNDNDMDED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x85BE4C0", Offset = "0x85BD2C0", VA = "0x1885BE4C0")]
	internal void HPFFIKLJMLG(string NJJDPBHNDPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class DCOHGDFNALN
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x85BFA30", Offset = "0x85BE830", VA = "0x1885BFA30")]
	public static EJLGFFHHDJD CNKMNHPBFEG(this EJLGFFHHDJD DKEBGKJJPPO, IEHEOOILKKD PHFLMLOOEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x85BFBD0", Offset = "0x85BE9D0", VA = "0x1885BFBD0")]
	public static EJLGFFHHDJD MLIDNDNAIMA(this EJLGFFHHDJD DKEBGKJJPPO, DOPKLEOCCDO IJMNADDOJFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class JGIDFDCNKIN : ALACNOHNDBC
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class LMLMKADBICK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public DOPKLEOCCDO subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public LMLMKADBICK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x85CBE20", Offset = "0x85CAC20", VA = "0x1885CBE20")]
		internal bool OPPJKFOJIEP(HLKGJIPFKJP s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly FLLFABBPDNP POCLFMIIHMA;

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
	public JGIDFDCNKIN(FLLFABBPDNP EKMDFFAGMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x85C9600", Offset = "0x85C8400", VA = "0x1885C9600", Slot = "4")]
	public EJLGFFHHDJD BHEMCOAOOEF(long IOOGOLJCMGG, long AIBOEBCNHLB, string LOPKMJOKGEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x85C94A0", Offset = "0x85C82A0", VA = "0x1885C94A0", Slot = "5")]
	public EJLGFFHHDJD BHEMCOAOOEF(long IOOGOLJCMGG, long AIBOEBCNHLB, CKNMKLKMAFP JINFFCDMHMF, Guid? OICMNLFEKDO, long JCHKNPOGNLH, bool MIEJNIDEEMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x85C8FC0", Offset = "0x85C7DC0", VA = "0x1885C8FC0", Slot = "6")]
	public EJLGFFHHDJD BHEMCOAOOEF(HIFJOJHPHLI NOIGPBLOOGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x85C91C0", Offset = "0x85C7FC0", VA = "0x1885C91C0", Slot = "7")]
	public EJLGFFHHDJD BHEMCOAOOEF(IEHEOOILKKD IPMOLJAFIMD, DOPKLEOCCDO COEAMHDJCMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x85C9690", Offset = "0x85C8490", VA = "0x1885C9690")]
	private Guid? GMEHGMPJCAN(IEHEOOILKKD COGKENFMFDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.NoEngine.Common.Preserve]
internal class CHBDJHIMMLM : FKBNPLCEDMG, EFFGJDOCBHN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct JEANNPFEBDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public CHBDJHIMMLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private OGIJLBDGAHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x85C8630", Offset = "0x85C7430", VA = "0x1885C8630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x85C8CD0", Offset = "0x85C7AD0", VA = "0x1885C8CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly DPBIDJALKLM MLENBBMEADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private string JLPPFEGLNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Task OJBKKMONNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private GMNLHEBCJHB PPAOCCCONKJ;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool PJOMDJFDICE
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x85BEA20", Offset = "0x85BD820", VA = "0x1885BEA20", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Task EPPLEFHOGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x85BE990", Offset = "0x85BD790", VA = "0x1885BE990", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900", Slot = "7")]
	public void IANLJFINMMK(GMNLHEBCJHB PPAOCCCONKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x85BEB70", Offset = "0x85BD970", VA = "0x1885BEB70", Slot = "6")]
	public void PMMEIDBJHIH(Task JDEJDGHOHNF, string HJPFPPBGHGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x85BEA50", Offset = "0x85BD850", VA = "0x1885BEA50")]
	[AsyncStateMachine(typeof(JEANNPFEBDD))]
	private Task OMIDPGIFCFD(Task JPKEDFDKHPA, string HJPFPPBGHGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x85BECD0", Offset = "0x85BDAD0", VA = "0x1885BECD0")]
	public CHBDJHIMMLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal class IDILFOAPGNA : AKCEBBAKJMD, EFFGJDOCBHN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private bool NNMCDAMNLAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private OJHCGNKMJME MLIGIMGEPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private PNEPNDOKHCF KLBDPNGJELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private FLLFABBPDNP EKMDFFAGMPN;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public OJHCGNKMJME NMMHPMMBLLA
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x85C61C0", Offset = "0x85C4FC0", VA = "0x1885C61C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x85C6330", Offset = "0x85C5130", VA = "0x1885C6330", Slot = "7")]
	public void IANLJFINMMK(GMNLHEBCJHB PPAOCCCONKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x85C6010", Offset = "0x85C4E10", VA = "0x1885C6010", Slot = "5")]
	public void BAJJFEAACNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x85C6230", Offset = "0x85C5030", VA = "0x1885C6230", Slot = "6")]
	public void IAEPAKEAIBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x85C6270", Offset = "0x85C5070", VA = "0x1885C6270")]
	private Task HICBNPODKDN(OJIEIHJFFCG AOJFFKDCAKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x85C6230", Offset = "0x85C5030", VA = "0x1885C6230", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public IDILFOAPGNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal class GGJDMHNFNBO : FLLFABBPDNP
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private class LONHJDGHDOI<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly IPJEPIMCHKK FMBEDHKNIIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly string MAKJJJECHHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly T LDGCNLHOBMI;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public T COJGBJGNJFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0xCA8320", Offset = "0xCA7120", VA = "0x180CA8320")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0xCA7770", Offset = "0xCA6570", VA = "0x180CA7770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x51B2D20", Offset = "0x51B1B20", VA = "0x1851B2D20")]
		public LONHJDGHDOI(IPJEPIMCHKK FMBEDHKNIIH, string MAKJJJECHHB, T LDGCNLHOBMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x51B2750", Offset = "0x51B1550", VA = "0x1851B2750")]
		private void NNCKBLOHACF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly IPJEPIMCHKK FMBEDHKNIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly LONHJDGHDOI<TimeSpan> LABADJAOGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly LONHJDGHDOI<TimeSpan> BNIOKNGDHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly LONHJDGHDOI<TimeSpan> EFFIPDEEPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly LONHJDGHDOI<TimeSpan> MHNKBGJDAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly LONHJDGHDOI<bool> CNHNGCCLJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly LONHJDGHDOI<bool> EMDOHKHPGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly LONHJDGHDOI<bool> PJJKCNLEMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly LONHJDGHDOI<int> IBOKFILMMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly LONHJDGHDOI<bool> GMNJDAPHGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly LONHJDGHDOI<bool> FAHGLAMAPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly LONHJDGHDOI<AJJFEMDAEDB> CNJBNPEDNKC;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public TimeSpan PDGGNOBGAPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x85C4FF0", Offset = "0x85C3DF0", VA = "0x1885C4FF0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public TimeSpan KIKIHKIFODH
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x85C5030", Offset = "0x85C3E30", VA = "0x1885C5030", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public TimeSpan GCIAHGIIENM
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x85C5130", Offset = "0x85C3F30", VA = "0x1885C5130", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public TimeSpan KPJCNBDLMOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x85C5070", Offset = "0x85C3E70", VA = "0x1885C5070", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool KDLMAMOOMPN
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x85C51F0", Offset = "0x85C3FF0", VA = "0x1885C51F0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool GEDFKDDHDEP
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x85C5280", Offset = "0x85C4080", VA = "0x1885C5280", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool MHPEHIHGAIH
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x85C50F0", Offset = "0x85C3EF0", VA = "0x1885C50F0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int KPKPAJHIHLF
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x85C5170", Offset = "0x85C3F70", VA = "0x1885C5170", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool JAFDOPKJNKA
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x85C51B0", Offset = "0x85C3FB0", VA = "0x1885C51B0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool NOJHKECIIMA
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x85C50B0", Offset = "0x85C3EB0", VA = "0x1885C50B0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool AJIHJJPKNOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x85C5230", Offset = "0x85C4030", VA = "0x1885C5230", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x85C52C0", Offset = "0x85C40C0", VA = "0x1885C52C0")]
	[UnityEngine.Scripting.Preserve]
	public GGJDMHNFNBO([LCNEJNNIOGA(null)] IPJEPIMCHKK FMBEDHKNIIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[UnityEngine.Scripting.Preserve]
internal class OIBICNGOFMC : OGDPOBHAJLA, EFFGJDOCBHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class DNKAKHGBMEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public LHFNDJOEGHO roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public DNKAKHGBMEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x85C1F40", Offset = "0x85C0D40", VA = "0x1885C1F40")]
		internal object BJCOIOOKDFB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action LLJBJNLIFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x85D2630", Offset = "0x85D1430", VA = "0x1885D2630", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x85D2C70", Offset = "0x85D1A70", VA = "0x1885D2C70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event ONLGPJJNKGI KNDMINJHFLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x85D2230", Offset = "0x85D1030", VA = "0x1885D2230", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x85D2970", Offset = "0x85D1770", VA = "0x1885D2970", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event ONLGPJJNKGI KDMGPIDFDCA
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x85D2BD0", Offset = "0x85D19D0", VA = "0x1885D2BD0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x85D28A0", Offset = "0x85D16A0", VA = "0x1885D28A0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event ONLGPJJNKGI DGKIIMEOOOM
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x85D2AE0", Offset = "0x85D18E0", VA = "0x1885D2AE0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x85D2A40", Offset = "0x85D1840", VA = "0x1885D2A40", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<LKEHMNNHDHP, bool> BFFJMGAGCJL
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x85D22D0", Offset = "0x85D10D0", VA = "0x1885D22D0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x85D2580", Offset = "0x85D1380", VA = "0x1885D2580", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "19")]
	public void IANLJFINMMK(GMNLHEBCJHB PPAOCCCONKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x85D2380", Offset = "0x85D1180", VA = "0x1885D2380", Slot = "14")]
	public void FFKLJDCBAFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x85D2A10", Offset = "0x85D1810", VA = "0x1885D2A10", Slot = "15")]
	public void IMANCLPPPLJ(LHFNDJOEGHO LFNOMKAPHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x85D2D10", Offset = "0x85D1B10", VA = "0x1885D2D10", Slot = "16")]
	public void NJJNEOELAHL(LHFNDJOEGHO LFNOMKAPHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x85D2940", Offset = "0x85D1740", VA = "0x1885D2940", Slot = "17")]
	public void ICMPIFJPJIL(LHFNDJOEGHO LFNOMKAPHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x85D2B80", Offset = "0x85D1980", VA = "0x1885D2B80", Slot = "18")]
	public void MGINDINLIKE(LKEHMNNHDHP CHNEHFOJOHF, bool FHEDCABKFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x85D26D0", Offset = "0x85D14D0", VA = "0x1885D26D0")]
	private void HDKOJPGLKCE(ONLGPJJNKGI EAEFPGALELD, LHFNDJOEGHO LFNOMKAPHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public OIBICNGOFMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[UnityEngine.Scripting.Preserve]
internal class POCDPNKMEOK : CLGEKOKCCID, EFFGJDOCBHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private class PKJBNGACFBH : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private struct FHJBGBOIKGN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public PKJBNGACFBH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public CLGEKOKCCID.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			private OGIJLBDGAHB <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			private ECMGPLECEJM[] <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			private TaskAwaiter<ECMGPLECEJM.OICBIJPCEPP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x85C42D0", Offset = "0x85C30D0", VA = "0x1885C42D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x85C4A10", Offset = "0x85C3810", VA = "0x1885C4A10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private struct DKPMDBNBIGC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public AsyncTaskMethodBuilder<ECMGPLECEJM.OICBIJPCEPP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public ECMGPLECEJM fallbackProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public PKJBNGACFBH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public CLGEKOKCCID.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			private OGIJLBDGAHB <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			private BAEDNBPLMBM <individualFallbackTaskState>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			private TaskAwaiter<ECMGPLECEJM.OICBIJPCEPP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x85C0AE0", Offset = "0x85BF8E0", VA = "0x1885C0AE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0x85C1790", Offset = "0x85C0590", VA = "0x1885C1790", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class MGNAEKMJHPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public ECMGPLECEJM fallbackProvider;

			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public MGNAEKMJHPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x85CC5E0", Offset = "0x85CB3E0", VA = "0x1885CC5E0")]
			internal object JHEMNGKPCJE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public Task JDEJDGHOHNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public CancellationTokenSource JANOHMJCACE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public BAEDNBPLMBM OODLLGLDAAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public KHIJDEHFOJA LKIBPKBGCOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public FDBBKNBANNJ KLDPEFLBHJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public DAFHNINMJHP GLJABNGDFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public ECMGPLECEJM[] MMGOLNNHCEH;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public bool IGGJDLMDHKL
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x85BDFE0", Offset = "0x85BCDE0", VA = "0x1885BDFE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool NOJFOIAGKMB
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x85BDE50", Offset = "0x85BCC50", VA = "0x1885BDE50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x85D4AB0", Offset = "0x85D38B0", VA = "0x1885D4AB0")]
		public PKJBNGACFBH(KHIJDEHFOJA LKIBPKBGCOO, FDBBKNBANNJ KLDPEFLBHJI, DAFHNINMJHP GLJABNGDFFO, ECMGPLECEJM[] MMGOLNNHCEH, CancellationToken GHKBKDKNIOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x85D3050", Offset = "0x85D1E50", VA = "0x1885D3050", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x85D3BF0", Offset = "0x85D29F0", VA = "0x1885D3BF0")]
		public void HIHFPJIDCPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x85D34A0", Offset = "0x85D22A0", VA = "0x1885D34A0")]
		public void FOGHONGOHIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x85D3750", Offset = "0x85D2550", VA = "0x1885D3750")]
		public void GKEPCCEBKBI(CLGEKOKCCID.Reason PPODFEMMOCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x85D33A0", Offset = "0x85D21A0", VA = "0x1885D33A0")]
		[AsyncStateMachine(typeof(FHJBGBOIKGN))]
		public Task FGBOPKPCAKF(CLGEKOKCCID.Reason KLOPBEMIGAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x85D3610", Offset = "0x85D2410", VA = "0x1885D3610")]
		[AsyncStateMachine(typeof(DKPMDBNBIGC))]
		private Task<ECMGPLECEJM.OICBIJPCEPP> GFGBKGBKCMJ(CLGEKOKCCID.Reason KLOPBEMIGAO, ECMGPLECEJM MMCDKOLBBOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x85D3C60", Offset = "0x85D2A60", VA = "0x1885D3C60")]
		private void IBKEDHEEDOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x85D3D80", Offset = "0x85D2B80", VA = "0x1885D3D80")]
		public bool JIJGIGIECOM(CLGEKOKCCID.Reason ENLAIAIPINB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x85D4370", Offset = "0x85D3170", VA = "0x1885D4370")]
		private void PICAHEANHPH(BAEDNBPLMBM JNOIIIFBOLM, CLGEKOKCCID.Reason KLOPBEMIGAO = CLGEKOKCCID.Reason.Unknown)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x85D3A20", Offset = "0x85D2820", VA = "0x1885D3A20")]
		private void GOOJLDEKFJE(BAEDNBPLMBM JNOIIIFBOLM, ECMGPLECEJM.OICBIJPCEPP BPINCJLADGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x85D31F0", Offset = "0x85D1FF0", VA = "0x1885D31F0")]
		private void EJDPJBBAAOD(BAEDNBPLMBM JNOIIIFBOLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x85D3E30", Offset = "0x85D2C30", VA = "0x1885D3E30")]
		private void KHLHBCDGEOH(BAEDNBPLMBM JNOIIIFBOLM, ECMGPLECEJM.OICBIJPCEPP BPINCJLADGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x85D4200", Offset = "0x85D3000", VA = "0x1885D4200")]
		private void OLHCOPCOAKN(BAEDNBPLMBM JNOIIIFBOLM, Exception HELNJIPKBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x85D2F40", Offset = "0x85D1D40", VA = "0x1885D2F40")]
		private void BFBPHMFOFID(ECMGPLECEJM MMCDKOLBBOD, CLGEKOKCCID.Reason KLOPBEMIGAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x85D4630", Offset = "0x85D3430", VA = "0x1885D4630")]
		private void PPAGKPIAMDM(ECMGPLECEJM MMCDKOLBBOD, CLGEKOKCCID.Reason KLOPBEMIGAO, string JAGEMFNEMAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x85D4740", Offset = "0x85D3540", VA = "0x1885D4740", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class BAEDNBPLMBM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public Task<ECMGPLECEJM.OICBIJPCEPP> JDEJDGHOHNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public CancellationTokenSource JANOHMJCACE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public ECMGPLECEJM MMCDKOLBBOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public CLGEKOKCCID.Reason PPODFEMMOCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public HashSet<CLGEKOKCCID.Reason> ONMINPNJMJM;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public bool IGGJDLMDHKL
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x85BDFE0", Offset = "0x85BCDE0", VA = "0x1885BDFE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public bool NOJFOIAGKMB
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x85BDE50", Offset = "0x85BCC50", VA = "0x1885BDE50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x85BDE70", Offset = "0x85BCC70", VA = "0x1885BDE70")]
		public void JMFEKBCNPCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x85BDE30", Offset = "0x85BCC30", VA = "0x1885BDE30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x85BE000", Offset = "0x85BCE00", VA = "0x1885BE000", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x85BE360", Offset = "0x85BD160", VA = "0x1885BE360")]
		public BAEDNBPLMBM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class OPOILGECAJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public CLGEKOKCCID.Reason reason;

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public OPOILGECAJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x85D2E60", Offset = "0x85D1C60", VA = "0x1885D2E60")]
		internal object PEOMIAIMDJD(BAEDNBPLMBM x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x85D2D80", Offset = "0x85D1B80", VA = "0x1885D2D80")]
		internal object CKLPJKJAPGJ(PKJBNGACFBH x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x85D2DF0", Offset = "0x85D1BF0", VA = "0x1885D2DF0")]
		internal object JJFGDHGLGOB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct MPILNGAEFLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public CLGEKOKCCID.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public POCDPNKMEOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private OPOILGECAJM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private OGIJLBDGAHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x85CC660", Offset = "0x85CB460", VA = "0x1885CC660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x85CD0E0", Offset = "0x85CBEE0", VA = "0x1885CD0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct IOJHEDKFCCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public POCDPNKMEOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public CLGEKOKCCID.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private PKJBNGACFBH <localTaskState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x85C6B90", Offset = "0x85C5990", VA = "0x1885C6B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x85C7820", Offset = "0x85C6620", VA = "0x1885C7820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct PPJAGPCGMLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public POCDPNKMEOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x85D5A90", Offset = "0x85D4890", VA = "0x1885D5A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x85D6030", Offset = "0x85D4E30", VA = "0x1885D6030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	internal static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	internal static readonly IEBEPMGFCGH PJEOFFBJHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private GMNLHEBCJHB PPAOCCCONKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private KHIJDEHFOJA LKIBPKBGCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private PKJBNGACFBH MJILEEFADHI;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private HNJJDFCNNLG NGAOLAIDCMC
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x85D4F80", Offset = "0x85D3D80", VA = "0x1885D4F80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool DMDLKCPFEGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x23DEAB0", Offset = "0x23DD8B0", VA = "0x1823DEAB0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private bool DHGFNIGADKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x85D5850", Offset = "0x85D4650", VA = "0x1885D5850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x85D5560", Offset = "0x85D4360", VA = "0x1885D5560", Slot = "7")]
	public void IANLJFINMMK(GMNLHEBCJHB PPAOCCCONKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x85D5390", Offset = "0x85D4190", VA = "0x1885D5390", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x85D56C0", Offset = "0x85D44C0", VA = "0x1885D56C0", Slot = "9")]
	public void JMFEKBCNPCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x85D55E0", Offset = "0x85D43E0", VA = "0x1885D55E0")]
	private bool IPNIPLJKBFH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x85D4EB0", Offset = "0x85D3CB0", VA = "0x1885D4EB0", Slot = "6")]
	private void BHFIPENJMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x85D53A0", Offset = "0x85D41A0", VA = "0x1885D53A0", Slot = "5")]
	[AsyncStateMachine(typeof(MPILNGAEFLD))]
	private Task GEMDGBFKCAM(CLGEKOKCCID.Reason KLOPBEMIGAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x85D4BD0", Offset = "0x85D39D0", VA = "0x1885D4BD0")]
	private bool BBAOBENBDGD(CLGEKOKCCID.Reason KLOPBEMIGAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x85D4FD0", Offset = "0x85D3DD0", VA = "0x1885D4FD0")]
	private ECMGPLECEJM[] DAEJKPFPMDK(DAFHNINMJHP FKMGNHDIMJC, FDBBKNBANNJ GDABFLEOLFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x85D58C0", Offset = "0x85D46C0", VA = "0x1885D58C0")]
	[AsyncStateMachine(typeof(IOJHEDKFCCO))]
	private Task KIMAEJPONDB(CLGEKOKCCID.Reason KLOPBEMIGAO, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x85D5490", Offset = "0x85D4290", VA = "0x1885D5490")]
	[AsyncStateMachine(typeof(PPJAGPCGMLG))]
	private Task HKPACFADHOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public POCDPNKMEOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[RecRoom.NoEngine.Common.Preserve]
internal class OGLJEDIINJG : JBIDHHLDGEM, EFFGJDOCBHN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct KGLPJHMIKFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public DAFHNINMJHP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public OGLJEDIINJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public ACOLPPBLNNC customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private OGIJLBDGAHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x85C9A80", Offset = "0x85C8880", VA = "0x1885C9A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x85CA3F0", Offset = "0x85C91F0", VA = "0x1885CA3F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct JCPLIPNNHIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public OGLJEDIINJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public DAFHNINMJHP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public ACOLPPBLNNC customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private HBCKFDINPOH<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private OGIJLBDGAHB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private DKMOFLOMOKC <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private FNEPCBJJIOG <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x85C7880", Offset = "0x85C6680", VA = "0x1885C7880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x85C85D0", Offset = "0x85C73D0", VA = "0x1885C85D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class EACELNFFKHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public Matchmaking.LCOHEPLGIOM result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public NBKPMBPLAEB errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public EACELNFFKHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x85C2550", Offset = "0x85C1350", VA = "0x1885C2550")]
		internal object KLDMBKLILGI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class JAOJGJADKKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public Task<EJLGFFHHDJD> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public JAOJGJADKKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		internal Task<EJLGFFHHDJD> CPJJKODMLGF(HBCKFDINPOH<string>.DLKHFLDLCIN _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private struct AGPILJFNBLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public OGLJEDIINJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public DAFHNINMJHP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public ACOLPPBLNNC customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public DKMOFLOMOKC joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private JAOJGJADKKJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private NDJMODJJIEA <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private OGIJLBDGAHB <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private CFKPBECMIBP <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private Task<Matchmaking.LHIBODNCGEG> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private GNICADJCPCM <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private int <i>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private TaskAwaiter<Matchmaking.LHIBODNCGEG> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private TaskAwaiter<EJLGFFHHDJD> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x85B6B80", Offset = "0x85B5980", VA = "0x1885B6B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x85BC5D0", Offset = "0x85BB3D0", VA = "0x1885BC5D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct FAHGCEGOOPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public OGLJEDIINJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private OGIJLBDGAHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x85E0A00", Offset = "0x85DF800", VA = "0x1885E0A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x85E1470", Offset = "0x85E0270", VA = "0x1885E1470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct PCFIIJHLNNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public OGLJEDIINJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private NAELDDAANND <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x85F35C0", Offset = "0x85F23C0", VA = "0x1885F35C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x85F3A50", Offset = "0x85F2850", VA = "0x1885F3A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private struct KKGOOFBGFDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public AsyncTaskMethodBuilder<Matchmaking.LHIBODNCGEG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public DAFHNINMJHP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public OGLJEDIINJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private TaskAwaiter<Matchmaking.LHIBODNCGEG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x85E9F70", Offset = "0x85E8D70", VA = "0x1885E9F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x85EA450", Offset = "0x85E9250", VA = "0x1885EA450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private struct BKCGCKDMIFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public Matchmaking.LHIBODNCGEG serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public OGLJEDIINJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public DKMOFLOMOKC joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private OGIJLBDGAHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private TaskAwaiter<PELAEIAHGNO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x85DA100", Offset = "0x85D8F00", VA = "0x1885DA100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x85DA750", Offset = "0x85D9550", VA = "0x1885DA750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class JEMNAMONHAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public DAFHNINMJHP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public JEMNAMONHAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x85E95B0", Offset = "0x85E83B0", VA = "0x1885E95B0")]
		internal object MKJNHJLOGPK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x85E94B0", Offset = "0x85E82B0", VA = "0x1885E94B0")]
		internal string MFFGOCMPLHE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private struct EHGJGDGMCBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public DAFHNINMJHP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public OGLJEDIINJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private JEMNAMONHAO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private OGIJLBDGAHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x85DFDA0", Offset = "0x85DEBA0", VA = "0x1885DFDA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x85E0930", Offset = "0x85DF730", VA = "0x1885E0930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct LNFFAOGBGLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public OGLJEDIINJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public DKMOFLOMOKC joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public EJLGFFHHDJD initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public DAFHNINMJHP targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public NDJMODJJIEA progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x85EB770", Offset = "0x85EA570", VA = "0x1885EB770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x85EBF60", Offset = "0x85EAD60", VA = "0x1885EBF60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct FEMDIOJLEDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public OGLJEDIINJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private OGIJLBDGAHB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private OGIJLBDGAHB <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private CancellationTokenSource <timeoutTcs>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private CancellationToken <timeoutToken>5__8;

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x85E2970", Offset = "0x85E1770", VA = "0x1885E2970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x85E4170", Offset = "0x85E2F70", VA = "0x1885E4170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct NBOEIFAAJDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public OKJOLANABCP localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public OGLJEDIINJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private OGIJLBDGAHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private TaskAwaiter<NPEBMFOKKKC> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x85F0CE0", Offset = "0x85EFAE0", VA = "0x1885F0CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x85F14E0", Offset = "0x85F02E0", VA = "0x1885F14E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class NMEJDEIGJOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public DAFHNINMJHP targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public NMEJDEIGJOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x85F15A0", Offset = "0x85F03A0", VA = "0x1885F15A0")]
		internal object DNBFGFOLBGJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class GBAMKLPHNMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public GBAMKLPHNMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x85E4800", Offset = "0x85E3600", VA = "0x1885E4800")]
		internal void AEPDBDDEFEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class JPIJDLEFGDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public DAFHNINMJHP targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public JPIJDLEFGDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x85E9890", Offset = "0x85E8690", VA = "0x1885E9890")]
		internal object PPENJIFCOHA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class PBEHMHOALOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public DAFHNINMJHP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public PBEHMHOALOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x85F34C0", Offset = "0x85F22C0", VA = "0x1885F34C0")]
		internal string CENEHHPGHOA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static readonly IEBEPMGFCGH FHDEPKDLLGN;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly IEBEPMGFCGH NFKKEKLDFBN;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly IEBEPMGFCGH DBMGHOCKFCM;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly string FJHBDEBOGEC;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static readonly string OOECKIOIGBB;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static readonly string LIGCIFHGGII;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public static readonly Guid ADEFHJEFJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private HMCLAFELGLA NFPANFIHGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private OOALADCCJDG EPHBDDJFCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private PNEPNDOKHCF KLBDPNGJELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private GMNLHEBCJHB PPAOCCCONKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private KHIJDEHFOJA LKIBPKBGCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private CLGEKOKCCID PLMICPCEJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private FKBNPLCEDMG AOAALKNJFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private OGDPOBHAJLA ELMBDFGIJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private LMAKAKBFNCK DLBECODNACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private IFKLAILBPMB CDKPMDBACAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private IDisposable FIHGJIGJHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private PMOBBKDCDFN AFLKOENIBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly DPBIDJALKLM BPKNHLGDCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private GNICADJCPCM OIIEMLMLBOJ;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public TaskStatus AOPKDKEBEEO
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xA30D50", Offset = "0xA2FB50", VA = "0x180A30D50", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x1355A80", Offset = "0x1354880", VA = "0x181355A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private HNJJDFCNNLG NGAOLAIDCMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x85CF220", Offset = "0x85CE020", VA = "0x1885CF220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x85D00F0", Offset = "0x85CEEF0", VA = "0x1885D00F0", Slot = "6")]
	public void IANLJFINMMK(GMNLHEBCJHB PPAOCCCONKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x85CF630", Offset = "0x85CE430", VA = "0x1885CF630", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x85CFF20", Offset = "0x85CED20", VA = "0x1885CFF20", Slot = "5")]
	[AsyncStateMachine(typeof(KGLPJHMIKFK))]
	public Task GCGCDHDOKJJ(DAFHNINMJHP LLANMJGNIHG, ACOLPPBLNNC MBNGJDJKBDI, CancellationToken KKIGNHNCIEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x85CF4E0", Offset = "0x85CE2E0", VA = "0x1885CF4E0")]
	[AsyncStateMachine(typeof(JCPLIPNNHIM))]
	private Task DHPAMMFLIIM(DAFHNINMJHP LLANMJGNIHG, ACOLPPBLNNC MBNGJDJKBDI, CancellationToken KKIGNHNCIEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x85CEBD0", Offset = "0x85CD9D0", VA = "0x1885CEBD0")]
	private void BKDMCDBOLPJ(LMAKAKBFNCK DLBECODNACL, DAFHNINMJHP LLANMJGNIHG, Exception HELNJIPKBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x85D0420", Offset = "0x85CF220", VA = "0x1885D0420")]
	private static void ICJFAJNAGFD(FNEPCBJJIOG DFNEPLLDHBF, Exception HELNJIPKBCP, [Optional] List<int> GKKIOOLIAGI, int FANNKICBIPK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x85D0C70", Offset = "0x85CFA70", VA = "0x1885D0C70")]
	[AsyncStateMachine(typeof(AGPILJFNBLI))]
	private Task ICKNEILLLDD(HBCKFDINPOH<string>.DLKHFLDLCIN HMLAIBMJFEO, DAFHNINMJHP LLANMJGNIHG, ACOLPPBLNNC MBNGJDJKBDI, DKMOFLOMOKC DLJCIIHNEBO, CancellationToken KKIGNHNCIEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x85D1150", Offset = "0x85CFF50", VA = "0x1885D1150")]
	private void KGKPBIAOJFD([CallerMemberName] string OEKFAICNNNL = "<unknown>")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x85D1740", Offset = "0x85D0540", VA = "0x1885D1740")]
	[AsyncStateMachine(typeof(FAHGCEGOOPJ))]
	private Task MEBCOOBBLLE(HBCKFDINPOH<string>.DLKHFLDLCIN HMLAIBMJFEO, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x85CFBF0", Offset = "0x85CE9F0", VA = "0x1885CFBF0")]
	private void FPGEHLFHLAK(DAFHNINMJHP LLANMJGNIHG, CancellationToken KKIGNHNCIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x85D0E60", Offset = "0x85CFC60", VA = "0x1885D0E60")]
	private void JIFAOJOJACK(DAFHNINMJHP LLANMJGNIHG, TaskStatus LGDMNONEILJ, string NJJDPBHNDPA, DKMOFLOMOKC DLJCIIHNEBO, Exception BKLHGCIIDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x85D10D0", Offset = "0x85CFED0", VA = "0x1885D10D0")]
	private void KACLAHPLGOH(DAFHNINMJHP LLANMJGNIHG, DKMOFLOMOKC DLJCIIHNEBO, OperationCanceledException OGDFBJGKKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x85D1360", Offset = "0x85D0160", VA = "0x1885D1360")]
	private void KLOFOBFMGHJ(DAFHNINMJHP LLANMJGNIHG, DKMOFLOMOKC DLJCIIHNEBO, Exception HELNJIPKBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x85CE8C0", Offset = "0x85CD6C0", VA = "0x1885CE8C0")]
	private void BCGGFPGNDEJ(DAFHNINMJHP LLANMJGNIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x85CF1C0", Offset = "0x85CDFC0", VA = "0x1885CF1C0")]
	private static LHFNDJOEGHO CBCBMLBHBEO(DAFHNINMJHP LLANMJGNIHG)
	{
		return default(LHFNDJOEGHO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x85D1C70", Offset = "0x85D0A70", VA = "0x1885D1C70")]
	[AsyncStateMachine(typeof(PCFIIJHLNNC))]
	private Task OFCEJCCPPOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x85CF270", Offset = "0x85CE070", VA = "0x1885CF270")]
	[AsyncStateMachine(typeof(KKGOOFBGFDE))]
	private Task<Matchmaking.LHIBODNCGEG> CCJPMHIMLLD(DAFHNINMJHP LLANMJGNIHG, HBCKFDINPOH<string>.DLKHFLDLCIN HMLAIBMJFEO, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x85D1B60", Offset = "0x85D0960", VA = "0x1885D1B60")]
	private static PELAEIAHGNO ODHCCCMIGGF(Matchmaking.LHIBODNCGEG JFPKEBMGIGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x85D1870", Offset = "0x85D0670", VA = "0x1885D1870")]
	[AsyncStateMachine(typeof(BKCGCKDMIFO))]
	private Task MIEFKJDDGBJ(Matchmaking.LHIBODNCGEG JFPKEBMGIGA, DKMOFLOMOKC DLJCIIHNEBO, HBCKFDINPOH<string>.DLKHFLDLCIN HMLAIBMJFEO, CancellationToken JCNCFHBCGLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x85D19C0", Offset = "0x85D07C0", VA = "0x1885D19C0")]
	[AsyncStateMachine(typeof(EHGJGDGMCBC))]
	private Task NALBFACNDHP(DAFHNINMJHP LLANMJGNIHG, CancellationTokenSource LNGDDNFGHPA, Task EGEPOOIHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x85D13E0", Offset = "0x85D01E0", VA = "0x1885D13E0")]
	[AsyncStateMachine(typeof(LNFFAOGBGLK))]
	private Task KPMPNLIMHED(EJLGFFHHDJD HEDPJIHKDLI, NDJMODJJIEA EKBPHAMIEHA, DAFHNINMJHP OLECCPPNDFE, DKMOFLOMOKC LCLAGICKGFM, HBCKFDINPOH<string>.DLKHFLDLCIN HMLAIBMJFEO, CancellationToken HBICOGDJIGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x85D1550", Offset = "0x85D0350", VA = "0x1885D1550")]
	private DKMOFLOMOKC LFCJKLPBGHA(DKMOFLOMOKC LCLAGICKGFM, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x85CF830", Offset = "0x85CE630", VA = "0x1885CF830")]
	[AsyncStateMachine(typeof(FEMDIOJLEDE))]
	private Task ELCJNBCOCPE(HBCKFDINPOH<string>.DLKHFLDLCIN HMLAIBMJFEO, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x85CF970", Offset = "0x85CE770", VA = "0x1885CF970")]
	[AsyncStateMachine(typeof(NBOEIFAAJDM))]
	private Task FDFJFOEPACH(CancellationToken GHKBKDKNIOM, int HLNLCIPOMGH, OKJOLANABCP IOINOICOAPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x85CF040", Offset = "0x85CDE40", VA = "0x1885CF040")]
	private static void CAPGDLKKGPM(DAFHNINMJHP LLANMJGNIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x85D1D40", Offset = "0x85D0B40", VA = "0x1885D1D40")]
	private void PGECPKGGCPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x85D12D0", Offset = "0x85D00D0", VA = "0x1885D12D0")]
	private void KLAKDOKGLAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x85D0DD0", Offset = "0x85CFBD0", VA = "0x1885D0DD0")]
	private void ILBEEOAKKKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x85D0060", Offset = "0x85CEE60", VA = "0x1885D0060")]
	private void GMKLBDOJLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x85CFB00", Offset = "0x85CE900", VA = "0x1885CFB00")]
	private static void FMBKMGIKMGJ(DAFHNINMJHP LLANMJGNIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x85CF3D0", Offset = "0x85CE1D0", VA = "0x1885CF3D0")]
	private static CancellationTokenRegistration CNNBDGENGKJ(DAFHNINMJHP LLANMJGNIHG, CancellationToken JCNCFHBCGLI)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x85CEAD0", Offset = "0x85CD8D0", VA = "0x1885CEAD0")]
	private static void BDBECLBKDNK(DAFHNINMJHP LLANMJGNIHG, Exception HELNJIPKBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x85CF680", Offset = "0x85CE480", VA = "0x1885CF680")]
	private void EDMPMPCMLGP(DAFHNINMJHP LLANMJGNIHG, Task EGEPOOIHMAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x85D1B00", Offset = "0x85D0900", VA = "0x1885D1B00")]
	private static void NDLHJECGFPL(Func<string> IDNIHMABKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x85D21A0", Offset = "0x85D0FA0", VA = "0x1885D21A0")]
	public OGLJEDIINJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x85CFAA0", Offset = "0x85CE8A0", VA = "0x1885CFAA0")]
	[CompilerGenerated]
	internal static (int, int?) FFDHKKDJAKO(NBKPMBPLAEB DMDAMPNBMKA)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[RecRoom.NoEngine.Common.Preserve]
internal class LNLJCNFJGKM : LELEALOGJCL, EFFGJDOCBHN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private struct DGGCAGKIMKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public LNLJCNFJGKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public OKJOLANABCP localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x85DF800", Offset = "0x85DE600", VA = "0x1885DF800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x85DFCE0", Offset = "0x85DEAE0", VA = "0x1885DFCE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class LBEBPKCFBII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public LNLJCNFJGKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public OKJOLANABCP localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public LBEBPKCFBII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x85EB670", Offset = "0x85EA470", VA = "0x1885EB670")]
		internal List<Task> MJGJHLHKGMO(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct LPAPFAGDODI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public AOFGFCPMAHF taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public OKJOLANABCP localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private OGIJLBDGAHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x85ED0A0", Offset = "0x85EBEA0", VA = "0x1885ED0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x85ED440", Offset = "0x85EC240", VA = "0x1885ED440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct FLNIDLPAAJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public LNLJCNFJGKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x85E4430", Offset = "0x85E3230", VA = "0x1885E4430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x85E4710", Offset = "0x85E3510", VA = "0x1885E4710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly HashSet<AOFGFCPMAHF> LNKJGNOOEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private OOALADCCJDG EPHBDDJFCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private GMNLHEBCJHB PPAOCCCONKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private LBAKINFFCND DEGIKAFAMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private GADJIEADLFE HMINIDBJHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private IDisposable FIHGJIGJHAK;

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x85EC340", Offset = "0x85EB140", VA = "0x1885EC340", Slot = "5")]
	public void IANLJFINMMK(GMNLHEBCJHB PPAOCCCONKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x85EC280", Offset = "0x85EB080", VA = "0x1885EC280", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x85EC2E0", Offset = "0x85EB0E0", VA = "0x1885EC2E0", Slot = "4")]
	public bool GKCNOFHDLGB(AOFGFCPMAHF IMCBLKNGABF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x85EC1B0", Offset = "0x85EAFB0", VA = "0x1885EC1B0")]
	private void DBAPBKFFMKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x85EC770", Offset = "0x85EB570", VA = "0x1885EC770")]
	private void LLAOPPKAAGO(PCKGILPFDIA MLFFBNNKHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x85EC990", Offset = "0x85EB790", VA = "0x1885EC990")]
	[AsyncStateMachine(typeof(DGGCAGKIMKJ))]
	private Task MINAIKCKJLG(int HLNLCIPOMGH, OKJOLANABCP IOINOICOAPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x85EC0E0", Offset = "0x85EAEE0", VA = "0x1885EC0E0")]
	private Func<CancellationToken, List<Task>> CNMJDONALPE(int HLNLCIPOMGH, OKJOLANABCP IOINOICOAPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x85ECA80", Offset = "0x85EB880", VA = "0x1885ECA80")]
	private List<Task> PMHNLHCBEFK(int HLNLCIPOMGH, OKJOLANABCP IOINOICOAPE, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x85EBFC0", Offset = "0x85EADC0", VA = "0x1885EBFC0")]
	[AsyncStateMachine(typeof(LPAPFAGDODI))]
	private Task BGDEDMDGIHI(AOFGFCPMAHF ICKCCEIMLGH, CancellationToken JLFLGDNCANL, int HLNLCIPOMGH, OKJOLANABCP IOINOICOAPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x85EC6A0", Offset = "0x85EB4A0", VA = "0x1885EC6A0")]
	[AsyncStateMachine(typeof(FLNIDLPAAJK))]
	private Task KNBANPGIPKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x85EC620", Offset = "0x85EB420", VA = "0x1885EC620")]
	private void JMFEKBCNPCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x85ECF50", Offset = "0x85EBD50", VA = "0x1885ECF50")]
	public LNLJCNFJGKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[UnityEngine.Scripting.Preserve]
internal sealed class DDALCDABCCJ : ALIJJKDAOBM, EFFGJDOCBHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class BPNPJDPJJML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public BPNPJDPJJML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x85DA7B0", Offset = "0x85D95B0", VA = "0x1885DA7B0")]
		internal object KICGEBLFCKD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class NKHFOJDNADL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public NKHFOJDNADL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x85F1540", Offset = "0x85F0340", VA = "0x1885F1540")]
		internal object BKCINCEKNHN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class CGHCDFDHMFB
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public CGHCDFDHMFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class MEHBOIHINKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public MEHBOIHINKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x85EEDC0", Offset = "0x85EDBC0", VA = "0x1885EEDC0")]
		internal object OOPHBFJNBGG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class DHOGBLFGACA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public DHOGBLFGACA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x85DFD40", Offset = "0x85DEB40", VA = "0x1885DFD40")]
		internal object NJCIPGDPNOA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private readonly Dictionary<Guid, BFMDFMBDOON> NONODBCJHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private readonly TimeSpan IGPLPFKHAHB;

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "9")]
	public void IANLJFINMMK(GMNLHEBCJHB PPAOCCCONKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x85DEFC0", Offset = "0x85DDDC0", VA = "0x1885DEFC0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x85DEB50", Offset = "0x85DD950", VA = "0x1885DEB50", Slot = "4")]
	public GDBEHCBBGEI AIKICPLLADB(Guid LGNCELEMLNH)
	{
		return default(GDBEHCBBGEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x85DEFD0", Offset = "0x85DDDD0", VA = "0x1885DEFD0", Slot = "5")]
	public bool FKCGDELNEED(Guid LGNCELEMLNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x85DF410", Offset = "0x85DE210", VA = "0x1885DF410", Slot = "6")]
	public bool NFPEANLIMIK(Guid LGNCELEMLNH, Task DELLKDOKFMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x85DEDE0", Offset = "0x85DDBE0", VA = "0x1885DEDE0", Slot = "7")]
	public bool APFKNMOAGAK(Guid LGNCELEMLNH, NPEBMFOKKKC MJMCEHEEBGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x85DED70", Offset = "0x85DDB70", VA = "0x1885DED70", Slot = "8")]
	public Task<(NPEBMFOKKKC, Task)> ALGJLBGDBBM(Guid LGNCELEMLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x85DF1E0", Offset = "0x85DDFE0", VA = "0x1885DF1E0")]
	private void FMBJLOEGLBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x85DF740", Offset = "0x85DE540", VA = "0x1885DF740")]
	public DDALCDABCCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[RecRoom.NoEngine.Common.Preserve]
internal class FEKEINAAKPD : DGLFJMDONOJ, EFFGJDOCBHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	private class MMLELDHGCOM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private readonly DAFHNINMJHP DFFKLNAFJEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private readonly CancellationTokenSource FMNLCBJFAGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public readonly CancellationToken CCBEJILEEIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private bool FNPNAGMIJBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private bool OMPJCPABCDP;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x85EF7A0", Offset = "0x85EE5A0", VA = "0x1885EF7A0")]
		public MMLELDHGCOM(DAFHNINMJHP DFFKLNAFJEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x85EF650", Offset = "0x85EE450", VA = "0x1885EF650")]
		public void JMFEKBCNPCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x85EF620", Offset = "0x85EE420", VA = "0x1885EF620", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class FOEFNHMNMEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public OJIEIHJFFCG disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public FOEFNHMNMEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x85E4770", Offset = "0x85E3570", VA = "0x1885E4770")]
		internal object NNOBHOIFAFK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct PMDFOJAOFHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public OJIEIHJFFCG disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public FEKEINAAKPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private OGIJLBDGAHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x85F4ED0", Offset = "0x85F3CD0", VA = "0x1885F4ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x85F5320", Offset = "0x85F4120", VA = "0x1885F5320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class IFIIAMILEPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public FEKEINAAKPD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public IFIIAMILEPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x85E7960", Offset = "0x85E6760", VA = "0x1885E7960")]
		internal object HNKOKEBBPCD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class LONOOKPNGLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public DAFHNINMJHP newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public IFIIAMILEPN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public LONOOKPNGLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x85ECFE0", Offset = "0x85EBDE0", VA = "0x1885ECFE0")]
		internal object LAEBMFCKMLD((DAFHNINMJHP lastLocalPlayerRoomInstance, DAFHNINMJHP newRoomInstance, CLGEKOKCCID fallbacks) x)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct MBEFHHHDIFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public FEKEINAAKPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private OGIJLBDGAHB <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x85ED4A0", Offset = "0x85EC2A0", VA = "0x1885ED4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xA5B8B0", Offset = "0xA5A6B0", VA = "0x180A5B8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class MDCJGKPAFGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public DAFHNINMJHP newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public MDCJGKPAFGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x85EEC60", Offset = "0x85EDA60", VA = "0x1885EEC60")]
		internal object CBAECKKEIFH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x85EED00", Offset = "0x85EDB00", VA = "0x1885EED00")]
		internal void PJAJBJOOOAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x85EEC20", Offset = "0x85EDA20", VA = "0x1885EEC20")]
		internal object AIGMMGOFFPH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x85EED80", Offset = "0x85EDB80", VA = "0x1885EED80")]
		internal object PKMOCCGCKHI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct BGLFJKCHLGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public DAFHNINMJHP newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public FEKEINAAKPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public ACOLPPBLNNC customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private MDCJGKPAFGM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private OGIJLBDGAHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x85D90E0", Offset = "0x85D7EE0", VA = "0x1885D90E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x85DA0A0", Offset = "0x85D8EA0", VA = "0x1885DA0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private static readonly IGGALAPCOGK.OHLAEHEBMAL LKFFNMFLEIC;

	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static readonly HBKLMMOCKFE DAFLNJPFBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private OOALADCCJDG EPHBDDJFCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private GMNLHEBCJHB PPAOCCCONKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private CLGEKOKCCID PLMICPCEJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private KHIJDEHFOJA LKIBPKBGCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private FLLFABBPDNP EKMDFFAGMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private JBIDHHLDGEM FFKOMCHKHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private DAFHNINMJHP PLIBMFOLCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private MMLELDHGCOM KEMBHEMGCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private bool LJGFGGMIEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private Task NAANAINEHPH;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private HNJJDFCNNLG NGAOLAIDCMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x85E1870", Offset = "0x85E0670", VA = "0x1885E1870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool FGOIJMCANMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xC904C0", Offset = "0xC8F2C0", VA = "0x180C904C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x85E1A70", Offset = "0x85E0870", VA = "0x1885E1A70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x85E1C40", Offset = "0x85E0A40", VA = "0x1885E1C40", Slot = "4")]
	public void IANLJFINMMK(GMNLHEBCJHB PPAOCCCONKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x85E1A80", Offset = "0x85E0880", VA = "0x1885E1A80", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x85E22C0", Offset = "0x85E10C0", VA = "0x1885E22C0")]
	[AsyncStateMachine(typeof(PMDFOJAOFHL))]
	private Task MEFOPBMDHGN(OJIEIHJFFCG EMEHDOCGFNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x85E1FB0", Offset = "0x85E0DB0", VA = "0x1885E1FB0")]
	private void JONAGOBBMLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x85E23B0", Offset = "0x85E11B0", VA = "0x1885E23B0")]
	private void OEEDAEIJIJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x85E2140", Offset = "0x85E0F40", VA = "0x1885E2140")]
	private void LKILDINIOHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x85E19F0", Offset = "0x85E07F0", VA = "0x1885E19F0")]
	private bool DLALOIEKFFM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x85E1EE0", Offset = "0x85E0CE0", VA = "0x1885E1EE0")]
	[AsyncStateMachine(typeof(MBEFHHHDIFH))]
	private void JLNIODINFHO(int LCALHIDHIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x85E14D0", Offset = "0x85E02D0", VA = "0x1885E14D0")]
	private void BFCOKEOBAJP([Out] IDisposable AFGMIFGNDKH, [Out] IDisposable COFGHEEDAGC, [Out] IDisposable CKCMFEHMIFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x85E1770", Offset = "0x85E0570", VA = "0x1885E1770")]
	private bool BKGHBANNOJD(DAFHNINMJHP DFFKLNAFJEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x85E1BF0", Offset = "0x85E09F0", VA = "0x1885E1BF0")]
	private void GHFGNNHJINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x85E18C0", Offset = "0x85E06C0", VA = "0x1885E18C0")]
	[AsyncStateMachine(typeof(BGLFJKCHLGK))]
	private Task DHPAMMFLIIM(DAFHNINMJHP DFFKLNAFJEO, ACOLPPBLNNC MBNGJDJKBDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x85E2900", Offset = "0x85E1700", VA = "0x1885E2900")]
	public FEKEINAAKPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[UnityEngine.Scripting.Preserve]
internal sealed class PJBPJBADOIG : AICMHOPJHHA, EFFGJDOCBHN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct KMMCPNFPPHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public AsyncTaskMethodBuilder<OHMAAOBKPPJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public PJBPJBADOIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private TaskAwaiter<OHMAAOBKPPJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x85EAA30", Offset = "0x85E9830", VA = "0x1885EAA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x85EACC0", Offset = "0x85E9AC0", VA = "0x1885EACC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class LJFIMBODGCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public JCNIBNHHJJK message;

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public LJFIMBODGCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x85EB710", Offset = "0x85EA510", VA = "0x1885EB710")]
		internal object DIENCFJAGAL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class AFBNLPBOIAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public JCNIBNHHJJK messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public AFBNLPBOIAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x85D7AD0", Offset = "0x85D68D0", VA = "0x1885D7AD0")]
		internal object LNDFMGFFMDK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class BGDLMEJHFKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public JCNIBNHHJJK request;

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public BGDLMEJHFKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x85D9080", Offset = "0x85D7E80", VA = "0x1885D9080")]
		internal object CLCPOAJMIKK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct NODNJDAGKDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public JCNIBNHHJJK request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public PJBPJBADOIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private OGIJLBDGAHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private TaskAwaiter<OGJNGIMJFAN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x85F1EB0", Offset = "0x85F0CB0", VA = "0x1885F1EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x85F2780", Offset = "0x85F1580", VA = "0x1885F2780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class LDOCIHHJJOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public JCNIBNHHJJK operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public LDOCIHHJJOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x85EB6B0", Offset = "0x85EA4B0", VA = "0x1885EB6B0")]
		internal object HNHBHJJFIMG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct MMPPNLFLLPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public JCNIBNHHJJK operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public PJBPJBADOIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private OGIJLBDGAHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private DKMOFLOMOKC <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<JCNIBNHHJJK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x85EF850", Offset = "0x85EE650", VA = "0x1885EF850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x85F03D0", Offset = "0x85EF1D0", VA = "0x1885F03D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct KFKHJIBDDLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public AsyncTaskMethodBuilder<OGJNGIMJFAN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public PJBPJBADOIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public JCNIBNHHJJK request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private BDIMCIHFLEI.BEFOLIKLBJL <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private DKMOFLOMOKC <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private TaskAwaiter<JCNIBNHHJJK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x85E99D0", Offset = "0x85E87D0", VA = "0x1885E99D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x85E9F00", Offset = "0x85E8D00", VA = "0x1885E9F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class HIIOODKPJKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public OGJNGIMJFAN operation;

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public HIIOODKPJKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x85E6520", Offset = "0x85E5320", VA = "0x1885E6520")]
		internal object MGNEDJJJAFO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct ONNFAOJKAGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public OGJNGIMJFAN operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public PJBPJBADOIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private OGIJLBDGAHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private HBCKFDINPOH<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x85F27E0", Offset = "0x85F15E0", VA = "0x1885F27E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x85F2E20", Offset = "0x85F1C20", VA = "0x1885F2E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class BDGFOHBCOBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public JCNIBNHHJJK request;

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public BDGFOHBCOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x85D9020", Offset = "0x85D7E20", VA = "0x1885D9020")]
		internal object HAIGHLJBDPM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class FKNCMPODHDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public JCNIBNHHJJK request;

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public FKNCMPODHDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x85E41D0", Offset = "0x85E2FD0", VA = "0x1885E41D0")]
		internal object IIDNJPOJCDB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private GMNLHEBCJHB PPAOCCCONKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private FKBNPLCEDMG AOAALKNJFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private BJAOKJCOCOJ IJLBJECHKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private MINEBKJHCFN HDIPNEJKKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private PNEPNDOKHCF KLBDPNGJELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private TaskCompletionSource<OHMAAOBKPPJ> DJBBDDJNMMH;

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x85F4140", Offset = "0x85F2F40", VA = "0x1885F4140", Slot = "7")]
	public void IANLJFINMMK(GMNLHEBCJHB PPAOCCCONKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x85F48B0", Offset = "0x85F36B0", VA = "0x1885F48B0", Slot = "6")]
	[AsyncStateMachine(typeof(KMMCPNFPPHA))]
	public Task<OHMAAOBKPPJ> OKBMACHEFDD(CancellationToken NEMPCADIIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x85F3DB0", Offset = "0x85F2BB0", VA = "0x1885F3DB0", Slot = "4")]
	public void HDAMJJCIIDC(JCNIBNHHJJK NJJDPBHNDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x85F4230", Offset = "0x85F3030", VA = "0x1885F4230", Slot = "5")]
	public void JACLGHLGFJA(JCNIBNHHJJK CCKLDIKDPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x85F4590", Offset = "0x85F3390", VA = "0x1885F4590")]
	[AsyncStateMachine(typeof(NODNJDAGKDN))]
	private Task JGCNPNLKOFN(JCNIBNHHJJK OHDJLNAKLPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x85F49C0", Offset = "0x85F37C0", VA = "0x1885F49C0")]
	[AsyncStateMachine(typeof(MMPPNLFLLPO))]
	private Task OKLKEEKFHOI(JCNIBNHHJJK EIPCPCKANBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x85F3B40", Offset = "0x85F2940", VA = "0x1885F3B40")]
	[AsyncStateMachine(typeof(KFKHJIBDDLO))]
	private Task<OGJNGIMJFAN> EGLEGIDKEDL(JCNIBNHHJJK OHDJLNAKLPC, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x85F3AB0", Offset = "0x85F28B0", VA = "0x1885F3AB0")]
	private DKMOFLOMOKC AEBFLHCDODF(JCNIBNHHJJK FGGHFEPNPLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x85F3C90", Offset = "0x85F2A90", VA = "0x1885F3C90")]
	[AsyncStateMachine(typeof(ONNFAOJKAGP))]
	private Task EHLGIDLGFHB(OGJNGIMJFAN GGHOJGJBMPF, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x85F46A0", Offset = "0x85F34A0", VA = "0x1885F46A0")]
	private OGJNGIMJFAN NEBCKJMGDID(JCNIBNHHJJK OHDJLNAKLPC, DKMOFLOMOKC JCGPNELIJIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x3B1EBB0", Offset = "0x3B1D9B0", VA = "0x183B1EBB0")]
	private T EBAHDGFAAPP<T>(T OAIIHELJHLG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x85F4AD0", Offset = "0x85F38D0", VA = "0x1885F4AD0")]
	private OGJNGIMJFAN PDDLICDHLOP(JCNIBNHHJJK OHDJLNAKLPC, DKMOFLOMOKC JCGPNELIJIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public PJBPJBADOIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[UnityEngine.Scripting.Preserve]
internal sealed class CEDNCDKDDLI : BJAOKJCOCOJ, EFFGJDOCBHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private sealed class PMBBMBLEBEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public PMBBMBLEBEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x85F4E60", Offset = "0x85F3C60", VA = "0x1885F4E60")]
		internal object ODAECLIPBCH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class GKACHNDJCDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public GKACHNDJCDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x85E58B0", Offset = "0x85E46B0", VA = "0x1885E58B0")]
		internal object EFGPJFGFOAJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	private PNEPNDOKHCF KLBDPNGJELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	private NFMCGGLGEDK EDJECMIICJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	private AICMHOPJHHA FJHGCGAFCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	private ALIJJKDAOBM NONODBCJHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	private DPKHKMABECE GLLMJNOCNDG;

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x85DB6F0", Offset = "0x85DA4F0", VA = "0x1885DB6F0", Slot = "6")]
	public void IANLJFINMMK(GMNLHEBCJHB PPAOCCCONKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x85DABD0", Offset = "0x85D99D0", VA = "0x1885DABD0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x85DBCD0", Offset = "0x85DAAD0", VA = "0x1885DBCD0", Slot = "4")]
	public GDBEHCBBGEI JOAOONBKLAH(JCNIBNHHJJK OMBHAFGMJJN)
	{
		return default(GDBEHCBBGEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x85DC110", Offset = "0x85DAF10", VA = "0x1885DC110", Slot = "5")]
	public void KECPLENIJGB(Guid LGNCELEMLNH, Task DELLKDOKFMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x85DAAC0", Offset = "0x85D98C0", VA = "0x1885DAAC0")]
	private void CBIIGOGJLDG(NEJHGGPCOKC KPAGBEKAECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x85DAEC0", Offset = "0x85D9CC0", VA = "0x1885DAEC0")]
	private void HBMNCMDDEKI(APFLCBFHHBM FELHJOMEEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x85DB460", Offset = "0x85DA260", VA = "0x1885DB460")]
	private void HCDANPICAOK(APFLCBFHHBM FELHJOMEEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x85DAC80", Offset = "0x85D9A80", VA = "0x1885DAC80")]
	private void FPMKDLHLOLK(APFLCBFHHBM FELHJOMEEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x85DA810", Offset = "0x85D9610", VA = "0x1885DA810")]
	private NPEBMFOKKKC BBLLLMEBMBA(JCNIBNHHJJK FGGHFEPNPLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x85DC510", Offset = "0x85DB310", VA = "0x1885DC510")]
	private void ODCMBIDAEHP(JCNIBNHHJJK EIPCPCKANBE, NPEBMFOKKKC MJMCEHEEBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x85DC320", Offset = "0x85DB120", VA = "0x1885DC320")]
	private bool NDHAIKFDCHO(JCNIBNHHJJK EIPCPCKANBE, NPEBMFOKKKC MJMCEHEEBGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x85DBAB0", Offset = "0x85DA8B0", VA = "0x1885DBAB0")]
	private bool JLOFEGPEKOI(JCNIBNHHJJK BEPLELKOLJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x85DB860", Offset = "0x85DA660", VA = "0x1885DB860")]
	private bool JKLKGCMFAPG(byte GDAEOLOIDMC, ExitGames.Client.Photon.Hashtable FELHJOMEEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public CEDNCDKDDLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[UnityEngine.Scripting.Preserve]
internal sealed class CLNADHNJGKK : EGIPCKEJEEF, EFFGJDOCBHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private sealed class AKBAFFAJOKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public OHMAAOBKPPJ operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public CLNADHNJGKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public JCNIBNHHJJK roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public AKBAFFAJOKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x85D89D0", Offset = "0x85D77D0", VA = "0x1885D89D0")]
		internal object NDIMDBKJCNN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x85D8820", Offset = "0x85D7620", VA = "0x1885D8820")]
		internal object MMBEOIHDJAC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct IGAHDFLKFMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public AsyncTaskMethodBuilder<NPEBMFOKKKC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public CLNADHNJGKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public JCNIBNHHJJK roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private OGIJLBDGAHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private TaskAwaiter<NPEBMFOKKKC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x85E79D0", Offset = "0x85E67D0", VA = "0x1885E79D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x85E8070", Offset = "0x85E6E70", VA = "0x1885E8070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class EICGOCFGECO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public OHMAAOBKPPJ operationType;

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public EICGOCFGECO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x85E0990", Offset = "0x85DF790", VA = "0x1885E0990")]
		internal object KNLFOKKKHED()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class CKCFKPCIGIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public JCNIBNHHJJK request;

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public CKCFKPCIGIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x85DD4A0", Offset = "0x85DC2A0", VA = "0x1885DD4A0")]
		internal object HANLEEHGKJM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x85DD430", Offset = "0x85DC230", VA = "0x1885DD430")]
		internal object GFMIDNOEAMC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x85DD510", Offset = "0x85DC310", VA = "0x1885DD510")]
		internal object ODJKLNCIMFD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct LAICFGIBJHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public AsyncTaskMethodBuilder<NPEBMFOKKKC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public JCNIBNHHJJK request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public CLNADHNJGKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private CKCFKPCIGIG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private OGIJLBDGAHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private GDBEHCBBGEI <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private NPEBMFOKKKC <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private TaskAwaiter<(NPEBMFOKKKC validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x85EAD30", Offset = "0x85E9B30", VA = "0x1885EAD30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x85EB600", Offset = "0x85EA400", VA = "0x1885EB600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private PNEPNDOKHCF KLBDPNGJELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private NFMCGGLGEDK EDJECMIICJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private BJAOKJCOCOJ IJLBJECHKKL;

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x85DDA80", Offset = "0x85DC880", VA = "0x1885DDA80", Slot = "5")]
	public void IANLJFINMMK(GMNLHEBCJHB PPAOCCCONKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x85DD630", Offset = "0x85DC430", VA = "0x1885DD630", Slot = "4")]
	[AsyncStateMachine(typeof(IGAHDFLKFMP))]
	private Task<NPEBMFOKKKC> AEMCDCDKIOI(JCNIBNHHJJK FGGHFEPNPLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x85DD750", Offset = "0x85DC550", VA = "0x1885DD750")]
	private bool GJFOFLLNIOD(OHMAAOBKPPJ CHNEHFOJOHF, [Out] NPEBMFOKKKC BPINCJLADGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x85DD940", Offset = "0x85DC740", VA = "0x1885DD940")]
	[AsyncStateMachine(typeof(LAICFGIBJHP))]
	private Task<NPEBMFOKKKC> HEIMDOHICPF(JCNIBNHHJJK OHDJLNAKLPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public CLNADHNJGKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class MHJJNEIBEDM : DIPENBPMFLI, EFFGJDOCBHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private struct FGCECNPLBPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public CKNMKLKMAFP PALGLIOEANG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public long DJJFMAPBLGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public Guid? HHIOJNGIFDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public bool ONIABBKNOPI;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct PAHIMGFJHJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public AsyncTaskMethodBuilder<EJLGFFHHDJD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public DAFHNINMJHP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public MHJJNEIBEDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private TaskAwaiter<IEHEOOILKKD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private TaskAwaiter<EJLGFFHHDJD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x85F2E80", Offset = "0x85F1C80", VA = "0x1885F2E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x85F3450", Offset = "0x85F2250", VA = "0x1885F3450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class CLAAOOELFLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public CLAAOOELFLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x85DD580", Offset = "0x85DC380", VA = "0x1885DD580")]
		internal object GEBGFMEHPAG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct HLAHJMNGDIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public AsyncTaskMethodBuilder<IEHEOOILKKD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public MHJJNEIBEDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public DAFHNINMJHP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private CLAAOOELFLF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private TaskAwaiter<IEHEOOILKKD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x85E6B70", Offset = "0x85E5970", VA = "0x1885E6B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x85E7160", Offset = "0x85E5F60", VA = "0x1885E7160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct AKDKDNCFJNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public AsyncTaskMethodBuilder<EJLGFFHHDJD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public MHJJNEIBEDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public DAFHNINMJHP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public IEHEOOILKKD roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private TaskAwaiter<FGCECNPLBPO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x85D8A40", Offset = "0x85D7840", VA = "0x1885D8A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x85D8FB0", Offset = "0x85D7DB0", VA = "0x1885D8FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class JGAJLIFNIIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public IEHEOOILKKD roomDetailsDto;

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public JGAJLIFNIIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xE8E460", Offset = "0xE8D260", VA = "0x180E8E460")]
		internal bool MDANONPPJLP(HLKGJIPFKJP sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x85E96B0", Offset = "0x85E84B0", VA = "0x1885E96B0")]
		internal object GHEJMAFOKNG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x85E9770", Offset = "0x85E8570", VA = "0x1885E9770")]
		internal object IMOEKDGBENA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x85E9800", Offset = "0x85E8600", VA = "0x1885E9800")]
		internal object LKJFOFKNEEM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class MOELDHPPIII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public bool loadUsedCompatibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public JGAJLIFNIIA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public MOELDHPPIII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x85F0430", Offset = "0x85EF230", VA = "0x1885F0430")]
		internal object DODJBHCLKPI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private struct COCOFFGLMOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public AsyncTaskMethodBuilder<FGCECNPLBPO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public IEHEOOILKKD roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public MHJJNEIBEDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public DAFHNINMJHP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private MOELDHPPIII <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private TaskAwaiter<FGCECNPLBPO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private TaskAwaiter<JLKEEJPFIPN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x85DDB30", Offset = "0x85DC930", VA = "0x1885DDB30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x85DEAE0", Offset = "0x85DD8E0", VA = "0x1885DEAE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class CGNOODKJKEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public CGNOODKJKEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x85DC720", Offset = "0x85DB520", VA = "0x1885DC720")]
		internal object HCAALICBGDJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private struct IKHDFFOHAMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public AsyncTaskMethodBuilder<FGCECNPLBPO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public HLKGJIPFKJP subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public MHJJNEIBEDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public DAFHNINMJHP dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private CGNOODKJKEL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private TaskAwaiter<ENAHMCDKIIN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x85E85B0", Offset = "0x85E73B0", VA = "0x1885E85B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x85E8C80", Offset = "0x85E7A80", VA = "0x1885E8C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	private KHIJDEHFOJA LKIBPKBGCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	private FLLFABBPDNP EKMDFFAGMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	private FOEDDKHMNOB AILCICFGDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private ALACNOHNDBC JNANGBADDPA;

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x85EEF90", Offset = "0x85EDD90", VA = "0x1885EEF90", Slot = "5")]
	public void IANLJFINMMK(GMNLHEBCJHB PPAOCCCONKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x85EF350", Offset = "0x85EE150", VA = "0x1885EF350", Slot = "4")]
	[AsyncStateMachine(typeof(PAHIMGFJHJO))]
	public Task<EJLGFFHHDJD> JAHJKEKANJD(HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, DAFHNINMJHP LLANMJGNIHG, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x85EF080", Offset = "0x85EDE80", VA = "0x1885EF080")]
	[AsyncStateMachine(typeof(HLAHJMNGDIK))]
	private Task<IEHEOOILKKD> IFAJPIOBGPB(DAFHNINMJHP LLANMJGNIHG, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x85EEE20", Offset = "0x85EDC20", VA = "0x1885EEE20")]
	[AsyncStateMachine(typeof(AKDKDNCFJNG))]
	private Task<EJLGFFHHDJD> GJNIPHLEMCH(DAFHNINMJHP LLANMJGNIHG, IEHEOOILKKD NMFHFJBGFII, long DPMNLDKPNGD, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x85EF4B0", Offset = "0x85EE2B0", VA = "0x1885EF4B0")]
	[AsyncStateMachine(typeof(COCOFFGLMOM))]
	private Task<FGCECNPLBPO> OJBMGAAKELG(DAFHNINMJHP LLANMJGNIHG, IEHEOOILKKD NMFHFJBGFII, long DPMNLDKPNGD, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x85EF1E0", Offset = "0x85EDFE0", VA = "0x1885EF1E0")]
	[AsyncStateMachine(typeof(IKHDFFOHAMO))]
	private Task<FGCECNPLBPO> IGCHKBPIHFI(DAFHNINMJHP DCGPFEEBIFC, HLKGJIPFKJP GNAKCJKHALF, long DPMNLDKPNGD, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public MHJJNEIBEDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[UnityEngine.Scripting.Preserve]
internal sealed class NNGFGBHILMH : MINEBKJHCFN, EFFGJDOCBHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private sealed class KEBJKNFEANC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public JCNIBNHHJJK request;

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public KEBJKNFEANC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x85E9910", Offset = "0x85E8710", VA = "0x1885E9910")]
		internal object BOACAEJEEKA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private struct AGCDBKEEFHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public AsyncTaskMethodBuilder<JCNIBNHHJJK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public JCNIBNHHJJK request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public NNGFGBHILMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public DKMOFLOMOKC pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private OGIJLBDGAHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private TaskAwaiter<JCNIBNHHJJK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x85D7B30", Offset = "0x85D6930", VA = "0x1885D7B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x85D8140", Offset = "0x85D6F40", VA = "0x1885D8140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private struct AHCEFJKLOHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public AsyncTaskMethodBuilder<JCNIBNHHJJK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public NNGFGBHILMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public DKMOFLOMOKC pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private OGIJLBDGAHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private TaskAwaiter<AIHNOLEIFPP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x85D81B0", Offset = "0x85D6FB0", VA = "0x1885D81B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x85D87B0", Offset = "0x85D75B0", VA = "0x1885D87B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class KFFNCIHNHCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public JCNIBNHHJJK request;

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public KFFNCIHNHCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x85E9970", Offset = "0x85E8770", VA = "0x1885E9970")]
		internal object JAPBJFPACGA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private struct CIDJEEGFJLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public AsyncTaskMethodBuilder<JCNIBNHHJJK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public JCNIBNHHJJK request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public NNGFGBHILMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public DKMOFLOMOKC pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private OGIJLBDGAHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private IICKNIEGMJG <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private KMIKJCDGICP <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private TaskAwaiter<AIHNOLEIFPP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x85DC7D0", Offset = "0x85DB5D0", VA = "0x1885DC7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x85DD3C0", Offset = "0x85DC1C0", VA = "0x1885DD3C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private PNEPNDOKHCF KLBDPNGJELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	private AKCEBBAKJMD HOGHALEECMC;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private OJHCGNKMJME NMMHPMMBLLA
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x85F1A00", Offset = "0x85F0800", VA = "0x1885F1A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x85F1B70", Offset = "0x85F0970", VA = "0x1885F1B70", Slot = "8")]
	public void IANLJFINMMK(GMNLHEBCJHB PPAOCCCONKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x85F18A0", Offset = "0x85F06A0", VA = "0x1885F18A0", Slot = "4")]
	[AsyncStateMachine(typeof(AGCDBKEEFHJ))]
	public Task<JCNIBNHHJJK> BNAADEKEIIL(JCNIBNHHJJK OHDJLNAKLPC, DKMOFLOMOKC JCGPNELIJIN, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x85F1C00", Offset = "0x85F0A00", VA = "0x1885F1C00", Slot = "5")]
	[AsyncStateMachine(typeof(AHCEFJKLOHG))]
	public Task<JCNIBNHHJJK> JBNFPNNNOPA(CancellationToken GHKBKDKNIOM, DKMOFLOMOKC JCGPNELIJIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x85F1AC0", Offset = "0x85F08C0", VA = "0x1885F1AC0", Slot = "6")]
	public HPFPDDDCBJJ FMKJFGHCMCO(OGJNGIMJFAN IHNPOBAJILE, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x85F1770", Offset = "0x85F0570", VA = "0x1885F1770", Slot = "7")]
	public HPFPDDDCBJJ AMLMCHJDEAO(OGJNGIMJFAN IHNPOBAJILE, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x85F1D50", Offset = "0x85F0B50", VA = "0x1885F1D50")]
	[AsyncStateMachine(typeof(CIDJEEGFJLO))]
	private Task<JCNIBNHHJJK> KOEDLNCHPIE(JCNIBNHHJJK OHDJLNAKLPC, DKMOFLOMOKC JCGPNELIJIN, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x3928360", Offset = "0x3927160", VA = "0x183928360")]
	private static byte[] MMJIBMCIMPN(JCNIBNHHJJK NJJDPBHNDPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public NNGFGBHILMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[UnityEngine.Scripting.Preserve]
internal sealed class HKEBGHNEHPP : NFMCGGLGEDK, EFFGJDOCBHN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private BPJFPFLMOMA LKGMJJACBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private PNEPNDOKHCF KLBDPNGJELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private FKBNPLCEDMG AOAALKNJFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private LAKFJEOHOAC IIHOKJDMJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private KHIJDEHFOJA LKIBPKBGCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private JBIDHHLDGEM FFKOMCHKHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private LELEALOGJCL HNMIHLHLGBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private FLLFABBPDNP EKMDFFAGMPN;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private HNJJDFCNNLG NGAOLAIDCMC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x85E65A0", Offset = "0x85E53A0", VA = "0x1885E65A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private static NPEBMFOKKKC LGKACBKCCFB
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x85E65F0", Offset = "0x85E53F0", VA = "0x1885E65F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x85E6770", Offset = "0x85E5570", VA = "0x1885E6770", Slot = "6")]
	public void IANLJFINMMK(GMNLHEBCJHB PPAOCCCONKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x85E6600", Offset = "0x85E5400", VA = "0x1885E6600", Slot = "4")]
	public NPEBMFOKKKC FIBLCMAMJOF(AHNIMKBJLEJ OIMMHJNPNEH, OHMAAOBKPPJ ECJGLDHJAKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x85E68E0", Offset = "0x85E56E0", VA = "0x1885E68E0", Slot = "5")]
	public NPEBMFOKKKC JBPMJHGAPEO(AHNIMKBJLEJ COJGENHFAGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x85E6B60", Offset = "0x85E5960", VA = "0x1885E6B60")]
	private static NPEBMFOKKKC MJCLBAMIAFE(KJPEKFGEGLI KLOPBEMIGAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public HKEBGHNEHPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class GOEJBNENHBN : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x85E64E0", Offset = "0x85E52E0", VA = "0x1885E64E0")]
	public GOEJBNENHBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x77ABA60", Offset = "0x77AA860", VA = "0x1877ABA60")]
	public GOEJBNENHBN(string NJJDPBHNDPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[UnityEngine.Scripting.Preserve]
internal sealed class GILEHBFEBME : MMFENADFOFA, EFFGJDOCBHN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private struct GLKGEHMPMPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public AsyncTaskMethodBuilder<NPEBMFOKKKC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public GILEHBFEBME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public ONKMAFKLDAF autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private HBCKFDINPOH<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private EJLDOPHFDFF <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private TaskAwaiter<NPEBMFOKKKC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x85E5920", Offset = "0x85E4720", VA = "0x1885E5920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x85E6470", Offset = "0x85E5270", VA = "0x1885E6470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct ILJANPDABIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public GILEHBFEBME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x85E8CF0", Offset = "0x85E7AF0", VA = "0x1885E8CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x85E9450", Offset = "0x85E8250", VA = "0x1885E9450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct KKPMEINDHGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public GILEHBFEBME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x85EA4C0", Offset = "0x85E92C0", VA = "0x1885EA4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x85EA9D0", Offset = "0x85E97D0", VA = "0x1885EA9D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct MPFMAMOPIMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public GILEHBFEBME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x85F0530", Offset = "0x85EF330", VA = "0x1885F0530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x85F0C80", Offset = "0x85EFA80", VA = "0x1885F0C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct FKNLFJHEIAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public GILEHBFEBME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x85E4230", Offset = "0x85E3030", VA = "0x1885E4230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x85E43D0", Offset = "0x85E31D0", VA = "0x1885E43D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct IEDINHNNONJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public GILEHBFEBME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x85E71D0", Offset = "0x85E5FD0", VA = "0x1885E71D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x85E7900", Offset = "0x85E6700", VA = "0x1885E7900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct IIEGOFAIAME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public GILEHBFEBME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x85E80E0", Offset = "0x85E6EE0", VA = "0x1885E80E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x85E8550", Offset = "0x85E7350", VA = "0x1885E8550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct GBGEAAADMKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public GILEHBFEBME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public ILAAIKBOLJH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private HBCKFDINPOH<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x85FC4C0", Offset = "0x85FB2C0", VA = "0x1885FC4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x85FCA60", Offset = "0x85FB860", VA = "0x1885FCA60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private PNEPNDOKHCF KLBDPNGJELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private GMNLHEBCJHB PPAOCCCONKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private KHIJDEHFOJA LKIBPKBGCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private MINEBKJHCFN HDIPNEJKKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	private FKBNPLCEDMG AOAALKNJFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400033E")]
	private LELEALOGJCL HNMIHLHLGBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	private CancellationTokenSource LAFDCEHCPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	private Task NOKIGPIJJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	private TaskCompletionSource<int> DIJHNIAPCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	private int KGEEEDMJIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	private int OOHNPMEAMBD;

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x85E4BA0", Offset = "0x85E39A0", VA = "0x1885E4BA0", Slot = "6")]
	public void IANLJFINMMK(GMNLHEBCJHB PPAOCCCONKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x1321F20", Offset = "0x1320D20", VA = "0x181321F20", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x85E4D50", Offset = "0x85E3B50", VA = "0x1885E4D50")]
	private void IPJCHKMAFLM(float DPIPEMJEKEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x85E5400", Offset = "0x85E4200", VA = "0x1885E5400", Slot = "4")]
	[AsyncStateMachine(typeof(GLKGEHMPMPP))]
	public Task<NPEBMFOKKKC> PHIPKBNLPLD(ONKMAFKLDAF GCOKBAEPGNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x85E49A0", Offset = "0x85E37A0", VA = "0x1885E49A0", Slot = "5")]
	[AsyncStateMachine(typeof(ILJANPDABIO))]
	public Task DBFBBJHDIHJ([Optional] CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x1321F20", Offset = "0x1320D20", VA = "0x181321F20")]
	public void MKOBHFDJNHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x85E5290", Offset = "0x85E4090", VA = "0x1885E5290")]
	private EJLDOPHFDFF PHHINPCICDE(ONKMAFKLDAF GCOKBAEPGNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x85E4E30", Offset = "0x85E3C30", VA = "0x1885E4E30")]
	[AsyncStateMachine(typeof(KKPMEINDHGF))]
	private Task KLIJHLAFIGG(CancellationToken KKIGNHNCIEJ, int HLNLCIPOMGH, OKJOLANABCP IOINOICOAPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x85E48A0", Offset = "0x85E36A0", VA = "0x1885E48A0")]
	[AsyncStateMachine(typeof(MPFMAMOPIMN))]
	private Task AFFJDJFIGNK(CancellationToken KKIGNHNCIEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x85E4F20", Offset = "0x85E3D20", VA = "0x1885E4F20")]
	[AsyncStateMachine(typeof(FKNLFJHEIAB))]
	private Task MBDABICOAHM([Optional] CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x85E51A0", Offset = "0x85E3FA0", VA = "0x1885E51A0")]
	[AsyncStateMachine(typeof(IEDINHNNONJ))]
	private Task PCCBFMNMKFL(CancellationToken KKIGNHNCIEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x85E5530", Offset = "0x85E4330", VA = "0x1885E5530")]
	[AsyncStateMachine(typeof(IIEGOFAIAME))]
	private Task PJBNKIKMNHM(CancellationToken OJPHHHKGNKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x85E5010", Offset = "0x85E3E10", VA = "0x1885E5010")]
	private Task MLOPBHJGICB(ILAAIKBOLJH DGLHGHKAGGH, CancellationToken KKIGNHNCIEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x85E4A90", Offset = "0x85E3890", VA = "0x1885E4A90")]
	[AsyncStateMachine(typeof(GBGEAAADMKO))]
	private Task IAFPIONBADD(ILAAIKBOLJH DGLHGHKAGGH, CancellationToken KKIGNHNCIEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x85E5630", Offset = "0x85E4430", VA = "0x1885E5630")]
	private bool PKFLMMMNOBG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public GILEHBFEBME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[UnityEngine.Scripting.Preserve]
internal class FMAJFFNGNML : LAKFJEOHOAC, EFFGJDOCBHN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct MJMOFHJKJBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public FMAJFFNGNML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private HBCKFDINPOH<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x860A8D0", Offset = "0x86096D0", VA = "0x18860A8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x860AE90", Offset = "0x8609C90", VA = "0x18860AE90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400037D")]
	private PGBAMBHBOMF HANFOIBOOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	private GMNLHEBCJHB PPAOCCCONKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	private NFMCGGLGEDK EDJECMIICJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	private MINEBKJHCFN HDIPNEJKKKO;

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x85FA870", Offset = "0x85F9670", VA = "0x1885FA870", Slot = "6")]
	public void IANLJFINMMK(GMNLHEBCJHB PPAOCCCONKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x85FA820", Offset = "0x85F9620", VA = "0x1885FA820", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x85FA720", Offset = "0x85F9520", VA = "0x1885FA720", Slot = "5")]
	[AsyncStateMachine(typeof(MJMOFHJKJBK))]
	public Task APNNEMJDJDP(string NOBPJADLJBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x85FAB50", Offset = "0x85F9950", VA = "0x1885FAB50", Slot = "4")]
	public NPEBMFOKKKC PKFLMMMNOBG(AHNIMKBJLEJ OIMMHJNPNEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x85FA5E0", Offset = "0x85F93E0", VA = "0x1885FA5E0")]
	private GILAOPNCJEC AIJOAFOOCCO(string NOBPJADLJBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public FMAJFFNGNML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public static class LHPNMOKFNNE
{
	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x86093A0", Offset = "0x86081A0", VA = "0x1886093A0")]
	public static void NBFALIKABCA(NAELDDAANND AHGNCOFKLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x8608D30", Offset = "0x8607B30", VA = "0x188608D30")]
	internal static void CAMIMFHDELF(NAELDDAANND AHGNCOFKLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x8608E90", Offset = "0x8607C90", VA = "0x188608E90")]
	internal static void KADJLHAIJDG(NAELDDAANND AHGNCOFKLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x8608F70", Offset = "0x8607D70", VA = "0x188608F70")]
	internal static void MACEOIFKMPK(NAELDDAANND AHGNCOFKLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x39F1040", Offset = "0x39EFE40", VA = "0x1839F1040")]
	private static void ALFKEBENIIC<Interface, Impl, Interface>(NAELDDAANND AHGNCOFKLHK) where Impl : Interface
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal class BCJBLBKBKAC : OBCLCBIDEGN<JCNIBNHHJJK>
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private sealed class AFFEPFPENME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public JCNIBNHHJJK message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public AFFEPFPENME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x85F6DB0", Offset = "0x85F5BB0", VA = "0x1885F6DB0")]
		internal object POMOJLOJKNH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly BCJBLBKBKAC ICOFMPPJNFC;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x85F7970", Offset = "0x85F6770", VA = "0x1885F7970")]
	public ExitGames.Client.Photon.Hashtable KIDMEGDOMCG(JCNIBNHHJJK NJJDPBHNDPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x85F7D40", Offset = "0x85F6B40", VA = "0x1885F7D40", Slot = "5")]
	protected override void PPKJMNPMKII(JCNIBNHHJJK NJJDPBHNDPA, IDictionary<object, object> FFEMKICJPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x85F7A00", Offset = "0x85F6800", VA = "0x1885F7A00", Slot = "6")]
	public override JCNIBNHHJJK LGDBIGPAFJK(IDictionary<object, object> FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x85F7C30", Offset = "0x85F6A30", VA = "0x1885F7C30")]
	private static void NDLHJECGFPL(string AFMCKLODPDE, JCNIBNHHJJK NJJDPBHNDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x85F7F10", Offset = "0x85F6D10", VA = "0x1885F7F10")]
	public BCJBLBKBKAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x85F76D0", Offset = "0x85F64D0", VA = "0x1885F76D0")]
	[CompilerGenerated]
	internal static string KDDNGLBJNKO(EJLGFFHHDJD DKEBGKJJPPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public static class IIEKPNFFHPH
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public static NPEBMFOKKKC LGKACBKCCFB
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x8604720", Offset = "0x8603520", VA = "0x188604720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x8604780", Offset = "0x8603580", VA = "0x188604780")]
	public static bool FGIEENECAPD(this NPEBMFOKKKC MJMCEHEEBGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x8604C00", Offset = "0x8603A00", VA = "0x188604C00")]
	public static NPEBMFOKKKC MJCLBAMIAFE(KJPEKFGEGLI COPGBILICEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x86047A0", Offset = "0x86035A0", VA = "0x1886047A0")]
	public static NPEBMFOKKKC HEPECPNEELI(IEnumerable<NPEBMFOKKKC> OGJOGEJNOOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x86049A0", Offset = "0x86037A0", VA = "0x1886049A0")]
	public static string KHGELNIFKED(this NPEBMFOKKKC BPINCJLADGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public abstract class FGOKPJMHAAM : EMDPBBBEDAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public delegate NPEBMFOKKKC MPCEKBCBMNI([NotNull] AHNIMKBJLEJ KLAPLKAGGKI);

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private sealed class FGDDICAPLAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public AHNIMKBJLEJ photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public FGDDICAPLAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x15C6FA0", Offset = "0x15C5DA0", VA = "0x1815C6FA0")]
		internal NPEBMFOKKKC KCMBOLIOPBD(MPCEKBCBMNI v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400038D")]
	private bool EKADHKFOHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400038E")]
	protected readonly HashSet<MPCEKBCBMNI> LNCCIBJNNMA;

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x85FA140", Offset = "0x85F8F40", VA = "0x1885FA140", Slot = "4")]
	public void BGOBEGEJACB(MPCEKBCBMNI LOCPONBEOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x85FA1A0", Offset = "0x85F8FA0", VA = "0x1885FA1A0", Slot = "5")]
	public void DNLDCMFDDBP(MPCEKBCBMNI LOCPONBEOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x85FA200", Offset = "0x85F9000", VA = "0x1885FA200", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x85FA250", Offset = "0x85F9050", VA = "0x1885FA250")]
	protected NPEBMFOKKKC MCPLKFHNBIJ(AHNIMKBJLEJ COJGENHFAGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x85FA4F0", Offset = "0x85F92F0", VA = "0x1885FA4F0")]
	protected FGOKPJMHAAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public class DDLBBKPDIOM : FGOKPJMHAAM, BPJFPFLMOMA, EMDPBBBEDAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private sealed class LCDOGAPDEEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public NPEBMFOKKKC result;

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public LCDOGAPDEEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x8606EC0", Offset = "0x8605CC0", VA = "0x188606EC0")]
		internal object OGEMEBOJDPK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x85F8DE0", Offset = "0x85F7BE0", VA = "0x1885F8DE0")]
	[UnityEngine.Scripting.Preserve]
	public DDLBBKPDIOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x85F8CD0", Offset = "0x85F7AD0", VA = "0x1885F8CD0", Slot = "8")]
	public NPEBMFOKKKC OOHGMCEDJCA(AHNIMKBJLEJ COJGENHFAGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public class ODICBADAPPJ : FGOKPJMHAAM, PGBAMBHBOMF, EMDPBBBEDAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private sealed class FLLJABFPPHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public NPEBMFOKKKC result;

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public FLLJABFPPHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x85FA580", Offset = "0x85F9380", VA = "0x1885FA580")]
		internal object DEEDBHGADIA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x85F8DE0", Offset = "0x85F7BE0", VA = "0x1885F8DE0")]
	[UnityEngine.Scripting.Preserve]
	public ODICBADAPPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x860E5A0", Offset = "0x860D3A0", VA = "0x18860E5A0", Slot = "8")]
	public NPEBMFOKKKC PKFLMMMNOBG(AHNIMKBJLEJ ALDGPAKLOOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal static class JCBJLNENJKH
{
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class IONAKJKIHIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public HBCKFDINPOH<string> timer;

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public IONAKJKIHIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x8604CD0", Offset = "0x8603AD0", VA = "0x188604CD0")]
		internal object GCANIJCMBCO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x8605920", Offset = "0x8604720", VA = "0x188605920")]
	public static HBCKFDINPOH<string> LAKIDHBDKNE(IEBEPMGFCGH NHLEILEPJMB, [Optional] string PLLKLGIGJPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x8605A00", Offset = "0x8604800", VA = "0x188605A00")]
	public static void OIALCAKEHDJ(HBCKFDINPOH<string> HMLAIBMJFEO, IEBEPMGFCGH NHLEILEPJMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x8605860", Offset = "0x8604660", VA = "0x188605860")]
	public static string JOJLOHPBGOK(JCNIBNHHJJK FGGHFEPNPLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
internal static class FFGAHKCNJMF
{
	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x85FA130", Offset = "0x85F8F30", VA = "0x1885FA130")]
	public static void NANEENIABON(this PNEPNDOKHCF KLBDPNGJELI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x85FA120", Offset = "0x85F8F20", VA = "0x1885FA120")]
	public static void JDABEBJNEMA(this PNEPNDOKHCF KLBDPNGJELI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x85FA000", Offset = "0x85F8E00", VA = "0x1885FA000")]
	private static void AOJODNJKNFE(this PNEPNDOKHCF KLBDPNGJELI, bool BILOBLEICIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class ELOGIEIIGLE : KEMOFGHCGFH, JKACFOLHIMF, KJFHLELIGPN, HEPJOOJLFOI
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[DefaultMember("Item")]
	private class CLINOBLOEGO : NEJHGGPCOKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private readonly byte OICKECDHHGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private readonly int HLDOEFCHGDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private readonly object CANLMPKAGGC;

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public byte JAOBBLBJLOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0xCA8320", Offset = "0xCA7120", VA = "0x180CA8320", Slot = "4")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public int EALAAGBDPPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0xB97DF0", Offset = "0xB96BF0", VA = "0x180B97DF0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public object GNFNGOLMLKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public object ANMDDLMJFBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x85F8090", Offset = "0x85F6E90", VA = "0x1885F8090", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x77B3540", Offset = "0x77B2340", VA = "0x1877B3540")]
		public CLINOBLOEGO(byte OICKECDHHGJ, int HLDOEFCHGDK, object CANLMPKAGGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x85F8040", Offset = "0x85F6E40", VA = "0x1885F8040", Slot = "8")]
		public bool GNFCCDJDLII(byte MAKJJJECHHB, [Out] object OAIIHELJHLG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000396")]
	private readonly JKACFOLHIMF PCALGMKBFCA;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public AHNIMKBJLEJ GGGCAKCKKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x85F9650", Offset = "0x85F8450", VA = "0x1885F9650", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int JBMBFAOOFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x85F95B0", Offset = "0x85F83B0", VA = "0x1885F95B0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public int CAPPFIMBOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x85F96F0", Offset = "0x85F84F0", VA = "0x1885F96F0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public AHNIMKBJLEJ HBMKGECCKIO
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x85F9600", Offset = "0x85F8400", VA = "0x1885F9600", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool MPFMOGHFLLC
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public int NHIHMODMOJG
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0xBFF4C0", Offset = "0xBFE2C0", VA = "0x180BFF4C0", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public string NBAJJIGOEBK
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x85F9F40", Offset = "0x85F8D40", VA = "0x1885F9F40", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Func<string, string> DLDABIOBFEM
	{
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x85F9C00", Offset = "0x85F8A00", VA = "0x1885F9C00", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event Action<string, long> OFAIBAIPBLF
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event Action<NEJHGGPCOKC> ICDHGGPFBAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x85F9740", Offset = "0x85F8540", VA = "0x1885F9740", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x85F9D70", Offset = "0x85F8B70", VA = "0x1885F9D70", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> OCKIAFFECPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "26")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "27")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<AHNIMKBJLEJ> FDJAPPFCHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action HMMDGDDCOKC
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x85F99A0", Offset = "0x85F87A0", VA = "0x1885F99A0", Slot = "35")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x85F9900", Offset = "0x85F8700", VA = "0x1885F9900", Slot = "36")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x85F9FA0", Offset = "0x85F8DA0", VA = "0x1885F9FA0", Slot = "19")]
	public void PPFFPDPKLCJ(string IHGFMOMOADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0xD43300", Offset = "0xD42100", VA = "0x180D43300")]
	public ELOGIEIIGLE(JKACFOLHIMF PCALGMKBFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x85F97F0", Offset = "0x85F85F0", VA = "0x1885F97F0", Slot = "8")]
	public bool DPJAECGGDEA(byte GDAEOLOIDMC, object NHNKMCAHFDJ, EEKDOOHAAOB PCLCKPBICJD, LADNPKPOAGM JEIGPENCGFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x85F9CD0", Offset = "0x85F8AD0", VA = "0x1885F9CD0", Slot = "20")]
	public AHNIMKBJLEJ KLLFNCOLKDI(int HCHHJGLKNCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x85F9A40", Offset = "0x85F8840", VA = "0x1885F9A40", Slot = "21")]
	public AHNIMKBJLEJ IEAGFINMIMG(int OEBMJHLGKIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x85F9B20", Offset = "0x85F8920", VA = "0x1885F9B20", Slot = "22")]
	public AHNIMKBJLEJ IHKKGMBEGNK(int HCHHJGLKNCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x85F9E60", Offset = "0x85F8C60", VA = "0x1885F9E60", Slot = "23")]
	public IReadOnlyList<AHNIMKBJLEJ> PCHPGEKJNEH(bool LGNLAJIJLPC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x85F9E20", Offset = "0x85F8C20", VA = "0x1885F9E20", Slot = "24")]
	public IReadOnlyList<AHNIMKBJLEJ> MKCKCLGBCMD(bool LGNLAJIJLPC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "25")]
	public bool HHJKLAJDHBC(AHNIMKBJLEJ ACKNEPODFAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "28")]
	public void EIMFOLHOLBC(object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "29")]
	public void ANIPDKFLAMB(object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "30")]
	public void COIJBGBKDGO(object JLFLGDNCANL, bool LLOCMBEOOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x85F96A0", Offset = "0x85F84A0", VA = "0x1885F96A0", Slot = "31")]
	public IDisposable CJILODFAJEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "32")]
	private bool OPJDDBDODDF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "33")]
	public void BPKMKIIKOAP(StringBuilder NIHOBNHAGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0xFE9770", Offset = "0xFE8570", VA = "0x180FE9770", Slot = "34")]
	public bool CPLOMDBJKKJ(bool PEDJGDAFCFA, [Out] string NGENEEODOJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0xF38670", Offset = "0xF37470", VA = "0x180F38670", Slot = "37")]
	public void AANCKBBEIPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal struct APFLCBFHHBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400039B")]
	private readonly IDictionary<object, object> FELHJOMEEAD;

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0xD5BCB0", Offset = "0xD5AAB0", VA = "0x180D5BCB0")]
	public APFLCBFHHBM(IDictionary<object, object> FELHJOMEEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x85F71F0", Offset = "0x85F5FF0", VA = "0x1885F71F0")]
	public bool FLIMALMPPHE([Out] JCNIBNHHJJK NJJDPBHNDPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x85F72A0", Offset = "0x85F60A0", VA = "0x1885F72A0")]
	public Guid JEMLFOLOFMH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x85F7350", Offset = "0x85F6150", VA = "0x1885F7350")]
	public NPEBMFOKKKC OIAKPHGLOOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x85F7100", Offset = "0x85F5F00", VA = "0x1885F7100")]
	public static ExitGames.Client.Photon.Hashtable BHEMCOAOOEF(JCNIBNHHJJK NJJDPBHNDPA, NPEBMFOKKKC MJMCEHEEBGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal static class BLCMEDGMODJ
{
	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x85F7F50", Offset = "0x85F6D50", VA = "0x1885F7F50")]
	public static bool KLKNPOHLKGD(this DAFHNINMJHP GLJABNGDFFO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
internal struct GADJIEADLFE : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private struct GDEGGFLPMDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public GADJIEADLFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x85FCAC0", Offset = "0x85FB8C0", VA = "0x1885FCAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x85FCCA0", Offset = "0x85FBAA0", VA = "0x1885FCCA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400039C")]
	private readonly CancellationTokenSource FMNLCBJFAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400039D")]
	private bool EKADHKFOHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400039E")]
	private Task JDEJDGHOHNF;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool JOCIPIGBAHE
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x85FBF50", Offset = "0x85FAD50", VA = "0x1885FBF50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x85FBF80", Offset = "0x85FAD80", VA = "0x1885FBF80")]
	public GADJIEADLFE(CancellationToken GHKBKDKNIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x85FBDF0", Offset = "0x85FABF0", VA = "0x1885FBDF0")]
	[AsyncStateMachine(typeof(GDEGGFLPMDD))]
	public Task BHGPACKEGCN(Func<CancellationToken, List<Task>> DCMBHLCHPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x85FBF00", Offset = "0x85FAD00", VA = "0x1885FBF00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public readonly struct CJDLDAABHBM<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct FEHBLMODHCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<HBACGGNKINL<TData>, DDPPOHMMKFK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public CJDLDAABHBM<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private TaskAwaiter<JKEBLLKKBOM<HBACGGNKINL<TData>, DDPPOHMMKFK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x4A4EE30", Offset = "0x4A4DC30", VA = "0x184A4EE30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x45E18E0", Offset = "0x45E06E0", VA = "0x1845E18E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	private readonly HHAHEEOIDKG<TGetDataArg, TData> JLPOGPHFPCB;

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0xD5BCB0", Offset = "0xD5AAB0", VA = "0x180D5BCB0")]
	internal CJDLDAABHBM(HHAHEEOIDKG<TGetDataArg, TData> JCFBNAHPHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x66392C0", Offset = "0x66380C0", VA = "0x1866392C0")]
	[AsyncStateMachine(typeof(CJDLDAABHBM<, >.FEHBLMODHCN))]
	public Task<JKEBLLKKBOM<HBACGGNKINL<TData>, DDPPOHMMKFK>> IKFNJMPICLF(TGetDataArg EMEICEFCBEP, string ODMKGLDGJKI, HBCKFDINPOH<string>.DLKHFLDLCIN HMLAIBMJFEO, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public static class EGMDMPDNOJM
{
	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x36A61D0", Offset = "0x36A4FD0", VA = "0x1836A61D0")]
	public static CJDLDAABHBM<TGetDataArg, TData> NBEICDCLFEE<TGetDataArg, TData>(HHAHEEOIDKG<TGetDataArg, TData> JCFBNAHPHAO)
	{
		return default(CJDLDAABHBM<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public struct NBKPMBPLAEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public readonly int JAOBBLBJLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public readonly int? MIOPNBPCAKM;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x513F4F0", Offset = "0x513E2F0", VA = "0x18513F4F0")]
	public NBKPMBPLAEB(int OICKECDHHGJ, [Optional] int? IEBOGMMABDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x860B460", Offset = "0x860A260", VA = "0x18860B460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public interface HHNHJBDJINK<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ACBFKIFJDBL();

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HHNHJBDJINK<T> IGKDDFALCOG(string PEIFKAPFPCB);

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HHNHJBDJINK<T> KFMKDKCJKKM(GJPGIFBLCMJ<T> DFMLOFIOJFH);

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HHNHJBDJINK<T> IOFFKLNHPEN(int DMDAMPNBMKA);

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HHNHJBDJINK<T> FBAEFBLMNDB(int DMDAMPNBMKA, MHAGKAHBCLN<T> DPPPGMPFOKF);
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public interface LMAKAKBFNCK
{
	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HHNHJBDJINK<T> HIBFOBFPOPP<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HOHHJCLCIIG HKJMFNBJOOJ(Exception HELNJIPKBCP);

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NBKPMBPLAEB IKAMIADCPKH(Exception HELNJIPKBCP);
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public delegate string GJPGIFBLCMJ<in T>(T HELNJIPKBCP) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public delegate int MHAGKAHBCLN<in T>(T HELNJIPKBCP) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FC")]
internal class GFDLLMNHLBB : LMAKAKBFNCK
{
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	private delegate string JGIKLCAONAL(Exception HELNJIPKBCP);

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	private delegate int GJBNHABNMPN(Exception HELNJIPKBCP);

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	private class ENGJLAFAHEB<T> : HHNHJBDJINK<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		[CompilerGenerated]
		private sealed class BFGODNPKPCA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public BFGODNPKPCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
			internal string HGNHENHCGKP(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000101")]
		[CompilerGenerated]
		private sealed class OEMHAKECBCN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			public GJPGIFBLCMJ<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public OEMHAKECBCN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0x5194E30", Offset = "0x5193C30", VA = "0x185194E30")]
			internal string JNCAIKHNELN(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000102")]
		[CompilerGenerated]
		private sealed class LIAOPBPMHPD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			public MHAGKAHBCLN<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public LIAOPBPMHPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0x5194E30", Offset = "0x5193C30", VA = "0x185194E30")]
			internal int LADMNFJCMEF(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private readonly GFDLLMNHLBB DLBECODNACL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private readonly Type OBFBKJPPCGL;

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x4613AD0", Offset = "0x46128D0", VA = "0x184613AD0")]
		internal ENGJLAFAHEB(GFDLLMNHLBB DLBECODNACL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x46136F0", Offset = "0x46124F0", VA = "0x1846136F0", Slot = "4")]
		public void ACBFKIFJDBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x4613850", Offset = "0x4612650", VA = "0x184613850", Slot = "5")]
		public HHNHJBDJINK<T> IGKDDFALCOG(string PEIFKAPFPCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x46139B0", Offset = "0x46127B0", VA = "0x1846139B0", Slot = "6")]
		public HHNHJBDJINK<T> KFMKDKCJKKM(GJPGIFBLCMJ<T> DFMLOFIOJFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x4613970", Offset = "0x4612770", VA = "0x184613970", Slot = "7")]
		public HHNHJBDJINK<T> IOFFKLNHPEN(int DMDAMPNBMKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x4613720", Offset = "0x4612520", VA = "0x184613720", Slot = "8")]
		public HHNHJBDJINK<T> FBAEFBLMNDB(int DMDAMPNBMKA, MHAGKAHBCLN<T> DPPPGMPFOKF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	private class GFFLPGCBGHI<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private bool PMGOKOMGCAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private readonly List<Type> CIMJKKLMGAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private readonly Dictionary<Type, TVal> EOJAGMBEKEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private readonly Dictionary<Type, int> JKCPKPMPFHI;

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public IReadOnlyList<Type> PKFMAMOLGCC
		{
			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0x4BC1930", Offset = "0x4BC0730", VA = "0x184BC1930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x4BC1DD0", Offset = "0x4BC0BD0", VA = "0x184BC1DD0")]
		public GFFLPGCBGHI(Dictionary<Type, int> JKCPKPMPFHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x4BC1A90", Offset = "0x4BC0890", VA = "0x184BC1A90")]
		public void AIKICPLLADB(Type MAKJJJECHHB, TVal AFBDJBIOHNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x4BC1C40", Offset = "0x4BC0A40", VA = "0x184BC1C40")]
		public bool HPIIEJMFIJJ(Type OBFBKJPPCGL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x4BC1BF0", Offset = "0x4BC09F0", VA = "0x184BC1BF0")]
		public bool DGGFCBDMMBJ(TVal OAIIHELJHLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x45D9020", Offset = "0x45D7E20", VA = "0x1845D9020")]
		public TVal MBFFDPKOBBN(Type AAFMBEEMJAC)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x4BC1D30", Offset = "0x4BC0B30", VA = "0x184BC1D30")]
		[CompilerGenerated]
		private int LLLDDINAMAO(Type LNKHFKEGICN, Type LMDBCLFDGMG)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private sealed class PEANGEGJODH : IEnumerable<NBKPMBPLAEB>, IEnumerable, IEnumerator<NBKPMBPLAEB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private NBKPMBPLAEB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public GFDLLMNHLBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private IEnumerator<NBKPMBPLAEB> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		private NBKPMBPLAEB System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004C2")]
			[Cpp2IlInjected.Address(RVA = "0x467A5B0", Offset = "0x46793B0", VA = "0x18467A5B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(NBKPMBPLAEB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0x8610B80", Offset = "0x860F980", VA = "0x188610B80", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0xED60C0", Offset = "0xED4EC0", VA = "0x180ED60C0")]
		[DebuggerHidden]
		public PEANGEGJODH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x8610BD0", Offset = "0x860F9D0", VA = "0x188610BD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x8610570", Offset = "0x860F370", VA = "0x188610570", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x8610A20", Offset = "0x860F820", VA = "0x188610A20")]
		private void PPMJPANAFBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x8610520", Offset = "0x860F320", VA = "0x188610520")]
		private void IMLDEFFNBDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x8610B30", Offset = "0x860F930", VA = "0x188610B30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x8610A70", Offset = "0x860F870", VA = "0x188610A70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NBKPMBPLAEB> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x8610A70", Offset = "0x860F870", VA = "0x188610A70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	private static readonly NBKPMBPLAEB OKMHACFNBMC;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	private static readonly Dictionary<Type, int> FMPNGKDJPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	private readonly HashSet<Type> BINIIADOIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	private readonly GFFLPGCBGHI<int> PCOIJFBOCBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	private readonly GFFLPGCBGHI<GJBNHABNMPN> FAMLFAOIBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	private readonly GFFLPGCBGHI<JGIKLCAONAL> KDNJNHALCIF;

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x85FD430", Offset = "0x85FC230", VA = "0x1885FD430")]
	[ENKLKENGHAE.AANPNKKBMFF.ENPJKGAFAPD]
	internal static void JKEPFALEAEN(NAELDDAANND DICMPHOPMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x85FE230", Offset = "0x85FD030", VA = "0x1885FE230")]
	[RecRoom.NoEngine.Common.Preserve]
	public GFDLLMNHLBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x3776EB0", Offset = "0x3775CB0", VA = "0x183776EB0", Slot = "4")]
	public HHNHJBDJINK<T> HIBFOBFPOPP<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x85FD1A0", Offset = "0x85FBFA0", VA = "0x1885FD1A0", Slot = "5")]
	public HOHHJCLCIIG HKJMFNBJOOJ(Exception HELNJIPKBCP)
	{
		return default(HOHHJCLCIIG);
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x85FD230", Offset = "0x85FC030", VA = "0x1885FD230", Slot = "6")]
	public NBKPMBPLAEB IKAMIADCPKH(Exception? HELNJIPKBCP)
	{
		return default(NBKPMBPLAEB);
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x85FCE30", Offset = "0x85FBC30", VA = "0x1885FCE30", Slot = "7")]
	[IteratorStateMachine(typeof(PEANGEGJODH))]
	public IEnumerable<NBKPMBPLAEB> BNPJHPNOCCJ(Exception HELNJIPKBCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x85FD050", Offset = "0x85FBE50", VA = "0x1885FD050", Slot = "8")]
	public string GBAPNAKMPDL(Exception? HELNJIPKBCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x85FD6F0", Offset = "0x85FC4F0", VA = "0x1885FD6F0")]
	private string MBKGKINACKH(AggregateException INHGMFELFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x85FDA00", Offset = "0x85FC800", VA = "0x1885FDA00")]
	private void MHCJMMJGNAE(Type OBFBKJPPCGL, int DMDAMPNBMKA, GJBNHABNMPN? HLCJNFPLBOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x85FD4A0", Offset = "0x85FC2A0", VA = "0x1885FD4A0")]
	private void KBAKKPKKFGD(Type OBFBKJPPCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x85FDDB0", Offset = "0x85FCBB0", VA = "0x1885FDDB0")]
	private void NDJNJMNBELE(Type OBFBKJPPCGL, JGIKLCAONAL IBFFEACMHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x85FCED0", Offset = "0x85FBCD0", VA = "0x1885FCED0")]
	private static int FIMLMJCENAL(Type OBFBKJPPCGL, Dictionary<Type, int> JKCPKPMPFHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x3904010", Offset = "0x3902E10", VA = "0x183904010")]
	private static bool BPBLNPMOFMP<TVal>(GFFLPGCBGHI<TVal> BGBLHEHBHCD, Type OBFBKJPPCGL, [Out] TVal OAIIHELJHLG) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x85FE080", Offset = "0x85FCE80", VA = "0x1885FE080")]
	[CompilerGenerated]
	internal static int OFHFJBCODMH(Type FNDBGPLHAAD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public struct HOHHJCLCIIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public readonly NBKPMBPLAEB JFHCABOAJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public readonly string OFPDKEBONBI;

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x86023D0", Offset = "0x86011D0", VA = "0x1886023D0")]
	public HOHHJCLCIIG(string ANDBLIAPACG, NBKPMBPLAEB DMDAMPNBMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x8602330", Offset = "0x8601130", VA = "0x188602330")]
	public string BNFOIHBMDKP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public class HMCLAFELGLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	private readonly GLGKNJAKNPE IIDKNHNCMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	private string PGAJOLIHNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	private long? APMNDBDMFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	private long? GIIEKNNAGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	private long? CKLBDBBMOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	private string GMKGDECHLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private FMFKKILGACO OHHMJLGGMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	private long? OKACJLKCDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private bool EOOIEPNECGA;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public string HHBPLICMAII
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public long CIJNMJFKCJI
	{
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x8601DE0", Offset = "0x8600BE0", VA = "0x188601DE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public long CAJAHKDDLHF
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x8601960", Offset = "0x8600760", VA = "0x188601960")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public long FAKALMNBDIF
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x8601430", Offset = "0x8600230", VA = "0x188601430")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public string JDIHDCDKAKB
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x8601920", Offset = "0x8600720", VA = "0x188601920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public FMFKKILGACO KJMCCKGMHEG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0xD99670", Offset = "0xD98470", VA = "0x180D99670")]
		get
		{
			return default(FMFKKILGACO);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x8601340", Offset = "0x8600140", VA = "0x188601340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public long OMBNMADBMAH
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x86012E0", Offset = "0x86000E0", VA = "0x1886012E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x8602090", Offset = "0x8600E90", VA = "0x188602090")]
	[UnityEngine.Scripting.Preserve]
	public HMCLAFELGLA([LCNEJNNIOGA(null)] GLGKNJAKNPE IIDKNHNCMKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x8601E40", Offset = "0x8600C40", VA = "0x188601E40")]
	private void PMCOLKNELJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x8601490", Offset = "0x8600290", VA = "0x188601490")]
	public void IIDBPLGOBLJ(long CEACGIDOODJ, long DPMNLDKPNGD, [Optional] long? KEIIDMOKGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x8601D40", Offset = "0x8600B40", VA = "0x188601D40")]
	public void NBAONDJIICM(long KEIIDMOKGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x8601260", Offset = "0x8600060", VA = "0x188601260")]
	public void BKIIPALIKHH(string JFGPGPDLOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x86019C0", Offset = "0x86007C0", VA = "0x1886019C0")]
	public void LIHEJHOFIHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
internal class HPFPDDDCBJJ : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private struct ICBMAIOCCHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public AsyncTaskMethodBuilder<JCNIBNHHJJK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public JCNIBNHHJJK roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public HPFPDDDCBJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private TaskAwaiter<OJHCGNKMJME.POGMNCIGBMJ<JCNIBNHHJJK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x8603820", Offset = "0x8602620", VA = "0x188603820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x8603D60", Offset = "0x8602B60", VA = "0x188603D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private struct FPNILINEEOC<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private sealed class PMCCFNBIHFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public JCNIBNHHJJK roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public PMCCFNBIHFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x86114C0", Offset = "0x86102C0", VA = "0x1886114C0")]
		internal JCNIBNHHJJK PHAMPIOIIJF(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct MGDBNOPCHDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public AsyncTaskMethodBuilder<OJHCGNKMJME.POGMNCIGBMJ<JCNIBNHHJJK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public JCNIBNHHJJK roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public HPFPDDDCBJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private IICKNIEGMJG <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private TaskAwaiter<OJHCGNKMJME.POGMNCIGBMJ<JCNIBNHHJJK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x860A250", Offset = "0x8609050", VA = "0x18860A250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x860A860", Offset = "0x8609660", VA = "0x18860A860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct PCECLOKNIED<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public HPFPDDDCBJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x576E100", Offset = "0x576CF00", VA = "0x18576E100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x45E18E0", Offset = "0x45E06E0", VA = "0x1845E18E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct LLOKMOBAFPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public HPFPDDDCBJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x86095E0", Offset = "0x86083E0", VA = "0x1886095E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x86098C0", Offset = "0x86086C0", VA = "0x1886098C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private sealed class JFPDFNKFCOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public JFPDFNKFCOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x8606170", Offset = "0x8604F70", VA = "0x188606170")]
		internal object KKJKEIIHBEP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x86060B0", Offset = "0x8604EB0", VA = "0x1886060B0")]
		internal bool IMKDNOMGGLN(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class HFLJMBPHBDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public HFLJMBPHBDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x85FE7A0", Offset = "0x85FD5A0", VA = "0x1885FE7A0")]
		internal object EFGAFAHKLOJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private sealed class FMAKLABGECM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public FMAKLABGECM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x85FAC10", Offset = "0x85F9A10", VA = "0x1885FAC10")]
		internal object PBJGECHFMDF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private sealed class CLEMJIGLNJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public CLEMJIGLNJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x85F7FD0", Offset = "0x85F6DD0", VA = "0x1885F7FD0")]
		internal object MLIJDEIEIHA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private sealed class BALCONLANGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public HPFPDDDCBJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public BALCONLANGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x85F7490", Offset = "0x85F6290", VA = "0x1885F7490")]
		internal object POMOJLOJKNH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private static readonly Guid LJIGKHBEOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public readonly OGJNGIMJFAN IDKGDPEDCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private readonly OJHCGNKMJME KILKNCGEANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	private readonly KJFHLELIGPN KLBDPNGJELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	private readonly HEPJOOJLFOI KKEAFJDKEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	private bool OHCAONCEFEB;

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x86035F0", Offset = "0x86023F0", VA = "0x1886035F0")]
	public HPFPDDDCBJJ(OGJNGIMJFAN GGHOJGJBMPF, OJHCGNKMJME KILKNCGEANK, KJFHLELIGPN KLBDPNGJELI, HEPJOOJLFOI KKEAFJDKEHJ, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x8602530", Offset = "0x8601330", VA = "0x188602530", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x8602BC0", Offset = "0x86019C0", VA = "0x188602BC0")]
	public void FNDIFNJPLOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x8602CE0", Offset = "0x8601AE0", VA = "0x188602CE0")]
	public void HOLALADOOGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x8602F30", Offset = "0x8601D30", VA = "0x188602F30")]
	public void LINCPACPAAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x8603260", Offset = "0x8602060", VA = "0x188603260")]
	[AsyncStateMachine(typeof(ICBMAIOCCHO))]
	internal Task<JCNIBNHHJJK> ODFKJFKFAHH(HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, JCNIBNHHJJK FGGHFEPNPLK, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x3928360", Offset = "0x3927160", VA = "0x183928360")]
	private static byte[] KEMJOKOGJGC<T>(T NJJDPBHNDPA) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x3928370", Offset = "0x3927170", VA = "0x183928370")]
	private static T KPFHGCBGJGH<T>(MessageParser<T> GKMMJBGAFIO, byte[] NJJDPBHNDPA, T POFCEEFGJMA) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x86023F0", Offset = "0x86011F0", VA = "0x1886023F0")]
	[AsyncStateMachine(typeof(MGDBNOPCHDM))]
	private Task<OJHCGNKMJME.POGMNCIGBMJ<JCNIBNHHJJK>> BLJKJKPFDPF(JCNIBNHHJJK FGGHFEPNPLK, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x39280C0", Offset = "0x3926EC0", VA = "0x1839280C0")]
	[AsyncStateMachine(typeof(PCECLOKNIED<>))]
	internal Task<T> FFLDCHAMHJA<T>(CancellationToken KKIGNHNCIEJ, Func<CancellationToken, Task<T>> ODGAFGNBCIO, int ACOBFBFOFNO = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x86026C0", Offset = "0x86014C0", VA = "0x1886026C0")]
	[AsyncStateMachine(typeof(LLOKMOBAFPC))]
	internal Task FFLDCHAMHJA(CancellationToken KKIGNHNCIEJ, Func<CancellationToken, Task> ODGAFGNBCIO, int ACOBFBFOFNO = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x8602EB0", Offset = "0x8601CB0", VA = "0x188602EB0")]
	public GEGMBPNFPKG KHKNEHPFDFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x86033C0", Offset = "0x86021C0", VA = "0x1886033C0")]
	public HFPIMAFEFHO PAJHOCENAHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x86027F0", Offset = "0x86015F0", VA = "0x1886027F0")]
	public LBNDPDAGLKC FHENFIDKKJB([Optional] IEBEPMGFCGH? NHLEILEPJMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x8602A60", Offset = "0x8601860", VA = "0x188602A60")]
	public void FKEFJPGEICP(Func<Guid, bool> AEDFCCIGBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x8602DA0", Offset = "0x8601BA0", VA = "0x188602DA0")]
	public void JGOJIDLEGOI(Func<Guid, bool> DBOLKDLBKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x8602540", Offset = "0x8601340", VA = "0x188602540")]
	public Guid FFFELJIKHAA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x8603150", Offset = "0x8601F50", VA = "0x188603150")]
	public void NGHOCFPNBKM(Guid KCIDHDICMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x8603440", Offset = "0x8602240", VA = "0x188603440")]
	public void PJMDJDJMLAH(JCNIBNHHJJK ENCPAOGHJCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x8603040", Offset = "0x8601E40", VA = "0x188603040")]
	public void NDLHJECGFPL(string NJLPOFCDDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x3927D20", Offset = "0x3926B20", VA = "0x183927D20")]
	private T EBAHDGFAAPP<T>(T OAIIHELJHLG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x8602FF0", Offset = "0x8601DF0", VA = "0x188602FF0")]
	public void MEAABEIHGIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x3927E10", Offset = "0x3926C10", VA = "0x183927E10")]
	[CompilerGenerated]
	internal static string EMGEAPJJCDN<T>(byte[] HNAKMABCJKP, int JLMEKGPDJJB, FPNILINEEOC<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal sealed class PIJAGBJPDIN : OGJNGIMJFAN
{
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private sealed class IJIKKOCHFND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public IJIKKOCHFND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x8604C60", Offset = "0x8603A60", VA = "0x188604C60")]
		internal object IOAIKFNLDIN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct KOGOFIDCMOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public PIJAGBJPDIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public HPFPDDDCBJJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private PAONFCHNCDI <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private HFPIMAFEFHO <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x8606510", Offset = "0x8605310", VA = "0x188606510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x8606E60", Offset = "0x8605C60", VA = "0x188606E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct OCJJHEGJJKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public PIJAGBJPDIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private TaskAwaiter<IEHEOOILKKD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x860DE00", Offset = "0x860CC00", VA = "0x18860DE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x860E540", Offset = "0x860D340", VA = "0x18860E540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private struct JAPPAHEJKMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public PIJAGBJPDIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private TaskAwaiter<ENAHMCDKIIN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x86054E0", Offset = "0x86042E0", VA = "0x1886054E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x86057F0", Offset = "0x86045F0", VA = "0x1886057F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private sealed class JPDEDLBLFKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public PAONFCHNCDI presence;

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public JPDEDLBLFKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x86063D0", Offset = "0x86051D0", VA = "0x1886063D0")]
		internal object BGJOFOOAOID()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	private static readonly IEBEPMGFCGH NHNGPLMPMAL;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	private static readonly IEBEPMGFCGH NMOKEIDJMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	private readonly EJLGFFHHDJD HEDPJIHKDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private readonly DAFHNINMJHP LCHHHCLEHKE;

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x8611330", Offset = "0x8610130", VA = "0x188611330")]
	public PIJAGBJPDIN(EJLGFFHHDJD HEDPJIHKDLI, DAFHNINMJHP LCHHHCLEHKE, Guid LGNCELEMLNH, GMNLHEBCJHB PPAOCCCONKJ, DKMOFLOMOKC CODPLCFCOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x8611010", Offset = "0x860FE10", VA = "0x188611010", Slot = "7")]
	[AsyncStateMachine(typeof(KOGOFIDCMOD))]
	protected override Task KPGELEGLGIH(HPFPDDDCBJJ OMDBDJDKPAE, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x8611150", Offset = "0x860FF50", VA = "0x188611150")]
	[AsyncStateMachine(typeof(OCJJHEGJJKP))]
	private Task OCKPNFMCPHK(CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x8610D20", Offset = "0x860FB20", VA = "0x188610D20")]
	[AsyncStateMachine(typeof(JAPPAHEJKMD))]
	private Task<int> FJEFOMNCODN(CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x8610E30", Offset = "0x860FC30", VA = "0x188610E30")]
	private PAONFCHNCDI FMPPLIIEFFA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
internal class EJLDOPHFDFF : OGJNGIMJFAN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private struct ABLCOJKFDFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public EJLDOPHFDFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public HPFPDDDCBJJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private TaskAwaiter<HIFJOJHPHLI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x85F63A0", Offset = "0x85F51A0", VA = "0x1885F63A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x85F6D50", Offset = "0x85F5B50", VA = "0x1885F6D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000425")]
	private readonly int HIFAIJJHKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000426")]
	private readonly ONKMAFKLDAF MKJDENHNJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public readonly long FBNGFADIKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public readonly long LMHINNDIOMJ;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public HIFJOJHPHLI NNEAACGICON
	{
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0xA0D980", Offset = "0xA0C780", VA = "0x180A0D980")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0xA0DA30", Offset = "0xA0C830", VA = "0x180A0DA30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x85F9480", Offset = "0x85F8280", VA = "0x1885F9480")]
	public EJLDOPHFDFF(Guid LGNCELEMLNH, GMNLHEBCJHB PPAOCCCONKJ, DKMOFLOMOKC CODPLCFCOPN, int HIFAIJJHKIC, ONKMAFKLDAF MKJDENHNJAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x85F9360", Offset = "0x85F8160", VA = "0x1885F9360", Slot = "7")]
	[AsyncStateMachine(typeof(ABLCOJKFDFP))]
	protected override Task KPGELEGLGIH(HPFPDDDCBJJ OMDBDJDKPAE, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal abstract class IPFILEEHCNI : OGJNGIMJFAN
{
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private sealed class HMBNHPFNKDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public IPFILEEHCNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public PLOMLBDJMJM playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public HMBNHPFNKDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x8601220", Offset = "0x8600020", VA = "0x188601220")]
		internal Task OEFPBABDEFG(HBCKFDINPOH<string>.DLKHFLDLCIN postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x8601190", Offset = "0x85FFF90", VA = "0x188601190")]
		internal object NBGKDPAJAJM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private struct IEMNLFMJBOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public IPFILEEHCNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public HPFPDDDCBJJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private HMBNHPFNKDP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x8603DD0", Offset = "0x8602BD0", VA = "0x188603DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x86045A0", Offset = "0x86033A0", VA = "0x1886045A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private struct LDKEHOHCPGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public PLOMLBDJMJM playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public IPFILEEHCNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x8606F20", Offset = "0x8605D20", VA = "0x188606F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x86074D0", Offset = "0x86062D0", VA = "0x1886074D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x8604FD0", Offset = "0x8603DD0", VA = "0x188604FD0")]
	public IPFILEEHCNI(Guid LGNCELEMLNH, GMNLHEBCJHB PPAOCCCONKJ, DKMOFLOMOKC CODPLCFCOPN, string GDAEANGJGBL, LKEHMNNHDHP CHNEHFOJOHF, bool KHMBMJKJFLG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x8604E90", Offset = "0x8603C90", VA = "0x188604E90", Slot = "7")]
	[AsyncStateMachine(typeof(IEMNLFMJBOE))]
	protected override Task KPGELEGLGIH(HPFPDDDCBJJ OMDBDJDKPAE, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task LIIEGMCACHC(HPFPDDDCBJJ OMDBDJDKPAE, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x8604D50", Offset = "0x8603B50", VA = "0x188604D50")]
	[AsyncStateMachine(typeof(LDKEHOHCPGK))]
	private Task IHJIAHPDGHJ(IDisposable NJHLJNDGFEJ, PLOMLBDJMJM PMMLGAPKIMG, HBCKFDINPOH<string>.DLKHFLDLCIN HMLAIBMJFEO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
internal class PNAHOLFDAJB : OGJNGIMJFAN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct JEMGBMBJMAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public PNAHOLFDAJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public HPFPDDDCBJJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private TaskAwaiter<ABCJCMNNNGP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x8605AC0", Offset = "0x86048C0", VA = "0x188605AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x8606050", Offset = "0x8604E50", VA = "0x188606050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000446")]
	private readonly ILAAIKBOLJH DGLHGHKAGGH;

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x86117A0", Offset = "0x86105A0", VA = "0x1886117A0")]
	public PNAHOLFDAJB(Guid LGNCELEMLNH, GMNLHEBCJHB PPAOCCCONKJ, DKMOFLOMOKC CODPLCFCOPN, ILAAIKBOLJH DGLHGHKAGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x86116C0", Offset = "0x86104C0", VA = "0x1886116C0", Slot = "6")]
	protected override string LJMGDMFOKAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x86115A0", Offset = "0x86103A0", VA = "0x1886115A0", Slot = "7")]
	[AsyncStateMachine(typeof(JEMGBMBJMAB))]
	protected override Task KPGELEGLGIH(HPFPDDDCBJJ OMDBDJDKPAE, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
internal abstract class OGJNGIMJFAN : AIKJEOAMDOK
{
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	public delegate Task LFKBAMIMBGM(HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private sealed class GDIEKCLEAJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public OGJNGIMJFAN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public GDIEKCLEAJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x85FCD00", Offset = "0x85FBB00", VA = "0x1885FCD00")]
		internal Task NHOEJDEPBGJ(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private sealed class NEHNOMKLBBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public GDIEKCLEAJG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public NEHNOMKLBBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x860B540", Offset = "0x860A340", VA = "0x18860B540")]
		internal object CGDICPEJFOL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct OIMEHOPIOFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public OGJNGIMJFAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public Func<OGJNGIMJFAN, HBCKFDINPOH<string>.DLKHFLDLCIN, HPFPDDDCBJJ> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private GDIEKCLEAJG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private HPFPDDDCBJJ <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private TaskAwaiter<JCNIBNHHJJK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x860F370", Offset = "0x860E170", VA = "0x18860F370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x86104C0", Offset = "0x860F2C0", VA = "0x1886104C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct HJBNEBALOOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x8600690", Offset = "0x85FF490", VA = "0x188600690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x8601130", Offset = "0x85FFF30", VA = "0x188601130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct NMLCLFODEKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public OGJNGIMJFAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x860DA40", Offset = "0x860C840", VA = "0x18860DA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x860DDA0", Offset = "0x860CBA0", VA = "0x18860DDA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public readonly Guid KAKAFMGMHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public readonly ByteString ONPFIMGAJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public readonly DKMOFLOMOKC DHDHGNDIHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	protected readonly string KCFMOMIHIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	private readonly GMNLHEBCJHB PPAOCCCONKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000454")]
	private readonly bool KHMBMJKJFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000455")]
	private readonly Queue<LFKBAMIMBGM> FKLBCIPHHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000456")]
	private readonly CFKPBECMIBP IEDIGCAHPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000457")]
	private readonly LKEHMNNHDHP CHNEHFOJOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000458")]
	private bool AJLGCLNJCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public FMFKKILGACO HDAAIBHBGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public FMFKKILGACO JGCHFOAEHJL;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public GMNLHEBCJHB OGPJPILGJBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public KHIJDEHFOJA NLOFNFPCHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x860E900", Offset = "0x860D700", VA = "0x18860E900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public BIPJBOOKCJI FCGOCHJLJPK
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x860E9D0", Offset = "0x860D7D0", VA = "0x18860E9D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public HNJJDFCNNLG NGAOLAIDCMC
	{
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x860E950", Offset = "0x860D750", VA = "0x18860E950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event MGLIPIHJPBA JJPHPJNAAMI
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x860EA20", Offset = "0x860D820", VA = "0x18860EA20", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x860E8E0", Offset = "0x860D6E0", VA = "0x18860E8E0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x860F210", Offset = "0x860E010", VA = "0x18860F210")]
	protected OGJNGIMJFAN(Guid LGNCELEMLNH, GMNLHEBCJHB PPAOCCCONKJ, DKMOFLOMOKC CODPLCFCOPN, string GDAEANGJGBL, LKEHMNNHDHP CHNEHFOJOHF, bool KHMBMJKJFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x860EE50", Offset = "0x860DC50", VA = "0x18860EE50", Slot = "6")]
	protected virtual string LJMGDMFOKAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x860F090", Offset = "0x860DE90", VA = "0x18860F090")]
	public void NJKBKDFFDJH(LFKBAMIMBGM ICKCCEIMLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x860ECE0", Offset = "0x860DAE0", VA = "0x18860ECE0")]
	protected void IACLEPPEBNP(float PJEGPPLKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x860ED00", Offset = "0x860DB00", VA = "0x18860ED00")]
	[AsyncStateMachine(typeof(OIMEHOPIOFP))]
	public Task LECHDFIDIED(CancellationToken GHKBKDKNIOM, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, [Optional] Func<OGJNGIMJFAN, HBCKFDINPOH<string>.DLKHFLDLCIN, HPFPDDDCBJJ> BFDPDNCKBKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x860EA40", Offset = "0x860D840", VA = "0x18860EA40")]
	[AsyncStateMachine(typeof(HJBNEBALOOK))]
	private static Task FEOGEJDHHMO(Func<CancellationToken, Task> AGNHCALAGPF, Func<CancellationToken, Task> HDLALLJBIHJ, CancellationToken KKIGNHNCIEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x860EF10", Offset = "0x860DD10", VA = "0x18860EF10")]
	private void MKFPALGIJJA(bool FHEDCABKFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x860E6B0", Offset = "0x860D4B0", VA = "0x18860E6B0")]
	private void APLMJFOJBKH(HPFPDDDCBJJ OMDBDJDKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task KPGELEGLGIH(HPFPDDDCBJJ OMDBDJDKPAE, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x860F0F0", Offset = "0x860DEF0", VA = "0x18860F0F0")]
	[AsyncStateMachine(typeof(NMLCLFODEKJ))]
	private Task ODBOMCKGGMH(HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x860EE90", Offset = "0x860DC90", VA = "0x18860EE90")]
	public JCNIBNHHJJK MJDNGEDHNGF(IICKNIEGMJG CHPLGPLOMHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x860EBF0", Offset = "0x860D9F0", VA = "0x18860EBF0")]
	[CompilerGenerated]
	private Task GFPLHBLDABK(CancellationToken JIJABGNNHPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x860EB70", Offset = "0x860D970", VA = "0x18860EB70")]
	[CompilerGenerated]
	private object GEMGGAAPMPC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
internal sealed class JHOFJEAIKAK : IPFILEEHCNI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct LHONOIIOEDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public JHOFJEAIKAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public HPFPDDDCBJJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private LHFNDJOEGHO <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private HFPIMAFEFHO <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x8608560", Offset = "0x8607360", VA = "0x188608560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x8608CD0", Offset = "0x8607AD0", VA = "0x188608CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400047C")]
	private readonly EJLGFFHHDJD DHJBELBEMNH;

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x8606320", Offset = "0x8605120", VA = "0x188606320")]
	public JHOFJEAIKAK(Guid LGNCELEMLNH, GMNLHEBCJHB PPAOCCCONKJ, EJLGFFHHDJD DHJBELBEMNH, DKMOFLOMOKC CODPLCFCOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x86061D0", Offset = "0x8604FD0", VA = "0x1886061D0", Slot = "8")]
	[AsyncStateMachine(typeof(LHONOIIOEDP))]
	protected override Task LIIEGMCACHC(HPFPDDDCBJJ OMDBDJDKPAE, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
internal class GILAOPNCJEC : OGJNGIMJFAN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct GANEHDELDGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public GILAOPNCJEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public HPFPDDDCBJJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private TaskAwaiter<ABCJCMNNNGP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x85FC0B0", Offset = "0x85FAEB0", VA = "0x1885FC0B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x85FC460", Offset = "0x85FB260", VA = "0x1885FC460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000486")]
	private readonly string NCOFNPLBCFI;

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x85FE6F0", Offset = "0x85FD4F0", VA = "0x1885FE6F0")]
	public GILAOPNCJEC(Guid LGNCELEMLNH, GMNLHEBCJHB PPAOCCCONKJ, DKMOFLOMOKC CODPLCFCOPN, string NCOFNPLBCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x85FE5E0", Offset = "0x85FD3E0", VA = "0x1885FE5E0", Slot = "7")]
	[AsyncStateMachine(typeof(GANEHDELDGL))]
	protected override Task KPGELEGLGIH(HPFPDDDCBJJ OMDBDJDKPAE, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
internal class DNPAAJJEDNJ : IPFILEEHCNI
{
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private sealed class IGABEAFDAIA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000132")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			public AsyncTaskMethodBuilder<JCNIBNHHJJK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400049B")]
			public IGABEAFDAIA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400049C")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400049D")]
			private TaskAwaiter<ABCJCMNNNGP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400049E")]
			private TaskAwaiter<JCNIBNHHJJK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000566")]
			[Cpp2IlInjected.Address(RVA = "0x8612790", Offset = "0x8611590", VA = "0x188612790", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000567")]
			[Cpp2IlInjected.Address(RVA = "0x8612C80", Offset = "0x8611A80", VA = "0x188612C80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public DNPAAJJEDNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public LBNDPDAGLKC serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public IBOBFJDJKHF roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public GEGMBPNFPKG uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public BBDLPBCCOHO roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public IGABEAFDAIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x8604600", Offset = "0x8603400", VA = "0x188604600")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<JCNIBNHHJJK> KODBBKGEDCC(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct LGLNALNLGFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public DNPAAJJEDNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public HPFPDDDCBJJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private IGABEAFDAIA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private LHFNDJOEGHO <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private HFPIMAFEFHO <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private JCNIBNHHJJK <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private TaskAwaiter<JCNIBNHHJJK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x8607680", Offset = "0x8606480", VA = "0x188607680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x8608500", Offset = "0x8607300", VA = "0x188608500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	private static readonly IEBEPMGFCGH NHNGPLMPMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400048F")]
	private readonly int JFFMBFCFHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	[CanBeNull]
	private readonly KKDADIJBPAI LANGIPGHPFC;

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x85F92B0", Offset = "0x85F80B0", VA = "0x1885F92B0")]
	public DNPAAJJEDNJ(Guid LGNCELEMLNH, GMNLHEBCJHB PPAOCCCONKJ, int JFFMBFCFHJI, KKDADIJBPAI LANGIPGHPFC, DKMOFLOMOKC CODPLCFCOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x85F8FC0", Offset = "0x85F7DC0", VA = "0x1885F8FC0", Slot = "8")]
	[AsyncStateMachine(typeof(LGLNALNLGFE))]
	protected override Task LIIEGMCACHC(HPFPDDDCBJJ OMDBDJDKPAE, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x85F9100", Offset = "0x85F7F00", VA = "0x1885F9100")]
	private void NEDLGIAPBEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x85F8DF0", Offset = "0x85F7BF0", VA = "0x1885F8DF0")]
	private void EOBPOCBKPMG(HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, LHFNDJOEGHO LFNOMKAPHON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
internal class NJKJCLDHHFP : OGJNGIMJFAN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct NELLOFFOJIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public NJKJCLDHHFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private LHFNDJOEGHO <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private long <superRoomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private long <subRoomId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private ENAHMCDKIIN <currentRoomSave>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private EHIFMMNJMNN<ReadOnlySequence<byte>> <subroomDataBlobHandle>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private TaskAwaiter<ENAHMCDKIIN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private TaskAwaiter<ReadOnlySequence<byte>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private TaskAwaiter<HIFJOJHPHLI> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private TaskAwaiter <>u__4;

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x860B600", Offset = "0x860A400", VA = "0x18860B600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x860CA20", Offset = "0x860B820", VA = "0x18860CA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	private readonly int JFFMBFCFHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	private readonly KKDADIJBPAI LANGIPGHPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	private Func<ABCJCMNNNGP, ABCJCMNNNGP> EDKBIAIMAMI;

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x860D980", Offset = "0x860C780", VA = "0x18860D980")]
	public NJKJCLDHHFP(Guid LGNCELEMLNH, GMNLHEBCJHB PPAOCCCONKJ, int JFFMBFCFHJI, KKDADIJBPAI LANGIPGHPFC, Func<ABCJCMNNNGP, ABCJCMNNNGP> EDKBIAIMAMI, DKMOFLOMOKC CODPLCFCOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x860D850", Offset = "0x860C650", VA = "0x18860D850", Slot = "7")]
	[AsyncStateMachine(typeof(NELLOFFOJIF))]
	protected override Task KPGELEGLGIH(HPFPDDDCBJJ OMDBDJDKPAE, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal abstract class HOBKGGNFPFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public readonly OGJNGIMJFAN IDKGDPEDCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public readonly HPFPDDDCBJJ AMPFAKGONCF;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public KHIJDEHFOJA NLOFNFPCHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x86020D0", Offset = "0x8600ED0", VA = "0x1886020D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public HNJJDFCNNLG NGAOLAIDCMC
	{
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x8602120", Offset = "0x8600F20", VA = "0x188602120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x86022D0", Offset = "0x86010D0", VA = "0x1886022D0")]
	protected HOBKGGNFPFC(HPFPDDDCBJJ OMDBDJDKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x86021B0", Offset = "0x8600FB0", VA = "0x1886021B0")]
	protected void NDLHJECGFPL(string NJLPOFCDDIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
internal struct DADICJBEDAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public Dictionary<Guid, List<PADAGBJFPOI>> KOJHMPHHJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public Dictionary<Guid, List<PADAGBJFPOI>> LFIJKFHMFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public Dictionary<Guid, List<PADAGBJFPOI>> DDOADMICJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public List<Guid> EPMGHEEEMHL;

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x85F80E0", Offset = "0x85F6EE0", VA = "0x1885F80E0")]
	public static DADICJBEDAM MBFFDPKOBBN(KHIJDEHFOJA LKIBPKBGCOO, FMFKKILGACO FGCFMMMFHAA, PCKGILPFDIA OIFHIOIKAIN)
	{
		return default(DADICJBEDAM);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct OJELIFMDMBP
{
	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0")]
	public static OJELIFMDMBP BHEMCOAOOEF()
	{
		return default(OJELIFMDMBP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal struct DDJDFAOFFLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public readonly IEHEOOILKKD OBHLDKPHIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public readonly HLKGJIPFKJP BMDHCHDHIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public readonly Guid? DGIHKBKLLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public readonly IReadOnlyCollection<FDPEOBPEHPG> HCILPACHGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public readonly IReadOnlyCollection<FDPEOBPEHPG> NGHKOJHJAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public readonly CKNMKLKMAFP JINFFCDMHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public readonly CKNMKLKMAFP LINKDNKHHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public readonly JLKEEJPFIPN GMECNDHBKDG;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool ODANCJIODPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x85F8B90", Offset = "0x85F7990", VA = "0x1885F8B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x85F8C20", Offset = "0x85F7A20", VA = "0x1885F8C20")]
	public DDJDFAOFFLH(IEHEOOILKKD OBHLDKPHIMF, HLKGJIPFKJP BMDHCHDHIHD, Guid? DGIHKBKLLKL, IReadOnlyList<FDPEOBPEHPG> HCILPACHGBE, IReadOnlyCollection<FDPEOBPEHPG> NGHKOJHJAIA, CKNMKLKMAFP JINFFCDMHMF, CKNMKLKMAFP LINKDNKHHPK, JLKEEJPFIPN GMECNDHBKDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct JAFBNNINLLG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	private readonly HPFPDDDCBJJ OMDBDJDKPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private readonly Guid KCIDHDICMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	private bool FHEDCABKFLG;

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x8605030", Offset = "0x8603E30", VA = "0x188605030")]
	public static JAFBNNINLLG FFFELJIKHAA(HPFPDDDCBJJ OMDBDJDKPAE)
	{
		return default(JAFBNNINLLG);
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x121B800", Offset = "0x121A600", VA = "0x18121B800")]
	public void OOCKOCMEHMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x8605020", Offset = "0x8603E20", VA = "0x188605020", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x8605340", Offset = "0x8604140", VA = "0x188605340")]
	private JAFBNNINLLG(HPFPDDDCBJJ OMDBDJDKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x8605100", Offset = "0x8603F00", VA = "0x188605100")]
	private void NGHOCFPNBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x8605060", Offset = "0x8603E60", VA = "0x188605060")]
	private Func<Guid, bool> FMDJCFGPACC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
internal class HFPIMAFEFHO : HOBKGGNFPFC, AIKJEOAMDOK
{
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	public delegate Task<FMFKKILGACO> HBGPDCLIBAP(PCKGILPFDIA FFEMKICJPKP, HJPJMEMMBCG NCCHMNIDDHB, CFKPBECMIBP EKBPHAMIEHA, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct MADEBCFEOLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public HFPIMAFEFHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public EJLGFFHHDJD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private JAFBNNINLLG <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		private TaskAwaiter<JCNIBNHHJJK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x8609920", Offset = "0x8608720", VA = "0x188609920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x860A1F0", Offset = "0x8608FF0", VA = "0x18860A1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct DBKNBKDEAJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public AsyncTaskMethodBuilder<JCNIBNHHJJK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public HFPIMAFEFHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public EJLGFFHHDJD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private TaskAwaiter<JCNIBNHHJJK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x85F86F0", Offset = "0x85F74F0", VA = "0x1885F86F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x85F8B20", Offset = "0x85F7920", VA = "0x1885F8B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct ABIDKAHMMMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public HFPIMAFEFHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public EJLGFFHHDJD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x85F5D00", Offset = "0x85F4B00", VA = "0x1885F5D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x85F6340", Offset = "0x85F5140", VA = "0x1885F6340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private sealed class MOFIGFBMOBN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000142")]
		private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004FA")]
			public AsyncTaskMethodBuilder<DDJDFAOFFLH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004FB")]
			public MOFIGFBMOBN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004FC")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004FD")]
			private DDJDFAOFFLH <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40004FE")]
			private TaskAwaiter<FMFKKILGACO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40004FF")]
			private TaskAwaiter<DDJDFAOFFLH> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0x8611840", Offset = "0x8610640", VA = "0x188611840", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0x8612030", Offset = "0x8610E30", VA = "0x188612030", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000143")]
		private struct <<LoadRoomLocal>b__3>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000500")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000501")]
			public AsyncTaskMethodBuilder<PCKGILPFDIA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000502")]
			public MOFIGFBMOBN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000503")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000504")]
			private PCKGILPFDIA <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000505")]
			private TaskAwaiter<FMFKKILGACO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000506")]
			private TaskAwaiter<PCKGILPFDIA> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x86120A0", Offset = "0x8610EA0", VA = "0x1886120A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B7")]
			[Cpp2IlInjected.Address(RVA = "0x8612720", Offset = "0x8611520", VA = "0x188612720", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public HFPIMAFEFHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public EJLGFFHHDJD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public CFKPBECMIBP preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public CFKPBECMIBP downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public DDJDFAOFFLH data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public CFKPBECMIBP postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public PCKGILPFDIA phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public KPPIONNPJCL.FDCOECOEOKN <>9__5;

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public MOFIGFBMOBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x860AEF0", Offset = "0x8609CF0", VA = "0x18860AEF0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<DDJDFAOFFLH> AICLIBDLGIM(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x860B040", Offset = "0x8609E40", VA = "0x18860B040")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<PCKGILPFDIA> BDAOMICIOHK(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x860B2C0", Offset = "0x860A0C0", VA = "0x18860B2C0")]
		internal void CHEJADCEAAN(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x860B300", Offset = "0x860A100", VA = "0x18860B300")]
		internal Task EHIMLAMIONC(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x860B160", Offset = "0x8609F60", VA = "0x18860B160")]
		internal Task BEMJMFJDOBA(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct NICDGNPKALN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public HFPIMAFEFHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public EJLGFFHHDJD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private MOFIGFBMOBN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private TaskAwaiter<DDJDFAOFFLH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private TaskAwaiter<PCKGILPFDIA> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x860CA80", Offset = "0x860B880", VA = "0x18860CA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x860D7F0", Offset = "0x860C5F0", VA = "0x18860D7F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct FOBPKBJFBDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public HFPIMAFEFHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public PCKGILPFDIA phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public CFKPBECMIBP postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		private TaskAwaiter<FMFKKILGACO> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private HJPJMEMMBCG <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x85FAC80", Offset = "0x85F9A80", VA = "0x1885FAC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x85FBD90", Offset = "0x85FAB90", VA = "0x1885FBD90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct BMPFHGKOIEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public HFPIMAFEFHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x8618300", Offset = "0x8617100", VA = "0x188618300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x8618AE0", Offset = "0x86178E0", VA = "0x188618AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct LAFCAENBDLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public HFPIMAFEFHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public PCKGILPFDIA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public CFKPBECMIBP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private TaskAwaiter<FMFKKILGACO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x8625120", Offset = "0x8623F20", VA = "0x188625120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x8625960", Offset = "0x8624760", VA = "0x188625960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct NAPPNAFIILK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public AsyncTaskMethodBuilder<FMFKKILGACO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public HFPIMAFEFHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public PCKGILPFDIA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public CFKPBECMIBP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private TaskAwaiter<FMFKKILGACO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x8627970", Offset = "0x8626770", VA = "0x188627970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x8628930", Offset = "0x8627730", VA = "0x188628930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct IAHJIDADDDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public AsyncTaskMethodBuilder<FMFKKILGACO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public HFPIMAFEFHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public PCKGILPFDIA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public CFKPBECMIBP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public HJPJMEMMBCG timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private TaskAwaiter<FMFKKILGACO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x861EC20", Offset = "0x861DA20", VA = "0x18861EC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x861FD30", Offset = "0x861EB30", VA = "0x18861FD30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private struct GNDLIBMJGMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public AsyncTaskMethodBuilder<FMFKKILGACO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public HFPIMAFEFHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public FMFKKILGACO operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public CFKPBECMIBP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public PCKGILPFDIA deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private TaskAwaiter<FMFKKILGACO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x861C260", Offset = "0x861B060", VA = "0x18861C260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x861C4B0", Offset = "0x861B2B0", VA = "0x18861C4B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private sealed class FBNNHDNMLAK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014D")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000556")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000557")]
			public AsyncTaskMethodBuilder<FMFKKILGACO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000558")]
			public FBNNHDNMLAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000559")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400055A")]
			private OGIJLBDGAHB <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400055B")]
			private TaskAwaiter<FMFKKILGACO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x862B460", Offset = "0x862A260", VA = "0x18862B460", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x862BA90", Offset = "0x862A890", VA = "0x18862BA90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public HFPIMAFEFHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public PCKGILPFDIA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public CFKPBECMIBP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public HBGPDCLIBAP masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public HJPJMEMMBCG timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public FMFKKILGACO originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public FBNNHDNMLAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x861A8C0", Offset = "0x86196C0", VA = "0x18861A8C0")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<FMFKKILGACO> GDKBPBNFPOO(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct AMGDBOMBGHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public AsyncTaskMethodBuilder<FMFKKILGACO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public HFPIMAFEFHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public PCKGILPFDIA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public CFKPBECMIBP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public HBGPDCLIBAP masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public HJPJMEMMBCG timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private OGIJLBDGAHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private TaskAwaiter<FMFKKILGACO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x86142C0", Offset = "0x86130C0", VA = "0x1886142C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x86147E0", Offset = "0x86135E0", VA = "0x1886147E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private struct GMDDOMHEFNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public HFPIMAFEFHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public PCKGILPFDIA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public CFKPBECMIBP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private FMFKKILGACO <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private IEnumerator<FMFKKILGACO> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private TaskAwaiter<FMFKKILGACO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x861BCA0", Offset = "0x861AAA0", VA = "0x18861BCA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x861C200", Offset = "0x861B000", VA = "0x18861C200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct HEGNLIBHLKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public HFPIMAFEFHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public PCKGILPFDIA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x861DC10", Offset = "0x861CA10", VA = "0x18861DC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x861DF00", Offset = "0x861CD00", VA = "0x18861DF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct LKCCKBLKKLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public HFPIMAFEFHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public PCKGILPFDIA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x8626560", Offset = "0x8625360", VA = "0x188626560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x8626790", Offset = "0x8625590", VA = "0x188626790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private sealed class ECNFAICDDIA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000153")]
		private struct <<RoomV2LoadLogic>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000580")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000581")]
			public AsyncTaskMethodBuilder<FMFKKILGACO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000582")]
			public ECNFAICDDIA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000583")]
			public PCKGILPFDIA data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000584")]
			public CFKPBECMIBP progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000585")]
			public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000586")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000587")]
			private TaskAwaiter<FMFKKILGACO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000588")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000589")]
			private TaskAwaiter<NIKJMMKGBCK> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005DA")]
			[Cpp2IlInjected.Address(RVA = "0x862BB00", Offset = "0x862A900", VA = "0x18862BB00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DB")]
			[Cpp2IlInjected.Address(RVA = "0x862C5D0", Offset = "0x862B3D0", VA = "0x18862C5D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public HFPIMAFEFHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public DLELGCAFMOF mainLoadService;

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public ECNFAICDDIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x8619E30", Offset = "0x8618C30", VA = "0x188619E30")]
		[AsyncStateMachine(typeof(<<RoomV2LoadLogic>b__0>d))]
		internal Task<FMFKKILGACO> DEMNFMKNBOG(PCKGILPFDIA data, HJPJMEMMBCG _, CFKPBECMIBP progressTracker, HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct JENPABCHOKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public HFPIMAFEFHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public PCKGILPFDIA phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public CFKPBECMIBP postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		private ECNFAICDDIA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		private HJPJMEMMBCG <timedYielder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private TaskAwaiter<FMFKKILGACO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x86208D0", Offset = "0x861F6D0", VA = "0x1886208D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x86217A0", Offset = "0x86205A0", VA = "0x1886217A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct AHPAFEADMLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public HFPIMAFEFHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public PCKGILPFDIA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x8613880", Offset = "0x8612680", VA = "0x188613880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x8613C80", Offset = "0x8612A80", VA = "0x188613C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct FOHFDHBHBLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public AsyncTaskMethodBuilder<FMFKKILGACO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public HFPIMAFEFHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public PCKGILPFDIA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public CFKPBECMIBP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private TaskAwaiter<FMFKKILGACO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x861ADB0", Offset = "0x8619BB0", VA = "0x18861ADB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x861B3D0", Offset = "0x861A1D0", VA = "0x18861B3D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	private readonly DPBIDJALKLM AAKMFKJOIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private readonly DPBIDJALKLM JIDKIJEPLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	private readonly HMCLAFELGLA NFPANFIHGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	private readonly ANPEONMLPAB GMOHCIIGBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	private readonly LAOBEKBOAFC AKMGIEFHFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	private ProfilerCounterValue<int> NCAIEOPBMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	private readonly NDJMODJJIEA EFLKAKJAPKE;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private GMNLHEBCJHB OGPJPILGJBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x85FF040", Offset = "0x85FDE40", VA = "0x1885FF040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event MGLIPIHJPBA JJPHPJNAAMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x85FF1F0", Offset = "0x85FDFF0", VA = "0x1885FF1F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x85FECC0", Offset = "0x85FDAC0", VA = "0x1885FECC0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x86003C0", Offset = "0x85FF1C0", VA = "0x1886003C0")]
	public HFPIMAFEFHO(HPFPDDDCBJJ OMDBDJDKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x85FF620", Offset = "0x85FE420", VA = "0x1885FF620")]
	[AsyncStateMachine(typeof(MADEBCFEOLH))]
	public Task HJKEGEGLBKO(EJLGFFHHDJD OHDJLNAKLPC, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x85FEE90", Offset = "0x85FDC90", VA = "0x1885FEE90")]
	[AsyncStateMachine(typeof(DBKNBKDEAJC))]
	private Task<JCNIBNHHJJK> CPEEGAMJBLB(EJLGFFHHDJD OHDJLNAKLPC, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x85FFFF0", Offset = "0x85FEDF0", VA = "0x1885FFFF0")]
	[AsyncStateMachine(typeof(ABIDKAHMMMH))]
	private Task OMCAKELGMPG(EJLGFFHHDJD OHDJLNAKLPC, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x85FF4D0", Offset = "0x85FE2D0", VA = "0x1885FF4D0")]
	[AsyncStateMachine(typeof(NICDGNPKALN))]
	private Task FPHKOJDCFDN(EJLGFFHHDJD OHDJLNAKLPC, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken CLDPDKPEMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x85FEA90", Offset = "0x85FD890", VA = "0x1885FEA90")]
	[AsyncStateMachine(typeof(FOBPKBJFBDM))]
	private Task BCBIADKLBEN(PCKGILPFDIA DHAKMALPICH, CFKPBECMIBP KCALNMNALEH, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken AIAIHADILOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x85FF3C0", Offset = "0x85FE1C0", VA = "0x1885FF3C0")]
	[AsyncStateMachine(typeof(BMPFHGKOIEK))]
	private Task FNLDLEFOECA(HBCKFDINPOH<string>.DLKHFLDLCIN HMLAIBMJFEO, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x85FF270", Offset = "0x85FE070", VA = "0x1885FF270")]
	[AsyncStateMachine(typeof(LAFCAENBDLF))]
	private Task FKDPNFAPIHE(PCKGILPFDIA FFEMKICJPKP, CFKPBECMIBP EKBPHAMIEHA, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x85FF070", Offset = "0x85FDE70", VA = "0x1885FF070")]
	[AsyncStateMachine(typeof(NAPPNAFIILK))]
	private Task<FMFKKILGACO> EAHFHAGFFCK(PCKGILPFDIA FFEMKICJPKP, HJPJMEMMBCG HLENMICNOJN, CFKPBECMIBP EKBPHAMIEHA, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x85FFB50", Offset = "0x85FE950", VA = "0x1885FFB50")]
	[AsyncStateMachine(typeof(IAHJIDADDDK))]
	private Task<FMFKKILGACO> LIKNNLJPPNG(PCKGILPFDIA FFEMKICJPKP, HJPJMEMMBCG HLENMICNOJN, CFKPBECMIBP EKBPHAMIEHA, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x8600150", Offset = "0x85FEF50", VA = "0x188600150")]
	[AsyncStateMachine(typeof(GNDLIBMJGMA))]
	private Task<FMFKKILGACO> PJNIHDOOAFK(FMFKKILGACO FGCFMMMFHAA, PCKGILPFDIA OIFHIOIKAIN, CFKPBECMIBP EKBPHAMIEHA, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM, bool ICFGEDOOFCM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x85FFA60", Offset = "0x85FE860", VA = "0x1885FFA60")]
	private bool LGNMJFEGFDM(PCKGILPFDIA DHAKMALPICH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x85FECE0", Offset = "0x85FDAE0", VA = "0x1885FECE0")]
	[AsyncStateMachine(typeof(AMGDBOMBGHE))]
	protected Task<FMFKKILGACO> BHIONCJMHHH(PCKGILPFDIA FFEMKICJPKP, HJPJMEMMBCG HLENMICNOJN, CFKPBECMIBP EKBPHAMIEHA, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM, HBGPDCLIBAP LOOMNACCPFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x85FE940", Offset = "0x85FD740", VA = "0x1885FE940")]
	[AsyncStateMachine(typeof(GMDDOMHEFNL))]
	private Task BAKBOMECNIE(PCKGILPFDIA FFEMKICJPKP, CFKPBECMIBP EKBPHAMIEHA, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x85FEFF0", Offset = "0x85FDDF0", VA = "0x1885FEFF0")]
	private void DFJAPGCALCB(FMFKKILGACO FNHHHKHKPEK, CFKPBECMIBP EKBPHAMIEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x85FF210", Offset = "0x85FE010", VA = "0x1885FF210")]
	private void ELHMKAGLONC(FMFKKILGACO FKEOONMBHJJ, [Out] FMFKKILGACO DIFDKDHMPCO, [Out] FMFKKILGACO GCFPHPBHPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x85FFFB0", Offset = "0x85FEDB0", VA = "0x1885FFFB0")]
	private Task<DDJDFAOFFLH> MOMPPDJKMPJ(EJLGFFHHDJD OHDJLNAKLPC, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x85FF8D0", Offset = "0x85FE6D0", VA = "0x1885FF8D0")]
	private Task<PCKGILPFDIA> KALOLLEDLNJ(DDJDFAOFFLH FFEMKICJPKP, KPPIONNPJCL.FDCOECOEOKN NODBBLEALIC, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x85FF910", Offset = "0x85FE710", VA = "0x1885FF910")]
	[AsyncStateMachine(typeof(HEGNLIBHLKE))]
	private Task LADGGACIINL(PCKGILPFDIA FFEMKICJPKP, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM, bool FIIAPMBNGPG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x86002D0", Offset = "0x85FF0D0", VA = "0x1886002D0")]
	[AsyncStateMachine(typeof(LKCCKBLKKLG))]
	private Task PJPKMNOGKOK(PCKGILPFDIA FFEMKICJPKP, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x85FEC90", Offset = "0x85FDA90", VA = "0x1885FEC90")]
	private Task BEBMPAEENFA(PCKGILPFDIA FFEMKICJPKP, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x8600130", Offset = "0x85FEF30", VA = "0x188600130")]
	private Task PEPPBLAOPPF(PCKGILPFDIA FFEMKICJPKP, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x85FFCD0", Offset = "0x85FEAD0", VA = "0x1885FFCD0")]
	private Task LKDAJMICKNC(PCKGILPFDIA FFEMKICJPKP, HJPJMEMMBCG HLENMICNOJN, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x85FEE70", Offset = "0x85FDC70", VA = "0x1885FEE70")]
	private Task CKIJIMGDNJC(PCKGILPFDIA FFEMKICJPKP, HJPJMEMMBCG HLENMICNOJN, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x85FF610", Offset = "0x85FE410", VA = "0x1885FF610")]
	private static Task HJAANFOBBPI(CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x85FF250", Offset = "0x85FE050", VA = "0x1885FF250")]
	private Task EOLIDBDPPAL(PCKGILPFDIA FFEMKICJPKP, HJPJMEMMBCG HLENMICNOJN, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x85FF1D0", Offset = "0x85FDFD0", VA = "0x1885FF1D0")]
	private Task EAPLGNNMJIB(PCKGILPFDIA FFEMKICJPKP, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x85FFE40", Offset = "0x85FEC40", VA = "0x1885FFE40")]
	private void MNGKMFEBFIP(EJLGFFHHDJD OHDJLNAKLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x85FEBE0", Offset = "0x85FD9E0", VA = "0x1885FEBE0")]
	public void BCBMFJHILLF(long KEIIDMOKGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	private static void GFKOGMOIDAI(IEHEOOILKKD OBHLDKPHIMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x85FFCF0", Offset = "0x85FEAF0", VA = "0x1885FFCF0")]
	[AsyncStateMachine(typeof(JENPABCHOKA))]
	private Task MCBHJJDNFME(PCKGILPFDIA DHAKMALPICH, CFKPBECMIBP KCALNMNALEH, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken AIAIHADILOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x85FE800", Offset = "0x85FD600", VA = "0x1885FE800")]
	[AsyncStateMachine(typeof(AHPAFEADMLI))]
	private Task AMLLKBEGJOE(PCKGILPFDIA FFEMKICJPKP, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x85FFE90", Offset = "0x85FEC90", VA = "0x1885FFE90")]
	private static DMDGHBDFKMP MNGLLIFBICJ(PCKGILPFDIA OIFHIOIKAIN)
	{
		return default(DMDGHBDFKMP);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x85FF770", Offset = "0x85FE570", VA = "0x1885FF770")]
	[AsyncStateMachine(typeof(FOHFDHBHBLC))]
	private Task<FMFKKILGACO> JMLEDHPHCIF(PCKGILPFDIA FFEMKICJPKP, HJPJMEMMBCG HLENMICNOJN, CFKPBECMIBP EKBPHAMIEHA, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	private void GPHNDPKPBPJ(FMFKKILGACO LCBIFPHGKKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
internal struct BCCOLCKLDPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A6")]
	private GMNLHEBCJHB PPAOCCCONKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005A7")]
	private PCKGILPFDIA FFEMKICJPKP;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private KHIJDEHFOJA NLOFNFPCHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x8615F00", Offset = "0x8614D00", VA = "0x188615F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x8615F50", Offset = "0x8614D50", VA = "0x188615F50")]
	public static Task LECHDFIDIED(GMNLHEBCJHB PPAOCCCONKJ, PCKGILPFDIA FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x8616030", Offset = "0x8614E30", VA = "0x188616030")]
	private void LECHDFIDIED()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000158")]
internal struct JIANMGMKNBE
{
	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x8621990", Offset = "0x8620790", VA = "0x188621990")]
	public static Task LECHDFIDIED(CancellationToken GHKBKDKNIOM)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct CCJBBHECAKF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private struct MDKLFJHNBHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public HPFPDDDCBJJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public PCKGILPFDIA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		private OGIJLBDGAHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x86267F0", Offset = "0x86255F0", VA = "0x1886267F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x8626D20", Offset = "0x8625B20", VA = "0x188626D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x8618DD0", Offset = "0x8617BD0", VA = "0x188618DD0")]
	[AsyncStateMachine(typeof(MDKLFJHNBHD))]
	public static Task LECHDFIDIED(HPFPDDDCBJJ OMDBDJDKPAE, PCKGILPFDIA FFEMKICJPKP, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015B")]
internal struct CFOMKCBMLMJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private struct KFLENMDOFKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public HPFPDDDCBJJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public PCKGILPFDIA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public HJPJMEMMBCG timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		private GMNLHEBCJHB <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private KHIJDEHFOJA <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private FMFKKILGACO <operationState>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private bool <isMaster>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private OGIJLBDGAHB <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private List<(PersistenceView, HDCAPCJGFLN)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private HDCAPCJGFLN <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x8623CD0", Offset = "0x8622AD0", VA = "0x188623CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x86249B0", Offset = "0x86237B0", VA = "0x1886249B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x8619110", Offset = "0x8617F10", VA = "0x188619110")]
	[AsyncStateMachine(typeof(KFLENMDOFKD))]
	public static Task LECHDFIDIED(HPFPDDDCBJJ OMDBDJDKPAE, PCKGILPFDIA FFEMKICJPKP, HJPJMEMMBCG HLENMICNOJN, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x8618F10", Offset = "0x8617D10", VA = "0x188618F10")]
	private static void DIIENPBJIIP(PersistenceView IOEIHBPMNDC, HDCAPCJGFLN KBPNMENODAC, PCKGILPFDIA FFEMKICJPKP, FMFKKILGACO FGCFMMMFHAA, bool HLHAANACKAD)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal struct PJGMANIKIAP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private struct NHFOCFFCPKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public GMNLHEBCJHB roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public PCKGILPFDIA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private OGIJLBDGAHB <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x86295B0", Offset = "0x86283B0", VA = "0x1886295B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x8629BD0", Offset = "0x86289D0", VA = "0x188629BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x862A920", Offset = "0x8629720", VA = "0x18862A920")]
	[AsyncStateMachine(typeof(NHFOCFFCPKM))]
	public static Task LECHDFIDIED(GMNLHEBCJHB PPAOCCCONKJ, PCKGILPFDIA FFEMKICJPKP, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
internal struct BEOENPAPKMM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private struct HEEDCKINBCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public GMNLHEBCJHB roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public PCKGILPFDIA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public HPFPDDDCBJJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x861D9A0", Offset = "0x861C7A0", VA = "0x18861D9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x861DBB0", Offset = "0x861C9B0", VA = "0x18861DBB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class LJCNGCGECDL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000163")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005DA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005DB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005DC")]
			public HBCKFDINPOH<string>.DLKHFLDLCIN timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005DD")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005DE")]
			public LJCNGCGECDL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005DF")]
			private HBCKFDINPOH<string>.DLKHFLDLCIN <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005E0")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0x862C640", Offset = "0x862B440", VA = "0x18862C640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0x862C9D0", Offset = "0x862B7D0", VA = "0x18862C9D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public LJCNGCGECDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x8626440", Offset = "0x8625240", VA = "0x188626440")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task JIHMAACALPG(HBCKFDINPOH<string>.DLKHFLDLCIN timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private struct OIEPMEAEJAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public BEOENPAPKMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		private OGIJLBDGAHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		private OGIJLBDGAHB <_>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		private TaskAwaiter<JCNIBNHHJJK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x8629CB0", Offset = "0x8628AB0", VA = "0x188629CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x862A8C0", Offset = "0x86296C0", VA = "0x18862A8C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private sealed class JFBDENBABOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public OBHJNBIABOM version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public JFBDENBABOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x86218B0", Offset = "0x86206B0", VA = "0x1886218B0")]
		internal object HHEJIJBGPMP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x8621800", Offset = "0x8620600", VA = "0x188621800")]
		internal object DPFJDFPMAGD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CB")]
	private GMNLHEBCJHB PPAOCCCONKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005CC")]
	private PCKGILPFDIA FFEMKICJPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005CD")]
	private HPFPDDDCBJJ OMDBDJDKPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	private bool FIIAPMBNGPG;

	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private static readonly ByteString ELILFJLCBBG;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private KHIJDEHFOJA NLOFNFPCHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x86176E0", Offset = "0x86164E0", VA = "0x1886176E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private HNJJDFCNNLG NGAOLAIDCMC
	{
		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x8617730", Offset = "0x8616530", VA = "0x188617730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x8618120", Offset = "0x8616F20", VA = "0x188618120")]
	[AsyncStateMachine(typeof(HEEDCKINBCD))]
	public static Task LECHDFIDIED(GMNLHEBCJHB PPAOCCCONKJ, PCKGILPFDIA FFEMKICJPKP, HPFPDDDCBJJ OMDBDJDKPAE, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM, bool FIIAPMBNGPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x8617FF0", Offset = "0x8616DF0", VA = "0x188617FF0")]
	[AsyncStateMachine(typeof(OIEPMEAEJAK))]
	private Task LECHDFIDIED(HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x86177D0", Offset = "0x86165D0", VA = "0x1886177D0")]
	private void JGADAFHFIMN([NotNull] IEHAENGDKAI POBCDALIHIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x8617FB0", Offset = "0x8616DB0", VA = "0x188617FB0")]
	private bool JIDLBMHFANC(OBHJNBIABOM MFIBIFPFGCD, IEHAENGDKAI POBCDALIHIP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
internal struct FAGLEAHJBFM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private struct BDJBKFGPBPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public AsyncTaskMethodBuilder<PCKGILPFDIA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public FAGLEAHJBFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public KPPIONNPJCL.FDCOECOEOKN downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		private OGIJLBDGAHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		private TaskAwaiter<IReadOnlyCollection<FDPEOBPEHPG>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		private TaskAwaiter<(JKEBLLKKBOM<KFPGMEKLIPK, DDPPOHMMKFK>, JKEBLLKKBOM<HBACGGNKINL<IEHAENGDKAI>, DDPPOHMMKFK>, JKEBLLKKBOM<HBACGGNKINL<MMIHAIKLLOA>, DDPPOHMMKFK>, JKEBLLKKBOM<HBACGGNKINL<IEnumerable<DBPOPHMEDLM>>, DDPPOHMMKFK>, JKEBLLKKBOM<HBACGGNKINL<PPPBEPLDMBL>, DDPPOHMMKFK>)> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x8616250", Offset = "0x8615050", VA = "0x188616250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x8617030", Offset = "0x8615E30", VA = "0x188617030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct HMHNJFAENGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<KFPGMEKLIPK, DDPPOHMMKFK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public FAGLEAHJBFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public IReadOnlyCollection<FDPEOBPEHPG> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public IReadOnlyCollection<FDPEOBPEHPG> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public KPPIONNPJCL.FDCOECOEOKN downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		private OGIJLBDGAHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		private TaskAwaiter<JKEBLLKKBOM<KFPGMEKLIPK, DDPPOHMMKFK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x861E550", Offset = "0x861D350", VA = "0x18861E550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x861EBB0", Offset = "0x861D9B0", VA = "0x18861EBB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005F0")]
	private CJDLDAABHBM<CKNMKLKMAFP, MMIHAIKLLOA> LMJPJKKOGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	private CJDLDAABHBM<CKNMKLKMAFP, IEHAENGDKAI> FIMJDOFOMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	private CJDLDAABHBM<JLKEEJPFIPN, IEnumerable<DBPOPHMEDLM>> PDBCIOGJJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	private CJDLDAABHBM<long, PPPBEPLDMBL> CANDBNOIMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	private JMIDENOHBFD LGIMKINJFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005F5")]
	private IEHEOOILKKD OBHLDKPHIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private HLKGJIPFKJP BMDHCHDHIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40005F7")]
	private Guid? DGIHKBKLLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005F8")]
	private IReadOnlyCollection<FDPEOBPEHPG> HCILPACHGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40005F9")]
	private Task<IReadOnlyCollection<FDPEOBPEHPG>> JDLAJKOINDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005FA")]
	private CKNMKLKMAFP JINFFCDMHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40005FB")]
	private CKNMKLKMAFP LINKDNKHHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40005FC")]
	private CKNMKLKMAFP? EHBDALNNCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40005FD")]
	private JLKEEJPFIPN GMECNDHBKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40005FE")]
	private HBCKFDINPOH<string>.DLKHFLDLCIN HMLAIBMJFEO;

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x8619FE0", Offset = "0x8618DE0", VA = "0x188619FE0")]
	public static Task<PCKGILPFDIA> LEACFCPJFKP(GMNLHEBCJHB PPAOCCCONKJ, [In] DDJDFAOFFLH FFEMKICJPKP, KPPIONNPJCL.FDCOECOEOKN NODBBLEALIC, HBCKFDINPOH<string>.DLKHFLDLCIN HMLAIBMJFEO, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x861A4E0", Offset = "0x86192E0", VA = "0x18861A4E0")]
	[AsyncStateMachine(typeof(BDJBKFGPBPL))]
	private Task<PCKGILPFDIA> LECHDFIDIED(KPPIONNPJCL.FDCOECOEOKN NODBBLEALIC, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x861A690", Offset = "0x8619490", VA = "0x18861A690")]
	[AsyncStateMachine(typeof(HMHNJFAENGM))]
	private Task<JKEBLLKKBOM<KFPGMEKLIPK, DDPPOHMMKFK>> MKJMBOKBFBG(Guid? DGIHKBKLLKL, IReadOnlyCollection<FDPEOBPEHPG> HCILPACHGBE, IReadOnlyCollection<FDPEOBPEHPG> NGHKOJHJAIA, long? CEACGIDOODJ, long? AIBOEBCNHLB, KPPIONNPJCL.FDCOECOEOKN NODBBLEALIC, HBCKFDINPOH<string>.DLKHFLDLCIN OMPFEMOLJIA, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
internal struct KFMJMLAKGJC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct AENGKEFFMBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public AsyncTaskMethodBuilder<DDJDFAOFFLH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public KFMJMLAKGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		private TaskAwaiter<DDJDFAOFFLH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x86133C0", Offset = "0x86121C0", VA = "0x1886133C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x8613810", Offset = "0x8612610", VA = "0x188613810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private struct KFDMFADHMMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public AsyncTaskMethodBuilder<DDJDFAOFFLH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public KFMJMLAKGJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		private TaskAwaiter<DDJDFAOFFLH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x86237E0", Offset = "0x86225E0", VA = "0x1886237E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x8623C60", Offset = "0x8622A60", VA = "0x188623C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private sealed class JLGHBOHJOFE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016D")]
		private struct <<FetchRoomLoadDetails>g__getRoomSaveData|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400063B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400063C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400063D")]
			public JLGHBOHJOFE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400063E")]
			private HBCKFDINPOH<string>.DLKHFLDLCIN <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400063F")]
			private TaskAwaiter<JILIMMDDMOA> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000640")]
			private TaskAwaiter<ENAHMCDKIIN> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0x862AA40", Offset = "0x8629840", VA = "0x18862AA40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061A")]
			[Cpp2IlInjected.Address(RVA = "0x862B400", Offset = "0x862A200", VA = "0x18862B400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public HKHLJMHFNLH roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public KHIJDEHFOJA callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public CKNMKLKMAFP superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public CKNMKLKMAFP subRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public IReadOnlyList<FDPEOBPEHPG> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public IReadOnlyList<FDPEOBPEHPG> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public IEHEOOILKKD roomDetails;

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public JLGHBOHJOFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0xE8E460", Offset = "0xE8D260", VA = "0x180E8E460")]
		internal bool ABPBIIIDGKK(HLKGJIPFKJP sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x8622DD0", Offset = "0x8621BD0", VA = "0x188622DD0")]
		[AsyncStateMachine(typeof(<<FetchRoomLoadDetails>g__getRoomSaveData|0>d))]
		internal Task GGLMFDDDDOL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x8622BD0", Offset = "0x86219D0", VA = "0x188622BD0")]
		internal Task<JLKEEJPFIPN> DGPOLMAALOO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private struct JJGDLHGHCJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public AsyncTaskMethodBuilder<DDJDFAOFFLH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public HKHLJMHFNLH roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public KHIJDEHFOJA callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public CKNMKLKMAFP superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private JLGHBOHJOFE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private HLKGJIPFKJP <subroom>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		private Task<JLKEEJPFIPN> <getRoomLoadDTOTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		private TaskAwaiter<IEHEOOILKKD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		private TaskAwaiter<JLKEEJPFIPN> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x8621A70", Offset = "0x8620870", VA = "0x188621A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x8622A20", Offset = "0x8621820", VA = "0x188622A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000616")]
	private KHIJDEHFOJA LKIBPKBGCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000617")]
	private HMCLAFELGLA NFPANFIHGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000618")]
	private HKHLJMHFNLH COHKMHPAMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000619")]
	private HBCKFDINPOH<string>.DLKHFLDLCIN HMLAIBMJFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400061A")]
	private long CEACGIDOODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400061B")]
	private long DPMNLDKPNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400061C")]
	private long JCHKNPOGNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400061D")]
	private string LOPKMJOKGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400061E")]
	private CKNMKLKMAFP POCPENBDDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400061F")]
	private Guid DDHPBDPNODD;

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x8624A10", Offset = "0x8623810", VA = "0x188624A10")]
	public static Task<DDJDFAOFFLH> LEACFCPJFKP(GMNLHEBCJHB PPAOCCCONKJ, EJLGFFHHDJD OHDJLNAKLPC, HBCKFDINPOH<string>.DLKHFLDLCIN HMLAIBMJFEO, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x8624C60", Offset = "0x8623A60", VA = "0x188624C60")]
	[AsyncStateMachine(typeof(AENGKEFFMBE))]
	private Task<DDJDFAOFFLH> LECHDFIDIED(CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x8624F80", Offset = "0x8623D80", VA = "0x188624F80")]
	[AsyncStateMachine(typeof(KFDMFADHMMD))]
	private Task<DDJDFAOFFLH> MOMPPDJKMPJ(HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x8624DB0", Offset = "0x8623BB0", VA = "0x188624DB0")]
	[AsyncStateMachine(typeof(JJGDLHGHCJL))]
	private static Task<DDJDFAOFFLH> MOMPPDJKMPJ(KHIJDEHFOJA LKIBPKBGCOO, HKHLJMHFNLH COHKMHPAMKN, long CEACGIDOODJ, long DPMNLDKPNGD, long JCHKNPOGNLH, string LOPKMJOKGEI, CKNMKLKMAFP POCPENBDDGF, Guid DDHPBDPNODD, CancellationToken GHKBKDKNIOM, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x86250F0", Offset = "0x8623EF0", VA = "0x1886250F0")]
	private void PDAOHMCKALH(IEHEOOILKKD OBHLDKPHIMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016F")]
internal struct BDNOAJLEOKF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct HLCKCMFGFND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public BDNOAJLEOKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x861DF60", Offset = "0x861CD60", VA = "0x18861DF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x861E4F0", Offset = "0x861D2F0", VA = "0x18861E4F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000654")]
	private KHIJDEHFOJA LKIBPKBGCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000655")]
	private PCKGILPFDIA FFEMKICJPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000656")]
	private HBCKFDINPOH<string>.DLKHFLDLCIN HMLAIBMJFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000657")]
	private float CJEFGICIICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000658")]
	private float HAEOILAEBIF;

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x86172C0", Offset = "0x86160C0", VA = "0x1886172C0")]
	public static Task EIEBKEDCELH(GMNLHEBCJHB PPAOCCCONKJ, PCKGILPFDIA FFEMKICJPKP, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x86175C0", Offset = "0x86163C0", VA = "0x1886175C0")]
	[AsyncStateMachine(typeof(HLCKCMFGFND))]
	public Task LECHDFIDIED(CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x8617460", Offset = "0x8616260", VA = "0x188617460")]
	private static void IGAAFLPHNKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x86170A0", Offset = "0x8615EA0", VA = "0x1886170A0")]
	private void ABJAMEJHIHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x8617200", Offset = "0x8616000", VA = "0x188617200")]
	private static float CKNPKGPKMNC(KHIJDEHFOJA LKIBPKBGCOO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x86175A0", Offset = "0x86163A0", VA = "0x1886175A0")]
	private static float IJBFFAEEGMO()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000172")]
internal struct BBHPLCNHDHK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private struct NFDNHGHHBBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public HPFPDDDCBJJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public PCKGILPFDIA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private OGIJLBDGAHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private OGJNGIMJFAN <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private GMNLHEBCJHB <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private DAMLBNEEAHP.CMJFJJHPABA <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		private TaskAwaiter<JCNIBNHHJJK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x8628D30", Offset = "0x8627B30", VA = "0x188628D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x8629550", Offset = "0x8628350", VA = "0x188629550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private struct JMEMBJDGIBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		private OGIJLBDGAHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x8622EA0", Offset = "0x8621CA0", VA = "0x188622EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x86231D0", Offset = "0x8621FD0", VA = "0x1886231D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x8615DC0", Offset = "0x8614BC0", VA = "0x188615DC0")]
	[AsyncStateMachine(typeof(NFDNHGHHBBF))]
	public static Task LECHDFIDIED(HPFPDDDCBJJ OMDBDJDKPAE, PCKGILPFDIA FFEMKICJPKP, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x8615D50", Offset = "0x8614B50", VA = "0x188615D50")]
	private static Task<JCNIBNHHJJK> GPMNNBDJAJJ(HPFPDDDCBJJ OMDBDJDKPAE, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x8615C90", Offset = "0x8614A90", VA = "0x188615C90")]
	[AsyncStateMachine(typeof(JMEMBJDGIBN))]
	private static Task BBKMCKONPHK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
internal struct CAHGAKBEJHG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private struct MLGGFCIKHBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public CAHGAKBEJHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x8626D80", Offset = "0x8625B80", VA = "0x188626D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x8627430", Offset = "0x8626230", VA = "0x188627430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private sealed class FMHJBFNMIBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public FMHJBFNMIBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x861AD30", Offset = "0x8619B30", VA = "0x18861AD30")]
		internal object FMFIDINAANP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct MOHNEGBJMOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public CAHGAKBEJHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		private OGIJLBDGAHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x8627490", Offset = "0x8626290", VA = "0x188627490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x8627910", Offset = "0x8626710", VA = "0x188627910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000673")]
	private bool CGCJNJOAPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	private HBCKFDINPOH<string>.DLKHFLDLCIN HMLAIBMJFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000675")]
	private GMNLHEBCJHB PPAOCCCONKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000676")]
	private CancellationToken GHKBKDKNIOM;

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x8618D60", Offset = "0x8617B60", VA = "0x188618D60")]
	public static Task PHCHALDJLNI(GMNLHEBCJHB PPAOCCCONKJ, bool CGCJNJOAPKI, HBCKFDINPOH<string>.DLKHFLDLCIN HMLAIBMJFEO, CancellationToken JCNCFHBCGLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x8618C70", Offset = "0x8617A70", VA = "0x188618C70")]
	[AsyncStateMachine(typeof(MLGGFCIKHBM))]
	private Task LECHDFIDIED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x8618B40", Offset = "0x8617940", VA = "0x188618B40")]
	[AsyncStateMachine(typeof(MOHNEGBJMOB))]
	private Task KCGBBMHLAFE(bool KMLMFPECCJP, string HNANIJLJDBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0")]
	private bool CCMDAAKEBPJ(bool CGCJNJOAPKI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
internal struct NCLLPPJMHEJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private struct AIBJBAKEONK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		public NCLLPPJMHEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x8613CE0", Offset = "0x8612AE0", VA = "0x188613CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x8614250", Offset = "0x8613050", VA = "0x188614250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private sealed class EICILLOIGAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public EICILLOIGAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x8619F90", Offset = "0x8618D90", VA = "0x188619F90")]
		internal object FMFIDINAANP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private struct BACFFLIOHCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public NCLLPPJMHEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		private OGIJLBDGAHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x8615790", Offset = "0x8614590", VA = "0x188615790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x8615C20", Offset = "0x8614A20", VA = "0x188615C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000686")]
	private FLOOBEEHKCN HIDHFKKOJBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000687")]
	private HBCKFDINPOH<string>.DLKHFLDLCIN HMLAIBMJFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000688")]
	private GMNLHEBCJHB PPAOCCCONKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000689")]
	private bool JOFPAOANCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400068A")]
	private PCKGILPFDIA FFEMKICJPKP;

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x8628CB0", Offset = "0x8627AB0", VA = "0x188628CB0")]
	public static Task<Scene> NBONKHCFADN(GMNLHEBCJHB PPAOCCCONKJ, FLOOBEEHKCN CIGLKBELFFM, HBCKFDINPOH<string>.DLKHFLDLCIN HMLAIBMJFEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x8628B90", Offset = "0x8627990", VA = "0x188628B90")]
	[AsyncStateMachine(typeof(AIBJBAKEONK))]
	private Task<Scene> LECHDFIDIED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x8628A10", Offset = "0x8627810", VA = "0x188628A10")]
	private bool FELBDCCJFGF(PCKGILPFDIA FFEMKICJPKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x86289A0", Offset = "0x86277A0", VA = "0x1886289A0")]
	private void FBJGOMCCDHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x8628A40", Offset = "0x8627840", VA = "0x188628A40")]
	[AsyncStateMachine(typeof(BACFFLIOHCG))]
	private Task<Scene> KCGBBMHLAFE(string HNANIJLJDBI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal struct LAOBEKBOAFC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private struct HBDGDEEOEKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		public AsyncTaskMethodBuilder<FMFKKILGACO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public LAOBEKBOAFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		public FMFKKILGACO nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public PCKGILPFDIA deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		private TaskAwaiter<FMFKKILGACO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x861C520", Offset = "0x861B320", VA = "0x18861C520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x861CFF0", Offset = "0x861BDF0", VA = "0x18861CFF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private struct FFCBPCABEEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public AsyncTaskMethodBuilder<FMFKKILGACO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public LAOBEKBOAFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public FMFKKILGACO state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		private TaskAwaiter<JCNIBNHHJJK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x861A9E0", Offset = "0x86197E0", VA = "0x18861A9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x861ACC0", Offset = "0x8619AC0", VA = "0x18861ACC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private readonly HPFPDDDCBJJ OMDBDJDKPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000698")]
	private readonly HMCLAFELGLA NFPANFIHGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000699")]
	private readonly ANPEONMLPAB GMOHCIIGBNE;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private OGJNGIMJFAN IDKGDPEDCHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x6A835A0", Offset = "0x6A823A0", VA = "0x186A835A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x8625CF0", Offset = "0x8624AF0", VA = "0x188625CF0")]
	public LAOBEKBOAFC(HPFPDDDCBJJ OMDBDJDKPAE, HMCLAFELGLA NFPANFIHGFH, ANPEONMLPAB GMOHCIIGBNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x8625B70", Offset = "0x8624970", VA = "0x188625B70")]
	[AsyncStateMachine(typeof(HBDGDEEOEKP))]
	public Task<FMFKKILGACO> PGPBOMEHPHG(FMFKKILGACO FOLADPBACIC, PCKGILPFDIA OIFHIOIKAIN, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM, bool ICFGEDOOFCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x86259C0", Offset = "0x86247C0", VA = "0x1886259C0")]
	[AsyncStateMachine(typeof(FFCBPCABEEM))]
	private Task<FMFKKILGACO> BAINGEOOEMA(HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, FMFKKILGACO JNOIIIFBOLM, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x8625B20", Offset = "0x8624920", VA = "0x188625B20")]
	private bool DHCOELKBKKC(FMFKKILGACO OIEFKDCOFAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x8625B50", Offset = "0x8624950", VA = "0x188625B50")]
	private void NDLHJECGFPL(string IDNIHMABKME)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal struct DIEANCIAFKD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct ILOHLBNHFEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public OGJNGIMJFAN operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public PCKGILPFDIA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public HJPJMEMMBCG timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		private OGIJLBDGAHB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		private List<(PersistenceView, HDCAPCJGFLN)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		private (PersistenceView, HDCAPCJGFLN) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x861FE50", Offset = "0x861EC50", VA = "0x18861FE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x8620520", Offset = "0x861F320", VA = "0x188620520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x8619CF0", Offset = "0x8618AF0", VA = "0x188619CF0")]
	[AsyncStateMachine(typeof(ILOHLBNHFEG))]
	public static Task LECHDFIDIED(OGJNGIMJFAN GGHOJGJBMPF, PCKGILPFDIA FFEMKICJPKP, HJPJMEMMBCG HLENMICNOJN, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000182")]
internal struct JJMDPNJECLI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private struct HDOPPGAKEFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		public OGJNGIMJFAN operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public PCKGILPFDIA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public HJPJMEMMBCG timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private OBHJNBIABOM <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		private OGIJLBDGAHB <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		private List<(PersistenceView, HDCAPCJGFLN)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		private HDCAPCJGFLN <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x861D060", Offset = "0x861BE60", VA = "0x18861D060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x861D940", Offset = "0x861C740", VA = "0x18861D940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x8622A90", Offset = "0x8621890", VA = "0x188622A90")]
	[AsyncStateMachine(typeof(HDOPPGAKEFH))]
	public static Task LECHDFIDIED(OGJNGIMJFAN GGHOJGJBMPF, PCKGILPFDIA FFEMKICJPKP, HJPJMEMMBCG HLENMICNOJN, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
public struct JDEOCDFKPLJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private struct LEICEMMMMLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<KFPGMEKLIPK, DDPPOHMMKFK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public JDEOCDFKPLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public KPPIONNPJCL.FDCOECOEOKN preloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		private OGIJLBDGAHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		private TaskAwaiter<JKEBLLKKBOM<KFPGMEKLIPK, DDPPOHMMKFK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x8625D50", Offset = "0x8624B50", VA = "0x188625D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x86263D0", Offset = "0x86251D0", VA = "0x1886263D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006C6")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006C7")]
	private long ACLALHMKNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006C8")]
	private long EODEBDPFIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	private Guid? PMIGJGDPOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	private IReadOnlyCollection<FDPEOBPEHPG> OKOKGNJHOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006CB")]
	private IReadOnlyCollection<FDPEOBPEHPG> DIIKHKFNNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006CC")]
	private JMIDENOHBFD JMEEDONOAOC;

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x8620580", Offset = "0x861F380", VA = "0x188620580")]
	public static Task<JKEBLLKKBOM<KFPGMEKLIPK, DDPPOHMMKFK>> LEACFCPJFKP(long CEACGIDOODJ, long DPMNLDKPNGD, ENAHMCDKIIN JJOANFOPKHL, KPPIONNPJCL.FDCOECOEOKN NCGLKLFPIGH, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x86206E0", Offset = "0x861F4E0", VA = "0x1886206E0")]
	[AsyncStateMachine(typeof(LEICEMMMMLA))]
	private Task<JKEBLLKKBOM<KFPGMEKLIPK, DDPPOHMMKFK>> LECHDFIDIED(KPPIONNPJCL.FDCOECOEOKN NCGLKLFPIGH, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
internal struct DAMLBNEEAHP
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	public struct CMJFJJHPABA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		public List<CMFLKMCPKHF> LKHMJELBKGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		public List<HDCAPCJGFLN> IPKACACCLII;

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0xAE6A40", Offset = "0xAE5840", VA = "0x180AE6A40")]
		public CMJFJJHPABA(List<CMFLKMCPKHF> LKHMJELBKGF, List<HDCAPCJGFLN> IPKACACCLII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private sealed class OANPPCFAIAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		public IEnumerable<CMFLKMCPKHF> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public OANPPCFAIAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x8629C30", Offset = "0x8628A30", VA = "0x188629C30")]
		internal object KHJFINJBGLG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006D4")]
	private GMNLHEBCJHB PPAOCCCONKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006D5")]
	private PCKGILPFDIA FFEMKICJPKP;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private KHIJDEHFOJA NLOFNFPCHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x8619260", Offset = "0x8618060", VA = "0x188619260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x8619510", Offset = "0x8618310", VA = "0x188619510")]
	public static CMJFJJHPABA LECHDFIDIED(GMNLHEBCJHB PPAOCCCONKJ, PCKGILPFDIA FFEMKICJPKP)
	{
		return default(CMJFJJHPABA);
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x86192B0", Offset = "0x86180B0", VA = "0x1886192B0")]
	private CMJFJJHPABA LECHDFIDIED()
	{
		return default(CMJFJJHPABA);
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x8619570", Offset = "0x8618370", VA = "0x188619570")]
	private CMJFJJHPABA LHOHIBJEIKG(IEHAENGDKAI POBCDALIHIP, OBHJNBIABOM NBEPHOLFLDJ)
	{
		return default(CMJFJJHPABA);
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x8619B20", Offset = "0x8618920", VA = "0x188619B20")]
	private bool OLIBFDOGECM(IEnumerable<CMFLKMCPKHF> LKHMJELBKGF)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000189")]
internal struct KEBIKBBLFBE
{
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private sealed class IFDBHCIMEPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		public DAMLBNEEAHP.CMJFJJHPABA instantiations;

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public IFDBHCIMEPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x861FDA0", Offset = "0x861EBA0", VA = "0x18861FDA0")]
		internal object JIHMAACALPG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private sealed class GFNHCOGKDMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public GFNHCOGKDMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x861BC10", Offset = "0x861AA10", VA = "0x18861BC10")]
		internal object NHOEJDEPBGJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x8623230", Offset = "0x8622030", VA = "0x188623230")]
	public static void LECHDFIDIED(OGJNGIMJFAN GGHOJGJBMPF, PCKGILPFDIA FFEMKICJPKP, DAMLBNEEAHP.CMJFJJHPABA OKHCMKKJNJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
internal class ANPEONMLPAB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private struct GDBEODCFAJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		public ANPEONMLPAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public FMFKKILGACO operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public PCKGILPFDIA deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x861B440", Offset = "0x861A240", VA = "0x18861B440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x861BBB0", Offset = "0x861A9B0", VA = "0x18861BBB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	private sealed class FHBOIDBHBGN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200018F")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006EA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006EB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006EC")]
			public FHBOIDBHBGN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006ED")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006EE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000679")]
			[Cpp2IlInjected.Address(RVA = "0x863C400", Offset = "0x863B200", VA = "0x18863C400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0x863C5A0", Offset = "0x863B3A0", VA = "0x18863C5A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public ANPEONMLPAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		public PCKGILPFDIA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public FHBOIDBHBGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x8630BA0", Offset = "0x862F9A0", VA = "0x188630BA0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task DILCIFJONBF(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[CompilerGenerated]
	private struct JPJFOMGKJHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		public ANPEONMLPAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		public PCKGILPFDIA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		private FHBOIDBHBGN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x8635620", Offset = "0x8634420", VA = "0x188635620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x8635B50", Offset = "0x8634950", VA = "0x188635B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[CompilerGenerated]
	private struct OADNKGIOJFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public ANPEONMLPAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		public PCKGILPFDIA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		private Dictionary<Guid, List<PADAGBJFPOI>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x863A280", Offset = "0x8639080", VA = "0x18863A280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x863A890", Offset = "0x8639690", VA = "0x18863A890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private struct IGPDJJHBAEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		public ANPEONMLPAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public PCKGILPFDIA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		private Dictionary<Guid, List<PADAGBJFPOI>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x8633230", Offset = "0x8632030", VA = "0x188633230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x86338C0", Offset = "0x86326C0", VA = "0x1886338C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private sealed class LEFBBILJKEG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000194")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400070E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400070F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000710")]
			public PADAGBJFPOI handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000711")]
			public LEFBBILJKEG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000712")]
			private OGIJLBDGAHB <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000713")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x863BF30", Offset = "0x863AD30", VA = "0x18863BF30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000686")]
			[Cpp2IlInjected.Address(RVA = "0x863C3A0", Offset = "0x863B1A0", VA = "0x18863C3A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		public CCKELKMINBH runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		public List<PADAGBJFPOI> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		public PCKGILPFDIA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public LEFBBILJKEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x8638A40", Offset = "0x8637840", VA = "0x188638A40")]
		internal object IPODJLFHOMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x8638940", Offset = "0x8637740", VA = "0x188638940")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task DHCIBMLHCJB(PADAGBJFPOI handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x8638B30", Offset = "0x8637930", VA = "0x188638B30")]
		internal object PAMAONEDIJJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private struct LBCGMLLIDBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		public CCKELKMINBH runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		public List<PADAGBJFPOI> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		public PCKGILPFDIA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		private LEFBBILJKEG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x86371E0", Offset = "0x8635FE0", VA = "0x1886371E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x86376B0", Offset = "0x86364B0", VA = "0x1886376B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private struct AHGDMLFIGNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		public ANPEONMLPAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		public PCKGILPFDIA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000724")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x862CE80", Offset = "0x862BC80", VA = "0x18862CE80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x862D170", Offset = "0x862BF70", VA = "0x18862D170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private sealed class EGEPLNJHAIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public EGEPLNJHAIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x862F840", Offset = "0x862E640", VA = "0x18862F840")]
		internal object BIGKEGANMME()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private struct INGBHLDDNLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		public ANPEONMLPAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		public PCKGILPFDIA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		private OGIJLBDGAHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x8633FF0", Offset = "0x8632DF0", VA = "0x188633FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x86344A0", Offset = "0x86332A0", VA = "0x1886344A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private sealed class LLJMMEFKKJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public LLJMMEFKKJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x8638C20", Offset = "0x8637A20", VA = "0x188638C20")]
		internal object CMBHGIGGMNK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private struct NDIPMIEMODJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		public ANPEONMLPAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000738")]
		private OGIJLBDGAHB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		private TaskAwaiter<JCNIBNHHJJK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x8639390", Offset = "0x8638190", VA = "0x188639390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x86399C0", Offset = "0x86387C0", VA = "0x1886399C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[CompilerGenerated]
	private sealed class POFJPHMKNHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public POFJPHMKNHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x863BEC0", Offset = "0x863ACC0", VA = "0x18863BEC0")]
		internal object HLELLPFHFFF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	private readonly HPFPDDDCBJJ OMDBDJDKPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	private DADICJBEDAM GMOHCIIGBNE;

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private OGJNGIMJFAN IDKGDPEDCHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x116D810", Offset = "0x116C610", VA = "0x18116D810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
	public ANPEONMLPAB(HPFPDDDCBJJ OMDBDJDKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x8615200", Offset = "0x8614000", VA = "0x188615200")]
	[AsyncStateMachine(typeof(GDBEODCFAJI))]
	public Task LECHDFIDIED(FMFKKILGACO FGCFMMMFHAA, PCKGILPFDIA OIFHIOIKAIN, HBCKFDINPOH<string>.DLKHFLDLCIN HMLAIBMJFEO, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x8614BB0", Offset = "0x86139B0", VA = "0x188614BB0")]
	[AsyncStateMachine(typeof(JPJFOMGKJHM))]
	private Task EFMHBBLDLGL(PCKGILPFDIA FFEMKICJPKP, HBCKFDINPOH<string>.DLKHFLDLCIN HMLAIBMJFEO, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x8614CF0", Offset = "0x8613AF0", VA = "0x188614CF0")]
	[AsyncStateMachine(typeof(OADNKGIOJFG))]
	private Task FFMPGDDAKJM(PCKGILPFDIA FFEMKICJPKP, HBCKFDINPOH<string>.DLKHFLDLCIN HMLAIBMJFEO, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x8615530", Offset = "0x8614330", VA = "0x188615530")]
	[AsyncStateMachine(typeof(IGPDJJHBAEM))]
	private Task MGPKCEGJEPH(PCKGILPFDIA FFEMKICJPKP, HBCKFDINPOH<string>.DLKHFLDLCIN HMLAIBMJFEO, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x8614E30", Offset = "0x8613C30", VA = "0x188614E30")]
	[AsyncStateMachine(typeof(LBCGMLLIDBC))]
	private Task FKILIGAAPDN(Guid IFEPHGDANJD, List<PADAGBJFPOI> NGOMHHFGLHO, CCKELKMINBH ACODCJEHKEO, PCKGILPFDIA FFEMKICJPKP, CancellationToken JLFLGDNCANL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x8614F80", Offset = "0x8613D80", VA = "0x188614F80")]
	[AsyncStateMachine(typeof(AHGDMLFIGNO))]
	private Task KDKEJEFKPND(PCKGILPFDIA FFEMKICJPKP, HBCKFDINPOH<string>.DLKHFLDLCIN HMLAIBMJFEO, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x8614A70", Offset = "0x8613870", VA = "0x188614A70")]
	[AsyncStateMachine(typeof(INGBHLDDNLC))]
	private Task DMIEONNPGPE(Guid EKPFJKHKIOC, PCKGILPFDIA FFEMKICJPKP, HBCKFDINPOH<string>.DLKHFLDLCIN HMLAIBMJFEO, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x86150C0", Offset = "0x8613EC0", VA = "0x1886150C0")]
	[AsyncStateMachine(typeof(NDIPMIEMODJ))]
	private Task KNMKEGOMDNJ(Guid EKPFJKHKIOC, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x8615670", Offset = "0x8614470", VA = "0x188615670")]
	private void PFLGBNENHPP(Guid EKPFJKHKIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x86149C0", Offset = "0x86137C0", VA = "0x1886149C0")]
	private void DAMKIHJNFMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x8614850", Offset = "0x8613650", VA = "0x188614850")]
	public Guid AEDAJCPMNPA(FMFKKILGACO FNHHHKHKPEK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x8615350", Offset = "0x8614150", VA = "0x188615350")]
	[CompilerGenerated]
	private object LLBPBBKPJIE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
internal struct EFGNEHHNFKO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[CompilerGenerated]
	private struct CGKELFLMAIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		public EFGNEHHNFKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		private IEnumerator<HEDKMGEOMGG> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x862EE60", Offset = "0x862DC60", VA = "0x18862EE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x862F500", Offset = "0x862E300", VA = "0x18862F500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400073C")]
	private KHIJDEHFOJA LKIBPKBGCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400073D")]
	private HBCKFDINPOH<string>.DLKHFLDLCIN HMLAIBMJFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400073E")]
	private CancellationToken GHKBKDKNIOM;

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x862F690", Offset = "0x862E490", VA = "0x18862F690")]
	public static Task BHGPACKEGCN(KHIJDEHFOJA LKIBPKBGCOO, HBCKFDINPOH<string>.DLKHFLDLCIN HMLAIBMJFEO, CancellationToken JCNCFHBCGLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x862F700", Offset = "0x862E500", VA = "0x18862F700")]
	[AsyncStateMachine(typeof(CGKELFLMAIC))]
	private Task LECHDFIDIED()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
public readonly struct BBDLPBCCOHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000745")]
	public readonly bool JEIEHMLHPNC;

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x2A25C90", Offset = "0x2A24A90", VA = "0x182A25C90")]
	public BBDLPBCCOHO(bool AJHDHLMBNMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
public readonly struct ABCJCMNNNGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000746")]
	public readonly IEHAENGDKAI? IPDCFMAIDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000747")]
	public readonly BOGEAFJJIPM BBKKMAAMLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000748")]
	public readonly Guid? JHILAODNCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000749")]
	public readonly IReadOnlyList<Guid> JIMLDJKNLIA;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public IReadOnlyCollection<string> PNNIOANOGBN
	{
		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x862CD60", Offset = "0x862BB60", VA = "0x18862CD60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public IReadOnlyDictionary<long, int> NHMEOOMLAJA
	{
		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x862CD40", Offset = "0x862BB40", VA = "0x18862CD40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x862CD80", Offset = "0x862BB80", VA = "0x18862CD80")]
	public ABCJCMNNNGP(IEHAENGDKAI? MLFFBNNKHKH, BOGEAFJJIPM KOKAFFHIPNB, Guid? DGIHKBKLLKL, [Optional] IReadOnlyList<Guid>? CBFFHPMPNDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
internal class LBNDPDAGLKC : HOBKGGNFPFC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A2")]
	[CompilerGenerated]
	private struct EHEEKGJEEGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		public AsyncTaskMethodBuilder<ABCJCMNNNGP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000751")]
		public LBNDPDAGLKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		public IDJDAJKALCK serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		public IBOBFJDJKHF roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		private PersistenceView[] <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000757")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		private OGIJLBDGAHB <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000759")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x862F8B0", Offset = "0x862E6B0", VA = "0x18862F8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x862FF50", Offset = "0x862ED50", VA = "0x18862FF50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	[CompilerGenerated]
	private sealed class NABGBKFJBKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400075A")]
		public float time;

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public NABGBKFJBKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x86391D0", Offset = "0x8637FD0", VA = "0x1886391D0")]
		internal object AECGOMABACD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[CompilerGenerated]
	private struct FMDGJEPLDHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400075B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400075C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400075D")]
		public LBNDPDAGLKC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400075E")]
		public PersistenceView[] activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000760")]
		public IDJDAJKALCK serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		private NABGBKFJBKA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		private OGIJLBDGAHB <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		private CancellationTokenSource <cts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		private HIMKNIEIOHE<Task> <tasks>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x8630E30", Offset = "0x862FC30", VA = "0x188630E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x8631900", Offset = "0x8630700", VA = "0x188631900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400074A")]
	private readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x400074B")]
	private static readonly TimeSpan ELLHODJJBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400074C")]
	private readonly MBJAAEFODEG LLPCLHGKMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400074D")]
	private readonly OLGEOLKHILK IDLHNBGNFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400074E")]
	private readonly CEMGLJFPJKA FDAJNHDPGPK;

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x86388D0", Offset = "0x86376D0", VA = "0x1886388D0")]
	public LBNDPDAGLKC(HPFPDDDCBJJ OMDBDJDKPAE, MBJAAEFODEG LLPCLHGKMPD, OLGEOLKHILK NBKBEGAJDII, CEMGLJFPJKA FDAJNHDPGPK, IEBEPMGFCGH NHLEILEPJMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x8638710", Offset = "0x8637510", VA = "0x188638710")]
	[AsyncStateMachine(typeof(EHEEKGJEEGI))]
	public Task<ABCJCMNNNGP> KIDMEGDOMCG(long DPMNLDKPNGD, IBOBFJDJKHF KIADMCLAHNB, IDJDAJKALCK JLPAALCHFHL, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x8637FC0", Offset = "0x8636DC0", VA = "0x188637FC0")]
	[AsyncStateMachine(typeof(FMDGJEPLDHD))]
	private Task IMIFKNKDDJG(IDJDAJKALCK JLPAALCHFHL, PersistenceView[] PIONDFDBMMC, StringBuilder HCHAIPACDLJ, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x8638100", Offset = "0x8636F00", VA = "0x188638100")]
	private ABCJCMNNNGP JEEIAMFDDAO(long DPMNLDKPNGD, IBOBFJDJKHF KIADMCLAHNB, IDJDAJKALCK JLPAALCHFHL, IEnumerable<PersistenceView> PIONDFDBMMC, StringBuilder HCHAIPACDLJ)
	{
		return default(ABCJCMNNNGP);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x8637960", Offset = "0x8636760", VA = "0x188637960")]
	private IEHAENGDKAI CNACDCMBDKE(long DPMNLDKPNGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x8637710", Offset = "0x8636510", VA = "0x188637710")]
	private void ALCAOAFABJB(IEHAENGDKAI JHOJNDIIPGJ, StringBuilder HCHAIPACDLJ, IEnumerable<PersistenceView> PIONDFDBMMC, [In] LIMDEMJFMGD CMDFAJDAGCE, HHCHLLLJFNE EAHKNEDDMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x8637B20", Offset = "0x8636920", VA = "0x188637B20")]
	private void EDPJJEBEPMP(IEHAENGDKAI JHOJNDIIPGJ, StringBuilder HCHAIPACDLJ, PersistenceView IOEIHBPMNDC, HHCHLLLJFNE EAHKNEDDMEF, [In] LIMDEMJFMGD CMDFAJDAGCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A6")]
internal class GEGMBPNFPKG : HOBKGGNFPFC
{
	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[CompilerGenerated]
	private sealed class EFNGPONCHJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		public DNDMPIPNEEC.KDGPAGGMFHO roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public EFNGPONCHJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x862F7F0", Offset = "0x862E5F0", VA = "0x18862F7F0")]
		internal object OEODOPMPDLF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[CompilerGenerated]
	private struct OHMHOLOELCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		public AsyncTaskMethodBuilder<(DNDMPIPNEEC.KDGPAGGMFHO roomDataUpload, DNDMPIPNEEC.KDGPAGGMFHO subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		public ABCJCMNNNGP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400076F")]
		public KHIJDEHFOJA callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		private EFNGPONCHJB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		private TaskAwaiter<DNDMPIPNEEC.KDGPAGGMFHO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x863A8F0", Offset = "0x86396F0", VA = "0x18863A8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x863B170", Offset = "0x8639F70", VA = "0x18863B170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	[CompilerGenerated]
	private struct HBGCOGPGNDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		public AsyncTaskMethodBuilder<HIFJOJHPHLI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		public GEGMBPNFPKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000779")]
		public KKDADIJBPAI roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400077A")]
		public ABCJCMNNNGP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400077B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400077C")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400077D")]
		private TaskAwaiter<HIFJOJHPHLI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x8632560", Offset = "0x8631360", VA = "0x188632560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x8632800", Offset = "0x8631600", VA = "0x188632800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[CompilerGenerated]
	private struct IHPNDGHINKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400077E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		public AsyncTaskMethodBuilder<HIFJOJHPHLI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		public KHIJDEHFOJA callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		public ABCJCMNNNGP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		public BOFEJEGFDGL ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		public KKDADIJBPAI roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		private TaskAwaiter<(DNDMPIPNEEC.KDGPAGGMFHO roomDataUpload, DNDMPIPNEEC.KDGPAGGMFHO subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000788")]
		private TaskAwaiter<HIFJOJHPHLI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x8633920", Offset = "0x8632720", VA = "0x188633920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x8633F80", Offset = "0x8632D80", VA = "0x188633F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[CompilerGenerated]
	private struct NJIBCEJHMEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000789")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400078A")]
		public AsyncTaskMethodBuilder<JILIMMDDMOA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400078B")]
		public GEGMBPNFPKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400078C")]
		public ABCJCMNNNGP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400078D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		private TaskAwaiter<(DNDMPIPNEEC.KDGPAGGMFHO roomDataUpload, DNDMPIPNEEC.KDGPAGGMFHO subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		private TaskAwaiter<JILIMMDDMOA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x8639D50", Offset = "0x8638B50", VA = "0x188639D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x863A210", Offset = "0x8639010", VA = "0x18863A210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[CompilerGenerated]
	private sealed class ECKIIGDOOPK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001AD")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400079B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400079C")]
			public AsyncTaskMethodBuilder<JCNIBNHHJJK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400079D")]
			public ECKIIGDOOPK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400079E")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400079F")]
			private JCNIBNHHJJK <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007A0")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007A1")]
			private TaskAwaiter<JILIMMDDMOA> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007A2")]
			private TaskAwaiter<HIFJOJHPHLI> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007A3")]
			private TaskAwaiter<JCNIBNHHJJK> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006C7")]
			[Cpp2IlInjected.Address(RVA = "0x863C600", Offset = "0x863B400", VA = "0x18863C600", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C8")]
			[Cpp2IlInjected.Address(RVA = "0x863D810", Offset = "0x863C610", VA = "0x18863D810", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		public GEGMBPNFPKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		public ABCJCMNNNGP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		public KKDADIJBPAI roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		public BBDLPBCCOHO roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400079A")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public ECKIIGDOOPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x862F560", Offset = "0x862E360", VA = "0x18862F560")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<JCNIBNHHJJK> GANIHOCGGMB(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AE")]
	[CompilerGenerated]
	private struct OPKKCCDAAIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007A5")]
		public AsyncTaskMethodBuilder<JCNIBNHHJJK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007A6")]
		public GEGMBPNFPKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007A7")]
		public ABCJCMNNNGP roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007A8")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007AB")]
		public KKDADIJBPAI roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007AC")]
		public BBDLPBCCOHO roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007AD")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007AF")]
		private TaskAwaiter<JCNIBNHHJJK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x863B1E0", Offset = "0x8639FE0", VA = "0x18863B1E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x863B510", Offset = "0x863A310", VA = "0x18863B510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000768")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x4000769")]
	private static readonly IEBEPMGFCGH NHNGPLMPMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400076A")]
	private readonly DIPENBPMFLI NAJEIHPDHAB;

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private GMNLHEBCJHB OGPJPILGJBC
	{
		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x85FF040", Offset = "0x85FDE40", VA = "0x1885FF040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0x86324D0", Offset = "0x86312D0", VA = "0x1886324D0")]
	public GEGMBPNFPKG(HPFPDDDCBJJ OMDBDJDKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0x8631960", Offset = "0x8630760", VA = "0x188631960")]
	[AsyncStateMachine(typeof(OHMHOLOELCJ))]
	private static Task<(DNDMPIPNEEC.KDGPAGGMFHO, DNDMPIPNEEC.KDGPAGGMFHO)> AGFMBLHELJN(KHIJDEHFOJA LKIBPKBGCOO, ABCJCMNNNGP EPCLCPLDMJG, long CEACGIDOODJ, long AIBOEBCNHLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0x8632110", Offset = "0x8630F10", VA = "0x188632110")]
	[AsyncStateMachine(typeof(HBGCOGPGNDM))]
	public Task<HIFJOJHPHLI> HMFHOALLIKH(int JFFMBFCFHJI, [CanBeNull] KKDADIJBPAI LANGIPGHPFC, ABCJCMNNNGP EPCLCPLDMJG, long CEACGIDOODJ, long AIBOEBCNHLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0x8631DC0", Offset = "0x8630BC0", VA = "0x188631DC0")]
	public static Task<HIFJOJHPHLI> HMFHOALLIKH(KHIJDEHFOJA LKIBPKBGCOO, int JFFMBFCFHJI, [CanBeNull] KKDADIJBPAI LANGIPGHPFC, ABCJCMNNNGP EPCLCPLDMJG, long CEACGIDOODJ, long AIBOEBCNHLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x8631C30", Offset = "0x8630A30", VA = "0x188631C30")]
	[AsyncStateMachine(typeof(IHPNDGHINKE))]
	public static Task<HIFJOJHPHLI> HMFHOALLIKH(KHIJDEHFOJA LKIBPKBGCOO, int JFFMBFCFHJI, [CanBeNull] KKDADIJBPAI LANGIPGHPFC, ABCJCMNNNGP EPCLCPLDMJG, long CEACGIDOODJ, long AIBOEBCNHLB, BOFEJEGFDGL DPGFPPJJIEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x8631AB0", Offset = "0x86308B0", VA = "0x188631AB0")]
	[AsyncStateMachine(typeof(NJIBCEJHMEJ))]
	private Task<JILIMMDDMOA> GHCINHNEHMG(string LOPKMJOKGEI, int JFFMBFCFHJI, ABCJCMNNNGP EPCLCPLDMJG, long CEACGIDOODJ, long AIBOEBCNHLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x8632280", Offset = "0x8631080", VA = "0x188632280")]
	[AsyncStateMachine(typeof(OPKKCCDAAIJ))]
	public Task<JCNIBNHHJJK> IJFFPKMCNNA(int JFFMBFCFHJI, KKDADIJBPAI? LANGIPGHPFC, ABCJCMNNNGP EPCLCPLDMJG, long CEACGIDOODJ, long AIBOEBCNHLB, BBDLPBCCOHO IFFCOIOHFKP, HBCKFDINPOH<string>.DLKHFLDLCIN OMKAOIIFEEI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
public abstract class PFBFGADNPAF<T> where T : PFBFGADNPAF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007B0")]
	internal readonly GMNLHEBCJHB BCLNFFFPCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007B1")]
	private int? ODEENNIBBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007B2")]
	protected readonly Guid KAKAFMGMHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007B3")]
	protected readonly OHMAAOBKPPJ ALLKGKGIHCB;

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	protected T NACKPFFEJED
	{
		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x5775320", Offset = "0x5774120", VA = "0x185775320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x5775630", Offset = "0x5774430", VA = "0x185775630")]
	internal PFBFGADNPAF(GMNLHEBCJHB EEACEJHHMAK, OHMAAOBKPPJ ECJGLDHJAKL, [Optional] Guid? LGNCELEMLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x5775420", Offset = "0x5774220", VA = "0x185775420")]
	private JCNIBNHHJJK HIAPKNKJOHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	protected virtual void CAGPCHIKIMC(JCNIBNHHJJK NJJDPBHNDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x5775280", Offset = "0x5774080", VA = "0x185775280")]
	public T AIAMDFHEDMF(AHNIMKBJLEJ ALDGPAKLOOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x5775380", Offset = "0x5774180", VA = "0x185775380")]
	public T FPKDHGJKPAA(int KCDAJOFMAFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x5775500", Offset = "0x5774300", VA = "0x185775500", Slot = "5")]
	public virtual Task<NPEBMFOKKKC> KHOHFCMNPOH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public class FMCIILJJKCO : PFBFGADNPAF<FMCIILJJKCO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007B4")]
	private EJLGFFHHDJD DKEBGKJJPPO;

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x8630D60", Offset = "0x862FB60", VA = "0x188630D60")]
	internal FMCIILJJKCO(GMNLHEBCJHB EEACEJHHMAK, OHMAAOBKPPJ ECJGLDHJAKL, [Optional] Guid? LGNCELEMLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x78668B0", Offset = "0x78656B0", VA = "0x1878668B0")]
	public FMCIILJJKCO BGOFMEOALIP(EJLGFFHHDJD DKEBGKJJPPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x8630C90", Offset = "0x862FA90", VA = "0x188630C90", Slot = "4")]
	protected override void CAGPCHIKIMC(JCNIBNHHJJK NJJDPBHNDPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
public class HLCOPCGLHDG : PFBFGADNPAF<HLCOPCGLHDG>
{
	[Cpp2IlInjected.Token(Token = "0x20001B2")]
	internal enum MOIOHJAJCLF
	{
		[Cpp2IlInjected.Token(Token = "0x40007B9")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40007BA")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40007BB")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B3")]
	[CompilerGenerated]
	private struct JFOCFGHEDME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007BD")]
		public AsyncTaskMethodBuilder<NPEBMFOKKKC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		public HLCOPCGLHDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007C0")]
		private TaskAwaiter<NPEBMFOKKKC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x8635200", Offset = "0x8634000", VA = "0x188635200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x86355B0", Offset = "0x86343B0", VA = "0x1886355B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007B5")]
	private MOIOHJAJCLF KEBKLBEFIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40007B6")]
	private string LNNDMGHOECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40007B7")]
	private KKDADIJBPAI DKEBGKJJPPO;

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x8632BB0", Offset = "0x86319B0", VA = "0x188632BB0")]
	internal HLCOPCGLHDG(GMNLHEBCJHB EEACEJHHMAK, OHMAAOBKPPJ ECJGLDHJAKL, [Optional] Guid? LGNCELEMLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(RVA = "0x8632B80", Offset = "0x8631980", VA = "0x188632B80")]
	public HLCOPCGLHDG OEOAEPPKGLF(string CDDMBEEGKND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(RVA = "0x8632B60", Offset = "0x8631960", VA = "0x188632B60")]
	public HLCOPCGLHDG NBCLJGBLIIA(bool LGKNHMNMGCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(RVA = "0x8632B40", Offset = "0x8631940", VA = "0x188632B40")]
	public HLCOPCGLHDG MKBHNBOJPHG(bool LNEDIINAILA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x8632A20", Offset = "0x8631820", VA = "0x188632A20")]
	public HLCOPCGLHDG GDJKDNPPKDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x8632870", Offset = "0x8631670", VA = "0x188632870", Slot = "4")]
	protected override void CAGPCHIKIMC(JCNIBNHHJJK NJJDPBHNDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x8632A50", Offset = "0x8631850", VA = "0x188632A50", Slot = "5")]
	[AsyncStateMachine(typeof(JFOCFGHEDME))]
	public override Task<NPEBMFOKKKC> KHOHFCMNPOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x86329E0", Offset = "0x86317E0", VA = "0x1886329E0")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<NPEBMFOKKKC> CFPBBJIBMML()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B4")]
internal static class JAKFELPGDEH
{
	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x8634580", Offset = "0x8633380", VA = "0x188634580")]
	public static void KBMCNCKALPA(this PAONFCHNCDI IPOHHDPALFE, DAFHNINMJHP LCHHHCLEHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x8634500", Offset = "0x8633300", VA = "0x188634500")]
	public static void CAPGDLKKGPM(this DAFHNINMJHP GLJABNGDFFO, [Optional] string NJJDPBHNDPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B5")]
public static class NCILPHCBHKL
{
	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(RVA = "0x8639240", Offset = "0x8638040", VA = "0x188639240")]
	public static CKNMKLKMAFP JIKCBEACKEC(this HEHHKGHCADP JDOOFLNELFN)
	{
		return default(CKNMKLKMAFP);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0x86392E0", Offset = "0x86380E0", VA = "0x1886392E0")]
	public static HEHHKGHCADP KJILCEBCEHK(this CKNMKLKMAFP AKFDFPKDONL)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x20001B6")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20001B7")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007C4")]
			public KJPEKFGEGLI ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007C5")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007C6")]
			public KJPEKFGEGLI HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007C7")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007C8")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007C9")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60006E9")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007C1")]
		private static KJPEKFGEGLI[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007C2")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007C3")]
		private Dictionary<KJPEKFGEGLI, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x863DE30", Offset = "0x863CC30", VA = "0x18863DE30")]
		public bool HBJHBKGJGLJ(KJPEKFGEGLI COPGBILICEN, [Out] ResultConfig EKMDFFAGMPN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x863DEA0", Offset = "0x863CCA0", VA = "0x18863DEA0")]
		public ResultConfig LIHKJGOOPAD(KJPEKFGEGLI KLOPBEMIGAO, [Optional] HashSet<KJPEKFGEGLI> JOELCLLBKFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x863E5B0", Offset = "0x863D3B0", VA = "0x18863E5B0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x863DFE0", Offset = "0x863CDE0", VA = "0x18863DFE0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0xBD1A10", Offset = "0xBD0810", VA = "0x180BD1A10")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B9")]
public class PMMEEPFJMDP : PMOBBKDCDFN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001BA")]
	[CompilerGenerated]
	private struct ALJGAOAEOML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D3")]
		public PMMEEPFJMDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007D4")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x862D1D0", Offset = "0x862BFD0", VA = "0x18862D1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x862D460", Offset = "0x862C260", VA = "0x18862D460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001BB")]
	[CompilerGenerated]
	private struct IGLADOEBKCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007D8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D9")]
		public HBCKFDINPOH<string>.DLKHFLDLCIN timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007DA")]
		public PMOBBKDCDFN preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007DB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007DC")]
		private HBCKFDINPOH<string>.DLKHFLDLCIN <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007DD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x8632D20", Offset = "0x8631B20", VA = "0x188632D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x86331D0", Offset = "0x8631FD0", VA = "0x1886331D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007CF")]
	private readonly ILPCKMBDCCL DCDLFGKLFBO;

	[Cpp2IlInjected.Token(Token = "0x40007D0")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public string DBGKBFOAAFL
	{
		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x863BBF0", Offset = "0x863A9F0", VA = "0x18863BBF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x863BB80", Offset = "0x863A980", VA = "0x18863BB80")]
	[ENKLKENGHAE.AANPNKKBMFF.ENPJKGAFAPD]
	internal static void CLCHOCNLOKB(NAELDDAANND DICMPHOPMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
	[RecRoom.NoEngine.Common.Preserve]
	public PMMEEPFJMDP([LCNEJNNIOGA(null)] ILPCKMBDCCL DCDLFGKLFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x863BD40", Offset = "0x863AB40", VA = "0x18863BD40", Slot = "5")]
	[AsyncStateMachine(typeof(ALJGAOAEOML))]
	public Task LECHDFIDIED(HBCKFDINPOH<string>.DLKHFLDLCIN FFINBNFCEEC, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x863BC20", Offset = "0x863AA20", VA = "0x18863BC20")]
	[AsyncStateMachine(typeof(IGLADOEBKCL))]
	private Task GJMJONADJHK(PMOBBKDCDFN AFLKOENIBGN, HBCKFDINPOH<string>.DLKHFLDLCIN FFINBNFCEEC, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BC")]
public interface ILPCKMBDCCL : PMOBBKDCDFN
{
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
public interface PMOBBKDCDFN
{
	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	string DBGKBFOAAFL
	{
		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LECHDFIDIED(HBCKFDINPOH<string>.DLKHFLDLCIN FFINBNFCEEC, CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
public static class BLEAAAFAEHD
{
	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x862E1C0", Offset = "0x862CFC0", VA = "0x18862E1C0")]
	[ENKLKENGHAE.AANPNKKBMFF.ENPJKGAFAPD]
	internal static void KPJOAGLHFJF(NAELDDAANND DICMPHOPMLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BF")]
public interface ONKMAFKLDAF : IEquatable<ONKMAFKLDAF>
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	DateTime EJCNNJGBFFB
	{
		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKCCBJCCMAH();

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NNEPNMIEKOF(long CEACGIDOODJ, long DPMNLDKPNGD, [Out] ABCJCMNNNGP EPCLCPLDMJG);
}
[Cpp2IlInjected.Token(Token = "0x20001C0")]
internal class EJMHAEILJBM : PANKIDIEDAK
{
	[Cpp2IlInjected.Token(Token = "0x20001C1")]
	[CompilerGenerated]
	private sealed class JBKOPNLJKPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007E0")]
		public ILAAIKBOLJH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007E1")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public JBKOPNLJKPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x8635190", Offset = "0x8633F90", VA = "0x188635190")]
		internal object HADNGFIJAAN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007DE")]
	private readonly HIONAHAKLPO KFIFDPEMBPD;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<ONKMAFKLDAF> NFOBLMGHMAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x8630A40", Offset = "0x862F840", VA = "0x188630A40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x8630AF0", Offset = "0x862F8F0", VA = "0x188630AF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
	[UnityEngine.Scripting.Preserve]
	public EJMHAEILJBM([LCNEJNNIOGA(null)] HIONAHAKLPO KFIFDPEMBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x8630070", Offset = "0x862EE70", VA = "0x188630070", Slot = "6")]
	public bool GBFNDMPIEAC(long CEACGIDOODJ, long DPMNLDKPNGD, ABCJCMNNNGP EPCLCPLDMJG, ILAAIKBOLJH DGLHGHKAGGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0xDD99C0", Offset = "0xDD87C0", VA = "0x180DD99C0")]
	private void HFFPGPFEJOO(ONKMAFKLDAF MKJDENHNJAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x86307A0", Offset = "0x862F5A0", VA = "0x1886307A0", Slot = "7")]
	public bool JACANJAAKHK(long CEACGIDOODJ, long DPMNLDKPNGD, [Out] ONKMAFKLDAF GCOKBAEPGNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x862FFC0", Offset = "0x862EDC0", VA = "0x18862FFC0", Slot = "8")]
	public bool AEMHAEHBPEM(long CEACGIDOODJ, long DPMNLDKPNGD, ILAAIKBOLJH DGLHGHKAGGH, [Out] ONKMAFKLDAF GCOKBAEPGNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x8630370", Offset = "0x862F170", VA = "0x188630370")]
	private void GFLOHNEHIGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x8630910", Offset = "0x862F710", VA = "0x188630910", Slot = "9")]
	public void JANDEIEOMNE(long CEACGIDOODJ, long DPMNLDKPNGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C3")]
internal abstract class JBKAMMACKKJ : HIONAHAKLPO
{
	[Cpp2IlInjected.Token(Token = "0x20001C4")]
	protected enum HAPOAEJALGK : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	[CompilerGenerated]
	private sealed class NGOIDBAFHOA : IEnumerable<ONKMAFKLDAF>, IEnumerable, IEnumerator<ONKMAFKLDAF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007E8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007E9")]
		private ONKMAFKLDAF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007EA")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007EB")]
		public JBKAMMACKKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007EC")]
		private ILAAIKBOLJH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40007ED")]
		public ILAAIKBOLJH <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007EE")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007EF")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		private ONKMAFKLDAF System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0xED60C0", Offset = "0xED4EC0", VA = "0x180ED60C0")]
		[DebuggerHidden]
		public NGOIDBAFHOA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x8639A20", Offset = "0x8638820", VA = "0x188639A20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x8639D00", Offset = "0x8638B00", VA = "0x188639D00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x8639C50", Offset = "0x8638A50", VA = "0x188639C50", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ONKMAFKLDAF> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x8639C50", Offset = "0x8638A50", VA = "0x188639C50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	[CompilerGenerated]
	private sealed class ANEMMHOHDDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F0")]
		public ILAAIKBOLJH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007F1")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public ANEMMHOHDDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x862D4C0", Offset = "0x862C2C0", VA = "0x18862D4C0")]
		internal object DEIENBJIBMM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C7")]
	[CompilerGenerated]
	private sealed class MNJEJJBELGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F2")]
		public JBKAMMACKKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007F3")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public MNJEJJBELGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x8639150", Offset = "0x8637F50", VA = "0x188639150")]
		internal void CAICCOBKEHL(GCJBIPFKLNC.LNAGCMEPPKJ ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007E4")]
	private readonly object BKJOMOGFCDM;

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	protected string LNKBIDEMIDP
	{
		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x8635100", Offset = "0x8633F00", VA = "0x188635100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public abstract CPOPOKDGKDF MKOPBIHCBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x8635110", Offset = "0x8633F10", VA = "0x188635110")]
	protected JBKAMMACKKJ([CanBeNull] string DAOHLFAGKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x86346D0", Offset = "0x86334D0", VA = "0x1886346D0", Slot = "5")]
	public bool DBAFGGLEAJO(long CEACGIDOODJ, long DPMNLDKPNGD, ILAAIKBOLJH DGLHGHKAGGH, [Out] ONKMAFKLDAF MKJDENHNJAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0x86348C0", Offset = "0x86336C0", VA = "0x1886348C0", Slot = "6")]
	[IteratorStateMachine(typeof(NGOIDBAFHOA))]
	public IEnumerable<ONKMAFKLDAF> FGOLOCCCPGL(ILAAIKBOLJH DGLHGHKAGGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void JCICAGEMLOB(Stream AIKCBNEFNLE, long CEACGIDOODJ, long DPMNLDKPNGD, ABCJCMNNNGP EPCLCPLDMJG);

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool AMHCCPICHPO(Stream HCIIKAOGIAL, long CEACGIDOODJ, long DPMNLDKPNGD, DHBELLPIHHF CMGBCBCKILE, [Out] ABCJCMNNNGP EPCLCPLDMJG);

	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0x8634D80", Offset = "0x8633B80", VA = "0x188634D80", Slot = "7")]
	public ONKMAFKLDAF MOGAPIJDDFB(long CEACGIDOODJ, long DPMNLDKPNGD, ABCJCMNNNGP EPCLCPLDMJG, ILAAIKBOLJH DGLHGHKAGGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo LGNJLKDJIIM(long CEACGIDOODJ, long DPMNLDKPNGD, ILAAIKBOLJH DGLHGHKAGGH, HAPOAEJALGK BEPKCBPBPND);

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo BEHMIHMDCBE(ILAAIKBOLJH DGLHGHKAGGH, HAPOAEJALGK BEPKCBPBPND);

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x8634D10", Offset = "0x8633B10", VA = "0x188634D10")]
	protected void LMDLICDMLAL(GCJBIPFKLNC.LNAGCMEPPKJ LIAPPGMCCJC, string IDNIHMABKME, FileInfo MFOCKNPHPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x8634950", Offset = "0x8633750", VA = "0x188634950")]
	internal bool LJGHIHEGPAN(FileInfo LPBNAMOIKBL, long CEACGIDOODJ, long DPMNLDKPNGD, [Out] ABCJCMNNNGP EPCLCPLDMJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	private void NLHBBPLJLJL(Exception BKLHGCIIDBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C8")]
internal class APLNJIEHFAD : JBKAMMACKKJ
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public override CPOPOKDGKDF MKOPBIHCBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x128F8E0", Offset = "0x128E6E0", VA = "0x18128F8E0", Slot = "8")]
		get
		{
			return default(CPOPOKDGKDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x862E180", Offset = "0x862CF80", VA = "0x18862E180")]
	public APLNJIEHFAD([Optional] string DAOHLFAGKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x862DD60", Offset = "0x862CB60", VA = "0x18862DD60")]
	private void GAHIDEBAKMK(ILAAIKBOLJH DGLHGHKAGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x862DDE0", Offset = "0x862CBE0", VA = "0x18862DDE0", Slot = "9")]
	internal override void JCICAGEMLOB(Stream AIKCBNEFNLE, long CEACGIDOODJ, long DPMNLDKPNGD, ABCJCMNNNGP EPCLCPLDMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x862D560", Offset = "0x862C360", VA = "0x18862D560", Slot = "10")]
	internal override bool AMHCCPICHPO(Stream HCIIKAOGIAL, long CEACGIDOODJ, long DPMNLDKPNGD, DHBELLPIHHF CMGBCBCKILE, [Out] ABCJCMNNNGP EPCLCPLDMJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x862E090", Offset = "0x862CE90", VA = "0x18862E090", Slot = "11")]
	protected override FileInfo LGNJLKDJIIM(long CEACGIDOODJ, long DPMNLDKPNGD, ILAAIKBOLJH DGLHGHKAGGH, HAPOAEJALGK BEPKCBPBPND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x862DC60", Offset = "0x862CA60", VA = "0x18862DC60", Slot = "12")]
	protected override DirectoryInfo BEHMIHMDCBE(ILAAIKBOLJH DGLHGHKAGGH, HAPOAEJALGK BEPKCBPBPND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C9")]
internal sealed class KPIFDIIIFIG : JBKAMMACKKJ
{
	[Cpp2IlInjected.Token(Token = "0x40007F4")]
	private static readonly byte[] MAKJJJECHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007F5")]
	private readonly byte[] BCCIDLGNEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40007F6")]
	private readonly byte[] KKCBEHKIBNP;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public override CPOPOKDGKDF MKOPBIHCBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x1801260", Offset = "0x1800060", VA = "0x181801260", Slot = "8")]
		get
		{
			return default(CPOPOKDGKDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x86370F0", Offset = "0x8635EF0", VA = "0x1886370F0")]
	public KPIFDIIIFIG([Optional] string DAOHLFAGKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x8636A50", Offset = "0x8635850", VA = "0x188636A50", Slot = "9")]
	internal override void JCICAGEMLOB(Stream AIKCBNEFNLE, long CEACGIDOODJ, long DPMNLDKPNGD, ABCJCMNNNGP EPCLCPLDMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x8635ED0", Offset = "0x8634CD0", VA = "0x188635ED0", Slot = "10")]
	internal override bool AMHCCPICHPO(Stream HCIIKAOGIAL, long CEACGIDOODJ, long DPMNLDKPNGD, DHBELLPIHHF CMGBCBCKILE, [Out] ABCJCMNNNGP EPCLCPLDMJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x8636E70", Offset = "0x8635C70", VA = "0x188636E70")]
	private void KACLMKANOHP(byte[] HNAKMABCJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x8636F30", Offset = "0x8635D30", VA = "0x188636F30", Slot = "11")]
	protected override FileInfo LGNJLKDJIIM(long CEACGIDOODJ, long DPMNLDKPNGD, ILAAIKBOLJH DGLHGHKAGGH, HAPOAEJALGK BEPKCBPBPND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x8636940", Offset = "0x8635740", VA = "0x188636940", Slot = "12")]
	protected override DirectoryInfo BEHMIHMDCBE(ILAAIKBOLJH DGLHGHKAGGH, HAPOAEJALGK BEPKCBPBPND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CB")]
public enum CPOPOKDGKDF : byte
{
	[Cpp2IlInjected.Token(Token = "0x40007FA")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40007FB")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40007FC")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001CC")]
internal class BNOMGMMDLPF : HIONAHAKLPO
{
	[Cpp2IlInjected.Token(Token = "0x20001CE")]
	[CompilerGenerated]
	private sealed class MFNEGDPPLIO : IEnumerable<ONKMAFKLDAF>, IEnumerable, IEnumerator<ONKMAFKLDAF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000803")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000804")]
		private ONKMAFKLDAF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000805")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000806")]
		public BNOMGMMDLPF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000807")]
		private ILAAIKBOLJH autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000808")]
		public ILAAIKBOLJH <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000809")]
		private CPOPOKDGKDF[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400080A")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400080B")]
		private IEnumerator<ONKMAFKLDAF> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		private ONKMAFKLDAF System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000748")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600074A")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0xED60C0", Offset = "0xED4EC0", VA = "0x180ED60C0")]
		[DebuggerHidden]
		public MFNEGDPPLIO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x86390C0", Offset = "0x8637EC0", VA = "0x1886390C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x8638C90", Offset = "0x8637A90", VA = "0x188638C90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x8638F70", Offset = "0x8637D70", VA = "0x188638F70")]
		private void PPMJPANAFBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x8639070", Offset = "0x8637E70", VA = "0x188639070", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x8638FC0", Offset = "0x8637DC0", VA = "0x188638FC0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ONKMAFKLDAF> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x8638FC0", Offset = "0x8637DC0", VA = "0x188638FC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007FD")]
	private readonly CPOPOKDGKDF[] KPLAGMHJNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007FE")]
	private readonly Dictionary<CPOPOKDGKDF, HIONAHAKLPO> MPDOIDBNAPB;

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public CPOPOKDGKDF MKOPBIHCBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x862E9F0", Offset = "0x862D7F0", VA = "0x18862E9F0", Slot = "4")]
		get
		{
			return default(CPOPOKDGKDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x862EB10", Offset = "0x862D910", VA = "0x18862EB10")]
	[UnityEngine.Scripting.Preserve]
	public BNOMGMMDLPF(params HIONAHAKLPO[] PBMGNHODLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x862E5D0", Offset = "0x862D3D0", VA = "0x18862E5D0", Slot = "5")]
	public bool DBAFGGLEAJO(long CEACGIDOODJ, long DPMNLDKPNGD, ILAAIKBOLJH DGLHGHKAGGH, [Out] ONKMAFKLDAF MKJDENHNJAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x862E720", Offset = "0x862D520", VA = "0x18862E720")]
	private void DPMPLLAJDLB(int HLHMMBKKCCK, long CEACGIDOODJ, long DPMNLDKPNGD, ILAAIKBOLJH DGLHGHKAGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x862E960", Offset = "0x862D760", VA = "0x18862E960", Slot = "6")]
	[IteratorStateMachine(typeof(MFNEGDPPLIO))]
	public IEnumerable<ONKMAFKLDAF> FGOLOCCCPGL(ILAAIKBOLJH DGLHGHKAGGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x862EA20", Offset = "0x862D820", VA = "0x18862EA20", Slot = "7")]
	public ONKMAFKLDAF MOGAPIJDDFB(long CEACGIDOODJ, long DPMNLDKPNGD, ABCJCMNNNGP EPCLCPLDMJG, ILAAIKBOLJH DGLHGHKAGGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CF")]
internal static class KLABMBMHIDN
{
	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x8635C30", Offset = "0x8634A30", VA = "0x188635C30")]
	internal static byte[] NLOMABFIOIP(byte[] HNAKMABCJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x8635BB0", Offset = "0x86349B0", VA = "0x188635BB0")]
	public static void FHCEDBAILBD(Stream GGIFBJCPEKA, byte[] JJJNJLEIPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074F")]
	[Cpp2IlInjected.Address(RVA = "0x8635CF0", Offset = "0x8634AF0", VA = "0x188635CF0")]
	public static bool PAGCNLMMLLP(Stream GGIFBJCPEKA, long OOOOFGNENBJ, DHBELLPIHHF JBOPHDMFKKJ, [Out] byte[] NJFJGGLCJIN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
internal sealed class PIHJDNBJCKK : ONKMAFKLDAF, IEquatable<ONKMAFKLDAF>, IEquatable<PIHJDNBJCKK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400080C")]
	private readonly JBKAMMACKKJ CNIGAMJLICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400080D")]
	public readonly FileInfo PDMOPPOEPLD;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public CPOPOKDGKDF MKOPBIHCBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x7EEED90", Offset = "0x7EEDB90", VA = "0x187EEED90", Slot = "9")]
		get
		{
			return default(CPOPOKDGKDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public DateTime EJCNNJGBFFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x863B8F0", Offset = "0x863A6F0", VA = "0x18863B8F0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000752")]
	[Cpp2IlInjected.Address(RVA = "0x863BA70", Offset = "0x863A870", VA = "0x18863BA70")]
	public PIHJDNBJCKK(JBKAMMACKKJ GPKKIPIMFEM, FileInfo LPBNAMOIKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(RVA = "0x863B9C0", Offset = "0x863A7C0", VA = "0x18863B9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(RVA = "0x863B7A0", Offset = "0x863A5A0", VA = "0x18863B7A0", Slot = "5")]
	public void FKCCBJCCMAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(RVA = "0x863B980", Offset = "0x863A780", VA = "0x18863B980", Slot = "6")]
	public bool NNEPNMIEKOF(long CEACGIDOODJ, long DPMNLDKPNGD, [Out] ABCJCMNNNGP EPCLCPLDMJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x863B730", Offset = "0x863A530", VA = "0x18863B730", Slot = "7")]
	public bool Equals(ONKMAFKLDAF HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000757")]
	[Cpp2IlInjected.Address(RVA = "0x863B580", Offset = "0x863A380", VA = "0x18863B580", Slot = "8")]
	public bool Equals(PIHJDNBJCKK HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000758")]
	[Cpp2IlInjected.Address(RVA = "0x863B640", Offset = "0x863A440", VA = "0x18863B640", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000759")]
	[Cpp2IlInjected.Address(RVA = "0x863B860", Offset = "0x863A660", VA = "0x18863B860", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D1")]
public delegate void DHBELLPIHHF(GCJBIPFKLNC.LNAGCMEPPKJ LABHDEEOFOF, string NJJDPBHNDPA);
[Cpp2IlInjected.Token(Token = "0x20001D2")]
internal interface HIONAHAKLPO
{
	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	CPOPOKDGKDF MKOPBIHCBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600075D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DBAFGGLEAJO(long CEACGIDOODJ, long DPMNLDKPNGD, ILAAIKBOLJH DGLHGHKAGGH, [Out] ONKMAFKLDAF MKJDENHNJAB);

	[Cpp2IlInjected.Token(Token = "0x600075E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<ONKMAFKLDAF> FGOLOCCCPGL(ILAAIKBOLJH DGLHGHKAGGH);

	[Cpp2IlInjected.Token(Token = "0x600075F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ONKMAFKLDAF MOGAPIJDDFB(long CEACGIDOODJ, long DPMNLDKPNGD, ABCJCMNNNGP EPCLCPLDMJG, ILAAIKBOLJH DGLHGHKAGGH);
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
